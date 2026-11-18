Module ModActiveForm

    Public Sub FormAdd(ByVal frmStr As String)
        Select UCase(frmStr)
            Case UCase("FrmEMPLOYEES")
                With FrmEMPLOYEES
                    .formAction = "add"
                    FrmEMPLOYEE_DETAILS.ShowDialog()
                    .Refresh_List()
                End With

            Case UCase("FrmPAYROLL")
                With FrmPAYROLL
                    .formAction = "add"
                    FrmPAYROLL_DETAILS.ShowDialog()
                    .RefreshPayrollList()
                End With

            Case UCase("FrmLOANS")
                With FrmLOANS
                    FrmLOAN_NEW.ShowDialog()
                    .Refresh_List()
                End With

            Case UCase("FrmADJUSTMENTS")
                With FrmADJUSTMENTS
                    .formAction = "add"
                    FrmADJUSTMENT_DETAILS.ShowDialog()
                    .Refresh_List()
                End With

            Case UCase("FrmLEAVES")
                With FrmLEAVES
                    .formAction = "add"
                    FrmLEAVE_DETAILS.ShowDialog()
                    .Refresh_List()
                End With

            Case UCase("FrmINCIDENTS")
                With FrmINCIDENTS
                    .formAction = "add"
                    FrmINCIDENT_DETAILS.ShowDialog()
                    .Refresh_List()
                End With

            Case UCase("FrmREPORTS")
                With FrmREPORTS
                    .dt_from.Value = New DateTime(Today.Year, Today.Month, 1).AddMonths(-1)
                    .dt_to.Value = New DateTime(Today.Year, Today.Month, 1).AddDays(-1)


                    center_RelativeTo(.dgv_reports, .grpFilter)
                    .grpFilter.Visible = True
                End With

            Case UCase("FrmSHIFTS")
                With FrmSHIFTS
                    .formAction = "add"
                    FrmSHIFT_DETAILS.ShowDialog()
                    .Refresh_List()
                End With

            Case UCase("FrmATTENDANCE")
                With FrmATTENDANCE
                    If .tabControl_Attendance.SelectedTab Is .Tab_Monitoring Then
                        ' Attendance tab
                    ElseIf .tabControl_Attendance.SelectedTab Is .Tab_Record Then
                        .formAction = "add"
                        FrmATTENDANCE_DETAILS.ShowDialog()
                    End If
                    .Refresh_List()
                End With

            Case UCase("FrmEVALUATION")
                With FrmEVALUATION
                    .formAction = "add"
                    FrmEVALUATION_DETAILS.ShowDialog()
                    .Refresh_List()
                End With

        End Select

        

        '    Case UCase("FrmSuppliersList")
        '        With FrmSuppliersList
        '            .formAction = "add"
        '            FrmSUPPLIER_DETAILS.ShowDialog()
        '            .RefreshList()
        '        End With
    End Sub


    Public Sub FormEdit(ByVal frmStr As String)
        Select Case UCase(frmStr)
            Case UCase("FrmEMPLOYEES")
                With FrmEMPLOYEES
                    .lst_employees.Focus()
                    If .lst_employees.Items.Count > 0 Then
                        .formAction = "edit"
                        FrmEMPLOYEE_DETAILS.ShowDialog()
                        .Refresh_List()
                    End If
                End With

            Case UCase("FrmPAYROLL")
                With FrmPAYROLL
                    .lst_payroll.Focus()
                    If .lst_payroll.Items.Count > 0 Then
                        .formAction = "edit"
                        FrmPAYROLL.ShowDialog()
                        .RefreshPayrollList()
                    End If
                End With

            Case UCase("FrmLOANS")
                With FrmLOANS
                    .lst_loans.Focus()
                    If .lst_loans.Items.Count > 0 Then
                        .Loan_ID = .lst_loans.FocusedItem.Text
                        FrmLOAN_EDIT.ShowDialog()
                        .Refresh_List()
                    End If
                End With

            Case UCase("FrmADJUSTMENTS")
                With FrmADJUSTMENTS
                    .lst_adjustments.Focus()
                    If .lst_adjustments.Items.Count > 0 Then
                        .formAction = "edit"
                        .Adjustment_ID = .lst_adjustments.FocusedItem.Text
                        FrmADJUSTMENT_DETAILS.ShowDialog()
                        .Refresh_List()
                    End If
                End With

            Case UCase("FrmLEAVES")
                With FrmLEAVES
                    .lst_leaves.Focus()
                    If .lst_leaves.Items.Count > 0 Then
                        .formAction = "edit"
                        .Leave_ID = .lst_leaves.FocusedItem.Text
                        FrmLEAVE_DETAILS.ShowDialog()
                        .Refresh_List()
                    End If
                End With

            Case UCase("FrmINCIDENTS")
                With FrmINCIDENTS
                    .lst_incidents.Focus()
                    If .lst_incidents.Items.Count > 0 Then
                        .formAction = "edit"
                        .Incident_ID = .lst_incidents.FocusedItem.Text
                        FrmINCIDENT_DETAILS.ShowDialog()
                        .Refresh_List()
                    End If
                End With

            Case UCase("FrmSHIFTS")
                With FrmSHIFTS
                    .lst_shifts.Focus()
                    If .lst_shifts.Items.Count > 0 Then
                        .formAction = "edit"
                        .Shift_ID = .lst_shifts.FocusedItem.Text
                        FrmSHIFT_DETAILS.ShowDialog()
                        .Refresh_List()
                    End If
                End With

            Case UCase("FrmATTENDANCE")
                With FrmATTENDANCE
                    If .tabControl_Attendance.SelectedTab Is .Tab_Monitoring Then

                    ElseIf .tabControl_Attendance.SelectedTab Is .Tab_Record Then
                        .lst_attendance.Focus()
                        If .lst_attendance.Items.Count > 0 Then
                            .formAction = "edit"
                            .Attendance_ID = .lst_attendance.FocusedItem.Text
                            FrmATTENDANCE_DETAILS.ShowDialog()

                        End If
                    End If
                    .Refresh_List()
                End With

            Case UCase("FrmEVALUATION")
                With FrmEVALUATION
                    .lst_evaluations.Focus()
                    If .lst_evaluations.Items.Count > 0 Then
                        .formAction = "edit"
                        .Evaluation_ID = .lst_evaluations.FocusedItem.Text
                        FrmEVALUATION_DETAILS.ShowDialog()
                        .Refresh_List()
                    End If
                End With

        End Select


        
        'Case UCase("FrmPHYSICAL_COUNT")
        'With FrmPHYSICAL_COUNT
        '    .lstphysical.Focus()
        '    If .lstphysical.Items.Count > 0 Then
        '        .formAction = "edit"
        '        .P_ID = .lstphysical.FocusedItem.Text
        '        FrmPHYSICAL_COUNT_DETAILS.ShowDialog()
        '        .Refresh_List()
        '    End If
        'End With
    End Sub

    Public Sub FormDelete(ByVal frmStr As String)
        Select Case UCase(frmStr)
            Case UCase("FrmEMPLOYEES")
                With FrmEMPLOYEES
                    .lst_employees.Focus()
                    sqlSTR = "DECLARE @EmployeeID INT = '" & .lst_employees.FocusedItem.SubItems(0).Text & "'; " & _
                        "SELECT " & _
                        "CASE WHEN EXISTS ( " & _
                        "SELECT 1 FROM Adjustments WHERE Employee_ID = @EmployeeID " & _
                        "UNION ALL " & _
                        "SELECT 1 FROM Evaluation WHERE Employee_ID = @EmployeeID " & _
                        "UNION ALL " & _
                        "SELECT 1 FROM Leaves WHERE Employee_ID = @EmployeeID " & _
                        "UNION ALL " & _
                        "SELECT 1 FROM Loans WHERE Employee_ID = @EmployeeID " & _
                        "UNION ALL " & _
                        "SELECT 1 FROM Payroll_Details WHERE Employee_ID = @EmployeeID " & _
                        ") THEN 'Yes' ELSE 'No' END as ExistsInAnyTable"
                    ExecuteSQLQuery(sqlSTR)

                    If sqlDT.Rows(0)("ExistsInAnyTable").ToString = "Yes" Then
                        MsgBox("You cannot delete an employee record with existing transactions.", MsgBoxStyle.Information)
                        Exit Sub
                    End If

                    If MsgBox("Do you want to delete this employee record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, msgBox_header) = MsgBoxResult.Yes Then
                        sqlSTR = "Delete from Employees where Employee_ID ='" & .lst_employees.FocusedItem.SubItems(0).Text & "'; " & vbCrLf & _
                        "Delete from File_Docs where Employee_ID ='" & .lst_employees.FocusedItem.SubItems(0).Text & "'; "
                        ExecuteSQLQuery(sqlSTR)
                        .Refresh_List()
                    End If

                End With
                
            Case UCase("FrmPAYROLL")
                With FrmPAYROLL
                    .lst_payroll.Focus()

                    If .lst_payroll.FocusedItem.SubItems(12).Text = "Yes" Then
                        MsgBox("You cannot delete an APPROVED payroll record.", MsgBoxStyle.Information)
                        Exit Sub
                    End If

                    If MsgBox("Do you want to delete this payroll record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, msgBox_header) = MsgBoxResult.Yes Then
                        sqlSTR = "Delete from Payroll where Payroll_ID ='" & .lst_payroll.FocusedItem.SubItems(0).Text & "'; " & vbCrLf & _
                        " Delete from Payroll_Details where Payroll_ID ='" & .lst_payroll.FocusedItem.SubItems(0).Text & "'; "
                        ExecuteSQLQuery(sqlSTR)
                        .RefreshPayrollList()
                    End If
                End With

            Case UCase("FrmADJUSTMENTS")
                With FrmADJUSTMENTS
                    .lst_adjustments.Focus()

                    If .lst_adjustments.FocusedItem.SubItems(8).Text = "Yes" Then
                        MsgBox("You cannot delete an APPROVED adjustment record.", MsgBoxStyle.Information)
                        Exit Sub
                    End If

                    If MsgBox("Do you want to delete this adjustment record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, msgBox_header) = MsgBoxResult.Yes Then
                        sqlSTR = "Delete from Adjustments where Adjustment_ID ='" & .lst_adjustments.FocusedItem.SubItems(0).Text & "'; "
                        ExecuteSQLQuery(sqlSTR)
                        .Refresh_List()
                    End If
                End With

            Case UCase("FrmLEAVES")
                With FrmLEAVES
                    .lst_leaves.Focus()

                    If .lst_leaves.FocusedItem.SubItems(11).Text = "Approved" Then
                        MsgBox("You cannot delete an APPROVED leave record.", MsgBoxStyle.Information)
                        Exit Sub
                    End If

                    If MsgBox("Do you want to delete this adjustment record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, msgBox_header) = MsgBoxResult.Yes Then
                        sqlSTR = "Delete from Leaves where Leave_ID ='" & .lst_leaves.FocusedItem.SubItems(0).Text & "'; "
                        ExecuteSQLQuery(sqlSTR)
                        .Refresh_List()
                    End If
                End With

            Case UCase("FrmSHIFTS")
                With FrmSHIFTS
                    .lst_shifts.Focus()

                    If .lst_shifts.FocusedItem.SubItems(10).Text = "Approved" Then
                        MsgBox("You cannot delete an APPROVED shift record.", MsgBoxStyle.Information)
                        Exit Sub
                    End If

                    If MsgBox("Do you want to delete this shift record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, msgBox_header) = MsgBoxResult.Yes Then
                        sqlSTR = "Delete from Shifts where Shift_ID ='" & .lst_shifts.FocusedItem.SubItems(0).Text & "'; " & vbCrLf & _
                        " Delete from Shifts_Details where Shift_ID ='" & .lst_shifts.FocusedItem.SubItems(0).Text & "'; "
                        ExecuteSQLQuery(sqlSTR)
                        .Refresh_List()
                    End If
                End With

            Case UCase("FrmATTENDANCE")
                With FrmATTENDANCE
                    If .tabControl_Attendance.SelectedTab Is .Tab_Monitoring Then

                    ElseIf .tabControl_Attendance.SelectedTab Is .Tab_Record Then
                        .lst_attendance.Focus()
                        If MsgBox("Do you want to delete this attendance record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, msgBox_header) = MsgBoxResult.Yes Then
                            sqlSTR = "Delete from Attendance where Attendance_ID ='" & .lst_attendance.FocusedItem.SubItems(0).Text & "'; " & vbCrLf & _
                            " Delete from Attendance_Details where Attendance_ID ='" & .lst_attendance.FocusedItem.SubItems(0).Text & "'; "
                            ExecuteSQLQuery(sqlSTR)

                        End If
                    End If
                    .Refresh_List()
                End With

            Case UCase("FrmEVALUATION")
                With FrmEVALUATION
                    .lst_evaluations.Focus()

                    If .lst_evaluations.FocusedItem.SubItems(6).Text = "Yes" Then
                        MsgBox("You cannot delete an VALIDATED evaluation record.", MsgBoxStyle.Information)
                        Exit Sub
                    End If

                    If MsgBox("Do you want to delete this evaluation record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, msgBox_header) = MsgBoxResult.Yes Then
                        sqlSTR = "Delete from Evaluation where Employee_ID ='" & .lst_evaluations.FocusedItem.SubItems(0).Text & "'; "
                        ExecuteSQLQuery(sqlSTR)
                        .Refresh_List()
                    End If
                End With
        End Select
        'Case UCase("FrmPHYSICAL_COUNT")
        'With FrmPHYSICAL_COUNT
        '    .lstphysical.Focus()
        '    If .lstphysical.Items.Count > 0 Then
        '        If .lstphysical.FocusedItem.SubItems(9).Text = "Yes" Then
        '            MsgBox("You cannot delete an APPROVED Physical Count record.")
        '            Exit Sub
        '        Else
        '            If MsgBox("Do you really want to delete this Physical Count record? This cannot be undone.", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
        '                sqlSTR = "DELETE FROM TBL_Physical_Count WHERE P_ID ='" & .lstphysical.FocusedItem.Text & "';"
        '                ExecuteSQLQuery(sqlSTR)

        '                sqlSTR = "DELETE FROM TBL_Physical_Count_Details WHERE P_ID ='" & .lstphysical.FocusedItem.Text & "';"
        '                ExecuteSQLQuery(sqlSTR)

        '                .Refresh_List()
        '            End If
        '        End If
        '    End If
        'End With
    End Sub

    Public Sub FormSearch(ByVal frmStr As String)
        Select Case UCase(frmStr)
            Case UCase("FrmEMPLOYEES")
                With FrmEMPLOYEES
                    center_RelativeTo(.lst_employees, .grpFilter)
                    .grpFilter.Visible = True
                End With

            Case UCase("FrmPAYROLL")
                With FrmPAYROLL
                    center_RelativeTo(.lst_payroll, .grpFilter)
                    .grpFilter.Visible = True
                End With

            Case UCase("FrmLOANS")
                With FrmLOANS
                    center_RelativeTo(.lst_loans, .grpFilter)
                    .grpFilter.Visible = True
                End With

            Case UCase("FrmADJUSTMENTS")
                With FrmADJUSTMENTS
                    center_RelativeTo(.lst_adjustments, .grpFilter)
                    .grpFilter.Visible = True
                End With

            Case UCase("FrmLEAVES")
                With FrmLEAVES
                    center_RelativeTo(.lst_leaves, .grpFilter)
                    .grpFilter.Visible = True
                End With

            Case UCase("FrmINCIDENTS")
                With FrmINCIDENTS
                    center_RelativeTo(.lst_incidents, .grpFilter)
                    .grpFilter.Visible = True
                End With

            Case UCase("FrmSHIFTS")
                With FrmSHIFTS
                    center_RelativeTo(.lst_shifts, .grpFilter)
                    .grpFilter.Visible = True
                End With

            Case UCase("FrmATTENDANCE")
                With FrmATTENDANCE
                    If .tabControl_Attendance.SelectedTab Is .Tab_Monitoring Then

                    ElseIf .tabControl_Attendance.SelectedTab Is .Tab_Record Then
                        center_RelativeTo(.lst_attendance, .grpFilter)
                        .grpFilter.Visible = True
                    End If
                End With

            Case UCase("FrmEVALUATION")
                With FrmEVALUATION
                    center_RelativeTo(.lst_evaluations, .grpFilter)
                    .grpFilter.Visible = True
                End With

        End Select
        'Case UCase("FrmPHYSICAL_COUNT")
        'With FrmPHYSICAL_COUNT
        '    center_RelativeTo(.lstphysical, .grpFilter)
        '    .grpFilter.Visible = True
        'End With
    End Sub

    Public Sub RefreshList(ByVal frmStr As String)
        Select Case UCase(frmStr)
            Case UCase("FrmEMPLOYEES")
                With FrmEMPLOYEES
                    .whereSQL = " and Employment_Status != 'Terminated' and Employment_Status != 'Resigned' "
                    .grpFilter.Visible = False
                    .Refresh_List()
                End With

            Case UCase("FrmPAYROLL")
                With FrmPAYROLL
                    .whereSQL = " and Cutoff_Date_Start >= DATEADD(DAY, -6, EOMONTH(GETDATE(), -1)) and Cutoff_Date_End <= EOMONTH(GETDATE()) "
                    .grpFilter.Visible = False
                    .RefreshPayrollList()
                End With

            Case UCase("FrmLOANS")
                With FrmLOANS
                    .whereSQL = " and Loan_Status = 'Active' "
                    .grpFilter.Visible = False
                    .Refresh_List()
                End With

            Case UCase("FrmADJUSTMENTS")
                With FrmADJUSTMENTS
                    .whereSQL = " and ((Year(Date_Adjusted) = Year(GETDATE()) and Month(Date_Adjusted) = Month(GETDATE())) or Adj_Approved = 'No') "
                    .grpFilter.Visible = False
                    .Refresh_List()
                End With

            Case UCase("FrmLEAVES")
                With FrmLEAVES
                    .whereSQL = " and (Leave_Status = 'Pending' or Leave_Start >= DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0) AND Leave_End   <  DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()) + 1, 0)) "
                    .grpFilter.Visible = False
                    .Refresh_List()
                End With

            Case UCase("FrmREPORTS")
                With FrmREPORTS
                    .Refresh_List()
                End With

            Case UCase("FrmSHIFTS")
                With FrmSHIFTS
                    .Refresh_List()
                End With

            Case UCase("FrmATTENDANCE")
                With FrmATTENDANCE
                    .whereSQL = "AND Attendance_Date >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) " & _
                    "AND Attendance_Date <  DATEADD(MONTH, 1, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)) "
                    .Refresh_List()
                End With

            Case UCase("FrmEVALUATION")
                With FrmEVALUATION
                    .whereSQL = " AND Evaluation_Date >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) " & _
                    "AND Evaluation_Date < DATEADD(MONTH, 1, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)) "
                    .Refresh_List()
                End With


        End Select


        'Case UCase("FrmPHYSICAL_COUNT")
        'With FrmPHYSICAL_COUNT
        '    .whereSQL = " and (CAST(P_Date AS DATE) = CAST(GETDATE() AS DATE) or COALESCE(P_Approved, 'No') = 'No') "
        '    .Refresh_List()
        'End With
    End Sub

End Module
