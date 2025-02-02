<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        ForgotPassButton = New LinkLabel()
        LogInButton = New Button()
        Password = New TextBox()
        Username = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleGoldenrod
        Panel1.Controls.Add(ForgotPassButton)
        Panel1.Controls.Add(LogInButton)
        Panel1.Controls.Add(Password)
        Panel1.Controls.Add(Username)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(51, 106)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(318, 468)
        Panel1.TabIndex = 1
        ' 
        ' ForgotPassButton
        ' 
        ForgotPassButton.AutoSize = True
        ForgotPassButton.Location = New Point(95, 390)
        ForgotPassButton.Name = "ForgotPassButton"
        ForgotPassButton.Size = New Size(98, 15)
        ForgotPassButton.TabIndex = 6
        ForgotPassButton.TabStop = True
        ForgotPassButton.Text = "forgot password?"
        ' 
        ' LogInButton
        ' 
        LogInButton.BackColor = Color.DeepSkyBlue
        LogInButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogInButton.Location = New Point(66, 336)
        LogInButton.Name = "LogInButton"
        LogInButton.Size = New Size(151, 51)
        LogInButton.TabIndex = 5
        LogInButton.Text = "LOGIN:"
        LogInButton.UseVisualStyleBackColor = False
        ' 
        ' Password
        ' 
        Password.Font = New Font("Segoe UI", 15.75F)
        Password.Location = New Point(38, 196)
        Password.Multiline = True
        Password.Name = "Password"
        Password.Size = New Size(201, 41)
        Password.TabIndex = 4
        Password.UseSystemPasswordChar = True
        ' 
        ' Username
        ' 
        Username.Font = New Font("Segoe UI", 15.75F)
        Username.Location = New Point(38, 75)
        Username.Multiline = True
        Username.Name = "Username"
        Username.Size = New Size(201, 41)
        Username.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        Label3.Location = New Point(38, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 30)
        Label3.TabIndex = 2
        Label3.Text = "PASSWORD:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        Label2.Location = New Point(38, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 30)
        Label2.TabIndex = 1
        Label2.Text = "USERNAME:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Olive
        ClientSize = New Size(1274, 690)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LogInButton As Button
    Friend WithEvents Password As TextBox
    Friend WithEvents Username As TextBox
    Friend WithEvents ForgotPassButton As LinkLabel

End Class
