Public Class FrmINCIDENTS
    Public formAction, Incident_ID, whereSQL As String
    Private Sub FrmINCIDENTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        whereSQL = " AND ((Incident_DateTime >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) " & _
                    "AND Incident_DateTime < DATEADD(MONTH, 1, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1))) " & _
                    "OR Incident_Status = 'Under Review') "
        Refresh_List()
    End Sub

    Public Sub Refresh_List()
        sqlSTR = "SELECT " & _
                "Incident_ID as ID, " & _
                "Incident_EncodeDate as 'Encode Date', " & _
                "Incident_DateTime as 'Incident Date', " & _
                "Incident_Classification as 'Incident Classification', " & _
                "(SELECT STRING_AGG( " & _
                "CONCAT( " & _
                "TRIM(Last_Name), ', ', " & _
                "TRIM(First_Name), " & _
                "CASE WHEN NULLIF(TRIM(Middle_Name), '') IS NOT NULL " & _
                "THEN ' ' + LEFT(TRIM(Middle_Name), 1) + '.' " & _
                "ELSE '' " & _
                "END " & _
                "), ', ') " & _
                "WITHIN GROUP (ORDER BY Last_Name, First_Name) " & _
                "FROM Employees " & _
                "WHERE Employee_ID IN ( " & _
                "SELECT Employee_ID " & _
                "FROM Incident_Details_Employees " & _
                "WHERE Incident_ID = Incident.Incident_ID " & _
                ")) as 'Employees Involved', " & _
                "Incident_Location as 'Incident Location', " & _
                "Incident_Details as 'Incident Detail(s)', " & _
                "Incident_Status as 'Incident Status', " & _
                "Incident_UpdateDate as 'Last Update', " & _
                "Prepared_By as 'Prepared By' " & _
                "FROM Incident " & _
                "WHERE 1=1 " & _
                "Order by Incident_EncodeDate;"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_incidents, Main.sidebar_images, 11)

        For Each item As ListViewItem In lst_incidents.Items
            If item.SubItems(7).Text = "Under Review" Then
                item.ForeColor = Color.Red
            Else
                item.ForeColor = Color.Black
            End If
        Next
    End Sub

    Private Sub lst_incidents_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_incidents.MouseDoubleClick
        lst_incidents.Focus()
        If lst_incidents.Items.Count > 0 Then
            formAction = "edit"
            Incident_ID = lst_incidents.FocusedItem.Text
            FrmINCIDENT_DETAILS.ShowDialog()
            Refresh_List()
        End If
    End Sub
End Class