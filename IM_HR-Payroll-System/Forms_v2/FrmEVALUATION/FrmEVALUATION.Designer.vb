<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEVALUATION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEVALUATION))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_panel = New System.Windows.Forms.Panel()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.cb_Validated = New System.Windows.Forms.CheckBox()
        Me.cmb_Validated = New System.Windows.Forms.ComboBox()
        Me.dt_toEval = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_fromEval = New System.Windows.Forms.DateTimePicker()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.cb_evalDate = New System.Windows.Forms.CheckBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.cb_name = New System.Windows.Forms.CheckBox()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.cb_employeeID = New System.Windows.Forms.CheckBox()
        Me.lst_evaluations = New System.Windows.Forms.ListView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.dgv_panel.SuspendLayout()
        Me.grpFilter.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(988, 72)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(68, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Evaluation"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgv_panel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(988, 554)
        Me.Panel2.TabIndex = 8
        '
        'dgv_panel
        '
        Me.dgv_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.dgv_panel.Controls.Add(Me.grpFilter)
        Me.dgv_panel.Controls.Add(Me.lst_evaluations)
        Me.dgv_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_panel.Location = New System.Drawing.Point(10, 10)
        Me.dgv_panel.Name = "dgv_panel"
        Me.dgv_panel.Padding = New System.Windows.Forms.Padding(5)
        Me.dgv_panel.Size = New System.Drawing.Size(968, 534)
        Me.dgv_panel.TabIndex = 706
        '
        'grpFilter
        '
        Me.grpFilter.Controls.Add(Me.cb_Validated)
        Me.grpFilter.Controls.Add(Me.cmb_Validated)
        Me.grpFilter.Controls.Add(Me.dt_toEval)
        Me.grpFilter.Controls.Add(Me.Label2)
        Me.grpFilter.Controls.Add(Me.dt_fromEval)
        Me.grpFilter.Controls.Add(Me.btn_submit)
        Me.grpFilter.Controls.Add(Me.btn_cancel)
        Me.grpFilter.Controls.Add(Me.cb_evalDate)
        Me.grpFilter.Controls.Add(Me.txt_name)
        Me.grpFilter.Controls.Add(Me.cb_name)
        Me.grpFilter.Controls.Add(Me.txt_employeeID)
        Me.grpFilter.Controls.Add(Me.cb_employeeID)
        Me.grpFilter.Location = New System.Drawing.Point(267, 145)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(392, 183)
        Me.grpFilter.TabIndex = 706
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Search"
        Me.grpFilter.Visible = False
        '
        'cb_Validated
        '
        Me.cb_Validated.AutoSize = True
        Me.cb_Validated.Location = New System.Drawing.Point(15, 109)
        Me.cb_Validated.Name = "cb_Validated"
        Me.cb_Validated.Size = New System.Drawing.Size(86, 21)
        Me.cb_Validated.TabIndex = 22
        Me.cb_Validated.Text = "Validated"
        Me.cb_Validated.UseVisualStyleBackColor = True
        '
        'cmb_Validated
        '
        Me.cmb_Validated.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Validated.FormattingEnabled = True
        Me.cmb_Validated.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb_Validated.Location = New System.Drawing.Point(149, 107)
        Me.cmb_Validated.Name = "cmb_Validated"
        Me.cmb_Validated.Size = New System.Drawing.Size(72, 24)
        Me.cmb_Validated.TabIndex = 21
        '
        'dt_toEval
        '
        Me.dt_toEval.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_toEval.Location = New System.Drawing.Point(278, 78)
        Me.dt_toEval.Name = "dt_toEval"
        Me.dt_toEval.Size = New System.Drawing.Size(101, 23)
        Me.dt_toEval.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(253, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "to"
        '
        'dt_fromEval
        '
        Me.dt_fromEval.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fromEval.Location = New System.Drawing.Point(149, 78)
        Me.dt_fromEval.Name = "dt_fromEval"
        Me.dt_fromEval.Size = New System.Drawing.Size(101, 23)
        Me.dt_fromEval.TabIndex = 18
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(203, 140)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(85, 30)
        Me.btn_submit.TabIndex = 15
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(294, 140)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(85, 30)
        Me.btn_cancel.TabIndex = 14
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'cb_evalDate
        '
        Me.cb_evalDate.AutoSize = True
        Me.cb_evalDate.Location = New System.Drawing.Point(15, 79)
        Me.cb_evalDate.Name = "cb_evalDate"
        Me.cb_evalDate.Size = New System.Drawing.Size(131, 21)
        Me.cb_evalDate.TabIndex = 8
        Me.cb_evalDate.Text = "Adjustment Date"
        Me.cb_evalDate.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(149, 49)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(179, 23)
        Me.txt_name.TabIndex = 3
        '
        'cb_name
        '
        Me.cb_name.AutoSize = True
        Me.cb_name.Location = New System.Drawing.Point(15, 51)
        Me.cb_name.Name = "cb_name"
        Me.cb_name.Size = New System.Drawing.Size(130, 21)
        Me.cb_name.TabIndex = 2
        Me.cb_name.Text = "Employee Name"
        Me.cb_name.UseVisualStyleBackColor = True
        '
        'txt_employeeID
        '
        Me.txt_employeeID.Location = New System.Drawing.Point(149, 20)
        Me.txt_employeeID.Name = "txt_employeeID"
        Me.txt_employeeID.Size = New System.Drawing.Size(82, 23)
        Me.txt_employeeID.TabIndex = 1
        '
        'cb_employeeID
        '
        Me.cb_employeeID.AutoSize = True
        Me.cb_employeeID.Location = New System.Drawing.Point(15, 22)
        Me.cb_employeeID.Name = "cb_employeeID"
        Me.cb_employeeID.Size = New System.Drawing.Size(106, 21)
        Me.cb_employeeID.TabIndex = 0
        Me.cb_employeeID.Text = "Employee ID"
        Me.cb_employeeID.UseVisualStyleBackColor = True
        '
        'lst_evaluations
        '
        Me.lst_evaluations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_evaluations.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lst_evaluations.FullRowSelect = True
        Me.lst_evaluations.GridLines = True
        Me.lst_evaluations.Location = New System.Drawing.Point(5, 5)
        Me.lst_evaluations.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_evaluations.Name = "lst_evaluations"
        Me.lst_evaluations.Size = New System.Drawing.Size(958, 524)
        Me.lst_evaluations.TabIndex = 707
        Me.lst_evaluations.UseCompatibleStateImageBehavior = False
        Me.lst_evaluations.View = System.Windows.Forms.View.Details
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FrmEVALUATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(988, 626)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmEVALUATION"
        Me.Text = "Evaluation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.dgv_panel.ResumeLayout(False)
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgv_panel As System.Windows.Forms.Panel
    Friend WithEvents grpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents cb_Validated As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Validated As System.Windows.Forms.ComboBox
    Friend WithEvents dt_toEval As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt_fromEval As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents cb_evalDate As System.Windows.Forms.CheckBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents cb_name As System.Windows.Forms.CheckBox
    Friend WithEvents txt_employeeID As System.Windows.Forms.TextBox
    Friend WithEvents cb_employeeID As System.Windows.Forms.CheckBox
    Friend WithEvents lst_evaluations As System.Windows.Forms.ListView
End Class
