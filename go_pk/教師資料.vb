Public Class 教師資料
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        新增老師資料.Show()
        Hide()

    End Sub

    Private Sub 教師資料_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Button1.BackColor
        Button1.FlatAppearance.MouseDownBackColor = Button1.BackColor
        Button2.BackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Button2.BackColor
        Button2.FlatAppearance.MouseDownBackColor = Button2.BackColor
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        修改老師資料.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        教師功能選擇.Show()
    End Sub
End Class