﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEXPORT_ONLINE_BANK
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lst_payrollView = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual
        Me.ReportViewer1.Size = New System.Drawing.Size(939, 464)
        Me.ReportViewer1.TabIndex = 1
        '
        'lst_payrollView
        '
        Me.lst_payrollView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_payrollView.FullRowSelect = True
        Me.lst_payrollView.GridLines = True
        Me.lst_payrollView.Location = New System.Drawing.Point(32, 585)
        Me.lst_payrollView.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_payrollView.Name = "lst_payrollView"
        Me.lst_payrollView.Size = New System.Drawing.Size(476, 84)
        Me.lst_payrollView.TabIndex = 17
        Me.lst_payrollView.UseCompatibleStateImageBehavior = False
        Me.lst_payrollView.View = System.Windows.Forms.View.Details
        '
        'FormEXPORT_ONLINE_BANK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 484)
        Me.Controls.Add(Me.lst_payrollView)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEXPORT_ONLINE_BANK"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Export to Online Banking"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents lst_payrollView As System.Windows.Forms.ListView
End Class
