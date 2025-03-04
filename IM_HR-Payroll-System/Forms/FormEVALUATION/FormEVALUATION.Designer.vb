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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditEvaluationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteEvaluationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_searchEvaluation = New System.Windows.Forms.Button()
        Me.btn_newEvaluation = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmb_year = New System.Windows.Forms.ComboBox()
        Me.cmb_month = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.searchBox = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_searchCancel = New System.Windows.Forms.Button()
        Me.btn_searchSubmit = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.searchBox.SuspendLayout()
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditEvaluationToolStripMenuItem, Me.DeleteEvaluationToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(204, 52)
        '
        'EditEvaluationToolStripMenuItem
        '
        Me.EditEvaluationToolStripMenuItem.Image = Global.Harmony.My.Resources.Resources.edit
        Me.EditEvaluationToolStripMenuItem.Name = "EditEvaluationToolStripMenuItem"
        Me.EditEvaluationToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.EditEvaluationToolStripMenuItem.Text = "Edit Evaluation"
        '
        'DeleteEvaluationToolStripMenuItem
        '
        Me.DeleteEvaluationToolStripMenuItem.Image = Global.Harmony.My.Resources.Resources.bin
        Me.DeleteEvaluationToolStripMenuItem.Name = "DeleteEvaluationToolStripMenuItem"
        Me.DeleteEvaluationToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.DeleteEvaluationToolStripMenuItem.Text = "Delete Evaluation"
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
        Me.Panel1.Controls.Add(Me.btn_searchEvaluation)
        Me.Panel1.Controls.Add(Me.btn_newEvaluation)
        Me.Panel1.Location = New System.Drawing.Point(730, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 62)
        Me.Panel1.TabIndex = 23
        '
        'btn_searchEvaluation
        '
        Me.btn_searchEvaluation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_searchEvaluation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_searchEvaluation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_searchEvaluation.ImageKey = "search.png"
        Me.btn_searchEvaluation.ImageList = Me.ImageList1
        Me.btn_searchEvaluation.Location = New System.Drawing.Point(12, 16)
        Me.btn_searchEvaluation.Name = "btn_searchEvaluation"
        Me.btn_searchEvaluation.Size = New System.Drawing.Size(174, 43)
        Me.btn_searchEvaluation.TabIndex = 13
        Me.btn_searchEvaluation.Text = "Search Evaluation"
        Me.btn_searchEvaluation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_searchEvaluation.UseVisualStyleBackColor = True
        '
        'btn_newEvaluation
        '
        Me.btn_newEvaluation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_newEvaluation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newEvaluation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newEvaluation.ImageKey = "plus.png"
        Me.btn_newEvaluation.ImageList = Me.ImageList1
        Me.btn_newEvaluation.Location = New System.Drawing.Point(190, 16)
        Me.btn_newEvaluation.Name = "btn_newEvaluation"
        Me.btn_newEvaluation.Size = New System.Drawing.Size(147, 43)
        Me.btn_newEvaluation.TabIndex = 12
        Me.btn_newEvaluation.Text = "New Evaluation"
        Me.btn_newEvaluation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_newEvaluation.UseVisualStyleBackColor = True
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
        'searchBox
        '
        Me.searchBox.Controls.Add(Me.Label5)
        Me.searchBox.Controls.Add(Me.btn_searchCancel)
        Me.searchBox.Controls.Add(Me.btn_searchSubmit)
        Me.searchBox.Controls.Add(Me.txt_search)
        Me.searchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBox.Location = New System.Drawing.Point(389, 153)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(304, 100)
        Me.searchBox.TabIndex = 25
        Me.searchBox.TabStop = False
        Me.searchBox.Text = "Search"
        Me.searchBox.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Keyword :"
        '
        'btn_searchCancel
        '
        Me.btn_searchCancel.Location = New System.Drawing.Point(220, 58)
        Me.btn_searchCancel.Name = "btn_searchCancel"
        Me.btn_searchCancel.Size = New System.Drawing.Size(75, 36)
        Me.btn_searchCancel.TabIndex = 20
        Me.btn_searchCancel.Text = "Cancel"
        Me.btn_searchCancel.UseVisualStyleBackColor = True
        '
        'btn_searchSubmit
        '
        Me.btn_searchSubmit.Location = New System.Drawing.Point(140, 57)
        Me.btn_searchSubmit.Name = "btn_searchSubmit"
        Me.btn_searchSubmit.Size = New System.Drawing.Size(75, 36)
        Me.btn_searchSubmit.TabIndex = 19
        Me.btn_searchSubmit.Text = "Submit"
        Me.btn_searchSubmit.UseVisualStyleBackColor = True
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(89, 25)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(206, 26)
        Me.txt_search.TabIndex = 14
        '
        'FormEVALUATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 293)
        Me.Controls.Add(Me.searchBox)
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
        Me.searchBox.ResumeLayout(False)
        Me.searchBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lst_evaluation As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditEvaluationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteEvaluationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_searchEvaluation As System.Windows.Forms.Button
    Friend WithEvents btn_newEvaluation As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_year As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_month As System.Windows.Forms.ComboBox
    Friend WithEvents searchBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_searchCancel As System.Windows.Forms.Button
    Friend WithEvents btn_searchSubmit As System.Windows.Forms.Button
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
End Class
