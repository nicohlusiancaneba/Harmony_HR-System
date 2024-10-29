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
            status = "where Leave_Status = 'Pending'"
        ElseIf rb_Upcoming.Checked Then
            status = "where Leave_Status = 'Approved' and (Leave_Start >= GETDATE() and Leave_End <= GETDATE())"
        ElseIf rb_Finished.Checked Then
            status = "where Leave_Status = 'Approved' and Leave_End < GETDATE()"
        ElseIf rb_Rejected.Checked Then
            status = "where Leave_Status = 'Rejected'"
        End If


        sqlSTR = "select Leave_ID as 'ID', Employees.Employee_ID as 'Employee ID', CONCAT(Last_Name, ', ', First_Name, ' ', LEFT(middle_name,1), '.') as Employee, " & _
                    "Date_Applied as 'Date Applied', Immediate_Supervisor as Supervisor, Leave_Category as Category, Leave_Start as 'Leave Start', " & _
                    "Leave_end as 'Leave End', Leave_TotalDays as 'Total Day(s)', Leave_Reason as Reason, Leave_Remarks as Remarks, Leave_Status as Status " & _
                    "from Leaves " & _
                    "INNER JOIN Employees on Employees.Employee_ID = Leaves.Employee_ID " & status

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

    Private Sub lst_leaves_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_leaves.MouseDoubleClick
        ShowForm1(FormLEAVE_DETAILS, "edit", lst_leaves.FocusedItem.Text)
        RefreshList()
    End Sub

    Private Sub DeleteLeaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteLeaveToolStripMenuItem.Click
        If lst_leaves.FocusedItem.SubItems(11).Text <> "Approved" Then
            If MsgBox("Do you want to delete this Leave record?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, msgBox_header) = MsgBoxResult.Yes Then

                sqlSTR = "Delete from Leaves where Leave_ID =" & lst_leaves.FocusedItem.Text
                ExecuteSQLQuery(sqlSTR)

                MsgBox("Deleted Leave record.", MsgBoxStyle.Information, msgBox_header)
            End If
        Else
            MsgBox("Cannot delete approved Leave record.", MsgBoxStyle.Information, msgBox_header)
        End If

        RefreshList()
    End Sub
End Class