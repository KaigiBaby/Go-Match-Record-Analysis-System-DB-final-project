<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 登入
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
        btn_return = New Button()
        loginEnter = New Button()
        loginAct = New TextBox()
        loginPwd = New TextBox()
        Label = New Label()
        SuspendLayout()
        ' 
        ' btn_return
        ' 
        btn_return.BackColor = Color.Transparent
        btn_return.FlatStyle = FlatStyle.Flat
        btn_return.Location = New Point(988, 12)
        btn_return.Name = "btn_return"
        btn_return.Size = New Size(108, 78)
        btn_return.TabIndex = 3
        btn_return.UseVisualStyleBackColor = False
        ' 
        ' loginEnter
        ' 
        loginEnter.BackColor = Color.Transparent
        loginEnter.FlatStyle = FlatStyle.Flat
        loginEnter.Location = New Point(900, 532)
        loginEnter.Name = "loginEnter"
        loginEnter.Size = New Size(160, 66)
        loginEnter.TabIndex = 4
        loginEnter.UseVisualStyleBackColor = False
        ' 
        ' loginAct
        ' 
        loginAct.Font = New Font("微軟正黑體", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        loginAct.Location = New Point(455, 222)
        loginAct.Name = "loginAct"
        loginAct.Size = New Size(319, 43)
        loginAct.TabIndex = 5
        ' 
        ' loginPwd
        ' 
        loginPwd.Font = New Font("微軟正黑體", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        loginPwd.Location = New Point(455, 345)
        loginPwd.Name = "loginPwd"
        loginPwd.Size = New Size(319, 43)
        loginPwd.TabIndex = 6
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Font = New Font("微軟正黑體", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Label.Location = New Point(434, 92)
        Label.Name = "Label"
        Label.Size = New Size(136, 76)
        Label.TabIndex = 7
        Label.Text = "Lab"
        ' 
        ' 登入
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._3
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1119, 631)
        Controls.Add(Label)
        Controls.Add(loginPwd)
        Controls.Add(loginAct)
        Controls.Add(loginEnter)
        Controls.Add(btn_return)
        Name = "登入"
        Text = "登入"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_return As Button
    Friend WithEvents loginEnter As Button
    Friend WithEvents loginAct As TextBox
    Friend WithEvents loginPwd As TextBox
    Friend WithEvents Label As Label
End Class
