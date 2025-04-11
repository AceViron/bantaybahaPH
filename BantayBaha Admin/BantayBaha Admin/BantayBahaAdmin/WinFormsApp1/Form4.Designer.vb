<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        titlebox = New TextBox()
        messagebox1 = New TextBox()
        datebox = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        sendbtn = New Button()
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
        Label1.Location = New Point(9, 9)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Size = New Size(628, 62)
        Label1.TabIndex = 28
        Label1.Text = "BantayBahaPH Notification"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' titlebox
        ' 
        titlebox.Location = New Point(25, 135)
        titlebox.Margin = New Padding(3, 4, 3, 4)
        titlebox.Multiline = True
        titlebox.Name = "titlebox"
        titlebox.Size = New Size(491, 60)
        titlebox.TabIndex = 29
        ' 
        ' messagebox1
        ' 
        messagebox1.Location = New Point(25, 232)
        messagebox1.Margin = New Padding(3, 4, 3, 4)
        messagebox1.Multiline = True
        messagebox1.Name = "messagebox1"
        messagebox1.ScrollBars = ScrollBars.Vertical
        messagebox1.Size = New Size(636, 328)
        messagebox1.TabIndex = 30
        messagebox1.Text = " "
        ' 
        ' datebox
        ' 
        datebox.Location = New Point(523, 135)
        datebox.Margin = New Padding(3, 4, 3, 4)
        datebox.Multiline = True
        datebox.Name = "datebox"
        datebox.Size = New Size(138, 60)
        datebox.TabIndex = 31
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(25, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 28)
        Label2.TabIndex = 32
        Label2.Text = "Title"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(25, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 28)
        Label3.TabIndex = 33
        Label3.Text = "Message"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(523, 103)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 28)
        Label4.TabIndex = 34
        Label4.Text = "Date"
        ' 
        ' sendbtn
        ' 
        sendbtn.BackColor = SystemColors.Control
        sendbtn.Location = New Point(669, 496)
        sendbtn.Margin = New Padding(3, 4, 3, 4)
        sendbtn.Name = "sendbtn"
        sendbtn.Size = New Size(232, 65)
        sendbtn.TabIndex = 35
        sendbtn.Text = "Send"
        sendbtn.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImage = My.Resources.Resources.background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(sendbtn)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(datebox)
        Controls.Add(messagebox1)
        Controls.Add(titlebox)
        Controls.Add(Label1)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BantayBahaPH Notification"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents titlebox As TextBox
    Friend WithEvents messagebox1 As TextBox
    Friend WithEvents datebox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sendbtn As Button
End Class
