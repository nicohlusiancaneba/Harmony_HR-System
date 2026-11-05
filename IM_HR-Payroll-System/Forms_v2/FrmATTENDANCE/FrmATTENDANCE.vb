Public Class FrmATTENDANCE
    Public formAction, Attendance_ID, month, year As String
    Private Sub FrmATTENDANCE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh_List()

        month = Split(lbl_dateYear.Text, " ")(0)
        year = Split(lbl_dateYear.Text, " ")(1)
    End Sub

    Public Sub Refresh_List()
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
            With dgv_employees.Columns(d + 1)
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
                sqlDT.Rows(i)("Employee_Name"),
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

        ' fill the grid with your pivot query here
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
                          "CASE Attendance_Details.Attendance_Status " & _
                          "WHEN 'Work From Home' THEN 'W' WHEN 'W' THEN 'W' " & _
                          "WHEN 'Half-Day' THEN 'H' WHEN 'H' THEN 'H' " & _
                          "WHEN 'Absent' THEN 'A' WHEN 'A' THEN 'A' " & _
                          "WHEN 'On-Leave' THEN 'L' WHEN 'L' THEN 'L' END END), '') AS " & dayNames(d - 1) & " "
        Next

        Return "SELECT " & _
               "Employees.Employee_ID, " & _
               "CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', LEFT(TRIM(Middle_Name), 1), '.') AS Employee_Name, " & _
               dayColumns & _
               "FROM Employees " & _
               "LEFT JOIN Attendance_Details " & _
               "ON Attendance_Details.Employee_ID = Employees.Employee_ID " & _
               "AND Attendance_Details.Attendance_Status IN ('Work From Home', 'W', 'Half-Day', 'H', 'Absent', 'A', 'On-Leave', 'L') " & _
               "LEFT JOIN Attendance " & _
               "ON Attendance.Attendance_ID = Attendance_Details.Attendance_ID " & _
               "AND Attendance.Attendance_Date >= '" & startDate & "' " & _
               "AND Attendance.Attendance_Date < '" & endDate & "' " & _
               "WHERE Employees.Employee_ID IN (SELECT Employee_ID FROM Attendance_Details) " & _
               "GROUP BY Employees.Employee_ID, " & _
               "CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', LEFT(TRIM(Middle_Name), 1), '.') " & _
               "ORDER BY Employee_Name"
    End Function
End Class