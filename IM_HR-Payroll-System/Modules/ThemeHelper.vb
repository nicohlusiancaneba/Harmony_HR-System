Imports System.Drawing
Imports System.Windows.Forms

Public Module ThemeHelper
    Public ReadOnly HighlightColor As Color = Color.FromArgb(29, 135, 112)
    Public ReadOnly HighlightTextColor As Color = Color.White

    ' Call once at startup (e.g. main form Load) to recolor all menus and toolbars
    Public Sub InstallMenuRenderer()
        ToolStripManager.Renderer = New ToolStripProfessionalRenderer(New HighlightColorTable())
    End Sub

    ' Call once per form, e.g. in Form Load: ThemeHelper.ApplyHighlight(Me)
    Public Sub ApplyHighlight(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is DataGridView Then
                StyleGrid(DirectCast(ctrl, DataGridView))
            ElseIf TypeOf ctrl Is ListView Then
                StyleListView(DirectCast(ctrl, ListView))
            ElseIf TypeOf ctrl Is ComboBox Then
                StyleComboBox(DirectCast(ctrl, ComboBox))
            ElseIf TypeOf ctrl Is CheckedListBox Then
                ' CheckedListBox does not support owner drawing, so it is skipped
            ElseIf TypeOf ctrl Is ListBox Then
                StyleListBox(DirectCast(ctrl, ListBox))
            ElseIf TypeOf ctrl Is TreeView Then
                StyleTreeView(DirectCast(ctrl, TreeView))
            ElseIf TypeOf ctrl Is CheckBox OrElse TypeOf ctrl Is RadioButton Then
                StyleToggle(DirectCast(ctrl, ButtonBase))
            End If

            If ctrl.HasChildren Then ApplyHighlight(ctrl)
        Next
    End Sub

#Region "DataGridView"
    Private Sub StyleGrid(dgv As DataGridView)
        dgv.DefaultCellStyle.SelectionBackColor = HighlightColor
        dgv.DefaultCellStyle.SelectionForeColor = HighlightTextColor
        dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = HighlightColor
        dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = HighlightTextColor
        dgv.RowHeadersDefaultCellStyle.SelectionBackColor = HighlightColor
        dgv.RowHeadersDefaultCellStyle.SelectionForeColor = HighlightTextColor
        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = HighlightColor
        dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = HighlightTextColor
    End Sub
#End Region

#Region "ListView"
    Private Sub StyleListView(lv As ListView)
        lv.OwnerDraw = True
        RemoveHandler lv.DrawColumnHeader, AddressOf ListView_DrawColumnHeader
        RemoveHandler lv.DrawItem, AddressOf ListView_DrawItem
        RemoveHandler lv.DrawSubItem, AddressOf ListView_DrawSubItem
        AddHandler lv.DrawColumnHeader, AddressOf ListView_DrawColumnHeader
        AddHandler lv.DrawItem, AddressOf ListView_DrawItem
        AddHandler lv.DrawSubItem, AddressOf ListView_DrawSubItem
    End Sub

    Private Sub ListView_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs)
        e.DrawDefault = True
    End Sub

    Private Sub ListView_DrawItem(sender As Object, e As DrawListViewItemEventArgs)
        Dim lv As ListView = DirectCast(sender, ListView)
        ' Details view is drawn cell by cell in DrawSubItem
        If lv.View <> View.Details Then
            If e.Item.Selected Then
                Using b As New SolidBrush(HighlightColor)
                    e.Graphics.FillRectangle(b, e.Bounds)
                End Using
                TextRenderer.DrawText(e.Graphics, e.Item.Text, e.Item.Font, e.Bounds, HighlightTextColor)
            Else
                e.DrawDefault = True
            End If
        End If
    End Sub

    Private Sub ListView_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs)
        Dim selected As Boolean = e.Item.Selected
        Dim backColor As Color = If(selected, HighlightColor, e.SubItem.BackColor)
        Dim foreColor As Color = If(selected, HighlightTextColor, e.SubItem.ForeColor)

        Using b As New SolidBrush(backColor)
            e.Graphics.FillRectangle(b, e.Bounds)
        End Using

        Dim textBounds As New Rectangle(e.Bounds.X + 3, e.Bounds.Y, e.Bounds.Width - 3, e.Bounds.Height)
        TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.SubItem.Font, textBounds, foreColor, _
                              TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.EndEllipsis)
    End Sub
#End Region

