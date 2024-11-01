Imports System.Text

Public Class Form1

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
        Dim passwordLength As Integer = CInt(NumericUpDown1.Value)
        Dim useUpperCase As Boolean = CheckBoxUpperCase.Checked
        Dim useLowerCase As Boolean = CheckBoxLowerCase.Checked
        Dim useNumbers As Boolean = CheckBoxNumbers.Checked
        Dim useSpecialChars As Boolean = CheckBoxSpecialChars.Checked

        If Not (useUpperCase Or useLowerCase Or useNumbers Or useSpecialChars) Then
            MessageBox.Show("Выберите хотя бы один тип символа для генерации пароля.")
            Return
        End If

        Dim generatedPassword As String = GeneratePassword(passwordLength, useUpperCase, useLowerCase, useNumbers, useSpecialChars)
        TextBoxPassword.Text = generatedPassword
    End Sub

    Private Function GeneratePassword(length As Integer, upper As Boolean, lower As Boolean, numbers As Boolean, special As Boolean) As String
        Dim allowedChars As New StringBuilder()

        If upper Then allowedChars.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ")
        If lower Then allowedChars.Append("abcdefghijklmnopqrstuvwxyz")
        If numbers Then allowedChars.Append("0123456789")
        If special Then allowedChars.Append("!@#$%^&*()-_=+[]{}|;:,.<>?")

        Dim rand As New Random()
        Dim password As String = ""

        For i As Integer = 1 To length
            Dim index As Integer = rand.Next(0, allowedChars.Length)
            password &= allowedChars(index)
        Next

        Return password
    End Function

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        Clipboard.SetText(TextBoxPassword.Text)
        MessageBox.Show("Пароль скопирован в буфер обмена.")
    End Sub
End Class