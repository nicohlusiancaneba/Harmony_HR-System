<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEVALUATION_DETAILS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lnk_Consistency = New System.Windows.Forms.LinkLabel()
        Me.lnk_QualityOfWork = New System.Windows.Forms.LinkLabel()
        Me.txt_QualityOfWork = New System.Windows.Forms.TextBox()
        Me.lnk_Productivity = New System.Windows.Forms.LinkLabel()
        Me.txt_Productivity = New System.Windows.Forms.TextBox()
        Me.txt_Consistency = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lnk_CommunicationSkills = New System.Windows.Forms.LinkLabel()
        Me.lnk_TechnicalSkills = New System.Windows.Forms.LinkLabel()
        Me.txt_CommunicationSkills = New System.Windows.Forms.TextBox()
        Me.txt_TechnicalSkills = New System.Windows.Forms.TextBox()
        Me.txt_ProblemSolving = New System.Windows.Forms.TextBox()
        Me.lnk_ProblemSolving = New System.Windows.Forms.LinkLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lnk_Professionalism = New System.Windows.Forms.LinkLabel()
        Me.txt_Professionalism = New System.Windows.Forms.TextBox()
        Me.lnk_Dependability = New System.Windows.Forms.LinkLabel()
        Me.txt_Attendance = New System.Windows.Forms.TextBox()
        Me.lnk_Attendance = New System.Windows.Forms.LinkLabel()
        Me.lnk_Teamwork = New System.Windows.Forms.LinkLabel()
        Me.txt_Dependability = New System.Windows.Forms.TextBox()
        Me.txt_Teamwork = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lnk_GoalFulfillment = New System.Windows.Forms.LinkLabel()
        Me.txt_Initiative = New System.Windows.Forms.TextBox()
        Me.txt_GoalFulfillment = New System.Windows.Forms.TextBox()
        Me.lnk_Initiative = New System.Windows.Forms.LinkLabel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lnk_Flexibility = New System.Windows.Forms.LinkLabel()
        Me.txt_Flexibility = New System.Windows.Forms.TextBox()
        Me.txt_LearningAbility = New System.Windows.Forms.TextBox()
        Me.lnk_LearningAbility = New System.Windows.Forms.LinkLabel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lnk_ConflictResolution = New System.Windows.Forms.LinkLabel()
        Me.lnk_DecisionMaking = New System.Windows.Forms.LinkLabel()
        Me.lnk_TeamManagement = New System.Windows.Forms.LinkLabel()
        Me.txt_ConflictResolution = New System.Windows.Forms.TextBox()
        Me.txt_TeamManagement = New System.Windows.Forms.TextBox()
        Me.txt_DecisionMaking = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txt_remarks = New System.Windows.Forms.RichTextBox()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.cmb_employees = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dt_evalDate = New System.Windows.Forms.DateTimePicker()
        Me.cb_Validated = New System.Windows.Forms.CheckBox()
        Me.txt_grand_Total = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_rateDescription = New System.Windows.Forms.TextBox()
        Me.cmb_evaluator = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 31)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Employee Evaluation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 100)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Evaluee :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Evaluator :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lnk_Consistency)
        Me.GroupBox1.Controls.Add(Me.lnk_QualityOfWork)
        Me.GroupBox1.Controls.Add(Me.txt_QualityOfWork)
        Me.GroupBox1.Controls.Add(Me.lnk_Productivity)
        Me.GroupBox1.Controls.Add(Me.txt_Productivity)
        Me.GroupBox1.Controls.Add(Me.txt_Consistency)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 139)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Job Performance (30%)"
        '
        'lnk_Consistency
        '
        Me.lnk_Consistency.AutoSize = True
        Me.lnk_Consistency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_Consistency.Location = New System.Drawing.Point(66, 98)
        Me.lnk_Consistency.Name = "lnk_Consistency"
        Me.lnk_Consistency.Size = New System.Drawing.Size(95, 20)
        Me.lnk_Consistency.TabIndex = 43
        Me.lnk_Consistency.TabStop = True
        Me.lnk_Consistency.Tag = "txt_Consistency"
        Me.lnk_Consistency.Text = "Consistency"
        '
        'lnk_QualityOfWork
        '
        Me.lnk_QualityOfWork.AutoSize = True
        Me.lnk_QualityOfWork.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_QualityOfWork.Location = New System.Drawing.Point(39, 32)
        Me.lnk_QualityOfWork.Name = "lnk_QualityOfWork"
        Me.lnk_QualityOfWork.Size = New System.Drawing.Size(116, 20)
        Me.lnk_QualityOfWork.TabIndex = 38
        Me.lnk_QualityOfWork.TabStop = True
        Me.lnk_QualityOfWork.Tag = "txt_QualityOfWork"
        Me.lnk_QualityOfWork.Text = "Quality of Work"
        '
        'txt_QualityOfWork
        '
        Me.txt_QualityOfWork.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_QualityOfWork.Location = New System.Drawing.Point(169, 28)
        Me.txt_QualityOfWork.Name = "txt_QualityOfWork"
        Me.txt_QualityOfWork.ReadOnly = True
        Me.txt_QualityOfWork.Size = New System.Drawing.Size(31, 26)
        Me.txt_QualityOfWork.TabIndex = 39
        Me.txt_QualityOfWork.Text = "0"
        Me.txt_QualityOfWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lnk_Productivity
        '
        Me.lnk_Productivity.AutoSize = True
        Me.lnk_Productivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_Productivity.Location = New System.Drawing.Point(66, 63)
        Me.lnk_Productivity.Name = "lnk_Productivity"
        Me.lnk_Productivity.Size = New System.Drawing.Size(89, 20)
        Me.lnk_Productivity.TabIndex = 42
        Me.lnk_Productivity.TabStop = True
        Me.lnk_Productivity.Tag = "txt_Productivity"
        Me.lnk_Productivity.Text = "Productivity"
        '
        'txt_Productivity
        '
        Me.txt_Productivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Productivity.Location = New System.Drawing.Point(169, 60)
        Me.txt_Productivity.Name = "txt_Productivity"
        Me.txt_Productivity.ReadOnly = True
        Me.txt_Productivity.Size = New System.Drawing.Size(31, 26)
        Me.txt_Productivity.TabIndex = 40
        Me.txt_Productivity.Text = "0"
        Me.txt_Productivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Consistency
        '
        Me.txt_Consistency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Consistency.Location = New System.Drawing.Point(169, 92)
        Me.txt_Consistency.Name = "txt_Consistency"
        Me.txt_Consistency.ReadOnly = True
        Me.txt_Consistency.Size = New System.Drawing.Size(31, 26)
        Me.txt_Consistency.TabIndex = 41
        Me.txt_Consistency.Text = "0"
        Me.txt_Consistency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lnk_CommunicationSkills)
        Me.GroupBox2.Controls.Add(Me.lnk_TechnicalSkills)
        Me.GroupBox2.Controls.Add(Me.txt_CommunicationSkills)
        Me.GroupBox2.Controls.Add(Me.txt_TechnicalSkills)
        Me.GroupBox2.Controls.Add(Me.txt_ProblemSolving)
        Me.GroupBox2.Controls.Add(Me.lnk_ProblemSolving)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 321)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 139)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Capabilities (20%)"
        '
        'lnk_CommunicationSkills
        '
        Me.lnk_CommunicationSkills.AutoSize = True
        Me.lnk_CommunicationSkills.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_CommunicationSkills.Location = New System.Drawing.Point(2, 94)
        Me.lnk_CommunicationSkills.Name = "lnk_CommunicationSkills"
        Me.lnk_CommunicationSkills.Size = New System.Drawing.Size(159, 20)
        Me.lnk_CommunicationSkills.TabIndex = 49
        Me.lnk_CommunicationSkills.TabStop = True
        Me.lnk_CommunicationSkills.Tag = "txt_CommunicationSkills"
        Me.lnk_CommunicationSkills.Text = "Communication Skills"
        '
        'lnk_TechnicalSkills
        '
        Me.lnk_TechnicalSkills.AutoSize = True
        Me.lnk_TechnicalSkills.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_TechnicalSkills.Location = New System.Drawing.Point(45, 29)
        Me.lnk_TechnicalSkills.Name = "lnk_TechnicalSkills"
        Me.lnk_TechnicalSkills.Size = New System.Drawing.Size(116, 20)
        Me.lnk_TechnicalSkills.TabIndex = 44
        Me.lnk_TechnicalSkills.TabStop = True
        Me.lnk_TechnicalSkills.Tag = "txt_TechnicalSkills"
        Me.lnk_TechnicalSkills.Text = "Technical Skills"
        '
        'txt_CommunicationSkills
        '
        Me.txt_CommunicationSkills.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_CommunicationSkills.Location = New System.Drawing.Point(175, 89)
        Me.txt_CommunicationSkills.Name = "txt_CommunicationSkills"
        Me.txt_CommunicationSkills.ReadOnly = True
        Me.txt_CommunicationSkills.Size = New System.Drawing.Size(31, 26)
        Me.txt_CommunicationSkills.TabIndex = 47
        Me.txt_CommunicationSkills.Text = "0"
        Me.txt_CommunicationSkills.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_TechnicalSkills
        '
        Me.txt_TechnicalSkills.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_TechnicalSkills.Location = New System.Drawing.Point(175, 25)
        Me.txt_TechnicalSkills.Name = "txt_TechnicalSkills"
        Me.txt_TechnicalSkills.ReadOnly = True
        Me.txt_TechnicalSkills.Size = New System.Drawing.Size(31, 26)
        Me.txt_TechnicalSkills.TabIndex = 45
        Me.txt_TechnicalSkills.Text = "0"
        Me.txt_TechnicalSkills.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_ProblemSolving
        '
        Me.txt_ProblemSolving.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_ProblemSolving.Location = New System.Drawing.Point(175, 57)
        Me.txt_ProblemSolving.Name = "txt_ProblemSolving"
        Me.txt_ProblemSolving.ReadOnly = True
        Me.txt_ProblemSolving.Size = New System.Drawing.Size(31, 26)
        Me.txt_ProblemSolving.TabIndex = 46
        Me.txt_ProblemSolving.Text = "0"
        Me.txt_ProblemSolving.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lnk_ProblemSolving
        '
        Me.lnk_ProblemSolving.AutoSize = True
        Me.lnk_ProblemSolving.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_ProblemSolving.Location = New System.Drawing.Point(39, 63)
        Me.lnk_ProblemSolving.Name = "lnk_ProblemSolving"
        Me.lnk_ProblemSolving.Size = New System.Drawing.Size(122, 20)
        Me.lnk_ProblemSolving.TabIndex = 48
        Me.lnk_ProblemSolving.TabStop = True
        Me.lnk_ProblemSolving.Tag = "txt_ProblemSolving"
        Me.lnk_ProblemSolving.Text = "Problem Solving"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lnk_Professionalism)
        Me.GroupBox3.Controls.Add(Me.txt_Professionalism)
        Me.GroupBox3.Controls.Add(Me.lnk_Dependability)
        Me.GroupBox3.Controls.Add(Me.txt_Attendance)
        Me.GroupBox3.Controls.Add(Me.lnk_Attendance)
        Me.GroupBox3.Controls.Add(Me.lnk_Teamwork)
        Me.GroupBox3.Controls.Add(Me.txt_Dependability)
        Me.GroupBox3.Controls.Add(Me.txt_Teamwork)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 476)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(230, 186)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Behavioral Attributes (20%)"
        '
        'lnk_Professionalism
        '
        Me.lnk_Professionalism.AutoSize = True
        Me.lnk_Professionalism.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_Professionalism.Location = New System.Drawing.Point(35, 139)
        Me.lnk_Professionalism.Name = "lnk_Professionalism"
        Me.lnk_Professionalism.Size = New System.Drawing.Size(120, 20)
        Me.lnk_Professionalism.TabIndex = 57
        Me.lnk_Professionalism.TabStop = True
        Me.lnk_Professionalism.Tag = "txt_Professionalism"
        Me.lnk_Professionalism.Text = "Professionalism"
        '
        'txt_Professionalism
        '
        Me.txt_Professionalism.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Professionalism.Location = New System.Drawing.Point(175, 133)
        Me.txt_Professionalism.Name = "txt_Professionalism"
        Me.txt_Professionalism.ReadOnly = True
        Me.txt_Professionalism.Size = New System.Drawing.Size(31, 26)
        Me.txt_Professionalism.TabIndex = 56
        Me.txt_Professionalism.Text = "0"
        Me.txt_Professionalism.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lnk_Dependability
        '
        Me.lnk_Dependability.AutoSize = True
        Me.lnk_Dependability.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_Dependability.Location = New System.Drawing.Point(50, 97)
        Me.lnk_Dependability.Name = "lnk_Dependability"
        Me.lnk_Dependability.Size = New System.Drawing.Size(105, 20)
        Me.lnk_Dependability.TabIndex = 55
        Me.lnk_Dependability.TabStop = True
        Me.lnk_Dependability.Tag = "txt_Dependability"
        Me.lnk_Dependability.Text = "Dependability"
        '
        'txt_Attendance
        '
        Me.txt_Attendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Attendance.Location = New System.Drawing.Point(175, 27)
        Me.txt_Attendance.Name = "txt_Attendance"
        Me.txt_Attendance.ReadOnly = True
        Me.txt_Attendance.Size = New System.Drawing.Size(31, 26)
        Me.txt_Attendance.TabIndex = 51
        Me.txt_Attendance.Text = "0"
        Me.txt_Attendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lnk_Attendance
        '
        Me.lnk_Attendance.AutoSize = True
        Me.lnk_Attendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_Attendance.Location = New System.Drawing.Point(69, 30)
        Me.lnk_Attendance.Name = "lnk_Attendance"
        Me.lnk_Attendance.Size = New System.Drawing.Size(92, 20)
        Me.lnk_Attendance.TabIndex = 50
        Me.lnk_Attendance.TabStop = True
        Me.lnk_Attendance.Tag = "txt_Attendance"
        Me.lnk_Attendance.Text = "Attendance"
        '
        'lnk_Teamwork
        '
        Me.lnk_Teamwork.AutoSize = True
        Me.lnk_Teamwork.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_Teamwork.Location = New System.Drawing.Point(73, 65)
        Me.lnk_Teamwork.Name = "lnk_Teamwork"
        Me.lnk_Teamwork.Size = New System.Drawing.Size(82, 20)
        Me.lnk_Teamwork.TabIndex = 54
        Me.lnk_Teamwork.TabStop = True
        Me.lnk_Teamwork.Tag = "txt_Teamwork"
        Me.lnk_Teamwork.Text = "Teamwork"
        '
        'txt_Dependability
        '
        Me.txt_Dependability.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Dependability.Location = New System.Drawing.Point(175, 91)
        Me.txt_Dependability.Name = "txt_Dependability"
        Me.txt_Dependability.ReadOnly = True
        Me.txt_Dependability.Size = New System.Drawing.Size(31, 26)
        Me.txt_Dependability.TabIndex = 53
        Me.txt_Dependability.Text = "0"
        Me.txt_Dependability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Teamwork
        '
        Me.txt_Teamwork.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Teamwork.Location = New System.Drawing.Point(175, 59)
        Me.txt_Teamwork.Name = "txt_Teamwork"
        Me.txt_Teamwork.ReadOnly = True
        Me.txt_Teamwork.Size = New System.Drawing.Size(31, 26)
        Me.txt_Teamwork.TabIndex = 52
        Me.txt_Teamwork.Text = "0"
        Me.txt_Teamwork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lnk_GoalFulfillment)
        Me.GroupBox4.Controls.Add(Me.txt_Initiative)
        Me.GroupBox4.Controls.Add(Me.txt_GoalFulfillment)
        Me.GroupBox4.Controls.Add(Me.lnk_Initiative)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(288, 176)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(230, 101)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Goal Achievement (10%)"
        '
        'lnk_GoalFulfillment
        '
        Me.lnk_GoalFulfillment.AutoSize = True
        Me.lnk_GoalFulfillment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_GoalFulfillment.Location = New System.Drawing.Point(45, 31)
        Me.lnk_GoalFulfillment.Name = "lnk_GoalFulfillment"
        Me.lnk_GoalFulfillment.Size = New System.Drawing.Size(119, 20)
        Me.lnk_GoalFulfillment.TabIndex = 44
        Me.lnk_GoalFulfillment.TabStop = True
        Me.lnk_GoalFulfillment.Tag = "txt_GoalFulfillment"
        Me.lnk_GoalFulfillment.Text = "Goal Fulfillment"
        '
        'txt_Initiative
        '
        Me.txt_Initiative.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Initiative.Location = New System.Drawing.Point(178, 57)
        Me.txt_Initiative.Name = "txt_Initiative"
        Me.txt_Initiative.ReadOnly = True
        Me.txt_Initiative.Size = New System.Drawing.Size(31, 26)
        Me.txt_Initiative.TabIndex = 46
        Me.txt_Initiative.Text = "0"
        Me.txt_Initiative.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_GoalFulfillment
        '
        Me.txt_GoalFulfillment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_GoalFulfillment.Location = New System.Drawing.Point(178, 25)
        Me.txt_GoalFulfillment.Name = "txt_GoalFulfillment"
        Me.txt_GoalFulfillment.ReadOnly = True
        Me.txt_GoalFulfillment.Size = New System.Drawing.Size(31, 26)
        Me.txt_GoalFulfillment.TabIndex = 45
        Me.txt_GoalFulfillment.Text = "0"
        Me.txt_GoalFulfillment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lnk_Initiative
        '
        Me.lnk_Initiative.AutoSize = True
        Me.lnk_Initiative.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_Initiative.Location = New System.Drawing.Point(97, 63)
        Me.lnk_Initiative.Name = "lnk_Initiative"
        Me.lnk_Initiative.Size = New System.Drawing.Size(67, 20)
        Me.lnk_Initiative.TabIndex = 47
        Me.lnk_Initiative.TabStop = True
        Me.lnk_Initiative.Tag = "txt_Initiative"
        Me.lnk_Initiative.Text = "Initiative"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lnk_Flexibility)
        Me.GroupBox5.Controls.Add(Me.txt_Flexibility)
        Me.GroupBox5.Controls.Add(Me.txt_LearningAbility)
        Me.GroupBox5.Controls.Add(Me.lnk_LearningAbility)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox5.Location = New System.Drawing.Point(288, 283)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(230, 101)
        Me.GroupBox5.TabIndex = 26
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Adaptability (10%)"
        '
        'lnk_Flexibility
        '
        Me.lnk_Flexibility.AutoSize = True
        Me.lnk_Flexibility.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_Flexibility.Location = New System.Drawing.Point(93, 31)
        Me.lnk_Flexibility.Name = "lnk_Flexibility"
        Me.lnk_Flexibility.Size = New System.Drawing.Size(71, 20)
        Me.lnk_Flexibility.TabIndex = 48
        Me.lnk_Flexibility.TabStop = True
        Me.lnk_Flexibility.Tag = "txt_Flexibility"
        Me.lnk_Flexibility.Text = "Flexibility"
        '
        'txt_Flexibility
        '
        Me.txt_Flexibility.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Flexibility.Location = New System.Drawing.Point(178, 25)
        Me.txt_Flexibility.Name = "txt_Flexibility"
        Me.txt_Flexibility.ReadOnly = True
        Me.txt_Flexibility.Size = New System.Drawing.Size(31, 26)
        Me.txt_Flexibility.TabIndex = 49
        Me.txt_Flexibility.Text = "0"
        Me.txt_Flexibility.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_LearningAbility
        '
        Me.txt_LearningAbility.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_LearningAbility.Location = New System.Drawing.Point(178, 57)
        Me.txt_LearningAbility.Name = "txt_LearningAbility"
        Me.txt_LearningAbility.ReadOnly = True
        Me.txt_LearningAbility.Size = New System.Drawing.Size(31, 26)
        Me.txt_LearningAbility.TabIndex = 50
        Me.txt_LearningAbility.Text = "0"
        Me.txt_LearningAbility.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lnk_LearningAbility
        '
        Me.lnk_LearningAbility.AutoSize = True
        Me.lnk_LearningAbility.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_LearningAbility.Location = New System.Drawing.Point(48, 63)
        Me.lnk_LearningAbility.Name = "lnk_LearningAbility"
        Me.lnk_LearningAbility.Size = New System.Drawing.Size(116, 20)
        Me.lnk_LearningAbility.TabIndex = 51
        Me.lnk_LearningAbility.TabStop = True
        Me.lnk_LearningAbility.Tag = "txt_LearningAbility"
        Me.lnk_LearningAbility.Text = "Learning Ability"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lnk_ConflictResolution)
        Me.GroupBox6.Controls.Add(Me.lnk_DecisionMaking)
        Me.GroupBox6.Controls.Add(Me.lnk_TeamManagement)
        Me.GroupBox6.Controls.Add(Me.txt_ConflictResolution)
        Me.GroupBox6.Controls.Add(Me.txt_TeamManagement)
        Me.GroupBox6.Controls.Add(Me.txt_DecisionMaking)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox6.Location = New System.Drawing.Point(288, 390)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(230, 139)
        Me.GroupBox6.TabIndex = 25
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Leadership (10%)"
        '
        'lnk_ConflictResolution
        '
        Me.lnk_ConflictResolution.AutoSize = True
        Me.lnk_ConflictResolution.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_ConflictResolution.Location = New System.Drawing.Point(22, 103)
        Me.lnk_ConflictResolution.Name = "lnk_ConflictResolution"
        Me.lnk_ConflictResolution.Size = New System.Drawing.Size(142, 20)
        Me.lnk_ConflictResolution.TabIndex = 55
        Me.lnk_ConflictResolution.TabStop = True
        Me.lnk_ConflictResolution.Tag = "txt_ConflictResolution"
        Me.lnk_ConflictResolution.Text = "Conflict Resolution"
        '
        'lnk_DecisionMaking
        '
        Me.lnk_DecisionMaking.AutoSize = True
        Me.lnk_DecisionMaking.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_DecisionMaking.Location = New System.Drawing.Point(39, 37)
        Me.lnk_DecisionMaking.Name = "lnk_DecisionMaking"
        Me.lnk_DecisionMaking.Size = New System.Drawing.Size(125, 20)
        Me.lnk_DecisionMaking.TabIndex = 50
        Me.lnk_DecisionMaking.TabStop = True
        Me.lnk_DecisionMaking.Tag = "txt_DecisionMaking"
        Me.lnk_DecisionMaking.Text = "Decision Making"
        '
        'lnk_TeamManagement
        '
        Me.lnk_TeamManagement.AutoSize = True
        Me.lnk_TeamManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_TeamManagement.Location = New System.Drawing.Point(17, 71)
        Me.lnk_TeamManagement.Name = "lnk_TeamManagement"
        Me.lnk_TeamManagement.Size = New System.Drawing.Size(147, 20)
        Me.lnk_TeamManagement.TabIndex = 54
        Me.lnk_TeamManagement.TabStop = True
        Me.lnk_TeamManagement.Tag = "txt_TeamManagement"
        Me.lnk_TeamManagement.Text = "Team Management"
        '
        'txt_ConflictResolution
        '
        Me.txt_ConflictResolution.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_ConflictResolution.Location = New System.Drawing.Point(178, 97)
        Me.txt_ConflictResolution.Name = "txt_ConflictResolution"
        Me.txt_ConflictResolution.ReadOnly = True
        Me.txt_ConflictResolution.Size = New System.Drawing.Size(31, 26)
        Me.txt_ConflictResolution.TabIndex = 53
        Me.txt_ConflictResolution.Text = "0"
        Me.txt_ConflictResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_TeamManagement
        '
        Me.txt_TeamManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_TeamManagement.Location = New System.Drawing.Point(178, 65)
        Me.txt_TeamManagement.Name = "txt_TeamManagement"
        Me.txt_TeamManagement.ReadOnly = True
        Me.txt_TeamManagement.Size = New System.Drawing.Size(31, 26)
        Me.txt_TeamManagement.TabIndex = 52
        Me.txt_TeamManagement.Text = "0"
        Me.txt_TeamManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_DecisionMaking
        '
        Me.txt_DecisionMaking.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_DecisionMaking.Location = New System.Drawing.Point(178, 33)
        Me.txt_DecisionMaking.Name = "txt_DecisionMaking"
        Me.txt_DecisionMaking.ReadOnly = True
        Me.txt_DecisionMaking.Size = New System.Drawing.Size(31, 26)
        Me.txt_DecisionMaking.TabIndex = 51
        Me.txt_DecisionMaking.Text = "0"
        Me.txt_DecisionMaking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txt_remarks)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox7.Location = New System.Drawing.Point(288, 535)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(230, 127)
        Me.GroupBox7.TabIndex = 26
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Remarks"
        '
        'txt_remarks
        '
        Me.txt_remarks.Location = New System.Drawing.Point(6, 23)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(218, 96)
        Me.txt_remarks.TabIndex = 0
        Me.txt_remarks.Text = ""
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(448, 672)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(70, 30)
        Me.btn_Cancel.TabIndex = 28
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(372, 672)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(70, 30)
        Me.btn_Save.TabIndex = 27
        Me.btn_Save.Text = "&Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'cmb_employees
        '
        Me.cmb_employees.DropDownHeight = 200
        Me.cmb_employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_employees.FormattingEnabled = True
        Me.cmb_employees.IntegralHeight = False
        Me.cmb_employees.Location = New System.Drawing.Point(101, 103)
        Me.cmb_employees.Name = "cmb_employees"
        Me.cmb_employees.Size = New System.Drawing.Size(250, 28)
        Me.cmb_employees.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(330, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 20)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Rate :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_evalDate
        '
        Me.dt_evalDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dt_evalDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dt_evalDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_evalDate.Location = New System.Drawing.Point(101, 65)
        Me.dt_evalDate.Name = "dt_evalDate"
        Me.dt_evalDate.Size = New System.Drawing.Size(126, 26)
        Me.dt_evalDate.TabIndex = 32
        '
        'cb_Validated
        '
        Me.cb_Validated.AutoSize = True
        Me.cb_Validated.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cb_Validated.Location = New System.Drawing.Point(271, 676)
        Me.cb_Validated.Name = "cb_Validated"
        Me.cb_Validated.Size = New System.Drawing.Size(95, 24)
        Me.cb_Validated.TabIndex = 33
        Me.cb_Validated.Text = "Validated"
        Me.cb_Validated.UseVisualStyleBackColor = True
        '
        'txt_grand_Total
        '
        Me.txt_grand_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_grand_Total.Location = New System.Drawing.Point(388, 47)
        Me.txt_grand_Total.Name = "txt_grand_Total"
        Me.txt_grand_Total.ReadOnly = True
        Me.txt_grand_Total.Size = New System.Drawing.Size(105, 53)
        Me.txt_grand_Total.TabIndex = 34
        Me.txt_grand_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label10.Location = New System.Drawing.Point(489, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 31)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "%"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_rateDescription
        '
        Me.txt_rateDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rateDescription.Location = New System.Drawing.Point(388, 106)
        Me.txt_rateDescription.Name = "txt_rateDescription"
        Me.txt_rateDescription.ReadOnly = True
        Me.txt_rateDescription.Size = New System.Drawing.Size(109, 23)
        Me.txt_rateDescription.TabIndex = 36
        Me.txt_rateDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_evaluator
        '
        Me.cmb_evaluator.DropDownHeight = 200
        Me.cmb_evaluator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_evaluator.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_evaluator.FormattingEnabled = True
        Me.cmb_evaluator.IntegralHeight = False
        Me.cmb_evaluator.Location = New System.Drawing.Point(101, 143)
        Me.cmb_evaluator.Name = "cmb_evaluator"
        Me.cmb_evaluator.Size = New System.Drawing.Size(250, 28)
        Me.cmb_evaluator.TabIndex = 37
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Harmony.My.Resources.Resources.evaluation2
        Me.PictureBox1.Location = New System.Drawing.Point(8, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'FormEVALUATION_DETAILS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 721)
        Me.Controls.Add(Me.cmb_evaluator)
        Me.Controls.Add(Me.txt_rateDescription)
        Me.Controls.Add(Me.txt_grand_Total)
        Me.Controls.Add(Me.cb_Validated)
        Me.Controls.Add(Me.dt_evalDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmb_employees)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEVALUATION_DETAILS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Evaluation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_remarks As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents cmb_employees As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dt_evalDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cb_Validated As System.Windows.Forms.CheckBox
    Friend WithEvents txt_grand_Total As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_rateDescription As System.Windows.Forms.TextBox
    Friend WithEvents cmb_evaluator As System.Windows.Forms.ComboBox
    Friend WithEvents lnk_QualityOfWork As System.Windows.Forms.LinkLabel
    Friend WithEvents lnk_Consistency As System.Windows.Forms.LinkLabel
    Friend WithEvents txt_QualityOfWork As System.Windows.Forms.TextBox
    Friend WithEvents lnk_Productivity As System.Windows.Forms.LinkLabel
    Friend WithEvents txt_Productivity As System.Windows.Forms.TextBox
    Friend WithEvents txt_Consistency As System.Windows.Forms.TextBox
    Friend WithEvents lnk_CommunicationSkills As System.Windows.Forms.LinkLabel
    Friend WithEvents lnk_TechnicalSkills As System.Windows.Forms.LinkLabel
    Friend WithEvents txt_CommunicationSkills As System.Windows.Forms.TextBox
    Friend WithEvents txt_TechnicalSkills As System.Windows.Forms.TextBox
    Friend WithEvents txt_ProblemSolving As System.Windows.Forms.TextBox
    Friend WithEvents lnk_ProblemSolving As System.Windows.Forms.LinkLabel
    Friend WithEvents lnk_Professionalism As System.Windows.Forms.LinkLabel
    Friend WithEvents txt_Professionalism As System.Windows.Forms.TextBox
    Friend WithEvents lnk_Dependability As System.Windows.Forms.LinkLabel
    Friend WithEvents txt_Attendance As System.Windows.Forms.TextBox
    Friend WithEvents lnk_Attendance As System.Windows.Forms.LinkLabel
    Friend WithEvents lnk_Teamwork As System.Windows.Forms.LinkLabel
    Friend WithEvents txt_Dependability As System.Windows.Forms.TextBox
    Friend WithEvents txt_Teamwork As System.Windows.Forms.TextBox
    Friend WithEvents lnk_GoalFulfillment As System.Windows.Forms.LinkLabel
    Friend WithEvents txt_Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txt_GoalFulfillment As System.Windows.Forms.TextBox
    Friend WithEvents lnk_Initiative As System.Windows.Forms.LinkLabel
    Friend WithEvents lnk_Flexibility As System.Windows.Forms.LinkLabel
    Friend WithEvents txt_Flexibility As System.Windows.Forms.TextBox
    Friend WithEvents txt_LearningAbility As System.Windows.Forms.TextBox
    Friend WithEvents lnk_LearningAbility As System.Windows.Forms.LinkLabel
    Friend WithEvents lnk_ConflictResolution As System.Windows.Forms.LinkLabel
    Friend WithEvents lnk_DecisionMaking As System.Windows.Forms.LinkLabel
    Friend WithEvents lnk_TeamManagement As System.Windows.Forms.LinkLabel
    Friend WithEvents txt_ConflictResolution As System.Windows.Forms.TextBox
    Friend WithEvents txt_TeamManagement As System.Windows.Forms.TextBox
    Friend WithEvents txt_DecisionMaking As System.Windows.Forms.TextBox
End Class
