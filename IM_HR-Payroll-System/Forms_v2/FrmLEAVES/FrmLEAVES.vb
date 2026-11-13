Public Class FrmLEAVES
    Public whereSQL, formAction, Leave_ID As String
    Private Sub FrmLEAVES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeHelper.ApplyHighlight(Me)
        whereSQL = " and (Leave_Status = 'Pending' or Leave_Start >= DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0) AND Leave_End   <  DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()) + 1, 0)) "
        Refresh_List()
    End Sub

    Public Sub Refresh_List()
        sqlSTR = "select Leave_ID as 'ID', " & _
                "Date_Applied as 'Date Applied', " & _
                "Employees.Employee_ID as 'Employee ID', " & _
                "CONCAT(Last_Name, ', ', First_Name, ' ', LEFT(middle_name,1), '.') as Employee, " & _
                "Immediate_Supervisor as Supervisor, " & _
                "Leave_Category as Category, " & _
                "Leave_Start as 'Leave Start', " & _
                "Leave_end as 'Leave End', " & _
                "Leave_TotalDays as 'Total Day(s)', " & _
                "Leave_Reason as Reason, " & _
                "Leave_Remarks as Remarks, " & _
                "COALESCE(Leave_Status, 'Pending') as Status " & _
                "from Leaves " & _
                "INNER JOIN Employees on Employees.Employee_ID = Leaves.Employee_ID " & _
                "where 1=1 " & whereSQL & _
                "order by Date_Applied, Leave_Start, Employee"

        FillListView(ExecuteSQLQuery(sqlSTR), lst_leaves, Main.sidebar_images, 8)

        For Each item As ListViewItem In lst_leaves.Items
            If item.SubItems(11).Text = "Pending" Then
                item.ForeColor = Color.Red
            Else
                item.ForeColor = Color.Black
            End If
        Next
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        grpFilter.Visible = False
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        grpFilter.Visible = False



        checkbox_CheckedValue(cb_employeeID, " and Employees.Employee_ID = '" & txt_employeeID.Text & "' ")
        checkbox_CheckedValue(cb_name, " and CONCAT(TRIM(Last_Name), ' ', TRIM(First_Name), ' ', TRIM(Middle_Name)) like '%" & txt_name.Text & "%' ")
        checkbox_CheckedValue(cb_leaveCategory, " and Leave_Category = '" & cmb_leaveCategory.Text & "' ")
        checkbox_CheckedValue(cb_leaveDate, " and Leave_Start >= '" & dt_fromLeave.Text & "' and Leave_End <='" & dt_toLeave.Text & "' ")
        checkbox_CheckedValue(cb_remarks, " and CONCAT(Leave_Reason, ' ', Leave_Remarks) like '%" & txt_remarks.Text & "%' ")
        checkbox_CheckedValue(cb_status, " and COALESCE(Leave_Status, 'Pending') = '" & cmb_status.Text & "' ")


        whereSQL = cb_employeeID.Tag & cb_name.Tag & cb_leaveCategory.Tag & cb_leaveDate.Tag & cb_remarks.Tag & cb_status.Tag

        If whereSQL = "" Then
            MsgBox("Search filter too broad. Try again.")
            Exit Sub
        End If



        Refresh_List()
    End Sub

    Private Sub lst_leaves_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_leaves.MouseDoubleClick
        lst_leaves.Focus()
        If lst_leaves.Items.Count > 0 Then
            formAction = "edit"
            Leave_ID = lst_leaves.FocusedItem.Text
            FrmLEAVE_DETAILS.ShowDialog()
            Refresh_List()
        End If
    End Sub
End Class