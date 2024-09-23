Public Class FormLOAN_NEW

    Private Sub FormLOAN_NEW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlSTR = "Select * from employees where Employment_Status != 'Inactive' Order by Last_Name, First_Name "
        FILLComboBox_Employee(sqlSTR, cmb_employees)
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click

        sqlSTR = "INSERT INTO Loans (Loan_Date, Employee_ID, Loan_Net_Amount, Loan_Interest_Rate, Loan_Gross_Amount, Loan_Payment_Start_Date, Loan_Payment_End_Date, Loan_Type, Suggested_PayPerCutoff, Loan_Reason, Loan_Remarks, Loan_Status) VALUES (" & _
                            "'" & DateTime.Now.ToString("MM/dd/yyyy") & "', '" & _
                             Split(cmb_employees.Text, " - ")(0) & "', '" & _
                             txt_netAmount.Text & "', '" & _
                             txt_interestRate.Text & "', '" & _
                             txt_grossAmount.Text & "', '" & _
                             dt_payStartDate.Text & "', '" & _
                             dt_payEndDate.Text & "', '" & _
                             cmb_loanType.Text & "', '" & _
                             txt_suggestedDeduction.Text & "', '" & _
                             txt_loanReason.Text & "', '" & _
                             txt_loanRemarks.Text & "', 'Active')"

        ExecuteSQLQuery(sqlSTR)
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub ComputeGrossAmount()
        txt_grossAmount.Text = (Val(txt_netAmount.Text) * (Val(txt_interestRate.Text) / 100)) + Val(txt_netAmount.Text)
    End Sub


    Private Function SuggestedNumberOfPayments() As Integer
        Dim number As Integer = DateDiff(DateInterval.Day, dt_payStartDate.Value, dt_payEndDate.Value) + 1
        Return (number / 15) + 1
    End Function




    Private Sub txt_netAmount_TextChanged(sender As Object, e As EventArgs) Handles txt_netAmount.TextChanged
        ComputeGrossAmount()
    End Sub

    Private Sub txt_interestRate_TextChanged(sender As Object, e As EventArgs) Handles txt_interestRate.TextChanged
        ComputeGrossAmount()
    End Sub

    Private Sub TextBox_NumberHandler()
        ' Loop through all controls in the form
        For Each ctrl As Control In Me.Controls
            ' Check if the control is a GroupBox
            If TypeOf ctrl Is GroupBox Then
                ' Loop through all controls in the GroupBox
                For Each gbCtrl As Control In CType(ctrl, GroupBox).Controls
                    ' Check if the control is a TextBox
                    If TypeOf gbCtrl Is TextBox Then
                        ' Add the KeyPress event handler
                        AddHandler CType(gbCtrl, TextBox).KeyPress, AddressOf TextBox_KeyPress
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Allow control keys, numbers, and a single period
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        Dim textBox As TextBox = CType(sender, TextBox)
        If (e.KeyChar = "."c) AndAlso (textBox.Text.IndexOf("."c) > -1) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txt_grossAmount_TextChanged(sender As Object, e As EventArgs) Handles txt_grossAmount.TextChanged
        suggestedLoanDeduction()
    End Sub

    Private Sub suggestedLoanDeduction()
        txt_suggestedDeduction.Text = Val(txt_grossAmount.Text) / SuggestedNumberOfPayments()
        txt_suggestedDeduction.Text = Math.Round(CDbl(txt_suggestedDeduction.Text), 2).ToString("0.00")
    End Sub

    Private Sub dt_payStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dt_payStartDate.ValueChanged
        suggestedLoanDeduction()
    End Sub

    Private Sub dt_payEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dt_payEndDate.ValueChanged
        suggestedLoanDeduction()
    End Sub

    Private Sub txt_suggestedDeduction_TextChanged(sender As Object, e As EventArgs) Handles txt_suggestedDeduction.TextChanged

    End Sub
End Class