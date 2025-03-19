<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormREPORTS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormREPORTS))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lst_report = New System.Windows.Forms.ListView()
        Me.reportLabel = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_newReport = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Create and view system generated reports"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 31)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "System Reports"
        '
        'lst_report
        '
        Me.lst_report.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_report.FullRowSelect = True
        Me.lst_report.GridLines = True
        Me.lst_report.Location = New System.Drawing.Point(8, 109)
        Me.lst_report.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_report.Name = "lst_report"
        Me.lst_report.Size = New System.Drawing.Size(1062, 177)
        Me.lst_report.TabIndex = 21
        Me.lst_report.UseCompatibleStateImageBehavior = False
        Me.lst_report.View = System.Windows.Forms.View.Details
        '
        'reportLabel
        '
        Me.reportLabel.AutoSize = True
        Me.reportLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.reportLabel.Location = New System.Drawing.Point(7, 82)
        Me.reportLabel.Name = "reportLabel"
        Me.reportLabel.Size = New System.Drawing.Size(376, 20)
        Me.reportLabel.TabIndex = 25
        Me.reportLabel.Text = "Click the 'New Report' button to generate the report."
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
        Me.Panel1.Controls.Add(Me.btn_newReport)
        Me.Panel1.Location = New System.Drawing.Point(727, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 62)
        Me.Panel1.TabIndex = 26
        '
        'btn_newReport
        '
        Me.btn_newReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_newReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newReport.ImageKey = "plus.png"
        Me.btn_newReport.ImageList = Me.ImageList1
        Me.btn_newReport.Location = New System.Drawing.Point(216, 16)
        Me.btn_newReport.Name = "btn_newReport"
        Me.btn_newReport.Size = New System.Drawing.Size(121, 43)
        Me.btn_newReport.TabIndex = 12
        Me.btn_newReport.Text = "New Report"
        Me.btn_newReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_newReport.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Harmony.My.Resources.Resources.reports2
        Me.PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'FormREPORTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 298)
        Me.Controls.Add(Me.reportLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lst_report)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormREPORTS"
        Me.Text = "FormREPORTS"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lst_report As System.Windows.Forms.ListView
    Friend WithEvents reportLabel As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_newReport As System.Windows.Forms.Button
End Class
