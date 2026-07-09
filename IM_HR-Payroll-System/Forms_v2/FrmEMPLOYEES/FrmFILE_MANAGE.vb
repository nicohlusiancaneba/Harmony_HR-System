Imports System.IO

Public Class FrmFILE_MANAGE
    Dim edit As Boolean
    Dim employee_id As Integer
    Dim uploaded_filepath, fileName, fileExtension, file_id As String
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

        If txt_uploadedFile.Text = "" Then
            MsgBox("No selected file.", MsgBoxStyle.Exclamation, msgBox_header)
            Exit Sub
        End If


        

        fileName = employee_id & "_" & cmb_FileType.Text

        If edit Then
            sqlSTR = "UPDATE File_Docs " & _
                        "SET Date_Modified = GETDATE() " & _
                        ",File_Name = '" & fileName & fileExtension & "' " & _
                        ",File_Extension = '" & fileExtension & "' " & _
                        ",File_Data = @FILE_TYPE " & _
                        ",File_Remarks = '" & txt_Remarks.Text & "' " & _
                        "WHERE File_ID = '" & file_id & "';"
            ExecuteSQLQuery_plusFile(sqlSTR, uploaded_filepath)
        Else
            For Each row As DataGridViewRow In FrmEMPLOYEE_DETAILS.dgv_files.Rows
                If Not row.IsNewRow AndAlso row.Cells("file_type").Value IsNot Nothing AndAlso row.Cells("file_type").Value.ToString() = cmb_FileType.Text Then
                    MsgBox("The file already exists, try again.", MsgBoxStyle.Exclamation, msgBox_header)
                    Exit Sub
                End If
            Next

            sqlSTR = "INSERT INTO File_Docs " & _
                "(Employee_ID " & _
                ",Date_Modified " & _
                ",File_Group " & _
                ",File_Type " & _
                ",File_Name " & _
                ",File_Extension " & _
                ",File_Data " & _
                ",File_Remarks) " & _
                "VALUES " & _
                "( " & _
                "'" & employee_id & "', " & _
                "GETDATE(), " & _
                "'Employees', " & _
                "'" & cmb_FileType.Text & "', " & _
                "'" & fileName & fileExtension & "', " & _
                "'" & fileExtension & "', " & _
                "@File_Type, " & _
                "'" & txt_Remarks.Text & "' " & _
                ");"
            ExecuteSQLQuery_plusFile(sqlSTR, uploaded_filepath)
        End If

        


        Me.Close()
    End Sub

    Private Sub FrmFILE_MANAGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        employee_id = FrmEMPLOYEE_DETAILS.Employee_ID
        edit = FrmEMPLOYEE_DETAILS.edit

        FILLComboBox2("select Dropdown_ID, Dropdown_Description from Dropdowns where Dropdown_Type = 'File_Type' order by Dropdown_Description", cmb_FileType)
        cmb_FileType.Items.Add("Others")

        If edit Then
            file_id = FrmEMPLOYEE_DETAILS.dgv_files.CurrentRow.Cells("File_ID").Value.ToString

            cmb_FileType.Text = FrmEMPLOYEE_DETAILS.dgv_files.CurrentRow.Cells("File_Type").Value.ToString
            cmb_FileType.Enabled = False
            txt_Remarks.Text = FrmEMPLOYEE_DETAILS.dgv_files.CurrentRow.Cells("File_Remarks").Value.ToString
        Else
            txt_uploadedFile.Text = ""
            txt_Remarks.Text = ""
            cmb_FileType.Enabled = True
            file_id = ""
        End If

        
        

    End Sub

    Private Sub cmb_FileType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_FileType.SelectedIndexChanged
        If cmb_FileType.Text = "Others" Then
            cmb_FileType.DropDownStyle = ComboBoxStyle.DropDown
        Else
            cmb_FileType.DropDownStyle = ComboBoxStyle.DropDownList
        End If
    End Sub
End Class