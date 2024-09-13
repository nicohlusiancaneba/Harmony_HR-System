Public Class FormADJUSTMENTS


    Private Sub FormADJUSTMENTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = MDIMain.Panel2.Height - 22
        Me.Width = MDIMain.Panel2.Width

        lst_adjusments.Width = Me.Width - 20
        lst_adjusments.Height = Me.Height - 120
    End Sub

    Private Sub btn_searchAdjustment_Click(sender As Object, e As EventArgs) Handles btn_searchAdjustment.Click
        searchBox.Visible = True
        txt_search.Text = ""
        txt_search.Focus()
        CenterGroupBoxRelativeToListView(searchBox, lst_adjusments)
    End Sub

    Private Sub btn_searchSubmit_Click(sender As Object, e As EventArgs) Handles btn_searchSubmit.Click
        searchBox.Visible = False
    End Sub

    Private Sub btn_searchCancel_Click(sender As Object, e As EventArgs) Handles btn_searchCancel.Click
        searchBox.Visible = False
    End Sub
End Class