<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 修改老師資料
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        btnSaveTeacher = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("微軟正黑體", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        TextBox1.Location = New Point(431, 206)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(256, 43)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("微軟正黑體", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        TextBox2.Location = New Point(431, 286)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(256, 43)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("微軟正黑體", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        TextBox3.Location = New Point(431, 366)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(256, 43)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("微軟正黑體", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        TextBox4.Location = New Point(431, 438)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(256, 43)
        TextBox4.TabIndex = 3
        ' 
        ' btnSaveTeacher
        ' 
        btnSaveTeacher.Location = New Point(903, 535)
        btnSaveTeacher.Name = "btnSaveTeacher"
        btnSaveTeacher.Size = New Size(168, 68)
        btnSaveTeacher.TabIndex = 4
        btnSaveTeacher.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = My.Resources.Resources._6
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(977, 21)
        Button2.Name = "Button2"
        Button2.Size = New Size(113, 76)
        Button2.TabIndex = 5
        Button2.Text = "Button1"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' 修改老師資料
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.圍棋__2_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1119, 631)
        Controls.Add(Button2)
        Controls.Add(btnSaveTeacher)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "修改老師資料"
        StartPosition = FormStartPosition.CenterScreen
        Text = "修改老師資料"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnSaveTeacher As Button
    Friend WithEvents Button2 As Button
End Class
