Public Class FormPAYROLL_PAYEE

    Private Sub FormPAYROLL_PAYEE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_NumberHandler()
        TextBox_BasicPayCompute("BasicPay")
    End Sub

    Private Sub TextBox_NumberHandler()
        ' Loop through all controls in the form
        For Each ctrl As Control In Me.Controls
            ' Check if the control is a GroupBox
            If TypeOf ctrl Is GroupBox Then
                ' Loop through all controls in the GroupBox
                For Each gbCtrl As Control In CType(ctrl, GroupBox).Controls
                    ' Check if the control is a TextBox
                    If TypeOf gbCtrl Is TextBox Then
                        ' Add the KeyPress event handler
                        AddHandler CType(gbCtrl, TextBox).KeyPress, AddressOf TextBox_KeyPress
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub TextBox_BasicPayCompute(tag As String)
        ' Loop through all controls in the form
        For Each ctrl As Control In Me.Controls
            ' Check if the control is a GroupBox
            If TypeOf ctrl Is GroupBox Then
                ' Loop through all controls in the GroupBox
                For Each gbCtrl As Control In CType(ctrl, GroupBox).Controls
                    ' Check if the control is a TextBox and has the specified tag
                    If TypeOf gbCtrl Is TextBox AndAlso gbCtrl.Tag IsNot Nothing AndAlso gbCtrl.Tag.ToString() = tag Then
                        ' Add the TextChanged event handler
                        AddHandler CType(gbCtrl, TextBox).TextChanged, AddressOf BasicPayCompute
                    End If
                Next
            End If
        Next
    End Sub


    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Allow control keys, numbers, and a single period
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        Dim textBox As TextBox = CType(sender, TextBox)
        If (e.KeyChar = "."c) AndAlso (textBox.Text.IndexOf("."c) > -1) Then
            e.Handled = True

        End If

        
    End Sub

    Private Sub BasicPayCompute(sender As Object, e As EventArgs)
        txt_totalRegular.Text = Val(txt_payRegular.Text) * Val(txt_numRegular.Text)
        txt_totalSpecial.Text = Val(txt_paySpecial.Text) * Val(txt_numSpecial.Text)
        txt_totalField.Text = Val(txt_payField.Text) * Val(txt_numField.Text)
        txt_totalHoliday.Text = Val(txt_payHoliday.Text) * Val(txt_numHoliday.Text)
        txt_totalOvertime.Text = Val(txt_payOvertime.Text) * Val(txt_numOvertime.Text)
        txt_totalNightDiff.Text = Val(txt_payNightDiff.Text) * Val(txt_numNightDiff.Text)
    End Sub


    Private Sub txt_payRegular_TextChanged(sender As Object, e As EventArgs) Handles txt_payRegular.TextChanged

    End Sub
End Class