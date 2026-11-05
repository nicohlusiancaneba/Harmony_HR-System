<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmATTENDANCE
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmATTENDANCE))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_panel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_employees = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_dateYear = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.cb_Approved = New System.Windows.Forms.CheckBox()
        Me.cmb_approved = New System.Windows.Forms.ComboBox()
        Me.dt_toAdjustment = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_fromAdjustment = New System.Windows.Forms.DateTimePicker()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.cb_remarks = New System.Windows.Forms.CheckBox()
        Me.cb_adjustmentDate = New System.Windows.Forms.CheckBox()
        Me.cb_Type = New System.Windows.Forms.CheckBox()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.cb_name = New System.Windows.Forms.CheckBox()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.cb_employeeID = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Employee_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Employee_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.One = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Two = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Three = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Four = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Five = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Six = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seven = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eleven = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Twelve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Thirteen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fourteen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fifteen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sixteen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seventeen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eighteen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nineteen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Twenty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TwentyOne = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TwentyTwo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TwentyThree = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TwentyFour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TwentyFive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TwentySix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TwentySeven = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TwentyEight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TwentyNine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Thirty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThirtyOne = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.dgv_panel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_employees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grpFilter.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel2.TabIndex = 7
        '
        'dgv_panel
        '
        Me.dgv_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.dgv_panel.Controls.Add(Me.TabControl1)
        Me.dgv_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_panel.Location = New System.Drawing.Point(10, 10)
        Me.dgv_panel.Name = "dgv_panel"
        Me.dgv_panel.Padding = New System.Windows.Forms.Padding(5)
        Me.dgv_panel.Size = New System.Drawing.Size(968, 534)
        Me.dgv_panel.TabIndex = 706
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(5, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(958, 524)
        Me.TabControl1.TabIndex = 708
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.dgv_employees)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(950, 495)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Monitoring"
        '
        'dgv_employees
        '
        Me.dgv_employees.AllowUserToAddRows = False
        Me.dgv_employees.AllowUserToDeleteRows = False
        Me.dgv_employees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_employees.BackgroundColor = System.Drawing.Color.White
        Me.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_employees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Employee_ID, Me.Employee_Name, Me.One, Me.Two, Me.Three, Me.Four, Me.Five, Me.Six, Me.Seven, Me.Eight, Me.Nine, Me.Ten, Me.Eleven, Me.Twelve, Me.Thirteen, Me.Fourteen, Me.Fifteen, Me.Sixteen, Me.Seventeen, Me.Eighteen, Me.Nineteen, Me.Twenty, Me.TwentyOne, Me.TwentyTwo, Me.TwentyThree, Me.TwentyFour, Me.TwentyFive, Me.TwentySix, Me.TwentySeven, Me.TwentyEight, Me.TwentyNine, Me.Thirty, Me.ThirtyOne})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_employees.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_employees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_employees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_employees.Location = New System.Drawing.Point(3, 42)
        Me.dgv_employees.MultiSelect = False
        Me.dgv_employees.Name = "dgv_employees"
        Me.dgv_employees.ReadOnly = True
        Me.dgv_employees.RowHeadersVisible = False
        Me.dgv_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_employees.ShowCellErrors = False
        Me.dgv_employees.ShowCellToolTips = False
        Me.dgv_employees.ShowEditingIcon = False
        Me.dgv_employees.ShowRowErrors = False
        Me.dgv_employees.Size = New System.Drawing.Size(944, 450)
        Me.dgv_employees.TabIndex = 709
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lbl_dateYear)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(944, 39)
        Me.Panel3.TabIndex = 708
        '
        'lbl_dateYear
        '
        Me.lbl_dateYear.AutoSize = True
        Me.lbl_dateYear.Location = New System.Drawing.Point(287, 10)
        Me.lbl_dateYear.Name = "lbl_dateYear"
        Me.lbl_dateYear.Size = New System.Drawing.Size(109, 17)
        Me.lbl_dateYear.TabIndex = 0
        Me.lbl_dateYear.Text = "November 2026"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.grpFilter)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(950, 495)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Record"
        '
        'grpFilter
        '
        Me.grpFilter.Controls.Add(Me.cb_Approved)
        Me.grpFilter.Controls.Add(Me.cmb_approved)
        Me.grpFilter.Controls.Add(Me.dt_toAdjustment)
        Me.grpFilter.Controls.Add(Me.Label2)
        Me.grpFilter.Controls.Add(Me.dt_fromAdjustment)
        Me.grpFilter.Controls.Add(Me.btn_submit)
        Me.grpFilter.Controls.Add(Me.btn_cancel)
        Me.grpFilter.Controls.Add(Me.txt_remarks)
        Me.grpFilter.Controls.Add(Me.cb_remarks)
        Me.grpFilter.Controls.Add(Me.cb_adjustmentDate)
        Me.grpFilter.Controls.Add(Me.cb_Type)
        Me.grpFilter.Controls.Add(Me.cmb_type)
        Me.grpFilter.Controls.Add(Me.txt_name)
        Me.grpFilter.Controls.Add(Me.cb_name)
        Me.grpFilter.Controls.Add(Me.txt_employeeID)
        Me.grpFilter.Controls.Add(Me.cb_employeeID)
        Me.grpFilter.Location = New System.Drawing.Point(54, 106)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(392, 242)
        Me.grpFilter.TabIndex = 706
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Search"
        Me.grpFilter.Visible = False
        '
        'cb_Approved
        '
        Me.cb_Approved.AutoSize = True
        Me.cb_Approved.Location = New System.Drawing.Point(15, 166)
        Me.cb_Approved.Name = "cb_Approved"
        Me.cb_Approved.Size = New System.Drawing.Size(88, 21)
        Me.cb_Approved.TabIndex = 22
        Me.cb_Approved.Text = "Approved"
        Me.cb_Approved.UseVisualStyleBackColor = True
        '
        'cmb_approved
        '
        Me.cmb_approved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_approved.FormattingEnabled = True
        Me.cmb_approved.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb_approved.Location = New System.Drawing.Point(149, 164)
        Me.cmb_approved.Name = "cmb_approved"
        Me.cmb_approved.Size = New System.Drawing.Size(72, 24)
        Me.cmb_approved.TabIndex = 21
        '
        'dt_toAdjustment
        '
        Me.dt_toAdjustment.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_toAdjustment.Location = New System.Drawing.Point(278, 107)
        Me.dt_toAdjustment.Name = "dt_toAdjustment"
        Me.dt_toAdjustment.Size = New System.Drawing.Size(101, 23)
        Me.dt_toAdjustment.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(253, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "to"
        '
        'dt_fromAdjustment
        '
        Me.dt_fromAdjustment.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fromAdjustment.Location = New System.Drawing.Point(149, 107)
        Me.dt_fromAdjustment.Name = "dt_fromAdjustment"
        Me.dt_fromAdjustment.Size = New System.Drawing.Size(101, 23)
        Me.dt_fromAdjustment.TabIndex = 18
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(203, 197)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(85, 30)
        Me.btn_submit.TabIndex = 15
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(294, 197)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(85, 30)
        Me.btn_cancel.TabIndex = 14
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'txt_remarks
        '
        Me.txt_remarks.Location = New System.Drawing.Point(149, 135)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(148, 23)
        Me.txt_remarks.TabIndex = 11
        '
        'cb_remarks
        '
        Me.cb_remarks.AutoSize = True
        Me.cb_remarks.Location = New System.Drawing.Point(15, 137)
        Me.cb_remarks.Name = "cb_remarks"
        Me.cb_remarks.Size = New System.Drawing.Size(83, 21)
        Me.cb_remarks.TabIndex = 10
        Me.cb_remarks.Text = "Remarks"
        Me.cb_remarks.UseVisualStyleBackColor = True
        '
        'cb_adjustmentDate
        '
        Me.cb_adjustmentDate.AutoSize = True
        Me.cb_adjustmentDate.Location = New System.Drawing.Point(15, 108)
        Me.cb_adjustmentDate.Name = "cb_adjustmentDate"
        Me.cb_adjustmentDate.Size = New System.Drawing.Size(131, 21)
        Me.cb_adjustmentDate.TabIndex = 8
        Me.cb_adjustmentDate.Text = "Adjustment Date"
        Me.cb_adjustmentDate.UseVisualStyleBackColor = True
        '
        'cb_Type
        '
        Me.cb_Type.AutoSize = True
        Me.cb_Type.Location = New System.Drawing.Point(15, 80)
        Me.cb_Type.Name = "cb_Type"
        Me.cb_Type.Size = New System.Drawing.Size(59, 21)
        Me.cb_Type.TabIndex = 5
        Me.cb_Type.Text = "Type"
        Me.cb_Type.UseVisualStyleBackColor = True
        '
        'cmb_type
        '
        Me.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Items.AddRange(New Object() {"Job Position", "Department", "Division", "Regularization", "Resignation", "Termination", "Rehire", "Salary", "Monthly Salary (SSS)", "Monthly Salary (Philhealth)", "Monthly Salary (PAG-IBIG)", "Monthly Salary (BIR)", "Working Days", "Paid Leave Days", "Bank Account No.", "SSS No.", "Philhealth No.", "Tax ID No. (TIN)", "PAG-IBIG No.", "SSS Share", "Philhealth Share", "Tax Amount", "PAG-IBIG Share"})
        Me.cmb_type.Location = New System.Drawing.Point(149, 78)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(148, 24)
        Me.cmb_type.TabIndex = 4
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(988, 72)
        Me.Panel1.TabIndex = 6
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
        Me.Label1.Size = New System.Drawing.Size(232, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Attendance"
        '
        'Employee_ID
        '
        Me.Employee_ID.HeaderText = "Employee ID"
        Me.Employee_ID.Name = "Employee_ID"
        Me.Employee_ID.ReadOnly = True
        '
        'Employee_Name
        '
        Me.Employee_Name.DividerWidth = 5
        Me.Employee_Name.HeaderText = "Employee Name"
        Me.Employee_Name.Name = "Employee_Name"
        Me.Employee_Name.ReadOnly = True
        Me.Employee_Name.Width = 200
        '
        'One
        '
        Me.One.HeaderText = "1"
        Me.One.Name = "One"
        Me.One.ReadOnly = True
        '
        'Two
        '
        Me.Two.HeaderText = "2"
        Me.Two.Name = "Two"
        Me.Two.ReadOnly = True
        '
        'Three
        '
        Me.Three.HeaderText = "3"
        Me.Three.Name = "Three"
        Me.Three.ReadOnly = True
        '
        'Four
        '
        Me.Four.HeaderText = "4"
        Me.Four.Name = "Four"
        Me.Four.ReadOnly = True
        '
        'Five
        '
        Me.Five.HeaderText = "5"
        Me.Five.Name = "Five"
        Me.Five.ReadOnly = True
        '
        'Six
        '
        Me.Six.HeaderText = "6"
        Me.Six.Name = "Six"
        Me.Six.ReadOnly = True
        '
        'Seven
        '
        Me.Seven.HeaderText = "7"
        Me.Seven.Name = "Seven"
        Me.Seven.ReadOnly = True
        '
        'Eight
        '
        Me.Eight.HeaderText = "8"
        Me.Eight.Name = "Eight"
        Me.Eight.ReadOnly = True
        '
        'Nine
        '
        Me.Nine.HeaderText = "9"
        Me.Nine.Name = "Nine"
        Me.Nine.ReadOnly = True
        '
        'Ten
        '
        Me.Ten.HeaderText = "10"
        Me.Ten.Name = "Ten"
        Me.Ten.ReadOnly = True
        '
        'Eleven
        '
        Me.Eleven.HeaderText = "11"
        Me.Eleven.Name = "Eleven"
        Me.Eleven.ReadOnly = True
        '
        'Twelve
        '
        Me.Twelve.HeaderText = "12"
        Me.Twelve.Name = "Twelve"
        Me.Twelve.ReadOnly = True
        '
        'Thirteen
        '
        Me.Thirteen.HeaderText = "13"
        Me.Thirteen.Name = "Thirteen"
        Me.Thirteen.ReadOnly = True
        '
        'Fourteen
        '
        Me.Fourteen.HeaderText = "14"
        Me.Fourteen.Name = "Fourteen"
        Me.Fourteen.ReadOnly = True
        '
        'Fifteen
        '
        Me.Fifteen.HeaderText = "15"
        Me.Fifteen.Name = "Fifteen"
        Me.Fifteen.ReadOnly = True
        '
        'Sixteen
        '
        Me.Sixteen.HeaderText = "16"
        Me.Sixteen.Name = "Sixteen"
        Me.Sixteen.ReadOnly = True
        '
        'Seventeen
        '
        Me.Seventeen.HeaderText = "17"
        Me.Seventeen.Name = "Seventeen"
        Me.Seventeen.ReadOnly = True
        '
        'Eighteen
        '
        Me.Eighteen.HeaderText = "18"
        Me.Eighteen.Name = "Eighteen"
        Me.Eighteen.ReadOnly = True
        '
        'Nineteen
        '
        Me.Nineteen.HeaderText = "19"
        Me.Nineteen.Name = "Nineteen"
        Me.Nineteen.ReadOnly = True
        '
        'Twenty
        '
        Me.Twenty.HeaderText = "20"
        Me.Twenty.Name = "Twenty"
        Me.Twenty.ReadOnly = True
        '
        'TwentyOne
        '
        Me.TwentyOne.HeaderText = "21"
        Me.TwentyOne.Name = "TwentyOne"
        Me.TwentyOne.ReadOnly = True
        '
        'TwentyTwo
        '
        Me.TwentyTwo.HeaderText = "22"
        Me.TwentyTwo.Name = "TwentyTwo"
        Me.TwentyTwo.ReadOnly = True
        '
        'TwentyThree
        '
        Me.TwentyThree.HeaderText = "23"
        Me.TwentyThree.Name = "TwentyThree"
        Me.TwentyThree.ReadOnly = True
        '
        'TwentyFour
        '
        Me.TwentyFour.HeaderText = "24"
        Me.TwentyFour.Name = "TwentyFour"
        Me.TwentyFour.ReadOnly = True
        '
        'TwentyFive
        '
        Me.TwentyFive.HeaderText = "25"
        Me.TwentyFive.Name = "TwentyFive"
        Me.TwentyFive.ReadOnly = True
        '
        'TwentySix
        '
        Me.TwentySix.HeaderText = "26"
        Me.TwentySix.Name = "TwentySix"
        Me.TwentySix.ReadOnly = True
        '
        'TwentySeven
        '
        Me.TwentySeven.HeaderText = "27"
        Me.TwentySeven.Name = "TwentySeven"
        Me.TwentySeven.ReadOnly = True
        '
        'TwentyEight
        '
        Me.TwentyEight.HeaderText = "28"
        Me.TwentyEight.Name = "TwentyEight"
        Me.TwentyEight.ReadOnly = True
        '
        'TwentyNine
        '
        Me.TwentyNine.HeaderText = "29"
        Me.TwentyNine.Name = "TwentyNine"
        Me.TwentyNine.ReadOnly = True
        '
        'Thirty
        '
        Me.Thirty.HeaderText = "30"
        Me.Thirty.Name = "Thirty"
        Me.Thirty.ReadOnly = True
        '
        'ThirtyOne
        '
        Me.ThirtyOne.HeaderText = "31"
        Me.ThirtyOne.Name = "ThirtyOne"
        Me.ThirtyOne.ReadOnly = True
        '
        'FrmATTENDANCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(988, 626)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmATTENDANCE"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Attendance"
        Me.Panel2.ResumeLayout(False)
        Me.dgv_panel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_employees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgv_panel As System.Windows.Forms.Panel
    Friend WithEvents grpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents cb_Approved As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_approved As System.Windows.Forms.ComboBox
    Friend WithEvents dt_toAdjustment As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt_fromAdjustment As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents cb_remarks As System.Windows.Forms.CheckBox
    Friend WithEvents cb_adjustmentDate As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Type As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_type As System.Windows.Forms.ComboBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents cb_name As System.Windows.Forms.CheckBox
    Friend WithEvents txt_employeeID As System.Windows.Forms.TextBox
    Friend WithEvents cb_employeeID As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_dateYear As System.Windows.Forms.Label
    Friend WithEvents dgv_employees As System.Windows.Forms.DataGridView
    Friend WithEvents Employee_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Employee_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents One As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Two As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Three As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Four As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Five As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Six As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Seven As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eleven As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Twelve As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Thirteen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fourteen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fifteen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sixteen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Seventeen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eighteen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nineteen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Twenty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TwentyOne As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TwentyTwo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TwentyThree As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TwentyFour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TwentyFive As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TwentySix As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TwentySeven As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TwentyEight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TwentyNine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Thirty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThirtyOne As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
