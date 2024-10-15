Imports System.IO
Imports MySqlConnector
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class PropertyImageForm
    Dim func As New MYFUNCTION()
    Dim theProperty As New The_Property()

    Private Sub PropertyImageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Center the panel in the form and load data
        Dim querySelectTypes As String = "SELECT id, name FROM `prop_type`"
        DataGridViewTypes.DataSource = func.getData(querySelectTypes)

        Dim querySelectProperties As String = "SELECT id, price, address FROM `the_property`"
        DataGridViewProperties.DataSource = func.getData(querySelectProperties)

        ' Load data into the ListBox
        loadListBoxData()

        ' Clear selection
        DataGridViewTypes.ClearSelection()
        DataGridViewProperties.ClearSelection()
        ListBox_Images.SelectedItem = Nothing

        CenterPanel()
    End Sub

    Private Sub CenterPanel()
        ' Center the menu panel in the form
        Panel_Menu.Location = New Point((ClientSize.Width - Panel_Menu.Width) / 2, Panel_Menu.Location.Y)

        ' Make the left and right panels full height
        PanelLeft.Size = New Size(PanelLeft.Width, ClientSize.Height)
        PanelRight.Size = New Size(PanelRight.Width, ClientSize.Height)
        PanelRight.Location = New Point(ClientSize.Width - PanelRight.Width, 0)

        ' Position the close button at the upper right
        ButtonClosedImages.Location = New Point(ClientSize.Width - (ButtonClosedImages.Width + 10), 10)
    End Sub

    Private Sub loadListBoxData()
        Try
            ' Load image IDs into the ListBox
            Dim querySelectImages As String = "SELECT id FROM `prop_images`"
            ListBox_Images.DataSource = func.getData(querySelectImages)
            ListBox_Images.DisplayMember = "id"
            ListBox_Images.ValueMember = "id"

            ' Clear any previous selection
            ListBox_Images.ClearSelected()
        Catch ex As Exception
            MessageBox.Show("Failed to load image data: " & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button_SelectImage_Click(sender As Object, e As EventArgs) Handles Button_SelectImages.Click
        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox_PropImage.Image = Image.FromFile(opf.FileName)
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        Try
            ' Check if an image has been selected
            If PictureBox_PropImage.Image Is Nothing Then
                MessageBox.Show("You need to select an image first.", "No Image Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Get the property ID from the DataGridView
            Dim propertyId As Integer = Convert.ToInt32(DataGridViewProperties.CurrentRow.Cells(0).Value.ToString())

            ' Save the image to a MemoryStream
            Using pic As New MemoryStream()
                PictureBox_PropImage.Image.Save(pic, PictureBox_PropImage.Image.RawFormat)

                ' Reset the position of the MemoryStream to the beginning
                pic.Position = 0

                ' Add the image to the database using the addImage function
                If theProperty.addImage(propertyId, pic) Then
                    MessageBox.Show("New property image added successfully.", "Add Image", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Image not added to this property.", "Add Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add Image Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonREMOVE_Click_1(sender As Object, e As EventArgs) Handles ButtonREMOVE.Click
        If ListBox_Images.SelectedValue Is Nothing Then
            MessageBox.Show("Please select an image to remove.", "Select Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim imageId As Integer = Convert.ToInt32(ListBox_Images.SelectedValue)

        If MessageBox.Show("Are you sure you want to remove this image?", "Delete Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If theProperty.removeImage(imageId) Then
                MessageBox.Show("Image removed successfully.", "Delete Image", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Refresh the ListBox data
                loadListBoxData()

                ' Clear the PictureBox
                PictureBox_PropImage.Image = Nothing
            Else
                MessageBox.Show("Image not removed.", "Delete Image", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    ' Display the selected image from the ListBox to the PictureBox
    Private Sub ListBox_Images_Click(sender As Object, e As EventArgs) Handles ListBox_Images.Click
        Dim imageId As Integer
        Try
            imageId = Convert.ToInt32(ListBox_Images.SelectedValue)
            Dim imageStream As MemoryStream = theProperty.getImageById(imageId)

            If imageStream IsNot Nothing AndAlso imageStream.Length > 0 Then
                PictureBox_PropImage.Image = Image.FromStream(imageStream)
            Else
                MessageBox.Show("No image found or failed to load.", "Load Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading the image: " & ex.Message, "Load Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' DataGridView Types Click event
    Private Sub DataGridViewTypes2_Click(sender As Object, e As EventArgs) Handles DataGridViewTypes.Click
        Try
            ' Check if a row is selected
            If DataGridViewTypes.CurrentRow IsNot Nothing Then
                Dim typeId As Integer = Convert.ToInt32(DataGridViewTypes.CurrentRow.Cells(0).Value)

                Dim querySelectProperties As String = "SELECT id, price, address FROM `the_property` WHERE `type` = @tp"
                Dim command As New MySqlCommand(querySelectProperties)
                command.Parameters.AddWithValue("@tp", typeId)

                DataGridViewProperties.DataSource = func.getDataUsingCommand(command)
            Else
                MessageBox.Show("Please select a property type from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving properties: " & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DataGridViewProperties_Click(sender As Object, e As EventArgs) Handles DataGridViewProperties.Click
        ' Add logic here if needed for DataGridViewProperties click event
    End Sub

    Private Sub ButtonClosedImages_Click(sender As Object, e As EventArgs) Handles ButtonClosedImages.Click
        Close()

    End Sub
End Class
