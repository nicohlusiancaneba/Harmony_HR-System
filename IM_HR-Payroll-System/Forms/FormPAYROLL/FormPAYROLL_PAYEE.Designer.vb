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
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.TextBox36 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
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
        Me.txt_payNightDiff.TabIndex = 39
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
        Me.txt_numNightDiff.TabIndex = 38
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
        Me.txt_payOvertime.TabIndex = 36
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
        Me.txt_numOvertime.TabIndex = 35
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
        Me.txt_payHoliday.TabIndex = 34
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
        Me.txt_numHoliday.TabIndex = 33
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
        Me.txt_payField.TabIndex = 32
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
        Me.txt_numField.TabIndex = 31
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
        Me.txt_paySpecial.TabIndex = 30
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
        Me.txt_numSpecial.TabIndex = 29
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
        Me.txt_payRegular.TabIndex = 23
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
        Me.txt_numRegular.TabIndex = 22
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
        Me.GroupBox2.Controls.Add(Me.TextBox31)
        Me.GroupBox2.Controls.Add(Me.TextBox30)
        Me.GroupBox2.Controls.Add(Me.TextBox29)
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(808, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 171)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional Pay"
        '
        'TextBox31
        '
        Me.TextBox31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox31.Location = New System.Drawing.Point(118, 134)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(56, 26)
        Me.TextBox31.TabIndex = 32
        Me.TextBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox30
        '
        Me.TextBox30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox30.Location = New System.Drawing.Point(118, 94)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(56, 26)
        Me.TextBox30.TabIndex = 31
        Me.TextBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox29
        '
        Me.TextBox29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox29.Location = New System.Drawing.Point(118, 53)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(56, 26)
        Me.TextBox29.TabIndex = 30
        Me.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(118, 13)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(56, 26)
        Me.TextBox11.TabIndex = 29
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GroupBox3.Controls.Add(Me.TextBox35)
        Me.GroupBox3.Controls.Add(Me.TextBox36)
        Me.GroupBox3.Controls.Add(Me.TextBox24)
        Me.GroupBox3.Controls.Add(Me.TextBox25)
        Me.GroupBox3.Controls.Add(Me.TextBox26)
        Me.GroupBox3.Controls.Add(Me.TextBox23)
        Me.GroupBox3.Controls.Add(Me.TextBox22)
        Me.GroupBox3.Controls.Add(Me.TextBox10)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TextBox9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 396)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(459, 219)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Deductions / Contributions"
        '
        'TextBox35
        '
        Me.TextBox35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox35.Location = New System.Drawing.Point(193, 175)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(47, 26)
        Me.TextBox35.TabIndex = 38
        Me.TextBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox36
        '
        Me.TextBox36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox36.Location = New System.Drawing.Point(110, 175)
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(56, 26)
        Me.TextBox36.TabIndex = 37
        Me.TextBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox24
        '
        Me.TextBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox24.Location = New System.Drawing.Point(337, 10)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(56, 26)
        Me.TextBox24.TabIndex = 36
        Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox25
        '
        Me.TextBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox25.Location = New System.Drawing.Point(337, 48)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(56, 26)
        Me.TextBox25.TabIndex = 35
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox26
        '
        Me.TextBox26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox26.Location = New System.Drawing.Point(337, 89)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(56, 26)
        Me.TextBox26.TabIndex = 34
        Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox23
        '
        Me.TextBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.Location = New System.Drawing.Point(110, 15)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(56, 26)
        Me.TextBox23.TabIndex = 33
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox22
        '
        Me.TextBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox22.Location = New System.Drawing.Point(110, 53)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(56, 26)
        Me.TextBox22.TabIndex = 32
        Me.TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(110, 94)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(56, 26)
        Me.TextBox10.TabIndex = 31
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(262, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 100)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "SSS :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tax :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Charge :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(193, 133)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(47, 26)
        Me.TextBox9.TabIndex = 29
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(173, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 60)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "x               min(s)     Total :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "x               min(s)     Total :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(110, 133)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(56, 26)
        Me.TextBox8.TabIndex = 26
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(183, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 180)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Insurance :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Philhealth :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PAG - IBIG :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Late :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Undertime :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox28)
        Me.GroupBox4.Controls.Add(Me.TextBox27)
        Me.GroupBox4.Controls.Add(Me.TextBox13)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.TextBox12)
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
        'TextBox27
        '
        Me.TextBox27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox27.Location = New System.Drawing.Point(110, 62)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(68, 26)
        Me.TextBox27.TabIndex = 33
        Me.TextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(110, 22)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(68, 26)
        Me.TextBox12.TabIndex = 29
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GroupBox5.Size = New System.Drawing.Size(324, 181)
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
        Me.ListView1.Size = New System.Drawing.Size(314, 153)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ListView2)
        Me.GroupBox6.Location = New System.Drawing.Point(477, 317)
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(538, 537)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(61, 24)
        Me.CheckBox1.TabIndex = 33
        Me.CheckBox1.Text = "SSS"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FormPAYROLL_PAYEE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 618)
        Me.Controls.Add(Me.CheckBox1)
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
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
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
    Friend WithEvents TextBox31 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents txt_payNightDiff As System.Windows.Forms.TextBox
    Friend WithEvents txt_numNightDiff As System.Windows.Forms.TextBox
    Friend WithEvents txt_totalNightDiff As System.Windows.Forms.TextBox
    Friend WithEvents TextBox35 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox36 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
