Public Class FormLOAN_PAYMENT

    Dim loan_id, payroll_detail_ID, loan_payment_id As Integer
    Dim balance_amount As Double
    Private Sub FormLOAN_PAYMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loan_id = 0
        loan_payment_id = 0

        If formOperation = "edit" Then
            loan_payment_id = xID1
            Label1.Text = "Edit Loan Payment No." & loan_payment_id
            sqlSTR = "select * from Loan_Payments where Loan_Payment_ID=" & loan_payment_id
            ExecuteSQLQuery(sqlSTR)

            dt_paymentDate.Text = sqlDT.Rows(0)("Payment_Date")
            txt_grossAmount.Text = sqlDT.Rows(0)("Gross_Payment")
            txt_remarks.Text = sqlDT.Rows(0)("Payment_Remarks").ToString
            loan_id = sqlDT.Rows(0)("Loan_ID")

            sqlSTR = "select Loans.Loan_ID as 'Loan ID', max(Employee_ID) as 'Employee ID', CONCAT(MAX(Loan_Payment_Start_Date), ' to ', MAX(Loan_Payment_End_Date)) as 'Cutoff Payment Due', max(Suggested_PayPerCutoff) as 'Suggested Payment', " & _
            " max(Loan_Gross_Amount) as 'Loan Gross', max(Loan_Gross_Amount) - sum(case when Payment_Posted = 'Yes' then COALESCE(Gross_Payment, 0) else 0 end) as 'Loan_Balance' " & _
            " from Loans LEFT JOIN Loan_Payments on Loan_Payments.Loan_ID = Loans.Loan_ID" & _
            " WHERE Loan_Status = 'Active' and Loans.Loan_ID=" & loan_id & _
            " group by Loans.Loan_ID "
            ExecuteSQLQuery(sqlSTR)
            balance_amount = sqlDT.Rows(0)("Loan_Balance")

        Else
            loan_id = xID1
            payroll_detail_ID = xID2
            Label1.Text = "Add Loan Payment"
            dt_paymentDate.Text = Today()
            txt_grossAmount.Text = ""
            txt_remarks.Text = ""

            sqlSTR = "select Loans.Loan_ID as 'Loan ID', max(Employee_ID) as 'Employee ID', CONCAT(MAX(Loan_Payment_Start_Date), ' to ', MAX(Loan_Payment_End_Date)) as 'Cutoff Payment Due', max(Suggested_PayPerCutoff) as 'Suggested_Payment', " & _
            " max(Loan_Gross_Amount) as 'Loan Gross', max(Loan_Gross_Amount) - sum(case when Payment_Posted = 'Yes' then COALESCE(Gross_Payment, 0) else 0 end) as 'Loan_Balance' " & _
            " from Loans LEFT JOIN Loan_Payments on Loan_Payments.Loan_ID = Loans.Loan_ID" & _
            " WHERE Loan_Status = 'Active' and Loans.Loan_ID=" & loan_id & _
            " group by Loans.Loan_ID "
            ExecuteSQLQuery(sqlSTR)
            balance_amount = sqlDT.Rows(0)("Loan_Balance")
            txt_grossAmount.Text = sqlDT.Rows(0)("Suggested_Payment")
        End If



    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If formOperation = "edit" Then
            sqlSTR = "Update Loan_Payments set Payment_Date='" & dt_paymentDate.Text & "', Gross_Payment='" & txt_grossAmount.Text & "', Payment_Remarks='" & txt_remarks.Text & "' where Loan_Payment_ID=" & loan_payment_id
            ExecuteSQLQuery(sqlSTR)
        Else
            sqlSTR = "INSERT INTO Loan_Payments(Loan_ID, Payroll_Detail_ID,  Payment_Remarks, Gross_Payment, Payment_Date, Payment_Posted) " & _
                            "Values (" & loan_id & ", NULLIF(" & payroll_detail_ID & ", 0), '" & txt_remarks.Text & "', '" & txt_grossAmount.Text & "', '" & dt_paymentDate.Value & "', 'No')"
            ExecuteSQLQuery(sqlSTR)
        End If


        MsgBox("Succesfully saved loan payment details.", MsgBoxStyle.Information, msgBox_header)
        Me.Close()
    End Sub


    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub txt_grossAmount_TextChanged(sender As Object, e As EventArgs) Handles txt_grossAmount.TextChanged
        CheckBalance(txt_grossAmount, balance_amount)
    End Sub

    Public Sub CheckBalance(txtbox As TextBox, balance As Double)
        If loan_id = 0 Or loan_payment_id = 0 Then
            Exit Sub
        End If

        If Val(txtbox.Text) > balance Then
            MsgBox("Payment amount invalid, current balance is " & Format(balance, "N2") & ". Try again or post payments first.", MsgBoxStyle.Information, msgBox_header)
            txtbox.Text = balance
        End If
    End Sub
End Class