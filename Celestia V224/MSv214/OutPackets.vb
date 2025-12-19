Imports System

Namespace MSv214
	' Token: 0x02000011 RID: 17
	Friend Class OutPackets
		' Token: 0x060000A6 RID: 166 RVA: 0x00006844 File Offset: 0x00004A44
		Public Shared Function AuthRequest(username As String, pwd As String) As OutPacket
			Dim outPacket As OutPacket = New OutPacket(CShort(OutPackets.AuthRequestPacket))
			outPacket.WriteString(username)
			outPacket.WriteString(pwd)
			Return outPacket
		End Function

		' Token: 0x060000A7 RID: 167 RVA: 0x0000685F File Offset: 0x00004A5F
		Public Shared Function CreateAccountRequest(username As String, pwd As String, email As String, mac As String) As OutPacket
			Dim outPacket As OutPacket = New OutPacket(CShort(OutPackets.CreateAccountPacket))
			outPacket.WriteString(username)
			outPacket.WriteString(pwd)
			outPacket.WriteString(email)
			outPacket.WriteString(mac)
			Return outPacket
		End Function

		' Token: 0x060000A8 RID: 168 RVA: 0x00006888 File Offset: 0x00004A88
		Public Shared Function FileChecksum(filename As String, checksum As String) As OutPacket
			Dim outPacket As OutPacket = New OutPacket(CShort(OutPackets.FileChecksumPacket))
			outPacket.WriteString(filename)
			outPacket.WriteString(checksum)
			Return outPacket
		End Function

		' Token: 0x060000A9 RID: 169 RVA: 0x000068A3 File Offset: 0x00004AA3
		Public Shared Function HeartbeatRequest(heartbeat As String) As OutPacket
			Dim outPacket As OutPacket = New OutPacket(CShort(OutPackets.HeartbeatRequestPacket))
			outPacket.WriteString(heartbeat)
			Return outPacket
		End Function

		' Token: 0x0400006C RID: 108
		Private Shared AuthRequestPacket As Integer = 10000

		' Token: 0x0400006D RID: 109
		Private Shared CreateAccountPacket As Integer = 10001

		' Token: 0x0400006E RID: 110
		Private Shared FileChecksumPacket As Integer = 10002

		' Token: 0x0400006F RID: 111
		Private Shared HeartbeatRequestPacket As Integer = 11000
	End Class
End Namespace
