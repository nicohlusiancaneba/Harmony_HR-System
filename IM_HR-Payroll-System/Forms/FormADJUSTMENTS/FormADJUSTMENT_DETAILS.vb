﻿Public Class FormADJUSTMENT_DETAILS
    Dim Adjustment_ID As Integer
    Dim approved As String
    Private Sub FormADJUSTMENT_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlSTR = "select * from Employees where Employment_Status != 'Resigned' or Employment_Status != 'Terminated' " & _
                " order by Last_Name, First_Name"
        FILLComboBox_Employee(sqlSTR, cmb_employees)


        If formOperation = "edit" Then
            Dim date_adjusted As String = ""
            Adjustment_ID = xID1
            sqlSTR = "SELECT *, CONCAT(Employees.Employee_ID, ' - ', Last_Name, ', ', First_Name, ', ', Middle_Name) as Employee " & _
                        "FROM Adjustments " & _
                        "INNER JOIN Employees on Employees.Employee_ID = Adjustments.Employee_ID " & _
                        "where Adjustment_ID =" & Adjustment_ID
            ExecuteSQLQuery(sqlSTR)

            cmb_employees.Text = sqlDT.Rows(0)("Employee").ToString
            txt_New.Text = sqlDT.Rows(0)("New_Value").ToString
            txt_Prev.Text = sqlDT.Rows(0)("Prev_Value").ToString
            approved = sqlDT.Rows(0)("Adj_Approved").ToString
            dt_dateAdj.Text = sqlDT.Rows(0)("Date_Adjusted").ToString
            cmb_adjustmentType.Text = sqlDT.Rows(0)("Adjustment_Type").ToString

            If approved = "Yes" Then
                cb_Approved.Checked = True
                cb_Approved.Enabled = False
                cmb_employees.Enabled = False
                cmb_adjustmentType.Enabled = False
                txt_New.ReadOnly = True
                btn_Save.Enabled = False

                Label1.Visible = True
                dt_dateAdj.Visible = True
            Else
                cb_Approved.Checked = False
                cb_Approved.Enabled = True
                cmb_employees.Enabled = True
                cmb_adjustmentType.Enabled = True
                txt_New.ReadOnly = False
                btn_Save.Enabled = True

                Label1.Visible = False
                dt_dateAdj.Visible = False
            End If
        Else
            cmb_employees.Text = ""
            cmb_adjustmentType.Text = ""
            txt_New.Text = ""
            txt_Prev.Text = ""
            cb_Approved.Checked = False
        End If
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If Val(txt_New.Text) = Val(txt_Prev.Text) Then
            MsgBox("Value Invalid, try again.", MsgBoxStyle.Exclamation, msgBox_header)
            Exit Sub
        End If

        If formOperation = "edit" Then
            sqlSTR = "UPDATE Adjustments SET " & _
                      "Adjustment_Type = '" & cmb_adjustmentType.Text & "', " & _
                      "New_Value = '" & txt_New.Text & "', " & _
                      "Prev_Value = '" & txt_Prev.Text & "', " & _
                      "Encoded_by = '" & xUsername & "' " & _
                      "WHERE Adjustment_ID = " & Adjustment_ID
            ExecuteSQLQuery(sqlSTR)
        Else
            sqlSTR = "INSERT INTO Adjustments (Employee_ID, Adjustment_Type, New_Value, Prev_Value, Encoded_by, Adj_Approved) " & _
                                    "VALUES ('" & Split(cmb_employees.Text, " - ")(0) & "', '" & cmb_adjustmentType.Text & "', '" & txt_New.Text & "', '" & txt_Prev.Text & "', '" & xUsername & "', 'No')"
            ExecuteSQLQuery(sqlSTR)
        End If



        If cb_Approved.Checked Then
            If MsgBox("Do you want to approve this adjustment record? Please note that once approved, you cannot undo this action.", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, msgBox_header) = MsgBoxResult.Yes Then
                Dim type As String = ""
                If cmb_adjustmentType.Text = "Salary" Then
                    type = "Current_Daily_Rate "
                ElseIf cmb_adjustmentType.Text = "SSS" Then
                    type = "SSS_Share"
                ElseIf cmb_adjustmentType.Text = "Pag-Ibig" Then
                    type = "Pag_ibig_Share"
                ElseIf cmb_adjustmentType.Text = "Philhealth" Then
                    type = "Philhealth_Share"
                ElseIf cmb_adjustmentType.Text = "Tax" Then
                    type = "Tax_Amount"
                End If

                sqlSTR = "Update Employees set " & type & " = '" & txt_New.Text & "'  where Employee_ID=" & Split(cmb_employees.Text, " - ")(0)
                ExecuteSQLQuery(sqlSTR)

                sqlSTR = "Update Adjustments set Date_Adjusted='" & DateTime.Now.ToString("MM/dd/yyyy") & "', Adj_Approved='Yes', Approved_by='" & xUsername & "' where Adjustment_ID=" & Adjustment_ID
                ExecuteSQLQuery(sqlSTR)
                MsgBox("Succesfully APPROVED adjustment record.", MsgBoxStyle.Information, msgBox_header)
            Else
                MsgBox("Succesfully saved adjustment record.", MsgBoxStyle.Information, msgBox_header)
            End If
        Else
            MsgBox("Succesfully saved adjustment record.", MsgBoxStyle.Information, msgBox_header)
        End If


        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub cmb_adjustmentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_adjustmentType.SelectedIndexChanged
        If cmb_employees.Text = "" Then Exit Sub

        sqlSTR = "select Current_Daily_Rate, SSS_Share, Philhealth_Share, Tax_Amount, Pag_ibig_Share from Employees where Employee_ID =" & Split(cmb_employees.Text, " - ")(0)
        ExecuteSQLQuery(sqlSTR)

        If cmb_adjustmentType.Text = "Salary" Then
            txt_Prev.Text = sqlDT.Rows(0)("Current_Daily_Rate").ToString
        ElseIf cmb_adjustmentType.Text = "SSS" Then
            txt_Prev.Text = sqlDT.Rows(0)("SSS_Share").ToString
        ElseIf cmb_adjustmentType.Text = "Pag-Ibig" Then
            txt_Prev.Text = sqlDT.Rows(0)("Pag_ibig_Share").ToString
        ElseIf cmb_adjustmentType.Text = "Philhealth" Then
            txt_Prev.Text = sqlDT.Rows(0)("Philhealth_Share").ToString
        ElseIf cmb_adjustmentType.Text = "Tax" Then
            txt_Prev.Text = sqlDT.Rows(0)("Tax_Amount").ToString
        End If
    End Sub


End Class