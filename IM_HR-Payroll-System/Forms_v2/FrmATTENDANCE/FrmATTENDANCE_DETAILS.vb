Public Class FrmATTENDANCE_DETAILS

    Dim formAction, Attendance_ID, temp_date As String
    Dim formLoaded As Boolean = False
    Private Sub FrmATTENDANCE_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeHelper.ApplyHighlight(Me)
        dgv_employees.Rows.Clear()

        Attendance_ID = FrmATTENDANCE.Attendance_ID

        'dt_attendanceDate.Text = "11/05/2026"

        formAction = FrmATTENDANCE.formAction

        If formAction = "edit" Then
            Attendance_ID = FrmATTENDANCE.Attendance_ID

            sqlSTR = "select * from Attendance where Attendance_ID ='" & Attendance_ID & "';"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                temp_date = sqlDT.Rows(0)("Attendance_Date").ToString()
                dt_attendanceDate.Text = temp_date
                txt_numEmployees.Text = sqlDT.Rows(0)("Num_Employees").ToString()
                txt_numOnDuty.Text = sqlDT.Rows(0)("Num_OnDuty").ToString()
                txt_numHalfDay.Text = sqlDT.Rows(0)("Num_HalfDay").ToString()
                txt_numAbsent.Text = sqlDT.Rows(0)("Num_Absent").ToString()
                txt_numOnLeave.Text = sqlDT.Rows(0)("Num_OnLeave").ToString()
                txt_numLate.Text = sqlDT.Rows(0)("Num_Late").ToString()
                txt_numUndertime.Text = sqlDT.Rows(0)("Num_Undertime").ToString()
                txt_numWFH.Text = sqlDT.Rows(0)("Num_WFH").ToString()
                txt_remarks.Text = sqlDT.Rows(0)("Remarks").ToString()
                lbl_encodedBy.Text = "Encoded by : " & sqlDT.Rows(0)("Encoded_By").ToString()
            Else
                Me.Close()
            End If

            sqlSTR = "select " & _
                    "Attendance_Details.Employee_ID " & _
                    ",CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') as Employee_Name " & _
                    ",Employee_Status " & _
                    ",Shift_Code " & _
                    ",Attendance_Status " & _
                    ",Late_Mins " & _
                    ",Undertime_Mins " & _
                    ",Shift_Time " & _
                    ",Shift_TimeIn " & _
                    ",Shift_TimeOut " & _
                    ",Lunch_TimeOut " & _
                    ",Lunch_TimeIn " & _
                    ",CONVERT(VARCHAR(8), Late_TimeIn, 108) AS Late_TimeIn " & _
                    ",CONVERT(VARCHAR(8), AM_Undertime, 108) AS AM_Undertime " & _
                    ",CONVERT(VARCHAR(8), PM_Undertime, 108) AS PM_Undertime" & _
                    ",Remarks " & _
                    ",Updated_By " & _
                    "from Attendance_Details " & _
                    "inner join Employees on Employees.Employee_ID = Attendance_Details.Employee_ID " & _
                    "where Attendance_ID = '" & Attendance_ID & "' " & _
                    "order by Employee_Name;"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                For i = 0 To sqlDT.Rows.Count - 1
                    dgv_employees.Rows.Add(
                    sqlDT.Rows(i)("Employee_ID"),
                    sqlDT.Rows(i)("Employee_Name"),
                    sqlDT.Rows(i)("Employee_Status"),
                    sqlDT.Rows(i)("Shift_Code"),
                    sqlDT.Rows(i)("Attendance_Status"),
                    sqlDT.Rows(i)("Late_Mins"),
                    sqlDT.Rows(i)("Undertime_Mins"),
                    sqlDT.Rows(i)("Shift_Time"),
                    sqlDT.Rows(i)("Shift_TimeIn"),
                    sqlDT.Rows(i)("Shift_TimeOut"),
                    sqlDT.Rows(i)("Lunch_TimeOut"),
                    sqlDT.Rows(i)("Lunch_TimeIn"),
                    sqlDT.Rows(i)("Late_TimeIn"),
                    sqlDT.Rows(i)("AM_Undertime"),
                    sqlDT.Rows(i)("PM_Undertime"),
                    sqlDT.Rows(i)("Remarks"),
                    sqlDT.Rows(i)("Updated_By")
                    )
                Next
            End If


        Else 'ADD
            temp_date = dt_attendanceDate.Text

            sqlSTR = "select Attendance_ID from Attendance " & _
                    "where Attendance_Date = '" & dt_attendanceDate.Text & "';"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                MsgBox("An existing attendance record was found. Access that record (ID#" & sqlDT.Rows(0)("Attendance_ID") & " instead.")
                Me.Close()
            End If


            sqlSTR = "select " & _
                    "Employees.Employee_ID, " & _
                    "CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') as Employee_Name, " & _
                    "Employment_Status, " & _
                    "Shift_Code, " & _
                    "CONCAT(Start_Time, ' to ', End_Time) as Shift_Time, " & _
                    "CASE " & _
                    "WHEN EXISTS (SELECT 1 " & _
                    "FROM Leaves " & _
                    "WHERE '" & dt_attendanceDate.Text & "' BETWEEN Leave_Start AND Leave_End " & _
                    "AND Leave_Status = 'Approved' " & _
                    "AND Leaves.Employee_ID = Employees.Employee_ID) " & _
                    "THEN 'On-Leave' " & _
                    "ELSE 'On-Duty' " & _
                    "END AS Attendance_Status, " & _
                    "Start_Time as Shift_TimeIn, " & _
                    "End_Time as Shift_TimeOut, " & _
                    "Lunch_BreakOut, " & _
                    "Lunch_BreakIn " & _
                    "from Employees " & _
                    "inner join Shifts_Details on Shifts_Details.Employee_ID = Employees.Employee_ID " & _
                    "inner join Shifts on Shifts.Shift_ID = Shifts_Details.Shift_ID " & _
                    "WHERE Shifts.Working_Days LIKE '%' + DATENAME(WEEKDAY, GETDATE()) + '%' " & _
                    "order by Employee_Name;"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                dgv_employees.Rows.Clear()

                For i = 0 To sqlDT.Rows.Count - 1
                    dgv_employees.Rows.Add(
                    sqlDT.Rows(i)("Employee_ID"),
                    sqlDT.Rows(i)("Employee_Name"),
                    sqlDT.Rows(i)("Employment_Status"),
                    sqlDT.Rows(i)("Shift_Code"),
                    sqlDT.Rows(i)("Attendance_Status"),
                    "0",
                    "0",
                    sqlDT.Rows(i)("Shift_Time"),
                    sqlDT.Rows(i)("Shift_TimeIn"),
                    sqlDT.Rows(i)("Shift_TimeOut"),
                    sqlDT.Rows(i)("Lunch_BreakOut"),
                    sqlDT.Rows(i)("Lunch_BreakIn"),
                    "",
                    "",
                    "",
                    "",
                    xUsername
                    )
                Next
            Else
                MsgBox("No employees with an assigned shift were found for the selected date.", MsgBoxStyle.Information)
                Me.Close()
            End If

            lbl_encodedBy.Text = "Encoded by : " & xUsername

        End If


        Count_Employees()
        formLoaded = True
    End Sub




    Private Sub Count_Employees()
        Dim num_employees, num_onDuty, num_WFH, num_halfday, num_absent, num_onleave, num_late, num_undertime As Integer

        For Each row As DataGridViewRow In dgv_employees.Rows
            If row.IsNewRow Then Continue For

            num_employees += 1

            ' Attendance status
            Dim status As String = ""
            If row.Cells("Attendance_Status").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("Attendance_Status").Value) Then
                status = row.Cells("Attendance_Status").Value.ToString().Trim()
            End If

            Select Case status.ToUpper()
                Case "ON-DUTY"
                    num_onDuty += 1
                Case "WORK FROM HOME"
                    num_WFH += 1
                Case "HALF-DAY"
                    num_halfday += 1
                    num_onDuty += 1
                Case "ABSENT"
                    num_absent += 1
                Case "ON-LEAVE"
                    num_onleave += 1
            End Select

            ' Late (count if not blank)
            If row.Cells("Late_Mins").Value.ToString().Trim() <> "0" Then
                num_late += 1
            End If

            ' Undertime (count if not blank)
            If row.Cells("Undertime_Mins").Value.ToString().Trim() <> "0" Then
                num_undertime += 1
            End If
        Next

        txt_numEmployees.Text = num_employees
        txt_numOnDuty.Text = num_onDuty
        txt_numWFH.Text = num_WFH
        txt_numHalfDay.Text = num_halfday
        txt_numAbsent.Text = num_absent
        txt_numOnLeave.Text = num_onleave
        txt_numLate.Text = num_late
        txt_numUndertime.Text = num_undertime



    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If dgv_employees.Rows.Count = 0 Then Exit Sub

        FrmATTENDANCE_DATA.ShowDialog()
        Count_Employees()
    End Sub

    Private Sub dgv_employees_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv_employees.MouseDoubleClick
        btn_update_Click(sender, e)
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If dgv_employees.Rows.Count = 0 Then
            MsgBox("No Employee Attendance Record found.", MsgBoxStyle.Information)
            Exit Sub
        End If


        If formAction = "edit" Then
            sqlSTR = "UPDATE Attendance SET " & _
         "Attendance_Date = '" & dt_attendanceDate.Text & "', " & _
         "Update_Date = GETDATE(), " & _
         "Num_Employees = '" & txt_numEmployees.Text & "', " & _
         "Num_OnDuty = '" & txt_numOnDuty.Text & "', " & _
         "Num_HalfDay = '" & txt_numHalfDay.Text & "', " & _
         "Num_Absent = '" & txt_numAbsent.Text & "', " & _
         "Num_OnLeave = '" & txt_numOnLeave.Text & "', " & _
         "Num_Late = '" & txt_numLate.Text & "', " & _
         "Num_Undertime = '" & txt_numUndertime.Text & "', " & _
         "Num_WFH = '" & txt_numWFH.Text & "', " & _
         "Remarks = '" & txt_remarks.Text & "' " & _
         "WHERE Attendance_ID = " & Attendance_ID & ";"
            ExecuteSQLQuery(sqlSTR)

            sqlSTR = "Delete from Attendance_Details where Attendance_ID = '" & Attendance_ID & "'; "
            ExecuteSQLQuery(sqlSTR)

        Else
            sqlSTR = "SELECT " & _
                    "CASE " & _
                    "WHEN IDENT_CURRENT('Attendance') <= IDENT_SEED('Attendance') " & _
                    "THEN IDENT_SEED('Attendance') " & _
                    "ELSE IDENT_CURRENT('Attendance') + IDENT_INCR('Attendance') " & _
                    "END AS Attendance_ID;"
            ExecuteSQLQuery(sqlSTR)

            Attendance_ID = sqlDT.Rows(0)("Attendance_ID")

            sqlSTR = "INSERT INTO Attendance " & _
                    "(Attendance_Date " & _
                    ",Update_Date " & _
                    ",Num_Employees " & _
                    ",Num_OnDuty " & _
                    ",Num_HalfDay " & _
                    ",Num_Absent " & _
                    ",Num_OnLeave " & _
                    ",Num_Late " & _
                    ",Num_Undertime " & _
                    ",Num_WFH " & _
                    ",Remarks " & _
                    ",Encoded_By) " & _
                    "VALUES " & _
                    "( " & _
                    "'" & dt_attendanceDate.Text & "', " & _
                    "GETDATE(), " & _
                    "'" & txt_numEmployees.Text & "', " & _
                    "'" & txt_numOnDuty.Text & "', " & _
                    "'" & txt_numHalfDay.Text & "', " & _
                    "'" & txt_numAbsent.Text & "', " & _
                    "'" & txt_numOnLeave.Text & "', " & _
                    "'" & txt_numLate.Text & "', " & _
                    "'" & txt_numUndertime.Text & "', " & _
                    "'" & txt_numWFH.Text & "', " & _
                    "'" & txt_remarks.Text & "', " & _
                    "'" & xUsername & "' " & _
                    ");"
            ExecuteSQLQuery(sqlSTR)

        End If

       If dgv_employees.Rows.Count > 0 Then
            sqlSTR = ""

            Dim late_timeIn, AM_Undertime, PM_Undertime As String

            For i = 0 To dgv_employees.Rows.Count - 1
                With dgv_employees.Rows(i)

                    If Convert.ToString(.Cells("Late_TimeIn").Value) <> "" Then
                        late_timeIn = "'" & Convert.ToString(.Cells("Late_TimeIn").Value).Replace("'", "''") & "'"
                    Else
                        late_timeIn = "null"
                    End If

                    If Convert.ToString(.Cells("Morning_Undertime").Value) <> "" Then
                        AM_Undertime = "'" & Convert.ToString(.Cells("Morning_Undertime").Value).Replace("'", "''") & "'"
                    Else
                        AM_Undertime = "null"
                    End If

                    If Convert.ToString(.Cells("Afternoon_Undertime").Value) <> "" Then
                        PM_Undertime = "'" & Convert.ToString(.Cells("Afternoon_Undertime").Value).Replace("'", "''") & "'"
                    Else
                        PM_Undertime = "null"
                    End If

                    sqlSTR &= "INSERT INTO Attendance_Details " & _
                            "(Attendance_ID " & _
                            ",Employee_ID " & _
                            ",Employee_Status " & _
                            ",Shift_Code " & _
                            ",Attendance_Status " & _
                            ",Late_Mins " & _
                            ",Undertime_Mins " & _
                            ",Shift_Time " & _
                            ",Shift_TimeIn " & _
                            ",Shift_TimeOut " & _
                            ",Lunch_TimeOut " & _
                            ",Lunch_TimeIn " & _
                            ",Late_TimeIn " & _
                            ",AM_Undertime " & _
                            ",PM_Undertime " & _
                            ",Remarks " & _
                            ",Updated_By) " & _
                            "VALUES " & _
                            "( " & _
                            "'" & Attendance_ID & "', " & _
                            "'" & Convert.ToString(.Cells("Employee_ID").Value) & "', " & _
                            "'" & Convert.ToString(.Cells("Employment_Status").Value) & "', " & _
                            "'" & Convert.ToString(.Cells("Shift_Code").Value) & "', " & _
                            "'" & Convert.ToString(.Cells("Attendance_Status").Value) & "', " & _
                            "'" & Convert.ToString(.Cells("Late_Mins").Value) & "', " & _
                            "'" & Convert.ToString(.Cells("Undertime_Mins").Value) & "', " & _
                            "'" & Convert.ToString(.Cells("Shift_Time").Value) & "', " & _
                            "'" & Convert.ToString(.Cells("Shift_TimeIn").Value) & "', " & _
                            "'" & Convert.ToString(.Cells("Shift_TimeOut").Value) & "', " & _
                            "'" & Convert.ToString(.Cells("Lunch_TimeOut").Value) & "', " & _
                            "'" & Convert.ToString(.Cells("Lunch_TimeIn").Value) & "', " & _
                            late_timeIn & ", " & _
                            AM_Undertime & ", " & _
                            PM_Undertime & ", " & _
                            "'" & Convert.ToString(.Cells("Remarks").Value).Replace("'", "''") & "', " & _
                            "'" & Convert.ToString(.Cells("Updated_By").Value) & "'); " & vbCrLf

                End With
            Next

            ExecuteSQLQuery(sqlSTR)
        End If

        Me.Close()
    End Sub


    Private Sub btn_absent_Click(sender As Object, e As EventArgs) Handles btn_absent.Click
        dgv_employees.CurrentRow.Cells("Attendance_Status").Value = "Absent"
        Count_Employees()
    End Sub

    Private Sub btn_halfDay_Click(sender As Object, e As EventArgs) Handles btn_halfDay.Click
        dgv_employees.CurrentRow.Cells("Attendance_Status").Value = "Half-Day"
        Count_Employees()
    End Sub

    Private Sub dt_attendanceDate_ValueChanged(sender As Object, e As EventArgs) Handles dt_attendanceDate.ValueChanged
        If formLoaded Then
            If formAction = "edit" Then
                sqlSTR = "select Attendance_ID from Attendance " & _
                        "where Attendance_Date = '" & dt_attendanceDate.Text & "' and Attendance_ID != '" & Attendance_ID & "';"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    MsgBox("An existing attendance record was found. Access that record (ID#" & sqlDT.Rows(0)("Attendance_ID") & " instead.")
                    dt_attendanceDate.Text = temp_date
                    Exit Sub
                End If

            Else
                sqlSTR = "select Attendance_ID from Attendance " & _
                    "where Attendance_Date = '" & dt_attendanceDate.Text & "';"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    MsgBox("An existing attendance record was found. Access that record (ID#" & sqlDT.Rows(0)("Attendance_ID") & " instead.")
                    dt_attendanceDate.Text = temp_date
                    Exit Sub
                End If


            End If


                If dgv_employees.Rows.Count > 0 Then
                    For i = 0 To dgv_employees.Rows.Count - 1
                        With dgv_employees.Rows(i)
                            sqlSTR = "SELECT CASE " & _
                            "WHEN EXISTS (SELECT 1 " & _
                            "FROM Leaves " & _
                            "WHERE '" & dt_attendanceDate.Text & "' BETWEEN Leave_Start AND Leave_End " & _
                            "AND Leave_Status = 'Approved' " & _
                            "AND Leaves.Employee_ID = '" & .Cells("Employee_ID").Value.ToString() & "') " & _
                            "THEN 'On-Leave' " & _
                            "ELSE 'On-Duty' " & _
                            "END AS Attendance_Status;"
                            ExecuteSQLQuery(sqlSTR)

                            .Cells("Attendance_Status").Value = sqlDT.Rows(0)("Attendance_Status")
                        End With

                    Next

                End If
            End If



    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        center_RelativeTo(dgv_employees, grpEmployees)

        Dim temp_employee_id As String = String.Join(", ", _
        dgv_employees.Rows.Cast(Of DataGridViewRow)() _
        .Where(Function(r) Not r.IsNewRow) _
        .Select(Function(r) Convert.ToString(r.Cells("Employee_ID").Value)))

        If temp_employee_id = "" Then temp_employee_id = "0"

        sqlSTR = "select " & _
                "Employee_ID, " & _
                "CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ',  LEFT(Middle_Name, 1), '.') as Employee_Name " & _
                "from Employees " & _
                "where Employee_ID not in " & _
                "(select Employee_ID from Attendance_Details " & _
                "inner join Attendance on Attendance.Attendance_ID = Attendance_Details.Attendance_ID " & _
                "where Attendance_Date = '" & dt_attendanceDate.Text & "') " & _
                "and Employee_ID in (select Employee_ID from Shifts_Details) " & _
                "and Employee_ID not in (" & temp_employee_id & ") " & _
                "order by Last_Name, First_Name, Middle_Name;"
        FILLComboBox(sqlSTR, cmb_employees)
        cmb_employees.Enabled = True
        grpEmployees.Visible = True

    End Sub

    Private Sub btn_cancelSubmit_Click(sender As Object, e As EventArgs) Handles btn_cancelSubmit.Click
        grpEmployees.Visible = False
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        grpEmployees.Visible = False

        If cmb_employees.Text = "" Then Exit Sub

        sqlSTR = "select " & _
                    "Employees.Employee_ID, " & _
                    "CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') as Employee_Name, " & _
                    "Employment_Status, " & _
                    "Shift_Code, " & _
                    "CONCAT(Start_Time, ' to ', End_Time) as Shift_Time, " & _
                    "CASE " & _
                    "WHEN EXISTS (SELECT 1 " & _
                    "FROM Leaves " & _
                    "WHERE '" & dt_attendanceDate.Text & "' BETWEEN Leave_Start AND Leave_End " & _
                    "AND Leave_Status = 'Approved' " & _
                    "AND Leaves.Employee_ID = Employees.Employee_ID) " & _
                    "THEN 'On-Leave' " & _
                    "ELSE 'On-Duty' " & _
                    "END AS Attendance_Status, " & _
                    "Start_Time as Shift_TimeIn, " & _
                    "End_Time as Shift_TimeOut, " & _
                    "Lunch_BreakOut, " & _
                    "Lunch_BreakIn " & _
                    "from Employees " & _
                    "inner join Shifts_Details on Shifts_Details.Employee_ID = Employees.Employee_ID " & _
                    "inner join Shifts on Shifts.Shift_ID = Shifts_Details.Shift_ID " & _
                    "WHERE Employees.Employee_ID = '" & Split(cmb_employees.Text, " - ")(0) & "' " & _
                    "order by Employee_Name;"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count = 1 Then
           
            dgv_employees.Rows.Add(
            sqlDT.Rows(0)("Employee_ID"),
            sqlDT.Rows(0)("Employee_Name"),
            sqlDT.Rows(0)("Employment_Status"),
            sqlDT.Rows(0)("Shift_Code"),
            sqlDT.Rows(0)("Attendance_Status"),
            "0",
            "0",
            sqlDT.Rows(0)("Shift_Time"),
            sqlDT.Rows(0)("Shift_TimeIn"),
            sqlDT.Rows(0)("Shift_TimeOut"),
            sqlDT.Rows(0)("Lunch_BreakOut"),
            sqlDT.Rows(0)("Lunch_BreakIn"),
            "",
            "",
            "",
            "",
            xUsername
            )
              
        Else
            MsgBox("Unable to add the selected employee to the attendance record.", MsgBoxStyle.Information)
        End If
    End Sub

End Class