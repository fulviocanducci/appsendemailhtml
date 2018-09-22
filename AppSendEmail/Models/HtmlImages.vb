Public Class HtmlImages
    Inherits List(Of Images)
    Public Overloads Sub Add(name As String, path As String, contentType As String)
        Add(New Images(name, path, contentType))
    End Sub
End Class
