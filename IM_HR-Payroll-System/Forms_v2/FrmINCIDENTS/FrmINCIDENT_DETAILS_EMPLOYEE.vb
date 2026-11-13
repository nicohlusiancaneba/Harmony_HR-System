Public Class FrmINCIDENT_DETAILS_EMPLOYEE
    Dim edit, formLoaded As Boolean
    Private Sub FrmINCIDENT_DETAILS_EMPLOYEE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeHelper.ApplyHighlight(Me)
        edit = FrmINCIDENT_DETAILS.edit

        inputText_ChangedHandler(Me)
        inputNum_ChangedHandler(Me)
        ClearGroupBoxInputs(grpEmployees)

        formLoaded = False

        cmb_employees.Items.Clear()


        With FrmINCIDENT_DETAILS.dgv_employees
            If edit Then
                cmb_employees.Enabled = False

                cmb_employees.Items.Add(.CurrentRow.Cells("Employee_ID").Value.ToString & " - " & .CurrentRow.Cells("Employee_Name").Value.ToString)

                cmb_employees.Text = .CurrentRow.Cells("Employee_ID").Value.ToString & " - " & .CurrentRow.Cells("Employee_Name").Value.ToString
                txt_jobTitle.Text = .CurrentRow.Cells("Job_Title").Value.ToString
                txt_department.Text = .CurrentRow.Cells("Department").Value.ToString
                txt_tenure.Text = .CurrentRow.Cells("Tenure").Value.ToString
                txt_age.Text = .CurrentRow.Cells("Age").Value.ToString
                txt_supervisor.Text = .CurrentRow.Cells("Supervisor").Value.ToString
                txt_statements.Text = .CurrentRow.Cells("Statement").Value.ToString
            Else
                sqlSTR = "select Employee_ID, CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') from Employees where Employment_Status != 'Resigned' and Employment_Status != 'Terminated' " & _
                " order by Last_Name, First_Name"
                FILLComboBox(sqlSTR, cmb_employees)

                cmb_employees.Enabled = True
            End If
        End With

        formLoaded = True
    End Sub

    Private Function holdSave() As Boolean
        If cmb_employees.Text = "" Then
            MsgBox("No selected employee, try again.", MsgBoxStyle.Information)
            Return True
        End If

        If txt_supervisor.Text = "" Then
            MsgBox("Supervisor cannot be blank.", MsgBoxStyle.Information)
            Return True
        End If

        Return False
    End Function

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If holdSave() Then Exit Sub


        With FrmINCIDENT_DETAILS.dgv_employees
            If edit Then
                .CurrentRow.Cells("Supervisor").Value = txt_supervisor.Text
                .CurrentRow.Cells("Statement").Value = txt_statements.Text
            Else

                .Rows.Add(
                    Split(cmb_employees.Text, " - ")(0),
                    Split(cmb_employees.Text, " - ")(1),
                    txt_jobTitle.Text,
                    txt_department.Text,
                    txt_tenure.Text,
                    txt_age.Text,
                    txt_supervisor.Text,
                    txt_statements.Text)

            End If
        End With

        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub cmb_employees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_employees.SelectedIndexChanged
        If formLoaded Then
            sqlSTR = "select Position, Department, DATEDIFF(YEAR, Date_of_Birth, GETDATE()) AS Age, " & _
                " CASE " & _
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
                "END as Tenure " & _
                " from Employees where Employee_ID = '" & Split(cmb_employees.Text, " - ")(0) & "';"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count = 1 Then
                txt_jobTitle.Text = sqlDT.Rows(0)("Position").ToString
                txt_department.Text = sqlDT.Rows(0)("Department").ToString
                txt_age.Text = sqlDT.Rows(0)("Age").ToString
                txt_tenure.Text = sqlDT.Rows(0)("Tenure").ToString
            Else
                cmb_employees.SelectedIndex = -1
            End If
        End If
    End Sub
End Class