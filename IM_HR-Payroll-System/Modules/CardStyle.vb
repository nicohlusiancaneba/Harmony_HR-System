Imports System.Drawing.Drawing2D

Public Module CardStyle

    Private Class CardInfo
        Public Radius As Integer
        Public Shadow As Integer
    End Class

    Private ReadOnly _cards As New Dictionary(Of Panel, CardInfo)
    Private ReadOnly _hookedParents As New HashSet(Of Control)

    ' Usage: CardPanel(panel_sidebar)
    Public Sub CardPanel(pnl As Panel,
                         Optional radius As Integer = 14,
                         Optional shadow As Integer = 8)

        If pnl Is Nothing OrElse pnl.Parent Is Nothing Then Return

        Dim info As New CardInfo With {.Radius = radius, .Shadow = shadow}
        If _cards.ContainsKey(pnl) Then
            _cards(pnl) = info
        Else
            _cards.Add(pnl, info)
            AddHandler pnl.SizeChanged, AddressOf Card_Changed
            AddHandler pnl.LocationChanged, AddressOf Card_Changed
            AddHandler pnl.VisibleChanged, AddressOf Card_Changed
        End If

        If Not _hookedParents.Contains(pnl.Parent) Then
            _hookedParents.Add(pnl.Parent)
            AddHandler pnl.Parent.Paint, AddressOf Parent_Paint
        End If

        ApplyRegion(pnl)
        pnl.Parent.Invalidate()
    End Sub

    Private Sub Card_Changed(sender As Object, e As EventArgs)
        Dim pnl As Panel = CType(sender, Panel)
        ApplyRegion(pnl)
        If pnl.Parent IsNot Nothing Then pnl.Parent.Invalidate()
    End Sub

    Private Sub ApplyRegion(pnl As Panel)
        If pnl.Width < 2 OrElse pnl.Height < 2 Then Return
        Dim info As CardInfo = _cards(pnl)
        Using path As GraphicsPath = RoundedRect(New Rectangle(0, 0, pnl.Width, pnl.Height), info.Radius)
            pnl.Region = New Region(path)
        End Using
    End Sub

    ' Draws the shadows on the parent, behind the panels
    Private Sub Parent_Paint(sender As Object, e As PaintEventArgs)
        Dim parent As Control = CType(sender, Control)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        For Each kv In _cards
            Dim pnl As Panel = kv.Key
            If pnl.Parent IsNot parent OrElse Not pnl.Visible Then Continue For

            For i As Integer = kv.Value.Shadow To 1 Step -1
                Dim r As Rectangle = pnl.Bounds
                r.Inflate(i, i)
                r.Offset(0, 2)
                Using path As GraphicsPath = RoundedRect(r, kv.Value.Radius + i),
                      br As New SolidBrush(Color.FromArgb(6, 40, 60, 90))
                    e.Graphics.FillPath(br, path)
                End Using
            Next
        Next
    End Sub

    Private Function RoundedRect(r As Rectangle, radius As Integer) As GraphicsPath
        Dim d As Integer = Math.Max(1, radius * 2)
        Dim p As New GraphicsPath()
        p.AddArc(r.X, r.Y, d, d, 180, 90)
        p.AddArc(r.Right - d, r.Y, d, d, 270, 90)
        p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90)
        p.AddArc(r.X, r.Bottom - d, d, d, 90, 90)
        p.CloseFigure()
        Return p
    End Function

End Module