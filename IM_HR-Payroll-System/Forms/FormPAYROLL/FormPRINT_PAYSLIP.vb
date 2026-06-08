Imports Microsoft.Reporting.WinForms
Imports System.IO


Public Class FormPRINT_PAYSLIP
    Private m_streams As List(Of Stream)
    Private m_currentPageIndex As Integer
    Dim payroll_id, employee_id As Integer
    Private Sub FormPRINT_PAYSLIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.Reset()
        payroll_id = xID1
        sqlSTR = "select * from Employees " & _
                " inner join Payroll_Details on Payroll_Details.Employee_ID = Employees.Employee_ID where Payroll_ID = " & payroll_id & _
                " order by Last_Name, First_Name"
        FILLComboBox_Employee(sqlSTR, cmb_employees)
    End Sub

    Private Sub cmb_employees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_employees.SelectedIndexChanged
        ReportViewer1.Reset()

        If cmb_employees.Text = "" Then
            Exit Sub
        End If

        employee_id = Split(cmb_employees.Text, " - ")(0)
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

    Private Sub btnLoadAll_Click(sender As Object, e As EventArgs) Handles btnLoadAll.Click
        ' Store current selection
        Dim currentSelection As Integer = cmb_employees.SelectedIndex

        ' Create combined DataTable to hold all employees' data
        Dim allPayslipsData As New DataTable()
        Dim isFirstEmployee As Boolean = True

        ' Loop through each employee in combobox
        For i As Integer = 0 To cmb_employees.Items.Count - 1
            ' Select the employee (this will trigger your existing logic)
            cmb_employees.SelectedIndex = i
            Application.DoEvents()

            ' Get the current employee_id that was set in the SelectedIndexChanged event
            Dim currentEmployeeId As String = employee_id

            ' Execute the same query for this employee
            Dim currentSqlSTR As String = "select *, Format(numOvertime, 'N2') as numOvertime_hr, Format(numNight_diff, 'N2') as numNight_diff_hr, " & _
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
                    "inner join Employees on Employees.Employee_ID = Payroll_Details.Employee_ID where Payroll_Details.Employee_ID=" & currentEmployeeId & " and Payroll_Details.Payroll_ID=" & payroll_id

            ' Execute query for current employee
            ExecuteSQLQuery(currentSqlSTR)

            ' Add current employee's data to combined table
            If isFirstEmployee Then
                ' Clone the structure from first employee
                allPayslipsData = sqlDT.Clone()
                isFirstEmployee = False
            End If

            ' Import all rows from current employee
            For Each row As DataRow In sqlDT.Rows
                allPayslipsData.ImportRow(row)
            Next
        Next

        ' Load all combined data into ReportViewer
        ReportViewer1.Reset()
        Dim businessName_RP As New ReportParameter("Business_Name", business_name)

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Reports\Payslip_Employee.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", allPayslipsData))
            .SetParameters(businessName_RP)
        End With

        ' Apply same page settings
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

        ' Restore original selection
        cmb_employees.SelectedIndex = currentSelection

        MessageBox.Show("All " & cmb_employees.Items.Count & " payslips loaded into report viewer.")
    End Sub

    ' Alternative simpler version - reuse existing logic
    Private Sub btnLoadAllSimple_Click(sender As Object, e As EventArgs) Handles btnLoadAllSimple.Click
        Dim currentSelection As Integer = cmb_employees.SelectedIndex
        Dim allPayslipsData As New DataTable()
        Dim isFirstEmployee As Boolean = True

        ' Loop through each employee
        For i As Integer = 0 To cmb_employees.Items.Count - 1
            ' This will trigger your SelectedIndexChanged event and populate sqlDT
            cmb_employees.SelectedIndex = i
            Application.DoEvents()

            ' Wait a moment for the report to load
            System.Threading.Thread.Sleep(100)

            ' Copy data from sqlDT (which is populated by your existing code)
            If isFirstEmployee Then
                allPayslipsData = sqlDT.Clone()
                isFirstEmployee = False
            End If

            ' Add current employee's data
            For Each row As DataRow In sqlDT.Rows
                allPayslipsData.ImportRow(row)
            Next
        Next

        ' Load combined data (reuse your existing report setup)
        ReportViewer1.Reset()
        Dim businessName_RP As New ReportParameter("Business_Name", business_name)

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Reports\Payslip_Employee.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", allPayslipsData))
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
        cmb_employees.SelectedIndex = currentSelection
    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub



End Class