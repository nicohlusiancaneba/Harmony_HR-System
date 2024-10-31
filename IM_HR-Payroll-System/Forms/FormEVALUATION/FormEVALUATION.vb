Public Class FormEVALUATION

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
            cmb_year.Items.Add("2024")
        End If

        cmb_month.Text = DateTime.Now.ToString("MMMM")
        cmb_year.Text = DateTime.Now.Year

    End Sub
End Class