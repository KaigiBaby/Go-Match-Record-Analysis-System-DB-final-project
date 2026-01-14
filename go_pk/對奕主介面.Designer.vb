<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 對奕主介面
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
        Button4 = New Button()
        Button5 = New Button()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources._6
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(977, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 76)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(189), CByte(143), CByte(83))
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("微軟正黑體", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Button2.Location = New Point(23, 147)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 86)
        Button2.TabIndex = 1
        Button2.Text = "新增"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(189), CByte(143), CByte(83))
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("微軟正黑體", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Button3.Location = New Point(23, 272)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 86)
        Button3.TabIndex = 5
        Button3.Text = "刪除"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(189), CByte(143), CByte(83))
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("微軟正黑體", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Button4.Location = New Point(23, 508)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 86)
        Button4.TabIndex = 6
        Button4.Text = "查詢"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(189), CByte(143), CByte(83))
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Font = New Font("微軟正黑體", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Button5.Location = New Point(23, 393)
        Button5.Name = "Button5"
        Button5.Size = New Size(112, 86)
        Button5.TabIndex = 7
        Button5.Text = "修改"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(166, 148)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(910, 447)
        Panel1.TabIndex = 8
        ' 
        ' 對奕主介面
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.米色黑色銅色_暖色系_經典風格的_品牌設計師_作品集簡報__8_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1119, 631)
        Controls.Add(Panel1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "對奕主介面"
        StartPosition = FormStartPosition.CenterScreen
        Text = "對奕主介面"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
End Class
