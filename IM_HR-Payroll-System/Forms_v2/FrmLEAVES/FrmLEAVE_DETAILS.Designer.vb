<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLEAVE_DETAILS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLEAVE_DETAILS))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_dateApplied = New System.Windows.Forms.DateTimePicker()
        Me.txt_Supervisor = New System.Windows.Forms.TextBox()
        Me.dt_leaveStart = New System.Windows.Forms.DateTimePicker()
        Me.dt_leaveEnd = New System.Windows.Forms.DateTimePicker()
        Me.txt_totalDays = New System.Windows.Forms.NumericUpDown()
        Me.cmb_Category = New System.Windows.Forms.ComboBox()
        Me.cmb_employees = New System.Windows.Forms.ComboBox()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_Approved = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpLeave = New System.Windows.Forms.GroupBox()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.txt_reason = New System.Windows.Forms.TextBox()
        CType(Me.txt_totalDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLeave.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 187)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Employee :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date Applied :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Immediate Supervisor :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Category :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Leave Sta" & _
    "rt :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Leave End :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(460, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 136)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Total Day(s) :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reason :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remarks :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_dateApplied
        '
        Me.dt_dateApplied.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_dateApplied.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_dateApplied.Location = New System.Drawing.Point(161, 47)
        Me.dt_dateApplied.Name = "dt_dateApplied"
        Me.dt_dateApplied.Size = New System.Drawing.Size(108, 23)
        Me.dt_dateApplied.TabIndex = 19
        '
        'txt_Supervisor
        '
        Me.txt_Supervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_Supervisor.Location = New System.Drawing.Point(161, 83)
        Me.txt_Supervisor.Name = "txt_Supervisor"
        Me.txt_Supervisor.Size = New System.Drawing.Size(194, 23)
        Me.txt_Supervisor.TabIndex = 20
        '
        'dt_leaveStart
        '
        Me.dt_leaveStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_leaveStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_leaveStart.Location = New System.Drawing.Point(161, 151)
        Me.dt_leaveStart.Name = "dt_leaveStart"
        Me.dt_leaveStart.Size = New System.Drawing.Size(108, 23)
        Me.dt_leaveStart.TabIndex = 21
        '
        'dt_leaveEnd
        '
        Me.dt_leaveEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_leaveEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_leaveEnd.Location = New System.Drawing.Point(161, 184)
        Me.dt_leaveEnd.Name = "dt_leaveEnd"
        Me.dt_leaveEnd.Size = New System.Drawing.Size(108, 23)
        Me.dt_leaveEnd.TabIndex = 22
        '
        'txt_totalDays
        '
        Me.txt_totalDays.DecimalPlaces = 1
        Me.txt_totalDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_totalDays.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_totalDays.Location = New System.Drawing.Point(557, 13)
        Me.txt_totalDays.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_totalDays.Name = "txt_totalDays"
        Me.txt_totalDays.Size = New System.Drawing.Size(60, 23)
        Me.txt_totalDays.TabIndex = 24
        Me.txt_totalDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_Category
        '
        Me.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_Category.FormattingEnabled = True
        Me.cmb_Category.Items.AddRange(New Object() {"Annual", "Sick", "Service Incentive", "Parental", "Maternity", "Paternity", "Leave w/o Pay", "Bereavement", "Other"})
        Me.cmb_Category.Location = New System.Drawing.Point(161, 116)
        Me.cmb_Category.Name = "cmb_Category"
        Me.cmb_Category.Size = New System.Drawing.Size(152, 24)
        Me.cmb_Category.TabIndex = 28
        '
        'cmb_employees
        '
        Me.cmb_employees.DropDownHeight = 200
        Me.cmb_employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_employees.FormattingEnabled = True
        Me.cmb_employees.IntegralHeight = False
        Me.cmb_employees.Location = New System.Drawing.Point(161, 14)
        Me.cmb_employees.Name = "cmb_employees"
        Me.cmb_employees.Size = New System.Drawing.Size(274, 24)
        Me.cmb_employees.TabIndex = 29
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Cancel.Location = New System.Drawing.Point(778, 8)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_Cancel.TabIndex = 31
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Save.Location = New System.Drawing.Point(702, 8)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(70, 30)
        Me.btn_Save.TabIndex = 30
        Me.btn_Save.Text = "&Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cb_Approved)
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_Save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.Location = New System.Drawing.Point(0, 288)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(861, 50)
        Me.Panel2.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(682, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 17)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "|"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = False
        '
        'cb_Approved
        '
        Me.cb_Approved.AutoSize = True
        Me.cb_Approved.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_Approved.Location = New System.Drawing.Point(592, 13)
        Me.cb_Approved.Name = "cb_Approved"
        Me.cb_Approved.Size = New System.Drawing.Size(88, 21)
        Me.cb_Approved.TabIndex = 23
        Me.cb_Approved.Text = "Approved"
        Me.cb_Approved.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(861, 50)
        Me.Panel1.TabIndex = 38
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(45, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(344, 31)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Leave Application Details"
        '
        'grpLeave
        '
        Me.grpLeave.Controls.Add(Me.txt_remarks)
        Me.grpLeave.Controls.Add(Me.txt_reason)
        Me.grpLeave.Controls.Add(Me.Label2)
        Me.grpLeave.Controls.Add(Me.cmb_employees)
        Me.grpLeave.Controls.Add(Me.dt_dateApplied)
        Me.grpLeave.Controls.Add(Me.cmb_Category)
        Me.grpLeave.Controls.Add(Me.txt_Supervisor)
        Me.grpLeave.Controls.Add(Me.dt_leaveStart)
        Me.grpLeave.Controls.Add(Me.txt_totalDays)
        Me.grpLeave.Controls.Add(Me.dt_leaveEnd)
        Me.grpLeave.Controls.Add(Me.Label3)
        Me.grpLeave.Location = New System.Drawing.Point(12, 56)
        Me.grpLeave.Name = "grpLeave"
        Me.grpLeave.Size = New System.Drawing.Size(836, 223)
        Me.grpLeave.TabIndex = 40
        Me.grpLeave.TabStop = False
        '
        'txt_remarks
        '
        Me.txt_remarks.Location = New System.Drawing.Point(560, 134)
        Me.txt_remarks.Multiline = True
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(267, 79)
        Me.txt_remarks.TabIndex = 31
        Me.txt_remarks.Tag = "inputText"
        '
        'txt_reason
        '
        Me.txt_reason.Location = New System.Drawing.Point(560, 49)
        Me.txt_reason.Multiline = True
        Me.txt_reason.Name = "txt_reason"
        Me.txt_reason.Size = New System.Drawing.Size(267, 79)
        Me.txt_reason.TabIndex = 30
        Me.txt_reason.Tag = "inputText"
        '
        'FrmLEAVE_DETAILS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(861, 338)
        Me.Controls.Add(Me.grpLeave)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLEAVE_DETAILS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Leave Details"
        CType(Me.txt_totalDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLeave.ResumeLayout(False)
        Me.grpLeave.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_dateApplied As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Supervisor As System.Windows.Forms.TextBox
    Friend WithEvents dt_leaveStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_leaveEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_totalDays As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmb_Category As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_employees As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_Approved As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grpLeave As System.Windows.Forms.GroupBox
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents txt_reason As System.Windows.Forms.TextBox
End Class
