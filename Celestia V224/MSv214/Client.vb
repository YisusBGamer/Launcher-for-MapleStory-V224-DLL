Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Namespace MSv214
	' Token: 0x0200000D RID: 13
	Public Class Client
		' Token: 0x17000027 RID: 39
		' (get) Token: 0x06000089 RID: 137 RVA: 0x00005FE1 File Offset: 0x000041E1
		' (set) Token: 0x0600008A RID: 138 RVA: 0x00005FE9 File Offset: 0x000041E9
		Private Property connected As Boolean

		' Token: 0x0600008B RID: 139 RVA: 0x00005FF4 File Offset: 0x000041F4
		Public Function Connect() As Boolean
			Dim s As String = If(Configs.localLogin, Configs.LocalIP, Configs.ServerIP)
			Try
				Dim ipaddress As IPAddress = IPAddress.Parse(Encoding.UTF8.GetString(Convert.FromBase64String(s)))
				Dim ipendPoint As IPEndPoint = New IPEndPoint(ipaddress, Configs.APIServerPort)
				Me.socket = New Socket(ipaddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
				Me.socket.BeginConnect(ipendPoint, AddressOf Me.ConnectCallback, Me.socket)
				Dim flag As Boolean = Client.connectDone.WaitOne(TimeSpan.FromSeconds(10.0))
				If flag Then
					Me.StartHeartbeat()
					Me.connected = True
					Return flag
				End If
			Catch ex As Exception
				Console.WriteLine(ex.ToString())
			End Try
			Me.socket.Close()
			Return False
		End Function

		' Token: 0x0600008C RID: 140 RVA: 0x000060C4 File Offset: 0x000042C4
		Private Sub ConnectCallback(ar As IAsyncResult)
			Try
				Dim socket As Socket = CType(ar.AsyncState, Socket)
				socket.EndConnect(ar)
				Console.WriteLine("Socket connected to {0}", socket.RemoteEndPoint.ToString())
				Client.connectDone.[Set]()
			Catch ex As Exception
				Console.WriteLine(ex.ToString())
			End Try
		End Sub

		' Token: 0x0600008D RID: 141 RVA: 0x00006124 File Offset: 0x00004324
		Public Sub Send(outPacket As OutPacket)
			Dim len As Integer = outPacket.len
			Dim array As Byte() = New Byte() { 0, 0, 0, CByte(len) }
			array(2) = CByte((len >> 8))
			array(1) = CByte((len >> 16))
			array(0) = CByte((len >> 24))
			Dim array2 As Byte() = New Byte(4 + len - 1) {}
			For i As Integer = 0 To array.Length - 1
				array2(i) = array(i)
			Next
			For j As Integer = array.Length To len + 4 - 1
				array2(j) = outPacket.buf(j - 4)
			Next
			Me.socket.BeginSend(array2, 0, array2.Length, SocketFlags.None, AddressOf Me.SendCallback, Me.socket)
			Client.sendDone.WaitOne(TimeSpan.FromSeconds(10.0))
		End Sub

		' Token: 0x0600008E RID: 142 RVA: 0x000061D8 File Offset: 0x000043D8
		Private Sub SendCallback(ar As IAsyncResult)
			Try
				Console.WriteLine("Sent {0} bytes to server.", CType(ar.AsyncState, Socket).EndSend(ar))
				Client.sendDone.[Set]()
			Catch ex As Exception
				Console.WriteLine(ex.ToString())
			End Try
		End Sub

		' Token: 0x0600008F RID: 143 RVA: 0x00006230 File Offset: 0x00004430
		Public Function Receive() As InPacket
			Try
				Dim inPacket As InPacket = New InPacket()
				Me.socket.BeginReceive(inPacket.buf, 0, 256, SocketFlags.None, AddressOf Me.ReceiveCallback, inPacket)
				While inPacket.len = -1
					Client.receiveDone.WaitOne(TimeSpan.FromSeconds(10.0))
				End While
				Return inPacket
			Catch ex As Exception
				Console.WriteLine(ex.ToString())
			End Try
			Return Nothing
		End Function

		' Token: 0x06000090 RID: 144 RVA: 0x000062B0 File Offset: 0x000044B0
		Private Sub ReceiveCallback(ar As IAsyncResult)
			Try
				Dim inPacket As InPacket = CType(ar.AsyncState, InPacket)
				Dim num As Integer = Me.socket.EndReceive(ar)
				If inPacket.len = -1 Then
					If num + inPacket.lenBufPtr >= 4 Then
						For i As Integer = 0 To 4 - inPacket.lenBufPtr - 1
							inPacket.lenBuf(i - inPacket.lenBufPtr) = inPacket.buf(i)
						Next
						inPacket.len = CInt(inPacket.buf(3)) + (CInt(inPacket.buf(2)) << 8) + (CInt(inPacket.buf(1)) << 16) + (CInt(inPacket.buf(0)) << 24)
					Else
						For j As Integer = 0 To num - 1
							inPacket.lenBuf(j + inPacket.lenBufPtr) = inPacket.buf(j)
						Next
						inPacket.lenBufPtr += num
					End If
				End If
				If num > 0 Then
					For k As Integer = 0 To num - 1
						inPacket.bufData(k + inPacket.curLen) = inPacket.buf(k)
					Next
					inPacket.curLen += num
					If inPacket.curLen < inPacket.len Then
						Me.socket.BeginReceive(inPacket.buf, 0, 256, SocketFlags.None, AddressOf Me.ReceiveCallback, inPacket)
					Else
						Client.receiveDone.[Set]()
					End If
				Else
					Client.receiveDone.[Set]()
				End If
			Catch ex As Exception
				Console.WriteLine(ex.ToString())
			End Try
		End Sub

		' Token: 0x06000091 RID: 145 RVA: 0x00006430 File Offset: 0x00004630
		Private Sub StartHeartbeat()
			Me.heartbeatTimer = AddressOf Me.SendHeartbeat
		End Sub

		' Token: 0x06000092 RID: 146 RVA: 0x00006458 File Offset: 0x00004658
		Private Sub SendHeartbeat(state As Object)
			Dim flag As Boolean = False
			Dim heartbeat As String = "1"
			If Me.connected AndAlso Me.socket IsNot Nothing AndAlso Me.socket.Connected Then
				Try
					Me.Send(OutPackets.HeartbeatRequest(heartbeat))
					Dim inPacket As InPacket = Me.Receive()
					inPacket.readInt()
					inPacket.readShort()
					If inPacket.readByte() = 1 Then
						flag = True
					End If
					GoTo IL_79
				Catch ex As Exception
					Me.connected = False
					Me.StopHeartbeat()
					Me.socket.Close()
					GoTo IL_79
				End Try
			End If
			Me.connected = False
			Me.StopHeartbeat()
			IL_79:
			If Not flag Then
				Me.connected = False
				Me.StopHeartbeat()
				Me.socket.Close()
			End If
		End Sub

		' Token: 0x06000093 RID: 147 RVA: 0x0000650C File Offset: 0x0000470C
		Private Sub StopHeartbeat()
			If Me.heartbeatTimer IsNot Nothing Then
				Me.heartbeatTimer.Dispose()
				Me.heartbeatTimer = Nothing
			End If
		End Sub

		' Token: 0x06000094 RID: 148 RVA: 0x00006528 File Offset: 0x00004728
		Public Function IsConnected() As Boolean
			Return Me.connected
		End Function

		' Token: 0x0400005B RID: 91
		Private Shared connectDone As ManualResetEvent = New ManualResetEvent(False)

		' Token: 0x0400005C RID: 92
		Private Shared sendDone As ManualResetEvent = New ManualResetEvent(False)

		' Token: 0x0400005D RID: 93
		Private Shared receiveDone As ManualResetEvent = New ManualResetEvent(False)

		' Token: 0x0400005E RID: 94
		Private heartbeatTimer As Timer

		' Token: 0x04000060 RID: 96
		Private Shared heartbeatInterval As Integer = 5

		' Token: 0x04000061 RID: 97
		Public socket As Socket
	End Class
End Namespace
