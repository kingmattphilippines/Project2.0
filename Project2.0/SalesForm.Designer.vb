<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SalesForm))
        Panel1 = New Panel()
        Button1 = New Button()
        Panel3 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        DataGridView1 = New DataGridView()
        Label8 = New Label()
        DateTimePicker1 = New DateTimePicker()
        ButtonCLEAR_FIELDS = New Button()
        ButtonREMOVE = New Button()
        ButtonEDIT = New Button()
        ButtonADD = New Button()
        DataGridViewCLIENTS = New DataGridView()
        TextBoxADDRESS = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        TextBoxPHONE = New TextBox()
        Label5 = New Label()
        TextBoxlNAME = New TextBox()
        Label4 = New Label()
        TextBoxfNAME = New TextBox()
        Label3 = New Label()
        TextBoxID = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewCLIENTS, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MediumAquamarine
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(31, 10)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1142, 681)
        Panel1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Castellar", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(1104, 2)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(38, 35)
        Button1.TabIndex = 6
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LemonChiffon
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(DataGridView1)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(DateTimePicker1)
        Panel3.Controls.Add(ButtonCLEAR_FIELDS)
        Panel3.Controls.Add(ButtonREMOVE)
        Panel3.Controls.Add(ButtonEDIT)
        Panel3.Controls.Add(ButtonADD)
        Panel3.Controls.Add(DataGridViewCLIENTS)
        Panel3.Controls.Add(TextBoxADDRESS)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(TextBoxPHONE)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(TextBoxlNAME)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(TextBoxfNAME)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TextBoxID)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(10, 78)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1130, 603)
        Panel3.TabIndex = 4
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Orange
        Button3.ForeColor = Color.White
        Button3.Location = New Point(837, 523)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(266, 58)
        Button3.TabIndex = 21
        Button3.Text = "Show Properties"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Orange
        Button2.ForeColor = Color.White
        Button2.Location = New Point(499, 523)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(293, 58)
        Button2.TabIndex = 20
        Button2.Text = "Show Clients"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlLight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(499, 298)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(604, 209)
        DataGridView1.TabIndex = 19
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Label8.Location = New Point(499, 18)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 20)
        Label8.TabIndex = 18
        Label8.Text = "Sales List"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Location = New Point(195, 254)
        DateTimePicker1.Margin = New Padding(2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(251, 38)
        DateTimePicker1.TabIndex = 17
        ' 
        ' ButtonCLEAR_FIELDS
        ' 
        ButtonCLEAR_FIELDS.BackColor = Color.Gold
        ButtonCLEAR_FIELDS.ForeColor = Color.Black
        ButtonCLEAR_FIELDS.Location = New Point(62, 523)
        ButtonCLEAR_FIELDS.Margin = New Padding(2)
        ButtonCLEAR_FIELDS.Name = "ButtonCLEAR_FIELDS"
        ButtonCLEAR_FIELDS.Size = New Size(384, 58)
        ButtonCLEAR_FIELDS.TabIndex = 16
        ButtonCLEAR_FIELDS.Text = "Clear Fields"
        ButtonCLEAR_FIELDS.UseVisualStyleBackColor = False
        ' 
        ' ButtonREMOVE
        ' 
        ButtonREMOVE.BackColor = Color.Red
        ButtonREMOVE.ForeColor = Color.White
        ButtonREMOVE.Location = New Point(325, 457)
        ButtonREMOVE.Margin = New Padding(2)
        ButtonREMOVE.Name = "ButtonREMOVE"
        ButtonREMOVE.Size = New Size(121, 50)
        ButtonREMOVE.TabIndex = 15
        ButtonREMOVE.Text = "REMOVE"
        ButtonREMOVE.UseVisualStyleBackColor = False
        ' 
        ' ButtonEDIT
        ' 
        ButtonEDIT.BackColor = Color.DeepSkyBlue
        ButtonEDIT.ForeColor = Color.White
        ButtonEDIT.Location = New Point(195, 457)
        ButtonEDIT.Margin = New Padding(2)
        ButtonEDIT.Name = "ButtonEDIT"
        ButtonEDIT.Size = New Size(114, 50)
        ButtonEDIT.TabIndex = 14
        ButtonEDIT.Text = "EDIT"
        ButtonEDIT.UseVisualStyleBackColor = False
        ' 
        ' ButtonADD
        ' 
        ButtonADD.BackColor = Color.YellowGreen
        ButtonADD.ForeColor = Color.White
        ButtonADD.Location = New Point(66, 457)
        ButtonADD.Margin = New Padding(2)
        ButtonADD.Name = "ButtonADD"
        ButtonADD.Size = New Size(109, 50)
        ButtonADD.TabIndex = 13
        ButtonADD.Text = "ADD"
        ButtonADD.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewCLIENTS
        ' 
        DataGridViewCLIENTS.BackgroundColor = SystemColors.ControlLight
        DataGridViewCLIENTS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCLIENTS.Location = New Point(499, 41)
        DataGridViewCLIENTS.Margin = New Padding(2)
        DataGridViewCLIENTS.Name = "DataGridViewCLIENTS"
        DataGridViewCLIENTS.RowHeadersWidth = 62
        DataGridViewCLIENTS.Size = New Size(604, 216)
        DataGridViewCLIENTS.TabIndex = 12
        ' 
        ' TextBoxADDRESS
        ' 
        TextBoxADDRESS.Location = New Point(195, 318)
        TextBoxADDRESS.Margin = New Padding(2)
        TextBoxADDRESS.Multiline = True
        TextBoxADDRESS.Name = "TextBoxADDRESS"
        TextBoxADDRESS.Size = New Size(251, 135)
        TextBoxADDRESS.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(66, 318)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 31)
        Label7.TabIndex = 10
        Label7.Text = "Comment:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(105, 250)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 31)
        Label6.TabIndex = 8
        Label6.Text = "Date:"
        ' 
        ' TextBoxPHONE
        ' 
        TextBoxPHONE.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxPHONE.Location = New Point(195, 198)
        TextBoxPHONE.Margin = New Padding(2)
        TextBoxPHONE.Name = "TextBoxPHONE"
        TextBoxPHONE.Size = New Size(251, 38)
        TextBoxPHONE.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(32, 198)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 31)
        Label5.TabIndex = 6
        Label5.Text = "Selling Price:"
        ' 
        ' TextBoxlNAME
        ' 
        TextBoxlNAME.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxlNAME.Location = New Point(195, 143)
        TextBoxlNAME.Margin = New Padding(2)
        TextBoxlNAME.Name = "TextBoxlNAME"
        TextBoxlNAME.Size = New Size(251, 38)
        TextBoxlNAME.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(66, 143)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 31)
        Label4.TabIndex = 4
        Label4.Text = "Client ID:"
        ' 
        ' TextBoxfNAME
        ' 
        TextBoxfNAME.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxfNAME.Location = New Point(195, 81)
        TextBoxfNAME.Margin = New Padding(2)
        TextBoxfNAME.Name = "TextBoxfNAME"
        TextBoxfNAME.Size = New Size(251, 38)
        TextBoxfNAME.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(62, 68)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 31)
        Label3.TabIndex = 2
        Label3.Text = "Owner ID:"
        ' 
        ' TextBoxID
        ' 
        TextBoxID.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxID.Location = New Point(195, 24)
        TextBoxID.Margin = New Padding(2)
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(251, 38)
        TextBoxID.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(103, 24)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 31)
        Label2.TabIndex = 0
        Label2.Text = "ID:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(10, 66)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1130, 8)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gill Sans Ultra Bold", 26F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(106, 0)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 61)
        Label1.TabIndex = 1
        Label1.Text = "SALES"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(10, 2)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(92, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' SalesForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumAquamarine
        ClientSize = New Size(1184, 738)
        Controls.Add(Panel1)
        Margin = New Padding(2)
        Name = "SalesForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sales_Form"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewCLIENTS, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ButtonCLEAR_FIELDS As Button
    Friend WithEvents ButtonREMOVE As Button
    Friend WithEvents ButtonEDIT As Button
    Friend WithEvents ButtonADD As Button
    Friend WithEvents DataGridViewCLIENTS As DataGridView
    Friend WithEvents TextBoxADDRESS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxPHONE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxlNAME As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxfNAME As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class

