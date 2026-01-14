<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 統計數據
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(189), CByte(143), CByte(83))
        Label1.Font = New Font("微軟正黑體", 16.2F, FontStyle.Bold)
        Label1.Location = New Point(233, 286)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 36)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(189), CByte(143), CByte(83))
        Label2.Font = New Font("微軟正黑體", 16.2F, FontStyle.Bold)
        Label2.Location = New Point(637, 286)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 36)
        Label2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("微軟正黑體", 16.2F, FontStyle.Bold)
        Label3.Location = New Point(949, 286)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 36)
        Label3.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(189), CByte(143), CByte(83))
        Label4.Font = New Font("微軟正黑體", 16.2F, FontStyle.Bold)
        Label4.Location = New Point(456, 385)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 36)
        Label4.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(189), CByte(143), CByte(83))
        Label5.Font = New Font("微軟正黑體", 16.2F, FontStyle.Bold)
        Label5.Location = New Point(456, 481)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 36)
        Label5.TabIndex = 4
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.FromArgb(CByte(203), CByte(198), CByte(184))
        ComboBox1.Font = New Font("微軟正黑體", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(548, 175)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(254, 46)
        ComboBox1.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources._6
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(977, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 76)
        Button1.TabIndex = 6
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' 統計數據
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.統計數據結果
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1119, 631)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "統計數據"
        StartPosition = FormStartPosition.CenterScreen
        Text = "統計數據"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
End Class
