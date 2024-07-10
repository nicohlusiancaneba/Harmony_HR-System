Public Class FormPAYROLL_PAYEE
    Private payroll_id, employee_id As Integer
    Private Sub FormPAYROLL_PAYEE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        employee_id = xID1
        payroll_id = xID2

        sqlSTR = "Select * from Employees where Employee_Id =" & employee_id
        ExecuteSQLQuery(sqlSTR)

        txt_payRegular.Text = sqlDT.Rows(0)("Current_Daily_Rate")
        txt_paySpecial.Text = sqlDT.Rows(0)("Current_Daily_Rate")
        txt_payField.Text = sqlDT.Rows(0)("Current_Daily_Rate")
        txt_payHoliday.Text = sqlDT.Rows(0)("Current_Daily_Rate")
        txt_payOvertime.Text = Format(Val(sqlDT.Rows(0)("Current_Daily_Rate")) / 8 / 60, "N2")
        txt_payNightDiff.Text = Format(((Val(sqlDT.Rows(0)("Current_Daily_Rate")) / 8) * 0.1) / 60, "N2")

        txt_philhealth.Text = sqlDT.Rows(0)("Philhealth_Share")
        txt_pagibig.Text = sqlDT.Rows(0)("Pag_ibig_Share")
        txt_SSS.Text = sqlDT.Rows(0)("SSS_Share")
        txt_tax.Text = sqlDT.Rows(0)("Tax_Amount")
        txt_minusLate.Text = Format(Val(sqlDT.Rows(0)("Current_Daily_Rate")) / 8 / 60, "N2")
        txt_minusUndertime.Text = Format(Val(sqlDT.Rows(0)("Current_Daily_Rate")) / 8 / 60, "N2")


        '//////// LOANS ////////
        sqlSTR = "SELECT Loan_ID AS 'Loan ID', Loan_Date AS 'Loan Date', Loan_Net_Amount AS 'Loan Net Amount', CONCAT(Loan_Interest_Rate, '%') AS 'Loan Interest Rate', Loan_Gross_Amount AS 'Loan Gross Amount', " & _
            " Loan_Reason AS 'Loan Reason', Loan_Remarks AS 'Loan Remarks' FROM Loans INNER JOIN Employees ON Employees.Employee_ID = Loans.Employee_ID " & _
            " where Loan_Status = 'Active' and Loans.Employee_ID = " & employee_id
        FillListView(ExecuteSQLQuery(sqlSTR), lst_loans, 0)
        '///////////////////////



        TextBox_NumberHandler()
        TextBox_BasicPayCompute("BasicPay")
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

    Private Sub TextBox_BasicPayCompute(tag As String)
        ' Loop through all controls in the form
        For Each ctrl As Control In Me.Controls
            ' Check if the control is a GroupBox
            If TypeOf ctrl Is GroupBox Then
                ' Loop through all controls in the GroupBox
                For Each gbCtrl As Control In CType(ctrl, GroupBox).Controls
                    ' Check if the control is a TextBox and has the specified tag
                    If TypeOf gbCtrl Is TextBox AndAlso gbCtrl.Tag IsNot Nothing AndAlso gbCtrl.Tag.ToString() = tag Then
                        ' Add the TextChanged event handler
                        AddHandler CType(gbCtrl, TextBox).TextChanged, AddressOf BasicPayCompute
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

    Private Sub BasicPayCompute(sender As Object, e As EventArgs)
        txt_totalRegular.Text = Val(txt_payRegular.Text) * Val(txt_numRegular.Text)
        txt_totalSpecial.Text = Val(txt_paySpecial.Text) * Val(txt_numSpecial.Text)
        txt_totalField.Text = Val(txt_payField.Text) * Val(txt_numField.Text)
        txt_totalHoliday.Text = Val(txt_payHoliday.Text) * Val(txt_numHoliday.Text)
        txt_totalOvertime.Text = Val(txt_payOvertime.Text) * Val(txt_numOvertime.Text)
        txt_totalNightDiff.Text = Val(txt_payNightDiff.Text) * Val(txt_numNightDiff.Text)

        txt_grandTotal_Gross.Text = (Val(txt_totalRegular.Text) + Val(txt_totalSpecial.Text) + Val(txt_totalField.Text) + Val(txt_totalHoliday.Text) + Val(txt_totalOvertime.Text) + Val(txt_totalNightDiff.Text))
        txt_grandTotal_Additional.Text = Val(txt_payAddSpecial.Text) + Val(txt_payAddField.Text) + Val(txt_payAddIncentive.Text) + Val(txt_payAddAllowance.Text)

    End Sub

    Private Sub DeductionsCompute()
        txt_totalLate.Text = Val(txt_minusLate.Text) * Val(txt_numLate.Text)
        txt_totalUndertime.Text = Val(txt_minusUndertime.Text) * Val(txt_numUndertime.Text)


        txt_grandTotal_Deduction.Text = Val(txt_totalLate.Text) + Val(txt_totalUndertime.Text) + Val(txt_charge.Text) + Val(txt_insurance.Tag) + Val(txt_philhealth.Tag) + Val(txt_pagibig.Tag) + Val(txt_SSS.Tag) + Val(txt_tax.Tag)
    End Sub

    Private Sub checkbox_Deductions(chckbox As CheckBox, txtbox As TextBox)
        If chckbox.Checked Then
            txtbox.BackColor = Color.WhiteSmoke
            txtbox.Tag = txtbox.Text
        Else
            txtbox.BackColor = Color.Gray
            txtbox.Tag = ""
        End If
        DeductionsCompute()
    End Sub

    Private Sub txt_charge_TextChanged(sender As Object, e As EventArgs) Handles txt_charge.TextChanged
        DeductionsCompute()
    End Sub

    Private Sub txt_totalLate_TextChanged(sender As Object, e As EventArgs) Handles txt_totalLate.TextChanged
        DeductionsCompute()
    End Sub

    Private Sub txt_totalUndertime_TextChanged(sender As Object, e As EventArgs) Handles txt_totalUndertime.TextChanged
        DeductionsCompute()
    End Sub

    Private Sub txt_numLate_TextChanged(sender As Object, e As EventArgs) Handles txt_numLate.TextChanged
        DeductionsCompute()
    End Sub

    Private Sub txt_numUndertime_TextChanged(sender As Object, e As EventArgs) Handles txt_numUndertime.TextChanged
        DeductionsCompute()
    End Sub



    Private Sub cb_philhealth_CheckedChanged(sender As Object, e As EventArgs) Handles cb_philhealth.CheckedChanged
        checkbox_Deductions(cb_philhealth, txt_philhealth)
    End Sub

    Private Sub cb_pagibig_CheckedChanged(sender As Object, e As EventArgs) Handles cb_pagibig.CheckedChanged
        checkbox_Deductions(cb_pagibig, txt_pagibig)
    End Sub

    Private Sub cb_SSS_CheckedChanged(sender As Object, e As EventArgs) Handles cb_SSS.CheckedChanged
        checkbox_Deductions(cb_SSS, txt_SSS)
    End Sub

    Private Sub cb_Tax_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Tax.CheckedChanged
        checkbox_Deductions(cb_Tax, txt_tax)
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        sqlSTR = "Update Payroll_Details SET " & _
"payRegular= '" & txt_payRegular.Text & "'," & _
"paySpecial= '" & txt_paySpecial.Text & "'," & _
"payField= '" & txt_payField.Text & "'," & _
"payHoliday= '" & txt_payHoliday.Text & "'," & _
"payOvertime= '" & txt_payOvertime.Text & "'," & _
"payNight_diff= '" & txt_payNightDiff.Text & "'," & _
"numRegular= '" & txt_numRegular.Text & "'," & _
"numSpecial= '" & txt_numSpecial.Text & "'," & _
"numField= '" & txt_numField.Text & "'," & _
"numHoliday= '" & txt_numHoliday.Text & "'," & _
"numOvertime= '" & txt_numOvertime.Text & "'," & _
"numNight_diff= '" & txt_numNightDiff.Text & "'," & _
"totalRegular= '" & txt_totalRegular.Text & "'," & _
"totalSpecial= '" & txt_totalSpecial.Text & "'," & _
"totalField= '" & txt_totalField.Text & "'," & _
"totalHoliday= '" & txt_totalHoliday.Text & "'," & _
"totalOvertime= '" & txt_totalOvertime.Text & "'," & _
"totalNight_diff= '" & txt_totalNightDiff.Text & "'," & _
"totalSSS= '" & txt_SSS.Text & "'," & _
"totalPhilhealth= '" & txt_philhealth.Text & "'," & _
"totalPagIbig= '" & txt_pagibig.Text & "'," & _
"totalTax= '" & txt_tax.Text & "'," & _
"totalInsurance= '" & txt_insurance.Text & "'," & _
"totalCharge= '" & txt_charge.Text & "'," & _
"totalLate= '" & txt_totalLate.Text & "'," & _
"totalUndertime= '" & txt_totalUndertime.Text & "'," & _
"minusLate= '" & txt_minusLate.Text & "'," & _
"minusUndertime= '" & txt_minusUndertime.Text & "'," & _
"numLate= '" & txt_numLate.Text & "'," & _
"numUndertime= '" & txt_numUndertime.Text & "'," & _
"totalAddSpecial= '" & txt_payAddSpecial.Text & "'," & _
"totalAddField= '" & txt_payAddField.Text & "'," & _
"totalAddIncentive= '" & txt_payAddIncentive.Text & "'," & _
"totalAddAllowance= '" & txt_payAddAllowance.Text & "'," & _
"grandTotal_Basic= '" & txt_grandTotal_Basic.Text & "'," & _
"grandTotal_Additional= '" & txt_grandTotal_Additional.Text & "'," & _
"grandTotal_Gross= '" & txt_grandTotal_Gross.Text & "'," & _
"grandTotal_Deductions= '" & txt_grandTotal_Deduction.Text & "'," & _
"grandTotal_Loans= '" & txt_grandTotal_Loan.Text & "'," & _
"grandTotal_Net= '" & txt_grandTotal_Net.Text & "'," & _
"payroll_employeeRemarks= '" & txt_payroll_employeeRemarks.Text & "'," & _
" WHERE Employee_ID = " & employee_id & " and Payroll_ID = " & payroll_id
        ExecuteSQLQuery(sqlSTR)
        MsgBox("Succesfully saved employee payroll details.", MsgBoxStyle.Information, msgBox_header)
    End Sub
End Class