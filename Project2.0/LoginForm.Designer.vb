<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Label1 = New Label()
        PanelUsername = New Panel()
        textUsername = New TextBox()
        PictureBox2 = New PictureBox()
        PanelPassword = New Panel()
        textPassword = New TextBox()
        PictureBox4 = New PictureBox()
        btnLOGIN = New Button()
        btnCANCEL = New Button()
        LabelError = New Label()
        PictureBox1 = New PictureBox()
        PanelUsername.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        PanelPassword.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(146, 144)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 32)
        Label1.TabIndex = 1
        Label1.Text = "Sign in"
        ' 
        ' PanelUsername
        ' 
        PanelUsername.BackColor = Color.White
        PanelUsername.Controls.Add(textUsername)
        PanelUsername.Controls.Add(PictureBox2)
        PanelUsername.Location = New Point(66, 232)
        PanelUsername.Margin = New Padding(2)
        PanelUsername.Name = "PanelUsername"
        PanelUsername.Size = New Size(258, 46)
        PanelUsername.TabIndex = 2
        ' 
        ' textUsername
        ' 
        textUsername.BorderStyle = BorderStyle.None
        textUsername.ForeColor = Color.Black
        textUsername.Location = New Point(53, 13)
        textUsername.Margin = New Padding(2)
        textUsername.Name = "textUsername"
        textUsername.Size = New Size(195, 20)
        textUsername.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.usernamelogo
        PictureBox2.Image = My.Resources.Resources.usernamelogo
        PictureBox2.Location = New Point(2, 2)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(46, 42)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' PanelPassword
        ' 
        PanelPassword.BackColor = Color.White
        PanelPassword.Controls.Add(textPassword)
        PanelPassword.Controls.Add(PictureBox4)
        PanelPassword.Location = New Point(66, 283)
        PanelPassword.Margin = New Padding(2)
        PanelPassword.Name = "PanelPassword"
        PanelPassword.Size = New Size(258, 46)
        PanelPassword.TabIndex = 4
        ' 
        ' textPassword
        ' 
        textPassword.BorderStyle = BorderStyle.None
        textPassword.ForeColor = Color.Black
        textPassword.Location = New Point(53, 13)
        textPassword.Margin = New Padding(2)
        textPassword.Name = "textPassword"
        textPassword.Size = New Size(195, 20)
        textPassword.TabIndex = 1
        textPassword.UseSystemPasswordChar = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = My.Resources.Resources.passLogo
        PictureBox4.Image = My.Resources.Resources.passLogo
        PictureBox4.Location = New Point(0, 0)
        PictureBox4.Margin = New Padding(2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(48, 46)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' btnLOGIN
        ' 
        btnLOGIN.BackColor = Color.DeepSkyBlue
        btnLOGIN.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnLOGIN.ForeColor = Color.White
        btnLOGIN.Location = New Point(66, 382)
        btnLOGIN.Margin = New Padding(2)
        btnLOGIN.Name = "btnLOGIN"
        btnLOGIN.Size = New Size(258, 36)
        btnLOGIN.TabIndex = 5
        btnLOGIN.Text = "Login"
        btnLOGIN.UseVisualStyleBackColor = False
        ' 
        ' btnCANCEL
        ' 
        btnCANCEL.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnCANCEL.Location = New Point(66, 422)
        btnCANCEL.Margin = New Padding(2)
        btnCANCEL.Name = "btnCANCEL"
        btnCANCEL.Size = New Size(258, 36)
        btnCANCEL.TabIndex = 6
        btnCANCEL.Text = "Cancel"
        btnCANCEL.UseVisualStyleBackColor = True
        ' 
        ' LabelError
        ' 
        LabelError.AutoSize = True
        LabelError.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        LabelError.ForeColor = Color.Red
        LabelError.Location = New Point(117, 341)
        LabelError.Margin = New Padding(2, 0, 2, 0)
        LabelError.Name = "LabelError"
        LabelError.Size = New Size(127, 19)
        LabelError.TabIndex = 7
        LabelError.Text = "Error message here"
        LabelError.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.LOGIN_LOGO
        PictureBox1.Image = My.Resources.Resources.LOGIN_LOGO
        PictureBox1.Location = New Point(131, 43)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 98)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(390, 546)
        Controls.Add(LabelError)
        Controls.Add(btnCANCEL)
        Controls.Add(btnLOGIN)
        Controls.Add(PanelPassword)
        Controls.Add(PanelUsername)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2)
        MaximizeBox = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login_Form"
        PanelUsername.ResumeLayout(False)
        PanelUsername.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        PanelPassword.ResumeLayout(False)
        PanelPassword.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelUsername As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents textUsername As TextBox
    Friend WithEvents PanelPassword As Panel
    Friend WithEvents textPassword As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnLOGIN As Button
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents LabelError As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
