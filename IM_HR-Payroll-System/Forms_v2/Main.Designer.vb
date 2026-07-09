<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.panel_sidebar = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmd_Employees = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel_topbar = New System.Windows.Forms.Panel()
        Me.panel_topBar_navigation = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_Refresh = New System.Windows.Forms.Button()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmd_New = New System.Windows.Forms.Button()
        Me.cmd_Search = New System.Windows.Forms.Button()
        Me.cmd_View = New System.Windows.Forms.Button()
        Me.cmd_Delete = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel_Border = New System.Windows.Forms.Panel()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_topbar.SuspendLayout()
        Me.panel_topBar_navigation.SuspendLayout()
        Me.Panel_Border.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.panel_sidebar)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.cmd_Employees)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 761)
        Me.Panel1.TabIndex = 0
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.ImageKey = "performance.png"
        Me.Button9.ImageList = Me.ImageList1
        Me.Button9.Location = New System.Drawing.Point(10, 182)
        Me.Button9.Name = "Button9"
        Me.Button9.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Button9.Size = New System.Drawing.Size(156, 41)
        Me.Button9.TabIndex = 1
        Me.Button9.Text = "          Dashboard"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "employees.png")
        Me.ImageList1.Images.SetKeyName(1, "statistics.png")
        Me.ImageList1.Images.SetKeyName(2, "priority.png")
        Me.ImageList1.Images.SetKeyName(3, "clock.png")
        Me.ImageList1.Images.SetKeyName(4, "transaction.png")
        Me.ImageList1.Images.SetKeyName(5, "money-bag.png")
        Me.ImageList1.Images.SetKeyName(6, "compensation.png")
        Me.ImageList1.Images.SetKeyName(7, "performance.png")
        Me.ImageList1.Images.SetKeyName(8, "calendar.png")
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.ImageKey = "statistics.png"
        Me.Button8.ImageList = Me.ImageList1
        Me.Button8.Location = New System.Drawing.Point(10, 558)
        Me.Button8.Name = "Button8"
        Me.Button8.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Button8.Size = New System.Drawing.Size(156, 41)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "          Reports"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.ImageKey = "priority.png"
        Me.Button7.ImageList = Me.ImageList1
        Me.Button7.Location = New System.Drawing.Point(10, 511)
        Me.Button7.Name = "Button7"
        Me.Button7.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Button7.Size = New System.Drawing.Size(156, 41)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "          Evaluation"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.ImageKey = "calendar.png"
        Me.Button6.ImageList = Me.ImageList1
        Me.Button6.Location = New System.Drawing.Point(10, 464)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(156, 41)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "          Leaves"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.ImageKey = "transaction.png"
        Me.Button5.ImageList = Me.ImageList1
        Me.Button5.Location = New System.Drawing.Point(10, 417)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(156, 41)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "          Adjustments"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.ImageKey = "clock.png"
        Me.Button4.ImageList = Me.ImageList1
        Me.Button4.Location = New System.Drawing.Point(10, 276)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(156, 41)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "          Attendance"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'panel_sidebar
        '
        Me.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_sidebar.Location = New System.Drawing.Point(0, 639)
        Me.panel_sidebar.Name = "panel_sidebar"
        Me.panel_sidebar.Size = New System.Drawing.Size(174, 122)
        Me.panel_sidebar.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImageKey = "money-bag.png"
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(10, 370)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(156, 41)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "          Loans"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageKey = "compensation.png"
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(10, 323)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(156, 41)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "          Payroll"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmd_Employees
        '
        Me.cmd_Employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmd_Employees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Employees.ImageKey = "employees.png"
        Me.cmd_Employees.ImageList = Me.ImageList1
        Me.cmd_Employees.Location = New System.Drawing.Point(10, 229)
        Me.cmd_Employees.Name = "cmd_Employees"
        Me.cmd_Employees.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmd_Employees.Size = New System.Drawing.Size(156, 41)
        Me.cmd_Employees.TabIndex = 2
        Me.cmd_Employees.Text = "          Employees"
        Me.cmd_Employees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Employees.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panel_topbar
        '
        Me.panel_topbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.panel_topbar.Controls.Add(Me.panel_topBar_navigation)
        Me.panel_topbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_topbar.Location = New System.Drawing.Point(174, 0)
        Me.panel_topbar.Name = "panel_topbar"
        Me.panel_topbar.Size = New System.Drawing.Size(1035, 63)
        Me.panel_topbar.TabIndex = 1
        '
        'panel_topBar_navigation
        '
        Me.panel_topBar_navigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.panel_topBar_navigation.Controls.Add(Me.Label1)
        Me.panel_topBar_navigation.Controls.Add(Me.cmd_Refresh)
        Me.panel_topBar_navigation.Controls.Add(Me.cmd_New)
        Me.panel_topBar_navigation.Controls.Add(Me.cmd_Search)
        Me.panel_topBar_navigation.Controls.Add(Me.cmd_View)
        Me.panel_topBar_navigation.Controls.Add(Me.cmd_Delete)
        Me.panel_topBar_navigation.Location = New System.Drawing.Point(236, 6)
        Me.panel_topBar_navigation.Name = "panel_topBar_navigation"
        Me.panel_topBar_navigation.Size = New System.Drawing.Size(563, 50)
        Me.panel_topBar_navigation.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(329, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "|"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmd_Refresh
        '
        Me.cmd_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_Refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.cmd_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_Refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Refresh.ImageKey = "loop.png"
        Me.cmd_Refresh.ImageList = Me.ImageList2
        Me.cmd_Refresh.Location = New System.Drawing.Point(455, 5)
        Me.cmd_Refresh.Name = "cmd_Refresh"
        Me.cmd_Refresh.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmd_Refresh.Size = New System.Drawing.Size(104, 38)
        Me.cmd_Refresh.TabIndex = 5
        Me.cmd_Refresh.Text = "Refresh"
        Me.cmd_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_Refresh.UseVisualStyleBackColor = True
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "employees.png")
        Me.ImageList2.Images.SetKeyName(1, "loop.png")
        Me.ImageList2.Images.SetKeyName(2, "search.png")
        Me.ImageList2.Images.SetKeyName(3, "trash.png")
        Me.ImageList2.Images.SetKeyName(4, "filter.png")
        Me.ImageList2.Images.SetKeyName(5, "new.png")
        '
        'cmd_New
        '
        Me.cmd_New.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_New.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.cmd_New.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_New.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_New.ImageKey = "new.png"
        Me.cmd_New.ImageList = Me.ImageList2
        Me.cmd_New.Location = New System.Drawing.Point(3, 5)
        Me.cmd_New.Name = "cmd_New"
        Me.cmd_New.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmd_New.Size = New System.Drawing.Size(104, 38)
        Me.cmd_New.TabIndex = 1
        Me.cmd_New.Text = "  New"
        Me.cmd_New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_New.UseVisualStyleBackColor = True
        '
        'cmd_Search
        '
        Me.cmd_Search.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.cmd_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Search.ImageKey = "search.png"
        Me.cmd_Search.ImageList = Me.ImageList2
        Me.cmd_Search.Location = New System.Drawing.Point(345, 5)
        Me.cmd_Search.Name = "cmd_Search"
        Me.cmd_Search.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmd_Search.Size = New System.Drawing.Size(104, 38)
        Me.cmd_Search.TabIndex = 4
        Me.cmd_Search.Text = " Search"
        Me.cmd_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_Search.UseVisualStyleBackColor = True
        '
        'cmd_View
        '
        Me.cmd_View.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_View.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.cmd_View.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_View.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_View.ImageKey = "filter.png"
        Me.cmd_View.ImageList = Me.ImageList2
        Me.cmd_View.Location = New System.Drawing.Point(113, 5)
        Me.cmd_View.Name = "cmd_View"
        Me.cmd_View.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmd_View.Size = New System.Drawing.Size(104, 38)
        Me.cmd_View.TabIndex = 2
        Me.cmd_View.Text = "   View"
        Me.cmd_View.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_View.UseVisualStyleBackColor = True
        '
        'cmd_Delete
        '
        Me.cmd_Delete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.cmd_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Delete.ImageKey = "trash.png"
        Me.cmd_Delete.ImageList = Me.ImageList2
        Me.cmd_Delete.Location = New System.Drawing.Point(223, 5)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmd_Delete.Size = New System.Drawing.Size(104, 38)
        Me.cmd_Delete.TabIndex = 3
        Me.cmd_Delete.Text = "  Delete"
        Me.cmd_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_Delete.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(174, 741)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1035, 20)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1189, 63)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(20, 678)
        Me.Panel4.TabIndex = 3
        '
        'Panel_Border
        '
        Me.Panel_Border.BackColor = System.Drawing.Color.White
        Me.Panel_Border.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Border.Controls.Add(Me.mainPanel)
        Me.Panel_Border.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Border.Location = New System.Drawing.Point(174, 63)
        Me.Panel_Border.Name = "Panel_Border"
        Me.Panel_Border.Padding = New System.Windows.Forms.Padding(15)
        Me.Panel_Border.Size = New System.Drawing.Size(1015, 678)
        Me.Panel_Border.TabIndex = 4
        '
        'mainPanel
        '
        Me.mainPanel.BackColor = System.Drawing.Color.White
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(15, 15)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(985, 648)
        Me.mainPanel.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1209, 761)
        Me.Controls.Add(Me.Panel_Border)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panel_topbar)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(800, 800)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Harmony"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_topbar.ResumeLayout(False)
        Me.panel_topBar_navigation.ResumeLayout(False)
        Me.panel_topBar_navigation.PerformLayout()
        Me.Panel_Border.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents panel_topbar As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmd_Employees As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents panel_topBar_navigation As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_Refresh As System.Windows.Forms.Button
    Friend WithEvents cmd_New As System.Windows.Forms.Button
    Friend WithEvents cmd_Search As System.Windows.Forms.Button
    Friend WithEvents cmd_View As System.Windows.Forms.Button
    Friend WithEvents cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel_Border As System.Windows.Forms.Panel
    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents panel_sidebar As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
