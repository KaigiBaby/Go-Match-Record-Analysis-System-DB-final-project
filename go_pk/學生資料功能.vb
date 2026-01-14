Public Class 學生資料功能
    Private Sub 學生資料功能_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Button1.BackColor
        Button1.FlatAppearance.MouseDownBackColor = Button1.BackColor

        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Button2.BackColor
        Button2.FlatAppearance.MouseDownBackColor = Button2.BackColor

        Button3.FlatStyle = FlatStyle.Flat
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseOverBackColor = Button3.BackColor
        Button3.FlatAppearance.MouseDownBackColor = Button3.BackColor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        學生資料新增.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        學生資料修改.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        學生功能選擇.Show()

    End Sub
End Class