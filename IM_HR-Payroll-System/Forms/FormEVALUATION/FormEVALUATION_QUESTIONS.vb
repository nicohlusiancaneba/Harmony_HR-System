Public Class FormEVALUATION_QUESTIONS

    Dim evaluationQuestions As String()() = {
        New String() {"Quality of Work", "How well does the employee complete tasks without mistakes?", "How often does the employee meet quality standards?", "How carefully does the employee check their work before submitting?", "How well does the employee follow instructions and guidelines?", "How much effort does the employee put into producing good results?"},
        New String() {"Productivity", "How efficiently does the employee complete their tasks?", "How much work does the employee complete in a typical day?", "How often does the employee meet deadlines?", "How well does the employee manage their time?", "How consistently does the employee stay focused on their work?"},
        New String() {"Consistency", "How often does the employee perform at the same level of quality?", "How regularly does the employee meet expectations?", "How steady is the employee’s performance over time?", "How reliable is the employee in delivering results?", "How often does the employee maintain a professional attitude?"},
        New String() {"Technical Skills", "How well does the employee use tools and equipment for their job?", "How skilled is the employee in their job-related tasks?", "How quickly does the employee learn new technical skills?", "How well does the employee apply their technical knowledge?", "How confident is the employee in using required technology or systems?"},
        New String() {"Problem Solving", "How well does the employee handle unexpected challenges?", "How effectively does the employee find solutions to problems?", "How often does the employee think critically about their work?", "How good is the employee at troubleshooting issues?", "How quickly does the employee solve problems when they arise?"},
        New String() {"Communication Skills", "How clearly does the employee express their thoughts?", "How well does the employee listen to others?", "How effectively does the employee communicate in writing?", "How confidently does the employee speak in meetings or discussions?", "How often does the employee communicate in a respectful manner?"},
        New String() {"Attendance", "How often is the employee present at work?", "How reliable is the employee in showing up on time?", "How often does the employee complete their scheduled hours?", "How well does the employee follow attendance policies?", "How rarely does the employee take unplanned absences?"},
        New String() {"Teamwork", "How well does the employee work with others?", "How often does the employee support their team members?", "How respectful is the employee in team discussions?", "How effectively does the employee contribute to team goals?", "How well does the employee cooperate with different departments?"},
        New String() {"Dependability", "How reliable is the employee in completing tasks as expected?", "How often does the employee follow through on commitments?", "How trustworthy is the employee in handling responsibilities?", "How well does the employee meet deadlines without reminders?", "How consistent is the employee in delivering work on time?"},
        New String() {"Professionalism", "How well does the employee maintain a professional attitude?", "How respectful is the employee toward colleagues and clients?", "How often does the employee follow workplace rules and ethics?", "How well does the employee handle feedback?", "How consistently does the employee act in a responsible manner?"},
        New String() {"Goal Fulfillment", "How effectively does the employee work toward their goals?", "How often does the employee achieve their targets?", "How well does the employee stay focused on long-term objectives?", "How proactive is the employee in meeting expectations?", "How consistently does the employee track their progress on goals?"},
        New String() {"Initiative", "How often does the employee take action without being asked?", "How willing is the employee to go beyond their basic tasks?", "How frequently does the employee suggest new ideas?", "How proactive is the employee in solving issues?", "How often does the employee volunteer for extra responsibilities?"},
        New String() {"Flexibility", "How well does the employee adapt to changes in the workplace?", "How easily does the employee adjust to new tasks?", "How open is the employee to learning new ways of working?", "How well does the employee handle sudden schedule changes?", "How easily does the employee switch between different types of work?"},
        New String() {"Learning Ability", "How quickly does the employee learn new skills?", "How open is the employee to receiving feedback?", "How well does the employee apply new knowledge to their work?", "How often does the employee seek to improve their skills?", "How effectively does the employee retain new information?"},
        New String() {"Decision Making", "How well does the employee make informed decisions?", "How confident is the employee in their decision-making?", "How often does the employee consider risks before making choices?", "How effectively does the employee analyze situations before acting?", "How well does the employee balance speed and accuracy in decisions?"},
        New String() {"Team Management", "How well does the employee lead or guide their team?", "How effectively does the employee delegate tasks?", "How supportive is the employee in helping their team succeed?", "How often does the employee motivate others?", "How well does the employee balance fairness and discipline?"},
        New String() {"Conflict Resolution", "How well does the employee handle disagreements?", "How effectively does the employee resolve conflicts within a team?", "How often does the employee remain calm in tense situations?", "How open is the employee to finding a compromise?", "How well does the employee address issues without escalating them?"}
    }



    Private Sub FormEVALUATION_QUESTIONS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = FormEVALUATION_DETAILS.criteriaText
        ShowQuestions(FormEVALUATION_DETAILS.criteriaText)
        num_Q1.Text = 1
        num_Q2.Text = 1
        num_Q3.Text = 1
        num_Q4.Text = 1
        num_Q5.Text = 1
    End Sub

    Private Sub ShowQuestions(criteria As String)
        For Each questionSet As String() In evaluationQuestions
            If questionSet(0) = criteria Then
                lbl_criteria.Text = "Criteria: " & questionSet(0) ' Set criteria label
                lbl_questions.Text = String.Join(vbCrLf & vbCrLf & vbCrLf, questionSet.Skip(1)) ' Join all questions into one string
                Exit Sub
            End If
        Next
        lbl_criteria.Text = "Not Found"
        lbl_questions.Text = "No questions available for this criteria."
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim total As Double
        total = (CInt(num_Q1.Text) + CInt(num_Q2.Text) + CInt(num_Q3.Text) + CInt(num_Q4.Text) + CInt(num_Q5.Text)) / 5
        FormEVALUATION_DETAILS.criteriaScore = CInt(Math.Round(total, 0))
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
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
            ' Check if the control is a NumericUpDown and its name starts with "txt_"
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

    Private Sub txt_ValueChanged(sender As Object, e As EventArgs) Handles num_Q1.TextChanged, num_Q2.TextChanged,
                                                                            num_Q3.TextChanged, num_Q4.TextChanged, num_Q5.TextChanged

        Dim numControl As NumericUpDown = TryCast(sender, NumericUpDown)

        If numControl.Text = "" Then numControl.Text = 1
        If CInt(numControl.Text) > 10 Then numControl.Text = 10
        If CInt(numControl.Text) < 0 Then numControl.Text = 1
    End Sub
End Class