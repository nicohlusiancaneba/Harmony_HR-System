﻿Public Class FormLOANS

    Private Sub FormLOANS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = MDIMain.Panel2.Height - 22
        Me.Width = MDIMain.Panel2.Width

        lst_loans.Width = Me.Width - 20
        lst_loans.Height = Me.Height - 120

        RefreshLoansList()
    End Sub

    Private Sub RefreshLoansList()
        sqlSTR = "SELECT Loan_ID AS 'Loan ID', Loans.Employee_ID AS 'Employee ID', Loan_Date AS 'Loan Date', Loan_Net_Amount AS 'Loan Net Amount', Loan_Interest_Rate AS 'Loan Interest Rate', Loan_Gross_Amount AS 'Loan Gross Amount', " & _
            " Loan_Payment_Start_Date AS 'Loan Payment Start Date', Loan_Payment_End_Date AS 'Loan Payment End Date', Loan_Reason AS 'Loan Reason', Loan_Remarks AS 'Loan Remarks', Loan_Status AS 'Loan Status' FROM Loans INNER JOIN Employees ON Employees.Employee_ID = Loans.Employee_ID"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_loans, 0)
    End Sub

    Private Sub btn_newLoan_Click(sender As Object, e As EventArgs) Handles btn_newLoan.Click
        FormLOAN_NEW.ShowDialog()
        RefreshLoansList()
    End Sub

    Private Sub EditEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEmployeeToolStripMenuItem.Click
        ShowForm1(FormLOAN_EDIT, "edit", lst_loans.FocusedItem.Text)
    End Sub
End Class