Imports System
Imports System.Text

Namespace MSv214
	' Token: 0x02000010 RID: 16
	Public Class OutPacket
		' Token: 0x060000A0 RID: 160 RVA: 0x00006770 File Offset: 0x00004970
		Public Sub New(op As Short)
			Me.WriteShort(op)
		End Sub

		' Token: 0x060000A1 RID: 161 RVA: 0x0000678F File Offset: 0x0000498F
		Public Sub WriteShort(s As Short)
			Me.Write(New Byte() { CByte(s), CByte((CUInt(s) >> 8)) })
		End Sub

		' Token: 0x060000A2 RID: 162 RVA: 0x000067A9 File Offset: 0x000049A9
		Public Sub WriteByte(b As Byte)
			Me.Write(New Byte() { b })
		End Sub

		' Token: 0x060000A3 RID: 163 RVA: 0x000067BB File Offset: 0x000049BB
		Public Sub WriteInt(i As Integer)
			Me.Write(New Byte() { CByte(i), CByte((i >> 8)), CByte((i >> 16)), CByte((i >> 24)) })
		End Sub

		' Token: 0x060000A4 RID: 164 RVA: 0x000067E5 File Offset: 0x000049E5
		Public Sub WriteString(str As String)
			Me.WriteShort(CShort(str.Length))
			Me.Write(Encoding.ASCII.GetBytes(str))
		End Sub

		' Token: 0x060000A5 RID: 165 RVA: 0x00006808 File Offset: 0x00004A08
		Public Sub Write(data As Byte())
			Dim num As Integer = Me.len
			For Each b As Byte In data
				Me.buf(num) = b
				num += 1
			Next
			Me.len = num
		End Sub

		' Token: 0x0400006A RID: 106
		Public buf As Byte() = New Byte(255) {}

		' Token: 0x0400006B RID: 107
		Public len As Integer
	End Class
End Namespace
