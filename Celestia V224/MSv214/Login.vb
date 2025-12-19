Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace MSv214
	' Token: 0x0200000B RID: 11
	Friend Class Login
		' Token: 0x17000022 RID: 34
		' (get) Token: 0x0600006D RID: 109 RVA: 0x00005BE2 File Offset: 0x00003DE2
		' (set) Token: 0x0600006E RID: 110 RVA: 0x00005BEA File Offset: 0x00003DEA
		Public Property CClient As Client

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x0600006F RID: 111 RVA: 0x00005BF3 File Offset: 0x00003DF3
		' (set) Token: 0x06000070 RID: 112 RVA: 0x00005BFB File Offset: 0x00003DFB
		Public Property User As String

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x06000071 RID: 113 RVA: 0x00005C04 File Offset: 0x00003E04
		' (set) Token: 0x06000072 RID: 114 RVA: 0x00005C0C File Offset: 0x00003E0C
		Public Property Pass As String

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x06000073 RID: 115 RVA: 0x00005C15 File Offset: 0x00003E15
		' (set) Token: 0x06000074 RID: 116 RVA: 0x00005C1D File Offset: 0x00003E1D
		Public Property Token As String

		' Token: 0x17000026 RID: 38
		' (get) Token: 0x06000075 RID: 117 RVA: 0x00005C26 File Offset: 0x00003E26
		' (set) Token: 0x06000076 RID: 118 RVA: 0x00005C2E File Offset: 0x00003E2E
		Public Property Auth As Boolean

		' Token: 0x06000077 RID: 119 RVA: 0x00005C37 File Offset: 0x00003E37
		Public Sub New()
		End Sub

		' Token: 0x06000078 RID: 120 RVA: 0x00005C3F File Offset: 0x00003E3F
		Public Sub New(user As String, pass As String)
			Me.User = user
			Me.Pass = pass
			Me.Token = Nothing
			Me.Auth = False
			Me.CClient = Nothing
		End Sub

		' Token: 0x06000079 RID: 121
		Private Declare Function CreateProcess Lib "kernel32.dll" (lpApplicationName As String, lpCommandLine As String, lpProcessAttributes As IntPtr, lpThreadAttributes As IntPtr, bInheritHandles As Boolean, dwCreationFlags As UInteger, lpEnvironment As IntPtr, lpCurrentDirectory As String, ByRef lpStartupInfo As Login.STARTUPINFO, <System.Runtime.InteropServices.OutAttribute()> ByRef lpProcessInformation As Login.PROCESS_INFORMATION) As Boolean

		' Token: 0x0600007A RID: 122
		Private Declare Function ResumeThread Lib "kernel32.dll" (hThread As IntPtr) As UInteger

		' Token: 0x0600007B RID: 123
		Private Declare Function OpenProcess Lib "kernel32.dll" (dwDesiredAccess As UInteger, bInheritHandle As Integer, dwProcessId As UInteger) As IntPtr

		' Token: 0x0600007C RID: 124
		Private Declare Function CloseHandle Lib "kernel32.dll" (hObject As IntPtr) As Integer

		' Token: 0x0600007D RID: 125
		Private Declare Function GetProcAddress Lib "kernel32.dll" (hModule As IntPtr, lpProcName As String) As IntPtr

		' Token: 0x0600007E RID: 126
		Private Declare Function GetModuleHandle Lib "kernel32.dll" (lpModuleName As String) As IntPtr

		' Token: 0x0600007F RID: 127
		Private Declare Function VirtualAllocEx Lib "kernel32.dll" (hProcess As IntPtr, lpAddress As IntPtr, dwSize As IntPtr, flAllocationType As UInteger, flProtect As UInteger) As IntPtr

		' Token: 0x06000080 RID: 128
		Private Declare Function WriteProcessMemory Lib "kernel32.dll" (hProcess As IntPtr, lpBaseAddress As IntPtr, buffer As Byte(), size As UInteger, lpNumberOfBytesWritten As Integer) As Integer

		' Token: 0x06000081 RID: 129
		Private Declare Function CreateRemoteThread Lib "kernel32.dll" (hProcess As IntPtr, lpThreadAttribute As IntPtr, dwStackSize As IntPtr, lpStartAddress As IntPtr, lpParameter As IntPtr, dwCreationFlags As UInteger, lpThreadId As IntPtr) As IntPtr

		' Token: 0x06000082 RID: 130 RVA: 0x00005C6C File Offset: 0x00003E6C
		Private Shared Function GetProcessId(proc As String) As Integer
			Dim result As Integer = -1
			Dim processes As Process() = Process.GetProcesses()
			For i As Integer = 0 To processes.Length - 1
				If processes(i).ProcessName = proc Then
					result = processes(i).Id
					Exit For
				End If
			Next
			Return result
		End Function

		' Token: 0x06000083 RID: 131 RVA: 0x00005CAC File Offset: 0x00003EAC
		Private Shared Function Inject(exe As String, dllPath As String) As Integer
			Dim processId As Integer = Login.GetProcessId(exe)
			If processId = -1 Then
				Return 1
			End If
			Dim procAddress As IntPtr = Login.GetProcAddress(Login.GetModuleHandle("Kernel32.dll"), "LoadLibraryA")
			If procAddress = CType(0, IntPtr) Then
				Return 2
			End If
			Dim intPtr As IntPtr = Login.OpenProcess(1082UI, 1, CUInt(processId))
			If intPtr = CType(0, IntPtr) Then
				Return 3
			End If
			Dim intPtr2 As IntPtr = Login.VirtualAllocEx(intPtr, CType(Nothing, IntPtr), CType(dllPath.Length, IntPtr), 12288UI, 64UI)
			If intPtr2 = CType(0, IntPtr) Then
				Return 4
			End If
			Dim bytes As Byte() = Encoding.ASCII.GetBytes(dllPath)
			If Login.WriteProcessMemory(intPtr, intPtr2, bytes, CUInt(bytes.Length), 0) = 0 Then
				Return 5
			End If
			If Login.CreateRemoteThread(intPtr, CType(Nothing, IntPtr), CType(0, IntPtr), procAddress, intPtr2, 0UI, CType(Nothing, IntPtr)) = CType(0, IntPtr) Then
				Return 6
			End If
			Login.CloseHandle(intPtr)
			Return 0
		End Function

		' Token: 0x06000084 RID: 132 RVA: 0x00005D8C File Offset: 0x00003F8C
		Private Function GetFileChecksum(filename As String, checksum As String) As Task(Of Byte)
			Dim <GetFileChecksum>d__ As Login.<GetFileChecksum>d__38
			<GetFileChecksum>d__.<>t__builder = AsyncTaskMethodBuilder(Of Byte).Create()
			<GetFileChecksum>d__.<>4__this = Me
			<GetFileChecksum>d__.filename = filename
			<GetFileChecksum>d__.checksum = checksum
			<GetFileChecksum>d__.<>1__state = -1
			<GetFileChecksum>d__.<>t__builder.Start(Of Login.<GetFileChecksum>d__38)(<GetFileChecksum>d__)
			Return <GetFileChecksum>d__.<>t__builder.Task
		End Function

		' Token: 0x06000085 RID: 133 RVA: 0x00005DE0 File Offset: 0x00003FE0
		Public Function LaunchMaple() As Boolean
			Dim CS$<>8__locals1 As Login.<>c__DisplayClass39_0 = New Login.<>c__DisplayClass39_0()
			CS$<>8__locals1.<>4__this = Me
			If Not Configs.localLogin Then
				CS$<>8__locals1.passChecksum = True
				CS$<>8__locals1.bufferSize = 10485760
				Dim files As String() = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.wz", SearchOption.TopDirectoryOnly)
				If files.Length > 26 Then
					MessageBox.Show("Too many .wz files detected. Please remove any wz files that didn't come with the client install.", "WZ Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return False
				End If
				If files.Length < 26 Then
					MessageBox.Show("Too few .wz files detected. Please reinstall the client or replace the files needed.", "WZ Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return False
				End If
				CS$<>8__locals1.wz_ignore = New String() { "Effect", "Sound", "Morph", "Reactor", "String", "TamingMob", "Base" }
				Parallel.ForEach(Of String)(files, Sub(wz_file As String)
					Dim <<LaunchMaple>b__0>d As Login.<>c__DisplayClass39_0.<<LaunchMaple>b__0>d
					<<LaunchMaple>b__0>d.<>t__builder = AsyncVoidMethodBuilder.Create()
					<<LaunchMaple>b__0>d.<>4__this = CS$<>8__locals1
					<<LaunchMaple>b__0>d.wz_file = wz_file
					<<LaunchMaple>b__0>d.<>1__state = -1
					<<LaunchMaple>b__0>d.<>t__builder.Start(Of Login.<>c__DisplayClass39_0.<<LaunchMaple>b__0>d)(<<LaunchMaple>b__0>d)
				End Sub)
				If Not CS$<>8__locals1.passChecksum Then
					Return False
				End If
			End If
			Try
				Dim startupinfo As Login.STARTUPINFO = Nothing
				Dim process_INFORMATION As Login.PROCESS_INFORMATION = Nothing
				If Login.CreateProcess("MapleStory.exe", " WebStart " + Me.Token, IntPtr.Zero, IntPtr.Zero, False, Login.CREATE_SUSPENDED, IntPtr.Zero, Nothing, startupinfo, process_INFORMATION) Then
					Dim num As Integer = Login.Inject("MapleStory", Login.sDllPath)
					If num = 0 Then
						Login.ResumeThread(process_INFORMATION.hThread)
						Login.CloseHandle(process_INFORMATION.hThread)
						Login.CloseHandle(process_INFORMATION.hProcess)
						Return True
					End If
					MessageBox.Show("Error code: " + num.ToString())
					Return False
				End If
			Catch ex As Exception
				MessageBox.Show("Could not start the game. Make sure the file is in your game folder and that this program is ran as admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Return False
		End Function

		' Token: 0x0400004E RID: 78
		Private Shared sDllPath As String = "ijl15.dll"

		' Token: 0x0400004F RID: 79
		Private Shared CREATE_SUSPENDED As UInteger = 4UI

		' Token: 0x02000021 RID: 33
		Public Structure PROCESS_INFORMATION
			' Token: 0x040000BD RID: 189
			Public hProcess As IntPtr

			' Token: 0x040000BE RID: 190
			Public hThread As IntPtr

			' Token: 0x040000BF RID: 191
			Public dwProcessId As UInteger

			' Token: 0x040000C0 RID: 192
			Public dwThreadId As UInteger
		End Structure

		' Token: 0x02000022 RID: 34
		Public Structure STARTUPINFO
			' Token: 0x040000C1 RID: 193
			Public cb As UInteger

			' Token: 0x040000C2 RID: 194
			Public lpReserved As String

			' Token: 0x040000C3 RID: 195
			Public lpDesktop As String

			' Token: 0x040000C4 RID: 196
			Public lpTitle As String

			' Token: 0x040000C5 RID: 197
			Public dwX As UInteger

			' Token: 0x040000C6 RID: 198
			Public dwY As UInteger

			' Token: 0x040000C7 RID: 199
			Public dwXSize As UInteger

			' Token: 0x040000C8 RID: 200
			Public dwYSize As UInteger

			' Token: 0x040000C9 RID: 201
			Public dwXCountChars As UInteger

			' Token: 0x040000CA RID: 202
			Public dwYCountChars As UInteger

			' Token: 0x040000CB RID: 203
			Public dwFillAttribute As UInteger

			' Token: 0x040000CC RID: 204
			Public dwFlags As UInteger

			' Token: 0x040000CD RID: 205
			Public wShowWindow As Short

			' Token: 0x040000CE RID: 206
			Public cbReserved2 As Short

			' Token: 0x040000CF RID: 207
			Public lpReserved2 As IntPtr

			' Token: 0x040000D0 RID: 208
			Public hStdInput As IntPtr

			' Token: 0x040000D1 RID: 209
			Public hStdOutput As IntPtr

			' Token: 0x040000D2 RID: 210
			Public hStdError As IntPtr
		End Structure

		' Token: 0x02000023 RID: 35
		Public Structure SECURITY_ATTRIBUTES
			' Token: 0x040000D3 RID: 211
			Public length As Integer

			' Token: 0x040000D4 RID: 212
			Public lpSecurityDescriptor As IntPtr

			' Token: 0x040000D5 RID: 213
			Public bInheritHandle As Boolean
		End Structure
	End Class
End Namespace
