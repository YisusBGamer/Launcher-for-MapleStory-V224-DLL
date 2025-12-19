Imports System
Imports System.Collections.Generic
Imports System.Net.Mail
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks

Namespace MSv214
	' Token: 0x0200000A RID: 10
	Public Class Register
		' Token: 0x06000066 RID: 102 RVA: 0x000058DC File Offset: 0x00003ADC
		Public Function HandleSignUpInput(inputs As Dictionary(Of Integer, String)) As Integer
			If inputs(1).Length < 6 OrElse inputs(1).Length > 18 OrElse Not Me.IsAlphaNumeric(inputs(1)) Then
				Return 1
			End If
			If inputs(2).Length < 6 OrElse inputs(2).Length > 18 OrElse Not Me.IsValidPassword(inputs(2)) Then
				Return 2
			End If
			If inputs(2) <> inputs(3) Then
				Return 3
			End If
			If inputs(4) Is Nothing OrElse inputs(4).Equals("") OrElse Not Me.IsValidEmail(inputs(4)) Then
				Return 10
			End If
			Dim num As Integer = 0
			For Each keyValuePair As KeyValuePair(Of Integer, String) In inputs
				If Not Me.IsSafeFromSqlInjection(keyValuePair.Value) Then
					Return 20 + num
				End If
				If keyValuePair.Key <> 3 Then
					num += 1
				End If
			Next
			Return 0
		End Function

		' Token: 0x06000067 RID: 103 RVA: 0x000059F4 File Offset: 0x00003BF4
		Private Function IsAlphaNumeric(input As String) As Boolean
			Return Regex.IsMatch(input, "^[a-zA-Z0-9]+$")
		End Function

		' Token: 0x06000068 RID: 104 RVA: 0x00005A01 File Offset: 0x00003C01
		Private Function IsValidPassword(input As String) As Boolean
			Return Regex.IsMatch(input, "^[a-zA-Z0-9!@#$%^&*()-_+=<>?]+$")
		End Function

		' Token: 0x06000069 RID: 105 RVA: 0x00005A10 File Offset: 0x00003C10
		Public Function IsValidEmail(emailaddress As String) As Boolean
			Dim result As Boolean
			Try
				If Not Regex.IsMatch(emailaddress, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$") Then
					result = False
				Else
					New MailAddress(emailaddress)
					result = True
				End If
			Catch ex As FormatException
				result = False
			End Try
			Return result
		End Function

		' Token: 0x0600006A RID: 106 RVA: 0x00005A50 File Offset: 0x00003C50
		Private Function IsSafeFromSqlInjection(input As String) As Boolean
			Dim text As String = input.ToLower()
			For Each value As String In New String() { "select", "update", "delete", "drop", "alter", "insert", "union", "exec" }
				If text.Contains(value) Then
					Return False
				End If
			Next
			If input.Contains(";") Then
				Return False
			End If
			For Each value2 As String In New String() { "--", "/*", "*/" }
				If input.Contains(value2) Then
					Return False
				End If
			Next
			Return True
		End Function

		' Token: 0x0600006B RID: 107 RVA: 0x00005B18 File Offset: 0x00003D18
		Public Function CreateAccount(inputs As Dictionary(Of Integer, String), mac As String, client As Client) As Task(Of Boolean)
			Dim <CreateAccount>d__ As Register.<CreateAccount>d__6
			<CreateAccount>d__.<>t__builder = AsyncTaskMethodBuilder(Of Boolean).Create()
			<CreateAccount>d__.inputs = inputs
			<CreateAccount>d__.mac = mac
			<CreateAccount>d__.client = client
			<CreateAccount>d__.<>1__state = -1
			<CreateAccount>d__.<>t__builder.Start(Of Register.<CreateAccount>d__6)(<CreateAccount>d__)
			Return <CreateAccount>d__.<>t__builder.Task
		End Function

		' Token: 0x0400004D RID: 77
		Public signUpInputMessages As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)() From { { 1, "Username must be Alpha Numeric and between 6 - 18 characters long." }, { 2, "Password must contain letters, numbers and special characters and be between 6 - 18 characters long." }, { 3, "Your passwords must match. Please try again." }, { 10, "Email is invalid." }, { 20, "Please use a differnet username." }, { 21, "Please use a differnet password." }, { 22, "Please use a differnet e-mail." } }
	End Class
End Namespace
