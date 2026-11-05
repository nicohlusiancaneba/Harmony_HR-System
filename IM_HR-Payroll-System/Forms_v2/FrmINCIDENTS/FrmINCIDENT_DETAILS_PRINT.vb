Public Class FrmINCIDENT_DETAILS_PRINT
    Dim Incident_ID As String

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ReportViewer1.Reset()
    End Sub


    Private Sub FrmINCIDENT_DETAILS_PRINT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Incident_ID = FrmINCIDENT_DETAILS.Incident_ID

        ReportViewer1.Reset()

        Dim Incidents, Incident_Details_Employees, Incident_Details_Offenses, Incident_Details_Actions As DataTable

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Reports\Incident_Report.rdlc"



          
            sqlSTR = "select " & _
                      "Incident_EncodeDate " & _
                      ",Incident_UpdateDate " & _
                      ",Incident_DateTime " & _
                      ",Incident_Classification " & _
                      ",Incident_Location " & _
                      ",Incident_Details " & _
                      ",Incident_Cause " & _
                      ",Incident_Evidence " & _
                      ",Incident_Recommendations " & _
                      ",Incident_Status " & _
                      ",Prepared_By " & _
                      ",CONCAT(TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '. ', TRIM(Last_name)) as Reported_By " & _
                      ",Position " & _
                      ",Department " & _
                      ",Division " & _
                      ",CASE " & _
                      "WHEN (DATEDIFF(MONTH, Hired_Date, GETDATE()) " & _
                      "- CASE WHEN DAY(Hired_Date) > DAY(GETDATE()) THEN 1 ELSE 0 END) / 12 = 0 " & _
                      "THEN " & _
                      "CAST((DATEDIFF(MONTH, Hired_Date, GETDATE()) " & _
                      "- CASE WHEN DAY(Hired_Date) > DAY(GETDATE()) THEN 1 ELSE 0 END) % 12 AS VARCHAR) " & _
                      "+ ' month' " & _
                      "+ CASE WHEN (DATEDIFF(MONTH, Hired_Date, GETDATE()) " & _
                      "- CASE WHEN DAY(Hired_Date) > DAY(GETDATE()) THEN 1 ELSE 0 END) % 12 = 1 " & _
                      "THEN '' ELSE 's' END " & _
                      "ELSE " & _
                      "CAST((DATEDIFF(MONTH, Hired_Date, GETDATE()) " & _
                      "- CASE WHEN DAY(Hired_Date) > DAY(GETDATE()) THEN 1 ELSE 0 END) / 12 AS VARCHAR) " & _
                      "+ ' year' " & _
                      "+ CASE WHEN (DATEDIFF(MONTH, Hired_Date, GETDATE()) " & _
                      "- CASE WHEN DAY(Hired_Date) > DAY(GETDATE()) THEN 1 ELSE 0 END) / 12 = 1 " & _
                      "THEN '' ELSE 's' END " & _
                      "+ CASE WHEN (DATEDIFF(MONTH, Hired_Date, GETDATE()) " & _
                      "- CASE WHEN DAY(Hired_Date) > DAY(GETDATE()) THEN 1 ELSE 0 END) % 12 = 0 " & _
                      "THEN '' " & _
                      "ELSE ' and ' " & _
                      "+ CAST((DATEDIFF(MONTH, Hired_Date, GETDATE()) " & _
                      "- CASE WHEN DAY(Hired_Date) > DAY(GETDATE()) THEN 1 ELSE 0 END) % 12 AS VARCHAR) " & _
                      "+ ' month' " & _
                      "+ CASE WHEN (DATEDIFF(MONTH, Hired_Date, GETDATE()) " & _
                      "- CASE WHEN DAY(Hired_Date) > DAY(GETDATE()) THEN 1 ELSE 0 END) % 12 = 1 " & _
                      "THEN '' ELSE 's' END " & _
                      "END " & _
                      "END as Tenure, " & _
                      "DATEDIFF(YEAR, Date_of_Birth, GETDATE()) " & _
                      "- CASE " & _
                      "WHEN DATEADD(YEAR, DATEDIFF(YEAR, Date_of_Birth, GETDATE()), Date_of_Birth) > CAST(GETDATE() AS DATE) " & _
                      "THEN 1 ELSE 0 " & _
                      "END AS Age, " & _
                      "Gender " & _
                      "from Incident " & _
                      "inner join Employees on Employees.Employee_ID = Incident.Reported_By_Employee_ID " & _
                      "where Incident_ID = '" & Incident_ID & "';"
            ExecuteSQLQuery(sqlSTR)
            Incidents = sqlDT.Copy()
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Incidents", Incidents))


            sqlSTR = "SELECT Incident_Employees_ID " & _
                   ",Incident_ID " & _
                   ",Employees.Employee_ID " & _
                   ",CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') as Employee_Involved " & _
                   ",Employee_Job_Title " & _
                   ",Employee_Department " & _
                   ",Employee_Tenure " & _
                   ",Employee_Age " & _
                   ",Employee_Supervisor " & _
                   ",Employee_Incident_Statement " & _
                   "FROM Incident_Details_Employees " & _
                   "INNER JOIN Employees on Employees.Employee_ID = Incident_Details_Employees.Employee_ID " & _
                   "where Incident_ID = '" & Incident_ID & "' " & _
                   "Order by Employee_Involved;"
            ExecuteSQLQuery(sqlSTR)
            Incident_Details_Employees = sqlDT.Copy()
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Incident_Details_Employees", Incident_Details_Employees))

            

            sqlSTR = "SELECT " & _
                    "CONCAT(ROW_NUMBER() OVER (ORDER BY TRIM(Last_name)), '. ', " & _
                    "CONCAT(TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '. ', TRIM(Last_name)), " & _
                    "' incurred ', " & _
                    "Offense_Class, " & _
                    "' offense for ', " & _
                    "Offense_Category, " & _
                    "' – ', " & _
                    "Offense_Definition, " & _
                    "' (', " & _
                    "Offense_Instance, " & _
                    "' Instance).' " & _
                    ") AS Offenses " & _
                    "FROM Incident_Details_Offenses " & _
                    "inner join Employees on Employees.Employee_ID = Incident_Details_Offenses.Employee_ID " & _
                    "where Incident_ID = '" & Incident_ID & "' " & _
                    "order by TRIM(Last_name);"
            ExecuteSQLQuery(sqlSTR)
            Incident_Details_Offenses = sqlDT.Copy()
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Incident_Details_Offenses", Incident_Details_Offenses))

            sqlSTR = "SELECT " & _
                    "CONCAT( " & _
                    "CONCAT(ROW_NUMBER() OVER (ORDER BY TRIM(Last_name)), '. '), " & _
                    "Decided_By, " & _
                    "' issued ', " & _
                    "Action_Taken, " & _
                    "' (', " & _
                    "Action_Details, " & _
                    "') for ', " & _
                    "TRIM(First_Name), " & _
                    "CASE " & _
                    "WHEN TRIM(ISNULL(Middle_Name, '')) <> '' " & _
                    "THEN CONCAT(' ', LEFT(TRIM(Middle_Name), 1), '.') " & _
                    "ELSE '' " & _
                    "END, " & _
                    "' ', " & _
                    "TRIM(Last_Name), " & _
                    "' on ', " & _
                    "FORMAT(TRY_CAST(Action_Decision_Date AS DATE), 'MM/dd/yyyy'), " & _
                    "CASE " & _
                    "WHEN Action_Taken = 'No Action Required' " & _
                    "THEN '.' " & _
                    "ELSE CONCAT( " & _
                    "', effective ', " & _
                    "FORMAT(TRY_CAST(Action_Start_Date AS DATE), 'MM/dd/yyyy'), " & _
                    "' through ', " & _
                    "FORMAT(TRY_CAST(Action_End_Date AS DATE), 'MM/dd/yyyy'), " & _
                    "'.' " & _
                    ") " & _
                    "END " & _
                    ") AS Action_Taken " & _
                    "FROM Incident_Details_Actions " & _
                    "INNER JOIN Employees ON Employees.Employee_ID = Incident_Details_Actions.Employee_ID " & _
                    "where Incident_ID = '" & Incident_ID & "' " & _
                    "ORDER BY TRIM(Last_Name);"
            ExecuteSQLQuery(sqlSTR)
            Incident_Details_Actions = sqlDT.Copy()
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Incident_Details_Actions", Incident_Details_Actions))


            

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