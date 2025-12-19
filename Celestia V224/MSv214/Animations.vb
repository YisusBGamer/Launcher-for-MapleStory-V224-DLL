Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports v214.Properties

Namespace MSv214
	' Token: 0x02000008 RID: 8
	Public Class Animations
		' Token: 0x0600004E RID: 78 RVA: 0x00005042 File Offset: 0x00003242
		Public Sub New(pictureBox As PictureBox, sprite As String)
			Me.pictureBox = pictureBox
			Me.sprite = sprite
		End Sub

		' Token: 0x0600004F RID: 79 RVA: 0x0000506E File Offset: 0x0000326E
		Public Sub New(button As Button, sprite As String)
			Me.button = button
			Me.sprite = sprite
		End Sub

		' Token: 0x06000050 RID: 80 RVA: 0x0000509C File Offset: 0x0000329C
		Public Sub LoadSprites(totalFrames As Integer)
			Me.spriteFrames.Clear()
			For i As Integer = 1 To totalFrames
				Dim name As String = String.Format("{0}_{1}", Me.sprite, i)
				Dim image As Image = CType(Resources.ResourceManager.GetObject(name), Image)
				If image IsNot Nothing Then
					Me.spriteFrames.Add(image)
				End If
			Next
		End Sub

		' Token: 0x06000051 RID: 81 RVA: 0x000050F7 File Offset: 0x000032F7
		Public Sub StartAnimationPB(frameRate As Integer)
			Me.animationTimer.Interval = frameRate
			AddHandler Me.animationTimer.Tick, AddressOf Me.AnimationTimer_Tick_PB
			Me.animationTimer.Start()
		End Sub

		' Token: 0x06000052 RID: 82 RVA: 0x00005127 File Offset: 0x00003327
		Public Sub StartAnimationBTN(frameRate As Integer)
			Me.animationTimer.Interval = frameRate
			AddHandler Me.animationTimer.Tick, AddressOf Me.AnimationTimer_Tick_BTN
			Me.animationTimer.Start()
		End Sub

		' Token: 0x06000053 RID: 83 RVA: 0x00005157 File Offset: 0x00003357
		Private Sub AnimationTimer_Tick_PB(sender As Object, e As EventArgs)
			Me.pictureBox.Image = Me.spriteFrames(Me.currentFrame)
			Me.currentFrame = (Me.currentFrame + 1) Mod Me.spriteFrames.Count
		End Sub

		' Token: 0x06000054 RID: 84 RVA: 0x0000518F File Offset: 0x0000338F
		Private Sub AnimationTimer_Tick_BTN(sender As Object, e As EventArgs)
			Me.button.Image = Me.spriteFrames(Me.currentFrame)
			Me.currentFrame = (Me.currentFrame + 1) Mod Me.spriteFrames.Count
		End Sub

		' Token: 0x06000055 RID: 85 RVA: 0x000051C7 File Offset: 0x000033C7
		Public Sub StopAnimationPB()
			Me.animationTimer.[Stop]()
			Me.pictureBox.Image = Nothing
		End Sub

		' Token: 0x06000056 RID: 86 RVA: 0x000051E0 File Offset: 0x000033E0
		Public Sub StopAnimationBTN()
			Me.animationTimer.[Stop]()
			Me.button.Image = Nothing
		End Sub

		' Token: 0x04000041 RID: 65
		Private spriteFrames As List(Of Image) = New List(Of Image)()

		' Token: 0x04000042 RID: 66
		Private currentFrame As Integer

		' Token: 0x04000043 RID: 67
		Private sprite As String

		' Token: 0x04000044 RID: 68
		Private animationTimer As Timer = New Timer()

		' Token: 0x04000045 RID: 69
		Private pictureBox As PictureBox

		' Token: 0x04000046 RID: 70
		Private button As Button
	End Class
End Namespace
