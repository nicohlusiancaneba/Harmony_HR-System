<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmINCIDENT_DETAILS_EMPLOYEE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmINCIDENT_DETAILS_EMPLOYEE))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpEmployees = New System.Windows.Forms.GroupBox()
        Me.txt_statements = New System.Windows.Forms.TextBox()
        Me.txt_supervisor = New System.Windows.Forms.TextBox()
        Me.txt_age = New System.Windows.Forms.TextBox()
        Me.txt_tenure = New System.Windows.Forms.TextBox()
        Me.txt_department = New System.Windows.Forms.TextBox()
        Me.txt_jobTitle = New System.Windows.Forms.TextBox()
        Me.cmb_employees = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEmployees.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_Save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.Location = New System.Drawing.Point(0, 381)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 50)
        Me.Panel2.TabIndex = 41
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Cancel.Location = New System.Drawing.Point(394, 8)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_Cancel.TabIndex = 19
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Save.Location = New System.Drawing.Point(318, 8)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(70, 30)
        Me.btn_Save.TabIndex = 18
        Me.btn_Save.Text = "&Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 50)
        Me.Panel1.TabIndex = 40
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(45, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(371, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Incident Details - Employee"
        '
        'grpEmployees
        '
        Me.grpEmployees.Controls.Add(Me.txt_statements)
        Me.grpEmployees.Controls.Add(Me.txt_supervisor)
        Me.grpEmployees.Controls.Add(Me.txt_age)
        Me.grpEmployees.Controls.Add(Me.txt_tenure)
        Me.grpEmployees.Controls.Add(Me.txt_department)
        Me.grpEmployees.Controls.Add(Me.txt_jobTitle)
        Me.grpEmployees.Controls.Add(Me.cmb_employees)
        Me.grpEmployees.Controls.Add(Me.Label1)
        Me.grpEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.grpEmployees.Location = New System.Drawing.Point(12, 56)
        Me.grpEmployees.Name = "grpEmployees"
        Me.grpEmployees.Size = New System.Drawing.Size(452, 312)
        Me.grpEmployees.TabIndex = 42
        Me.grpEmployees.TabStop = False
        '
        'txt_statements
        '
        Me.txt_statements.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_statements.Location = New System.Drawing.Point(114, 221)
        Me.txt_statements.Multiline = True
        Me.txt_statements.Name = "txt_statements"
        Me.txt_statements.Size = New System.Drawing.Size(325, 81)
        Me.txt_statements.TabIndex = 27
        Me.txt_statements.Tag = "inputText"
        '
        'txt_supervisor
        '
        Me.txt_supervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_supervisor.Location = New System.Drawing.Point(114, 188)
        Me.txt_supervisor.Name = "txt_supervisor"
        Me.txt_supervisor.Size = New System.Drawing.Size(170, 23)
        Me.txt_supervisor.TabIndex = 26
        Me.txt_supervisor.Tag = "inputText"
        '
        'txt_age
        '
        Me.txt_age.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_age.Location = New System.Drawing.Point(114, 154)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.ReadOnly = True
        Me.txt_age.Size = New System.Drawing.Size(50, 23)
        Me.txt_age.TabIndex = 25
        Me.txt_age.Tag = "inputText"
        '
        'txt_tenure
        '
        Me.txt_tenure.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_tenure.Location = New System.Drawing.Point(114, 120)
        Me.txt_tenure.Name = "txt_tenure"
        Me.txt_tenure.ReadOnly = True
        Me.txt_tenure.Size = New System.Drawing.Size(170, 23)
        Me.txt_tenure.TabIndex = 24
        Me.txt_tenure.Tag = "inputText"
        '
        'txt_department
        '
        Me.txt_department.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_department.Location = New System.Drawing.Point(114, 86)
        Me.txt_department.Name = "txt_department"
        Me.txt_department.ReadOnly = True
        Me.txt_department.Size = New System.Drawing.Size(301, 23)
        Me.txt_department.TabIndex = 23
        Me.txt_department.Tag = "inputText"
        '
        'txt_jobTitle
        '
        Me.txt_jobTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_jobTitle.Location = New System.Drawing.Point(114, 51)
        Me.txt_jobTitle.Name = "txt_jobTitle"
        Me.txt_jobTitle.ReadOnly = True
        Me.txt_jobTitle.Size = New System.Drawing.Size(239, 23)
        Me.txt_jobTitle.TabIndex = 22
        Me.txt_jobTitle.Tag = "inputText"
        '
        'cmb_employees
        '
        Me.cmb_employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_employees.FormattingEnabled = True
        Me.cmb_employees.Location = New System.Drawing.Point(114, 17)
        Me.cmb_employees.Name = "cmb_employees"
        Me.cmb_employees.Size = New System.Drawing.Size(301, 24)
        Me.cmb_employees.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(15, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 221)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Job Title :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Department :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tenure :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Age :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Supervisor :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Statement(s) :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmINCIDENT_DETAILS_EMPLOYEE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(472, 431)
        Me.Controls.Add(Me.grpEmployees)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmINCIDENT_DETAILS_EMPLOYEE"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Incident Details - Employee"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEmployees.ResumeLayout(False)
        Me.grpEmployees.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpEmployees As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_employees As System.Windows.Forms.ComboBox
    Friend WithEvents txt_jobTitle As System.Windows.Forms.TextBox
    Friend WithEvents txt_statements As System.Windows.Forms.TextBox
    Friend WithEvents txt_supervisor As System.Windows.Forms.TextBox
    Friend WithEvents txt_age As System.Windows.Forms.TextBox
    Friend WithEvents txt_tenure As System.Windows.Forms.TextBox
    Friend WithEvents txt_department As System.Windows.Forms.TextBox
End Class
