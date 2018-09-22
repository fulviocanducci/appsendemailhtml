Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Text

Public Class SendEmail

    Private Property Email As IEmail
    Private Property HtmlBody As HtmlBody
    Private Property HtmlImages As HtmlImages
    Private Property EmailEncoding As Encoding

    Sub New(email As Email, htmlBody As HtmlBody, Optional htmlImages As HtmlImages = Nothing)
        Me.Email = email
        Me.HtmlBody = htmlBody
        Me.HtmlImages = htmlImages
        EmailEncoding = Encoding.UTF8
    End Sub

    Private Sub AddAttachmentImages(items As HtmlImages, Mail As MailMessage)
        For Each item As Images In items
            Dim Attachment As Attachment = New Attachment(item.Path, New ContentType(item.ContentType)) _
               With {
                .ContentId = item.Name,
                .Name = item.Name,
                .NameEncoding = EmailEncoding,
                .ContentType = New ContentType(item.ContentType),
                .TransferEncoding = TransferEncoding.Base64
              }
            Mail.Attachments.Add(Attachment)
        Next
    End Sub

    Private Sub AddLinkResources(items As HtmlImages, alternateView As AlternateView)
        For Each item As Images In items
            Dim resource As LinkedResource = New LinkedResource(item.Path)
            resource.ContentType = New ContentType(item.ContentType)
            resource.ContentId = item.Name
            resource.TransferEncoding = TransferEncoding.Base64
            alternateView.LinkedResources.Add(resource)
        Next
    End Sub

    Private Function CreateMailMessage() As MailMessage
        Return New MailMessage With {
            .From = New MailAddress(Credential.Email, Credential.Name),
            .IsBodyHtml = True,
            .Subject = Email.SendSubject,
            .SubjectEncoding = EmailEncoding,
            .BodyEncoding = EmailEncoding,
            .HeadersEncoding = EmailEncoding,
            .BodyTransferEncoding = TransferEncoding.SevenBit
        }
    End Function

    Private Function CreateAlternateView(textBody As String) As AlternateView
        Return AlternateView.CreateAlternateViewFromString(textBody, Nothing, MediaTypeNames.Text.Html)
    End Function

    Public Function Send() As Boolean

        Dim textBody As String = HtmlBody.ReplaceAndReaderToString(Email)

        Dim Mail As MailMessage = CreateMailMessage()
        Mail.To.Add(Email.SendTo)

        Dim alternateView As AlternateView = CreateAlternateView(textBody)

        AddLinkResources(HtmlImages, alternateView)
        'AddAttachmentImages(HtmlImages, Mail)

        Mail.AlternateViews.Add(alternateView)

        Dim SMTP As New SmtpClient(Credential.SmtpAddress)

        Try
            SMTP.EnableSsl = Credential.EnableSsl
            SMTP.Credentials = New NetworkCredential(Credential.Email, Credential.Password)
            SMTP.Port = Credential.Port
            SMTP.Send(Mail)
            Return True
        Catch ex As Exception
            Mail.Dispose()
            SMTP.Dispose()
        End Try

        Return False

    End Function

End Class
