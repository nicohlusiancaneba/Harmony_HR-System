Public Class FormREPORT_CREATE

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub FormREPORT_CREATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_reportType.SelectedIndex = -1
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        With FormREPORTS
            If cmb_reportType.Text = "Adjustments" Then
                sqlSTR = "select Date_adjusted as 'Date Adjusted', Employees.Employee_ID as 'Employee ID', " & _
                    "CONCAT(Last_Name, ', ', First_Name, ' ', SUBSTRING(Middle_Name, 1, 1), '.') as 'Employee Name', " & _
                    "Adjustment_Type as 'Adjustment Type', Prev_Value as 'Previous Value', New_Value as 'New Value', " & _
                    "Hired_Date as 'Hired Date', REPLACE(COALESCE(FORMAT(Regularization_Date, 'MM/dd/yyyy'), '01/30/2040'), '01/30/2040', '') as 'Regularization Date', " & _
                    "Position, No_of_Work_Days_per_Month as 'Working Days', Approved_by 'Approved by'  from Adjustments " & _
                    "inner join Employees on Employees.Employee_ID = Adjustments.Employee_ID " & _
                    "WHERE Date_Adjusted >= '" & dt_from.Text & "' and Date_Adjusted <= '" & dt_to.Text & "' " & _
                    "order by Date_Adjusted, Last_Name"
                .reportLabel.Text = "Employee Adjusments record from " & dt_from.Text & " to " & dt_to.Text
            ElseIf cmb_reportType.Text = "Deductions" Then
                sqlSTR = "SELECT " & _
                    "CONCAT(MIN(Cutoff_Date_Start), ' to ', MAX(Cutoff_Date_End)) AS 'Cutoff Period', " & _
                    "Employees.Employee_ID AS 'Employee ID', " & _
                    "MAX(CONCAT(Last_Name, ', ', First_Name, ' ', SUBSTRING(Middle_Name, 1, 1), '.')) AS 'Name', " & _
                    "SUM(totalSSS) AS 'Total SSS', " & _
                    "SUM(totalPhilhealth) AS 'Total PhilHealth', " & _
                    "SUM(totalPagIbig) AS 'Total Pag-IBIG', " & _
                    "SUM(TotalTax) AS 'Total Tax', " & _
                    "SUM(TotalInsurance) AS 'Total Insurance' " & _
                    "FROM Payroll_Details " & _
                    "INNER JOIN Payroll ON Payroll.Payroll_ID = Payroll_Details.Payroll_ID " & _
                    "INNER JOIN Employees ON Employees.Employee_ID = Payroll_Details.Employee_ID " & _
                    "WHERE Cutoff_Date_Start >= '" & dt_from.Text & "' " & _
                    "AND Cutoff_Date_End <= '" & dt_to.Text & "' " & _
                    "GROUP BY Employees.Employee_ID " & _
                    "ORDER BY Name;"
                .reportLabel.Text = "Employee Deductions record from " & dt_from.Text & " to " & dt_to.Text
            ElseIf cmb_reportType.Text = "Employee Upcoming Birthdays" Then
                sqlSTR = "select DATENAME(MONTH, Date_of_Birth) as Month, Employee_ID as 'Employee ID', CONCAT(First_Name, ' ', LEFT(Middle_Name,1), '. ', Last_Name) as 'Employee Name', Position, Department, " & _
                    "Date_of_Birth as 'Birthdate', " & _
                    "CASE " & _
                    "WHEN DATEDIFF(YEAR, Hired_Date, GETDATE()) = 0 " & _
                    "THEN CONCAT(DATEDIFF(MONTH, Hired_Date, GETDATE()), ' month(s)') " & _
                    "ELSE CONCAT(DATEDIFF(YEAR, Hired_Date, GETDATE()), ' year(s)') " & _
                    "END AS 'Tenure' from employees " & _
                    "where Month(Date_of_Birth) >= MONTH(GETDATE()) and Month(Date_of_Birth) <= MONTH(GETDATE())+3 " & _
                    "and (Employment_Status != 'Terminated' and Employment_Status != 'Resigned') " & _
                    "order by Month(Date_of_Birth)"
                .reportLabel.Text = "Employee Upcoming Birthdays"
            ElseIf cmb_reportType.Text = "Employees (All)" Then
                sqlSTR = "SELECT " & _
                    "ROW_NUMBER() OVER (ORDER BY Last_Name) AS '#', " & _
                    "Employee_ID AS 'Employee ID', Last_Name AS 'Last Name', First_Name AS 'First Name', Middle_Name AS 'Middle Name', Gender, Date_of_Birth as 'Date of Birth',  " & _
                    "Address, Hired_Date AS 'Hired Date',  Employment_Status AS 'Employment Status', Position, " & _
                    "Department, Civil_Status AS 'Civil Status', Starting_Daily_Rate AS 'Starting Daily Rate', Current_Daily_Rate AS 'Current Daily Rate', " & _
                    "No_of_Work_Days_per_Month AS 'Working Days', SSS_No AS 'SSS No', Philhealth_No AS 'PhilHealth No', TIN_No AS 'TIN No', Pag_ibig_No AS 'Pag-IBIG No' " & _
                    "FROM Employees; "
                .reportLabel.Text = "List of All Employees"
            ElseIf cmb_reportType.Text = "Employees (Regular)" Then
                sqlSTR = "SELECT " & _
                        "ROW_NUMBER() OVER (ORDER BY Last_Name) AS '#', " & _
                        "Employee_ID AS 'Employee ID', Last_Name AS 'Last Name', First_Name AS 'First Name', Middle_Name AS 'Middle Name', Gender, Date_of_Birth as 'Date of Birth', " & _
                        "Address, Hired_Date AS 'Hired Date',  Employment_Status AS 'Employment Status', Position, " & _
                        "Department, Civil_Status AS 'Civil Status', Starting_Daily_Rate AS 'Starting Daily Rate', Current_Daily_Rate AS 'Current Daily Rate', " & _
                        "No_of_Work_Days_per_Month AS 'Working Days', SSS_No AS 'SSS No', Philhealth_No AS 'PhilHealth No', TIN_No AS 'TIN No', Pag_ibig_No AS 'Pag-IBIG No' " & _
                        "FROM Employees " & _
                        "WHERE Employment_Status LIKE '%Regular%';"
                .reportLabel.Text = "List of Regular Employees"
            ElseIf cmb_reportType.Text = "Employees (Probationary)" Then
                sqlSTR = "SELECT " & _
                        "ROW_NUMBER() OVER (ORDER BY Last_Name) AS '#', " & _
                        "Employee_ID AS 'Employee ID', Last_Name AS 'Last Name', First_Name AS 'First Name', Middle_Name AS 'Middle Name', Gender, Date_of_Birth as 'Date of Birth', " & _
                        "Address, Hired_Date AS 'Hired Date',  Employment_Status AS 'Employment Status', Position, " & _
                        "Department, Civil_Status AS 'Civil Status', Starting_Daily_Rate AS 'Starting Daily Rate', Current_Daily_Rate AS 'Current Daily Rate', " & _
                        "No_of_Work_Days_per_Month AS 'Working Days', SSS_No AS 'SSS No', Philhealth_No AS 'PhilHealth No', TIN_No AS 'TIN No', Pag_ibig_No AS 'Pag-IBIG No' " & _
                        "FROM Employees " & _
                        "WHERE Employment_Status LIKE '%Probationary%';"
                .reportLabel.Text = "List of Probationary Employees"
            ElseIf cmb_reportType.Text = "Employees (Terminated/Resigned)" Then
                sqlSTR = "SELECT " & _
                        "ROW_NUMBER() OVER (ORDER BY Last_Name) AS '#', " & _
                        "Employee_ID AS 'Employee ID', Last_Name AS 'Last Name', First_Name AS 'First Name', Middle_Name AS 'Middle Name', Gender, Date_of_Birth as 'Date of Birth', " & _
                        "Address, Hired_Date AS 'Hired Date',  Employment_Status AS 'Employment Status', Position, " & _
                        "Department, Civil_Status AS 'Civil Status', Starting_Daily_Rate AS 'Starting Daily Rate', Current_Daily_Rate AS 'Current Daily Rate', " & _
                        "No_of_Work_Days_per_Month AS 'Working Days', SSS_No AS 'SSS No', Philhealth_No AS 'PhilHealth No', TIN_No AS 'TIN No', Pag_ibig_No AS 'Pag-IBIG No' " & _
                        "FROM Employees " & _
                        "WHERE Employment_Status LIKE '%Terminated%' or Employment_Status LIKE '%Resigned%';"
                .reportLabel.Text = "List of Terminated/Resigned Employees"
            ElseIf cmb_reportType.Text = "Leaves" Then
                sqlSTR = "SELECT " & _
                        "Date_Applied AS 'Date Applied', " & _
                        "Employees.Employee_ID AS 'Employee ID', " & _
                        "CONCAT(Last_Name, ', ', First_Name, ' ', SUBSTRING(Middle_Name, 1, 1), '.') AS 'Employee Name', " & _
                        "Leave_Category AS 'Leave Category', " & _
                        "Leave_Status AS 'Leave Status', " & _
                        "Leave_Start AS 'Leave Start', " & _
                        "Leave_End AS 'Leave End', " & _
                        "Leave_TotalDays AS 'Total Leave Days', " & _
                        "Leave_Reason AS 'Leave Reason', " & _
                        "Leave_Remarks AS 'Leave Remarks' " & _
                        "FROM Leaves " & _
                        "INNER JOIN Employees ON Employees.Employee_ID = Leaves.Employee_ID " & _
                        "WHERE (Leave_Start >= FORMAT(GETDATE(), 'yyyy-MM-dd') AND Leave_End >= FORMAT(GETDATE(), 'yyyy-MM-dd')) " & _
                        "ORDER BY Leave_Start, Employees.Employee_ID;"
                .reportLabel.Text = "Employee Upcoming Leaves"
            ElseIf cmb_reportType.Text = "Loan Balances" Then
                sqlSTR = "SELECT " & _
            "MAX(Employees.Employee_ID) AS 'Employee ID', " & _
            "MAX(CONCAT(Last_Name, ', ', First_Name, ' ', SUBSTRING(Middle_Name, 1, 1), '.')) AS 'Employee Name', " & _
            "MAX(CONCAT(Loan_Payment_Start_Date, ' to ', Loan_Payment_End_Date)) AS 'Payment Terms', " & _
            "MAX(Loan_Type) AS 'Loan Type', " & _
            "MAX(Loan_Reason) AS 'Loan Reason', " & _
            "FORMAT(MAX(Loan_Gross_Amount), 'N2') AS 'Loan Gross Amount', " & _
            "FORMAT(MAX(Suggested_PayPerCutoff), 'N2') AS 'Suggested Pay Per Cutoff', " & _
            "FORMAT(MAX(Loan_Gross_Amount) - SUM( " & _
            "CASE " & _
            "WHEN Payment_Posted = 'Yes' THEN COALESCE(Gross_Payment, 0) " & _
            "ELSE 0 " & _
            "END), 'N2') AS 'Balance Amount' " & _
            "FROM Loans " & _
            "LEFT JOIN Loan_Payments ON Loan_Payments.Loan_ID = Loans.Loan_ID " & _
            "INNER JOIN Employees ON Employees.Employee_ID = Loans.Employee_ID " & _
            "GROUP BY Loans.Loan_ID " & _
            "HAVING MAX(Loan_Gross_Amount) - SUM( " & _
            "CASE " & _
            "WHEN Payment_Posted = 'Yes' THEN COALESCE(Gross_Payment, 0) " & _
            "ELSE 0 " & _
            "END) > 0;"
                .reportLabel.Text = "Employee Loan Balances"
            ElseIf cmb_reportType.Text = "Loan Payments (Payroll)" Then
                sqlSTR = "SELECT " & _
                    "Payment_Date AS 'Payment Date', " & _
                    "CONCAT(Last_Name, ', ', First_Name, ' ', SUBSTRING(Middle_Name, 1, 1), '.') AS 'Employee Name', " & _
                    "FORMAT(Gross_Payment, 'N2') AS 'Gross Payment', " & _
                    "Loan_Payment_Start_Date AS 'Loan Payment Start Date', " & _
                    "Loan_Payment_End_Date AS 'Loan Payment End Date', " & _
                    "Loan_Reason AS 'Loan Reason', " & _
                    "Loan_Status AS 'Loan Status', " & _
                    "Loan_Type AS 'Loan Type' " & _
                    "FROM Loan_Payments " & _
                    "INNER JOIN Loans ON Loans.Loan_ID = Loan_Payments.Loan_ID " & _
                    "INNER JOIN Employees ON Employees.Employee_ID = Loans.Employee_ID " & _
                    "LEFT JOIN Payroll_Details on Payroll_Details.Payroll_Detail_ID = Loan_Payments.Payroll_Detail_ID " & _
                    "LEFT JOIN Payroll on Payroll.Payroll_ID = Payroll_Details.Payroll_ID " & _
                    "WHERE Cutoff_Date_Start >= '" & dt_from.Text & "' " & _
                    "AND Cutoff_Date_End <= '" & dt_to.Text & "' " & _
                    "and Payment_Posted = 'Yes' " & _
                    "ORDER BY Payment_Date, 'Employee Name';"
                .reportLabel.Text = "Loan Payments (Payroll) record from " & dt_from.Text & " to " & dt_to.Text
            ElseIf cmb_reportType.Text = "Loan Payments (Non-Payroll)" Then
                sqlSTR = "SELECT " & _
                    "Payment_Date AS 'Payment Date', " & _
                    "(Select CONCAT(Last_Name, ', ', First_Name, ' ', SUBSTRING(Middle_Name, 1, 1), '.') from Employees where Employees.Employee_ID = Loans.Employee_ID) as 'Employee Name', " & _
                    "FORMAT(Gross_Payment, 'N2') AS 'Gross Payment', " & _
                    "Loan_Payment_Start_Date AS 'Loan Payment Start Date', " & _
                    "Loan_Payment_End_Date AS 'Loan Payment End Date', " & _
                    "Loan_Reason AS 'Loan Reason', " & _
                    "Loan_Status AS 'Loan Status', " & _
                    "Loan_Type AS 'Loan Type' " & _
                    "FROM Loan_Payments " & _
                    "INNER JOIN Loans ON Loans.Loan_ID = Loan_Payments.Loan_ID " & _
                    "WHERE Payment_Date >= '" & dt_from.Text & "' " & _
                    "AND Payment_Date <= '" & dt_to.Text & "' " & _
                    "and Payment_Posted = 'Yes' " & _
                    "and COALESCE(Payroll_Detail_ID, '') = '' " & _
                    "ORDER BY Payment_Date, 'Employee Name';"
                .reportLabel.Text = "Loan Payments (Non-Payroll) record from " & dt_from.Text & " to " & dt_to.Text
            ElseIf cmb_reportType.Text = "New Employees" Then
                sqlSTR = "SELECT " & _
                    "Employee_ID AS 'Employee ID', " & _
                    "Last_Name AS 'Last Name', " & _
                    "First_Name AS 'First Name', " & _
                    "Middle_Name AS 'Middle Name', " & _
                    "Employment_Status AS 'Employment Status', " & _
                    "Position AS 'Position', " & _
                    "Department AS 'Department', " & _
                    "Civil_Status AS 'Civil Status', " & _
                    "Starting_Daily_Rate AS 'Starting Daily Rate', " & _
                    "No_of_Work_Days_per_Month AS 'No. of Work Days per Month', " & _
                    "SSS_No AS 'SSS No.', " & _
                    "Philhealth_No AS 'PhilHealth No.', " & _
                    "TIN_No AS 'TIN No.', " & _
                    "Pag_ibig_No AS 'Pag-IBIG No.' " & _
                    "FROM Employees; " & _
                    "where Hired_Date >= '" & dt_from.Text & "'"
                .reportLabel.Text = "New Employees hired starting " & dt_from.Text
            ElseIf cmb_reportType.Text = "New Loans" Then
                sqlSTR = "SELECT " & _
                    "Loan_Date AS 'Loan Date', " & _
                    "CONCAT(Last_Name, ', ', First_Name, ' ', SUBSTRING(Middle_Name, 1, 1), '.') AS 'Employee Name', " & _
                    "Loan_Type AS 'Loan Type', " & _
                    "Loan_Reason AS 'Loan Reason', " & _
                    "FORMAT(Loan_Gross_Amount, 'N2') AS 'Loan Gross Amount', " & _
                    "CONCAT(Loan_Payment_Start_Date, ' to ', Loan_Payment_End_Date) AS 'Payment Terms', " & _
                    "FORMAT(Suggested_PayPerCutoff, 'N2') AS 'Suggested Pay Per Cutoff' " & _
                    "FROM Loans " & _
                    "INNER JOIN Employees ON Employees.Employee_ID = Loans.Employee_ID " & _
                    "WHERE Loan_Date >= '" & dt_from.Text & "' " & _
                    "AND Loan_Date <= '" & dt_to.Text & "' " & _
                    "ORDER BY Last_Name;"
                .reportLabel.Text = "Employees Loans record from " & dt_from.Text & " to " & dt_to.Text
            ElseIf cmb_reportType.Text = "Payroll" Then
                sqlSTR = "SELECT " & _
                    "CONCAT(MIN(Cutoff_Date_Start), ' to ', MAX(Cutoff_Date_End)) AS 'Cutoff Period', " & _
                    "Employees.Employee_ID AS 'ID', " & _
                    "MAX(CONCAT(Last_Name, ', ', First_Name, ' ', SUBSTRING(Middle_Name, 1, 1), '.')) AS 'Name', " & _
                    "SUM(numRegular) AS 'Regular Day(s)', " & _
                    "SUM(numSpecial) AS 'Special Day(s)', " & _
                    "SUM(numField) AS 'Field Day(s)', " & _
                    "SUM(numHoliday) AS 'Holiday Day(s)', " & _
                    "SUM(numLeave) AS 'Leave Day(s)', " & _
                    "SUM(numOvertime) AS 'Overtime Min(s)', " & _
                    "SUM(numNight_diff) AS 'Night Diff. Min(s)', " & _
                    "SUM(totalRegular) AS 'Regular Pay', " & _
                    "SUM(totalSpecial) AS 'Special Pay', " & _
                    "SUM(totalField) AS 'Field Pay', " & _
                    "SUM(totalHoliday) AS 'Holiday Pay', " & _
                    "SUM(totalLeave) AS 'Leave Pay', " & _
                    "SUM(totalOvertime) AS 'Overtime Pay', " & _
                    "SUM(totalNight_diff) AS 'Night Diff. Pay', " & _
                    "SUM(COALESCE(totalSSS, 0)) AS 'SSS', " & _
                    "SUM(totalPhilhealth) AS 'Philhealth', " & _
                    "SUM(totalPagIbig) AS 'Pag-ibig', " & _
                    "SUM(totalTax) AS 'Tax', " & _
                    "SUM(totalInsurance) AS 'Insurance', " & _
                    "SUM(totalCharge) AS 'Charge', " & _
                    "SUM(totalNumAbsent) AS 'Total Absent(s)', " & _
                    "SUM(totalNumLate) AS 'Total Late(s)', " & _
                    "SUM(numLate) AS 'Late Min(s)', " & _
                    "SUM(numUndertime) AS 'Undertime Min(s)', " & _
                    "FORMAT(SUM(totalLate), 'N2') AS 'Total Late', " & _
                    "FORMAT(SUM(totalUndertime), 'N2') AS 'Total Undertime', " & _
                    "FORMAT(SUM(totalAddSpecial), 'N2') AS 'Add Special Pay', " & _
                    "FORMAT(SUM(totalAddField), 'N2') AS 'Add Field Pay', " & _
                    "FORMAT(SUM(totalAddIncentive), 'N2') AS 'Add Incentive', " & _
                    "FORMAT(SUM(totalAddAllowance), 'N2') AS 'Add Allowance', " & _
                    "FORMAT(SUM(grandTotal_Basic), 'N2') AS 'Total Basic', " & _
                    "FORMAT(SUM(grandTotal_Additional), 'N2') AS 'Total Additional', " & _
                    "FORMAT(SUM(grandTotal_Gross), 'N2') AS 'Total Gross', " & _
                    "FORMAT(SUM(grandTotal_Deduction), 'N2') AS 'Total Deductions', " & _
                    "FORMAT(SUM(grandTotal_Loan), 'N2') AS 'Total Loan', " & _
                    "FORMAT(SUM(grandTotal_Net), 'N2') AS 'Total Net' " & _
                    "FROM Payroll_Details " & _
                    "INNER JOIN Payroll ON Payroll.Payroll_ID = Payroll_Details.Payroll_ID " & _
                    "INNER JOIN Employees ON Employees.Employee_ID = Payroll_Details.Employee_ID " & _
                    "WHERE Cutoff_Date_Start >= '" & dt_from.Text & "' " & _
                    "AND Cutoff_Date_End <= '" & dt_to.Text & "' " & _
                    "GROUP BY Employees.Employee_ID " & _
                    "ORDER BY Name; "
                .reportLabel.Text = "Employees Payroll record from " & dt_from.Text & " to " & dt_to.Text
            Else
                MsgBox("Invalid report type selected.", MsgBoxStyle.Information, msgBox_header)
                Exit Sub
            End If

            FillListView(ExecuteSQLQuery(sqlSTR), .lst_report, 0)

            If .lst_report.Items.Count = 0 Then
                MsgBox("No data available. Please double-check the entered dates and try again.", MsgBoxStyle.Information, msgBox_header)
                Exit Sub
            Else
                ListView_ToClipboard(.lst_report)
            End If

            If cmb_reportType.Text = "Deductions" Then
                totalsListView(.lst_report, "3, 4, 5, 6, 7")
            ElseIf cmb_reportType.Text = "Loan Balances" Then
                totalsListView(.lst_report, "7")
            ElseIf cmb_reportType.Text = "Loan Payments (Payroll)" Then
                totalsListView(.lst_report, "2")
            ElseIf cmb_reportType.Text = "Loan Payments (Non-Payroll)" Then
                totalsListView(.lst_report, "2")
            ElseIf cmb_reportType.Text = "New Loans" Then
                totalsListView(.lst_report, "4")
            ElseIf cmb_reportType.Text = "Payroll" Then
                totalsListView(.lst_report, "33, 34, 35, 36, 37, 38")
            End If


        End With
        Me.Close()
    End Sub

    Private Sub cmb_reportType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_reportType.SelectedIndexChanged
        If cmb_reportType.Text = "Employee Upcoming Birthdays" OrElse
       cmb_reportType.Text = "Employees (All)" OrElse
       cmb_reportType.Text = "Employees (Regular)" OrElse
       cmb_reportType.Text = "Employees (Probationary)" OrElse
       cmb_reportType.Text = "Employees (Terminated/Resigned)" OrElse
       cmb_reportType.Text = "Leaves" OrElse
       cmb_reportType.Text = "Loan Balances" OrElse
       cmb_reportType.Text = "New Loans" Then

            groupboxDates.Enabled = False

        ElseIf cmb_reportType.Text = "New Employees" Then
            dt_to.Enabled = False
        Else
            groupboxDates.Enabled = True
            dt_to.Enabled = True
        End If
    End Sub
End Class