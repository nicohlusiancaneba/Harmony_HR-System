Public Class FormLOAN_PAYMENT

    Dim loan_id, payroll_detail_ID As Integer
    Private Sub FormLOAN_PAYMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loan_id = xID1
        payroll_detail_ID = xID2
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        sqlSTR = "INSERT INTO Loan_Payments(Loan_ID, Payroll_Detail_ID,  Net_Payment, Interest_Rate, Gross_Payment, Payment_Date) " & _
                "Values (" & loan_id & ", Replace(" & payroll_detail_ID & ", 0, null), '" & txt_netAmount.Text & "', '" & txt_interestRate.Text & "', '" & txt_grossAmount.Text & "', '" & dt_paymentDate.Value & "')"
        ExecuteSQLQuery(sqlSTR)
        Me.Close()
    End Sub
End Class