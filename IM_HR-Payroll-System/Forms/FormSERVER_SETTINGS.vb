Public Class FormSERVER_SETTINGS
    Dim CONSTR As String
    Public serverName As String
    Public userName As String
    Public pass As String
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Call writeFileStrData(txtip.Text & ":" & txtservername.Text & ":" & txtusername.Text & ":" & txtpassword.Text & ":" & (IIf(RadioButton1.Checked, 1, 2)) & ":" & cmb_dbname.Text, Application.StartupPath & "\Config.ini", , "Unicode")
        checkServer()
        serverName = CnString
        Me.Close()


        MDIMain.Show()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        txtip.Enabled = True
        txtpassword.Enabled = True
        txtservername.Enabled = True
        txtusername.Enabled = True
        txtip.Focus()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        txtip.Enabled = False
        txtpassword.Enabled = False
        txtusername.Enabled = False
        txtservername.Focus()
    End Sub

    Private Sub FormSERVER_SETTINGS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
    End Sub

    Private Sub cmb_dbname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_dbname.SelectedIndexChanged

    End Sub
End Class