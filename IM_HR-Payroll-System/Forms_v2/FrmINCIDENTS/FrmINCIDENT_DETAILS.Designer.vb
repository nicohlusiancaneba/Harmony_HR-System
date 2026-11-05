<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmINCIDENT_DETAILS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmINCIDENT_DETAILS))
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_preparedBy = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Incident_TabControl = New System.Windows.Forms.TabControl()
        Me.Employees_Involved = New System.Windows.Forms.TabPage()
        Me.dgv_employees = New System.Windows.Forms.DataGridView()
        Me.Employee_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Employee_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Job_Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tenure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supervisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Statement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Offenses_Incurred = New System.Windows.Forms.TabPage()
        Me.dgv_offenses = New System.Windows.Forms.DataGridView()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Definition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Offense_Class = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Instance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Employee_ID2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subject_Employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action_Taken = New System.Windows.Forms.TabPage()
        Me.dgv_actionTaken = New System.Windows.Forms.DataGridView()
        Me.ActionTaken = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Details = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Start_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.End_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Decision_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Decided_By = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Employee_ID3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subject_Employee3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.cmb_employees = New System.Windows.Forms.ComboBox()
        Me.dt_lastUpdate = New System.Windows.Forms.DateTimePicker()
        Me.dt_encodeDate = New System.Windows.Forms.DateTimePicker()
        Me.cmb_classification = New System.Windows.Forms.ComboBox()
        Me.dt_incidentDate = New System.Windows.Forms.DateTimePicker()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.txt_recommendations = New System.Windows.Forms.TextBox()
        Me.txt_evidence = New System.Windows.Forms.TextBox()
        Me.txt_cause = New System.Windows.Forms.TextBox()
        Me.txt_details = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Incident_TabControl.SuspendLayout()
        Me.Employees_Involved.SuspendLayout()
        CType(Me.dgv_employees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Offenses_Incurred.SuspendLayout()
        CType(Me.dgv_offenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Action_Taken.SuspendLayout()
        CType(Me.dgv_actionTaken, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetails.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbl_preparedBy)
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_Save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.Location = New System.Drawing.Point(0, 743)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(787, 50)
        Me.Panel2.TabIndex = 39
        '
        'lbl_preparedBy
        '
        Me.lbl_preparedBy.AutoSize = True
        Me.lbl_preparedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_preparedBy.Location = New System.Drawing.Point(16, 15)
        Me.lbl_preparedBy.Name = "lbl_preparedBy"
        Me.lbl_preparedBy.Size = New System.Drawing.Size(95, 17)
        Me.lbl_preparedBy.TabIndex = 20
        Me.lbl_preparedBy.Text = "Prepared By :"
        Me.lbl_preparedBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label_ID)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(787, 50)
        Me.Panel1.TabIndex = 38
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
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(45, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Incident Details"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.grpDetails)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 75)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10, 5, 10, 10)
        Me.Panel3.Size = New System.Drawing.Size(787, 668)
        Me.Panel3.TabIndex = 40
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btn_delete)
        Me.GroupBox2.Controls.Add(Me.btn_edit)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Controls.Add(Me.Incident_TabControl)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(10, 306)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(10, 5, 10, 10)
        Me.GroupBox2.Size = New System.Drawing.Size(767, 352)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(166, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 17)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "|"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_delete.ImageKey = "plus.png"
        Me.btn_delete.Location = New System.Drawing.Point(181, 314)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 30)
        Me.btn_delete.TabIndex = 52
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
        Me.btn_edit.Location = New System.Drawing.Point(87, 314)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 30)
        Me.btn_edit.TabIndex = 51
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
        Me.btn_add.Location = New System.Drawing.Point(6, 314)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 30)
        Me.btn_add.TabIndex = 50
        Me.btn_add.Text = "Add"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Incident_TabControl
        '
        Me.Incident_TabControl.Controls.Add(Me.Employees_Involved)
        Me.Incident_TabControl.Controls.Add(Me.Offenses_Incurred)
        Me.Incident_TabControl.Controls.Add(Me.Action_Taken)
        Me.Incident_TabControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Incident_TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Incident_TabControl.Location = New System.Drawing.Point(10, 18)
        Me.Incident_TabControl.Name = "Incident_TabControl"
        Me.Incident_TabControl.SelectedIndex = 0
        Me.Incident_TabControl.Size = New System.Drawing.Size(747, 291)
        Me.Incident_TabControl.TabIndex = 0
        '
        'Employees_Involved
        '
        Me.Employees_Involved.BackColor = System.Drawing.Color.White
        Me.Employees_Involved.Controls.Add(Me.dgv_employees)
        Me.Employees_Involved.Location = New System.Drawing.Point(4, 25)
        Me.Employees_Involved.Name = "Employees_Involved"
        Me.Employees_Involved.Padding = New System.Windows.Forms.Padding(3)
        Me.Employees_Involved.Size = New System.Drawing.Size(739, 262)
        Me.Employees_Involved.TabIndex = 0
        Me.Employees_Involved.Text = "Employee(s) Involved"
        '
        'dgv_employees
        '
        Me.dgv_employees.AllowUserToAddRows = False
        Me.dgv_employees.AllowUserToDeleteRows = False
        Me.dgv_employees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_employees.BackgroundColor = System.Drawing.Color.White
        Me.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_employees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Employee_ID, Me.Employee_Name, Me.Job_Title, Me.Department, Me.Tenure, Me.Age, Me.Supervisor, Me.Statement})
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_employees.DefaultCellStyle = DataGridViewCellStyle19
        Me.dgv_employees.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.dgv_employees.Size = New System.Drawing.Size(733, 256)
        Me.dgv_employees.TabIndex = 40
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
        'Tenure
        '
        Me.Tenure.HeaderText = "Tenure"
        Me.Tenure.Name = "Tenure"
        Me.Tenure.ReadOnly = True
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.ReadOnly = True
        '
        'Supervisor
        '
        Me.Supervisor.HeaderText = "Supervisor"
        Me.Supervisor.Name = "Supervisor"
        Me.Supervisor.ReadOnly = True
        Me.Supervisor.Width = 150
        '
        'Statement
        '
        Me.Statement.HeaderText = "Statement(s)"
        Me.Statement.Name = "Statement"
        Me.Statement.ReadOnly = True
        Me.Statement.Width = 300
        '
        'Offenses_Incurred
        '
        Me.Offenses_Incurred.BackColor = System.Drawing.Color.White
        Me.Offenses_Incurred.Controls.Add(Me.dgv_offenses)
        Me.Offenses_Incurred.Location = New System.Drawing.Point(4, 25)
        Me.Offenses_Incurred.Name = "Offenses_Incurred"
        Me.Offenses_Incurred.Padding = New System.Windows.Forms.Padding(3)
        Me.Offenses_Incurred.Size = New System.Drawing.Size(739, 262)
        Me.Offenses_Incurred.TabIndex = 2
        Me.Offenses_Incurred.Text = "Offense(s) Incurred"
        '
        'dgv_offenses
        '
        Me.dgv_offenses.AllowUserToAddRows = False
        Me.dgv_offenses.AllowUserToDeleteRows = False
        Me.dgv_offenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_offenses.BackgroundColor = System.Drawing.Color.White
        Me.dgv_offenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_offenses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Category, Me.Definition, Me.Offense_Class, Me.Instance, Me.Employee_ID2, Me.Subject_Employee})
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_offenses.DefaultCellStyle = DataGridViewCellStyle20
        Me.dgv_offenses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_offenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_offenses.Location = New System.Drawing.Point(3, 3)
        Me.dgv_offenses.MultiSelect = False
        Me.dgv_offenses.Name = "dgv_offenses"
        Me.dgv_offenses.ReadOnly = True
        Me.dgv_offenses.RowHeadersVisible = False
        Me.dgv_offenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_offenses.ShowCellErrors = False
        Me.dgv_offenses.ShowCellToolTips = False
        Me.dgv_offenses.ShowEditingIcon = False
        Me.dgv_offenses.ShowRowErrors = False
        Me.dgv_offenses.Size = New System.Drawing.Size(733, 256)
        Me.dgv_offenses.TabIndex = 41
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        Me.Category.Width = 200
        '
        'Definition
        '
        Me.Definition.HeaderText = "Definition"
        Me.Definition.Name = "Definition"
        Me.Definition.ReadOnly = True
        Me.Definition.Width = 300
        '
        'Offense_Class
        '
        Me.Offense_Class.HeaderText = "Class"
        Me.Offense_Class.Name = "Offense_Class"
        Me.Offense_Class.ReadOnly = True
        Me.Offense_Class.Width = 120
        '
        'Instance
        '
        Me.Instance.HeaderText = "Instance"
        Me.Instance.Name = "Instance"
        Me.Instance.ReadOnly = True
        Me.Instance.Width = 80
        '
        'Employee_ID2
        '
        Me.Employee_ID2.HeaderText = "Employee ID"
        Me.Employee_ID2.Name = "Employee_ID2"
        Me.Employee_ID2.ReadOnly = True
        Me.Employee_ID2.Width = 80
        '
        'Subject_Employee
        '
        Me.Subject_Employee.HeaderText = "Subject Employee"
        Me.Subject_Employee.Name = "Subject_Employee"
        Me.Subject_Employee.ReadOnly = True
        Me.Subject_Employee.Width = 200
        '
        'Action_Taken
        '
        Me.Action_Taken.BackColor = System.Drawing.Color.White
        Me.Action_Taken.Controls.Add(Me.dgv_actionTaken)
        Me.Action_Taken.Location = New System.Drawing.Point(4, 25)
        Me.Action_Taken.Name = "Action_Taken"
        Me.Action_Taken.Padding = New System.Windows.Forms.Padding(3)
        Me.Action_Taken.Size = New System.Drawing.Size(739, 262)
        Me.Action_Taken.TabIndex = 1
        Me.Action_Taken.Text = "Action(s) Taken"
        '
        'dgv_actionTaken
        '
        Me.dgv_actionTaken.AllowUserToAddRows = False
        Me.dgv_actionTaken.AllowUserToDeleteRows = False
        Me.dgv_actionTaken.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_actionTaken.BackgroundColor = System.Drawing.Color.White
        Me.dgv_actionTaken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_actionTaken.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ActionTaken, Me.Details, Me.Start_Date, Me.End_Date, Me.Decision_Date, Me.Decided_By, Me.Employee_ID3, Me.Subject_Employee3})
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_actionTaken.DefaultCellStyle = DataGridViewCellStyle21
        Me.dgv_actionTaken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_actionTaken.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_actionTaken.Location = New System.Drawing.Point(3, 3)
        Me.dgv_actionTaken.MultiSelect = False
        Me.dgv_actionTaken.Name = "dgv_actionTaken"
        Me.dgv_actionTaken.ReadOnly = True
        Me.dgv_actionTaken.RowHeadersVisible = False
        Me.dgv_actionTaken.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_actionTaken.ShowCellErrors = False
        Me.dgv_actionTaken.ShowCellToolTips = False
        Me.dgv_actionTaken.ShowEditingIcon = False
        Me.dgv_actionTaken.ShowRowErrors = False
        Me.dgv_actionTaken.Size = New System.Drawing.Size(733, 256)
        Me.dgv_actionTaken.TabIndex = 42
        '
        'ActionTaken
        '
        Me.ActionTaken.HeaderText = "Action(s) Taken"
        Me.ActionTaken.Name = "ActionTaken"
        Me.ActionTaken.ReadOnly = True
        Me.ActionTaken.Width = 150
        '
        'Details
        '
        Me.Details.HeaderText = "Details"
        Me.Details.Name = "Details"
        Me.Details.ReadOnly = True
        Me.Details.Width = 300
        '
        'Start_Date
        '
        Me.Start_Date.HeaderText = "Start Date"
        Me.Start_Date.Name = "Start_Date"
        Me.Start_Date.ReadOnly = True
        '
        'End_Date
        '
        Me.End_Date.HeaderText = "End Date"
        Me.End_Date.Name = "End_Date"
        Me.End_Date.ReadOnly = True
        '
        'Decision_Date
        '
        Me.Decision_Date.HeaderText = "Decision Date"
        Me.Decision_Date.Name = "Decision_Date"
        Me.Decision_Date.ReadOnly = True
        '
        'Decided_By
        '
        Me.Decided_By.HeaderText = "Decided By"
        Me.Decided_By.Name = "Decided_By"
        Me.Decided_By.ReadOnly = True
        Me.Decided_By.Width = 180
        '
        'Employee_ID3
        '
        Me.Employee_ID3.HeaderText = "Employee ID"
        Me.Employee_ID3.Name = "Employee_ID3"
        Me.Employee_ID3.ReadOnly = True
        Me.Employee_ID3.Width = 80
        '
        'Subject_Employee3
        '
        Me.Subject_Employee3.HeaderText = "Subject Employee"
        Me.Subject_Employee3.Name = "Subject_Employee3"
        Me.Subject_Employee3.ReadOnly = True
        Me.Subject_Employee3.Width = 200
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.cmb_employees)
        Me.grpDetails.Controls.Add(Me.dt_lastUpdate)
        Me.grpDetails.Controls.Add(Me.dt_encodeDate)
        Me.grpDetails.Controls.Add(Me.cmb_classification)
        Me.grpDetails.Controls.Add(Me.dt_incidentDate)
        Me.grpDetails.Controls.Add(Me.cmb_status)
        Me.grpDetails.Controls.Add(Me.txt_location)
        Me.grpDetails.Controls.Add(Me.txt_recommendations)
        Me.grpDetails.Controls.Add(Me.txt_evidence)
        Me.grpDetails.Controls.Add(Me.txt_cause)
        Me.grpDetails.Controls.Add(Me.txt_details)
        Me.grpDetails.Controls.Add(Me.Label4)
        Me.grpDetails.Controls.Add(Me.Label1)
        Me.grpDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpDetails.Location = New System.Drawing.Point(10, 5)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(767, 301)
        Me.grpDetails.TabIndex = 0
        Me.grpDetails.TabStop = False
        '
        'cmb_employees
        '
        Me.cmb_employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_employees.FormattingEnabled = True
        Me.cmb_employees.Location = New System.Drawing.Point(111, 149)
        Me.cmb_employees.Name = "cmb_employees"
        Me.cmb_employees.Size = New System.Drawing.Size(245, 24)
        Me.cmb_employees.TabIndex = 11
        '
        'dt_lastUpdate
        '
        Me.dt_lastUpdate.CustomFormat = "M/dd/yyyy hh:mm tt"
        Me.dt_lastUpdate.Enabled = False
        Me.dt_lastUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_lastUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_lastUpdate.Location = New System.Drawing.Point(111, 82)
        Me.dt_lastUpdate.Name = "dt_lastUpdate"
        Me.dt_lastUpdate.Size = New System.Drawing.Size(163, 23)
        Me.dt_lastUpdate.TabIndex = 3
        '
        'dt_encodeDate
        '
        Me.dt_encodeDate.CustomFormat = "M/dd/yyyy hh:mm tt"
        Me.dt_encodeDate.Enabled = False
        Me.dt_encodeDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_encodeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_encodeDate.Location = New System.Drawing.Point(111, 48)
        Me.dt_encodeDate.Name = "dt_encodeDate"
        Me.dt_encodeDate.Size = New System.Drawing.Size(163, 23)
        Me.dt_encodeDate.TabIndex = 2
        '
        'cmb_classification
        '
        Me.cmb_classification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_classification.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_classification.FormattingEnabled = True
        Me.cmb_classification.Items.AddRange(New Object() {"Employee-Related", "Work-Related", "Health and Safety", "Property and Assets", "Security and Data"})
        Me.cmb_classification.Location = New System.Drawing.Point(111, 116)
        Me.cmb_classification.Name = "cmb_classification"
        Me.cmb_classification.Size = New System.Drawing.Size(163, 24)
        Me.cmb_classification.TabIndex = 4
        '
        'dt_incidentDate
        '
        Me.dt_incidentDate.CustomFormat = "M/dd/yyyy hh:mm tt"
        Me.dt_incidentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_incidentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_incidentDate.Location = New System.Drawing.Point(111, 14)
        Me.dt_incidentDate.Name = "dt_incidentDate"
        Me.dt_incidentDate.Size = New System.Drawing.Size(163, 23)
        Me.dt_incidentDate.TabIndex = 1
        '
        'cmb_status
        '
        Me.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"Under Review", "Concluded"})
        Me.cmb_status.Location = New System.Drawing.Point(510, 269)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(114, 24)
        Me.cmb_status.TabIndex = 10
        '
        'txt_location
        '
        Me.txt_location.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_location.Location = New System.Drawing.Point(111, 185)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(245, 23)
        Me.txt_location.TabIndex = 5
        Me.txt_location.Tag = "inputText"
        '
        'txt_recommendations
        '
        Me.txt_recommendations.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_recommendations.Location = New System.Drawing.Point(510, 186)
        Me.txt_recommendations.Multiline = True
        Me.txt_recommendations.Name = "txt_recommendations"
        Me.txt_recommendations.Size = New System.Drawing.Size(245, 70)
        Me.txt_recommendations.TabIndex = 9
        Me.txt_recommendations.Tag = "inputText"
        '
        'txt_evidence
        '
        Me.txt_evidence.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_evidence.Location = New System.Drawing.Point(510, 100)
        Me.txt_evidence.Multiline = True
        Me.txt_evidence.Name = "txt_evidence"
        Me.txt_evidence.Size = New System.Drawing.Size(245, 70)
        Me.txt_evidence.TabIndex = 8
        Me.txt_evidence.Tag = "inputText"
        '
        'txt_cause
        '
        Me.txt_cause.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_cause.Location = New System.Drawing.Point(510, 18)
        Me.txt_cause.Multiline = True
        Me.txt_cause.Name = "txt_cause"
        Me.txt_cause.Size = New System.Drawing.Size(245, 70)
        Me.txt_cause.TabIndex = 7
        Me.txt_cause.Tag = "inputText"
        '
        'txt_details
        '
        Me.txt_details.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_details.Location = New System.Drawing.Point(111, 220)
        Me.txt_details.Multiline = True
        Me.txt_details.Name = "txt_details"
        Me.txt_details.Size = New System.Drawing.Size(245, 70)
        Me.txt_details.TabIndex = 6
        Me.txt_details.Tag = "inputText"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(365, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 272)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cause(s) :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Evidence(s) :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recommendation(s) :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Status :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 221)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Incident Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Encode Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Last Update :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Classification :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reported" & _
    " by :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Location :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Detail(s) :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(69, 21)
        Me.PrintToolStripMenuItem.Text = "Print 🖨️"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(787, 25)
        Me.MenuStrip1.TabIndex = 41
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FrmINCIDENT_DETAILS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(787, 793)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmINCIDENT_DETAILS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incident Details"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Incident_TabControl.ResumeLayout(False)
        Me.Employees_Involved.ResumeLayout(False)
        CType(Me.dgv_employees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Offenses_Incurred.ResumeLayout(False)
        CType(Me.dgv_offenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Action_Taken.ResumeLayout(False)
        CType(Me.dgv_actionTaken, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_details As System.Windows.Forms.TextBox
    Friend WithEvents cmb_status As System.Windows.Forms.ComboBox
    Friend WithEvents txt_location As System.Windows.Forms.TextBox
    Friend WithEvents txt_recommendations As System.Windows.Forms.TextBox
    Friend WithEvents txt_evidence As System.Windows.Forms.TextBox
    Friend WithEvents txt_cause As System.Windows.Forms.TextBox
    Friend WithEvents cmb_classification As System.Windows.Forms.ComboBox
    Friend WithEvents dt_incidentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Incident_TabControl As System.Windows.Forms.TabControl
    Friend WithEvents Employees_Involved As System.Windows.Forms.TabPage
    Friend WithEvents Action_Taken As System.Windows.Forms.TabPage
    Friend WithEvents Offenses_Incurred As System.Windows.Forms.TabPage
    Friend WithEvents dgv_employees As System.Windows.Forms.DataGridView
    Friend WithEvents Employee_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Employee_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Job_Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Department As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tenure As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Supervisor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Statement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_offenses As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_actionTaken As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents lbl_preparedBy As System.Windows.Forms.Label
    Friend WithEvents dt_encodeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_lastUpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label_ID As System.Windows.Forms.Label
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Definition As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Offense_Class As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Instance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Employee_ID2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subject_Employee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActionTaken As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Details As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Start_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents End_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Decision_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Decided_By As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Employee_ID3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subject_Employee3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_employees As System.Windows.Forms.ComboBox
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
End Class
