<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPAYROLL_PAYEE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPAYROLL_PAYEE))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_payNightDiff = New System.Windows.Forms.TextBox()
        Me.txt_numNightDiff = New System.Windows.Forms.TextBox()
        Me.txt_totalNightDiff = New System.Windows.Forms.TextBox()
        Me.txt_payOvertime = New System.Windows.Forms.TextBox()
        Me.txt_numOvertime = New System.Windows.Forms.TextBox()
        Me.txt_payHoliday = New System.Windows.Forms.TextBox()
        Me.txt_numHoliday = New System.Windows.Forms.TextBox()
        Me.txt_payField = New System.Windows.Forms.TextBox()
        Me.txt_numField = New System.Windows.Forms.TextBox()
        Me.txt_paySpecial = New System.Windows.Forms.TextBox()
        Me.txt_numSpecial = New System.Windows.Forms.TextBox()
        Me.txt_totalOvertime = New System.Windows.Forms.TextBox()
        Me.txt_totalHoliday = New System.Windows.Forms.TextBox()
        Me.txt_totalField = New System.Windows.Forms.TextBox()
        Me.txt_totalSpecial = New System.Windows.Forms.TextBox()
        Me.txt_totalRegular = New System.Windows.Forms.TextBox()
        Me.txt_payRegular = New System.Windows.Forms.TextBox()
        Me.txt_numRegular = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_payAddAllowance = New System.Windows.Forms.TextBox()
        Me.txt_payAddIncentive = New System.Windows.Forms.TextBox()
        Me.txt_payAddField = New System.Windows.Forms.TextBox()
        Me.txt_payAddSpecial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_totalUndertime = New System.Windows.Forms.TextBox()
        Me.txt_totalLate = New System.Windows.Forms.TextBox()
        Me.cb_pagibig = New System.Windows.Forms.CheckBox()
        Me.cb_philhealth = New System.Windows.Forms.CheckBox()
        Me.cb_insurance = New System.Windows.Forms.CheckBox()
        Me.cb_Tax = New System.Windows.Forms.CheckBox()
        Me.cb_SSS = New System.Windows.Forms.CheckBox()
        Me.txt_numUndertime = New System.Windows.Forms.TextBox()
        Me.txt_minusUndertime = New System.Windows.Forms.TextBox()
        Me.txt_SSS = New System.Windows.Forms.TextBox()
        Me.txt_tax = New System.Windows.Forms.TextBox()
        Me.txt_charge = New System.Windows.Forms.TextBox()
        Me.txt_insurance = New System.Windows.Forms.TextBox()
        Me.txt_philhealth = New System.Windows.Forms.TextBox()
        Me.txt_pagibig = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_numLate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_minusLate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.txt_deductions = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_gross = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 100)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Payroll Payee ID :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Employee ID :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_payNightDiff)
        Me.GroupBox1.Controls.Add(Me.txt_numNightDiff)
        Me.GroupBox1.Controls.Add(Me.txt_totalNightDiff)
        Me.GroupBox1.Controls.Add(Me.txt_payOvertime)
        Me.GroupBox1.Controls.Add(Me.txt_numOvertime)
        Me.GroupBox1.Controls.Add(Me.txt_payHoliday)
        Me.GroupBox1.Controls.Add(Me.txt_numHoliday)
        Me.GroupBox1.Controls.Add(Me.txt_payField)
        Me.GroupBox1.Controls.Add(Me.txt_numField)
        Me.GroupBox1.Controls.Add(Me.txt_paySpecial)
        Me.GroupBox1.Controls.Add(Me.txt_numSpecial)
        Me.GroupBox1.Controls.Add(Me.txt_totalOvertime)
        Me.GroupBox1.Controls.Add(Me.txt_totalHoliday)
        Me.GroupBox1.Controls.Add(Me.txt_totalField)
        Me.GroupBox1.Controls.Add(Me.txt_totalSpecial)
        Me.GroupBox1.Controls.Add(Me.txt_totalRegular)
        Me.GroupBox1.Controls.Add(Me.txt_payRegular)
        Me.GroupBox1.Controls.Add(Me.txt_numRegular)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 258)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Pay"
        '
        'txt_payNightDiff
        '
        Me.txt_payNightDiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_payNightDiff.Location = New System.Drawing.Point(125, 214)
        Me.txt_payNightDiff.Name = "txt_payNightDiff"
        Me.txt_payNightDiff.Size = New System.Drawing.Size(56, 26)
        Me.txt_payNightDiff.TabIndex = 11
        Me.txt_payNightDiff.Tag = "BasicPay"
        Me.txt_payNightDiff.Text = "0"
        Me.txt_payNightDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_numNightDiff
        '
        Me.txt_numNightDiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numNightDiff.Location = New System.Drawing.Point(207, 214)
        Me.txt_numNightDiff.Name = "txt_numNightDiff"
        Me.txt_numNightDiff.Size = New System.Drawing.Size(47, 26)
        Me.txt_numNightDiff.TabIndex = 12
        Me.txt_numNightDiff.Tag = "BasicPay"
        Me.txt_numNightDiff.Text = "0"
        Me.txt_numNightDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_totalNightDiff
        '
        Me.txt_totalNightDiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalNightDiff.Location = New System.Drawing.Point(373, 214)
        Me.txt_totalNightDiff.Name = "txt_totalNightDiff"
        Me.txt_totalNightDiff.ReadOnly = True
        Me.txt_totalNightDiff.Size = New System.Drawing.Size(56, 26)
        Me.txt_totalNightDiff.TabIndex = 37
        Me.txt_totalNightDiff.Text = "0"
        Me.txt_totalNightDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_payOvertime
        '
        Me.txt_payOvertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_payOvertime.Location = New System.Drawing.Point(125, 174)
        Me.txt_payOvertime.Name = "txt_payOvertime"
        Me.txt_payOvertime.Size = New System.Drawing.Size(56, 26)
        Me.txt_payOvertime.TabIndex = 9
        Me.txt_payOvertime.Tag = "BasicPay"
        Me.txt_payOvertime.Text = "0"
        Me.txt_payOvertime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_numOvertime
        '
        Me.txt_numOvertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numOvertime.Location = New System.Drawing.Point(207, 174)
        Me.txt_numOvertime.Name = "txt_numOvertime"
        Me.txt_numOvertime.Size = New System.Drawing.Size(47, 26)
        Me.txt_numOvertime.TabIndex = 10
        Me.txt_numOvertime.Tag = "BasicPay"
        Me.txt_numOvertime.Text = "0"
        Me.txt_numOvertime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_payHoliday
        '
        Me.txt_payHoliday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_payHoliday.Location = New System.Drawing.Point(125, 134)
        Me.txt_payHoliday.Name = "txt_payHoliday"
        Me.txt_payHoliday.Size = New System.Drawing.Size(56, 26)
        Me.txt_payHoliday.TabIndex = 7
        Me.txt_payHoliday.Tag = "BasicPay"
        Me.txt_payHoliday.Text = "0"
        Me.txt_payHoliday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_numHoliday
        '
        Me.txt_numHoliday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numHoliday.Location = New System.Drawing.Point(207, 134)
        Me.txt_numHoliday.Name = "txt_numHoliday"
        Me.txt_numHoliday.Size = New System.Drawing.Size(47, 26)
        Me.txt_numHoliday.TabIndex = 8
        Me.txt_numHoliday.Tag = "BasicPay"
        Me.txt_numHoliday.Text = "0"
        Me.txt_numHoliday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_payField
        '
        Me.txt_payField.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_payField.Location = New System.Drawing.Point(125, 92)
        Me.txt_payField.Name = "txt_payField"
        Me.txt_payField.Size = New System.Drawing.Size(56, 26)
        Me.txt_payField.TabIndex = 5
        Me.txt_payField.Tag = "BasicPay"
        Me.txt_payField.Text = "0"
        Me.txt_payField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_numField
        '
        Me.txt_numField.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numField.Location = New System.Drawing.Point(207, 92)
        Me.txt_numField.Name = "txt_numField"
        Me.txt_numField.Size = New System.Drawing.Size(47, 26)
        Me.txt_numField.TabIndex = 6
        Me.txt_numField.Tag = "BasicPay"
        Me.txt_numField.Text = "0"
        Me.txt_numField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_paySpecial
        '
        Me.txt_paySpecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_paySpecial.Location = New System.Drawing.Point(125, 55)
        Me.txt_paySpecial.Name = "txt_paySpecial"
        Me.txt_paySpecial.Size = New System.Drawing.Size(56, 26)
        Me.txt_paySpecial.TabIndex = 3
        Me.txt_paySpecial.Tag = "BasicPay"
        Me.txt_paySpecial.Text = "0"
        Me.txt_paySpecial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_numSpecial
        '
        Me.txt_numSpecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numSpecial.Location = New System.Drawing.Point(207, 55)
        Me.txt_numSpecial.Name = "txt_numSpecial"
        Me.txt_numSpecial.Size = New System.Drawing.Size(47, 26)
        Me.txt_numSpecial.TabIndex = 4
        Me.txt_numSpecial.Tag = "BasicPay"
        Me.txt_numSpecial.Text = "0"
        Me.txt_numSpecial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_totalOvertime
        '
        Me.txt_totalOvertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalOvertime.Location = New System.Drawing.Point(373, 174)
        Me.txt_totalOvertime.Name = "txt_totalOvertime"
        Me.txt_totalOvertime.ReadOnly = True
        Me.txt_totalOvertime.Size = New System.Drawing.Size(56, 26)
        Me.txt_totalOvertime.TabIndex = 28
        Me.txt_totalOvertime.Text = "0"
        Me.txt_totalOvertime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_totalHoliday
        '
        Me.txt_totalHoliday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalHoliday.Location = New System.Drawing.Point(373, 134)
        Me.txt_totalHoliday.Name = "txt_totalHoliday"
        Me.txt_totalHoliday.ReadOnly = True
        Me.txt_totalHoliday.Size = New System.Drawing.Size(56, 26)
        Me.txt_totalHoliday.TabIndex = 27
        Me.txt_totalHoliday.Text = "0"
        Me.txt_totalHoliday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_totalField
        '
        Me.txt_totalField.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalField.Location = New System.Drawing.Point(373, 92)
        Me.txt_totalField.Name = "txt_totalField"
        Me.txt_totalField.ReadOnly = True
        Me.txt_totalField.Size = New System.Drawing.Size(56, 26)
        Me.txt_totalField.TabIndex = 26
        Me.txt_totalField.Text = "0"
        Me.txt_totalField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_totalSpecial
        '
        Me.txt_totalSpecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalSpecial.Location = New System.Drawing.Point(373, 55)
        Me.txt_totalSpecial.Name = "txt_totalSpecial"
        Me.txt_totalSpecial.ReadOnly = True
        Me.txt_totalSpecial.Size = New System.Drawing.Size(56, 26)
        Me.txt_totalSpecial.TabIndex = 25
        Me.txt_totalSpecial.Text = "0"
        Me.txt_totalSpecial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_totalRegular
        '
        Me.txt_totalRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalRegular.Location = New System.Drawing.Point(373, 13)
        Me.txt_totalRegular.Name = "txt_totalRegular"
        Me.txt_totalRegular.ReadOnly = True
        Me.txt_totalRegular.Size = New System.Drawing.Size(56, 26)
        Me.txt_totalRegular.TabIndex = 24
        Me.txt_totalRegular.Text = "0"
        Me.txt_totalRegular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_payRegular
        '
        Me.txt_payRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_payRegular.Location = New System.Drawing.Point(125, 13)
        Me.txt_payRegular.Name = "txt_payRegular"
        Me.txt_payRegular.Size = New System.Drawing.Size(56, 26)
        Me.txt_payRegular.TabIndex = 1
        Me.txt_payRegular.Tag = "BasicPay"
        Me.txt_payRegular.Text = "0"
        Me.txt_payRegular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_numRegular
        '
        Me.txt_numRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numRegular.Location = New System.Drawing.Point(207, 13)
        Me.txt_numRegular.Name = "txt_numRegular"
        Me.txt_numRegular.Size = New System.Drawing.Size(47, 26)
        Me.txt_numRegular.TabIndex = 2
        Me.txt_numRegular.Tag = "BasicPay"
        Me.txt_numRegular.Text = "0"
        Me.txt_numRegular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(188, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 220)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 220)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Regular Days :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Special Days :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Field Days : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Holiday Days :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Overtime :" & _
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Night Diff. :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_payAddAllowance)
        Me.GroupBox2.Controls.Add(Me.txt_payAddIncentive)
        Me.GroupBox2.Controls.Add(Me.txt_payAddField)
        Me.GroupBox2.Controls.Add(Me.txt_payAddSpecial)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(808, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 171)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional Pay"
        '
        'txt_payAddAllowance
        '
        Me.txt_payAddAllowance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_payAddAllowance.Location = New System.Drawing.Point(118, 134)
        Me.txt_payAddAllowance.Name = "txt_payAddAllowance"
        Me.txt_payAddAllowance.Size = New System.Drawing.Size(56, 26)
        Me.txt_payAddAllowance.TabIndex = 32
        Me.txt_payAddAllowance.Tag = "BasicPay"
        Me.txt_payAddAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_payAddIncentive
        '
        Me.txt_payAddIncentive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_payAddIncentive.Location = New System.Drawing.Point(118, 94)
        Me.txt_payAddIncentive.Name = "txt_payAddIncentive"
        Me.txt_payAddIncentive.Size = New System.Drawing.Size(56, 26)
        Me.txt_payAddIncentive.TabIndex = 31
        Me.txt_payAddIncentive.Tag = "BasicPay"
        Me.txt_payAddIncentive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_payAddField
        '
        Me.txt_payAddField.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_payAddField.Location = New System.Drawing.Point(118, 53)
        Me.txt_payAddField.Name = "txt_payAddField"
        Me.txt_payAddField.Size = New System.Drawing.Size(56, 26)
        Me.txt_payAddField.TabIndex = 30
        Me.txt_payAddField.Tag = "BasicPay"
        Me.txt_payAddField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_payAddSpecial
        '
        Me.txt_payAddSpecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_payAddSpecial.Location = New System.Drawing.Point(118, 13)
        Me.txt_payAddSpecial.Name = "txt_payAddSpecial"
        Me.txt_payAddSpecial.Size = New System.Drawing.Size(56, 26)
        Me.txt_payAddSpecial.TabIndex = 29
        Me.txt_payAddSpecial.Tag = "BasicPay"
        Me.txt_payAddSpecial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 140)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Special :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Field :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Incentive :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Allowance :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_totalUndertime)
        Me.GroupBox3.Controls.Add(Me.txt_totalLate)
        Me.GroupBox3.Controls.Add(Me.cb_pagibig)
        Me.GroupBox3.Controls.Add(Me.cb_philhealth)
        Me.GroupBox3.Controls.Add(Me.cb_insurance)
        Me.GroupBox3.Controls.Add(Me.cb_Tax)
        Me.GroupBox3.Controls.Add(Me.cb_SSS)
        Me.GroupBox3.Controls.Add(Me.txt_numUndertime)
        Me.GroupBox3.Controls.Add(Me.txt_minusUndertime)
        Me.GroupBox3.Controls.Add(Me.txt_SSS)
        Me.GroupBox3.Controls.Add(Me.txt_tax)
        Me.GroupBox3.Controls.Add(Me.txt_charge)
        Me.GroupBox3.Controls.Add(Me.txt_insurance)
        Me.GroupBox3.Controls.Add(Me.txt_philhealth)
        Me.GroupBox3.Controls.Add(Me.txt_pagibig)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txt_numLate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_minusLate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 396)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(459, 219)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Deductions / Contributions"
        '
        'txt_totalUndertime
        '
        Me.txt_totalUndertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalUndertime.Location = New System.Drawing.Point(373, 175)
        Me.txt_totalUndertime.Name = "txt_totalUndertime"
        Me.txt_totalUndertime.ReadOnly = True
        Me.txt_totalUndertime.Size = New System.Drawing.Size(56, 26)
        Me.txt_totalUndertime.TabIndex = 44
        Me.txt_totalUndertime.Tag = "Deductions"
        Me.txt_totalUndertime.Text = "0"
        Me.txt_totalUndertime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_totalLate
        '
        Me.txt_totalLate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalLate.Location = New System.Drawing.Point(373, 133)
        Me.txt_totalLate.Name = "txt_totalLate"
        Me.txt_totalLate.ReadOnly = True
        Me.txt_totalLate.Size = New System.Drawing.Size(56, 26)
        Me.txt_totalLate.TabIndex = 43
        Me.txt_totalLate.Tag = "Deductions"
        Me.txt_totalLate.Text = "0"
        Me.txt_totalLate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cb_pagibig
        '
        Me.cb_pagibig.AutoSize = True
        Me.cb_pagibig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_pagibig.Location = New System.Drawing.Point(5, 94)
        Me.cb_pagibig.Name = "cb_pagibig"
        Me.cb_pagibig.Size = New System.Drawing.Size(117, 24)
        Me.cb_pagibig.TabIndex = 42
        Me.cb_pagibig.Text = "PAG - IBIG :"
        Me.cb_pagibig.UseVisualStyleBackColor = True
        '
        'cb_philhealth
        '
        Me.cb_philhealth.AutoSize = True
        Me.cb_philhealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_philhealth.Location = New System.Drawing.Point(15, 53)
        Me.cb_philhealth.Name = "cb_philhealth"
        Me.cb_philhealth.Size = New System.Drawing.Size(105, 24)
        Me.cb_philhealth.TabIndex = 41
        Me.cb_philhealth.Text = "Philhealth :"
        Me.cb_philhealth.UseVisualStyleBackColor = True
        '
        'cb_insurance
        '
        Me.cb_insurance.AutoSize = True
        Me.cb_insurance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_insurance.Location = New System.Drawing.Point(15, 17)
        Me.cb_insurance.Name = "cb_insurance"
        Me.cb_insurance.Size = New System.Drawing.Size(107, 24)
        Me.cb_insurance.TabIndex = 40
        Me.cb_insurance.Text = "Insurance :"
        Me.cb_insurance.UseVisualStyleBackColor = True
        '
        'cb_Tax
        '
        Me.cb_Tax.AutoSize = True
        Me.cb_Tax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Tax.Location = New System.Drawing.Point(287, 48)
        Me.cb_Tax.Name = "cb_Tax"
        Me.cb_Tax.Size = New System.Drawing.Size(61, 24)
        Me.cb_Tax.TabIndex = 39
        Me.cb_Tax.Text = "Tax :"
        Me.cb_Tax.UseVisualStyleBackColor = True
        '
        'cb_SSS
        '
        Me.cb_SSS.AutoSize = True
        Me.cb_SSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_SSS.Location = New System.Drawing.Point(279, 10)
        Me.cb_SSS.Name = "cb_SSS"
        Me.cb_SSS.Size = New System.Drawing.Size(69, 24)
        Me.cb_SSS.TabIndex = 33
        Me.cb_SSS.Text = "SSS :"
        Me.cb_SSS.UseVisualStyleBackColor = True
        '
        'txt_numUndertime
        '
        Me.txt_numUndertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numUndertime.Location = New System.Drawing.Point(206, 175)
        Me.txt_numUndertime.Name = "txt_numUndertime"
        Me.txt_numUndertime.Size = New System.Drawing.Size(47, 26)
        Me.txt_numUndertime.TabIndex = 17
        Me.txt_numUndertime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_minusUndertime
        '
        Me.txt_minusUndertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_minusUndertime.Location = New System.Drawing.Point(123, 175)
        Me.txt_minusUndertime.Name = "txt_minusUndertime"
        Me.txt_minusUndertime.Size = New System.Drawing.Size(56, 26)
        Me.txt_minusUndertime.TabIndex = 16
        Me.txt_minusUndertime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_SSS
        '
        Me.txt_SSS.BackColor = System.Drawing.Color.Gray
        Me.txt_SSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SSS.ForeColor = System.Drawing.Color.Black
        Me.txt_SSS.Location = New System.Drawing.Point(350, 10)
        Me.txt_SSS.Name = "txt_SSS"
        Me.txt_SSS.ReadOnly = True
        Me.txt_SSS.Size = New System.Drawing.Size(56, 26)
        Me.txt_SSS.TabIndex = 36
        Me.txt_SSS.Text = "100"
        Me.txt_SSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_tax
        '
        Me.txt_tax.BackColor = System.Drawing.Color.Gray
        Me.txt_tax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tax.Location = New System.Drawing.Point(350, 48)
        Me.txt_tax.Name = "txt_tax"
        Me.txt_tax.ReadOnly = True
        Me.txt_tax.Size = New System.Drawing.Size(56, 26)
        Me.txt_tax.TabIndex = 35
        Me.txt_tax.Text = "100"
        Me.txt_tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_charge
        '
        Me.txt_charge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_charge.Location = New System.Drawing.Point(350, 89)
        Me.txt_charge.Name = "txt_charge"
        Me.txt_charge.Size = New System.Drawing.Size(56, 26)
        Me.txt_charge.TabIndex = 13
        Me.txt_charge.Tag = "Deductions"
        Me.txt_charge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_insurance
        '
        Me.txt_insurance.BackColor = System.Drawing.Color.Gray
        Me.txt_insurance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_insurance.Location = New System.Drawing.Point(123, 15)
        Me.txt_insurance.Name = "txt_insurance"
        Me.txt_insurance.ReadOnly = True
        Me.txt_insurance.Size = New System.Drawing.Size(56, 26)
        Me.txt_insurance.TabIndex = 33
        Me.txt_insurance.Text = "100"
        Me.txt_insurance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_philhealth
        '
        Me.txt_philhealth.BackColor = System.Drawing.Color.Gray
        Me.txt_philhealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_philhealth.Location = New System.Drawing.Point(123, 53)
        Me.txt_philhealth.Name = "txt_philhealth"
        Me.txt_philhealth.ReadOnly = True
        Me.txt_philhealth.Size = New System.Drawing.Size(56, 26)
        Me.txt_philhealth.TabIndex = 32
        Me.txt_philhealth.Text = "100"
        Me.txt_philhealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_pagibig
        '
        Me.txt_pagibig.BackColor = System.Drawing.Color.Gray
        Me.txt_pagibig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pagibig.Location = New System.Drawing.Point(123, 94)
        Me.txt_pagibig.Name = "txt_pagibig"
        Me.txt_pagibig.ReadOnly = True
        Me.txt_pagibig.Size = New System.Drawing.Size(56, 26)
        Me.txt_pagibig.TabIndex = 31
        Me.txt_pagibig.Text = "100"
        Me.txt_pagibig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(275, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 100)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "SSS :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tax :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Charge :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_numLate
        '
        Me.txt_numLate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numLate.Location = New System.Drawing.Point(206, 133)
        Me.txt_numLate.Name = "txt_numLate"
        Me.txt_numLate.Size = New System.Drawing.Size(47, 26)
        Me.txt_numLate.TabIndex = 15
        Me.txt_numLate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(186, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 60)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "x               min(s)     Total :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "x               min(s)     Total :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_minusLate
        '
        Me.txt_minusLate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_minusLate.Location = New System.Drawing.Point(123, 133)
        Me.txt_minusLate.Name = "txt_minusLate"
        Me.txt_minusLate.Size = New System.Drawing.Size(56, 26)
        Me.txt_minusLate.TabIndex = 14
        Me.txt_minusLate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(196, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 180)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Insurance :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Philhealth :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PAG - IBIG :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Late :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Undertime :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox28)
        Me.GroupBox4.Controls.Add(Me.txt_deductions)
        Me.GroupBox4.Controls.Add(Me.TextBox13)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txt_gross)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(808, 307)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(184, 216)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total"
        '
        'TextBox28
        '
        Me.TextBox28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox28.Location = New System.Drawing.Point(110, 103)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(68, 26)
        Me.TextBox28.TabIndex = 34
        Me.TextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_deductions
        '
        Me.txt_deductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_deductions.Location = New System.Drawing.Point(110, 62)
        Me.txt_deductions.Name = "txt_deductions"
        Me.txt_deductions.Size = New System.Drawing.Size(68, 26)
        Me.txt_deductions.TabIndex = 33
        Me.txt_deductions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox13
        '
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(10, 171)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(168, 32)
        Me.TextBox13.TabIndex = 32
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(46, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 20)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Net  Total :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 20)
        Me.Label10.TabIndex = 30
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_gross
        '
        Me.txt_gross.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_gross.Location = New System.Drawing.Point(110, 22)
        Me.txt_gross.Name = "txt_gross"
        Me.txt_gross.Size = New System.Drawing.Size(68, 26)
        Me.txt_gross.TabIndex = 29
        Me.txt_gross.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 100)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Gross :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deductions :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loans :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ListView1)
        Me.GroupBox5.Location = New System.Drawing.Point(478, 130)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(324, 272)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Loans"
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(5, 18)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(314, 247)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ListView2)
        Me.GroupBox6.Location = New System.Drawing.Point(477, 408)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(324, 207)
        Me.GroupBox6.TabIndex = 32
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Loan Payment"
        '
        'ListView2
        '
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(5, 48)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(314, 154)
        Me.ListView2.TabIndex = 17
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'FormPAYROLL_PAYEE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 632)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormPAYROLL_PAYEE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Payee Record"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_totalRegular As System.Windows.Forms.TextBox
    Friend WithEvents txt_payRegular As System.Windows.Forms.TextBox
    Friend WithEvents txt_numRegular As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_totalOvertime As System.Windows.Forms.TextBox
    Friend WithEvents txt_totalHoliday As System.Windows.Forms.TextBox
    Friend WithEvents txt_totalField As System.Windows.Forms.TextBox
    Friend WithEvents txt_totalSpecial As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_payAddSpecial As System.Windows.Forms.TextBox
    Friend WithEvents txt_pagibig As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_numLate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_minusLate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_gross As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_payOvertime As System.Windows.Forms.TextBox
    Friend WithEvents txt_numOvertime As System.Windows.Forms.TextBox
    Friend WithEvents txt_payHoliday As System.Windows.Forms.TextBox
    Friend WithEvents txt_numHoliday As System.Windows.Forms.TextBox
    Friend WithEvents txt_payField As System.Windows.Forms.TextBox
    Friend WithEvents txt_numField As System.Windows.Forms.TextBox
    Friend WithEvents txt_paySpecial As System.Windows.Forms.TextBox
    Friend WithEvents txt_numSpecial As System.Windows.Forms.TextBox
    Friend WithEvents txt_payAddAllowance As System.Windows.Forms.TextBox
    Friend WithEvents txt_payAddIncentive As System.Windows.Forms.TextBox
    Friend WithEvents txt_payAddField As System.Windows.Forms.TextBox
    Friend WithEvents txt_SSS As System.Windows.Forms.TextBox
    Friend WithEvents txt_tax As System.Windows.Forms.TextBox
    Friend WithEvents txt_charge As System.Windows.Forms.TextBox
    Friend WithEvents txt_insurance As System.Windows.Forms.TextBox
    Friend WithEvents txt_philhealth As System.Windows.Forms.TextBox
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents txt_deductions As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents txt_payNightDiff As System.Windows.Forms.TextBox
    Friend WithEvents txt_numNightDiff As System.Windows.Forms.TextBox
    Friend WithEvents txt_totalNightDiff As System.Windows.Forms.TextBox
    Friend WithEvents txt_numUndertime As System.Windows.Forms.TextBox
    Friend WithEvents txt_minusUndertime As System.Windows.Forms.TextBox
    Friend WithEvents cb_SSS As System.Windows.Forms.CheckBox
    Friend WithEvents cb_pagibig As System.Windows.Forms.CheckBox
    Friend WithEvents cb_philhealth As System.Windows.Forms.CheckBox
    Friend WithEvents cb_insurance As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Tax As System.Windows.Forms.CheckBox
    Friend WithEvents txt_totalUndertime As System.Windows.Forms.TextBox
    Friend WithEvents txt_totalLate As System.Windows.Forms.TextBox
End Class
