<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormADJUSTMENTS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormADJUSTMENTS))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditAdjustment = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAdjustment = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rb_tax = New System.Windows.Forms.RadioButton()
        Me.rb_Philhealth = New System.Windows.Forms.RadioButton()
        Me.rb_PagIBIG = New System.Windows.Forms.RadioButton()
        Me.rb_SSS = New System.Windows.Forms.RadioButton()
        Me.rb_salary = New System.Windows.Forms.RadioButton()
        Me.rb_All = New System.Windows.Forms.RadioButton()
        Me.searchBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_searchCancel = New System.Windows.Forms.Button()
        Me.btn_searchSubmit = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_searchAdjustment = New System.Windows.Forms.Button()
        Me.btn_newAdjustment = New System.Windows.Forms.Button()
        Me.lst_adjusments = New System.Windows.Forms.ListView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rb_reg = New System.Windows.Forms.RadioButton()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.searchBox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "List of all details of adjustments per employee."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Adjustments Record"
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
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditAdjustment, Me.DeleteAdjustment})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(211, 52)
        '
        'EditAdjustment
        '
        Me.EditAdjustment.Image = Global.Harmony.My.Resources.Resources.edit
        Me.EditAdjustment.Name = "EditAdjustment"
        Me.EditAdjustment.Size = New System.Drawing.Size(210, 24)
        Me.EditAdjustment.Text = "Edit Adjustment"
        '
        'DeleteAdjustment
        '
        Me.DeleteAdjustment.Image = Global.Harmony.My.Resources.Resources.bin
        Me.DeleteAdjustment.Name = "DeleteAdjustment"
        Me.DeleteAdjustment.Size = New System.Drawing.Size(210, 24)
        Me.DeleteAdjustment.Text = "Delete Adjustment"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rb_reg)
        Me.Panel2.Controls.Add(Me.rb_tax)
        Me.Panel2.Controls.Add(Me.rb_Philhealth)
        Me.Panel2.Controls.Add(Me.rb_PagIBIG)
        Me.Panel2.Controls.Add(Me.rb_SSS)
        Me.Panel2.Controls.Add(Me.rb_salary)
        Me.Panel2.Controls.Add(Me.rb_All)
        Me.Panel2.Location = New System.Drawing.Point(8, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(606, 33)
        Me.Panel2.TabIndex = 27
        '
        'rb_tax
        '
        Me.rb_tax.AutoSize = True
        Me.rb_tax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_tax.Location = New System.Drawing.Point(412, 5)
        Me.rb_tax.Name = "rb_tax"
        Me.rb_tax.Size = New System.Drawing.Size(52, 24)
        Me.rb_tax.TabIndex = 5
        Me.rb_tax.TabStop = True
        Me.rb_tax.Text = "Tax"
        Me.rb_tax.UseVisualStyleBackColor = True
        '
        'rb_Philhealth
        '
        Me.rb_Philhealth.AutoSize = True
        Me.rb_Philhealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Philhealth.Location = New System.Drawing.Point(310, 5)
        Me.rb_Philhealth.Name = "rb_Philhealth"
        Me.rb_Philhealth.Size = New System.Drawing.Size(96, 24)
        Me.rb_Philhealth.TabIndex = 4
        Me.rb_Philhealth.TabStop = True
        Me.rb_Philhealth.Text = "Philhealth"
        Me.rb_Philhealth.UseVisualStyleBackColor = True
        '
        'rb_PagIBIG
        '
        Me.rb_PagIBIG.AutoSize = True
        Me.rb_PagIBIG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_PagIBIG.Location = New System.Drawing.Point(196, 5)
        Me.rb_PagIBIG.Name = "rb_PagIBIG"
        Me.rb_PagIBIG.Size = New System.Drawing.Size(108, 24)
        Me.rb_PagIBIG.TabIndex = 3
        Me.rb_PagIBIG.TabStop = True
        Me.rb_PagIBIG.Text = "PAG - IBIG"
        Me.rb_PagIBIG.UseVisualStyleBackColor = True
        '
        'rb_SSS
        '
        Me.rb_SSS.AutoSize = True
        Me.rb_SSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_SSS.Location = New System.Drawing.Point(130, 5)
        Me.rb_SSS.Name = "rb_SSS"
        Me.rb_SSS.Size = New System.Drawing.Size(60, 24)
        Me.rb_SSS.TabIndex = 2
        Me.rb_SSS.TabStop = True
        Me.rb_SSS.Text = "SSS"
        Me.rb_SSS.UseVisualStyleBackColor = True
        '
        'rb_salary
        '
        Me.rb_salary.AutoSize = True
        Me.rb_salary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_salary.Location = New System.Drawing.Point(53, 5)
        Me.rb_salary.Name = "rb_salary"
        Me.rb_salary.Size = New System.Drawing.Size(71, 24)
        Me.rb_salary.TabIndex = 1
        Me.rb_salary.TabStop = True
        Me.rb_salary.Text = "Salary"
        Me.rb_salary.UseVisualStyleBackColor = True
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
        'searchBox
        '
        Me.searchBox.Controls.Add(Me.Label3)
        Me.searchBox.Controls.Add(Me.btn_searchCancel)
        Me.searchBox.Controls.Add(Me.btn_searchSubmit)
        Me.searchBox.Controls.Add(Me.txt_search)
        Me.searchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBox.Location = New System.Drawing.Point(286, 150)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(304, 100)
        Me.searchBox.TabIndex = 26
        Me.searchBox.TabStop = False
        Me.searchBox.Text = "Search"
        Me.searchBox.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Keyword :"
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
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btn_searchAdjustment)
        Me.Panel1.Controls.Add(Me.btn_newAdjustment)
        Me.Panel1.Location = New System.Drawing.Point(726, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 62)
        Me.Panel1.TabIndex = 25
        '
        'btn_searchAdjustment
        '
        Me.btn_searchAdjustment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_searchAdjustment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_searchAdjustment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_searchAdjustment.ImageKey = "search.png"
        Me.btn_searchAdjustment.ImageList = Me.ImageList1
        Me.btn_searchAdjustment.Location = New System.Drawing.Point(4, 12)
        Me.btn_searchAdjustment.Name = "btn_searchAdjustment"
        Me.btn_searchAdjustment.Size = New System.Drawing.Size(176, 43)
        Me.btn_searchAdjustment.TabIndex = 13
        Me.btn_searchAdjustment.Text = "Search Adjustment"
        Me.btn_searchAdjustment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_searchAdjustment.UseVisualStyleBackColor = True
        '
        'btn_newAdjustment
        '
        Me.btn_newAdjustment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_newAdjustment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newAdjustment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newAdjustment.ImageKey = "plus.png"
        Me.btn_newAdjustment.ImageList = Me.ImageList1
        Me.btn_newAdjustment.Location = New System.Drawing.Point(184, 12)
        Me.btn_newAdjustment.Name = "btn_newAdjustment"
        Me.btn_newAdjustment.Size = New System.Drawing.Size(158, 43)
        Me.btn_newAdjustment.TabIndex = 12
        Me.btn_newAdjustment.Text = "New Adjustment"
        Me.btn_newAdjustment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_newAdjustment.UseVisualStyleBackColor = True
        '
        'lst_adjusments
        '
        Me.lst_adjusments.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lst_adjusments.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_adjusments.FullRowSelect = True
        Me.lst_adjusments.GridLines = True
        Me.lst_adjusments.Location = New System.Drawing.Point(8, 104)
        Me.lst_adjusments.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_adjusments.Name = "lst_adjusments"
        Me.lst_adjusments.Size = New System.Drawing.Size(1062, 177)
        Me.lst_adjusments.TabIndex = 24
        Me.lst_adjusments.UseCompatibleStateImageBehavior = False
        Me.lst_adjusments.View = System.Windows.Forms.View.Details
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Harmony.My.Resources.Resources.adjustment
        Me.PictureBox1.Location = New System.Drawing.Point(8, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'rb_reg
        '
        Me.rb_reg.AutoSize = True
        Me.rb_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_reg.Location = New System.Drawing.Point(470, 5)
        Me.rb_reg.Name = "rb_reg"
        Me.rb_reg.Size = New System.Drawing.Size(129, 24)
        Me.rb_reg.TabIndex = 6
        Me.rb_reg.TabStop = True
        Me.rb_reg.Text = "Regularization"
        Me.rb_reg.UseVisualStyleBackColor = True
        '
        'FormADJUSTMENTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 287)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lst_adjusments)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormADJUSTMENTS"
        Me.Text = "FormADJUSTMENTS"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.searchBox.ResumeLayout(False)
        Me.searchBox.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditAdjustment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteAdjustment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rb_tax As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Philhealth As System.Windows.Forms.RadioButton
    Friend WithEvents rb_PagIBIG As System.Windows.Forms.RadioButton
    Friend WithEvents rb_SSS As System.Windows.Forms.RadioButton
    Friend WithEvents rb_salary As System.Windows.Forms.RadioButton
    Friend WithEvents rb_All As System.Windows.Forms.RadioButton
    Friend WithEvents searchBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_searchCancel As System.Windows.Forms.Button
    Friend WithEvents btn_searchSubmit As System.Windows.Forms.Button
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_searchAdjustment As System.Windows.Forms.Button
    Friend WithEvents btn_newAdjustment As System.Windows.Forms.Button
    Friend WithEvents lst_adjusments As System.Windows.Forms.ListView
    Friend WithEvents rb_reg As System.Windows.Forms.RadioButton
End Class
