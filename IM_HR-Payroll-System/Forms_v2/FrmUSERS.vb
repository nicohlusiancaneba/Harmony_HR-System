Imports System.IO
Imports System.Text.RegularExpressions

Public Class FrmUSERS
    Dim User_ID As String
    Dim edit As Boolean
    Private Sub lbl_createdBy_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmUSERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeHelper.ApplyHighlight(Me)
        Refresh_List()


    End Sub

    Private Sub Refresh_List()
        sqlSTR = "select " & _
                "User_ID as ID, " & _
                "Username, " & _
                "'********' AS Password, " & _
                "User_Access as 'Access' " & _
                "from Users " & _
                "order by username;"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_users, -1)
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        pic_User.Image = Nothing
        center_RelativeTo(lst_users, grpUser)
        grpUser.Visible = True
        edit = False
        grpUser.Text = "Add User"

        txt_userName.Text = ""
        txt_password.Text = ""
        cmb_AccessType.SelectedIndex = 0


        txt_userName.Enabled = True

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        pic_User.Image = Nothing
        center_RelativeTo(lst_users, grpUser)
        grpUser.Visible = True
        edit = True
        grpUser.Text = "Edit User"


        User_ID = lst_users.FocusedItem.Text

        txt_userName.Enabled = False


        sqlSTR = "select * from Users where User_ID = '" & User_ID & "';"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count = 1 Then
            txt_userName.Text = sqlDT.Rows(0)("Username")
            txt_password.Text = sqlDT.Rows(0)("Password")
            cmb_AccessType.Text = sqlDT.Rows(0)("User_Access")

            If sqlDT.Rows(0)("User_Image") IsNot DBNull.Value Then
                Dim img As Image = Nothing
                Dim imgBytes() As Byte = CType(sqlDT.Rows(0)("User_Image"), Byte())
                Using ms As New MemoryStream(imgBytes)
                    img = Image.FromStream(ms)
                End Using

                pic_User.Image = img
            End If

        Else
            Me.Close()
        End If


        Picture_Status()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If txt_userName.Text = "" Then
            MsgBox("Username cannot be blank.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If txt_password.Text = "" Then
            MsgBox("Password cannot be blank.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Len(txt_userName.Text) < 3 Then
            MsgBox("Username must be {4} characters.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Len(txt_password.Text) < 6 Then
            MsgBox("Password must be {6} characters.", MsgBoxStyle.Information)
            Exit Sub
        End If


        txt_userName.Text = txt_userName.Text.ToLower()


        Dim imgBytes() As Byte = Nothing
        If pic_User.Image IsNot Nothing Then
            Using ms As New MemoryStream()
                pic_User.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                imgBytes = ms.ToArray()
            End Using
            pic_User.Tag = "?"
        Else
            pic_User.Tag = "null"
            MsgBox("User Image cannot be blank.", MsgBoxStyle.Information)
            Exit Sub
        End If




        If edit Then
            sqlSTR = "UPDATE Users " & _
             "SET " & _
             "Password = '" & txt_password.Text & "', " & _
             "User_Access = '" & cmb_AccessType.Text & "', " & _
             "User_Image = " & pic_User.Tag & " " & _
             "WHERE User_ID = '" & User_ID & "';"

        Else
            sqlSTR = "select username from users where username ='" & txt_userName.Text & "';"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                MsgBox("Username already taken, try other username.", MsgBoxStyle.Information)
                Exit Sub
            End If

            sqlSTR = "INSERT INTO Users " & _
                "(Username " & _
                ",Password " & _
                ",User_Access " & _
                ",User_Image) " & _
                "VALUES " & _
                "( " & _
                "'" & txt_userName.Text & "', " & _
                "'" & txt_password.Text & "', " & _
                "'" & cmb_AccessType.Text & "', " & _
                "" & pic_User.Tag & " " & _
                ");"
        End If



        Dim parameters As New List(Of Object) From {If(imgBytes, DBNull.Value)}

        ExecuteSQLQuery_WithParams(sqlSTR, parameters)


        grpUser.Visible = False
        Refresh_List()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        grpUser.Visible = False
        Refresh_List()
    End Sub

    Private Sub Picture_Status()
        If pic_User.Image IsNot Nothing Then
            pic_User.BringToFront()
            pic_None.SendToBack()

            btn_addPic.Visible = False
            btn_removePic.Visible = True
        Else
            pic_User.SendToBack()
            pic_None.BringToFront()

            btn_addPic.Visible = True
            btn_removePic.Visible = False
        End If
    End Sub

    Private Sub btn_addPic_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_addPic.LinkClicked
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select Patient Picture"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

            If ofd.ShowDialog() = DialogResult.OK Then
                ' Load the original image
                Dim original As Image = Image.FromFile(ofd.FileName)

                ' Resize while maintaining aspect ratio
                Dim maxSize As Integer = 200
                Dim ratio As Double = Math.Min(maxSize / original.Width, maxSize / original.Height)
                Dim newWidth As Integer = CInt(original.Width * ratio)
                Dim newHeight As Integer = CInt(original.Height * ratio)

                Dim resized As New Bitmap(original, New Size(newWidth, newHeight))

                ' Set the PictureBox image
                pic_User.Image = resized
                pic_User.SizeMode = PictureBoxSizeMode.Zoom

                ' Dispose original image
                original.Dispose()
            End If
        End Using

        Picture_Status()
    End Sub


    Private Sub btn_removePic_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_removePic.LinkClicked
        pic_User.Image = Nothing

        Picture_Status()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Do you want to delete this user record? This cannot be undone", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, msgBox_header) = MsgBoxResult.Yes Then
            lst_users.Focus()
            sqlSTR = "delete from Users where User_ID ='" & lst_users.FocusedItem.Text & "';"
            ExecuteSQLQuery(sqlSTR)
            Refresh_List()
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub



    ' ---------- Username: letters and underscore only ----------
    Private Sub txt_userName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_userName.KeyPress
        ' allow control keys (Backspace, Ctrl+C, etc.)
        If Char.IsControl(e.KeyChar) Then Exit Sub

        If Not Regex.IsMatch(e.KeyChar.ToString(), "^[A-Za-z_]$") Then
            e.Handled = True   ' block the character
        End If
    End Sub

    Private Sub txt_userName_TextChanged(sender As Object, e As EventArgs) Handles txt_userName.TextChanged
        ' handles paste: remove anything not allowed
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
End Class