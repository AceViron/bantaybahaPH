<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        username = New TextBox()
        addusers = New Button()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        selectuser = New Button()
        bntupdateuser = New Button()
        bntdeleteuser = New Button()
        useremail = New TextBox()
        useraddress = New TextBox()
        usercontact = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' username
        ' 
        username.Location = New Point(9, 155)
        username.Name = "username"
        username.Size = New Size(243, 27)
        username.TabIndex = 33
        ' 
        ' addusers
        ' 
        addusers.Anchor = AnchorStyles.Top
        addusers.AutoSize = True
        addusers.BackColor = Color.White
        addusers.BackgroundImageLayout = ImageLayout.None
        addusers.FlatStyle = FlatStyle.Popup
        addusers.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addusers.Location = New Point(9, 420)
        addusers.Margin = New Padding(0)
        addusers.Name = "addusers"
        addusers.Size = New Size(243, 38)
        addusers.TabIndex = 30
        addusers.Text = "ADD"
        addusers.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(267, 129)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(635, 458)
        DataGridView1.TabIndex = 29
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(9, 9)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Size = New Size(484, 62)
        Label1.TabIndex = 28
        Label1.Text = "BantayBahaPH Users"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' selectuser
        ' 
        selectuser.Anchor = AnchorStyles.Top
        selectuser.AutoSize = True
        selectuser.BackColor = Color.White
        selectuser.BackgroundImageLayout = ImageLayout.None
        selectuser.FlatStyle = FlatStyle.Popup
        selectuser.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        selectuser.Location = New Point(9, 382)
        selectuser.Margin = New Padding(0)
        selectuser.Name = "selectuser"
        selectuser.Size = New Size(243, 38)
        selectuser.TabIndex = 34
        selectuser.Text = "SELECT"
        selectuser.UseVisualStyleBackColor = False
        ' 
        ' bntupdateuser
        ' 
        bntupdateuser.Anchor = AnchorStyles.Top
        bntupdateuser.AutoSize = True
        bntupdateuser.BackColor = Color.White
        bntupdateuser.BackgroundImageLayout = ImageLayout.None
        bntupdateuser.FlatStyle = FlatStyle.Popup
        bntupdateuser.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bntupdateuser.Location = New Point(9, 458)
        bntupdateuser.Margin = New Padding(0)
        bntupdateuser.Name = "bntupdateuser"
        bntupdateuser.Size = New Size(243, 38)
        bntupdateuser.TabIndex = 35
        bntupdateuser.Text = "UPDATE"
        bntupdateuser.UseVisualStyleBackColor = False
        ' 
        ' bntdeleteuser
        ' 
        bntdeleteuser.Anchor = AnchorStyles.Top
        bntdeleteuser.AutoSize = True
        bntdeleteuser.BackColor = Color.White
        bntdeleteuser.BackgroundImageLayout = ImageLayout.None
        bntdeleteuser.FlatStyle = FlatStyle.Popup
        bntdeleteuser.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bntdeleteuser.Location = New Point(9, 496)
        bntdeleteuser.Margin = New Padding(0)
        bntdeleteuser.Name = "bntdeleteuser"
        bntdeleteuser.Size = New Size(243, 38)
        bntdeleteuser.TabIndex = 36
        bntdeleteuser.Text = "DELETE"
        bntdeleteuser.UseVisualStyleBackColor = False
        ' 
        ' useremail
        ' 
        useremail.Location = New Point(9, 329)
        useremail.Name = "useremail"
        useremail.Size = New Size(243, 27)
        useremail.TabIndex = 37
        ' 
        ' useraddress
        ' 
        useraddress.Location = New Point(9, 214)
        useraddress.Name = "useraddress"
        useraddress.Size = New Size(243, 27)
        useraddress.TabIndex = 38
        ' 
        ' usercontact
        ' 
        usercontact.Location = New Point(9, 273)
        usercontact.Name = "usercontact"
        usercontact.Size = New Size(243, 27)
        usercontact.TabIndex = 39
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(9, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 40
        Label2.Text = "name"
        Label2.UseMnemonic = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 20)
        Label3.TabIndex = 41
        Label3.Text = "address"
        Label3.UseMnemonic = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(9, 250)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 20)
        Label4.TabIndex = 42
        Label4.Text = "contact"
        Label4.UseMnemonic = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(9, 306)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 20)
        Label5.TabIndex = 43
        Label5.Text = "email"
        Label5.UseMnemonic = False
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(usercontact)
        Controls.Add(useraddress)
        Controls.Add(useremail)
        Controls.Add(bntdeleteuser)
        Controls.Add(bntupdateuser)
        Controls.Add(selectuser)
        Controls.Add(username)
        Controls.Add(addusers)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "Form8"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BantayBahaPH Users"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private Function UpdateUser(docId As String, text As String, text1 As String, text2 As String, text3 As String) As Control
        Throw New NotImplementedException()
    End Function

    Private Function DeleteUser(docId As String) As Control
        Throw New NotImplementedException()
    End Function

    Friend WithEvents username As TextBox
    Private addusers As Button
    Friend WithEvents bntadduser As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents selectuser As Button
    Private WithEvents bntupdateuser As Button
    Private WithEvents bntdeleteuser As Button
    Friend WithEvents useremail As TextBox
    Friend WithEvents useraddress As TextBox
    Friend WithEvents usercontact As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class