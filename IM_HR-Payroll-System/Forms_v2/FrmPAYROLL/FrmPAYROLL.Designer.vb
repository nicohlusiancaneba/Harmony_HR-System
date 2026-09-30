<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPAYROLL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPAYROLL))
        Me.lst_payroll = New System.Windows.Forms.ListView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_panel = New System.Windows.Forms.Panel()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.txt_approver = New System.Windows.Forms.TextBox()
        Me.dt_toCutoff = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_fromCutoff = New System.Windows.Forms.DateTimePicker()
        Me.cb_cutoffPeriod = New System.Windows.Forms.CheckBox()
        Me.dt_toPayroll = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_fromPayroll = New System.Windows.Forms.DateTimePicker()
        Me.cmb_approved = New System.Windows.Forms.ComboBox()
        Me.cb_approved = New System.Windows.Forms.CheckBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.cb_approver = New System.Windows.Forms.CheckBox()
        Me.txt_encoder = New System.Windows.Forms.TextBox()
        Me.cb_encoder = New System.Windows.Forms.CheckBox()
        Me.cb_payrollDate = New System.Windows.Forms.CheckBox()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.cb_remarks = New System.Windows.Forms.CheckBox()
        Me.txt_payrollID = New System.Windows.Forms.TextBox()
        Me.cb_payrollID = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cb_type = New System.Windows.Forms.CheckBox()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.cmb_monthApplicable = New System.Windows.Forms.ComboBox()
        Me.cb_monthApplicable = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dgv_panel.SuspendLayout()
        Me.grpFilter.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_payroll
        '
        Me.lst_payroll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_payroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_payroll.FullRowSelect = True
        Me.lst_payroll.GridLines = True
        Me.lst_payroll.Location = New System.Drawing.Point(5, 5)
        Me.lst_payroll.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_payroll.Name = "lst_payroll"
        Me.lst_payroll.Size = New System.Drawing.Size(759, 432)
        Me.lst_payroll.TabIndex = 15
        Me.lst_payroll.UseCompatibleStateImageBehavior = False
        Me.lst_payroll.View = System.Windows.Forms.View.Details
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 72)
        Me.Panel1.TabIndex = 24
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(68, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payroll"
        '
        'dgv_panel
        '
        Me.dgv_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.dgv_panel.Controls.Add(Me.grpFilter)
        Me.dgv_panel.Controls.Add(Me.lst_payroll)
        Me.dgv_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_panel.Location = New System.Drawing.Point(10, 10)
        Me.dgv_panel.Name = "dgv_panel"
        Me.dgv_panel.Padding = New System.Windows.Forms.Padding(5)
        Me.dgv_panel.Size = New System.Drawing.Size(769, 442)
        Me.dgv_panel.TabIndex = 706
        '
        'grpFilter
        '
        Me.grpFilter.Controls.Add(Me.cmb_monthApplicable)
        Me.grpFilter.Controls.Add(Me.cb_monthApplicable)
        Me.grpFilter.Controls.Add(Me.cmb_type)
        Me.grpFilter.Controls.Add(Me.cb_type)
        Me.grpFilter.Controls.Add(Me.txt_approver)
        Me.grpFilter.Controls.Add(Me.dt_toCutoff)
        Me.grpFilter.Controls.Add(Me.Label3)
        Me.grpFilter.Controls.Add(Me.dt_fromCutoff)
        Me.grpFilter.Controls.Add(Me.cb_cutoffPeriod)
        Me.grpFilter.Controls.Add(Me.dt_toPayroll)
        Me.grpFilter.Controls.Add(Me.Label2)
        Me.grpFilter.Controls.Add(Me.dt_fromPayroll)
        Me.grpFilter.Controls.Add(Me.cmb_approved)
        Me.grpFilter.Controls.Add(Me.cb_approved)
        Me.grpFilter.Controls.Add(Me.btn_submit)
        Me.grpFilter.Controls.Add(Me.btn_cancel)
        Me.grpFilter.Controls.Add(Me.cb_approver)
        Me.grpFilter.Controls.Add(Me.txt_encoder)
        Me.grpFilter.Controls.Add(Me.cb_encoder)
        Me.grpFilter.Controls.Add(Me.cb_payrollDate)
        Me.grpFilter.Controls.Add(Me.txt_remarks)
        Me.grpFilter.Controls.Add(Me.cb_remarks)
        Me.grpFilter.Controls.Add(Me.txt_payrollID)
        Me.grpFilter.Controls.Add(Me.cb_payrollID)
        Me.grpFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.grpFilter.Location = New System.Drawing.Point(186, 50)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(391, 338)
        Me.grpFilter.TabIndex = 706
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Search"
        Me.grpFilter.Visible = False
        '
        'txt_approver
        '
        Me.txt_approver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_approver.Location = New System.Drawing.Point(151, 226)
        Me.txt_approver.Name = "txt_approver"
        Me.txt_approver.Size = New System.Drawing.Size(148, 23)
        Me.txt_approver.TabIndex = 25
        '
        'dt_toCutoff
        '
        Me.dt_toCutoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_toCutoff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_toCutoff.Location = New System.Drawing.Point(281, 168)
        Me.dt_toCutoff.Name = "dt_toCutoff"
        Me.dt_toCutoff.Size = New System.Drawing.Size(101, 23)
        Me.dt_toCutoff.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(255, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "to"
        '
        'dt_fromCutoff
        '
        Me.dt_fromCutoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_fromCutoff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fromCutoff.Location = New System.Drawing.Point(151, 168)
        Me.dt_fromCutoff.Name = "dt_fromCutoff"
        Me.dt_fromCutoff.Size = New System.Drawing.Size(101, 23)
        Me.dt_fromCutoff.TabIndex = 22
        '
        'cb_cutoffPeriod
        '
        Me.cb_cutoffPeriod.AutoSize = True
        Me.cb_cutoffPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_cutoffPeriod.Location = New System.Drawing.Point(15, 170)
        Me.cb_cutoffPeriod.Name = "cb_cutoffPeriod"
        Me.cb_cutoffPeriod.Size = New System.Drawing.Size(109, 21)
        Me.cb_cutoffPeriod.TabIndex = 21
        Me.cb_cutoffPeriod.Text = "Cutoff Period"
        Me.cb_cutoffPeriod.UseVisualStyleBackColor = True
        '
        'dt_toPayroll
        '
        Me.dt_toPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_toPayroll.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_toPayroll.Location = New System.Drawing.Point(281, 139)
        Me.dt_toPayroll.Name = "dt_toPayroll"
        Me.dt_toPayroll.Size = New System.Drawing.Size(101, 23)
        Me.dt_toPayroll.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(255, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "to"
        '
        'dt_fromPayroll
        '
        Me.dt_fromPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_fromPayroll.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fromPayroll.Location = New System.Drawing.Point(151, 139)
        Me.dt_fromPayroll.Name = "dt_fromPayroll"
        Me.dt_fromPayroll.Size = New System.Drawing.Size(101, 23)
        Me.dt_fromPayroll.TabIndex = 18
        '
        'cmb_approved
        '
        Me.cmb_approved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_approved.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_approved.FormattingEnabled = True
        Me.cmb_approved.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb_approved.Location = New System.Drawing.Point(151, 256)
        Me.cmb_approved.Name = "cmb_approved"
        Me.cmb_approved.Size = New System.Drawing.Size(54, 24)
        Me.cmb_approved.TabIndex = 17
        '
        'cb_approved
        '
        Me.cb_approved.AutoSize = True
        Me.cb_approved.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_approved.Location = New System.Drawing.Point(14, 259)
        Me.cb_approved.Name = "cb_approved"
        Me.cb_approved.Size = New System.Drawing.Size(96, 21)
        Me.cb_approved.TabIndex = 16
        Me.cb_approved.Text = "Approved?"
        Me.cb_approved.UseVisualStyleBackColor = True
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(206, 298)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(85, 30)
        Me.btn_submit.TabIndex = 15
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(297, 298)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(85, 30)
        Me.btn_cancel.TabIndex = 14
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'cb_approver
        '
        Me.cb_approver.AutoSize = True
        Me.cb_approver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_approver.Location = New System.Drawing.Point(14, 229)
        Me.cb_approver.Name = "cb_approver"
        Me.cb_approver.Size = New System.Drawing.Size(107, 21)
        Me.cb_approver.TabIndex = 12
        Me.cb_approver.Text = "Approved by"
        Me.cb_approver.UseVisualStyleBackColor = True
        '
        'txt_encoder
        '
        Me.txt_encoder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_encoder.Location = New System.Drawing.Point(151, 197)
        Me.txt_encoder.Name = "txt_encoder"
        Me.txt_encoder.Size = New System.Drawing.Size(148, 23)
        Me.txt_encoder.TabIndex = 11
        '
        'cb_encoder
        '
        Me.cb_encoder.AutoSize = True
        Me.cb_encoder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_encoder.Location = New System.Drawing.Point(15, 199)
        Me.cb_encoder.Name = "cb_encoder"
        Me.cb_encoder.Size = New System.Drawing.Size(102, 21)
        Me.cb_encoder.TabIndex = 10
        Me.cb_encoder.Text = "Encoded by"
        Me.cb_encoder.UseVisualStyleBackColor = True
        '
        'cb_payrollDate
        '
        Me.cb_payrollDate.AutoSize = True
        Me.cb_payrollDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_payrollDate.Location = New System.Drawing.Point(15, 141)
        Me.cb_payrollDate.Name = "cb_payrollDate"
        Me.cb_payrollDate.Size = New System.Drawing.Size(104, 21)
        Me.cb_payrollDate.TabIndex = 8
        Me.cb_payrollDate.Text = "Payroll Date"
        Me.cb_payrollDate.UseVisualStyleBackColor = True
        '
        'txt_remarks
        '
        Me.txt_remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_remarks.Location = New System.Drawing.Point(151, 49)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(179, 23)
        Me.txt_remarks.TabIndex = 3
        '
        'cb_remarks
        '
        Me.cb_remarks.AutoSize = True
        Me.cb_remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_remarks.Location = New System.Drawing.Point(15, 52)
        Me.cb_remarks.Name = "cb_remarks"
        Me.cb_remarks.Size = New System.Drawing.Size(94, 21)
        Me.cb_remarks.TabIndex = 2
        Me.cb_remarks.Text = "Particulars"
        Me.cb_remarks.UseVisualStyleBackColor = True
        '
        'txt_payrollID
        '
        Me.txt_payrollID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_payrollID.Location = New System.Drawing.Point(151, 20)
        Me.txt_payrollID.Name = "txt_payrollID"
        Me.txt_payrollID.Size = New System.Drawing.Size(82, 23)
        Me.txt_payrollID.TabIndex = 1
        '
        'cb_payrollID
        '
        Me.cb_payrollID.AutoSize = True
        Me.cb_payrollID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_payrollID.Location = New System.Drawing.Point(15, 22)
        Me.cb_payrollID.Name = "cb_payrollID"
        Me.cb_payrollID.Size = New System.Drawing.Size(87, 21)
        Me.cb_payrollID.TabIndex = 0
        Me.cb_payrollID.Text = "Payroll ID"
        Me.cb_payrollID.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgv_panel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Panel2.Location = New System.Drawing.Point(0, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(789, 462)
        Me.Panel2.TabIndex = 26
        '
        'cb_type
        '
        Me.cb_type.AutoSize = True
        Me.cb_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_type.Location = New System.Drawing.Point(15, 80)
        Me.cb_type.Name = "cb_type"
        Me.cb_type.Size = New System.Drawing.Size(59, 21)
        Me.cb_type.TabIndex = 26
        Me.cb_type.Text = "Type"
        Me.cb_type.UseVisualStyleBackColor = True
        '
        'cmb_type
        '
        Me.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Items.AddRange(New Object() {"Bonus", "Incentive", "Monthly", "Weekly", "Others"})
        Me.cmb_type.Location = New System.Drawing.Point(151, 79)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(101, 24)
        Me.cmb_type.TabIndex = 27
        '
        'cmb_monthApplicable
        '
        Me.cmb_monthApplicable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_monthApplicable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_monthApplicable.FormattingEnabled = True
        Me.cmb_monthApplicable.Items.AddRange(New Object() {"Bonus", "Incentive", "Monthly", "Weekly", "Others"})
        Me.cmb_monthApplicable.Location = New System.Drawing.Point(151, 109)
        Me.cmb_monthApplicable.Name = "cmb_monthApplicable"
        Me.cmb_monthApplicable.Size = New System.Drawing.Size(134, 24)
        Me.cmb_monthApplicable.TabIndex = 29
        '
        'cb_monthApplicable
        '
        Me.cb_monthApplicable.AutoSize = True
        Me.cb_monthApplicable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_monthApplicable.Location = New System.Drawing.Point(15, 110)
        Me.cb_monthApplicable.Name = "cb_monthApplicable"
        Me.cb_monthApplicable.Size = New System.Drawing.Size(135, 21)
        Me.cb_monthApplicable.TabIndex = 28
        Me.cb_monthApplicable.Text = "Month Applicable"
        Me.cb_monthApplicable.UseVisualStyleBackColor = True
        '
        'FrmPAYROLL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(789, 534)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmPAYROLL"
        Me.Text = "Payroll"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dgv_panel.ResumeLayout(False)
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lst_payroll As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_panel As System.Windows.Forms.Panel
    Friend WithEvents grpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents dt_toCutoff As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_fromCutoff As System.Windows.Forms.DateTimePicker
    Friend WithEvents cb_cutoffPeriod As System.Windows.Forms.CheckBox
    Friend WithEvents dt_toPayroll As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt_fromPayroll As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_approved As System.Windows.Forms.ComboBox
    Friend WithEvents cb_approved As System.Windows.Forms.CheckBox
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents cb_approver As System.Windows.Forms.CheckBox
    Friend WithEvents txt_encoder As System.Windows.Forms.TextBox
    Friend WithEvents cb_encoder As System.Windows.Forms.CheckBox
    Friend WithEvents cb_payrollDate As System.Windows.Forms.CheckBox
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents cb_remarks As System.Windows.Forms.CheckBox
    Friend WithEvents txt_payrollID As System.Windows.Forms.TextBox
    Friend WithEvents cb_payrollID As System.Windows.Forms.CheckBox
    Friend WithEvents txt_approver As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmb_type As System.Windows.Forms.ComboBox
    Friend WithEvents cb_type As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_monthApplicable As System.Windows.Forms.ComboBox
    Friend WithEvents cb_monthApplicable As System.Windows.Forms.CheckBox
End Class
