Public Class FormEVALUATION_DETAILS
    Dim evaluation_ID, employee_ID As Integer
    Public criteriaScore As Integer = 0
    Public criteriaText As String
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
                txt_QualityOfWork.Text = sqlDT.Rows(0)("Quality_of_Work")
                txt_Productivity.Text = sqlDT.Rows(0)("Productivity")
                txt_Consistency.Text = sqlDT.Rows(0)("Consistency")
                txt_TechnicalSkills.Text = sqlDT.Rows(0)("Technical_Skills")
                txt_ProblemSolving.Text = sqlDT.Rows(0)("Problem_Solving")
                txt_CommunicationSkills.Text = sqlDT.Rows(0)("Communication_Skills")
                txt_Attendance.Text = sqlDT.Rows(0)("Attendance")
                txt_Teamwork.Text = sqlDT.Rows(0)("Teamwork")
                txt_Dependability.Text = sqlDT.Rows(0)("Dependability")
                txt_Professionalism.Text = sqlDT.Rows(0)("Professionalism")
                txt_GoalFulfillment.Text = sqlDT.Rows(0)("Goal_Fulfillment")
                txt_Initiative.Text = sqlDT.Rows(0)("Initiative")
                txt_Flexibility.Text = sqlDT.Rows(0)("Flexibility")
                txt_LearningAbility.Text = sqlDT.Rows(0)("Learning_Ability")
                txt_DecisionMaking.Text = sqlDT.Rows(0)("Decision_Making")
                txt_TeamManagement.Text = sqlDT.Rows(0)("Team_Management")
                txt_ConflictResolution.Text = sqlDT.Rows(0)("Conflict_Resolution")
                cb_Validated.Tag = sqlDT.Rows(0)("Evaluation_Validated")
            End If

            TotalPercentage_Compute()
        Else
            evaluation_ID = 0
            dt_evalDate.Text = Today()
            cmb_employees.SelectedIndex = -1
            txt_remarks.Text = ""
            txt_QualityOfWork.Text = "0"
            txt_Productivity.Text = "0"
            txt_Consistency.Text = "0"
            txt_TechnicalSkills.Text = "0"
            txt_ProblemSolving.Text = "0"
            txt_CommunicationSkills.Text = "0"
            txt_Attendance.Text = "0"
            txt_Teamwork.Text = "0"
            txt_Dependability.Text = "0"
            txt_Professionalism.Text = "0"
            txt_GoalFulfillment.Text = "0"
            txt_Initiative.Text = "0"
            txt_Flexibility.Text = "0"
            txt_LearningAbility.Text = "0"
            txt_DecisionMaking.Text = "0"
            txt_TeamManagement.Text = "0"
            txt_ConflictResolution.Text = "0"
            cb_Validated.Checked = False
            TotalPercentage_Compute()
        End If

        If cb_Validated.Tag = "Yes" Then
            cb_Validated.Checked = True
            dt_evalDate.Enabled = False
            cmb_employees.Enabled = False
            txt_QualityOfWork.Enabled = False
            txt_Productivity.Enabled = False
            txt_Consistency.Enabled = False
            txt_TechnicalSkills.Enabled = False
            txt_ProblemSolving.Enabled = False
            txt_CommunicationSkills.Enabled = False
            txt_Attendance.Enabled = False
            txt_Teamwork.Enabled = False
            txt_Dependability.Enabled = False
            txt_Professionalism.Enabled = False
            txt_GoalFulfillment.Enabled = False
            txt_Initiative.Enabled = False
            txt_Flexibility.Enabled = False
            txt_LearningAbility.Enabled = False
            txt_DecisionMaking.Enabled = False
            txt_TeamManagement.Enabled = False
            txt_ConflictResolution.Enabled = False
            cb_Validated.Enabled = False
        Else
            cb_Validated.Checked = False
            dt_evalDate.Enabled = True
            cmb_employees.Enabled = True
            txt_QualityOfWork.Enabled = True
            txt_Productivity.Enabled = True
            txt_Consistency.Enabled = True
            txt_TechnicalSkills.Enabled = True
            txt_ProblemSolving.Enabled = True
            txt_CommunicationSkills.Enabled = True
            txt_Attendance.Enabled = True
            txt_Teamwork.Enabled = True
            txt_Dependability.Enabled = True
            txt_Professionalism.Enabled = True
            txt_GoalFulfillment.Enabled = True
            txt_Initiative.Enabled = True
            txt_Flexibility.Enabled = True
            txt_LearningAbility.Enabled = True
            txt_DecisionMaking.Enabled = True
            txt_TeamManagement.Enabled = True
            txt_ConflictResolution.Enabled = True
            cb_Validated.Enabled = True
        End If

    End Sub




    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If Catched_ZeroBlank() Then
            MsgBox("Check criteria scores – they cannot be left blank or set to zero.", MsgBoxStyle.Exclamation, msgBox_header)
            Exit Sub
        End If

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
            MsgBox("Evaluee cannot be blank, try again.", MsgBoxStyle.Exclamation, msgBox_header)
            Exit Sub
        End If

        If cmb_evaluator.Text = "" Then
            MsgBox("Evaluator cannot be blank, try again.", MsgBoxStyle.Exclamation, msgBox_header)
            Exit Sub
        End If


        If cmb_employees.Text = cmb_evaluator.Text Then
            MsgBox("Evaluee and Evaluator cannot be the same, try again.", MsgBoxStyle.Exclamation, msgBox_header)
            Exit Sub
        End If

        If formOperation = "edit" Then
            sqlSTR = "UPDATE Evaluation SET " & _
    "Evaluation_Date = '" & dt_evalDate.Text & "', " & _
    "Employee_ID = " & Split(cmb_employees.Text, " - ")(0) & ", " & _
    "Evaluator_ID = " & Split(cmb_evaluator.Text, " - ")(0) & ", " & _
    "Quality_of_Work = " & txt_QualityOfWork.Text & ", " & _
    "Productivity = " & txt_Productivity.Text & ", " & _
    "Consistency = " & txt_Consistency.Text & ", " & _
    "Technical_Skills = " & txt_TechnicalSkills.Text & ", " & _
    "Problem_Solving = " & txt_ProblemSolving.Text & ", " & _
    "Communication_Skills = " & txt_CommunicationSkills.Text & ", " & _
    "Attendance = " & txt_Attendance.Text & ", " & _
    "Teamwork = " & txt_Teamwork.Text & ", " & _
    "Dependability = " & txt_Dependability.Text & ", " & _
    "Professionalism = " & txt_Professionalism.Text & ", " & _
    "Goal_Fulfillment = " & txt_GoalFulfillment.Text & ", " & _
    "Initiative = " & txt_Initiative.Text & ", " & _
    "Flexibility = " & txt_Flexibility.Text & ", " & _
    "Learning_Ability = " & txt_LearningAbility.Text & ", " & _
    "Decision_Making = " & txt_DecisionMaking.Text & ", " & _
    "Team_Management = " & txt_TeamManagement.Text & ", " & _
    "Conflict_Resolution = " & txt_ConflictResolution.Text & ", " & _
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
    txt_QualityOfWork.Text & ", " & txt_Productivity.Text & ", " & txt_Consistency.Text & ", " & _
    txt_TechnicalSkills.Text & ", " & txt_ProblemSolving.Text & ", " & txt_CommunicationSkills.Text & ", " & _
    txt_Attendance.Text & ", " & txt_Teamwork.Text & ", " & txt_Dependability.Text & ", " & _
    txt_Professionalism.Text & ", " & txt_GoalFulfillment.Text & ", " & txt_Initiative.Text & ", " & _
    txt_Flexibility.Text & ", " & txt_LearningAbility.Text & ", " & txt_DecisionMaking.Text & ", " & _
    txt_TeamManagement.Text & ", " & txt_ConflictResolution.Text & ", " & _
    "'" & txt_remarks.Text & "', '" & txt_rateDescription.Text & "', '" & cb_Validated.Tag & "', " & txt_grand_Total.Text & ", " & Split(cmb_evaluator.Text, " - ")(0) & ")"
            ExecuteSQLQuery(sqlSTR)
        End If

        Me.Close()
    End Sub

    Private Sub TotalPercentage_Compute()
        Dim Job_Performance, Capabilities, Behavorial_Attributes,
            Goal_Achievement, Adaptability, Leadership, Grand_Total As Double
        Job_Performance = (((Val(txt_QualityOfWork.Text) + Val(txt_Productivity.Text) + Val(txt_Consistency.Text)) / 30) * 0.3) * 100
        Capabilities = (((Val(txt_TechnicalSkills.Text) + Val(txt_ProblemSolving.Text) + Val(txt_CommunicationSkills.Text)) / 30) * 0.2) * 100
        Behavorial_Attributes = (((Val(txt_Attendance.Text) + Val(txt_Teamwork.Text) + Val(txt_Dependability.Text) + Val(txt_Professionalism.Text)) / 40) * 0.2) * 100
        Goal_Achievement = (((Val(txt_GoalFulfillment.Text) + Val(txt_Initiative.Text)) / 20) * 0.1) * 100
        Adaptability = (((Val(txt_Flexibility.Text) + Val(txt_LearningAbility.Text)) / 20) * 0.1) * 100
        Leadership = (((Val(txt_DecisionMaking.Text) + Val(txt_TeamManagement.Text) + Val(txt_ConflictResolution.Text)) / 30) * 0.1) * 100
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

    Private Sub txt_ValueChanged(sender As Object, e As EventArgs) Handles txt_QualityOfWork.TextChanged, txt_Productivity.TextChanged,
                                                                            txt_Consistency.TextChanged, txt_TechnicalSkills.TextChanged,
                                                                            txt_ProblemSolving.TextChanged, txt_CommunicationSkills.TextChanged,
                                                                            txt_Attendance.TextChanged, txt_Teamwork.TextChanged, txt_Dependability.TextChanged,
                                                                            txt_Professionalism.TextChanged, txt_GoalFulfillment.TextChanged, txt_Initiative.TextChanged,
                                                                            txt_Flexibility.TextChanged, txt_LearningAbility.TextChanged, txt_DecisionMaking.TextChanged,
                                                                            txt_TeamManagement.TextChanged, txt_ConflictResolution.TextChanged

        Dim numControl As TextBox = TryCast(sender, TextBox)

        If numControl.Text = "" Then numControl.Text = 0
        If CInt(numControl.Text) > 10 Then numControl.Text = 10
        If CInt(numControl.Text) < 0 Then numControl.Text = 0

        TotalPercentage_Compute()
    End Sub

    


    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub lnk_QualityOfWork_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_QualityOfWork.LinkClicked, lnk_Productivity.LinkClicked,
                                                                            lnk_Consistency.LinkClicked, lnk_TechnicalSkills.LinkClicked,
                                                                            lnk_ProblemSolving.LinkClicked, lnk_CommunicationSkills.LinkClicked,
                                                                            lnk_Attendance.LinkClicked, lnk_Teamwork.LinkClicked, lnk_Dependability.LinkClicked,
                                                                            lnk_Professionalism.LinkClicked, lnk_GoalFulfillment.LinkClicked, lnk_Initiative.LinkClicked,
                                                                            lnk_Flexibility.LinkClicked, lnk_LearningAbility.LinkClicked, lnk_DecisionMaking.LinkClicked,
                                                                            lnk_TeamManagement.LinkClicked, lnk_ConflictResolution.LinkClicked
        Dim lnkLabel As LinkLabel = TryCast(sender, LinkLabel)

        EvaluationPerCriteria(lnkLabel.Text, GetTextBoxByName(lnkLabel.Tag))
    End Sub

    Private Sub EvaluationPerCriteria(criteriaName As String, criteriaTotal As TextBox)
        criteriaScore = 0
        criteriaText = criteriaName
        FormEVALUATION_QUESTIONS.ShowDialog()
        criteriaTotal.Text = criteriaScore
    End Sub

    Private Function GetTextBoxByName(textBoxName As String) As TextBox
        ' Loop through all controls on the form
        For Each ctrl As Control In Me.Controls
            ' Check only GroupBoxes
            If TypeOf ctrl Is GroupBox Then
                ' Loop through all controls inside the GroupBox
                For Each innerCtrl As Control In ctrl.Controls
                    If TypeOf innerCtrl Is TextBox AndAlso innerCtrl.Name = textBoxName Then
                        Return DirectCast(innerCtrl, TextBox)
                    End If
                Next
            End If
        Next
        Return Nothing
    End Function

    Private Function Catched_ZeroBlank() As Boolean
        ' Loop through all controls on the form
        For Each ctrl As Control In Me.Controls
            ' Check only GroupBoxes
            If TypeOf ctrl Is GroupBox Then
                ' Loop through all TextBoxes inside the GroupBox
                For Each innerCtrl As Control In ctrl.Controls
                    If TypeOf innerCtrl Is TextBox AndAlso innerCtrl.Name.StartsWith("txt_") Then
                        Dim txtBox As TextBox = DirectCast(innerCtrl, TextBox)

                        ' Check if TextBox is blank or zero
                        If String.IsNullOrWhiteSpace(txtBox.Text) OrElse txtBox.Text = "0" Then
                            Return True ' Found a blank or zero TextBox
                        End If
                    End If
                Next
            End If
        Next
        Return False ' No blank or zero TextBox found
    End Function

 

End Class