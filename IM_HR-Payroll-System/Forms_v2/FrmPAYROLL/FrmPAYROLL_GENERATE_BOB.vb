Public Class FrmPAYROLL_GENERATE_BOB

    Private Sub FrmPAYROLL_GENERATE_BOB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_payroll.Items.Clear()
        dgv_payroll.Rows.Clear()
        txt_totalNet.Text = "0.00"
    End Sub

    Private Sub Fill_Payroll_ComboBox()
        FILLComboBox("select Payroll_ID, Payroll_Remarks from Payroll where Cutoff_Date_Start >= '" & dt_start.Text & "' and Cutoff_Date_End <= '" & dt_end.Text & "' and Payroll_Approved='Yes' order by Payroll_ID", cmb_payroll)
    End Sub

    Private Sub dt_start_ValueChanged(sender As Object, e As EventArgs) Handles dt_start.ValueChanged
        Fill_Payroll_ComboBox()
    End Sub

    Private Sub dt_end_ValueChanged(sender As Object, e As EventArgs) Handles dt_end.ValueChanged
        Fill_Payroll_ComboBox()
    End Sub


    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        lst_payroll.Items.Clear()
        dgv_payroll.Rows.Clear()
        txt_totalNet.Text = "0.00"
    End Sub

    'Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
    '    If cmb_payroll.Text <> "" Then
    '        lst_payroll.Items.Add(Split(cmb_payroll.Text, " - ")(0))
    '        lst_payroll.Items(lst_payroll.Items.Count - 1).SubItems.Add(Split(cmb_payroll.Text, " - ")(1))
    '    End If

    'End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If cmb_payroll.Text <> "" Then
            ' 1. Split the text once and store it
            Dim parts As String() = Split(cmb_payroll.Text, " - ")
            Dim newEmpID As String = parts(0)
            Dim newEmpValue As String = parts(1)

            ' 2. Check if Column 0 already contains this value
            For Each item As ListViewItem In lst_payroll.Items
                If item.Text = newEmpID Then
                    MessageBox.Show("This item is already added to the payroll list!", "Duplicate Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub ' Stop running the code right here
                End If
            Next

            ' 3. If it doesn't exist, go ahead and add it safely
            Dim newItem As New ListViewItem(newEmpID)
            newItem.SubItems.Add(newEmpValue)
            lst_payroll.Items.Add(newItem)
        End If
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        lst_payroll.Focus()
        If lst_payroll.Items.Count > 0 Then
            lst_payroll.FocusedItem.Remove()
        End If
    End Sub

    Private Sub btn_generateData_Click(sender As Object, e As EventArgs) Handles btn_generateData.Click
        dgv_payroll.Rows.Clear()
        Dim payroll_id As String = ""
        If lst_payroll.Items.Count > 1 Then
            'For i = 0 To lst_payroll.Items.Count - 1
            '    If i = lst_payroll.Items.Count - 1 Then
            '        payroll_id &= lst_payroll.Items(i).Text
            '    Else
            '        payroll_id &= lst_payroll.Items(i).Text & ","
            '    End If

            'Next

            payroll_id = String.Join(",", lst_payroll.Items.Cast(Of ListViewItem)().Select(Function(x) x.Text))
        Else
            MsgBox("Minimum number of Payroll (2) to generate is not met, try again.")
            Exit Sub
        End If

        sqlSTR = "select Payroll_Account_Number, TRIM(Last_Name) as Last_Name, TRIM(First_Name) as First_Name, TRIM(Middle_Name) as Middle_Name, grandTotal_Net from Payroll_Details " & _
                    "inner join Employees on Employees.Employee_ID = Payroll_Details.Employee_ID " & _
                    "where Payroll_ID in " & _
                    "( " & _
                    payroll_id & _
                    ") " & _
                    "and COALESCE(Payroll_Account_Number, '') !=''"
        ExecuteSQLQuery(sqlSTR)
        dgv_payroll.Rows.Clear()


        If sqlDT.Rows.Count > 0 Then
            dgv_payroll.Columns("Account_No").DefaultCellStyle.Format = "@"
            Dim total_net As Double = 0
            For i = 0 To sqlDT.Rows.Count - 1
                total_net = total_net + CDbl(sqlDT.Rows(i)("grandTotal_Net").ToString())
                dgv_payroll.Rows.Add(
                    " " & sqlDT.Rows(i)("Payroll_Account_Number").ToString() & " ",
                    sqlDT.Rows(i)("Last_Name").ToString(),
                    sqlDT.Rows(i)("First_Name").ToString(),
                    sqlDT.Rows(i)("Middle_Name").ToString(),
                    sqlDT.Rows(i)("grandTotal_Net").ToString())
            Next
            txt_totalNet.Text = total_net.ToString("N2")

        End If

        'MsgBox("Data copied to clipboard.", MsgBoxStyle.Information, msgBox_header)
    End Sub
End Class