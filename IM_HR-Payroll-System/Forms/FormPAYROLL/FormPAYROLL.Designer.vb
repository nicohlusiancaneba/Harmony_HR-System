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
        Me.btn_newPayroll = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lst_payroll = New System.Windows.Forms.ListView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rb_Approved = New System.Windows.Forms.RadioButton()
        Me.rb_Pending = New System.Windows.Forms.RadioButton()
        Me.rb_All = New System.Windows.Forms.RadioButton()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "plus.png")
        Me.ImageList1.Images.SetKeyName(1, "add.png")
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
        'btn_newPayroll
        '
        Me.btn_newPayroll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_newPayroll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newPayroll.ImageKey = "plus.png"
        Me.btn_newPayroll.ImageList = Me.ImageList1
        Me.btn_newPayroll.Location = New System.Drawing.Point(749, 26)
        Me.btn_newPayroll.Name = "btn_newPayroll"
        Me.btn_newPayroll.Size = New System.Drawing.Size(118, 43)
        Me.btn_newPayroll.TabIndex = 19
        Me.btn_newPayroll.Text = "New Payroll"
        Me.btn_newPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_newPayroll.UseVisualStyleBackColor = True
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
        'lst_payroll
        '
        Me.lst_payroll.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lst_payroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_payroll.FullRowSelect = True
        Me.lst_payroll.GridLines = True
        Me.lst_payroll.Location = New System.Drawing.Point(6, 74)
        Me.lst_payroll.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_payroll.Name = "lst_payroll"
        Me.lst_payroll.Size = New System.Drawing.Size(866, 64)
        Me.lst_payroll.TabIndex = 15
        Me.lst_payroll.UseCompatibleStateImageBehavior = False
        Me.lst_payroll.View = System.Windows.Forms.View.Details
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rb_Approved)
        Me.Panel2.Controls.Add(Me.rb_Pending)
        Me.Panel2.Controls.Add(Me.rb_All)
        Me.Panel2.Location = New System.Drawing.Point(8, 228)
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
        'FormPAYROLL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 150)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_newPayroll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lst_payroll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPAYROLL"
        Me.Text = "FormPAYROLL"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
End Class
