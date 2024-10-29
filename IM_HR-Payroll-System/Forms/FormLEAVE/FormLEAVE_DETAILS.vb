Public Class FormLEAVE_DETAILS

    Dim leave_id As Integer
    Private Sub FormLEAVE_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlSTR = "Select * from employees where Employment_Status != 'Resigned' or Employment_Status != 'Terminated' order by Last_Name, First_Name"
        FILLComboBox_Employee(sqlSTR, cmb_employees)

        If formOperation = "edit" Then
            leave_id = xID1
            sqlSTR = "select *, CONCAT(Employees.Employee_ID, ' - ', Last_Name, ', ', First_Name, ', ', Middle_Name) as EmployeeDetails from Leaves inner join Employees on Employees.Employee_ID = Leaves.Employee_ID where Leave_ID =" & leave_id
            ExecuteSQLQuery(sqlSTR)
            cmb_employees.Text = sqlDT.Rows(0)("EmployeeDetails").ToString
            dt_dateApplied.Text = sqlDT.Rows(0)("Date_Applied").ToString
            txt_Supervisor.Text = sqlDT.Rows(0)("Immediate_Supervisor").ToString
            cmb_Category.Text = sqlDT.Rows(0)("Leave_Category").ToString
            dt_leaveStart.Text = sqlDT.Rows(0)("Leave_Start").ToString
            dt_leaveEnd.Text = sqlDT.Rows(0)("Leave_End").ToString
            txt_totalDays.Text = CDbl(sqlDT.Rows(0)("Leave_TotalDays").ToString)
            txt_reason.Text = sqlDT.Rows(0)("Leave_Reason").ToString
            txt_remarks.Text = sqlDT.Rows(0)("Leave_Remarks").ToString
            cmb_status.Text = sqlDT.Rows(0)("Leave_Status").ToString

            If cmb_status.Text = "Approved" Then
                btn_Save.Enabled = False
            End If
        Else
            cmb_employees.Text = ""
            dt_dateApplied.Text = Today
            txt_Supervisor.Text = ""
            cmb_Category.Text = ""
            dt_leaveStart.Text = ""
            dt_leaveEnd.Text = ""
            txt_totalDays.Text = 1
            txt_reason.Text = ""
            txt_remarks.Text = ""
            cmb_status.Text = "Pending"

            btn_Save.Enabled = True
        End If

    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If cmb_status.Text = "Approved" Then
            If MsgBox("Would you like to approve this leave record? Please note that once approved, it cannot be modified.", MsgBoxStyle.YesNo + MsgBoxStyle.Information, msgBox_header) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If


        If formOperation = "edit" Then
            sqlSTR = "UPDATE Leaves SET " &
                      "Employee_ID = '" & Split(cmb_employees.Text, " - ")(0) & "', " &
                      "Date_Applied = '" & dt_dateApplied.Text & "', " &
                      "Immediate_Supervisor = '" & txt_Supervisor.Text & "', " &
                      "Leave_Category = '" & cmb_Category.Text & "', " &
                      "Leave_Start = '" & dt_leaveStart.Text & "', " &
                      "Leave_End = '" & dt_leaveEnd.Text & "', " &
                      "Leave_TotalDays = " & CDbl(txt_totalDays.Text) & ", " &
                      "Leave_Reason = '" & txt_reason.Text & "', " &
                      "Leave_Remarks = '" & txt_remarks.Text & "', " &
                      "Leave_Status = '" & cmb_status.Text & "' " &
                      "WHERE Leave_ID = " & leave_id
            ExecuteSQLQuery(sqlSTR)
        Else
            sqlSTR = "INSERT INTO Leaves (Employee_ID, Date_Applied, Immediate_Supervisor, Leave_Category, Leave_Start, Leave_End, Leave_TotalDays, Leave_Reason, Leave_Remarks, Leave_Status) " &
                      "VALUES ('" & Split(cmb_employees.Text, " - ")(0) & "', '" & dt_dateApplied.Text & "', '" & txt_Supervisor.Text & "', '" & cmb_Category.Text & "', '" & dt_leaveStart.Text & "', '" & dt_leaveEnd.Text & "', " & CDbl(txt_totalDays.Text) & ", '" & txt_reason.Text & "', '" & txt_remarks.Text & "', '" & cmb_status.Text & "')"
            ExecuteSQLQuery(sqlSTR)
        End If
        MsgBox("Succesfully saved Leave record.", MsgBoxStyle.Information, msgBox_header)
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub
End Class