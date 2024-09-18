<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPAYROLL_ADD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPAYROLL_ADD))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lst_payrollRecord = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cb_Approved = New System.Windows.Forms.CheckBox()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_encodedby = New System.Windows.Forms.Label()
        Me.txt_payroll_ID = New System.Windows.Forms.TextBox()
        Me.txt_TotalgrossPay = New System.Windows.Forms.TextBox()
        Me.txt_TotalnetPay = New System.Windows.Forms.TextBox()
        Me.txt_totalLoansPaid = New System.Windows.Forms.TextBox()
        Me.txt_totalDeductions = New System.Windows.Forms.TextBox()
        Me.dt_payroll = New System.Windows.Forms.DateTimePicker()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.rtb_remarks = New System.Windows.Forms.RichTextBox()
        Me.btn_newPayroll = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grp_Payrollpayee = New System.Windows.Forms.GroupBox()
        Me.btn_cancelSubmit = New System.Windows.Forms.Button()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.cmb_employees = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dt_cutoffStart = New System.Windows.Forms.DateTimePicker()
        Me.dt_cutoffEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrintEmployeePayslipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToBankFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Payrollpayee.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 60)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Payroll ID :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cutoff Period :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lst_payrollRecord
        '
        Me.lst_payrollRecord.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lst_payrollRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_payrollRecord.FullRowSelect = True
        Me.lst_payrollRecord.GridLines = True
        Me.lst_payrollRecord.Location = New System.Drawing.Point(11, 182)
        Me.lst_payrollRecord.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_payrollRecord.Name = "lst_payrollRecord"
        Me.lst_payrollRecord.Size = New System.Drawing.Size(1098, 381)
        Me.lst_payrollRecord.TabIndex = 20
        Me.lst_payrollRecord.UseCompatibleStateImageBehavior = False
        Me.lst_payrollRecord.View = System.Windows.Forms.View.Details
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditEmployeeToolStripMenuItem, Me.DeleteEmployeeToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(232, 52)
        '
        'EditEmployeeToolStripMenuItem
        '
        Me.EditEmployeeToolStripMenuItem.Image = Global.Harmony.My.Resources.Resources.edit
        Me.EditEmployeeToolStripMenuItem.Name = "EditEmployeeToolStripMenuItem"
        Me.EditEmployeeToolStripMenuItem.Size = New System.Drawing.Size(231, 24)
        Me.EditEmployeeToolStripMenuItem.Text = "Edit Payroll Record"
        '
        'DeleteEmployeeToolStripMenuItem
        '
        Me.DeleteEmployeeToolStripMenuItem.Image = Global.Harmony.My.Resources.Resources.bin
        Me.DeleteEmployeeToolStripMenuItem.Name = "DeleteEmployeeToolStripMenuItem"
        Me.DeleteEmployeeToolStripMenuItem.Size = New System.Drawing.Size(231, 24)
        Me.DeleteEmployeeToolStripMenuItem.Text = "Delete Payroll Record"
        '
        'cb_Approved
        '
        Me.cb_Approved.AutoSize = True
        Me.cb_Approved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Approved.Location = New System.Drawing.Point(937, 575)
        Me.cb_Approved.Name = "cb_Approved"
        Me.cb_Approved.Size = New System.Drawing.Size(96, 24)
        Me.cb_Approved.TabIndex = 21
        Me.cb_Approved.Text = "Approved"
        Me.cb_Approved.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(1037, 650)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_Cancel.TabIndex = 23
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(1039, 571)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(70, 30)
        Me.btn_Save.TabIndex = 22
        Me.btn_Save.Text = "&Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(343, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 100)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Total Gross Pay :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Net Pay :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remarks :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(923, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Date :" & Global.Microsoft.VisualBasic.ChrW(13)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(627, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 60)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Total Deductions :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Loans Paid :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 26)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Payroll Record"
        '
        'txt_encodedby
        '
        Me.txt_encodedby.AutoSize = True
        Me.txt_encodedby.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_encodedby.Location = New System.Drawing.Point(12, 571)
        Me.txt_encodedby.Name = "txt_encodedby"
        Me.txt_encodedby.Size = New System.Drawing.Size(101, 20)
        Me.txt_encodedby.TabIndex = 29
        Me.txt_encodedby.Text = "Encoded by :"
        '
        'txt_payroll_ID
        '
        Me.txt_payroll_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_payroll_ID.Location = New System.Drawing.Point(130, 82)
        Me.txt_payroll_ID.Name = "txt_payroll_ID"
        Me.txt_payroll_ID.ReadOnly = True
        Me.txt_payroll_ID.Size = New System.Drawing.Size(85, 26)
        Me.txt_payroll_ID.TabIndex = 30
        '
        'txt_TotalgrossPay
        '
        Me.txt_TotalgrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalgrossPay.Location = New System.Drawing.Point(478, 38)
        Me.txt_TotalgrossPay.Name = "txt_TotalgrossPay"
        Me.txt_TotalgrossPay.ReadOnly = True
        Me.txt_TotalgrossPay.Size = New System.Drawing.Size(99, 26)
        Me.txt_TotalgrossPay.TabIndex = 32
        '
        'txt_TotalnetPay
        '
        Me.txt_TotalnetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalnetPay.Location = New System.Drawing.Point(478, 79)
        Me.txt_TotalnetPay.Name = "txt_TotalnetPay"
        Me.txt_TotalnetPay.ReadOnly = True
        Me.txt_TotalnetPay.Size = New System.Drawing.Size(99, 26)
        Me.txt_TotalnetPay.TabIndex = 33
        '
        'txt_totalLoansPaid
        '
        Me.txt_totalLoansPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalLoansPaid.Location = New System.Drawing.Point(770, 82)
        Me.txt_totalLoansPaid.Name = "txt_totalLoansPaid"
        Me.txt_totalLoansPaid.ReadOnly = True
        Me.txt_totalLoansPaid.Size = New System.Drawing.Size(99, 26)
        Me.txt_totalLoansPaid.TabIndex = 35
        '
        'txt_totalDeductions
        '
        Me.txt_totalDeductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalDeductions.Location = New System.Drawing.Point(770, 41)
        Me.txt_totalDeductions.Name = "txt_totalDeductions"
        Me.txt_totalDeductions.ReadOnly = True
        Me.txt_totalDeductions.Size = New System.Drawing.Size(99, 26)
        Me.txt_totalDeductions.TabIndex = 34
        '
        'dt_payroll
        '
        Me.dt_payroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_payroll.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_payroll.Location = New System.Drawing.Point(990, 41)
        Me.dt_payroll.Name = "dt_payroll"
        Me.dt_payroll.Size = New System.Drawing.Size(119, 26)
        Me.dt_payroll.TabIndex = 37
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "plus.png")
        Me.ImageList1.Images.SetKeyName(1, "add.png")
        '
        'rtb_remarks
        '
        Me.rtb_remarks.Location = New System.Drawing.Point(478, 116)
        Me.rtb_remarks.Name = "rtb_remarks"
        Me.rtb_remarks.Size = New System.Drawing.Size(391, 51)
        Me.rtb_remarks.TabIndex = 40
        Me.rtb_remarks.Text = ""
        '
        'btn_newPayroll
        '
        Me.btn_newPayroll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_newPayroll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newPayroll.ImageKey = "plus.png"
        Me.btn_newPayroll.ImageList = Me.ImageList1
        Me.btn_newPayroll.Location = New System.Drawing.Point(983, 124)
        Me.btn_newPayroll.Name = "btn_newPayroll"
        Me.btn_newPayroll.Size = New System.Drawing.Size(124, 43)
        Me.btn_newPayroll.TabIndex = 39
        Me.btn_newPayroll.Text = "New Payee"
        Me.btn_newPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_newPayroll.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Harmony.My.Resources.Resources.payroll
        Me.PictureBox1.Location = New System.Drawing.Point(9, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'grp_Payrollpayee
        '
        Me.grp_Payrollpayee.Controls.Add(Me.btn_cancelSubmit)
        Me.grp_Payrollpayee.Controls.Add(Me.btn_submit)
        Me.grp_Payrollpayee.Controls.Add(Me.cmb_employees)
        Me.grp_Payrollpayee.Controls.Add(Me.Label5)
        Me.grp_Payrollpayee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Payrollpayee.Location = New System.Drawing.Point(357, 305)
        Me.grp_Payrollpayee.Name = "grp_Payrollpayee"
        Me.grp_Payrollpayee.Size = New System.Drawing.Size(434, 98)
        Me.grp_Payrollpayee.TabIndex = 41
        Me.grp_Payrollpayee.TabStop = False
        Me.grp_Payrollpayee.Text = "Create Payroll Payee Record for:"
        Me.grp_Payrollpayee.Visible = False
        '
        'btn_cancelSubmit
        '
        Me.btn_cancelSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelSubmit.Location = New System.Drawing.Point(358, 60)
        Me.btn_cancelSubmit.Name = "btn_cancelSubmit"
        Me.btn_cancelSubmit.Size = New System.Drawing.Size(70, 30)
        Me.btn_cancelSubmit.TabIndex = 42
        Me.btn_cancelSubmit.Text = "&Cancel"
        Me.btn_cancelSubmit.UseVisualStyleBackColor = True
        '
        'btn_submit
        '
        Me.btn_submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.Location = New System.Drawing.Point(282, 60)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(70, 30)
        Me.btn_submit.TabIndex = 23
        Me.btn_submit.Text = "&Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'cmb_employees
        '
        Me.cmb_employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employees.FormattingEnabled = True
        Me.cmb_employees.Location = New System.Drawing.Point(75, 26)
        Me.cmb_employees.Name = "cmb_employees"
        Me.cmb_employees.Size = New System.Drawing.Size(353, 28)
        Me.cmb_employees.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Select :"
        '
        'dt_cutoffStart
        '
        Me.dt_cutoffStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_cutoffStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_cutoffStart.Location = New System.Drawing.Point(130, 119)
        Me.dt_cutoffStart.Name = "dt_cutoffStart"
        Me.dt_cutoffStart.Size = New System.Drawing.Size(119, 26)
        Me.dt_cutoffStart.TabIndex = 42
        '
        'dt_cutoffEnd
        '
        Me.dt_cutoffEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_cutoffEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_cutoffEnd.Location = New System.Drawing.Point(264, 119)
        Me.dt_cutoffEnd.Name = "dt_cutoffEnd"
        Me.dt_cutoffEnd.Size = New System.Drawing.Size(119, 26)
        Me.dt_cutoffEnd.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(249, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 20)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "-"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintEmployeePayslipToolStripMenuItem, Me.ExportToBankFormatToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1115, 25)
        Me.MenuStrip1.TabIndex = 45
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrintEmployeePayslipToolStripMenuItem
        '
        Me.PrintEmployeePayslipToolStripMenuItem.Name = "PrintEmployeePayslipToolStripMenuItem"
        Me.PrintEmployeePayslipToolStripMenuItem.Size = New System.Drawing.Size(98, 21)
        Me.PrintEmployeePayslipToolStripMenuItem.Text = "Print Payslip"
        '
        'ExportToBankFormatToolStripMenuItem
        '
        Me.ExportToBankFormatToolStripMenuItem.Name = "ExportToBankFormatToolStripMenuItem"
        Me.ExportToBankFormatToolStripMenuItem.Size = New System.Drawing.Size(160, 21)
        Me.ExportToBankFormatToolStripMenuItem.Text = "Export to Bank Format"
        '
        'FormPAYROLL_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 608)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dt_cutoffEnd)
        Me.Controls.Add(Me.dt_cutoffStart)
        Me.Controls.Add(Me.grp_Payrollpayee)
        Me.Controls.Add(Me.rtb_remarks)
        Me.Controls.Add(Me.btn_newPayroll)
        Me.Controls.Add(Me.dt_payroll)
        Me.Controls.Add(Me.txt_totalLoansPaid)
        Me.Controls.Add(Me.txt_totalDeductions)
        Me.Controls.Add(Me.txt_TotalnetPay)
        Me.Controls.Add(Me.txt_TotalgrossPay)
        Me.Controls.Add(Me.txt_payroll_ID)
        Me.Controls.Add(Me.txt_encodedby)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.cb_Approved)
        Me.Controls.Add(Me.lst_payrollRecord)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPAYROLL_ADD"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Record"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Payrollpayee.ResumeLayout(False)
        Me.grp_Payrollpayee.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lst_payrollRecord As System.Windows.Forms.ListView
    Friend WithEvents cb_Approved As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_encodedby As System.Windows.Forms.Label
    Friend WithEvents txt_payroll_ID As System.Windows.Forms.TextBox
    Friend WithEvents txt_TotalgrossPay As System.Windows.Forms.TextBox
    Friend WithEvents txt_TotalnetPay As System.Windows.Forms.TextBox
    Friend WithEvents txt_totalLoansPaid As System.Windows.Forms.TextBox
    Friend WithEvents txt_totalDeductions As System.Windows.Forms.TextBox
    Friend WithEvents dt_payroll As System.Windows.Forms.DateTimePicker
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btn_newPayroll As System.Windows.Forms.Button
    Friend WithEvents rtb_remarks As System.Windows.Forms.RichTextBox
    Friend WithEvents grp_Payrollpayee As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancelSubmit As System.Windows.Forms.Button
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents cmb_employees As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dt_cutoffStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_cutoffEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PrintEmployeePayslipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToBankFormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
