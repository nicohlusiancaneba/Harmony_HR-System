Public Class FormPAYROLL

    Private Sub FormPAYROLL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = MDIMain.Panel2.Height - 22
        Me.Width = MDIMain.Panel2.Width
        lst_payroll.Width = Me.Width - 20
        lst_payroll.Height = Me.Height - 80






        rb_Pending.Checked = True
        RefreshPayrollList()
    End Sub


    Public Sub RefreshPayrollList()
        'Dim status As String = ""
        'If rb_All.Checked Then
        '    status = ""
        'ElseIf rb_Approved.Checked Then
        '    status = " where COALESCE(Payroll_Approved, 'No') = 'Yes' "
        'ElseIf rb_Pending.Checked Then
        '    status = " where COALESCE(Payroll_Approved, 'No') = 'No' "
        'End If


        sqlSTR = "SELECT " & _
    "Payroll_ID AS 'Payroll ID', " & _
    "Payroll_Date AS 'Payroll Date', " & _
    "CONCAT(Cutoff_Date_Start, ' to ', Cutoff_Date_End) AS 'Cutoff Period', " & _
    "Total_GrossPay AS 'Total Gross Pay', " & _
    "Total_NetPay AS 'Total Net Pay', " & _
    "Total_Deductions AS 'Total Deductions', " & _
    "Total_LoansPaid AS 'Total Loans Paid', " & _
    "Payroll_Remarks AS 'Remarks', " & _
    "Encoded_by AS 'Encoded By', " & _
    "COALESCE(Payroll_Approved, 'No') AS 'Payroll Approved', " & _
    "Approved_by AS 'Approved By' " & _
    "FROM Payroll order by COALESCE(Payroll_Approved, 'No'), Payroll_ID "
        FillListView(ExecuteSQLQuery(sqlSTR), lst_payroll, 0)

        For Each item As ListViewItem In lst_payroll.Items
            If item.SubItems(9).Text = "No" Then
                item.ForeColor = Color.Red
            Else
                item.ForeColor = Color.Black
            End If
        Next
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
        If lst_payroll.FocusedItem.SubItems(9).Text = "No" Then
            If MsgBox("Do you want to delete this payroll record?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, msgBox_header) = MsgBoxResult.Yes Then

                sqlSTR = "DELETE lp " & _
                        "FROM Loan_Payments lp " & _
                        "INNER JOIN Payroll_Details pd ON pd.Payroll_Detail_ID = lp.Payroll_Detail_ID " & _
                        "INNER JOIN Payroll p ON p.Payroll_ID = pd.Payroll_ID " & _
                        "WHERE lp.Payment_Posted = 'No' AND pd.Payroll_ID =" & lst_payroll.FocusedItem.Text
                ExecuteSQLQuery(sqlSTR)

                sqlSTR = "Delete from Payroll where Payroll_ID =" & lst_payroll.FocusedItem.Text
                ExecuteSQLQuery(sqlSTR)

                sqlSTR = "Delete from Payroll_Details where Payroll_ID =" & lst_payroll.FocusedItem.Text
                ExecuteSQLQuery(sqlSTR)

                

                MsgBox("Deleted Payroll record.", MsgBoxStyle.Information, msgBox_header)
            End If
        Else
            MsgBox("Cannot delete approved Payroll record.", MsgBoxStyle.Information, msgBox_header)
        End If

        RefreshPayrollList()
    End Sub

    Private Sub lst_payroll_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_payroll.MouseDoubleClick
        ShowForm1(FormPAYROLL_ADD, "edit", lst_payroll.FocusedItem.Text)
        RefreshPayrollList()
    End Sub


    Private Sub rb_All_CheckedChanged(sender As Object, e As EventArgs) Handles rb_All.CheckedChanged
        RefreshPayrollList()
    End Sub

    Private Sub rb_Pending_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Pending.CheckedChanged
        RefreshPayrollList()
    End Sub

    Private Sub rb_Approved_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Approved.CheckedChanged
        RefreshPayrollList()
    End Sub
End Class