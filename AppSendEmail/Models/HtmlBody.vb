Imports System.IO
Imports System.Reflection

Public Class HtmlBody
    Public ReadOnly Property Path As String
    Sub New(ByVal path As String)
        Me.Path = path
    End Sub
    Public Function ReplaceAndReaderToString(replaces As Object) As String
        Dim textEmail As String = File.ReadAllText(Path)
        For Each prop As PropertyInfo In replaces.GetType().GetProperties()
            textEmail = textEmail.Replace(String.Format("@{0}", prop.Name), prop.GetValue(replaces))
        Next
        Return textEmail
    End Function
End Class
