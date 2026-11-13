Imports System.IO

Public Class FrmEMPLOYEES
    Public whereSQL, formAction As String
    Private Sub FrmEMPLOYEES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeHelper.ApplyHighlight(Me)

        FILLComboBox2("select Dropdown_ID, Dropdown_Description from Dropdowns where Dropdown_Type = 'Department' order by Dropdown_Description", cmb_department)

        whereSQL = " and Employment_Status != 'Terminated' and Employment_Status != 'Resigned' "
        Refresh_List()
    End Sub


    'Public Sub Refresh_List()
    '    sqlSTR = "SELECT " & _
    '            "ROW_NUMBER() OVER (ORDER BY Employees.Last_Name, Employees.First_Name) AS Num, " & _
    '            "Employees.Employee_ID, " & _
    '            "Employees.Last_Name, " & _
    '            "Employees.First_Name, " & _
    '            "Employees.Middle_Name, " & _
    '            "Employees.Employment_Status, " & _
    '            "Employees.Position, " & _
    '            "Employees.Department, " & _
    '            "Employees.Date_of_Birth, " & _
    '            "File_Docs.File_Data AS Employee_Picture, " & _
    '            "Employees.Hired_Date " & _
    '            "FROM Employees " & _
    '            "LEFT JOIN File_Docs " & _
    '            "ON File_Docs.Employee_ID = Employees.Employee_ID " & _
    '            "AND File_Docs.File_type = 'Picture' " & _
    '            " where 1=1 " & whereSQL & _
    '            "ORDER BY Employees.Last_Name, Employees.First_Name;"
    '    ExecuteSQLQuery(sqlSTR)

    '    dgv_employees.Rows.Clear()
    '    If sqlDT.Rows.Count > 0 Then
    '        For i = 0 To sqlDT.Rows.Count - 1
    '            Dim img As Image = Nothing
    '            If sqlDT.Rows(i)("Employee_Picture") IsNot DBNull.Value Then
    '                Dim imgBytes() As Byte = CType(sqlDT.Rows(i)("Employee_Picture"), Byte())
    '                Using ms As New MemoryStream(imgBytes)
    '                    img = Image.FromStream(ms)
    '                End Using

    '                img = ResizeImage(img, 100)
    '            End If


    '            dgv_employees.Rows.Add(
    '                sqlDT.Rows(i)("Num"),
    '                sqlDT.Rows(i)("Employee_ID"),
    '                img,
    '                sqlDT.Rows(i)("Last_Name"),
    '                sqlDT.Rows(i)("First_Name"),
    '                sqlDT.Rows(i)("Middle_Name"),
    '                sqlDT.Rows(i)("Employment_Status"),
    '                sqlDT.Rows(i)("Position"),
    '                sqlDT.Rows(i)("Department"),
    '                sqlDT.Rows(i)("Date_of_Birth"),
    '                sqlDT.Rows(i)("Hired_Date")
    '            )
    '        Next
    '    End If



    'End Sub


    Public Sub Refresh_List()
        sqlSTR = "SELECT " & _
                "ROW_NUMBER() OVER (ORDER BY Employees.Last_Name, Employees.First_Name) AS '#', " & _
                "Employees.Employee_ID as 'ID', " & _
                "Employees.Last_Name as 'Last Name', " & _
                "Employees.First_Name as 'First Name', " & _
                "Employees.Middle_Name as 'Middle Name', " & _
                "Employees.Employment_Status as 'Employment Status', " & _
                "Employees.Position as 'Job Position', " & _
                "Employees.Department as Department, " & _
                "Employees.Date_of_Birth as 'Birthday', " & _
                "Employees.Hired_Date as 'Hired Date' " & _
                "FROM Employees " & _
                " where 1=1 " & whereSQL & _
                "ORDER BY Employees.Last_Name, Employees.First_Name;"
        FillListView(ExecuteSQLQuery(sqlSTR), lst_employees, Main.sidebar_images, 0)

        


    End Sub

    'Private Sub dgv_users_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv_employees.MouseDoubleClick
    '    dgv_employees.Focus()
    '    If dgv_employees.Rows.Count > 0 Then
    '        formAction = "edit"
    '        FrmEMPLOYEE_DETAILS.ShowDialog()
    '        Refresh_List()
    '    End If


    'End Sub

    Private Sub lst_employees_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_employees.MouseDoubleClick

        lst_employees.Focus()
        If lst_employees.Items.Count > 0 Then
            formAction = "edit"
            FrmEMPLOYEE_DETAILS.ShowDialog()
            Refresh_List()
        End If
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        checkbox_CheckedValue(cb_employeeID, " and Employees.Employee_ID = '" & txt_employeeID.Text & "' ")
        checkbox_CheckedValue(cb_name, " and CONCAT(First_Name, ' ', Middle_Name, ' ', Last_Name) like '%" & txt_name.Text & "%' ")
        checkbox_CheckedValue(cb_gender, " and Gender = '" & cmb_gender.Text & "' ")
        checkbox_CheckedValue(cb_civilStatus, " and Civil_Status = '" & cmb_civilStatus.Text & "' ")
        checkbox_CheckedValue(cb_hiredDate, " and Hired_Date between '" & dt_fromHired.Text & "' and '" & dt_toHired.Text & "' ")
        checkbox_CheckedValue(cb_regularization, " and Regularization_Date between '" & dt_fromRegular.Text & "' and '" & dt_toRegular.Text & "' ")
        checkbox_CheckedValue(cb_position, " and Position like '%" & txt_position.Text & "%' ")
        checkbox_CheckedValue(cb_department, " and Department = '" & cmb_department.Text & "' ")
        checkbox_CheckedValue(cb_status, " and Employment_Status = '" & cmb_status.Text & "' ")


        whereSQL = cb_employeeID.Tag & cb_name.Tag & cb_gender.Tag & cb_civilStatus.Tag & cb_hiredDate.Tag & cb_regularization.Tag & cb_position.Tag & cb_department.Tag & cb_status.Tag

        If whereSQL = "" Then
            MsgBox("Search filter too broad. Try again.")
            Exit Sub
        End If

        Refresh_List()



        grpFilter.Visible = False
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        grpFilter.Visible = False
    End Sub
End Class