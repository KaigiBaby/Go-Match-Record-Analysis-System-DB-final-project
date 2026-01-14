<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 對弈新增
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
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox5 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.FromArgb(CByte(189), CByte(143), CByte(83))
        ComboBox1.Font = New Font("微軟正黑體", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(154, 35)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(209, 42)
        ComboBox1.TabIndex = 0
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.FromArgb(CByte(189), CByte(143), CByte(83))
        ComboBox2.Font = New Font("微軟正黑體", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(154, 154)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(209, 42)
        ComboBox2.TabIndex = 1
        ' 
        ' ComboBox3
        ' 
        ComboBox3.BackColor = Color.FromArgb(CByte(189), CByte(143), CByte(83))
        ComboBox3.Font = New Font("微軟正黑體", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(154, 275)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(209, 42)
        ComboBox3.TabIndex = 2
        ' 
        ' ComboBox4
        ' 
        ComboBox4.BackColor = Color.FromArgb(CByte(189), CByte(143), CByte(83))
        ComboBox4.Font = New Font("微軟正黑體", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"9", "13", "19"})
        ComboBox4.Location = New Point(588, 154)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(209, 42)
        ComboBox4.TabIndex = 3
        ' 
        ' ComboBox5
        ' 
        ComboBox5.BackColor = Color.FromArgb(CByte(189), CByte(143), CByte(83))
        ComboBox5.Font = New Font("微軟正黑體", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(588, 275)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(209, 42)
        ComboBox5.TabIndex = 4
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        DateTimePicker1.Font = New Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        DateTimePicker1.Location = New Point(588, 35)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(209, 38)
        DateTimePicker1.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("微軟正黑體", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Button1.Location = New Point(780, 382)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 58)
        Button1.TabIndex = 6
        Button1.Text = "儲存"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' 對弈新增
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._17
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(910, 447)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox5)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "對弈新增"
        Text = "對弈新增"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
End Class
