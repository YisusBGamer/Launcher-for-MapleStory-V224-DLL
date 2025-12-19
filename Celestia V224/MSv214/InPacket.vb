Imports System
Imports System.Text

Namespace MSv214
	' Token: 0x0200000F RID: 15
	Public Class InPacket
		' Token: 0x0600009A RID: 154 RVA: 0x00006608 File Offset: 0x00004808
		Public Function readByte() As Byte
			Dim b As Byte = Me.bufData(Me.readPtr)
			Me.readPtr += 1
			Return b
		End Function

		' Token: 0x0600009B RID: 155 RVA: 0x00006628 File Offset: 0x00004828
		Public Function readBytes(len As Integer) As Byte()
			Dim array As Byte() = New Byte(len - 1) {}
			For i As Integer = 0 To len - 1
				Dim array2 As Byte() = array
				Dim num As Integer = i
				Dim array3 As Byte() = Me.bufData
				Dim num2 As Integer = Me.readPtr
				Me.readPtr = num2 + 1
				array2(num) = array3(num2)
			Next
			Return array
		End Function

		' Token: 0x0600009C RID: 156 RVA: 0x00006664 File Offset: 0x00004864
		Public Function readShort() As Short
			Dim num As Short = CShort((CInt(Me.bufData(Me.readPtr)) + (CInt(Me.bufData(Me.readPtr + 1)) << 8)))
			Me.readPtr += 2
			Return num
		End Function

		' Token: 0x0600009D RID: 157 RVA: 0x00006698 File Offset: 0x00004898
		Public Function readInt() As Integer
			Dim result As Integer = CInt(Me.bufData(Me.readPtr)) + (CInt(Me.bufData(Me.readPtr + 1)) << 8) + (CInt(Me.bufData(Me.readPtr + 2)) << 16) + (CInt(Me.bufData(Me.readPtr + 3)) << 24)
			Me.readPtr += 4
			Return result
		End Function

		' Token: 0x0600009E RID: 158 RVA: 0x000066F8 File Offset: 0x000048F8
		Public Function readString() As String
			Dim count As Short = Me.readShort()
			Console.WriteLine("Len = " + count.ToString())
			Return Encoding.ASCII.GetString(Me.readBytes(CInt(count)), 0, CInt(count))
		End Function

		' Token: 0x04000062 RID: 98
		Public buf As Byte() = New Byte(255) {}

		' Token: 0x04000063 RID: 99
		Public bufData As Byte() = New Byte(255) {}

		' Token: 0x04000064 RID: 100
		Public lenBuf As Byte() = New Byte(3) {}

		' Token: 0x04000065 RID: 101
		Public len As Integer = -1

		' Token: 0x04000066 RID: 102
		Public Const BufferSize As Integer = 256

		' Token: 0x04000067 RID: 103
		Public curLen As Integer

		' Token: 0x04000068 RID: 104
		Public lenBufPtr As Integer

		' Token: 0x04000069 RID: 105
		Public readPtr As Integer
	End Class
End Namespace
