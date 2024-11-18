Public Class FormPAYROLL_ADD
    Dim payroll_Id As Integer
    Dim approved As Boolean
    Private Sub FormPAYROLL_ADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_payroll_ID.Text = ""
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
            dt_cutoffStart.Text = sqlDT.Rows(0)("Cutoff_Date_Start")
            dt_cutoffEnd.Text = sqlDT.Rows(0)("Cutoff_Date_End")
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
                dt_cutoffStart.Enabled = False
                dt_cutoffEnd.Enabled = False
                rtb_remarks.ReadOnly = True
                dt_payroll.Enabled = False
                EditEmployeeToolStripMenuItem.Text = "View Payroll Record"
                DeleteEmployeeToolStripMenuItem.Enabled = False
                'Me.ControlBox = True
            Else
                cb_Approved.Checked = False
                cb_Approved.Enabled = True
                btn_newPayroll.Enabled = True
                btn_Save.Enabled = True
                dt_cutoffStart.Enabled = True
                dt_cutoffEnd.Enabled = True
                rtb_remarks.ReadOnly = False
                dt_payroll.Enabled = True
                EditEmployeeToolStripMenuItem.Text = "Edit Payroll Record"
                DeleteEmployeeToolStripMenuItem.Enabled = True
                'Me.ControlBox = False
            End If

        Else 'ADD
            sqlSTR = "SELECT IDENT_CURRENT('Payroll') + IDENT_INCR('Payroll') AS Payroll_ID"
            ExecuteSQLQuery(sqlSTR)

            payroll_Id = sqlDT.Rows(0)("Payroll_ID")
            txt_payroll_ID.Text = payroll_Id
            txt_encodedby.Text = "Encoded by : " & xUsername
        End If

        RefreshPayrollDetailList()

       
    End Sub







    Private Sub RefreshPayrollDetailList()
        Dim net, gross, loan, deduction As Double
        sqlSTR = "Select Payroll_Detail_ID as ID, Payroll_Details.Employee_ID as 'Employee ID', CONCAT(Last_Name, ', ', First_Name) as 'Employee', FORMAT(COALESCE(grandTotal_Basic, 0), 'N2') AS 'Total Basic Pay', FORMAT(COALESCE(grandTotal_Additional, 0), 'N2') AS 'Total Additional Pay', FORMAT(COALESCE(grandTotal_Gross, 0), 'N2') AS 'Total Gross', " & _
                "FORMAT(COALESCE(grandTotal_Deduction, 0), 'N2') AS 'Total Deduction', FORMAT(COALESCE(grandTotal_Loan, 0), 'N2') AS 'Total Loan Payment', FORMAT(COALESCE(grandTotal_Net, 0), 'N2') AS 'Total Net' " & _
                "from Payroll_Details INNER JOIN Employees on Employees.Employee_ID = Payroll_Details.Employee_ID where Payroll_ID = " & payroll_Id & " order by Last_Name, First_Name"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_payrollRecord, 0)

        For i = 0 To lst_payrollRecord.Items.Count - 1
            gross = gross + CDbl(lst_payrollRecord.Items(i).SubItems(5).Text)
            deduction = deduction + CDbl(lst_payrollRecord.Items(i).SubItems(6).Text)
            loan = loan + CDbl(lst_payrollRecord.Items(i).SubItems(7).Text)
            net = net + CDbl(lst_payrollRecord.Items(i).SubItems(8).Text)
        Next
        txt_TotalgrossPay.Text = Format(gross, "N2")
        txt_totalDeductions.Text = Format(deduction, "N2")
        txt_totalLoansPaid.Text = Format(loan, "N2")
        txt_TotalnetPay.Text = Format(net, "N2")
    End Sub


    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        If lst_payrollRecord.Items.Count > 0 And approved = False Then
            Save()
        End If
        Me.Close()
    End Sub



    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Save()
    End Sub

    Private Sub Save()
        If formOperation = "edit" Then
            sqlSTR = "UPDATE Payroll SET " &
                       "Payroll_Date = '" & dt_payroll.Text & "', " &
                       "Cutoff_Date_Start = '" & dt_cutoffStart.Text & "', " &
                       "Cutoff_Date_End = '" & dt_cutoffEnd.Text & "', " &
                       "Total_GrossPay = '" & txt_TotalgrossPay.Text & "', " &
                       "Total_NetPay = '" & txt_TotalnetPay.Text & "', " &
                       "Total_Deductions = '" & txt_totalDeductions.Text & "', " &
                       "Total_LoansPaid = '" & txt_totalLoansPaid.Text & "', " &
                       "Payroll_Remarks = '" & rtb_remarks.Text & "' " &
                       "WHERE Payroll_ID =" & payroll_Id
            ExecuteSQLQuery(sqlSTR)

        Else 'Add
            sqlSTR = "select payroll_id from payroll where payroll_id =" & txt_payroll_ID.Text
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count = 0 Then
                sqlSTR = "INSERT INTO Payroll (Payroll_Date, Cutoff_Date_Start, Cutoff_Date_End, Total_GrossPay, Total_NetPay, Total_Deductions, Total_LoansPaid, Payroll_Remarks, Encoded_by) " &
                      "VALUES ('" & dt_payroll.Text & "', '" & dt_cutoffStart.Text & "', '" & dt_cutoffEnd.Text & "', '" & txt_TotalgrossPay.Text & "', '" & txt_TotalnetPay.Text & "', '" & txt_totalDeductions.Text & "', '" & txt_totalLoansPaid.Text & "', '" & rtb_remarks.Text & "', '" & xUsername & "')"
                ExecuteSQLQuery(sqlSTR)
            End If
        End If

        If Not txt_encodedby.Text.Contains(xUsername) Then
            sqlSTR = "Update Payroll SET Encoded_by = Concat(Encoded_by, ', " & xUsername & "') where Payroll_ID =" & payroll_Id
            ExecuteSQLQuery(sqlSTR)
        End If

        If cb_Approved.Checked Then

            If MsgBox("Would you like to approve this payroll record? Please note that once approved, it cannot be modified.", MsgBoxStyle.YesNo + MsgBoxStyle.Information, msgBox_header) = MsgBoxResult.Yes Then
                sqlSTR = "Update Payroll set Payroll_Approved='Yes', Approved_by='" & xUsername & "' where Payroll_ID=" & payroll_Id
                ExecuteSQLQuery(sqlSTR)

                For i = 0 To lst_payrollRecord.Items.Count - 1
                    sqlSTR = "Update Loan_Payments set Payment_Posted = 'Yes' where Payroll_Detail_ID =" & lst_payrollRecord.Items(i).SubItems(0).Text
                    ExecuteSQLQuery(sqlSTR)
                Next
                UpdateLoanStatus()
            Else
                cb_Approved.Checked = False
                Exit Sub
            End If
            MsgBox("Succesfully APPROVED payroll record.", MsgBoxStyle.Information, msgBox_header)
        Else
            'MsgBox("Succesfully SAVED payroll record.", MsgBoxStyle.Information, msgBox_header)
        End If



        FormPAYROLL.RefreshPayrollList()
        Me.Close()
    End Sub



    '//////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub btn_newPayroll_Click(sender As Object, e As EventArgs) Handles btn_newPayroll.Click
        sqlSTR = "Select * from employees where Employment_Status != 'Resigned' or Employment_Status != 'Terminated' order by Last_Name, First_Name"
        FILLComboBox_Employee(sqlSTR, cmb_employees)
        grp_Payrollpayee.Visible = True
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If cmb_employees.Text = "" Then Exit Sub

        sqlSTR = "select Employee_ID from Payroll_Details where Employee_ID =" & Split(cmb_employees.Text, " - ")(0) & " and Payroll_ID = " & payroll_Id
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            MsgBox("Payroll for current employee is already existing, edit instead and try again.", MsgBoxStyle.Critical, msgBox_header)
            Exit Sub
        End If


        sqlSTR = "select Payroll_ID from Payroll where Payroll_ID =" & payroll_Id
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count = 0 Then
            sqlSTR = "INSERT INTO Payroll (Payroll_Date, Cutoff_Date_Start, Cutoff_Date_End, Total_GrossPay, Total_NetPay, Total_Deductions, Total_LoansPaid, Payroll_Remarks, Encoded_by) " &
                      "VALUES ('" & dt_payroll.Text & "', '" & dt_cutoffStart.Text & "', '" & dt_cutoffEnd.Text & "', '" & txt_TotalgrossPay.Text & "', '" & txt_TotalnetPay.Text & "', '" & txt_totalDeductions.Text & "', '" & txt_totalLoansPaid.Text & "', '" & rtb_remarks.Text & "', '" & xUsername & "')"
            ExecuteSQLQuery(sqlSTR)

            formOperation = "edit"
        End If


        sqlSTR = "INSERT INTO Payroll_Details (Employee_ID, Payroll_ID) VALUES (" & Split(cmb_employees.Text, " - ")(0) & ", " & payroll_Id & ")"
        ExecuteSQLQuery(sqlSTR)

        ShowForm2(FormPAYROLL_PAYEE, formOperation, Split(cmb_employees.Text, " - ")(0), payroll_Id)
        grp_Payrollpayee.Visible = False

        RefreshPayrollDetailList()


    End Sub

    Private Sub btn_cancelSubmit_Click(sender As Object, e As EventArgs) Handles btn_cancelSubmit.Click
        grp_Payrollpayee.Visible = False

        RefreshPayrollDetailList()
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////////////////




    Private Sub EditEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEmployeeToolStripMenuItem.Click
        If approved Then
            ShowForm2(FormPAYROLL_PAYEE, "view", lst_payrollRecord.FocusedItem.SubItems(1).Text, payroll_Id)
            grp_Payrollpayee.Visible = False
        Else
            ShowForm2(FormPAYROLL_PAYEE, "edit", lst_payrollRecord.FocusedItem.SubItems(1).Text, payroll_Id)
            grp_Payrollpayee.Visible = False
        End If

        RefreshPayrollDetailList()
    End Sub

    Private Sub lst_payrollRecord_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_payrollRecord.MouseDoubleClick
        If approved Then
            ShowForm2(FormPAYROLL_PAYEE, "view", lst_payrollRecord.FocusedItem.SubItems(1).Text, payroll_Id)
            grp_Payrollpayee.Visible = False
        Else
            ShowForm2(FormPAYROLL_PAYEE, "edit", lst_payrollRecord.FocusedItem.SubItems(1).Text, payroll_Id)
            grp_Payrollpayee.Visible = False
        End If

        RefreshPayrollDetailList()
    End Sub


    Private Sub DeleteEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeToolStripMenuItem.Click
        If MsgBox("Do you want to delete this payroll detail record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, msgBox_header) = MsgBoxResult.Yes Then
            sqlSTR = "Delete payroll_details where Payroll_Detail_ID=" & lst_payrollRecord.FocusedItem.Text
            ExecuteSQLQuery(sqlSTR)

            MsgBox("Deleted payroll detail record.", MsgBoxStyle.Information, msgBox_header)
        End If
        RefreshPayrollDetailList()
    End Sub

    Private Sub PrintEmployeePayslipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintEmployeePayslipToolStripMenuItem.Click
        If approved Then
            ShowForm1(FormPRINT_PAYSLIP, "add", payroll_Id)
        Else
            MsgBox("Payroll not approved; try again once approved.", MsgBoxStyle.Exclamation, msgBox_header)
            Exit Sub
        End If



    End Sub

    Private Sub ExportToBankFormatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToBankFormatToolStripMenuItem.Click
        If approved Then
            ShowForm1(FormEXPORT_ONLINE_BANK, "add", payroll_Id)
        Else
            MsgBox("Payroll not approved; try again once approved.", MsgBoxStyle.Exclamation, msgBox_header)
            Exit Sub
        End If


    End Sub

    Private Sub UpdateLoanStatus()
        sqlSTR = "select Loans.Loan_ID, " & _
            "max(Loan_Gross_Amount) as 'Loan Gross', " & _
            "max(Loan_Gross_Amount) - sum(case when Payment_Posted = 'Yes' then COALESCE(Gross_Payment, 0) else 0 end) as 'Loan_Balance' " & _
            "from Loans LEFT JOIN Loan_Payments on Loan_Payments.Loan_ID = Loans.Loan_ID " & _
            "group by Loans.Loan_ID " & _
            "having max(Loan_Gross_Amount) - sum(case when Payment_Posted = 'Yes' then COALESCE(Gross_Payment, 0) else 0 end) < 1 " & _
            "and MAX(Loan_Status) = 'Active'"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            Dim LoanID_List As New List(Of Integer)()
            For i = 0 To sqlDT.Rows.Count - 1
                LoanID_List.Add(sqlDT.Rows(i)("Loan_ID"))
            Next
            For Each value As Integer In LoanID_List
                sqlSTR = "update Loans set Loan_Status = 'Paid' where Loan_ID=" & value
                ExecuteSQLQuery(sqlSTR)
            Next
        End If
    End Sub


    'Private Function HasLoanPostingError() As Boolean
    '    sqlSTR = "select max(Employees.Employee_ID) as Employee_Id, Concat(max(Last_Name), ', ' , max(first_name)) as Name, sum(COALESCE(Gross_Payment, 0)) as Gross, max(Loan_Gross_Amount) - sum(case when Payment_Posted='Yes' then COALESCE(Gross_Payment, 0) else 0 end) as Balance_Amount, Loans.Loan_ID  from Loan_Payments " & _
    '                "left join Loans on Loans.Loan_ID = Loan_Payments.Loan_ID " & _
    '                "left join Payroll_Details on Payroll_Details.Payroll_Detail_ID = Loan_Payments.Payroll_Detail_ID " & _
    '                "left join Payroll on Payroll.Payroll_ID = Payroll_Details.Payroll_ID " & _
    '                "left join Employees on Employees.Employee_ID = Payroll_Details.Employee_ID " & _
    '                "where Payroll.Payroll_ID =" & payroll_Id & _
    '                "group by Loans.Loan_ID " & _
    '                "having sum(COALESCE(Gross_Payment, 0)) > max(Loan_Gross_Amount) - sum(case when Payment_Posted='Yes' then COALESCE(Gross_Payment, 0) else 0 end)"
    '    ExecuteSQLQuery(sqlSTR)

    '    If sqlDT.Rows.Count > 0 Then
    '        Dim list As String = ""
    '        For i = 0 To sqlDT.Rows.Count - 1
    '            list = list & sqlDT.Rows(i)("Employee_Id") & " - " & sqlDT.Rows(i)("Name") & "(Loan ID: " & sqlDT.Rows(i)("Loan_Id") & ")" & vbCrLf
    '        Next
    '        MsgBox("The following have discrepancies in loan payments:" & vbCrLf & list & vbCrLf & "Fix errors, then try again.", MsgBoxStyle.Critical, msgBox_header)
    '        Return True
    '    End If
    '    Return False
    'End Function

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        ShowForm1(FormVIEW_PAYROLL, "view", payroll_Id)
    End Sub

    Private Sub cb_Approved_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Approved.CheckedChanged

    End Sub

    Private Sub cmb_employees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_employees.SelectedIndexChanged

    End Sub
End Class