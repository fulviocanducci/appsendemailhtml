Public Class Email
    Implements IEmail
    Public Property SendTo() As String Implements IEmail.SendTo
    Public Property SendSubject() As String Implements IEmail.SendSubject
    Public Property SendBoby As String Implements IEmail.SendBoby
End Class
