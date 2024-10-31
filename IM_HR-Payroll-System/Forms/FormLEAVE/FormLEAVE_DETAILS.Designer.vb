<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLEAVE_DETAILS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLEAVE_DETAILS))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_dateApplied = New System.Windows.Forms.DateTimePicker()
        Me.txt_Supervisor = New System.Windows.Forms.TextBox()
        Me.dt_leaveStart = New System.Windows.Forms.DateTimePicker()
        Me.dt_leaveEnd = New System.Windows.Forms.DateTimePicker()
        Me.txt_totalDays = New System.Windows.Forms.NumericUpDown()
        Me.txt_reason = New System.Windows.Forms.RichTextBox()
        Me.txt_remarks = New System.Windows.Forms.RichTextBox()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.cmb_Category = New System.Windows.Forms.ComboBox()
        Me.cmb_employees = New System.Windows.Forms.ComboBox()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_totalDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 31)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Leave Application"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 220)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Employee :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date Applied :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Immediate Supervisor :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Category :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Leave Sta" & _
    "rt :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Leave End :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(517, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 220)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Total Day(s) :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reason :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remarks :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Leave Status :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_dateApplied
        '
        Me.dt_dateApplied.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_dateApplied.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_dateApplied.Location = New System.Drawing.Point(183, 93)
        Me.dt_dateApplied.Name = "dt_dateApplied"
        Me.dt_dateApplied.Size = New System.Drawing.Size(121, 26)
        Me.dt_dateApplied.TabIndex = 19
        '
        'txt_Supervisor
        '
        Me.txt_Supervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Supervisor.Location = New System.Drawing.Point(183, 135)
        Me.txt_Supervisor.Name = "txt_Supervisor"
        Me.txt_Supervisor.Size = New System.Drawing.Size(194, 26)
        Me.txt_Supervisor.TabIndex = 20
        '
        'dt_leaveStart
        '
        Me.dt_leaveStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_leaveStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_leaveStart.Location = New System.Drawing.Point(183, 214)
        Me.dt_leaveStart.Name = "dt_leaveStart"
        Me.dt_leaveStart.Size = New System.Drawing.Size(121, 26)
        Me.dt_leaveStart.TabIndex = 21
        '
        'dt_leaveEnd
        '
        Me.dt_leaveEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_leaveEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_leaveEnd.Location = New System.Drawing.Point(183, 251)
        Me.dt_leaveEnd.Name = "dt_leaveEnd"
        Me.dt_leaveEnd.Size = New System.Drawing.Size(121, 26)
        Me.dt_leaveEnd.TabIndex = 22
        '
        'txt_totalDays
        '
        Me.txt_totalDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalDays.Location = New System.Drawing.Point(634, 55)
        Me.txt_totalDays.Name = "txt_totalDays"
        Me.txt_totalDays.Size = New System.Drawing.Size(51, 26)
        Me.txt_totalDays.TabIndex = 24
        Me.txt_totalDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_reason
        '
        Me.txt_reason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_reason.Location = New System.Drawing.Point(634, 95)
        Me.txt_reason.Name = "txt_reason"
        Me.txt_reason.Size = New System.Drawing.Size(255, 72)
        Me.txt_reason.TabIndex = 25
        Me.txt_reason.Text = ""
        '
        'txt_remarks
        '
        Me.txt_remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_remarks.Location = New System.Drawing.Point(634, 173)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(255, 72)
        Me.txt_remarks.TabIndex = 26
        Me.txt_remarks.Text = ""
        '
        'cmb_status
        '
        Me.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"Pending", "Approved", "Rejected"})
        Me.cmb_status.Location = New System.Drawing.Point(634, 255)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(152, 28)
        Me.cmb_status.TabIndex = 27
        '
        'cmb_Category
        '
        Me.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Category.FormattingEnabled = True
        Me.cmb_Category.Items.AddRange(New Object() {"Annual", "Sick", "Service Incentive", "Parental", "Maternity", "Paternity", "Leave w/o Pay", "Bereavement", "Other"})
        Me.cmb_Category.Location = New System.Drawing.Point(183, 173)
        Me.cmb_Category.Name = "cmb_Category"
        Me.cmb_Category.Size = New System.Drawing.Size(152, 28)
        Me.cmb_Category.TabIndex = 28
        '
        'cmb_employees
        '
        Me.cmb_employees.DropDownHeight = 200
        Me.cmb_employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_employees.FormattingEnabled = True
        Me.cmb_employees.IntegralHeight = False
        Me.cmb_employees.Location = New System.Drawing.Point(183, 53)
        Me.cmb_employees.Name = "cmb_employees"
        Me.cmb_employees.Size = New System.Drawing.Size(328, 28)
        Me.cmb_employees.TabIndex = 29
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(819, 309)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_Cancel.TabIndex = 31
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(743, 309)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(70, 30)
        Me.btn_Save.TabIndex = 30
        Me.btn_Save.Text = "&Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'FormLEAVE_DETAILS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 353)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.cmb_employees)
        Me.Controls.Add(Me.cmb_Category)
        Me.Controls.Add(Me.cmb_status)
        Me.Controls.Add(Me.txt_remarks)
        Me.Controls.Add(Me.txt_reason)
        Me.Controls.Add(Me.txt_totalDays)
        Me.Controls.Add(Me.dt_leaveEnd)
        Me.Controls.Add(Me.dt_leaveStart)
        Me.Controls.Add(Me.txt_Supervisor)
        Me.Controls.Add(Me.dt_dateApplied)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLEAVE_DETAILS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Leave Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_totalDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_dateApplied As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Supervisor As System.Windows.Forms.TextBox
    Friend WithEvents dt_leaveStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_leaveEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_totalDays As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_reason As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_remarks As System.Windows.Forms.RichTextBox
    Friend WithEvents cmb_status As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Category As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_employees As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
End Class
