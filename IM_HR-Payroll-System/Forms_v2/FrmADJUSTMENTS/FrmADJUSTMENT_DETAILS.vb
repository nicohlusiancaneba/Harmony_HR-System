Public Class FrmADJUSTMENT_DETAILS
    Dim Adjustment_ID As Integer
    Dim approved, formAction As String
    Dim formLoaded As Boolean

    Private Sub FrmADJUSTMENT_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlSTR = "select Employee_ID, CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') from Employees where Employment_Status != 'Resigned' and Employment_Status != 'Terminated' " & _
                " order by Last_Name, First_Name"
        FILLComboBox(sqlSTR, cmb_employees)

        

        formLoaded = False



        formAction = FrmADJUSTMENTS.formAction
        If formAction = "edit" Then
            Dim new_value As String = ""
            Adjustment_ID = FrmADJUSTMENTS.Adjustment_ID
            sqlSTR = "SELECT *, CONCAT(Employees.Employee_ID, ' - ', TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') as Employee " & _
                        "FROM Adjustments " & _
                        "INNER JOIN Employees on Employees.Employee_ID = Adjustments.Employee_ID " & _
                        "where Adjustment_ID =" & Adjustment_ID
            ExecuteSQLQuery(sqlSTR)

            cmb_employees.Text = sqlDT.Rows(0)("Employee").ToString
            new_value = sqlDT.Rows(0)("New_Value").ToString
            txt_Prev.Text = sqlDT.Rows(0)("Prev_Value").ToString
            approved = sqlDT.Rows(0)("Adj_Approved").ToString
            dt_dateAdj.Text = sqlDT.Rows(0)("Date_Adjusted").ToString
            cmb_adjustmentType.Text = sqlDT.Rows(0)("Adjustment_Type").ToString

            cmb_newText.Visible = False
            dt_newDate.Visible = False
            txt_newText.Visible = False
            If cmb_adjustmentType.Text = "Department" Or cmb_adjustmentType.Text = "Division" Then
                cmb_newText.Text = new_value
                cmb_newText.Visible = True
            ElseIf cmb_adjustmentType.Text = "Regularization" Or cmb_adjustmentType.Text = "Termination" Or cmb_adjustmentType.Text = "Resignation" Or cmb_adjustmentType.Text = "Rehire" Then
                dt_newDate.Text = new_value
                dt_newDate.Visible = True
            Else
                txt_newText.Text = new_value
                txt_newText.Visible = True
            End If

            If txt_Prev.Text.Length * 8 < 300 Then
                txt_Prev.Width = txt_Prev.Text.Length * 8
            Else
                txt_Prev.Width = 300
            End If

            If txt_Prev.Width <= 90 Then
                txt_Prev.Width = 90
            End If



            If approved = "Yes" Then
                grpAdjustment.Enabled = False

                cb_Approved.Checked = True
                cb_Approved.Enabled = False
                btn_Save.Enabled = False

                Label1.Visible = True
                dt_dateAdj.Visible = True

                lbl_details.Text = "Adjustment Type :" & vbCrLf & vbCrLf & "Employee :" & vbCrLf & vbCrLf & "Previous Record :" & vbCrLf & vbCrLf & "Updated Record :"
            Else
                grpAdjustment.Enabled = True

                cb_Approved.Checked = False
                cb_Approved.Enabled = True
                btn_Save.Enabled = True

                Label1.Visible = False
                dt_dateAdj.Visible = False

                lbl_details.Text = "Adjustment Type :" & vbCrLf & vbCrLf & "Employee :" & vbCrLf & vbCrLf & "Current Record :" & vbCrLf & vbCrLf & "New Record :"
            End If


        Else
            sqlSTR = "SELECT IDENT_CURRENT('Adjustments') + IDENT_INCR('Adjustments') AS Adjustment_ID"
            ExecuteSQLQuery(sqlSTR)

            Adjustment_ID = sqlDT.Rows(0)("Adjustment_ID")

            lbl_details.Text = "Adjustment Type :" & vbCrLf & vbCrLf & "Employee :" & vbCrLf & vbCrLf & "Current Record :" & vbCrLf & vbCrLf & "New Record :"
            grpAdjustment.Enabled = True
            cmb_adjustmentType.SelectedIndex = 0
            cmb_employees.SelectedIndex = 0
            txt_Prev.Text = ""
            txt_newText.Text = ""
            cmb_newText.SelectedIndex = -1
            dt_newDate.Text = Today()
            txt_remarks.Text = ""
            cb_Approved.Checked = False
            cb_Approved.Enabled = True
            btn_Save.Enabled = True

            Label1.Visible = False
            dt_dateAdj.Visible = False

            formLoaded = True
            Adjustment_Type()
            Employee_Current_Value()
        End If


        formLoaded = True
    End Sub


    Private Sub Select_Employment()

    End Sub

    Private Sub Adjustment_Type()


        cmb_newText.Visible = False
        dt_newDate.Visible = False
        txt_newText.Visible = False

        cmb_newText.Text = ""
        dt_newDate.Text = ""
        txt_newText.Text = ""

        Dim temp_employee As String

        temp_employee = cmb_employees.Text

        If cmb_adjustmentType.Text = "Department" Or cmb_adjustmentType.Text = "Division" Then
            cmb_newText.Visible = True
            If cmb_adjustmentType.Text = "Department" Then
                sqlSTR = "select Dropdown_ID, Dropdown_Description from Dropdowns where Dropdown_Type = 'Department'"
                FILLComboBox2(sqlSTR, cmb_newText)
            ElseIf cmb_adjustmentType.Text = "Division" Then
                sqlSTR = "select Dropdown_ID, Dropdown_Description from Dropdowns where Dropdown_Type = 'Division'"
                FILLComboBox2(sqlSTR, cmb_newText)
            End If

            sqlSTR = "select Employee_ID, CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') from Employees where Employment_Status != 'Resigned' and Employment_Status != 'Terminated' " & _
                " order by Last_Name, First_Name"
            FILLComboBox(sqlSTR, cmb_employees)


        ElseIf cmb_adjustmentType.Text = "Regularization" Or cmb_adjustmentType.Text = "Termination" Or cmb_adjustmentType.Text = "Resignation" Or cmb_adjustmentType.Text = "Rehire" Then

            dt_newDate.Visible = True
            If cmb_adjustmentType.Text = "Regularization" Then
                sqlSTR = "select Employee_ID, CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') from Employees where Employment_Status like '%Probationary%' " & _
                " order by Last_Name, First_Name"
                FILLComboBox(sqlSTR, cmb_employees)
            ElseIf cmb_adjustmentType.Text = "Termination" Or cmb_adjustmentType.Text = "Resignation" Then
                sqlSTR = "select Employee_ID, CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') from Employees where Employment_Status != 'Resigned' and Employment_Status != 'Terminated' " & _
                " order by Last_Name, First_Name"
                FILLComboBox(sqlSTR, cmb_employees)
            ElseIf cmb_adjustmentType.Text = "Rehire" Then
                sqlSTR = "select Employee_ID, CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') from Employees where Employment_Status = 'Resigned' or Employment_Status = 'Terminated' " & _
                " order by Last_Name, First_Name"
                FILLComboBox(sqlSTR, cmb_employees)
            End If


        Else
            txt_newText.Visible = True
            sqlSTR = "select Employee_ID, CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') from Employees where Employment_Status != 'Resigned' and Employment_Status != 'Terminated' " & _
                " order by Last_Name, First_Name"
            FILLComboBox(sqlSTR, cmb_employees)
        End If

        cmb_employees.Text = temp_employee
    End Sub


    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim new_value As String
        If cmb_adjustmentType.Text = "Department" Or cmb_adjustmentType.Text = "Division" Then
            new_value = cmb_newText.Text
        ElseIf cmb_adjustmentType.Text = "Regularization" Or cmb_adjustmentType.Text = "Termination" Or cmb_adjustmentType.Text = "Resignation" Or cmb_adjustmentType.Text = "Rehire" Then
            new_value = dt_newDate.Text
        Else
            new_value = txt_newText.Text
        End If



        If new_value = txt_Prev.Text Then
            MsgBox("Value Invalid, try again.", MsgBoxStyle.Exclamation, msgBox_header)
            Exit Sub
        End If

        If formAction = "edit" Then
            sqlSTR = "UPDATE Adjustments SET " & _
                      "Adjustment_Type = '" & cmb_adjustmentType.Text & "', " & _
                      "New_Value = '" & new_value & "', " & _
                      "Prev_Value = '" & txt_Prev.Text & "', " & _
                      "Remarks = '" & txt_remarks.Text & "', " & _
                      "Encoded_by = '" & xUsername & "' " & _
                      "WHERE Adjustment_ID = " & Adjustment_ID
            ExecuteSQLQuery(sqlSTR)
        Else
            sqlSTR = "INSERT INTO Adjustments (Employee_ID, Adjustment_Type, New_Value, Prev_Value, Encoded_by, Remarks, Adj_Approved) " & _
                                    "VALUES ('" & Split(cmb_employees.Text, " - ")(0) & "', '" & cmb_adjustmentType.Text & "', '" & new_value & "', '" & txt_Prev.Text & "', '" & xUsername & "', '" & txt_remarks.Text & "', 'No')"
            ExecuteSQLQuery(sqlSTR)
        End If



        If cb_Approved.Checked Then
            If MsgBox("Do you want to approve this adjustment record? Please note that once approved, you cannot undo this action.", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, msgBox_header) = MsgBoxResult.Yes Then
                Dim type As String = ""
                If cmb_adjustmentType.Text = "Salary" Then
                    type = "Current_Daily_Rate "
                ElseIf cmb_adjustmentType.Text = "SSS Share" Then
                    type = "SSS_Share"
                ElseIf cmb_adjustmentType.Text = "PAG-IBIG Share" Then
                    type = "Pag_ibig_Share"
                ElseIf cmb_adjustmentType.Text = "Philhealth Share" Then
                    type = "Philhealth_Share"
                ElseIf cmb_adjustmentType.Text = "Tax Amount" Then
                    type = "Tax_Amount"
                ElseIf cmb_adjustmentType.Text = "Regularization" Then
                    type = "Employment_Status = 'Regular', Regularization_Date"
                ElseIf cmb_adjustmentType.Text = "Termination" Then
                    type = "Employment_Status = 'Terminated', End_Of_EmploymentDate"
                ElseIf cmb_adjustmentType.Text = "Resignation" Then
                    type = "Employment_Status = 'Resigned', End_Of_EmploymentDate"
                ElseIf cmb_adjustmentType.Text = "Rehire" Then
                    type = "Employment_Status = 'Probationary', Hired_Date"
                ElseIf cmb_adjustmentType.Text = "Department" Then
                    type = "Department"
                ElseIf cmb_adjustmentType.Text = "Division" Then
                    type = "Division"
                ElseIf cmb_adjustmentType.Text = "Job Position" Then
                    type = "Position"
                ElseIf cmb_adjustmentType.Text = "Working Days" Then
                    type = "No_of_Work_Days_per_Month"
                ElseIf cmb_adjustmentType.Text = "Paid Leave Days" Then
                    type = "Paid_Leaves"
                ElseIf cmb_adjustmentType.Text = "Bank Account No." Then
                    type = "Payroll_Account_Number"
                ElseIf cmb_adjustmentType.Text = "SSS No." Then
                    type = "SSS_No"
                ElseIf cmb_adjustmentType.Text = "Philhealth No." Then
                    type = "Philhealth_No"
                ElseIf cmb_adjustmentType.Text = "Tax ID No. (TIN)" Then
                    type = "TIN_No"
                ElseIf cmb_adjustmentType.Text = "PAG-IBIG No." Then
                    type = "Pag_ibig_No"
                ElseIf cmb_adjustmentType.Text = "Monthly Salary (SSS)" Then
                    type = "Monthly_Salary_SSS"
                ElseIf cmb_adjustmentType.Text = "Monthly Salary (Philhealth)" Then
                    type = "Monthly_Salary_Philhealth"
                ElseIf cmb_adjustmentType.Text = "Monthly Salary (PAG-IBIG)" Then
                    type = "Monthly_Salary_PAGIBIG"
                ElseIf cmb_adjustmentType.Text = "Monthly Salary (BIR)" Then
                    type = "Monthly_Salary_BIR"
                End If

                sqlSTR = "Update Employees set " & type & " = '" & new_value & "'  where Employee_ID=" & Split(cmb_employees.Text, " - ")(0)
                ExecuteSQLQuery(sqlSTR)

                If cmb_adjustmentType.Text = "Salary" Or cmb_adjustmentType.Text = "Working Days" Then
                    sqlSTR = "Update Employees set Monthly_Salary = Current_Daily_Rate * No_of_Work_Days_per_Month " & _
                            " where Employee_ID ='" & Split(cmb_employees.Text, " - ")(0) & "'"
                    ExecuteSQLQuery(sqlSTR)
                End If

                sqlSTR = "Update Adjustments set Date_Adjusted='" & DateTime.Now.ToString("MM/dd/yyyy") & "', Adj_Approved='Yes', Approved_by='" & xUsername & "' where Adjustment_ID='" & Adjustment_ID & "';"
                ExecuteSQLQuery(sqlSTR)
                MsgBox("Succesfully APPROVED adjustment record.", MsgBoxStyle.Information, msgBox_header)
            Else
                MsgBox("Succesfully saved adjustment record.", MsgBoxStyle.Information, msgBox_header)
            End If
        Else
            MsgBox("Succesfully saved adjustment record.", MsgBoxStyle.Information, msgBox_header)
        End If


        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub cmb_adjustmentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_adjustmentType.SelectedIndexChanged
        If formLoaded Then
            Adjustment_Type()
            Employee_Current_Value()
        End If


        'If cmb_employees.Text = "" Then Exit Sub

        'If approved <> "Yes" Then
        '    sqlSTR = "select Regularization_Date, Current_Daily_Rate, SSS_Share, Philhealth_Share, Tax_Amount, Pag_ibig_Share from Employees where Employee_ID =" & Split(cmb_employees.Text, " - ")(0)
        '    ExecuteSQLQuery(sqlSTR)

        '    If cmb_adjustmentType.Text = "Salary" Then
        '        txt_Prev.Text = sqlDT.Rows(0)("Current_Daily_Rate").ToString
        '    ElseIf cmb_adjustmentType.Text = "SSS" Then
        '        txt_Prev.Text = sqlDT.Rows(0)("SSS_Share").ToString
        '    ElseIf cmb_adjustmentType.Text = "Pag-Ibig" Then
        '        txt_Prev.Text = sqlDT.Rows(0)("Pag_ibig_Share").ToString
        '    ElseIf cmb_adjustmentType.Text = "Philhealth" Then
        '        txt_Prev.Text = sqlDT.Rows(0)("Philhealth_Share").ToString
        '    ElseIf cmb_adjustmentType.Text = "Tax" Then
        '        txt_Prev.Text = sqlDT.Rows(0)("Tax_Amount").ToString
        '    End If

        '    If cmb_adjustmentType.Text = "Regularization" Then
        '        txt_Prev.Text = "n/a"
        '        txt_newText.Text = Today()
        '        txt_newText.ReadOnly = True
        '        txt_newText.Visible = False
        '        dt_newDate.Visible = True
        '    Else
        '        txt_newText.Text = ""
        '        txt_newText.ReadOnly = False
        '        txt_newText.Visible = True
        '        dt_newDate.Visible = False
        '    End If
        'End If





    End Sub

    Private Sub Employee_Current_Value()
        cmb_newText.Text = ""
        dt_newDate.Text = ""
        txt_newText.Text = ""

        If formLoaded Then
            Dim type As String = ""
            If cmb_adjustmentType.Text = "Salary" Then
                type = "Current_Daily_Rate "
            ElseIf cmb_adjustmentType.Text = "SSS Share" Then
                type = "SSS_Share"
            ElseIf cmb_adjustmentType.Text = "PAG-IBIG Share" Then
                type = "Pag_ibig_Share"
            ElseIf cmb_adjustmentType.Text = "Philhealth Share" Then
                type = "Philhealth_Share"
            ElseIf cmb_adjustmentType.Text = "Tax Amount" Then
                type = "Tax_Amount"
            ElseIf cmb_adjustmentType.Text = "Regularization" Or cmb_adjustmentType.Text = "Termination" Or cmb_adjustmentType.Text = "Resignation" Or cmb_adjustmentType.Text = "Rehire" Then
                type = "End_Of_EmploymentDate"
            ElseIf cmb_adjustmentType.Text = "Department" Then
                type = "Department"
            ElseIf cmb_adjustmentType.Text = "Division" Then
                type = "Division"
            ElseIf cmb_adjustmentType.Text = "Job Position" Then
                type = "Position"
            ElseIf cmb_adjustmentType.Text = "Working Days" Then
                type = "No_of_Work_Days_per_Month"
            ElseIf cmb_adjustmentType.Text = "Paid Leave Days" Then
                type = "Paid_Leaves"
            ElseIf cmb_adjustmentType.Text = "Bank Account No." Then
                type = "Payroll_Account_Number"
            ElseIf cmb_adjustmentType.Text = "SSS No." Then
                type = "SSS_No"
            ElseIf cmb_adjustmentType.Text = "Philhealth No." Then
                type = "Philhealth_No"
            ElseIf cmb_adjustmentType.Text = "Tax ID No. (TIN)" Then
                type = "TIN_No"
            ElseIf cmb_adjustmentType.Text = "PAG-IBIG No." Then
                type = "Pag_ibig_No"
            ElseIf cmb_adjustmentType.Text = "Monthly Salary (SSS)" Then
                type = "Monthly_Salary_SSS"
            ElseIf cmb_adjustmentType.Text = "Monthly Salary (Philhealth)" Then
                type = "Monthly_Salary_Philhealth"
            ElseIf cmb_adjustmentType.Text = "Monthly Salary (PAG-IBIG)" Then
                type = "Monthly_Salary_PAGIBIG"
            ElseIf cmb_adjustmentType.Text = "Monthly Salary (BIR)" Then
                type = "Monthly_Salary_BIR"
            End If

            sqlSTR = "Select " & type & " as current_value from Employees where Employee_ID ='" & Split(cmb_employees.Text, " - ")(0) & "';"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                txt_Prev.Text = sqlDT.Rows(0)("current_value").ToString
                'If txt_Prev.Text.Length * 8 <= 90 Then
                '    txt_Prev.Width = 90
                'End If

                If txt_Prev.Text.Length * 8 < 300 Then
                    txt_Prev.Width = txt_Prev.Text.Length * 8

                Else
                    txt_Prev.Width = 300
                End If

                If txt_Prev.Width <= 90 Then
                    txt_Prev.Width = 90
                End If

            Else
                txt_Prev.Text = ""
            End If

        End If
    End Sub



    Private Sub cmb_employees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_employees.SelectedIndexChanged
        If formLoaded Then
            Employee_Current_Value()
        End If


        'If formLoaded Then
        '    sqlSTR = "select Employee_ID from Employees where Employment_Status != 'Regular' and Employee_ID=" & Split(cmb_employees.Text, " - ")(0)
        '    ExecuteSQLQuery(sqlSTR)
        '    cmb_adjustmentType.Items.Clear()
        '    If sqlDT.Rows.Count > 0 Then
        '        cmb_adjustmentType.Items.Add("Regularization")
        '        cmb_adjustmentType.Items.Add("Salary")
        '        cmb_adjustmentType.Items.Add("SSS")
        '        cmb_adjustmentType.Items.Add("Pag-Ibig")
        '        cmb_adjustmentType.Items.Add("Philhealth")
        '        cmb_adjustmentType.Items.Add("Tax")
        '    Else
        '        cmb_adjustmentType.Items.Add("Salary")
        '        cmb_adjustmentType.Items.Add("SSS")
        '        cmb_adjustmentType.Items.Add("Pag-Ibig")
        '        cmb_adjustmentType.Items.Add("Philhealth")
        '        cmb_adjustmentType.Items.Add("Tax")
        '    End If
        'End If


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Function GetAutoDropDownWidth(cbo As ComboBox, Optional maxWidth As Integer = 300) As Integer
        Dim widestWidth As Integer = cbo.Width

        For Each item As Object In cbo.Items
            Dim itemWidth As Integer = TextRenderer.MeasureText(item.ToString(), cbo.Font).Width
            If itemWidth > widestWidth Then
                widestWidth = itemWidth
            End If
        Next

        ' Add buffer for scrollbar/padding
        widestWidth += SystemInformation.VerticalScrollBarWidth + 10

        ' Cap at max size
        If widestWidth > maxWidth Then
            widestWidth = maxWidth
        End If

        Return widestWidth
    End Function



End Class

