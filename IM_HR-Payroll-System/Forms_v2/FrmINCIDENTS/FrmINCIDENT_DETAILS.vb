Public Class FrmINCIDENT_DETAILS
    Public formAction, Incident_ID As String
    Public edit As Boolean = False
    Private Sub FrmINCIDENT_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeHelper.ApplyHighlight(Me)
        inputText_ChangedHandler(Me)
        inputNum_ChangedHandler(Me)

        cmb_classification.SelectedIndex = 0
        cmb_status.SelectedIndex = 0
        ClearGroupBoxInputs(grpDetails)
        dgv_employees.Rows.Clear()
        dgv_offenses.Rows.Clear()
        dgv_actionTaken.Rows.Clear()

        sqlSTR = "select Employee_ID, CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') from Employees where Employment_Status != 'Resigned' and Employment_Status != 'Terminated' " & _
                " order by Last_Name, First_Name"
        FILLComboBox(sqlSTR, cmb_employees)

        formAction = FrmINCIDENTS.formAction
        If formAction = "edit" Then
            Incident_ID = FrmINCIDENTS.Incident_ID

            Label_ID.Text = "ID#" & Incident_ID
            Label_ID.Left = Panel1.Width - Label_ID.Width - 10

            sqlSTR = "SELECT Incident_ID " & _
                    ",Incident_EncodeDate " & _
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
                    ",CONCAT(Employee_ID, ' - ', TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') as Reported_By " & _
                    "FROM Incident " & _
                    "LEFT JOIN Employees on Employees.Employee_ID = Incident.Reported_By_Employee_ID " & _
                    "where Incident_Id = '" & Incident_ID & "'; "
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count = 0 Then Me.Close()

            dt_incidentDate.Text = sqlDT.Rows(0)("Incident_DateTime").ToString
            dt_encodeDate.Text = sqlDT.Rows(0)("Incident_EncodeDate").ToString
            dt_lastUpdate.Text = sqlDT.Rows(0)("Incident_UpdateDate").ToString
            cmb_classification.Text = sqlDT.Rows(0)("Incident_Classification").ToString
            cmb_employees.Text = sqlDT.Rows(0)("Reported_By").ToString
            txt_location.Text = sqlDT.Rows(0)("Incident_Location").ToString
            txt_details.Text = sqlDT.Rows(0)("Incident_Details").ToString
            txt_cause.Text = sqlDT.Rows(0)("Incident_Cause").ToString
            txt_evidence.Text = sqlDT.Rows(0)("Incident_Evidence").ToString
            txt_recommendations.Text = sqlDT.Rows(0)("Incident_Recommendations").ToString
            cmb_status.Text = sqlDT.Rows(0)("Incident_Status").ToString
            lbl_preparedBy.Text = "Prepared by : " & sqlDT.Rows(0)("Prepared_By").ToString

            If cmb_status.Text = "Concluded" Then
                grpDetails.Enabled = False
                btn_add.Enabled = False
                btn_edit.Enabled = False
                btn_delete.Enabled = False
                btn_Save.Enabled = False
            Else
                grpDetails.Enabled = True
                btn_add.Enabled = True
                btn_edit.Enabled = True
                btn_delete.Enabled = True
                btn_Save.Enabled = True
            End If

            'EMPLOYEES
            sqlSTR = "SELECT Incident_Employees_ID " & _
                    ",Incident_ID " & _
                    ",Employees.Employee_ID " & _
                    ",CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') as Employee_Name " & _
                    ",Employee_Job_Title " & _
                    ",Employee_Department " & _
                    ",Employee_Tenure " & _
                    ",Employee_Age " & _
                    ",Employee_Supervisor " & _
                    ",Employee_Incident_Statement " & _
                    "FROM Incident_Details_Employees " & _
                    "INNER JOIN Employees on Employees.Employee_ID = Incident_Details_Employees.Employee_ID " & _
                    "where Incident_ID = '" & Incident_ID & "' " & _
                    "Order by Employee_Name;"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                For i = 0 To sqlDT.Rows.Count - 1
                    dgv_employees.Rows.Add(
                    sqlDT.Rows(i)("Employee_ID"),
                    sqlDT.Rows(i)("Employee_Name"),
                    sqlDT.Rows(i)("Employee_Job_Title"),
                    sqlDT.Rows(i)("Employee_Department"),
                    sqlDT.Rows(i)("Employee_Tenure"),
                    sqlDT.Rows(i)("Employee_Age"),
                    sqlDT.Rows(i)("Employee_Supervisor"),
                    sqlDT.Rows(i)("Employee_Incident_Statement")
                    )
                Next
            End If

            'OFFENSES
            sqlSTR = "SELECT Incident_Offenses_ID " & _
                        ",Incident_ID " & _
                        ",Employees.Employee_ID " & _
                        ",CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') as Employee_Name " & _
                        ",Offense_Category " & _
                        ",Offense_Definition " & _
                        ",Offense_Class " & _
                        ",Offense_Instance " & _
                        "FROM Incident_Details_Offenses " & _
                        "INNER JOIN Employees on Employees.Employee_ID = Incident_Details_Offenses.Employee_ID " & _
                        "where Incident_ID = '" & Incident_ID & "' " & _
                        "Order by Employee_Name;"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                For i = 0 To sqlDT.Rows.Count - 1
                    dgv_offenses.Rows.Add(
                    sqlDT.Rows(i)("Offense_Category"),
                    sqlDT.Rows(i)("Offense_Definition"),
                    sqlDT.Rows(i)("Offense_Class"),
                    sqlDT.Rows(i)("Offense_Instance"),
                    sqlDT.Rows(i)("Employee_ID"),
                    sqlDT.Rows(i)("Employee_Name")
                    )
                Next
            End If

            'ACTIONS
            sqlSTR = "SELECT Incident_Actions_ID " & _
                        ",Incident_ID " & _
                        ",Employees.Employee_ID " & _
                        ",CONCAT(TRIM(Last_Name), ', ', TRIM(First_Name), ' ', left(TRIM(Middle_Name), 1), '.') as Employee_Name " & _
                        ",Action_Taken " & _
                        ",Action_Details " & _
                        ",Action_Start_Date " & _
                        ",Action_End_Date " & _
                        ",Action_Decision_Date " & _
                        ",Decided_By " & _
                        "FROM Incident_Details_Actions " & _
                        "INNER JOIN Employees on Employees.Employee_ID = Incident_Details_Actions.Employee_ID " & _
                        "where Incident_ID = '" & Incident_ID & "' " & _
                        "Order by Employee_Name;"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                For i = 0 To sqlDT.Rows.Count - 1
                    dgv_actionTaken.Rows.Add(
                    sqlDT.Rows(i)("Action_Taken"),
                    sqlDT.Rows(i)("Action_Details"),
                    sqlDT.Rows(i)("Action_Start_Date"),
                    sqlDT.Rows(i)("Action_End_Date"),
                    sqlDT.Rows(i)("Action_Decision_Date"),
                    sqlDT.Rows(i)("Decided_By"),
                    sqlDT.Rows(i)("Employee_ID"),
                    sqlDT.Rows(i)("Employee_Name")
                    )
                Next
            End If



        Else



            grpDetails.Enabled = True
            btn_add.Enabled = True
            btn_edit.Enabled = True
            btn_delete.Enabled = True
            btn_Save.Enabled = True
            lbl_preparedBy.Text = "Prepared by : " & xUsername
        End If
    End Sub


    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        edit = False
        Select Case Incident_TabControl.SelectedTab.Name
            Case "Employees_Involved"
                FrmINCIDENT_DETAILS_EMPLOYEE.ShowDialog()
            Case "Offenses_Incurred"
                If dgv_employees.Rows.Count = 0 Then
                    MsgBox("No employee has been recorded. Record of an involved employee is required to save an offense incurred record.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                FrmINCIDENT_DETAILS_OFFENSES.ShowDialog()
            Case "Action_Taken"
                If dgv_employees.Rows.Count = 0 Then
                    MsgBox("No employee has been recorded. Record of an involved employee is required to save an action taken record.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                FrmINCIDENT_DETAILS_ACTION.ShowDialog()
        End Select
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If btn_Save.Enabled = False Then Exit Sub

        edit = True
        Select Case Incident_TabControl.SelectedTab.Name
            Case "Employees_Involved"
                FrmINCIDENT_DETAILS_EMPLOYEE.ShowDialog()
            Case "Offenses_Incurred"
                FrmINCIDENT_DETAILS_OFFENSES.ShowDialog()
            Case "Action_Taken"
                FrmINCIDENT_DETAILS_ACTION.ShowDialog()
        End Select
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Select Case Incident_TabControl.SelectedTab.Name
            Case "Employees_Involved"
                dgv_employees.Focus()
                If dgv_employees.Rows.Count > 0 Then
                    If dgv_employees.CurrentRow IsNot Nothing AndAlso Not dgv_employees.CurrentRow.IsNewRow Then
                        dgv_employees.Rows.Remove(dgv_employees.CurrentRow)
                    End If
                End If
            Case "Offenses_Incurred"
                dgv_offenses.Focus()
                If dgv_offenses.Rows.Count > 0 Then
                    If dgv_offenses.CurrentRow IsNot Nothing AndAlso Not dgv_offenses.CurrentRow.IsNewRow Then
                        dgv_offenses.Rows.Remove(dgv_offenses.CurrentRow)
                    End If
                End If
            Case "Action_Taken"
                dgv_actionTaken.Focus()
                If dgv_actionTaken.Rows.Count > 0 Then
                    If dgv_actionTaken.CurrentRow IsNot Nothing AndAlso Not dgv_actionTaken.CurrentRow.IsNewRow Then
                        dgv_actionTaken.Rows.Remove(dgv_actionTaken.CurrentRow)
                    End If
                End If
        End Select
    End Sub

    Private Sub dgv_employees_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv_employees.MouseDoubleClick,
                                                                                                                                dgv_offenses.MouseDoubleClick,
                                                                                                                                dgv_actionTaken.MouseDoubleClick
        btn_edit_Click(sender, e)
    End Sub

    'Private Sub dgv_offenses_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv_offenses.MouseDoubleClick
    '    'Function Here
    'End Sub

    'Private Sub dgv_actionTaken_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv_actionTaken.MouseDoubleClick
    '    'Function Here
    'End Sub



    Private Function holdSave() As Boolean
        If dgv_employees.Rows.Count = 0 Then
            MsgBox("List of Employee(s) Involved record is required.", MsgBoxStyle.Information)
            Return True
        End If

        If cmb_employees.Text = "" Then
            MsgBox("Reported by is required.", MsgBoxStyle.Information)
            Return True
        End If

        If cmb_status.Text = "Concluded" Then
            If dgv_offenses.Rows.Count = 0 Then
                MsgBox("List of Offense(s) Incurred record is required.", MsgBoxStyle.Information)
                Return True
            End If

            If dgv_actionTaken.Rows.Count = 0 Then
                MsgBox("List of Action(s) Taken record is required.", MsgBoxStyle.Information)
                Return True
            End If

            If dgv_employees.Rows.Count <> dgv_actionTaken.Rows.Count Then

                ' Collect the Employee_IDs that already have an action taken
                Dim actionIds As New HashSet(Of String)
                For Each r As DataGridViewRow In dgv_actionTaken.Rows
                    If r.IsNewRow Then Continue For
                    If r.Cells("Employee_ID3").Value IsNot Nothing Then
                        actionIds.Add(r.Cells("Employee_ID3").Value.ToString().Trim())
                    End If
                Next

                ' Find employees with no matching action taken (store their names)
                Dim missingNames As New List(Of String)
                For Each r As DataGridViewRow In dgv_employees.Rows
                    If r.IsNewRow Then Continue For
                    If r.Cells("Employee_ID").Value IsNot Nothing Then
                        Dim empId As String = r.Cells("Employee_ID").Value.ToString().Trim()
                        If Not actionIds.Contains(empId) Then
                            Dim empName As String = ""
                            If r.Cells("Employee_Name").Value IsNot Nothing Then
                                empName = r.Cells("Employee_Name").Value.ToString().Trim()
                            End If
                            missingNames.Add(empName)
                        End If
                    End If
                Next

                If missingNames.Count > 0 Then
                    MsgBox("No action taken for: " & vbCrLf & String.Join(vbCrLf, missingNames), MsgBoxStyle.Information)
                End If

                Return True
            End If
        End If

        If txt_location.Text = "" Then
            MsgBox("Location cannot be blank.", MsgBoxStyle.Information)
            Return True
        End If

        If txt_details.Text = "" Then
            MsgBox("Detail(s) cannot be blank.", MsgBoxStyle.Information)
            Return True
        End If

        If txt_cause.Text = "" Then
            MsgBox("Cause(s) cannot be blank.", MsgBoxStyle.Information)
            Return True
        End If

        Return False
    End Function

    Private Sub Save()
        If formAction = "edit" Then
            sqlSTR = "UPDATE Incident " & _
                    "SET " & _
                    "Incident_UpdateDate       = '" & dt_lastUpdate.Text & "', " & _
                    "Incident_DateTime         = '" & dt_incidentDate.Text & "', " & _
                    "Incident_Classification   = '" & cmb_classification.Text & "', " & _
                    "Reported_By_Employee_ID   = '" & Split(cmb_employees.Text, " - ")(0) & "', " & _
                    "Incident_Location         = '" & txt_location.Text & "', " & _
                    "Incident_Details          = '" & txt_details.Text & "', " & _
                    "Incident_Cause            = '" & txt_cause.Text & "', " & _
                    "Incident_Evidence         = '" & txt_evidence.Text & "', " & _
                    "Incident_Recommendations  = '" & txt_recommendations.Text & "', " & _
                    "Incident_Status           = '" & cmb_status.Text & "' " & _
                    "WHERE Incident_ID = '" & Incident_ID & "';"
            ExecuteSQLQuery(sqlSTR)

            sqlSTR = "Delete from Incident_Details_Employees where Incident_ID = '" & Incident_ID & "'; " & _
                    "Delete from Incident_Details_Offenses where Incident_ID = '" & Incident_ID & "'; " & _
                    "Delete from Incident_Details_Actions where Incident_ID = '" & Incident_ID & "';"
            ExecuteSQLQuery(sqlSTR)

        Else
            sqlSTR = "SELECT " & _
                    "CASE " & _
                    "WHEN IDENT_CURRENT('Incident') <= IDENT_SEED('Incident') " & _
                    "THEN IDENT_SEED('Incident') " & _
                    "ELSE IDENT_CURRENT('Incident') + IDENT_INCR('Incident') " & _
                    "END AS Incident_ID;"
            ExecuteSQLQuery(sqlSTR)

            Incident_ID = sqlDT.Rows(0)("Incident_ID")

            sqlSTR = "INSERT INTO Incident " & _
                    "( " & _
                    "Incident_EncodeDate, " & _
                    "Incident_UpdateDate, " & _
                    "Incident_DateTime, " & _
                    "Incident_Classification, " & _
                    "Reported_By_Employee_ID, " & _
                    "Incident_Location, " & _
                    "Incident_Details, " & _
                    "Incident_Cause, " & _
                    "Incident_Evidence, " & _
                    "Incident_Recommendations, " & _
                    "Incident_Status, " & _
                    "Prepared_By " & _
                    ") " & _
                    "VALUES " & _
                    "( " & _
                    "GETDATE(), " & _
                    "GETDATE(), " & _
                    "'" & dt_incidentDate.Text & "', " & _
                    "'" & cmb_classification.Text & "', " & _
                    "'" & Split(cmb_employees.Text, " - ")(0) & "', " & _
                    "'" & txt_location.Text & "', " & _
                    "'" & txt_details.Text & "', " & _
                    "'" & txt_cause.Text & "', " & _
                    "'" & txt_evidence.Text & "', " & _
                    "'" & txt_recommendations.Text & "', " & _
                    "'" & cmb_status.Text & "', " & _
                    "'" & xUsername & "' " & _
                    ");"
            ExecuteSQLQuery(sqlSTR)

        End If

        sqlSTR = ""
        If dgv_employees.Rows.Count > 0 Then
            For i = 0 To dgv_employees.Rows.Count - 1
                With dgv_employees.Rows(i)
                    sqlSTR &= "INSERT INTO Incident_Details_Employees " & _
                              "( " & _
                              "Incident_ID, " & _
                              "Employee_ID, " & _
                              "Employee_Job_Title, " & _
                              "Employee_Department, " & _
                              "Employee_Tenure, " & _
                              "Employee_Age, " & _
                              "Employee_Supervisor, " & _
                              "Employee_Incident_Statement " & _
                              ") " & _
                              "VALUES " & _
                              "( " & _
                              "'" & Incident_ID & "', " & _
                              "'" & .Cells("Employee_ID").Value.ToString() & "', " & _
                              "'" & .Cells("Job_Title").Value.ToString() & "', " & _
                              "'" & .Cells("Department").Value.ToString() & "', " & _
                              "'" & .Cells("Tenure").Value.ToString() & "', " & _
                              "'" & .Cells("Age").Value.ToString() & "', " & _
                              "'" & .Cells("Supervisor").Value.ToString() & "', " & _
                              "'" & .Cells("Statement").Value.ToString() & "' " & _
                              "); " & vbCrLf
                End With
            Next
        End If

        If dgv_offenses.Rows.Count > 0 Then
            For i = 0 To dgv_offenses.Rows.Count - 1
                With dgv_offenses.Rows(i)
                    sqlSTR &= "INSERT INTO Incident_Details_Offenses " & _
                                "( " & _
                                "Incident_ID, " & _
                                "Employee_ID, " & _
                                "Offense_Category, " & _
                                "Offense_Definition, " & _
                                "Offense_Class, " & _
                                "Offense_Instance " & _
                                ") " & _
                                "VALUES " & _
                                "( " & _
                                "'" & Incident_ID & "', " & _
                                "'" & .Cells("Employee_ID2").Value.ToString() & "', " & _
                                "'" & .Cells("Category").Value.ToString() & "', " & _
                                "'" & .Cells("Definition").Value.ToString() & "', " & _
                                "'" & .Cells("Offense_Class").Value.ToString() & "', " & _
                                "'" & .Cells("Instance").Value.ToString() & "' " & _
                                "); " & vbCrLf
                End With
            Next
        End If

        If dgv_actionTaken.Rows.Count > 0 Then
            For i = 0 To dgv_actionTaken.Rows.Count - 1
                With dgv_actionTaken.Rows(i)
                    sqlSTR &= "INSERT INTO Incident_Details_Actions " & _
                                "( " & _
                                "Incident_ID, " & _
                                "Employee_ID, " & _
                                "Action_Taken, " & _
                                "Action_Details, " & _
                                "Action_Start_Date, " & _
                                "Action_End_Date, " & _
                                "Action_Decision_Date, " & _
                                "Decided_By " & _
                                ") " & _
                                "VALUES " & _
                                "( " & _
                                "'" & Incident_ID & "', " & _
                                "'" & .Cells("Employee_ID3").Value.ToString() & "', " & _
                                "'" & .Cells("ActionTaken").Value.ToString() & "', " & _
                                "'" & .Cells("Details").Value.ToString() & "', " & _
                                "'" & .Cells("Start_Date").Value.ToString() & "', " & _
                                "'" & .Cells("End_Date").Value.ToString() & "', " & _
                                "'" & .Cells("Decision_Date").Value.ToString() & "', " & _
                                "'" & .Cells("Decided_By").Value.ToString() & "' " & _
                                ");" & vbCrLf
                End With
            Next
        End If

        If sqlSTR <> "" Then ExecuteSQLQuery(sqlSTR)
    End Sub


    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If holdSave() Then Exit Sub

        Save()


        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        If holdSave() Then Exit Sub

        Save()

        FrmINCIDENT_DETAILS_PRINT.ShowDialog()
    End Sub
End Class