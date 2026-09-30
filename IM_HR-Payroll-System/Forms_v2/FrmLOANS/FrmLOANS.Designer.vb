<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLOANS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLOANS))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_panel = New System.Windows.Forms.Panel()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.dt_toSched = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_fromSched = New System.Windows.Forms.DateTimePicker()
        Me.cb_paymentSchedule = New System.Windows.Forms.CheckBox()
        Me.dt_toLoan = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_fromLoan = New System.Windows.Forms.DateTimePicker()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.cb_status = New System.Windows.Forms.CheckBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.cb_loanType = New System.Windows.Forms.CheckBox()
        Me.txt_reason = New System.Windows.Forms.TextBox()
        Me.cb_loanReason = New System.Windows.Forms.CheckBox()
        Me.cb_loanDate = New System.Windows.Forms.CheckBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.cb_name = New System.Windows.Forms.CheckBox()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.cb_employeeID = New System.Windows.Forms.CheckBox()
        Me.lst_loans = New System.Windows.Forms.ListView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.dgv_panel.SuspendLayout()
        Me.grpFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 72)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(68, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Loans"
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgv_panel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(968, 539)
        Me.Panel2.TabIndex = 2
        '
        'dgv_panel
        '
        Me.dgv_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.dgv_panel.Controls.Add(Me.grpFilter)
        Me.dgv_panel.Controls.Add(Me.lst_loans)
        Me.dgv_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_panel.Location = New System.Drawing.Point(10, 10)
        Me.dgv_panel.Name = "dgv_panel"
        Me.dgv_panel.Padding = New System.Windows.Forms.Padding(5)
        Me.dgv_panel.Size = New System.Drawing.Size(948, 519)
        Me.dgv_panel.TabIndex = 706
        '
        'grpFilter
        '
        Me.grpFilter.Controls.Add(Me.dt_toSched)
        Me.grpFilter.Controls.Add(Me.Label3)
        Me.grpFilter.Controls.Add(Me.dt_fromSched)
        Me.grpFilter.Controls.Add(Me.cb_paymentSchedule)
        Me.grpFilter.Controls.Add(Me.dt_toLoan)
        Me.grpFilter.Controls.Add(Me.Label2)
        Me.grpFilter.Controls.Add(Me.dt_fromLoan)
        Me.grpFilter.Controls.Add(Me.cmb_status)
        Me.grpFilter.Controls.Add(Me.cb_status)
        Me.grpFilter.Controls.Add(Me.btn_submit)
        Me.grpFilter.Controls.Add(Me.btn_cancel)
        Me.grpFilter.Controls.Add(Me.cmb_type)
        Me.grpFilter.Controls.Add(Me.cb_loanType)
        Me.grpFilter.Controls.Add(Me.txt_reason)
        Me.grpFilter.Controls.Add(Me.cb_loanReason)
        Me.grpFilter.Controls.Add(Me.cb_loanDate)
        Me.grpFilter.Controls.Add(Me.txt_name)
        Me.grpFilter.Controls.Add(Me.cb_name)
        Me.grpFilter.Controls.Add(Me.txt_employeeID)
        Me.grpFilter.Controls.Add(Me.cb_employeeID)
        Me.grpFilter.Location = New System.Drawing.Point(269, 103)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(411, 276)
        Me.grpFilter.TabIndex = 706
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Search"
        Me.grpFilter.Visible = False
        '
        'dt_toSched
        '
        Me.dt_toSched.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_toSched.Location = New System.Drawing.Point(300, 107)
        Me.dt_toSched.Name = "dt_toSched"
        Me.dt_toSched.Size = New System.Drawing.Size(101, 23)
        Me.dt_toSched.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(274, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "to"
        '
        'dt_fromSched
        '
        Me.dt_fromSched.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fromSched.Location = New System.Drawing.Point(170, 107)
        Me.dt_fromSched.Name = "dt_fromSched"
        Me.dt_fromSched.Size = New System.Drawing.Size(101, 23)
        Me.dt_fromSched.TabIndex = 22
        '
        'cb_paymentSchedule
        '
        Me.cb_paymentSchedule.AutoSize = True
        Me.cb_paymentSchedule.Location = New System.Drawing.Point(15, 109)
        Me.cb_paymentSchedule.Name = "cb_paymentSchedule"
        Me.cb_paymentSchedule.Size = New System.Drawing.Size(145, 21)
        Me.cb_paymentSchedule.TabIndex = 21
        Me.cb_paymentSchedule.Text = "Payment Schedule"
        Me.cb_paymentSchedule.UseVisualStyleBackColor = True
        '
        'dt_toLoan
        '
        Me.dt_toLoan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_toLoan.Location = New System.Drawing.Point(300, 78)
        Me.dt_toLoan.Name = "dt_toLoan"
        Me.dt_toLoan.Size = New System.Drawing.Size(101, 23)
        Me.dt_toLoan.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "to"
        '
        'dt_fromLoan
        '
        Me.dt_fromLoan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fromLoan.Location = New System.Drawing.Point(170, 78)
        Me.dt_fromLoan.Name = "dt_fromLoan"
        Me.dt_fromLoan.Size = New System.Drawing.Size(101, 23)
        Me.dt_fromLoan.TabIndex = 18
        '
        'cmb_status
        '
        Me.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"Active", "Paid"})
        Me.cmb_status.Location = New System.Drawing.Point(170, 195)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(113, 24)
        Me.cmb_status.TabIndex = 17
        '
        'cb_status
        '
        Me.cb_status.AutoSize = True
        Me.cb_status.Location = New System.Drawing.Point(14, 195)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(67, 21)
        Me.cb_status.TabIndex = 16
        Me.cb_status.Text = "Status"
        Me.cb_status.UseVisualStyleBackColor = True
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(225, 234)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(85, 30)
        Me.btn_submit.TabIndex = 15
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(316, 234)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(85, 30)
        Me.btn_cancel.TabIndex = 14
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'cmb_type
        '
        Me.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(170, 165)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(179, 24)
        Me.cmb_type.TabIndex = 13
        '
        'cb_loanType
        '
        Me.cb_loanType.AutoSize = True
        Me.cb_loanType.Location = New System.Drawing.Point(14, 165)
        Me.cb_loanType.Name = "cb_loanType"
        Me.cb_loanType.Size = New System.Drawing.Size(95, 21)
        Me.cb_loanType.TabIndex = 12
        Me.cb_loanType.Text = "Loan Type"
        Me.cb_loanType.UseVisualStyleBackColor = True
        '
        'txt_reason
        '
        Me.txt_reason.Location = New System.Drawing.Point(170, 136)
        Me.txt_reason.Name = "txt_reason"
        Me.txt_reason.Size = New System.Drawing.Size(148, 23)
        Me.txt_reason.TabIndex = 11
        '
        'cb_loanReason
        '
        Me.cb_loanReason.AutoSize = True
        Me.cb_loanReason.Location = New System.Drawing.Point(15, 138)
        Me.cb_loanReason.Name = "cb_loanReason"
        Me.cb_loanReason.Size = New System.Drawing.Size(112, 21)
        Me.cb_loanReason.TabIndex = 10
        Me.cb_loanReason.Text = "Loan Reason"
        Me.cb_loanReason.UseVisualStyleBackColor = True
        '
        'cb_loanDate
        '
        Me.cb_loanDate.AutoSize = True
        Me.cb_loanDate.Location = New System.Drawing.Point(15, 80)
        Me.cb_loanDate.Name = "cb_loanDate"
        Me.cb_loanDate.Size = New System.Drawing.Size(93, 21)
        Me.cb_loanDate.TabIndex = 8
        Me.cb_loanDate.Text = "Loan Date"
        Me.cb_loanDate.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(170, 49)
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
        Me.txt_employeeID.Location = New System.Drawing.Point(170, 20)
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
        'lst_loans
        '
        Me.lst_loans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_loans.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lst_loans.FullRowSelect = True
        Me.lst_loans.GridLines = True
        Me.lst_loans.Location = New System.Drawing.Point(5, 5)
        Me.lst_loans.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_loans.Name = "lst_loans"
        Me.lst_loans.Size = New System.Drawing.Size(938, 509)
        Me.lst_loans.TabIndex = 707
        Me.lst_loans.UseCompatibleStateImageBehavior = False
        Me.lst_loans.View = System.Windows.Forms.View.Details
        '
        'FrmLOANS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(968, 611)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmLOANS"
        Me.Text = "Loans"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.dgv_panel.ResumeLayout(False)
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgv_panel As System.Windows.Forms.Panel
    Friend WithEvents grpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents dt_toSched As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_fromSched As System.Windows.Forms.DateTimePicker
    Friend WithEvents cb_paymentSchedule As System.Windows.Forms.CheckBox
    Friend WithEvents dt_toLoan As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt_fromLoan As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_status As System.Windows.Forms.ComboBox
    Friend WithEvents cb_status As System.Windows.Forms.CheckBox
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents cmb_type As System.Windows.Forms.ComboBox
    Friend WithEvents cb_loanType As System.Windows.Forms.CheckBox
    Friend WithEvents txt_reason As System.Windows.Forms.TextBox
    Friend WithEvents cb_loanReason As System.Windows.Forms.CheckBox
    Friend WithEvents cb_loanDate As System.Windows.Forms.CheckBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents cb_name As System.Windows.Forms.CheckBox
    Friend WithEvents txt_employeeID As System.Windows.Forms.TextBox
    Friend WithEvents cb_employeeID As System.Windows.Forms.CheckBox
    Friend WithEvents lst_loans As System.Windows.Forms.ListView
End Class
