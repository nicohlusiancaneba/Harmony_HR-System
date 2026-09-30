<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLOAN_PAYMENT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLOAN_PAYMENT))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.dt_paymentDate = New System.Windows.Forms.DateTimePicker()
        Me.txt_grossAmount = New System.Windows.Forms.TextBox()
        Me.txt_remarks = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(17, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 85)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Payment Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Amount :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remarks :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_cancel.Location = New System.Drawing.Point(332, 8)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_cancel.TabIndex = 43
        Me.btn_cancel.Text = "&Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_save.Location = New System.Drawing.Point(257, 8)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(70, 30)
        Me.btn_save.TabIndex = 42
        Me.btn_save.Text = "&Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'dt_paymentDate
        '
        Me.dt_paymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_paymentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_paymentDate.Location = New System.Drawing.Point(128, 67)
        Me.dt_paymentDate.Name = "dt_paymentDate"
        Me.dt_paymentDate.Size = New System.Drawing.Size(127, 23)
        Me.dt_paymentDate.TabIndex = 44
        '
        'txt_grossAmount
        '
        Me.txt_grossAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_grossAmount.Location = New System.Drawing.Point(128, 101)
        Me.txt_grossAmount.Name = "txt_grossAmount"
        Me.txt_grossAmount.Size = New System.Drawing.Size(100, 23)
        Me.txt_grossAmount.TabIndex = 47
        Me.txt_grossAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_remarks
        '
        Me.txt_remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_remarks.Location = New System.Drawing.Point(128, 138)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(274, 73)
        Me.txt_remarks.TabIndex = 48
        Me.txt_remarks.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 50)
        Me.Panel1.TabIndex = 49
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(48, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Loan Payment"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_cancel)
        Me.Panel3.Controls.Add(Me.btn_save)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel3.Location = New System.Drawing.Point(0, 225)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(416, 50)
        Me.Panel3.TabIndex = 148
        '
        'FrmLOAN_PAYMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(416, 275)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_remarks)
        Me.Controls.Add(Me.txt_grossAmount)
        Me.Controls.Add(Me.dt_paymentDate)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLOAN_PAYMENT"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Payment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents dt_paymentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_grossAmount As System.Windows.Forms.TextBox
    Friend WithEvents txt_remarks As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
