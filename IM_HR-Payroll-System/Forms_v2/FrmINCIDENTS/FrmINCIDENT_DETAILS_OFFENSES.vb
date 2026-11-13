Public Class FrmINCIDENT_DETAILS_OFFENSES
    Dim edit, formloaded As Boolean
    Private Sub FrmINCIDENT_DETAILS_OFFENSES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeHelper.ApplyHighlight(Me)
        edit = FrmINCIDENT_DETAILS.edit

        inputText_ChangedHandler(Me)
        inputNum_ChangedHandler(Me)
        ClearGroupBoxInputs(grpOffenses)

        formloaded = False

        cmb_employees.Items.Clear()


        FILLComboBox2("select 1, Offense_Category from Offenses group by Offense_Category;", cmb_category)

        With FrmINCIDENT_DETAILS.dgv_offenses
            If edit Then
                cmb_employees.Enabled = False
                cmb_employees.Items.Add(.CurrentRow.Cells("Employee_ID2").Value.ToString & " - " & .CurrentRow.Cells("Subject_Employee").Value.ToString)


                cmb_employees.Text = .CurrentRow.Cells("Employee_ID2").Value.ToString & " - " & .CurrentRow.Cells("Subject_Employee").Value.ToString
                cmb_category.Text = .CurrentRow.Cells("Category").Value.ToString
                FILLComboBox2("select 1, Offense_Definition from Offenses where Offense_Category = '" & cmb_category.Text & "' group by Offense_Definition;", cmb_definition)
                cmb_definition.Text = .CurrentRow.Cells("Definition").Value.ToString
                txt_class.Text = .CurrentRow.Cells("Offense_Class").Value.ToString
                txt_instance.Text = .CurrentRow.Cells("Instance").Value.ToString



            Else
                With FrmINCIDENT_DETAILS.dgv_employees
                    For Each row As DataGridViewRow In .Rows
                        If row.IsNewRow Then Continue For
                        cmb_employees.Items.Add(Convert.ToString(row.Cells("Employee_ID").Value) & " - " & Convert.ToString(row.Cells("Employee_Name").Value))
                    Next
                End With


                'sqlSTR = "select Employee_ID, CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') from Employees where Employment_Status != 'Resigned' and Employment_Status != 'Terminated' " & _
                '" order by Last_Name, First_Name"
                'FILLComboBox(sqlSTR, cmb_employees)

                cmb_employees.Enabled = True
            End If
        End With

        formloaded = True
    End Sub

    Private Sub cmb_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_category.SelectedIndexChanged
        If formloaded Then
            FILLComboBox2("select 1, Offense_Definition from Offenses where Offense_Category = '" & cmb_category.Text & "' group by Offense_Definition;", cmb_definition)
        End If
    End Sub

    Private Sub cmb_definition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_definition.SelectedIndexChanged
        If formloaded Then

            If Not edit Then
                For Each row As DataGridViewRow In FrmINCIDENT_DETAILS.dgv_offenses.Rows
                    If row.IsNewRow Then Continue For

                    If Convert.ToString(row.Cells("Definition").Value).Trim() = cmb_definition.Text And Convert.ToString(row.Cells("Employee_ID2").Value).Trim() = Split(cmb_employees.Text, " - ")(0) Then
                        MsgBox("This offense is already assigned to the selected employee. Please review the details and try again. (Duplicate)", MsgBoxStyle.Information)
                        cmb_definition.SelectedIndex = -1
                        Exit Sub
                    End If
                Next
            End If



            If cmb_definition.Text <> "" Then
                sqlSTR = "select top 1 Offense_Class from Offenses where Offense_Definition='" & cmb_definition.Text & "';"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count = 1 Then
                    txt_class.Text = sqlDT.Rows(0)("Offense_Class").ToString
                End If

                sqlSTR = "DECLARE @Instance_No INT; " & _
                        "SELECT @Instance_No = COUNT(*) + 1 " & _
                        "FROM Incident_Details_Offenses " & _
                        "INNER JOIN Incident " & _
                        "ON Incident.Incident_ID = Incident_Details_Offenses.Incident_ID " & _
                        "WHERE Incident_Details_Offenses.Employee_ID        = '" & Split(cmb_employees.Text, " - ")(0) & "' " & _
                        "AND Incident_Details_Offenses.Offense_Category   = '" & cmb_category.Text & "' " & _
                        "AND Incident_Details_Offenses.Offense_Definition = '" & cmb_definition.Text & "' " & _
                        "AND Incident.Incident_Status                    = 'Concluded'; " & _
                        " " & _
                        "SELECT CAST(@Instance_No AS VARCHAR(10)) " & _
                        "+ CASE WHEN @Instance_No % 100 IN (11, 12, 13) THEN 'th' " & _
                        "WHEN @Instance_No % 10 = 1 THEN 'st' " & _
                        "WHEN @Instance_No % 10 = 2 THEN 'nd' " & _
                        "WHEN @Instance_No % 10 = 3 THEN 'rd' " & _
                        "ELSE 'th' END AS Offense_Instance;"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count = 1 Then
                    txt_instance.Text = sqlDT.Rows(0)("Offense_Instance").ToString
                Else
                    txt_instance.Text = "1st"
                End If


            Else
                txt_class.Text = ""
            End If
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Function holdSave() As Boolean
        If cmb_employees.Text = "" Then
            MsgBox("No selected employee, try again.", MsgBoxStyle.Information)
            Return True
        End If

        If cmb_category.Text = "" Then
            MsgBox("Offense Category cannot be blank.", MsgBoxStyle.Information)
            Return True
        End If

        If cmb_definition.Text = "" Then
            MsgBox("Offense Definition cannot be blank.", MsgBoxStyle.Information)
            Return True
        End If


        Return False
    End Function

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If holdSave() Then Exit Sub

        With FrmINCIDENT_DETAILS.dgv_offenses
            If edit Then
                .CurrentRow.Cells("Employee_ID2").Value = Split(cmb_employees.Text, " - ")(0)
                .CurrentRow.Cells("Subject_Employee").Value = Split(cmb_employees.Text, " - ")(1)
                .CurrentRow.Cells("Category").Value = cmb_category.Text
                .CurrentRow.Cells("Definition").Value = cmb_definition.Text
                .CurrentRow.Cells("Offense_Class").Value = txt_class.Text
                .CurrentRow.Cells("Instance").Value = txt_instance.Text

            Else

                .Rows.Add(
                    cmb_category.Text,
                    cmb_definition.Text,
                    txt_class.Text,
                    txt_instance.Text,
                    Split(cmb_employees.Text, " - ")(0),
                    Split(cmb_employees.Text, " - ")(1))

            End If
        End With

        Me.Close()
    End Sub
End Class