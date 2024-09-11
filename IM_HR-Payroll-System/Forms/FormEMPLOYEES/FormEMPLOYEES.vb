Public Class FormEMPLOYEES

    Private Sub FormEMPLOYEES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = MDIMain.Panel2.Height - 22
        Me.Width = MDIMain.Panel2.Width

        lst_employees.Width = Me.Width - 20
        lst_employees.Height = Me.Height - 120

        RefreshEmployeeList()
    End Sub


    Private Sub btn_newEmployee_Click(sender As Object, e As EventArgs) Handles btn_newEmployee.Click
        ShowForm1(FormEMPLOYEES_DETAILS, "add", 0)
        RefreshEmployeeList()
    End Sub

    Public Sub RefreshEmployeeList()
        sqlSTR = "SELECT Employee_ID AS 'Employee ID', Last_Name AS 'Last Name', First_Name AS 'First Name', " & _
    "Middle_Name AS 'Middle Name', Date_of_Birth AS 'Date of Birth', Gender AS 'Gender', " & _
    "Civil_Status AS 'Civil Status', Address AS 'Address', Contact_No AS 'Contact No', " & _
    "Emergency_Contact_Person AS 'Emergency Contact Person', Emergency_Relationship AS 'Emergency Relationship', " & _
    "Emergency_Address AS 'Emergency Address', Emergency_Contact_No AS 'Emergency Contact No', " & _
    "Payroll_Account_Number AS 'Bank Account Number', SSS_No AS 'SSS No', Philhealth_No AS 'Philhealth No', " & _
    "TIN_No AS 'TIN No', Pag_ibig_No AS 'Pag-ibig No', Hired_Date AS 'Hired Date', Employment_Status AS 'Employment Status', " & _
    "Regularization_Date AS 'Regularization Date', Position AS 'Position', Department AS 'Department', Division AS 'Division', " & _
    "Starting_Daily_Rate AS 'Starting Daily Rate', Current_Daily_Rate AS 'Current Daily Rate', Monthly_Salary AS 'Monthly Salary', " & _
    "No_of_Work_Days_per_Month AS 'Work Days/Month' FROM EMPLOYEES"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_employees, 0)
    End Sub


    Public Sub SearchEmployeeList()
        sqlSTR = "SELECT Employee_ID AS 'Employee ID', Last_Name AS 'Last Name', First_Name AS 'First Name', " & _
    "Middle_Name AS 'Middle Name', Date_of_Birth AS 'Date of Birth', Gender AS 'Gender', " & _
    "Civil_Status AS 'Civil Status', Address AS 'Address', Contact_No AS 'Contact No', " & _
    "Emergency_Contact_Person AS 'Emergency Contact Person', Emergency_Relationship AS 'Emergency Relationship', " & _
    "Emergency_Address AS 'Emergency Address', Emergency_Contact_No AS 'Emergency Contact No', " & _
    "Payroll_Account_Number AS 'Bank Account Number', SSS_No AS 'SSS No', Philhealth_No AS 'Philhealth No', " & _
    "TIN_No AS 'TIN No', Pag_ibig_No AS 'Pag-ibig No', Hired_Date AS 'Hired Date', Employment_Status AS 'Employment Status', " & _
    "Regularization_Date AS 'Regularization Date', Position AS 'Position', Department AS 'Department', Division AS 'Division', " & _
    "Starting_Daily_Rate AS 'Starting Daily Rate', Current_Daily_Rate AS 'Current Daily Rate', Monthly_Salary AS 'Monthly Salary', " & _
    "No_of_Work_Days_per_Month AS 'Work Days/Month' FROM EMPLOYEES " & _
    "WHERE CONCAT(Employee_ID, ' ', Last_Name, ' ', First_Name, ' ', Middle_Name, ' ', Civil_Status, ' ', " & _
    "Gender, ' ', Address, ' ', Contact_No, ' ', Emergency_Contact_Person, ' ',  Employment_Status, ' ', " & _
    "Emergency_Address, ' ', Emergency_Contact_No, ' ', Payroll_Account_Number, ' ', Position, ' ', " & _
    "Department, ' ', Division, ' ', SSS_No, ' ', Philhealth_No, ' ', TIN_No, ' ', Pag_ibig_No) LIKE '%" & txt_search.Text & "%' and Employment_Status like '%" & cmb_employmentStatus.Text & "%'"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_employees, 0)
    End Sub

    Private Sub EditEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEmployeeToolStripMenuItem.Click
        ShowForm1(FormEMPLOYEES_DETAILS, "edit", lst_employees.FocusedItem.Text)
        RefreshEmployeeList()
    End Sub

    Private Sub DeleteEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeToolStripMenuItem.Click
        If MsgBox("Do you want to delete this employee record?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, msgBox_header) = MsgBoxResult.Yes Then
            sqlSTR = "Delete from Employees where Employee_ID =" & lst_employees.FocusedItem.Text
            ExecuteSQLQuery(sqlSTR)

            MsgBox("Delete employee record.", MsgBoxStyle.Information, msgBox_header)
        End If
    End Sub




    Private Sub cmb_employmentStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_employmentStatus.SelectedIndexChanged
        SearchEmployeeList()
    End Sub

    Private Sub btn_searchSubmit_Click(sender As Object, e As EventArgs) Handles btn_searchSubmit.Click
        SearchEmployeeList()

        searchBox.Visible = False
    End Sub

    Private Sub btn_searchCancel_Click(sender As Object, e As EventArgs) Handles btn_searchCancel.Click
        searchBox.Visible = False
    End Sub

    Private Sub btn_searchEmployee_Click(sender As Object, e As EventArgs) Handles btn_searchEmployee.Click
        searchBox.Visible = True
        txt_search.Text = ""
        CenterGroupBoxRelativeToListView(searchBox, lst_employees)
    End Sub
End Class