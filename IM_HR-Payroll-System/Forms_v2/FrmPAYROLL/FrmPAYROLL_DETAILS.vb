Public Class FrmPAYROLL_DETAILS
    Public payroll_Id, frmOperation, employeeID As String

    Public approved, edit, formLoaded As Boolean
    Private Sub FrmPAYROLL_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeHelper.ApplyHighlight(Me)
        formLoaded = False
        txt_TotalgrossPay.Text = ""
        txt_totalLoansPaid.Text = ""
        txt_totalDeductions.Text = ""
        txt_TotalnetPay.Text = ""
        rtb_remarks.Text = ""
        cmb_type.Text = "Monthly"
        dt_payroll.Text = Today()
        dt_cutoffEnd.Text = Today()
        dt_cutoffStart.Text = Today()
        cmb_monthApplicable.Text = Today.ToString("MMMM")
        approved = False
        dgv_payroll.Rows.Clear()
        payroll_Id = ""
        frmOperation = FrmPAYROLL.formAction

        If frmOperation = "edit" Then
            payroll_Id = FrmPAYROLL.lst_payroll.FocusedItem.SubItems(0).Text

            Label_ID.Visible = True
            Label_ID.Text = "ID#" & payroll_Id
            Label_ID.Left = Panel1.Width - Label_ID.Width - 10

            sqlSTR = "SELECT *, COALESCE(Payroll_Type, 'Others') as Payrolltype, COALESCE(Payroll_Month, DATENAME(MONTH, Cutoff_Date_End)) as Payrollmonth from Payroll where Payroll_ID='" & payroll_Id & "';"
            ExecuteSQLQuery(sqlSTR)

            dt_payroll.Text = sqlDT.Rows(0)("Payroll_Date")
            cmb_type.Text = sqlDT.Rows(0)("Payrolltype")
            cmb_monthApplicable.Text = sqlDT.Rows(0)("Payrollmonth")
            dt_cutoffStart.Text = sqlDT.Rows(0)("Cutoff_Date_Start")
            dt_cutoffEnd.Text = sqlDT.Rows(0)("Cutoff_Date_End")
            'txt_TotalgrossPay.Text = sqlDT.Rows(0)("Total_GrossPay")
            'txt_TotalnetPay.Text = sqlDT.Rows(0)("Total_NetPay")
            'txt_totalDeductions.Text = sqlDT.Rows(0)("Total_Deductions")
            'txt_totalLoansPaid.Text = sqlDT.Rows(0)("Total_LoansPaid")
            rtb_remarks.Text = sqlDT.Rows(0)("Payroll_Remarks")
            lbl_encoder.Text = "Encoded by : " & sqlDT.Rows(0)("Encoded_by")

            If sqlDT.Rows(0)("Payroll_Approved").ToString = "Yes" Then
                approved = True
            End If

            If approved Then
                cb_Approved.Checked = True
                cb_Approved.Enabled = False
                btn_add.Enabled = False
                btn_edit.Text = "View"
                btn_delete.Enabled = False
                btn_Save.Enabled = False
                ContextMenuStrip1.Enabled = True
                Payroll_Details.Enabled = False


            Else
                cb_Approved.Checked = False
                cb_Approved.Enabled = True
                btn_add.Enabled = True
                btn_edit.Text = "Edit"
                btn_delete.Enabled = True
                btn_Save.Enabled = True
                ContextMenuStrip1.Enabled = False
                Payroll_Details.Enabled = True



            End If

            Refresh_Payroll_Details()


        Else 'ADD
            cb_Approved.Checked = False
            cb_Approved.Enabled = True
            btn_add.Enabled = True
            btn_edit.Text = "Edit"
            btn_delete.Enabled = True
            btn_Save.Enabled = True
            ContextMenuStrip1.Enabled = False
            Payroll_Details.Enabled = True

        End If




        formLoaded = True
    End Sub

    Private Sub Compute_Total()
        Dim loans, deductions, net, gross As Double

        loans = 0
        deductions = 0
        net = 0
        gross = 0

        For Each row As DataGridViewRow In dgv_payroll.Rows
            If Not row.IsNewRow Then

                gross += Convert.ToDouble(If(row.Cells("Total_Gross").Value, 0))
                deductions += Convert.ToDouble(If(row.Cells("Total_Deductions").Value, 0))
                loans += Convert.ToDouble(If(row.Cells("Total_Loan_Pays").Value, 0))
                net += Convert.ToDouble(If(row.Cells("Total_Net").Value, 0))
            End If
        Next

        txt_TotalgrossPay.Text = gross.ToString("N2")
        txt_totalDeductions.Text = deductions.ToString("N2")
        txt_totalLoansPaid.Text = loans.ToString("N2")
        txt_TotalnetPay.Text = net.ToString("N2")
    End Sub

    Private Sub Refresh_Payroll_Details()
        sqlSTR = "Select " & _
                        "Payroll_Detail_ID as ID, " & _
                        "Payroll_Details.Employee_ID as Employee_ID, " & _
                        "CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', LEFT(TRIM(Middle_Name), 1), '.') as Name, " & _
                        "FORMAT(COALESCE(grandTotal_Basic, 0), 'N2') AS Basic, " & _
                        "FORMAT(COALESCE(grandTotal_Additional, 0), 'N2') AS Additional, " & _
                        "FORMAT(COALESCE(grandTotal_Gross, 0), 'N2') AS Gross, " & _
                        "FORMAT(COALESCE(grandTotal_Deduction, 0), 'N2') AS Deduction, " & _
                        "FORMAT(COALESCE(grandTotal_Loan, 0), 'N2') AS Loan, " & _
                        "FORMAT(COALESCE(grandTotal_Net, 0), 'N2') AS Net " & _
                        "from Payroll_Details " & _
                        "INNER JOIN Employees on Employees.Employee_ID = Payroll_Details.Employee_ID " & _
                        "where Payroll_ID = '" & payroll_Id & "' " & _
                        "order by Last_Name, First_Name, Middle_Name;"
        ExecuteSQLQuery(sqlSTR)
        dgv_payroll.Rows.Clear()

        If sqlDT.Rows.Count > 0 Then
            For i = 0 To sqlDT.Rows.Count - 1
                dgv_payroll.Rows.Add(
                sqlDT.Rows(i)("ID"),
                sqlDT.Rows(i)("Employee_ID"),
                sqlDT.Rows(i)("Name"),
                sqlDT.Rows(i)("Basic"),
                sqlDT.Rows(i)("Additional"),
                sqlDT.Rows(i)("Gross"),
                sqlDT.Rows(i)("Deduction"),
                sqlDT.Rows(i)("Loan"),
                sqlDT.Rows(i)("Net")
                )
            Next
        End If

        Compute_Total()
    End Sub




    'Private Sub RefreshPayrollDetailList()
    '    Dim net, gross, loan, deduction As Double
    '    sqlSTR = "Select Payroll_Detail_ID as ID, Payroll_Details.Employee_ID as 'Employee ID', CONCAT(Last_Name, ', ', First_Name) as 'Employee', FORMAT(COALESCE(grandTotal_Basic, 0), 'N2') AS 'Total Basic Pay', FORMAT(COALESCE(grandTotal_Additional, 0), 'N2') AS 'Total Additional Pay', FORMAT(COALESCE(grandTotal_Gross, 0), 'N2') AS 'Total Gross', " & _
    '            "FORMAT(COALESCE(grandTotal_Deduction, 0), 'N2') AS 'Total Deduction', FORMAT(COALESCE(grandTotal_Loan, 0), 'N2') AS 'Total Loan Payment', FORMAT(COALESCE(grandTotal_Net, 0), 'N2') AS 'Total Net' " & _
    '            "from Payroll_Details INNER JOIN Employees on Employees.Employee_ID = Payroll_Details.Employee_ID where Payroll_ID = " & payroll_Id & " order by Last_Name, First_Name"
    '    FillListView(ExecuteSQLQuery(sqlSTR), lst_payrollRecord, 0)

    '    For i = 0 To lst_payrollRecord.Items.Count - 1
    '        gross = gross + CDbl(lst_payrollRecord.Items(i).SubItems(5).Text)
    '        deduction = deduction + CDbl(lst_payrollRecord.Items(i).SubItems(6).Text)
    '        loan = loan + CDbl(lst_payrollRecord.Items(i).SubItems(7).Text)
    '        net = net + CDbl(lst_payrollRecord.Items(i).SubItems(8).Text)
    '    Next
    '    txt_TotalgrossPay.Text = Format(gross, "N2")
    '    txt_totalDeductions.Text = Format(deduction, "N2")
    '    txt_totalLoansPaid.Text = Format(loan, "N2")
    '    txt_TotalnetPay.Text = Format(net, "N2")
    'End Sub


    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub



    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Save()
        Me.Close()
    End Sub

    Private Sub Save_New_Payroll()
            sqlSTR = "INSERT INTO Payroll (Payroll_Date, Cutoff_Date_Start, Cutoff_Date_End, Total_GrossPay, Total_NetPay, Total_Deductions, Total_LoansPaid, Payroll_Remarks, Encoded_by, Payroll_Type, Payroll_Month) " &
                  "VALUES ('" & dt_payroll.Text & "', '" & dt_cutoffStart.Text & "', '" & dt_cutoffEnd.Text & "', '" & txt_TotalgrossPay.Text & "', '" & txt_TotalnetPay.Text & "', '" & txt_totalDeductions.Text & "', '" & txt_totalLoansPaid.Text & "', '" & rtb_remarks.Text & "', lower('" & xUsername & "'), '" & cmb_type.Text & "', '" & cmb_monthApplicable.Text & "')"
            ExecuteSQLQuery(sqlSTR)
    End Sub


    Private Sub Save_Exist_Payroll()
        sqlSTR = "UPDATE Payroll SET " &
                       "Payroll_Date = '" & dt_payroll.Text & "', " &
                       "Payroll_Type = '" & cmb_type.Text & "', " &
                       "Payroll_Month = '" & cmb_monthApplicable.Text & "', " &
                       "Cutoff_Date_Start = '" & dt_cutoffStart.Text & "', " &
                       "Cutoff_Date_End = '" & dt_cutoffEnd.Text & "', " &
                       "Total_GrossPay = '" & txt_TotalgrossPay.Text & "', " &
                       "Total_NetPay = '" & txt_TotalnetPay.Text & "', " &
                       "Total_Deductions = '" & txt_totalDeductions.Text & "', " &
                       "Total_LoansPaid = '" & txt_totalLoansPaid.Text & "', " &
                       "Payroll_Remarks = '" & rtb_remarks.Text & "' " &
                       "WHERE Payroll_ID =" & payroll_Id
        ExecuteSQLQuery(sqlSTR)
    End Sub

    Private Sub Save()
        If frmOperation = "edit" Then
            Save_Exist_Payroll()
        Else 'Add
            sqlSTR = "select payroll_id from payroll where payroll_id =" & payroll_Id
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count = 0 Then
                Save_New_Payroll()
            End If

        End If


        If cb_Approved.Checked Then
            If MsgBox("Would you like to approve this payroll record? Please note that once approved, it cannot be modified.", MsgBoxStyle.YesNo + MsgBoxStyle.Information, msgBox_header) = MsgBoxResult.Yes Then
                sqlSTR = "Update Payroll set Payroll_Approved='Yes', Approved_by= lower('" & xUsername & "') where Payroll_ID=" & payroll_Id
                ExecuteSQLQuery(sqlSTR)

                sqlSTR = ""
                For i = 0 To dgv_payroll.Rows.Count - 1
                    sqlSTR &= "Update Loan_Payments set Payment_Posted = 'Yes' where Payroll_Detail_ID ='" & dgv_payroll.CurrentRow.Cells("Payroll_Detail_ID").Value.ToString & "'; " & vbCrLf
                Next
                ExecuteSQLQuery(sqlSTR)

                UpdateLoanStatus()
            Else
                cb_Approved.Checked = False
                Exit Sub
            End If
            MsgBox("Succesfully APPROVED payroll record.", MsgBoxStyle.Information, msgBox_header)
        End If

    End Sub



    '//////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        center_RelativeTo(dgv_payroll, grp_Payrollpayee)

        sqlSTR = "Select " & _
                "Employee_ID, " & _
                "CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ',  LEFT(Middle_Name, 1), '.') as Employee_Name " & _
                "from employees where Employment_Status != 'Resigned' and Employment_Status != 'Terminated' " & _
                "order by Last_Name, First_Name, Middle_Name;"
        FILLComboBox(sqlSTR, cmb_employees)
        grp_Payrollpayee.Visible = True

        edit = False
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If cmb_employees.Text = "" Then Exit Sub


        employeeID = Split(cmb_employees.Text, " - ")(0)
        Dim exists As Boolean = False
        For Each row As DataGridViewRow In dgv_payroll.Rows
            If Not row.IsNewRow Then
                If row.Cells("Employee_ID").Value IsNot Nothing Then
                    If row.Cells("Employee_ID").Value.ToString() = employeeID Then
                        exists = True
                        Exit For
                    End If
                End If
            End If
        Next

        If exists Then
            MsgBox("Employee payroll record already exists.", MsgBoxStyle.Information)
            Exit Sub
        End If


        If frmOperation <> "edit" Then
            sqlSTR = "SELECT " & _
                        "CASE " & _
                        "WHEN IDENT_CURRENT('Payroll') <= IDENT_SEED('Payroll') " & _
                        "THEN IDENT_SEED('Payroll') " & _
                        "ELSE IDENT_CURRENT('Payroll') + IDENT_INCR('Payroll') " & _
                        "END AS Payroll_ID;"
            ExecuteSQLQuery(sqlSTR)
            payroll_Id = sqlDT.Rows(0)("Payroll_ID")


            Save_New_Payroll()

            Label_ID.Visible = True
            Label_ID.Text = "ID#" & payroll_Id
            Label_ID.Left = Panel1.Width - Label_ID.Width - 10

            frmOperation = "edit"
        End If


        'sqlSTR = "INSERT INTO Payroll_Details (Employee_ID, Payroll_ID) VALUES (" & Split(cmb_employees.Text, " - ")(0) & ", " & payroll_Id & ")"
        'ExecuteSQLQuery(sqlSTR)

        sqlSTR = "INSERT INTO Payroll_Details " & _
                "(Payroll_ID " & _
                ",Employee_ID " & _
                ",payRegular " & _
                ",paySpecial " & _
                ",payField " & _
                ",payHoliday " & _
                ",payOvertime " & _
                ",payNight_diff " & _
                ",numRegular " & _
                ",numSpecial " & _
                ",numField " & _
                ",numHoliday " & _
                ",numOvertime " & _
                ",numNight_diff " & _
                ",totalRegular " & _
                ",totalSpecial " & _
                ",totalField " & _
                ",totalHoliday " & _
                ",totalOvertime " & _
                ",totalNight_diff " & _
                ",totalSSS " & _
                ",totalPhilhealth " & _
                ",totalPagIbig " & _
                ",totalTax " & _
                ",totalInsurance " & _
                ",totalCharge " & _
                ",totalLate " & _
                ",totalUndertime " & _
                ",minusLate " & _
                ",minusUndertime " & _
                ",numLate " & _
                ",numUndertime " & _
                ",totalAddSpecial " & _
                ",totalAddField " & _
                ",totalAddIncentive " & _
                ",totalAddAllowance " & _
                ",grandTotal_Basic " & _
                ",grandTotal_Additional " & _
                ",grandTotal_Gross " & _
                ",grandTotal_Deduction " & _
                ",grandTotal_Loan " & _
                ",grandTotal_Net " & _
                ",payroll_employeeRemarks " & _
                ",payLeave " & _
                ",numLeave " & _
                ",totalLeave " & _
                ",totalNumAbsent " & _
                ",totalNumLate) " & _
                "SELECT " & _
                "'" & payroll_Id & "', " & _
                "Employee_ID, " & _
                "Current_Daily_Rate as payRegular, " & _
                "0 as paySpecial, " & _
                "0 as payField, " & _
                "Current_Daily_Rate as payHoliday, " & _
                "CAST(ROUND(((Current_Daily_Rate / 8) / 60), 2) AS DECIMAL(10,2)) as payOvertime, " & _
                "CAST(ROUND((((Current_Daily_Rate / 8) * 0.1) / 60), 2) AS DECIMAL(10,2)) as payNight_diff, " & _
                "0 as numRegular, " & _
                "0 as numSpecial, " & _
                "0 as numField, " & _
                "0 as numHoliday, " & _
                "0 as numOvertime, " & _
                "0 as numNight_diff, " & _
                "0 as totalRegular, " & _
                "0 as totalSpecial, " & _
                "0 as totalField, " & _
                "0 as totalHoliday, " & _
                "0 as totalOvertime, " & _
                "0 as totalNight_diff, " & _
                "0 as totalSSS, " & _
                "0 as totalPhilhealth, " & _
                "0 as totalPagIbig, " & _
                "0 as totalTax, " & _
                "0 as totalInsurance, " & _
                "0 as totalCharge, " & _
                "0 as totalLate, " & _
                "0 as totalUndertime, " & _
                "CAST(ROUND(((Current_Daily_Rate / 8) / 60), 2) AS DECIMAL(10,2)) as minusLate, " & _
                "CAST(ROUND(((Current_Daily_Rate / 8) / 60), 2) AS DECIMAL(10,2)) as minusUndertime, " & _
                "0 as numLate, " & _
                "0 as numUndertime, " & _
                "0 as totalAddSpecial, " & _
                "0 as totalAddField, " & _
                "0 as totalAddIncentive, " & _
                "0 as totalAddAllowance, " & _
                "0 as grandTotal_Basic, " & _
                "0 as grandTotal_Additional, " & _
                "0 as grandTotal_Gross, " & _
                "0 as grandTotal_Deduction, " & _
                "0 as grandTotal_Loan, " & _
                "0 as grandTotal_Net, " & _
                "'' as payroll_employeeRemarks, " & _
                "Current_Daily_Rate as payLeave, " & _
                "(SELECT " & _
                "ISNULL(SUM( " & _
                "DATEDIFF(day, " & _
                "CASE WHEN Leave_Start < '" & dt_cutoffStart.Text & "' THEN '" & dt_cutoffStart.Text & "' ELSE Leave_Start END, " & _
                "CASE WHEN Leave_End > '" & dt_cutoffEnd.Text & "' THEN '" & dt_cutoffEnd.Text & "' ELSE Leave_End END " & _
                ") + 1 " & _
                "), 0) as LeaveDaysWithinCutoff " & _
                "FROM Leaves " & _
                "WHERE " & _
                "Leave_Status = 'Approved' " & _
                "AND Leave_Category NOT IN ('Leave w/o Pay', 'Others', 'Other', 'Bereavement') " & _
                "AND Leaves.Employee_ID = Employees.Employee_ID " & _
                "AND Leave_Start <= '" & dt_cutoffEnd.Text & "' " & _
                "AND Leave_End >= '" & dt_cutoffStart.Text & "') as numLeave, " & _
                "(SELECT " & _
                "ISNULL(SUM( " & _
                "DATEDIFF(day, " & _
                "CASE WHEN Leave_Start < '" & dt_cutoffStart.Text & "' THEN '" & dt_cutoffStart.Text & "' ELSE Leave_Start END, " & _
                "CASE WHEN Leave_End > '" & dt_cutoffEnd.Text & "' THEN '" & dt_cutoffEnd.Text & "' ELSE Leave_End END " & _
                ") + 1 " & _
                "), 0) as LeaveDaysWithinCutoff " & _
                "FROM Leaves " & _
                "WHERE " & _
                "Leave_Status = 'Approved' " & _
                "AND Leave_Category NOT IN ('Leave w/o Pay', 'Others', 'Other', 'Bereavement') " & _
                "AND Leaves.Employee_ID = Employees.Employee_ID " & _
                "AND Leave_Start <= '" & dt_cutoffEnd.Text & "' " & _
                "AND Leave_End >= '" & dt_cutoffStart.Text & "') * Current_Daily_Rate as totalLeave, " & _
                "0 as totalNumAbsent, " & _
                "0 as totalNumLate " & _
                "FROM Employees " & _
                "WHERE Employees.Employee_ID = '" & employeeID & "';"
        ExecuteSQLQuery(sqlSTR)

        edit = True
        FrmPAYROLL_DATA.ShowDialog()

        Refresh_Payroll_Details()
        grp_Payrollpayee.Visible = False
    End Sub

    Private Sub btn_cancelSubmit_Click(sender As Object, e As EventArgs) Handles btn_cancelSubmit.Click
        grp_Payrollpayee.Visible = False

        Refresh_Payroll_Details()
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////////////////




    'Private Sub EditEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEmployeeToolStripMenuItem.Click
    '    If approved Then
    '        ShowForm2(FormPAYROLL_PAYEE, "view", lst_payrollRecord.FocusedItem.SubItems(1).Text, payroll_Id)
    '        grp_Payrollpayee.Visible = False
    '    Else
    '        ShowForm2(FormPAYROLL_PAYEE, "edit", lst_payrollRecord.FocusedItem.SubItems(1).Text, payroll_Id)
    '        grp_Payrollpayee.Visible = False
    '    End If

    '    RefreshPayrollDetailList()
    'End Sub

    'Private Sub lst_payrollRecord_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If approved Then
    '        ShowForm2(FormPAYROLL_PAYEE, "view", lst_payrollRecord.FocusedItem.SubItems(1).Text, payroll_Id)
    '        grp_Payrollpayee.Visible = False
    '    Else
    '        ShowForm2(FormPAYROLL_PAYEE, "edit", lst_payrollRecord.FocusedItem.SubItems(1).Text, payroll_Id)
    '        grp_Payrollpayee.Visible = False
    '    End If

    '    RefreshPayrollDetailList()
    'End Sub


    'Private Sub DeleteEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeToolStripMenuItem.Click
    '    If MsgBox("Do you want to delete this payroll detail record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, msgBox_header) = MsgBoxResult.Yes Then
    '        sqlSTR = "Delete payroll_details where Payroll_Detail_ID=" & lst_payrollRecord.FocusedItem.Text
    '        ExecuteSQLQuery(sqlSTR)

    '        MsgBox("Deleted payroll detail record.", MsgBoxStyle.Information, msgBox_header)
    '    End If
    '    RefreshPayrollDetailList()
    'End Sub

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



    Private Sub cb_Approved_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Approved.CheckedChanged

    End Sub

    Private Sub cmb_employees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_employees.SelectedIndexChanged

    End Sub



    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If approved Then
            edit = False
        Else
            edit = True
        End If



        employeeID = dgv_payroll.CurrentRow.Cells("Employee_ID").Value.ToString
        FrmPAYROLL_DATA.ShowDialog()

        Refresh_Payroll_Details()
    End Sub


    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Do you want to delete this payroll record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, msgBox_header) = MsgBoxResult.Yes Then
            sqlSTR = "Delete from Payroll_Details where Payroll_Detail_ID ='" & dgv_payroll.CurrentRow.Cells("Payroll_Detail_ID").Value.ToString & "';"
            ExecuteSQLQuery(sqlSTR)


            Refresh_Payroll_Details()
        End If
        
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrintPayslipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPayslipToolStripMenuItem.Click
        FrmPRINT_PAYSLIP.ShowDialog()
    End Sub
End Class