Public Class FrmATTENDANCE
    Public formAction, Attendance_ID, month, year, whereSQL As String
    Private Sub FrmATTENDANCE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeHelper.ApplyHighlight(Me)
        whereSQL = "AND Attendance_Date >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) " & _
                    "AND Attendance_Date <  DATEADD(MONTH, 1, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)) "




        month = Split(lbl_dateYear.Text, " ")(0)
        year = Split(lbl_dateYear.Text, " ")(1)

        Refresh_List()
    End Sub


    Private Sub Frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'CenterDateYear()

    End Sub

    Private Sub CenterDateYear()
        lbl_dateYear.Left = (Panel3.ClientSize.Width - lbl_dateYear.Width) \ 2
        lbl_dateYear.Top = (Panel3.ClientSize.Height - lbl_dateYear.Height) \ 2
    End Sub

    Public Sub Refresh_List()
        If tabControl_Attendance.SelectedTab Is Tab_Monitoring Then
            Dim firstDay As Date
            If Not Date.TryParseExact(lbl_dateYear.Text.Trim(), "MMMM yyyy", _
                    System.Globalization.CultureInfo.InvariantCulture, _
                    System.Globalization.DateTimeStyles.None, firstDay) Then
                MsgBox("Invalid month and year: " & lbl_dateYear.Text, MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim daysInMonth As Integer = Date.DaysInMonth(firstDay.Year, firstDay.Month)

            dgv_employees.EnableHeadersVisualStyles = False
            dgv_employees.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True
            dgv_employees.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For d As Integer = 1 To 31
                With dgv_employees.Columns(d + 2)
                    If d <= daysInMonth Then
                        Dim dt As Date = firstDay.AddDays(d - 1)

                        .HeaderText = dt.ToString("ddd", System.Globalization.CultureInfo.InvariantCulture) & vbCrLf & d.ToString()
                        .Width = 50
                        .Visible = True

                        If dt.DayOfWeek = DayOfWeek.Sunday Then
                            .HeaderCell.Style.BackColor = Color.LightCoral
                        Else
                            .HeaderCell.Style.BackColor = Color.White
                        End If
                    Else
                        .Visible = False
                    End If
                End With
            Next

            sqlSTR = BuildAttendanceSQL(firstDay)
            ExecuteSQLQuery(sqlSTR)
            dgv_employees.Rows.Clear()
            If sqlDT.Rows.Count > 0 Then
                For i = 0 To sqlDT.Rows.Count - 1
                    dgv_employees.Rows.Add(
                    sqlDT.Rows(i)("Employee_ID"),
                    sqlDT.Rows(i)("Employee_Name"),
                    sqlDT.Rows(i)("Employment_Status"),
                    sqlDT.Rows(i)("One"),
                    sqlDT.Rows(i)("Two"),
                    sqlDT.Rows(i)("Three"),
                    sqlDT.Rows(i)("Four"),
                    sqlDT.Rows(i)("Five"),
                    sqlDT.Rows(i)("Six"),
                    sqlDT.Rows(i)("Seven"),
                    sqlDT.Rows(i)("Eight"),
                    sqlDT.Rows(i)("Nine"),
                    sqlDT.Rows(i)("Ten"),
                    sqlDT.Rows(i)("Eleven"),
                    sqlDT.Rows(i)("Twelve"),
                    sqlDT.Rows(i)("Thirteen"),
                    sqlDT.Rows(i)("Fourteen"),
                    sqlDT.Rows(i)("Fifteen"),
                    sqlDT.Rows(i)("Sixteen"),
                    sqlDT.Rows(i)("Seventeen"),
                    sqlDT.Rows(i)("Eighteen"),
                    sqlDT.Rows(i)("Nineteen"),
                    sqlDT.Rows(i)("Twenty"),
                    sqlDT.Rows(i)("TwentyOne"),
                    sqlDT.Rows(i)("TwentyTwo"),
                    sqlDT.Rows(i)("TwentyThree"),
                    sqlDT.Rows(i)("TwentyFour"),
                    sqlDT.Rows(i)("TwentyFive"),
                    sqlDT.Rows(i)("TwentySix"),
                    sqlDT.Rows(i)("TwentySeven"),
                    sqlDT.Rows(i)("TwentyEight"),
                    sqlDT.Rows(i)("TwentyNine"),
                    sqlDT.Rows(i)("Thirty"),
                    sqlDT.Rows(i)("ThirtyOne")
                    )
                Next
            End If
        ElseIf tabControl_Attendance.SelectedTab Is Tab_Record Then
            sqlSTR = "SELECT Attendance_ID as ID " & _
                ",Attendance_Date as 'Attendance Date' " & _
                ",Remarks as 'Remarks' " & _
                ",Num_Employees as 'No. of Employees' " & _
                ",Num_OnDuty as 'On-Duty Count' " & _
                ",Num_HalfDay as 'Haly-Day Count' " & _
                ",Num_Absent as 'Absent Count' " & _
                ",Num_OnLeave as 'On-Leave Count' " & _
                ",Num_Late as 'Late Count' " & _
                ",Num_Undertime as 'Undertime Count' " & _
                ",Num_WFH as 'WFH Count' " & _
                ",Update_Date as 'Last Update' " & _
                ",Encoded_By as 'Encoded By' " & _
                "FROM Attendance " & _
                "WHERE 1=1 " & whereSQL & _
                "order by Attendance_Date;"
            FillListView(ExecuteSQLQuery(sqlSTR), lst_attendance, Main.sidebar_images, 3)
        End If









        ' fill the grid with your pivot query here
    End Sub


    Private Sub tab_Attendance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControl_Attendance.SelectedIndexChanged
        Refresh_List()
    End Sub

    Private Sub Refresh_List_Record()
        

    End Sub

    Private Function BuildAttendanceSQL(firstDay As Date) As String
        ' yyyyMMdd is unambiguous in SQL Server, whatever the language or date format setting
        Dim startDate As String = firstDay.ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture)
        Dim endDate As String = firstDay.AddMonths(1).ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture)

        Dim dayNames() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", _
                                    "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty", _
                                    "TwentyOne", "TwentyTwo", "TwentyThree", "TwentyFour", "TwentyFive", "TwentySix", "TwentySeven", "TwentyEight", "TwentyNine", "Thirty", _
                                    "ThirtyOne"}

        Dim dayColumns As String = ""
        For d As Integer = 1 To 31
            If d > 1 Then dayColumns &= ", "
            dayColumns &= "COALESCE(MAX(CASE WHEN DAY(Attendance.Attendance_Date) = " & d & " THEN " & _
                          "CASE " & _
                          "WHEN Attendance_Details.Attendance_Status IN ('On-Duty', 'OD') THEN '' + " & _
                          "CASE WHEN ISNULL(Attendance_Details.Late_Mins, 0) > 0 THEN 'L' ELSE '' END + " & _
                          "CASE WHEN ISNULL(Attendance_Details.Undertime_Mins, 0) > 0 THEN 'U' ELSE '' END " & _
                          "WHEN Attendance_Details.Attendance_Status IN ('Work From Home', 'W') THEN 'W' " & _
                          "WHEN Attendance_Details.Attendance_Status IN ('Half-Day', 'H') THEN 'H' + " & _
                          "CASE WHEN ISNULL(Attendance_Details.Late_Mins, 0) > 0 THEN 'L' ELSE '' END + " & _
                          "CASE WHEN ISNULL(Attendance_Details.Undertime_Mins, 0) > 0 THEN 'U' ELSE '' END " & _
                          "WHEN Attendance_Details.Attendance_Status IN ('Absent', 'A') THEN 'A' " & _
                          "WHEN Attendance_Details.Attendance_Status IN ('On-Leave', 'OL') THEN 'O' " & _
                          "WHEN ISNULL(Attendance_Details.Late_Mins, 0) > 0 AND ISNULL(Attendance_Details.Undertime_Mins, 0) > 0 THEN 'LU' " & _
                          "WHEN ISNULL(Attendance_Details.Late_Mins, 0) > 0 THEN 'L' " & _
                          "WHEN ISNULL(Attendance_Details.Undertime_Mins, 0) > 0 THEN 'U' " & _
                          "END END), '') AS " & dayNames(d - 1) & " "
        Next

        Return "SELECT " & _
               "Employees.Employee_ID, " & _
               "CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', LEFT(TRIM(Middle_Name), 1), '.') AS Employee_Name, " & _
               "MAX(Employment_Status) as Employment_Status, " & _
               dayColumns & _
               "FROM Employees " & _
               "LEFT JOIN Attendance_Details " & _
               "ON Attendance_Details.Employee_ID = Employees.Employee_ID " & _
               "AND Attendance_Details.Attendance_Status IN ('On-Duty', 'Work From Home', 'Half-Day', 'Absent', 'On-Leave') " & _
               "LEFT JOIN Attendance " & _
               "ON Attendance.Attendance_ID = Attendance_Details.Attendance_ID " & _
               "AND Attendance.Attendance_Date >= '" & startDate & "' " & _
               "AND Attendance.Attendance_Date < '" & endDate & "' " & _
               "WHERE Employees.Employee_ID IN (SELECT Employee_ID FROM Attendance_Details) " & _
               "GROUP BY Employees.Employee_ID, " & _
               "CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', LEFT(TRIM(Middle_Name), 1), '.') " & _
               "ORDER BY Employee_Name"
    End Function

    Private Sub lst_attendance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_attendance.SelectedIndexChanged
       
    End Sub

    Private Sub lst_attendance_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_attendance.MouseDoubleClick
        lst_attendance.Focus()
        If lst_attendance.Items.Count > 0 Then
            formAction = "edit"
            Attendance_ID = lst_attendance.FocusedItem.Text
            FrmATTENDANCE_DETAILS.ShowDialog()

        End If
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        grpFilter.Visible = False

        checkbox_CheckedValue(cb_attendanceID, " and Attendance_ID = '" & txt_attendanceID.Text & "' ")
        checkbox_CheckedValue(cb_attendanceDate, " and Attendance_Date between '" & dt_fromAttendance.Text & "' and '" & dt_toAttendance.Text & "' ")
        checkbox_CheckedValue(cb_remarks, " and Remarks like '%" & txt_remarks.Text & "%' ")

        whereSQL = cb_attendanceID.Tag & cb_attendanceDate.Tag & cb_remarks.Tag

        If whereSQL = "" Then
            Exit Sub
        End If

        Refresh_List()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        grpFilter.Visible = False
    End Sub
End Class