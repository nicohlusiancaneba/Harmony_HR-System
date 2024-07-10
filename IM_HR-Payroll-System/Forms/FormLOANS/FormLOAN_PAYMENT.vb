Public Class FormLOAN_PAYMENT

    Dim loan_id, payroll_detail_ID, loan_payment_id As Integer
    Private Sub FormLOAN_PAYMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

        If formOperation = "edit" Then
            loan_payment_id = xID1
            Label1.Text = "Edit Loan Payment No." & loan_payment_id
            sqlSTR = "select * from Loan_Payments where Loan_Payment_ID=" & loan_payment_id
            ExecuteSQLQuery(sqlSTR)

            dt_paymentDate.Text = sqlDT.Rows(0)("Payment_Date")
            txt_grossAmount.Text = sqlDT.Rows(0)("Gross_Payment")
            txt_remarks.Text = sqlDT.Rows(0)("Payment_Remarks").ToString


        Else
            loan_id = xID1
            payroll_detail_ID = xID2
            Label1.Text = "Add Loan Payment"
            dt_paymentDate.Text = Today()
            txt_grossAmount.Text = ""
            txt_remarks.Text = ""
        End If



    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If formOperation = "edit" Then
            sqlSTR = "Update Loan_Payments set Payment_Date='" & dt_paymentDate.Text & "', Gross_Payment='" & txt_grossAmount.Text & "', Payment_Remarks='" & txt_remarks.Text & "' where Loan_Payment_ID=" & loan_payment_id
            ExecuteSQLQuery(sqlSTR)
        Else
            sqlSTR = "INSERT INTO Loan_Payments(Loan_ID, Payroll_Detail_ID,  Payment_Remarks, Gross_Payment, Payment_Date) " & _
                            "Values (" & loan_id & ", Replace(" & payroll_detail_ID & ", 0, null), '" & txt_remarks.Text & "', '" & txt_grossAmount.Text & "', '" & dt_paymentDate.Value & "')"
            ExecuteSQLQuery(sqlSTR)
        End If



        MsgBox("Succesfully saved loan payment details.", MsgBoxStyle.Information, msgBox_header)
        Me.Close()
    End Sub


    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class