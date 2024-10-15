Public Class MainForm

    Dim ownersf As New OwnerForm()
    Dim propertyF As New PropertyForm()
    Dim property_type As New TypeForm()
    Dim clientsF As New ClientForm()
    Dim propImagesF As New PropertyImageForm()
    Dim salesF As New SalesForm()
    'make it the all item in sidebar

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Center Panel1 and Panel2 at the top
        CenterPanelAtTop(Panel_Menu)
        CenterPanelAtTop(Panel2)

        ' Adjust the panel sizes to fill the height of the form
        PanelLeft.Size = New Size(PanelLeft.Width, ClientSize.Height)
        PanelRight.Size = New Size(PanelRight.Width, ClientSize.Height)
        PanelRight.Location = New Point(ClientSize.Width - PanelRight.Width, 0)
    End Sub

    Private Sub CenterPanelAtTop(panel As Panel)
        ' Center the specified panel at the top of the form
        panel.Location = New Point((ClientSize.Width - panel.Width) / 2, 0)
    End Sub

    ' Method to display a form below Panel2 with 1-inch space
    Private Sub DisplayFormBelowPanel2(formToShow As Form)
        ' Hide all other forms
        HideAllForms()

        ' Set the form location to be below Panel2 with 1-inch space (96 pixels)
        formToShow.TopLevel = False ' This makes the form a child control of the main form
        formToShow.FormBorderStyle = FormBorderStyle.None ' Remove the border
        formToShow.Location = New Point(Panel2.Left, Panel2.Bottom + 30) '  pixels below Panel2
        formToShow.Size = New Size(Panel2.Width, formToShow.Height) ' Adjust width to match Panel2
        formToShow.Anchor = AnchorStyles.Top ' Anchor to the top
        Me.Controls.Add(formToShow) ' Add the form to the main form controls
        formToShow.Show() ' Show the form
        formToShow.BringToFront() ' Bring to front
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

    ' Button click to display OwnerForm
    Private Sub Button_Owner_Click(sender As Object, e As EventArgs) Handles Button_Owner.Click
        DisplayFormBelowPanel2(ownersf)
    End Sub

    ' Button click to display PropertyForm
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DisplayFormBelowPanel2(propertyF)
    End Sub

    ' Button click to display TypeForm


    ' Button click to display ClientForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DisplayFormBelowPanel2(clientsF)
    End Sub

    ' Button click to display PropertyImageForm
    Private Sub ButtonIMAGES_Click(sender As Object, e As EventArgs) Handles ButtonIMAGES.Click
        DisplayFormBelowPanel2(propImagesF)
    End Sub

    ' Button click to display SalesForm
    Private Sub SALES_Click(sender As Object, e As EventArgs) Handles SALES.Click
        DisplayFormBelowPanel2(salesF)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Create a list to hold forms to close
        Dim formsToClose As New List(Of Form)

        ' Add all open forms to the list
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
        Dim loginForm As New LoginForm() ' Replace LoginForm with the actual name of your login form
        loginForm.Show()

        ' Optionally close the current form
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonTypes_Click(sender As Object, e As EventArgs) Handles ButtonTypes.Click
        DisplayFormBelowPanel2(property_type)
    End Sub
End Class
