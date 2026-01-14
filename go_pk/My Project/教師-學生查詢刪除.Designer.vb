<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 教師_學生查詢刪除
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
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(200, 367)
        Button1.Name = "Button1"
        Button1.Size = New Size(255, 93)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(673, 367)
        Button2.Name = "Button2"
        Button2.Size = New Size(255, 93)
        Button2.TabIndex = 2
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = My.Resources.Resources._6
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Location = New Point(977, 21)
        Button3.Name = "Button3"
        Button3.Size = New Size(113, 76)
        Button3.TabIndex = 6
        Button3.Text = "Button1"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' 教師_學生查詢刪除
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.老師_學生資料背景
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1119, 631)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        DoubleBuffered = True
        Name = "教師_學生查詢刪除"
        Text = "教師_學生查詢刪除"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
