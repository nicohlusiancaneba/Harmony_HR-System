Public Class FormEVALUATION_DETAILS
    Dim evaluation_ID, employee_ID As Integer

    Private Sub FormEVALUATION_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlSTR = "Select * from employees where Employment_Status != 'Resigned' or Employment_Status != 'Terminated' order by Last_Name, First_Name"
        FILLComboBox_Employee(sqlSTR, cmb_employees)
        FILLComboBox_Employee(sqlSTR, cmb_evaluator)
        If formOperation = "edit" Then
            evaluation_ID = xID1
            sqlSTR = "select *, CONCAT(Employees.Employee_ID, ' - ', Last_Name, ', ', First_Name, ', ', Middle_Name) as EmployeeName, (select top 1 CONCAT(Employees.Employee_ID, ' - ', Last_Name, ', ', First_Name, ', ', Middle_Name) from employees where employee_id = Evaluator_ID) as Evaluator_Name from Evaluation INNER JOIN Employees on Employees.Employee_ID = Evaluation.Employee_ID where Evaluation_ID =" & evaluation_ID
            ExecuteSQLQuery(sqlSTR)
            'Split(cmb_employees.Text, " - ")(0)
            If sqlDT.Rows.Count > 0 Then
                employee_ID = sqlDT.Rows(0)("Employee_ID")
                cmb_employees.Text = sqlDT.Rows(0)("EmployeeName")
                cmb_evaluator.Text = sqlDT.Rows(0)("Evaluator_Name")
                dt_evalDate.Text = sqlDT.Rows(0)("Evaluation_Date")
                num_QualityOfWork.Text = sqlDT.Rows(0)("Quality_of_Work")
                num_Productivity.Text = sqlDT.Rows(0)("Productivity")
                num_Consistency.Text = sqlDT.Rows(0)("Consistency")
                num_TechnicalSkills.Text = sqlDT.Rows(0)("Technical_Skills")
                num_ProblemSolving.Text = sqlDT.Rows(0)("Problem_Solving")
                num_CommunicationSkills.Text = sqlDT.Rows(0)("Communication_Skills")
                num_Attendance.Text = sqlDT.Rows(0)("Attendance")
                num_Teamwork.Text = sqlDT.Rows(0)("Teamwork")
                num_Dependability.Text = sqlDT.Rows(0)("Dependability")
                num_Professionalism.Text = sqlDT.Rows(0)("Professionalism")
                num_GoalFulfillment.Text = sqlDT.Rows(0)("Goal_Fulfillment")
                num_Initiative.Text = sqlDT.Rows(0)("Initiative")
                num_Flexibility.Text = sqlDT.Rows(0)("Flexibility")
                num_LearningAbility.Text = sqlDT.Rows(0)("Learning_Ability")
                num_DecisionMaking.Text = sqlDT.Rows(0)("Decision_Making")
                num_TeamManagement.Text = sqlDT.Rows(0)("Team_Management")
                num_ConflictResolution.Text = sqlDT.Rows(0)("Conflict_Resolution")
                cb_Validated.Tag = sqlDT.Rows(0)("Evaluation_Validated")
            End If

            TotalPercentage_Compute()
        Else
            evaluation_ID = 0
            dt_evalDate.Text = Today()
            cmb_employees.SelectedIndex = -1
            txt_remarks.Text = ""
            ResetNumFields()
            cb_Validated.Checked = False
            TotalPercentage_Compute()
        End If

        If cb_Validated.Tag = "Yes" Then
            cb_Validated.Checked = True
            dt_evalDate.Enabled = False
            cmb_employees.Enabled = False
            num_QualityOfWork.Enabled = False
            num_Productivity.Enabled = False
            num_Consistency.Enabled = False
            num_TechnicalSkills.Enabled = False
            num_ProblemSolving.Enabled = False
            num_CommunicationSkills.Enabled = False
            num_Attendance.Enabled = False
            num_Teamwork.Enabled = False
            num_Dependability.Enabled = False
            num_Professionalism.Enabled = False
            num_GoalFulfillment.Enabled = False
            num_Initiative.Enabled = False
            num_Flexibility.Enabled = False
            num_LearningAbility.Enabled = False
            num_DecisionMaking.Enabled = False
            num_TeamManagement.Enabled = False
            num_ConflictResolution.Enabled = False
            cb_Validated.Enabled = False
        Else
            cb_Validated.Checked = False
            dt_evalDate.Enabled = True
            cmb_employees.Enabled = True
            num_QualityOfWork.Enabled = True
            num_Productivity.Enabled = True
            num_Consistency.Enabled = True
            num_TechnicalSkills.Enabled = True
            num_ProblemSolving.Enabled = True
            num_CommunicationSkills.Enabled = True
            num_Attendance.Enabled = True
            num_Teamwork.Enabled = True
            num_Dependability.Enabled = True
            num_Professionalism.Enabled = True
            num_GoalFulfillment.Enabled = True
            num_Initiative.Enabled = True
            num_Flexibility.Enabled = True
            num_LearningAbility.Enabled = True
            num_DecisionMaking.Enabled = True
            num_TeamManagement.Enabled = True
            num_ConflictResolution.Enabled = True
            cb_Validated.Enabled = True
        End If

    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If cb_Validated.Checked Then
            cb_Validated.Tag = "Yes"
            If MsgBox("Would you like to validate this evaluation record? Please note that once validated, it cannot be modified.", MsgBoxStyle.YesNo + MsgBoxStyle.Information, msgBox_header) = MsgBoxResult.No Then
                cb_Validated.Checked = False
                cb_Validated.Tag = "No"
                Exit Sub
            End If
        Else
            cb_Validated.Tag = "No"
        End If

        If cmb_employees.Text = "" Then
            MsgBox("Evaluee cannot be blank, try again.")
            Exit Sub
        End If

        If cmb_evaluator.Text = "" Then
            MsgBox("Evaluator cannot be blank, try again.")
            Exit Sub
        End If


        If cmb_employees.Text = cmb_evaluator.Text Then
            MsgBox("Evaluee and Evaluator cannot be the same, try again.")
            Exit Sub
        End If

        If formOperation = "edit" Then
            sqlSTR = "UPDATE Evaluation SET " & _
    "Evaluation_Date = '" & dt_evalDate.Text & "', " & _
    "Employee_ID = " & Split(cmb_employees.Text, " - ")(0) & ", " & _
    "Evaluator_ID = " & Split(cmb_evaluator.Text, " - ")(0) & ", " & _
    "Quality_of_Work = " & num_QualityOfWork.Text & ", " & _
    "Productivity = " & num_Productivity.Text & ", " & _
    "Consistency = " & num_Consistency.Text & ", " & _
    "Technical_Skills = " & num_TechnicalSkills.Text & ", " & _
    "Problem_Solving = " & num_ProblemSolving.Text & ", " & _
    "Communication_Skills = " & num_CommunicationSkills.Text & ", " & _
    "Attendance = " & num_Attendance.Text & ", " & _
    "Teamwork = " & num_Teamwork.Text & ", " & _
    "Dependability = " & num_Dependability.Text & ", " & _
    "Professionalism = " & num_Professionalism.Text & ", " & _
    "Goal_Fulfillment = " & num_GoalFulfillment.Text & ", " & _
    "Initiative = " & num_Initiative.Text & ", " & _
    "Flexibility = " & num_Flexibility.Text & ", " & _
    "Learning_Ability = " & num_LearningAbility.Text & ", " & _
    "Decision_Making = " & num_DecisionMaking.Text & ", " & _
    "Team_Management = " & num_TeamManagement.Text & ", " & _
    "Conflict_Resolution = " & num_ConflictResolution.Text & ", " & _
    "Evaluation_Remarks = '" & txt_remarks.Text & "', " & _
    "Total_Percentage = '" & txt_grand_Total.Text & "', " & _
    "Evaluation_Description = '" & txt_rateDescription.Text & "', " & _
    "Evaluation_Validated = '" & cb_Validated.Tag & "' " & _
    "WHERE Evaluation_ID = " & evaluation_ID
            ExecuteSQLQuery(sqlSTR)
        Else
            sqlSTR = "INSERT INTO Evaluation (" & _
    "Evaluation_Date, Employee_ID, Quality_of_Work, Productivity, Consistency, " & _
    "Technical_Skills, Problem_Solving, Communication_Skills, Attendance, " & _
    "Teamwork, Dependability, Professionalism, Goal_Fulfillment, Initiative, " & _
    "Flexibility, Learning_Ability, Decision_Making, Team_Management, Conflict_Resolution, " & _
    "Evaluation_Remarks, Evaluation_Description, Evaluation_Validated, Total_Percentage, Evaluator_ID) " & _
    "VALUES ('" & dt_evalDate.Text & "', " & _
    Split(cmb_employees.Text, " - ")(0) & ", " & _
    num_QualityOfWork.Text & ", " & num_Productivity.Text & ", " & num_Consistency.Text & ", " & _
    num_TechnicalSkills.Text & ", " & num_ProblemSolving.Text & ", " & num_CommunicationSkills.Text & ", " & _
    num_Attendance.Text & ", " & num_Teamwork.Text & ", " & num_Dependability.Text & ", " & _
    num_Professionalism.Text & ", " & num_GoalFulfillment.Text & ", " & num_Initiative.Text & ", " & _
    num_Flexibility.Text & ", " & num_LearningAbility.Text & ", " & num_DecisionMaking.Text & ", " & _
    num_TeamManagement.Text & ", " & num_ConflictResolution.Text & ", " & _
    "'" & txt_remarks.Text & "', '" & txt_rateDescription.Text & "', '" & cb_Validated.Tag & "', " & txt_grand_Total.Text & ", " & Split(cmb_evaluator.Text, " - ")(0) & ")"
            ExecuteSQLQuery(sqlSTR)
        End If

        Me.Close()
    End Sub

    Private Sub TotalPercentage_Compute()
        Dim Job_Performance, Capabilities, Behavorial_Attributes,
            Goal_Achievement, Adaptability, Leadership, Grand_Total As Double
        Job_Performance = (((CInt(num_QualityOfWork.Text) + CInt(num_Productivity.Text) + CInt(num_Consistency.Text)) / 30) * 0.3) * 100
        Capabilities = (((CInt(num_TechnicalSkills.Text) + CInt(num_ProblemSolving.Text) + CInt(num_CommunicationSkills.Text)) / 30) * 0.2) * 100
        Behavorial_Attributes = (((CInt(num_Attendance.Text) + CInt(num_Teamwork.Text) + CInt(num_Dependability.Text) + CInt(num_Professionalism.Text)) / 40) * 0.2) * 100
        Goal_Achievement = (((CInt(num_GoalFulfillment.Text) + CInt(num_Initiative.Text)) / 20) * 0.1) * 100
        Adaptability = (((CInt(num_Flexibility.Text) + CInt(num_LearningAbility.Text)) / 20) * 0.1) * 100
        Leadership = (((CInt(num_DecisionMaking.Text) + CInt(num_TeamManagement.Text) + CInt(num_ConflictResolution.Text)) / 30) * 0.1) * 100
        Grand_Total = Job_Performance + Capabilities + Behavorial_Attributes +
            Goal_Achievement + Adaptability + Leadership
        txt_grand_Total.Text = Grand_Total.ToString("F2")

        Dim score As Integer
        If Double.TryParse(txt_grand_Total.Text, score) Then
            Select Case score
                Case 91 To 100
                    txt_rateDescription.Text = "Outstanding"
                Case 80 To 90
                    txt_rateDescription.Text = "Excellent"
                Case 65 To 79
                    txt_rateDescription.Text = "Average"
                Case 36 To 64
                    txt_rateDescription.Text = "Below Average"
                Case 10 To 35
                    txt_rateDescription.Text = "Poor"
                Case Else
                    txt_rateDescription.Text = "Invalid"
            End Select
        Else
            txt_rateDescription.Text = "Invalid"
        End If

    End Sub

    Private Sub num_ValueChanged(sender As Object, e As EventArgs) Handles num_QualityOfWork.TextChanged, num_Productivity.TextChanged,
                                                                            num_Consistency.TextChanged, num_TechnicalSkills.TextChanged,
                                                                            num_ProblemSolving.TextChanged, num_CommunicationSkills.TextChanged,
                                                                            num_Attendance.TextChanged, num_Teamwork.TextChanged, num_Dependability.TextChanged,
                                                                            num_Professionalism.TextChanged, num_GoalFulfillment.TextChanged, num_Initiative.TextChanged,
                                                                            num_Flexibility.TextChanged, num_LearningAbility.TextChanged, num_DecisionMaking.TextChanged,
                                                                            num_TeamManagement.TextChanged, num_ConflictResolution.TextChanged

        Dim numControl As NumericUpDown = TryCast(sender, NumericUpDown)

        If numControl.Text = "" Then numControl.Text = 1
        If CInt(numControl.Text) > 10 Then numControl.Text = 10
        If CInt(numControl.Text) < 1 Then numControl.Text = 1

        TotalPercentage_Compute()
    End Sub

    Private Sub ResetNumFields()
        ' Loop through all controls in the form, including those inside GroupBoxes
        For Each ctrl As Control In Me.Controls
            ResetNumericUpDowns(ctrl) ' Call recursive function
        Next
    End Sub

    Private Sub ResetNumericUpDowns(parent As Control)
        ' Loop through all child controls
        For Each ctrl As Control In parent.Controls
            ' Check if the control is a NumericUpDown and its name starts with "num_"
            If TypeOf ctrl Is NumericUpDown AndAlso ctrl.Name.StartsWith("num_") Then
                Dim numCtrl As NumericUpDown = DirectCast(ctrl, NumericUpDown)
                numCtrl.Value = 1 ' Reset value to 1
            End If

            ' If the control has child controls (like a GroupBox or Panel), call recursively
            If ctrl.HasChildren Then
                ResetNumericUpDowns(ctrl)
            End If
        Next
    End Sub


    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub
End Class