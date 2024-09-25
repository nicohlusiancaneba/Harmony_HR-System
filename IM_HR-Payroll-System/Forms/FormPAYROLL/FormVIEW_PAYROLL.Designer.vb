<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVIEW_PAYROLL
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
        Me.lst_payrollView = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'lst_payrollView
        '
        Me.lst_payrollView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_payrollView.FullRowSelect = True
        Me.lst_payrollView.GridLines = True
        Me.lst_payrollView.Location = New System.Drawing.Point(11, 11)
        Me.lst_payrollView.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_payrollView.Name = "lst_payrollView"
        Me.lst_payrollView.Size = New System.Drawing.Size(1082, 569)
        Me.lst_payrollView.TabIndex = 16
        Me.lst_payrollView.UseCompatibleStateImageBehavior = False
        Me.lst_payrollView.View = System.Windows.Forms.View.Details
        '
        'FormVIEW_PAYROLL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 591)
        Me.Controls.Add(Me.lst_payrollView)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormVIEW_PAYROLL"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Comprehensive Payroll View"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lst_payrollView As System.Windows.Forms.ListView
End Class
