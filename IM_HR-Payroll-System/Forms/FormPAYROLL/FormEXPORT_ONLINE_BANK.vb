Public Class FormEXPORT_ONLINE_BANK
    Dim payroll_id As Integer
    Private Sub FormEXPORT_ONLINE_BANK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.Reset()
        payroll_id = xID1
        sqlSTR = "select ROW_NUMBER() OVER (ORDER BY Payroll_Details.Employee_ID) as 'Number', Payroll_Account_Number, " & _
            "Last_Name, First_Name, Middle_Name, grandTotal_Net from Payroll_Details " & _
            "inner join Employees on Employees.Employee_ID = Payroll_Details.Employee_ID " & _
            "where Payroll_ID = " & payroll_id
        ExecuteSQLQuery(sqlSTR)

        'Dim businessName_RP As New ReportParameter("Business_Name", business_name)
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Reports\Payroll_Export.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", sqlDT))
            '.SetParameters(businessName_RP)
        End With

        Dim pageSettings As New System.Drawing.Printing.PageSettings()
        pageSettings.PaperSize = New System.Drawing.Printing.PaperSize("A4", 827, 1169)
        pageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        pageSettings.Landscape = False
        With Me.ReportViewer1
            .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            .ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            .ZoomPercent = 100
            .SetPageSettings(pageSettings)
        End With
        ReportViewer1.RefreshReport()
    End Sub
End Class