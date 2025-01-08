Public Class FormLOANS

    Private Sub FormLOANS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = MDIMain.Panel2.Height - 22
        Me.Width = MDIMain.Panel2.Width

        lst_loans.Width = Me.Width - 20
        lst_loans.Height = Me.Height - 120

        rb_Active.Checked = True

        RefreshLoansList()
    End Sub

    Private Sub RefreshLoansList()
        Dim status As String = ""
        If rb_All.Checked Then
            status = ""
        ElseIf rb_Active.Checked Then
            status = "Active"
        ElseIf rb_Paid.Checked Then
            status = "Paid"
        End If


        sqlSTR = "SELECT Loans.Loan_ID AS 'Loan ID', MAX(Loans.Employee_ID) AS 'Employee ID', MAX(CONCAT(Last_Name, ', ', First_Name)) AS Employee, " & _
                    "MAX(Loan_Date) AS 'Loan Date', MAX(Loan_Type) AS 'Loan Type', FORMAT(MAX(Loan_Net_Amount), 'N2') AS 'Loan Net', MAX(CONCAT(Loan_Interest_Rate, '%')) AS 'Interest Rate', " & _
                    "FORMAT(MAX(Loan_Gross_Amount), 'N2') AS 'Loan Gross', FORMAT(max(Loan_Gross_Amount) - sum(case when Payment_Posted = 'Yes' then COALESCE(Gross_Payment, 0) else 0 end), 'N2') as 'Loan Balance', " & _
                    "MAX(Loan_Payment_Start_Date) AS 'Loan Payment Start Date', MAX(Loan_Payment_End_Date) AS 'Loan Payment End Date', " & _
                    "MAX(Loan_Reason) AS 'Loan Reason', MAX(Loan_Remarks) AS 'Loan Remarks', MAX(Loan_Status) AS 'Loan Status' " & _
                    "FROM Loans " & _
                    "LEFT JOIN Loan_Payments ON Loan_Payments.Loan_ID = Loans.Loan_ID " & _
                    "INNER JOIN Employees ON Employees.Employee_ID = Loans.Employee_ID " & _
                    "WHERE Loan_Status LIKE '%" & status & "%' " & _
                    "GROUP BY Loans.Loan_ID " & _
                    "ORDER BY MAX(Last_Name), MAX(First_Name), MAX(Loan_Date);"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_loans, 0)
    End Sub

    Private Sub btn_newLoan_Click(sender As Object, e As EventArgs) Handles btn_newLoan.Click
        FormLOAN_NEW.ShowDialog()
        RefreshLoansList()
    End Sub

    Private Sub EditEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEmployeeToolStripMenuItem.Click
        ShowForm1(FormLOAN_EDIT, "edit", lst_loans.FocusedItem.Text)
        RefreshLoansList()
    End Sub

    Private Sub lst_loans_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_loans.MouseDoubleClick
        ShowForm1(FormLOAN_EDIT, "edit", lst_loans.FocusedItem.Text)
        RefreshLoansList()
    End Sub

    Private Sub DeleteEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeToolStripMenuItem.Click
        sqlSTR = "select Loan_Payment_ID from Loan_Payments where loan_id =" & lst_loans.FocusedItem.Text
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            MsgBox("The loan record cannot be deleted because there are active payments associated with it.", MsgBoxStyle.Critical, msgBox_header)
            Exit Sub
        End If

        sqlSTR = "Delete from Loans where Loan_ID =" & lst_loans.FocusedItem.Text
        ExecuteSQLQuery(sqlSTR)
        MsgBox("Deleted loan record.", MsgBoxStyle.Information, msgBox_header)
        RefreshLoansList()
    End Sub

    Private Sub rb_All_CheckedChanged(sender As Object, e As EventArgs) Handles rb_All.CheckedChanged
        RefreshLoansList()
    End Sub

    Private Sub rb_Active_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Active.CheckedChanged
        RefreshLoansList()
    End Sub

    Private Sub rb_Paid_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Paid.CheckedChanged
        RefreshLoansList()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        searchBox.Visible = True
        txt_search.Text = ""
        txt_search.Focus()
        CenterGroupBoxRelativeToListView(searchBox, lst_loans)
    End Sub

    Private Sub SearchLoan()
        rb_All.Checked = False
        rb_Active.Checked = False
        rb_Paid.Checked = False

        sqlSTR = "SELECT Loans.Loan_ID AS 'Loan ID', MAX(Loans.Employee_ID) AS 'Employee ID', MAX(CONCAT(Last_Name, ', ', First_Name)) AS Employee, " & _
                    "MAX(Loan_Date) AS 'Loan Date', MAX(Loan_Type) AS 'Loan Type', FORMAT(MAX(Loan_Net_Amount), 'N2') AS 'Loan Net', MAX(CONCAT(Loan_Interest_Rate, '%')) AS 'Interest Rate', " & _
                    "FORMAT(MAX(Loan_Gross_Amount), 'N2') AS 'Loan Gross', FORMAT(max(Loan_Gross_Amount) - sum(case when Payment_Posted = 'Yes' then COALESCE(Gross_Payment, 0) else 0 end), 'N2') as 'Loan Balance', " & _
                    "MAX(Loan_Payment_Start_Date) AS 'Loan Payment Start Date', MAX(Loan_Payment_End_Date) AS 'Loan Payment End Date', " & _
                    "MAX(Loan_Reason) AS 'Loan Reason', MAX(Loan_Remarks) AS 'Loan Remarks', MAX(Loan_Status) AS 'Loan Status' " & _
                    "FROM Loans " & _
                    "LEFT JOIN Loan_Payments ON Loan_Payments.Loan_ID = Loans.Loan_ID " & _
                    "INNER JOIN Employees ON Employees.Employee_ID = Loans.Employee_ID " & _
                    "WHERE CONCAT(Loans.Loan_ID, ' ', Loans.Employee_ID, ' ', Last_Name, ' ', First_Name)  LIKE '%" & txt_search.Text & "%' " & _
                    "GROUP BY Loans.Loan_ID " & _
                    "ORDER BY MAX(Loan_Date), MAX(Last_Name), MAX(First_Name);"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_loans, 0)
    End Sub

    Private Sub btn_searchSubmit_Click(sender As Object, e As EventArgs) Handles btn_searchSubmit.Click
        SearchLoan()
        searchBox.Visible = False

    End Sub

    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = 13 Then
            SearchLoan()
            searchBox.Visible = False
        End If
    End Sub

    Private Sub btn_searchCancel_Click(sender As Object, e As EventArgs) Handles btn_searchCancel.Click
        searchBox.Visible = False
    End Sub
End Class