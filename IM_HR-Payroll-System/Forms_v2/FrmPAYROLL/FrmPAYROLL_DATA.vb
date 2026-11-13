Public Class FrmPAYROLL_DATA
    Private edit, formLoaded As Boolean
    Private payroll_id, employee_id, payroll_detail_id As String
    Private Sub FrmPAYROLL_DATA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeHelper.ApplyHighlight(Me)
        TextBox_NumberHandler()
        TextBox_BasicPayCompute("BasicPay")
        formLoaded = False

        cb_pagibig.Checked = False
        cb_SSS.Checked = False
        cb_philhealth.Checked = False
        cb_Tax.Checked = False
        edit = FrmPAYROLL_DETAILS.edit
        If edit = False Then
            txt_payroll_employeeRemarks.Enabled = False
            gb_BasicPay.Enabled = False
            gb_Deductions.Enabled = False
            gb_Loans.Enabled = False
            gb_loanPayment.Enabled = False
            gb_Additional.Enabled = False
            gb_total.Enabled = False

            btn_Save.Enabled = False
        Else
            txt_payroll_employeeRemarks.Enabled = True
            gb_BasicPay.Enabled = True
            gb_Deductions.Enabled = True
            gb_Loans.Enabled = True
            gb_loanPayment.Enabled = True
            gb_Additional.Enabled = True
            gb_total.Enabled = True

            btn_Save.Enabled = True
        End If

        employee_id = FrmPAYROLL_DETAILS.employeeID
        payroll_id = FrmPAYROLL_DETAILS.payroll_Id



        sqlSTR = "SELECT " & _
            "CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', LEFT(Middle_Name, 1), '.') as EmployeeName " & _
            ",Payroll_Detail_ID " & _
            ",COALESCE(payRegular, 0) as payRegular " & _
            ",COALESCE(paySpecial, 0) as paySpecial " & _
            ",COALESCE(payField, 0) as payField " & _
            ",COALESCE(payHoliday, 0) as payHoliday " & _
            ",COALESCE(payOvertime, 0) as payOvertime " & _
            ",COALESCE(payNight_diff, 0) as payNight_diff " & _
            ",COALESCE(numRegular, 0) as numRegular " & _
            ",COALESCE(numSpecial, 0) as numSpecial " & _
            ",COALESCE(numField, 0) as numField " & _
            ",COALESCE(numHoliday, 0) as numHoliday " & _
            ",COALESCE(numOvertime, 0) as numOvertime " & _
            ",COALESCE(numNight_diff, 0) as numNight_diff " & _
            ",COALESCE(totalRegular, 0) as totalRegular " & _
            ",COALESCE(totalSpecial, 0) as totalSpecial " & _
            ",COALESCE(totalField, 0) as totalField " & _
            ",COALESCE(totalHoliday, 0) as totalHoliday " & _
            ",COALESCE(totalOvertime, 0) as totalOvertime " & _
            ",COALESCE(totalNight_diff, 0) as totalNight_diff " & _
            ",COALESCE(totalSSS, 0) as totalSSS " & _
            ",COALESCE(totalPhilhealth, 0) as totalPhilhealth " & _
            ",COALESCE(totalPagIbig, 0) as totalPagIbig " & _
            ",COALESCE(totalTax, 0) as totalTax " & _
            ",COALESCE(totalInsurance, 0) as totalInsurance " & _
            ",COALESCE(totalCharge, 0) as totalCharge " & _
            ",COALESCE(totalLate, 0) as totalLate " & _
            ",COALESCE(totalUndertime, 0) as totalUndertime " & _
            ",COALESCE(minusLate, 0) as minusLate " & _
            ",COALESCE(minusUndertime, 0) as minusUndertime " & _
            ",COALESCE(numLate, 0) as numLate " & _
            ",COALESCE(numUndertime, 0) as numUndertime " & _
            ",COALESCE(totalAddSpecial, 0) as totalAddSpecial " & _
            ",COALESCE(totalAddField, 0) as totalAddField " & _
            ",COALESCE(totalAddIncentive, 0) as totalAddIncentive " & _
            ",COALESCE(totalAddAllowance, 0) as totalAddAllowance " & _
            ",COALESCE(grandTotal_Basic, 0) as grandTotal_Basic " & _
            ",COALESCE(grandTotal_Additional, 0) as grandTotal_Additional " & _
            ",COALESCE(grandTotal_Gross, 0) as grandTotal_Gross " & _
            ",COALESCE(grandTotal_Deduction, 0) as grandTotal_Deduction " & _
            ",COALESCE(grandTotal_Loan, 0) as grandTotal_Loan " & _
            ",COALESCE(grandTotal_Net, 0) as grandTotal_Net " & _
            ",payroll_employeeRemarks " & _
            ",COALESCE(payLeave, 0) as payLeave " & _
            ",COALESCE(numLeave, 0) as numLeave " & _
            ",COALESCE(totalLeave, 0) as totalLeave " & _
            ",COALESCE(totalNumAbsent, 0) as totalNumAbsent " & _
            ",COALESCE(totalNumLate, 0) as totalNumLate " & _
            ",COALESCE(Philhealth_Share, 0) as Philhealth_Share " & _
            ",COALESCE(Pag_ibig_Share, 0) as Pag_ibig_Share " & _
            ",COALESCE(SSS_Share, 0) as SSS_Share " & _
            ",COALESCE(Tax_Amount, 0) as Tax_Amount " & _
            ",Position " & _
            ",Employment_Status " & _
            ",CASE " & _
            "WHEN (DATEDIFF(MONTH, Hired_Date, GETDATE()) " & _
            "- CASE WHEN DAY(Hired_Date) > DAY(GETDATE()) THEN 1 ELSE 0 END) / 12 = 0 " & _
            "THEN " & _
            "CAST((DATEDIFF(MONTH, Hired_Date, GETDATE()) " & _
            "- CASE WHEN DAY(Hired_Date) > DAY(GETDATE()) THEN 1 ELSE 0 END) % 12 AS VARCHAR) " & _
            "+ ' month' " & _
            "+ CASE WHEN (DATEDIFF(MONTH, Hired_Date, GETDATE()) " & _
            "- CASE WHEN DAY(Hired_Date) > DAY(GETDATE()) THEN 1 ELSE 0 END) % 12 = 1 " & _
            "THEN '' ELSE 's' END " & _
            "ELSE " & _
            "CAST((DATEDIFF(MONTH, Hired_Date, GETDATE()) " & _
            "- CASE WHEN DAY(Hired_Date) > DAY(GETDATE()) THEN 1 ELSE 0 END) / 12 AS VARCHAR) " & _
            "+ ' year' " & _
            "+ CASE WHEN (DATEDIFF(MONTH, Hired_Date, GETDATE()) " & _
            "- CASE WHEN DAY(Hired_Date) > DAY(GETDATE()) THEN 1 ELSE 0 END) / 12 = 1 " & _
            "THEN '' ELSE 's' END " & _
            "+ CASE WHEN (DATEDIFF(MONTH, Hired_Date, GETDATE()) " & _
            "- CASE WHEN DAY(Hired_Date) > DAY(GETDATE()) THEN 1 ELSE 0 END) % 12 = 0 " & _
            "THEN '' " & _
            "ELSE ' and ' " & _
            "+ CAST((DATEDIFF(MONTH, Hired_Date, GETDATE()) " & _
            "- CASE WHEN DAY(Hired_Date) > DAY(GETDATE()) THEN 1 ELSE 0 END) % 12 AS VARCHAR) " & _
            "+ ' month' " & _
            "+ CASE WHEN (DATEDIFF(MONTH, Hired_Date, GETDATE()) " & _
            "- CASE WHEN DAY(Hired_Date) > DAY(GETDATE()) THEN 1 ELSE 0 END) % 12 = 1 " & _
            "THEN '' ELSE 's' END " & _
            "END " & _
            "END as Tenure " & _
            ",Payroll_Account_Number " & _
            ",SSS_No " & _
            ",Philhealth_No " & _
            ",TIN_no " & _
            ",Pag_ibig_No " & _
            "FROM Payroll_Details " & _
            "INNER JOIN Employees on Employees.Employee_ID = Payroll_Details.Employee_ID " & _
            "where Payroll_ID = '" & payroll_id & "' and Payroll_Details.Employee_ID = '" & employee_id & "'"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count = 0 Then
            Me.Close()
        End If






        Label_ID.Text = "Employee ID#" & employee_id & " - " & sqlDT.Rows(0)("EmployeeName")
        Label_ID.Left = Panel1.Width - Label_ID.Width - 10

        lbl_emp1.Text = sqlDT.Rows(0)("Payroll_Account_Number") & vbCrLf & _
                         sqlDT.Rows(0)("SSS_No") & vbCrLf & _
                       sqlDT.Rows(0)("Philhealth_No") & vbCrLf & _
                        sqlDT.Rows(0)("Pag_ibig_No") & vbCrLf & _
                         sqlDT.Rows(0)("TIN_no")

        lbl_emp2.Text = sqlDT.Rows(0)("Position") & vbCrLf & _
                        sqlDT.Rows(0)("Employment_Status") & vbCrLf & _
                        sqlDT.Rows(0)("Tenure")


        payroll_detail_id = sqlDT.Rows(0)("Payroll_Detail_ID")

        txt_payroll_employeeRemarks.Text = sqlDT.Rows(0)("payroll_employeeRemarks")

        '''''''''''''START OF BASIC PAY'''''''''''''
        txt_payRegular.Text = sqlDT.Rows(0)("payRegular")
        txt_paySpecial.Text = sqlDT.Rows(0)("paySpecial")
        txt_payField.Text = sqlDT.Rows(0)("payField")
        txt_payHoliday.Text = sqlDT.Rows(0)("payHoliday")
        txt_payLeave.Text = sqlDT.Rows(0)("payLeave")
        txt_payOvertime.Text = sqlDT.Rows(0)("payOvertime")
        txt_payNightDiff.Text = sqlDT.Rows(0)("payNight_diff")

        txt_numRegular.Text = sqlDT.Rows(0)("numRegular").ToString
        txt_numSpecial.Text = sqlDT.Rows(0)("numSpecial").ToString
        txt_numField.Text = sqlDT.Rows(0)("numField").ToString
        txt_numHoliday.Text = sqlDT.Rows(0)("numHoliday").ToString
        txt_numLeave.Text = sqlDT.Rows(0)("numLeave").ToString
        txt_numOvertime.Text = sqlDT.Rows(0)("numOvertime").ToString
        txt_numNightDiff.Text = sqlDT.Rows(0)("numNight_diff").ToString
        '''''''''''''END OF BASIC PAY'''''''''''''


        '''''''''''''START OF DEDUCTIONS'''''''''''''
        txt_philhealth.Text = sqlDT.Rows(0)("Philhealth_Share").ToString
        txt_pagibig.Text = sqlDT.Rows(0)("Pag_ibig_Share").ToString
        txt_SSS.Text = sqlDT.Rows(0)("SSS_Share").ToString
        txt_minusLate.Text = sqlDT.Rows(0)("minusLate").ToString
        txt_minusUndertime.Text = sqlDT.Rows(0)("minusUndertime").ToString

        txt_tax.Text = sqlDT.Rows(0)("Tax_Amount").ToString
        txt_insurance.Text = sqlDT.Rows(0)("totalInsurance").ToString
        txt_charge.Text = sqlDT.Rows(0)("totalCharge").ToString
        txt_numLate.Text = sqlDT.Rows(0)("numLate").ToString
        txt_numUndertime.Text = sqlDT.Rows(0)("numUndertime").ToString
        txt_totalNumAbsent.Text = sqlDT.Rows(0)("totalNumAbsent").ToString
        txt_totalNumLate.Text = sqlDT.Rows(0)("totalNumLate").ToString

        If SafeDbl(sqlDT.Rows(0)("totalSSS").ToString) > 0 Then cb_SSS.Checked = True
        If SafeDbl(sqlDT.Rows(0)("totalPhilhealth").ToString) > 0 Then cb_philhealth.Checked = True
        If SafeDbl(sqlDT.Rows(0)("totalPagIbig").ToString) > 0 Then cb_pagibig.Checked = True
        If SafeDbl(sqlDT.Rows(0)("totalTax").ToString) > 0 Then cb_Tax.Checked = True
        '''''''''''''END OF DEDUCTIONS'''''''''''''


        '''''''''''''START OF ADDITIONALS'''''''''''''
        txt_payAddSpecial.Text = sqlDT.Rows(0)("totalAddSpecial").ToString
        txt_payAddField.Text = sqlDT.Rows(0)("totalAddField").ToString
        txt_payAddIncentive.Text = sqlDT.Rows(0)("totalAddIncentive").ToString
        txt_payAddAllowance.Text = sqlDT.Rows(0)("totalAddAllowance").ToString
        '''''''''''''END OF ADDITIONALS'''''''''''''






        'sqlSTR = "Select *, CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', LEFT(Middle_Name, 1), '.') as EmployeeName from Employees where Employee_Id =" & employee_id
        'ExecuteSQLQuery(sqlSTR)

        'Label_ID.Text = "Employee ID#" & employee_id & " - " & sqlDT.Rows(0)("EmployeeName")
        'Label_ID.Left = Panel1.Width - Label_ID.Width - 10


        'txt_paySpecial.Text = 0
        'txt_payField.Text = 0

        'for new
        'txt_payRegular.Text = sqlDT.Rows(0)("Current_Daily_Rate")
        'txt_payHoliday.Text = sqlDT.Rows(0)("Current_Daily_Rate")
        'txt_payLeave.Text = sqlDT.Rows(0)("Current_Daily_Rate")
        'txt_payOvertime.Text = Format(Val(sqlDT.Rows(0)("Current_Daily_Rate")) / 8 / 60, "N2")
        'txt_payNightDiff.Text = Format(((Val(sqlDT.Rows(0)("Current_Daily_Rate")) / 8) * 0.1) / 60, "N2")


        'txt_philhealth.Text = sqlDT.Rows(0)("Philhealth_Share").ToString
        'txt_pagibig.Text = sqlDT.Rows(0)("Pag_ibig_Share").ToString
        'txt_SSS.Text = sqlDT.Rows(0)("SSS_Share").ToString
        'txt_tax.Text = sqlDT.Rows(0)("Tax_Amount").ToString
        'txt_minusLate.Text = Format(Val(sqlDT.Rows(0)("Current_Daily_Rate")) / 8 / 60, "N2")
        'txt_minusUndertime.Text = Format(Val(sqlDT.Rows(0)("Current_Daily_Rate")) / 8 / 60, "N2")



        'sqlSTR = "select *, COALESCE(totalSSS, 0) as total_SSS, COALESCE(totalPhilhealth, 0) as total_Philhealth, COALESCE(totalPagIbig, 0) as total_PagIbig, COALESCE(totalTax, 0) as total_Tax, COALESCE(payRegular, 0) as payRegular2, COALESCE(paySpecial, 0) as paySpecial2, COALESCE(payField, 0) as payField2 from Payroll_Details INNER JOIN Payroll on Payroll.Payroll_ID = Payroll_Details.Payroll_ID " & _
        '    " where Employee_ID =" & employee_id & " and Payroll_Details.Payroll_id =" & payroll_id
        'ExecuteSQLQuery(sqlSTR)

        'payroll_detail_id = sqlDT.Rows(0)("Payroll_Detail_ID")
        'dt_cutoffStart.Text = sqlDT.Rows(0)("Cutoff_Date_Start")
        'dt_cutoffEnd.Text = sqlDT.Rows(0)("Cutoff_Date_End")



        'If sqlDT.Rows(0)("payRegular2") <> 0 Then
        '    txt_payRegular.Text = sqlDT.Rows(0)("payRegular2")
        '    txt_payHoliday.Text = sqlDT.Rows(0)("payRegular2")
        '    txt_payLeave.Text = sqlDT.Rows(0)("payRegular2")
        '    txt_payOvertime.Text = Format(Val(sqlDT.Rows(0)("payRegular2")) / 8 / 60, "N2")
        '    txt_payNightDiff.Text = Format(((Val(sqlDT.Rows(0)("payRegular2")) / 8) * 0.1) / 60, "N2")
        'End If
        'txt_paySpecial.Text = sqlDT.Rows(0)("paySpecial2")
        'txt_payField.Text = sqlDT.Rows(0)("payField2")

        'txt_numRegular.Text = sqlDT.Rows(0)("numRegular").ToString
        'txt_numSpecial.Text = sqlDT.Rows(0)("numSpecial").ToString
        'txt_numField.Text = sqlDT.Rows(0)("numField").ToString
        'txt_numHoliday.Text = sqlDT.Rows(0)("numHoliday").ToString
        'txt_numLeave.Text = sqlDT.Rows(0)("numLeave").ToString
        'txt_numOvertime.Text = sqlDT.Rows(0)("numOvertime").ToString
        'txt_numNightDiff.Text = sqlDT.Rows(0)("numNight_diff").ToString
        'txt_totalRegular.Text = sqlDT.Rows(0)("totalRegular").ToString
        'txt_totalSpecial.Text = sqlDT.Rows(0)("totalSpecial").ToString
        'txt_totalField.Text = sqlDT.Rows(0)("totalField").ToString
        'txt_totalHoliday.Text = sqlDT.Rows(0)("totalHoliday").ToString
        'txt_totalLeave.Text = sqlDT.Rows(0)("totalLeave").ToString
        'txt_totalOvertime.Text = sqlDT.Rows(0)("totalOvertime").ToString
        'txt_totalNightDiff.Text = sqlDT.Rows(0)("totalNight_diff").ToString

        'txt_SSS.Text = sqlDT.Rows(0)("totalSSS")
        'txt_philhealth.Text = sqlDT.Rows(0)("totalPhilhealth")
        'txt_pagibig.Text = sqlDT.Rows(0)("totalPagIbig")
        'txt_tax.Text = sqlDT.Rows(0)("totalTax")

        'If SafeDbl(sqlDT.Rows(0)("total_SSS").ToString) > 0 Then cb_SSS.Checked = True
        'If SafeDbl(sqlDT.Rows(0)("total_Philhealth").ToString) > 0 Then cb_philhealth.Checked = True
        'If SafeDbl(sqlDT.Rows(0)("total_PagIbig").ToString) > 0 Then cb_pagibig.Checked = True
        'If SafeDbl(sqlDT.Rows(0)("total_Tax").ToString) > 0 Then cb_Tax.Checked = True

        'txt_insurance.Text = sqlDT.Rows(0)("totalInsurance").ToString
        'txt_charge.Text = sqlDT.Rows(0)("totalCharge").ToString
        'txt_totalLate.Text = sqlDT.Rows(0)("totalLate").ToString
        'txt_totalUndertime.Text = sqlDT.Rows(0)("totalUndertime").ToString
        'txt_numLate.Text = sqlDT.Rows(0)("numLate").ToString
        'txt_numUndertime.Text = sqlDT.Rows(0)("numUndertime").ToString

        'txt_totalNumAbsent.Text = sqlDT.Rows(0)("totalNumAbsent").ToString
        'txt_totalNumLate.Text = sqlDT.Rows(0)("totalNumLate").ToString

        'txt_payAddSpecial.Text = sqlDT.Rows(0)("totalAddSpecial").ToString
        'txt_payAddField.Text = sqlDT.Rows(0)("totalAddField").ToString
        'txt_payAddIncentive.Text = sqlDT.Rows(0)("totalAddIncentive").ToString
        'txt_payAddAllowance.Text = sqlDT.Rows(0)("totalAddAllowance").ToString

        'txt_grandTotal_Basic.Text = sqlDT.Rows(0)("grandTotal_Basic").ToString
        'txt_grandTotal_Additional.Text = sqlDT.Rows(0)("grandTotal_Additional").ToString
        'txt_grandTotal_Gross.Text = sqlDT.Rows(0)("grandTotal_Gross").ToString
        'txt_grandTotal_Deduction.Text = sqlDT.Rows(0)("grandTotal_Deduction").ToString
        'txt_grandTotal_Loan.Text = sqlDT.Rows(0)("grandTotal_Loan").ToString
        'txt_grandTotal_Net.Text = sqlDT.Rows(0)("grandTotal_Net").ToString
        'txt_payroll_employeeRemarks.Text = sqlDT.Rows(0)("payroll_employeeRemarks").ToString
        formLoaded = True

        DeductionsCompute()
        RefreshLoanList()
        RefreshLoanPaymentList()


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
        txt_totalRegular.Text = (SafeDbl(txt_payRegular.Text) * SafeDbl(txt_numRegular.Text)).ToString("N2")
        txt_totalSpecial.Text = (SafeDbl(txt_paySpecial.Text) * SafeDbl(txt_numSpecial.Text)).ToString("N2")
        txt_totalField.Text = (SafeDbl(txt_payField.Text) * SafeDbl(txt_numField.Text)).ToString("N2")
        txt_totalHoliday.Text = (SafeDbl(txt_payHoliday.Text) * SafeDbl(txt_numHoliday.Text)).ToString("N2")
        txt_totalLeave.Text = (SafeDbl(txt_payLeave.Text) * SafeDbl(txt_numLeave.Text)).ToString("N2")
        txt_totalOvertime.Text = (SafeDbl(txt_payOvertime.Text) * SafeDbl(txt_numOvertime.Text)).ToString("N2")
        txt_totalNightDiff.Text = (SafeDbl(txt_payNightDiff.Text) * SafeDbl(txt_numNightDiff.Text)).ToString("N2")

        GrandTotalCompute()
    End Sub

    Private Function SafeDbl(value As Object) As Double
        If value Is Nothing OrElse Not IsNumeric(value) Then
            Return 0
        End If
        Return CDbl(value)
    End Function

    Private Sub GrandTotalCompute()
        If formLoaded Then
            txt_grandTotal_Basic.Text = (SafeDbl(txt_totalRegular.Text) + SafeDbl(txt_totalSpecial.Text) + SafeDbl(txt_totalField.Text) + SafeDbl(txt_totalHoliday.Text) + SafeDbl(txt_totalLeave.Text) + SafeDbl(txt_totalOvertime.Text) + SafeDbl(txt_totalNightDiff.Text)).ToString("N2")
            txt_grandTotal_Additional.Text = (SafeDbl(txt_payAddSpecial.Text) + SafeDbl(txt_payAddField.Text) + SafeDbl(txt_payAddIncentive.Text) + SafeDbl(txt_payAddAllowance.Text)).ToString("N2")
            txt_grandTotal_Gross.Text = (SafeDbl(txt_grandTotal_Basic.Text) + SafeDbl(txt_grandTotal_Additional.Text)).ToString("N2")
            txt_grandTotal_Net.Text = (SafeDbl(txt_grandTotal_Gross.Text) - SafeDbl(txt_grandTotal_Deduction.Text) - SafeDbl(txt_grandTotal_Loan.Text)).ToString("N2")
        End If


        'txt_grandTotal_Basic.Text = SafeDbl(txt_grandTotal_Basic.Text).ToString("N2")
        'txt_grandTotal_Additional.Text = SafeDbl(txt_grandTotal_Additional.Text).ToString("N2")
        'txt_grandTotal_Gross.Text = SafeDbl(txt_grandTotal_Gross.Text).ToString("N2")
        'txt_grandTotal_Net.Text = SafeDbl(txt_grandTotal_Net.Text).ToString("N2")

    End Sub

    Private Sub DeductionsCompute()
        If formLoaded Then
            txt_totalLate.Text = (SafeDbl(txt_minusLate.Text) * SafeDbl(txt_numLate.Text)).ToString("N2")
            txt_totalUndertime.Text = (SafeDbl(txt_minusUndertime.Text) * SafeDbl(txt_numUndertime.Text)).ToString("N2")
            txt_grandTotal_Deduction.Text = (SafeDbl(txt_totalLate.Text) + SafeDbl(txt_totalUndertime.Text) + SafeDbl(txt_charge.Text) + SafeDbl(txt_insurance.Text) + SafeDbl(txt_philhealth.Tag) + SafeDbl(txt_pagibig.Tag) + SafeDbl(txt_SSS.Tag) + SafeDbl(txt_tax.Tag)).ToString("N2")
        End If


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
        If SafeDbl(txt_grandTotal_Net.Text) < 1 Then
            MsgBox("Payroll net amount invalid. Check values and try again.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

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

        Me.Close()
    End Sub



    Private Sub EditEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEmployeeToolStripMenuItem.Click
        If LoanID_hasLoanPayment() Then
            Exit Sub
        End If
        ShowForm2(FrmLOAN_PAYMENT, "add", lst_loans.FocusedItem.Text, payroll_detail_id)
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
        ShowForm2(FrmLOAN_PAYMENT, "edit", lst_loanPayment.FocusedItem.Text, payroll_detail_id)
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