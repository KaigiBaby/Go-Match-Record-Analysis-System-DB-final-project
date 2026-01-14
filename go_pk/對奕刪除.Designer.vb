<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 對奕刪除
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
        Button1 = New Button()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(265, -1)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(646, 451)
        DataGridView1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("微軟正黑體", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Button1.Location = New Point(142, 382)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 58)
        Button1.TabIndex = 7
        Button1.Text = "刪除"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft JhengHei UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        Label1.Location = New Point(61, 180)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 47)
        Label1.TabIndex = 8
        Label1.Text = "？？？"
        ' 
        ' 對奕刪除
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.米色黑色銅色_暖色系_經典風格的_品牌設計師_作品集簡報__10_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(910, 447)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "對奕刪除"
        Text = "對奕刪除"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
