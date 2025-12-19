Imports System
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks

Namespace MSv214
	' Token: 0x0200000E RID: 14
	Friend Class Handlers
		' Token: 0x06000097 RID: 151 RVA: 0x00006564 File Offset: 0x00004764
		Public Shared Function getAuthTokenFromInput(inPacket As InPacket) As String
			inPacket.readInt()
			inPacket.readShort()
			Dim flag As Boolean = inPacket.readByte() <> 0
			Dim text As String = ""
			If Not flag Then
				text = inPacket.readString()
				Console.WriteLine(text)
			End If
			Return text
		End Function

		' Token: 0x06000098 RID: 152 RVA: 0x0000659C File Offset: 0x0000479C
		Public Shared Function SendAccountCreateRequest(username As String, password As String, email As String, mac As String, client As Client) As Task(Of Byte)
			Dim <SendAccountCreateRequest>d__ As Handlers.<SendAccountCreateRequest>d__1
			<SendAccountCreateRequest>d__.<>t__builder = AsyncTaskMethodBuilder(Of Byte).Create()
			<SendAccountCreateRequest>d__.username = username
			<SendAccountCreateRequest>d__.password = password
			<SendAccountCreateRequest>d__.email = email
			<SendAccountCreateRequest>d__.mac = mac
			<SendAccountCreateRequest>d__.client = client
			<SendAccountCreateRequest>d__.<>1__state = -1
			<SendAccountCreateRequest>d__.<>t__builder.Start(Of Handlers.<SendAccountCreateRequest>d__1)(<SendAccountCreateRequest>d__)
			Return <SendAccountCreateRequest>d__.<>t__builder.Task
		End Function
	End Class
End Namespace
