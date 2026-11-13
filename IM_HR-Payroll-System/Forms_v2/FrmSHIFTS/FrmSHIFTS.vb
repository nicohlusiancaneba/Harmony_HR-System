Public Class FrmSHIFTS
    Public formAction, Shift_ID As String
    Private Sub FrmSHIFTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeHelper.ApplyHighlight(Me)
        Refresh_List()
    End Sub


    Private Sub Frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        left_panel.Width = Me.Width * 0.6
    End Sub

    Private Sub lst_shifts_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_shifts.MouseDoubleClick
        lst_shifts.Focus()
        If lst_shifts.Items.Count > 0 Then
            formAction = "edit"
            Shift_ID = lst_shifts.FocusedItem.Text
            FrmSHIFT_DETAILS.ShowDialog()
            Refresh_List()
        End If
    End Sub

  

    Public Sub Refresh_List()
        sqlSTR = "SELECT " & _
                "Shift_ID as ID " & _
                ",Shift_Created as 'Date Created' " & _
                ",Shift_Code as 'Shift Code' " & _
                ",Shift_Name as 'Name' " & _
                ",Start_Time as 'Shift Start' " & _
                ",End_Time as 'Shift End' " & _
                ",CONCAT(GracePeriod_Min, ' min(s)') as ' Grace Period' " & _
                ",CONCAT(Required_Hours, ' hour(s)') as 'Required Hour(s)' " & _
                ",CONCAT(No_Days_Weekly, ' day(s)') as 'Days/Week' " & _
                ",Employee_Count as 'Employee Count' " & _
                ",Shift_Status as 'Shift Status' " & _
                ",Shift_Approved as 'Date Approved' " & _
                ",Created_By as 'Created By' " & _
                ",Updated_By as 'Updated By' " & _
                "FROM dbo.Shifts " & _
                "where 1=1 " & _
                "Order By Shift_ID;"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_shifts, Main.sidebar_images, 9)

        sqlSTR = "select CONCAT(Last_Name, ', ', First_Name, ' ', left(Middle_Name, 1), '.') as 'No Shift Assigned', Position, Department from Employees " & _
                "where Employment_Status != 'Terminated' and Employment_Status != 'Resigned' " & _
                "and Employee_ID not in (select Distinct Employee_ID from Shifts_Details " & _
                "inner join Shifts on Shifts.Shift_ID = Shifts_Details.Shift_ID " & _
                "where Shift_Status = 'Approved') " & _
                "Order by Last_Name, First_Name, Middle_Name;"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_employees, Main.sidebar_images, 0)

        For Each item As ListViewItem In lst_shifts.Items
            If item.SubItems(10).Text = "Pending" Then
                item.ForeColor = Color.Red
            Else
                item.ForeColor = Color.Black
            End If
        Next
    End Sub
End Class