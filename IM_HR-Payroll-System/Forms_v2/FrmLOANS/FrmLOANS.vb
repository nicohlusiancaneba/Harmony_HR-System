Public Class FrmLOANS
    Public whereSQL, Loan_ID As String
    Private Sub FrmLOANS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        whereSQL = " and Loan_Status = 'Active' "

        Refresh_List()
    End Sub


    Public Sub Refresh_List()
        sqlSTR = "SELECT " & _
                "Loans.Loan_ID AS 'Loan ID', " & _
                "MAX(Loans.Employee_ID) AS 'Employee ID', " & _
                "MAX(CONCAT(Last_Name, ', ', First_Name, ' ', LEFT(Middle_Name,1), '.')) AS Employee, " & _
                "MAX(Loan_Date) AS 'Loan Date', " & _
                "MAX(Loan_Type) AS 'Loan Type', " & _
                "FORMAT(MAX(Loan_Net_Amount), 'N2') AS 'Loan Net', " & _
                "MAX(CONCAT(Loan_Interest_Rate, '%')) AS 'Interest Rate', " & _
                "FORMAT(MAX(Loan_Gross_Amount), 'N2') AS 'Loan Gross', " & _
                "CONCAT(MAX(Loan_Payment_Start_Date), ' to ', MAX(Loan_Payment_End_Date)) AS 'Loan Payment Schedule', " & _
                "FORMAT(max(Loan_Gross_Amount) - sum(case when Payment_Posted = 'Yes' then COALESCE(Gross_Payment, 0) else 0 end), 'N2') as 'Loan Balance', " & _
                "MAX(Loan_Reason) AS 'Loan Reason', " & _
                "MAX(Loan_Remarks) AS 'Loan Remarks', " & _
                "MAX(Loan_Status) AS 'Loan Status' " & _
                "FROM Loans " & _
                "LEFT JOIN Loan_Payments ON Loan_Payments.Loan_ID = Loans.Loan_ID " & _
                "INNER JOIN Employees ON Employees.Employee_ID = Loans.Employee_ID " & _
                "WHERE 1=1 " & whereSQL & _
                "GROUP BY Loans.Loan_ID " & _
                "ORDER BY MAX(Last_Name), MAX(First_Name), MAX(Loan_Date);"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_loans, Main.sidebar_images, 5)

    End Sub

    Private Sub lst_loans_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_loans.MouseDoubleClick
        lst_loans.Focus()
        If lst_loans.Items.Count > 0 Then
            Loan_ID = lst_loans.FocusedItem.Text
            FrmLOAN_EDIT.ShowDialog()
            Refresh_List()
        End If

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        grpFilter.Visible = False
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        grpFilter.Visible = False

        checkbox_CheckedValue(cb_employeeID, " and Employees.Employee_ID = '" & txt_employeeID.Text & "' ")
        checkbox_CheckedValue(cb_name, " and CONCAT(Last_Name, ' ', First_Name, ' ', Middle_Name) like '%" & txt_name.Text & "%' ")
        checkbox_CheckedValue(cb_loanDate, " and Loan_Date between '" & dt_fromLoan.Text & "' and '" & dt_toLoan.Text & "' ")
        checkbox_CheckedValue(cb_paymentSchedule, " and Loan_Payment_Start_Date >= '" & dt_fromSched.Text & "' and Loan_Payment_End_Date <= '" & dt_toSched.Text & "' ")
        checkbox_CheckedValue(cb_loanReason, " and Loan_Reason like '%" & txt_reason.Text & "%' ")
        checkbox_CheckedValue(cb_loanType, " and Loan_Type = '" & cmb_type.Text & "' ")
        checkbox_CheckedValue(cb_status, " and Loan_Status = '" & cmb_status.Text & "' ")

        whereSQL = cb_employeeID.Tag & cb_name.Tag & cb_loanDate.Tag & cb_paymentSchedule.Tag & cb_loanReason.Tag & cb_loanType.Tag & cb_status.Tag

        If whereSQL = "" Then Exit Sub

        Refresh_List()
    End Sub
End Class