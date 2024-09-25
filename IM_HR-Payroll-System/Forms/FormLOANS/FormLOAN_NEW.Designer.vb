<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLOAN_NEW
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
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 26)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "New Employee Loan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 400)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Employee :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loan Type :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Net Amount :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Interest Rate :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gross Amount :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Suggested Deduction :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cutoff Pay Start Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cutoff Pay End Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lo" & _
    "an Reason :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loan Remarks :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_netAmount
        '
        Me.txt_netAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_netAmount.Location = New System.Drawing.Point(180, 139)
        Me.txt_netAmount.Name = "txt_netAmount"
        Me.txt_netAmount.Size = New System.Drawing.Size(100, 26)
        Me.txt_netAmount.TabIndex = 20
        Me.txt_netAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_interestRate
        '
        Me.txt_interestRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_interestRate.Location = New System.Drawing.Point(180, 179)
        Me.txt_interestRate.Name = "txt_interestRate"
        Me.txt_interestRate.Size = New System.Drawing.Size(43, 26)
        Me.txt_interestRate.TabIndex = 21
        Me.txt_interestRate.Text = "0"
        Me.txt_interestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_grossAmount
        '
        Me.txt_grossAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_grossAmount.Location = New System.Drawing.Point(180, 218)
        Me.txt_grossAmount.Name = "txt_grossAmount"
        Me.txt_grossAmount.ReadOnly = True
        Me.txt_grossAmount.Size = New System.Drawing.Size(100, 26)
        Me.txt_grossAmount.TabIndex = 22
        Me.txt_grossAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dt_payStartDate
        '
        Me.dt_payStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_payStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_payStartDate.Location = New System.Drawing.Point(180, 301)
        Me.dt_payStartDate.Name = "dt_payStartDate"
        Me.dt_payStartDate.Size = New System.Drawing.Size(127, 26)
        Me.dt_payStartDate.TabIndex = 23
        '
        'dt_payEndDate
        '
        Me.dt_payEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_payEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_payEndDate.Location = New System.Drawing.Point(179, 342)
        Me.dt_payEndDate.Name = "dt_payEndDate"
        Me.dt_payEndDate.Size = New System.Drawing.Size(127, 26)
        Me.dt_payEndDate.TabIndex = 24
        '
        'txt_loanReason
        '
        Me.txt_loanReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loanReason.Location = New System.Drawing.Point(179, 387)
        Me.txt_loanReason.Name = "txt_loanReason"
        Me.txt_loanReason.Size = New System.Drawing.Size(199, 50)
        Me.txt_loanReason.TabIndex = 25
        Me.txt_loanReason.Text = ""
        '
        'txt_loanRemarks
        '
        Me.txt_loanRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loanRemarks.Location = New System.Drawing.Point(179, 443)
        Me.txt_loanRemarks.Name = "txt_loanRemarks"
        Me.txt_loanRemarks.Size = New System.Drawing.Size(199, 50)
        Me.txt_loanRemarks.TabIndex = 26
        Me.txt_loanRemarks.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(224, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "%"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_submit
        '
        Me.btn_submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.Location = New System.Drawing.Point(222, 513)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(75, 27)
        Me.btn_submit.TabIndex = 28
        Me.btn_submit.Text = "&Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(303, 513)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 27)
        Me.btn_cancel.TabIndex = 29
        Me.btn_cancel.Text = "&Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'cmb_employees
        '
        Me.cmb_employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_employees.FormattingEnabled = True
        Me.cmb_employees.Location = New System.Drawing.Point(180, 58)
        Me.cmb_employees.Name = "cmb_employees"
        Me.cmb_employees.Size = New System.Drawing.Size(199, 28)
        Me.cmb_employees.TabIndex = 30
        '
        'cmb_loanType
        '
        Me.cmb_loanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_loanType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_loanType.FormattingEnabled = True
        Me.cmb_loanType.Items.AddRange(New Object() {"", "Cash Advance", "Emergency", "Personal", "Product"})
        Me.cmb_loanType.Location = New System.Drawing.Point(180, 98)
        Me.cmb_loanType.Name = "cmb_loanType"
        Me.cmb_loanType.Size = New System.Drawing.Size(127, 28)
        Me.cmb_loanType.TabIndex = 31
        '
        'txt_suggestedDeduction
        '
        Me.txt_suggestedDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_suggestedDeduction.Location = New System.Drawing.Point(180, 259)
        Me.txt_suggestedDeduction.Name = "txt_suggestedDeduction"
        Me.txt_suggestedDeduction.ReadOnly = True
        Me.txt_suggestedDeduction.Size = New System.Drawing.Size(100, 26)
        Me.txt_suggestedDeduction.TabIndex = 32
        Me.txt_suggestedDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(286, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "/ Cutoff"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Harmony.My.Resources.Resources.loan
        Me.PictureBox1.Location = New System.Drawing.Point(5, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'FormLOAN_NEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 554)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_suggestedDeduction)
        Me.Controls.Add(Me.cmb_loanType)
        Me.Controls.Add(Me.cmb_employees)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_loanRemarks)
        Me.Controls.Add(Me.txt_loanReason)
        Me.Controls.Add(Me.dt_payEndDate)
        Me.Controls.Add(Me.dt_payStartDate)
        Me.Controls.Add(Me.txt_grossAmount)
        Me.Controls.Add(Me.txt_interestRate)
        Me.Controls.Add(Me.txt_netAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLOAN_NEW"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Employee Loan"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
