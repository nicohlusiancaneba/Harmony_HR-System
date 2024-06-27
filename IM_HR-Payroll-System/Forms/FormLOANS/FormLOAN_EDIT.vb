Public Class FormLOAN_EDIT
    Dim Loan_ID, employee_id As Integer
    Private Sub FormLOAN_EDIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loan_ID = xID1
        sqlSTR = "Select * from employees where Employment_Status != 'Inactive'"
        FILLComboBox_Employee(sqlSTR, cmb_employees)

        sqlSTR = "select *, Loans.Employee_ID as EmployeeID, CONCAT(Loans.Employee_ID, ' - ', Last_Name, ', ', First_Name, ', ', Middle_Name) as EmployeeDetails from Loans INNER JOIN Employees on Employees.Employee_ID = Loans.Employee_ID where Loan_ID = " & Loan_ID
        ExecuteSQLQuery(sqlSTR)
        employee_id = sqlDT.Rows(0)("EmployeeID")
        cmb_employees.Text = sqlDT.Rows(0)("EmployeeDetails")
        txt_netAmount.Text = sqlDT.Rows(0)("Loan_Net_Amount")
        txt_grossAmount.Text = sqlDT.Rows(0)("Loan_Gross_Amount")
        txt_interestRate.Text = sqlDT.Rows(0)("Loan_Interest_Rate")
        dt_payStartDate.Text = sqlDT.Rows(0)("Loan_Payment_Start_Date")
        dt_payEndDate.Text = sqlDT.Rows(0)("Loan_Payment_End_Date")
        txt_loanReason.Text = sqlDT.Rows(0)("Loan_Reason")
        txt_loanRemarks.Text = sqlDT.Rows(0)("Loan_Remarks")
        cmb_loanStatus.Text = sqlDT.Rows(0)("Loan_Status")
        cmb_loanType.Text = sqlDT.Rows(0)("Loan_Type")

        RefreshLoanPaymentList()
    End Sub

    Private Sub RefreshLoanPaymentList()
        sqlSTR = "select Loan_Payment_ID as ID, Loan_ID as 'Loan ID', Payroll_Detail_ID as 'Payroll ID', Payment_Date as 'Payment Date', " & _
                "Net_Payment as 'Net Payment', CONCAT(Interest_Rate,'%') as 'Interest Rate', Gross_Payment as 'Gross Payment' from Loan_Payments where Loan_ID=" & Loan_ID
        FillListView(ExecuteSQLQuery(sqlSTR), lst_loanPayment, 0)
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_newLoan_Click(sender As Object, e As EventArgs) Handles btn_newLoan.Click
        ShowForm2(FormLOAN_PAYMENT, "add", Loan_ID, 0)
        RefreshLoanPaymentList()
    End Sub
End Class