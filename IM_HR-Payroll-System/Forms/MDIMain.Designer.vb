<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_settings = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_employees = New System.Windows.Forms.Button()
        Me.btn_loans = New System.Windows.Forms.Button()
        Me.btn_payroll = New System.Windows.Forms.Button()
        Me.btn_adjustments = New System.Windows.Forms.Button()
        Me.btn_leave = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Version = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CompanyName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.User = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_settings)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 861)
        Me.Panel1.TabIndex = 1
        '
        'btn_settings
        '
        Me.btn_settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_settings.ImageKey = "settings.png"
        Me.btn_settings.ImageList = Me.ImageList1
        Me.btn_settings.Location = New System.Drawing.Point(7, 726)
        Me.btn_settings.Name = "btn_settings"
        Me.btn_settings.Size = New System.Drawing.Size(155, 50)
        Me.btn_settings.TabIndex = 8
        Me.btn_settings.Text = "           Settings"
        Me.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_settings.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "payroll2.png")
        Me.ImageList1.Images.SetKeyName(1, "leave2.png")
        Me.ImageList1.Images.SetKeyName(2, "adjustment2.png")
        Me.ImageList1.Images.SetKeyName(3, "loan2.png")
        Me.ImageList1.Images.SetKeyName(4, "leave.png")
        Me.ImageList1.Images.SetKeyName(5, "adjustment.png")
        Me.ImageList1.Images.SetKeyName(6, "loan.png")
        Me.ImageList1.Images.SetKeyName(7, "payroll.png")
        Me.ImageList1.Images.SetKeyName(8, "employees.png")
        Me.ImageList1.Images.SetKeyName(9, "logout.png")
        Me.ImageList1.Images.SetKeyName(10, "settings.png")
        Me.ImageList1.Images.SetKeyName(11, "evaluation.png")
        Me.ImageList1.Images.SetKeyName(12, "reports.png")
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btn_employees)
        Me.Panel3.Controls.Add(Me.btn_loans)
        Me.Panel3.Controls.Add(Me.btn_payroll)
        Me.Panel3.Controls.Add(Me.btn_adjustments)
        Me.Panel3.Controls.Add(Me.btn_leave)
        Me.Panel3.Location = New System.Drawing.Point(3, 219)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(168, 433)
        Me.Panel3.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageKey = "reports.png"
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(7, 363)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 50)
        Me.Button2.TabIndex = 8
        Me.Button2.Tag = "button"
        Me.Button2.Text = "           Reports"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageKey = "evaluation.png"
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(7, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 50)
        Me.Button1.TabIndex = 6
        Me.Button1.Tag = "button"
        Me.Button1.Text = "           Evaluation"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_employees
        '
        Me.btn_employees.BackColor = System.Drawing.Color.White
        Me.btn_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_employees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_employees.ImageKey = "employees.png"
        Me.btn_employees.ImageList = Me.ImageList1
        Me.btn_employees.Location = New System.Drawing.Point(7, 3)
        Me.btn_employees.Name = "btn_employees"
        Me.btn_employees.Size = New System.Drawing.Size(155, 50)
        Me.btn_employees.TabIndex = 1
        Me.btn_employees.Tag = "button"
        Me.btn_employees.Text = "           Employees"
        Me.btn_employees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_employees.UseVisualStyleBackColor = False
        '
        'btn_loans
        '
        Me.btn_loans.BackColor = System.Drawing.Color.White
        Me.btn_loans.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_loans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_loans.ImageKey = "loan.png"
        Me.btn_loans.ImageList = Me.ImageList1
        Me.btn_loans.Location = New System.Drawing.Point(7, 123)
        Me.btn_loans.Name = "btn_loans"
        Me.btn_loans.Size = New System.Drawing.Size(155, 50)
        Me.btn_loans.TabIndex = 2
        Me.btn_loans.Tag = "button"
        Me.btn_loans.Text = "           Loans"
        Me.btn_loans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_loans.UseVisualStyleBackColor = False
        '
        'btn_payroll
        '
        Me.btn_payroll.BackColor = System.Drawing.Color.White
        Me.btn_payroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_payroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_payroll.ImageKey = "payroll.png"
        Me.btn_payroll.ImageList = Me.ImageList1
        Me.btn_payroll.Location = New System.Drawing.Point(7, 63)
        Me.btn_payroll.Name = "btn_payroll"
        Me.btn_payroll.Size = New System.Drawing.Size(155, 50)
        Me.btn_payroll.TabIndex = 1
        Me.btn_payroll.Tag = "button"
        Me.btn_payroll.Text = "           Payroll"
        Me.btn_payroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_payroll.UseVisualStyleBackColor = False
        '
        'btn_adjustments
        '
        Me.btn_adjustments.BackColor = System.Drawing.Color.White
        Me.btn_adjustments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adjustments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_adjustments.ImageKey = "adjustment.png"
        Me.btn_adjustments.ImageList = Me.ImageList1
        Me.btn_adjustments.Location = New System.Drawing.Point(7, 183)
        Me.btn_adjustments.Name = "btn_adjustments"
        Me.btn_adjustments.Size = New System.Drawing.Size(155, 50)
        Me.btn_adjustments.TabIndex = 3
        Me.btn_adjustments.Tag = "button"
        Me.btn_adjustments.Text = "           Adjustments"
        Me.btn_adjustments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_adjustments.UseVisualStyleBackColor = False
        '
        'btn_leave
        '
        Me.btn_leave.BackColor = System.Drawing.Color.White
        Me.btn_leave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_leave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_leave.ImageKey = "leave.png"
        Me.btn_leave.ImageList = Me.ImageList1
        Me.btn_leave.Location = New System.Drawing.Point(7, 243)
        Me.btn_leave.Name = "btn_leave"
        Me.btn_leave.Size = New System.Drawing.Size(155, 50)
        Me.btn_leave.TabIndex = 5
        Me.btn_leave.Tag = "button"
        Me.btn_leave.Text = "           Leave" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           Application"
        Me.btn_leave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_leave.UseVisualStyleBackColor = False
        '
        'btn_logout
        '
        Me.btn_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.ImageKey = "logout.png"
        Me.btn_logout.ImageList = Me.ImageList1
        Me.btn_logout.Location = New System.Drawing.Point(7, 782)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(155, 50)
        Me.btn_logout.TabIndex = 7
        Me.btn_logout.Text = "           Log Out"
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Harmony.My.Resources.Resources.Harmony_GIF
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.StatusStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(174, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1044, 861)
        Me.Panel2.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.Version, Me.CompanyName, Me.User})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 839)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(1044, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(144, 17)
        Me.ToolStripStatusLabel1.Text = "Powered by I.M. Solutions"
        '
        'Version
        '
        Me.Version.BackColor = System.Drawing.Color.YellowGreen
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(0, 17)
        '
        'CompanyName
        '
        Me.CompanyName.BackColor = System.Drawing.Color.LightSalmon
        Me.CompanyName.Name = "CompanyName"
        Me.CompanyName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CompanyName.Size = New System.Drawing.Size(0, 17)
        '
        'User
        '
        Me.User.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(0, 17)
        '
        'MDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 861)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MDIMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Harmony | Human Resource and Payroll Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_adjustments As System.Windows.Forms.Button
    Friend WithEvents btn_loans As System.Windows.Forms.Button
    Friend WithEvents btn_payroll As System.Windows.Forms.Button
    Friend WithEvents btn_employees As System.Windows.Forms.Button
    Friend WithEvents btn_leave As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_settings As System.Windows.Forms.Button
    Friend WithEvents CompanyName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Version As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents User As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
