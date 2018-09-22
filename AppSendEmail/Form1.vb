Public Class Form1
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
        Dispose()
    End Sub

    Private Async Sub BtnSend_ClickAsync(sender As Object, e As EventArgs) Handles BtnSend.Click
        Await SendEmailAsync()
    End Sub

    Private Function SendEmailAsync() As Task(Of Boolean)

        BtnSend.Text = "Enviando ..."
        BtnSend.Enabled = False
        GroupBoxCommander.Enabled = False
        Update()

        Dim email As New Email With {
            .SendTo = TxtTo.Text,
            .SendSubject = TxtSubject.Text,
            .SendBoby = TxtBody.Text
        }

        Dim htmlBody As New HtmlBody("./Html/layout.html")
        Dim htmlImages As New HtmlImages From {
            {"logo2.png", "./Html/_logo2.png", "image/png"}
        }

        Dim send As New SendEmail(email, htmlBody, htmlImages)

        If send.Send() Then
            MessageBox.Show("Enviado com exito", "E-mail", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Problemas no envio de E-mail", "E-mail", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        BtnSend.Enabled = True
        BtnSend.Text = "Enviar"
        GroupBoxCommander.Enabled = True
        Update()

        Return Task.FromResult(True)

    End Function
End Class
