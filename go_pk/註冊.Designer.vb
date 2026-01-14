<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 註冊
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
        TextBoxSname = New TextBox()
        ComboBox2 = New ComboBox()
        btn_return = New Button()
        RegisterButton = New Button()
        TextBoxSaccount = New TextBox()
        TextBoxSpassword = New TextBox()
        SuspendLayout()
        ' 
        ' TextBoxSname
        ' 
        TextBoxSname.Font = New Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        TextBoxSname.Location = New Point(96, 211)
        TextBoxSname.Name = "TextBoxSname"
        TextBoxSname.Size = New Size(133, 42)
        TextBoxSname.TabIndex = 0
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(387, 210)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 43)
        ComboBox2.TabIndex = 1
        ' 
        ' btn_return
        ' 
        btn_return.BackColor = Color.Transparent
        btn_return.Location = New Point(999, 19)
        btn_return.Name = "btn_return"
        btn_return.Size = New Size(108, 78)
        btn_return.TabIndex = 2
        btn_return.UseVisualStyleBackColor = False
        ' 
        ' RegisterButton
        ' 
        RegisterButton.BackColor = Color.Transparent
        RegisterButton.Location = New Point(854, 509)
        RegisterButton.Name = "RegisterButton"
        RegisterButton.Size = New Size(207, 93)
        RegisterButton.TabIndex = 3
        RegisterButton.UseVisualStyleBackColor = False
        ' 
        ' TextBoxSaccount
        ' 
        TextBoxSaccount.Font = New Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        TextBoxSaccount.Location = New Point(334, 361)
        TextBoxSaccount.Name = "TextBoxSaccount"
        TextBoxSaccount.Size = New Size(362, 42)
        TextBoxSaccount.TabIndex = 4
        ' 
        ' TextBoxSpassword
        ' 
        TextBoxSpassword.Font = New Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        TextBoxSpassword.Location = New Point(334, 444)
        TextBoxSpassword.Name = "TextBoxSpassword"
        TextBoxSpassword.Size = New Size(362, 42)
        TextBoxSpassword.TabIndex = 5
        ' 
        ' 註冊
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._4
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1119, 631)
        Controls.Add(TextBoxSpassword)
        Controls.Add(TextBoxSaccount)
        Controls.Add(RegisterButton)
        Controls.Add(btn_return)
        Controls.Add(ComboBox2)
        Controls.Add(TextBoxSname)
        Name = "註冊"
        Text = "註冊"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxSname As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents btn_return As Button
    Friend WithEvents RegisterButton As Button
    Friend WithEvents TextBoxSaccount As TextBox
    Friend WithEvents TextBoxSpassword As TextBox
End Class
