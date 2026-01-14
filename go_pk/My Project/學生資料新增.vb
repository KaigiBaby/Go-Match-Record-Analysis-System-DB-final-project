Imports System.Windows.Forms.Design
Imports MySql.Data.MySqlClient
Public Class 學生資料新增
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Private Sub 學生資料新增_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Button1.BackColor
        Button1.FlatAppearance.MouseDownBackColor = Button1.BackColor

        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Button2.BackColor
        Button2.FlatAppearance.MouseDownBackColor = Button2.BackColor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user=root;password='0000';database=forgo"

        Dim READER As MySqlDataReader
        Dim sname, school, grade, sphone, slevel, teacher As String
        sname = TextBox1.Text
        school = TextBox2.Text
        grade = TextBox3.Text
        sphone = TextBox4.Text
        slevel = TextBox5.Text
        teacher = TextBox6.Text

        Try
            ' 查找目前只有 sid、saccount、spassword 屬性有值的一筆資料  
            Dim findSql As String = "SELECT * FROM 學生 WHERE slevel IS NULL LIMIT 1"
            conn.Open()
            cmd = New MySqlCommand(findSql, conn)
            READER = cmd.ExecuteReader()

            If READER.Read() Then
                Dim sid As Integer = CInt(READER("sid"))

                ' 關閉 Reader 以便進行下一個命令
                READER.Close()

                ' 更新該資料的其他屬性
                Dim updateSql As String = "UPDATE 學生 SET sname=@sname, school=@school, grade=@grade, sphone=@sphone, slevel=@slevel, teacher=@teacher WHERE sid=@sid"
                cmd = New MySqlCommand(updateSql, conn)
                cmd.Parameters.AddWithValue("@sid", sid)
                cmd.Parameters.AddWithValue("@sname", sname)
                cmd.Parameters.AddWithValue("@school", school)
                cmd.Parameters.AddWithValue("@grade", grade)
                cmd.Parameters.AddWithValue("@sphone", sphone)
                cmd.Parameters.AddWithValue("@slevel", slevel)
                cmd.Parameters.AddWithValue("@teacher", teacher)
                cmd.ExecuteNonQuery()

                MsgBox("Data successfully updated!", MsgBoxStyle.Information)

                ' 清空 TextBox
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
            Else
                MsgBox("No record found to update.", MsgBoxStyle.Information)
            End If

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