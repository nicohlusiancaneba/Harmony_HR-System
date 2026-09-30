Public Class FrmADJUSTMENTS
    Public whereSQL, formAction, Adjustment_ID As String
    Private Sub FrmADJUSTMENTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        whereSQL = " and ((Year(Date_Adjusted) = Year(GETDATE()) and Month(Date_Adjusted) = Month(GETDATE())) or Adj_Approved = 'No') "
        Refresh_List()
    End Sub

    Public Sub Refresh_List()
        sqlSTR = "SELECT " & _
                "Adjustment_ID as ID, " & _
                "Employees.Employee_ID as 'Employee ID', " & _
                "CONCAT(Last_Name, ', ', First_Name, ' ', left(Middle_Name, 1), '.') as 'Employee', " & _
                "Adjustment_Type as 'Adjustment Type', " & _
                "CASE WHEN TRY_CONVERT(decimal(18,4), Prev_Value) IS NOT NULL " & _
                    "THEN CONVERT(varchar(50), CONVERT(money, TRY_CONVERT(decimal(18,4), Prev_Value)), 1) " & _
                    "ELSE Prev_Value " & _
                "END AS 'Previous Value', " & _
                "CASE WHEN TRY_CONVERT(decimal(18,4), New_Value) IS NOT NULL " & _
                    "THEN CONVERT(varchar(50), CONVERT(money, TRY_CONVERT(decimal(18,4), New_Value)), 1) " & _
                    "ELSE New_Value " & _
                "END AS 'New Value', " & _
                "Remarks, " & _
                "Encoded_by as 'Encoded by', " & _
                "Adj_Approved as 'Approved', " & _
                "Date_Adjusted as 'Date Adjusted', " & _
                "Approved_by as 'Approved by' " & _
                "FROM Adjustments " & _
                "inner join Employees on Employees.Employee_ID = Adjustments.Employee_ID " & _
                "where 1=1 " & whereSQL & _
                "order by Adj_Approved, Adjustment_Type, Last_Name, First_Name"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_adjustments, Main.sidebar_images, 4)

        For Each item As ListViewItem In lst_adjustments.Items
            If item.SubItems(8).Text = "No" Then
                item.ForeColor = Color.Red
            Else
                item.ForeColor = Color.Black
            End If
        Next
    End Sub

    Private Sub lst_adjustments_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_adjustments.MouseDoubleClick

        lst_adjustments.Focus()
        If lst_adjustments.Items.Count > 0 Then
            formAction = "edit"
            Adjustment_ID = lst_adjustments.FocusedItem.Text
            FrmADJUSTMENT_DETAILS.ShowDialog()
            Refresh_List()
        End If

    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        grpFilter.Visible = False



        checkbox_CheckedValue(cb_employeeID, " and Employees.Employee_ID = '" & txt_employeeID.Text & "' ")
        checkbox_CheckedValue(cb_name, " and CONCAT(TRIM(Last_Name), ' ', TRIM(First_Name), ' ', TRIM(Middle_Name)) like '%" & txt_name.Text & "%' ")
        checkbox_CheckedValue(cb_Type, " and Adjustment_Type = '" & cmb_type.Text & "' ")
        checkbox_CheckedValue(cb_adjustmentDate, " and Date_Adjusted between '" & dt_fromAdjustment.Text & "' and '" & dt_toAdjustment.Text & "' ")
        checkbox_CheckedValue(cb_remarks, " and Remarks like '%" & txt_remarks.Text & "%' ")
        checkbox_CheckedValue(cb_Approved, " and COALESCE(Adj_Approved, 'No') = '" & cmb_approved.Text & "' ")


        whereSQL = cb_employeeID.Tag & cb_name.Tag & cb_Type.Tag & cb_adjustmentDate.Tag & cb_remarks.Tag & cb_Approved.Tag

        If whereSQL = "" Then
            MsgBox("Search filter too broad. Try again.")
            Exit Sub
        End If



        Refresh_List()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        grpFilter.Visible = False
    End Sub
End Class