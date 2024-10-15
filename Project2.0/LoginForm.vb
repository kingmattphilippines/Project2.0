Imports MySqlConnector

Public Class LoginForm

    Dim db As New Database()
    Dim func As New MYFUNCTION()

    Private Sub btnLOGIN_Click(sender As Object, e As EventArgs) Handles btnLOGIN.Click
        ' Hide error message label
        LabelError.Visible = False

        ' Check if the textbox is empty
        If emptyFields() Then
            Dim Username As String = textUsername.Text.Trim()
            Dim Password As String = textPassword.Text.Trim()

            Dim query As String = "SELECT COUNT(*) FROM `user` WHERE `username` = @un AND `password` = @pass"

            Using conn As New MySqlConnection(db.getConnection().ConnectionString)
                conn.Open() ' Open the connection
                Using command As New MySqlCommand(query, conn)
                    command.Parameters.AddWithValue("@un", Username)
                    command.Parameters.AddWithValue("@pass", Password)

                    Try
                        ' Execute the command and get the result
                        Dim rowsCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                        If rowsCount > 0 Then
                            ' If the user exists
                            Dim mainform As New MainForm()
                            mainform.Show() ' Show the main form
                            mainform.BringToFront() ' Bring the main form to the front
                            Me.Hide() ' Hide the login form
                        Else
                            ' If not exist
                            LabelError.Text = "Wrong Username or Password"
                            LabelError.Visible = True
                        End If
                    Catch ex As Exception
                        ' Handle potential errors
                        MessageBox.Show("An error occurred: " & ex.Message)
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        Close()
    End Sub

    Public Function emptyFields() As Boolean
        ' Set panel colors to default
        PanelUsername.BackColor = Color.White
        PanelPassword.BackColor = Color.White

        Dim Username As String = textUsername.Text.Trim()
        Dim Password As String = textPassword.Text.Trim()

        If String.IsNullOrEmpty(Username) AndAlso String.IsNullOrEmpty(Password) Then
            PanelUsername.BackColor = Color.Red
            PanelPassword.BackColor = Color.Red
            Return False
        ElseIf String.IsNullOrEmpty(Username) Then
            PanelUsername.BackColor = Color.Red
            Return False
        ElseIf String.IsNullOrEmpty(Password) Then
            PanelPassword.BackColor = Color.Red
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Code to run when form loads (if needed)
    End Sub


End Class