#Region "ComboBox"
    Private Sub StyleComboBox(cbo As ComboBox)
        cbo.DrawMode = DrawMode.OwnerDrawFixed
        RemoveHandler cbo.DrawItem, AddressOf ComboBox_DrawItem
        AddHandler cbo.DrawItem, AddressOf ComboBox_DrawItem
    End Sub

    Private Sub ComboBox_DrawItem(sender As Object, e As DrawItemEventArgs)
        If e.Index < 0 Then Return

        Dim cbo As ComboBox = DirectCast(sender, ComboBox)
        Dim selected As Boolean = (e.State And DrawItemState.Selected) = DrawItemState.Selected
        Dim backColor As Color = If(selected, HighlightColor, cbo.BackColor)
        Dim foreColor As Color = If(selected, HighlightTextColor, cbo.ForeColor)

        Using b As New SolidBrush(backColor)
            e.Graphics.FillRectangle(b, e.Bounds)
        End Using

        ' GetItemText respects DisplayMember when the ComboBox is data bound
        Dim text As String = cbo.GetItemText(cbo.Items(e.Index))
        Dim textBounds As New Rectangle(e.Bounds.X + 2, e.Bounds.Y, e.Bounds.Width - 2, e.Bounds.Height)
        TextRenderer.DrawText(e.Graphics, text, cbo.Font, textBounds, foreColor, _
                              TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.EndEllipsis)
    End Sub
#End Region

#Region "ListBox"
    Private Sub StyleListBox(lb As ListBox)
        lb.DrawMode = DrawMode.OwnerDrawFixed
        RemoveHandler lb.DrawItem, AddressOf ListBox_DrawItem
        AddHandler lb.DrawItem, AddressOf ListBox_DrawItem
    End Sub

    Private Sub ListBox_DrawItem(sender As Object, e As DrawItemEventArgs)
        If e.Index < 0 Then Return

        Dim lb As ListBox = DirectCast(sender, ListBox)
        Dim selected As Boolean = (e.State And DrawItemState.Selected) = DrawItemState.Selected

        Using b As New SolidBrush(If(selected, HighlightColor, lb.BackColor))
            e.Graphics.FillRectangle(b, e.Bounds)
        End Using

        TextRenderer.DrawText(e.Graphics, lb.GetItemText(lb.Items(e.Index)), lb.Font, e.Bounds, _
                              If(selected, HighlightTextColor, lb.ForeColor), _
                              TextFormatFlags.Left Or TextFormatFlags.VerticalCenter)
    End Sub
#End Region

#Region "TreeView"
    Private Sub StyleTreeView(tv As TreeView)
        tv.DrawMode = TreeViewDrawMode.OwnerDrawText
        tv.HideSelection = False
        RemoveHandler tv.DrawNode, AddressOf TreeView_DrawNode
        AddHandler tv.DrawNode, AddressOf TreeView_DrawNode
    End Sub

    Private Sub TreeView_DrawNode(sender As Object, e As DrawTreeNodeEventArgs)
        Dim tv As TreeView = DirectCast(sender, TreeView)
        Dim selected As Boolean = (e.State And TreeNodeStates.Selected) = TreeNodeStates.Selected

        If selected Then
            Using b As New SolidBrush(HighlightColor)
                e.Graphics.FillRectangle(b, e.Bounds)
            End Using
            TextRenderer.DrawText(e.Graphics, e.Node.Text, tv.Font, e.Bounds, HighlightTextColor, _
                                  TextFormatFlags.VerticalCenter)
        Else
            e.DrawDefault = True
        End If
    End Sub
#End Region

#Region "CheckBox / RadioButton"
    Private Sub StyleToggle(btn As ButtonBase)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderColor = HighlightColor
        btn.ForeColor = HighlightColor   ' also changes the label text color
    End Sub
#End Region
End Module

' Menu / toolbar highlight colors
Public Class HighlightColorTable
    Inherits ProfessionalColorTable

    Public Overrides ReadOnly Property MenuItemSelected As Color
        Get
            Return ThemeHelper.HighlightColor
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As Color
        Get
            Return ThemeHelper.HighlightColor
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As Color
        Get
            Return ThemeHelper.HighlightColor
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonSelectedHighlight As Color
        Get
            Return ThemeHelper.HighlightColor
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonSelectedGradientBegin As Color
        Get
            Return ThemeHelper.HighlightColor
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonSelectedGradientEnd As Color
        Get
            Return ThemeHelper.HighlightColor
        End Get
    End Property
End Class