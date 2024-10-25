Public Class FormLEAVE

    Private Sub FormLEAVE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = MDIMain.Panel2.Height - 22
        Me.Width = MDIMain.Panel2.Width

        lst_leaves.Width = Me.Width - 20
        lst_leaves.Height = Me.Height - 120

        rb_pending.Checked = True
    End Sub


    Private Sub RefreshList()
        Dim status As String = ""
        If rb_pending.Checked Then
            status = "Pending"
        ElseIf rb_Upcoming.Checked Then
            status = "Upcoming"
        ElseIf rb_Finished.Checked Then
            status = "Finished"
        ElseIf rb_Rejected.Checked Then
            status = "Rejected"
        End If


        sqlSTR = "select Leave_ID as 'ID', Employees.Employee_ID as 'Employee ID', CONCAT(Last_Name, ', ', First_Name, ' ', LEFT(middle_name,1), '.') as Employee, " & _
                    "Date_Applied as 'Date Applied', Immediate_Supervisor as Supervisor, Leave_Category as Category, Leave_Start as 'Leave Start', " & _
                    "Leave_end as 'Leave End', Leave_TotalDays as 'Total Day(s)', Leave_Reason as Reason, Leave_Remarks as Remarks " & _
                    "from Leaves " & _
                    "INNER JOIN Employees on Employees.Employee_ID = Leaves.Employee_ID " & _
                    "where Leave_Status like '%" & status & "%'"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_leaves, 0)

    End Sub

    Private Sub rb_pending_CheckedChanged(sender As Object, e As EventArgs) Handles rb_pending.CheckedChanged
        RefreshList()
    End Sub

    Private Sub rb_Upcoming_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Upcoming.CheckedChanged
        RefreshList()
    End Sub

    Private Sub rb_Finished_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Finished.CheckedChanged
        RefreshList()
    End Sub

    Private Sub rb_Rejected_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Rejected.CheckedChanged
        RefreshList()
    End Sub


    Private Sub btn_newLeave_Click(sender As Object, e As EventArgs) Handles btn_newLeave.Click
        ShowForm1(FormLEAVE_DETAILS, "add", 0)
        RefreshList()
    End Sub

    Private Sub btn_searchLeave_Click(sender As Object, e As EventArgs) Handles btn_searchLeave.Click

    End Sub

    Private Sub EditLeaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditLeaveToolStripMenuItem.Click
        ShowForm1(FormLEAVE_DETAILS, "edit", lst_leaves.FocusedItem.Text)
        RefreshList()
    End Sub

    Private Sub DeleteLeaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteLeaveToolStripMenuItem.Click

    End Sub
End Class