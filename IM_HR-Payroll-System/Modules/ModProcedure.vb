Option Explicit On
Imports System.IO
Imports System.Text.RegularExpressions
Module ModProcedure
    Dim xsize As Integer
    Public xID1, xID2 As Integer
    Public formOperation As String
    Public msgBox_header As String = "Harmony | HR & Payroll Management System"
    'load data in the listview
    Public Sub FillListView(ByVal sqlData As DataTable, ByVal lvList As ListView, ByVal imageID As Integer)
        Dim i As Integer
        Dim j As Integer
        'lvList.Refresh()
        lvList.Clear()
        For i = 0 To sqlData.Columns.Count - 1
            lvList.Columns.Add(sqlData.Columns(i).ColumnName)
        Next i

        For i = 0 To sqlData.Rows.Count - 1
            lvList.Items.Add(sqlData.Rows(i).Item(0), imageID)
            For j = 1 To sqlData.Columns.Count - 1
                If Not IsDBNull(sqlData.Rows(i).Item(j)) Then
                    lvList.Items(i).SubItems.Add(sqlData.Rows(i).Item(j))
                Else
                    lvList.Items(i).SubItems.Add("")
                End If
            Next j
        Next i

        For i = 0 To sqlData.Columns.Count - 1
            xsize = lvList.Width / sqlData.Columns.Count - 8
            'MsgBox(xsize)
            'If xsize > 1440 Then
            lvList.Columns(i).Width = -2
            'lvList.Columns(i).Width = xsize
            'Else
            '   lvList.Columns(i).Width = 2000
            'End If
            'lvList.Columns(i).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
        Next i
    End Sub

    Public Sub ShowForm1(frm As Form, operation As String, id1 As Integer)
        frm.MaximizeBox = False
        frm.MinimizeBox = False
        frm.FormBorderStyle = FormBorderStyle.FixedSingle
        frm.ShowIcon = False
        frm.ShowInTaskbar = False


        formOperation = operation
        xID1 = id1
        frm.ShowDialog()
    End Sub

    Public Sub ShowForm2(frm As Form, operation As String, id1 As Integer, id2 As Integer)
        frm.MaximizeBox = False
        frm.MinimizeBox = False
        frm.FormBorderStyle = FormBorderStyle.FixedSingle
        frm.ShowIcon = False
        frm.ShowInTaskbar = False

        formOperation = operation
        xID1 = id1
        xID2 = id2
        frm.ShowDialog()
    End Sub


    Public Sub Audit_Log(audit_string As String)
        sqlSTR = " Insert into Audit_Log(Audit_Description, Time_Stamp, Username)" & _
                    " Values ('" & audit_string & "', GETDATE(), '" & xUsername & "')"
        ExecuteSQLQuery(sqlSTR)
    End Sub


    Public Sub OnKeyboardEnter(ByVal control As Control, ByVal action As Action)
        ' Attach the KeyDown event handler
        AddHandler control.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                        If e.KeyCode = Keys.Enter Then
                                            e.SuppressKeyPress = True ' To prevent the beep sound on Enter
                                            action.Invoke() ' Run the passed action
                                        End If
                                    End Sub
    End Sub

    Public Sub RemoveCharacters(ByVal txtBox As TextBox, ByVal charsToRemove As String)
        ' Create a pattern for the specified characters
        Dim pattern As String = "[" & Regex.Escape(charsToRemove) & "]"

        ' Use Regex to replace the unwanted characters with an empty string
        txtBox.Text = Regex.Replace(txtBox.Text, pattern, "")
    End Sub


    '    Public Function str_Filter(ByVal Text As TextBox, ByVal ascKey1 As Integer, ByVal ascKey2 As Integer, ByVal ascKey3 As Integer, ByVal N_Repeat As Integer)
    '        On Error Resume Next
    '        '-----function dump all strings except
    '        Dim Delimeter As String
    '        Dim X As Long
    '        Dim intStr As String
    '        Dim NumberToRepeatCharacter As Integer

    '        'MsgBox(Chr(Asc(Text.Text)))
    '        'MsgBox(Asc(Text.Text))
    '        For X = 1 To Len(Text.Text)         'asckey1                                asckey2                              asckey3
    '            If Asc(Mid((Text.Text), X, 1)) >= ascKey1 And Asc(Mid((Text.Text), X, 1)) <= ascKey2 Or Asc(Mid(Text.Text, X, 1)) = ascKey3 Then
    '            Else
    '                Delimeter = Chr(Asc(Mid(Text.Text, X, 1)))
    '                'MsgBox(Delimeter)
    '            End If
    '        Next
    '        intStr = ""
    '        For X = 1 To Len(Text.Text)
    '            If N_Repeat > 0 Then
    '                If Asc(Mid(Text.Text, X, 1)) = ascKey3 Then
    '                    If NumberToRepeatCharacter >= N_Repeat Then
    '                        SendKeys.Send("{END}")
    '                        Exit For
    '                    End If
    '                    NumberToRepeatCharacter = NumberToRepeatCharacter + 1
    '                End If
    '            End If
    '            'If NumberToRepeatCharacter <> N_Repeat Then
    '            If Mid(Text.Text, X, 1) <> Delimeter Then
    '                intStr = intStr & Mid(Text.Text, X, 1)
    '                'NumberToRepeatCharacter = NumberToRepeatCharacter + 1
    '            Else
    '                'can be uncomment if you want
    '                'SendKeys.Send("{END}")
    '            End If
    '            ' Else
    '            ' SendKeys.Send("{END}")
    '            ' End If

    '            'NumberToRepeatCharacter = X
    '        Next
    '        'MsgBox(NumberToRepeatCharacter)
    '        str_Filter = intStr
    '    End Function
    '    Public Function filter_Special_Char(ByVal str As String)
    '        filter_Special_Char = Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(str, "!", ""), "@", ""), "#", ""), "$", ""), "%", ""), "^", ""), "&", ""), "*", ""), "(", ""), ")", ""), "_", ""), "+", "")
    '    End Function

    '    Public Function x_Access(ByRef xAccnt As String) As Boolean
    '        If UCase(xAccnt) <> UCase("Administrator") Then
    '            MsgBox("Only Administrator are allowed to access this module", MsgBoxStyle.Information, "Sales and Inventory")
    '            x_Access = False
    '        Else
    '            x_Access = True
    '        End If
    '    End Function
    '    Public Sub FormShow(ByVal frm As Form, ByVal edit As Boolean, ByVal iID As Integer, ByVal iID2 As Integer)
    '        If edit = True Then
    '            frm.Text = frm.Text & " - Edit"
    '        Else
    '            frm.Text = frm.Text & " - Add"
    '        End If
    '        If iID2 > 0 Then
    '            globalID = iID & "x" & iID2 ' pass current ID
    '        Else
    '            globalID = iID ' pass current ID
    '        End If
    '        frm.ShowDialog()
    '    End Sub
    '    Public Sub FormClose(ByVal frmstr As Form)
    '        Dim i As Integer
    '        If frmstr.Name <> "FrmBG" Then
    '            With MDIMain
    '                For i = 0 To .lstShortCut.Items.Count - 1
    '                    If UCase(.lstShortCut.Items(i).Text) = UCase(frmstr.Text) Then
    '                        .lstShortCut.Items(i).Remove()
    '                        frmstr.Close()
    '                        Exit For
    '                    End If
    '                Next
    '                If UCase(frmstr.Name) = UCase("frmreports") Then
    '                    frmstr.Close()
    '                ElseIf UCase(frmstr.Name) = UCase("frmreportsdated") Then
    '                    frmstr.Close()
    '                End If
    '            End With
    '        End If
    '    End Sub

    '    Public Sub ActivatedToolbar(ByVal frmstr As Form)

    '        'Debug.Print(frmstr.Name)
    '        'MDIREFRESH()

    '        With MDIMain
    '            Select Case UCase(frmstr.Name)
    '                Case UCase("frmsupplierslist")
    '                    MDIREFRESH()
    '                Case UCase("frmpurchaseorder")
    '                    MDIREFRESH()
    '                Case UCase("frmstockmonitoringbalances")
    '                    MDIREFRESH()

    '                    .cmdNew.Enabled = False
    '                    .cmdEdit.Enabled = False
    '                    .cmdDelete.Enabled = True

    '                Case UCase("FrmCATLIST")
    '                    MDIREFRESH()

    '                    '.cmdNew.Enabled = False
    '                    '.cmdEdit.Enabled = False
    '                    '.cmdDelete.Enabled = False



    '                Case UCase("frmproducts_reorder")
    '                    MDIREFRESH()

    '                    .cmdNew.Enabled = False
    '                    .cmdEdit.Enabled = False
    '                    .cmdSearch.Enabled = False
    '                    .cmdDelete.Enabled = False

    '                Case UCase("FrmDEFFECTIVE_RETURN_STOCKS")
    '                    MDIREFRESH()
    '                    .cmdDelete.Enabled = False

    '                Case UCase("frmorder_form")
    '                    MDIREFRESH()

    '                Case UCase("frmposreceipt_list")

    '                    .cmdNew.Enabled = False
    '                    .cmdEdit.Enabled = False
    '                    .cmdDelete.Enabled = False
    '                    .cmdRefresh.Enabled = True
    '                    .cmdSearch.Enabled = True
    '                    .cmdPrint.Enabled = True
    '                    .cmdClose.Enabled = True
    '                    '.cmdPrint.Enabled = False

    '                Case UCase("frmposcashier")
    '                    'MDIDISABLED()

    '                    .cmdNew.Enabled = False
    '                    .cmdEdit.Enabled = False
    '                    .cmdSearch.Enabled = False
    '                    .cmdDelete.Enabled = False
    '                    .cmdRefresh.Enabled = False
    '                    .cmdPrint.Enabled = False
    '                    .cmdClose.Enabled = True

    '                Case UCase("frmphysicalcount")
    '                    .cmdNew.Enabled = True
    '                    .cmdEdit.Enabled = True
    '                    .cmdSearch.Enabled = False
    '                    .cmdDelete.Enabled = True
    '                    .cmdRefresh.Enabled = True
    '                    .cmdPrint.Enabled = True
    '                    .cmdClose.Enabled = True

    '                Case UCase("frmsuppliersproduct")
    '                    .cmdNew.Enabled = False
    '                    .cmdEdit.Enabled = False
    '                    .cmdDelete.Enabled = False

    '                Case UCase("frmcatitemlist")
    '                    MDIREFRESH()

    '                Case UCase("frmreports")
    '                    MDIDISABLED()
    '                    .cmdClose.Enabled = True

    '                Case UCase("frmreportsdated")
    '                    MDIDISABLED()
    '                    .cmdClose.Enabled = True

    '                Case UCase("frmaudit_trail")
    '                    .cmdNew.Enabled = False
    '                    .cmdEdit.Enabled = False
    '                    .cmdSearch.Enabled = False
    '                    .cmdDelete.Enabled = False
    '                    .cmdRefresh.Enabled = True
    '                    .cmdPrint.Enabled = True
    '                    .cmdClose.Enabled = True
    '                Case UCase("frmbg")
    '                    MDIDISABLED()

    '                Case UCase("frmCANVASS_FORM")
    '                    .cmdNew.Enabled = True
    '                    .cmdEdit.Enabled = True
    '                    .cmdSearch.Enabled = True
    '                    .cmdDelete.Enabled = True
    '                    .cmdRefresh.Enabled = True
    '                    .cmdPrint.Enabled = False
    '                    .cmdClose.Enabled = True
    '            End Select
    '        End With
    '    End Sub
    '    Public Sub Audit_Trail(ByVal user_ID As Integer, ByVal xtime As String, ByVal xAction As String)
    '        'For i = 1 To 800
    '        sqlSTR = "INSERT INTO TBL_Audit_Trail (User_ID, Action, Date, Timex, log_ID) " & _
    '                 "VALUES (" & user_ID & ", " _
    '                            & "'" & xAction & "', " _
    '                            & "'" & Format(Now, "MM/dd/yyyy") & "', " _
    '                            & "'" & xtime & "', " _
    '                            & LOGID & ")"
    '        ExecuteSQLQuery(sqlSTR)
    '        ' Next
    '    End Sub

    Public Sub writeFileStrData(ByVal MyData As Object, ByVal filePath As String, Optional ByVal transType As String = "", Optional ByVal dataEncoding As String = "")

        Dim Str As String
        Dim fs As FileStream
        Dim tempBytes() As Byte

        tempBytes = Nothing

        If transType = "" Then
            transType = "Append" 'Set default 
        End If

        If dataEncoding = "" Then
            dataEncoding = "ANSI"
        End If

        Try
            Str = CType(MyData, String)
            'Str = CType(Split(MyData, "-")(0) & Chr(10) & Chr(13) & Split(MyData, "-")(1), String)
            'MsgBox(Str)
            If dataEncoding = "ANSI" Then
                tempBytes = System.Text.Encoding.Default.GetBytes(Str)
            ElseIf dataEncoding = "Unicode" Then
                tempBytes = System.Text.Encoding.Unicode.GetBytes(Str)
            End If

            fs = New FileStream(filePath, FileMode.Create, FileAccess.Write)
            If transType = "Append" Then
                fs.Seek(0, SeekOrigin.End)
            ElseIf transType = "Overwrite" Then
                fs.Seek(0, SeekOrigin.Begin)
            End If

            fs.Write(tempBytes, 0, tempBytes.Length)
            fs.Close()
        Catch ex As Exception

            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
        End Try

    End Sub


    '    Public Function R_eplace(ByVal str As String)
    '        Return Replace(Replace(Replace(str, "'", "$.$"), ",", "$..$"), "`", "")
    '    End Function
    '    Public Function R_Change(ByVal str As String)
    '        If Len(str) > 0 Then
    '            Return Replace(Replace(Replace(str, "$.$", "'"), "$..$", ","), "`", "")
    '        Else
    '            Return ""
    '        End If
    '    End Function
    Public Sub TextChangeDelay(textBox As TextBox, functionName As Action(Of String), interval As Integer)
        ' Create a new instance of the DelayedTextChangedHandler class
        Dim handler As New DelayedTextChangedHandler(textBox, interval, functionName)
    End Sub

    Public Sub CenterGroupBoxRelativeToListView(groupBox As GroupBox, listView As ListView)
        ' Get the center of the ListView
        Dim listViewCenterX As Integer = listView.Left + (listView.Width \ 2)
        Dim listViewCenterY As Integer = listView.Top + (listView.Height \ 2)

        ' Calculate the new location for the GroupBox so it is centered relative to the ListView
        Dim newGroupBoxX As Integer = listViewCenterX - (groupBox.Width \ 2)
        Dim newGroupBoxY As Integer = listViewCenterY - (groupBox.Height \ 2)

        ' Set the new location of the GroupBox
        groupBox.Location = New Point(newGroupBoxX, newGroupBoxY)
    End Sub

