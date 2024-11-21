Imports System.IO

Public Class FormFILE_MANAGE

    Dim employee_id As Integer
    Dim uploaded_filepath, fileName, fileExtension As String
    Private Sub btn_openFiles_Click(sender As Object, e As EventArgs) Handles btn_openFiles.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        uploaded_filepath = OpenFileDialog1.FileName
        fileExtension = Path.GetExtension(uploaded_filepath)
        txt_uploadedFile.Text = Path.GetFileName(uploaded_filepath)
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click
        If cmb_FileType.Text = "" Then
            MsgBox("File type cannot be blank, try again.", MsgBoxStyle.Exclamation, msgBox_header)
            Exit Sub
        End If


        For Each item As ListViewItem In FormEMPLOYEES_DETAILS.lst_empFiles.Items
            If item.SubItems(2).Text = cmb_FileType.Text Then
                MsgBox("The file already exists, try again. To update, delete the existing file first and then upload the new one.", MsgBoxStyle.Exclamation, msgBox_header)
                Exit Sub
            End If
        Next

        fileName = employee_id & "_" & cmb_FileType.Text

        If WebDav_UploadFile("Harmony", uploaded_filepath, fileName) Then
            sqlSTR = "INSERT INTO Files " & _
                    "(Employee_ID " & _
                    ",Date_Modified " & _
                    ",File_Group " & _
                    ",File_Type " & _
                    ",File_Name " & _
                    ",File_Extension " & _
                    ",File_Remarks) " & _
                    "VALUES " & _
                        "(" & employee_id & ", " & _
                        "'" & Today() & "', " & _
                        "'Employees', " & _
                        "'" & cmb_FileType.Text & "', " & _
                        "'" & fileName & fileExtension & "', " & _
                        "'" & fileExtension & "', " & _
                        "'" & txt_Remarks.Text & "')"
            ExecuteSQLQuery(sqlSTR)
        End If

        If cmb_FileType.Text = "Picture" Then
            FormEMPLOYEES_DETAILS.Load_EmployeePicture()
        End If

        Me.Close()
    End Sub

    Private Sub FormFILE_MANAGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        employee_id = xID1
        txt_uploadedFile.Text = ""
        txt_Remarks.Text = ""
        FILLComboBox2("select Dropdown_ID, Dropdown_Description from Dropdowns where Dropdown_Type = 'File_Type' order by Dropdown_Description", cmb_FileType)
        cmb_FileType.Items.Add("Others")

    End Sub

    Private Sub cmb_FileType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_FileType.SelectedIndexChanged
        If cmb_FileType.Text = "Others" Then
            cmb_FileType.DropDownStyle = ComboBoxStyle.DropDown
        Else
            cmb_FileType.DropDownStyle = ComboBoxStyle.DropDownList
        End If
    End Sub
End Class