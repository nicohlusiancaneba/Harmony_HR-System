<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLOANS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLOANS))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lst_loans = New System.Windows.Forms.ListView()
        Me.btn_newLoan = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rb_Paid = New System.Windows.Forms.RadioButton()
        Me.rb_Active = New System.Windows.Forms.RadioButton()
        Me.rb_All = New System.Windows.Forms.RadioButton()
        Me.searchBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_searchCancel = New System.Windows.Forms.Button()
        Me.btn_searchSubmit = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_search = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.searchBox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "List of all details of employee loans"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 31)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Employees Loans Record"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditEmployeeToolStripMenuItem, Me.DeleteEmployeeToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(166, 52)
        '
        'EditEmployeeToolStripMenuItem
        '
        Me.EditEmployeeToolStripMenuItem.Image = Global.Harmony.My.Resources.Resources.edit
        Me.EditEmployeeToolStripMenuItem.Name = "EditEmployeeToolStripMenuItem"
        Me.EditEmployeeToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.EditEmployeeToolStripMenuItem.Text = "Edit Loan"
        '
        'DeleteEmployeeToolStripMenuItem
        '
        Me.DeleteEmployeeToolStripMenuItem.Image = Global.Harmony.My.Resources.Resources.bin
        Me.DeleteEmployeeToolStripMenuItem.Name = "DeleteEmployeeToolStripMenuItem"
        Me.DeleteEmployeeToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.DeleteEmployeeToolStripMenuItem.Text = "Delete Loan"
        '
        'lst_loans
        '
        Me.lst_loans.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lst_loans.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_loans.FullRowSelect = True
        Me.lst_loans.GridLines = True
        Me.lst_loans.Location = New System.Drawing.Point(8, 104)
        Me.lst_loans.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_loans.Name = "lst_loans"
        Me.lst_loans.Size = New System.Drawing.Size(866, 176)
        Me.lst_loans.TabIndex = 23
        Me.lst_loans.UseCompatibleStateImageBehavior = False
        Me.lst_loans.View = System.Windows.Forms.View.Details
        '
        'btn_newLoan
        '
        Me.btn_newLoan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newLoan.ImageKey = "plus.png"
        Me.btn_newLoan.ImageList = Me.ImageList1
        Me.btn_newLoan.Location = New System.Drawing.Point(134, 2)
        Me.btn_newLoan.Name = "btn_newLoan"
        Me.btn_newLoan.Size = New System.Drawing.Size(108, 43)
        Me.btn_newLoan.TabIndex = 22
        Me.btn_newLoan.Text = "New Loan"
        Me.btn_newLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_newLoan.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Harmony.My.Resources.Resources.loan
        Me.PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rb_Paid)
        Me.Panel2.Controls.Add(Me.rb_Active)
        Me.Panel2.Controls.Add(Me.rb_All)
        Me.Panel2.Location = New System.Drawing.Point(8, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(199, 33)
        Me.Panel2.TabIndex = 24
        '
        'rb_Paid
        '
        Me.rb_Paid.AutoSize = True
        Me.rb_Paid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Paid.Location = New System.Drawing.Point(129, 5)
        Me.rb_Paid.Name = "rb_Paid"
        Me.rb_Paid.Size = New System.Drawing.Size(58, 24)
        Me.rb_Paid.TabIndex = 2
        Me.rb_Paid.TabStop = True
        Me.rb_Paid.Text = "Paid"
        Me.rb_Paid.UseVisualStyleBackColor = True
        '
        'rb_Active
        '
        Me.rb_Active.AutoSize = True
        Me.rb_Active.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Active.Location = New System.Drawing.Point(53, 5)
        Me.rb_Active.Name = "rb_Active"
        Me.rb_Active.Size = New System.Drawing.Size(70, 24)
        Me.rb_Active.TabIndex = 1
        Me.rb_Active.TabStop = True
        Me.rb_Active.Text = "Active"
        Me.rb_Active.UseVisualStyleBackColor = True
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
        Me.searchBox.Location = New System.Drawing.Point(289, 150)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(304, 100)
        Me.searchBox.TabIndex = 25
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
        Me.Panel1.Controls.Add(Me.btn_search)
        Me.Panel1.Controls.Add(Me.btn_newLoan)
        Me.Panel1.Location = New System.Drawing.Point(628, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 48)
        Me.Panel1.TabIndex = 26
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "plus.png")
        Me.ImageList1.Images.SetKeyName(1, "add.png")
        Me.ImageList1.Images.SetKeyName(2, "search.png")
        '
        'btn_search
        '
        Me.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ImageKey = "search.png"
        Me.btn_search.ImageList = Me.ImageList1
        Me.btn_search.Location = New System.Drawing.Point(3, 2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(130, 43)
        Me.btn_search.TabIndex = 23
        Me.btn_search.Text = "Search Loan"
        Me.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'FormLOANS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 291)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lst_loans)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLOANS"
        Me.Text = "FormLOANS"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.searchBox.ResumeLayout(False)
        Me.searchBox.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_newLoan As System.Windows.Forms.Button
    Friend WithEvents lst_loans As System.Windows.Forms.ListView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rb_Paid As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Active As System.Windows.Forms.RadioButton
    Friend WithEvents rb_All As System.Windows.Forms.RadioButton
    Friend WithEvents searchBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_searchCancel As System.Windows.Forms.Button
    Friend WithEvents btn_searchSubmit As System.Windows.Forms.Button
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btn_search As System.Windows.Forms.Button
End Class
