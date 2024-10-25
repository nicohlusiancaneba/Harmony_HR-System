Public Class FormLEAVE_DETAILS


    Private Sub FormLEAVE_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlSTR = "Select * from employees where Employment_Status != 'Resigned' or Employment_Status != 'Terminated' order by Last_Name, First_Name"
        FILLComboBox_Employee(sqlSTR, cmb_employees)

        If formOperation = "edit" Then

        Else

        End If

    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click

        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub
End Class