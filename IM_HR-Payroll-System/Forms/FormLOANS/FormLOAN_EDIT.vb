Public Class FormLOAN_EDIT
    Dim Loan_ID, employee_id As Integer
    Private Sub FormLOAN_EDIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loan_ID = xID1
        sqlSTR = "Select * from employees where Employment_Status != 'Inactive'"
        FILLComboBox_Employee(sqlSTR, cmb_employees)

        sqlSTR = "select *, CONCAT(Loans.Employee_ID, ' - ', Last_Name, ', ', First_Name, ', ', Middle_Name) as EmployeeDetails from Loans INNER JOIN Employees on Employees.Employee_ID = Loans.Employee_ID where Loan_ID = " & Loan_ID
        ExecuteSQLQuery(sqlSTR)

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
    End Sub
End Class