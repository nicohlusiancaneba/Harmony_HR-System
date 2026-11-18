Imports System.Deployment.Application
Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions

Public Class FrmLOGIN

    Private Sub FrmLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CardPanel(panel_login, 8, 5)
        ThemeHelper.ApplyHighlight(Me)



        txt_username.Text = ""
        txt_password.Text = ""

        txt_username.Select()
    End Sub


    Private Sub pb_loginPic_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Login()

        
    End Sub


    Private Sub txt_userName_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_username.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Login()
        End If
    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Login()
        End If
    End Sub


    Private Sub Login()
        On Error Resume Next

        'check Login Credentials
        sqlSTR = "select * from users where username = '" & txt_username.Text & "' AND password ='" & txt_password.Text & "'"
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count = 1 Then
            xUsername = txt_username.Text
            xPassword = txt_password.Text
            With Main

                .mainLeft_Panel.Visible = True
                .mainPanel.Visible = True

                .lbl_username.Text = UcFirst(xUsername)
                .lbl_access.Text = sqlDT.Rows(0)("User_Access").ToString

                If sqlDT.Rows(0)("User_Image") IsNot DBNull.Value Then
                    Dim img As Image = Nothing
                    Dim imgBytes() As Byte = CType(sqlDT.Rows(0)("User_Image"), Byte())
                    Using ms As New MemoryStream(imgBytes)
                        img = Image.FromStream(ms)
                    End Using



                    .pic_User.Image = img

                End If

                SetCircularPictureBox(Main.pic_User)

                
            End With

            
                Main.cmd_dashboard_Click(Main.cmd_dashboard, EventArgs.Empty)


        Else
            MsgBox("Invalid Username or Password.")
            With Main
                .panel_topbar.Visible = False
                .mainLeft_Panel.Visible = False
            End With
            Exit Sub
        End If

        sqlSTR = "select Business_Name from Global_Data"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            business_name = sqlDT.Rows(0)("Business_Name").ToString
        End If

        Me.Close()






    End Sub




    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Application.Exit()
    End Sub


    ' ---------- Username: letters and underscore only ----------
    Private Sub txt_userName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_username.KeyPress
        ' allow control keys (Backspace, Ctrl+C, etc.)
        If Char.IsControl(e.KeyChar) Then Exit Sub

        If Not Regex.IsMatch(e.KeyChar.ToString(), "^[A-Za-z_]$") Then
            e.Handled = True   ' block the character
        End If
    End Sub

    Private Sub txt_userName_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged
        ' handles paste: remove anything not allowed
        txt_username.Text = txt_username.Text.ToLower()
        Dim cleaned As String = Regex.Replace(txt_userName.Text, "[^A-Za-z_]", "")
        If cleaned <> txt_userName.Text Then
            Dim pos As Integer = txt_userName.SelectionStart - (txt_userName.Text.Length - cleaned.Length)
            txt_userName.Text = cleaned
            txt_userName.SelectionStart = Math.Max(pos, 0)
        End If
    End Sub

    ' ---------- Password: no apostrophe and no comma ----------
    Private Sub txt_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_password.KeyPress
        If Char.IsControl(e.KeyChar) Then Exit Sub

        If Regex.IsMatch(e.KeyChar.ToString(), "^['',]$") Then
            e.Handled = True   ' block the character
        End If
    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged
        ' handles paste: remove apostrophe and comma
        Dim cleaned As String = Regex.Replace(txt_password.Text, "[',]", "")
        If cleaned <> txt_password.Text Then
            Dim pos As Integer = txt_password.SelectionStart - (txt_password.Text.Length - cleaned.Length)
            txt_password.Text = cleaned
            txt_password.SelectionStart = Math.Max(pos, 0)
        End If
    End Sub


    Private Sub SetCircularPictureBox(picBox As PictureBox)
        picBox.Size = New Size(50, 50)
        picBox.SizeMode = PictureBoxSizeMode.StretchImage

        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, picBox.Width - 1, picBox.Height - 1)

        picBox.Region = New Region(path)
    End Sub
End Class