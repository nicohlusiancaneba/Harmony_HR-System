Imports System.IO

Public Class FrmEMPLOYEE_DETAILS
    Public formAction, Employee_ID As String

    Public formLoaded, edit As Boolean

    Private Sub FrmEMPLOYEE_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inputText_ChangedHandler(Me)
        inputNum_ChangedHandler(Me)
        inputNum1_ChangedHandler(Me)
        ClearGroupBoxInputs(grpEmployeeInfo)
        employee_Pic.Image = Nothing

        formAction = FrmEMPLOYEES.formAction
        formLoaded = False
        If formAction = "edit" Then
            Employee_ID = FrmEMPLOYEES.dgv_employees.CurrentRow.Cells("Employee_ID").Value.ToString

            If Employee_ID = "" Then Exit Sub

            'INFO TAB
            sqlSTR = "SELECT Employee_ID " & _
                            ",Last_Name " & _
                            ",First_Name " & _
                            ",Middle_Name " & _
                            ",Date_of_Birth " & _
                            ",Gender " & _
                            ",Address " & _
                            ",Contact_No " & _
                            ",Emergency_Contact_Person " & _
                            ",Emergency_Relationship " & _
                            ",Emergency_Address " & _
                            ",Emergency_Contact_No " & _
                            ",Payroll_Account_Number " & _
                            ",Hired_Date " & _
                            ",Employment_Status " & _
                            ",Regularization_Date " & _
                            ",Position " & _
                            ",Department " & _
                            ",Division " & _
                            ",Starting_Daily_Rate " & _
                            ",Current_Daily_Rate " & _
                            ",Monthly_Salary " & _
                            ",No_of_Work_Days_per_Month " & _
                            ",SSS_No " & _
                            ",Philhealth_No " & _
                            ",TIN_No " & _
                            ",Pag_ibig_No " & _
                            ",Civil_Status " & _
                            ",SSS_Share " & _
                            ",Philhealth_Share " & _
                            ",Tax_Amount " & _
                            ",Pag_ibig_Share " & _
                            ",End_Of_EmploymentDate " & _
                            ",Paid_Leaves " & _
                            "FROM Employees " & _
                            " where Employee_ID='" & Employee_ID & "';"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count = 1 Then
                txt_lastName.Text = sqlDT.Rows(0)("Last_Name").ToString
                txt_firstName.Text = sqlDT.Rows(0)("First_Name").ToString
                txt_middleName.Text = sqlDT.Rows(0)("Middle_Name").ToString
                dt_birthday.Text = sqlDT.Rows(0)("Date_of_Birth").ToString
                cmb_gender.Text = sqlDT.Rows(0)("Gender").ToString
                cmb_civilStatus.Text = sqlDT.Rows(0)("Civil_Status").ToString
                txt_address.Text = sqlDT.Rows(0)("Address").ToString
                txt_contact.Text = sqlDT.Rows(0)("Contact_No").ToString

                cmb_employmentStatus.Text = sqlDT.Rows(0)("Employment_Status").ToString
                txt_jobPosition.Text = sqlDT.Rows(0)("Position").ToString
                cmb_department.Text = sqlDT.Rows(0)("Department").ToString
                cmb_division.Text = sqlDT.Rows(0)("Division").ToString
                dt_employmentDate.Text = sqlDT.Rows(0)("Hired_Date").ToString
                txt_regularizationDate.Text = sqlDT.Rows(0)("Regularization_Date").ToString
                txt_endEmploymentDate.Text = sqlDT.Rows(0)("End_Of_EmploymentDate").ToString

                txt_startingRate.Text = sqlDT.Rows(0)("Starting_Daily_Rate").ToString
                txt_currentRate.Text = sqlDT.Rows(0)("Current_Daily_Rate").ToString
                txt_workingDays.Text = sqlDT.Rows(0)("No_of_Work_Days_per_Month").ToString
                txt_monthlyRate.Text = sqlDT.Rows(0)("Monthly_Salary").ToString
                txt_paidLeaves.Text = sqlDT.Rows(0)("Paid_Leaves").ToString

                txt_bankAccountNo.Text = sqlDT.Rows(0)("Payroll_Account_Number").ToString
                txt_SSSno.Text = sqlDT.Rows(0)("SSS_No").ToString
                txt_philhealthNo.Text = sqlDT.Rows(0)("Philhealth_No").ToString
                txt_tin.Text = sqlDT.Rows(0)("TIN_No").ToString
                txt_PAGIBIGno.Text = sqlDT.Rows(0)("Pag_ibig_No").ToString

                txt_sssValue.Text = sqlDT.Rows(0)("SSS_Share").ToString
                txt_philhealthValue.Text = sqlDT.Rows(0)("Philhealth_Share").ToString
                txt_taxValue.Text = sqlDT.Rows(0)("Tax_Amount").ToString
                txt_PAGIBIGvalue.Text = sqlDT.Rows(0)("Pag_ibig_Share").ToString

                txt_emergencyContact.Text = sqlDT.Rows(0)("Emergency_Contact_Person").ToString
                txt_emergencyRelationship.Text = sqlDT.Rows(0)("Emergency_Relationship").ToString
                txt_emergencyNo.Text = sqlDT.Rows(0)("Emergency_Contact_No").ToString
            Else
                Exit Sub
            End If

            sqlSTR = "select File_Data as User_Image from file_docs " & _
                        "where Employee_ID = '" & Employee_ID & "' and File_type ='Picture';"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count = 1 Then
                If sqlDT.Rows(0)("User_Image") IsNot DBNull.Value Then
                    Dim img As Image = Nothing
                    Dim imgBytes() As Byte = CType(sqlDT.Rows(0)("User_Image"), Byte())
                    Using ms As New MemoryStream(imgBytes)
                        img = Image.FromStream(ms)
                    End Using

                    'img = ResizeImage(img, 100)

                    employee_Pic.Image = img
                End If
            End If


            sqlSTR = "SELECT File_ID " & _
                    ",Date_Modified " & _
                    ",File_Type " & _
                    ",File_Name " & _
                    ",File_Extension " & _
                    ",File_Data " & _
                    ",File_Remarks " & _
                    "FROM File_Docs " & _
                    "where Employee_ID = '" & Employee_ID & "';"
            ExecuteSQLQuery(sqlSTR)
            dgv_files.Rows.Clear()
            If sqlDT.Rows.Count > 0 Then
                For i = 0 To sqlDT.Rows.Count - 1
                    dgv_files.Rows.Add(
                        sqlDT.Rows(i)("File_ID"),
                        sqlDT.Rows(i)("Date_Modified"),
                        sqlDT.Rows(i)("File_Type"),
                        sqlDT.Rows(i)("File_Name"),
                        sqlDT.Rows(i)("File_Extension"),
                        sqlDT.Rows(i)("File_Remarks"),
                        sqlDT.Rows(i)("File_Data"),
                        "Download"
                    )
                Next
            End If

            'INFO TAB


        Else 'ADD

        End If

        formLoaded = True
    End Sub

    Private Sub dgv_files_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_files.CellDoubleClick

        Dim row As DataGridViewRow = dgv_files.CurrentRow

        If row Is Nothing Then Return

        Dim fileBytes As Byte() = CType(row.Cells("File_Data").Value, Byte())
        Dim fileExt As String = row.Cells("File_Extension").Value.ToString()
        Dim fileName As String = row.Cells("File_Name").Value.ToString()

        If fileBytes Is Nothing OrElse fileBytes.Length = 0 Then
            MsgBox("No file data found for this row.", MsgBoxStyle.Exclamation)
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Title = "Save File"
            sfd.Filter = fileExt.TrimStart("."c).ToUpper() & " Files|*" & fileExt & "|All Files|*.*"
            sfd.FileName = fileName

            If sfd.ShowDialog() = DialogResult.OK Then
                File.WriteAllBytes(sfd.FileName, fileBytes)
                MsgBox("File downloaded successfully.", MsgBoxStyle.Information)
            End If
        End Using

    End Sub


    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub txt_startingRate_TextChanged(sender As Object, e As EventArgs) Handles txt_startingRate.TextChanged
        If formLoaded Then
            If formAction = "add" Then
                txt_currentRate.Text = txt_startingRate.Text
            End If
        End If
    End Sub


    Private Sub txt_currentRate_TextChanged(sender As Object, e As EventArgs) Handles txt_currentRate.TextChanged
        If formLoaded Then
            Compute_Monthly()
        End If
    End Sub

    Private Sub Compute_Monthly()
        If IsNumeric(txt_startingRate.Text) And IsNumeric(txt_currentRate.Text) And IsNumeric(txt_workingDays.Text) Then
            txt_monthlyRate.Text = CInt(txt_workingDays.Text) * CDbl(txt_currentRate.Text)
        End If
    End Sub

    Private Sub txt_workingDays_TextChanged(sender As Object, e As EventArgs) Handles txt_workingDays.TextChanged
        If formLoaded Then
            Compute_Monthly()
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        edit = False
        FrmFILE_MANAGE.ShowDialog()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        edit = True
        FrmFILE_MANAGE.ShowDialog()
    End Sub
End Class