﻿Public Class FormPAYROLL_PAYEE
    Private payroll_id, employee_id, payroll_detail_id As Integer
    Private Sub FormPAYROLL_PAYEE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_pagibig.Checked = False
        cb_SSS.Checked = False
        cb_philhealth.Checked = False
        cb_Tax.Checked = False

        If formOperation = "view" Then

            gb_BasicPay.Enabled = False
            gb_Deductions.Enabled = False
            gb_Loans.Enabled = False
            gb_loanPayment.Enabled = False
            gb_Additional.Enabled = False
            gb_total.Enabled = False

            btn_Save.Enabled = False
        Else
            gb_BasicPay.Enabled = True
            gb_Deductions.Enabled = True
            gb_Loans.Enabled = True
            gb_loanPayment.Enabled = True
            gb_Additional.Enabled = True
            gb_total.Enabled = True

            btn_Save.Enabled = True
        End If

        employee_id = xID1
        payroll_id = xID2

        sqlSTR = "Select *, CONCAT(Last_Name, ', ', First_Name) as EmployeeName from Employees where Employee_Id =" & employee_id
        ExecuteSQLQuery(sqlSTR)

        txt_EmployeeID.Text = sqlDT.Rows(0)("Employee_Id")
        txt_employeeName.Text = sqlDT.Rows(0)("EmployeeName")

        txt_paySpecial.Text = 0
        txt_payField.Text = 0

        'for new
        txt_payRegular.Text = sqlDT.Rows(0)("Current_Daily_Rate")
        txt_payHoliday.Text = sqlDT.Rows(0)("Current_Daily_Rate")
        txt_payLeave.Text = sqlDT.Rows(0)("Current_Daily_Rate")
        txt_payOvertime.Text = Format(Val(sqlDT.Rows(0)("Current_Daily_Rate")) / 8 / 60, "N2")
        txt_payNightDiff.Text = Format(((Val(sqlDT.Rows(0)("Current_Daily_Rate")) / 8) * 0.1) / 60, "N2")


        txt_philhealth.Text = sqlDT.Rows(0)("Philhealth_Share").ToString
        txt_pagibig.Text = sqlDT.Rows(0)("Pag_ibig_Share").ToString
        txt_SSS.Text = sqlDT.Rows(0)("SSS_Share").ToString
        txt_tax.Text = sqlDT.Rows(0)("Tax_Amount").ToString
        txt_minusLate.Text = Format(Val(sqlDT.Rows(0)("Current_Daily_Rate")) / 8 / 60, "N2")
        txt_minusUndertime.Text = Format(Val(sqlDT.Rows(0)("Current_Daily_Rate")) / 8 / 60, "N2")



        sqlSTR = "select *, COALESCE(totalSSS, 0) as total_SSS, COALESCE(totalPhilhealth, 0) as total_Philhealth, COALESCE(totalPagIbig, 0) as total_PagIbig, COALESCE(totalTax, 0) as total_Tax, COALESCE(payRegular, 0) as payRegular2 from Payroll_Details INNER JOIN Payroll on Payroll.Payroll_ID = Payroll_Details.Payroll_ID " & _
            " where Employee_ID =" & employee_id & " and Payroll_Details.Payroll_id =" & payroll_id
        ExecuteSQLQuery(sqlSTR)

        payroll_detail_id = sqlDT.Rows(0)("Payroll_Detail_ID")
        dt_cutoffStart.Text = sqlDT.Rows(0)("Cutoff_Date_Start")
        dt_cutoffEnd.Text = sqlDT.Rows(0)("Cutoff_Date_End")



        If sqlDT.Rows(0)("payRegular2") <> 0 Then
            txt_payRegular.Text = sqlDT.Rows(0)("payRegular2")
            txt_payHoliday.Text = sqlDT.Rows(0)("payRegular2")
            txt_payLeave.Text = sqlDT.Rows(0)("payRegular2")
            txt_payOvertime.Text = Format(Val(sqlDT.Rows(0)("payRegular2")) / 8 / 60, "N2")
            txt_payNightDiff.Text = Format(((Val(sqlDT.Rows(0)("payRegular2")) / 8) * 0.1) / 60, "N2")
        End If


        txt_numRegular.Text = sqlDT.Rows(0)("numRegular").ToString
        txt_numSpecial.Text = sqlDT.Rows(0)("numSpecial").ToString
        txt_numField.Text = sqlDT.Rows(0)("numField").ToString
        txt_numHoliday.Text = sqlDT.Rows(0)("numHoliday").ToString
        txt_numLeave.Text = sqlDT.Rows(0)("numLeave").ToString
        txt_numOvertime.Text = sqlDT.Rows(0)("numOvertime").ToString
        txt_numNightDiff.Text = sqlDT.Rows(0)("numNight_diff").ToString
        txt_totalRegular.Text = sqlDT.Rows(0)("totalRegular").ToString
        txt_totalSpecial.Text = sqlDT.Rows(0)("totalSpecial").ToString
        txt_totalField.Text = sqlDT.Rows(0)("totalField").ToString
        txt_totalHoliday.Text = sqlDT.Rows(0)("totalHoliday").ToString
        txt_totalLeave.Text = sqlDT.Rows(0)("totalLeave").ToString
        txt_totalOvertime.Text = sqlDT.Rows(0)("totalOvertime").ToString
        txt_totalNightDiff.Text = sqlDT.Rows(0)("totalNight_diff").ToString

        'txt_SSS.Text = sqlDT.Rows(0)("totalSSS")
        'txt_philhealth.Text = sqlDT.Rows(0)("totalPhilhealth")
        'txt_pagibig.Text = sqlDT.Rows(0)("totalPagIbig")
        'txt_tax.Text = sqlDT.Rows(0)("totalTax")

        If CDbl(sqlDT.Rows(0)("total_SSS").ToString) > 0 Then cb_SSS.Checked = True
        If CDbl(sqlDT.Rows(0)("total_Philhealth").ToString) > 0 Then cb_philhealth.Checked = True
        If CDbl(sqlDT.Rows(0)("total_PagIbig").ToString) > 0 Then cb_pagibig.Checked = True
        If CDbl(sqlDT.Rows(0)("total_Tax").ToString) > 0 Then cb_Tax.Checked = True

        txt_insurance.Text = sqlDT.Rows(0)("totalInsurance").ToString
        txt_charge.Text = sqlDT.Rows(0)("totalCharge").ToString
        txt_totalLate.Text = sqlDT.Rows(0)("totalLate").ToString
        txt_totalUndertime.Text = sqlDT.Rows(0)("totalUndertime").ToString
        txt_numLate.Text = sqlDT.Rows(0)("numLate").ToString
        txt_numUndertime.Text = sqlDT.Rows(0)("numUndertime").ToString

        txt_totalNumAbsent.Text = sqlDT.Rows(0)("totalNumAbsent").ToString
        txt_totalNumLate.Text = sqlDT.Rows(0)("totalNumLate").ToString

        txt_payAddSpecial.Text = sqlDT.Rows(0)("totalAddSpecial").ToString
        txt_payAddField.Text = sqlDT.Rows(0)("totalAddField").ToString
        txt_payAddIncentive.Text = sqlDT.Rows(0)("totalAddIncentive").ToString
        txt_payAddAllowance.Text = sqlDT.Rows(0)("totalAddAllowance").ToString

        txt_grandTotal_Basic.Text = sqlDT.Rows(0)("grandTotal_Basic").ToString
        txt_grandTotal_Additional.Text = sqlDT.Rows(0)("grandTotal_Additional").ToString
        txt_grandTotal_Gross.Text = sqlDT.Rows(0)("grandTotal_Gross").ToString
        txt_grandTotal_Deduction.Text = sqlDT.Rows(0)("grandTotal_Deduction").ToString
        txt_grandTotal_Loan.Text = sqlDT.Rows(0)("grandTotal_Loan").ToString
        txt_grandTotal_Net.Text = sqlDT.Rows(0)("grandTotal_Net").ToString
        txt_payroll_employeeRemarks.Text = sqlDT.Rows(0)("payroll_employeeRemarks").ToString


        DeductionsCompute()
        RefreshLoanList()
        RefreshLoanPaymentList()

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
        txt_totalLeave.Text = Val(txt_payLeave.Text) * Val(txt_numLeave.Text)
        txt_totalOvertime.Text = Val(txt_payOvertime.Text) * Val(txt_numOvertime.Text)
        txt_totalNightDiff.Text = Val(txt_payNightDiff.Text) * Val(txt_numNightDiff.Text)

        GrandTotalCompute()
    End Sub

    Private Sub GrandTotalCompute()
        txt_grandTotal_Basic.Text = (Val(txt_totalRegular.Text) + Val(txt_totalSpecial.Text) + Val(txt_totalField.Text) + Val(txt_totalHoliday.Text) + Val(txt_totalLeave.Text) + Val(txt_totalOvertime.Text) + Val(txt_totalNightDiff.Text))
        txt_grandTotal_Additional.Text = Val(txt_payAddSpecial.Text) + Val(txt_payAddField.Text) + Val(txt_payAddIncentive.Text) + Val(txt_payAddAllowance.Text)
        txt_grandTotal_Gross.Text = Val(txt_grandTotal_Basic.Text) + Val(txt_grandTotal_Additional.Text)

        txt_grandTotal_Net.Text = Val(txt_grandTotal_Gross.Text) - Val(txt_grandTotal_Deduction.Text) - Val(txt_grandTotal_Loan.Text)
    End Sub

    Private Sub DeductionsCompute()
        txt_totalLate.Text = Val(txt_minusLate.Text) * Val(txt_numLate.Text)
        txt_totalUndertime.Text = Val(txt_minusUndertime.Text) * Val(txt_numUndertime.Text)


        txt_grandTotal_Deduction.Text = Val(txt_totalLate.Text) + Val(txt_totalUndertime.Text) + Val(txt_charge.Text) + Val(txt_insurance.Text) + Val(txt_philhealth.Tag) + Val(txt_pagibig.Tag) + Val(txt_SSS.Tag) + Val(txt_tax.Tag)
        GrandTotalCompute()
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

    Private Sub RefreshLoanPaymentList()
        sqlSTR = "select Loan_Payment_ID as ID, Loan_Payments.Loan_ID as 'Loan ID', Payroll_Detail_ID as 'Payroll Detail ID', Loan_Type as 'Loan Type', Payment_Date as 'Payment Date', " & _
                "FORMAT(Gross_Payment, 'N2') as 'Payment', Payment_Remarks as Remarks from Loan_Payments " & _
                "INNER JOIN Loans on Loans.Loan_ID = Loan_Payments.Loan_ID where payroll_detail_id=" & payroll_detail_id
        FillListView(ExecuteSQLQuery(sqlSTR), lst_loanPayment, 0)

        Dim payment As Double = 0
        For i As Integer = 0 To lst_loanPayment.Items.Count - 1
            payment = payment + lst_loanPayment.Items(i).SubItems(5).Text
        Next i
        txt_grandTotal_Loan.Text = Val(payment)
        GrandTotalCompute()
    End Sub

    Private Sub RefreshLoanList()
        sqlSTR = "select Loans.Loan_ID as 'ID', MAX(Loan_Type) AS 'Loan Type', CONCAT(MAX(Loan_Payment_Start_Date), ' to ', MAX(Loan_Payment_End_Date)) as 'Loan Duration', FORMAT(max(Suggested_PayPerCutoff), 'N2') as 'Suggested Payment', " & _
            " FORMAT(max(Loan_Gross_Amount), 'N2') as 'Loan Gross', FORMAT(max(Loan_Gross_Amount) - sum(case when Payment_Posted = 'Yes' then COALESCE(Gross_Payment, 0) else 0 end), 'N2') as 'Loan Balance' " & _
            " from Loans LEFT JOIN Loan_Payments on Loan_Payments.Loan_ID = Loans.Loan_ID" & _
            " WHERE Loan_Status = 'Active' and Employee_ID=" & employee_id & _
            " group by Loans.Loan_ID "
        FillListView(ExecuteSQLQuery(sqlSTR), lst_loans, 0)
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
"payLeave= '" & txt_payLeave.Text & "'," & _
"payOvertime= '" & txt_payOvertime.Text & "'," & _
"payNight_diff= '" & txt_payNightDiff.Text & "'," & _
"numRegular= '" & txt_numRegular.Text & "'," & _
"numSpecial= '" & txt_numSpecial.Text & "'," & _
"numField= '" & txt_numField.Text & "'," & _
"numHoliday= '" & txt_numHoliday.Text & "'," & _
"numLeave= '" & txt_numLeave.Text & "'," & _
"numOvertime= '" & txt_numOvertime.Text & "'," & _
"numNight_diff= '" & txt_numNightDiff.Text & "'," & _
"totalRegular= '" & txt_totalRegular.Text & "'," & _
"totalSpecial= '" & txt_totalSpecial.Text & "'," & _
"totalField= '" & txt_totalField.Text & "'," & _
"totalHoliday= '" & txt_totalHoliday.Text & "'," & _
"totalLeave= '" & txt_totalLeave.Text & "'," & _
"totalOvertime= '" & txt_totalOvertime.Text & "'," & _
"totalNight_diff= '" & txt_totalNightDiff.Text & "'," & _
"totalSSS= '" & txt_SSS.Tag & "'," & _
"totalPhilhealth= '" & txt_philhealth.Tag & "'," & _
"totalPagIbig= '" & txt_pagibig.Tag & "'," & _
"totalTax= '" & txt_tax.Tag & "'," & _
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
"grandTotal_Deduction= '" & txt_grandTotal_Deduction.Text & "'," & _
"grandTotal_Loan= '" & txt_grandTotal_Loan.Text & "'," & _
"grandTotal_Net= '" & txt_grandTotal_Net.Text & "'," & _
"totalNumAbsent= '" & txt_totalNumAbsent.Text & "'," & _
"totalNumLate= '" & txt_totalNumLate.Text & "'," & _
"payroll_employeeRemarks= '" & txt_payroll_employeeRemarks.Text & "'" & _
" WHERE Employee_ID = " & employee_id & " and Payroll_ID = " & payroll_id
        ExecuteSQLQuery(sqlSTR)
        MsgBox("Succesfully saved employee payroll details.", MsgBoxStyle.Information, msgBox_header)
        Me.Close()
    End Sub



    Private Sub EditEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEmployeeToolStripMenuItem.Click
        If LoanID_hasLoanPayment() Then
            Exit Sub
        End If
        ShowForm2(FormLOAN_PAYMENT, "add", lst_loans.FocusedItem.Text, payroll_detail_id)
        RefreshLoanPaymentList()
    End Sub

    Private Sub txt_insurance_TextChanged(sender As Object, e As EventArgs) Handles txt_insurance.TextChanged

    End Sub



    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub


    Private Sub DeleteLoan_Click(sender As Object, e As EventArgs) Handles DeleteLoan.Click
        If MsgBox("Do you want to delete this loan payment record?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, msgBox_header) = MsgBoxResult.Yes Then
            sqlSTR = "Delete from Loan_Payments where Loan_Payment_ID =" & lst_loanPayment.FocusedItem.Text
            ExecuteSQLQuery(sqlSTR)

            MsgBox("Deleted loan payment record.", MsgBoxStyle.Information, msgBox_header)
        End If
        RefreshLoanPaymentList()
    End Sub

    Private Sub EditLoan_Click(sender As Object, e As EventArgs) Handles EditLoan.Click
        ShowForm2(FormLOAN_PAYMENT, "edit", lst_loanPayment.FocusedItem.Text, payroll_detail_id)
        RefreshLoanPaymentList()
    End Sub

    Private Function LoanID_hasLoanPayment() As Boolean
        For i = 0 To lst_loanPayment.Items.Count - 1
            If lst_loans.FocusedItem.Text = lst_loanPayment.Items(i).SubItems(1).Text Then
                MsgBox("Loan payment record already exists below, update and try again.", MsgBoxStyle.Information, msgBox_header)
                Return True
            End If
        Next
        Return False
    End Function


End Class