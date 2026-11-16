Imports System.Deployment.Application

Public Class Main

    Private Sub cmd_Employees_Click(sender As Object, e As EventArgs) Handles cmd_employees.Click
        FrmEMPLOYEES.TopLevel = False
        FrmEMPLOYEES.FormBorderStyle = FormBorderStyle.None
        FrmEMPLOYEES.Dock = DockStyle.Fill
        mainPanel.Controls.Clear()
        mainPanel.Controls.Add(FrmEMPLOYEES)
        FrmEMPLOYEES.Show()
        Activate_Topbar(DirectCast(sender, Button).Name)
        TintSelectedButton(cmd_employees, Color.FromArgb(242, 247, 241))
        DirectCast(sender, Button).BackColor = Color.FromArgb(29, 135, 112)
        DirectCast(sender, Button).ForeColor = Color.FromArgb(242, 247, 241)


    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ThemeHelper.InstallMenuRenderer()
        CacheButtonImageKeys()
        lbl_version.Text = ""
        center_RelativeTo(panel_topbar, panel_topBar_navigation)
        panel_topbar.Visible = False
        mainLeft_Panel.Visible = False
        mainRight_Panel.Visible = False
        System_Version()
        FrmLOGIN.ShowDialog()


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


    Private Sub cmd_New_Click(sender As Object, e As EventArgs) Handles cmd_New.Click
        If mainPanel.Controls.Count > 0 Then
            Dim activeForm As Form = TryCast(mainPanel.Controls(0), Form)
            If activeForm IsNot Nothing Then
                FormAdd(activeForm.Name)
            End If
        End If
    End Sub

    Private Sub cmd_View_Click(sender As Object, e As EventArgs) Handles cmd_View.Click
        If mainPanel.Controls.Count > 0 Then
            Dim activeForm As Form = TryCast(mainPanel.Controls(0), Form)
            If activeForm IsNot Nothing Then
                FormEdit(activeForm.Name)
            End If
        End If
    End Sub

    Private Sub cmd_Delete_Click(sender As Object, e As EventArgs) Handles cmd_Delete.Click
        If mainPanel.Controls.Count > 0 Then
            Dim activeForm As Form = TryCast(mainPanel.Controls(0), Form)
            If activeForm IsNot Nothing Then
                FormDelete(activeForm.Name)
            End If
        End If
    End Sub

    Private Sub cmd_Search_Click(sender As Object, e As EventArgs) Handles cmd_Search.Click
        If mainPanel.Controls.Count > 0 Then
            Dim activeForm As Form = TryCast(mainPanel.Controls(0), Form)
            If activeForm IsNot Nothing Then
                FormSearch(activeForm.Name)
            End If
        End If
    End Sub

    Private Sub cmd_Refresh_Click(sender As Object, e As EventArgs) Handles cmd_Refresh.Click
        If mainPanel.Controls.Count > 0 Then
            Dim activeForm As Form = TryCast(mainPanel.Controls(0), Form)
            If activeForm IsNot Nothing Then
                RefreshList(activeForm.Name)
            End If
        End If
    End Sub

    Private Sub Activate_Topbar(frmName As String)
        If mainPanel.Controls.Count > 0 Then
            panel_topBar_navigation.Visible = True
        End If

        For Each ctrl As Control In sidebar_panel.Controls
            If TypeOf ctrl Is Button Then
                'ctrl.BackColor = Color.White
                ctrl.ForeColor = Color.Black
                ctrl.BackColor = Color.FromArgb(242, 247, 241)
                ctrl.ForeColor = Color.FromArgb(29, 135, 112)
            End If
            RestoreSidebarButtons()

        Next




        cmd_New.Enabled = True
        cmd_View.Enabled = True
        cmd_Delete.Enabled = True
        cmd_Search.Enabled = True
        cmd_Refresh.Enabled = True



        Select Case UCase(frmName)
            Case UCase("cmd_dashboard")
                cmd_New.Enabled = False
                cmd_View.Enabled = False
                cmd_Delete.Enabled = False
                cmd_Search.Enabled = False
                cmd_Refresh.Enabled = True

            Case UCase("cmd_employees")
                cmd_New.Enabled = True
                cmd_View.Enabled = True
                cmd_Delete.Enabled = True
                cmd_Search.Enabled = True
                cmd_Refresh.Enabled = True

            Case UCase("cmd_attendance")
                cmd_New.Enabled = True
                cmd_View.Enabled = True
                cmd_Delete.Enabled = True
                cmd_Search.Enabled = True
                cmd_Refresh.Enabled = True

            Case UCase("cmd_shifts")
                cmd_New.Enabled = True
                cmd_View.Enabled = True
                cmd_Delete.Enabled = True
                cmd_Search.Enabled = False
                cmd_Refresh.Enabled = True

            Case UCase("cmd_payroll")
                cmd_New.Enabled = True
                cmd_View.Enabled = True
                cmd_Delete.Enabled = True
                cmd_Search.Enabled = True
                cmd_Refresh.Enabled = True

            Case UCase("cmd_loans")
                cmd_New.Enabled = True
                cmd_View.Enabled = True
                cmd_Delete.Enabled = True
                cmd_Search.Enabled = True
                cmd_Refresh.Enabled = True

            Case UCase("cmd_adjustments")
                cmd_New.Enabled = True
                cmd_View.Enabled = True
                cmd_Delete.Enabled = True
                cmd_Search.Enabled = True
                cmd_Refresh.Enabled = True

            Case UCase("cmd_leaves")
                cmd_New.Enabled = True
                cmd_View.Enabled = True
                cmd_Delete.Enabled = True
                cmd_Search.Enabled = True
                cmd_Refresh.Enabled = True

            Case UCase("cmd_incidents")
                cmd_New.Enabled = True
                cmd_View.Enabled = True
                cmd_Delete.Enabled = True
                cmd_Search.Enabled = True
                cmd_Refresh.Enabled = True

            Case UCase("cmd_evaluation")
                cmd_New.Enabled = True
                cmd_View.Enabled = True
                cmd_Delete.Enabled = True
                cmd_Search.Enabled = True
                cmd_Refresh.Enabled = True

            Case UCase("cmd_reports")
                cmd_New.Enabled = True
                cmd_View.Enabled = False
                cmd_Delete.Enabled = False
                cmd_Search.Enabled = False
                cmd_Refresh.Enabled = True


        End Select
    End Sub

    Private Sub cmd_payroll_Click(sender As Object, e As EventArgs) Handles cmd_payroll.Click
        FrmPAYROLL.TopLevel = False
        FrmPAYROLL.FormBorderStyle = FormBorderStyle.None
        FrmPAYROLL.Dock = DockStyle.Fill
        mainPanel.Controls.Clear()
        mainPanel.Controls.Add(FrmPAYROLL)
        FrmPAYROLL.Show()
        Activate_Topbar(DirectCast(sender, Button).Name)
        TintSelectedButton(cmd_payroll, Color.FromArgb(242, 247, 241))
        DirectCast(sender, Button).BackColor = Color.FromArgb(29, 135, 112)
        DirectCast(sender, Button).ForeColor = Color.FromArgb(242, 247, 241)
    End Sub

    Private Sub cmd_loans_Click(sender As Object, e As EventArgs) Handles cmd_loans.Click
        FrmLOANS.TopLevel = False
        FrmLOANS.FormBorderStyle = FormBorderStyle.None
        FrmLOANS.Dock = DockStyle.Fill
        mainPanel.Controls.Clear()
        mainPanel.Controls.Add(FrmLOANS)
        FrmLOANS.Show()
        Activate_Topbar(DirectCast(sender, Button).Name)
        TintSelectedButton(cmd_loans, Color.FromArgb(242, 247, 241))
        DirectCast(sender, Button).BackColor = Color.FromArgb(29, 135, 112)
        DirectCast(sender, Button).ForeColor = Color.FromArgb(242, 247, 241)
    End Sub

    Private Sub cmd_adjustments_Click(sender As Object, e As EventArgs) Handles cmd_adjustments.Click
        FrmADJUSTMENTS.TopLevel = False
        FrmADJUSTMENTS.FormBorderStyle = FormBorderStyle.None
        FrmADJUSTMENTS.Dock = DockStyle.Fill
        mainPanel.Controls.Clear()
        mainPanel.Controls.Add(FrmADJUSTMENTS)
        FrmADJUSTMENTS.Show()
        Activate_Topbar(DirectCast(sender, Button).Name)
        TintSelectedButton(cmd_adjustments, Color.FromArgb(242, 247, 241))
        DirectCast(sender, Button).BackColor = Color.FromArgb(29, 135, 112)
        DirectCast(sender, Button).ForeColor = Color.FromArgb(242, 247, 241)
    End Sub

    Private Sub cmd_leaves_Click(sender As Object, e As EventArgs) Handles cmd_leaves.Click
        'cmd_leaves.ImageList = sidebar_images_selected
        'cmd_leaves.ImageKey = "calendar.png"

        FrmLEAVES.TopLevel = False
        FrmLEAVES.FormBorderStyle = FormBorderStyle.None
        FrmLEAVES.Dock = DockStyle.Fill
        mainPanel.Controls.Clear()
        mainPanel.Controls.Add(FrmLEAVES)
        FrmLEAVES.Show()
        Activate_Topbar(DirectCast(sender, Button).Name)
        TintSelectedButton(cmd_leaves, Color.FromArgb(242, 247, 241))
        DirectCast(sender, Button).BackColor = Color.FromArgb(29, 135, 112)
        DirectCast(sender, Button).ForeColor = Color.FromArgb(242, 247, 241)
    End Sub


    Private Sub cmd_incidents_Click(sender As Object, e As EventArgs) Handles cmd_incidents.Click
        FrmINCIDENTS.TopLevel = False
        FrmINCIDENTS.FormBorderStyle = FormBorderStyle.None
        FrmINCIDENTS.Dock = DockStyle.Fill
        mainPanel.Controls.Clear()
        mainPanel.Controls.Add(FrmINCIDENTS)
        FrmINCIDENTS.Show()
        Activate_Topbar(DirectCast(sender, Button).Name)
        TintSelectedButton(cmd_incidents, Color.FromArgb(242, 247, 241))
        DirectCast(sender, Button).BackColor = Color.FromArgb(29, 135, 112)
        DirectCast(sender, Button).ForeColor = Color.FromArgb(242, 247, 241)
    End Sub

    Private Sub cmd_reports_Click(sender As Object, e As EventArgs) Handles cmd_reports.Click
        FrmREPORTS.TopLevel = False
        FrmREPORTS.FormBorderStyle = FormBorderStyle.None
        FrmREPORTS.Dock = DockStyle.Fill
        mainPanel.Controls.Clear()
        mainPanel.Controls.Add(FrmREPORTS)
        FrmREPORTS.Show()
        Activate_Topbar(DirectCast(sender, Button).Name)
        TintSelectedButton(cmd_reports, Color.FromArgb(242, 247, 241))
        DirectCast(sender, Button).BackColor = Color.FromArgb(29, 135, 112)
        DirectCast(sender, Button).ForeColor = Color.FromArgb(242, 247, 241)
    End Sub


    Private Sub cmd_shifts_Click(sender As Object, e As EventArgs) Handles cmd_shifts.Click
        FrmSHIFTS.TopLevel = False
        FrmSHIFTS.FormBorderStyle = FormBorderStyle.None
        FrmSHIFTS.Dock = DockStyle.Fill
        mainPanel.Controls.Clear()
        mainPanel.Controls.Add(FrmSHIFTS)
        FrmSHIFTS.Show()
        Activate_Topbar(DirectCast(sender, Button).Name)
        TintSelectedButton(cmd_shifts, Color.FromArgb(242, 247, 241))
        DirectCast(sender, Button).BackColor = Color.FromArgb(29, 135, 112)
        DirectCast(sender, Button).ForeColor = Color.FromArgb(242, 247, 241)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub cmd_attendance_Click(sender As Object, e As EventArgs) Handles cmd_attendance.Click
        FrmATTENDANCE.TopLevel = False
        FrmATTENDANCE.FormBorderStyle = FormBorderStyle.None
        FrmATTENDANCE.Dock = DockStyle.Fill
        mainPanel.Controls.Clear()
        mainPanel.Controls.Add(FrmATTENDANCE)
        FrmATTENDANCE.Show()
        Activate_Topbar(DirectCast(sender, Button).Name)
        TintSelectedButton(cmd_attendance, Color.FromArgb(242, 247, 241))
        DirectCast(sender, Button).BackColor = Color.FromArgb(29, 135, 112)
        DirectCast(sender, Button).ForeColor = Color.FromArgb(242, 247, 241)
    End Sub



    Private Sub cmd_dashboard_Click(sender As Object, e As EventArgs) Handles cmd_dashboard.Click

    End Sub


    Private buttonImageKeys As New Dictionary(Of Button, String)
    Private tintedImage As Bitmap

    ' Call once in Form Load, before any button is selected
    Private Sub CacheButtonImageKeys()
        buttonImageKeys.Clear()
        For Each ctrl As Control In sidebar_panel.Controls
            Dim btn As Button = TryCast(ctrl, Button)
            If btn IsNot Nothing AndAlso btn.ImageList Is sidebar_images AndAlso btn.ImageKey <> "" Then
                buttonImageKeys(btn) = btn.ImageKey
            End If
        Next
    End Sub

    ' Tint only the selected button's icon
    Private Sub TintSelectedButton(selected As Button, tintColor As Color)
        RestoreSidebarButtons()

        If buttonImageKeys.ContainsKey(selected) Then
            Using src As New Bitmap(sidebar_images.Images(buttonImageKeys(selected)))
                tintedImage = TintImage(src, tintColor)
            End Using
            selected.Image = tintedImage   ' this clears the button's ImageList/ImageKey
        End If
    End Sub

    ' Put every button back to its original ImageList image
    Private Sub RestoreSidebarButtons()
        For Each kvp As KeyValuePair(Of Button, String) In buttonImageKeys
            kvp.Key.ImageList = sidebar_images
            kvp.Key.ImageKey = kvp.Value
        Next
        If tintedImage IsNot Nothing Then
            tintedImage.Dispose()
            tintedImage = Nothing
        End If
    End Sub

    ' Recolors every non-transparent pixel to tintColor and keeps the alpha
    Private Function TintImage(src As Bitmap, tintColor As Color) As Bitmap
        Dim result As New Bitmap(src.Width, src.Height, Imaging.PixelFormat.Format32bppArgb)
        Dim cm As New Imaging.ColorMatrix(New Single()() {
            New Single() {0, 0, 0, 0, 0},
            New Single() {0, 0, 0, 0, 0},
            New Single() {0, 0, 0, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {tintColor.R / 255.0F, tintColor.G / 255.0F, tintColor.B / 255.0F, 0, 1}
        })
        Using ia As New Imaging.ImageAttributes()
            ia.SetColorMatrix(cm)
            Using g As Graphics = Graphics.FromImage(result)
                g.DrawImage(src, New Rectangle(0, 0, src.Width, src.Height), _
                            0, 0, src.Width, src.Height, GraphicsUnit.Pixel, ia)
            End Using
        End Using
        Return result
    End Function


    Private Sub cmd_evaluation_Click(sender As Object, e As EventArgs) Handles cmd_evaluation.Click

    End Sub

    Private Sub mainPanel_Paint(sender As Object, e As PaintEventArgs) Handles mainPanel.Paint

    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        FrmUSERS.ShowDialog()
    End Sub


    Private Sub System_Version()
        If ApplicationDeployment.IsNetworkDeployed Then
            Dim currentVersion As Version = ApplicationDeployment.CurrentDeployment.CurrentVersion

            lbl_version.Text = "v." & currentVersion.ToString()

            sqlSTR = "select top 1 System_Version from Global_Data"
            ExecuteSQLQuery(sqlSTR)

            Dim dbVersion As New Version(sqlDT.Rows(0)("System_Version").ToString)


            If currentVersion < dbVersion Then
                MsgBox("A new updated version (" & dbVersion.ToString() & ") is available." & vbCrLf & _
       "Please update your system to fix errors, resolve bugs, and minimize incorrect outputs and inputs.", _
       MsgBoxStyle.Information, "System Update Available")
            End If

            If currentVersion > dbVersion Then
                sqlSTR = "Update Global_Data set System_Version='" & currentVersion.ToString & "'"
                ExecuteSQLQuery(sqlSTR)
            End If
        Else
            lbl_version.Text = "(Debug)"
        End If
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        closeForms()


        panel_topbar.Visible = False
        mainLeft_Panel.Visible = False
        mainRight_Panel.Visible = False



        FrmLOGIN.ShowDialog()
    End Sub

    Public Sub closeForms()


        Dim formsToClose As New List(Of Form)

        For Each openForm As Form In Application.OpenForms
            If openForm.Name <> "Main" AndAlso openForm.Name <> "FrmLOGIN" Then
                formsToClose.Add(openForm)
            End If
        Next

        For Each form As Form In formsToClose
            form.Close()
        Next


        RestoreSidebarButtons()
 
    End Sub
End Class