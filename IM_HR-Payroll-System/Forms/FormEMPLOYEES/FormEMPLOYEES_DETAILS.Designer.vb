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
        Me.components = New System.ComponentModel.Container()
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
        Me.dt_hiredDate = New System.Windows.Forms.DateTimePicker()
        Me.txt_regularizationDate = New System.Windows.Forms.TextBox()
        Me.cmb_division = New System.Windows.Forms.ComboBox()
        Me.cmb_department = New System.Windows.Forms.ComboBox()
        Me.txt_workDaysNo = New System.Windows.Forms.TextBox()
        Me.txt_monthlySalary = New System.Windows.Forms.TextBox()
        Me.txt_currentRate = New System.Windows.Forms.TextBox()
        Me.txt_startingRate = New System.Windows.Forms.TextBox()
        Me.txt_jobPosition = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_taxAmount = New System.Windows.Forms.TextBox()
        Me.txt_SSSshare = New System.Windows.Forms.TextBox()
        Me.txt_philhealthShare = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_pagIbigShare = New System.Windows.Forms.TextBox()
        Me.cmb_employmentStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_pagibigNo = New System.Windows.Forms.TextBox()
        Me.txt_TINno = New System.Windows.Forms.TextBox()
        Me.txt_PhilhealthNo = New System.Windows.Forms.TextBox()
        Me.txt_SSSno = New System.Windows.Forms.TextBox()
        Me.txt_bankNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.employee_Picture = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_download = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_newFile = New System.Windows.Forms.Button()
        Me.lst_empFiles = New System.Windows.Forms.ListView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dt_endEmpDate = New System.Windows.Forms.DateTimePicker()
        Me.txt_endEmpDate = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.employee_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
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
        Me.GroupBox2.Location = New System.Drawing.Point(371, 6)
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
        Me.txt_emergencyContactPerson.Size = New System.Drawing.Size(194, 26)
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
        Me.GroupBox3.Controls.Add(Me.dt_hiredDate)
        Me.GroupBox3.Controls.Add(Me.txt_regularizationDate)
        Me.GroupBox3.Controls.Add(Me.cmb_division)
        Me.GroupBox3.Controls.Add(Me.cmb_department)
        Me.GroupBox3.Controls.Add(Me.txt_workDaysNo)
        Me.GroupBox3.Controls.Add(Me.txt_monthlySalary)
        Me.GroupBox3.Controls.Add(Me.txt_currentRate)
        Me.GroupBox3.Controls.Add(Me.txt_startingRate)
        Me.GroupBox3.Controls.Add(Me.txt_jobPosition)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(359, 375)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Employment Record"
        '
        'dt_hiredDate
        '
        Me.dt_hiredDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_hiredDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_hiredDate.Location = New System.Drawing.Point(163, 13)
        Me.dt_hiredDate.Name = "dt_hiredDate"
        Me.dt_hiredDate.Size = New System.Drawing.Size(121, 26)
        Me.dt_hiredDate.TabIndex = 16
        '
        'txt_regularizationDate
        '
        Me.txt_regularizationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_regularizationDate.Location = New System.Drawing.Point(163, 54)
        Me.txt_regularizationDate.Name = "txt_regularizationDate"
        Me.txt_regularizationDate.ReadOnly = True
        Me.txt_regularizationDate.Size = New System.Drawing.Size(101, 26)
        Me.txt_regularizationDate.TabIndex = 17
        '
        'cmb_division
        '
        Me.cmb_division.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_division.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_division.FormattingEnabled = True
        Me.cmb_division.Location = New System.Drawing.Point(163, 172)
        Me.cmb_division.Name = "cmb_division"
        Me.cmb_division.Size = New System.Drawing.Size(190, 28)
        Me.cmb_division.TabIndex = 26
        '
        'cmb_department
        '
        Me.cmb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_department.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_department.FormattingEnabled = True
        Me.cmb_department.Location = New System.Drawing.Point(163, 133)
        Me.cmb_department.Name = "cmb_department"
        Me.cmb_department.Size = New System.Drawing.Size(190, 28)
        Me.cmb_department.TabIndex = 25
        '
        'txt_workDaysNo
        '
        Me.txt_workDaysNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_workDaysNo.Location = New System.Drawing.Point(163, 334)
        Me.txt_workDaysNo.Name = "txt_workDaysNo"
        Me.txt_workDaysNo.Size = New System.Drawing.Size(86, 26)
        Me.txt_workDaysNo.TabIndex = 23
        '
        'txt_monthlySalary
        '
        Me.txt_monthlySalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_monthlySalary.Location = New System.Drawing.Point(163, 294)
        Me.txt_monthlySalary.Name = "txt_monthlySalary"
        Me.txt_monthlySalary.ReadOnly = True
        Me.txt_monthlySalary.Size = New System.Drawing.Size(86, 26)
        Me.txt_monthlySalary.TabIndex = 22
        '
        'txt_currentRate
        '
        Me.txt_currentRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_currentRate.Location = New System.Drawing.Point(163, 254)
        Me.txt_currentRate.Name = "txt_currentRate"
        Me.txt_currentRate.Size = New System.Drawing.Size(86, 26)
        Me.txt_currentRate.TabIndex = 21
        '
        'txt_startingRate
        '
        Me.txt_startingRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_startingRate.Location = New System.Drawing.Point(163, 215)
        Me.txt_startingRate.Name = "txt_startingRate"
        Me.txt_startingRate.Size = New System.Drawing.Size(86, 26)
        Me.txt_startingRate.TabIndex = 20
        '
        'txt_jobPosition
        '
        Me.txt_jobPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jobPosition.Location = New System.Drawing.Point(163, 95)
        Me.txt_jobPosition.Name = "txt_jobPosition"
        Me.txt_jobPosition.Size = New System.Drawing.Size(190, 26)
        Me.txt_jobPosition.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 340)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Hired Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Regularization Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Job Position :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Department : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Divis" & _
    "ion :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Starting Daily Rate :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Current Daily Rate :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Monthly Salary :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wo" & _
    "rk Days / Month :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Employment Status :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txt_taxAmount)
        Me.GroupBox5.Controls.Add(Me.txt_SSSshare)
        Me.GroupBox5.Controls.Add(Me.txt_philhealthShare)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.txt_pagIbigShare)
        Me.GroupBox5.Location = New System.Drawing.Point(362, 294)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(376, 89)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Contributions / Deductions Amount"
        '
        'txt_taxAmount
        '
        Me.txt_taxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_taxAmount.Location = New System.Drawing.Point(284, 21)
        Me.txt_taxAmount.Name = "txt_taxAmount"
        Me.txt_taxAmount.Size = New System.Drawing.Size(86, 24)
        Me.txt_taxAmount.TabIndex = 23
        '
        'txt_SSSshare
        '
        Me.txt_SSSshare.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SSSshare.Location = New System.Drawing.Point(87, 22)
        Me.txt_SSSshare.Name = "txt_SSSshare"
        Me.txt_SSSshare.Size = New System.Drawing.Size(86, 24)
        Me.txt_SSSshare.TabIndex = 20
        '
        'txt_philhealthShare
        '
        Me.txt_philhealthShare.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_philhealthShare.Location = New System.Drawing.Point(87, 56)
        Me.txt_philhealthShare.Name = "txt_philhealthShare"
        Me.txt_philhealthShare.Size = New System.Drawing.Size(86, 24)
        Me.txt_philhealthShare.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(198, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 54)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Tax :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PAG-IBIG :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_pagIbigShare
        '
        Me.txt_pagIbigShare.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pagIbigShare.Location = New System.Drawing.Point(284, 56)
        Me.txt_pagIbigShare.Name = "txt_pagIbigShare"
        Me.txt_pagIbigShare.Size = New System.Drawing.Size(86, 24)
        Me.txt_pagIbigShare.TabIndex = 22
        '
        'cmb_employmentStatus
        '
        Me.cmb_employmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employmentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_employmentStatus.FormattingEnabled = True
        Me.cmb_employmentStatus.Items.AddRange(New Object() {"", "Owner", "Regular", "Probationary", "Probationary (Extended)", "Outsource", "Resigned", "Terminated"})
        Me.cmb_employmentStatus.Location = New System.Drawing.Point(208, 252)
        Me.cmb_employmentStatus.Name = "cmb_employmentStatus"
        Me.cmb_employmentStatus.Size = New System.Drawing.Size(121, 28)
        Me.cmb_employmentStatus.TabIndex = 18
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_pagibigNo)
        Me.GroupBox4.Controls.Add(Me.txt_TINno)
        Me.GroupBox4.Controls.Add(Me.txt_PhilhealthNo)
        Me.GroupBox4.Controls.Add(Me.txt_SSSno)
        Me.GroupBox4.Controls.Add(Me.txt_bankNo)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(371, 174)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(362, 207)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Bank and Govt. Mandatories Account Numbers"
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
        'btn_Save
        '
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(614, 464)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(70, 30)
        Me.btn_Save.TabIndex = 14
        Me.btn_Save.Text = "&Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(690, 464)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_Cancel.TabIndex = 15
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 45)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(752, 413)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.employee_Picture)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(744, 387)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Page 1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(367, 318)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 54)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "SSS :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Philhealth :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'employee_Picture
        '
        Me.employee_Picture.InitialImage = CType(resources.GetObject("employee_Picture.InitialImage"), System.Drawing.Image)
        Me.employee_Picture.Location = New System.Drawing.Point(436, 19)
        Me.employee_Picture.Name = "employee_Picture"
        Me.employee_Picture.Size = New System.Drawing.Size(232, 232)
        Me.employee_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.employee_Picture.TabIndex = 0
        Me.employee_Picture.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.cmb_employmentStatus)
        Me.GroupBox6.Location = New System.Drawing.Point(362, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(376, 290)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Identification"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(744, 387)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Page 2"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.btn_download)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.btn_Delete)
        Me.TabPage3.Controls.Add(Me.btn_newFile)
        Me.TabPage3.Controls.Add(Me.lst_empFiles)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(744, 387)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Page 3"
        '
        'btn_download
        '
        Me.btn_download.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_download.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_download.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_download.ImageKey = "download.png"
        Me.btn_download.ImageList = Me.ImageList1
        Me.btn_download.Location = New System.Drawing.Point(403, 6)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(99, 30)
        Me.btn_download.TabIndex = 18
        Me.btn_download.Text = "Download"
        Me.btn_download.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_download.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "plus.png")
        Me.ImageList1.Images.SetKeyName(1, "add.png")
        Me.ImageList1.Images.SetKeyName(2, "search.png")
        Me.ImageList1.Images.SetKeyName(3, "bin.png")
        Me.ImageList1.Images.SetKeyName(4, "edit.png")
        Me.ImageList1.Images.SetKeyName(5, "download.png")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(623, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "|"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Scanned Files "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Delete
        '
        Me.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Delete.ImageKey = "bin.png"
        Me.btn_Delete.ImageList = Me.ImageList1
        Me.btn_Delete.Location = New System.Drawing.Point(508, 6)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(110, 30)
        Me.btn_Delete.TabIndex = 15
        Me.btn_Delete.Text = "Delete File"
        Me.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'btn_newFile
        '
        Me.btn_newFile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_newFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_newFile.ImageKey = "plus.png"
        Me.btn_newFile.ImageList = Me.ImageList1
        Me.btn_newFile.Location = New System.Drawing.Point(639, 6)
        Me.btn_newFile.Name = "btn_newFile"
        Me.btn_newFile.Size = New System.Drawing.Size(99, 30)
        Me.btn_newFile.TabIndex = 13
        Me.btn_newFile.Text = "New File"
        Me.btn_newFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_newFile.UseVisualStyleBackColor = True
        '
        'lst_empFiles
        '
        Me.lst_empFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lst_empFiles.FullRowSelect = True
        Me.lst_empFiles.GridLines = True
        Me.lst_empFiles.Location = New System.Drawing.Point(5, 41)
        Me.lst_empFiles.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_empFiles.Name = "lst_empFiles"
        Me.lst_empFiles.Size = New System.Drawing.Size(734, 341)
        Me.lst_empFiles.TabIndex = 9
        Me.lst_empFiles.UseCompatibleStateImageBehavior = False
        Me.lst_empFiles.View = System.Windows.Forms.View.Details
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Harmony.My.Resources.Resources.employees
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 469)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(195, 20)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "End of Employment Date :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Visible = False
        '
        'dt_endEmpDate
        '
        Me.dt_endEmpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_endEmpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_endEmpDate.Location = New System.Drawing.Point(456, 465)
        Me.dt_endEmpDate.Name = "dt_endEmpDate"
        Me.dt_endEmpDate.Size = New System.Drawing.Size(121, 26)
        Me.dt_endEmpDate.TabIndex = 19
        Me.dt_endEmpDate.Visible = False
        '
        'txt_endEmpDate
        '
        Me.txt_endEmpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_endEmpDate.Location = New System.Drawing.Point(209, 467)
        Me.txt_endEmpDate.Name = "txt_endEmpDate"
        Me.txt_endEmpDate.ReadOnly = True
        Me.txt_endEmpDate.Size = New System.Drawing.Size(101, 26)
        Me.txt_endEmpDate.TabIndex = 30
        '
        'FormEMPLOYEES_DETAILS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 503)
        Me.Controls.Add(Me.txt_endEmpDate)
        Me.Controls.Add(Me.dt_endEmpDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEMPLOYEES_DETAILS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Record"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.employee_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents employee_Picture As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lst_empFiles As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btn_newFile As System.Windows.Forms.Button
    Friend WithEvents btn_Delete As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_download As System.Windows.Forms.Button
    Friend WithEvents txt_regularizationDate As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dt_endEmpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_endEmpDate As System.Windows.Forms.TextBox
End Class
