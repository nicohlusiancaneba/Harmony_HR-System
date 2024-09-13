Public Class FormLOANS

    Private Sub FormLOANS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = MDIMain.Panel2.Height - 22
        Me.Width = MDIMain.Panel2.Width

        lst_loans.Width = Me.Width - 20
        lst_loans.Height = Me.Height - 120

        rb_Active.Checked = True

        RefreshLoansList()
    End Sub

    Private Sub RefreshLoansList()
        Dim status As String = ""
        If rb_All.Checked Then
            status = ""
        ElseIf rb_Active.Checked Then
            status = "Active"
        ElseIf rb_Paid.Checked Then
            status = "Paid"
        End If


        sqlSTR = "SELECT Loan_ID AS 'Loan ID', Loans.Employee_ID AS 'Employee ID', CONCAT(Last_Name, ', ', First_Name) as Employee, Loan_Date AS 'Loan Date', Loan_Net_Amount AS 'Loan Net Amount', CONCAT(Loan_Interest_Rate, '%') AS 'Loan Interest Rate', Loan_Gross_Amount AS 'Loan Gross Amount', " & _
            " Loan_Payment_Start_Date AS 'Loan Payment Start Date', Loan_Payment_End_Date AS 'Loan Payment End Date', Loan_Reason AS 'Loan Reason', Loan_Remarks AS 'Loan Remarks', Loan_Status AS 'Loan Status' FROM Loans INNER JOIN Employees ON Employees.Employee_ID = Loans.Employee_ID where Loan_Status like '%" & status & "%'"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_loans, 0)
    End Sub

    Private Sub btn_newLoan_Click(sender As Object, e As EventArgs) Handles btn_newLoan.Click
        FormLOAN_NEW.ShowDialog()
        RefreshLoansList()
    End Sub

    Private Sub EditEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEmployeeToolStripMenuItem.Click
        ShowForm1(FormLOAN_EDIT, "edit", lst_loans.FocusedItem.Text)
        RefreshLoansList()
    End Sub

    Private Sub lst_loans_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_loans.MouseDoubleClick
        ShowForm1(FormLOAN_EDIT, "edit", lst_loans.FocusedItem.Text)
        RefreshLoansList()
    End Sub

    Private Sub DeleteEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeToolStripMenuItem.Click
        If MsgBox("Do you want to delete this loan record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, msgBox_header) = MsgBoxResult.Yes Then
            sqlSTR = "select Loan_Payment_ID from Loan_Payments where loan_id =" & lst_loans.FocusedItem.Text
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                MsgBox("The loan record cannot be deleted because there are active payments associated with it.", MsgBoxStyle.Critical, msgBox_header)

            Else
                sqlSTR = "Delete from Loans where Loan_ID =" & lst_loans.FocusedItem.Text
                ExecuteSQLQuery(sqlSTR)

                MsgBox("Deleted loan record.", MsgBoxStyle.Information, msgBox_header)
            End If


        End If
        RefreshLoansList()
    End Sub

    Private Sub rb_All_CheckedChanged(sender As Object, e As EventArgs) Handles rb_All.CheckedChanged
        RefreshLoansList()
    End Sub

    Private Sub rb_Active_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Active.CheckedChanged
        RefreshLoansList()
    End Sub

    Private Sub rb_Paid_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Paid.CheckedChanged
        RefreshLoansList()
    End Sub
End Class