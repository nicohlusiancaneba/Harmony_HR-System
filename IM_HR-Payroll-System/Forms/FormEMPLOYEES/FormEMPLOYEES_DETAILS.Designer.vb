<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEMPLOYEES_DETAILS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEMPLOYEES_DETAILS))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dt_birthDate = New System.Windows.Forms.DateTimePicker()
        Me.cmb_civilStatus = New System.Windows.Forms.ComboBox()
        Me.cmb_gender = New System.Windows.Forms.ComboBox()
        Me.txt_contactNo = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_middleName = New System.Windows.Forms.TextBox()
        Me.txt_firstName = New System.Windows.Forms.TextBox()
        Me.txt_lastName = New System.Windows.Forms.TextBox()
        Me.txt_IDno = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_emergencyContactNo = New System.Windows.Forms.TextBox()
        Me.txt_emergencyAddress = New System.Windows.Forms.TextBox()
        Me.txt_emergencyRelationship = New System.Windows.Forms.TextBox()
        Me.txt_emergencyContactPerson = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dt_regularizationDate = New System.Windows.Forms.DateTimePicker()
        Me.dt_hiredDate = New System.Windows.Forms.DateTimePicker()
        Me.cmb_division = New System.Windows.Forms.ComboBox()
        Me.cmb_department = New System.Windows.Forms.ComboBox()
        Me.cmb_employmentStatus = New System.Windows.Forms.ComboBox()
        Me.txt_workDaysNo = New System.Windows.Forms.TextBox()
        Me.txt_monthlySalary = New System.Windows.Forms.TextBox()
        Me.txt_currentRate = New System.Windows.Forms.TextBox()
        Me.txt_startingRate = New System.Windows.Forms.TextBox()
        Me.txt_jobPosition = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_pagibigNo = New System.Windows.Forms.TextBox()
        Me.txt_TINno = New System.Windows.Forms.TextBox()
        Me.txt_PhilhealthNo = New System.Windows.Forms.TextBox()
        Me.txt_SSSno = New System.Windows.Forms.TextBox()
        Me.txt_bankNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.txt_pagIbigShare = New System.Windows.Forms.TextBox()
        Me.txt_philhealthShare = New System.Windows.Forms.TextBox()
        Me.txt_SSSshare = New System.Windows.Forms.TextBox()
        Me.txt_taxAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 340)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID No. :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Last Name :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "First Name :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Middle Name :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date of Birth :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ge" & _
    "nder :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Civil Status :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Address :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contact No. :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dt_birthDate)
        Me.GroupBox1.Controls.Add(Me.cmb_civilStatus)
        Me.GroupBox1.Controls.Add(Me.cmb_gender)
        Me.GroupBox1.Controls.Add(Me.txt_contactNo)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.txt_middleName)
        Me.GroupBox1.Controls.Add(Me.txt_firstName)
        Me.GroupBox1.Controls.Add(Me.txt_lastName)
        Me.GroupBox1.Controls.Add(Me.txt_IDno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 380)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Details"
        '
        'dt_birthDate
        '
        Me.dt_birthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_birthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_birthDate.Location = New System.Drawing.Point(132, 173)
        Me.dt_birthDate.Name = "dt_birthDate"
        Me.dt_birthDate.Size = New System.Drawing.Size(121, 26)
        Me.dt_birthDate.TabIndex = 18
        '
        'cmb_civilStatus
        '
        Me.cmb_civilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_civilStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_civilStatus.FormattingEnabled = True
        Me.cmb_civilStatus.Items.AddRange(New Object() {"", "Single", "Married", "Separated", "Divorced", "Widowed"})
        Me.cmb_civilStatus.Location = New System.Drawing.Point(132, 253)
        Me.cmb_civilStatus.Name = "cmb_civilStatus"
        Me.cmb_civilStatus.Size = New System.Drawing.Size(87, 28)
        Me.cmb_civilStatus.TabIndex = 17
        '
        'cmb_gender
        '
        Me.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_gender.FormattingEnabled = True
        Me.cmb_gender.Items.AddRange(New Object() {"", "Male", "Female"})
        Me.cmb_gender.Location = New System.Drawing.Point(132, 212)
        Me.cmb_gender.Name = "cmb_gender"
        Me.cmb_gender.Size = New System.Drawing.Size(87, 28)
        Me.cmb_gender.TabIndex = 16
        '
        'txt_contactNo
        '
        Me.txt_contactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contactNo.Location = New System.Drawing.Point(132, 334)
        Me.txt_contactNo.Name = "txt_contactNo"
        Me.txt_contactNo.Size = New System.Drawing.Size(128, 26)
        Me.txt_contactNo.TabIndex = 9
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(132, 294)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(194, 26)
        Me.txt_address.TabIndex = 8
        '
        'txt_middleName
        '
        Me.txt_middleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_middleName.Location = New System.Drawing.Point(132, 134)
        Me.txt_middleName.Name = "txt_middleName"
        Me.txt_middleName.Size = New System.Drawing.Size(128, 26)
        Me.txt_middleName.TabIndex = 4
        '
        'txt_firstName
        '
        Me.txt_firstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_firstName.Location = New System.Drawing.Point(132, 94)
        Me.txt_firstName.Name = "txt_firstName"
        Me.txt_firstName.Size = New System.Drawing.Size(128, 26)
        Me.txt_firstName.TabIndex = 3
        '
        'txt_lastName
        '
        Me.txt_lastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lastName.Location = New System.Drawing.Point(132, 54)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.Size = New System.Drawing.Size(128, 26)
        Me.txt_lastName.TabIndex = 2
        '
        'txt_IDno
        '
        Me.txt_IDno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IDno.Location = New System.Drawing.Point(132, 14)
        Me.txt_IDno.Name = "txt_IDno"
        Me.txt_IDno.Size = New System.Drawing.Size(87, 26)
        Me.txt_IDno.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_emergencyContactNo)
        Me.GroupBox2.Controls.Add(Me.txt_emergencyAddress)
        Me.GroupBox2.Controls.Add(Me.txt_emergencyRelationship)
        Me.GroupBox2.Controls.Add(Me.txt_emergencyContactPerson)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(368, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 167)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Emergency Contact Info"
        '
        'txt_emergencyContactNo
        '
        Me.txt_emergencyContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_emergencyContactNo.Location = New System.Drawing.Point(150, 134)
        Me.txt_emergencyContactNo.Name = "txt_emergencyContactNo"
        Me.txt_emergencyContactNo.Size = New System.Drawing.Size(122, 26)
        Me.txt_emergencyContactNo.TabIndex = 13
        '
        'txt_emergencyAddress
        '
        Me.txt_emergencyAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_emergencyAddress.Location = New System.Drawing.Point(150, 94)
        Me.txt_emergencyAddress.Name = "txt_emergencyAddress"
        Me.txt_emergencyAddress.Size = New System.Drawing.Size(194, 26)
        Me.txt_emergencyAddress.TabIndex = 12
        '
        'txt_emergencyRelationship
        '
        Me.txt_emergencyRelationship.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_emergencyRelationship.Location = New System.Drawing.Point(150, 54)
        Me.txt_emergencyRelationship.Name = "txt_emergencyRelationship"
        Me.txt_emergencyRelationship.Size = New System.Drawing.Size(122, 26)
        Me.txt_emergencyRelationship.TabIndex = 11
        '
        'txt_emergencyContactPerson
        '
        Me.txt_emergencyContactPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_emergencyContactPerson.Location = New System.Drawing.Point(150, 14)
        Me.txt_emergencyContactPerson.Name = "txt_emergencyContactPerson"
        Me.txt_emergencyContactPerson.Size = New System.Drawing.Size(122, 26)
        Me.txt_emergencyContactPerson.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 140)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contact Person :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Relationship :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Address :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contact No. :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.dt_regularizationDate)
        Me.GroupBox3.Controls.Add(Me.dt_hiredDate)
        Me.GroupBox3.Controls.Add(Me.cmb_division)
        Me.GroupBox3.Controls.Add(Me.cmb_department)
        Me.GroupBox3.Controls.Add(Me.cmb_employmentStatus)
        Me.GroupBox3.Controls.Add(Me.txt_workDaysNo)
        Me.GroupBox3.Controls.Add(Me.txt_monthlySalary)
        Me.GroupBox3.Controls.Add(Me.txt_currentRate)
        Me.GroupBox3.Controls.Add(Me.txt_startingRate)
        Me.GroupBox3.Controls.Add(Me.txt_jobPosition)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(736, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(462, 413)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Employment Record"
        '
        'dt_regularizationDate
        '
        Me.dt_regularizationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_regularizationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_regularizationDate.Location = New System.Drawing.Point(181, 94)
        Me.dt_regularizationDate.Name = "dt_regularizationDate"
        Me.dt_regularizationDate.Size = New System.Drawing.Size(121, 26)
        Me.dt_regularizationDate.TabIndex = 27
        '
        'dt_hiredDate
        '
        Me.dt_hiredDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_hiredDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_hiredDate.Location = New System.Drawing.Point(181, 13)
        Me.dt_hiredDate.Name = "dt_hiredDate"
        Me.dt_hiredDate.Size = New System.Drawing.Size(121, 26)
        Me.dt_hiredDate.TabIndex = 16
        '
        'cmb_division
        '
        Me.cmb_division.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_division.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_division.FormattingEnabled = True
        Me.cmb_division.Items.AddRange(New Object() {"Accounting Division", "Finance Division", "Purchasing Division", "", "Sales Division ", "Marketing Division", "", "Distribution  Division", "Warehouse Division", "Logistics Division", "", "FDA Concerns  Division", "Pharmacy Divison", "QC & QA Division", "CPE Division", "", "IT System Mgmt. Division", "Inventory Management Division", "Software/Web  App Division", "", "Iriga Branch", "Catanduanes Branch", "Masbate Branch", "Sorsogon Branch", "", "Performance Mgmt, Training & Devt. and Operations Division", "Staffing & Personnel Mgmt. Division", "Compensation & Benefits Division", "Legal", "Nurse / Safety Staff"})
        Me.cmb_division.Location = New System.Drawing.Point(181, 211)
        Me.cmb_division.Name = "cmb_division"
        Me.cmb_division.Size = New System.Drawing.Size(269, 28)
        Me.cmb_division.TabIndex = 26
        '
        'cmb_department
        '
        Me.cmb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_department.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_department.FormattingEnabled = True
        Me.cmb_department.Items.AddRange(New Object() {"", "Accounting & Finance Department", "Branch Store Operations Department", "Distribution & Warehouse Department", "Human Resource Department", "Information Technology & Inventory Department", "Regulatory Affairs Department", "Sales & Marketing Department"})
        Me.cmb_department.Location = New System.Drawing.Point(181, 172)
        Me.cmb_department.Name = "cmb_department"
        Me.cmb_department.Size = New System.Drawing.Size(269, 28)
        Me.cmb_department.TabIndex = 25
        '
        'cmb_employmentStatus
        '
        Me.cmb_employmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employmentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_employmentStatus.FormattingEnabled = True
        Me.cmb_employmentStatus.Items.AddRange(New Object() {"", "Regular", "Probationary", "Outsource"})
        Me.cmb_employmentStatus.Location = New System.Drawing.Point(181, 52)
        Me.cmb_employmentStatus.Name = "cmb_employmentStatus"
        Me.cmb_employmentStatus.Size = New System.Drawing.Size(121, 28)
        Me.cmb_employmentStatus.TabIndex = 18
        '
        'txt_workDaysNo
        '
        Me.txt_workDaysNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_workDaysNo.Location = New System.Drawing.Point(181, 373)
        Me.txt_workDaysNo.Name = "txt_workDaysNo"
        Me.txt_workDaysNo.Size = New System.Drawing.Size(86, 26)
        Me.txt_workDaysNo.TabIndex = 23
        '
        'txt_monthlySalary
        '
        Me.txt_monthlySalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_monthlySalary.Location = New System.Drawing.Point(181, 333)
        Me.txt_monthlySalary.Name = "txt_monthlySalary"
        Me.txt_monthlySalary.Size = New System.Drawing.Size(86, 26)
        Me.txt_monthlySalary.TabIndex = 22
        '
        'txt_currentRate
        '
        Me.txt_currentRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_currentRate.Location = New System.Drawing.Point(181, 293)
        Me.txt_currentRate.Name = "txt_currentRate"
        Me.txt_currentRate.Size = New System.Drawing.Size(86, 26)
        Me.txt_currentRate.TabIndex = 21
        '
        'txt_startingRate
        '
        Me.txt_startingRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_startingRate.Location = New System.Drawing.Point(181, 254)
        Me.txt_startingRate.Name = "txt_startingRate"
        Me.txt_startingRate.Size = New System.Drawing.Size(86, 26)
        Me.txt_startingRate.TabIndex = 20
        '
        'txt_jobPosition
        '
        Me.txt_jobPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jobPosition.Location = New System.Drawing.Point(181, 134)
        Me.txt_jobPosition.Name = "txt_jobPosition"
        Me.txt_jobPosition.Size = New System.Drawing.Size(197, 26)
        Me.txt_jobPosition.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 380)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_pagibigNo)
        Me.GroupBox4.Controls.Add(Me.txt_TINno)
        Me.GroupBox4.Controls.Add(Me.txt_PhilhealthNo)
        Me.GroupBox4.Controls.Add(Me.txt_SSSno)
        Me.GroupBox4.Controls.Add(Me.txt_bankNo)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(368, 218)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(362, 207)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Account Numbers & Contributions"
        '
        'txt_pagibigNo
        '
        Me.txt_pagibigNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pagibigNo.Location = New System.Drawing.Point(145, 173)
        Me.txt_pagibigNo.Name = "txt_pagibigNo"
        Me.txt_pagibigNo.Size = New System.Drawing.Size(199, 26)
        Me.txt_pagibigNo.TabIndex = 18
        '
        'txt_TINno
        '
        Me.txt_TINno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TINno.Location = New System.Drawing.Point(145, 134)
        Me.txt_TINno.Name = "txt_TINno"
        Me.txt_TINno.Size = New System.Drawing.Size(199, 26)
        Me.txt_TINno.TabIndex = 17
        '
        'txt_PhilhealthNo
        '
        Me.txt_PhilhealthNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PhilhealthNo.Location = New System.Drawing.Point(145, 93)
        Me.txt_PhilhealthNo.Name = "txt_PhilhealthNo"
        Me.txt_PhilhealthNo.Size = New System.Drawing.Size(199, 26)
        Me.txt_PhilhealthNo.TabIndex = 16
        '
        'txt_SSSno
        '
        Me.txt_SSSno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SSSno.Location = New System.Drawing.Point(145, 54)
        Me.txt_SSSno.Name = "txt_SSSno"
        Me.txt_SSSno.Size = New System.Drawing.Size(199, 26)
        Me.txt_SSSno.TabIndex = 15
        '
        'txt_bankNo
        '
        Me.txt_bankNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bankNo.Location = New System.Drawing.Point(145, 13)
        Me.txt_bankNo.Name = "txt_bankNo"
        Me.txt_bankNo.Size = New System.Drawing.Size(199, 26)
        Me.txt_bankNo.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 180)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Bank Acct. No. :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SSS No. :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Philhealth No. :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TIN No. :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PAG-IBIG No. :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 26)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Employee Record"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IM_HR_Payroll_System.My.Resources.Resources.employees
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'btn_Save
        '
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(1052, 431)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(70, 30)
        Me.btn_Save.TabIndex = 14
        Me.btn_Save.Text = "&Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(1128, 431)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_Cancel.TabIndex = 15
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'txt_pagIbigShare
        '
        Me.txt_pagIbigShare.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pagIbigShare.Location = New System.Drawing.Point(83, 122)
        Me.txt_pagIbigShare.Name = "txt_pagIbigShare"
        Me.txt_pagIbigShare.Size = New System.Drawing.Size(66, 24)
        Me.txt_pagIbigShare.TabIndex = 22
        '
        'txt_philhealthShare
        '
        Me.txt_philhealthShare.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_philhealthShare.Location = New System.Drawing.Point(83, 50)
        Me.txt_philhealthShare.Name = "txt_philhealthShare"
        Me.txt_philhealthShare.Size = New System.Drawing.Size(66, 24)
        Me.txt_philhealthShare.TabIndex = 21
        '
        'txt_SSSshare
        '
        Me.txt_SSSshare.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SSSshare.Location = New System.Drawing.Point(83, 16)
        Me.txt_SSSshare.Name = "txt_SSSshare"
        Me.txt_SSSshare.Size = New System.Drawing.Size(66, 24)
        Me.txt_SSSshare.TabIndex = 20
        '
        'txt_taxAmount
        '
        Me.txt_taxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_taxAmount.Location = New System.Drawing.Point(83, 87)
        Me.txt_taxAmount.Name = "txt_taxAmount"
        Me.txt_taxAmount.Size = New System.Drawing.Size(66, 24)
        Me.txt_taxAmount.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 126)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "SSS :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Philhealth :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tax :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PAG-IBIG :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.txt_taxAmount)
        Me.GroupBox5.Controls.Add(Me.txt_SSSshare)
        Me.GroupBox5.Controls.Add(Me.txt_philhealthShare)
        Me.GroupBox5.Controls.Add(Me.txt_pagIbigShare)
        Me.GroupBox5.Location = New System.Drawing.Point(290, 249)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(160, 153)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Contributions / Deductions"
        '
        'FormEMPLOYEES_DETAILS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 471)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormEMPLOYEES_DETAILS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Record"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents dt_birthDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_civilStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_gender As System.Windows.Forms.ComboBox
    Friend WithEvents txt_contactNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents txt_middleName As System.Windows.Forms.TextBox
    Friend WithEvents txt_firstName As System.Windows.Forms.TextBox
    Friend WithEvents txt_lastName As System.Windows.Forms.TextBox
    Friend WithEvents txt_IDno As System.Windows.Forms.TextBox
    Friend WithEvents txt_emergencyContactNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_emergencyAddress As System.Windows.Forms.TextBox
    Friend WithEvents txt_emergencyRelationship As System.Windows.Forms.TextBox
    Friend WithEvents txt_emergencyContactPerson As System.Windows.Forms.TextBox
    Friend WithEvents dt_regularizationDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_hiredDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_division As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_department As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_employmentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txt_workDaysNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_monthlySalary As System.Windows.Forms.TextBox
    Friend WithEvents txt_currentRate As System.Windows.Forms.TextBox
    Friend WithEvents txt_startingRate As System.Windows.Forms.TextBox
    Friend WithEvents txt_jobPosition As System.Windows.Forms.TextBox
    Friend WithEvents txt_pagibigNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_TINno As System.Windows.Forms.TextBox
    Friend WithEvents txt_PhilhealthNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_SSSno As System.Windows.Forms.TextBox
    Friend WithEvents txt_bankNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_pagIbigShare As System.Windows.Forms.TextBox
    Friend WithEvents txt_philhealthShare As System.Windows.Forms.TextBox
    Friend WithEvents txt_SSSshare As System.Windows.Forms.TextBox
    Friend WithEvents txt_taxAmount As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
