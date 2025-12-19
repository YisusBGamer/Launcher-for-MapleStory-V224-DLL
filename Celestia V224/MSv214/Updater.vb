Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Threading.Tasks

Namespace MSv214
	' Token: 0x02000009 RID: 9
	Public Class Updater
		' Token: 0x06000057 RID: 87 RVA: 0x000051FC File Offset: 0x000033FC
		Public Function UpdateOperation() As Task(Of Boolean)
			Dim <UpdateOperation>d__ As Updater.<UpdateOperation>d__6
			<UpdateOperation>d__.<>t__builder = AsyncTaskMethodBuilder(Of Boolean).Create()
			<UpdateOperation>d__.<>4__this = Me
			<UpdateOperation>d__.<>1__state = -1
			<UpdateOperation>d__.<>t__builder.Start(Of Updater.<UpdateOperation>d__6)(<UpdateOperation>d__)
			Return <UpdateOperation>d__.<>t__builder.Task
		End Function

		' Token: 0x06000058 RID: 88 RVA: 0x00005240 File Offset: 0x00003440
		Public Sub ExtractBatFile()
			Dim name As String = "v214.UpdateScript.bat"
			Dim path As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UpdateScript.bat")
			Try
				Using manifestResourceStream As Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name)
					If manifestResourceStream IsNot Nothing Then
						Using fileStream As FileStream = New FileStream(path, FileMode.Create)
							manifestResourceStream.CopyTo(fileStream)
						End Using
					End If
				End Using
			Catch
			End Try
		End Sub

		' Token: 0x06000059 RID: 89 RVA: 0x000052CC File Offset: 0x000034CC
		Private Sub ExecuteScript(scriptFileName As String)
			Try
				Process.Start(New ProcessStartInfo() With { .FileName = scriptFileName, .UseShellExecute = True, .CreateNoWindow = True, .Verb = "runas" })
				Environment.[Exit](0)
			Catch
			End Try
		End Sub

		' Token: 0x0600005A RID: 90 RVA: 0x00005320 File Offset: 0x00003520
		Public Function CheckFileConnect() As Task(Of Integer)
			Dim <CheckFileConnect>d__ As Updater.<CheckFileConnect>d__9
			<CheckFileConnect>d__.<>t__builder = AsyncTaskMethodBuilder(Of Integer).Create()
			<CheckFileConnect>d__.<>4__this = Me
			<CheckFileConnect>d__.<>1__state = -1
			<CheckFileConnect>d__.<>t__builder.Start(Of Updater.<CheckFileConnect>d__9)(<CheckFileConnect>d__)
			Return <CheckFileConnect>d__.<>t__builder.Task
		End Function

		' Token: 0x0600005B RID: 91 RVA: 0x00005364 File Offset: 0x00003564
		Public Function DownloadFile(fileName As String) As Task(Of Boolean)
			Dim <DownloadFile>d__ As Updater.<DownloadFile>d__10
			<DownloadFile>d__.<>t__builder = AsyncTaskMethodBuilder(Of Boolean).Create()
			<DownloadFile>d__.<>4__this = Me
			<DownloadFile>d__.fileName = fileName
			<DownloadFile>d__.<>1__state = -1
			<DownloadFile>d__.<>t__builder.Start(Of Updater.<DownloadFile>d__10)(<DownloadFile>d__)
			Return <DownloadFile>d__.<>t__builder.Task
		End Function

		' Token: 0x0600005C RID: 92 RVA: 0x000053B0 File Offset: 0x000035B0
		Private Function DownloadAndCheckExe(fileName As String) As Task
			Dim <DownloadAndCheckExe>d__ As Updater.<DownloadAndCheckExe>d__11
			<DownloadAndCheckExe>d__.<>t__builder = AsyncTaskMethodBuilder.Create()
			<DownloadAndCheckExe>d__.<>4__this = Me
			<DownloadAndCheckExe>d__.fileName = fileName
			<DownloadAndCheckExe>d__.<>1__state = -1
			<DownloadAndCheckExe>d__.<>t__builder.Start(Of Updater.<DownloadAndCheckExe>d__11)(<DownloadAndCheckExe>d__)
			Return <DownloadAndCheckExe>d__.<>t__builder.Task
		End Function

		' Token: 0x0600005D RID: 93 RVA: 0x000053FC File Offset: 0x000035FC
		Private Function ReadHashTable() As Dictionary(Of String, String)
			Dim dictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)()
			If File.Exists(Me.localFilePaths(Updater.fileNames(5))) Then
				Try
					Dim array As String() = File.ReadAllLines(Me.localFilePaths(Updater.fileNames(5)))
					For i As Integer = 0 To array.Length - 1
						Dim array2 As String() = array(i).Split(New Char() { ","c })
						If array2.Length = 2 Then
							Dim key As String = array2(0).Trim()
							Dim value As String = array2(1).Trim()
							If Not dictionary.ContainsKey(key) Then
								dictionary.Add(key, value)
							End If
						End If
					Next
					Return dictionary
				Catch
				End Try
			End If
			Return Nothing
		End Function

		' Token: 0x0600005E RID: 94 RVA: 0x000054AC File Offset: 0x000036AC
		Private Function CheckLocalFileHash(fileName As String, expectedHash As String) As Boolean
			Dim bufferSize As Integer = 2097152
			Dim path As String = Path.Combine(Directory.GetCurrentDirectory(), fileName)
			If File.Exists(path) Then
				Dim value As Byte()
				Using md As MD5 = MD5.Create()
					Using fileStream As FileStream = New FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize)
						Using bufferedStream As BufferedStream = New BufferedStream(fileStream, bufferSize)
							value = md.ComputeHash(bufferedStream)
						End Using
					End Using
				End Using
				If BitConverter.ToString(value).Replace("-", "").ToLowerInvariant() = expectedHash Then
					Return True
				End If
			End If
			Return False
		End Function

		' Token: 0x0600005F RID: 95 RVA: 0x0000556C File Offset: 0x0000376C
		Private Function GetStatusCodeAsync(serverFilePath As String) As Task(Of Integer)
			Dim <GetStatusCodeAsync>d__ As Updater.<GetStatusCodeAsync>d__14
			<GetStatusCodeAsync>d__.<>t__builder = AsyncTaskMethodBuilder(Of Integer).Create()
			<GetStatusCodeAsync>d__.serverFilePath = serverFilePath
			<GetStatusCodeAsync>d__.<>1__state = -1
			<GetStatusCodeAsync>d__.<>t__builder.Start(Of Updater.<GetStatusCodeAsync>d__14)(<GetStatusCodeAsync>d__)
			Return <GetStatusCodeAsync>d__.<>t__builder.Task
		End Function

		' Token: 0x06000060 RID: 96 RVA: 0x000055AF File Offset: 0x000037AF
		Public Sub DeleteOldFiles()
			Me.DeleteFilesWithoutRecycleBin(New String() { "temp.exe", "updatehashes.udtr", "UpdateScript.bat" })
		End Sub

		' Token: 0x06000061 RID: 97 RVA: 0x000055D8 File Offset: 0x000037D8
		Private Sub DeleteFilesWithoutRecycleBin(ParamArray filePaths As String())
			Try
				For Each path As String In filePaths
					If File.Exists(path) Then
						File.Delete(path)
					End If
				Next
			Catch ex As Exception
				Console.WriteLine("Error deleting file: " + ex.Message)
			End Try
		End Sub

		' Token: 0x06000062 RID: 98 RVA: 0x00005634 File Offset: 0x00003834
		Public Function CheckFileExists(fileName As String) As Boolean
			Return File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName))
		End Function

		' Token: 0x06000063 RID: 99 RVA: 0x00005650 File Offset: 0x00003850
		Private Function CombineSFN(root As String, sfn As String) As String
			Return root + sfn
		End Function

		' Token: 0x04000047 RID: 71
		Private Shared HttpClientTimeout As TimeSpan = TimeSpan.FromSeconds(10.0)

		' Token: 0x04000048 RID: 72
		Private Shared serverFileRoot As String = "v214/"

		' Token: 0x04000049 RID: 73
		Private Shared fileNames As String() = New String() { "v214 Official.exe", "MapleStory.exe", "v214.dll", "ijl15.dll", "Data.wz", "updatehashes.udtr" }

		' Token: 0x0400004A RID: 74
		Private localFilePaths As Dictionary(Of String, String) = New Dictionary(Of String, String)() From { { Updater.fileNames(0), Assembly.GetExecutingAssembly().Location }, { Updater.fileNames(1), Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Updater.fileNames(1)) }, { Updater.fileNames(2), Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Updater.fileNames(2)) }, { Updater.fileNames(3), Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Updater.fileNames(3)) }, { Updater.fileNames(4), Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Updater.fileNames(4)) }, { Updater.fileNames(5), Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Updater.fileNames(5)) } }

		' Token: 0x0400004B RID: 75
		Private serverFilePathsStatCodes As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)() From { { Updater.fileNames(0), -1 }, { Updater.fileNames(1), -1 }, { Updater.fileNames(2), -1 }, { Updater.fileNames(3), -1 }, { Updater.fileNames(4), -1 }, { Updater.fileNames(5), -1 } }

		' Token: 0x0400004C RID: 76
		Private Shared updateStatusMessages As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)() From { { -1, "Server is Offline" }, { 0, "Communicated with Server and found files..." }, { 1, "Client is Current Version" }, { 10, "Updating Client files..." }, { 11, "Updating Maple Client and Restarting..." }, { 20, "Server Client File Not Found" }, { 21, "Server Maple Client File Not Found" }, { 22, "Server v214.dll File Not Found" }, { 23, "Server ijl15.dll File Not Found" }, { 24, "Server Data.wz File Not Found" }, { 25, "Server Hash Table File Not Found" }, { 30, "Server Connection/File Download Failed" }, { 50, "Do not have permission to Access Server" }, { 100, "Update Server Unavalible" } }
	End Class
End Namespace
