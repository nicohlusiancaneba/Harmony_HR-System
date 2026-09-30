<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLEAVES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLEAVES))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_panel = New System.Windows.Forms.Panel()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.cb_status = New System.Windows.Forms.CheckBox()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.dt_toLeave = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_fromLeave = New System.Windows.Forms.DateTimePicker()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.cb_remarks = New System.Windows.Forms.CheckBox()
        Me.cb_leaveDate = New System.Windows.Forms.CheckBox()
        Me.cb_leaveCategory = New System.Windows.Forms.CheckBox()
        Me.cmb_leaveCategory = New System.Windows.Forms.ComboBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.cb_name = New System.Windows.Forms.CheckBox()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.cb_employeeID = New System.Windows.Forms.CheckBox()
        Me.lst_leaves = New System.Windows.Forms.ListView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.dgv_panel.SuspendLayout()
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
        Me.Panel2.TabIndex = 5
        '
        'dgv_panel
        '
        Me.dgv_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.dgv_panel.Controls.Add(Me.grpFilter)
        Me.dgv_panel.Controls.Add(Me.lst_leaves)
        Me.dgv_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_panel.Location = New System.Drawing.Point(10, 10)
        Me.dgv_panel.Name = "dgv_panel"
        Me.dgv_panel.Padding = New System.Windows.Forms.Padding(5)
        Me.dgv_panel.Size = New System.Drawing.Size(968, 534)
        Me.dgv_panel.TabIndex = 706
        '
        'grpFilter
        '
        Me.grpFilter.Controls.Add(Me.cb_status)
        Me.grpFilter.Controls.Add(Me.cmb_status)
        Me.grpFilter.Controls.Add(Me.dt_toLeave)
        Me.grpFilter.Controls.Add(Me.Label2)
        Me.grpFilter.Controls.Add(Me.dt_fromLeave)
        Me.grpFilter.Controls.Add(Me.btn_submit)
        Me.grpFilter.Controls.Add(Me.btn_cancel)
        Me.grpFilter.Controls.Add(Me.txt_remarks)
        Me.grpFilter.Controls.Add(Me.cb_remarks)
        Me.grpFilter.Controls.Add(Me.cb_leaveDate)
        Me.grpFilter.Controls.Add(Me.cb_leaveCategory)
        Me.grpFilter.Controls.Add(Me.cmb_leaveCategory)
        Me.grpFilter.Controls.Add(Me.txt_name)
        Me.grpFilter.Controls.Add(Me.cb_name)
        Me.grpFilter.Controls.Add(Me.txt_employeeID)
        Me.grpFilter.Controls.Add(Me.cb_employeeID)
        Me.grpFilter.Location = New System.Drawing.Point(268, 115)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(412, 242)
        Me.grpFilter.TabIndex = 706
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Search"
        Me.grpFilter.Visible = False
        '
        'cb_status
        '
        Me.cb_status.AutoSize = True
        Me.cb_status.Location = New System.Drawing.Point(15, 166)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(67, 21)
        Me.cb_status.TabIndex = 22
        Me.cb_status.Text = "Status"
        Me.cb_status.UseVisualStyleBackColor = True
        '
        'cmb_status
        '
        Me.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"Approved", "Pending"})
        Me.cmb_status.Location = New System.Drawing.Point(161, 164)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(101, 24)
        Me.cmb_status.TabIndex = 21
        '
        'dt_toLeave
        '
        Me.dt_toLeave.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_toLeave.Location = New System.Drawing.Point(290, 107)
        Me.dt_toLeave.Name = "dt_toLeave"
        Me.dt_toLeave.Size = New System.Drawing.Size(101, 23)
        Me.dt_toLeave.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(265, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "to"
        '
        'dt_fromLeave
        '
        Me.dt_fromLeave.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fromLeave.Location = New System.Drawing.Point(161, 107)
        Me.dt_fromLeave.Name = "dt_fromLeave"
        Me.dt_fromLeave.Size = New System.Drawing.Size(101, 23)
        Me.dt_fromLeave.TabIndex = 18
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(215, 197)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(85, 30)
        Me.btn_submit.TabIndex = 15
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(306, 197)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(85, 30)
        Me.btn_cancel.TabIndex = 14
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'txt_remarks
        '
        Me.txt_remarks.Location = New System.Drawing.Point(161, 135)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(148, 23)
        Me.txt_remarks.TabIndex = 11
        '
        'cb_remarks
        '
        Me.cb_remarks.AutoSize = True
        Me.cb_remarks.Location = New System.Drawing.Point(15, 137)
        Me.cb_remarks.Name = "cb_remarks"
        Me.cb_remarks.Size = New System.Drawing.Size(144, 21)
        Me.cb_remarks.TabIndex = 10
        Me.cb_remarks.Text = "Remarks / Reason"
        Me.cb_remarks.UseVisualStyleBackColor = True
        '
        'cb_leaveDate
        '
        Me.cb_leaveDate.AutoSize = True
        Me.cb_leaveDate.Location = New System.Drawing.Point(15, 108)
        Me.cb_leaveDate.Name = "cb_leaveDate"
        Me.cb_leaveDate.Size = New System.Drawing.Size(100, 21)
        Me.cb_leaveDate.TabIndex = 8
        Me.cb_leaveDate.Text = "Leave Date"
        Me.cb_leaveDate.UseVisualStyleBackColor = True
        '
        'cb_leaveCategory
        '
        Me.cb_leaveCategory.AutoSize = True
        Me.cb_leaveCategory.Location = New System.Drawing.Point(15, 80)
        Me.cb_leaveCategory.Name = "cb_leaveCategory"
        Me.cb_leaveCategory.Size = New System.Drawing.Size(127, 21)
        Me.cb_leaveCategory.TabIndex = 5
        Me.cb_leaveCategory.Text = "Leave Category"
        Me.cb_leaveCategory.UseVisualStyleBackColor = True
        '
        'cmb_leaveCategory
        '
        Me.cmb_leaveCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_leaveCategory.FormattingEnabled = True
        Me.cmb_leaveCategory.Items.AddRange(New Object() {"Annual", "Sick", "Service Incentive", "Parental", "Maternity", "Paternity", "Leave w/o Pay", "Bereavement", "Other"})
        Me.cmb_leaveCategory.Location = New System.Drawing.Point(161, 78)
        Me.cmb_leaveCategory.Name = "cmb_leaveCategory"
        Me.cmb_leaveCategory.Size = New System.Drawing.Size(148, 24)
        Me.cmb_leaveCategory.TabIndex = 4
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(161, 49)
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
        Me.txt_employeeID.Location = New System.Drawing.Point(161, 20)
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
        'lst_leaves
        '
        Me.lst_leaves.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_leaves.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lst_leaves.FullRowSelect = True
        Me.lst_leaves.GridLines = True
        Me.lst_leaves.Location = New System.Drawing.Point(5, 5)
        Me.lst_leaves.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_leaves.Name = "lst_leaves"
        Me.lst_leaves.Size = New System.Drawing.Size(958, 524)
        Me.lst_leaves.TabIndex = 707
        Me.lst_leaves.UseCompatibleStateImageBehavior = False
        Me.lst_leaves.View = System.Windows.Forms.View.Details
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(988, 72)
        Me.Panel1.TabIndex = 4
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
        Me.Label1.Size = New System.Drawing.Size(373, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Leave Applications"
        '
        'FrmLEAVES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(988, 626)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmLEAVES"
        Me.Text = "Leave Applications"
        Me.Panel2.ResumeLayout(False)
        Me.dgv_panel.ResumeLayout(False)
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
    Friend WithEvents cb_status As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_status As System.Windows.Forms.ComboBox
    Friend WithEvents dt_toLeave As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt_fromLeave As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents cb_remarks As System.Windows.Forms.CheckBox
    Friend WithEvents cb_leaveDate As System.Windows.Forms.CheckBox
    Friend WithEvents cb_leaveCategory As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_leaveCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents cb_name As System.Windows.Forms.CheckBox
    Friend WithEvents txt_employeeID As System.Windows.Forms.TextBox
    Friend WithEvents cb_employeeID As System.Windows.Forms.CheckBox
    Friend WithEvents lst_leaves As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
