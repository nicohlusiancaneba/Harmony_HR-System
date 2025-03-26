Imports System.Net
Imports System.IO

Public Class FormEMPLOYEES_DETAILS
    Dim employee_id As Integer
    Dim tempReg_Date, tempEmpStatus As String
    Dim finishedLoad As Boolean
    Private Sub FormEMPLOYEES_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectedIndex = 0
        finishedLoad = False
        tempEmpStatus = ""
        FILLComboBox2("select Dropdown_ID, Dropdown_Description from Dropdowns where Dropdown_Type = 'Department' order by Dropdown_Description", cmb_department)
        FILLComboBox2("select Dropdown_ID, Dropdown_Description from Dropdowns where Dropdown_Type = 'Division' order by Dropdown_Description", cmb_division)

        If formOperation = "edit" Then
            employee_id = xID1

            sqlSTR = "select *, FORMAT(Regularization_Date, 'MM/dd/yyyy') as Regularization_Date2 from employees where Employee_ID=" & employee_id
            ExecuteSQLQuery(sqlSTR)

            txt_IDno.Text = sqlDT.Rows(0)("Employee_ID").ToString
            txt_lastName.Text = sqlDT.Rows(0)("Last_Name").ToString
            txt_firstName.Text = sqlDT.Rows(0)("First_Name").ToString
            txt_middleName.Text = sqlDT.Rows(0)("Middle_Name").ToString
            dt_birthDate.Text = sqlDT.Rows(0)("Date_of_Birth").ToString
            cmb_gender.Text = sqlDT.Rows(0)("Gender").ToString
            cmb_civilStatus.Text = sqlDT.Rows(0)("Civil_Status").ToString
            txt_address.Text = sqlDT.Rows(0)("Address").ToString
            txt_contactNo.Text = sqlDT.Rows(0)("Contact_No").ToString
            txt_emergencyContactPerson.Text = sqlDT.Rows(0)("Emergency_Contact_Person").ToString
            txt_emergencyRelationship.Text = sqlDT.Rows(0)("Emergency_Relationship").ToString
            txt_emergencyAddress.Text = sqlDT.Rows(0)("Emergency_Address").ToString
            txt_emergencyContactNo.Text = sqlDT.Rows(0)("Emergency_Contact_No").ToString
            txt_bankNo.Text = sqlDT.Rows(0)("Payroll_Account_Number").ToString
            dt_hiredDate.Text = sqlDT.Rows(0)("Hired_Date").ToString
            txt_regularizationDate.Text = sqlDT.Rows(0)("Regularization_Date2").ToString
            cmb_employmentStatus.Text = sqlDT.Rows(0)("Employment_Status").ToString
            txt_jobPosition.Text = sqlDT.Rows(0)("Position").ToString
            cmb_department.Text = sqlDT.Rows(0)("Department").ToString
            cmb_division.Text = sqlDT.Rows(0)("Division").ToString
            txt_startingRate.Text = sqlDT.Rows(0)("Starting_Daily_Rate").ToString
            txt_currentRate.Text = sqlDT.Rows(0)("Current_Daily_Rate").ToString
            txt_monthlySalary.Text = sqlDT.Rows(0)("Monthly_Salary").ToString
            txt_workDaysNo.Text = sqlDT.Rows(0)("No_of_Work_Days_per_Month").ToString
            txt_SSSno.Text = sqlDT.Rows(0)("SSS_No").ToString
            txt_PhilhealthNo.Text = sqlDT.Rows(0)("Philhealth_No").ToString
            txt_TINno.Text = sqlDT.Rows(0)("TIN_No").ToString
            txt_pagibigNo.Text = sqlDT.Rows(0)("Pag_ibig_No").ToString
            txt_SSSshare.Text = sqlDT.Rows(0)("SSS_Share").ToString()
            txt_philhealthShare.Text = sqlDT.Rows(0)("Philhealth_Share").ToString
            txt_taxAmount.Text = sqlDT.Rows(0)("Tax_Amount").ToString
            txt_pagIbigShare.Text = sqlDT.Rows(0)("Pag_ibig_Share").ToString
            txt_endEmpDate.Text = sqlDT.Rows(0)("End_Of_EmploymentDate").ToString

            txt_currentRate.ReadOnly = True
            txt_SSSshare.ReadOnly = True
            txt_philhealthShare.ReadOnly = True
            txt_taxAmount.ReadOnly = True
            txt_pagIbigShare.ReadOnly = True

            finishedLoad = True
            tempEmpStatus = cmb_employmentStatus.Text

            Load_EmployeePicture()
            RefreshList_Files()

        Else 'Add
            txt_IDno.Text = ""
            txt_lastName.Text = ""
            txt_firstName.Text = ""
            txt_middleName.Text = ""
            cmb_gender.Text = ""
            cmb_civilStatus.Text = ""
            txt_address.Text = ""
            txt_contactNo.Text = ""
            txt_emergencyContactPerson.Text = ""
            txt_emergencyRelationship.Text = ""
            txt_emergencyAddress.Text = ""
            txt_emergencyContactNo.Text = ""
            txt_bankNo.Text = ""
            cmb_employmentStatus.Text = ""
            txt_jobPosition.Text = ""
            cmb_department.Text = ""
            cmb_division.Text = ""
            txt_startingRate.Text = ""
            txt_currentRate.Text = ""
            txt_monthlySalary.Text = ""
            txt_workDaysNo.Text = ""
            txt_SSSno.Text = ""
            txt_PhilhealthNo.Text = ""
            txt_TINno.Text = ""
            txt_pagibigNo.Text = ""
            txt_SSSshare.Text = ""
            txt_philhealthShare.Text = ""
            txt_taxAmount.Text = ""
            txt_pagIbigShare.Text = ""

            dt_birthDate.Text = Today()
            dt_hiredDate.Text = Today()



            txt_currentRate.ReadOnly = False
            txt_SSSshare.ReadOnly = False
            txt_philhealthShare.ReadOnly = False
            txt_taxAmount.ReadOnly = False
            txt_pagIbigShare.ReadOnly = False
            employee_Picture.Image = Nothing
        End If

    End Sub


    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If txt_regularizationDate.Text = "" Then
            txt_regularizationDate.Tag = "null"
        Else
            txt_regularizationDate.Tag = "'" & txt_regularizationDate.Text & "'"
        End If

        If txt_IDno.Text = "" Then
            MsgBox("Employee No. cannot be blank.", MsgBoxStyle.Information, msgBox_header)
            Exit Sub
        End If


        If formOperation = "edit" Then
            sqlSTR = "UPDATE Employees SET " & _
    "Employee_ID = '" & txt_IDno.Text & "', " & _
    "Last_Name = '" & txt_lastName.Text & "', " & _
    "First_Name = '" & txt_firstName.Text & "', " & _
    "Middle_Name = '" & txt_middleName.Text & "', " & _
    "Date_of_Birth = '" & dt_birthDate.Text & "', " & _
    "Gender = '" & cmb_gender.Text & "', " & _
    "Civil_Status = '" & cmb_civilStatus.Text & "', " & _
    "Address = '" & txt_address.Text & "', " & _
    "Contact_No = '" & txt_contactNo.Text & "', " & _
    "Emergency_Contact_Person = '" & txt_emergencyContactPerson.Text & "', " & _
    "Emergency_Relationship = '" & txt_emergencyRelationship.Text & "', " & _
    "Emergency_Address = '" & txt_emergencyAddress.Text & "', " & _
    "Emergency_Contact_No = '" & txt_emergencyContactNo.Text & "', " & _
    "Payroll_Account_Number = '" & txt_bankNo.Text & "', " & _
    "Hired_Date = '" & dt_hiredDate.Text & "', " & _
    "Employment_Status = '" & cmb_employmentStatus.Text & "', " & _
    "Regularization_Date = " & txt_regularizationDate.Tag & ", " & _
    "Position = '" & txt_jobPosition.Text & "', " & _
    "Department = '" & cmb_department.Text & "', " & _
    "Division = '" & cmb_division.Text & "', " & _
    "Starting_Daily_Rate = '" & txt_startingRate.Text & "', " & _
    "Current_Daily_Rate = '" & txt_currentRate.Text & "', " & _
    "Monthly_Salary = '" & txt_monthlySalary.Text & "', " & _
    "No_of_Work_Days_per_Month = '" & txt_workDaysNo.Text & "', " & _
    "SSS_No = '" & txt_SSSno.Text & "', " & _
    "Philhealth_No = '" & txt_PhilhealthNo.Text & "', " & _
    "TIN_No = '" & txt_TINno.Text & "', " & _
    "Pag_ibig_No = '" & txt_pagibigNo.Text & "', " & _
    "SSS_Share = '" & txt_SSSshare.Text & "', " & _
    "Philhealth_Share = '" & txt_philhealthShare.Text & "', " & _
    "Tax_Amount = '" & txt_taxAmount.Text & "', " & _
    "Pag_ibig_Share = '" & txt_pagIbigShare.Text & "' " & _
    "WHERE Employee_ID = " & employee_id
            ExecuteSQLQuery(sqlSTR)

            If cmb_employmentStatus.Text = "Resigned" Or cmb_employmentStatus.Text = "Terminated" Then
                sqlSTR = "Update Employees set End_Of_EmploymentDate='" & txt_endEmpDate.Text & "' where Employee_ID =" & employee_id
                ExecuteSQLQuery(sqlSTR)
            End If


        Else 'Add
            sqlSTR = "INSERT INTO Employees (" &
         "Employee_ID, Last_Name, First_Name, Middle_Name, Date_of_Birth, Gender, Civil_Status, Address, Contact_No, " &
         "Emergency_Contact_Person, Emergency_Relationship, Emergency_Address, Emergency_Contact_No, " &
         "Payroll_Account_Number, Hired_Date, Employment_Status,  Position, Department, Division, " &
         "Starting_Daily_Rate, Current_Daily_Rate, Monthly_Salary, No_of_Work_Days_per_Month, SSS_No, Philhealth_No, " &
         "TIN_No, Pag_ibig_No, SSS_Share, Philhealth_Share, Tax_Amount, Pag_ibig_Share) VALUES ('" &
         txt_IDno.Text & "', '" &
         txt_lastName.Text & "', '" &
         txt_firstName.Text & "', '" &
         txt_middleName.Text & "', '" &
         dt_birthDate.Text & "', '" &
         cmb_gender.Text & "', '" &
         cmb_civilStatus.Text & "', '" &
         txt_address.Text & "', '" &
         txt_contactNo.Text & "', '" &
         txt_emergencyContactPerson.Text & "', '" &
         txt_emergencyRelationship.Text & "', '" &
         txt_emergencyAddress.Text & "', '" &
         txt_emergencyContactNo.Text & "', '" &
         txt_bankNo.Text & "', '" &
         dt_hiredDate.Text & "', '" &
         cmb_employmentStatus.Text & "', '" &
         txt_jobPosition.Text & "', '" &
         cmb_department.Text & "', '" &
         cmb_division.Text & "', '" &
         txt_startingRate.Text & "', '" &
         txt_currentRate.Text & "', '" &
         txt_monthlySalary.Text & "', '" &
         txt_workDaysNo.Text & "', '" &
         txt_SSSno.Text & "', '" &
         txt_PhilhealthNo.Text & "', '" &
         txt_TINno.Text & "', '" &
         txt_pagibigNo.Text & "', '" &
         txt_SSSshare.Text & "', '" &
         txt_philhealthShare.Text & "', '" &
         txt_taxAmount.Text & "', '" &
         txt_pagIbigShare.Text & "')"
            ExecuteSQLQuery(sqlSTR)
        End If

        MsgBox("Succesfully saved employee details.", MsgBoxStyle.Information, msgBox_header)
        Me.Close()
        'FormEMPLOYEES.rb_Regular.Checked = True

    End Sub


    Private Sub RefreshList_Files()
        sqlSTR = "select File_ID as ID, Date_Modified as 'Date Modified', " & _
                    "File_Type as 'File Type', File_Name as 'Filename', File_Remarks as 'Remarks' from Files " & _
                    "where Employee_ID =" & employee_id
        FillListView(ExecuteSQLQuery(sqlSTR), lst_empFiles, 0)
    End Sub



    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub cmb_employmentStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_employmentStatus.SelectedIndexChanged
        If finishedLoad And tempEmpStatus <> cmb_employmentStatus.Text And cmb_employmentStatus.Text = "Regular" Then
            MsgBox("Update the employment status to 'Regular' in the Adjustments record instead.", MsgBoxStyle.Information, msgBox_header)
            cmb_employmentStatus.Text = tempEmpStatus
        End If

        If cmb_employmentStatus.Text.Contains("Probationary") Then
            txt_regularizationDate.Text = ""
        End If

        If cmb_employmentStatus.Text = "Resigned" Or cmb_employmentStatus.Text = "Terminated" Then
            If txt_endEmpDate.Text = "" Then txt_endEmpDate.Text = Today()
            Label11.Visible = True
            txt_endEmpDate.Visible = True
        Else
            Label11.Visible = False
            txt_endEmpDate.Visible = False
        End If

    End Sub


    Private Sub ComputeMonthlySalary()
        If txt_currentRate.Text = "0" Then
            'txt_monthlySalary.Text = Val(txt_startingRate.Text) * Val(txt_workDaysNo.Text)
            txt_currentRate.Text = txt_startingRate.Text
        End If
        txt_monthlySalary.Text = Val(txt_currentRate.Text) * Val(txt_workDaysNo.Text)
    End Sub

    Private Sub txt_currentRate_TextChanged(sender As Object, e As EventArgs) Handles txt_currentRate.TextChanged
        ComputeMonthlySalary()
    End Sub

    Private Sub txt_workDaysNo_TextChanged(sender As Object, e As EventArgs) Handles txt_workDaysNo.TextChanged
        ComputeMonthlySalary()
    End Sub

    Private Sub txt_emergencyAddress_TextChanged(sender As Object, e As EventArgs) Handles txt_emergencyAddress.TextChanged
        RemoveCharacters(txt_emergencyAddress, ",")
    End Sub


    Public Sub Load_EmployeePicture()
        Dim fileName As String = ""
        sqlSTR = "select file_name from Files where file_type ='Picture' and employee_id =" & employee_id
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count = 1 Then
            fileName = sqlDT.Rows(0)("file_name").ToString
        Else
            'fileName = "user.png"
            employee_Picture.Image = My.Resources.User
            Exit Sub
        End If

        Try
            Dim imageUrl As String = "https://bcvr.ph/w3bd4v/Harmony/" & fileName

            ' Create WebRequest
            Dim request As WebRequest = WebRequest.Create(imageUrl)

            ' Use Using for WebResponse and Stream
            Using response As WebResponse = request.GetResponse(),
                  stream As Stream = response.GetResponseStream()

                ' Load the image into the PictureBox
                employee_Picture.Image = Image.FromStream(stream)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message)
        End Try

    End Sub


    Private Sub btn_newFile_Click(sender As Object, e As EventArgs) Handles btn_newFile.Click
        Dim temp As String = formOperation
        ShowForm1(FormFILE_MANAGE, "add", employee_id)
        RefreshList_Files()
        formOperation = temp
    End Sub

    Private Sub btn_download_Click(sender As Object, e As EventArgs) Handles btn_download.Click
        lst_empFiles.Focus()
        WebDav_DownloadFile("Harmony", lst_empFiles.FocusedItem.SubItems(3).Text)
    End Sub

    Private Sub lst_empFiles_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_empFiles.MouseDoubleClick
        WebDav_DownloadFile("Harmony", lst_empFiles.FocusedItem.SubItems(3).Text)
    End Sub



    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If MsgBox("Do you want to delete this file record?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, msgBox_header) = MsgBoxResult.Yes Then
            WebDav_DeleteFile("Harmony", lst_empFiles.FocusedItem.SubItems(3).Text)
            sqlSTR = "Delete from Files where File_ID =" & lst_empFiles.FocusedItem.Text
            ExecuteSQLQuery(sqlSTR)

            MsgBox("Deleted file record.", MsgBoxStyle.Information, msgBox_header)
        End If
        RefreshList_Files()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 2 Then
            If formOperation <> "edit" Then
                MsgBox("Operation not allowed. Please add the employee first before uploading the necessary files, then try again.", MsgBoxStyle.Information, msgBox_header)
                TabControl1.SelectedIndex = 0
            End If

        End If
    End Sub


End Class