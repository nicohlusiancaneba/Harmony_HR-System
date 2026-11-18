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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmATTENDANCE))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_panel = New System.Windows.Forms.Panel()
        Me.tabControl_Attendance = New System.Windows.Forms.TabControl()
        Me.Tab_Monitoring = New System.Windows.Forms.TabPage()
        Me.dgv_employees = New System.Windows.Forms.DataGridView()
        Me.Employee_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Employee_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Employment_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_dateYear = New System.Windows.Forms.Label()
        Me.Tab_Record = New System.Windows.Forms.TabPage()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.dt_toAttendance = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_fromAttendance = New System.Windows.Forms.DateTimePicker()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.cb_remarks = New System.Windows.Forms.CheckBox()
        Me.cb_attendanceDate = New System.Windows.Forms.CheckBox()
        Me.txt_attendanceID = New System.Windows.Forms.TextBox()
        Me.cb_attendanceID = New System.Windows.Forms.CheckBox()
        Me.lst_attendance = New System.Windows.Forms.ListView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.dgv_panel.SuspendLayout()
        Me.tabControl_Attendance.SuspendLayout()
        Me.Tab_Monitoring.SuspendLayout()
        CType(Me.dgv_employees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Tab_Record.SuspendLayout()
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
        Me.dgv_panel.Controls.Add(Me.tabControl_Attendance)
        Me.dgv_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_panel.Location = New System.Drawing.Point(10, 10)
        Me.dgv_panel.Name = "dgv_panel"
        Me.dgv_panel.Padding = New System.Windows.Forms.Padding(5)
        Me.dgv_panel.Size = New System.Drawing.Size(968, 534)
        Me.dgv_panel.TabIndex = 706
        '
        'tabControl_Attendance
        '
        Me.tabControl_Attendance.Controls.Add(Me.Tab_Monitoring)
        Me.tabControl_Attendance.Controls.Add(Me.Tab_Record)
        Me.tabControl_Attendance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl_Attendance.Location = New System.Drawing.Point(5, 5)
        Me.tabControl_Attendance.Name = "tabControl_Attendance"
        Me.tabControl_Attendance.SelectedIndex = 0
        Me.tabControl_Attendance.Size = New System.Drawing.Size(958, 524)
        Me.tabControl_Attendance.TabIndex = 708
        '
        'Tab_Monitoring
        '
        Me.Tab_Monitoring.BackColor = System.Drawing.Color.White
        Me.Tab_Monitoring.Controls.Add(Me.dgv_employees)
        Me.Tab_Monitoring.Controls.Add(Me.Panel3)
        Me.Tab_Monitoring.Location = New System.Drawing.Point(4, 25)
        Me.Tab_Monitoring.Name = "Tab_Monitoring"
        Me.Tab_Monitoring.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Monitoring.Size = New System.Drawing.Size(950, 495)
        Me.Tab_Monitoring.TabIndex = 0
        Me.Tab_Monitoring.Text = "Monitoring"
        '
        'dgv_employees
        '
        Me.dgv_employees.AllowUserToAddRows = False
        Me.dgv_employees.AllowUserToDeleteRows = False
        Me.dgv_employees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_employees.BackgroundColor = System.Drawing.Color.White
        Me.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_employees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Employee_ID, Me.Employee_Name, Me.Employment_Status, Me.One, Me.Two, Me.Three, Me.Four, Me.Five, Me.Six, Me.Seven, Me.Eight, Me.Nine, Me.Ten, Me.Eleven, Me.Twelve, Me.Thirteen, Me.Fourteen, Me.Fifteen, Me.Sixteen, Me.Seventeen, Me.Eighteen, Me.Nineteen, Me.Twenty, Me.TwentyOne, Me.TwentyTwo, Me.TwentyThree, Me.TwentyFour, Me.TwentyFive, Me.TwentySix, Me.TwentySeven, Me.TwentyEight, Me.TwentyNine, Me.Thirty, Me.ThirtyOne})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_employees.DefaultCellStyle = DataGridViewCellStyle1
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
        'Employee_ID
        '
        Me.Employee_ID.Frozen = True
        Me.Employee_ID.HeaderText = "Employee ID"
        Me.Employee_ID.Name = "Employee_ID"
        Me.Employee_ID.ReadOnly = True
        Me.Employee_ID.Visible = False
        '
        'Employee_Name
        '
        Me.Employee_Name.Frozen = True
        Me.Employee_Name.HeaderText = "Employee Name"
        Me.Employee_Name.Name = "Employee_Name"
        Me.Employee_Name.ReadOnly = True
        Me.Employee_Name.Width = 200
        '
        'Employment_Status
        '
        Me.Employment_Status.DividerWidth = 5
        Me.Employment_Status.Frozen = True
        Me.Employment_Status.HeaderText = "Employment Status"
        Me.Employment_Status.Name = "Employment_Status"
        Me.Employment_Status.ReadOnly = True
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.lbl_dateYear)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(944, 39)
        Me.Panel3.TabIndex = 708
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(410, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(528, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "L - Late  |  U - Undertime  |  H - Half-Day  |  A - Absent  |  O - On-Leave  |  W" & _
    " - WFH"
        '
        'lbl_dateYear
        '
        Me.lbl_dateYear.AutoSize = True
        Me.lbl_dateYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_dateYear.Location = New System.Drawing.Point(7, 10)
        Me.lbl_dateYear.Name = "lbl_dateYear"
        Me.lbl_dateYear.Size = New System.Drawing.Size(134, 20)
        Me.lbl_dateYear.TabIndex = 0
        Me.lbl_dateYear.Text = "November 2026"
        '
        'Tab_Record
        '
        Me.Tab_Record.BackColor = System.Drawing.Color.White
        Me.Tab_Record.Controls.Add(Me.grpFilter)
        Me.Tab_Record.Controls.Add(Me.lst_attendance)
        Me.Tab_Record.Location = New System.Drawing.Point(4, 25)
        Me.Tab_Record.Name = "Tab_Record"
        Me.Tab_Record.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Record.Size = New System.Drawing.Size(950, 495)
        Me.Tab_Record.TabIndex = 1
        Me.Tab_Record.Text = "Record"
        '
        'grpFilter
        '
        Me.grpFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.grpFilter.Controls.Add(Me.dt_toAttendance)
        Me.grpFilter.Controls.Add(Me.Label2)
        Me.grpFilter.Controls.Add(Me.dt_fromAttendance)
        Me.grpFilter.Controls.Add(Me.btn_submit)
        Me.grpFilter.Controls.Add(Me.btn_cancel)
        Me.grpFilter.Controls.Add(Me.txt_remarks)
        Me.grpFilter.Controls.Add(Me.cb_remarks)
        Me.grpFilter.Controls.Add(Me.cb_attendanceDate)
        Me.grpFilter.Controls.Add(Me.txt_attendanceID)
        Me.grpFilter.Controls.Add(Me.cb_attendanceID)
        Me.grpFilter.Location = New System.Drawing.Point(271, 132)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(392, 146)
        Me.grpFilter.TabIndex = 706
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Search"
        Me.grpFilter.Visible = False
        '
        'dt_toAttendance
        '
        Me.dt_toAttendance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_toAttendance.Location = New System.Drawing.Point(278, 49)
        Me.dt_toAttendance.Name = "dt_toAttendance"
        Me.dt_toAttendance.Size = New System.Drawing.Size(101, 23)
        Me.dt_toAttendance.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(253, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "to"
        '
        'dt_fromAttendance
        '
        Me.dt_fromAttendance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fromAttendance.Location = New System.Drawing.Point(149, 49)
        Me.dt_fromAttendance.Name = "dt_fromAttendance"
        Me.dt_fromAttendance.Size = New System.Drawing.Size(101, 23)
        Me.dt_fromAttendance.TabIndex = 18
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(203, 106)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(85, 30)
        Me.btn_submit.TabIndex = 15
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(294, 106)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(85, 30)
        Me.btn_cancel.TabIndex = 14
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'txt_remarks
        '
        Me.txt_remarks.Location = New System.Drawing.Point(149, 77)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(148, 23)
        Me.txt_remarks.TabIndex = 11
        '
        'cb_remarks
        '
        Me.cb_remarks.AutoSize = True
        Me.cb_remarks.Location = New System.Drawing.Point(15, 79)
        Me.cb_remarks.Name = "cb_remarks"
        Me.cb_remarks.Size = New System.Drawing.Size(83, 21)
        Me.cb_remarks.TabIndex = 10
        Me.cb_remarks.Text = "Remarks"
        Me.cb_remarks.UseVisualStyleBackColor = True
        '
        'cb_attendanceDate
        '
        Me.cb_attendanceDate.AutoSize = True
        Me.cb_attendanceDate.Location = New System.Drawing.Point(15, 50)
        Me.cb_attendanceDate.Name = "cb_attendanceDate"
        Me.cb_attendanceDate.Size = New System.Drawing.Size(133, 21)
        Me.cb_attendanceDate.TabIndex = 8
        Me.cb_attendanceDate.Text = "Attendance Date"
        Me.cb_attendanceDate.UseVisualStyleBackColor = True
        '
        'txt_attendanceID
        '
        Me.txt_attendanceID.Location = New System.Drawing.Point(149, 20)
        Me.txt_attendanceID.Name = "txt_attendanceID"
        Me.txt_attendanceID.Size = New System.Drawing.Size(82, 23)
        Me.txt_attendanceID.TabIndex = 1
        '
        'cb_attendanceID
        '
        Me.cb_attendanceID.AutoSize = True
        Me.cb_attendanceID.Location = New System.Drawing.Point(15, 22)
        Me.cb_attendanceID.Name = "cb_attendanceID"
        Me.cb_attendanceID.Size = New System.Drawing.Size(116, 21)
        Me.cb_attendanceID.TabIndex = 0
        Me.cb_attendanceID.Text = "Attendance ID"
        Me.cb_attendanceID.UseVisualStyleBackColor = True
        '
        'lst_attendance
        '
        Me.lst_attendance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_attendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lst_attendance.FullRowSelect = True
        Me.lst_attendance.GridLines = True
        Me.lst_attendance.Location = New System.Drawing.Point(3, 3)
        Me.lst_attendance.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_attendance.Name = "lst_attendance"
        Me.lst_attendance.Size = New System.Drawing.Size(944, 489)
        Me.lst_attendance.TabIndex = 708
        Me.lst_attendance.UseCompatibleStateImageBehavior = False
        Me.lst_attendance.View = System.Windows.Forms.View.Details
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
        Me.tabControl_Attendance.ResumeLayout(False)
        Me.Tab_Monitoring.ResumeLayout(False)
        CType(Me.dgv_employees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Tab_Record.ResumeLayout(False)
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
    Friend WithEvents dt_toAttendance As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt_fromAttendance As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents cb_remarks As System.Windows.Forms.CheckBox
    Friend WithEvents cb_attendanceDate As System.Windows.Forms.CheckBox
    Friend WithEvents txt_attendanceID As System.Windows.Forms.TextBox
    Friend WithEvents cb_attendanceID As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabControl_Attendance As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Monitoring As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Record As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_dateYear As System.Windows.Forms.Label
    Friend WithEvents dgv_employees As System.Windows.Forms.DataGridView
    Friend WithEvents lst_attendance As System.Windows.Forms.ListView
    Friend WithEvents Employee_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Employee_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Employment_Status As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
