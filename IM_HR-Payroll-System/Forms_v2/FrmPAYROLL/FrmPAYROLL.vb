Public Class FrmPAYROLL
    Public whereSQL, formAction, payroll_ID As String
    Private Sub FrmPAYROLL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeHelper.ApplyHighlight(Me)
        sqlSTR = "select '1' as ID, CONCAT(COALESCE(Payroll_Month, DATENAME(MONTH, Cutoff_Date_End)), ' ', Year(Cutoff_Date_End)) as Month_Covered from Payroll " & _
                    "group by CONCAT(COALESCE(Payroll_Month, DATENAME(MONTH, Cutoff_Date_End)), ' ', Year(Cutoff_Date_End)) " & _
                    "order by MAX(Cutoff_Date_End) desc;"
        FILLComboBox2(sqlSTR, cmb_monthApplicable)


        whereSQL = " and Cutoff_Date_Start >= DATEADD(DAY, -6, EOMONTH(GETDATE(), -1)) and Cutoff_Date_End <= EOMONTH(GETDATE()) "


        RefreshPayrollList()
    End Sub




    Public Sub RefreshPayrollList()
        sqlSTR = "SELECT " & _
    "Payroll_ID AS 'Payroll ID', " & _
    "Payroll_Date AS 'Payroll Date', " & _
    "COALESCE(Payroll_Type, 'Others') as Type, " & _
    "CONCAT(COALESCE(Payroll_Month, DATENAME(MONTH, Cutoff_Date_End)), ' ', Year(Cutoff_Date_End)) as 'Month Covered', " & _
    "CONCAT(Cutoff_Date_Start, ' to ', Cutoff_Date_End) AS 'Cutoff Period', " & _
    "Payroll_Remarks AS 'Particulars', " & _
    "Total_GrossPay AS 'Total Gross Pay', " & _
    "Total_NetPay AS 'Total Net Pay', " & _
    "Total_Deductions AS 'Total Deductions', " & _
    "Total_LoansPaid AS 'Total Loans Paid', " & _
    "Encoded_by AS 'Encoded By', " & _
    "Checked_by AS 'Checked By', " & _
    "COALESCE(Payroll_Approved, 'No') AS 'Payroll Approved', " & _
    "Approved_by AS 'Approved By' " & _
    "FROM Payroll where 1=1 " & whereSQL & " order by COALESCE(Payroll_Approved, 'No'), Payroll_ID "
        FillListView(ExecuteSQLQuery(sqlSTR), lst_payroll, Main.sidebar_images, 6)

        For Each item As ListViewItem In lst_payroll.Items
            If item.SubItems(12).Text = "No" Then
                item.ForeColor = Color.Red
            Else
                item.ForeColor = Color.Black
            End If
        Next
    End Sub

    'Private Sub btn_newPayroll_Click(sender As Object, e As EventArgs)
    '    ShowForm1(FrmPAYROLL_DETAILS, "add", 0)
    '    RefreshPayrollList()
    'End Sub

    'Private Sub EditEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    ShowForm1(FrmPAYROLL_DETAILS, "edit", lst_payroll.FocusedItem.Text)
    '    RefreshPayrollList()
    'End Sub

    'Private Sub DeleteEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    If lst_payroll.FocusedItem.SubItems(10).Text = "No" Then
    '        If MsgBox("Do you want to delete this payroll record?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, msgBox_header) = MsgBoxResult.Yes Then

    '            sqlSTR = "DELETE Loan_Payments " & _
    '                "where Loan_Payment_ID in (select Loan_Payment_ID from Loan_Payments " & _
    '                "inner join Payroll_Details on Payroll_Details.Payroll_Detail_ID = Loan_Payments.Payroll_Detail_ID " & _
    '                "inner join Payroll on Payroll.Payroll_ID = Payroll_Details.Payroll_ID " & _
    '                "where Payroll.Payroll_ID = " & lst_payroll.FocusedItem.Text & ")"
    '            ExecuteSQLQuery(sqlSTR)

    '            sqlSTR = "Delete from Payroll where Payroll_ID =" & lst_payroll.FocusedItem.Text
    '            ExecuteSQLQuery(sqlSTR)

    '            sqlSTR = "Delete from Payroll_Details where Payroll_ID =" & lst_payroll.FocusedItem.Text
    '            ExecuteSQLQuery(sqlSTR)



    '            MsgBox("Deleted Payroll record.", MsgBoxStyle.Information, msgBox_header)
    '        End If
    '    Else
    '        MsgBox("Cannot delete approved Payroll record.", MsgBoxStyle.Information, msgBox_header)
    '    End If

    '    RefreshPayrollList()
    'End Sub

    Private Sub lst_payroll_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_payroll.MouseDoubleClick
        formAction = "edit"

        FrmPAYROLL_DETAILS.ShowDialog()

        RefreshPayrollList()
    End Sub



   




    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        grpFilter.Visible = False
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        grpFilter.Visible = False

        checkbox_CheckedValue(cb_payrollID, " and Payroll.Payroll_ID = '" & txt_payrollID.Text & "' ")
        checkbox_CheckedValue(cb_type, " and COALESCE(Payroll_Type, 'Others') = '" & cmb_type.Text & "' ")
        checkbox_CheckedValue(cb_monthApplicable, " and CONCAT(COALESCE(Payroll_Month, DATENAME(MONTH, Cutoff_Date_End)), ' ', Year(Cutoff_Date_End)) = '" & cmb_monthApplicable.Text & "' ")
        checkbox_CheckedValue(cb_remarks, " and Payroll_Remarks like '%" & txt_remarks.Text & "%' ")
        checkbox_CheckedValue(cb_payrollDate, " and Payroll_Date between '" & dt_fromPayroll.Text & "' and '" & dt_toPayroll.Text & "' ")
        checkbox_CheckedValue(cb_cutoffPeriod, " and Cutoff_Date_Start >= '" & dt_fromCutoff.Text & "' and Cutoff_Date_End <= '" & dt_toCutoff.Text & "' ")
        checkbox_CheckedValue(cb_encoder, " and Encoded_by = '" & txt_encoder.Text & "' ")
        checkbox_CheckedValue(cb_approver, " and Approved_by = '" & txt_approver.Text & "' ")
        checkbox_CheckedValue(cb_approved, " and Payroll_Approved = '" & cmb_approved.Text & "' ")


        whereSQL = cb_payrollID.Tag & cb_type.Tag & cb_monthApplicable.Tag & cb_remarks.Tag & cb_payrollDate.Tag & cb_cutoffPeriod.Tag & cb_encoder.Tag & cb_approver.Tag & cb_approved.Tag

        If whereSQL = "" Then
            MsgBox("Search filter too broad. Try again.")
            Exit Sub
        End If

        RefreshPayrollList()


    End Sub
End Class