Public Class FrmSHIFT_DETAILS
    Dim formAction, Shift_ID, Shift_Status, temp_shift_code, working_days As String
    Public edit As Boolean = False
    Private Sub FrmSHIFT_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inputText_ChangedHandler(Me)
        inputNum_ChangedHandler(Me)
        ClearGroupBoxInputs(grpDetails)

        cmb_flexible.SelectedIndex = 0
        cmb_nightDiff.SelectedIndex = 0
        cmb_overnight.SelectedIndex = 0
        num_gracePeriod.Text = 0
        num_workingDays.Text = 0
        num_requiredHours.Text = 1
        dgv_employees.Rows.Clear()
        ResetWorkingDays()



        temp_shift_code = ""
        Shift_Status = "Pending"
        formAction = FrmSHIFTS.formAction

        If formAction = "edit" Then

            Shift_ID = FrmSHIFTS.Shift_ID

            Label_ID.Text = "ID#" & Shift_ID
            Label_ID.Left = Panel1.Width - Label_ID.Width - 10

            sqlSTR = "SELECT * from Shifts " & _
                    "where Shift_ID = '" & Shift_ID & "';"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count = 1 Then
                temp_shift_code = sqlDT.Rows(0)("Shift_Code").ToString()
                txt_shiftCode.Text = temp_shift_code
                txt_shiftParticulars.Text = sqlDT.Rows(0)("Shift_Name").ToString()
                tp_shiftStart.Text = sqlDT.Rows(0)("Start_Time").ToString()
                tp_shiftEnd.Text = sqlDT.Rows(0)("End_Time").ToString()
                tp_lunchOut.Text = sqlDT.Rows(0)("Lunch_BreakOut").ToString()
                tp_lunchIn.Text = sqlDT.Rows(0)("Lunch_BreakIn").ToString()
                tp_minTimeIn.Text = sqlDT.Rows(0)("Min_TimeIn").ToString()
                tp_overtimeStart.Text = sqlDT.Rows(0)("Overtime_Start").ToString()
                num_gracePeriod.Text = sqlDT.Rows(0)("GracePeriod_Min").ToString()
                num_workingDays.Text = sqlDT.Rows(0)("No_Days_Weekly").ToString()
                num_requiredHours.Text = sqlDT.Rows(0)("Required_Hours").ToString()
                cmb_overnight.Text = sqlDT.Rows(0)("Is_Overnight").ToString()
                cmb_flexible.Text = sqlDT.Rows(0)("Is_Flexible").ToString()
                cmb_nightDiff.Text = sqlDT.Rows(0)("Has_NightDiff").ToString()
                working_days = sqlDT.Rows(0)("Working_Days").ToString()
                LoadWorkingDays(working_days)
                lbl_createdBy.Text = "Created By : " & sqlDT.Rows(0)("Created_By").ToString()
                Shift_Status = sqlDT.Rows(0)("Shift_Status").ToString()

                If Shift_Status = "Approved" Then
                    cb_Approved.Checked = True
                Else
                    cb_Approved.Checked = False
                End If

                sqlSTR = "SELECT Shift_Detail_ID " & _
                        ",Shifts_Details.Employee_ID " & _
                        ",CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') as Employee_Name " & _
                        ",Position " & _
                        ",Department " & _
                        ",Assignment_Type " & _
                        ",Remarks " & _
                        "FROM Shifts_Details " & _
                        "inner join Employees on Employees.Employee_ID = Shifts_Details.Employee_ID " & _
                        "where Shift_ID = '" & Shift_ID & "';"
                ExecuteSQLQuery(sqlSTR)

                dgv_employees.Rows.Clear()
                If sqlDT.Rows.Count > 0 Then
                    For i = 0 To sqlDT.Rows.Count - 1
                        dgv_employees.Rows.Add(
                        sqlDT.Rows(i)("Employee_ID"),
                        sqlDT.Rows(i)("Employee_Name"),
                        sqlDT.Rows(i)("Position"),
                        sqlDT.Rows(i)("Department"),
                        sqlDT.Rows(i)("Assignment_Type"),
                        sqlDT.Rows(i)("Remarks")
                        )
                    Next
                End If


            Else
                Me.Close()
            End If

        Else
            lbl_createdBy.Text = "Created By : " & xUsername
            cb_Approved.Checked = False
        End If


        If Shift_Status = "Approved" Then
            grpDetails.Enabled = False

            btn_add.Enabled = False
            btn_edit.Enabled = False
            btn_delete.Enabled = False

            cb_Approved.Enabled = False
            btn_Save.Enabled = False
        Else
            grpDetails.Enabled = True

            btn_add.Enabled = True
            btn_edit.Enabled = True
            btn_delete.Enabled = True

            cb_Approved.Enabled = True
            btn_Save.Enabled = True
        End If


    End Sub


    Private Sub Save()
        Dim approve_date As String

        If cb_Approved.Checked Then
            Shift_Status = "Approved"
            approve_date = "'" & DateTime.Now & "'"
        Else
            Shift_Status = "Pending"
            approve_date = "null"
        End If

        working_days = String.Join(", ", clb_workingDays.CheckedItems.Cast(Of String)())


        If formAction = "edit" Then
            sqlSTR = "UPDATE Shifts SET " & _
         "Shift_Code = '" & txt_shiftCode.Text & "', " & _
         "Shift_Name = '" & txt_shiftParticulars.Text & "', " & _
         "Start_Time = '" & tp_shiftStart.Text & "', " & _
         "Working_Days = '" & working_days & "', " & _
         "End_Time = '" & tp_shiftEnd.Text & "', " & _
         "Lunch_BreakOut = '" & tp_lunchOut.Text & "', " & _
         "Lunch_BreakIn = '" & tp_lunchIn.Text & "', " & _
         "GracePeriod_Min = '" & num_gracePeriod.Text & "', " & _
         "Min_TimeIn = '" & tp_minTimeIn.Text & "', " & _
         "Overtime_Start = '" & tp_overtimeStart.Text & "', " & _
         "Has_NightDiff = '" & cmb_nightDiff.Text & "', " & _
         "Is_Overnight = '" & cmb_overnight.Text & "', " & _
         "Is_Flexible = '" & cmb_flexible.Text & "', " & _
         "Required_Hours = '" & num_requiredHours.Text & "', " & _
         "No_Days_Weekly = '" & num_workingDays.Text & "', " & _
         "Employee_Count = '" & dgv_employees.Rows.Count & "', " & _
         "Shift_Status = '" & Shift_Status & "', " & _
         "Updated_By = '" & xUsername & "', " & _
         "Shift_Approved = " & approve_date & " " & _
         "WHERE Shift_ID = " & Shift_ID & ";"
            ExecuteSQLQuery(sqlSTR)

            sqlSTR = "Delete from Shifts_Details where Shift_ID = '" & Shift_ID & "'; "
            ExecuteSQLQuery(sqlSTR)

        Else
            sqlSTR = "SELECT " & _
                    "CASE " & _
                    "WHEN IDENT_CURRENT('Shifts') <= IDENT_SEED('Shifts') " & _
                    "THEN IDENT_SEED('Shifts') " & _
                    "ELSE IDENT_CURRENT('Shifts') + IDENT_INCR('Shifts') " & _
                    "END AS Shift_ID;"
            ExecuteSQLQuery(sqlSTR)

            Shift_ID = sqlDT.Rows(0)("Shift_ID")

            sqlSTR = "INSERT INTO Shifts " & _
                        "(Shift_Code " & _
                        ",Shift_Name " & _
                        ",Start_Time " & _
                        ",End_Time " & _
                        ",Working_Days " & _
                        ",Lunch_BreakOut " & _
                        ",Lunch_BreakIn " & _
                        ",GracePeriod_Min " & _
                        ",Min_TimeIn " & _
                        ",Overtime_Start " & _
                        ",Has_NightDiff " & _
                        ",Is_Overnight " & _
                        ",Is_Flexible " & _
                        ",Required_Hours " & _
                        ",No_Days_Weekly " & _
                        ",Employee_Count " & _
                        ",Shift_Status " & _
                        ",Created_By " & _
                        ",Updated_By " & _
                        ",Shift_Created " & _
                        ",Shift_Approved) " & _
                        "VALUES " & _
                        "( " & _
                        "'" & txt_shiftCode.Text & "', " & _
                        "'" & txt_shiftParticulars.Text & "', " & _
                        "'" & tp_shiftStart.Text & "', " & _
                        "'" & tp_shiftEnd.Text & "', " & _
                        "'" & working_days & "', " & _
                        "'" & tp_lunchOut.Text & "', " & _
                        "'" & tp_lunchIn.Text & "', " & _
                        "'" & num_gracePeriod.Text & "', " & _
                        "'" & tp_minTimeIn.Text & "', " & _
                        "'" & tp_overtimeStart.Text & "', " & _
                        "'" & cmb_nightDiff.Text & "', " & _
                        "'" & cmb_overnight.Text & "', " & _
                        "'" & cmb_flexible.Text & "', " & _
                        "'" & num_requiredHours.Text & "', " & _
                        "'" & num_workingDays.Text & "', " & _
                        "'" & dgv_employees.Rows.Count & "', " & _
                        "'" & Shift_Status & "', " & _
                        "'" & xUsername & "', " & _
                        "'" & xUsername & "', " & _
                        "GETDATE(), " & _
                        "" & approve_date & " " & _
                        ");"
            ExecuteSQLQuery(sqlSTR)

        End If

        sqlSTR = ""
        If dgv_employees.Rows.Count > 0 Then
            For i = 0 To dgv_employees.Rows.Count - 1
                With dgv_employees.Rows(i)
                    sqlSTR &= "INSERT INTO Shifts_Details " & _
                            "(Shift_ID " & _
                            ",Employee_ID " & _
                            ",Assignment_Type " & _
                            ",Remarks) " & _
                            "VALUES " & _
                            "( " & _
                            "'" & Shift_ID & "', " & _
                            "'" & .Cells("Employee_ID").Value.ToString() & "', " & _
                            "'" & .Cells("Assignment_Type").Value.ToString() & "', " & _
                            "'" & .Cells("Remarks").Value.ToString() & "' " & _
                            "); " & vbCrLf
                End With
            Next
            ExecuteSQLQuery(sqlSTR)
        End If
    End Sub

    Private Function HoldSave() As Boolean
        If txt_shiftCode.Text = "" Then
            MsgBox("Shift Code cannot be blank.", MsgBoxStyle.Information)
            Return True
        End If

        If txt_shiftParticulars.Text = "" Then
            MsgBox("Shift Particulars cannot be blank.", MsgBoxStyle.Information)
            Return True
        End If

        If txt_shiftCode.Text <> temp_shift_code Then
            sqlSTR = "select Shift_Code from Shifts where Shift_Code = '" & txt_shiftCode.Text & "' group by Shift_Code;"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                MsgBox("Shift Code already exists, enter a different one.", MsgBoxStyle.Information)
                Return True
            End If
        End If

        If clb_workingDays.CheckedItems.Count = 0 Then
            MsgBox("Please select at least one working day.", MsgBoxStyle.Exclamation)
            Return True
        End If

        Return False
    End Function

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If HoldSave() Then Exit Sub

        Save()

        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        center_RelativeTo(dgv_employees, grpEmployees)

        sqlSTR = "Select " & _
                "Employee_ID, " & _
                "CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ',  LEFT(Middle_Name, 1), '.') as Employee_Name " & _
                "from employees where Employment_Status != 'Resigned' and Employment_Status != 'Terminated' and Employee_ID not in (select distinct Employee_ID from Shifts_Details) " & _
                "order by Last_Name, First_Name, Middle_Name;"
        FILLComboBox(sqlSTR, cmb_employees)
        cmb_employees.Enabled = True
        cmb_assignmentType.SelectedIndex = 0
        txt_remarks.Text = ""
        grpEmployees.Visible = True

        edit = False
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If dgv_employees.Rows.Count = 0 Then Exit Sub

        center_RelativeTo(dgv_employees, grpEmployees)

        sqlSTR = "Select " & _
                "Employee_ID, " & _
                "CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ',  LEFT(Middle_Name, 1), '.') as Employee_Name " & _
                "from employees where Employee_ID = '" & dgv_employees.CurrentRow.Cells("Employee_ID").Value.ToString & "' " & _
                "order by Last_Name, First_Name, Middle_Name;"
        FILLComboBox(sqlSTR, cmb_employees)


        cmb_employees.Text = dgv_employees.CurrentRow.Cells("Employee_ID").Value.ToString & " - " & dgv_employees.CurrentRow.Cells("Employee_Name").Value.ToString
        cmb_assignmentType.Text = dgv_employees.CurrentRow.Cells("Assignment_Type").Value.ToString
        txt_remarks.Text = dgv_employees.CurrentRow.Cells("Remarks").Value.ToString

        cmb_employees.Enabled = False
        grpEmployees.Visible = True
        edit = True
    End Sub

    Private Sub dgv_employees_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv_employees.MouseDoubleClick
        If btn_edit.Enabled = True Then
            btn_edit_Click(sender, e)
        End If
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If cmb_employees.Text = "" Then
            MsgBox("No selected Employee.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Not edit Then
            Dim temp_employee_ID As String
            temp_employee_ID = Split(cmb_employees.Text, " - ")(0)
            Dim exists As Boolean = False
            For Each row As DataGridViewRow In dgv_employees.Rows
                If Not row.IsNewRow Then
                    If row.Cells("Employee_ID").Value IsNot Nothing Then
                        If row.Cells("Employee_ID").Value.ToString() = temp_employee_ID Then
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
        End If
        


        If cmb_assignmentType.Text = "" Then
            MsgBox("Assignment Type cannot be blank.", MsgBoxStyle.Information)
            Exit Sub
        End If


        If edit Then
            dgv_employees.CurrentRow.Cells("Assignment_Type").Value = cmb_assignmentType.Text
            dgv_employees.CurrentRow.Cells("Remarks").Value = txt_remarks.Text
        Else
            sqlSTR = "select Position, Department from Employees where Employee_ID ='" & Split(cmb_employees.Text, " - ")(0) & "';"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count = 1 Then
                dgv_employees.Rows.Add(
                            Split(cmb_employees.Text, " - ")(0),
                            Split(cmb_employees.Text, " - ")(1),
                            sqlDT.Rows(0)("Position"),
                            sqlDT.Rows(0)("Department"),
                            cmb_assignmentType.Text,
                            txt_remarks.Text
                            )
            End If
        End If

        grpEmployees.Visible = False
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        grpEmployees.Visible = False

        dgv_employees.Focus()
        If dgv_employees.Rows.Count > 0 Then
            If dgv_employees.CurrentRow IsNot Nothing AndAlso Not dgv_employees.CurrentRow.IsNewRow Then
                dgv_employees.Rows.Remove(dgv_employees.CurrentRow)
            End If
        End If


    End Sub

    Private Sub btn_cancelSubmit_Click(sender As Object, e As EventArgs) Handles btn_cancelSubmit.Click
        grpEmployees.Visible = False
    End Sub

    Private Sub grpDetails_Enter(sender As Object, e As EventArgs) Handles grpDetails.Enter

    End Sub

    'Private Sub dt_late_ValueChanged(sender As Object, e As EventArgs) Handles dt_late.ValueChanged
    '    Dim maxTime As TimeSpan = New TimeSpan(10, 0, 0) ' 10:00 AM

    '    If dt_late.Value.TimeOfDay > maxTime Then
    '        dt_late.Value = dt_late.Value.Date.Add(maxTime)
    '        MessageBox.Show("Late time cannot be later than 10:00 AM.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End If
    'End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


    Private Sub clb_workingDays_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clb_workingDays.ItemCheck
        Dim checkedCount As Integer = 0

        For i As Integer = 0 To clb_workingDays.Items.Count - 1
            If i = e.Index Then
                ' the item being changed: use its NEW state
                If e.NewValue = CheckState.Checked Then checkedCount += 1
            Else
                ' every other item: use its current state
                If clb_workingDays.GetItemChecked(i) Then checkedCount += 1
            End If
        Next

        num_workingDays.Text = checkedCount.ToString()
    End Sub

    Private Sub ResetWorkingDays()
        For i As Integer = 0 To clb_workingDays.Items.Count - 1
            clb_workingDays.SetItemChecked(i, False)
        Next

        clb_workingDays.ClearSelected()   ' also removes the highlighted row
    End Sub


    Private Sub LoadWorkingDays(working_days As String)
        ' uncheck everything first
        For i As Integer = 0 To clb_workingDays.Items.Count - 1
            clb_workingDays.SetItemChecked(i, False)
        Next

        If String.IsNullOrWhiteSpace(working_days) Then Exit Sub

        For Each day As String In working_days.Split(","c)
            Dim idx As Integer = clb_workingDays.Items.IndexOf(day.Trim())
            If idx >= 0 Then clb_workingDays.SetItemChecked(idx, True)
        Next
    End Sub
End Class