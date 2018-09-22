<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GroupBoxCommander = New System.Windows.Forms.GroupBox()
        Me.TxtBody = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSubject = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTo = New System.Windows.Forms.TextBox()
        Me.GroupBoxCommander.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSend
        '
        Me.BtnSend.Location = New System.Drawing.Point(13, 271)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(75, 23)
        Me.BtnSend.TabIndex = 6
        Me.BtnSend.Text = "Enviar"
        Me.BtnSend.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(334, 271)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 7
        Me.BtnClose.Text = "Sair"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'GroupBoxCommander
        '
        Me.GroupBoxCommander.Controls.Add(Me.TxtBody)
        Me.GroupBoxCommander.Controls.Add(Me.Label3)
        Me.GroupBoxCommander.Controls.Add(Me.TxtSubject)
        Me.GroupBoxCommander.Controls.Add(Me.Label2)
        Me.GroupBoxCommander.Controls.Add(Me.Label1)
        Me.GroupBoxCommander.Controls.Add(Me.TxtTo)
        Me.GroupBoxCommander.Location = New System.Drawing.Point(13, 13)
        Me.GroupBoxCommander.Name = "GroupBoxCommander"
        Me.GroupBoxCommander.Size = New System.Drawing.Size(396, 252)
        Me.GroupBoxCommander.TabIndex = 8
        Me.GroupBoxCommander.TabStop = False
        '
        'TxtBody
        '
        Me.TxtBody.Location = New System.Drawing.Point(10, 141)
        Me.TxtBody.Multiline = True
        Me.TxtBody.Name = "TxtBody"
        Me.TxtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtBody.Size = New System.Drawing.Size(374, 96)
        Me.TxtBody.TabIndex = 11
        Me.TxtBody.Text = "Mensagem Example"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mensagem"
        '
        'TxtSubject
        '
        Me.TxtSubject.Location = New System.Drawing.Point(10, 86)
        Me.TxtSubject.Name = "TxtSubject"
        Me.TxtSubject.Size = New System.Drawing.Size(375, 20)
        Me.TxtSubject.TabIndex = 9
        Me.TxtSubject.Text = "Assunto Example"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Assunto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Para"
        '
        'TxtTo
        '
        Me.TxtTo.Location = New System.Drawing.Point(10, 38)
        Me.TxtTo.Name = "TxtTo"
        Me.TxtTo.Size = New System.Drawing.Size(375, 20)
        Me.TxtTo.TabIndex = 6
        Me.TxtTo.Text = "dias.fulvio@gmail.com"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(423, 308)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSend)
        Me.Controls.Add(Me.GroupBoxCommander)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enviar E-mail Html"
        Me.GroupBoxCommander.ResumeLayout(False)
        Me.GroupBoxCommander.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSend As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents GroupBoxCommander As GroupBox
    Friend WithEvents TxtBody As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSubject As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTo As TextBox
End Class
