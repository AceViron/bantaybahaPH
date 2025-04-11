Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso Components1 IsNot Nothing Then
                Components1.Dispose()
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
        user_txtbox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        pass_txtbox = New TextBox()
        loginbtn = New Button()
        SuspendLayout()
        ' 
        ' user_txtbox
        ' 
        user_txtbox.BorderStyle = BorderStyle.None
        user_txtbox.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        user_txtbox.Location = New Point(10, 156)
        user_txtbox.Margin = New Padding(0)
        user_txtbox.Name = "user_txtbox"
        user_txtbox.Size = New Size(457, 27)
        user_txtbox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(10, 12)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Size = New Size(510, 62)
        Label1.TabIndex = 1
        Label1.Text = "BantayBahaPH Admin"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.ImageAlign = ContentAlignment.TopCenter
        Label2.Location = New Point(10, 116)
        Label2.Margin = New Padding(0)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 37)
        Label2.TabIndex = 2
        Label2.Text = "Username:"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.ImageAlign = ContentAlignment.TopCenter
        Label3.Location = New Point(10, 185)
        Label3.Margin = New Padding(0)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 37)
        Label3.TabIndex = 4
        Label3.Text = "Password:"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' pass_txtbox
        ' 
        pass_txtbox.BorderStyle = BorderStyle.None
        pass_txtbox.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pass_txtbox.Location = New Point(10, 225)
        pass_txtbox.Margin = New Padding(0)
        pass_txtbox.Name = "pass_txtbox"
        pass_txtbox.PasswordChar = "*"c
        pass_txtbox.Size = New Size(457, 27)
        pass_txtbox.TabIndex = 3
        ' 
        ' loginbtn
        ' 
        loginbtn.Anchor = AnchorStyles.Top
        loginbtn.AutoSize = True
        loginbtn.BackColor = Color.White
        loginbtn.BackgroundImageLayout = ImageLayout.None
        loginbtn.FlatStyle = FlatStyle.Popup
        loginbtn.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loginbtn.Location = New Point(8, 273)
        loginbtn.Margin = New Padding(0)
        loginbtn.Name = "loginbtn"
        loginbtn.Size = New Size(457, 56)
        loginbtn.TabIndex = 5
        loginbtn.Text = "Login"
        loginbtn.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackgroundImage = My.Resources.Resources.background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(loginbtn)
        Controls.Add(Label3)
        Controls.Add(pass_txtbox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(user_txtbox)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BantayBahaPH Admin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents user_txtbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pass_txtbox As TextBox
    Friend WithEvents loginbtn As Button

    Public Property Components1 As IContainer
        Get
            Return components
        End Get
        Set(value As IContainer)
            components = value
        End Set
    End Property
End Class
