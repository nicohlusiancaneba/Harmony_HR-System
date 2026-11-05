Public Class FrmINCIDENT_DETAILS_ACTION
    Dim edit, formloaded As Boolean
    Private Sub FrmINCIDENT_DETAILS_ACTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        edit = FrmINCIDENT_DETAILS.edit

        inputText_ChangedHandler(Me)
        inputNum_ChangedHandler(Me)
        ClearGroupBoxInputs(grpAction)

        formloaded = False

        cmb_employees.Items.Clear()
        cmb_actionTaken.SelectedIndex = -1



        With FrmINCIDENT_DETAILS.dgv_actionTaken
            If edit Then
                cmb_employees.Enabled = False
                cmb_employees.Items.Add(.CurrentRow.Cells("Employee_ID3").Value.ToString & " - " & .CurrentRow.Cells("Subject_Employee3").Value.ToString)


                cmb_employees.Text = .CurrentRow.Cells("Employee_ID3").Value.ToString & " - " & .CurrentRow.Cells("Subject_Employee3").Value.ToString
                cmb_actionTaken.Text = .CurrentRow.Cells("ActionTaken").Value.ToString
                txt_details.Text = .CurrentRow.Cells("Details").Value.ToString
                dt_start.Text = .CurrentRow.Cells("Start_Date").Value.ToString
                dt_end.Text = .CurrentRow.Cells("End_Date").Value.ToString
                dt_decision.Text = .CurrentRow.Cells("Decision_Date").Value.ToString
                txt_decidedBy.Text = .CurrentRow.Cells("Decided_By").Value.ToString



            Else
                With FrmINCIDENT_DETAILS.dgv_employees
                    For Each row As DataGridViewRow In .Rows
                        If row.IsNewRow Then Continue For
                        cmb_employees.Items.Add(Convert.ToString(row.Cells("Employee_ID").Value) & " - " & Convert.ToString(row.Cells("Employee_Name").Value))
                    Next
                End With

                cmb_employees.Enabled = True
            End If
        End With

        formloaded = True
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub


    Private Function holdSave() As Boolean
        If cmb_employees.Text = "" Then
            MsgBox("No selected employee, try again.", MsgBoxStyle.Information)
            Return True
        End If

        If cmb_actionTaken.Text = "" Then
            MsgBox("Action Taken cannot be blank.", MsgBoxStyle.Information)
            Return True
        End If

        If txt_details.Text = "" Then
            MsgBox("Details cannot be blank.", MsgBoxStyle.Information)
            Return True
        End If

        If dt_start.Value.Date > dt_end.Value.Date Then
            MsgBox("Start date cannot be later than End date.", MsgBoxStyle.Information)
            Return True
        End If

        If txt_decidedBy.Text = "" Then
            MsgBox("Decided by cannot be blank.", MsgBoxStyle.Information)
            Return True
        End If

        Return False
    End Function

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If holdSave() Then Exit Sub

        With FrmINCIDENT_DETAILS.dgv_actionTaken
            If cmb_actionTaken.Text = "No Action Required" Then
                dt_start.Tag = ""
                dt_end.Tag = ""
            Else
                dt_start.Tag = dt_start.Text
                dt_end.Tag = dt_end.Text
            End If

            If edit Then

                .CurrentRow.Cells("ActionTaken").Value = cmb_actionTaken.Text
                .CurrentRow.Cells("Details").Value = txt_details.Text
                .CurrentRow.Cells("Start_Date").Value = dt_start.Tag
                .CurrentRow.Cells("End_Date").Value = dt_end.Tag
                .CurrentRow.Cells("Decision_Date").Value = dt_decision.Text
                .CurrentRow.Cells("Decided_By").Value = txt_decidedBy.Text

            Else

                .Rows.Add(
                    cmb_actionTaken.Text,
                    txt_details.Text,
                    dt_start.Tag,
                    dt_end.Tag,
                    dt_decision.Text,
                    txt_decidedBy.Text,
                    Split(cmb_employees.Text, " - ")(0),
                    Split(cmb_employees.Text, " - ")(1))

            End If
        End With

        Me.Close()
    End Sub

    Private Sub cmb_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_actionTaken.SelectedIndexChanged
        If cmb_actionTaken.Text = "No Action Required" Then
            dt_start.Enabled = False
            dt_end.Enabled = False
        Else
            dt_start.Enabled = True
            dt_end.Enabled = True
        End If
    End Sub

    Private Sub cmb_employees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_employees.SelectedIndexChanged
        If Not edit Then
            For Each row As DataGridViewRow In FrmINCIDENT_DETAILS.dgv_actionTaken.Rows
                If row.IsNewRow Then Continue For

                If Convert.ToString(row.Cells("Employee_ID3").Value).Trim() = Split(cmb_employees.Text, " - ")(0) Then
                    MsgBox("An action is already assigned to this employee. Please check and try again.", MsgBoxStyle.Information)
                    cmb_employees.SelectedIndex = -1
                    Exit For
                End If
            Next
        End If
       
    End Sub
End Class