Public Class FrmATTENDANCE_DATA
    Dim formLoaded As Boolean
    Dim shiftStart, lunchOut, lunchIn, shiftEnd As DateTime
    Dim minTime, maxTime, afternoon_undertime_minTime, afternoon_undertime_maxTime, morning_undertime_minTime, morning_undertime_maxTime As TimeSpan
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()

    End Sub

    Private Sub FrmATTENDANCE_DATA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeHelper.ApplyHighlight(Me)
        cmb_attendanceStatus.SelectedIndex = 0







        With FrmATTENDANCE_DETAILS.dgv_employees.CurrentRow
            txt_employeeID.Text = .Cells("Employee_ID").Value.ToString
            txt_employeeName.Text = .Cells("Employee_Name").Value.ToString
            txt_employmentStatus.Text = .Cells("Employment_Status").Value.ToString
            txt_shiftCode.Text = .Cells("Shift_Code").Value.ToString
            txt_shiftStart.Text = .Cells("Shift_TimeIn").Value.ToString
            txt_lunchOut.Text = .Cells("Lunch_TimeOut").Value.ToString
            txt_shiftEnd.Text = .Cells("Shift_TimeOut").Value.ToString
            txt_lunchIn.Text = .Cells("Lunch_TimeIn").Value.ToString

            cmb_attendanceStatus.Text = .Cells("Attendance_Status").Value.ToString




            If .Cells("Late_TimeIn").Value.ToString <> "" Then
                cb_lateTimeIn.Checked = True
                tp_lateTimeIn.Text = .Cells("Late_TimeIn").Value.ToString
            Else
                cb_lateTimeIn.Checked = False
                tp_lateTimeIn.Enabled = False

                If DateTime.TryParse(txt_shiftStart.Text.Trim(), shiftStart) Then
                    tp_lateTimeIn.Text = shiftStart.AddMinutes(1).TimeOfDay.ToString
                End If
            End If

            If .Cells("Morning_Undertime").Value.ToString <> "" Then
                cb_morningUndertime.Checked = True
                tp_morningUndertime.Text = .Cells("Morning_Undertime").Value.ToString
            Else
                cb_morningUndertime.Checked = False
                tp_morningUndertime.Enabled = False
            End If

            If .Cells("Afternoon_Undertime").Value.ToString <> "" Then
                cb_afternoonUndertime.Checked = True
                tp_afternoonUndertime.Text = .Cells("Afternoon_Undertime").Value.ToString
            Else
                cb_afternoonUndertime.Checked = False
                tp_afternoonUndertime.Enabled = False
            End If

            txt_remarks.Text = .Cells("Remarks").Value.ToString
        End With






        'afternoon_undertime_minTime = New TimeSpan(14, 1, 0)
        'afternoon_undertime_maxTime = New TimeSpan(16, 59, 0)

        'morning_undertime_minTime = New TimeSpan(10, 1, 0)
        'morning_undertime_maxTime = New TimeSpan(11, 59, 0)



        formLoaded = True
    End Sub

    Private Sub Enable_Disable_TimePicker()
        If formLoaded Then
            If cb_lateTimeIn.Checked Then
                tp_lateTimeIn.Enabled = True
            Else
                tp_lateTimeIn.Enabled = False
            End If

            If cb_morningUndertime.Checked Then
                tp_morningUndertime.Enabled = True
            Else
                tp_morningUndertime.Enabled = False
            End If


            If cb_afternoonUndertime.Checked Then
                tp_afternoonUndertime.Enabled = True
            Else
                tp_afternoonUndertime.Enabled = False
            End If
        End If
       

    End Sub

    Private Sub cb_CheckedChanged(sender As Object, e As EventArgs) Handles cb_lateTimeIn.CheckedChanged, cb_morningUndertime.CheckedChanged, cb_afternoonUndertime.CheckedChanged
        Enable_Disable_TimePicker()
    End Sub


    Private Sub cmb_attendanceStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_attendanceStatus.SelectedIndexChanged
        cb_lateTimeIn.Checked = False
        cb_morningUndertime.Checked = False
        cb_afternoonUndertime.Checked = False

        If cmb_attendanceStatus.Text = "On-Duty" Or cmb_attendanceStatus.Text = "Half-Day" Then
            cb_lateTimeIn.Enabled = True
            cb_morningUndertime.Enabled = True
            cb_afternoonUndertime.Enabled = True
        Else
            cb_lateTimeIn.Enabled = False
            cb_morningUndertime.Enabled = False
            cb_afternoonUndertime.Enabled = False
        End If
    End Sub


    Private Function holdSave() As Boolean
        If cmb_attendanceStatus.Text = "Half-Day" Then
            If cb_morningUndertime.Checked And cb_afternoonUndertime.Checked Then
                MsgBox("Both morning and afternoon undertime record is invalid for Half-Day duty.", MsgBoxStyle.Information)
                Return True
            End If
        End If


        Return False
    End Function


    Private isAdjusting As Boolean = False

    Private Sub tp_lateTimeIn_ValueChanged(sender As Object, e As EventArgs) Handles tp_lateTimeIn.ValueChanged
        If Not formLoaded OrElse isAdjusting Then Exit Sub

        If DateTime.TryParse(txt_shiftStart.Text.Trim(), shiftStart) Then
            minTime = shiftStart.AddMinutes(1).TimeOfDay
            maxTime = shiftStart.AddHours(2).TimeOfDay
        End If

        Dim msg As String = String.Empty
        Dim current As TimeSpan = tp_lateTimeIn.Value.TimeOfDay

        If current < minTime Then
            isAdjusting = True
            tp_lateTimeIn.Value = tp_lateTimeIn.Value.Date.Add(minTime)
            isAdjusting = False
            msg = "Late time set to " & minTime.ToString() & "."
        ElseIf current > maxTime Then
            isAdjusting = True
            tp_lateTimeIn.Value = tp_lateTimeIn.Value.Date.Add(maxTime)
            isAdjusting = False
            msg = "Late time cannot be later than " & maxTime.ToString() & "."
        End If

        If msg <> String.Empty Then
            MessageBox.Show(msg, "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub tp_morningUndertime_ValueChanged(sender As Object, e As EventArgs) Handles tp_morningUndertime.ValueChanged
        If Not formLoaded OrElse isAdjusting Then Exit Sub

        Dim shiftStartTime, lunchOutTime As DateTime
        Dim minTime, maxTime As TimeSpan

        If DateTime.TryParse(txt_shiftStart.Text.Trim(), shiftStartTime) AndAlso
           DateTime.TryParse(txt_lunchOut.Text.Trim(), lunchOutTime) Then
            minTime = shiftStartTime.AddHours(2).AddMinutes(1).TimeOfDay
            maxTime = lunchOutTime.AddMinutes(-1).TimeOfDay
        Else
            Exit Sub
        End If

        Dim msg As String = String.Empty
        Dim current As TimeSpan = tp_morningUndertime.Value.TimeOfDay

        If current < minTime Then
            isAdjusting = True
            tp_morningUndertime.Value = tp_morningUndertime.Value.Date.Add(minTime)
            isAdjusting = False
            msg = "Morning undertime set to " & minTime.ToString("hh\:mm") & "."
        ElseIf current > maxTime Then
            isAdjusting = True
            tp_morningUndertime.Value = tp_morningUndertime.Value.Date.Add(maxTime)
            isAdjusting = False
            msg = "Morning undertime cannot be later than " & maxTime.ToString("hh\:mm") & "."
        End If

        If msg <> String.Empty Then
            MessageBox.Show(msg, "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub tp_afternoonUndertime_ValueChanged(sender As Object, e As EventArgs) Handles tp_afternoonUndertime.ValueChanged
        If Not formLoaded OrElse isAdjusting Then Exit Sub

        Dim lunchInTime, shiftEndTime As DateTime
        Dim minTime, maxTime As TimeSpan

        If DateTime.TryParse(txt_lunchIn.Text.Trim(), lunchInTime) AndAlso
           DateTime.TryParse(txt_shiftEnd.Text.Trim(), shiftEndTime) Then
            minTime = lunchInTime.AddHours(2).AddMinutes(1).TimeOfDay
            maxTime = shiftEndTime.AddMinutes(-1).TimeOfDay
        Else
            Exit Sub
        End If

        Dim msg As String = String.Empty
        Dim current As TimeSpan = tp_afternoonUndertime.Value.TimeOfDay

        If current < minTime Then
            isAdjusting = True
            tp_afternoonUndertime.Value = tp_afternoonUndertime.Value.Date.Add(minTime)
            isAdjusting = False
            msg = "Afternoon undertime set to " & minTime.ToString("hh\:mm") & "."
        ElseIf current > maxTime Then
            isAdjusting = True
            tp_afternoonUndertime.Value = tp_afternoonUndertime.Value.Date.Add(maxTime)
            isAdjusting = False
            msg = "Afternoon undertime cannot be later than " & maxTime.ToString("hh\:mm") & "."
        End If

        If msg <> String.Empty Then
            MessageBox.Show(msg, "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If holdSave() Then Exit Sub

        With FrmATTENDANCE_DETAILS.dgv_employees.CurrentRow


            .Cells("Attendance_Status").Value = cmb_attendanceStatus.Text

            If cb_lateTimeIn.Checked Then
                .Cells("Late_TimeIn").Value = tp_lateTimeIn.Text
                .Cells("Late_Mins").Value = Math.Max(0, CInt((DateTime.Parse(tp_lateTimeIn.Text).TimeOfDay - DateTime.Parse(txt_shiftStart.Text).TimeOfDay).TotalMinutes))
            Else
                .Cells("Late_TimeIn").Value = ""
                .Cells("Late_Mins").Value = 0
            End If

            Dim undertime As Integer = 0
            If cb_morningUndertime.Checked Then
                .Cells("Morning_Undertime").Value = tp_morningUndertime.Text
                undertime = undertime + Math.Max(0, CInt((DateTime.Parse(txt_lunchOut.Text).TimeOfDay - DateTime.Parse(tp_morningUndertime.Text).TimeOfDay).TotalMinutes))
            Else
                .Cells("Morning_Undertime").Value = ""
            End If

            If cb_afternoonUndertime.Checked Then
                .Cells("Afternoon_Undertime").Value = tp_afternoonUndertime.Text
                undertime = undertime + Math.Max(0, CInt((DateTime.Parse(txt_shiftEnd.Text).TimeOfDay - DateTime.Parse(tp_afternoonUndertime.Text).TimeOfDay).TotalMinutes))
            Else
                .Cells("Afternoon_Undertime").Value = ""
            End If

            .Cells("Undertime_Mins").Value = undertime

            .Cells("Remarks").Value = txt_remarks.Text
        End With

        Me.Close()
    End Sub
End Class