<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSHIFTS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSHIFTS))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.left_panel = New System.Windows.Forms.Panel()
        Me.dgv_panel = New System.Windows.Forms.Panel()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.dt_toRegular = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_fromRegular = New System.Windows.Forms.DateTimePicker()
        Me.cb_regularization = New System.Windows.Forms.CheckBox()
        Me.dt_toHired = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_fromHired = New System.Windows.Forms.DateTimePicker()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.cb_status = New System.Windows.Forms.CheckBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.cmb_department = New System.Windows.Forms.ComboBox()
        Me.cb_department = New System.Windows.Forms.CheckBox()
        Me.txt_position = New System.Windows.Forms.TextBox()
        Me.cb_position = New System.Windows.Forms.CheckBox()
        Me.cb_hiredDate = New System.Windows.Forms.CheckBox()
        Me.cb_civilStatus = New System.Windows.Forms.CheckBox()
        Me.cmb_civilStatus = New System.Windows.Forms.ComboBox()
        Me.cb_gender = New System.Windows.Forms.CheckBox()
        Me.cmb_gender = New System.Windows.Forms.ComboBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.cb_name = New System.Windows.Forms.CheckBox()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.cb_employeeID = New System.Windows.Forms.CheckBox()
        Me.lst_shifts = New System.Windows.Forms.ListView()
        Me.right_panel = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lst_employees = New System.Windows.Forms.ListView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.left_panel.SuspendLayout()
        Me.dgv_panel.SuspendLayout()
        Me.grpFilter.SuspendLayout()
        Me.right_panel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1014, 72)
        Me.Panel1.TabIndex = 1
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
        Me.Label1.Size = New System.Drawing.Size(126, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Shifts"
        '
        'left_panel
        '
        Me.left_panel.Controls.Add(Me.dgv_panel)
        Me.left_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.left_panel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.left_panel.Location = New System.Drawing.Point(0, 72)
        Me.left_panel.Name = "left_panel"
        Me.left_panel.Padding = New System.Windows.Forms.Padding(10)
        Me.left_panel.Size = New System.Drawing.Size(616, 627)
        Me.left_panel.TabIndex = 2
        '
        'dgv_panel
        '
        Me.dgv_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.dgv_panel.Controls.Add(Me.grpFilter)
        Me.dgv_panel.Controls.Add(Me.lst_shifts)
        Me.dgv_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_panel.Location = New System.Drawing.Point(10, 10)
        Me.dgv_panel.Name = "dgv_panel"
        Me.dgv_panel.Padding = New System.Windows.Forms.Padding(5)
        Me.dgv_panel.Size = New System.Drawing.Size(596, 607)
        Me.dgv_panel.TabIndex = 706
        '
        'grpFilter
        '
        Me.grpFilter.Controls.Add(Me.dt_toRegular)
        Me.grpFilter.Controls.Add(Me.Label3)
        Me.grpFilter.Controls.Add(Me.dt_fromRegular)
        Me.grpFilter.Controls.Add(Me.cb_regularization)
        Me.grpFilter.Controls.Add(Me.dt_toHired)
        Me.grpFilter.Controls.Add(Me.Label2)
        Me.grpFilter.Controls.Add(Me.dt_fromHired)
        Me.grpFilter.Controls.Add(Me.cmb_status)
        Me.grpFilter.Controls.Add(Me.cb_status)
        Me.grpFilter.Controls.Add(Me.btn_submit)
        Me.grpFilter.Controls.Add(Me.btn_cancel)
        Me.grpFilter.Controls.Add(Me.cmb_department)
        Me.grpFilter.Controls.Add(Me.cb_department)
        Me.grpFilter.Controls.Add(Me.txt_position)
        Me.grpFilter.Controls.Add(Me.cb_position)
        Me.grpFilter.Controls.Add(Me.cb_hiredDate)
        Me.grpFilter.Controls.Add(Me.cb_civilStatus)
        Me.grpFilter.Controls.Add(Me.cmb_civilStatus)
        Me.grpFilter.Controls.Add(Me.cb_gender)
        Me.grpFilter.Controls.Add(Me.cmb_gender)
        Me.grpFilter.Controls.Add(Me.txt_name)
        Me.grpFilter.Controls.Add(Me.cb_name)
        Me.grpFilter.Controls.Add(Me.txt_employeeID)
        Me.grpFilter.Controls.Add(Me.cb_employeeID)
        Me.grpFilter.Location = New System.Drawing.Point(51, 81)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(411, 326)
        Me.grpFilter.TabIndex = 706
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Search"
        Me.grpFilter.Visible = False
        '
        'dt_toRegular
        '
        Me.dt_toRegular.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_toRegular.Location = New System.Drawing.Point(300, 167)
        Me.dt_toRegular.Name = "dt_toRegular"
        Me.dt_toRegular.Size = New System.Drawing.Size(101, 23)
        Me.dt_toRegular.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(274, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "to"
        '
        'dt_fromRegular
        '
        Me.dt_fromRegular.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fromRegular.Location = New System.Drawing.Point(170, 167)
        Me.dt_fromRegular.Name = "dt_fromRegular"
        Me.dt_fromRegular.Size = New System.Drawing.Size(101, 23)
        Me.dt_fromRegular.TabIndex = 22
        '
        'cb_regularization
        '
        Me.cb_regularization.AutoSize = True
        Me.cb_regularization.Location = New System.Drawing.Point(15, 169)
        Me.cb_regularization.Name = "cb_regularization"
        Me.cb_regularization.Size = New System.Drawing.Size(152, 21)
        Me.cb_regularization.TabIndex = 21
        Me.cb_regularization.Text = "Regularization Date"
        Me.cb_regularization.UseVisualStyleBackColor = True
        '
        'dt_toHired
        '
        Me.dt_toHired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_toHired.Location = New System.Drawing.Point(300, 138)
        Me.dt_toHired.Name = "dt_toHired"
        Me.dt_toHired.Size = New System.Drawing.Size(101, 23)
        Me.dt_toHired.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "to"
        '
        'dt_fromHired
        '
        Me.dt_fromHired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fromHired.Location = New System.Drawing.Point(170, 138)
        Me.dt_fromHired.Name = "dt_fromHired"
        Me.dt_fromHired.Size = New System.Drawing.Size(101, 23)
        Me.dt_fromHired.TabIndex = 18
        '
        'cmb_status
        '
        Me.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Location = New System.Drawing.Point(170, 255)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(113, 24)
        Me.cmb_status.TabIndex = 17
        '
        'cb_status
        '
        Me.cb_status.AutoSize = True
        Me.cb_status.Location = New System.Drawing.Point(14, 255)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(67, 21)
        Me.cb_status.TabIndex = 16
        Me.cb_status.Text = "Status"
        Me.cb_status.UseVisualStyleBackColor = True
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(225, 287)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(85, 30)
        Me.btn_submit.TabIndex = 15
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(316, 287)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(85, 30)
        Me.btn_cancel.TabIndex = 14
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'cmb_department
        '
        Me.cmb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_department.FormattingEnabled = True
        Me.cmb_department.Location = New System.Drawing.Point(170, 225)
        Me.cmb_department.Name = "cmb_department"
        Me.cmb_department.Size = New System.Drawing.Size(179, 24)
        Me.cmb_department.TabIndex = 13
        '
        'cb_department
        '
        Me.cb_department.AutoSize = True
        Me.cb_department.Location = New System.Drawing.Point(14, 225)
        Me.cb_department.Name = "cb_department"
        Me.cb_department.Size = New System.Drawing.Size(101, 21)
        Me.cb_department.TabIndex = 12
        Me.cb_department.Text = "Department"
        Me.cb_department.UseVisualStyleBackColor = True
        '
        'txt_position
        '
        Me.txt_position.Location = New System.Drawing.Point(170, 196)
        Me.txt_position.Name = "txt_position"
        Me.txt_position.Size = New System.Drawing.Size(148, 23)
        Me.txt_position.TabIndex = 11
        '
        'cb_position
        '
        Me.cb_position.AutoSize = True
        Me.cb_position.Location = New System.Drawing.Point(15, 198)
        Me.cb_position.Name = "cb_position"
        Me.cb_position.Size = New System.Drawing.Size(77, 21)
        Me.cb_position.TabIndex = 10
        Me.cb_position.Text = "Position"
        Me.cb_position.UseVisualStyleBackColor = True
        '
        'cb_hiredDate
        '
        Me.cb_hiredDate.AutoSize = True
        Me.cb_hiredDate.Location = New System.Drawing.Point(15, 140)
        Me.cb_hiredDate.Name = "cb_hiredDate"
        Me.cb_hiredDate.Size = New System.Drawing.Size(95, 21)
        Me.cb_hiredDate.TabIndex = 8
        Me.cb_hiredDate.Text = "Hired Date"
        Me.cb_hiredDate.UseVisualStyleBackColor = True
        '
        'cb_civilStatus
        '
        Me.cb_civilStatus.AutoSize = True
        Me.cb_civilStatus.Location = New System.Drawing.Point(15, 110)
        Me.cb_civilStatus.Name = "cb_civilStatus"
        Me.cb_civilStatus.Size = New System.Drawing.Size(96, 21)
        Me.cb_civilStatus.TabIndex = 7
        Me.cb_civilStatus.Text = "Civil Status"
        Me.cb_civilStatus.UseVisualStyleBackColor = True
        '
        'cmb_civilStatus
        '
        Me.cmb_civilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_civilStatus.FormattingEnabled = True
        Me.cmb_civilStatus.Location = New System.Drawing.Point(170, 108)
        Me.cmb_civilStatus.Name = "cmb_civilStatus"
        Me.cmb_civilStatus.Size = New System.Drawing.Size(82, 24)
        Me.cmb_civilStatus.TabIndex = 6
        '
        'cb_gender
        '
        Me.cb_gender.AutoSize = True
        Me.cb_gender.Location = New System.Drawing.Point(15, 80)
        Me.cb_gender.Name = "cb_gender"
        Me.cb_gender.Size = New System.Drawing.Size(75, 21)
        Me.cb_gender.TabIndex = 5
        Me.cb_gender.Text = "Gender"
        Me.cb_gender.UseVisualStyleBackColor = True
        '
        'cmb_gender
        '
        Me.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_gender.FormattingEnabled = True
        Me.cmb_gender.Location = New System.Drawing.Point(170, 78)
        Me.cmb_gender.Name = "cmb_gender"
        Me.cmb_gender.Size = New System.Drawing.Size(82, 24)
        Me.cmb_gender.TabIndex = 4
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
        'lst_shifts
        '
        Me.lst_shifts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_shifts.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lst_shifts.FullRowSelect = True
        Me.lst_shifts.GridLines = True
        Me.lst_shifts.Location = New System.Drawing.Point(5, 5)
        Me.lst_shifts.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_shifts.Name = "lst_shifts"
        Me.lst_shifts.Size = New System.Drawing.Size(586, 597)
        Me.lst_shifts.TabIndex = 707
        Me.lst_shifts.UseCompatibleStateImageBehavior = False
        Me.lst_shifts.View = System.Windows.Forms.View.Details
        '
        'right_panel
        '
        Me.right_panel.Controls.Add(Me.Panel4)
        Me.right_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.right_panel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.right_panel.Location = New System.Drawing.Point(616, 72)
        Me.right_panel.Name = "right_panel"
        Me.right_panel.Padding = New System.Windows.Forms.Padding(10)
        Me.right_panel.Size = New System.Drawing.Size(398, 627)
        Me.right_panel.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lst_employees)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(10, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel4.Size = New System.Drawing.Size(378, 607)
        Me.Panel4.TabIndex = 706
        '
        'lst_employees
        '
        Me.lst_employees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lst_employees.FullRowSelect = True
        Me.lst_employees.GridLines = True
        Me.lst_employees.Location = New System.Drawing.Point(5, 5)
        Me.lst_employees.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_employees.Name = "lst_employees"
        Me.lst_employees.Size = New System.Drawing.Size(368, 597)
        Me.lst_employees.TabIndex = 707
        Me.lst_employees.UseCompatibleStateImageBehavior = False
        Me.lst_employees.View = System.Windows.Forms.View.Details
        '
        'FrmSHIFTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1014, 699)
        Me.ControlBox = False
        Me.Controls.Add(Me.right_panel)
        Me.Controls.Add(Me.left_panel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmSHIFTS"
        Me.Text = "Shifts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.left_panel.ResumeLayout(False)
        Me.dgv_panel.ResumeLayout(False)
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        Me.right_panel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents left_panel As System.Windows.Forms.Panel
    Friend WithEvents dgv_panel As System.Windows.Forms.Panel
    Friend WithEvents grpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents dt_toRegular As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_fromRegular As System.Windows.Forms.DateTimePicker
    Friend WithEvents cb_regularization As System.Windows.Forms.CheckBox
    Friend WithEvents dt_toHired As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt_fromHired As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_status As System.Windows.Forms.ComboBox
    Friend WithEvents cb_status As System.Windows.Forms.CheckBox
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents cmb_department As System.Windows.Forms.ComboBox
    Friend WithEvents cb_department As System.Windows.Forms.CheckBox
    Friend WithEvents txt_position As System.Windows.Forms.TextBox
    Friend WithEvents cb_position As System.Windows.Forms.CheckBox
    Friend WithEvents cb_hiredDate As System.Windows.Forms.CheckBox
    Friend WithEvents cb_civilStatus As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_civilStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cb_gender As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_gender As System.Windows.Forms.ComboBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents cb_name As System.Windows.Forms.CheckBox
    Friend WithEvents txt_employeeID As System.Windows.Forms.TextBox
    Friend WithEvents cb_employeeID As System.Windows.Forms.CheckBox
    Friend WithEvents lst_shifts As System.Windows.Forms.ListView
    Friend WithEvents right_panel As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lst_employees As System.Windows.Forms.ListView
End Class
