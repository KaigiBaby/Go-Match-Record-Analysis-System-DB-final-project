<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 學生資料新增
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
        Button2 = New Button()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = My.Resources.Resources._6
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(977, 21)
        Button2.Name = "Button2"
        Button2.Size = New Size(113, 76)
        Button2.TabIndex = 15
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(909, 560)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 67)
        Button1.TabIndex = 16
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(655, 149)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(247, 27)
        TextBox1.TabIndex = 17
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(655, 223)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(247, 27)
        TextBox2.TabIndex = 18
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(655, 296)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(247, 27)
        TextBox3.TabIndex = 19
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(655, 369)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(247, 27)
        TextBox4.TabIndex = 20
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(655, 444)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(247, 27)
        TextBox5.TabIndex = 21
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(655, 516)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(247, 27)
        TextBox6.TabIndex = 22
        ' 
        ' 學生資料新增
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.圍棋__4_
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1119, 631)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Name = "學生資料新增"
        Text = "學生資料新增"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
End Class
