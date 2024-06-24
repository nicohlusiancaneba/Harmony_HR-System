Public Class FormPAYROLL_ADD
    Dim payroll_Id As Integer
    Private Sub FormPAYROLL_ADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_payroll_ID.Text = ""
        txt_cutoff.Text = ""
        txt_TotalgrossPay.Text = ""
        txt_totalLoansPaid.Text = ""
        txt_totalDeductions.Text = ""
        txt_TotalnetPay.Text = ""
        rtb_remarks.Text = ""

        If formOperation = "edit" Then
            payroll_Id = xID1
            txt_payroll_ID.Text = payroll_Id

            sqlSTR = "SELECT * from Payroll where Payroll_ID=" & payroll_Id
            ExecuteSQLQuery(sqlSTR)

            dt_payroll.Text = sqlDT.Rows(0)("Payroll_Date")
            txt_cutoff.Text = sqlDT.Rows(0)("Cutoff_Period")
            txt_TotalgrossPay.Text = sqlDT.Rows(0)("Total_GrossPay")
            txt_TotalnetPay.Text = sqlDT.Rows(0)("Total_NetPay")
            txt_totalDeductions.Text = sqlDT.Rows(0)("Total_Deductions")
            txt_totalLoansPaid.Text = sqlDT.Rows(0)("Total_LoansPaid")
            rtb_remarks.Text = sqlDT.Rows(0)("Payroll_Remarks")
            txt_encodedby.Text = "Encoded by : " & sqlDT.Rows(0)("Encoded_by")

        Else 'ADD
            sqlSTR = "SELECT IDENT_CURRENT('Payroll') + IDENT_INCR('Payroll') AS Payroll_ID"
            ExecuteSQLQuery(sqlSTR)

            payroll_Id = sqlDT.Rows(0)("Payroll_ID")
            txt_payroll_ID.Text = payroll_Id
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If formOperation = "edit" Then
            sqlSTR = "UPDATE Payroll SET " &
                       "Payroll_Date = '" & dt_payroll.Text & "', " &
                       "Cutoff_Period = '" & txt_cutoff.Text & "', " &
                       "Total_GrossPay = '" & txt_TotalgrossPay.Text & "', " &
                       "Total_NetPay = '" & txt_TotalnetPay.Text & "', " &
                       "Total_Deductions = '" & txt_totalDeductions.Text & "', " &
                       "Total_LoansPaid = '" & txt_totalLoansPaid.Text & "', " &
                       "Payroll_Remarks = '" & rtb_remarks.Text & "' " &
                       "WHERE Payroll_ID =" & payroll_Id
            ExecuteSQLQuery(sqlSTR)

            If Not txt_encodedby.Text.Contains(xUsername) Then
                sqlSTR = "Update Payroll SET Encoded_by = Concat(Encoded_by, ', " & xUsername & "') where Payroll_ID =" & payroll_Id
                ExecuteSQLQuery(sqlSTR)
            End If


        Else 'Add
            sqlSTR = "INSERT INTO Payroll (Payroll_Date, Cutoff_Period, Total_GrossPay, Total_NetPay, Total_Deductions, Total_LoansPaid, Payroll_Remarks, Encoded_by,) " &
                      "VALUES ('" & dt_payroll.Text & "', '" & txt_cutoff.Text & "', '" & txt_TotalgrossPay.Text & "', '" & txt_TotalnetPay.Text & "', '" & txt_totalDeductions.Text & "', '" & txt_totalLoansPaid.Text & "', '" & rtb_remarks.Text & "', '" & xUsername & "')"
            ExecuteSQLQuery(sqlSTR)
        End If
        MsgBox("Succesfully saved payroll record.", MsgBoxStyle.Information, msgBox_header)
        Me.Close()
    End Sub





    '//////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub btn_newPayroll_Click(sender As Object, e As EventArgs) Handles btn_newPayroll.Click
        sqlSTR = "Select * from employees where Employment_Status != 'Inactive'"
        FILLComboBox_Employee(sqlSTR, cmb_employees)
        grp_Payrollpayee.Visible = True
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click

        grp_Payrollpayee.Visible = False
    End Sub

    Private Sub btn_cancelSubmit_Click(sender As Object, e As EventArgs) Handles btn_cancelSubmit.Click
        grp_Payrollpayee.Visible = False
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////////////////
    


    
End Class