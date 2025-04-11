<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        regbtn = New Button()
        password = New TextBox()
        username = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        bckbtn = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' regbtn
        ' 
        regbtn.BackColor = Color.Orange
        regbtn.BackgroundImageLayout = ImageLayout.None
        regbtn.FlatStyle = FlatStyle.Popup
        regbtn.Font = New Font("Arial", 9F, FontStyle.Bold)
        regbtn.Location = New Point(81, 132)
        regbtn.Margin = New Padding(0)
        regbtn.Name = "regbtn"
        regbtn.Size = New Size(191, 23)
        regbtn.TabIndex = 11
        regbtn.Text = "Register"
        regbtn.UseVisualStyleBackColor = False
        ' 
        ' password
        ' 
        password.Font = New Font("Arial", 9F, FontStyle.Bold)
        password.Location = New Point(81, 103)
        password.Name = "password"
        password.PasswordChar = "*"c
        password.Size = New Size(191, 21)
        password.TabIndex = 9
        ' 
        ' username
        ' 
        username.Font = New Font("Arial", 9F, FontStyle.Bold)
        username.Location = New Point(81, 63)
        username.Name = "username"
        username.Size = New Size(191, 21)
        username.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label2.Location = New Point(12, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 7
        Label2.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label1.Location = New Point(12, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 6
        Label1.Text = "Username:"
        ' 
        ' bckbtn
        ' 
        bckbtn.BackColor = Color.Orange
        bckbtn.FlatStyle = FlatStyle.Popup
        bckbtn.Font = New Font("Arial", 9F, FontStyle.Bold)
        bckbtn.ForeColor = SystemColors.ControlText
        bckbtn.Location = New Point(81, 161)
        bckbtn.Name = "bckbtn"
        bckbtn.Size = New Size(191, 23)
        bckbtn.TabIndex = 12
        bckbtn.Text = "Back"
        bckbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(164, 34)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(284, 261)
        Controls.Add(PictureBox1)
        Controls.Add(bckbtn)
        Controls.Add(regbtn)
        Controls.Add(password)
        Controls.Add(username)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "BantayBahaPH Admin Register"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents regbtn As Button
    Friend WithEvents password As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bckbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
