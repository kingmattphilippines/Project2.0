<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainForm))
        Panel_Menu = New Panel()
        btnLogout = New Button()
        Panel2 = New Panel()
        Button_Owner = New Button()
        SALES = New Button()
        Panel1 = New Panel()
        Button_Client = New Button()
        Button_Property = New Button()
        ButtonIMAGES = New Button()
        ButtonTypes = New Button()
        PanelLeft = New Panel()
        PanelRight = New Panel()
        Panel_Menu.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel_Menu
        ' 
        Panel_Menu.BackColor = Color.Silver
        Panel_Menu.BackgroundImageLayout = ImageLayout.Stretch
        Panel_Menu.Controls.Add(btnLogout)
        Panel_Menu.Controls.Add(Panel2)
        Panel_Menu.Dock = DockStyle.Fill
        Panel_Menu.Location = New Point(0, 0)
        Panel_Menu.Margin = New Padding(2)
        Panel_Menu.Name = "Panel_Menu"
        Panel_Menu.Size = New Size(1454, 840)
        Panel_Menu.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), Image)
        btnLogout.BackgroundImageLayout = ImageLayout.Stretch
        btnLogout.Location = New Point(1381, 790)
        btnLogout.Margin = New Padding(2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(64, 50)
        btnLogout.TabIndex = 6
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(Button_Owner)
        Panel2.Controls.Add(SALES)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Button_Client)
        Panel2.Controls.Add(Button_Property)
        Panel2.Controls.Add(ButtonIMAGES)
        Panel2.Controls.Add(ButtonTypes)
        Panel2.Location = New Point(104, 2)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1202, 145)
        Panel2.TabIndex = 0
        ' 
        ' Button_Owner
        ' 
        Button_Owner.BackColor = Color.NavajoWhite
        Button_Owner.Font = New Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Button_Owner.ForeColor = Color.MidnightBlue
        Button_Owner.Location = New Point(0, 42)
        Button_Owner.Margin = New Padding(2)
        Button_Owner.Name = "Button_Owner"
        Button_Owner.Size = New Size(185, 65)
        Button_Owner.TabIndex = 0
        Button_Owner.Text = "OWNERS"
        Button_Owner.UseVisualStyleBackColor = False
        ' 
        ' SALES
        ' 
        SALES.BackColor = Color.NavajoWhite
        SALES.Font = New Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point)
        SALES.ForeColor = Color.MidnightBlue
        SALES.Location = New Point(1006, 42)
        SALES.Margin = New Padding(2)
        SALES.Name = "SALES"
        SALES.Size = New Size(196, 65)
        SALES.TabIndex = 6
        SALES.Text = "SALES"
        SALES.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Location = New Point(2, 111)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1202, 8)
        Panel1.TabIndex = 5
        ' 
        ' Button_Client
        ' 
        Button_Client.BackColor = Color.NavajoWhite
        Button_Client.Font = New Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Button_Client.ForeColor = Color.MidnightBlue
        Button_Client.Location = New Point(190, 43)
        Button_Client.Margin = New Padding(2)
        Button_Client.Name = "Button_Client"
        Button_Client.Size = New Size(197, 64)
        Button_Client.TabIndex = 1
        Button_Client.Text = "CLIENTS"
        Button_Client.UseVisualStyleBackColor = False
        ' 
        ' Button_Property
        ' 
        Button_Property.BackColor = Color.NavajoWhite
        Button_Property.Font = New Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Button_Property.ForeColor = Color.MidnightBlue
        Button_Property.Location = New Point(391, 45)
        Button_Property.Margin = New Padding(2)
        Button_Property.Name = "Button_Property"
        Button_Property.Size = New Size(194, 62)
        Button_Property.TabIndex = 2
        Button_Property.Text = "PROPERTIES"
        Button_Property.UseVisualStyleBackColor = False
        ' 
        ' ButtonIMAGES
        ' 
        ButtonIMAGES.BackColor = Color.NavajoWhite
        ButtonIMAGES.Font = New Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonIMAGES.ForeColor = Color.MidnightBlue
        ButtonIMAGES.Location = New Point(798, 44)
        ButtonIMAGES.Margin = New Padding(2)
        ButtonIMAGES.Name = "ButtonIMAGES"
        ButtonIMAGES.Size = New Size(203, 65)
        ButtonIMAGES.TabIndex = 4
        ButtonIMAGES.Text = "IMAGES"
        ButtonIMAGES.UseVisualStyleBackColor = False
        ' 
        ' ButtonTypes
        ' 
        ButtonTypes.BackColor = Color.NavajoWhite
        ButtonTypes.Font = New Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonTypes.ForeColor = Color.MidnightBlue
        ButtonTypes.Location = New Point(590, 45)
        ButtonTypes.Margin = New Padding(2)
        ButtonTypes.Name = "ButtonTypes"
        ButtonTypes.Size = New Size(203, 65)
        ButtonTypes.TabIndex = 3
        ButtonTypes.Text = "TYPES"
        ButtonTypes.UseVisualStyleBackColor = False
        ' 
        ' PanelLeft
        ' 
        PanelLeft.BackColor = Color.RosyBrown
        PanelLeft.Location = New Point(0, 0)
        PanelLeft.Margin = New Padding(2)
        PanelLeft.Name = "PanelLeft"
        PanelLeft.Size = New Size(4, 209)
        PanelLeft.TabIndex = 2
        ' 
        ' PanelRight
        ' 
        PanelRight.BackColor = Color.RosyBrown
        PanelRight.Location = New Point(1450, 0)
        PanelRight.Margin = New Padding(2)
        PanelRight.Name = "PanelRight"
        PanelRight.Size = New Size(4, 209)
        PanelRight.TabIndex = 3
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1454, 840)
        Controls.Add(PanelRight)
        Controls.Add(PanelLeft)
        Controls.Add(Panel_Menu)
        Margin = New Padding(2)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "-"
        WindowState = FormWindowState.Maximized
        Panel_Menu.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel_Menu As Panel
    Friend WithEvents Button_Owner As Button
    Friend WithEvents ButtonIMAGES As Button
    Friend WithEvents ButtonTypes As Button
    Friend WithEvents Button_Property As Button
    Friend WithEvents Button_Client As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PanelRight As Panel
    Friend WithEvents SALES As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogout As Button
End Class
