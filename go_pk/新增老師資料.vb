Imports System.Windows.Forms.Design
Imports MySql.Data.MySqlClient

Public Class 新增老師資料
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub 新增老師資料_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSaveTeacher.BackColor = Color.Transparent
        btnSaveTeacher.FlatStyle = FlatStyle.Flat
        btnSaveTeacher.FlatAppearance.BorderSize = 0
        btnSaveTeacher.FlatAppearance.MouseOverBackColor = btnSaveTeacher.BackColor
        btnSaveTeacher.FlatAppearance.MouseDownBackColor = btnSaveTeacher.BackColor
        Button2.BackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Button2.BackColor
        Button2.FlatAppearance.MouseDownBackColor = Button2.BackColor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSaveTeacher.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user=root;password='0000';database=forgo"

        Dim Tname As String = TextBox1.Text
        Dim Tlevel As String = TextBox4.Text
        Dim Tphone As String = TextBox2.Text
        Dim workdate As Date

        If String.IsNullOrWhiteSpace(Tname) Or String.IsNullOrWhiteSpace(Tlevel) Or String.IsNullOrWhiteSpace(Tphone) Or String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MsgBox("All fields must be filled!", MsgBoxStyle.Exclamation)
            Return
        End If

        If Not Date.TryParse(TextBox3.Text, workdate) Then
            MsgBox("Invalid work date format! Use YYYY-MM-DD.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            conn.Open()

            ' 更新該老師的資料
            Dim updateSql As String = "UPDATE 老師 SET Tname=@Tname, Tlevel=@Tlevel, Tphone=@Tphone, workdate=@workdate WHERE Tid=@Tid"
            cmd = New MySqlCommand(updateSql, conn)
            cmd.Parameters.AddWithValue("@Tid", 登入主畫面.CurrentUserTid)
            cmd.Parameters.AddWithValue("@Tname", Tname)
            cmd.Parameters.AddWithValue("@Tlevel", Tlevel)
            cmd.Parameters.AddWithValue("@Tphone", Tphone)
            cmd.Parameters.AddWithValue("@workdate", workdate)
            cmd.ExecuteNonQuery()

            MsgBox("Data successfully updated!", MsgBoxStyle.Information)

            ' 清空 TextBox
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        教師資料.Show()
        Me.Hide()
    End Sub
End Class
