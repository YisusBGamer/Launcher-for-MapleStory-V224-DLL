Imports System
Imports System.Windows.Forms
Imports MSv214

Namespace MSv214Launcher
	' Token: 0x02000006 RID: 6
	Friend Module Program
		' Token: 0x0600002A RID: 42 RVA: 0x00002652 File Offset: 0x00000852
		<STAThread()>
		Private Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New LauncherUI())
		End Sub
	End Module
End Namespace
