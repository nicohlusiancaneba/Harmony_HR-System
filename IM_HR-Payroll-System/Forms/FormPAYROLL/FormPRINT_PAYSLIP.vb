Public Class FormPRINT_PAYSLIP
    Dim payroll_id, employee_id As Integer
    Private Sub FormPRINT_PAYSLIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        payroll_id = xID1
        sqlSTR = "select * from Employees " & _
                "inner join Payroll_Details on Payroll_Details.Employee_ID = Employees.Employee_ID where Payroll_ID = " & payroll_id
        FILLComboBox_Employee(sqlSTR, cmb_employees)
    End Sub

    Private Sub cmb_employees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_employees.SelectedIndexChanged
        employee_id = Split(cmb_employees.Text, " - ")(0)
        sqlSTR = "select *  from Payroll_Details " & _
                    "inner join Payroll on Payroll.Payroll_ID = Payroll_Details.Payroll_ID " & _
                    "inner join Employees on Employees.Employee_ID = Payroll_Details.Employee_ID where Payroll_Details.Employee_ID=" & employee_id & " and Payroll_Details.Payroll_ID=" & payroll_id
        ExecuteSQLQuery(sqlSTR)


        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Reports\Payslip_Employee.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", sqlDT))
        End With
        Me.ReportViewer1.RefreshReport()
        'Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        'Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
    End Sub
End Class