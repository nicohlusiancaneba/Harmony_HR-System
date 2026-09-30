<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPAYROLL_DETAILS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPAYROLL_DETAILS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PrintPayslipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cb_Approved = New System.Windows.Forms.CheckBox()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_TotalgrossPay = New System.Windows.Forms.TextBox()
        Me.txt_TotalnetPay = New System.Windows.Forms.TextBox()
        Me.txt_totalLoansPaid = New System.Windows.Forms.TextBox()
        Me.txt_totalDeductions = New System.Windows.Forms.TextBox()
        Me.dt_payroll = New System.Windows.Forms.DateTimePicker()
        Me.rtb_remarks = New System.Windows.Forms.RichTextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.grp_Payrollpayee = New System.Windows.Forms.GroupBox()
        Me.btn_cancelSubmit = New System.Windows.Forms.Button()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.cmb_employees = New System.Windows.Forms.ComboBox()
        Me.dt_cutoffStart = New System.Windows.Forms.DateTimePicker()
        Me.dt_cutoffEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrintEmployeePayslipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToBankFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_encoder = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgv_payroll = New System.Windows.Forms.DataGridView()
        Me.Payroll_Detail_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Employee_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Employee_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Basic_Pay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Add_Pay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Gross = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Deductions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Loan_Pays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Net = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Payroll_Details = New System.Windows.Forms.GroupBox()
        Me.cmb_monthApplicable = New System.Windows.Forms.ComboBox()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.grp_Payrollpayee.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_payroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Payroll_Details.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 85)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Type : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Month Applicable :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cutoff Period :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintPayslipToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(175, 26)
        '
        'PrintPayslipToolStripMenuItem
        '
        Me.PrintPayslipToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintPayslipToolStripMenuItem.Name = "PrintPayslipToolStripMenuItem"
        Me.PrintPayslipToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PrintPayslipToolStripMenuItem.Text = "🖨️ Print Payslip"
        Me.PrintPayslipToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'cb_Approved
        '
        Me.cb_Approved.AutoSize = True
        Me.cb_Approved.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_Approved.Location = New System.Drawing.Point(826, 15)
        Me.cb_Approved.Name = "cb_Approved"
        Me.cb_Approved.Size = New System.Drawing.Size(88, 21)
        Me.cb_Approved.TabIndex = 21
        Me.cb_Approved.Text = "Approved"
        Me.cb_Approved.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(996, 11)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_Cancel.TabIndex = 23
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(920, 11)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(70, 30)
        Me.btn_Save.TabIndex = 22
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(607, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 51)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Total Deductions :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Loans Paid :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_TotalgrossPay
        '
        Me.txt_TotalgrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_TotalgrossPay.Location = New System.Drawing.Point(945, 406)
        Me.txt_TotalgrossPay.Name = "txt_TotalgrossPay"
        Me.txt_TotalgrossPay.ReadOnly = True
        Me.txt_TotalgrossPay.Size = New System.Drawing.Size(99, 23)
        Me.txt_TotalgrossPay.TabIndex = 32
        Me.txt_TotalgrossPay.Text = "0.00"
        Me.txt_TotalgrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_TotalnetPay
        '
        Me.txt_TotalnetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_TotalnetPay.Location = New System.Drawing.Point(945, 372)
        Me.txt_TotalnetPay.Name = "txt_TotalnetPay"
        Me.txt_TotalnetPay.ReadOnly = True
        Me.txt_TotalnetPay.Size = New System.Drawing.Size(99, 23)
        Me.txt_TotalnetPay.TabIndex = 33
        Me.txt_TotalnetPay.Text = "0.00"
        Me.txt_TotalnetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_totalLoansPaid
        '
        Me.txt_totalLoansPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_totalLoansPaid.Location = New System.Drawing.Point(733, 406)
        Me.txt_totalLoansPaid.Name = "txt_totalLoansPaid"
        Me.txt_totalLoansPaid.ReadOnly = True
        Me.txt_totalLoansPaid.Size = New System.Drawing.Size(99, 23)
        Me.txt_totalLoansPaid.TabIndex = 35
        Me.txt_totalLoansPaid.Text = "0.00"
        Me.txt_totalLoansPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_totalDeductions
        '
        Me.txt_totalDeductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_totalDeductions.Location = New System.Drawing.Point(733, 372)
        Me.txt_totalDeductions.Name = "txt_totalDeductions"
        Me.txt_totalDeductions.ReadOnly = True
        Me.txt_totalDeductions.Size = New System.Drawing.Size(99, 23)
        Me.txt_totalDeductions.TabIndex = 34
        Me.txt_totalDeductions.Text = "0.00"
        Me.txt_totalDeductions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dt_payroll
        '
        Me.dt_payroll.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_payroll.Enabled = False
        Me.dt_payroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_payroll.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_payroll.Location = New System.Drawing.Point(668, 14)
        Me.dt_payroll.Name = "dt_payroll"
        Me.dt_payroll.Size = New System.Drawing.Size(106, 23)
        Me.dt_payroll.TabIndex = 37
        '
        'rtb_remarks
        '
        Me.rtb_remarks.Location = New System.Drawing.Point(668, 50)
        Me.rtb_remarks.Name = "rtb_remarks"
        Me.rtb_remarks.Size = New System.Drawing.Size(376, 55)
        Me.rtb_remarks.TabIndex = 40
        Me.rtb_remarks.Text = ""
        '
        'btn_add
        '
        Me.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_add.ImageKey = "plus.png"
        Me.btn_add.Location = New System.Drawing.Point(10, 373)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 30)
        Me.btn_add.TabIndex = 39
        Me.btn_add.Text = "Add"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'grp_Payrollpayee
        '
        Me.grp_Payrollpayee.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.grp_Payrollpayee.Controls.Add(Me.btn_cancelSubmit)
        Me.grp_Payrollpayee.Controls.Add(Me.btn_submit)
        Me.grp_Payrollpayee.Controls.Add(Me.cmb_employees)
        Me.grp_Payrollpayee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.grp_Payrollpayee.Location = New System.Drawing.Point(345, 132)
        Me.grp_Payrollpayee.Name = "grp_Payrollpayee"
        Me.grp_Payrollpayee.Size = New System.Drawing.Size(262, 91)
        Me.grp_Payrollpayee.TabIndex = 41
        Me.grp_Payrollpayee.TabStop = False
        Me.grp_Payrollpayee.Text = "Select Employee"
        Me.grp_Payrollpayee.Visible = False
        '
        'btn_cancelSubmit
        '
        Me.btn_cancelSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_cancelSubmit.Location = New System.Drawing.Point(184, 52)
        Me.btn_cancelSubmit.Name = "btn_cancelSubmit"
        Me.btn_cancelSubmit.Size = New System.Drawing.Size(70, 30)
        Me.btn_cancelSubmit.TabIndex = 42
        Me.btn_cancelSubmit.Text = "&Cancel"
        Me.btn_cancelSubmit.UseVisualStyleBackColor = True
        '
        'btn_submit
        '
        Me.btn_submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_submit.Location = New System.Drawing.Point(108, 52)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(70, 30)
        Me.btn_submit.TabIndex = 23
        Me.btn_submit.Text = "&Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'cmb_employees
        '
        Me.cmb_employees.DropDownHeight = 300
        Me.cmb_employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employees.FormattingEnabled = True
        Me.cmb_employees.IntegralHeight = False
        Me.cmb_employees.Location = New System.Drawing.Point(6, 22)
        Me.cmb_employees.Name = "cmb_employees"
        Me.cmb_employees.Size = New System.Drawing.Size(248, 24)
        Me.cmb_employees.TabIndex = 1
        '
        'dt_cutoffStart
        '
        Me.dt_cutoffStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_cutoffStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_cutoffStart.Location = New System.Drawing.Point(136, 82)
        Me.dt_cutoffStart.Name = "dt_cutoffStart"
        Me.dt_cutoffStart.Size = New System.Drawing.Size(108, 23)
        Me.dt_cutoffStart.TabIndex = 42
        '
        'dt_cutoffEnd
        '
        Me.dt_cutoffEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_cutoffEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_cutoffEnd.Location = New System.Drawing.Point(273, 82)
        Me.dt_cutoffEnd.Name = "dt_cutoffEnd"
        Me.dt_cutoffEnd.Size = New System.Drawing.Size(108, 23)
        Me.dt_cutoffEnd.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(247, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 17)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "to"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintEmployeePayslipToolStripMenuItem, Me.ExportToBankFormatToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(1077, 25)
        Me.MenuStrip1.TabIndex = 45
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrintEmployeePayslipToolStripMenuItem
        '
        Me.PrintEmployeePayslipToolStripMenuItem.Name = "PrintEmployeePayslipToolStripMenuItem"
        Me.PrintEmployeePayslipToolStripMenuItem.Size = New System.Drawing.Size(114, 21)
        Me.PrintEmployeePayslipToolStripMenuItem.Text = "Print Payslip🖨️"
        '
        'ExportToBankFormatToolStripMenuItem
        '
        Me.ExportToBankFormatToolStripMenuItem.Name = "ExportToBankFormatToolStripMenuItem"
        Me.ExportToBankFormatToolStripMenuItem.Size = New System.Drawing.Size(69, 21)
        Me.ExportToBankFormatToolStripMenuItem.Text = "Export⤵️"
        '
        'lbl_encoder
        '
        Me.lbl_encoder.AutoSize = True
        Me.lbl_encoder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_encoder.Location = New System.Drawing.Point(8, 15)
        Me.lbl_encoder.Name = "lbl_encoder"
        Me.lbl_encoder.Size = New System.Drawing.Size(91, 17)
        Me.lbl_encoder.TabIndex = 46
        Me.lbl_encoder.Text = "Encoded by :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label_ID)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1077, 50)
        Me.Panel1.TabIndex = 47
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Label_ID
        '
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label_ID.Location = New System.Drawing.Point(646, 9)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(60, 31)
        Me.Label_ID.TabIndex = 3
        Me.Label_ID.Text = "ID#"
        Me.Label_ID.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(45, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 31)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Payroll Details"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_Save)
        Me.Panel2.Controls.Add(Me.cb_Approved)
        Me.Panel2.Controls.Add(Me.lbl_encoder)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.Location = New System.Drawing.Point(0, 640)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1077, 50)
        Me.Panel2.TabIndex = 48
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.grp_Payrollpayee)
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.txt_TotalgrossPay)
        Me.GroupBox1.Controls.Add(Me.txt_TotalnetPay)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_totalDeductions)
        Me.GroupBox1.Controls.Add(Me.txt_totalLoansPaid)
        Me.GroupBox1.Controls.Add(Me.dgv_payroll)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Size = New System.Drawing.Size(1054, 437)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(170, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "|"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_delete
        '
        Me.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_delete.ImageKey = "plus.png"
        Me.btn_delete.Location = New System.Drawing.Point(185, 373)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 30)
        Me.btn_delete.TabIndex = 44
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_edit.ImageKey = "plus.png"
        Me.btn_edit.Location = New System.Drawing.Point(91, 373)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 30)
        Me.btn_edit.TabIndex = 43
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(852, 373)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 51)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Total Net :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Gross :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dgv_payroll
        '
        Me.dgv_payroll.AllowUserToAddRows = False
        Me.dgv_payroll.AllowUserToDeleteRows = False
        Me.dgv_payroll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_payroll.BackgroundColor = System.Drawing.Color.White
        Me.dgv_payroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_payroll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Payroll_Detail_ID, Me.Employee_ID, Me.Employee_Name, Me.Total_Basic_Pay, Me.Total_Add_Pay, Me.Total_Gross, Me.Total_Deductions, Me.Total_Loan_Pays, Me.Total_Net})
        Me.dgv_payroll.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_payroll.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_payroll.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv_payroll.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_payroll.Location = New System.Drawing.Point(10, 26)
        Me.dgv_payroll.Name = "dgv_payroll"
        Me.dgv_payroll.ReadOnly = True
        Me.dgv_payroll.RowHeadersVisible = False
        Me.dgv_payroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_payroll.ShowCellErrors = False
        Me.dgv_payroll.ShowCellToolTips = False
        Me.dgv_payroll.ShowEditingIcon = False
        Me.dgv_payroll.ShowRowErrors = False
        Me.dgv_payroll.Size = New System.Drawing.Size(1034, 338)
        Me.dgv_payroll.TabIndex = 707
        '
        'Payroll_Detail_ID
        '
        Me.Payroll_Detail_ID.Frozen = True
        Me.Payroll_Detail_ID.HeaderText = "ID"
        Me.Payroll_Detail_ID.Name = "Payroll_Detail_ID"
        Me.Payroll_Detail_ID.ReadOnly = True
        Me.Payroll_Detail_ID.Visible = False
        Me.Payroll_Detail_ID.Width = 50
        '
        'Employee_ID
        '
        Me.Employee_ID.Frozen = True
        Me.Employee_ID.HeaderText = "Employee ID"
        Me.Employee_ID.Name = "Employee_ID"
        Me.Employee_ID.ReadOnly = True
        Me.Employee_ID.Width = 80
        '
        'Employee_Name
        '
        Me.Employee_Name.DividerWidth = 5
        Me.Employee_Name.Frozen = True
        Me.Employee_Name.HeaderText = "Employee Name"
        Me.Employee_Name.Name = "Employee_Name"
        Me.Employee_Name.ReadOnly = True
        Me.Employee_Name.Width = 200
        '
        'Total_Basic_Pay
        '
        Me.Total_Basic_Pay.HeaderText = "Total Basic Pay"
        Me.Total_Basic_Pay.Name = "Total_Basic_Pay"
        Me.Total_Basic_Pay.ReadOnly = True
        Me.Total_Basic_Pay.Width = 150
        '
        'Total_Add_Pay
        '
        Me.Total_Add_Pay.HeaderText = "Total Additional Pay"
        Me.Total_Add_Pay.Name = "Total_Add_Pay"
        Me.Total_Add_Pay.ReadOnly = True
        Me.Total_Add_Pay.Width = 150
        '
        'Total_Gross
        '
        Me.Total_Gross.HeaderText = "Total Gross"
        Me.Total_Gross.Name = "Total_Gross"
        Me.Total_Gross.ReadOnly = True
        Me.Total_Gross.Width = 150
        '
        'Total_Deductions
        '
        Me.Total_Deductions.HeaderText = "Total Deductions"
        Me.Total_Deductions.Name = "Total_Deductions"
        Me.Total_Deductions.ReadOnly = True
        Me.Total_Deductions.Width = 150
        '
        'Total_Loan_Pays
        '
        Me.Total_Loan_Pays.HeaderText = "Total Loan Payments"
        Me.Total_Loan_Pays.Name = "Total_Loan_Pays"
        Me.Total_Loan_Pays.ReadOnly = True
        Me.Total_Loan_Pays.Width = 150
        '
        'Total_Net
        '
        Me.Total_Net.HeaderText = "Total Net"
        Me.Total_Net.Name = "Total_Net"
        Me.Total_Net.ReadOnly = True
        Me.Total_Net.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(565, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 51)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Payroll Date : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Particulars :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Payroll_Details
        '
        Me.Payroll_Details.Controls.Add(Me.cmb_monthApplicable)
        Me.Payroll_Details.Controls.Add(Me.cmb_type)
        Me.Payroll_Details.Controls.Add(Me.Label2)
        Me.Payroll_Details.Controls.Add(Me.Label1)
        Me.Payroll_Details.Controls.Add(Me.dt_payroll)
        Me.Payroll_Details.Controls.Add(Me.rtb_remarks)
        Me.Payroll_Details.Controls.Add(Me.dt_cutoffStart)
        Me.Payroll_Details.Controls.Add(Me.dt_cutoffEnd)
        Me.Payroll_Details.Controls.Add(Me.Label7)
        Me.Payroll_Details.Location = New System.Drawing.Point(12, 81)
        Me.Payroll_Details.Name = "Payroll_Details"
        Me.Payroll_Details.Size = New System.Drawing.Size(1054, 114)
        Me.Payroll_Details.TabIndex = 51
        Me.Payroll_Details.TabStop = False
        '
        'cmb_monthApplicable
        '
        Me.cmb_monthApplicable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_monthApplicable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_monthApplicable.FormattingEnabled = True
        Me.cmb_monthApplicable.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmb_monthApplicable.Location = New System.Drawing.Point(134, 47)
        Me.cmb_monthApplicable.Name = "cmb_monthApplicable"
        Me.cmb_monthApplicable.Size = New System.Drawing.Size(126, 24)
        Me.cmb_monthApplicable.TabIndex = 52
        '
        'cmb_type
        '
        Me.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Items.AddRange(New Object() {"Bonus", "Incentive", "Monthly", "Weekly", "Others"})
        Me.cmb_type.Location = New System.Drawing.Point(134, 13)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(102, 24)
        Me.cmb_type.TabIndex = 51
        '
        'FrmPAYROLL_DETAILS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1077, 690)
        Me.ControlBox = False
        Me.Controls.Add(Me.Payroll_Details)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPAYROLL_DETAILS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Details"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.grp_Payrollpayee.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_payroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Payroll_Details.ResumeLayout(False)
        Me.Payroll_Details.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cb_Approved As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_TotalgrossPay As System.Windows.Forms.TextBox
    Friend WithEvents txt_TotalnetPay As System.Windows.Forms.TextBox
    Friend WithEvents txt_totalLoansPaid As System.Windows.Forms.TextBox
    Friend WithEvents txt_totalDeductions As System.Windows.Forms.TextBox
    Friend WithEvents dt_payroll As System.Windows.Forms.DateTimePicker
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents rtb_remarks As System.Windows.Forms.RichTextBox
    Friend WithEvents grp_Payrollpayee As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancelSubmit As System.Windows.Forms.Button
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents cmb_employees As System.Windows.Forms.ComboBox
    Friend WithEvents dt_cutoffStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_cutoffEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PrintEmployeePayslipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToBankFormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_encoder As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label_ID As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgv_payroll As System.Windows.Forms.DataGridView
    Friend WithEvents Payroll_Details As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_monthApplicable As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_type As System.Windows.Forms.ComboBox
    Friend WithEvents Payroll_Detail_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Employee_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Employee_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Basic_Pay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Add_Pay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Gross As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Deductions As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Loan_Pays As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Net As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintPayslipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
