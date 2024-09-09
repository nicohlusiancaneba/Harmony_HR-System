Public Class FormPAYROLL_ADD
    Dim payroll_Id As Integer
    Dim approved As Boolean
    Private Sub FormPAYROLL_ADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_payroll_ID.Text = ""
        txt_cutoff.Text = ""
        txt_TotalgrossPay.Text = ""
        txt_totalLoansPaid.Text = ""
        txt_totalDeductions.Text = ""
        txt_TotalnetPay.Text = ""
        rtb_remarks.Text = ""
        approved = False


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

            If sqlDT.Rows(0)("Payroll_Approved").ToString = "Yes" Then
                approved = True
            End If

            If approved Then
                cb_Approved.Checked = True
                cb_Approved.Enabled = False
                btn_newPayroll.Enabled = False
                btn_Save.Enabled = False
                txt_cutoff.ReadOnly = True
                rtb_remarks.ReadOnly = True
                dt_payroll.Enabled = False
            Else
                cb_Approved.Checked = False
                cb_Approved.Enabled = True
                btn_newPayroll.Enabled = True
                btn_Save.Enabled = True
                txt_cutoff.ReadOnly = False
                rtb_remarks.ReadOnly = False
                dt_payroll.Enabled = True
            End If

        Else 'ADD
            sqlSTR = "SELECT IDENT_CURRENT('Payroll') + IDENT_INCR('Payroll') AS Payroll_ID"
            ExecuteSQLQuery(sqlSTR)

            payroll_Id = sqlDT.Rows(0)("Payroll_ID")
            txt_payroll_ID.Text = payroll_Id
        End If

        RefreshPayrollDetailList()
    End Sub

    Private Sub RefreshPayrollDetailList()
        sqlSTR = "Select Payroll_Detail_ID as ID, Payroll_Details.Employee_ID as 'Employee ID', CONCAT(Last_Name, ', ', First_Name) as 'Employee', grandTotal_Basic as 'Total Basic Pay', grandTotal_Additional as 'Total Additional Pay', " & _
                "grandTotal_Gross as 'Total Gross', grandTotal_Deduction as 'Total Deduction', grandTotal_Loan as 'Total Loan Payment', grandTotal_Net as 'Total Net' " & _
                "from Payroll_Details INNER JOIN Employees on Employees.Employee_ID = Payroll_Details.Employee_ID where Payroll_ID = " & payroll_Id
        FillListView(ExecuteSQLQuery(sqlSTR), lst_payrollRecord, 0)
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

        If cb_Approved.Checked Then
            If MsgBox("Would you like to approve this payroll record? Please note that once approved, it cannot be modified.", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, msgBox_header) = MsgBoxResult.Yes Then
                sqlSTR = "Update Payroll set Payroll_Approved='Yes', Approved_by='" & xUsername & "' where Payroll_ID=" & payroll_Id
                ExecuteSQLQuery(sqlSTR)

                For i = 0 To lst_payrollRecord.Items.Count - 1
                    sqlSTR = "Update Loan_Payments set Payment_Posted = 'Yes' where Payroll_Detail_ID =" & lst_payrollRecord.FocusedItem.Text
                    ExecuteSQLQuery(sqlSTR)
                Next
            End If
            MsgBox("Succesfully APPROVED payroll record.", MsgBoxStyle.Information, msgBox_header)
        Else
            MsgBox("Succesfully SAVED payroll record.", MsgBoxStyle.Information, msgBox_header)
        End If


        Me.Close()
    End Sub





    '//////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub btn_newPayroll_Click(sender As Object, e As EventArgs) Handles btn_newPayroll.Click
        sqlSTR = "Select * from employees where Employment_Status != 'Inactive'"
        FILLComboBox_Employee(sqlSTR, cmb_employees)
        grp_Payrollpayee.Visible = True
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        sqlSTR = "select Employee_ID from Payroll_Details where Employee_ID =" & Split(cmb_employees.Text, " - ")(0) & " and Payroll_ID = " & payroll_Id
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            MsgBox("Payroll for current employee is already existing, edit instead and try again.", MsgBoxStyle.Critical, msgBox_header)
            Exit Sub
        End If

        sqlSTR = "INSERT INTO Payroll_Details (Employee_ID, Payroll_ID) VALUES (" & Split(cmb_employees.Text, " - ")(0) & ", " & payroll_Id & ")"
        ExecuteSQLQuery(sqlSTR)

        ShowForm2(FormPAYROLL_PAYEE, "add", Split(cmb_employees.Text, " - ")(0), payroll_Id)
        grp_Payrollpayee.Visible = False

        RefreshPayrollDetailList()
    End Sub

    Private Sub btn_cancelSubmit_Click(sender As Object, e As EventArgs) Handles btn_cancelSubmit.Click
        grp_Payrollpayee.Visible = False

        RefreshPayrollDetailList()
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////////////////
    


    
    Private Sub EditEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEmployeeToolStripMenuItem.Click
        ShowForm2(FormPAYROLL_PAYEE, "edit", lst_payrollRecord.FocusedItem.SubItems(1).Text, payroll_Id)
        grp_Payrollpayee.Visible = False

        RefreshPayrollDetailList()
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Approved.CheckedChanged

    End Sub
End Class