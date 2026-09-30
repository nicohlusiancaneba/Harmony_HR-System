<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmADJUSTMENT_DETAILS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmADJUSTMENT_DETAILS))
        Me.cmb_employees = New System.Windows.Forms.ComboBox()
        Me.lbl_details = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.cmb_adjustmentType = New System.Windows.Forms.ComboBox()
        Me.txt_Prev = New System.Windows.Forms.TextBox()
        Me.txt_newText = New System.Windows.Forms.TextBox()
        Me.cb_Approved = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt_dateAdj = New System.Windows.Forms.DateTimePicker()
        Me.dt_newDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_newText = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.grpAdjustment = New System.Windows.Forms.GroupBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAdjustment.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_employees
        '
        Me.cmb_employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_employees.FormattingEnabled = True
        Me.cmb_employees.Location = New System.Drawing.Point(134, 47)
        Me.cmb_employees.Name = "cmb_employees"
        Me.cmb_employees.Size = New System.Drawing.Size(301, 24)
        Me.cmb_employees.TabIndex = 17
        '
        'lbl_details
        '
        Me.lbl_details.AutoSize = True
        Me.lbl_details.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_details.Location = New System.Drawing.Point(6, 16)
        Me.lbl_details.Name = "lbl_details"
        Me.lbl_details.Size = New System.Drawing.Size(122, 119)
        Me.lbl_details.TabIndex = 16
        Me.lbl_details.Text = "Adjustment Type :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Employee :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Current Record :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New Record :"
        Me.lbl_details.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Cancel.Location = New System.Drawing.Point(682, 8)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_Cancel.TabIndex = 19
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Save.Location = New System.Drawing.Point(606, 8)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(70, 30)
        Me.btn_Save.TabIndex = 18
        Me.btn_Save.Text = "&Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'cmb_adjustmentType
        '
        Me.cmb_adjustmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_adjustmentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_adjustmentType.FormattingEnabled = True
        Me.cmb_adjustmentType.Items.AddRange(New Object() {"Job Position", "Department", "Division", "Regularization", "Resignation", "Termination", "Rehire", "Salary", "Monthly Salary (SSS)", "Monthly Salary (Philhealth)", "Monthly Salary (PAG-IBIG)", "Monthly Salary (BIR)", "Working Days", "Paid Leave Days", "Bank Account No.", "SSS No.", "Philhealth No.", "Tax ID No. (TIN)", "PAG-IBIG No.", "SSS Share", "Philhealth Share", "Tax Amount", "PAG-IBIG Share"})
        Me.cmb_adjustmentType.Location = New System.Drawing.Point(134, 14)
        Me.cmb_adjustmentType.Name = "cmb_adjustmentType"
        Me.cmb_adjustmentType.Size = New System.Drawing.Size(127, 24)
        Me.cmb_adjustmentType.TabIndex = 20
        '
        'txt_Prev
        '
        Me.txt_Prev.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_Prev.Location = New System.Drawing.Point(134, 82)
        Me.txt_Prev.Name = "txt_Prev"
        Me.txt_Prev.ReadOnly = True
        Me.txt_Prev.Size = New System.Drawing.Size(86, 23)
        Me.txt_Prev.TabIndex = 21
        Me.txt_Prev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_newText
        '
        Me.txt_newText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_newText.Location = New System.Drawing.Point(134, 116)
        Me.txt_newText.Name = "txt_newText"
        Me.txt_newText.Size = New System.Drawing.Size(127, 23)
        Me.txt_newText.TabIndex = 22
        Me.txt_newText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_newText.Visible = False
        '
        'cb_Approved
        '
        Me.cb_Approved.AutoSize = True
        Me.cb_Approved.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_Approved.Location = New System.Drawing.Point(498, 13)
        Me.cb_Approved.Name = "cb_Approved"
        Me.cb_Approved.Size = New System.Drawing.Size(88, 21)
        Me.cb_Approved.TabIndex = 23
        Me.cb_Approved.Text = "Approved"
        Me.cb_Approved.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(490, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Date Adjusted :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = False
        '
        'dt_dateAdj
        '
        Me.dt_dateAdj.Enabled = False
        Me.dt_dateAdj.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_dateAdj.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_dateAdj.Location = New System.Drawing.Point(601, 115)
        Me.dt_dateAdj.Name = "dt_dateAdj"
        Me.dt_dateAdj.Size = New System.Drawing.Size(110, 23)
        Me.dt_dateAdj.TabIndex = 25
        Me.dt_dateAdj.Visible = False
        '
        'dt_newDate
        '
        Me.dt_newDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_newDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_newDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_newDate.Location = New System.Drawing.Point(134, 116)
        Me.dt_newDate.Name = "dt_newDate"
        Me.dt_newDate.Size = New System.Drawing.Size(107, 23)
        Me.dt_newDate.TabIndex = 26
        Me.dt_newDate.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_Save)
        Me.Panel2.Controls.Add(Me.cb_Approved)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.Location = New System.Drawing.Point(0, 227)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(777, 50)
        Me.Panel2.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(588, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "|"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(777, 50)
        Me.Panel1.TabIndex = 36
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(45, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Adjustment Details"
        '
        'cmb_newText
        '
        Me.cmb_newText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_newText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_newText.FormattingEnabled = True
        Me.cmb_newText.Location = New System.Drawing.Point(134, 115)
        Me.cmb_newText.Name = "cmb_newText"
        Me.cmb_newText.Size = New System.Drawing.Size(301, 24)
        Me.cmb_newText.TabIndex = 38
        Me.cmb_newText.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(490, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Remarks :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_remarks
        '
        Me.txt_remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_remarks.Location = New System.Drawing.Point(493, 37)
        Me.txt_remarks.Multiline = True
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(253, 69)
        Me.txt_remarks.TabIndex = 40
        Me.txt_remarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpAdjustment
        '
        Me.grpAdjustment.Controls.Add(Me.lbl_details)
        Me.grpAdjustment.Controls.Add(Me.txt_remarks)
        Me.grpAdjustment.Controls.Add(Me.Label4)
        Me.grpAdjustment.Controls.Add(Me.cmb_employees)
        Me.grpAdjustment.Controls.Add(Me.cmb_adjustmentType)
        Me.grpAdjustment.Controls.Add(Me.txt_Prev)
        Me.grpAdjustment.Controls.Add(Me.dt_dateAdj)
        Me.grpAdjustment.Controls.Add(Me.Label1)
        Me.grpAdjustment.Controls.Add(Me.dt_newDate)
        Me.grpAdjustment.Controls.Add(Me.txt_newText)
        Me.grpAdjustment.Controls.Add(Me.cmb_newText)
        Me.grpAdjustment.Location = New System.Drawing.Point(12, 56)
        Me.grpAdjustment.Name = "grpAdjustment"
        Me.grpAdjustment.Size = New System.Drawing.Size(755, 162)
        Me.grpAdjustment.TabIndex = 41
        Me.grpAdjustment.TabStop = False
        '
        'FrmADJUSTMENT_DETAILS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(777, 277)
        Me.Controls.Add(Me.grpAdjustment)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmADJUSTMENT_DETAILS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adjustment Detail"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAdjustment.ResumeLayout(False)
        Me.grpAdjustment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_employees As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_details As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents cmb_adjustmentType As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Prev As System.Windows.Forms.TextBox
    Friend WithEvents txt_newText As System.Windows.Forms.TextBox
    Friend WithEvents cb_Approved As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dt_dateAdj As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_newDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_newText As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents grpAdjustment As System.Windows.Forms.GroupBox
End Class
