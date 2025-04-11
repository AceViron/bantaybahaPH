<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        txtuser = New TextBox()
        txtpass = New TextBox()
        loginbtn = New Button()
        regbtn = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label1.Location = New Point(12, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label2.Location = New Point(12, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' txtuser
        ' 
        txtuser.Font = New Font("Arial", 9F, FontStyle.Bold)
        txtuser.Location = New Point(81, 72)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(191, 21)
        txtuser.TabIndex = 2
        ' 
        ' txtpass
        ' 
        txtpass.Font = New Font("Arial", 9F, FontStyle.Bold)
        txtpass.Location = New Point(81, 112)
        txtpass.Name = "txtpass"
        txtpass.PasswordChar = "*"c
        txtpass.Size = New Size(191, 21)
        txtpass.TabIndex = 3
        ' 
        ' loginbtn
        ' 
        loginbtn.BackColor = Color.Orange
        loginbtn.FlatStyle = FlatStyle.Popup
        loginbtn.Font = New Font("Arial", 9F, FontStyle.Bold)
        loginbtn.Location = New Point(81, 141)
        loginbtn.Name = "loginbtn"
        loginbtn.Size = New Size(191, 23)
        loginbtn.TabIndex = 4
        loginbtn.Text = "Login"
        loginbtn.UseVisualStyleBackColor = False
        ' 
        ' regbtn
        ' 
        regbtn.BackColor = Color.Orange
        regbtn.FlatStyle = FlatStyle.Popup
        regbtn.Font = New Font("Arial", 9F, FontStyle.Bold)
        regbtn.Location = New Point(81, 170)
        regbtn.Name = "regbtn"
        regbtn.Size = New Size(191, 23)
        regbtn.TabIndex = 5
        regbtn.Text = "Register"
        regbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Margin = New Padding(0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(164, 34)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(284, 261)
        Controls.Add(PictureBox1)
        Controls.Add(regbtn)
        Controls.Add(loginbtn)
        Controls.Add(txtpass)
        Controls.Add(txtuser)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "BantayBahaPH Admin Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents regbtn As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
