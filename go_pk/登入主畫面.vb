Public Class 登入主畫面
    Public Shared ConnectionString As String = "Server=127.0.0.1;Database=forgo;User Id=root;Password=0000;"
    Public Shared QueryString As String
    Public Shared CurrentUserAccount As String
    Public Shared CurrentUserSid As String
    Public Shared CurrentUserTid As String

    Private Sub UserCheck1(sender As Object, e As EventArgs) Handles User1.Click
        QueryString = "SELECT * FROM 學生 WHERE saccount=@saccount AND spassword=@spassword"
        登入.Label.Tag = 1
        登入.UpdateLabel()
        登入.Show()
        Hide()
    End Sub

    Private Sub UserCheck2(sender As Object, e As EventArgs) Handles User2.Click
        QueryString = "SELECT * FROM 老師 WHERE Taccount=@Taccount AND Tpassword=@Tpassword"
        登入.Label.Tag = 2
        登入.UpdateLabel()
        登入.Show()
        Hide()
    End Sub

    Private Sub UserCheck3(sender As Object, e As EventArgs) Handles User3.Click
        註冊.Show()
        Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        User1.FlatStyle = FlatStyle.Flat
        User1.FlatAppearance.BorderSize = 0
        User1.FlatAppearance.MouseOverBackColor = User1.BackColor
        User1.FlatAppearance.MouseDownBackColor = User1.BackColor
        User2.FlatStyle = FlatStyle.Flat
        User2.FlatAppearance.BorderSize = 0
        User2.FlatAppearance.MouseOverBackColor = User2.BackColor
        User2.FlatAppearance.MouseDownBackColor = User2.BackColor
        User3.FlatStyle = FlatStyle.Flat
        User3.FlatAppearance.BorderSize = 0
        User3.FlatAppearance.MouseOverBackColor = User3.BackColor
        User3.FlatAppearance.MouseDownBackColor = User3.BackColor

        ' 設置 KeyPreview 為 True 以捕捉按鍵事件
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' 檢查按下的是否為 Esc 鍵
        If e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If
    End Sub
End Class