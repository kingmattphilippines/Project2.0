Public Class MainForm

    ' Declare forms
    Dim ownersf As New OwnerForm()
    Dim propertyF As New PropertyForm()
    Dim property_type As New TypeForm()
    Dim clientsF As New ClientForm()
    Dim propImagesF As New PropertyImageForm()
    Dim salesF As New SalesForm()

    ' MainForm Load event
    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Center panels
        CenterPanelAtTop(Panel_Menu)
        CenterPanelAtTop(Panel2)

        ' Adjust panel sizes
        PanelLeft.Size = New Size(PanelLeft.Width, ClientSize.Height)
        PanelRight.Size = New Size(PanelRight.Width, ClientSize.Height)
        PanelRight.Location = New Point(ClientSize.Width - PanelRight.Width, 0)
    End Sub

    ' Center the specified panel at the top of the form
    Private Sub CenterPanelAtTop(panel As Panel)
        panel.Location = New Point((ClientSize.Width - panel.Width) / 2, 0)
    End Sub

    ' Display a form as a dialog
    Private Sub DisplayFormAsDialog(ByRef formToShow As Form)
        Try
            ' If the form is disposed, create a new instance
            If formToShow Is Nothing OrElse formToShow.IsDisposed Then
                Select Case formToShow.GetType().Name
                    Case "OwnerForm"
                        formToShow = New OwnerForm()
                    Case "ClientForm"
                        formToShow = New ClientForm()
                    Case "PropertyForm"
                        formToShow = New PropertyForm()
                    Case "TypeForm"
                        formToShow = New TypeForm()
                    Case "PropertyImageForm"
                        formToShow = New PropertyImageForm()
                    Case "SalesForm"
                        formToShow = New SalesForm()
                End Select
            End If

            ' Hide all other forms
            HideAllForms()

            ' Show the form as a dialog
            formToShow.ShowDialog(Me) ' Show as a modal dialog

        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    ' Hide all forms
    Private Sub HideAllForms()
        ownersf.Hide()
        propertyF.Hide()
        property_type.Hide()
        propImagesF.Hide()
        salesF.Hide()
        clientsF.Hide()
    End Sub

    ' Unified button click handler to display the corresponding form
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button_Owner.Click, Button_Client.Click, Button_Property.Click, ButtonTypes.Click, ButtonIMAGES.Click, SALES.Click
        Dim formToShow As Form = Nothing

        Select Case DirectCast(sender, Button).Name
            Case Button_Owner.Name
                formToShow = ownersf
            Case Button_Client.Name
                formToShow = clientsF
            Case Button_Property.Name
                formToShow = propertyF
            Case ButtonTypes.Name
                formToShow = property_type
            Case ButtonIMAGES.Name
                formToShow = propImagesF
            Case SALES.Name
                formToShow = salesF
        End Select

        If formToShow IsNot Nothing Then
            DisplayFormAsDialog(formToShow) ' Call the method to show the form as a dialog
        End If
    End Sub

    ' Logout button click handler
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Create a list to hold forms to close
        Dim formsToClose As New List(Of Form)

        ' Add all open forms to the list except the current form
        For Each form As Form In Application.OpenForms
            If form IsNot Me Then
                formsToClose.Add(form)
            End If
        Next

        ' Close each form from the list
        For Each form As Form In formsToClose
            form.Close()
        Next

        ' Show the login form
        Dim loginForm As New LoginForm()
        loginForm.Show()

        ' Optionally close the current form
        Close()
    End Sub

End Class
