﻿Public Class Form_LOGIN

    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
       

        On Error Resume Next
        Dim timex As String
        'If e.KeyCode = 13 Then
        If Not checkServer() Then
            FormSERVER_SETTINGS.ShowDialog()
            Exit Sub
        End If

        'check Login Credentials
        sqlSTR = "select * from users where username = '" & txtuser.Text & "' AND password ='" & txtpassword.Text & "'"
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            'sqlSTR = "In"
            xUsername = txtuser.Text
            xPassword = txtpassword.Text
            MDIMain.Enabled = True

            Me.Close()
        Else
            MsgBox("Invalid Username or Password.")
            Exit Sub
        End If

    End Sub

    Private Sub cmdserver_Click(sender As Object, e As EventArgs) Handles cmdserver.Click
        FormSERVER_SETTINGS.ShowDialog()
    End Sub

    Private Sub cmdclose_Click(sender As Object, e As EventArgs) Handles cmdclose.Click
        If MsgBox("Are you sure want to exit system?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub
End Class