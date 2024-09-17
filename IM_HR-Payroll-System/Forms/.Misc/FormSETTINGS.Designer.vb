<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSETTINGS
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Business = New System.Windows.Forms.TabPage()
        Me.txt_buss_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Server = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_buss_address = New System.Windows.Forms.TextBox()
        Me.txt_buss_contact = New System.Windows.Forms.TextBox()
        Me.txt_buss_email = New System.Windows.Forms.TextBox()
        Me.txt_buss_website = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_dbname = New System.Windows.Forms.ComboBox()
        Me.txtip = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtservername = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.Business.SuspendLayout()
        Me.Server.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Business)
        Me.TabControl1.Controls.Add(Me.Server)
        Me.TabControl1.Location = New System.Drawing.Point(12, 77)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(371, 213)
        Me.TabControl1.TabIndex = 0
        '
        'Business
        '
        Me.Business.BackColor = System.Drawing.SystemColors.Control
        Me.Business.Controls.Add(Me.txt_buss_website)
        Me.Business.Controls.Add(Me.txt_buss_email)
        Me.Business.Controls.Add(Me.txt_buss_contact)
        Me.Business.Controls.Add(Me.txt_buss_address)
        Me.Business.Controls.Add(Me.txt_buss_name)
        Me.Business.Controls.Add(Me.Label1)
        Me.Business.Location = New System.Drawing.Point(4, 22)
        Me.Business.Name = "Business"
        Me.Business.Padding = New System.Windows.Forms.Padding(3)
        Me.Business.Size = New System.Drawing.Size(363, 187)
        Me.Business.TabIndex = 0
        Me.Business.Text = "Business"
        '
        'txt_buss_name
        '
        Me.txt_buss_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buss_name.Location = New System.Drawing.Point(130, 14)
        Me.txt_buss_name.Name = "txt_buss_name"
        Me.txt_buss_name.Size = New System.Drawing.Size(163, 23)
        Me.txt_buss_name.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 153)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Address :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contact Number :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Email Address :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Website :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Server
        '
        Me.Server.BackColor = System.Drawing.SystemColors.Control
        Me.Server.Controls.Add(Me.Label11)
        Me.Server.Controls.Add(Me.txtusername)
        Me.Server.Controls.Add(Me.cmb_dbname)
        Me.Server.Controls.Add(Me.txtservername)
        Me.Server.Controls.Add(Me.txtpassword)
        Me.Server.Controls.Add(Me.txtip)
        Me.Server.Location = New System.Drawing.Point(4, 22)
        Me.Server.Name = "Server"
        Me.Server.Padding = New System.Windows.Forms.Padding(3)
        Me.Server.Size = New System.Drawing.Size(363, 187)
        Me.Server.TabIndex = 1
        Me.Server.Text = "Server"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Adjust system settings and preferences."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 31)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Settings"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Harmony.My.Resources.Resources.settings
        Me.PictureBox1.Location = New System.Drawing.Point(13, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'txt_buss_address
        '
        Me.txt_buss_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buss_address.Location = New System.Drawing.Point(130, 48)
        Me.txt_buss_address.Name = "txt_buss_address"
        Me.txt_buss_address.Size = New System.Drawing.Size(222, 23)
        Me.txt_buss_address.TabIndex = 2
        '
        'txt_buss_contact
        '
        Me.txt_buss_contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buss_contact.Location = New System.Drawing.Point(130, 81)
        Me.txt_buss_contact.Name = "txt_buss_contact"
        Me.txt_buss_contact.Size = New System.Drawing.Size(138, 23)
        Me.txt_buss_contact.TabIndex = 3
        '
        'txt_buss_email
        '
        Me.txt_buss_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buss_email.Location = New System.Drawing.Point(130, 115)
        Me.txt_buss_email.Name = "txt_buss_email"
        Me.txt_buss_email.Size = New System.Drawing.Size(222, 23)
        Me.txt_buss_email.TabIndex = 4
        '
        'txt_buss_website
        '
        Me.txt_buss_website.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buss_website.Location = New System.Drawing.Point(130, 145)
        Me.txt_buss_website.Name = "txt_buss_website"
        Me.txt_buss_website.Size = New System.Drawing.Size(138, 23)
        Me.txt_buss_website.TabIndex = 5
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(231, 295)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(64, 29)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(304, 295)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(64, 29)
        Me.btn_cancel.TabIndex = 15
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(50, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 153)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Database :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IP Address :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Server Name :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Username :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_dbname
        '
        Me.cmb_dbname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_dbname.Enabled = False
        Me.cmb_dbname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_dbname.FormattingEnabled = True
        Me.cmb_dbname.Items.AddRange(New Object() {"", "BCVR-HR"})
        Me.cmb_dbname.Location = New System.Drawing.Point(155, 11)
        Me.cmb_dbname.Name = "cmb_dbname"
        Me.cmb_dbname.Size = New System.Drawing.Size(94, 24)
        Me.cmb_dbname.TabIndex = 13
        '
        'txtip
        '
        Me.txtip.Enabled = False
        Me.txtip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtip.Location = New System.Drawing.Point(155, 47)
        Me.txtip.Name = "txtip"
        Me.txtip.Size = New System.Drawing.Size(132, 23)
        Me.txtip.TabIndex = 1
        '
        'txtpassword
        '
        Me.txtpassword.Enabled = False
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtpassword.Location = New System.Drawing.Point(155, 148)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(132, 23)
        Me.txtpassword.TabIndex = 7
        '
        'txtservername
        '
        Me.txtservername.Enabled = False
        Me.txtservername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtservername.Location = New System.Drawing.Point(155, 81)
        Me.txtservername.Name = "txtservername"
        Me.txtservername.Size = New System.Drawing.Size(132, 23)
        Me.txtservername.TabIndex = 3
        '
        'txtusername
        '
        Me.txtusername.Enabled = False
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtusername.Location = New System.Drawing.Point(155, 114)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(132, 23)
        Me.txtusername.TabIndex = 6
        '
        'FormSETTINGS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 333)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSETTINGS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.Business.ResumeLayout(False)
        Me.Business.PerformLayout()
        Me.Server.ResumeLayout(False)
        Me.Server.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Business As System.Windows.Forms.TabPage
    Friend WithEvents Server As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_buss_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_buss_website As System.Windows.Forms.TextBox
    Friend WithEvents txt_buss_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_buss_contact As System.Windows.Forms.TextBox
    Friend WithEvents txt_buss_address As System.Windows.Forms.TextBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents cmb_dbname As System.Windows.Forms.ComboBox
    Friend WithEvents txtservername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtip As System.Windows.Forms.TextBox
End Class
