<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormREPORT_CREATE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormREPORT_CREATE))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupboxDates = New System.Windows.Forms.GroupBox()
        Me.dt_to = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_from = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_reportType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupboxDates.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 31)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Generate Report"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Harmony.My.Resources.Resources.reports2
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'groupboxDates
        '
        Me.groupboxDates.Controls.Add(Me.dt_to)
        Me.groupboxDates.Controls.Add(Me.Label2)
        Me.groupboxDates.Controls.Add(Me.dt_from)
        Me.groupboxDates.Controls.Add(Me.Label3)
        Me.groupboxDates.Location = New System.Drawing.Point(12, 116)
        Me.groupboxDates.Name = "groupboxDates"
        Me.groupboxDates.Size = New System.Drawing.Size(464, 60)
        Me.groupboxDates.TabIndex = 21
        Me.groupboxDates.TabStop = False
        Me.groupboxDates.Text = "Select Inclusive Dates"
        '
        'dt_to
        '
        Me.dt_to.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dt_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_to.Location = New System.Drawing.Point(327, 21)
        Me.dt_to.Name = "dt_to"
        Me.dt_to.Size = New System.Drawing.Size(128, 26)
        Me.dt_to.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(252, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Date To :"
        '
        'dt_from
        '
        Me.dt_from.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dt_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_from.Location = New System.Drawing.Point(105, 21)
        Me.dt_from.Name = "dt_from"
        Me.dt_from.Size = New System.Drawing.Size(128, 26)
        Me.dt_from.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Date From :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmb_reportType)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 61)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Type of Report"
        '
        'cmb_reportType
        '
        Me.cmb_reportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_reportType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmb_reportType.FormattingEnabled = True
        Me.cmb_reportType.Items.AddRange(New Object() {"Adjustments", "Deductions", "Employee Upcoming Birthdays", "Employees (All)", "Employees (Regular)", "Employees (Probationary)", "Employees (Terminated/Resigned)", "Leaves", "Loan Balances", "Loan Payments (Payroll)", "Loan Payments (Non-Payroll)", "New Employees", "New Loans", "Payroll"})
        Me.cmb_reportType.Location = New System.Drawing.Point(63, 19)
        Me.cmb_reportType.Name = "cmb_reportType"
        Me.cmb_reportType.Size = New System.Drawing.Size(247, 28)
        Me.cmb_reportType.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Type :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(9, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(446, 45)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(406, 254)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_Cancel.TabIndex = 31
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(330, 254)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(70, 30)
        Me.btn_Save.TabIndex = 30
        Me.btn_Save.Text = "&Submit"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'FormREPORT_CREATE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 296)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupboxDates)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormREPORT_CREATE"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Report"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupboxDates.ResumeLayout(False)
        Me.groupboxDates.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents groupboxDates As System.Windows.Forms.GroupBox
    Friend WithEvents dt_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_reportType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
End Class
