<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        searchbox = New TextBox()
        addbtn = New Button()
        DataGridView2 = New DataGridView()
        Label1 = New Label()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' searchbox
        ' 
        searchbox.Location = New Point(9, 129)
        searchbox.Name = "searchbox"
        searchbox.Size = New Size(243, 27)
        searchbox.TabIndex = 33
        ' 
        ' addbtn
        ' 
        addbtn.Anchor = AnchorStyles.Top
        addbtn.AutoSize = True
        addbtn.BackColor = Color.White
        addbtn.BackgroundImageLayout = ImageLayout.None
        addbtn.FlatStyle = FlatStyle.Popup
        addbtn.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addbtn.Location = New Point(9, 159)
        addbtn.Margin = New Padding(0)
        addbtn.Name = "searchbnt"
        addbtn.Size = New Size(243, 38)
        addbtn.TabIndex = 30
        addbtn.Text = "SEARCH"
        addbtn.UseVisualStyleBackColor = False
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(267, 129)
        DataGridView2.Margin = New Padding(3, 4, 3, 4)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(635, 458)
        DataGridView2.TabIndex = 29
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
        Label1.Size = New Size(537, 62)
        Label1.TabIndex = 28
        Label1.Text = "BantayBahaPH Rescues"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(searchbox)
        Controls.Add(addbtn)
        Controls.Add(DataGridView2)
        Controls.Add(Label1)
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BantayBahaPH Rescues"
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents searchbox As TextBox
    Friend WithEvents addbtn As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label1 As Label
End Class
