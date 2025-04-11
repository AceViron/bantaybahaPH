<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Label3 = New Label()
        Label2 = New Label()
        adminpassword = New TextBox()
        bntdeleteuser = New Button()
        bntupdateuser = New Button()
        selectuser = New Button()
        useradmin = New TextBox()
        addusers = New Button()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 20)
        Label3.TabIndex = 55
        Label3.Text = "password"
        Label3.UseMnemonic = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 54
        Label2.Text = "username"
        Label2.UseMnemonic = False
        ' 
        ' adminpassword
        ' 
        adminpassword.Location = New Point(11, 216)
        adminpassword.Name = "adminpassword"
        adminpassword.Size = New Size(243, 27)
        adminpassword.TabIndex = 52
        ' 
        ' bntdeleteuser
        ' 
        bntdeleteuser.Anchor = AnchorStyles.Top
        bntdeleteuser.AutoSize = True
        bntdeleteuser.BackColor = Color.White
        bntdeleteuser.BackgroundImageLayout = ImageLayout.None
        bntdeleteuser.FlatStyle = FlatStyle.Popup
        bntdeleteuser.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bntdeleteuser.Location = New Point(9, 446)
        bntdeleteuser.Margin = New Padding(0)
        bntdeleteuser.Name = "bntdeleteuser"
        bntdeleteuser.Size = New Size(243, 38)
        bntdeleteuser.TabIndex = 50
        bntdeleteuser.Text = "DELETE"
        bntdeleteuser.UseVisualStyleBackColor = False
        ' 
        ' bntupdateuser
        ' 
        bntupdateuser.Anchor = AnchorStyles.Top
        bntupdateuser.AutoSize = True
        bntupdateuser.BackColor = Color.White
        bntupdateuser.BackgroundImageLayout = ImageLayout.None
        bntupdateuser.FlatStyle = FlatStyle.Popup
        bntupdateuser.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bntupdateuser.Location = New Point(9, 387)
        bntupdateuser.Margin = New Padding(0)
        bntupdateuser.Name = "bntupdateuser"
        bntupdateuser.Size = New Size(243, 38)
        bntupdateuser.TabIndex = 49
        bntupdateuser.Text = "UPDATE"
        bntupdateuser.UseVisualStyleBackColor = False
        ' 
        ' selectuser
        ' 
        selectuser.Anchor = AnchorStyles.Top
        selectuser.AutoSize = True
        selectuser.BackColor = Color.White
        selectuser.BackgroundImageLayout = ImageLayout.None
        selectuser.FlatStyle = FlatStyle.Popup
        selectuser.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        selectuser.Location = New Point(9, 277)
        selectuser.Margin = New Padding(0)
        selectuser.Name = "selectuser"
        selectuser.Size = New Size(243, 38)
        selectuser.TabIndex = 48
        selectuser.Text = "SELECT"
        selectuser.UseVisualStyleBackColor = False
        ' 
        ' useradmin
        ' 
        useradmin.Location = New Point(11, 157)
        useradmin.Name = "useradmin"
        useradmin.Size = New Size(243, 27)
        useradmin.TabIndex = 47
        ' 
        ' addusers
        ' 
        addusers.Anchor = AnchorStyles.Top
        addusers.AutoSize = True
        addusers.BackColor = Color.White
        addusers.BackgroundImageLayout = ImageLayout.None
        addusers.FlatStyle = FlatStyle.Popup
        addusers.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addusers.Location = New Point(9, 333)
        addusers.Margin = New Padding(0)
        addusers.Name = "addusers"
        addusers.Size = New Size(243, 38)
        addusers.TabIndex = 46
        addusers.Text = "ADD"
        addusers.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(269, 131)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(635, 458)
        DataGridView1.TabIndex = 45
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(11, 11)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Size = New Size(510, 62)
        Label1.TabIndex = 44
        Label1.Text = "BantayBahaPH Admin"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(adminpassword)
        Controls.Add(bntdeleteuser)
        Controls.Add(bntupdateuser)
        Controls.Add(selectuser)
        Controls.Add(useradmin)
        Controls.Add(addusers)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BantayBahaPH Admins"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents deletebtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents addbtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents adminpassword As TextBox
    Private WithEvents bntdeleteuser As Button
    Private WithEvents bntupdateuser As Button
    Friend WithEvents selectuser As Button
    Friend WithEvents useradmin As TextBox
    Private WithEvents addusers As Button
End Class
