<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmINCIDENT_DETAILS_OFFENSES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmINCIDENT_DETAILS_OFFENSES))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpOffenses = New System.Windows.Forms.GroupBox()
        Me.txt_instance = New System.Windows.Forms.TextBox()
        Me.cmb_definition = New System.Windows.Forms.ComboBox()
        Me.cmb_category = New System.Windows.Forms.ComboBox()
        Me.txt_class = New System.Windows.Forms.TextBox()
        Me.cmb_employees = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOffenses.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_Save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.Location = New System.Drawing.Point(0, 253)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(560, 50)
        Me.Panel2.TabIndex = 41
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Cancel.Location = New System.Drawing.Point(478, 8)
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
        Me.btn_Save.Location = New System.Drawing.Point(402, 8)
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
        Me.Panel1.Size = New System.Drawing.Size(560, 50)
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
        Me.Label2.Size = New System.Drawing.Size(346, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Incident Details - Offense"
        '
        'grpOffenses
        '
        Me.grpOffenses.Controls.Add(Me.txt_instance)
        Me.grpOffenses.Controls.Add(Me.cmb_definition)
        Me.grpOffenses.Controls.Add(Me.cmb_category)
        Me.grpOffenses.Controls.Add(Me.txt_class)
        Me.grpOffenses.Controls.Add(Me.cmb_employees)
        Me.grpOffenses.Controls.Add(Me.Label1)
        Me.grpOffenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.grpOffenses.Location = New System.Drawing.Point(12, 56)
        Me.grpOffenses.Name = "grpOffenses"
        Me.grpOffenses.Size = New System.Drawing.Size(536, 191)
        Me.grpOffenses.TabIndex = 42
        Me.grpOffenses.TabStop = False
        '
        'txt_instance
        '
        Me.txt_instance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_instance.Location = New System.Drawing.Point(96, 154)
        Me.txt_instance.Name = "txt_instance"
        Me.txt_instance.ReadOnly = True
        Me.txt_instance.Size = New System.Drawing.Size(54, 23)
        Me.txt_instance.TabIndex = 31
        Me.txt_instance.Tag = "inputText"
        '
        'cmb_definition
        '
        Me.cmb_definition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_definition.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_definition.FormattingEnabled = True
        Me.cmb_definition.Location = New System.Drawing.Point(96, 85)
        Me.cmb_definition.Name = "cmb_definition"
        Me.cmb_definition.Size = New System.Drawing.Size(420, 24)
        Me.cmb_definition.TabIndex = 30
        '
        'cmb_category
        '
        Me.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_category.FormattingEnabled = True
        Me.cmb_category.Location = New System.Drawing.Point(96, 51)
        Me.cmb_category.Name = "cmb_category"
        Me.cmb_category.Size = New System.Drawing.Size(334, 24)
        Me.cmb_category.TabIndex = 28
        '
        'txt_class
        '
        Me.txt_class.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_class.Location = New System.Drawing.Point(96, 120)
        Me.txt_class.Name = "txt_class"
        Me.txt_class.ReadOnly = True
        Me.txt_class.Size = New System.Drawing.Size(97, 23)
        Me.txt_class.TabIndex = 25
        Me.txt_class.Tag = "inputText"
        '
        'cmb_employees
        '
        Me.cmb_employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_employees.FormattingEnabled = True
        Me.cmb_employees.Location = New System.Drawing.Point(96, 17)
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
        Me.Label1.Size = New System.Drawing.Size(78, 153)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Category :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Definition :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Class :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Instance :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmINCIDENT_DETAILS_OFFENSES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(560, 303)
        Me.Controls.Add(Me.grpOffenses)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmINCIDENT_DETAILS_OFFENSES"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Incident Details - Offense"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOffenses.ResumeLayout(False)
        Me.grpOffenses.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpOffenses As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_employees As System.Windows.Forms.ComboBox
    Friend WithEvents txt_class As System.Windows.Forms.TextBox
    Friend WithEvents cmb_category As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_definition As System.Windows.Forms.ComboBox
    Friend WithEvents txt_instance As System.Windows.Forms.TextBox
End Class
