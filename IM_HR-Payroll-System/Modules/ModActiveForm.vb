Module ModActiveForm

    Public Sub FormAdd(ByVal frmStr As String)
        Select UCase(frmStr)
            Case UCase("FrmEMPLOYEES")
                With FrmEMPLOYEES
                    .formAction = "add"
                    FrmEMPLOYEE_DETAILS.ShowDialog()
                    .Refresh_List()
                End With

        End Select

        '    Case UCase("FrmSuppliersList")
        '        With FrmSuppliersList
        '            .formAction = "add"
        '            FrmSUPPLIER_DETAILS.ShowDialog()
        '            .RefreshList()
        '        End With
    End Sub


    Public Sub FormEdit(ByVal frmStr As String)
        Select Case UCase(frmStr)
            Case UCase("FrmEMPLOYEES")
                With FrmEMPLOYEES
                    .dgv_employees.Focus()
                    If .dgv_employees.Rows.Count > 0 Then
                        .formAction = "edit"
                        FrmEMPLOYEE_DETAILS.ShowDialog()
                        .Refresh_List()
                    End If
                End With

        End Select
        'Case UCase("FrmPHYSICAL_COUNT")
        'With FrmPHYSICAL_COUNT
        '    .lstphysical.Focus()
        '    If .lstphysical.Items.Count > 0 Then
        '        .formAction = "edit"
        '        .P_ID = .lstphysical.FocusedItem.Text
        '        FrmPHYSICAL_COUNT_DETAILS.ShowDialog()
        '        .Refresh_List()
        '    End If
        'End With
    End Sub

    Public Sub FormDelete(ByVal frmStr As String)
        Select Case UCase(frmStr)

        End Select
        'Case UCase("FrmPHYSICAL_COUNT")
        'With FrmPHYSICAL_COUNT
        '    .lstphysical.Focus()
        '    If .lstphysical.Items.Count > 0 Then
        '        If .lstphysical.FocusedItem.SubItems(9).Text = "Yes" Then
        '            MsgBox("You cannot delete an APPROVED Physical Count record.")
        '            Exit Sub
        '        Else
        '            If MsgBox("Do you really want to delete this Physical Count record? This cannot be undone.", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
        '                sqlSTR = "DELETE FROM TBL_Physical_Count WHERE P_ID ='" & .lstphysical.FocusedItem.Text & "';"
        '                ExecuteSQLQuery(sqlSTR)

        '                sqlSTR = "DELETE FROM TBL_Physical_Count_Details WHERE P_ID ='" & .lstphysical.FocusedItem.Text & "';"
        '                ExecuteSQLQuery(sqlSTR)

        '                .Refresh_List()
        '            End If
        '        End If
        '    End If
        'End With
    End Sub

    Public Sub FormSearch(ByVal frmStr As String)
        Select Case UCase(frmStr)
            Case UCase("FrmEMPLOYEES")
                With FrmEMPLOYEES
                    center_RelativeTo(.lst_employees, .grpFilter)
                    .grpFilter.Visible = True
                End With
        End Select
        'Case UCase("FrmPHYSICAL_COUNT")
        'With FrmPHYSICAL_COUNT
        '    center_RelativeTo(.lstphysical, .grpFilter)
        '    .grpFilter.Visible = True
        'End With
    End Sub

    Public Sub RefreshList(ByVal frmStr As String)
        Select Case UCase(frmStr)
            Case UCase("FrmEMPLOYEES")
                With FrmEMPLOYEES
                    .whereSQL = " and Employment_Status != 'Terminated' and Employment_Status != 'Resigned' "
                    .grpFilter.Visible = False
                    .Refresh_List()
                End With
        End Select
        'Case UCase("FrmPHYSICAL_COUNT")
        'With FrmPHYSICAL_COUNT
        '    .whereSQL = " and (CAST(P_Date AS DATE) = CAST(GETDATE() AS DATE) or COALESCE(P_Approved, 'No') = 'No') "
        '    .Refresh_List()
        'End With
    End Sub

End Module
