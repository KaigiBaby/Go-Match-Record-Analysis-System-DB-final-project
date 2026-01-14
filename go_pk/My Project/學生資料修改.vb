Imports MySql.Data.MySqlClient
Public Class 學生資料修改
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim currentSid As Integer
    Private Sub 學生資料修改_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Button1.BackColor
        Button1.FlatAppearance.MouseDownBackColor = Button1.BackColor

        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Button2.BackColor
        Button2.FlatAppearance.MouseDownBackColor = Button2.BackColor

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user=root;password='0000';database=forgo"

        Try
            conn.Open()

            currentSid = CInt(登入主畫面.CurrentUserSid)

            ' 抓取目前使用者的資料
            Dim sql As String = "SELECT sname, school, grade, sphone, slevel, teacher FROM 學生 WHERE sid=@sid"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@sid", currentSid)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                TextBox1.Text = reader("sname").ToString()
                TextBox2.Text = reader("school").ToString()
                TextBox3.Text = reader("grade").ToString()
                TextBox4.Text = reader("sphone").ToString()
                TextBox5.Text = reader("slevel").ToString()
                TextBox6.Text = reader("teacher").ToString()
            End If

            reader.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user=root;password='0000';database=forgo"

        Dim sname, school, grade, sphone, slevel, teacher As String
        sname = TextBox1.Text
        school = TextBox2.Text
        grade = TextBox3.Text
        sphone = TextBox4.Text
        slevel = TextBox5.Text
        teacher = TextBox6.Text

        Try
            ' 更新當前使用者的資料
            Dim sql As String = "UPDATE 學生 SET sname=@sname, school=@school, grade=@grade, sphone=@sphone, slevel=@slevel, teacher=@teacher WHERE sid=@sid"
            conn.Open()
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@sid", currentSid)
            cmd.Parameters.AddWithValue("@sname", sname)
            cmd.Parameters.AddWithValue("@school", school)
            cmd.Parameters.AddWithValue("@grade", grade)
            cmd.Parameters.AddWithValue("@sphone", sphone)
            cmd.Parameters.AddWithValue("@slevel", slevel)
            cmd.Parameters.AddWithValue("@teacher", teacher)
            cmd.ExecuteNonQuery()

            MsgBox("修改成功!", MsgBoxStyle.Information)

            ' 清空 TextBox
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        學生資料功能.Show()
    End Sub
End Class