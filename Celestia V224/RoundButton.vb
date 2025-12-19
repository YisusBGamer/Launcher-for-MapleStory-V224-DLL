Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

' Token: 0x02000003 RID: 3
Public Class RoundButton
	Inherits Button

	' Token: 0x06000003 RID: 3 RVA: 0x0000218C File Offset: 0x0000038C
	Protected Overrides Sub OnPaint(e As PaintEventArgs)
		MyBase.OnPaint(e)
		Dim graphicsPath As GraphicsPath = New GraphicsPath()
		Dim rectangle As Rectangle = New Rectangle(0, 0, MyBase.Width, MyBase.Height)
		Dim num As Integer = 7
		graphicsPath.AddArc(rectangle.X, rectangle.Y, num * 2, num * 2, 180F, 90F)
		graphicsPath.AddArc(rectangle.Width - 2 * num, rectangle.Y, num * 2, num * 2, 270F, 90F)
		graphicsPath.AddArc(rectangle.Width - 2 * num, rectangle.Height - 2 * num, num * 2, num * 2, 0F, 90F)
		graphicsPath.AddArc(rectangle.X, rectangle.Height - 2 * num, num * 2, num * 2, 90F, 90F)
		graphicsPath.CloseFigure()
		MyBase.Region = New Region(graphicsPath)
		Using pen As Pen = New Pen(Me.BoarderColor, 2F)
			e.Graphics.DrawPath(pen, graphicsPath)
		End Using
	End Sub

	' Token: 0x04000002 RID: 2
	Private BoarderColor As Color = Color.FromArgb(25, 40, 50)
End Class
