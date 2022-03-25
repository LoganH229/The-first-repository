Public Class MyRect
    Public Property Pen As Pen
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point
    Public Property w As Integer
    Public Property h As Integer
    Public Property points As Integer
    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            Dim points(2) As Point
            points(0) = New Point(m_a.X, m_a.Y)
            points(1) = New Point(m_a.X, m_a.Y + w)
            points(2) = New Point(m_a.X + h, m_a.Y)
            g.DrawPolygon(Pen, points)
            'g.DrawRectangle(Pen, m_a.X, m_a.Y, w, h)
            'g.DrawArc(Pen, m_a.X, m_a.Y, 50, 100, 0, 90)
            'g.DrawPie(Pen, m_a.X, m_a.Y, 74, 100, 0, 90)

        End Using

    End Sub
End Class
