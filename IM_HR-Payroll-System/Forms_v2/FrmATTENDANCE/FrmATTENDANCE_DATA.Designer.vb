<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmATTENDANCE_DATA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmATTENDANCE_DATA))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_employmentStatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_lunchIn = New System.Windows.Forms.TextBox()
        Me.txt_lunchOut = New System.Windows.Forms.TextBox()
        Me.cb_afternoonUndertime = New System.Windows.Forms.CheckBox()
        Me.cb_morningUndertime = New System.Windows.Forms.CheckBox()
        Me.cb_lateTimeIn = New System.Windows.Forms.CheckBox()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.tp_afternoonUndertime = New System.Windows.Forms.DateTimePicker()
        Me.tp_morningUndertime = New System.Windows.Forms.DateTimePicker()
        Me.tp_lateTimeIn = New System.Windows.Forms.DateTimePicker()
        Me.cmb_attendanceStatus = New System.Windows.Forms.ComboBox()
        Me.txt_shiftEnd = New System.Windows.Forms.TextBox()
        Me.txt_shiftStart = New System.Windows.Forms.TextBox()
        Me.txt_shiftCode = New System.Windows.Forms.TextBox()
        Me.txt_employeeName = New System.Windows.Forms.TextBox()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_Save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.Location = New System.Drawing.Point(0, 286)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 50)
        Me.Panel2.TabIndex = 43
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btn_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 50)
        Me.Panel1.TabIndex = 42
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(45, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Attendance Data"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10, 5, 10, 10)
        Me.Panel3.Size = New System.Drawing.Size(781, 236)
        Me.Panel3.TabIndex = 44
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_employmentStatus)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_lunchIn)
        Me.GroupBox1.Controls.Add(Me.txt_lunchOut)
        Me.GroupBox1.Controls.Add(Me.cb_afternoonUndertime)
        Me.GroupBox1.Controls.Add(Me.cb_morningUndertime)
        Me.GroupBox1.Controls.Add(Me.cb_lateTimeIn)
        Me.GroupBox1.Controls.Add(Me.txt_remarks)
        Me.GroupBox1.Controls.Add(Me.tp_afternoonUndertime)
        Me.GroupBox1.Controls.Add(Me.tp_morningUndertime)
        Me.GroupBox1.Controls.Add(Me.tp_lateTimeIn)
        Me.GroupBox1.Controls.Add(Me.cmb_attendanceStatus)
        Me.GroupBox1.Controls.Add(Me.txt_shiftEnd)
        Me.GroupBox1.Controls.Add(Me.txt_shiftStart)
        Me.GroupBox1.Controls.Add(Me.txt_shiftCode)
        Me.GroupBox1.Controls.Add(Me.txt_employeeName)
        Me.GroupBox1.Controls.Add(Me.txt_employeeID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 221)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txt_employmentStatus
        '
        Me.txt_employmentStatus.Location = New System.Drawing.Point(141, 86)
        Me.txt_employmentStatus.Name = "txt_employmentStatus"
        Me.txt_employmentStatus.ReadOnly = True
        Me.txt_employmentStatus.Size = New System.Drawing.Size(126, 23)
        Me.txt_employmentStatus.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Shift Code :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 51)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_lunchIn
        '
        Me.txt_lunchIn.Location = New System.Drawing.Point(141, 154)
        Me.txt_lunchIn.Name = "txt_lunchIn"
        Me.txt_lunchIn.ReadOnly = True
        Me.txt_lunchIn.Size = New System.Drawing.Size(58, 23)
        Me.txt_lunchIn.TabIndex = 16
        '
        'txt_lunchOut
        '
        Me.txt_lunchOut.Location = New System.Drawing.Point(229, 122)
        Me.txt_lunchOut.Name = "txt_lunchOut"
        Me.txt_lunchOut.ReadOnly = True
        Me.txt_lunchOut.Size = New System.Drawing.Size(58, 23)
        Me.txt_lunchOut.TabIndex = 15
        '
        'cb_afternoonUndertime
        '
        Me.cb_afternoonUndertime.AutoSize = True
        Me.cb_afternoonUndertime.Location = New System.Drawing.Point(393, 89)
        Me.cb_afternoonUndertime.Name = "cb_afternoonUndertime"
        Me.cb_afternoonUndertime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cb_afternoonUndertime.Size = New System.Drawing.Size(116, 21)
        Me.cb_afternoonUndertime.TabIndex = 14
        Me.cb_afternoonUndertime.Text = "PM Undertime"
        Me.cb_afternoonUndertime.UseVisualStyleBackColor = True
        '
        'cb_morningUndertime
        '
        Me.cb_morningUndertime.AutoSize = True
        Me.cb_morningUndertime.Location = New System.Drawing.Point(393, 55)
        Me.cb_morningUndertime.Name = "cb_morningUndertime"
        Me.cb_morningUndertime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cb_morningUndertime.Size = New System.Drawing.Size(116, 21)
        Me.cb_morningUndertime.TabIndex = 13
        Me.cb_morningUndertime.Text = "AM Undertime"
        Me.cb_morningUndertime.UseVisualStyleBackColor = True
        '
        'cb_lateTimeIn
        '
        Me.cb_lateTimeIn.AutoSize = True
        Me.cb_lateTimeIn.Location = New System.Drawing.Point(403, 21)
        Me.cb_lateTimeIn.Name = "cb_lateTimeIn"
        Me.cb_lateTimeIn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cb_lateTimeIn.Size = New System.Drawing.Size(106, 21)
        Me.cb_lateTimeIn.TabIndex = 12
        Me.cb_lateTimeIn.Text = "Late Time-In"
        Me.cb_lateTimeIn.UseVisualStyleBackColor = True
        '
        'txt_remarks
        '
        Me.txt_remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_remarks.Location = New System.Drawing.Point(526, 122)
        Me.txt_remarks.Multiline = True
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(223, 84)
        Me.txt_remarks.TabIndex = 11
        '
        'tp_afternoonUndertime
        '
        Me.tp_afternoonUndertime.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_afternoonUndertime.CustomFormat = "HH:mm:ss"
        Me.tp_afternoonUndertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_afternoonUndertime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tp_afternoonUndertime.Location = New System.Drawing.Point(526, 88)
        Me.tp_afternoonUndertime.Name = "tp_afternoonUndertime"
        Me.tp_afternoonUndertime.ShowUpDown = True
        Me.tp_afternoonUndertime.Size = New System.Drawing.Size(77, 23)
        Me.tp_afternoonUndertime.TabIndex = 10
        Me.tp_afternoonUndertime.Value = New Date(2026, 10, 26, 16, 59, 0, 0)
        '
        'tp_morningUndertime
        '
        Me.tp_morningUndertime.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_morningUndertime.CustomFormat = "HH:mm:ss"
        Me.tp_morningUndertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_morningUndertime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tp_morningUndertime.Location = New System.Drawing.Point(526, 54)
        Me.tp_morningUndertime.Name = "tp_morningUndertime"
        Me.tp_morningUndertime.ShowUpDown = True
        Me.tp_morningUndertime.Size = New System.Drawing.Size(77, 23)
        Me.tp_morningUndertime.TabIndex = 9
        Me.tp_morningUndertime.Value = New Date(2026, 10, 26, 11, 59, 0, 0)
        '
        'tp_lateTimeIn
        '
        Me.tp_lateTimeIn.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_lateTimeIn.CustomFormat = "HH:mm:ss"
        Me.tp_lateTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tp_lateTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tp_lateTimeIn.Location = New System.Drawing.Point(526, 20)
        Me.tp_lateTimeIn.Name = "tp_lateTimeIn"
        Me.tp_lateTimeIn.ShowUpDown = True
        Me.tp_lateTimeIn.Size = New System.Drawing.Size(77, 23)
        Me.tp_lateTimeIn.TabIndex = 8
        Me.tp_lateTimeIn.Value = New Date(2026, 10, 26, 8, 1, 0, 0)
        '
        'cmb_attendanceStatus
        '
        Me.cmb_attendanceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_attendanceStatus.FormattingEnabled = True
        Me.cmb_attendanceStatus.Items.AddRange(New Object() {"On-Duty", "Work From Home", "Half-Day", "Absent", "On-Leave"})
        Me.cmb_attendanceStatus.Location = New System.Drawing.Point(141, 188)
        Me.cmb_attendanceStatus.Name = "cmb_attendanceStatus"
        Me.cmb_attendanceStatus.Size = New System.Drawing.Size(132, 24)
        Me.cmb_attendanceStatus.TabIndex = 7
        '
        'txt_shiftEnd
        '
        Me.txt_shiftEnd.Location = New System.Drawing.Point(229, 154)
        Me.txt_shiftEnd.Name = "txt_shiftEnd"
        Me.txt_shiftEnd.ReadOnly = True
        Me.txt_shiftEnd.Size = New System.Drawing.Size(58, 23)
        Me.txt_shiftEnd.TabIndex = 6
        '
        'txt_shiftStart
        '
        Me.txt_shiftStart.Location = New System.Drawing.Point(141, 121)
        Me.txt_shiftStart.Name = "txt_shiftStart"
        Me.txt_shiftStart.ReadOnly = True
        Me.txt_shiftStart.Size = New System.Drawing.Size(58, 23)
        Me.txt_shiftStart.TabIndex = 5
        '
        'txt_shiftCode
        '
        Me.txt_shiftCode.Location = New System.Drawing.Point(304, 20)
        Me.txt_shiftCode.Name = "txt_shiftCode"
        Me.txt_shiftCode.ReadOnly = True
        Me.txt_shiftCode.Size = New System.Drawing.Size(67, 23)
        Me.txt_shiftCode.TabIndex = 4
        '
        'txt_employeeName
        '
        Me.txt_employeeName.Location = New System.Drawing.Point(141, 53)
        Me.txt_employeeName.Name = "txt_employeeName"
        Me.txt_employeeName.ReadOnly = True
        Me.txt_employeeName.Size = New System.Drawing.Size(230, 23)
        Me.txt_employeeName.TabIndex = 3
        '
        'txt_employeeID
        '
        Me.txt_employeeID.Location = New System.Drawing.Point(141, 19)
        Me.txt_employeeID.Name = "txt_employeeID"
        Me.txt_employeeID.ReadOnly = True
        Me.txt_employeeID.Size = New System.Drawing.Size(67, 23)
        Me.txt_employeeID.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(415, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 119)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Late Time-In :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AM Undertime :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PM Undertime :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remarks :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 187)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Employee Name :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Employment Status :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AM Shift :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PM Shift" & _
    " :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Attendance Status :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmATTENDANCE_DATA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(781, 336)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmATTENDANCE_DATA"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Attendance Data"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_shiftCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_employeeName As System.Windows.Forms.TextBox
    Friend WithEvents txt_employeeID As System.Windows.Forms.TextBox
    Friend WithEvents txt_shiftStart As System.Windows.Forms.TextBox
    Friend WithEvents txt_shiftEnd As System.Windows.Forms.TextBox
    Friend WithEvents cmb_attendanceStatus As System.Windows.Forms.ComboBox
    Friend WithEvents tp_lateTimeIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents tp_afternoonUndertime As System.Windows.Forms.DateTimePicker
    Friend WithEvents tp_morningUndertime As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents cb_afternoonUndertime As System.Windows.Forms.CheckBox
    Friend WithEvents cb_morningUndertime As System.Windows.Forms.CheckBox
    Friend WithEvents cb_lateTimeIn As System.Windows.Forms.CheckBox
    Friend WithEvents txt_lunchOut As System.Windows.Forms.TextBox
    Friend WithEvents txt_lunchIn As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_employmentStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
