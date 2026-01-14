<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 學生對弈查詢
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
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        DateTimePicker1 = New DateTimePicker()
        Button3 = New Button()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources._6
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(976, 24)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 76)
        Button1.TabIndex = 1
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(460, 151)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(571, 455)
        DataGridView1.TabIndex = 13
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        DateTimePicker1.Font = New Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        DateTimePicker1.Location = New Point(118, 309)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(209, 38)
        DateTimePicker1.TabIndex = 12
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("微軟正黑體", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Button3.Location = New Point(361, 538)
        Button3.Name = "Button3"
        Button3.Size = New Size(88, 58)
        Button3.TabIndex = 15
        Button3.Text = "全部"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("微軟正黑體", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Button4.Location = New Point(273, 538)
        Button4.Name = "Button4"
        Button4.Size = New Size(88, 58)
        Button4.TabIndex = 14
        Button4.Text = "確定"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' 學生對弈查詢
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.圍棋__6_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1119, 631)
        Controls.Add(Button3)
        Controls.Add(Button4)
        Controls.Add(DataGridView1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button1)
        Name = "學生對弈查詢"
        Text = "學生對弈查詢"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
