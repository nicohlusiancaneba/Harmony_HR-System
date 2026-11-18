<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSHIFT_DETAILS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSHIFT_DETAILS))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_Approved = New System.Windows.Forms.CheckBox()
        Me.lbl_createdBy = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grpEmployees = New System.Windows.Forms.GroupBox()
        Me.btn_cancelSubmit = New System.Windows.Forms.Button()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.cmb_assignmentType = New System.Windows.Forms.ComboBox()
        Me.cmb_employees = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.dgv_employees = New System.Windows.Forms.DataGridView()
        Me.Employee_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Employee_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Job_Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Assignment_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.num_workingDays = New System.Windows.Forms.TextBox()
        Me.clb_workingDays = New System.Windows.Forms.CheckedListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tp_lunchIn = New System.Windows.Forms.DateTimePicker()
        Me.tp_lunchOut = New System.Windows.Forms.DateTimePicker()
        Me.cmb_nightDiff = New System.Windows.Forms.ComboBox()
        Me.cmb_flexible = New System.Windows.Forms.ComboBox()
        Me.cmb_overnight = New System.Windows.Forms.ComboBox()
        Me.num_requiredHours = New System.Windows.Forms.NumericUpDown()
        Me.num_gracePeriod = New System.Windows.Forms.NumericUpDown()
        Me.txt_shiftCode = New System.Windows.Forms.TextBox()
        Me.txt_shiftParticulars = New System.Windows.Forms.TextBox()
        Me.tp_shiftEnd = New System.Windows.Forms.DateTimePicker()
        Me.tp_shiftStart = New System.Windows.Forms.DateTimePicker()
        Me.tp_overtimeStart = New System.Windows.Forms.DateTimePicker()
        Me.tp_minTimeIn = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpEmployees.SuspendLayout()
        CType(Me.dgv_employees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetails.SuspendLayout()
        CType(Me.num_requiredHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_gracePeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(800, 50)
        Me.Panel1.TabIndex = 39
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
        Me.Label_ID.Location = New System.Drawing.Point(363, 10)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(60, 31)
        Me.Label_ID.TabIndex = 5
        Me.Label_ID.Text = "ID#"
        Me.Label_ID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(45, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Shift Details"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cb_Approved)
        Me.Panel2.Controls.Add(Me.lbl_createdBy)
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_Save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.Location = New System.Drawing.Point(0, 668)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 50)
        Me.Panel2.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(604, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 17)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "|"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cb_Approved
        '
        Me.cb_Approved.AutoSize = True
        Me.cb_Approved.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_Approved.Location = New System.Drawing.Point(512, 13)
        Me.cb_Approved.Name = "cb_Approved"
        Me.cb_Approved.Size = New System.Drawing.Size(88, 21)
        Me.cb_Approved.TabIndex = 39
        Me.cb_Approved.Text = "Approved"
        Me.cb_Approved.UseVisualStyleBackColor = True
        '
        'lbl_createdBy
        '
        Me.lbl_createdBy.AutoSize = True
        Me.lbl_createdBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_createdBy.Location = New System.Drawing.Point(16, 15)
        Me.lbl_createdBy.Name = "lbl_createdBy"
        Me.lbl_createdBy.Size = New System.Drawing.Size(86, 17)
        Me.lbl_createdBy.TabIndex = 20
        Me.lbl_createdBy.Text = "Created By :"
        Me.lbl_createdBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Cancel.Location = New System.Drawing.Point(699, 8)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_Cancel.TabIndex = 19
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Save.Location = New System.Drawing.Point(623, 8)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(70, 30)
        Me.btn_Save.TabIndex = 18
        Me.btn_Save.Text = "&Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.grpDetails)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10, 5, 10, 10)
        Me.Panel3.Size = New System.Drawing.Size(800, 618)
        Me.Panel3.TabIndex = 41
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grpEmployees)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btn_delete)
        Me.GroupBox2.Controls.Add(Me.btn_edit)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Controls.Add(Me.dgv_employees)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(780, 385)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employees"
        '
        'grpEmployees
        '
        Me.grpEmployees.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.grpEmployees.Controls.Add(Me.btn_cancelSubmit)
        Me.grpEmployees.Controls.Add(Me.btn_submit)
        Me.grpEmployees.Controls.Add(Me.txt_remarks)
        Me.grpEmployees.Controls.Add(Me.cmb_assignmentType)
        Me.grpEmployees.Controls.Add(Me.cmb_employees)
        Me.grpEmployees.Controls.Add(Me.Label6)
        Me.grpEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grpEmployees.Location = New System.Drawing.Point(179, 88)
        Me.grpEmployees.Name = "grpEmployees"
        Me.grpEmployees.Size = New System.Drawing.Size(424, 200)
        Me.grpEmployees.TabIndex = 58
        Me.grpEmployees.TabStop = False
        Me.grpEmployees.Visible = False
        '
        'btn_cancelSubmit
        '
        Me.btn_cancelSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_cancelSubmit.Location = New System.Drawing.Point(341, 162)
        Me.btn_cancelSubmit.Name = "btn_cancelSubmit"
        Me.btn_cancelSubmit.Size = New System.Drawing.Size(70, 30)
        Me.btn_cancelSubmit.TabIndex = 44
        Me.btn_cancelSubmit.Text = "&Cancel"
        Me.btn_cancelSubmit.UseVisualStyleBackColor = True
        '
        'btn_submit
        '
        Me.btn_submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_submit.Location = New System.Drawing.Point(265, 162)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(70, 30)
        Me.btn_submit.TabIndex = 43
        Me.btn_submit.Text = "&Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'txt_remarks
        '
        Me.txt_remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_remarks.Location = New System.Drawing.Point(135, 81)
        Me.txt_remarks.Multiline = True
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(276, 75)
        Me.txt_remarks.TabIndex = 18
        Me.txt_remarks.Tag = "inputText"
        '
        'cmb_assignmentType
        '
        Me.cmb_assignmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_assignmentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_assignmentType.FormattingEnabled = True
        Me.cmb_assignmentType.Items.AddRange(New Object() {"Permanent", "Rotating", "Temporary", "Training"})
        Me.cmb_assignmentType.Location = New System.Drawing.Point(135, 47)
        Me.cmb_assignmentType.Name = "cmb_assignmentType"
        Me.cmb_assignmentType.Size = New System.Drawing.Size(131, 24)
        Me.cmb_assignmentType.TabIndex = 17
        '
        'cmb_employees
        '
        Me.cmb_employees.DropDownHeight = 300
        Me.cmb_employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_employees.FormattingEnabled = True
        Me.cmb_employees.IntegralHeight = False
        Me.cmb_employees.Location = New System.Drawing.Point(135, 13)
        Me.cmb_employees.Name = "cmb_employees"
        Me.cmb_employees.Size = New System.Drawing.Size(276, 24)
        Me.cmb_employees.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 85)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Employee :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Assignment Type :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remarks :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(166, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 17)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "|"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_delete.ImageKey = "plus.png"
        Me.btn_delete.Location = New System.Drawing.Point(181, 347)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 30)
        Me.btn_delete.TabIndex = 56
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_edit.ImageKey = "plus.png"
        Me.btn_edit.Location = New System.Drawing.Point(87, 347)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 30)
        Me.btn_edit.TabIndex = 55
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_add.ImageKey = "plus.png"
        Me.btn_add.Location = New System.Drawing.Point(6, 347)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 30)
        Me.btn_add.TabIndex = 54
        Me.btn_add.Text = "Add"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'dgv_employees
        '
        Me.dgv_employees.AllowUserToAddRows = False
        Me.dgv_employees.AllowUserToDeleteRows = False
        Me.dgv_employees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_employees.BackgroundColor = System.Drawing.Color.White
        Me.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_employees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Employee_ID, Me.Employee_Name, Me.Job_Title, Me.Department, Me.Assignment_Type, Me.Remarks})
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
        Me.dgv_employees.Location = New System.Drawing.Point(3, 19)
        Me.dgv_employees.MultiSelect = False
        Me.dgv_employees.Name = "dgv_employees"
        Me.dgv_employees.ReadOnly = True
        Me.dgv_employees.RowHeadersVisible = False
        Me.dgv_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_employees.ShowCellErrors = False
        Me.dgv_employees.ShowCellToolTips = False
        Me.dgv_employees.ShowEditingIcon = False
        Me.dgv_employees.ShowRowErrors = False
        Me.dgv_employees.Size = New System.Drawing.Size(767, 322)
        Me.dgv_employees.TabIndex = 41
        '
        'Employee_ID
        '
        Me.Employee_ID.HeaderText = "Employee ID"
        Me.Employee_ID.Name = "Employee_ID"
        Me.Employee_ID.ReadOnly = True
        Me.Employee_ID.Width = 80
        '
        'Employee_Name
        '
        Me.Employee_Name.HeaderText = "Employee Name"
        Me.Employee_Name.Name = "Employee_Name"
        Me.Employee_Name.ReadOnly = True
        Me.Employee_Name.Width = 200
        '
        'Job_Title
        '
        Me.Job_Title.HeaderText = "Job Title"
        Me.Job_Title.Name = "Job_Title"
        Me.Job_Title.ReadOnly = True
        Me.Job_Title.Width = 150
        '
        'Department
        '
        Me.Department.HeaderText = "Department"
        Me.Department.Name = "Department"
        Me.Department.ReadOnly = True
        Me.Department.Width = 150
        '
        'Assignment_Type
        '
        Me.Assignment_Type.HeaderText = "Assignment Type"
        Me.Assignment_Type.Name = "Assignment_Type"
        Me.Assignment_Type.ReadOnly = True
        '
        'Remarks
        '
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.Label8)
        Me.grpDetails.Controls.Add(Me.num_workingDays)
        Me.grpDetails.Controls.Add(Me.clb_workingDays)
        Me.grpDetails.Controls.Add(Me.Label7)
        Me.grpDetails.Controls.Add(Me.tp_lunchIn)
        Me.grpDetails.Controls.Add(Me.tp_lunchOut)
        Me.grpDetails.Controls.Add(Me.cmb_nightDiff)
        Me.grpDetails.Controls.Add(Me.cmb_flexible)
        Me.grpDetails.Controls.Add(Me.cmb_overnight)
        Me.grpDetails.Controls.Add(Me.num_requiredHours)
        Me.grpDetails.Controls.Add(Me.num_gracePeriod)
        Me.grpDetails.Controls.Add(Me.txt_shiftCode)
        Me.grpDetails.Controls.Add(Me.txt_shiftParticulars)
        Me.grpDetails.Controls.Add(Me.tp_shiftEnd)
        Me.grpDetails.Controls.Add(Me.tp_shiftStart)
        Me.grpDetails.Controls.Add(Me.tp_overtimeStart)
        Me.grpDetails.Controls.Add(Me.tp_minTimeIn)
        Me.grpDetails.Controls.Add(Me.Label3)
        Me.grpDetails.Controls.Add(Me.Label1)
        Me.grpDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.grpDetails.Location = New System.Drawing.Point(10, 5)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(780, 218)
        Me.grpDetails.TabIndex = 0
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Shift Details"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(645, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Working Days :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'num_workingDays
        '
        Me.num_workingDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.num_workingDays.Location = New System.Drawing.Point(553, 82)
        Me.num_workingDays.Name = "num_workingDays"
        Me.num_workingDays.ReadOnly = True
        Me.num_workingDays.Size = New System.Drawing.Size(54, 23)
        Me.num_workingDays.TabIndex = 19
        Me.num_workingDays.Tag = "inputText"
        Me.num_workingDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'clb_workingDays
        '
        Me.clb_workingDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.clb_workingDays.FormattingEnabled = True
        Me.clb_workingDays.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.clb_workingDays.Location = New System.Drawing.Point(653, 36)
        Me.clb_workingDays.Name = "clb_workingDays"
        Me.clb_workingDays.Size = New System.Drawing.Size(111, 130)
        Me.clb_workingDays.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(229, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 51)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tp_lunchIn
        '
        Me.tp_lunchIn.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_lunchIn.CustomFormat = "hh:mm tt"
        Me.tp_lunchIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_lunchIn.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.tp_lunchIn.Location = New System.Drawing.Point(252, 116)
        Me.tp_lunchIn.Name = "tp_lunchIn"
        Me.tp_lunchIn.ShowUpDown = True
        Me.tp_lunchIn.Size = New System.Drawing.Size(99, 23)
        Me.tp_lunchIn.TabIndex = 16
        Me.tp_lunchIn.Value = New Date(2026, 10, 26, 13, 0, 0, 0)
        '
        'tp_lunchOut
        '
        Me.tp_lunchOut.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_lunchOut.CustomFormat = "hh:mm tt"
        Me.tp_lunchOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_lunchOut.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.tp_lunchOut.Location = New System.Drawing.Point(127, 116)
        Me.tp_lunchOut.Name = "tp_lunchOut"
        Me.tp_lunchOut.ShowUpDown = True
        Me.tp_lunchOut.Size = New System.Drawing.Size(99, 23)
        Me.tp_lunchOut.TabIndex = 15
        Me.tp_lunchOut.Value = New Date(2026, 10, 26, 12, 0, 0, 0)
        '
        'cmb_nightDiff
        '
        Me.cmb_nightDiff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nightDiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_nightDiff.FormattingEnabled = True
        Me.cmb_nightDiff.Items.AddRange(New Object() {"No", "Yes"})
        Me.cmb_nightDiff.Location = New System.Drawing.Point(553, 185)
        Me.cmb_nightDiff.Name = "cmb_nightDiff"
        Me.cmb_nightDiff.Size = New System.Drawing.Size(54, 24)
        Me.cmb_nightDiff.TabIndex = 14
        '
        'cmb_flexible
        '
        Me.cmb_flexible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_flexible.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_flexible.FormattingEnabled = True
        Me.cmb_flexible.Items.AddRange(New Object() {"No", "Yes"})
        Me.cmb_flexible.Location = New System.Drawing.Point(553, 150)
        Me.cmb_flexible.Name = "cmb_flexible"
        Me.cmb_flexible.Size = New System.Drawing.Size(54, 24)
        Me.cmb_flexible.TabIndex = 13
        '
        'cmb_overnight
        '
        Me.cmb_overnight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_overnight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_overnight.FormattingEnabled = True
        Me.cmb_overnight.Items.AddRange(New Object() {"No", "Yes"})
        Me.cmb_overnight.Location = New System.Drawing.Point(553, 116)
        Me.cmb_overnight.Name = "cmb_overnight"
        Me.cmb_overnight.Size = New System.Drawing.Size(54, 24)
        Me.cmb_overnight.TabIndex = 12
        '
        'num_requiredHours
        '
        Me.num_requiredHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.num_requiredHours.Location = New System.Drawing.Point(553, 49)
        Me.num_requiredHours.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.num_requiredHours.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_requiredHours.Name = "num_requiredHours"
        Me.num_requiredHours.Size = New System.Drawing.Size(54, 23)
        Me.num_requiredHours.TabIndex = 11
        Me.num_requiredHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_requiredHours.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'num_gracePeriod
        '
        Me.num_gracePeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.num_gracePeriod.Location = New System.Drawing.Point(553, 16)
        Me.num_gracePeriod.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.num_gracePeriod.Name = "num_gracePeriod"
        Me.num_gracePeriod.Size = New System.Drawing.Size(54, 23)
        Me.num_gracePeriod.TabIndex = 9
        Me.num_gracePeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_shiftCode
        '
        Me.txt_shiftCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_shiftCode.Location = New System.Drawing.Point(127, 12)
        Me.txt_shiftCode.Name = "txt_shiftCode"
        Me.txt_shiftCode.Size = New System.Drawing.Size(92, 23)
        Me.txt_shiftCode.TabIndex = 8
        Me.txt_shiftCode.Tag = "inputText"
        '
        'txt_shiftParticulars
        '
        Me.txt_shiftParticulars.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_shiftParticulars.Location = New System.Drawing.Point(127, 47)
        Me.txt_shiftParticulars.Name = "txt_shiftParticulars"
        Me.txt_shiftParticulars.Size = New System.Drawing.Size(241, 23)
        Me.txt_shiftParticulars.TabIndex = 7
        Me.txt_shiftParticulars.Tag = "inputText"
        '
        'tp_shiftEnd
        '
        Me.tp_shiftEnd.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_shiftEnd.CustomFormat = "hh:mm tt"
        Me.tp_shiftEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_shiftEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.tp_shiftEnd.Location = New System.Drawing.Point(252, 82)
        Me.tp_shiftEnd.Name = "tp_shiftEnd"
        Me.tp_shiftEnd.ShowUpDown = True
        Me.tp_shiftEnd.Size = New System.Drawing.Size(99, 23)
        Me.tp_shiftEnd.TabIndex = 6
        Me.tp_shiftEnd.Value = New Date(2026, 10, 26, 17, 0, 0, 0)
        '
        'tp_shiftStart
        '
        Me.tp_shiftStart.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_shiftStart.CustomFormat = "hh:mm tt"
        Me.tp_shiftStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_shiftStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.tp_shiftStart.Location = New System.Drawing.Point(127, 83)
        Me.tp_shiftStart.Name = "tp_shiftStart"
        Me.tp_shiftStart.ShowUpDown = True
        Me.tp_shiftStart.Size = New System.Drawing.Size(99, 23)
        Me.tp_shiftStart.TabIndex = 5
        Me.tp_shiftStart.Value = New Date(2026, 10, 26, 8, 0, 0, 0)
        '
        'tp_overtimeStart
        '
        Me.tp_overtimeStart.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_overtimeStart.CustomFormat = "hh:mm tt"
        Me.tp_overtimeStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_overtimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.tp_overtimeStart.Location = New System.Drawing.Point(127, 185)
        Me.tp_overtimeStart.Name = "tp_overtimeStart"
        Me.tp_overtimeStart.ShowUpDown = True
        Me.tp_overtimeStart.Size = New System.Drawing.Size(99, 23)
        Me.tp_overtimeStart.TabIndex = 4
        Me.tp_overtimeStart.Value = New Date(2026, 10, 26, 17, 30, 0, 0)
        '
        'tp_minTimeIn
        '
        Me.tp_minTimeIn.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_minTimeIn.CustomFormat = "hh:mm tt"
        Me.tp_minTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_minTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.tp_minTimeIn.Location = New System.Drawing.Point(127, 151)
        Me.tp_minTimeIn.Name = "tp_minTimeIn"
        Me.tp_minTimeIn.ShowUpDown = True
        Me.tp_minTimeIn.Size = New System.Drawing.Size(99, 23)
        Me.tp_minTimeIn.TabIndex = 3
        Me.tp_minTimeIn.Value = New Date(2026, 10, 26, 10, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(395, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 187)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Grace Period (Min) :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Required Hour(s) :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Working Days / Week :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Overnight " & _
    ":" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Flexible :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Night Differntial :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 187)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Shift Code :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shift Particulars :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shift Time :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lunch Break :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Min. Time" & _
    " In :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Overtime Start :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmSHIFT_DETAILS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 718)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSHIFT_DETAILS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shift Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpEmployees.ResumeLayout(False)
        Me.grpEmployees.PerformLayout()
        CType(Me.dgv_employees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        CType(Me.num_requiredHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_gracePeriod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label_ID As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_createdBy As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tp_shiftEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents tp_shiftStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents tp_overtimeStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents tp_minTimeIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_shiftCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_shiftParticulars As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_nightDiff As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_flexible As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_overnight As System.Windows.Forms.ComboBox
    Friend WithEvents num_requiredHours As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_gracePeriod As System.Windows.Forms.NumericUpDown
    Friend WithEvents dgv_employees As System.Windows.Forms.DataGridView
    Friend WithEvents Employee_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Employee_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Job_Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Department As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Assignment_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cb_Approved As System.Windows.Forms.CheckBox
    Friend WithEvents grpEmployees As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_employees As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_assignmentType As System.Windows.Forms.ComboBox
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelSubmit As System.Windows.Forms.Button
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents tp_lunchOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tp_lunchIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents num_workingDays As System.Windows.Forms.TextBox
    Friend WithEvents clb_workingDays As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
