Public Class FormLOAN_EDIT
    Dim Loan_ID, employee_id As Integer
    Private Sub FormLOAN_EDIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loan_ID = xID1


        sqlSTR = "select *, Loans.Employee_ID as EmployeeID, CONCAT(Loans.Employee_ID, ' - ', Last_Name, ', ', First_Name, ', ', Middle_Name) as EmployeeDetails from Loans INNER JOIN Employees on Employees.Employee_ID = Loans.Employee_ID where Loan_ID = " & Loan_ID
        ExecuteSQLQuery(sqlSTR)
        employee_id = sqlDT.Rows(0)("EmployeeID")
        txt_employees.Text = sqlDT.Rows(0)("EmployeeDetails")
        txt_netAmount.Text = sqlDT.Rows(0)("Loan_Net_Amount")
        txt_grossAmount.Text = sqlDT.Rows(0)("Loan_Gross_Amount")
        txt_interestRate.Text = sqlDT.Rows(0)("Loan_Interest_Rate")
        dt_payStartDate.Text = sqlDT.Rows(0)("Loan_Payment_Start_Date")
        dt_payEndDate.Text = sqlDT.Rows(0)("Loan_Payment_End_Date")
        txt_loanReason.Text = sqlDT.Rows(0)("Loan_Reason")
        txt_loanRemarks.Text = sqlDT.Rows(0)("Loan_Remarks")
        cmb_loanStatus.Text = sqlDT.Rows(0)("Loan_Status")
        cmb_loanType.Text = sqlDT.Rows(0)("Loan_Type")
        txt_suggestedDeduction.Text = sqlDT.Rows(0)("Suggested_PayPerCutoff").ToString
        RefreshLoanPaymentList()
    End Sub

    Private Sub RefreshLoanPaymentList()
        sqlSTR = "select Loan_Payment_ID as ID, Loan_ID as 'Loan ID', Payroll_Detail_ID as 'Payroll Detail ID', Payment_Date as 'Payment Date', " & _
                "Gross_Payment as 'Payment', Payment_Remarks as Remarks, Payment_Posted as 'Payment Posted' from Loan_Payments where Loan_ID=" & Loan_ID
        FillListView(ExecuteSQLQuery(sqlSTR), lst_loanPayment, 0)
        ComputeBalance()
    End Sub

    Private Sub ComputeGrossAmount()
        txt_grossAmount.Text = (Val(txt_netAmount.Text) * (Val(txt_interestRate.Text) / 100)) + Val(txt_netAmount.Text)
        ComputeBalance()
    End Sub

    Private Function SuggestedNumberOfPayments() As Integer
        Dim number As Integer = DateDiff(DateInterval.Day, dt_payStartDate.Value, dt_payEndDate.Value) + 1
        Return (number / 15) + 1
    End Function

    Private Sub suggestedLoanDeduction()
        txt_suggestedDeduction.Text = Val(txt_grossAmount.Text) / SuggestedNumberOfPayments()
    End Sub

    Private Sub ComputeBalance()
        If lst_loanPayment.Items.Count > 0 Then
            Dim payment As Double
            For i As Integer = 0 To lst_loanPayment.Items.Count - 1
                If lst_loanPayment.Items(i).SubItems(6).Text = "Yes" Then
                    payment = payment + lst_loanPayment.Items(i).SubItems(4).Text
                End If

            Next i
            txt_balanceAmount.Text = Val(txt_grossAmount.Text) - payment
        Else
            txt_balanceAmount.Text = Val(txt_grossAmount.Text)
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        sqlSTR = "Update Loans SET " & _
"Loan_Net_Amount= '" & txt_netAmount.Text & "'," & _
"Loan_Gross_Amount= '" & txt_grossAmount.Text & "'," & _
"Loan_Interest_Rate= '" & txt_interestRate.Text & "'," & _
"Loan_Payment_Start_Date= '" & dt_payStartDate.Text & "'," & _
"Loan_Payment_End_Date= '" & dt_payEndDate.Text & "'," & _
"Loan_Reason= '" & txt_loanReason.Text & "'," & _
"Loan_Remarks= '" & txt_loanRemarks.Text & "'," & _
"Loan_Status= '" & cmb_loanStatus.Text & "'," & _
"Loan_Type= '" & cmb_loanType.Text & "'," & _
"Suggested_PayPerCutoff= '" & txt_suggestedDeduction.Text & "' " & _
"where Loan_ID =" & Loan_ID
        ExecuteSQLQuery(sqlSTR)
        MsgBox("Succesfully saved loan details.", MsgBoxStyle.Information, msgBox_header)
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_newLoan_Click(sender As Object, e As EventArgs) Handles btn_newLoan.Click
        If CDbl(txt_balanceAmount.Text) <= 0 Then
            MsgBox("Loan balance is paid, adding loan payment is not allowed.", MsgBoxStyle.Exclamation, msgBox_header)
            Exit Sub
        End If

        ShowForm2(FormLOAN_PAYMENT, "add", Loan_ID, 0)
        RefreshLoanPaymentList()
    End Sub


    Private Sub EditEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEmployeeToolStripMenuItem.Click
        If lst_loanPayment.FocusedItem.SubItems(2).Text <> "" Then
            MsgBox("Cannot edit this loan payment, payment is deducted from paryoll.", MsgBoxStyle.Exclamation, msgBox_header)
            Exit Sub
        End If



        ShowForm1(FormLOAN_PAYMENT, "edit", lst_loanPayment.FocusedItem.Text)
        RefreshLoanPaymentList()
    End Sub

    Private Sub lst_loanPayment_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_loanPayment.MouseDoubleClick
        If lst_loanPayment.FocusedItem.SubItems(2).Text <> "" Then
            MsgBox("Cannot edit this loan payment, payment is deducted from paryoll.", MsgBoxStyle.Exclamation, msgBox_header)
            Exit Sub
        End If



        ShowForm1(FormLOAN_PAYMENT, "edit", lst_loanPayment.FocusedItem.Text)
        RefreshLoanPaymentList()
    End Sub


    Private Sub DeleteEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeToolStripMenuItem.Click
        If lst_loanPayment.FocusedItem.SubItems(2).Text <> "" Then
            MsgBox("Cannot delete this loan payment, payment is deducted from paryoll.", MsgBoxStyle.Exclamation, msgBox_header)
            Exit Sub
        End If

        If MsgBox("Do you want to delete this loan payment record?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, msgBox_header) = MsgBoxResult.Yes Then
            sqlSTR = "Delete from Loan_Payments where Loan_Payment_ID =" & lst_loanPayment.FocusedItem.Text
            ExecuteSQLQuery(sqlSTR)

            MsgBox("Delete loan payment record.", MsgBoxStyle.Information, msgBox_header)
        End If
        RefreshLoanPaymentList()
    End Sub

    Private Sub txt_netAmount_TextChanged(sender As Object, e As EventArgs) Handles txt_netAmount.TextChanged
        ComputeGrossAmount()
    End Sub

    Private Sub txt_grossAmount_TextChanged(sender As Object, e As EventArgs) Handles txt_grossAmount.TextChanged
        suggestedLoanDeduction()
    End Sub

    Private Sub txt_interestRate_TextChanged(sender As Object, e As EventArgs) Handles txt_interestRate.TextChanged
        ComputeGrossAmount()
    End Sub

    Private Sub PostPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PostPaymentToolStripMenuItem.Click
        If lst_loanPayment.FocusedItem.SubItems(6).Text = "Yes" Then
            MsgBox("Loan payment already posted.", MsgBoxStyle.Exclamation, msgBox_header)
            Exit Sub
        End If

        If lst_loanPayment.FocusedItem.SubItems(2).Text <> "" Then
            MsgBox("Cannot post this loan payment, payment is posted from approved paryoll.", MsgBoxStyle.Exclamation, msgBox_header)
            Exit Sub
        End If

        If MsgBox("Do you want to post this loan payment record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, msgBox_header) = MsgBoxResult.Yes Then
            sqlSTR = "Update Loan_Payments set Payment_Posted = 'Yes' where Loan_Payment_ID =" & lst_loanPayment.FocusedItem.Text
            ExecuteSQLQuery(sqlSTR)
            MsgBox("Loan payment posted.", MsgBoxStyle.Information, msgBox_header)
        End If
        RefreshLoanPaymentList()
    End Sub

    Private Sub cmb_loanStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_loanStatus.SelectedIndexChanged
        If cmb_loanStatus.Text = "Paid" Then
            If CDbl(txt_balanceAmount.Text) > 0 Then
                MsgBox("The loan balance remains unpaid.", MsgBoxStyle.Exclamation, msgBox_header)
                cmb_loanStatus.Text = "Active"
            End If
        End If
    End Sub
End Class