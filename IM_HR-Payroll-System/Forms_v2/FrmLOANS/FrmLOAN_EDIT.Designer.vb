<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLOAN_EDIT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLOAN_EDIT))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_loanRemarks = New System.Windows.Forms.RichTextBox()
        Me.txt_loanReason = New System.Windows.Forms.RichTextBox()
        Me.dt_payEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dt_payStartDate = New System.Windows.Forms.DateTimePicker()
        Me.txt_grossAmount = New System.Windows.Forms.TextBox()
        Me.txt_interestRate = New System.Windows.Forms.TextBox()
        Me.txt_netAmount = New System.Windows.Forms.TextBox()
        Me.lst_loanPayment = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PostPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_balanceAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_loanStatus = New System.Windows.Forms.ComboBox()
        Me.cmb_loanType = New System.Windows.Forms.ComboBox()
        Me.txt_employees = New System.Windows.Forms.TextBox()
        Me.txt_suggestedDeduction = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_totalPayment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_post = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.lbl_encodedBy = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(15, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 204)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Employee :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Net Amount :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Interest Rate :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gross Amount :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Balance Amount" & _
    " :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Suggested Pay :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/ Cutoff "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(367, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 221)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Loan Type :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cutoff Pay Start Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cutoff Pay End Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loan Reason :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loan Remarks :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loan Status :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_loanRemarks
        '
        Me.txt_loanRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_loanRemarks.Location = New System.Drawing.Point(522, 224)
        Me.txt_loanRemarks.Name = "txt_loanRemarks"
        Me.txt_loanRemarks.Size = New System.Drawing.Size(252, 40)
        Me.txt_loanRemarks.TabIndex = 37
        Me.txt_loanRemarks.Text = ""
        '
        'txt_loanReason
        '
        Me.txt_loanReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_loanReason.Location = New System.Drawing.Point(522, 170)
        Me.txt_loanReason.Name = "txt_loanReason"
        Me.txt_loanReason.Size = New System.Drawing.Size(252, 40)
        Me.txt_loanReason.TabIndex = 36
        Me.txt_loanReason.Text = ""
        '
        'dt_payEndDate
        '
        Me.dt_payEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_payEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_payEndDate.Location = New System.Drawing.Point(522, 134)
        Me.dt_payEndDate.Name = "dt_payEndDate"
        Me.dt_payEndDate.Size = New System.Drawing.Size(101, 23)
        Me.dt_payEndDate.TabIndex = 35
        '
        'dt_payStartDate
        '
        Me.dt_payStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_payStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_payStartDate.Location = New System.Drawing.Point(522, 102)
        Me.dt_payStartDate.Name = "dt_payStartDate"
        Me.dt_payStartDate.Size = New System.Drawing.Size(101, 23)
        Me.dt_payStartDate.TabIndex = 34
        '
        'txt_grossAmount
        '
        Me.txt_grossAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_grossAmount.Location = New System.Drawing.Point(136, 170)
        Me.txt_grossAmount.Name = "txt_grossAmount"
        Me.txt_grossAmount.ReadOnly = True
        Me.txt_grossAmount.Size = New System.Drawing.Size(100, 23)
        Me.txt_grossAmount.TabIndex = 33
        Me.txt_grossAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_interestRate
        '
        Me.txt_interestRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_interestRate.Location = New System.Drawing.Point(136, 136)
        Me.txt_interestRate.Name = "txt_interestRate"
        Me.txt_interestRate.ReadOnly = True
        Me.txt_interestRate.Size = New System.Drawing.Size(43, 23)
        Me.txt_interestRate.TabIndex = 32
        Me.txt_interestRate.Text = "0"
        Me.txt_interestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_netAmount
        '
        Me.txt_netAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_netAmount.Location = New System.Drawing.Point(136, 102)
        Me.txt_netAmount.Name = "txt_netAmount"
        Me.txt_netAmount.ReadOnly = True
        Me.txt_netAmount.Size = New System.Drawing.Size(100, 23)
        Me.txt_netAmount.TabIndex = 31
        Me.txt_netAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lst_loanPayment
        '
        Me.lst_loanPayment.Dock = System.Windows.Forms.DockStyle.Top
        Me.lst_loanPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lst_loanPayment.FullRowSelect = True
        Me.lst_loanPayment.GridLines = True
        Me.lst_loanPayment.Location = New System.Drawing.Point(10, 16)
        Me.lst_loanPayment.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_loanPayment.Name = "lst_loanPayment"
        Me.lst_loanPayment.Size = New System.Drawing.Size(742, 232)
        Me.lst_loanPayment.TabIndex = 39
        Me.lst_loanPayment.UseCompatibleStateImageBehavior = False
        Me.lst_loanPayment.View = System.Windows.Forms.View.Details
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditEmployeeToolStripMenuItem, Me.DeleteEmployeeToolStripMenuItem, Me.PostPaymentToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(177, 76)
        '
        'EditEmployeeToolStripMenuItem
        '
        Me.EditEmployeeToolStripMenuItem.Image = Global.Harmony.My.Resources.Resources.edit
        Me.EditEmployeeToolStripMenuItem.Name = "EditEmployeeToolStripMenuItem"
        Me.EditEmployeeToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.EditEmployeeToolStripMenuItem.Text = "Edit Payment"
        '
        'DeleteEmployeeToolStripMenuItem
        '
        Me.DeleteEmployeeToolStripMenuItem.Image = Global.Harmony.My.Resources.Resources.bin
        Me.DeleteEmployeeToolStripMenuItem.Name = "DeleteEmployeeToolStripMenuItem"
        Me.DeleteEmployeeToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.DeleteEmployeeToolStripMenuItem.Text = "Delete Loan"
        '
        'PostPaymentToolStripMenuItem
        '
        Me.PostPaymentToolStripMenuItem.Image = Global.Harmony.My.Resources.Resources.upload
        Me.PostPaymentToolStripMenuItem.Name = "PostPaymentToolStripMenuItem"
        Me.PostPaymentToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.PostPaymentToolStripMenuItem.Text = "Post Payment"
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_cancel.Location = New System.Drawing.Point(699, 10)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_cancel.TabIndex = 41
        Me.btn_cancel.Text = "&Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_save.Location = New System.Drawing.Point(624, 10)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(70, 30)
        Me.btn_save.TabIndex = 40
        Me.btn_save.Text = "&Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'txt_balanceAmount
        '
        Me.txt_balanceAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_balanceAmount.Location = New System.Drawing.Point(136, 204)
        Me.txt_balanceAmount.Name = "txt_balanceAmount"
        Me.txt_balanceAmount.ReadOnly = True
        Me.txt_balanceAmount.Size = New System.Drawing.Size(100, 23)
        Me.txt_balanceAmount.TabIndex = 42
        Me.txt_balanceAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(181, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 17)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "%"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmb_loanStatus
        '
        Me.cmb_loanStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_loanStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_loanStatus.FormattingEnabled = True
        Me.cmb_loanStatus.Items.AddRange(New Object() {"Active", "Paid"})
        Me.cmb_loanStatus.Location = New System.Drawing.Point(522, 270)
        Me.cmb_loanStatus.Name = "cmb_loanStatus"
        Me.cmb_loanStatus.Size = New System.Drawing.Size(113, 24)
        Me.cmb_loanStatus.TabIndex = 45
        '
        'cmb_loanType
        '
        Me.cmb_loanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_loanType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_loanType.FormattingEnabled = True
        Me.cmb_loanType.Items.AddRange(New Object() {"Allowance Advance", "Cash Advance", "Emergency", "Personal", "Product", "SSS", "PAG-IBIG"})
        Me.cmb_loanType.Location = New System.Drawing.Point(522, 65)
        Me.cmb_loanType.Name = "cmb_loanType"
        Me.cmb_loanType.Size = New System.Drawing.Size(127, 24)
        Me.cmb_loanType.TabIndex = 140
        '
        'txt_employees
        '
        Me.txt_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_employees.Location = New System.Drawing.Point(136, 68)
        Me.txt_employees.Name = "txt_employees"
        Me.txt_employees.ReadOnly = True
        Me.txt_employees.Size = New System.Drawing.Size(199, 23)
        Me.txt_employees.TabIndex = 143
        Me.txt_employees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_suggestedDeduction
        '
        Me.txt_suggestedDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_suggestedDeduction.Location = New System.Drawing.Point(136, 237)
        Me.txt_suggestedDeduction.Name = "txt_suggestedDeduction"
        Me.txt_suggestedDeduction.ReadOnly = True
        Me.txt_suggestedDeduction.Size = New System.Drawing.Size(100, 23)
        Me.txt_suggestedDeduction.TabIndex = 145
        Me.txt_suggestedDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(789, 50)
        Me.Panel2.TabIndex = 146
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(45, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(254, 31)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Loan Details - Edit"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lbl_encodedBy)
        Me.Panel3.Controls.Add(Me.btn_cancel)
        Me.Panel3.Controls.Add(Me.btn_save)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel3.Location = New System.Drawing.Point(0, 604)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(789, 50)
        Me.Panel3.TabIndex = 147
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_totalPayment)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btn_post)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.lst_loanPayment)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 300)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10, 3, 10, 10)
        Me.GroupBox1.Size = New System.Drawing.Size(762, 293)
        Me.GroupBox1.TabIndex = 148
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Payments"
        '
        'txt_totalPayment
        '
        Me.txt_totalPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_totalPayment.Location = New System.Drawing.Point(652, 258)
        Me.txt_totalPayment.Name = "txt_totalPayment"
        Me.txt_totalPayment.ReadOnly = True
        Me.txt_totalPayment.Size = New System.Drawing.Size(100, 23)
        Me.txt_totalPayment.TabIndex = 149
        Me.txt_totalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(506, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 17)
        Me.Label6.TabIndex = 149
        Me.Label6.Text = "Total Loan Payment :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_post
        '
        Me.btn_post.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_post.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_post.ImageKey = "plus.png"
        Me.btn_post.Location = New System.Drawing.Point(170, 253)
        Me.btn_post.Name = "btn_post"
        Me.btn_post.Size = New System.Drawing.Size(75, 30)
        Me.btn_post.TabIndex = 147
        Me.btn_post.Text = "Post"
        Me.btn_post.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_post.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(251, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 17)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "|"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_delete
        '
        Me.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_delete.ImageKey = "plus.png"
        Me.btn_delete.Location = New System.Drawing.Point(266, 253)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 30)
        Me.btn_delete.TabIndex = 145
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_edit.ImageKey = "plus.png"
        Me.btn_edit.Location = New System.Drawing.Point(91, 253)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 30)
        Me.btn_edit.TabIndex = 144
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_add.ImageKey = "plus.png"
        Me.btn_add.Location = New System.Drawing.Point(10, 253)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 30)
        Me.btn_add.TabIndex = 143
        Me.btn_add.Text = "Add"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'lbl_encodedBy
        '
        Me.lbl_encodedBy.AutoSize = True
        Me.lbl_encodedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_encodedBy.Location = New System.Drawing.Point(9, 17)
        Me.lbl_encodedBy.Name = "lbl_encodedBy"
        Me.lbl_encodedBy.Size = New System.Drawing.Size(92, 17)
        Me.lbl_encodedBy.TabIndex = 42
        Me.lbl_encodedBy.Text = "Encoded By :"
        Me.lbl_encodedBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmLOAN_EDIT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(789, 654)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txt_suggestedDeduction)
        Me.Controls.Add(Me.txt_employees)
        Me.Controls.Add(Me.cmb_loanType)
        Me.Controls.Add(Me.cmb_loanStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_balanceAmount)
        Me.Controls.Add(Me.txt_loanRemarks)
        Me.Controls.Add(Me.txt_loanReason)
        Me.Controls.Add(Me.dt_payEndDate)
        Me.Controls.Add(Me.dt_payStartDate)
        Me.Controls.Add(Me.txt_grossAmount)
        Me.Controls.Add(Me.txt_interestRate)
        Me.Controls.Add(Me.txt_netAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLOAN_EDIT"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Details - Edit"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_loanRemarks As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_loanReason As System.Windows.Forms.RichTextBox
    Friend WithEvents dt_payEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_payStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_grossAmount As System.Windows.Forms.TextBox
    Friend WithEvents txt_interestRate As System.Windows.Forms.TextBox
    Friend WithEvents txt_netAmount As System.Windows.Forms.TextBox
    Friend WithEvents lst_loanPayment As System.Windows.Forms.ListView
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txt_balanceAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_loanStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_loanType As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_employees As System.Windows.Forms.TextBox
    Friend WithEvents txt_suggestedDeduction As System.Windows.Forms.TextBox
    Friend WithEvents PostPaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_post As System.Windows.Forms.Button
    Friend WithEvents txt_totalPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_encodedBy As System.Windows.Forms.Label
End Class
