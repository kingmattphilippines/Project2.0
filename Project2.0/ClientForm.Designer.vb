﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ClientForm))
        Panel1 = New Panel()
        Button1 = New Button()
        Panel3 = New Panel()
        ButtonCLEAR_FIELDS = New Button()
        ButtonREMOVE = New Button()
        ButtonEDIT = New Button()
        ButtonADD = New Button()
        DataGridViewCLIENTS = New DataGridView()
        TextBoxADDRESS = New TextBox()
        Label7 = New Label()
        TextBoxMAIL = New TextBox()
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
        CType(DataGridViewCLIENTS, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MistyRose
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(41, 20)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1129, 817)
        Panel1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Castellar", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(1089, 2)
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
        Panel3.Controls.Add(ButtonCLEAR_FIELDS)
        Panel3.Controls.Add(ButtonREMOVE)
        Panel3.Controls.Add(ButtonEDIT)
        Panel3.Controls.Add(ButtonADD)
        Panel3.Controls.Add(DataGridViewCLIENTS)
        Panel3.Controls.Add(TextBoxADDRESS)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(TextBoxMAIL)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(TextBoxPHONE)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(TextBoxlNAME)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(TextBoxfNAME)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TextBoxID)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(0, 106)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1127, 462)
        Panel3.TabIndex = 4
        ' 
        ' ButtonCLEAR_FIELDS
        ' 
        ButtonCLEAR_FIELDS.BackColor = Color.Gold
        ButtonCLEAR_FIELDS.ForeColor = Color.Black
        ButtonCLEAR_FIELDS.Location = New Point(17, 396)
        ButtonCLEAR_FIELDS.Margin = New Padding(2)
        ButtonCLEAR_FIELDS.Name = "ButtonCLEAR_FIELDS"
        ButtonCLEAR_FIELDS.Size = New Size(488, 40)
        ButtonCLEAR_FIELDS.TabIndex = 16
        ButtonCLEAR_FIELDS.Text = "Clear Fields"
        ButtonCLEAR_FIELDS.UseVisualStyleBackColor = False
        ' 
        ' ButtonREMOVE
        ' 
        ButtonREMOVE.BackColor = Color.Red
        ButtonREMOVE.ForeColor = Color.White
        ButtonREMOVE.Location = New Point(329, 352)
        ButtonREMOVE.Margin = New Padding(2)
        ButtonREMOVE.Name = "ButtonREMOVE"
        ButtonREMOVE.Size = New Size(176, 40)
        ButtonREMOVE.TabIndex = 15
        ButtonREMOVE.Text = "REMOVE"
        ButtonREMOVE.UseVisualStyleBackColor = False
        ' 
        ' ButtonEDIT
        ' 
        ButtonEDIT.BackColor = Color.DeepSkyBlue
        ButtonEDIT.ForeColor = Color.White
        ButtonEDIT.Location = New Point(176, 352)
        ButtonEDIT.Margin = New Padding(2)
        ButtonEDIT.Name = "ButtonEDIT"
        ButtonEDIT.Size = New Size(139, 40)
        ButtonEDIT.TabIndex = 14
        ButtonEDIT.Text = "EDIT"
        ButtonEDIT.UseVisualStyleBackColor = False
        ' 
        ' ButtonADD
        ' 
        ButtonADD.BackColor = Color.YellowGreen
        ButtonADD.ForeColor = Color.White
        ButtonADD.Location = New Point(17, 352)
        ButtonADD.Margin = New Padding(2)
        ButtonADD.Name = "ButtonADD"
        ButtonADD.Size = New Size(145, 40)
        ButtonADD.TabIndex = 13
        ButtonADD.Text = "ADD"
        ButtonADD.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewCLIENTS
        ' 
        DataGridViewCLIENTS.BackgroundColor = SystemColors.ControlLight
        DataGridViewCLIENTS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCLIENTS.Location = New Point(530, 18)
        DataGridViewCLIENTS.Margin = New Padding(2)
        DataGridViewCLIENTS.Name = "DataGridViewCLIENTS"
        DataGridViewCLIENTS.RowHeadersWidth = 62
        DataGridViewCLIENTS.Size = New Size(575, 314)
        DataGridViewCLIENTS.TabIndex = 12
        ' 
        ' TextBoxADDRESS
        ' 
        TextBoxADDRESS.Location = New Point(143, 231)
        TextBoxADDRESS.Margin = New Padding(2)
        TextBoxADDRESS.Multiline = True
        TextBoxADDRESS.Name = "TextBoxADDRESS"
        TextBoxADDRESS.Size = New Size(362, 102)
        TextBoxADDRESS.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(52, 234)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 20)
        Label7.TabIndex = 10
        Label7.Text = "Address:"
        ' 
        ' TextBoxMAIL
        ' 
        TextBoxMAIL.Location = New Point(143, 190)
        TextBoxMAIL.Margin = New Padding(2)
        TextBoxMAIL.Name = "TextBoxMAIL"
        TextBoxMAIL.Size = New Size(362, 27)
        TextBoxMAIL.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(52, 192)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 20)
        Label6.TabIndex = 8
        Label6.Text = "Email:"
        ' 
        ' TextBoxPHONE
        ' 
        TextBoxPHONE.Location = New Point(143, 148)
        TextBoxPHONE.Margin = New Padding(2)
        TextBoxPHONE.Name = "TextBoxPHONE"
        TextBoxPHONE.Size = New Size(362, 27)
        TextBoxPHONE.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(52, 150)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 6
        Label5.Text = "Phone:"
        ' 
        ' TextBoxlNAME
        ' 
        TextBoxlNAME.Location = New Point(143, 103)
        TextBoxlNAME.Margin = New Padding(2)
        TextBoxlNAME.Name = "TextBoxlNAME"
        TextBoxlNAME.Size = New Size(362, 27)
        TextBoxlNAME.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(52, 106)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 20)
        Label4.TabIndex = 4
        Label4.Text = "Last Name:"
        ' 
        ' TextBoxfNAME
        ' 
        TextBoxfNAME.Location = New Point(143, 62)
        TextBoxfNAME.Margin = New Padding(2)
        TextBoxfNAME.Name = "TextBoxfNAME"
        TextBoxfNAME.Size = New Size(362, 27)
        TextBoxfNAME.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(52, 65)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 2
        Label3.Text = "First Name:"
        ' 
        ' TextBoxID
        ' 
        TextBoxID.Location = New Point(143, 18)
        TextBoxID.Margin = New Padding(2)
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(362, 27)
        TextBoxID.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(52, 21)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 20)
        Label2.TabIndex = 0
        Label2.Text = "ID:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(10, 85)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1117, 8)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gill Sans Ultra Bold", 26F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(106, 19)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(247, 61)
        Label1.TabIndex = 1
        Label1.Text = "CLIENTS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(10, 2)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(92, 78)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ClientForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(1202, 783)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "ClientForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridViewCLIENTS, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ButtonCLEAR_FIELDS As Button
    Friend WithEvents ButtonREMOVE As Button
    Friend WithEvents ButtonEDIT As Button
    Friend WithEvents ButtonADD As Button
    Friend WithEvents DataGridViewCLIENTS As DataGridView
    Friend WithEvents TextBoxADDRESS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxMAIL As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxPHONE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxlNAME As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxfNAME As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label2 As Label
End Class
