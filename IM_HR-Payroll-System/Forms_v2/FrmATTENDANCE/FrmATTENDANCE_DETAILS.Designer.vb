<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmATTENDANCE_DETAILS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmATTENDANCE_DETAILS))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_encodedBy = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_halfDay = New System.Windows.Forms.Button()
        Me.dgv_employees = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_absent = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_numWFH = New System.Windows.Forms.TextBox()
        Me.txt_numUndertime = New System.Windows.Forms.TextBox()
        Me.txt_numLate = New System.Windows.Forms.TextBox()
        Me.txt_numOnLeave = New System.Windows.Forms.TextBox()
        Me.txt_numAbsent = New System.Windows.Forms.TextBox()
        Me.txt_numHalfDay = New System.Windows.Forms.TextBox()
        Me.txt_numOnDuty = New System.Windows.Forms.TextBox()
        Me.txt_numEmployees = New System.Windows.Forms.TextBox()
        Me.dt_attendanceDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.grpEmployees = New System.Windows.Forms.GroupBox()
        Me.btn_cancelSubmit = New System.Windows.Forms.Button()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.cmb_employees = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Employee_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Employee_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Employment_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shift_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Attendance_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Late_Mins = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Undertime_Mins = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shift_Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shift_TimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shift_TimeOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lunch_TimeOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lunch_TimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Late_TimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Morning_Undertime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Afternoon_Undertime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Updated_By = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_employees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpEmployees.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbl_encodedBy)
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_Save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.Location = New System.Drawing.Point(0, 662)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(991, 50)
        Me.Panel2.TabIndex = 41
        '
        'lbl_encodedBy
        '
        Me.lbl_encodedBy.AutoSize = True
        Me.lbl_encodedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_encodedBy.Location = New System.Drawing.Point(16, 15)
        Me.lbl_encodedBy.Name = "lbl_encodedBy"
        Me.lbl_encodedBy.Size = New System.Drawing.Size(92, 17)
        Me.lbl_encodedBy.TabIndex = 20
        Me.lbl_encodedBy.Text = "Encoded By :"
        Me.lbl_encodedBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Cancel.Location = New System.Drawing.Point(911, 8)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_Cancel.TabIndex = 19
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Save.Location = New System.Drawing.Point(835, 8)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(70, 30)
        Me.btn_Save.TabIndex = 18
        Me.btn_Save.Text = "&Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label_ID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(991, 50)
        Me.Panel1.TabIndex = 40
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label_ID
        '
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label_ID.Location = New System.Drawing.Point(727, 10)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(60, 31)
        Me.Label_ID.TabIndex = 5
        Me.Label_ID.Text = "ID#"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(45, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Attendance Details"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10, 5, 10, 10)
        Me.Panel3.Size = New System.Drawing.Size(991, 612)
        Me.Panel3.TabIndex = 42
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Size = New System.Drawing.Size(971, 481)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.grpEmployees)
        Me.Panel4.Controls.Add(Me.btn_insert)
        Me.Panel4.Controls.Add(Me.btn_halfDay)
        Me.Panel4.Controls.Add(Me.dgv_employees)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.btn_absent)
        Me.Panel4.Controls.Add(Me.btn_update)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel4.Location = New System.Drawing.Point(0, 13)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel4.Size = New System.Drawing.Size(971, 468)
        Me.Panel4.TabIndex = 0
        '
        'btn_halfDay
        '
        Me.btn_halfDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_halfDay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_halfDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_halfDay.ImageKey = "plus.png"
        Me.btn_halfDay.Location = New System.Drawing.Point(262, 432)
        Me.btn_halfDay.Name = "btn_halfDay"
        Me.btn_halfDay.Size = New System.Drawing.Size(75, 30)
        Me.btn_halfDay.TabIndex = 62
        Me.btn_halfDay.Text = "Half-Day"
        Me.btn_halfDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_halfDay.UseVisualStyleBackColor = True
        '
        'dgv_employees
        '
        Me.dgv_employees.AllowUserToAddRows = False
        Me.dgv_employees.AllowUserToDeleteRows = False
        Me.dgv_employees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_employees.BackgroundColor = System.Drawing.Color.White
        Me.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_employees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Employee_ID, Me.Employee_Name, Me.Employment_Status, Me.Shift_Code, Me.Attendance_Status, Me.Late_Mins, Me.Undertime_Mins, Me.Shift_Time, Me.Shift_TimeIn, Me.Shift_TimeOut, Me.Lunch_TimeOut, Me.Lunch_TimeIn, Me.Late_TimeIn, Me.Morning_Undertime, Me.Afternoon_Undertime, Me.Remarks, Me.Updated_By})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_employees.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_employees.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv_employees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_employees.Location = New System.Drawing.Point(3, 3)
        Me.dgv_employees.MultiSelect = False
        Me.dgv_employees.Name = "dgv_employees"
        Me.dgv_employees.ReadOnly = True
        Me.dgv_employees.RowHeadersVisible = False
        Me.dgv_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_employees.ShowCellErrors = False
        Me.dgv_employees.ShowCellToolTips = False
        Me.dgv_employees.ShowEditingIcon = False
        Me.dgv_employees.ShowRowErrors = False
        Me.dgv_employees.Size = New System.Drawing.Size(965, 424)
        Me.dgv_employees.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(166, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 17)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "|"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_absent
        '
        Me.btn_absent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_absent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_absent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_absent.ImageKey = "plus.png"
        Me.btn_absent.Location = New System.Drawing.Point(181, 432)
        Me.btn_absent.Name = "btn_absent"
        Me.btn_absent.Size = New System.Drawing.Size(75, 30)
        Me.btn_absent.TabIndex = 60
        Me.btn_absent.Text = "Absent"
        Me.btn_absent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_absent.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_update.ImageKey = "plus.png"
        Me.btn_update.Location = New System.Drawing.Point(87, 432)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 30)
        Me.btn_update.TabIndex = 58
        Me.btn_update.Text = "Update"
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_remarks)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_numWFH)
        Me.GroupBox1.Controls.Add(Me.txt_numUndertime)
        Me.GroupBox1.Controls.Add(Me.txt_numLate)
        Me.GroupBox1.Controls.Add(Me.txt_numOnLeave)
        Me.GroupBox1.Controls.Add(Me.txt_numAbsent)
        Me.GroupBox1.Controls.Add(Me.txt_numHalfDay)
        Me.GroupBox1.Controls.Add(Me.txt_numOnDuty)
        Me.GroupBox1.Controls.Add(Me.txt_numEmployees)
        Me.GroupBox1.Controls.Add(Me.dt_attendanceDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(971, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txt_remarks
        '
        Me.txt_remarks.Location = New System.Drawing.Point(737, 40)
        Me.txt_remarks.Multiline = True
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(221, 63)
        Me.txt_remarks.TabIndex = 14
        Me.txt_remarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(734, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Remarks :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_numWFH
        '
        Me.txt_numWFH.Location = New System.Drawing.Point(657, 85)
        Me.txt_numWFH.Name = "txt_numWFH"
        Me.txt_numWFH.ReadOnly = True
        Me.txt_numWFH.Size = New System.Drawing.Size(46, 23)
        Me.txt_numWFH.TabIndex = 12
        Me.txt_numWFH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_numUndertime
        '
        Me.txt_numUndertime.Location = New System.Drawing.Point(657, 51)
        Me.txt_numUndertime.Name = "txt_numUndertime"
        Me.txt_numUndertime.ReadOnly = True
        Me.txt_numUndertime.Size = New System.Drawing.Size(46, 23)
        Me.txt_numUndertime.TabIndex = 11
        Me.txt_numUndertime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_numLate
        '
        Me.txt_numLate.Location = New System.Drawing.Point(657, 17)
        Me.txt_numLate.Name = "txt_numLate"
        Me.txt_numLate.ReadOnly = True
        Me.txt_numLate.Size = New System.Drawing.Size(46, 23)
        Me.txt_numLate.TabIndex = 10
        Me.txt_numLate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_numOnLeave
        '
        Me.txt_numOnLeave.Location = New System.Drawing.Point(429, 85)
        Me.txt_numOnLeave.Name = "txt_numOnLeave"
        Me.txt_numOnLeave.ReadOnly = True
        Me.txt_numOnLeave.Size = New System.Drawing.Size(46, 23)
        Me.txt_numOnLeave.TabIndex = 9
        Me.txt_numOnLeave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_numAbsent
        '
        Me.txt_numAbsent.Location = New System.Drawing.Point(429, 51)
        Me.txt_numAbsent.Name = "txt_numAbsent"
        Me.txt_numAbsent.ReadOnly = True
        Me.txt_numAbsent.Size = New System.Drawing.Size(46, 23)
        Me.txt_numAbsent.TabIndex = 8
        Me.txt_numAbsent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_numHalfDay
        '
        Me.txt_numHalfDay.Location = New System.Drawing.Point(429, 17)
        Me.txt_numHalfDay.Name = "txt_numHalfDay"
        Me.txt_numHalfDay.ReadOnly = True
        Me.txt_numHalfDay.Size = New System.Drawing.Size(46, 23)
        Me.txt_numHalfDay.TabIndex = 7
        Me.txt_numHalfDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_numOnDuty
        '
        Me.txt_numOnDuty.Location = New System.Drawing.Point(152, 85)
        Me.txt_numOnDuty.Name = "txt_numOnDuty"
        Me.txt_numOnDuty.ReadOnly = True
        Me.txt_numOnDuty.Size = New System.Drawing.Size(46, 23)
        Me.txt_numOnDuty.TabIndex = 6
        Me.txt_numOnDuty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_numEmployees
        '
        Me.txt_numEmployees.Location = New System.Drawing.Point(152, 51)
        Me.txt_numEmployees.Name = "txt_numEmployees"
        Me.txt_numEmployees.ReadOnly = True
        Me.txt_numEmployees.Size = New System.Drawing.Size(46, 23)
        Me.txt_numEmployees.TabIndex = 5
        Me.txt_numEmployees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dt_attendanceDate
        '
        Me.dt_attendanceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_attendanceDate.Location = New System.Drawing.Point(152, 18)
        Me.dt_attendanceDate.Name = "dt_attendanceDate"
        Me.dt_attendanceDate.Size = New System.Drawing.Size(107, 23)
        Me.dt_attendanceDate.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(500, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 85)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Late Employees :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Undertime Employees :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WFH Employees :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(275, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 85)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Half-Day Employees :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Absent Employees :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "On-Leave Employees :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 85)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Attendance Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No. of Employees :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "On-Duty Employees :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_insert
        '
        Me.btn_insert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_insert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_insert.ImageKey = "plus.png"
        Me.btn_insert.Location = New System.Drawing.Point(6, 432)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(75, 30)
        Me.btn_insert.TabIndex = 63
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'grpEmployees
        '
        Me.grpEmployees.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.grpEmployees.Controls.Add(Me.btn_cancelSubmit)
        Me.grpEmployees.Controls.Add(Me.btn_submit)
        Me.grpEmployees.Controls.Add(Me.cmb_employees)
        Me.grpEmployees.Controls.Add(Me.Label7)
        Me.grpEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grpEmployees.Location = New System.Drawing.Point(273, 134)
        Me.grpEmployees.Name = "grpEmployees"
        Me.grpEmployees.Size = New System.Drawing.Size(424, 89)
        Me.grpEmployees.TabIndex = 64
        Me.grpEmployees.TabStop = False
        Me.grpEmployees.Text = "Add Employee Attendance"
        Me.grpEmployees.Visible = False
        '
        'btn_cancelSubmit
        '
        Me.btn_cancelSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_cancelSubmit.Location = New System.Drawing.Point(341, 51)
        Me.btn_cancelSubmit.Name = "btn_cancelSubmit"
        Me.btn_cancelSubmit.Size = New System.Drawing.Size(70, 30)
        Me.btn_cancelSubmit.TabIndex = 44
        Me.btn_cancelSubmit.Text = "&Cancel"
        Me.btn_cancelSubmit.UseVisualStyleBackColor = True
        '
        'btn_submit
        '
        Me.btn_submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_submit.Location = New System.Drawing.Point(265, 51)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(70, 30)
        Me.btn_submit.TabIndex = 43
        Me.btn_submit.Text = "&Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'cmb_employees
        '
        Me.cmb_employees.DropDownHeight = 300
        Me.cmb_employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_employees.FormattingEnabled = True
        Me.cmb_employees.IntegralHeight = False
        Me.cmb_employees.Location = New System.Drawing.Point(90, 17)
        Me.cmb_employees.Name = "cmb_employees"
        Me.cmb_employees.Size = New System.Drawing.Size(321, 24)
        Me.cmb_employees.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(6, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Employee :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Employment_Status
        '
        Me.Employment_Status.HeaderText = "Employment Status"
        Me.Employment_Status.Name = "Employment_Status"
        Me.Employment_Status.ReadOnly = True
        Me.Employment_Status.Width = 150
        '
        'Shift_Code
        '
        Me.Shift_Code.HeaderText = "Shift Code"
        Me.Shift_Code.Name = "Shift_Code"
        Me.Shift_Code.ReadOnly = True
        '
        'Attendance_Status
        '
        Me.Attendance_Status.HeaderText = "Attendance Status"
        Me.Attendance_Status.Name = "Attendance_Status"
        Me.Attendance_Status.ReadOnly = True
        '
        'Late_Mins
        '
        Me.Late_Mins.HeaderText = "Late (Min.)"
        Me.Late_Mins.Name = "Late_Mins"
        Me.Late_Mins.ReadOnly = True
        '
        'Undertime_Mins
        '
        Me.Undertime_Mins.HeaderText = "Undertime (Min.)"
        Me.Undertime_Mins.Name = "Undertime_Mins"
        Me.Undertime_Mins.ReadOnly = True
        '
        'Shift_Time
        '
        Me.Shift_Time.HeaderText = "Shift Time"
        Me.Shift_Time.Name = "Shift_Time"
        Me.Shift_Time.ReadOnly = True
        '
        'Shift_TimeIn
        '
        Me.Shift_TimeIn.HeaderText = "Shift Time-In"
        Me.Shift_TimeIn.Name = "Shift_TimeIn"
        Me.Shift_TimeIn.ReadOnly = True
        Me.Shift_TimeIn.Visible = False
        '
        'Shift_TimeOut
        '
        Me.Shift_TimeOut.HeaderText = "Shift Time-Out"
        Me.Shift_TimeOut.Name = "Shift_TimeOut"
        Me.Shift_TimeOut.ReadOnly = True
        Me.Shift_TimeOut.Visible = False
        '
        'Lunch_TimeOut
        '
        Me.Lunch_TimeOut.HeaderText = "Lunch Time-Out"
        Me.Lunch_TimeOut.Name = "Lunch_TimeOut"
        Me.Lunch_TimeOut.ReadOnly = True
        Me.Lunch_TimeOut.Visible = False
        '
        'Lunch_TimeIn
        '
        Me.Lunch_TimeIn.HeaderText = "Lunch Time-In"
        Me.Lunch_TimeIn.Name = "Lunch_TimeIn"
        Me.Lunch_TimeIn.ReadOnly = True
        Me.Lunch_TimeIn.Visible = False
        '
        'Late_TimeIn
        '
        Me.Late_TimeIn.HeaderText = "Late Time-In"
        Me.Late_TimeIn.Name = "Late_TimeIn"
        Me.Late_TimeIn.ReadOnly = True
        '
        'Morning_Undertime
        '
        Me.Morning_Undertime.HeaderText = "AM Undertime"
        Me.Morning_Undertime.Name = "Morning_Undertime"
        Me.Morning_Undertime.ReadOnly = True
        '
        'Afternoon_Undertime
        '
        Me.Afternoon_Undertime.HeaderText = "PM Undertime"
        Me.Afternoon_Undertime.Name = "Afternoon_Undertime"
        Me.Afternoon_Undertime.ReadOnly = True
        '
        'Remarks
        '
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        Me.Remarks.Width = 250
        '
        'Updated_By
        '
        Me.Updated_By.HeaderText = "Update By"
        Me.Updated_By.Name = "Updated_By"
        Me.Updated_By.ReadOnly = True
        '
        'FrmATTENDANCE_DETAILS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(991, 712)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmATTENDANCE_DETAILS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance Details"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgv_employees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpEmployees.ResumeLayout(False)
        Me.grpEmployees.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_encodedBy As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label_ID As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dgv_employees As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_absent As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_attendanceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_numWFH As System.Windows.Forms.TextBox
    Friend WithEvents txt_numUndertime As System.Windows.Forms.TextBox
    Friend WithEvents txt_numLate As System.Windows.Forms.TextBox
    Friend WithEvents txt_numOnLeave As System.Windows.Forms.TextBox
    Friend WithEvents txt_numAbsent As System.Windows.Forms.TextBox
    Friend WithEvents txt_numHalfDay As System.Windows.Forms.TextBox
    Friend WithEvents txt_numOnDuty As System.Windows.Forms.TextBox
    Friend WithEvents txt_numEmployees As System.Windows.Forms.TextBox
    Friend WithEvents btn_halfDay As System.Windows.Forms.Button
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents grpEmployees As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancelSubmit As System.Windows.Forms.Button
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents cmb_employees As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Employee_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Employee_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Employment_Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Shift_Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Attendance_Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Late_Mins As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Undertime_Mins As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Shift_Time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Shift_TimeIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Shift_TimeOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lunch_TimeOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lunch_TimeIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Late_TimeIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Morning_Undertime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Afternoon_Undertime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Updated_By As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
