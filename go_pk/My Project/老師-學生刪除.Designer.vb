<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 老師_學生刪除
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
        Button2 = New Button()
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
        Button1.TabIndex = 8
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(453, 325)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(397, 27)
        ComboBox1.TabIndex = 9
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(903, 536)
        Button2.Name = "Button2"
        Button2.Size = New Size(160, 61)
        Button2.TabIndex = 10
        Button2.UseVisualStyleBackColor = False
        ' 
        ' 老師_學生刪除
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.圍棋__3_
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1119, 631)
        Controls.Add(Button2)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Name = "老師_學生刪除"
        Text = "老師_學生刪除"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
End Class
