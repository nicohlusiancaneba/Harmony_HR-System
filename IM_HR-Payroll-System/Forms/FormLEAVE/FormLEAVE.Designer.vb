<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLEAVE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLEAVE))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rb_Rejected = New System.Windows.Forms.RadioButton()
        Me.rb_Finished = New System.Windows.Forms.RadioButton()
        Me.rb_Upcoming = New System.Windows.Forms.RadioButton()
        Me.rb_pending = New System.Windows.Forms.RadioButton()
        Me.lst_leaves = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditLeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteLeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_searchLeave = New System.Windows.Forms.Button()
        Me.btn_newLeave = New System.Windows.Forms.Button()
        Me.rb_All = New System.Windows.Forms.RadioButton()
        Me.rb_onLeave = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(298, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "List of all leave applications of employees"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Leave Application"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rb_onLeave)
        Me.Panel2.Controls.Add(Me.rb_All)
        Me.Panel2.Controls.Add(Me.rb_Rejected)
        Me.Panel2.Controls.Add(Me.rb_Finished)
        Me.Panel2.Controls.Add(Me.rb_Upcoming)
        Me.Panel2.Controls.Add(Me.rb_pending)
        Me.Panel2.Location = New System.Drawing.Point(12, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(573, 33)
        Me.Panel2.TabIndex = 20
        '
        'rb_Rejected
        '
        Me.rb_Rejected.AutoSize = True
        Me.rb_Rejected.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Rejected.Location = New System.Drawing.Point(401, 5)
        Me.rb_Rejected.Name = "rb_Rejected"
        Me.rb_Rejected.Size = New System.Drawing.Size(91, 24)
        Me.rb_Rejected.TabIndex = 3
        Me.rb_Rejected.TabStop = True
        Me.rb_Rejected.Text = "Rejected"
        Me.rb_Rejected.UseVisualStyleBackColor = True
        '
        'rb_Finished
        '
        Me.rb_Finished.AutoSize = True
        Me.rb_Finished.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Finished.Location = New System.Drawing.Point(301, 5)
        Me.rb_Finished.Name = "rb_Finished"
        Me.rb_Finished.Size = New System.Drawing.Size(87, 24)
        Me.rb_Finished.TabIndex = 2
        Me.rb_Finished.TabStop = True
        Me.rb_Finished.Text = "Finished"
        Me.rb_Finished.UseVisualStyleBackColor = True
        '
        'rb_Upcoming
        '
        Me.rb_Upcoming.AutoSize = True
        Me.rb_Upcoming.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Upcoming.Location = New System.Drawing.Point(92, 5)
        Me.rb_Upcoming.Name = "rb_Upcoming"
        Me.rb_Upcoming.Size = New System.Drawing.Size(99, 24)
        Me.rb_Upcoming.TabIndex = 1
        Me.rb_Upcoming.TabStop = True
        Me.rb_Upcoming.Text = "Upcoming"
        Me.rb_Upcoming.UseVisualStyleBackColor = True
        '
        'rb_pending
        '
        Me.rb_pending.AutoSize = True
        Me.rb_pending.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_pending.Location = New System.Drawing.Point(3, 5)
        Me.rb_pending.Name = "rb_pending"
        Me.rb_pending.Size = New System.Drawing.Size(85, 24)
        Me.rb_pending.TabIndex = 0
        Me.rb_pending.TabStop = True
        Me.rb_pending.Text = "Pending"
        Me.rb_pending.UseVisualStyleBackColor = True
        '
        'lst_leaves
        '
        Me.lst_leaves.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lst_leaves.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_leaves.FullRowSelect = True
        Me.lst_leaves.GridLines = True
        Me.lst_leaves.Location = New System.Drawing.Point(8, 104)
        Me.lst_leaves.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_leaves.Name = "lst_leaves"
        Me.lst_leaves.Size = New System.Drawing.Size(1062, 177)
        Me.lst_leaves.TabIndex = 19
        Me.lst_leaves.UseCompatibleStateImageBehavior = False
        Me.lst_leaves.View = System.Windows.Forms.View.Details
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditLeaveToolStripMenuItem, Me.DeleteLeaveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(173, 52)
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
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "plus.png")
        Me.ImageList1.Images.SetKeyName(1, "add.png")
        Me.ImageList1.Images.SetKeyName(2, "search.png")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btn_searchLeave)
        Me.Panel1.Controls.Add(Me.btn_newLeave)
        Me.Panel1.Location = New System.Drawing.Point(792, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(278, 62)
        Me.Panel1.TabIndex = 22
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
        Me.btn_searchLeave.Size = New System.Drawing.Size(143, 43)
        Me.btn_searchLeave.TabIndex = 13
        Me.btn_searchLeave.Text = "Search Leave"
        Me.btn_searchLeave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_searchLeave.UseVisualStyleBackColor = True
        Me.btn_searchLeave.Visible = False
        '
        'btn_newLeave
        '
        Me.btn_newLeave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_newLeave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newLeave.ImageKey = "plus.png"
        Me.btn_newLeave.ImageList = Me.ImageList1
        Me.btn_newLeave.Location = New System.Drawing.Point(159, 16)
        Me.btn_newLeave.Name = "btn_newLeave"
        Me.btn_newLeave.Size = New System.Drawing.Size(117, 43)
        Me.btn_newLeave.TabIndex = 12
        Me.btn_newLeave.Text = "New Leave"
        Me.btn_newLeave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_newLeave.UseVisualStyleBackColor = True
        '
        'rb_All
        '
        Me.rb_All.AutoSize = True
        Me.rb_All.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_All.Location = New System.Drawing.Point(503, 5)
        Me.rb_All.Name = "rb_All"
        Me.rb_All.Size = New System.Drawing.Size(44, 24)
        Me.rb_All.TabIndex = 4
        Me.rb_All.TabStop = True
        Me.rb_All.Text = "All"
        Me.rb_All.UseVisualStyleBackColor = True
        '
        'rb_onLeave
        '
        Me.rb_onLeave.AutoSize = True
        Me.rb_onLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_onLeave.Location = New System.Drawing.Point(201, 5)
        Me.rb_onLeave.Name = "rb_onLeave"
        Me.rb_onLeave.Size = New System.Drawing.Size(90, 24)
        Me.rb_onLeave.TabIndex = 5
        Me.rb_onLeave.TabStop = True
        Me.rb_onLeave.Text = "On-leave"
        Me.rb_onLeave.UseVisualStyleBackColor = True
        '
        'FormLEAVE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 287)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lst_leaves)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLEAVE"
        Me.Text = "FormLEAVE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rb_Rejected As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Finished As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Upcoming As System.Windows.Forms.RadioButton
    Friend WithEvents rb_pending As System.Windows.Forms.RadioButton
    Friend WithEvents lst_leaves As System.Windows.Forms.ListView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditLeaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteLeaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_searchLeave As System.Windows.Forms.Button
    Friend WithEvents btn_newLeave As System.Windows.Forms.Button
    Friend WithEvents rb_All As System.Windows.Forms.RadioButton
    Friend WithEvents rb_onLeave As System.Windows.Forms.RadioButton
End Class
