Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports v214.Properties

Namespace MSv214
	' Token: 0x02000007 RID: 7
	Public Partial Class LauncherUI
		Inherits Form

		' Token: 0x0600002B RID: 43 RVA: 0x0000266C File Offset: 0x0000086C
		Public Sub New()
			Me.InitializeComponent()
			Me.EnableDragging(Me)
			Me.ChangeButtonBGEvent(Me)
		End Sub

		' Token: 0x0600002C RID: 44 RVA: 0x00002708 File Offset: 0x00000908
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			MyBase.OnPaint(e)
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			Dim rectangle As Rectangle = New Rectangle(0, 0, MyBase.Width, MyBase.Height)
			graphicsPath.AddArc(rectangle.X, rectangle.Y, 24, 24, 180F, 90F)
			graphicsPath.AddArc(rectangle.Width - 24, rectangle.Y, 24, 24, 270F, 90F)
			graphicsPath.AddArc(rectangle.Width - 24, rectangle.Height - 24, 24, 24, 0F, 90F)
			graphicsPath.AddArc(rectangle.X, rectangle.Height - 24, 24, 24, 90F, 90F)
			graphicsPath.CloseFigure()
			MyBase.Region = New Region(graphicsPath)
			Using pen As Pen = New Pen(Me.BoarderColor, 4F)
				e.Graphics.DrawPath(pen, graphicsPath)
			End Using
		End Sub

		' Token: 0x0600002D RID: 45 RVA: 0x00002818 File Offset: 0x00000A18
		Private Sub ChangeButtonBGEvent(control As Control)
			For Each obj As Object In control.Controls
				Dim control2 As Control = CType(obj, Control)
				Dim button As Button = TryCast(control2, Button)
				If button IsNot Nothing Then
					If button Is Me.btnMenuLogin OrElse button Is Me.btnMenuRegister OrElse button Is Me.btnMenuGameStart OrElse button Is Me.btnMenuAboutUs OrElse button Is Me.btnMenuDonate OrElse button Is Me.btnMenuExit Then
						AddHandler button.MouseEnter, AddressOf Me.Button_MouseEnter
						AddHandler button.MouseLeave, AddressOf Me.Button_MouseLeave
					End If
				ElseIf control2.HasChildren Then
					Me.ChangeButtonBGEvent(control2)
				End If
			Next
		End Sub

		' Token: 0x0600002E RID: 46 RVA: 0x000028E8 File Offset: 0x00000AE8
		Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
			Dim button As Button = TryCast(sender, Button)
			If button IsNot Nothing Then
				button.BackColor = Color.FromArgb(50, 80, 100)
			End If
		End Sub

		' Token: 0x0600002F RID: 47 RVA: 0x00002910 File Offset: 0x00000B10
		Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
			Dim button As Button = TryCast(sender, Button)
			If button IsNot Nothing Then
				button.BackColor = Color.Transparent
			End If
		End Sub

		' Token: 0x06000030 RID: 48 RVA: 0x00002934 File Offset: 0x00000B34
		Private Sub EnableDragging(control As Control)
			AddHandler control.MouseDown, AddressOf Me.Control_MouseDown
			AddHandler control.MouseMove, AddressOf Me.Control_MouseMove
			AddHandler control.MouseUp, AddressOf Me.Control_MouseUp
			For Each obj As Object In control.Controls
				Dim control2 As Control = CType(obj, Control)
				If Not(TypeOf control2 Is Button) AndAlso Not(TypeOf control2 Is TextBox) Then
					Me.EnableDragging(control2)
				End If
			Next
		End Sub

		' Token: 0x06000031 RID: 49 RVA: 0x000029D4 File Offset: 0x00000BD4
		Private Sub Control_MouseDown(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				Me.isDragging = True
				Me.lastCursorPosition = Cursor.Position
			End If
		End Sub

		' Token: 0x06000032 RID: 50 RVA: 0x000029F8 File Offset: 0x00000BF8
		Private Sub Control_MouseMove(sender As Object, e As MouseEventArgs)
			If Me.isDragging Then
				Dim position As Point = Cursor.Position
				Dim num As Integer = position.X - Me.lastCursorPosition.X
				Dim num2 As Integer = position.Y - Me.lastCursorPosition.Y
				MyBase.Location = New Point(MyBase.Location.X + num, MyBase.Location.Y + num2)
				Me.lastCursorPosition = position
			End If
		End Sub

		' Token: 0x06000033 RID: 51 RVA: 0x00002A6D File Offset: 0x00000C6D
		Private Sub Control_MouseUp(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				Me.isDragging = False
			End If
		End Sub

		' Token: 0x06000034 RID: 52 RVA: 0x00002A84 File Offset: 0x00000C84
		Private Sub LauncherUI_Load(sender As Object, e As EventArgs)
			Me.animatedOverUser = New Animations(Me.picBoxOverUser, Me.OverUserSprite)
			Me.animatedOverUser.LoadSprites(6)
			Me.animatedOverUser.StartAnimationPB(80)
			Me.btnMenuGameStart.Image = Resources.GameStart_Grey
			Me.pnlLogin.Hide()
			Me.pnlRegister.Hide()
			Me.pnlAboutUs.Hide()
			Me.pnlBlank.Hide()
			Me.btnMenuAboutUs.Hide()
			Me.btnMenuDonate.Hide()
			Me.checkForUpdates()
		End Sub

		' Token: 0x06000035 RID: 53 RVA: 0x00002B1A File Offset: 0x00000D1A
		Private Sub btnMenuExit_Click(sender As Object, e As EventArgs)
			Environment.[Exit](0)
		End Sub

		' Token: 0x06000036 RID: 54 RVA: 0x00002B22 File Offset: 0x00000D22
		Private Sub btnMenuLogin_Click(sender As Object, e As EventArgs)
			Me.SwapPanelVeiw(Me.pnlLogin)
		End Sub

		' Token: 0x06000037 RID: 55 RVA: 0x00002B30 File Offset: 0x00000D30
		Private Sub btnMenuRegister_Click(sender As Object, e As EventArgs)
			If Me.login.Auth Then
				MessageBox.Show("You have already signed into an account.")
				Return
			End If
			Me.SwapPanelVeiw(Me.pnlRegister)
		End Sub

		' Token: 0x06000038 RID: 56 RVA: 0x00002B57 File Offset: 0x00000D57
		Private Sub btnMenuDonate_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000039 RID: 57 RVA: 0x00002B59 File Offset: 0x00000D59
		Private Sub btnMenuAboutUs_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600003A RID: 58 RVA: 0x00002B5B File Offset: 0x00000D5B
		Private Sub picBoxSettingsWheel_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600003B RID: 59 RVA: 0x00002B60 File Offset: 0x00000D60
		Private Sub btnMenuGameStart_Click(sender As Object, e As EventArgs)
			Dim <btnMenuGameStart_Click>d__ As LauncherUI.<btnMenuGameStart_Click>d__35
			<btnMenuGameStart_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create()
			<btnMenuGameStart_Click>d__.<>4__this = Me
			<btnMenuGameStart_Click>d__.<>1__state = -1
			<btnMenuGameStart_Click>d__.<>t__builder.Start(Of LauncherUI.<btnMenuGameStart_Click>d__35)(<btnMenuGameStart_Click>d__)
		End Sub

		' Token: 0x0600003C RID: 60 RVA: 0x00002B98 File Offset: 0x00000D98
		Private Sub btnMenuGameStart_MouseEnter(sender As Object, e As EventArgs)
			If Me.btnMenuGameStart.Enabled AndAlso Me.animatedGameStart Is Nothing Then
				Me.animatedGameStart = New Animations(Me.btnMenuGameStart, Me.GameStartSprite)
				Me.animatedGameStart.LoadSprites(3)
				Me.animatedGameStart.StartAnimationBTN(100)
			End If
		End Sub

		' Token: 0x0600003D RID: 61 RVA: 0x00002BEA File Offset: 0x00000DEA
		Private Sub btnMenuGameStart_MouseLeave(sender As Object, e As EventArgs)
			If Me.animatedGameStart IsNot Nothing Then
				Me.animatedGameStart.StopAnimationBTN()
				Me.animatedGameStart = Nothing
				Me.btnMenuGameStart.Image = Resources.GameStart_2
			End If
		End Sub

		' Token: 0x0600003E RID: 62 RVA: 0x00002C18 File Offset: 0x00000E18
		Private Sub picBoxSettingsWheel_MouseEnter(sender As Object, e As EventArgs)
			If Me.picBoxSettingsWheel.Enabled AndAlso Me.animatedSettingsWheel Is Nothing Then
				Me.animatedSettingsWheel = New Animations(Me.picBoxSettingsWheel, Me.SettingsWheelSprite)
				Me.animatedSettingsWheel.LoadSprites(4)
				Me.animatedSettingsWheel.StartAnimationPB(80)
			End If
		End Sub

		' Token: 0x0600003F RID: 63 RVA: 0x00002C6A File Offset: 0x00000E6A
		Private Sub picBoxSettingsWheel_MouseLeave(sender As Object, e As EventArgs)
			If Me.animatedSettingsWheel IsNot Nothing Then
				Me.animatedSettingsWheel.StopAnimationPB()
				Me.animatedSettingsWheel = Nothing
				Me.picBoxSettingsWheel.Image = Resources.SettingsWheel_1
			End If
		End Sub

		' Token: 0x06000040 RID: 64 RVA: 0x00002C98 File Offset: 0x00000E98
		Private Sub picBoxSettingsWheel_MouseDown(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				If Me.animatedSettingsWheel IsNot Nothing Then
					Me.animatedSettingsWheel.StopAnimationPB()
					Me.animatedSettingsWheel = Nothing
					Me.picBoxSettingsWheel.Image = Resources.SettingsWheel_1
				End If
				Me.picBoxSettingsWheel.Image = Resources.SettingsWheel_pressed
			End If
		End Sub

		' Token: 0x06000041 RID: 65 RVA: 0x00002CEC File Offset: 0x00000EEC
		Private Sub picBoxSettingsWheel_MouseUp(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				Me.picBoxSettingsWheel.Image = Resources.SettingsWheel
				If Me.picBoxSettingsWheel.Enabled AndAlso Me.animatedSettingsWheel Is Nothing Then
					Me.animatedSettingsWheel = New Animations(Me.picBoxSettingsWheel, Me.SettingsWheelSprite)
					Me.animatedSettingsWheel.LoadSprites(4)
					Me.animatedSettingsWheel.StartAnimationPB(80)
				End If
			End If
		End Sub

		' Token: 0x06000042 RID: 66 RVA: 0x00002D5C File Offset: 0x00000F5C
		Private Sub btnLogin_Click(sender As Object, e As EventArgs)
			Dim <btnLogin_Click>d__ As LauncherUI.<btnLogin_Click>d__42
			<btnLogin_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create()
			<btnLogin_Click>d__.<>4__this = Me
			<btnLogin_Click>d__.<>1__state = -1
			<btnLogin_Click>d__.<>t__builder.Start(Of LauncherUI.<btnLogin_Click>d__42)(<btnLogin_Click>d__)
		End Sub

		' Token: 0x06000043 RID: 67 RVA: 0x00002D94 File Offset: 0x00000F94
		Private Sub btnRegister_Click(sender As Object, e As EventArgs)
			Dim <btnRegister_Click>d__ As LauncherUI.<btnRegister_Click>d__43
			<btnRegister_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create()
			<btnRegister_Click>d__.<>4__this = Me
			<btnRegister_Click>d__.<>1__state = -1
			<btnRegister_Click>d__.<>t__builder.Start(Of LauncherUI.<btnRegister_Click>d__43)(<btnRegister_Click>d__)
		End Sub

		' Token: 0x06000044 RID: 68 RVA: 0x00002DCC File Offset: 0x00000FCC
		Private Sub SwapPanelVeiw(panel As Panel)
			MyBase.SuspendLayout()
			If Me.pnlLogin.Visible AndAlso panel IsNot Me.pnlLogin Then
				Me.pnlLogin.Hide()
				Me.tbLoginPassword.Clear()
				Me.tbLoginUsername.Clear()
			End If
			If Me.pnlAboutUs.Visible AndAlso panel IsNot Me.pnlAboutUs Then
				Me.pnlAboutUs.Hide()
			End If
			If Me.pnlBlank.Visible AndAlso panel IsNot Me.pnlBlank Then
				Me.pnlBlank.Hide()
			End If
			If Me.pnlRegister.Visible AndAlso panel IsNot Me.pnlRegister Then
				Me.pnlRegister.Hide()
				Me.tbRegEMail.Clear()
				Me.tbRegPassword.Clear()
				Me.tbRegREPassword.Clear()
				Me.tbRegUsername.Clear()
			End If
			If Not panel.Visible Then
				panel.Show()
			End If
			MyBase.ResumeLayout(True)
		End Sub

		' Token: 0x06000045 RID: 69 RVA: 0x00002EBC File Offset: 0x000010BC
		Private Function StartGame() As Task
			Dim <StartGame>d__ As LauncherUI.<StartGame>d__45
			<StartGame>d__.<>t__builder = AsyncTaskMethodBuilder.Create()
			<StartGame>d__.<>4__this = Me
			<StartGame>d__.<>1__state = -1
			<StartGame>d__.<>t__builder.Start(Of LauncherUI.<StartGame>d__45)(<StartGame>d__)
			Return <StartGame>d__.<>t__builder.Task
		End Function

		' Token: 0x06000046 RID: 70 RVA: 0x00002F00 File Offset: 0x00001100
		Private Function loginAndDisplayUser(user As String, pass As String) As Task
			Dim <loginAndDisplayUser>d__ As LauncherUI.<loginAndDisplayUser>d__46
			<loginAndDisplayUser>d__.<>t__builder = AsyncTaskMethodBuilder.Create()
			<loginAndDisplayUser>d__.<>4__this = Me
			<loginAndDisplayUser>d__.user = user
			<loginAndDisplayUser>d__.pass = pass
			<loginAndDisplayUser>d__.<>1__state = -1
			<loginAndDisplayUser>d__.<>t__builder.Start(Of LauncherUI.<loginAndDisplayUser>d__46)(<loginAndDisplayUser>d__)
			Return <loginAndDisplayUser>d__.<>t__builder.Task
		End Function

		' Token: 0x06000047 RID: 71 RVA: 0x00002F54 File Offset: 0x00001154
		Private Function checkForUpdates() As Task
			Dim <checkForUpdates>d__ As LauncherUI.<checkForUpdates>d__47
			<checkForUpdates>d__.<>t__builder = AsyncTaskMethodBuilder.Create()
			<checkForUpdates>d__.<>4__this = Me
			<checkForUpdates>d__.<>1__state = -1
			<checkForUpdates>d__.<>t__builder.Start(Of LauncherUI.<checkForUpdates>d__47)(<checkForUpdates>d__)
			Return <checkForUpdates>d__.<>t__builder.Task
		End Function

		' Token: 0x06000048 RID: 72 RVA: 0x00002F98 File Offset: 0x00001198
		Private Function LoginCheck(user As String, pass As String) As Task(Of Boolean)
			Dim <LoginCheck>d__ As LauncherUI.<LoginCheck>d__48
			<LoginCheck>d__.<>t__builder = AsyncTaskMethodBuilder(Of Boolean).Create()
			<LoginCheck>d__.<>4__this = Me
			<LoginCheck>d__.user = user
			<LoginCheck>d__.pass = pass
			<LoginCheck>d__.<>1__state = -1
			<LoginCheck>d__.<>t__builder.Start(Of LauncherUI.<LoginCheck>d__48)(<LoginCheck>d__)
			Return <LoginCheck>d__.<>t__builder.Task
		End Function

		' Token: 0x06000049 RID: 73 RVA: 0x00002FEC File Offset: 0x000011EC
		Private Function GetToken(user As String, pass As String) As Task(Of String)
			Dim <GetToken>d__ As LauncherUI.<GetToken>d__49
			<GetToken>d__.<>t__builder = AsyncTaskMethodBuilder(Of String).Create()
			<GetToken>d__.<>4__this = Me
			<GetToken>d__.user = user
			<GetToken>d__.pass = pass
			<GetToken>d__.<>1__state = -1
			<GetToken>d__.<>t__builder.Start(Of LauncherUI.<GetToken>d__49)(<GetToken>d__)
			Return <GetToken>d__.<>t__builder.Task
		End Function

		' Token: 0x0600004A RID: 74 RVA: 0x00003040 File Offset: 0x00001240
		Private Sub tmrCheckConnection_Tick(sender As Object, e As EventArgs)
			If Not Me.client.IsConnected() OrElse Me.client Is Nothing Then
				If Me.animatedUserBorder IsNot Nothing Then
					Me.animatedUserBorder.StopAnimationPB()
					Me.animatedUserBorder = Nothing
				End If
				If Me.animatedGameStart IsNot Nothing Then
					Me.animatedGameStart.StopAnimationBTN()
					Me.animatedGameStart = Nothing
				End If
				Me.btnMenuGameStart.Image = If((Me.btnMenuGameStart.Image IsNot Resources.GameStart_Grey), Resources.GameStart_Grey, Me.btnMenuGameStart.Image)
				Me.btnMenuGameStart.Enabled = (Not Me.btnMenuGameStart.Enabled AndAlso Me.btnMenuGameStart.Enabled)
				Me.picBoxUserInfoBorder.Image = If((Me.picBoxUserInfoBorder.Image IsNot Resources.UserBorder_Grey), Resources.UserBorder_Grey, Me.picBoxUserInfoBorder.Image)
				Me.lblConnectStatus.Text = "Connection Status: Disconnected, Reconnecting..."
				Me.lblConnectStatus.ForeColor = Color.Red
				Me.tmrCheckConnection.Interval = 5000
				Try
					If Me.client Is Nothing Then
						Me.client = New Client()
					End If
					Me.client.Connect()
					Return
				Catch ex As Exception
					Console.WriteLine(ex.ToString())
					Me.client = Nothing
					Return
				End Try
			End If
			If Me.login.Auth Then
				If Me.animatedUserBorder Is Nothing Then
					Me.animatedUserBorder = New Animations(Me.picBoxUserInfoBorder, Me.UserBorderSprite)
					Me.animatedUserBorder.LoadSprites(6)
					Me.animatedUserBorder.StartAnimationPB(100)
				End If
				Me.btnMenuGameStart.Enabled = (Not Me.btnMenuGameStart.Enabled OrElse Me.btnMenuGameStart.Enabled)
				Me.btnMenuGameStart.Image = If((Me.btnMenuGameStart.Image IsNot Resources.GameStart_1), Resources.GameStart_1, Me.btnMenuGameStart.Image)
			End If
			Me.lblConnectStatus.Text = "Connection Status: Connected"
			Me.lblConnectStatus.ForeColor = Color.Lime
			Me.tmrCheckConnection.Interval = 15000
		End Sub

		' Token: 0x0600004B RID: 75 RVA: 0x00003264 File Offset: 0x00001464
		Private Sub pnlInfo_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x04000006 RID: 6
		Private client As Client = New Client()

		' Token: 0x04000007 RID: 7
		Private login As Login = New Login()

		' Token: 0x04000008 RID: 8
		Private register As Register = New Register()

		' Token: 0x04000009 RID: 9
		Private updater As Updater = New Updater()

		' Token: 0x0400000A RID: 10
		Private Const BorderSize As Integer = 4

		' Token: 0x0400000B RID: 11
		Private Const BorderRadius As Integer = 24

		' Token: 0x0400000C RID: 12
		Private BoarderColor As Color = Color.FromArgb(25, 40, 50)

		' Token: 0x0400000D RID: 13
		Private isDragging As Boolean

		' Token: 0x0400000E RID: 14
		Private lastCursorPosition As Point

		' Token: 0x0400000F RID: 15
		Private animatedOverUser As Animations

		' Token: 0x04000010 RID: 16
		Private OverUserSprite As String = "OverUser"

		' Token: 0x04000011 RID: 17
		Private animatedUserBorder As Animations

		' Token: 0x04000012 RID: 18
		Private UserBorderSprite As String = "UserBorder"

		' Token: 0x04000013 RID: 19
		Private animatedGameStart As Animations

		' Token: 0x04000014 RID: 20
		Private GameStartSprite As String = "GameStart"

		' Token: 0x04000015 RID: 21
		Private animatedLoading As Animations

		' Token: 0x04000016 RID: 22
		Private LoadingSprite As String = "Loading"

		' Token: 0x04000017 RID: 23
		Private animatedSettingsWheel As Animations

		' Token: 0x04000018 RID: 24
		Private SettingsWheelSprite As String = "SettingsWheel"
	End Class
End Namespace
