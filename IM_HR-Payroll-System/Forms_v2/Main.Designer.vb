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
        Me.sidebar_panel = New System.Windows.Forms.Panel()
        Me.sidebar_images = New System.Windows.Forms.ImageList(Me.components)
        Me.panel_topbar = New System.Windows.Forms.Panel()
        Me.panel_topBar_navigation = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel_Border = New System.Windows.Forms.Panel()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_access = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_username = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cmd_Refresh = New System.Windows.Forms.Button()
        Me.cmd_New = New System.Windows.Forms.Button()
        Me.cmd_Search = New System.Windows.Forms.Button()
        Me.cmd_View = New System.Windows.Forms.Button()
        Me.cmd_Delete = New System.Windows.Forms.Button()
        Me.pic_User = New System.Windows.Forms.PictureBox()
        Me.cmd_incidents = New System.Windows.Forms.Button()
        Me.cmd_shifts = New System.Windows.Forms.Button()
        Me.cmd_dashboard = New System.Windows.Forms.Button()
        Me.cmd_attendance = New System.Windows.Forms.Button()
        Me.cmd_evaluation = New System.Windows.Forms.Button()
        Me.cmd_adjustments = New System.Windows.Forms.Button()
        Me.cmd_payroll = New System.Windows.Forms.Button()
        Me.cmd_employees = New System.Windows.Forms.Button()
        Me.cmd_loans = New System.Windows.Forms.Button()
        Me.cmd_leaves = New System.Windows.Forms.Button()
        Me.cmd_reports = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sidebar_images_selected = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.sidebar_panel.SuspendLayout()
        Me.panel_topbar.SuspendLayout()
        Me.panel_topBar_navigation.SuspendLayout()
        Me.Panel_Border.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pic_User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.sidebar_panel)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 881)
        Me.Panel1.TabIndex = 0
        '
        'sidebar_panel
        '
        Me.sidebar_panel.Controls.Add(Me.cmd_incidents)
        Me.sidebar_panel.Controls.Add(Me.cmd_shifts)
        Me.sidebar_panel.Controls.Add(Me.cmd_dashboard)
        Me.sidebar_panel.Controls.Add(Me.cmd_attendance)
        Me.sidebar_panel.Controls.Add(Me.cmd_evaluation)
        Me.sidebar_panel.Controls.Add(Me.cmd_adjustments)
        Me.sidebar_panel.Controls.Add(Me.cmd_payroll)
        Me.sidebar_panel.Controls.Add(Me.cmd_employees)
        Me.sidebar_panel.Controls.Add(Me.cmd_loans)
        Me.sidebar_panel.Controls.Add(Me.cmd_leaves)
        Me.sidebar_panel.Controls.Add(Me.cmd_reports)
        Me.sidebar_panel.Location = New System.Drawing.Point(6, 182)
        Me.sidebar_panel.Name = "sidebar_panel"
        Me.sidebar_panel.Size = New System.Drawing.Size(162, 537)
        Me.sidebar_panel.TabIndex = 4
        '
        'sidebar_images
        '
        Me.sidebar_images.ImageStream = CType(resources.GetObject("sidebar_images.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.sidebar_images.TransparentColor = System.Drawing.Color.Transparent
        Me.sidebar_images.Images.SetKeyName(0, "employees.png")
        Me.sidebar_images.Images.SetKeyName(1, "statistics.png")
        Me.sidebar_images.Images.SetKeyName(2, "priority.png")
        Me.sidebar_images.Images.SetKeyName(3, "clock.png")
        Me.sidebar_images.Images.SetKeyName(4, "transaction.png")
        Me.sidebar_images.Images.SetKeyName(5, "money-bag.png")
        Me.sidebar_images.Images.SetKeyName(6, "compensation.png")
        Me.sidebar_images.Images.SetKeyName(7, "performance.png")
        Me.sidebar_images.Images.SetKeyName(8, "calendar.png")
        Me.sidebar_images.Images.SetKeyName(9, "full-time-job.png")
        Me.sidebar_images.Images.SetKeyName(10, "working.png")
        Me.sidebar_images.Images.SetKeyName(11, "memo.png")
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(174, 861)
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
        Me.Panel4.Size = New System.Drawing.Size(20, 798)
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
        Me.Panel_Border.Size = New System.Drawing.Size(1015, 798)
        Me.Panel_Border.TabIndex = 4
        '
        'mainPanel
        '
        Me.mainPanel.BackColor = System.Drawing.Color.White
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(15, 15)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(985, 768)
        Me.mainPanel.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pic_User)
        Me.Panel2.Controls.Add(Me.lbl_access)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Controls.Add(Me.ShapeContainer2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 765)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(174, 116)
        Me.Panel2.TabIndex = 0
        '
        'lbl_access
        '
        Me.lbl_access.AutoSize = True
        Me.lbl_access.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_access.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lbl_access.Location = New System.Drawing.Point(74, 35)
        Me.lbl_access.Name = "lbl_access"
        Me.lbl_access.Size = New System.Drawing.Size(53, 17)
        Me.lbl_access.TabIndex = 12
        Me.lbl_access.Text = "Access"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_username})
        Me.MenuStrip1.Location = New System.Drawing.Point(61, 7)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(101, 25)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'logout
        '
        Me.logout.BackColor = System.Drawing.Color.White
        Me.logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.logout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.logout.Name = "logout"
        Me.logout.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.logout.Size = New System.Drawing.Size(152, 22)
        Me.logout.Text = "Logout"
        '
        'lbl_username
        '
        Me.lbl_username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_username.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.UsersToolStripMenuItem, Me.logout})
        Me.lbl_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_username.Size = New System.Drawing.Size(93, 21)
        Me.lbl_username.Text = "Username"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UsersToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'LineShape1
        '
        Me.LineShape1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.LineShape1.X1 = 9
        Me.LineShape1.X2 = 165
        Me.LineShape1.Y1 = 4
        Me.LineShape1.Y2 = 4
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(174, 116)
        Me.ShapeContainer2.TabIndex = 14
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.LineShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.SelectionColor = System.Drawing.Color.Transparent
        Me.LineShape2.X1 = 9
        Me.LineShape2.X2 = 165
        Me.LineShape2.Y1 = 61
        Me.LineShape2.Y2 = 61
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
        'pic_User
        '
        Me.pic_User.BackColor = System.Drawing.Color.Transparent
        Me.pic_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_User.Location = New System.Drawing.Point(12, 7)
        Me.pic_User.Name = "pic_User"
        Me.pic_User.Size = New System.Drawing.Size(50, 50)
        Me.pic_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_User.TabIndex = 13
        Me.pic_User.TabStop = False
        '
        'cmd_incidents
        '
        Me.cmd_incidents.FlatAppearance.BorderSize = 0
        Me.cmd_incidents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_incidents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_incidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_incidents.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmd_incidents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmd_incidents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_incidents.ImageKey = "memo.png"
        Me.cmd_incidents.ImageList = Me.sidebar_images
        Me.cmd_incidents.Location = New System.Drawing.Point(3, 379)
        Me.cmd_incidents.Name = "cmd_incidents"
        Me.cmd_incidents.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmd_incidents.Size = New System.Drawing.Size(156, 41)
        Me.cmd_incidents.TabIndex = 11
        Me.cmd_incidents.Text = "          Incidents"
        Me.cmd_incidents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_incidents.UseVisualStyleBackColor = True
        '
        'cmd_shifts
        '
        Me.cmd_shifts.FlatAppearance.BorderSize = 0
        Me.cmd_shifts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_shifts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_shifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_shifts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmd_shifts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmd_shifts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_shifts.ImageKey = "full-time-job.png"
        Me.cmd_shifts.ImageList = Me.sidebar_images
        Me.cmd_shifts.Location = New System.Drawing.Point(3, 97)
        Me.cmd_shifts.Name = "cmd_shifts"
        Me.cmd_shifts.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmd_shifts.Size = New System.Drawing.Size(156, 41)
        Me.cmd_shifts.TabIndex = 10
        Me.cmd_shifts.Text = "          Shifts"
        Me.cmd_shifts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_shifts.UseVisualStyleBackColor = True
        '
        'cmd_dashboard
        '
        Me.cmd_dashboard.FlatAppearance.BorderSize = 0
        Me.cmd_dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_dashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmd_dashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmd_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_dashboard.ImageKey = "performance.png"
        Me.cmd_dashboard.ImageList = Me.sidebar_images
        Me.cmd_dashboard.Location = New System.Drawing.Point(3, 3)
        Me.cmd_dashboard.Name = "cmd_dashboard"
        Me.cmd_dashboard.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmd_dashboard.Size = New System.Drawing.Size(156, 41)
        Me.cmd_dashboard.TabIndex = 1
        Me.cmd_dashboard.Text = "          Dashboard"
        Me.cmd_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_dashboard.UseVisualStyleBackColor = True
        '
        'cmd_attendance
        '
        Me.cmd_attendance.FlatAppearance.BorderSize = 0
        Me.cmd_attendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_attendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_attendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmd_attendance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmd_attendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_attendance.ImageKey = "clock.png"
        Me.cmd_attendance.ImageList = Me.sidebar_images
        Me.cmd_attendance.Location = New System.Drawing.Point(3, 144)
        Me.cmd_attendance.Name = "cmd_attendance"
        Me.cmd_attendance.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmd_attendance.Size = New System.Drawing.Size(156, 41)
        Me.cmd_attendance.TabIndex = 3
        Me.cmd_attendance.Text = "          Attendance"
        Me.cmd_attendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_attendance.UseVisualStyleBackColor = True
        '
        'cmd_evaluation
        '
        Me.cmd_evaluation.FlatAppearance.BorderSize = 0
        Me.cmd_evaluation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_evaluation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_evaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_evaluation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmd_evaluation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmd_evaluation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_evaluation.ImageKey = "priority.png"
        Me.cmd_evaluation.ImageList = Me.sidebar_images
        Me.cmd_evaluation.Location = New System.Drawing.Point(3, 426)
        Me.cmd_evaluation.Name = "cmd_evaluation"
        Me.cmd_evaluation.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmd_evaluation.Size = New System.Drawing.Size(156, 41)
        Me.cmd_evaluation.TabIndex = 8
        Me.cmd_evaluation.Text = "          Evaluation"
        Me.cmd_evaluation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_evaluation.UseVisualStyleBackColor = True
        '
        'cmd_adjustments
        '
        Me.cmd_adjustments.FlatAppearance.BorderSize = 0
        Me.cmd_adjustments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_adjustments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_adjustments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_adjustments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmd_adjustments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmd_adjustments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_adjustments.ImageKey = "transaction.png"
        Me.cmd_adjustments.ImageList = Me.sidebar_images
        Me.cmd_adjustments.Location = New System.Drawing.Point(3, 285)
        Me.cmd_adjustments.Name = "cmd_adjustments"
        Me.cmd_adjustments.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmd_adjustments.Size = New System.Drawing.Size(156, 41)
        Me.cmd_adjustments.TabIndex = 6
        Me.cmd_adjustments.Text = "          Adjustments"
        Me.cmd_adjustments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_adjustments.UseVisualStyleBackColor = True
        '
        'cmd_payroll
        '
        Me.cmd_payroll.FlatAppearance.BorderSize = 0
        Me.cmd_payroll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_payroll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_payroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_payroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmd_payroll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmd_payroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_payroll.ImageKey = "compensation.png"
        Me.cmd_payroll.ImageList = Me.sidebar_images
        Me.cmd_payroll.Location = New System.Drawing.Point(3, 191)
        Me.cmd_payroll.Name = "cmd_payroll"
        Me.cmd_payroll.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmd_payroll.Size = New System.Drawing.Size(156, 41)
        Me.cmd_payroll.TabIndex = 4
        Me.cmd_payroll.Text = "          Payroll"
        Me.cmd_payroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_payroll.UseVisualStyleBackColor = True
        '
        'cmd_employees
        '
        Me.cmd_employees.FlatAppearance.BorderSize = 0
        Me.cmd_employees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_employees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmd_employees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmd_employees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_employees.ImageKey = "employees.png"
        Me.cmd_employees.ImageList = Me.sidebar_images
        Me.cmd_employees.Location = New System.Drawing.Point(3, 50)
        Me.cmd_employees.Name = "cmd_employees"
        Me.cmd_employees.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmd_employees.Size = New System.Drawing.Size(156, 41)
        Me.cmd_employees.TabIndex = 2
        Me.cmd_employees.Text = "          Employees"
        Me.cmd_employees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_employees.UseVisualStyleBackColor = True
        '
        'cmd_loans
        '
        Me.cmd_loans.FlatAppearance.BorderSize = 0
        Me.cmd_loans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_loans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_loans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_loans.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmd_loans.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmd_loans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_loans.ImageKey = "money-bag.png"
        Me.cmd_loans.ImageList = Me.sidebar_images
        Me.cmd_loans.Location = New System.Drawing.Point(3, 238)
        Me.cmd_loans.Name = "cmd_loans"
        Me.cmd_loans.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmd_loans.Size = New System.Drawing.Size(156, 41)
        Me.cmd_loans.TabIndex = 5
        Me.cmd_loans.Text = "          Loans"
        Me.cmd_loans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_loans.UseVisualStyleBackColor = True
        '
        'cmd_leaves
        '
        Me.cmd_leaves.FlatAppearance.BorderSize = 0
        Me.cmd_leaves.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_leaves.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_leaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_leaves.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmd_leaves.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmd_leaves.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_leaves.ImageKey = "calendar.png"
        Me.cmd_leaves.ImageList = Me.sidebar_images
        Me.cmd_leaves.Location = New System.Drawing.Point(3, 332)
        Me.cmd_leaves.Name = "cmd_leaves"
        Me.cmd_leaves.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmd_leaves.Size = New System.Drawing.Size(156, 41)
        Me.cmd_leaves.TabIndex = 7
        Me.cmd_leaves.Text = "          Leaves"
        Me.cmd_leaves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_leaves.UseVisualStyleBackColor = True
        '
        'cmd_reports
        '
        Me.cmd_reports.FlatAppearance.BorderSize = 0
        Me.cmd_reports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_reports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmd_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_reports.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmd_reports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmd_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_reports.ImageKey = "statistics.png"
        Me.cmd_reports.ImageList = Me.sidebar_images
        Me.cmd_reports.Location = New System.Drawing.Point(3, 473)
        Me.cmd_reports.Name = "cmd_reports"
        Me.cmd_reports.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmd_reports.Size = New System.Drawing.Size(156, 41)
        Me.cmd_reports.TabIndex = 9
        Me.cmd_reports.Text = "          Reports"
        Me.cmd_reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_reports.UseVisualStyleBackColor = True
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
        'sidebar_images_selected
        '
        Me.sidebar_images_selected.ImageStream = CType(resources.GetObject("sidebar_images_selected.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.sidebar_images_selected.TransparentColor = System.Drawing.Color.Transparent
        Me.sidebar_images_selected.Images.SetKeyName(0, "calendar.png")
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1209, 881)
        Me.Controls.Add(Me.Panel_Border)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panel_topbar)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 800)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Harmony"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.sidebar_panel.ResumeLayout(False)
        Me.panel_topbar.ResumeLayout(False)
        Me.panel_topBar_navigation.ResumeLayout(False)
        Me.panel_topBar_navigation.PerformLayout()
        Me.Panel_Border.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pic_User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents panel_topbar As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmd_employees As System.Windows.Forms.Button
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
    Friend WithEvents cmd_dashboard As System.Windows.Forms.Button
    Friend WithEvents cmd_reports As System.Windows.Forms.Button
    Friend WithEvents cmd_evaluation As System.Windows.Forms.Button
    Friend WithEvents cmd_leaves As System.Windows.Forms.Button
    Friend WithEvents cmd_adjustments As System.Windows.Forms.Button
    Friend WithEvents cmd_attendance As System.Windows.Forms.Button
    Friend WithEvents sidebar_panel As System.Windows.Forms.Panel
    Friend WithEvents cmd_loans As System.Windows.Forms.Button
    Friend WithEvents cmd_payroll As System.Windows.Forms.Button
    Public WithEvents sidebar_images As System.Windows.Forms.ImageList
    Friend WithEvents cmd_shifts As System.Windows.Forms.Button
    Friend WithEvents cmd_incidents As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pic_User As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_access As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents lbl_username As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents sidebar_images_selected As System.Windows.Forms.ImageList
End Class
