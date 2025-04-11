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
        Label1 = New Label()
        livebtn = New Button()
        usersbtn = New Button()
        adminbtn = New Button()
        levelbtn = New Button()
        rescuebtn = New Button()
        msgbtn = New Button()
        reportbtn = New Button()
        SuspendLayout()
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
        Label1.TabIndex = 2
        Label1.Text = "BantayBahaPH Admin"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' livebtn
        ' 
        livebtn.Anchor = AnchorStyles.Top
        livebtn.AutoSize = True
        livebtn.BackColor = Color.White
        livebtn.BackgroundImageLayout = ImageLayout.None
        livebtn.FlatStyle = FlatStyle.Popup
        livebtn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        livebtn.Location = New Point(9, 127)
        livebtn.Margin = New Padding(0)
        livebtn.Name = "livebtn"
        livebtn.Size = New Size(253, 53)
        livebtn.TabIndex = 6
        livebtn.Text = "Live View"
        livebtn.UseVisualStyleBackColor = False
        ' 
        ' usersbtn
        ' 
        usersbtn.Anchor = AnchorStyles.Top
        usersbtn.AutoSize = True
        usersbtn.BackColor = Color.White
        usersbtn.BackgroundImageLayout = ImageLayout.None
        usersbtn.FlatStyle = FlatStyle.Popup
        usersbtn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        usersbtn.Location = New Point(9, 367)
        usersbtn.Margin = New Padding(0)
        usersbtn.Name = "usersbtn"
        usersbtn.Size = New Size(253, 53)
        usersbtn.TabIndex = 7
        usersbtn.Text = "Users"
        usersbtn.UseVisualStyleBackColor = False
        ' 
        ' adminbtn
        ' 
        adminbtn.Anchor = AnchorStyles.Top
        adminbtn.AutoSize = True
        adminbtn.BackColor = Color.White
        adminbtn.BackgroundImageLayout = ImageLayout.None
        adminbtn.FlatStyle = FlatStyle.Popup
        adminbtn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        adminbtn.Location = New Point(9, 319)
        adminbtn.Margin = New Padding(0)
        adminbtn.Name = "adminbtn"
        adminbtn.Size = New Size(253, 53)
        adminbtn.TabIndex = 8
        adminbtn.Text = "Admins"
        adminbtn.UseVisualStyleBackColor = False
        ' 
        ' levelbtn
        ' 
        levelbtn.Anchor = AnchorStyles.Top
        levelbtn.AutoSize = True
        levelbtn.BackColor = Color.White
        levelbtn.BackgroundImageLayout = ImageLayout.None
        levelbtn.FlatStyle = FlatStyle.Popup
        levelbtn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        levelbtn.Location = New Point(9, 271)
        levelbtn.Margin = New Padding(0)
        levelbtn.Name = "levelbtn"
        levelbtn.Size = New Size(253, 53)
        levelbtn.TabIndex = 9
        levelbtn.Text = "Water Level"
        levelbtn.UseVisualStyleBackColor = False
        ' 
        ' rescuebtn
        ' 
        rescuebtn.Anchor = AnchorStyles.Top
        rescuebtn.AutoSize = True
        rescuebtn.BackColor = Color.White
        rescuebtn.BackgroundImageLayout = ImageLayout.None
        rescuebtn.FlatStyle = FlatStyle.Popup
        rescuebtn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        rescuebtn.Location = New Point(9, 175)
        rescuebtn.Margin = New Padding(0)
        rescuebtn.Name = "rescuebtn"
        rescuebtn.Size = New Size(253, 53)
        rescuebtn.TabIndex = 10
        rescuebtn.Text = "Notification"
        rescuebtn.UseVisualStyleBackColor = False
        ' 
        ' msgbtn
        ' 
        msgbtn.Anchor = AnchorStyles.Top
        msgbtn.AutoSize = True
        msgbtn.BackColor = Color.White
        msgbtn.BackgroundImageLayout = ImageLayout.None
        msgbtn.FlatStyle = FlatStyle.Popup
        msgbtn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        msgbtn.Location = New Point(9, 223)
        msgbtn.Margin = New Padding(0)
        msgbtn.Name = "msgbtn"
        msgbtn.Size = New Size(253, 53)
        msgbtn.TabIndex = 11
        msgbtn.Text = "Rescues"
        msgbtn.UseVisualStyleBackColor = False
        ' 
        ' reportbtn
        ' 
        reportbtn.Anchor = AnchorStyles.Top
        reportbtn.AutoSize = True
        reportbtn.BackColor = Color.White
        reportbtn.BackgroundImageLayout = ImageLayout.None
        reportbtn.FlatStyle = FlatStyle.Popup
        reportbtn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        reportbtn.Location = New Point(9, 420)
        reportbtn.Margin = New Padding(0)
        reportbtn.Name = "reportbtn"
        reportbtn.Size = New Size(253, 53)
        reportbtn.TabIndex = 12
        reportbtn.Text = "History/Report"
        reportbtn.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(reportbtn)
        Controls.Add(msgbtn)
        Controls.Add(rescuebtn)
        Controls.Add(levelbtn)
        Controls.Add(adminbtn)
        Controls.Add(usersbtn)
        Controls.Add(livebtn)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BantayBahaPH Admin Dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents livebtn As Button
    Friend WithEvents usersbtn As Button
    Friend WithEvents adminbtn As Button
    Friend WithEvents levelbtn As Button
    Friend WithEvents rescuebtn As Button
    Friend WithEvents msgbtn As Button
    Friend WithEvents reportbtn As Button
End Class
