Public Class Main

    Private Sub cmd_Employees_Click(sender As Object, e As EventArgs) Handles cmd_Employees.Click
        FrmEMPLOYEES.TopLevel = False
        FrmEMPLOYEES.FormBorderStyle = FormBorderStyle.None
        FrmEMPLOYEES.Dock = DockStyle.Fill
        mainPanel.Controls.Clear()
        mainPanel.Controls.Add(FrmEMPLOYEES)
        FrmEMPLOYEES.Show()
        'Activate_Topbar(DirectCast(sender, Button).Name)
        DirectCast(sender, Button).BackColor = Color.FromArgb(29, 135, 112)
        DirectCast(sender, Button).ForeColor = Color.White
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center_RelativeTo(panel_topbar, panel_topBar_navigation)
    End Sub

    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        center_RelativeTo(panel_topbar, panel_topBar_navigation)

    End Sub

    Private Function GetRoundedRectPath(rect As Rectangle, radius As Integer) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath()
        Dim diameter As Integer = radius * 2

        ' Top-left corner
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        ' Top-right corner
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        ' Bottom-right corner
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        ' Bottom-left corner
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)

        path.CloseFigure()
        Return path
    End Function

    Private Sub Panel_Border_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Border.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim radius As Integer = 40 ' at least 10
        Dim outsideColor As Color = Color.FromArgb(242, 247, 241)
        Dim borderColor As Color = outsideColor
        Dim borderWidth As Integer = 2

        Dim fullRect As New Rectangle(0, 0, Panel_Border.Width, Panel_Border.Height)
        Dim rect As New Rectangle(0, 0, Panel_Border.Width - 1, Panel_Border.Height - 1)

        ' 1) Fill the whole panel with the "outside" color first (covers the corners)
        Using outsideBrush As New SolidBrush(outsideColor)
            e.Graphics.FillRectangle(outsideBrush, fullRect)
        End Using

        Using path As Drawing2D.GraphicsPath = GetRoundedRectPath(rect, radius)

            ' 2) Fill the inside of the rounded shape with the panel's actual background color
            Using insideBrush As New SolidBrush(Panel_Border.BackColor)
                e.Graphics.FillPath(insideBrush, path)
            End Using

            ' 3) Draw the rounded border on top
            Using pen As New Pen(borderColor, borderWidth)
                e.Graphics.DrawPath(pen, path)
            End Using
        End Using
    End Sub


End Class