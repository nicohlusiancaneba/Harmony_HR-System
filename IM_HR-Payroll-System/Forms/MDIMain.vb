Public Class MDIMain

    Private Sub MDIMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Height = Me.Height

        'Dim temp As Integer = 5 + 4.46
        'btn_employees.Height = Panel1.Height / temp
        'btn_payroll.Height = Panel1.Height / temp
        'btn_leave.Height = Panel1.Height / temp
        'btn_adjustments.Height = Panel1.Height / temp
        'btn_loans.Height = Panel1.Height / temp


        btn_logout.Location = New Point(7, Panel1.Height - 60)
        btn_settings.Location = New Point(7, btn_logout.Location.Y - 60)
        Form_LOGIN.ShowDialog()
    End Sub

    Private Sub activeButtonForm(clickedButton As Button)
        btn_employees.BackColor = Color.White
        btn_leave.BackColor = Color.White
        btn_payroll.BackColor = Color.White
        btn_adjustments.BackColor = Color.White
        btn_loans.BackColor = Color.White

        clickedButton.BackColor = Color.Gainsboro
    End Sub

    Private Sub btn_employees_Click(sender As Object, e As EventArgs) Handles btn_employees.Click
        With FormEMPLOYEES
            .TopLevel = False
            Panel2.Controls.Add(FormEMPLOYEES)
            .BringToFront()
            .Show()
        End With
        activeButtonForm(btn_employees)
    End Sub

    Private Sub btn_payroll_Click(sender As Object, e As EventArgs) Handles btn_payroll.Click
        With FormPAYROLL
            .TopLevel = False
            Panel2.Controls.Add(FormPAYROLL)
            .BringToFront()
            .Show()
        End With
        activeButtonForm(btn_payroll)
    End Sub

    Private Sub btn_loans_Click(sender As Object, e As EventArgs) Handles btn_loans.Click
        activeButtonForm(btn_loans)
    End Sub

    Private Sub btn_adjustments_Click(sender As Object, e As EventArgs) Handles btn_adjustments.Click
        activeButtonForm(btn_adjustments)
    End Sub

    Private Sub btn_leave_Click(sender As Object, e As EventArgs) Handles btn_leave.Click
        activeButtonForm(btn_leave)
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
