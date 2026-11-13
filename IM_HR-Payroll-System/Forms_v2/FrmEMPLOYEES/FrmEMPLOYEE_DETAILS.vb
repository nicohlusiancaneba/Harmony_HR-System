Imports System.IO

Public Class FrmEMPLOYEE_DETAILS
    Public formAction, Employee_ID As String

    Public formLoaded, edit As Boolean



    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ShowTabPage(Employee_tabControl, Files, 1)
        ShowTabPage(Employee_tabControl, Attendance, 2)
        ShowTabPage(Employee_tabControl, Payroll, 3)
        ShowTabPage(Employee_tabControl, Loans, 4)
        ShowTabPage(Employee_tabControl, Adjustments, 5)
        ShowTabPage(Employee_tabControl, Leaves, 6)
    End Sub

    Private Sub FrmEMPLOYEE_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inputText_ChangedHandler(Me)
        inputNum_ChangedHandler(Me)
        inputNum1_ChangedHandler(Me)
        ClearGroupBoxInputs(grpEmployeeInfo)
        ThemeHelper.ApplyHighlight(Me)



        FILLComboBox2("select Dropdown_ID, Dropdown_Description from Dropdowns where Dropdown_Type = 'Department' order by Dropdown_Description", cmb_department)
        FILLComboBox2("select Dropdown_ID, Dropdown_Description from Dropdowns where Dropdown_Type = 'Division' order by Dropdown_Description", cmb_division)

        Employee_tabControl.SelectedIndex = 0
        employee_Pic.Image = Nothing
        cmb_civilStatus.SelectedIndex = 0
        cmb_gender.SelectedIndex = 0
        cmb_department.SelectedIndex = 0
        cmb_division.SelectedIndex = 0


        formAction = FrmEMPLOYEES.formAction
        formLoaded = False
        If formAction = "edit" Then
            Employee_ID = FrmEMPLOYEES.lst_employees.FocusedItem.SubItems(1).Text

            If Employee_ID = "" Then Exit Sub


            ShowTabPage(Employee_tabControl, Files, 1)
            ShowTabPage(Employee_tabControl, Attendance, 2)
            ShowTabPage(Employee_tabControl, Payroll, 3)
            ShowTabPage(Employee_tabControl, Loans, 4)
            ShowTabPage(Employee_tabControl, Adjustments, 5)
            ShowTabPage(Employee_tabControl, Leaves, 6)

            txt_jobPosition.ReadOnly = True
            cmb_department.Enabled = False
            cmb_division.Enabled = False
            dt_employmentDate.Enabled = False
            txt_paidLeaves.ReadOnly = True

            txt_startingRate.ReadOnly = True
            txt_workingDays.ReadOnly = True
            txt_salarySSS.ReadOnly = True
            txt_salaryPhilhealth.ReadOnly = True
            txt_salaryPAGIBIG.ReadOnly = True
            txt_salaryBIR.ReadOnly = True


            txt_bankAccountNo.ReadOnly = True
            txt_SSSno.ReadOnly = True
            txt_philhealthNo.ReadOnly = True
            txt_tin.ReadOnly = True
            txt_PAGIBIGno.ReadOnly = True

            txt_sssValue.ReadOnly = True
            txt_philhealthValue.ReadOnly = True
            txt_PAGIBIGvalue.ReadOnly = True
            txt_taxValue.ReadOnly = True




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
                            ",COALESCE(Paid_Leaves,0) as Paid_Leaves " & _
                            ",COALESCE(Monthly_Salary_SSS, 0) as Monthly_Salary_SSS " & _
                            ",COALESCE(Monthly_Salary_Philhealth, 0) as Monthly_Salary_Philhealth " & _
                            ",COALESCE(Monthly_Salary_PAGIBIG, 0) as Monthly_Salary_PAGIBIG " & _
                            ",COALESCE(Monthly_Salary_BIR, 0) as Monthly_Salary_BIR " & _
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

                txt_employmentStatus.Text = sqlDT.Rows(0)("Employment_Status").ToString
                txt_jobPosition.Text = sqlDT.Rows(0)("Position").ToString
                cmb_department.Text = sqlDT.Rows(0)("Department").ToString
                cmb_division.Text = sqlDT.Rows(0)("Division").ToString
                dt_employmentDate.Text = sqlDT.Rows(0)("Hired_Date").ToString
                txt_regularizationDate.Text = sqlDT.Rows(0)("Regularization_Date").ToString
                txt_endEmploymentDate.Text = sqlDT.Rows(0)("End_Of_EmploymentDate").ToString
                txt_paidLeaves.Text = sqlDT.Rows(0)("Paid_Leaves").ToString

                txt_startingRate.Text = sqlDT.Rows(0)("Starting_Daily_Rate").ToString
                txt_currentRate.Text = sqlDT.Rows(0)("Current_Daily_Rate").ToString
                txt_workingDays.Text = sqlDT.Rows(0)("No_of_Work_Days_per_Month").ToString
                txt_monthlyRate.Text = sqlDT.Rows(0)("Monthly_Salary").ToString
                txt_salarySSS.Text = sqlDT.Rows(0)("Monthly_Salary_SSS").ToString
                txt_salaryPhilhealth.Text = sqlDT.Rows(0)("Monthly_Salary_Philhealth").ToString
                txt_salaryPAGIBIG.Text = sqlDT.Rows(0)("Monthly_Salary_PAGIBIG").ToString
                txt_salaryBIR.Text = sqlDT.Rows(0)("Monthly_Salary_BIR").ToString


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
                txt_emergencyAddress.Text = sqlDT.Rows(0)("Emergency_Address").ToString
                txt_emergencyRelationship.Text = sqlDT.Rows(0)("Emergency_Relationship").ToString
                txt_emergencyNo.Text = sqlDT.Rows(0)("Emergency_Contact_No").ToString

                Label_ID.Text = "ID#" & Employee_ID & " - " & txt_lastName.Text & ", " & txt_firstName.Text
                Label_ID.Left = Panel1.Width - Label_ID.Width - 10
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

            Refresh_Files()
            Refresh_Attendance()
            Refresh_Payroll()
            Refresh_Loans()
            Refresh_Adjustments()
            Refresh_Leaves()

            'INFO TAB


        Else 'ADD
            sqlSTR = "select top 1 Employee_ID + 1 as New_Employee_ID from Employees order by Employee_ID desc;"
            ExecuteSQLQuery(sqlSTR)
            Employee_ID = sqlDT.Rows(0)("New_Employee_ID").ToString
            Label_ID.Text = "ID#" & Employee_ID
            Label_ID.Left = Panel1.Width - Label_ID.Width - 10

            txt_employmentStatus.Text = "Probationary"
            txt_jobPosition.ReadOnly = False
            cmb_department.Enabled = True
            cmb_division.Enabled = True
            dt_employmentDate.Enabled = True
            txt_paidLeaves.ReadOnly = False

            txt_startingRate.ReadOnly = False
            txt_workingDays.ReadOnly = False
            txt_salarySSS.ReadOnly = False
            txt_salaryPhilhealth.ReadOnly = False
            txt_salaryPAGIBIG.ReadOnly = False
            txt_salaryBIR.ReadOnly = False

            txt_bankAccountNo.ReadOnly = False
            txt_SSSno.ReadOnly = False
            txt_philhealthNo.ReadOnly = False
            txt_tin.ReadOnly = False
            txt_PAGIBIGno.ReadOnly = False

            txt_sssValue.ReadOnly = False
            txt_philhealthValue.ReadOnly = False
            txt_PAGIBIGvalue.ReadOnly = False
            txt_taxValue.ReadOnly = False

            HideTabPage(Employee_tabControl, Files)
            HideTabPage(Employee_tabControl, Attendance)
            HideTabPage(Employee_tabControl, Payroll)
            HideTabPage(Employee_tabControl, Loans)
            HideTabPage(Employee_tabControl, Adjustments)
            HideTabPage(Employee_tabControl, Leaves)
        End If

        formLoaded = True
    End Sub

    Private Sub Refresh_Files()
        sqlSTR = "SELECT * " & _
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
    End Sub

    Private Sub Refresh_Attendance()
        sqlSTR = "select " & _
                "COALESCE(Payroll_Month, DATENAME(MONTH, Cutoff_Date_End)) as 'Payroll Month', " & _
                "sum(numRegular) as 'Total Regular Day', " & _
                "sum(numSpecial) as 'Total Special Day', " & _
                "sum(COALESCE(numLeave, 0)) as 'Total Leave Day', " & _
                "sum(numField) as 'Total Field Day', " & _
                "sum(numHoliday) as 'Total Holiday', " & _
                "sum(COALESCE(totalNumAbsent, 0)) as 'Total Absent', " & _
                "sum(COALESCE(totalNumLate, 0)) as 'Total Late' " & _
                "from Payroll_Details " & _
                "inner join Payroll on Payroll.Payroll_ID = Payroll_Details.Payroll_ID " & _
                "where Employee_ID = '" & Employee_ID & "' " & _
                "and Payroll_Approved = 'Yes' " & _
                "and Year(Cutoff_Date_End) = Year(GETDATE()) " & _
                "group by COALESCE(Payroll_Month, DATENAME(MONTH, Cutoff_Date_End)) " & _
                "order by MAX(Cutoff_Date_Start) desc"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_attendance, 0)

        If lst_attendance.Items.Count > 0 Then
            listView_Total(lst_attendance, 1, 2, 3, 4, 5, 6, 7)
        End If

    End Sub

    Private Sub Refresh_Payroll()
        sqlSTR = "select " & _
                "Payroll_Details.Payroll_ID as 'Payroll ID', " & _
                "CONCAT(Cutoff_Date_Start, ' to ', Cutoff_Date_End) as 'Cutoff Period', " & _
                "FORMAT(totalSSS, 'N2') as 'Total SSS', " & _
                "FORMAT(totalPhilhealth, 'N2') as 'Total Philhealth', " & _
                "FORMAT(totalPagIbig, 'N2') as 'Total PAG-IBIG', " & _
                "FORMAT(totalTax, 'N2') as 'Total Tax', " & _
                "FORMAT(grandTotal_Basic, 'N2') as 'Total Basic', " & _
                "FORMAT(grandTotal_Additional, 'N2') as 'Total Additional', " & _
                "FORMAT(grandTotal_Gross, 'N2') as 'Total Gross', " & _
                "FORMAT(grandTotal_Deduction, 'N2') as 'Total Deduction', " & _
                "FORMAT(grandTotal_Loan, 'N2') as 'Total Loan', " & _
                "FORMAT(grandTotal_Net, 'N2') as 'Total Net', " & _
                "payroll_employeeRemarks as 'Payroll Remarks' " & _
                "from Payroll_Details " & _
                "inner join Payroll on Payroll.Payroll_ID = Payroll_Details.Payroll_ID " & _
                "where Employee_ID = '" & Employee_ID & "' " & _
                "and Payroll_Approved = 'Yes' " & _
                "order by Cutoff_Date_Start desc"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_payroll, 0)

        If lst_payroll.Items.Count > 0 Then
            listView_Total(lst_payroll, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)
        End If

    End Sub

    Private Sub Refresh_Loans()
        sqlSTR = "SELECT " & _
                    "Loans.Loan_ID AS 'ID', " & _
                    "MAX(Loan_Date) AS 'Loan Date', " & _
                    "MAX(Loan_Type) AS 'Loan Type', " & _
                    "FORMAT(MAX(Loan_Gross_Amount), 'N2') AS 'Loan Gross', " & _
                    "FORMAT(sum(case when Payment_Posted = 'Yes' then COALESCE(Gross_Payment, 0) else 0 end), 'N2') as 'Loan Payment', " & _
                    "FORMAT(max(Loan_Gross_Amount) - sum(case when Payment_Posted = 'Yes' then COALESCE(Gross_Payment, 0) else 0 end), 'N2') as 'Loan Balance', " & _
                    "CONCAT(MAX(Loan_Payment_Start_Date), ' to ', MAX(Loan_Payment_End_Date)) AS 'Loan Payment Period', " & _
                    "MAX(Loan_Reason) AS 'Loan Reason', MAX(Loan_Remarks) AS 'Loan Remarks', MAX(Loan_Status) AS 'Loan Status' " & _
                    "FROM Loans " & _
                    "LEFT JOIN Loan_Payments ON Loan_Payments.Loan_ID = Loans.Loan_ID " & _
                    "INNER JOIN Employees ON Employees.Employee_ID = Loans.Employee_ID " & _
                    "WHERE Loans.Employee_ID = '" & Employee_ID & "' " & _
                    "GROUP BY Loans.Loan_ID " & _
                    "ORDER BY MAX(Loan_Date);"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_loans, 0)

        If lst_loans.Items.Count > 0 Then
            listView_Total(lst_loans, 3, 4, 5)
        End If

    End Sub

    Private Sub Refresh_Adjustments()
        sqlSTR = "SELECT " & _
                    "Adjustment_ID as ID, " & _
                    "Date_Adjusted as 'Date Adjusted', " & _
                    "Adjustment_Type as 'Adjustment Type', " & _
                    "Remarks, " & _
                    "Prev_Value as 'Previous Value', " & _
                    "New_Value as 'New Value', " & _
                    "Encoded_by as 'Encoded by', " & _
                    "Approved_by as 'Approved by' " & _
                    "FROM Adjustments " & _
                    "inner join Employees on Employees.Employee_ID = Adjustments.Employee_ID " & _
                    "where Employees.Employee_ID ='" & Employee_ID & "' " & _
                    "and Adj_Approved = 'Yes' " & _
                    "order by Date_Adjusted, Adjustment_Type;"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_adjustments, 0)

        

    End Sub

    Private Sub Refresh_Leaves()
        sqlSTR = "select " & _
                "Leave_ID as 'ID', " & _
                "Date_Applied as 'Date Applied', " & _
                "Immediate_Supervisor as Supervisor, " & _
                "Leave_Category as Category, " & _
                "Leave_Start as 'Leave Start', " & _
                "Leave_end as 'Leave End', " & _
                "Leave_TotalDays as 'Total Day(s)', " & _
                "CASE WHEN Leave_Category not in ('Leave w/o Pay', 'Bereavement', 'Others', 'Other') then 'Yes' else 'No' end as 'Paid Leave?', " & _
                "Leave_Reason as Reason, " & _
                "Leave_Remarks as Remarks " & _
                "from Leaves " & _
                "INNER JOIN Employees on Employees.Employee_ID = Leaves.Employee_ID " & _
                "where Employees.Employee_ID = '" & Employee_ID & "' " & _
                "and Leave_Status = 'Approved' " & _
                "order by Leave_Start desc"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_leaves, 0)

        Dim paid_leaves_availed As Double = 0

        If lst_leaves.Items.Count > 0 Then


            For i = 0 To lst_leaves.Items.Count - 1
                If lst_leaves.Items(i).SubItems(7).Text.ToString = "Yes" And Date.Parse(lst_leaves.Items(i).SubItems(4).Text).Year = Date.Today.Year Then
                    paid_leaves_availed = paid_leaves_availed + CDbl(lst_leaves.Items(i).SubItems(6).Text.ToString)
                End If
            Next
        End If

        txt_paidAvail.Text = paid_leaves_availed
    End Sub

    Private Sub dgv_files_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_files.CellDoubleClick



    End Sub

    Private Sub dgv_files_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_files.CellContentClick
        If e.RowIndex >= 0 AndAlso dgv_files.Columns(e.ColumnIndex).Name = "Download_Link" Then
            Dim row As DataGridViewRow = dgv_files.Rows(e.RowIndex)

            Dim fileBytes As Byte() = CType(row.Cells("File_Data").Value, Byte())
            Dim fileExt As String = If(row.Cells("File_Extension").Value, "").ToString()
            Dim fileName As String = If(row.Cells("File_Name").Value, "download").ToString()

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
        End If
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
        Refresh_Files()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        dgv_files.Focus()
        If dgv_files.Rows.Count > 0 Then
            edit = True
            FrmFILE_MANAGE.ShowDialog()
            Refresh_Files()
        End If

    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        dgv_files.Focus()
        If dgv_files.Rows.Count > 0 Then
            If MsgBox("Do you really want to delete this uploaded file? This cannot be undone.", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                sqlSTR = "Delete from File_Docs where File_ID = '" & dgv_files.CurrentRow.Cells("File_ID").Value.ToString & "';"
                ExecuteSQLQuery(sqlSTR)
            End If

            Refresh_Files()
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If HoldSave() Then Exit Sub


        If formAction = "edit" Then
            sqlSTR = "UPDATE Employees " &
    "SET Last_Name = '" & txt_lastName.Text & "'" &
    ",First_Name = '" & txt_firstName.Text & "'" &
    ",Middle_Name = '" & txt_middleName.Text & "'" &
    ",Date_of_Birth = '" & dt_birthday.Text & "'" &
    ",Gender = '" & cmb_gender.Text & "'" &
    ",Address = '" & txt_address.Text & "'" &
    ",Contact_No = '" & txt_contact.Text & "'" &
    ",Emergency_Contact_Person = '" & txt_emergencyContact.Text & "'" &
    ",Emergency_Address = '" & txt_emergencyAddress.Text & "'" &
    ",Emergency_Relationship = '" & txt_emergencyRelationship.Text & "'" &
    ",Emergency_Contact_No = '" & txt_emergencyNo.Text & "'" &
    ",Civil_Status = '" & cmb_civilStatus.Text & "'" &
    "WHERE Employee_ID = '" & Employee_ID & "';"
            ExecuteSQLQuery(sqlSTR)
        Else
            sqlSTR = "INSERT INTO Employees " &
    "(Employee_ID, Last_Name, First_Name, Middle_Name, Date_of_Birth, Gender, Address, Contact_No, " &
    "Emergency_Contact_Person, Emergency_Address, Emergency_Relationship, Emergency_Contact_No, " &
    "Payroll_Account_Number, Hired_Date, Employment_Status, Position, Department, " &
    "Division, Starting_Daily_Rate, Current_Daily_Rate, Monthly_Salary, Monthly_Salary_SSS, Monthly_Salary_Philhealth, Monthly_Salary_PAGIBIG, Monthly_Salary_BIR, No_of_Work_Days_per_Month, " &
    "SSS_No, Philhealth_No, TIN_No, Pag_ibig_No, Civil_Status, SSS_Share, Philhealth_Share, Tax_Amount, " &
    "Pag_ibig_Share, Paid_Leaves) " &
    "VALUES " &
    "('" & Employee_ID & "'" &
    ",'" & txt_lastName.Text & "'" &
    ",'" & txt_firstName.Text & "'" &
    ",'" & txt_middleName.Text & "'" &
    ",'" & dt_birthday.Text & "'" &
    ",'" & cmb_gender.Text & "'" &
    ",'" & txt_address.Text & "'" &
    ",'" & txt_contact.Text & "'" &
    ",'" & txt_emergencyContact.Text & "'" &
    ",'" & txt_emergencyAddress.Text & "'" &
    ",'" & txt_emergencyRelationship.Text & "'" &
    ",'" & txt_emergencyNo.Text & "'" &
    ",'" & txt_bankAccountNo.Text & "'" &
    ",'" & dt_employmentDate.Text & "'" &
    ",'" & txt_employmentStatus.Text & "'" &
    ",'" & txt_jobPosition.Text & "'" &
    ",'" & cmb_department.Text & "'" &
    ",'" & cmb_division.Text & "'" &
    ",'" & txt_startingRate.Text & "'" &
    ",'" & txt_currentRate.Text & "'" &
    ",'" & txt_monthlyRate.Text & "'" &
    ",'" & txt_salarySSS.Text & "'" &
    ",'" & txt_salaryPhilhealth.Text & "'" &
    ",'" & txt_salaryPAGIBIG.Text & "'" &
    ",'" & txt_salaryBIR.Text & "'" &
    ",'" & txt_workingDays.Text & "'" &
    ",'" & txt_SSSno.Text & "'" &
    ",'" & txt_philhealthNo.Text & "'" &
    ",'" & txt_tin.Text & "'" &
    ",'" & txt_PAGIBIGno.Text & "'" &
    ",'" & cmb_civilStatus.Text & "'" &
    ",'" & txt_sssValue.Text & "'" &
    ",'" & txt_philhealthValue.Text & "'" &
    ",'" & txt_taxValue.Text & "'" &
    ",'" & txt_PAGIBIGvalue.Text & "'" &
    ",'" & txt_paidLeaves.Text & "');"
            ExecuteSQLQuery(sqlSTR)
        End If

        Me.Close()
    End Sub

    Private Function HoldSave()

        If formAction = "add" Then
            If txt_jobPosition.Text = "" Or txt_jobPosition.Text.Length < 5 Then
                MsgBox("Enter employee's valid job position.")
                Return True
            End If

            If txt_startingRate.Text = "" Then
                MsgBox("Employee's starting daily rate cannot be blank.")
                Return True
            End If

            If txt_workingDays.Text = "" Then
                MsgBox("Employee's number of working days per month cannot be blank.")
                Return True
            End If

            If txt_paidLeaves.Text = "" Then
                MsgBox("Employee's number of leaves per year cannot be blank.")
                Return True
            End If
        End If

        If txt_lastName.Text = "" Or txt_firstName.Text = "" Or txt_middleName.Text = "" Then
            MsgBox("Employee's name cannot be incomplete, try again.")
            Return True
        End If


        If dt_birthday.Value > Date.Today.AddYears(-18) Then
            MsgBox("Employee must be at least 18 years old.")
            Return True
        End If

        If txt_address.Text = "" Or txt_address.Text.Length < 5 Then
            MsgBox("Enter employee's valid and complete home address.")
            Return True
        End If

        If txt_contact.Text = "" Or txt_contact.Text.Length < 10 Then
            MsgBox("Enter employee's valid and complete contact number.")
            Return True
        End If

        If txt_emergencyContact.Text = "" Or txt_emergencyRelationship.Text = "" Or txt_emergencyNo.Text = "" Then
            MsgBox("Employee's emergency contact details cannot be incomplete, try again.")
            Return True
        End If

        Return False
    End Function


    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub txt_paidLeaves_TextChanged(sender As Object, e As EventArgs) Handles txt_paidLeaves.TextChanged
        txt_paidLeaves2.Text = txt_paidLeaves.Text
    End Sub


End Class