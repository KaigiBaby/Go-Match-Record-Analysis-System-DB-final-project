<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 登入主畫面
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
        User3 = New Button()
        User2 = New Button()
        User1 = New Button()
        SuspendLayout()
        ' 
        ' User3
        ' 
        User3.BackColor = Color.Transparent
        User3.FlatStyle = FlatStyle.Flat
        User3.Location = New Point(907, 534)
        User3.Name = "User3"
        User3.Size = New Size(153, 67)
        User3.TabIndex = 5
        User3.UseVisualStyleBackColor = False
        ' 
        ' User2
        ' 
        User2.BackColor = Color.Transparent
        User2.FlatStyle = FlatStyle.Flat
        User2.Location = New Point(655, 294)
        User2.Name = "User2"
        User2.Size = New Size(303, 98)
        User2.TabIndex = 4
        User2.UseVisualStyleBackColor = False
        ' 
        ' User1
        ' 
        User1.BackColor = Color.Transparent
        User1.FlatStyle = FlatStyle.Flat
        User1.Location = New Point(145, 294)
        User1.Name = "User1"
        User1.Size = New Size(328, 98)
        User1.TabIndex = 3
        User1.UseVisualStyleBackColor = False
        ' 
        ' 登入主畫面
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1119, 631)
        Controls.Add(User3)
        Controls.Add(User2)
        Controls.Add(User1)
        Name = "登入主畫面"
        Text = "登入主畫面"
        ResumeLayout(False)
    End Sub

    Friend WithEvents User3 As Button
    Friend WithEvents User2 As Button
    Friend WithEvents User1 As Button
End Class
