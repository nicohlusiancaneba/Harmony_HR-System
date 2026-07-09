Public Class FrmEMPLOYEES
    Public whereSQL, formAction As String
    Private Sub FrmEMPLOYEES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        whereSQL = " and Employment_Status != 'Terminated' and Employment_Status != 'Resigned' "
        Refresh_List()
    End Sub


    Private Sub Refresh_List()
        sqlSTR = "select " & _
                "ROW_NUMBER() OVER (ORDER BY Last_Name, First_Name) AS Num, " & _
                "Employee_ID, " & _
                "Last_Name, " & _
                "First_Name, " & _
                "Middle_Name, " & _
                "Employment_Status, " & _
                "Position, " & _
                "Department, " & _
                "Date_of_Birth, " & _
                "Hired_Date from Employees " & _
                " where 1=1 " & whereSQL & _
                "Order by Last_Name, First_Name;"
        ExecuteSQLQuery(sqlSTR)

        dgv_employees.Rows.Clear()
        If sqlDT.Rows.Count > 0 Then
            For i = 0 To sqlDT.Rows.Count - 1
                dgv_employees.Rows.Add(
                    sqlDT.Rows(i)("Num"),
                    sqlDT.Rows(i)("Employee_ID"),
                    sqlDT.Rows(i)("Last_Name"),
                    sqlDT.Rows(i)("First_Name"),
                    sqlDT.Rows(i)("Middle_Name"),
                    sqlDT.Rows(i)("Employment_Status"),
                    sqlDT.Rows(i)("Position"),
                    sqlDT.Rows(i)("Department"),
                    sqlDT.Rows(i)("Date_of_Birth"),
                    sqlDT.Rows(i)("Hired_Date")
                )
            Next
        End If

    End Sub

    Private Sub dgv_users_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv_employees.MouseDoubleClick
        dgv_employees.Focus()
        If dgv_employees.Rows.Count > 0 Then
            formAction = "edit"
            FrmEMPLOYEE_DETAILS.ShowDialog()
            Refresh_List()
        End If
    End Sub

End Class