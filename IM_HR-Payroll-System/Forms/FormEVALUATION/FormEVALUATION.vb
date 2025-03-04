Public Class FormEVALUATION
    Dim xSelectIndex As Boolean
    Private Sub FormEVALUATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = MDIMain.Panel2.Height - 22
        Me.Width = MDIMain.Panel2.Width

        lst_evaluation.Width = Me.Width - 20
        lst_evaluation.Height = Me.Height - 120

        sqlSTR = "select max(evaluation_id), year(evaluation_date) from Evaluation group by year(evaluation_date)"
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            FILLComboBox2(sqlSTR, cmb_year)
        Else
            cmb_year.Items.Add(DateTime.Now.Year)
        End If

        cmb_month.Text = DateTime.Now.ToString("MMMM")
        cmb_year.Text = DateTime.Now.Year

        xSelectIndex = True
        RefreshList()
    End Sub

    Private Sub btn_newLeave_Click(sender As Object, e As EventArgs) Handles btn_newEvaluation.Click
        ShowForm1(FormEVALUATION_DETAILS, "add", 0)
        RefreshList()
    End Sub

    Private Sub RefreshList()
        If xSelectIndex Then
            sqlSTR = "select Evaluation_ID as ID, Evaluation_Date as 'Evaluation Date', CONCAT(Last_Name, ', ', First_Name, ', ', Middle_Name) as 'Evaluee', " & _
                "CONCAT(Total_Percentage, '%') as Percentage, Evaluation_Description as 'Evaluation Description', Evaluation_Remarks as Remarks, Evaluation_Validated as 'Validated?', " & _
                "(select top 1 CONCAT(Last_Name, ', ', First_Name, ', ', Middle_Name) from employees where employee_id = Evaluator_ID) as Evaluator " & _
                "from evaluation " & _
                "INNER JOIN Employees on Employees.Employee_ID = Evaluation.Employee_ID " & _
                "WHERE DATENAME(MONTH, Evaluation_Date) = '" & cmb_month.Text & "' and Year(Evaluation_Date) ='" & cmb_year.Text & "'"
            FillListView(ExecuteSQLQuery(sqlSTR), lst_evaluation, 0)
        End If
        
    End Sub

    Private Sub EditLeaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEvaluationToolStripMenuItem.Click
        ShowForm1(FormEVALUATION_DETAILS, "edit", lst_evaluation.FocusedItem.Text)
        RefreshList()
    End Sub

    Private Sub lst_evaluation_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_evaluation.MouseDoubleClick
        ShowForm1(FormEVALUATION_DETAILS, "edit", lst_evaluation.FocusedItem.Text)
        RefreshList()
    End Sub

    Private Sub DeleteEvaluationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEvaluationToolStripMenuItem.Click
        If lst_evaluation.FocusedItem.SubItems(6).Text = "Yes" Then
            MsgBox("Cannot delete a validated evaluation.", MsgBoxStyle.Information, msgBox_header)
            Exit Sub
        End If

        If MsgBox("Do you want to delete this evaluation record?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, msgBox_header) = MsgBoxResult.Yes Then
            sqlSTR = "Delete from evaluation where Evaluation_ID =" & lst_evaluation.FocusedItem.Text
            ExecuteSQLQuery(sqlSTR)

            MsgBox("Deleted evaluation record.", MsgBoxStyle.Information, msgBox_header)
        End If
        RefreshList()
    End Sub

    Private Sub cmb_date_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_month.SelectedIndexChanged, cmb_year.SelectedIndexChanged
        RefreshList()
    End Sub

    Private Sub btn_searchEvaluation_Click(sender As Object, e As EventArgs) Handles btn_searchEvaluation.Click
        searchBox.Visible = True
        txt_search.Text = ""
        txt_search.Focus()
        CenterGroupBoxRelativeToListView(searchBox, lst_evaluation)
    End Sub

    Private Sub EvaluationSearch()
        xSelectIndex = False
        cmb_month.SelectedIndex = -1
        cmb_year.SelectedIndex = -1
        sqlSTR = "SELECT Evaluation_ID as ID, Evaluation_Date as 'Evaluation Date', " & _
         "CONCAT(Last_Name, ', ', First_Name, ', ', Middle_Name) as 'Evaluee', " & _
         "CONCAT(Total_Percentage, '%') as Percentage, Evaluation_Description as 'Evaluation Description', " & _
         "Evaluation_Remarks as Remarks, Evaluation_Validated as 'Validated?', " & _
         "(SELECT TOP 1 CONCAT(Last_Name, ', ', First_Name, ', ', Middle_Name) " & _
         " FROM Employees WHERE Employee_ID = evaluation.Evaluator_ID ORDER BY Employee_ID) as Evaluator " & _
         "FROM Evaluation " & _
         "INNER JOIN Employees ON Employees.Employee_ID = Evaluation.Employee_ID " & _
         "WHERE CONCAT(Evaluation_ID, ' ', Employees.Employee_ID, ' ', Last_Name, ' ', First_Name, ' ', Middle_Name, ' ', " & _
         "COALESCE(Evaluation_Remarks, '')) LIKE '%" & txt_search.Text & "%'"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_evaluation, 0)
        searchBox.Visible = False
        xSelectIndex = True
    End Sub

    Private Sub btn_searchSubmit_Click(sender As Object, e As EventArgs) Handles btn_searchSubmit.Click
        EvaluationSearch()
    End Sub

    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = 13 Then
            EvaluationSearch()
            searchBox.Visible = False
        End If
    End Sub

    Private Sub btn_searchCancel_Click(sender As Object, e As EventArgs) Handles btn_searchCancel.Click
        searchBox.Visible = True
    End Sub
End Class