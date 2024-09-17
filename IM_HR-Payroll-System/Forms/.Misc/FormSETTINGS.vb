Public Class FormSETTINGS

    Private Sub FormSETTINGS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServerSettings(cmb_dbname, txtip, txtservername, txtusername, txtpassword)

        sqlSTR = "select * from Global_Data"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            txt_buss_name.Text = sqlDT.Rows(0)("Business_Name")
            txt_buss_address.Text = sqlDT.Rows(0)("Business_Address")
            txt_buss_contact.Text = sqlDT.Rows(0)("Business_ContactNo")
            txt_buss_email.Text = sqlDT.Rows(0)("Business_Email")
            txt_buss_website.Text = sqlDT.Rows(0)("Business_Website")
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If TabControl1.SelectedTab.Text = "Business" Then
            sqlSTR = "select * from Global_Data"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                sqlSTR = "UPDATE Global_Data SET " &
         "Business_Name='" & txt_buss_name.Text & "', " &
         "Business_Address='" & txt_buss_address.Text & "', " &
         "Business_ContactNo='" & txt_buss_contact.Text & "', " &
         "Business_Email='" & txt_buss_email.Text & "', " &
         "Business_Website='" & txt_buss_website.Text & "'"
            Else
                sqlSTR = "INSERT INTO Global_Data (Business_Name, Business_Address, Business_ContactNo, Business_Email, Business_Website) " &
         "VALUES ('" & txt_buss_name.Text & "', '" & txt_buss_address.Text & "', '" & txt_buss_contact.Text & "', '" & txt_buss_email.Text & "', '" & txt_buss_website.Text & "')"
            End If
            ExecuteSQLQuery(sqlSTR)
            MDIMain.CompanyName.Text = "Company: " & txt_buss_name.Text
        ElseIf TabControl1.SelectedTab.Text = "Server" Then
            'UpdateServerSettings(cmb_dbname.Text, txtip.Text, txtservername.Text, txtusername.Text, txtpassword.Text)
        End If

        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class