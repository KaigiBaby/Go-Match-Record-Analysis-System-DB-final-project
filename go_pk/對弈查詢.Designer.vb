<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 對弈查詢
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
        ComboBox1 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        CheckBox1 = New CheckBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("微軟正黑體", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Button1.Location = New Point(171, 382)
        Button1.Name = "Button1"
        Button1.Size = New Size(88, 58)
        Button1.TabIndex = 7
        Button1.Text = "確定"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.FromArgb(CByte(189), CByte(143), CByte(83))
        ComboBox1.Font = New Font("微軟正黑體", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(30, 118)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(209, 42)
        ComboBox1.TabIndex = 8
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        DateTimePicker1.Font = New Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        DateTimePicker1.Location = New Point(54, 280)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(209, 38)
        DateTimePicker1.TabIndex = 9
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(357, -2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(554, 451)
        DataGridView1.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("微軟正黑體", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Button2.Location = New Point(259, 382)
        Button2.Name = "Button2"
        Button2.Size = New Size(88, 58)
        Button2.TabIndex = 11
        Button2.Text = "全部"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        CheckBox1.Location = New Point(30, 294)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(18, 17)
        CheckBox1.TabIndex = 12
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' 對弈查詢
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.米色黑色銅色_暖色系_經典風格的_品牌設計師_作品集簡報__9_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(910, 447)
        Controls.Add(CheckBox1)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "對弈查詢"
        Text = "對弈查詢"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
