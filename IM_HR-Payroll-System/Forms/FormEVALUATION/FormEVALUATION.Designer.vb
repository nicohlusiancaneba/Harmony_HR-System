<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEVALUATION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEVALUATION))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lst_evaluation = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_month = New System.Windows.Forms.ComboBox()
        Me.cmb_year = New System.Windows.Forms.ComboBox()
        Me.btn_searchLeave = New System.Windows.Forms.Button()
        Me.btn_newLeave = New System.Windows.Forms.Button()
        Me.EditLeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteLeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "List of all evaluation of employees"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 31)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Employee Evaluation"
        '
        'lst_evaluation
        '
        Me.lst_evaluation.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lst_evaluation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_evaluation.FullRowSelect = True
        Me.lst_evaluation.GridLines = True
        Me.lst_evaluation.Location = New System.Drawing.Point(8, 109)
        Me.lst_evaluation.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_evaluation.Name = "lst_evaluation"
        Me.lst_evaluation.Size = New System.Drawing.Size(1062, 177)
        Me.lst_evaluation.TabIndex = 20
        Me.lst_evaluation.UseCompatibleStateImageBehavior = False
        Me.lst_evaluation.View = System.Windows.Forms.View.Details
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "plus.png")
        Me.ImageList1.Images.SetKeyName(1, "add.png")
        Me.ImageList1.Images.SetKeyName(2, "search.png")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditLeaveToolStripMenuItem, Me.DeleteLeaveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(173, 52)
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btn_searchLeave)
        Me.Panel1.Controls.Add(Me.btn_newLeave)
        Me.Panel1.Location = New System.Drawing.Point(730, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 62)
        Me.Panel1.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmb_year)
        Me.Panel2.Controls.Add(Me.cmb_month)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(12, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(420, 33)
        Me.Panel2.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Month :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(215, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Year :"
        '
        'cmb_month
        '
        Me.cmb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_month.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmb_month.FormattingEnabled = True
        Me.cmb_month.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmb_month.Location = New System.Drawing.Point(64, 2)
        Me.cmb_month.Name = "cmb_month"
        Me.cmb_month.Size = New System.Drawing.Size(126, 28)
        Me.cmb_month.TabIndex = 25
        '
        'cmb_year
        '
        Me.cmb_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmb_year.FormattingEnabled = True
        Me.cmb_year.Location = New System.Drawing.Point(263, 2)
        Me.cmb_year.Name = "cmb_year"
        Me.cmb_year.Size = New System.Drawing.Size(81, 28)
        Me.cmb_year.TabIndex = 27
        '
        'btn_searchLeave
        '
        Me.btn_searchLeave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_searchLeave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_searchLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_searchLeave.ImageKey = "search.png"
        Me.btn_searchLeave.ImageList = Me.ImageList1
        Me.btn_searchLeave.Location = New System.Drawing.Point(12, 16)
        Me.btn_searchLeave.Name = "btn_searchLeave"
        Me.btn_searchLeave.Size = New System.Drawing.Size(174, 43)
        Me.btn_searchLeave.TabIndex = 13
        Me.btn_searchLeave.Text = "Search Evaluation"
        Me.btn_searchLeave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_searchLeave.UseVisualStyleBackColor = True
        '
        'btn_newLeave
        '
        Me.btn_newLeave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_newLeave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newLeave.ImageKey = "plus.png"
        Me.btn_newLeave.ImageList = Me.ImageList1
        Me.btn_newLeave.Location = New System.Drawing.Point(190, 16)
        Me.btn_newLeave.Name = "btn_newLeave"
        Me.btn_newLeave.Size = New System.Drawing.Size(147, 43)
        Me.btn_newLeave.TabIndex = 12
        Me.btn_newLeave.Text = "New Evaluation"
        Me.btn_newLeave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_newLeave.UseVisualStyleBackColor = True
        '
        'EditLeaveToolStripMenuItem
        '
        Me.EditLeaveToolStripMenuItem.Image = Global.Harmony.My.Resources.Resources.edit
        Me.EditLeaveToolStripMenuItem.Name = "EditLeaveToolStripMenuItem"
        Me.EditLeaveToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.EditLeaveToolStripMenuItem.Text = "Edit Leave"
        '
        'DeleteLeaveToolStripMenuItem
        '
        Me.DeleteLeaveToolStripMenuItem.Image = Global.Harmony.My.Resources.Resources.bin
        Me.DeleteLeaveToolStripMenuItem.Name = "DeleteLeaveToolStripMenuItem"
        Me.DeleteLeaveToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.DeleteLeaveToolStripMenuItem.Text = "Delete Leave"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Harmony.My.Resources.Resources.evaluation2
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'FormEVALUATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 293)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lst_evaluation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEVALUATION"
        Me.Text = "FormEVALUATION"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lst_evaluation As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditLeaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteLeaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_searchLeave As System.Windows.Forms.Button
    Friend WithEvents btn_newLeave As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_year As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_month As System.Windows.Forms.ComboBox
End Class
