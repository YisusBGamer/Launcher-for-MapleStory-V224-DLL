Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices

Namespace v214.Properties
	' Token: 0x02000004 RID: 4
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")>
	<DebuggerNonUserCode()>
	<CompilerGenerated()>
	Friend Class Resources
		' Token: 0x06000005 RID: 5 RVA: 0x000022C5 File Offset: 0x000004C5
		Friend Sub New()
		End Sub

		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000006 RID: 6 RVA: 0x000022CD File Offset: 0x000004CD
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Shared ReadOnly Property ResourceManager As ResourceManager
			Get
				If Resources.resourceMan Is Nothing Then
					Resources.resourceMan = New ResourceManager("v214.Properties.Resources", GetType(Resources).Assembly)
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000007 RID: 7 RVA: 0x000022F9 File Offset: 0x000004F9
		' (set) Token: 0x06000008 RID: 8 RVA: 0x00002300 File Offset: 0x00000500
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Shared Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000009 RID: 9 RVA: 0x00002308 File Offset: 0x00000508
		Friend Shared ReadOnly Property Arena_Background As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("Arena_Background", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x0600000A RID: 10 RVA: 0x00002323 File Offset: 0x00000523
		Friend Shared ReadOnly Property GameStart_1 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("GameStart_1", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000B RID: 11 RVA: 0x0000233E File Offset: 0x0000053E
		Friend Shared ReadOnly Property GameStart_2 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("GameStart_2", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000006 RID: 6
		' (get) Token: 0x0600000C RID: 12 RVA: 0x00002359 File Offset: 0x00000559
		Friend Shared ReadOnly Property GameStart_3 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("GameStart_3", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000007 RID: 7
		' (get) Token: 0x0600000D RID: 13 RVA: 0x00002374 File Offset: 0x00000574
		Friend Shared ReadOnly Property GameStart_Grey As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("GameStart_Grey", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000008 RID: 8
		' (get) Token: 0x0600000E RID: 14 RVA: 0x0000238F File Offset: 0x0000058F
		Friend Shared ReadOnly Property Loading_1 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("Loading_1", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000009 RID: 9
		' (get) Token: 0x0600000F RID: 15 RVA: 0x000023AA File Offset: 0x000005AA
		Friend Shared ReadOnly Property Loading_2 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("Loading_2", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x1700000A RID: 10
		' (get) Token: 0x06000010 RID: 16 RVA: 0x000023C5 File Offset: 0x000005C5
		Friend Shared ReadOnly Property Loading_3 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("Loading_3", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x1700000B RID: 11
		' (get) Token: 0x06000011 RID: 17 RVA: 0x000023E0 File Offset: 0x000005E0
		Friend Shared ReadOnly Property Loading_4 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("Loading_4", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x1700000C RID: 12
		' (get) Token: 0x06000012 RID: 18 RVA: 0x000023FB File Offset: 0x000005FB
		Friend Shared ReadOnly Property Loading_5 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("Loading_5", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x1700000D RID: 13
		' (get) Token: 0x06000013 RID: 19 RVA: 0x00002416 File Offset: 0x00000616
		Friend Shared ReadOnly Property OverUser_1 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("OverUser_1", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x1700000E RID: 14
		' (get) Token: 0x06000014 RID: 20 RVA: 0x00002431 File Offset: 0x00000631
		Friend Shared ReadOnly Property OverUser_2 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("OverUser_2", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x06000015 RID: 21 RVA: 0x0000244C File Offset: 0x0000064C
		Friend Shared ReadOnly Property OverUser_3 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("OverUser_3", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000010 RID: 16
		' (get) Token: 0x06000016 RID: 22 RVA: 0x00002467 File Offset: 0x00000667
		Friend Shared ReadOnly Property OverUser_4 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("OverUser_4", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000011 RID: 17
		' (get) Token: 0x06000017 RID: 23 RVA: 0x00002482 File Offset: 0x00000682
		Friend Shared ReadOnly Property OverUser_5 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("OverUser_5", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000012 RID: 18
		' (get) Token: 0x06000018 RID: 24 RVA: 0x0000249D File Offset: 0x0000069D
		Friend Shared ReadOnly Property OverUser_6 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("OverUser_6", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x06000019 RID: 25 RVA: 0x000024B8 File Offset: 0x000006B8
		Friend Shared ReadOnly Property SettingsWheel As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("SettingsWheel", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000014 RID: 20
		' (get) Token: 0x0600001A RID: 26 RVA: 0x000024D3 File Offset: 0x000006D3
		Friend Shared ReadOnly Property SettingsWheel_1 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("SettingsWheel_1", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000015 RID: 21
		' (get) Token: 0x0600001B RID: 27 RVA: 0x000024EE File Offset: 0x000006EE
		Friend Shared ReadOnly Property SettingsWheel_2 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("SettingsWheel_2", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000016 RID: 22
		' (get) Token: 0x0600001C RID: 28 RVA: 0x00002509 File Offset: 0x00000709
		Friend Shared ReadOnly Property SettingsWheel_3 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("SettingsWheel_3", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000017 RID: 23
		' (get) Token: 0x0600001D RID: 29 RVA: 0x00002524 File Offset: 0x00000724
		Friend Shared ReadOnly Property SettingsWheel_4 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("SettingsWheel_4", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000018 RID: 24
		' (get) Token: 0x0600001E RID: 30 RVA: 0x0000253F File Offset: 0x0000073F
		Friend Shared ReadOnly Property SettingsWheel_pressed As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("SettingsWheel_pressed", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000019 RID: 25
		' (get) Token: 0x0600001F RID: 31 RVA: 0x0000255A File Offset: 0x0000075A
		Friend Shared ReadOnly Property UpdateScript As String
			Get
				Return Resources.ResourceManager.GetString("UpdateScript", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x1700001A RID: 26
		' (get) Token: 0x06000020 RID: 32 RVA: 0x00002570 File Offset: 0x00000770
		Friend Shared ReadOnly Property UserBorder_1 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("UserBorder_1", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x1700001B RID: 27
		' (get) Token: 0x06000021 RID: 33 RVA: 0x0000258B File Offset: 0x0000078B
		Friend Shared ReadOnly Property UserBorder_2 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("UserBorder_2", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x1700001C RID: 28
		' (get) Token: 0x06000022 RID: 34 RVA: 0x000025A6 File Offset: 0x000007A6
		Friend Shared ReadOnly Property UserBorder_3 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("UserBorder_3", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x1700001D RID: 29
		' (get) Token: 0x06000023 RID: 35 RVA: 0x000025C1 File Offset: 0x000007C1
		Friend Shared ReadOnly Property UserBorder_4 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("UserBorder_4", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x1700001E RID: 30
		' (get) Token: 0x06000024 RID: 36 RVA: 0x000025DC File Offset: 0x000007DC
		Friend Shared ReadOnly Property UserBorder_5 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("UserBorder_5", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x1700001F RID: 31
		' (get) Token: 0x06000025 RID: 37 RVA: 0x000025F7 File Offset: 0x000007F7
		Friend Shared ReadOnly Property UserBorder_6 As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("UserBorder_6", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000020 RID: 32
		' (get) Token: 0x06000026 RID: 38 RVA: 0x00002612 File Offset: 0x00000812
		Friend Shared ReadOnly Property UserBorder_Grey As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("UserBorder_Grey", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x04000003 RID: 3
		Private Shared resourceMan As ResourceManager

		' Token: 0x04000004 RID: 4
		Private Shared resourceCulture As CultureInfo
	End Class
End Namespace
