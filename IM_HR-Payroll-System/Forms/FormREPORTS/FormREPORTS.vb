Public Class FormREPORTS

    Private Sub FormREPORTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = MDIMain.Panel2.Height - 22
        Me.Width = MDIMain.Panel2.Width

        lst_report.Width = Me.Width - 20
        lst_report.Height = Me.Height - 120
    End Sub

    Private Sub btn_newReport_Click(sender As Object, e As EventArgs) Handles btn_newReport.Click
        FormREPORT_CREATE.ShowDialog()
    End Sub
End Class