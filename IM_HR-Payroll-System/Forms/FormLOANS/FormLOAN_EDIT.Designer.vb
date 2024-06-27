<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLOAN_EDIT
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_employees = New System.Windows.Forms.ComboBox()
        Me.txt_loanRemarks = New System.Windows.Forms.RichTextBox()
        Me.txt_loanReason = New System.Windows.Forms.RichTextBox()
        Me.dt_payEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dt_payStartDate = New System.Windows.Forms.DateTimePicker()
        Me.txt_grossAmount = New System.Windows.Forms.TextBox()
        Me.txt_interestRate = New System.Windows.Forms.TextBox()
        Me.txt_netAmount = New System.Windows.Forms.TextBox()
        Me.lst_employees = New System.Windows.Forms.ListView()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_balanceAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_loanStatus = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_loanType = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 26)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Employee Loan Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IM_HR_Payroll_System.My.Resources.Resources.loan
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 180)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Employee :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Net Amount :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Interest Rate :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gross Amount :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Balance Amount" & _
    " :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(410, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 200)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Loan Type :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Payment Start Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Payment End Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loan Reason :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L" & _
    "oan Remarks :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmb_employees
        '
        Me.cmb_employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_employees.FormattingEnabled = True
        Me.cmb_employees.Location = New System.Drawing.Point(153, 51)
        Me.cmb_employees.Name = "cmb_employees"
        Me.cmb_employees.Size = New System.Drawing.Size(199, 28)
        Me.cmb_employees.TabIndex = 38
        '
        'txt_loanRemarks
        '
        Me.txt_loanRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loanRemarks.Location = New System.Drawing.Point(573, 195)
        Me.txt_loanRemarks.Name = "txt_loanRemarks"
        Me.txt_loanRemarks.Size = New System.Drawing.Size(199, 50)
        Me.txt_loanRemarks.TabIndex = 37
        Me.txt_loanRemarks.Text = ""
        '
        'txt_loanReason
        '
        Me.txt_loanReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loanReason.Location = New System.Drawing.Point(573, 139)
        Me.txt_loanReason.Name = "txt_loanReason"
        Me.txt_loanReason.Size = New System.Drawing.Size(199, 50)
        Me.txt_loanReason.TabIndex = 36
        Me.txt_loanReason.Text = ""
        '
        'dt_payEndDate
        '
        Me.dt_payEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_payEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_payEndDate.Location = New System.Drawing.Point(573, 94)
        Me.dt_payEndDate.Name = "dt_payEndDate"
        Me.dt_payEndDate.Size = New System.Drawing.Size(127, 26)
        Me.dt_payEndDate.TabIndex = 35
        '
        'dt_payStartDate
        '
        Me.dt_payStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_payStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_payStartDate.Location = New System.Drawing.Point(574, 53)
        Me.dt_payStartDate.Name = "dt_payStartDate"
        Me.dt_payStartDate.Size = New System.Drawing.Size(127, 26)
        Me.dt_payStartDate.TabIndex = 34
        '
        'txt_grossAmount
        '
        Me.txt_grossAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_grossAmount.Location = New System.Drawing.Point(153, 171)
        Me.txt_grossAmount.Name = "txt_grossAmount"
        Me.txt_grossAmount.ReadOnly = True
        Me.txt_grossAmount.Size = New System.Drawing.Size(100, 26)
        Me.txt_grossAmount.TabIndex = 33
        Me.txt_grossAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_interestRate
        '
        Me.txt_interestRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_interestRate.Location = New System.Drawing.Point(153, 132)
        Me.txt_interestRate.Name = "txt_interestRate"
        Me.txt_interestRate.Size = New System.Drawing.Size(43, 26)
        Me.txt_interestRate.TabIndex = 32
        Me.txt_interestRate.Text = "0"
        Me.txt_interestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_netAmount
        '
        Me.txt_netAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_netAmount.Location = New System.Drawing.Point(153, 92)
        Me.txt_netAmount.Name = "txt_netAmount"
        Me.txt_netAmount.Size = New System.Drawing.Size(100, 26)
        Me.txt_netAmount.TabIndex = 31
        Me.txt_netAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lst_employees
        '
        Me.lst_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_employees.FullRowSelect = True
        Me.lst_employees.GridLines = True
        Me.lst_employees.Location = New System.Drawing.Point(11, 285)
        Me.lst_employees.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_employees.Name = "lst_employees"
        Me.lst_employees.Size = New System.Drawing.Size(798, 214)
        Me.lst_employees.TabIndex = 39
        Me.lst_employees.UseCompatibleStateImageBehavior = False
        Me.lst_employees.View = System.Windows.Forms.View.Details
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(734, 504)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 27)
        Me.btn_cancel.TabIndex = 41
        Me.btn_cancel.Text = "&Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(653, 504)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 27)
        Me.btn_save.TabIndex = 40
        Me.btn_save.Text = "&Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'txt_balanceAmount
        '
        Me.txt_balanceAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_balanceAmount.Location = New System.Drawing.Point(153, 211)
        Me.txt_balanceAmount.Name = "txt_balanceAmount"
        Me.txt_balanceAmount.ReadOnly = True
        Me.txt_balanceAmount.Size = New System.Drawing.Size(100, 26)
        Me.txt_balanceAmount.TabIndex = 42
        Me.txt_balanceAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(202, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 20)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "%"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 507)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 20)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Loan Status :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmb_loanStatus
        '
        Me.cmb_loanStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_loanStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_loanStatus.FormattingEnabled = True
        Me.cmb_loanStatus.Items.AddRange(New Object() {"", "Active", "Paid", "Pending", "Rejected"})
        Me.cmb_loanStatus.Location = New System.Drawing.Point(122, 504)
        Me.cmb_loanStatus.Name = "cmb_loanStatus"
        Me.cmb_loanStatus.Size = New System.Drawing.Size(113, 28)
        Me.cmb_loanStatus.TabIndex = 45
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(11, 256)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 26)
        Me.Panel1.TabIndex = 139
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(3, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 19)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "List of Payments"
        '
        'cmb_loanType
        '
        Me.cmb_loanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_loanType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_loanType.FormattingEnabled = True
        Me.cmb_loanType.Items.AddRange(New Object() {"", "Cash Advance", "Emergency", "Product", "Salary"})
        Me.cmb_loanType.Location = New System.Drawing.Point(573, 9)
        Me.cmb_loanType.Name = "cmb_loanType"
        Me.cmb_loanType.Size = New System.Drawing.Size(127, 28)
        Me.cmb_loanType.TabIndex = 140
        '
        'FormLOAN_EDIT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 542)
        Me.Controls.Add(Me.cmb_loanType)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmb_loanStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_balanceAmount)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.lst_employees)
        Me.Controls.Add(Me.cmb_employees)
        Me.Controls.Add(Me.txt_loanRemarks)
        Me.Controls.Add(Me.txt_loanReason)
        Me.Controls.Add(Me.dt_payEndDate)
        Me.Controls.Add(Me.dt_payStartDate)
        Me.Controls.Add(Me.txt_grossAmount)
        Me.Controls.Add(Me.txt_interestRate)
        Me.Controls.Add(Me.txt_netAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormLOAN_EDIT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Loan Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_employees As System.Windows.Forms.ComboBox
    Friend WithEvents txt_loanRemarks As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_loanReason As System.Windows.Forms.RichTextBox
    Friend WithEvents dt_payEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_payStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_grossAmount As System.Windows.Forms.TextBox
    Friend WithEvents txt_interestRate As System.Windows.Forms.TextBox
    Friend WithEvents txt_netAmount As System.Windows.Forms.TextBox
    Friend WithEvents lst_employees As System.Windows.Forms.ListView
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txt_balanceAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_loanStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmb_loanType As System.Windows.Forms.ComboBox
End Class
