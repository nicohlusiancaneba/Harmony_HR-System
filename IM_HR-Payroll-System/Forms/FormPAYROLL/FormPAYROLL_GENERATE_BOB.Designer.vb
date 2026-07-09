<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPAYROLL_GENERATE_BOB
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lst_payroll = New System.Windows.Forms.ListView()
        Me.Payroll_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Payroll_Remarks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_generateData = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_payroll = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt_end = New System.Windows.Forms.DateTimePicker()
        Me.dt_start = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_payroll = New System.Windows.Forms.DataGridView()
        Me.Account_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.First_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Middle_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Net = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_totalNet = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_payroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst_payroll
        '
        Me.lst_payroll.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Payroll_ID, Me.Payroll_Remarks})
        Me.lst_payroll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_payroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lst_payroll.FullRowSelect = True
        Me.lst_payroll.GridLines = True
        Me.lst_payroll.Location = New System.Drawing.Point(5, 18)
        Me.lst_payroll.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_payroll.Name = "lst_payroll"
        Me.lst_payroll.Size = New System.Drawing.Size(346, 217)
        Me.lst_payroll.TabIndex = 16
        Me.lst_payroll.UseCompatibleStateImageBehavior = False
        Me.lst_payroll.View = System.Windows.Forms.View.Details
        '
        'Payroll_ID
        '
        Me.Payroll_ID.Text = "Payroll ID"
        Me.Payroll_ID.Width = 100
        '
        'Payroll_Remarks
        '
        Me.Payroll_Remarks.Text = "Payroll Remarks"
        Me.Payroll_Remarks.Width = 250
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Generate Multiple Payroll for BOB Format"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lst_payroll)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(356, 240)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Payroll for Generate"
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_add.Location = New System.Drawing.Point(112, 105)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 29)
        Me.btn_add.TabIndex = 19
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_remove.Location = New System.Drawing.Point(193, 105)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(75, 29)
        Me.btn_remove.TabIndex = 20
        Me.btn_remove.Text = "Remove"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_clear.Location = New System.Drawing.Point(295, 105)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 29)
        Me.btn_clear.TabIndex = 21
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(274, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "|"
        '
        'btn_generateData
        '
        Me.btn_generateData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generateData.Location = New System.Drawing.Point(112, 386)
        Me.btn_generateData.Name = "btn_generateData"
        Me.btn_generateData.Size = New System.Drawing.Size(144, 42)
        Me.btn_generateData.TabIndex = 23
        Me.btn_generateData.Text = "Generate Data"
        Me.btn_generateData.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Select Payroll :"
        '
        'cmb_payroll
        '
        Me.cmb_payroll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_payroll.DropDownWidth = 350
        Me.cmb_payroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_payroll.FormattingEnabled = True
        Me.cmb_payroll.Location = New System.Drawing.Point(119, 72)
        Me.cmb_payroll.Name = "cmb_payroll"
        Me.cmb_payroll.Size = New System.Drawing.Size(251, 24)
        Me.cmb_payroll.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(224, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "to"
        '
        'dt_end
        '
        Me.dt_end.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_end.Location = New System.Drawing.Point(250, 43)
        Me.dt_end.Name = "dt_end"
        Me.dt_end.Size = New System.Drawing.Size(101, 23)
        Me.dt_end.TabIndex = 27
        '
        'dt_start
        '
        Me.dt_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_start.Location = New System.Drawing.Point(119, 43)
        Me.dt_start.Name = "dt_start"
        Me.dt_start.Size = New System.Drawing.Size(101, 23)
        Me.dt_start.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(11, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Select Cutoff :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_payroll)
        Me.GroupBox2.Location = New System.Drawing.Point(396, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(655, 370)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of Payroll for Generate"
        '
        'dgv_payroll
        '
        Me.dgv_payroll.AllowUserToAddRows = False
        Me.dgv_payroll.AllowUserToDeleteRows = False
        Me.dgv_payroll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_payroll.BackgroundColor = System.Drawing.Color.White
        Me.dgv_payroll.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_payroll.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_payroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_payroll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Account_No, Me.Last_Name, Me.First_Name, Me.Middle_Name, Me.Total_Net})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_payroll.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_payroll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_payroll.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_payroll.Location = New System.Drawing.Point(5, 18)
        Me.dgv_payroll.Name = "dgv_payroll"
        Me.dgv_payroll.ReadOnly = True
        Me.dgv_payroll.RowHeadersVisible = False
        Me.dgv_payroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_payroll.ShowCellErrors = False
        Me.dgv_payroll.ShowCellToolTips = False
        Me.dgv_payroll.ShowEditingIcon = False
        Me.dgv_payroll.ShowRowErrors = False
        Me.dgv_payroll.Size = New System.Drawing.Size(645, 347)
        Me.dgv_payroll.TabIndex = 705
        '
        'Account_No
        '
        Me.Account_No.HeaderText = "Account No."
        Me.Account_No.Name = "Account_No"
        Me.Account_No.ReadOnly = True
        Me.Account_No.Width = 150
        '
        'Last_Name
        '
        Me.Last_Name.HeaderText = "Last Name"
        Me.Last_Name.Name = "Last_Name"
        Me.Last_Name.ReadOnly = True
        Me.Last_Name.Width = 120
        '
        'First_Name
        '
        Me.First_Name.HeaderText = "First Name"
        Me.First_Name.Name = "First_Name"
        Me.First_Name.ReadOnly = True
        Me.First_Name.Width = 120
        '
        'Middle_Name
        '
        Me.Middle_Name.HeaderText = "Middle Name"
        Me.Middle_Name.Name = "Middle_Name"
        Me.Middle_Name.ReadOnly = True
        Me.Middle_Name.Width = 120
        '
        'Total_Net
        '
        Me.Total_Net.HeaderText = "Total Net"
        Me.Total_Net.Name = "Total_Net"
        Me.Total_Net.ReadOnly = True
        Me.Total_Net.Width = 200
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(790, 397)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Total Payroll :"
        '
        'txt_totalNet
        '
        Me.txt_totalNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_totalNet.Location = New System.Drawing.Point(898, 394)
        Me.txt_totalNet.Name = "txt_totalNet"
        Me.txt_totalNet.ReadOnly = True
        Me.txt_totalNet.Size = New System.Drawing.Size(148, 26)
        Me.txt_totalNet.TabIndex = 31
        Me.txt_totalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormPAYROLL_GENERATE_BOB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 438)
        Me.Controls.Add(Me.txt_totalNet)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dt_end)
        Me.Controls.Add(Me.dt_start)
        Me.Controls.Add(Me.cmb_payroll)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_generateData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPAYROLL_GENERATE_BOB"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Data for BOB"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_payroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lst_payroll As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_generateData As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_payroll As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dt_end As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_start As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Payroll_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Payroll_Remarks As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_payroll As System.Windows.Forms.DataGridView
    Friend WithEvents Account_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Last_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents First_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Middle_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Net As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_totalNet As System.Windows.Forms.TextBox
End Class
