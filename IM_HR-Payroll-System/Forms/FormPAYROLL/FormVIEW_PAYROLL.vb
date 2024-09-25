Public Class FormVIEW_PAYROLL
    Dim payroll_id As Integer
    Private Sub FormVIEW_PAYROLL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_payrollView.Clear()
        payroll_id = xID1
        RefreshList()
    End Sub

    Private Sub RefreshList()
        sqlSTR = "select Payroll_Details.Employee_ID as 'Employee ID', CONCAT(Last_Name, ', ', First_Name, ' ', Left(Middle_Name, 1), '.') as 'Employee', " & _
            "payRegular as '[A] Daily Rate', numRegular as '[A] Day(s)', totalRegular as '[A] Subtotal', " & _
            "numHoliday as '[B] Holiday', totalHoliday as '[B] Subtotal', " & _
            "paySpecial as '[C] Special Rate', numSpecial as '[C] Day(s)', totalSpecial as '[C] Subtotal', " & _
            "payField as '[D] Field Rate', numField as '[D] Day(s)', totalField as '[D] Subtotal', " & _
            "numOvertime as '[E] Overtime (Min.)', totalOvertime as '[E] Subtotal', " & _
            "numNight_diff as '[F] Night Diff. (Min.)', totalNight_diff as '[F] Subtotal', " & _
            "grandTotal_Basic as 'Total Basic', " & _
            "totalAddSpecial as '[G] Special+', totalAddField as '[G] Field+', totalAddIncentive as '[G] Incentive', totalAddAllowance as '[G] Allowance', " & _
            "grandTotal_Additional as 'Total Additional', " & _
            "grandTotal_Gross as 'Total Gross', " & _
            "totalSSS as '[H] SSS', totalPhilhealth as '[H] Philhealth', totalPagIbig as '[H] Pagibig', totalTax as '[H] Tax', totalInsurance as '[H] Insurance', totalCharge as '[H] Charge', " & _
            "numLate as '[I] Late', totallate as '[I] Subtotal', " & _
            "numUndertime as '[J] Undertime', totalUndertime as '[J] Subtotal', " & _
            "grandTotal_Deduction as 'Total Deductions', " & _
            "COALESCE((select sum(Gross_Payment) from Loan_Payments as LP " & _
            "inner join Loans on Loans.Loan_ID = LP.Loan_ID " & _
            "where Loan_Type = 'Cash Advance' and LP.Payroll_Detail_ID = Payroll_Details.Payroll_Detail_ID), 0.00) as '[K] Cash Advance', " & _
            "COALESCE((select sum(Gross_Payment) from Loan_Payments as LP " & _
            "inner join Loans on Loans.Loan_ID = LP.Loan_ID " & _
            "where Loan_Type = 'Personal' and LP.Payroll_Detail_ID = Payroll_Details.Payroll_Detail_ID), 0.00) as '[K] Personal Loan', " & _
            "COALESCE((select sum(Gross_Payment) from Loan_Payments as LP " & _
            "inner join Loans on Loans.Loan_ID = LP.Loan_ID " & _
            "where Loan_Type = 'Emergency' and LP.Payroll_Detail_ID = Payroll_Details.Payroll_Detail_ID), 0.00) as '[K] Emergency Loan', " & _
            "COALESCE((select sum(Gross_Payment) from Loan_Payments as LP " & _
            "inner join Loans on Loans.Loan_ID = LP.Loan_ID " & _
            "where Loan_Type = 'Product' and LP.Payroll_Detail_ID = Payroll_Details.Payroll_Detail_ID), 0.00) as '[K] Product Loan', " & _
            "grandTotal_Loan as 'Total Loan Payment', " & _
            "grandTotal_Net as 'Grand Total (NET)', " & _
            "REPLACE(RTRIM(payroll_employeeRemarks), CHAR(10), ' / ') as 'Remarks' " & _
            "from Payroll_Details " & _
            "INNER JOIN Payroll on Payroll.Payroll_ID = Payroll_Details.Payroll_ID " & _
            "INNER JOIN Employees on Employees.Employee_ID = Payroll_Details.Employee_ID " & _
            "where Payroll_Details.Payroll_Id = " & xID1 & _
            " order by Payroll_Details.Employee_ID"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_payrollView, 0)



        For Each item As ListViewItem In lst_payrollView.Items
            For i As Integer = 2 To 40
                Dim value As Decimal
                If Decimal.TryParse(item.SubItems(i).Text, value) Then
                    If value = 0D Then
                        item.SubItems(i).Text = "" ' or "" for completely blank
                    Else
                        item.SubItems(i).Text = value.ToString("N2")
                    End If
                End If
            Next
        Next
        ListView_ToClipboard(lst_payrollView)
        MsgBox("Data copied to clipboard.", MsgBoxStyle.Information, msgBox_header)
    End Sub


End Class