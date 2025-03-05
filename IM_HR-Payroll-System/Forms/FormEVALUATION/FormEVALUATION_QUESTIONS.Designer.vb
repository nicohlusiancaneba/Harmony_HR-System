<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEVALUATION_QUESTIONS
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
        Me.lbl_criteria = New System.Windows.Forms.Label()
        Me.num_Q5 = New System.Windows.Forms.NumericUpDown()
        Me.num_Q4 = New System.Windows.Forms.NumericUpDown()
        Me.num_Q3 = New System.Windows.Forms.NumericUpDown()
        Me.num_Q2 = New System.Windows.Forms.NumericUpDown()
        Me.num_Q1 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_questions = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.num_Q5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_Q4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_Q3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_Q2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_Q1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_criteria
        '
        Me.lbl_criteria.AutoSize = True
        Me.lbl_criteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_criteria.Location = New System.Drawing.Point(12, 47)
        Me.lbl_criteria.Name = "lbl_criteria"
        Me.lbl_criteria.Size = New System.Drawing.Size(59, 20)
        Me.lbl_criteria.TabIndex = 37
        Me.lbl_criteria.Text = "Criteria"
        Me.lbl_criteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_Q5
        '
        Me.num_Q5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.num_Q5.Location = New System.Drawing.Point(16, 331)
        Me.num_Q5.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.num_Q5.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_Q5.Name = "num_Q5"
        Me.num_Q5.Size = New System.Drawing.Size(41, 26)
        Me.num_Q5.TabIndex = 36
        Me.num_Q5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_Q5.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'num_Q4
        '
        Me.num_Q4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.num_Q4.Location = New System.Drawing.Point(16, 271)
        Me.num_Q4.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.num_Q4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_Q4.Name = "num_Q4"
        Me.num_Q4.Size = New System.Drawing.Size(41, 26)
        Me.num_Q4.TabIndex = 35
        Me.num_Q4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_Q4.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'num_Q3
        '
        Me.num_Q3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.num_Q3.Location = New System.Drawing.Point(16, 212)
        Me.num_Q3.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.num_Q3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_Q3.Name = "num_Q3"
        Me.num_Q3.Size = New System.Drawing.Size(41, 26)
        Me.num_Q3.TabIndex = 34
        Me.num_Q3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_Q3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'num_Q2
        '
        Me.num_Q2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.num_Q2.Location = New System.Drawing.Point(16, 147)
        Me.num_Q2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.num_Q2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_Q2.Name = "num_Q2"
        Me.num_Q2.Size = New System.Drawing.Size(41, 26)
        Me.num_Q2.TabIndex = 33
        Me.num_Q2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_Q2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'num_Q1
        '
        Me.num_Q1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.num_Q1.Location = New System.Drawing.Point(16, 94)
        Me.num_Q1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.num_Q1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_Q1.Name = "num_Q1"
        Me.num_Q1.Size = New System.Drawing.Size(41, 26)
        Me.num_Q1.TabIndex = 32
        Me.num_Q1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_Q1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_questions
        '
        Me.lbl_questions.AutoSize = True
        Me.lbl_questions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_questions.Location = New System.Drawing.Point(76, 94)
        Me.lbl_questions.Name = "lbl_questions"
        Me.lbl_questions.Size = New System.Drawing.Size(81, 20)
        Me.lbl_questions.TabIndex = 31
        Me.lbl_questions.Text = "Questions"
        Me.lbl_questions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(532, 375)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_Cancel.TabIndex = 39
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(456, 375)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(70, 30)
        Me.btn_Save.TabIndex = 38
        Me.btn_Save.Text = "&Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(589, 15)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Instructions: Rate from 1 to 10, with 1 being the lowest and 10 being the highest" & _
    ", based on the given criteria."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormEVALUATION_QUESTIONS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 417)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.lbl_criteria)
        Me.Controls.Add(Me.num_Q5)
        Me.Controls.Add(Me.num_Q4)
        Me.Controls.Add(Me.num_Q3)
        Me.Controls.Add(Me.num_Q2)
        Me.Controls.Add(Me.num_Q1)
        Me.Controls.Add(Me.lbl_questions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEVALUATION_QUESTIONS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEVALUATION_QUESTIONS"
        CType(Me.num_Q5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_Q4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_Q3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_Q2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_Q1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_criteria As System.Windows.Forms.Label
    Friend WithEvents num_Q5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_Q4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_Q3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_Q2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_Q1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_questions As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
