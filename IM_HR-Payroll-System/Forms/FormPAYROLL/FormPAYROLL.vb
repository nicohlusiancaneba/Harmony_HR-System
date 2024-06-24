Public Class FormPAYROLL

    Private Sub FormPAYROLL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = MDIMain.Panel2.Height - 22
        Me.Width = MDIMain.Panel2.Width
        lst_payroll.Width = Me.Width - 20
        lst_payroll.Height = Me.Height - 120







        RefreshPayrollList()
    End Sub


    Private Sub RefreshPayrollList()
        sqlSTR = "SELECT " & _
    "Payroll_ID AS 'Payroll ID', " & _
    "Payroll_Date AS 'Payroll Date', " & _
    "Cutoff_Period AS 'Cutoff Period', " & _
    "Total_GrossPay AS 'Total Gross Pay', " & _
    "Total_NetPay AS 'Total Net Pay', " & _
    "Total_Deductions AS 'Total Deductions', " & _
    "Total_LoansPaid AS 'Total Loans Paid', " & _
    "Payroll_Remarks AS 'Remarks', " & _
    "Encoded_by AS 'Encoded By', " & _
    "Payroll_Approved AS 'Payroll Approved', " & _
    "Approved_by AS 'Approved By' " & _
    "FROM Payroll;"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_payroll, 0)
    End Sub

    Private Sub btn_newPayroll_Click(sender As Object, e As EventArgs) Handles btn_newPayroll.Click
        ShowForm1(FormPAYROLL_ADD, "add", 0)
        RefreshPayrollList()
    End Sub

    Private Sub EditEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEmployeeToolStripMenuItem.Click
        ShowForm1(FormPAYROLL_ADD, "edit", lst_payroll.FocusedItem.Text)
        RefreshPayrollList()
    End Sub

    Private Sub DeleteEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeToolStripMenuItem.Click

    End Sub
End Class