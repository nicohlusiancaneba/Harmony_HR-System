Imports Microsoft.Reporting.WinForms
Imports System.IO


Public Class FrmPRINT_PAYSLIP
    Private m_streams As List(Of Stream)
    Private m_currentPageIndex As Integer
    Dim payroll_id, employee_id As Integer

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ReportViewer1.Reset()
    End Sub

    Private Sub FrmPRINT_PAYSLIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.Reset()



        employee_id = FrmPAYROLL_DETAILS.dgv_payroll.CurrentRow.Cells("Employee_ID").Value.ToString
        payroll_id = FrmPAYROLL_DETAILS.payroll_Id
        sqlSTR = "select *, Format(numOvertime, 'N2') as numOvertime_hr, Format(numNight_diff, 'N2') as numNight_diff_hr, " & _
                "Format(numLate, 'N2') as numLate_hr, Format(numUndertime, 'N2') as numUndertime_hr, " & _
                "COALESCE((select sum(Gross_Payment) from Loan_Payments as LP " & _
                "inner join Loans on Loans.Loan_ID = LP.Loan_ID " & _
                "where Loan_Type = 'Allowance Advance' and LP.Payroll_Detail_ID = Payroll_Details.Payroll_Detail_ID), 0.00) as Allowance_Advance, " & _
                "COALESCE((select sum(Gross_Payment) from Loan_Payments as LP " & _
                "inner join Loans on Loans.Loan_ID = LP.Loan_ID " & _
                "where Loan_Type = 'Cash Advance' and LP.Payroll_Detail_ID = Payroll_Details.Payroll_Detail_ID), 0.00) as Cash_Advance, " & _
                "COALESCE((select sum(Gross_Payment) from Loan_Payments as LP " & _
                "inner join Loans on Loans.Loan_ID = LP.Loan_ID " & _
                "where Loan_Type = 'Personal' and LP.Payroll_Detail_ID = Payroll_Details.Payroll_Detail_ID), 0.00) as Personal, " & _
                "COALESCE((select sum(Gross_Payment) from Loan_Payments as LP " & _
                "inner join Loans on Loans.Loan_ID = LP.Loan_ID " & _
                "where Loan_Type = 'Emergency' and LP.Payroll_Detail_ID = Payroll_Details.Payroll_Detail_ID), 0.00) as Emergency, " & _
                "COALESCE((select sum(Gross_Payment) from Loan_Payments as LP " & _
                "inner join Loans on Loans.Loan_ID = LP.Loan_ID " & _
                "where Loan_Type = 'SSS' and LP.Payroll_Detail_ID = Payroll_Details.Payroll_Detail_ID), 0.00) as SSSloan, " & _
                "COALESCE((select sum(Gross_Payment) from Loan_Payments as LP " & _
                "inner join Loans on Loans.Loan_ID = LP.Loan_ID " & _
                "where Loan_Type = 'PAG-IBIG' and LP.Payroll_Detail_ID = Payroll_Details.Payroll_Detail_ID), 0.00) as PAGIBIGloan, " & _
                "COALESCE((select sum(Gross_Payment) from Loan_Payments as LP " & _
                "inner join Loans on Loans.Loan_ID = LP.Loan_ID " & _
                "where Loan_Type = 'Product' and LP.Payroll_Detail_ID = Payroll_Details.Payroll_Detail_ID), 0.00) as Others " & _
                "from Payroll_Details " & _
                "inner join Payroll on Payroll.Payroll_ID = Payroll_Details.Payroll_ID " & _
                "inner join Employees on Employees.Employee_ID = Payroll_Details.Employee_ID where Payroll_Details.Employee_ID=" & employee_id & " and Payroll_Details.Payroll_ID=" & payroll_id
        ExecuteSQLQuery(sqlSTR)

        Dim businessName_RP As New ReportParameter("Business_Name", business_name)
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Reports\Payslip_Employee.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", sqlDT))
            .SetParameters(businessName_RP)
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

    Private Sub cmb_employees_SelectedIndexChanged(sender As Object, e As EventArgs)
        

    End Sub

    



End Class