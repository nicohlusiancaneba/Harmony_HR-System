<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFILE_MANAGE
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_openFiles = New System.Windows.Forms.Button()
        Me.txt_uploadedFile = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_FileType = New System.Windows.Forms.ComboBox()
        Me.txt_Remarks = New System.Windows.Forms.TextBox()
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_openFiles
        '
        Me.btn_openFiles.Location = New System.Drawing.Point(27, 96)
        Me.btn_openFiles.Name = "btn_openFiles"
        Me.btn_openFiles.Size = New System.Drawing.Size(75, 27)
        Me.btn_openFiles.TabIndex = 18
        Me.btn_openFiles.Text = "Choose File"
        Me.btn_openFiles.UseVisualStyleBackColor = True
        '
        'txt_uploadedFile
        '
        Me.txt_uploadedFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uploadedFile.Location = New System.Drawing.Point(110, 96)
        Me.txt_uploadedFile.Name = "txt_uploadedFile"
        Me.txt_uploadedFile.Size = New System.Drawing.Size(206, 26)
        Me.txt_uploadedFile.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 100)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "File Type :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remarks :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                 :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_FileType
        '
        Me.cmb_FileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_FileType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_FileType.FormattingEnabled = True
        Me.cmb_FileType.Location = New System.Drawing.Point(110, 16)
        Me.cmb_FileType.Name = "cmb_FileType"
        Me.cmb_FileType.Size = New System.Drawing.Size(253, 28)
        Me.cmb_FileType.TabIndex = 26
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Location = New System.Drawing.Point(110, 58)
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(253, 26)
        Me.txt_Remarks.TabIndex = 27
        '
        'btn_upload
        '
        Me.btn_upload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_upload.Location = New System.Drawing.Point(207, 145)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(75, 27)
        Me.btn_upload.TabIndex = 28
        Me.btn_upload.Text = "Upload"
        Me.btn_upload.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_cancel.Location = New System.Drawing.Point(288, 145)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 27)
        Me.btn_cancel.TabIndex = 29
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'FormFILE_MANAGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 184)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_upload)
        Me.Controls.Add(Me.txt_Remarks)
        Me.Controls.Add(Me.cmb_FileType)
        Me.Controls.Add(Me.txt_uploadedFile)
        Me.Controls.Add(Me.btn_openFiles)
        Me.Controls.Add(Me.Label9)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormFILE_MANAGE"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Upload"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_openFiles As System.Windows.Forms.Button
    Friend WithEvents txt_uploadedFile As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_FileType As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents btn_upload As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
End Class
