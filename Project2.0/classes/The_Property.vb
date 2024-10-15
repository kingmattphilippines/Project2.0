Imports System.IO
Imports MySqlConnector

Public Class The_Property

    Dim func As New MYFUNCTION()
    Private db As New Database()

    ' Get property by ID
    Function getPropertyById(ByVal id As Integer) As DataTable
        Dim result As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM `the_property` WHERE `id` = @id")

        ' Ensure the connection is managed correctly
        Using conn As MySqlConnection = db.getConnection()
            db.openConnection(conn)
            Try
                command.Parameters.AddWithValue("@id", id)
                command.Connection = conn

                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(result)
                End Using

                ' Check if rows were returned
                If result.Rows.Count = 0 Then
                    ' Return an empty DataTable if no property was found
                    Return New DataTable()
                End If
            Catch ex As Exception
                MessageBox.Show("Error retrieving property: " & ex.Message)
                ' Return an empty DataTable in case of error
                Return New DataTable()
            Finally
                db.closesConnection(conn) ' Ensure the connection is closed
            End Try
        End Using

        Return result
    End Function

    ' Add a new property
    Function addProperty(ByVal type As Integer,
                         ByVal owner As Integer,
                         ByVal size As Integer,
                         ByVal price As String,
                         ByVal address As String,
                         ByVal beds As Integer,
                         ByVal baths As Integer,
                         ByVal age As Integer,
                         ByVal balcony As Boolean,
                         ByVal backyard As Boolean,
                         ByVal garage As Boolean,
                         ByVal pool As Boolean,
                         ByVal fireplace As Boolean,
                         ByVal elevator As Boolean,
                         ByVal comment As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `the_property`( `type`, `owner`, `size`, `price`, `address`, `beds`, `baths`, `age`, `balcony`, `backyard`, `garage`, `pool`, `fireplace`, `elevator`, `comment`) VALUES (@tp,@ownerId,@sz,@prc,@adrs,@bds,@bths,@age,@blcn,@bkyd,@grg,@pool,@frplc,@elv,@cmnt)")

        command.Parameters.AddWithValue("@tp", type)
        command.Parameters.AddWithValue("@ownerId", owner)
        command.Parameters.AddWithValue("@sz", size)
        command.Parameters.AddWithValue("@prc", price)
        command.Parameters.AddWithValue("@adrs", address)
        command.Parameters.AddWithValue("@bds", beds)
        command.Parameters.AddWithValue("@bths", baths)
        command.Parameters.AddWithValue("@age", age)
        command.Parameters.AddWithValue("@blcn", balcony)
        command.Parameters.AddWithValue("@bkyd", backyard)
        command.Parameters.AddWithValue("@grg", garage)
        command.Parameters.AddWithValue("@pool", pool)
        command.Parameters.AddWithValue("@frplc", fireplace)
        command.Parameters.AddWithValue("@elv", elevator)
        command.Parameters.AddWithValue("@cmnt", comment)

        Return func.exeQuery(command)
    End Function

    ' Edit the selected property
    Function editProperty(ByVal propertyId As Integer,
                      ByVal type As Integer,
                      ByVal owner As Integer,
                      ByVal size As Integer,
                      ByVal price As String,
                      ByVal address As String,
                      ByVal beds As Integer,
                      ByVal baths As Integer,
                      ByVal age As Integer,
                      ByVal balcony As Boolean,
                      ByVal backyard As Boolean,
                      ByVal garage As Boolean,
                      ByVal pool As Boolean,
                      ByVal fireplace As Boolean,
                      ByVal elevator As Boolean,
                      ByVal comment As String) As Boolean

        Dim command As New MySqlCommand("UPDATE `the_property` SET `type`=@tp, `owner`=@ownerId, `size`=@sz, `price`=@prc, `address`=@adrs, `beds`=@bds, `baths`=@bths, `age`=@age, `balcony`=@blcn, `backyard`=@bkyd, `garage`=@grg, `pool`=@pool, `fireplace`=@frplc, `elevator`=@elv, `comment`=@cmnt WHERE `id`=@id")

        command.Parameters.AddWithValue("@tp", type)
        command.Parameters.AddWithValue("@ownerId", owner)
        command.Parameters.AddWithValue("@sz", size)
        command.Parameters.AddWithValue("@prc", price)
        command.Parameters.AddWithValue("@adrs", address)
        command.Parameters.AddWithValue("@bds", beds)
        command.Parameters.AddWithValue("@bths", baths)
        command.Parameters.AddWithValue("@age", age)
        command.Parameters.AddWithValue("@blcn", balcony)
        command.Parameters.AddWithValue("@bkyd", backyard)
        command.Parameters.AddWithValue("@grg", garage)
        command.Parameters.AddWithValue("@pool", pool)
        command.Parameters.AddWithValue("@frplc", fireplace)
        command.Parameters.AddWithValue("@elv", elevator)
        command.Parameters.AddWithValue("@cmnt", comment)
        command.Parameters.AddWithValue("@id", propertyId)

        Return func.exeQuery(command)
    End Function

    ' Remove the selected property
    Function removeProperty(ByVal propertyId As Integer) As Boolean
        Dim command As New MySqlCommand("DELETE FROM `the_property` WHERE `id`=@id")
        command.Parameters.AddWithValue("@id", propertyId)
        Return func.exeQuery(command)
    End Function

    ' Add a property image
    Function addImage(ByVal PropertyId As Integer, ByVal propertyImage As MemoryStream) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `prop_images`(`propertyid`, `prop_image`) VALUES (@pid, @img)")
        command.Parameters.AddWithValue("@pid", PropertyId)
        command.Parameters.AddWithValue("@img", propertyImage.ToArray())

        Return func.exeQuery(command)
    End Function

    ' Remove a property image
    Function removeImage(ByVal imageId As Integer) As Boolean
        Dim command As New MySqlCommand("DELETE FROM `prop_images` WHERE `id` = @imgId")
        command.Parameters.AddWithValue("@imgId", imageId)

        Return func.exeQuery(command)
    End Function

    ' Get all images for a property
    Function getpropertyImages(ByVal propertyId As Integer) As DataTable
        Dim result As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM `prop_images` WHERE `propertyid` = @pid")
        command.Parameters.AddWithValue("@pid", propertyId)

        ' Use a connection to execute the command
        Using conn As MySqlConnection = db.getConnection()
            db.openConnection(conn)
            Try
                command.Connection = conn
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(result)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error retrieving images: " & ex.Message)
                Return New DataTable() ' Return an empty DataTable in case of error
            Finally
                db.closesConnection(conn)
            End Try
        End Using

        Return result
    End Function

    ' Get image by ID
    Function getImageById(ByVal imageId As Integer) As MemoryStream
        Dim command As New MySqlCommand("SELECT `prop_image` FROM `prop_images` WHERE `id` = @id")
        command.Parameters.AddWithValue("@id", imageId)

        Dim table As New DataTable()

        ' Use a connection to execute the command
        Using conn As MySqlConnection = db.getConnection()
            db.openConnection(conn)
            Try
                command.Connection = conn
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)
                End Using

                If table.Rows.Count > 0 Then
                    Return New MemoryStream(CType(table.Rows(0)("prop_image"), Byte()))
                Else
                    Return New MemoryStream()
                End If
            Catch ex As Exception
                MessageBox.Show("Error retrieving image: " & ex.Message)
                Return New MemoryStream()
            Finally
                db.closesConnection(conn)
            End Try
        End Using
    End Function

End Class
