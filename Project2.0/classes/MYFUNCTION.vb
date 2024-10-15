'Imports MySqlConnector

'Public Class MYFUNCTION
'    Dim db As New Database()

'    Friend ReadOnly Property getDataUsingCommand(command As MySqlCommand) As Object
'        Get
'            Throw New NotImplementedException()
'        End Get
'    End Property

'    ' Create function to return table data
'    Function getData(ByVal query As String) As DataTable
'        Dim table As New DataTable()
'        Using connection As MySqlConnection = db.getConnection()
'            Using command As New MySqlCommand(query, connection)
'                Using adapter As New MySqlDataAdapter(command)
'                    db.openConnection(connection)
'                    adapter.Fill(table)
'                End Using
'            End Using
'            db.closesConnection(connection)
'        End Using
'        Return table
'    End Function

'    ' Create function to execute queries
'    Function exeQuery(ByVal command As MySqlCommand) As Boolean
'        Using connection As MySqlConnection = db.getConnection()
'            command.Connection = connection
'            db.openConnection(connection)
'            Try
'                Return command.ExecuteNonQuery() = 1
'            Finally
'                db.closesConnection(connection)
'            End Try
'        End Using
'    End Function





'    ' Add other functions as needed...
'End Class


Imports MySqlConnector

Public Class MYFUNCTION
    Dim db As New Database()

    ' Function to get data using a MySqlCommand
    Public Function getDataUsingCommand(command As MySqlCommand) As DataTable
        Dim table As New DataTable()
        Try
            ' Set the connection for the command
            command.Connection = db.getConnection()

            ' Open the connection
            db.openConnection(command.Connection)

            ' Use a data adapter to fill the DataTable with the results of the command
            Using adapter As New MySqlDataAdapter(command)
                adapter.Fill(table)
            End Using

        Catch ex As Exception
            ' Display an error message if something goes wrong
            MessageBox.Show("An error occurred while retrieving properties: " & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed even if an exception occurs
            db.closesConnection(command.Connection)
        End Try

        ' Return the filled DataTable
        Return table
    End Function

    ' Function to get data using a query string
    Function getData(ByVal query As String) As DataTable
        Dim table As New DataTable()
        Using connection As MySqlConnection = db.getConnection()
            Using command As New MySqlCommand(query, connection)
                Using adapter As New MySqlDataAdapter(command)
                    db.openConnection(connection)
                    adapter.Fill(table)
                End Using
            End Using
            db.closesConnection(connection)
        End Using
        Return table
    End Function

    ' Function to execute a query
    Function exeQuery(ByVal command As MySqlCommand) As Boolean
        Using connection As MySqlConnection = db.getConnection()
            command.Connection = connection
            db.openConnection(connection)
            Try
                Return command.ExecuteNonQuery() = 1
            Finally
                db.closesConnection(connection)
            End Try
        End Using
    End Function

    ' Add other functions as needed...
End Class