End Module

Public Class DelayedTextChangedHandler
    Private ReadOnly _timer As Timer
    Private ReadOnly _textBox As TextBox
    Private ReadOnly _onDelayedTextChanged As Action(Of String)

    ' Constructor to initialize the handler with the TextBox, interval, and the callback function
    Public Sub New(textBox As TextBox, interval As Integer, onDelayedTextChanged As Action(Of String))
        _textBox = textBox
        _onDelayedTextChanged = onDelayedTextChanged

        ' Create and configure the timer
        _timer = New Timer()
        _timer.Interval = interval
        AddHandler _timer.Tick, AddressOf TimerTick

        ' Subscribe to the TextChanged event of the TextBox
        AddHandler _textBox.TextChanged, AddressOf OnTextChanged
    End Sub

    ' TextChanged event handler for the TextBox
    Private Sub OnTextChanged(sender As Object, e As EventArgs)
        ' Restart the timer whenever text changes
        _timer.Stop()
        _timer.Start()
    End Sub

    ' Timer tick event that fires after the delay
    Private Sub TimerTick(sender As Object, e As EventArgs)
        ' Stop the timer and invoke the callback function with the current text
        _timer.Stop()
        _onDelayedTextChanged.Invoke(_textBox.Text)
    End Sub

    ' Dispose of the timer and unsubscribe from events when done
    Public Sub Dispose()
        RemoveHandler _textBox.TextChanged, AddressOf OnTextChanged
        RemoveHandler _timer.Tick, AddressOf TimerTick
        _timer.Dispose()
    End Sub

    
End Class