Public Class FrmEVALUATION
    Public whereSQL, Evaluation_ID, formAction As String
    Private Sub FrmEVALUATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        whereSQL = " AND Evaluation_Date >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) " & _
                    "AND Evaluation_Date < DATEADD(MONTH, 1, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)) "
        Refresh_List()
    End Sub

    Public Sub Refresh_List()
        sqlSTR = "SELECT " & _
                "Evaluation_ID AS ID, " & _
                "Evaluation_Date AS 'Evaluation Date', " & _
                "CONCAT(Last_Name, ', ', First_Name, ', ', Middle_Name) AS Evaluee, " & _
                "CONCAT(Total_Percentage, '%') AS Percentage, " & _
                "Evaluation_Description AS 'Evaluation Description', " & _
                "Evaluation_Remarks AS Remarks, " & _
                "Evaluation_Validated AS 'Validated?', " & _
                "(SELECT TOP 1 " & _
                    "CONCAT(Last_Name, ', ', First_Name, ', ', Middle_Name) " & _
                 "FROM Employees " & _
                 "WHERE Employee_ID = Evaluator_ID) AS Evaluator " & _
                "FROM Evaluation " & _
                "INNER JOIN Employees ON Employees.Employee_ID = Evaluation.Employee_ID " & _
                "WHERE 1=1 " & whereSQL & _
                "Order by Evaluation_Date, Evaluee;"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_evaluations, 3)

        For Each item As ListViewItem In lst_evaluations.Items
            If item.SubItems(6).Text = "No" Then
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
        checkbox_CheckedValue(cb_name, " and CONCAT(Last_Name, ', ', First_Name, ', ', Middle_Name) like '%" & txt_name.Text & "%' ")
        checkbox_CheckedValue(cb_evalDate, " and Evaluation_Date between '" & dt_fromEval.Text & "' and '" & dt_toEval.Text & "' ")
        checkbox_CheckedValue(cb_Validated, " and Evaluation_Validated = '" & cmb_Validated.Text & "' ")


        whereSQL = cb_employeeID.Tag & cb_name.Tag & cb_evalDate.Tag & cb_Validated.Tag

        If whereSQL = "" Then
            Exit Sub
        End If

        Refresh_List()
    End Sub

    Private Sub lst_evaluations_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_evaluations.MouseDoubleClick
        Evaluation_ID = lst_evaluations.FocusedItem.Text
        formAction = "edit"
        FrmEVALUATION_DETAILS.ShowDialog()
    End Sub
End Class