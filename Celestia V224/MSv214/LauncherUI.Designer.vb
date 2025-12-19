Imports System
Imports MSv214
Imports System.ComponentModel

Namespace MSv214
	' Token: 0x02000007 RID: 7
	Partial Public Class LauncherUI
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600004C RID: 76 RVA: 0x00003266 File Offset: 0x00001466
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x0600004D RID: 77 RVA: 0x00003288 File Offset: 0x00001488
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Me.pnlControl = New Global.System.Windows.Forms.Panel()
			Me.btnMenuGameStart = New Global.System.Windows.Forms.Button()
			Me.btnMenuExit = New Global.System.Windows.Forms.Button()
			Me.btnMenuAboutUs = New Global.System.Windows.Forms.Button()
			Me.btnMenuDonate = New Global.System.Windows.Forms.Button()
			Me.btnMenuRegister = New Global.System.Windows.Forms.Button()
			Me.btnMenuLogin = New Global.System.Windows.Forms.Button()
			Me.pnlMenuUserInfo = New Global.System.Windows.Forms.Panel()
			Me.picBoxOverUser = New Global.System.Windows.Forms.PictureBox()
			Me.pnlLoggedInUser = New Global.System.Windows.Forms.Panel()
			Me.lblUserLogin = New Global.System.Windows.Forms.Label()
			Me.lblUserWelcome = New Global.System.Windows.Forms.Label()
			Me.picBoxUserInfoBorder = New Global.System.Windows.Forms.PictureBox()
			Me.pnlInfo = New Global.System.Windows.Forms.Panel()
			Me.picBoxSettingsWheel = New Global.System.Windows.Forms.PictureBox()
			Me.lblConnectStatus = New Global.System.Windows.Forms.Label()
			Me.pnlUserResponse = New Global.System.Windows.Forms.Panel()
			Me.tmrCheckConnection = New Global.System.Windows.Forms.Timer(Me.components)
			Me.pnlAboutUs = New Global.RoundPanel()
			Me.pnlLogin = New Global.RoundPanel()
			Me.tbLoginPassword = New Global.System.Windows.Forms.TextBox()
			Me.tbLoginUsername = New Global.System.Windows.Forms.TextBox()
			Me.lblPassword = New Global.System.Windows.Forms.Label()
			Me.lblUsername = New Global.System.Windows.Forms.Label()
			Me.btnLogin = New Global.RoundButton()
			Me.pnlBlank = New Global.RoundPanel()
			Me.pnlRegister = New Global.RoundPanel()
			Me.lblRegEMail = New Global.System.Windows.Forms.Label()
			Me.lblRegREPassword = New Global.System.Windows.Forms.Label()
			Me.tbRegREPassword = New Global.System.Windows.Forms.TextBox()
			Me.tbRegPassword = New Global.System.Windows.Forms.TextBox()
			Me.tbRegEMail = New Global.System.Windows.Forms.TextBox()
			Me.tbRegUsername = New Global.System.Windows.Forms.TextBox()
			Me.lblRegPassword = New Global.System.Windows.Forms.Label()
			Me.lblRegUsername = New Global.System.Windows.Forms.Label()
			Me.btnRegister = New Global.RoundButton()
			Me.pnlProgMsg = New Global.RoundPanel()
			Me.picBoxLoading = New Global.System.Windows.Forms.PictureBox()
			Me.pnlNews = New Global.RoundPanel()
			Me.pnlControl.SuspendLayout()
			Me.pnlMenuUserInfo.SuspendLayout()
			CType(Me.picBoxOverUser, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlLoggedInUser.SuspendLayout()
			CType(Me.picBoxUserInfoBorder, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlInfo.SuspendLayout()
			CType(Me.picBoxSettingsWheel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlUserResponse.SuspendLayout()
			Me.pnlLogin.SuspendLayout()
			Me.pnlRegister.SuspendLayout()
			Me.pnlProgMsg.SuspendLayout()

			Me.pnlControl.BackColor = Global.System.Drawing.Color.FromArgb(220, 25, 40, 50)
			Me.pnlControl.Controls.Add(Me.btnMenuGameStart)
			Me.pnlControl.Controls.Add(Me.btnMenuExit)
			Me.pnlControl.Controls.Add(Me.btnMenuAboutUs)
			Me.pnlControl.Controls.Add(Me.btnMenuDonate)
			Me.pnlControl.Controls.Add(Me.btnMenuRegister)
			Me.pnlControl.Controls.Add(Me.btnMenuLogin)
			Me.pnlControl.Controls.Add(Me.pnlMenuUserInfo)
			Me.pnlControl.Dock = Global.System.Windows.Forms.DockStyle.Left
			Me.pnlControl.Location = New Global.System.Drawing.Point(0, 0)
			Me.pnlControl.Name = "pnlControl"
			Me.pnlControl.Size = New Global.System.Drawing.Size(200, 550)
			Me.pnlControl.TabIndex = 0
			Me.btnMenuGameStart.BackColor = Global.System.Drawing.Color.Transparent
			Me.btnMenuGameStart.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			Me.btnMenuGameStart.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.btnMenuGameStart.FlatAppearance.BorderSize = 0
			Me.btnMenuGameStart.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnMenuGameStart.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnMenuGameStart.ForeColor = Global.System.Drawing.Color.Transparent
			Me.btnMenuGameStart.Image = Global.v214.Properties.Resources.GameStart_Grey
			Me.btnMenuGameStart.Location = New Global.System.Drawing.Point(0, 470)
			Me.btnMenuGameStart.Name = "btnMenuGameStart"
			Me.btnMenuGameStart.Size = New Global.System.Drawing.Size(200, 40)
			Me.btnMenuGameStart.TabIndex = 5
			Me.btnMenuGameStart.UseVisualStyleBackColor = False
			AddHandler Me.btnMenuGameStart.Click, AddressOf Me.btnMenuGameStart_Click
			AddHandler Me.btnMenuGameStart.MouseEnter, AddressOf Me.btnMenuGameStart_MouseEnter
			AddHandler Me.btnMenuGameStart.MouseLeave, AddressOf Me.btnMenuGameStart_MouseLeave
			Me.btnMenuExit.BackColor = Global.System.Drawing.Color.Transparent
			Me.btnMenuExit.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			Me.btnMenuExit.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.btnMenuExit.FlatAppearance.BorderSize = 0
			Me.btnMenuExit.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnMenuExit.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnMenuExit.ForeColor = Global.System.Drawing.Color.FromArgb(0, 125, 250)
			Me.btnMenuExit.Location = New Global.System.Drawing.Point(0, 510)
			Me.btnMenuExit.Name = "btnMenuExit"
			Me.btnMenuExit.Size = New Global.System.Drawing.Size(200, 40)
			Me.btnMenuExit.TabIndex = 6
			Me.btnMenuExit.Text = "Exit"
			Me.btnMenuExit.UseVisualStyleBackColor = False
			AddHandler Me.btnMenuExit.Click, AddressOf Me.btnMenuExit_Click
			Me.btnMenuAboutUs.BackColor = Global.System.Drawing.Color.Transparent
			Me.btnMenuAboutUs.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			Me.btnMenuAboutUs.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.btnMenuAboutUs.FlatAppearance.BorderSize = 0
			Me.btnMenuAboutUs.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnMenuAboutUs.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnMenuAboutUs.ForeColor = Global.System.Drawing.Color.FromArgb(0, 125, 250)
			Me.btnMenuAboutUs.Location = New Global.System.Drawing.Point(0, 285)
			Me.btnMenuAboutUs.Name = "btnMenuAboutUs"
			Me.btnMenuAboutUs.Size = New Global.System.Drawing.Size(200, 40)
			Me.btnMenuAboutUs.TabIndex = 4
			Me.btnMenuAboutUs.Text = "About Us"
			Me.btnMenuAboutUs.UseVisualStyleBackColor = False
			AddHandler Me.btnMenuAboutUs.Click, AddressOf Me.btnMenuAboutUs_Click
			Me.btnMenuDonate.BackColor = Global.System.Drawing.Color.Transparent
			Me.btnMenuDonate.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			Me.btnMenuDonate.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.btnMenuDonate.FlatAppearance.BorderSize = 0
			Me.btnMenuDonate.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnMenuDonate.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnMenuDonate.ForeColor = Global.System.Drawing.Color.FromArgb(0, 125, 250)
			Me.btnMenuDonate.Location = New Global.System.Drawing.Point(0, 245)
			Me.btnMenuDonate.Name = "btnMenuDonate"
			Me.btnMenuDonate.Size = New Global.System.Drawing.Size(200, 40)
			Me.btnMenuDonate.TabIndex = 3
			Me.btnMenuDonate.Text = "Donate"
			Me.btnMenuDonate.UseVisualStyleBackColor = False
			AddHandler Me.btnMenuDonate.Click, AddressOf Me.btnMenuDonate_Click
			Me.btnMenuRegister.BackColor = Global.System.Drawing.Color.Transparent
			Me.btnMenuRegister.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			Me.btnMenuRegister.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.btnMenuRegister.FlatAppearance.BorderSize = 0
			Me.btnMenuRegister.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnMenuRegister.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnMenuRegister.ForeColor = Global.System.Drawing.Color.FromArgb(0, 125, 250)
			Me.btnMenuRegister.Location = New Global.System.Drawing.Point(0, 205)
			Me.btnMenuRegister.Name = "btnMenuRegister"
			Me.btnMenuRegister.Size = New Global.System.Drawing.Size(200, 40)
			Me.btnMenuRegister.TabIndex = 2
			Me.btnMenuRegister.Text = "Register"
			Me.btnMenuRegister.UseVisualStyleBackColor = False
			AddHandler Me.btnMenuRegister.Click, AddressOf Me.btnMenuRegister_Click
			Me.btnMenuLogin.BackColor = Global.System.Drawing.Color.Transparent
			Me.btnMenuLogin.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			Me.btnMenuLogin.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.btnMenuLogin.FlatAppearance.BorderSize = 0
			Me.btnMenuLogin.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnMenuLogin.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnMenuLogin.ForeColor = Global.System.Drawing.Color.FromArgb(0, 125, 250)
			Me.btnMenuLogin.Location = New Global.System.Drawing.Point(0, 165)
			Me.btnMenuLogin.Name = "btnMenuLogin"
			Me.btnMenuLogin.Size = New Global.System.Drawing.Size(200, 40)
			Me.btnMenuLogin.TabIndex = 1
			Me.btnMenuLogin.Text = "Login"
			Me.btnMenuLogin.UseVisualStyleBackColor = False
			AddHandler Me.btnMenuLogin.Click, AddressOf Me.btnMenuLogin_Click
			Me.pnlMenuUserInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.pnlMenuUserInfo.Controls.Add(Me.picBoxOverUser)
			Me.pnlMenuUserInfo.Controls.Add(Me.pnlLoggedInUser)
			Me.pnlMenuUserInfo.Controls.Add(Me.lblUserWelcome)
			Me.pnlMenuUserInfo.Controls.Add(Me.picBoxUserInfoBorder)
			Me.pnlMenuUserInfo.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.pnlMenuUserInfo.Location = New Global.System.Drawing.Point(0, 0)
			Me.pnlMenuUserInfo.Name = "pnlMenuUserInfo"
			Me.pnlMenuUserInfo.Size = New Global.System.Drawing.Size(200, 165)
			Me.pnlMenuUserInfo.TabIndex = 0
			Me.picBoxOverUser.Image = Global.v214.Properties.Resources.OverUser_1
			Me.picBoxOverUser.Location = New Global.System.Drawing.Point(18, 15)
			Me.picBoxOverUser.Name = "picBoxOverUser"
			Me.picBoxOverUser.Size = New Global.System.Drawing.Size(164, 71)
			Me.picBoxOverUser.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.CenterImage
			Me.picBoxOverUser.TabIndex = 5
			Me.picBoxOverUser.TabStop = False
			Me.pnlLoggedInUser.Controls.Add(Me.lblUserLogin)
			Me.pnlLoggedInUser.Location = New Global.System.Drawing.Point(17, 110)
			Me.pnlLoggedInUser.Name = "pnlLoggedInUser"
			Me.pnlLoggedInUser.Size = New Global.System.Drawing.Size(165, 39)
			Me.pnlLoggedInUser.TabIndex = 4
			Me.lblUserLogin.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.lblUserLogin.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.lblUserLogin.Font = New Global.System.Drawing.Font("Nirmala UI", 12.0F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblUserLogin.ForeColor = Global.System.Drawing.Color.FromArgb(0, 125, 250)
			Me.lblUserLogin.Location = New Global.System.Drawing.Point(0, 0)
			Me.lblUserLogin.Name = "lblUserLogin"
			Me.lblUserLogin.Size = New Global.System.Drawing.Size(165, 39)
			Me.lblUserLogin.TabIndex = 3
			Me.lblUserLogin.Text = "Please Login"
			Me.lblUserLogin.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblUserWelcome.AutoSize = True
			Me.lblUserWelcome.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblUserWelcome.ForeColor = Global.System.Drawing.Color.FromArgb(250, 125, 0)
			Me.lblUserWelcome.Location = New Global.System.Drawing.Point(67, 89)
			Me.lblUserWelcome.Name = "lblUserWelcome"
			Me.lblUserWelcome.Size = New Global.System.Drawing.Size(65, 17)
			Me.lblUserWelcome.TabIndex = 2
			Me.lblUserWelcome.Text = "Welcome"
			Me.picBoxUserInfoBorder.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			Me.picBoxUserInfoBorder.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.picBoxUserInfoBorder.Image = Global.v214.Properties.Resources.UserBorder_Grey
			Me.picBoxUserInfoBorder.Location = New Global.System.Drawing.Point(0, 0)
			Me.picBoxUserInfoBorder.Name = "picBoxUserInfoBorder"
			Me.picBoxUserInfoBorder.Size = New Global.System.Drawing.Size(200, 165)
			Me.picBoxUserInfoBorder.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.picBoxUserInfoBorder.TabIndex = 0
			Me.picBoxUserInfoBorder.TabStop = False
			Me.pnlInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.pnlInfo.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			Me.pnlInfo.Controls.Add(Me.picBoxSettingsWheel)
			Me.pnlInfo.Controls.Add(Me.lblConnectStatus)
			Me.pnlInfo.Controls.Add(Me.pnlUserResponse)
			Me.pnlInfo.Controls.Add(Me.pnlProgMsg)
			Me.pnlInfo.Controls.Add(Me.pnlNews)
			Me.pnlInfo.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.pnlInfo.Location = New Global.System.Drawing.Point(200, 0)
			Me.pnlInfo.Name = "pnlInfo"
			Me.pnlInfo.Padding = New Global.System.Windows.Forms.Padding(50, 50, 50, 25)
			Me.pnlInfo.Size = New Global.System.Drawing.Size(550, 550)
			Me.pnlInfo.TabIndex = 1
			Me.picBoxSettingsWheel.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Center
			Me.picBoxSettingsWheel.Image = Global.v214.Properties.Resources.SettingsWheel
			Me.picBoxSettingsWheel.Location = New Global.System.Drawing.Point(515, 0)
			Me.picBoxSettingsWheel.Name = "picBoxSettingsWheel"
			Me.picBoxSettingsWheel.Size = New Global.System.Drawing.Size(35, 35)
			Me.picBoxSettingsWheel.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.picBoxSettingsWheel.TabIndex = 2
			Me.picBoxSettingsWheel.TabStop = False
			AddHandler Me.picBoxSettingsWheel.Click, AddressOf Me.picBoxSettingsWheel_Click
			AddHandler Me.picBoxSettingsWheel.MouseDown, AddressOf Me.picBoxSettingsWheel_MouseDown
			AddHandler Me.picBoxSettingsWheel.MouseEnter, AddressOf Me.picBoxSettingsWheel_MouseEnter
			AddHandler Me.picBoxSettingsWheel.MouseLeave, AddressOf Me.picBoxSettingsWheel_MouseLeave
			AddHandler Me.picBoxSettingsWheel.MouseUp, AddressOf Me.picBoxSettingsWheel_MouseUp
			Me.lblConnectStatus.AutoSize = True
			Me.lblConnectStatus.Font = New Global.System.Drawing.Font("Nirmala UI", 12.0F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblConnectStatus.ForeColor = Global.System.Drawing.Color.FromArgb(250, 125, 0)
			Me.lblConnectStatus.Location = New Global.System.Drawing.Point(6, 9)
			Me.lblConnectStatus.Name = "lblConnectStatus"
			Me.lblConnectStatus.Size = New Global.System.Drawing.Size(152, 21)
			Me.lblConnectStatus.TabIndex = 0
			Me.lblConnectStatus.Text = "Connection Status:"
			Me.pnlUserResponse.BackColor = Global.System.Drawing.Color.Transparent
			Me.pnlUserResponse.Controls.Add(Me.pnlAboutUs)
			Me.pnlUserResponse.Controls.Add(Me.pnlLogin)
			Me.pnlUserResponse.Controls.Add(Me.pnlBlank)
			Me.pnlUserResponse.Controls.Add(Me.pnlRegister)
			Me.pnlUserResponse.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.pnlUserResponse.Location = New Global.System.Drawing.Point(50, 355)
			Me.pnlUserResponse.Name = "pnlUserResponse"
			Me.pnlUserResponse.Size = New Global.System.Drawing.Size(450, 127)
			Me.pnlUserResponse.TabIndex = 1
			Me.tmrCheckConnection.Interval = 5000

			Me.pnlAboutUs.BackColor = Global.System.Drawing.Color.FromArgb(80, 25, 40, 50)
			Me.pnlAboutUs.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.pnlAboutUs.Location = New Global.System.Drawing.Point(0, 0)
			Me.pnlAboutUs.Name = "pnlAboutUs"
			Me.pnlAboutUs.Size = New Global.System.Drawing.Size(450, 127)
			Me.pnlAboutUs.TabIndex = 1
			Me.pnlLogin.BackColor = Global.System.Drawing.Color.FromArgb(80, 25, 40, 50)
			Me.pnlLogin.Controls.Add(Me.tbLoginPassword)
			Me.pnlLogin.Controls.Add(Me.tbLoginUsername)
			Me.pnlLogin.Controls.Add(Me.lblPassword)
			Me.pnlLogin.Controls.Add(Me.lblUsername)
			Me.pnlLogin.Controls.Add(Me.btnLogin)
			Me.pnlLogin.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.pnlLogin.Location = New Global.System.Drawing.Point(0, 0)
			Me.pnlLogin.Name = "pnlLogin"
			Me.pnlLogin.Size = New Global.System.Drawing.Size(450, 127)
			Me.pnlLogin.TabIndex = 0
			Me.tbLoginPassword.Location = New Global.System.Drawing.Point(148, 66)
			Me.tbLoginPassword.Name = "tbLoginPassword"
			Me.tbLoginPassword.PasswordChar = "*"c
			Me.tbLoginPassword.Size = New Global.System.Drawing.Size(150, 20)
			Me.tbLoginPassword.TabIndex = 2
			Me.tbLoginUsername.Location = New Global.System.Drawing.Point(148, 24)
			Me.tbLoginUsername.Name = "tbLoginUsername"
			Me.tbLoginUsername.Size = New Global.System.Drawing.Size(150, 20)
			Me.tbLoginUsername.TabIndex = 1
			Me.lblPassword.AutoSize = True
			Me.lblPassword.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblPassword.ForeColor = Global.System.Drawing.Color.FromArgb(0, 125, 250)
			Me.lblPassword.Location = New Global.System.Drawing.Point(190, 46)
			Me.lblPassword.Name = "lblPassword"
			Me.lblPassword.Size = New Global.System.Drawing.Size(66, 17)
			Me.lblPassword.TabIndex = 99
			Me.lblPassword.Text = "Password"
			Me.lblUsername.AutoSize = True
			Me.lblUsername.BackColor = Global.System.Drawing.Color.FromArgb(80, 25, 40, 50)
			Me.lblUsername.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblUsername.ForeColor = Global.System.Drawing.Color.FromArgb(0, 125, 250)
			Me.lblUsername.Location = New Global.System.Drawing.Point(190, 4)
			Me.lblUsername.Name = "lblUsername"
			Me.lblUsername.Size = New Global.System.Drawing.Size(69, 17)
			Me.lblUsername.TabIndex = 99
			Me.lblUsername.Text = "Username"
			Me.btnLogin.BackColor = Global.System.Drawing.Color.FromArgb(25, 40, 50)
			Me.btnLogin.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.btnLogin.FlatAppearance.BorderSize = 0
			Me.btnLogin.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnLogin.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnLogin.ForeColor = Global.System.Drawing.Color.FromArgb(0, 125, 250)
			Me.btnLogin.Location = New Global.System.Drawing.Point(0, 101)
			Me.btnLogin.Margin = New Global.System.Windows.Forms.Padding(0)
			Me.btnLogin.Name = "btnLogin"
			Me.btnLogin.Size = New Global.System.Drawing.Size(450, 26)
			Me.btnLogin.TabIndex = 3
			Me.btnLogin.Text = "Login"
			Me.btnLogin.UseVisualStyleBackColor = False
			AddHandler Me.btnLogin.Click, AddressOf Me.btnLogin_Click
			Me.pnlBlank.BackColor = Global.System.Drawing.Color.FromArgb(80, 25, 40, 50)
			Me.pnlBlank.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.pnlBlank.Location = New Global.System.Drawing.Point(0, 0)
			Me.pnlBlank.Name = "pnlBlank"
			Me.pnlBlank.Size = New Global.System.Drawing.Size(450, 127)
			Me.pnlBlank.TabIndex = 3
			Me.pnlRegister.BackColor = Global.System.Drawing.Color.FromArgb(80, 25, 40, 50)
			Me.pnlRegister.Controls.Add(Me.lblRegEMail)
			Me.pnlRegister.Controls.Add(Me.lblRegREPassword)
			Me.pnlRegister.Controls.Add(Me.tbRegREPassword)
			Me.pnlRegister.Controls.Add(Me.tbRegPassword)
			Me.pnlRegister.Controls.Add(Me.tbRegEMail)
			Me.pnlRegister.Controls.Add(Me.tbRegUsername)
			Me.pnlRegister.Controls.Add(Me.lblRegPassword)
			Me.pnlRegister.Controls.Add(Me.lblRegUsername)
			Me.pnlRegister.Controls.Add(Me.btnRegister)
			Me.pnlRegister.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.pnlRegister.Location = New Global.System.Drawing.Point(0, 0)
			Me.pnlRegister.Name = "pnlRegister"
			Me.pnlRegister.Size = New Global.System.Drawing.Size(450, 127)
			Me.pnlRegister.TabIndex = 1
			Me.lblRegEMail.AutoSize = True
			Me.lblRegEMail.BackColor = Global.System.Drawing.Color.FromArgb(80, 25, 40, 50)
			Me.lblRegEMail.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRegEMail.ForeColor = Global.System.Drawing.Color.FromArgb(0, 125, 250)
			Me.lblRegEMail.Location = New Global.System.Drawing.Point(57, 73)
			Me.lblRegEMail.Name = "lblRegEMail"
			Me.lblRegEMail.Size = New Global.System.Drawing.Size(47, 17)
			Me.lblRegEMail.TabIndex = 99
			Me.lblRegEMail.Text = "E-Mail"
			Me.lblRegREPassword.AutoSize = True
			Me.lblRegREPassword.BackColor = Global.System.Drawing.Color.FromArgb(80, 25, 40, 50)
			Me.lblRegREPassword.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRegREPassword.ForeColor = Global.System.Drawing.Color.FromArgb(0, 125, 250)
			Me.lblRegREPassword.Location = New Global.System.Drawing.Point(57, 50)
			Me.lblRegREPassword.Name = "lblRegREPassword"
			Me.lblRegREPassword.Size = New Global.System.Drawing.Size(122, 17)
			Me.lblRegREPassword.TabIndex = 99
			Me.lblRegREPassword.Text = "Re-Enter Password"
			Me.tbRegREPassword.Location = New Global.System.Drawing.Point(220, 50)
			Me.tbRegREPassword.Name = "tbRegREPassword"
			Me.tbRegREPassword.PasswordChar = "*"c
			Me.tbRegREPassword.Size = New Global.System.Drawing.Size(162, 20)
			Me.tbRegREPassword.TabIndex = 3
			Me.tbRegPassword.Location = New Global.System.Drawing.Point(220, 27)
			Me.tbRegPassword.Name = "tbRegPassword"
			Me.tbRegPassword.PasswordChar = "*"c
			Me.tbRegPassword.Size = New Global.System.Drawing.Size(162, 20)
			Me.tbRegPassword.TabIndex = 2
			Me.tbRegEMail.Location = New Global.System.Drawing.Point(220, 73)
			Me.tbRegEMail.Name = "tbRegEMail"
			Me.tbRegEMail.Size = New Global.System.Drawing.Size(162, 20)
			Me.tbRegEMail.TabIndex = 4
			Me.tbRegUsername.Location = New Global.System.Drawing.Point(220, 4)
			Me.tbRegUsername.Name = "tbRegUsername"
			Me.tbRegUsername.Size = New Global.System.Drawing.Size(162, 20)
			Me.tbRegUsername.TabIndex = 1
			Me.lblRegPassword.AutoSize = True
			Me.lblRegPassword.BackColor = Global.System.Drawing.Color.FromArgb(80, 25, 40, 50)
			Me.lblRegPassword.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRegPassword.ForeColor = Global.System.Drawing.Color.FromArgb(0, 125, 250)
			Me.lblRegPassword.Location = New Global.System.Drawing.Point(57, 27)
			Me.lblRegPassword.Name = "lblRegPassword"
			Me.lblRegPassword.Size = New Global.System.Drawing.Size(66, 17)
			Me.lblRegPassword.TabIndex = 99
			Me.lblRegPassword.Text = "Password"
			Me.lblRegUsername.AutoSize = True
			Me.lblRegUsername.BackColor = Global.System.Drawing.Color.FromArgb(80, 25, 40, 50)
			Me.lblRegUsername.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.lblRegUsername.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRegUsername.ForeColor = Global.System.Drawing.Color.FromArgb(0, 125, 250)
			Me.lblRegUsername.Location = New Global.System.Drawing.Point(57, 4)
			Me.lblRegUsername.Name = "lblRegUsername"
			Me.lblRegUsername.Size = New Global.System.Drawing.Size(69, 17)
			Me.lblRegUsername.TabIndex = 99
			Me.lblRegUsername.Text = "Username"
			Me.btnRegister.BackColor = Global.System.Drawing.Color.FromArgb(25, 40, 50)
			Me.btnRegister.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.btnRegister.FlatAppearance.BorderSize = 0
			Me.btnRegister.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnRegister.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnRegister.ForeColor = Global.System.Drawing.Color.FromArgb(0, 125, 250)
			Me.btnRegister.Location = New Global.System.Drawing.Point(0, 101)
			Me.btnRegister.Margin = New Global.System.Windows.Forms.Padding(0)
			Me.btnRegister.Name = "btnRegister"
			Me.btnRegister.Size = New Global.System.Drawing.Size(450, 26)
			Me.btnRegister.TabIndex = 5
			Me.btnRegister.Text = "Register"
			Me.btnRegister.UseVisualStyleBackColor = False
			AddHandler Me.btnRegister.Click, AddressOf Me.btnRegister_Click
			Me.pnlProgMsg.BackColor = Global.System.Drawing.Color.FromArgb(80, 25, 40, 50)
			Me.pnlProgMsg.Controls.Add(Me.picBoxLoading)
			Me.pnlProgMsg.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.pnlProgMsg.Location = New Global.System.Drawing.Point(50, 482)
			Me.pnlProgMsg.Name = "pnlProgMsg"
			Me.pnlProgMsg.Padding = New Global.System.Windows.Forms.Padding(5)
			Me.pnlProgMsg.Size = New Global.System.Drawing.Size(450, 43)
			Me.pnlProgMsg.TabIndex = 1
			Me.picBoxLoading.BackColor = Global.System.Drawing.Color.Transparent
			Me.picBoxLoading.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			Me.picBoxLoading.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.picBoxLoading.Location = New Global.System.Drawing.Point(5, 5)
			Me.picBoxLoading.Name = "picBoxLoading"
			Me.picBoxLoading.Size = New Global.System.Drawing.Size(440, 33)
			Me.picBoxLoading.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.CenterImage
			Me.picBoxLoading.TabIndex = 0
			Me.picBoxLoading.TabStop = False
			Me.pnlNews.BackColor = Global.System.Drawing.Color.FromArgb(80, 25, 40, 50)
			Me.pnlNews.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.pnlNews.Location = New Global.System.Drawing.Point(50, 50)
			Me.pnlNews.Name = "pnlNews"
			Me.pnlNews.Size = New Global.System.Drawing.Size(450, 299)
			Me.pnlNews.TabIndex = 0
			Me.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me.BackgroundImage = Global.v214.Properties.Resources.Arena_Background
			Me.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Name = "LauncherUI"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			AddHandler MyBase.Load, AddressOf Me.LauncherUI_Load
			Me.pnlControl.ResumeLayout(False)
			Me.pnlMenuUserInfo.ResumeLayout(False)
			Me.pnlMenuUserInfo.PerformLayout()
			CType(Me.picBoxOverUser, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlLoggedInUser.ResumeLayout(False)
			CType(Me.picBoxUserInfoBorder, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlInfo.ResumeLayout(False)
			Me.pnlInfo.PerformLayout()
			CType(Me.picBoxSettingsWheel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlUserResponse.ResumeLayout(False)
			Me.pnlLogin.ResumeLayout(False)
			Me.pnlLogin.PerformLayout()
			Me.pnlRegister.ResumeLayout(False)
			Me.pnlRegister.PerformLayout()
			Me.pnlProgMsg.ResumeLayout(False)
			CType(Me.picBoxLoading, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000019 RID: 25
		Private components As Global.System.ComponentModel.IContainer

		' Token: 0x0400001A RID: 26
		Private pnlControl As Global.System.Windows.Forms.Panel

		' Token: 0x0400001B RID: 27
		Private btnMenuLogin As Global.System.Windows.Forms.Button

		' Token: 0x0400001C RID: 28
		Private pnlMenuUserInfo As Global.System.Windows.Forms.Panel

		' Token: 0x0400001D RID: 29
		Private btnMenuExit As Global.System.Windows.Forms.Button

		' Token: 0x0400001E RID: 30
		Private btnMenuAboutUs As Global.System.Windows.Forms.Button

		' Token: 0x0400001F RID: 31
		Private btnMenuDonate As Global.System.Windows.Forms.Button

		' Token: 0x04000020 RID: 32
		Private btnMenuRegister As Global.System.Windows.Forms.Button

		' Token: 0x04000021 RID: 33
		Private pnlInfo As Global.System.Windows.Forms.Panel

		' Token: 0x04000022 RID: 34
		Private pnlNews As Global.RoundPanel

		' Token: 0x04000023 RID: 35
		Private pnlProgMsg As Global.RoundPanel

		' Token: 0x04000024 RID: 36
		Private pnlUserResponse As Global.System.Windows.Forms.Panel

		' Token: 0x04000025 RID: 37
		Private pnlLogin As Global.RoundPanel

		' Token: 0x04000026 RID: 38
		Private pnlRegister As Global.RoundPanel

		' Token: 0x04000027 RID: 39
		Private pnlAboutUs As Global.RoundPanel

		' Token: 0x04000028 RID: 40
		Private btnLogin As Global.RoundButton

		' Token: 0x04000029 RID: 41
		Private btnMenuGameStart As Global.System.Windows.Forms.Button

		' Token: 0x0400002A RID: 42
		Private tbLoginPassword As Global.System.Windows.Forms.TextBox

		' Token: 0x0400002B RID: 43
		Private tbLoginUsername As Global.System.Windows.Forms.TextBox

		' Token: 0x0400002C RID: 44
		Private lblPassword As Global.System.Windows.Forms.Label

		' Token: 0x0400002D RID: 45
		Private lblUsername As Global.System.Windows.Forms.Label

		' Token: 0x0400002E RID: 46
		Private tbRegREPassword As Global.System.Windows.Forms.TextBox

		' Token: 0x0400002F RID: 47
		Private tbRegPassword As Global.System.Windows.Forms.TextBox

		' Token: 0x04000030 RID: 48
		Private tbRegEMail As Global.System.Windows.Forms.TextBox

		' Token: 0x04000031 RID: 49
		Private tbRegUsername As Global.System.Windows.Forms.TextBox

		' Token: 0x04000032 RID: 50
		Private lblRegPassword As Global.System.Windows.Forms.Label

		' Token: 0x04000033 RID: 51
		Private lblRegUsername As Global.System.Windows.Forms.Label

		' Token: 0x04000034 RID: 52
		Private btnRegister As Global.RoundButton

		' Token: 0x04000035 RID: 53
		Private lblRegEMail As Global.System.Windows.Forms.Label

		' Token: 0x04000036 RID: 54
		Private lblRegREPassword As Global.System.Windows.Forms.Label

		' Token: 0x04000037 RID: 55
		Private pnlBlank As Global.RoundPanel

		' Token: 0x04000038 RID: 56
		Private lblConnectStatus As Global.System.Windows.Forms.Label

		' Token: 0x04000039 RID: 57
		Private tmrCheckConnection As Global.System.Windows.Forms.Timer

		' Token: 0x0400003A RID: 58
		Private picBoxUserInfoBorder As Global.System.Windows.Forms.PictureBox

		' Token: 0x0400003B RID: 59
		Private picBoxLoading As Global.System.Windows.Forms.PictureBox

		' Token: 0x0400003C RID: 60
		Private lblUserWelcome As Global.System.Windows.Forms.Label

		' Token: 0x0400003D RID: 61
		Private lblUserLogin As Global.System.Windows.Forms.Label

		' Token: 0x0400003E RID: 62
		Private pnlLoggedInUser As Global.System.Windows.Forms.Panel

		' Token: 0x0400003F RID: 63
		Private picBoxOverUser As Global.System.Windows.Forms.PictureBox

		' Token: 0x04000040 RID: 64
		Private picBoxSettingsWheel As Global.System.Windows.Forms.PictureBox
	End Class
End Namespace
