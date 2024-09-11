<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEMPLOYEES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEMPLOYEES))
        Me.lst_employees = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_newEmployee = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_searchEmployee = New System.Windows.Forms.Button()
        Me.cmb_employmentStatus = New System.Windows.Forms.ComboBox()
        Me.searchBox = New System.Windows.Forms.GroupBox()
        Me.btn_searchCancel = New System.Windows.Forms.Button()
        Me.btn_searchSubmit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.searchBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_employees
        '
        Me.lst_employees.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lst_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_employees.FullRowSelect = True
        Me.lst_employees.GridLines = True
        Me.lst_employees.Location = New System.Drawing.Point(8, 104)
        Me.lst_employees.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_employees.Name = "lst_employees"
        Me.lst_employees.Size = New System.Drawing.Size(866, 177)
        Me.lst_employees.TabIndex = 8
        Me.lst_employees.UseCompatibleStateImageBehavior = False
        Me.lst_employees.View = System.Windows.Forms.View.Details
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditEmployeeToolStripMenuItem, Me.DeleteEmployeeToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(200, 52)
        '
        'EditEmployeeToolStripMenuItem
        '
        Me.EditEmployeeToolStripMenuItem.Image = Global.Harmony.My.Resources.Resources.edit
        Me.EditEmployeeToolStripMenuItem.Name = "EditEmployeeToolStripMenuItem"
        Me.EditEmployeeToolStripMenuItem.Size = New System.Drawing.Size(199, 24)
        Me.EditEmployeeToolStripMenuItem.Text = "Edit Employee"
        '
        'DeleteEmployeeToolStripMenuItem
        '
        Me.DeleteEmployeeToolStripMenuItem.Image = Global.Harmony.My.Resources.Resources.bin
        Me.DeleteEmployeeToolStripMenuItem.Name = "DeleteEmployeeToolStripMenuItem"
        Me.DeleteEmployeeToolStripMenuItem.Size = New System.Drawing.Size(199, 24)
        Me.DeleteEmployeeToolStripMenuItem.Text = "Delete Employee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Employees Record"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "List of all details of employees"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "plus.png")
        Me.ImageList1.Images.SetKeyName(1, "add.png")
        Me.ImageList1.Images.SetKeyName(2, "search.png")
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(89, 25)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(206, 26)
        Me.txt_search.TabIndex = 14
        '
        'btn_newEmployee
        '
        Me.btn_newEmployee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_newEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newEmployee.ImageKey = "plus.png"
        Me.btn_newEmployee.ImageList = Me.ImageList1
        Me.btn_newEmployee.Location = New System.Drawing.Point(174, 12)
        Me.btn_newEmployee.Name = "btn_newEmployee"
        Me.btn_newEmployee.Size = New System.Drawing.Size(142, 43)
        Me.btn_newEmployee.TabIndex = 12
        Me.btn_newEmployee.Text = "New Employee"
        Me.btn_newEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_newEmployee.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Harmony.My.Resources.Resources.employees
        Me.PictureBox1.Location = New System.Drawing.Point(8, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Employment Status :"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btn_searchEmployee)
        Me.Panel1.Controls.Add(Me.btn_newEmployee)
        Me.Panel1.Location = New System.Drawing.Point(549, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 62)
        Me.Panel1.TabIndex = 16
        '
        'btn_searchEmployee
        '
        Me.btn_searchEmployee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_searchEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_searchEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_searchEmployee.ImageKey = "search.png"
        Me.btn_searchEmployee.ImageList = Me.ImageList1
        Me.btn_searchEmployee.Location = New System.Drawing.Point(6, 12)
        Me.btn_searchEmployee.Name = "btn_searchEmployee"
        Me.btn_searchEmployee.Size = New System.Drawing.Size(162, 43)
        Me.btn_searchEmployee.TabIndex = 13
        Me.btn_searchEmployee.Text = "Search Employee"
        Me.btn_searchEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_searchEmployee.UseVisualStyleBackColor = True
        '
        'cmb_employmentStatus
        '
        Me.cmb_employmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employmentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_employmentStatus.FormattingEnabled = True
        Me.cmb_employmentStatus.Items.AddRange(New Object() {"", "Owner", "Regular", "Probationary", "Probationary (Extended)", "Outsource"})
        Me.cmb_employmentStatus.Location = New System.Drawing.Point(170, 71)
        Me.cmb_employmentStatus.Name = "cmb_employmentStatus"
        Me.cmb_employmentStatus.Size = New System.Drawing.Size(142, 28)
        Me.cmb_employmentStatus.TabIndex = 16
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
        Me.searchBox.TabIndex = 17
        Me.searchBox.TabStop = False
        Me.searchBox.Text = "Search"
        Me.searchBox.Visible = False
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
        'FormEMPLOYEES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 292)
        Me.Controls.Add(Me.cmb_employmentStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lst_employees)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEMPLOYEES"
        Me.Text = "FormEMPLOYEES"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.searchBox.ResumeLayout(False)
        Me.searchBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lst_employees As System.Windows.Forms.ListView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_newEmployee As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmb_employmentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents searchBox As System.Windows.Forms.GroupBox
    Friend WithEvents btn_searchSubmit As System.Windows.Forms.Button
    Friend WithEvents btn_searchEmployee As System.Windows.Forms.Button
    Friend WithEvents btn_searchCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
