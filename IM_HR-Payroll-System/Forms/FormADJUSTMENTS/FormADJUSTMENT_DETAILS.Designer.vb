<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormADJUSTMENT_DETAILS
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmb_employees = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.cmb_adjustmentType = New System.Windows.Forms.ComboBox()
        Me.txt_Prev = New System.Windows.Forms.TextBox()
        Me.txt_New = New System.Windows.Forms.TextBox()
        Me.cb_Approved = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt_dateAdj = New System.Windows.Forms.DateTimePicker()
        Me.dt_regularization = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 26)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Adjustment Record"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Harmony.My.Resources.Resources.adjustment
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'cmb_employees
        '
        Me.cmb_employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_employees.FormattingEnabled = True
        Me.cmb_employees.Location = New System.Drawing.Point(152, 56)
        Me.cmb_employees.Name = "cmb_employees"
        Me.cmb_employees.Size = New System.Drawing.Size(344, 28)
        Me.cmb_employees.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 160)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Employee :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Adjustment Type :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Previous Record :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New Record :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(444, 229)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_Cancel.TabIndex = 19
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(368, 229)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(70, 30)
        Me.btn_Save.TabIndex = 18
        Me.btn_Save.Text = "&Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'cmb_adjustmentType
        '
        Me.cmb_adjustmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_adjustmentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_adjustmentType.FormattingEnabled = True
        Me.cmb_adjustmentType.Items.AddRange(New Object() {"Regularization", "Salary", "SSS", "Pag-Ibig", "Philhealth", "Tax"})
        Me.cmb_adjustmentType.Location = New System.Drawing.Point(152, 97)
        Me.cmb_adjustmentType.Name = "cmb_adjustmentType"
        Me.cmb_adjustmentType.Size = New System.Drawing.Size(127, 28)
        Me.cmb_adjustmentType.TabIndex = 20
        '
        'txt_Prev
        '
        Me.txt_Prev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Prev.Location = New System.Drawing.Point(152, 138)
        Me.txt_Prev.Name = "txt_Prev"
        Me.txt_Prev.ReadOnly = True
        Me.txt_Prev.Size = New System.Drawing.Size(86, 26)
        Me.txt_Prev.TabIndex = 21
        '
        'txt_New
        '
        Me.txt_New.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_New.Location = New System.Drawing.Point(152, 178)
        Me.txt_New.Name = "txt_New"
        Me.txt_New.Size = New System.Drawing.Size(86, 26)
        Me.txt_New.TabIndex = 22
        '
        'cb_Approved
        '
        Me.cb_Approved.AutoSize = True
        Me.cb_Approved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Approved.Location = New System.Drawing.Point(12, 233)
        Me.cb_Approved.Name = "cb_Approved"
        Me.cb_Approved.Size = New System.Drawing.Size(96, 24)
        Me.cb_Approved.TabIndex = 23
        Me.cb_Approved.Text = "Approved"
        Me.cb_Approved.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Date Adjusted :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = False
        '
        'dt_dateAdj
        '
        Me.dt_dateAdj.Enabled = False
        Me.dt_dateAdj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_dateAdj.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_dateAdj.Location = New System.Drawing.Point(404, 178)
        Me.dt_dateAdj.Name = "dt_dateAdj"
        Me.dt_dateAdj.Size = New System.Drawing.Size(110, 26)
        Me.dt_dateAdj.TabIndex = 25
        Me.dt_dateAdj.Visible = False
        '
        'dt_regularization
        '
        Me.dt_regularization.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_regularization.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_regularization.Location = New System.Drawing.Point(152, 178)
        Me.dt_regularization.Name = "dt_regularization"
        Me.dt_regularization.Size = New System.Drawing.Size(110, 26)
        Me.dt_regularization.TabIndex = 26
        Me.dt_regularization.Visible = False
        '
        'FormADJUSTMENT_DETAILS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 272)
        Me.Controls.Add(Me.dt_dateAdj)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_Approved)
        Me.Controls.Add(Me.txt_New)
        Me.Controls.Add(Me.txt_Prev)
        Me.Controls.Add(Me.cmb_adjustmentType)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.cmb_employees)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dt_regularization)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormADJUSTMENT_DETAILS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adjustment Detail"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmb_employees As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents cmb_adjustmentType As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Prev As System.Windows.Forms.TextBox
    Friend WithEvents txt_New As System.Windows.Forms.TextBox
    Friend WithEvents cb_Approved As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dt_dateAdj As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_regularization As System.Windows.Forms.DateTimePicker
End Class
