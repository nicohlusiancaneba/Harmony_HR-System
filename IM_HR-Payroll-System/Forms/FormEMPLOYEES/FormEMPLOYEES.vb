Public Class FormEMPLOYEES

    Private Sub FormEMPLOYEES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = MDIMain.Panel2.Height - 22
        Me.Width = MDIMain.Panel2.Width

        lst_employees.Width = Me.Width - 20
        lst_employees.Height = Me.Height - 120

        rb_All.Checked = True
        'RefreshEmployeeList()
    End Sub


    Private Sub btn_newEmployee_Click(sender As Object, e As EventArgs) Handles btn_newEmployee.Click
        ShowForm1(FormEMPLOYEES_DETAILS, "add", 0)
        RefreshEmployeeList()
    End Sub

    Public Sub RefreshEmployeeList()
        Dim status As String
        If rb_All.Checked Then
            status = ""
        ElseIf rb_Regular.Checked Then
            status = "Regular"
        ElseIf rb_Outsource.Checked Then
            status = "Outsource"
        ElseIf rb_Probationary.Checked Then
            status = "Probationary"
        ElseIf rb_Terminated.Checked Then
            status = "Terminated"
        ElseIf rb_Resigned.Checked Then
            status = "Resigned"
        Else
            Exit Sub
        End If


        sqlSTR = "SELECT Employee_ID AS 'Employee ID', Last_Name AS 'Last Name', First_Name AS 'First Name', " & _
    "Middle_Name AS 'Middle Name', Date_of_Birth AS 'Date of Birth', Gender AS 'Gender', " & _
    "Civil_Status AS 'Civil Status', Address AS 'Address', Contact_No AS 'Contact No', " & _
    "Emergency_Contact_Person AS 'Emergency Contact Person', Emergency_Relationship AS 'Emergency Relationship', " & _
    "Emergency_Address AS 'Emergency Address', Emergency_Contact_No AS 'Emergency Contact No', " & _
    "Payroll_Account_Number AS 'Bank Account Number', SSS_No AS 'SSS No', Philhealth_No AS 'Philhealth No', " & _
    "TIN_No AS 'TIN No', Pag_ibig_No AS 'Pag-ibig No', Hired_Date AS 'Hired Date', Employment_Status AS 'Employment Status', " & _
    "Regularization_Date AS 'Regularization Date', Position AS 'Position', Department AS 'Department', Division AS 'Division', " & _
    "No_of_Work_Days_per_Month AS 'Work Days/Month' FROM EMPLOYEES where Employment_Status Like '%" & status & "%' order by Employee_ID"

        FillListView(ExecuteSQLQuery(sqlSTR), lst_employees, 0)
    End Sub


    Public Sub SearchEmployeeList()
        rb_All.Checked = False
        rb_Outsource.Checked = False
        rb_Probationary.Checked = False
        rb_Regular.Checked = False
        rb_Resigned.Checked = False
        rb_Terminated.Checked = False
        lst_employees.Clear()


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
    "Department, ' ', Division, ' ', SSS_No, ' ', Philhealth_No, ' ', TIN_No, ' ', Pag_ibig_No) LIKE '%" & txt_search.Text & "%' order by Employee_ID"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_employees, 0)
    End Sub

    Private Sub EditEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEmployeeToolStripMenuItem.Click
        ShowForm1(FormEMPLOYEES_DETAILS, "edit", lst_employees.FocusedItem.Text)
        RefreshEmployeeList()
    End Sub

    Private Sub lst_employees_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_employees.MouseDoubleClick
        ShowForm1(FormEMPLOYEES_DETAILS, "edit", lst_employees.FocusedItem.Text)
        RefreshEmployeeList()
    End Sub

    Private Sub DeleteEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeToolStripMenuItem.Click
        If MsgBox("Do you want to delete this employee record?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, msgBox_header) = MsgBoxResult.Yes Then
            sqlSTR = "Delete from Employees where Employee_ID =" & lst_employees.FocusedItem.Text
            ExecuteSQLQuery(sqlSTR)

            MsgBox("Deleted employee record.", MsgBoxStyle.Information, msgBox_header)
        End If
        RefreshEmployeeList()
    End Sub




    Private Sub cmb_employmentStatus_SelectedIndexChanged(sender As Object, e As EventArgs)
        SearchEmployeeList()
    End Sub

    Private Sub btn_searchSubmit_Click(sender As Object, e As EventArgs) Handles btn_searchSubmit.Click
        SearchEmployeeList()
        searchBox.Visible = False
    End Sub

    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = 13 Then
            SearchEmployeeList()
            searchBox.Visible = False
        End If
    End Sub

    Private Sub btn_searchCancel_Click(sender As Object, e As EventArgs) Handles btn_searchCancel.Click
        searchBox.Visible = False
    End Sub

    Private Sub btn_searchEmployee_Click(sender As Object, e As EventArgs) Handles btn_searchEmployee.Click
        searchBox.Visible = True
        txt_search.Text = ""
        txt_search.Focus()
        CenterGroupBoxRelativeToListView(searchBox, lst_employees)
    End Sub

    Private Sub rb_All_CheckedChanged(sender As Object, e As EventArgs) Handles rb_All.CheckedChanged
        RefreshEmployeeList()
    End Sub

    Private Sub rb_Regular_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Regular.CheckedChanged
        RefreshEmployeeList()
    End Sub

    Private Sub rb_Probationary_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Probationary.CheckedChanged
        RefreshEmployeeList()
    End Sub

    Private Sub rb_Outsource_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Outsource.CheckedChanged
        RefreshEmployeeList()
    End Sub

    Private Sub rb_Resigned_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Resigned.CheckedChanged
        RefreshEmployeeList()
    End Sub

    Private Sub rb_Terminated_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Terminated.CheckedChanged
        RefreshEmployeeList()
    End Sub
End Class