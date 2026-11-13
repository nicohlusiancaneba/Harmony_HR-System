Public Class FrmLEAVE_DETAILS

    Dim Leave_ID As Integer
    Dim leave_status, formAction As String
    Private Sub FrmLEAVE_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeHelper.ApplyHighlight(Me)
        sqlSTR = "select Employee_ID, CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') from Employees where Employment_Status != 'Resigned' and Employment_Status != 'Terminated' " & _
                 " order by Last_Name, First_Name"
        FILLComboBox(sqlSTR, cmb_employees)
        leave_status = "Pending"
        cmb_Category.SelectedIndex = 0
        formAction = FrmLEAVES.formAction
        If formAction = "edit" Then
            Leave_ID = FrmLEAVES.Leave_ID
            sqlSTR = "select *, CONCAT(Employees.Employee_ID, ' - ', TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') as EmployeeDetails from Leaves inner join Employees on Employees.Employee_ID = Leaves.Employee_ID where Leave_ID ='" & Leave_ID & "'"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count = 0 Then
                Exit Sub
            End If

            cmb_employees.Text = sqlDT.Rows(0)("EmployeeDetails").ToString
            dt_dateApplied.Text = sqlDT.Rows(0)("Date_Applied").ToString
            txt_Supervisor.Text = sqlDT.Rows(0)("Immediate_Supervisor").ToString
            cmb_Category.Text = sqlDT.Rows(0)("Leave_Category").ToString
            dt_leaveStart.Text = sqlDT.Rows(0)("Leave_Start").ToString
            dt_leaveEnd.Text = sqlDT.Rows(0)("Leave_End").ToString
            txt_totalDays.Text = CDbl(sqlDT.Rows(0)("Leave_TotalDays").ToString)
            txt_reason.Text = sqlDT.Rows(0)("Leave_Reason").ToString
            txt_remarks.Text = sqlDT.Rows(0)("Leave_Remarks").ToString
            leave_status = sqlDT.Rows(0)("Leave_Status").ToString

            If leave_status = "Approved" Then
                btn_Save.Enabled = False
                cb_Approved.Enabled = False
                cb_Approved.Checked = True
                grpLeave.Enabled = False
            Else
                btn_Save.Enabled = True
                cb_Approved.Enabled = True
                cb_Approved.Checked = False
                grpLeave.Enabled = True
            End If
        Else
            grpLeave.Enabled = True
            cmb_employees.Text = ""
            dt_dateApplied.Text = Today
            txt_Supervisor.Text = ""
            cmb_Category.Text = ""
            dt_leaveStart.Text = ""
            dt_leaveEnd.Text = ""
            txt_totalDays.Text = 1
            txt_reason.Text = ""
            txt_remarks.Text = ""
            leave_status = "Pending"

            btn_Save.Enabled = True
            cb_Approved.Enabled = True
            cb_Approved.Checked = False
        End If

    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If txt_Supervisor.Text = "" Or cmb_Category.Text = "" Then
            MsgBox("Some required fields are empty. Please fill them in and try again.", MsgBoxStyle.Information, msgBox_header)
            Exit Sub
        End If




        If cb_Approved.Checked Then
            If MsgBox("Would you like to approve this leave record? Please note that once approved, it cannot be modified.", MsgBoxStyle.YesNo + MsgBoxStyle.Information, msgBox_header) = MsgBoxResult.No Then
                leave_status = "Pending"
                Exit Sub
            End If

            leave_status = "Approved"
        End If


        If formAction = "edit" Then
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
                      "Leave_Status = '" & leave_status & "' " &
                      "WHERE Leave_ID = " & leave_id
            ExecuteSQLQuery(sqlSTR)
        Else
            sqlSTR = "INSERT INTO Leaves (Employee_ID, Date_Applied, Immediate_Supervisor, Leave_Category, Leave_Start, Leave_End, Leave_TotalDays, Leave_Reason, Leave_Remarks, Leave_Status) " &
                      "VALUES ('" & Split(cmb_employees.Text, " - ")(0) & "', '" & dt_dateApplied.Text & "', '" & txt_Supervisor.Text & "', '" & cmb_Category.Text & "', '" & dt_leaveStart.Text & "', '" & dt_leaveEnd.Text & "', " & CDbl(txt_totalDays.Text) & ", '" & txt_reason.Text & "', '" & txt_remarks.Text & "', '" & leave_status & "')"
            ExecuteSQLQuery(sqlSTR)
        End If
        MsgBox("Succesfully saved Leave record.", MsgBoxStyle.Information, msgBox_header)
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub



    Private Sub txt_totalDays_ValueChanged(sender As Object, e As EventArgs) Handles txt_totalDays.ValueChanged

    End Sub
End Class