Imports System.IO

Public Class Images
    Sub New()
    End Sub
    Sub New(name As String, path As String, contentType As String)
        Me.Name = name
        Me.Path = path
        Me.ContentType = contentType
        Base64String = Convert.ToBase64String(File.ReadAllBytes(path))
    End Sub
    Public Property Name() As String
    Public Property Path() As String
    Public Property ContentType() As String
    Public Property Base64String() As String
End Class
