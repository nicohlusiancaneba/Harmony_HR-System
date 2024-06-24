Public Class FormEMPLOYEES_DETAILS
    Dim employee_id As Integer
    Private Sub FormEMPLOYEES_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formOperation = "edit" Then
            employee_id = xID1
            sqlSTR = "select * from employees where Employee_ID=" & employee_id
            ExecuteSQLQuery(sqlSTR)

            txt_IDno.Text = sqlDT.Rows(0)("Employee_ID")
            txt_lastName.Text = sqlDT.Rows(0)("Last_Name")
            txt_firstName.Text = sqlDT.Rows(0)("First_Name")
            txt_middleName.Text = sqlDT.Rows(0)("Middle_Name")
            dt_birthDate.Text = sqlDT.Rows(0)("Date_of_Birth")
            cmb_gender.Text = sqlDT.Rows(0)("Gender")
            cmb_civilStatus.Text = sqlDT.Rows(0)("Civil_Status").ToString()
            txt_address.Text = sqlDT.Rows(0)("Address")
            txt_contactNo.Text = sqlDT.Rows(0)("Contact_No")
            txt_emergencyContactPerson.Text = sqlDT.Rows(0)("Emergency_Contact_Person")
            txt_emergencyRelationship.Text = sqlDT.Rows(0)("Emergency_Relationship")
            txt_emergencyAddress.Text = sqlDT.Rows(0)("Emergency_Address")
            txt_emergencyContactNo.Text = sqlDT.Rows(0)("Emergency_Contact_No")
            txt_bankNo.Text = sqlDT.Rows(0)("Payroll_Account_Number")
            dt_hiredDate.Text = sqlDT.Rows(0)("Hired_Date")
            cmb_employmentStatus.Text = sqlDT.Rows(0)("Employment_Status")
            dt_regularizationDate.Text = sqlDT.Rows(0)("Regularization_Date").ToString
            txt_jobPosition.Text = sqlDT.Rows(0)("Position")
            cmb_department.Text = sqlDT.Rows(0)("Department")
            cmb_division.Text = sqlDT.Rows(0)("Division")
            txt_startingRate.Text = sqlDT.Rows(0)("Starting_Daily_Rate")
            txt_currentRate.Text = sqlDT.Rows(0)("Current_Daily_Rate")
            txt_monthlySalary.Text = sqlDT.Rows(0)("Monthly_Salary")
            txt_workDaysNo.Text = sqlDT.Rows(0)("No_of_Work_Days_per_Month")
            txt_SSSno.Text = sqlDT.Rows(0)("SSS_No")
            txt_PhilhealthNo.Text = sqlDT.Rows(0)("Philhealth_No")
            txt_TINno.Text = sqlDT.Rows(0)("TIN_No")
            txt_pagibigNo.Text = sqlDT.Rows(0)("Pag_ibig_No")
            txt_SSSshare.Text = sqlDT.Rows(0)("SSS_Share").ToString()
            txt_philhealthShare.Text = sqlDT.Rows(0)("Philhealth_Share").ToString()
            txt_taxAmount.Text = sqlDT.Rows(0)("Tax_Amount").ToString()
            txt_pagIbigShare.Text = sqlDT.Rows(0)("Pag_ibig_Share").ToString()


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
            dt_regularizationDate.Text = Today()
        End If




    End Sub


    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If dt_regularizationDate.Enabled = True Then
            dt_regularizationDate.Tag = "'" & dt_regularizationDate.Text & "'"
        Else
            dt_regularizationDate.Tag = "null"
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
    "Regularization_Date = " & dt_regularizationDate.Tag & ", " & _
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

        Else 'Add
            sqlSTR = "INSERT INTO Employees (" &
         "Employee_ID, Last_Name, First_Name, Middle_Name, Date_of_Birth, Gender, Civil_Status, Address, Contact_No, " &
         "Emergency_Contact_Person, Emergency_Relationship, Emergency_Address, Emergency_Contact_No, " &
         "Payroll_Account_Number, Hired_Date, Employment_Status, Regularization_Date, Position, Department, Division, " &
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
         cmb_employmentStatus.Text & "', " &
         dt_regularizationDate.Tag & ", '" &
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
        End If
        ExecuteSQLQuery(sqlSTR)
        MsgBox("Succesfully saved employee details.", MsgBoxStyle.Information, msgBox_header)
        Me.Close()
        FormEMPLOYEES.RefreshEmployeeList()
    End Sub



    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub cmb_employmentStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_employmentStatus.SelectedIndexChanged
        If cmb_employmentStatus.Text <> "Regular" Then
            dt_regularizationDate.Enabled = False
            dt_regularizationDate.Text = Today()
        Else
            dt_regularizationDate.Enabled = True
            dt_regularizationDate.Text = Today()
        End If
    End Sub
End Class