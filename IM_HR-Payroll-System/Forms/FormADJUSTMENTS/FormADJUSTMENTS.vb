Public Class FormADJUSTMENTS


    Private Sub FormADJUSTMENTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = MDIMain.Panel2.Height - 22
        Me.Width = MDIMain.Panel2.Width

        lst_adjusments.Width = Me.Width - 20
        lst_adjusments.Height = Me.Height - 120

        rb_All.Checked = True
        'RefreshList_Adjustments()
    End Sub

    Private Sub RefreshList_Adjustments()
        Dim rb_selected As String = ""
        If rb_All.Checked Then
            rb_selected = ""
        ElseIf rb_PagIBIG.Checked Then
            rb_selected = "Pag-Ibig"
        ElseIf rb_Philhealth.Checked Then
            rb_selected = "Philhealth"
        ElseIf rb_salary.Checked Then
            rb_selected = "Salary"
        ElseIf rb_SSS.Checked Then
            rb_selected = "SSS"
        ElseIf rb_tax.Checked Then
            rb_selected = "Tax"
        ElseIf rb_reg.Checked Then
            rb_selected = "Regularization"
        End If


        sqlSTR = "SELECT Adjustment_ID as ID, CONCAT(Last_Name, ', ', First_Name, ' ', left(Middle_Name, 1), '.') as 'Employee', " & _
                    "Adjustment_Type as 'Adjustment Type', Prev_Value as 'Previous Value', New_Value as 'New Value', Encoded_by as 'Encoded by', " & _
                    "Adj_Approved as 'Approved', Date_Adjusted as 'Date Adjusted', Approved_by as 'Approved by' " & _
                    "FROM Adjustments " & _
                    "inner join Employees on Employees.Employee_ID = Adjustments.Employee_ID where Adjustment_Type like '%" & rb_selected & "%' and " & _
                    "CONCAT(Employees.Employee_ID, ' ', Last_Name, ' ', First_Name, ' ', Middle_Name, ' ', Adjustment_Type, ' ', Prev_Value, ' ', New_Value) like '%" & txt_search.Text & "%'" & _
                    "order by Adjustment_Type, Last_Name, First_Name "
        FillListView(ExecuteSQLQuery(sqlSTR), lst_adjusments, 0)
    End Sub

    Private Sub btn_searchAdjustment_Click(sender As Object, e As EventArgs) Handles btn_searchAdjustment.Click
        searchBox.Visible = True
        txt_search.Text = ""
        txt_search.Focus()
        CenterGroupBoxRelativeToListView(searchBox, lst_adjusments)
    End Sub

    Private Sub btn_searchSubmit_Click(sender As Object, e As EventArgs) Handles btn_searchSubmit.Click
        rb_All.Checked = False
        rb_PagIBIG.Checked = False
        rb_Philhealth.Checked = False
        rb_salary.Checked = False
        rb_SSS.Checked = False
        rb_tax.Checked = False

        RefreshList_Adjustments()
        searchBox.Visible = False
        txt_search.Text = ""
    End Sub

    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = 13 Then
            rb_All.Checked = False
            rb_PagIBIG.Checked = False
            rb_Philhealth.Checked = False
            rb_salary.Checked = False
            rb_SSS.Checked = False
            rb_tax.Checked = False

            RefreshList_Adjustments()
            searchBox.Visible = False
            txt_search.Text = ""
        End If
    End Sub


    Private Sub btn_searchCancel_Click(sender As Object, e As EventArgs) Handles btn_searchCancel.Click
        searchBox.Visible = False
    End Sub

    Private Sub btn_newAdjustment_Click(sender As Object, e As EventArgs) Handles btn_newAdjustment.Click
        ShowForm1(FormADJUSTMENT_DETAILS, "add", 0)
        RefreshList_Adjustments()
    End Sub

    Private Sub lst_adjusments_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_adjusments.MouseDoubleClick
        ShowForm1(FormADJUSTMENT_DETAILS, "edit", lst_adjusments.FocusedItem.Text)
        RefreshList_Adjustments()
    End Sub

    Private Sub EditAdjustment_Click(sender As Object, e As EventArgs) Handles EditAdjustment.Click
        ShowForm1(FormADJUSTMENT_DETAILS, "edit", lst_adjusments.FocusedItem.Text)
        RefreshList_Adjustments()
    End Sub

    Private Sub DeleteAdjustment_Click(sender As Object, e As EventArgs) Handles DeleteAdjustment.Click
        If lst_adjusments.FocusedItem.SubItems(6).Text = "No" Then
            If MsgBox("Do you want to delete this adjustment record?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, msgBox_header) = MsgBoxResult.Yes Then
                sqlSTR = "Delete from Adjustments where Adjustment_ID =" & lst_adjusments.FocusedItem.Text
                ExecuteSQLQuery(sqlSTR)

                MsgBox("Deleted adjustment record.", MsgBoxStyle.Information, msgBox_header)
            End If
        Else
            MsgBox("Cannot delete approved adjustment record.", MsgBoxStyle.Information, msgBox_header)
        End If


        
        RefreshList_Adjustments()
    End Sub

    Private Sub rb_All_CheckedChanged(sender As Object, e As EventArgs) Handles rb_All.CheckedChanged
        RefreshList_Adjustments()
    End Sub

    Private Sub rb_salary_CheckedChanged(sender As Object, e As EventArgs) Handles rb_salary.CheckedChanged
        RefreshList_Adjustments()
    End Sub

    Private Sub rb_SSS_CheckedChanged(sender As Object, e As EventArgs) Handles rb_SSS.CheckedChanged
        RefreshList_Adjustments()
    End Sub

    Private Sub rb_PagIBIG_CheckedChanged(sender As Object, e As EventArgs) Handles rb_PagIBIG.CheckedChanged
        RefreshList_Adjustments()
    End Sub

    Private Sub rb_Philhealth_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Philhealth.CheckedChanged
        RefreshList_Adjustments()
    End Sub

    Private Sub rb_tax_CheckedChanged(sender As Object, e As EventArgs) Handles rb_tax.CheckedChanged
        RefreshList_Adjustments()
    End Sub
End Class