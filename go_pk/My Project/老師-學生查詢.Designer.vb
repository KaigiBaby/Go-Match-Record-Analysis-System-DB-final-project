<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 老師_學生查詢
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(427, 227)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(404, 264)
        DataGridView1.TabIndex = 0
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(180, 368)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(233, 27)
        ComboBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources._6
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(977, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 76)
        Button1.TabIndex = 7
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' 老師_學生查詢
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.老師_查詢學生背景
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1119, 631)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(DataGridView1)
        DoubleBuffered = True
        Name = "老師_學生查詢"
        Text = "老師_學生查詢"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
End Class
