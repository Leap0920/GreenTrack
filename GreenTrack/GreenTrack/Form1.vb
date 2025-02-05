Imports MySql.Data.MySqlClient

Public Class Form1
    Private connectionString As String = "Server=localhost;Database=Psys_Db;Uid=root;Pwd=;"

    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        Dim user As String = Username.Text
        Dim pass As String = Password.Text

        If AuthenticateUser(user, pass) Then
            MessageBox.Show("Login successful!")
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged

    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub ForgotPassButton_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ForgotPassButton.LinkClicked

    End Sub
End Class
