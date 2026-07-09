<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEMPLOYEE_DETAILS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEMPLOYEE_DETAILS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Info = New System.Windows.Forms.TabPage()
        Me.grpEmployeeInfo = New System.Windows.Forms.GroupBox()
        Me.Panel_Picture = New System.Windows.Forms.Panel()
        Me.employee_Pic = New System.Windows.Forms.PictureBox()
        Me.txt_emergencyNo = New System.Windows.Forms.TextBox()
        Me.txt_emergencyRelationship = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_emergencyContact = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_endEmploymentDate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_paidLeaves = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_PAGIBIGvalue = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_taxValue = New System.Windows.Forms.TextBox()
        Me.txt_lastName = New System.Windows.Forms.TextBox()
        Me.txt_philhealthValue = New System.Windows.Forms.TextBox()
        Me.txt_firstName = New System.Windows.Forms.TextBox()
        Me.txt_sssValue = New System.Windows.Forms.TextBox()
        Me.txt_middleName = New System.Windows.Forms.TextBox()
        Me.txt_PAGIBIGno = New System.Windows.Forms.TextBox()
        Me.dt_birthday = New System.Windows.Forms.DateTimePicker()
        Me.txt_tin = New System.Windows.Forms.TextBox()
        Me.cmb_gender = New System.Windows.Forms.ComboBox()
        Me.txt_philhealthNo = New System.Windows.Forms.TextBox()
        Me.cmb_civilStatus = New System.Windows.Forms.ComboBox()
        Me.txt_SSSno = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_bankAccountNo = New System.Windows.Forms.TextBox()
        Me.txt_contact = New System.Windows.Forms.TextBox()
        Me.txt_monthlyRate = New System.Windows.Forms.TextBox()
        Me.cmb_employmentStatus = New System.Windows.Forms.ComboBox()
        Me.txt_workingDays = New System.Windows.Forms.TextBox()
        Me.txt_jobPosition = New System.Windows.Forms.TextBox()
        Me.txt_currentRate = New System.Windows.Forms.TextBox()
        Me.txt_regularizationDate = New System.Windows.Forms.TextBox()
        Me.txt_startingRate = New System.Windows.Forms.TextBox()
        Me.cmb_department = New System.Windows.Forms.ComboBox()
        Me.dt_employmentDate = New System.Windows.Forms.DateTimePicker()
        Me.cmb_division = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Files = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgv_files = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.File_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Modified = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.File_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.File_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.File_Extension = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.File_Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.File_Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Download = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Info.SuspendLayout()
        Me.grpEmployeeInfo.SuspendLayout()
        Me.Panel_Picture.SuspendLayout()
        CType(Me.employee_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Files.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_files, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 50)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(646, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID#"
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
        Me.Label1.Size = New System.Drawing.Size(241, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee Details"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.btn_cancel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.Location = New System.Drawing.Point(0, 564)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(978, 50)
        Me.Panel2.TabIndex = 1
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(790, 8)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(85, 30)
        Me.btn_save.TabIndex = 17
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(881, 8)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(85, 30)
        Me.btn_cancel.TabIndex = 16
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 442)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Picture :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Last Name :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "First Name :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Middle Name :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date o" & _
    "f Birth :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gender :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Civil Status : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Address :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contact No. :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Info)
        Me.TabControl1.Controls.Add(Me.Files)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 50)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(978, 514)
        Me.TabControl1.TabIndex = 3
        '
        'Info
        '
        Me.Info.BackColor = System.Drawing.Color.White
        Me.Info.Controls.Add(Me.grpEmployeeInfo)
        Me.Info.Location = New System.Drawing.Point(4, 22)
        Me.Info.Name = "Info"
        Me.Info.Padding = New System.Windows.Forms.Padding(3)
        Me.Info.Size = New System.Drawing.Size(970, 488)
        Me.Info.TabIndex = 0
        Me.Info.Text = "Info"
        '
        'grpEmployeeInfo
        '
        Me.grpEmployeeInfo.Controls.Add(Me.Panel_Picture)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_emergencyNo)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_emergencyRelationship)
        Me.grpEmployeeInfo.Controls.Add(Me.Label5)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_emergencyContact)
        Me.grpEmployeeInfo.Controls.Add(Me.Label6)
        Me.grpEmployeeInfo.Controls.Add(Me.Label12)
        Me.grpEmployeeInfo.Controls.Add(Me.Label7)
        Me.grpEmployeeInfo.Controls.Add(Me.Label13)
        Me.grpEmployeeInfo.Controls.Add(Me.Label8)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_endEmploymentDate)
        Me.grpEmployeeInfo.Controls.Add(Me.Label9)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_paidLeaves)
        Me.grpEmployeeInfo.Controls.Add(Me.Label11)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_PAGIBIGvalue)
        Me.grpEmployeeInfo.Controls.Add(Me.Label10)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_taxValue)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_lastName)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_philhealthValue)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_firstName)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_sssValue)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_middleName)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_PAGIBIGno)
        Me.grpEmployeeInfo.Controls.Add(Me.dt_birthday)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_tin)
        Me.grpEmployeeInfo.Controls.Add(Me.cmb_gender)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_philhealthNo)
        Me.grpEmployeeInfo.Controls.Add(Me.cmb_civilStatus)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_SSSno)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_address)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_bankAccountNo)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_contact)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_monthlyRate)
        Me.grpEmployeeInfo.Controls.Add(Me.cmb_employmentStatus)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_workingDays)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_jobPosition)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_currentRate)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_regularizationDate)
        Me.grpEmployeeInfo.Controls.Add(Me.txt_startingRate)
        Me.grpEmployeeInfo.Controls.Add(Me.cmb_department)
        Me.grpEmployeeInfo.Controls.Add(Me.dt_employmentDate)
        Me.grpEmployeeInfo.Controls.Add(Me.cmb_division)
        Me.grpEmployeeInfo.Controls.Add(Me.Label3)
        Me.grpEmployeeInfo.Controls.Add(Me.Label4)
        Me.grpEmployeeInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpEmployeeInfo.Location = New System.Drawing.Point(3, 3)
        Me.grpEmployeeInfo.Name = "grpEmployeeInfo"
        Me.grpEmployeeInfo.Size = New System.Drawing.Size(964, 482)
        Me.grpEmployeeInfo.TabIndex = 46
        Me.grpEmployeeInfo.TabStop = False
        '
        'Panel_Picture
        '
        Me.Panel_Picture.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel_Picture.Controls.Add(Me.employee_Pic)
        Me.Panel_Picture.Location = New System.Drawing.Point(111, 18)
        Me.Panel_Picture.Name = "Panel_Picture"
        Me.Panel_Picture.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel_Picture.Size = New System.Drawing.Size(120, 120)
        Me.Panel_Picture.TabIndex = 46
        '
        'employee_Pic
        '
        Me.employee_Pic.BackColor = System.Drawing.Color.White
        Me.employee_Pic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.employee_Pic.Location = New System.Drawing.Point(5, 5)
        Me.employee_Pic.Name = "employee_Pic"
        Me.employee_Pic.Size = New System.Drawing.Size(110, 110)
        Me.employee_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.employee_Pic.TabIndex = 45
        Me.employee_Pic.TabStop = False
        '
        'txt_emergencyNo
        '
        Me.txt_emergencyNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_emergencyNo.Location = New System.Drawing.Point(815, 443)
        Me.txt_emergencyNo.Name = "txt_emergencyNo"
        Me.txt_emergencyNo.Size = New System.Drawing.Size(137, 23)
        Me.txt_emergencyNo.TabIndex = 44
        Me.txt_emergencyNo.Tag = "inputText"
        '
        'txt_emergencyRelationship
        '
        Me.txt_emergencyRelationship.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_emergencyRelationship.Location = New System.Drawing.Point(815, 409)
        Me.txt_emergencyRelationship.Name = "txt_emergencyRelationship"
        Me.txt_emergencyRelationship.Size = New System.Drawing.Size(137, 23)
        Me.txt_emergencyRelationship.TabIndex = 43
        Me.txt_emergencyRelationship.Tag = "inputText"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Personal Info"
        '
        'txt_emergencyContact
        '
        Me.txt_emergencyContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_emergencyContact.Location = New System.Drawing.Point(815, 375)
        Me.txt_emergencyContact.Name = "txt_emergencyContact"
        Me.txt_emergencyContact.Size = New System.Drawing.Size(137, 23)
        Me.txt_emergencyContact.TabIndex = 42
        Me.txt_emergencyContact.Tag = "inputText"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(321, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Wage Info"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(669, 359)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Emergency Info"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(321, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Employment Info"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(672, 377)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 85)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Emergency Contact :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Relationship :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contact No. :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(734, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 119)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "SSS :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Philhealth :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tax :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PAG-IBIG :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_endEmploymentDate
        '
        Me.txt_endEmploymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endEmploymentDate.Location = New System.Drawing.Point(483, 238)
        Me.txt_endEmploymentDate.Name = "txt_endEmploymentDate"
        Me.txt_endEmploymentDate.ReadOnly = True
        Me.txt_endEmploymentDate.Size = New System.Drawing.Size(83, 23)
        Me.txt_endEmploymentDate.TabIndex = 39
        Me.txt_endEmploymentDate.Tag = "inputText"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(669, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Mandatories"
        '
        'txt_paidLeaves
        '
        Me.txt_paidLeaves.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_paidLeaves.Location = New System.Drawing.Point(483, 441)
        Me.txt_paidLeaves.Name = "txt_paidLeaves"
        Me.txt_paidLeaves.Size = New System.Drawing.Size(48, 23)
        Me.txt_paidLeaves.TabIndex = 38
        Me.txt_paidLeaves.Tag = "inputText"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(683, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 153)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Bank Account No. :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SSS No. :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Philhealth No. :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tax ID No. (TIN) :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PAG-" & _
    "IBIG No. :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_PAGIBIGvalue
        '
        Me.txt_PAGIBIGvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PAGIBIGvalue.Location = New System.Drawing.Point(815, 323)
        Me.txt_PAGIBIGvalue.Name = "txt_PAGIBIGvalue"
        Me.txt_PAGIBIGvalue.Size = New System.Drawing.Size(83, 23)
        Me.txt_PAGIBIGvalue.TabIndex = 37
        Me.txt_PAGIBIGvalue.Tag = "inputText"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(669, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Account Number Info"
        '
        'txt_taxValue
        '
        Me.txt_taxValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_taxValue.Location = New System.Drawing.Point(815, 289)
        Me.txt_taxValue.Name = "txt_taxValue"
        Me.txt_taxValue.Size = New System.Drawing.Size(83, 23)
        Me.txt_taxValue.TabIndex = 36
        Me.txt_taxValue.Tag = "inputText"
        '
        'txt_lastName
        '
        Me.txt_lastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lastName.Location = New System.Drawing.Point(111, 170)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.Size = New System.Drawing.Size(136, 23)
        Me.txt_lastName.TabIndex = 11
        Me.txt_lastName.Tag = "inputText"
        '
        'txt_philhealthValue
        '
        Me.txt_philhealthValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_philhealthValue.Location = New System.Drawing.Point(815, 255)
        Me.txt_philhealthValue.Name = "txt_philhealthValue"
        Me.txt_philhealthValue.Size = New System.Drawing.Size(83, 23)
        Me.txt_philhealthValue.TabIndex = 35
        Me.txt_philhealthValue.Tag = "inputText"
        '
        'txt_firstName
        '
        Me.txt_firstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_firstName.Location = New System.Drawing.Point(111, 204)
        Me.txt_firstName.Name = "txt_firstName"
        Me.txt_firstName.Size = New System.Drawing.Size(136, 23)
        Me.txt_firstName.TabIndex = 12
        Me.txt_firstName.Tag = "inputText"
        '
        'txt_sssValue
        '
        Me.txt_sssValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sssValue.Location = New System.Drawing.Point(815, 221)
        Me.txt_sssValue.Name = "txt_sssValue"
        Me.txt_sssValue.Size = New System.Drawing.Size(83, 23)
        Me.txt_sssValue.TabIndex = 34
        Me.txt_sssValue.Tag = "inputText"
        '
        'txt_middleName
        '
        Me.txt_middleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_middleName.Location = New System.Drawing.Point(111, 238)
        Me.txt_middleName.Name = "txt_middleName"
        Me.txt_middleName.Size = New System.Drawing.Size(136, 23)
        Me.txt_middleName.TabIndex = 13
        Me.txt_middleName.Tag = "inputText"
        '
        'txt_PAGIBIGno
        '
        Me.txt_PAGIBIGno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PAGIBIGno.Location = New System.Drawing.Point(815, 170)
        Me.txt_PAGIBIGno.Name = "txt_PAGIBIGno"
        Me.txt_PAGIBIGno.Size = New System.Drawing.Size(137, 23)
        Me.txt_PAGIBIGno.TabIndex = 33
        Me.txt_PAGIBIGno.Tag = "inputText"
        '
        'dt_birthday
        '
        Me.dt_birthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_birthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_birthday.Location = New System.Drawing.Point(110, 271)
        Me.dt_birthday.Name = "dt_birthday"
        Me.dt_birthday.Size = New System.Drawing.Size(107, 23)
        Me.dt_birthday.TabIndex = 14
        '
        'txt_tin
        '
        Me.txt_tin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tin.Location = New System.Drawing.Point(815, 135)
        Me.txt_tin.Name = "txt_tin"
        Me.txt_tin.Size = New System.Drawing.Size(137, 23)
        Me.txt_tin.TabIndex = 32
        Me.txt_tin.Tag = "inputText"
        '
        'cmb_gender
        '
        Me.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_gender.FormattingEnabled = True
        Me.cmb_gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmb_gender.Location = New System.Drawing.Point(111, 305)
        Me.cmb_gender.Name = "cmb_gender"
        Me.cmb_gender.Size = New System.Drawing.Size(121, 24)
        Me.cmb_gender.TabIndex = 15
        '
        'txt_philhealthNo
        '
        Me.txt_philhealthNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_philhealthNo.Location = New System.Drawing.Point(815, 101)
        Me.txt_philhealthNo.Name = "txt_philhealthNo"
        Me.txt_philhealthNo.Size = New System.Drawing.Size(137, 23)
        Me.txt_philhealthNo.TabIndex = 31
        Me.txt_philhealthNo.Tag = "inputText"
        '
        'cmb_civilStatus
        '
        Me.cmb_civilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_civilStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_civilStatus.FormattingEnabled = True
        Me.cmb_civilStatus.Items.AddRange(New Object() {"Single", "Married", "Separated", "Divorced", "Widowed"})
        Me.cmb_civilStatus.Location = New System.Drawing.Point(110, 338)
        Me.cmb_civilStatus.Name = "cmb_civilStatus"
        Me.cmb_civilStatus.Size = New System.Drawing.Size(121, 24)
        Me.cmb_civilStatus.TabIndex = 16
        '
        'txt_SSSno
        '
        Me.txt_SSSno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SSSno.Location = New System.Drawing.Point(815, 67)
        Me.txt_SSSno.Name = "txt_SSSno"
        Me.txt_SSSno.Size = New System.Drawing.Size(137, 23)
        Me.txt_SSSno.TabIndex = 30
        Me.txt_SSSno.Tag = "inputText"
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(110, 377)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(180, 54)
        Me.txt_address.TabIndex = 17
        Me.txt_address.Tag = "inputText"
        '
        'txt_bankAccountNo
        '
        Me.txt_bankAccountNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bankAccountNo.Location = New System.Drawing.Point(815, 33)
        Me.txt_bankAccountNo.Name = "txt_bankAccountNo"
        Me.txt_bankAccountNo.Size = New System.Drawing.Size(137, 23)
        Me.txt_bankAccountNo.TabIndex = 29
        Me.txt_bankAccountNo.Tag = "inputText"
        '
        'txt_contact
        '
        Me.txt_contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contact.Location = New System.Drawing.Point(111, 441)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(121, 23)
        Me.txt_contact.TabIndex = 18
        Me.txt_contact.Tag = "inputNum"
        '
        'txt_monthlyRate
        '
        Me.txt_monthlyRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_monthlyRate.Location = New System.Drawing.Point(483, 407)
        Me.txt_monthlyRate.Name = "txt_monthlyRate"
        Me.txt_monthlyRate.ReadOnly = True
        Me.txt_monthlyRate.Size = New System.Drawing.Size(107, 23)
        Me.txt_monthlyRate.TabIndex = 28
        Me.txt_monthlyRate.Tag = "inputText"
        '
        'cmb_employmentStatus
        '
        Me.cmb_employmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employmentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_employmentStatus.FormattingEnabled = True
        Me.cmb_employmentStatus.Items.AddRange(New Object() {"Owner", "Regular", "Probationary", "Probationary (Extended)", "Outsource", "Resigned", "Terminated"})
        Me.cmb_employmentStatus.Location = New System.Drawing.Point(483, 32)
        Me.cmb_employmentStatus.Name = "cmb_employmentStatus"
        Me.cmb_employmentStatus.Size = New System.Drawing.Size(121, 24)
        Me.cmb_employmentStatus.TabIndex = 19
        '
        'txt_workingDays
        '
        Me.txt_workingDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_workingDays.Location = New System.Drawing.Point(483, 373)
        Me.txt_workingDays.Name = "txt_workingDays"
        Me.txt_workingDays.Size = New System.Drawing.Size(48, 23)
        Me.txt_workingDays.TabIndex = 27
        Me.txt_workingDays.Tag = "inputText"
        '
        'txt_jobPosition
        '
        Me.txt_jobPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jobPosition.Location = New System.Drawing.Point(483, 67)
        Me.txt_jobPosition.Name = "txt_jobPosition"
        Me.txt_jobPosition.Size = New System.Drawing.Size(176, 23)
        Me.txt_jobPosition.TabIndex = 20
        Me.txt_jobPosition.Tag = "inputText"
        '
        'txt_currentRate
        '
        Me.txt_currentRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_currentRate.Location = New System.Drawing.Point(483, 339)
        Me.txt_currentRate.Name = "txt_currentRate"
        Me.txt_currentRate.ReadOnly = True
        Me.txt_currentRate.Size = New System.Drawing.Size(83, 23)
        Me.txt_currentRate.TabIndex = 26
        Me.txt_currentRate.Tag = "inputText"
        '
        'txt_regularizationDate
        '
        Me.txt_regularizationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_regularizationDate.Location = New System.Drawing.Point(483, 203)
        Me.txt_regularizationDate.Name = "txt_regularizationDate"
        Me.txt_regularizationDate.ReadOnly = True
        Me.txt_regularizationDate.Size = New System.Drawing.Size(83, 23)
        Me.txt_regularizationDate.TabIndex = 21
        Me.txt_regularizationDate.Tag = "inputText"
        '
        'txt_startingRate
        '
        Me.txt_startingRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_startingRate.Location = New System.Drawing.Point(483, 305)
        Me.txt_startingRate.Name = "txt_startingRate"
        Me.txt_startingRate.Size = New System.Drawing.Size(83, 23)
        Me.txt_startingRate.TabIndex = 25
        Me.txt_startingRate.Tag = "inputText"
        '
        'cmb_department
        '
        Me.cmb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_department.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_department.FormattingEnabled = True
        Me.cmb_department.Location = New System.Drawing.Point(483, 100)
        Me.cmb_department.Name = "cmb_department"
        Me.cmb_department.Size = New System.Drawing.Size(176, 24)
        Me.cmb_department.TabIndex = 22
        '
        'dt_employmentDate
        '
        Me.dt_employmentDate.Enabled = False
        Me.dt_employmentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_employmentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_employmentDate.Location = New System.Drawing.Point(483, 169)
        Me.dt_employmentDate.Name = "dt_employmentDate"
        Me.dt_employmentDate.Size = New System.Drawing.Size(107, 23)
        Me.dt_employmentDate.TabIndex = 24
        '
        'cmb_division
        '
        Me.cmb_division.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_division.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_division.FormattingEnabled = True
        Me.cmb_division.Location = New System.Drawing.Point(483, 134)
        Me.cmb_division.Name = "cmb_division"
        Me.cmb_division.Size = New System.Drawing.Size(176, 24)
        Me.cmb_division.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(324, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 425)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = resources.GetString("Label4.Text")
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Files
        '
        Me.Files.BackColor = System.Drawing.Color.White
        Me.Files.Controls.Add(Me.Panel4)
        Me.Files.Controls.Add(Me.Panel3)
        Me.Files.Location = New System.Drawing.Point(4, 22)
        Me.Files.Name = "Files"
        Me.Files.Padding = New System.Windows.Forms.Padding(3)
        Me.Files.Size = New System.Drawing.Size(970, 488)
        Me.Files.TabIndex = 1
        Me.Files.Text = "Files"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgv_files)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel4.Location = New System.Drawing.Point(3, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(964, 445)
        Me.Panel4.TabIndex = 1
        '
        'dgv_files
        '
        Me.dgv_files.AllowUserToAddRows = False
        Me.dgv_files.AllowUserToDeleteRows = False
        Me.dgv_files.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_files.BackgroundColor = System.Drawing.Color.White
        Me.dgv_files.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_files.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.File_ID, Me.Date_Modified, Me.File_Type, Me.File_Name, Me.File_Extension, Me.File_Remarks, Me.File_Data, Me.Download})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_files.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_files.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_files.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_files.Location = New System.Drawing.Point(0, 0)
        Me.dgv_files.Name = "dgv_files"
        Me.dgv_files.ReadOnly = True
        Me.dgv_files.RowHeadersVisible = False
        Me.dgv_files.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_files.ShowCellErrors = False
        Me.dgv_files.ShowCellToolTips = False
        Me.dgv_files.ShowEditingIcon = False
        Me.dgv_files.ShowRowErrors = False
        Me.dgv_files.Size = New System.Drawing.Size(964, 445)
        Me.dgv_files.TabIndex = 706
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.btn_remove)
        Me.Panel3.Controls.Add(Me.btn_edit)
        Me.Panel3.Controls.Add(Me.btn_add)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(964, 37)
        Me.Panel3.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(867, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(9, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "|"
        '
        'btn_remove
        '
        Me.btn_remove.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_remove.Location = New System.Drawing.Point(884, 3)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(75, 28)
        Me.btn_remove.TabIndex = 2
        Me.btn_remove.Text = "Remove"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_edit.Location = New System.Drawing.Point(783, 3)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 28)
        Me.btn_edit.TabIndex = 1
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_add.Location = New System.Drawing.Point(702, 3)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 28)
        Me.btn_add.TabIndex = 0
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'File_ID
        '
        Me.File_ID.HeaderText = "ID"
        Me.File_ID.Name = "File_ID"
        Me.File_ID.ReadOnly = True
        Me.File_ID.Width = 80
        '
        'Date_Modified
        '
        Me.Date_Modified.HeaderText = "Date Modified"
        Me.Date_Modified.Name = "Date_Modified"
        Me.Date_Modified.ReadOnly = True
        Me.Date_Modified.Width = 130
        '
        'File_Type
        '
        Me.File_Type.HeaderText = "File Type"
        Me.File_Type.Name = "File_Type"
        Me.File_Type.ReadOnly = True
        Me.File_Type.Width = 150
        '
        'File_Name
        '
        Me.File_Name.HeaderText = "File Name"
        Me.File_Name.Name = "File_Name"
        Me.File_Name.ReadOnly = True
        Me.File_Name.Width = 180
        '
        'File_Extension
        '
        Me.File_Extension.HeaderText = "File Extension"
        Me.File_Extension.Name = "File_Extension"
        Me.File_Extension.ReadOnly = True
        '
        'File_Remarks
        '
        Me.File_Remarks.HeaderText = "File Remarks"
        Me.File_Remarks.Name = "File_Remarks"
        Me.File_Remarks.ReadOnly = True
        Me.File_Remarks.Width = 200
        '
        'File_Data
        '
        Me.File_Data.HeaderText = "File Data"
        Me.File_Data.Name = "File_Data"
        Me.File_Data.ReadOnly = True
        Me.File_Data.Visible = False
        '
        'Download
        '
        Me.Download.HeaderText = "Download"
        Me.Download.Name = "Download"
        Me.Download.ReadOnly = True
        '
        'FrmEMPLOYEE_DETAILS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(978, 614)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmEMPLOYEE_DETAILS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Info.ResumeLayout(False)
        Me.grpEmployeeInfo.ResumeLayout(False)
        Me.grpEmployeeInfo.PerformLayout()
        Me.Panel_Picture.ResumeLayout(False)
        CType(Me.employee_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Files.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgv_files, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Info As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Files As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_civilStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_gender As System.Windows.Forms.ComboBox
    Friend WithEvents dt_birthday As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_middleName As System.Windows.Forms.TextBox
    Friend WithEvents txt_firstName As System.Windows.Forms.TextBox
    Friend WithEvents txt_lastName As System.Windows.Forms.TextBox
    Friend WithEvents cmb_employmentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txt_contact As System.Windows.Forms.TextBox
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents dt_employmentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_division As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_department As System.Windows.Forms.ComboBox
    Friend WithEvents txt_regularizationDate As System.Windows.Forms.TextBox
    Friend WithEvents txt_jobPosition As System.Windows.Forms.TextBox
    Friend WithEvents txt_monthlyRate As System.Windows.Forms.TextBox
    Friend WithEvents txt_workingDays As System.Windows.Forms.TextBox
    Friend WithEvents txt_currentRate As System.Windows.Forms.TextBox
    Friend WithEvents txt_startingRate As System.Windows.Forms.TextBox
    Friend WithEvents txt_PAGIBIGvalue As System.Windows.Forms.TextBox
    Friend WithEvents txt_taxValue As System.Windows.Forms.TextBox
    Friend WithEvents txt_philhealthValue As System.Windows.Forms.TextBox
    Friend WithEvents txt_sssValue As System.Windows.Forms.TextBox
    Friend WithEvents txt_PAGIBIGno As System.Windows.Forms.TextBox
    Friend WithEvents txt_tin As System.Windows.Forms.TextBox
    Friend WithEvents txt_philhealthNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_SSSno As System.Windows.Forms.TextBox
    Friend WithEvents txt_bankAccountNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_paidLeaves As System.Windows.Forms.TextBox
    Friend WithEvents txt_endEmploymentDate As System.Windows.Forms.TextBox
    Friend WithEvents txt_emergencyNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_emergencyRelationship As System.Windows.Forms.TextBox
    Friend WithEvents txt_emergencyContact As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents grpEmployeeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Panel_Picture As System.Windows.Forms.Panel
    Friend WithEvents employee_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents dgv_files As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents File_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Date_Modified As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents File_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents File_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents File_Extension As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents File_Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents File_Data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Download As System.Windows.Forms.DataGridViewLinkColumn
End Class
