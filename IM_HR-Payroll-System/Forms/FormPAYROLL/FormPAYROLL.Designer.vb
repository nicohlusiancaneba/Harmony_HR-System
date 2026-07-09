<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPAYROLL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPAYROLL))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lst_payroll = New System.Windows.Forms.ListView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rb_Approved = New System.Windows.Forms.RadioButton()
        Me.rb_Pending = New System.Windows.Forms.RadioButton()
        Me.rb_All = New System.Windows.Forms.RadioButton()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt_end = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_start = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MiscellaneousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateMultiplePayrollBOBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.btn_refreshPayroll = New System.Windows.Forms.Button()
        Me.btn_newPayroll = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.grpFilter.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "plus.png")
        Me.ImageList1.Images.SetKeyName(1, "add.png")
        Me.ImageList1.Images.SetKeyName(2, "loading-arrow.png")
        Me.ImageList1.Images.SetKeyName(3, "filter.png")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditEmployeeToolStripMenuItem, Me.DeleteEmployeeToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(176, 52)
        '
        'EditEmployeeToolStripMenuItem
        '
        Me.EditEmployeeToolStripMenuItem.Image = Global.Harmony.My.Resources.Resources.edit
        Me.EditEmployeeToolStripMenuItem.Name = "EditEmployeeToolStripMenuItem"
        Me.EditEmployeeToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.EditEmployeeToolStripMenuItem.Text = "Edit Payroll"
        '
        'DeleteEmployeeToolStripMenuItem
        '
        Me.DeleteEmployeeToolStripMenuItem.Image = Global.Harmony.My.Resources.Resources.bin
        Me.DeleteEmployeeToolStripMenuItem.Name = "DeleteEmployeeToolStripMenuItem"
        Me.DeleteEmployeeToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.DeleteEmployeeToolStripMenuItem.Text = "Delete Payroll"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "List of all records of payroll per cutoff week"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 31)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Payroll"
        '
        'lst_payroll
        '
        Me.lst_payroll.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lst_payroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_payroll.FullRowSelect = True
        Me.lst_payroll.GridLines = True
        Me.lst_payroll.Location = New System.Drawing.Point(6, 74)
        Me.lst_payroll.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_payroll.Name = "lst_payroll"
        Me.lst_payroll.Size = New System.Drawing.Size(954, 178)
        Me.lst_payroll.TabIndex = 15
        Me.lst_payroll.UseCompatibleStateImageBehavior = False
        Me.lst_payroll.View = System.Windows.Forms.View.Details
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rb_Approved)
        Me.Panel2.Controls.Add(Me.rb_Pending)
        Me.Panel2.Controls.Add(Me.rb_All)
        Me.Panel2.Location = New System.Drawing.Point(6, 407)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(277, 33)
        Me.Panel2.TabIndex = 20
        Me.Panel2.Visible = False
        '
        'rb_Approved
        '
        Me.rb_Approved.AutoSize = True
        Me.rb_Approved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Approved.Location = New System.Drawing.Point(140, 5)
        Me.rb_Approved.Name = "rb_Approved"
        Me.rb_Approved.Size = New System.Drawing.Size(95, 24)
        Me.rb_Approved.TabIndex = 2
        Me.rb_Approved.TabStop = True
        Me.rb_Approved.Text = "Approved"
        Me.rb_Approved.UseVisualStyleBackColor = True
        '
        'rb_Pending
        '
        Me.rb_Pending.AutoSize = True
        Me.rb_Pending.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Pending.Location = New System.Drawing.Point(53, 5)
        Me.rb_Pending.Name = "rb_Pending"
        Me.rb_Pending.Size = New System.Drawing.Size(85, 24)
        Me.rb_Pending.TabIndex = 1
        Me.rb_Pending.TabStop = True
        Me.rb_Pending.Text = "Pending"
        Me.rb_Pending.UseVisualStyleBackColor = True
        '
        'rb_All
        '
        Me.rb_All.AutoSize = True
        Me.rb_All.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_All.Location = New System.Drawing.Point(3, 5)
        Me.rb_All.Name = "rb_All"
        Me.rb_All.Size = New System.Drawing.Size(44, 24)
        Me.rb_All.TabIndex = 0
        Me.rb_All.TabStop = True
        Me.rb_All.Text = "All"
        Me.rb_All.UseVisualStyleBackColor = True
        '
        'grpFilter
        '
        Me.grpFilter.Controls.Add(Me.btn_cancel)
        Me.grpFilter.Controls.Add(Me.btn_submit)
        Me.grpFilter.Controls.Add(Me.Label4)
        Me.grpFilter.Controls.Add(Me.dt_end)
        Me.grpFilter.Controls.Add(Me.Label3)
        Me.grpFilter.Controls.Add(Me.dt_start)
        Me.grpFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFilter.Location = New System.Drawing.Point(301, 111)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(347, 100)
        Me.grpFilter.TabIndex = 23
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Select Cutoff Period"
        Me.grpFilter.Visible = False
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(253, 59)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 33)
        Me.btn_cancel.TabIndex = 5
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(172, 59)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(75, 33)
        Me.btn_submit.TabIndex = 4
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(189, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "To :"
        '
        'dt_end
        '
        Me.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_end.Location = New System.Drawing.Point(227, 30)
        Me.dt_end.Name = "dt_end"
        Me.dt_end.Size = New System.Drawing.Size(101, 23)
        Me.dt_end.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "From :"
        '
        'dt_start
        '
        Me.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_start.Location = New System.Drawing.Point(65, 31)
        Me.dt_start.Name = "dt_start"
        Me.dt_start.Size = New System.Drawing.Size(101, 23)
        Me.dt_start.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiscellaneousToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(972, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MiscellaneousToolStripMenuItem
        '
        Me.MiscellaneousToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateMultiplePayrollBOBToolStripMenuItem})
        Me.MiscellaneousToolStripMenuItem.Name = "MiscellaneousToolStripMenuItem"
        Me.MiscellaneousToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.MiscellaneousToolStripMenuItem.Text = "Tools"
        '
        'GenerateMultiplePayrollBOBToolStripMenuItem
        '
        Me.GenerateMultiplePayrollBOBToolStripMenuItem.Name = "GenerateMultiplePayrollBOBToolStripMenuItem"
        Me.GenerateMultiplePayrollBOBToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.GenerateMultiplePayrollBOBToolStripMenuItem.Text = "Generate Multiple Payroll (BOB)"
        '
        'btn_filter
        '
        Me.btn_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_filter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_filter.ImageKey = "filter.png"
        Me.btn_filter.ImageList = Me.ImageList1
        Me.btn_filter.Location = New System.Drawing.Point(598, 26)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(83, 43)
        Me.btn_filter.TabIndex = 22
        Me.btn_filter.Text = "Filter"
        Me.btn_filter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'btn_refreshPayroll
        '
        Me.btn_refreshPayroll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_refreshPayroll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_refreshPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refreshPayroll.ImageKey = "loading-arrow.png"
        Me.btn_refreshPayroll.ImageList = Me.ImageList1
        Me.btn_refreshPayroll.Location = New System.Drawing.Point(687, 26)
        Me.btn_refreshPayroll.Name = "btn_refreshPayroll"
        Me.btn_refreshPayroll.Size = New System.Drawing.Size(149, 43)
        Me.btn_refreshPayroll.TabIndex = 21
        Me.btn_refreshPayroll.Text = "Refresh Payroll"
        Me.btn_refreshPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_refreshPayroll.UseVisualStyleBackColor = True
        '
        'btn_newPayroll
        '
        Me.btn_newPayroll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_newPayroll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newPayroll.ImageKey = "plus.png"
        Me.btn_newPayroll.ImageList = Me.ImageList1
        Me.btn_newPayroll.Location = New System.Drawing.Point(842, 26)
        Me.btn_newPayroll.Name = "btn_newPayroll"
        Me.btn_newPayroll.Size = New System.Drawing.Size(118, 43)
        Me.btn_newPayroll.TabIndex = 19
        Me.btn_newPayroll.Text = "New Payroll"
        Me.btn_newPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_newPayroll.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Harmony.My.Resources.Resources.payroll
        Me.PictureBox1.Location = New System.Drawing.Point(8, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'FormPAYROLL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 261)
        Me.Controls.Add(Me.grpFilter)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.btn_refreshPayroll)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_newPayroll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lst_payroll)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPAYROLL"
        Me.Text = "FormPAYROLL"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_newPayroll As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lst_payroll As System.Windows.Forms.ListView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rb_Approved As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Pending As System.Windows.Forms.RadioButton
    Friend WithEvents rb_All As System.Windows.Forms.RadioButton
    Friend WithEvents btn_refreshPayroll As System.Windows.Forms.Button
    Friend WithEvents btn_filter As System.Windows.Forms.Button
    Friend WithEvents grpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dt_end As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_start As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MiscellaneousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateMultiplePayrollBOBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
