Public Class FormPAYROLL
    Dim whereSQL As String
    Private Sub FormPAYROLL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = MDIMain.Panel2.Height - 22
        Me.Width = MDIMain.Panel2.Width
        lst_payroll.Width = Me.Width - 20
        lst_payroll.Height = Me.Height - 80


        whereSQL = " and Cutoff_Date_Start >= DATEADD(DAY, -6, EOMONTH(GETDATE(), -1)) and Cutoff_Date_End <= EOMONTH(GETDATE()) "



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
    "Checked_by AS 'Checked By', " & _
    "COALESCE(Payroll_Approved, 'No') AS 'Payroll Approved', " & _
    "Approved_by AS 'Approved By' " & _
    "FROM Payroll where 1=1 " & whereSQL & " order by COALESCE(Payroll_Approved, 'No'), Payroll_ID "
        FillListView(ExecuteSQLQuery(sqlSTR), lst_payroll, 0)

        For Each item As ListViewItem In lst_payroll.Items
            If item.SubItems(10).Text = "No" Then
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
        If lst_payroll.FocusedItem.SubItems(10).Text = "No" Then
            If MsgBox("Do you want to delete this payroll record?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, msgBox_header) = MsgBoxResult.Yes Then

                sqlSTR = "DELETE Loan_Payments " & _
                    "where Loan_Payment_ID in (select Loan_Payment_ID from Loan_Payments " & _
                    "inner join Payroll_Details on Payroll_Details.Payroll_Detail_ID = Loan_Payments.Payroll_Detail_ID " & _
                    "inner join Payroll on Payroll.Payroll_ID = Payroll_Details.Payroll_ID " & _
                    "where Payroll.Payroll_ID = " & lst_payroll.FocusedItem.Text & ")"
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

    Private Sub btn_refreshPayroll_Click(sender As Object, e As EventArgs) Handles btn_refreshPayroll.Click
        whereSQL = " and Cutoff_Date_Start >= DATEADD(DAY, -6, EOMONTH(GETDATE(), -1)) and Cutoff_Date_End <= EOMONTH(GETDATE()) "
        RefreshPayrollList()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        grpFilter.Visible = False
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        grpFilter.Visible = False

        whereSQL = " and Cutoff_Date_Start >= '" & dt_start.Text & "' and Cutoff_Date_End <= '" & dt_end.Text & "' "

        RefreshPayrollList()
    End Sub

   

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        grpFilter.Visible = True
        CenterGroupBoxRelativeToListView(grpFilter, lst_payroll)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub dt_end_ValueChanged(sender As Object, e As EventArgs) Handles dt_end.ValueChanged

    End Sub

    Private Sub dt_start_ValueChanged(sender As Object, e As EventArgs) Handles dt_start.ValueChanged

    End Sub

    Private Sub GenerateMultiplePayrollBOBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateMultiplePayrollBOBToolStripMenuItem.Click
        FormPAYROLL_GENERATE_BOB.ShowDialog()
    End Sub
End Class