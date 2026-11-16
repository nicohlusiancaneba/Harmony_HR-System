<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUSERS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUSERS))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpUser = New System.Windows.Forms.GroupBox()
        Me.btn_addPic = New System.Windows.Forms.LinkLabel()
        Me.btn_removePic = New System.Windows.Forms.LinkLabel()
        Me.pic_None = New System.Windows.Forms.PictureBox()
        Me.cmb_AccessType = New System.Windows.Forms.ComboBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_userName = New System.Windows.Forms.TextBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.lst_users = New System.Windows.Forms.ListView()
        Me.pic_User = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpUser.SuspendLayout()
        CType(Me.pic_None, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_User, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.Location = New System.Drawing.Point(0, 470)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(488, 50)
        Me.Panel2.TabIndex = 42
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Cancel.Location = New System.Drawing.Point(410, 8)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_Cancel.TabIndex = 19
        Me.btn_Cancel.Text = "&Close"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 50)
        Me.Panel1.TabIndex = 41
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
        Me.Label2.Size = New System.Drawing.Size(91, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Users"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10, 5, 10, 10)
        Me.Panel3.Size = New System.Drawing.Size(488, 420)
        Me.Panel3.TabIndex = 43
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grpUser)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.lst_users)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10, 3, 10, 10)
        Me.GroupBox1.Size = New System.Drawing.Size(468, 405)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'grpUser
        '
        Me.grpUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.grpUser.Controls.Add(Me.btn_addPic)
        Me.grpUser.Controls.Add(Me.btn_removePic)
        Me.grpUser.Controls.Add(Me.pic_None)
        Me.grpUser.Controls.Add(Me.cmb_AccessType)
        Me.grpUser.Controls.Add(Me.txt_password)
        Me.grpUser.Controls.Add(Me.txt_userName)
        Me.grpUser.Controls.Add(Me.btn_close)
        Me.grpUser.Controls.Add(Me.btn_Save)
        Me.grpUser.Controls.Add(Me.Label1)
        Me.grpUser.Controls.Add(Me.pic_User)
        Me.grpUser.Location = New System.Drawing.Point(102, 60)
        Me.grpUser.Name = "grpUser"
        Me.grpUser.Size = New System.Drawing.Size(271, 243)
        Me.grpUser.TabIndex = 713
        Me.grpUser.TabStop = False
        Me.grpUser.Text = "Add/Edit User"
        Me.grpUser.Visible = False
        '
        'btn_addPic
        '
        Me.btn_addPic.AutoSize = True
        Me.btn_addPic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addPic.LinkColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btn_addPic.Location = New System.Drawing.Point(185, 73)
        Me.btn_addPic.Name = "btn_addPic"
        Me.btn_addPic.Size = New System.Drawing.Size(73, 13)
        Me.btn_addPic.TabIndex = 924
        Me.btn_addPic.TabStop = True
        Me.btn_addPic.Text = "Upload Image"
        Me.btn_addPic.Visible = False
        '
        'btn_removePic
        '
        Me.btn_removePic.AutoSize = True
        Me.btn_removePic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_removePic.LinkColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btn_removePic.Location = New System.Drawing.Point(185, 73)
        Me.btn_removePic.Name = "btn_removePic"
        Me.btn_removePic.Size = New System.Drawing.Size(79, 13)
        Me.btn_removePic.TabIndex = 925
        Me.btn_removePic.TabStop = True
        Me.btn_removePic.Text = "Remove Image"
        Me.btn_removePic.Visible = False
        '
        'pic_None
        '
        Me.pic_None.BackColor = System.Drawing.Color.Transparent
        Me.pic_None.Image = CType(resources.GetObject("pic_None.Image"), System.Drawing.Image)
        Me.pic_None.InitialImage = CType(resources.GetObject("pic_None.InitialImage"), System.Drawing.Image)
        Me.pic_None.Location = New System.Drawing.Point(107, 16)
        Me.pic_None.Name = "pic_None"
        Me.pic_None.Size = New System.Drawing.Size(70, 70)
        Me.pic_None.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_None.TabIndex = 922
        Me.pic_None.TabStop = False
        '
        'cmb_AccessType
        '
        Me.cmb_AccessType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_AccessType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_AccessType.FormattingEnabled = True
        Me.cmb_AccessType.Items.AddRange(New Object() {"Administrator", "Accounting", "Human Resource", "Trainee"})
        Me.cmb_AccessType.Location = New System.Drawing.Point(104, 166)
        Me.cmb_AccessType.Name = "cmb_AccessType"
        Me.cmb_AccessType.Size = New System.Drawing.Size(151, 24)
        Me.cmb_AccessType.TabIndex = 24
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_password.Location = New System.Drawing.Point(104, 133)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_password.Size = New System.Drawing.Size(108, 23)
        Me.txt_password.TabIndex = 23
        Me.txt_password.Tag = "inputText"
        '
        'txt_userName
        '
        Me.txt_userName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_userName.Location = New System.Drawing.Point(104, 100)
        Me.txt_userName.Name = "txt_userName"
        Me.txt_userName.Size = New System.Drawing.Size(108, 23)
        Me.txt_userName.TabIndex = 22
        Me.txt_userName.Tag = "inputText"
        '
        'btn_close
        '
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_close.Location = New System.Drawing.Point(188, 202)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(70, 30)
        Me.btn_close.TabIndex = 21
        Me.btn_close.Text = "&Cancel"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Save.Location = New System.Drawing.Point(112, 202)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(70, 30)
        Me.btn_Save.TabIndex = 20
        Me.btn_Save.Text = "&Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 170)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Image :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Username :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "User Access :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(169, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 17)
        Me.Label4.TabIndex = 712
        Me.Label4.Text = "|"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_delete.ImageKey = "plus.png"
        Me.btn_delete.Location = New System.Drawing.Point(184, 366)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 30)
        Me.btn_delete.TabIndex = 711
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_edit.ImageKey = "plus.png"
        Me.btn_edit.Location = New System.Drawing.Point(90, 366)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 30)
        Me.btn_edit.TabIndex = 710
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_add.ImageKey = "plus.png"
        Me.btn_add.Location = New System.Drawing.Point(9, 366)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 30)
        Me.btn_add.TabIndex = 709
        Me.btn_add.Text = "Add"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'lst_users
        '
        Me.lst_users.Dock = System.Windows.Forms.DockStyle.Top
        Me.lst_users.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lst_users.FullRowSelect = True
        Me.lst_users.GridLines = True
        Me.lst_users.Location = New System.Drawing.Point(10, 16)
        Me.lst_users.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_users.Name = "lst_users"
        Me.lst_users.Size = New System.Drawing.Size(448, 345)
        Me.lst_users.TabIndex = 708
        Me.lst_users.UseCompatibleStateImageBehavior = False
        Me.lst_users.View = System.Windows.Forms.View.Details
        '
        'pic_User
        '
        Me.pic_User.BackColor = System.Drawing.Color.Transparent
        Me.pic_User.InitialImage = CType(resources.GetObject("pic_User.InitialImage"), System.Drawing.Image)
        Me.pic_User.Location = New System.Drawing.Point(107, 16)
        Me.pic_User.Name = "pic_User"
        Me.pic_User.Size = New System.Drawing.Size(70, 70)
        Me.pic_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_User.TabIndex = 926
        Me.pic_User.TabStop = False
        '
        'FrmUSERS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(488, 520)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUSERS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpUser.ResumeLayout(False)
        Me.grpUser.PerformLayout()
        CType(Me.pic_None, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_User, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lst_users As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents grpUser As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents txt_userName As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents cmb_AccessType As System.Windows.Forms.ComboBox
    Friend WithEvents pic_None As System.Windows.Forms.PictureBox
    Friend WithEvents btn_addPic As System.Windows.Forms.LinkLabel
    Friend WithEvents btn_removePic As System.Windows.Forms.LinkLabel
    Friend WithEvents pic_User As System.Windows.Forms.PictureBox
End Class
