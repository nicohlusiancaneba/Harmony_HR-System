<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLOAN_NEW
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLOAN_NEW))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_netAmount = New System.Windows.Forms.TextBox()
        Me.txt_interestRate = New System.Windows.Forms.TextBox()
        Me.txt_grossAmount = New System.Windows.Forms.TextBox()
        Me.dt_payStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dt_payEndDate = New System.Windows.Forms.DateTimePicker()
        Me.txt_loanReason = New System.Windows.Forms.RichTextBox()
        Me.txt_loanRemarks = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.cmb_employees = New System.Windows.Forms.ComboBox()
        Me.cmb_loanType = New System.Windows.Forms.ComboBox()
        Me.txt_suggestedDeduction = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(25, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 255)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Employee :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loan Type :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Net Amount :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Interest Rate :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gross Amount :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cutoff Pay Start Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cutoff Pay End Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Suggested Deduction :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_netAmount
        '
        Me.txt_netAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_netAmount.Location = New System.Drawing.Point(183, 130)
        Me.txt_netAmount.Name = "txt_netAmount"
        Me.txt_netAmount.Size = New System.Drawing.Size(94, 23)
        Me.txt_netAmount.TabIndex = 20
        Me.txt_netAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_interestRate
        '
        Me.txt_interestRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_interestRate.Location = New System.Drawing.Point(183, 163)
        Me.txt_interestRate.Name = "txt_interestRate"
        Me.txt_interestRate.Size = New System.Drawing.Size(43, 23)
        Me.txt_interestRate.TabIndex = 21
        Me.txt_interestRate.Text = "0"
        Me.txt_interestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_grossAmount
        '
        Me.txt_grossAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_grossAmount.Location = New System.Drawing.Point(183, 197)
        Me.txt_grossAmount.Name = "txt_grossAmount"
        Me.txt_grossAmount.ReadOnly = True
        Me.txt_grossAmount.Size = New System.Drawing.Size(94, 23)
        Me.txt_grossAmount.TabIndex = 22
        Me.txt_grossAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dt_payStartDate
        '
        Me.dt_payStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_payStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_payStartDate.Location = New System.Drawing.Point(183, 232)
        Me.dt_payStartDate.Name = "dt_payStartDate"
        Me.dt_payStartDate.Size = New System.Drawing.Size(107, 23)
        Me.dt_payStartDate.TabIndex = 23
        '
        'dt_payEndDate
        '
        Me.dt_payEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_payEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_payEndDate.Location = New System.Drawing.Point(183, 265)
        Me.dt_payEndDate.Name = "dt_payEndDate"
        Me.dt_payEndDate.Size = New System.Drawing.Size(107, 23)
        Me.dt_payEndDate.TabIndex = 24
        '
        'txt_loanReason
        '
        Me.txt_loanReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_loanReason.Location = New System.Drawing.Point(549, 63)
        Me.txt_loanReason.Name = "txt_loanReason"
        Me.txt_loanReason.Size = New System.Drawing.Size(222, 99)
        Me.txt_loanReason.TabIndex = 25
        Me.txt_loanReason.Text = ""
        '
        'txt_loanRemarks
        '
        Me.txt_loanRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_loanRemarks.Location = New System.Drawing.Point(549, 180)
        Me.txt_loanRemarks.Name = "txt_loanRemarks"
        Me.txt_loanRemarks.Size = New System.Drawing.Size(222, 99)
        Me.txt_loanRemarks.TabIndex = 26
        Me.txt_loanRemarks.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(225, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "%"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_submit
        '
        Me.btn_submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_submit.Location = New System.Drawing.Point(625, 8)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(70, 30)
        Me.btn_submit.TabIndex = 28
        Me.btn_submit.Text = "&Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_cancel.Location = New System.Drawing.Point(701, 8)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_cancel.TabIndex = 29
        Me.btn_cancel.Text = "&Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'cmb_employees
        '
        Me.cmb_employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_employees.FormattingEnabled = True
        Me.cmb_employees.Location = New System.Drawing.Point(183, 60)
        Me.cmb_employees.Name = "cmb_employees"
        Me.cmb_employees.Size = New System.Drawing.Size(222, 24)
        Me.cmb_employees.TabIndex = 30
        '
        'cmb_loanType
        '
        Me.cmb_loanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_loanType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_loanType.FormattingEnabled = True
        Me.cmb_loanType.Items.AddRange(New Object() {"", "Allowance Advance", "Cash Advance", "Emergency", "Personal", "Product", "SSS", "PAG-IBIG"})
        Me.cmb_loanType.Location = New System.Drawing.Point(183, 95)
        Me.cmb_loanType.Name = "cmb_loanType"
        Me.cmb_loanType.Size = New System.Drawing.Size(127, 24)
        Me.cmb_loanType.TabIndex = 31
        '
        'txt_suggestedDeduction
        '
        Me.txt_suggestedDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_suggestedDeduction.Location = New System.Drawing.Point(183, 300)
        Me.txt_suggestedDeduction.Name = "txt_suggestedDeduction"
        Me.txt_suggestedDeduction.ReadOnly = True
        Me.txt_suggestedDeduction.Size = New System.Drawing.Size(100, 23)
        Me.txt_suggestedDeduction.TabIndex = 32
        Me.txt_suggestedDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(783, 50)
        Me.Panel1.TabIndex = 34
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(45, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Loan Details - New"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_submit)
        Me.Panel2.Controls.Add(Me.btn_cancel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.Location = New System.Drawing.Point(0, 342)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(783, 50)
        Me.Panel2.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(435, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 136)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Loan Reason :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loan Remarks :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FrmLOAN_NEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(783, 392)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_suggestedDeduction)
        Me.Controls.Add(Me.cmb_loanType)
        Me.Controls.Add(Me.cmb_employees)
        Me.Controls.Add(Me.txt_loanRemarks)
        Me.Controls.Add(Me.txt_loanReason)
        Me.Controls.Add(Me.dt_payEndDate)
        Me.Controls.Add(Me.dt_payStartDate)
        Me.Controls.Add(Me.txt_grossAmount)
        Me.Controls.Add(Me.txt_interestRate)
        Me.Controls.Add(Me.txt_netAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLOAN_NEW"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Details - New"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_netAmount As System.Windows.Forms.TextBox
    Friend WithEvents txt_interestRate As System.Windows.Forms.TextBox
    Friend WithEvents txt_grossAmount As System.Windows.Forms.TextBox
    Friend WithEvents dt_payStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_payEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_loanReason As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_loanRemarks As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents cmb_employees As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_loanType As System.Windows.Forms.ComboBox
    Friend WithEvents txt_suggestedDeduction As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
