Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class 修改老師資料
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim currentTid As Integer

    Private Sub 修改老師資料_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user=root;password='0000';database=forgo"
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

        Try
            conn.Open()

            currentTid = CInt(登入主畫面.CurrentUserTid)

            ' 抓取目前使用者的資料
            Dim sql As String = "SELECT Tname, Tphone, Tlevel, workdate FROM 老師 WHERE Tid=@Tid"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@Tid", currentTid)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                TextBox1.Text = reader("Tname").ToString()
                TextBox2.Text = reader("Tphone").ToString()
                TextBox3.Text = reader("workdate").ToString()
                TextBox4.Text = reader("Tlevel").ToString()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        教師資料.Show()
        Me.Hide()
    End Sub

    Private Sub btnSaveTeacher_Click(sender As Object, e As EventArgs) Handles btnSaveTeacher.Click

        Dim Tname As String = TextBox1.Text
        Dim Tphone As String = TextBox2.Text
        Dim workdate As Date
        Dim Tlevel As String = TextBox4.Text

        If String.IsNullOrWhiteSpace(Tname) Or String.IsNullOrWhiteSpace(Tlevel) Or String.IsNullOrWhiteSpace(Tphone) Or String.IsNullOrWhiteSpace(TextBox4.Text) Then
            MsgBox("All fields must be filled!", MsgBoxStyle.Exclamation)
            Return
        End If

        If Not Date.TryParse(TextBox3.Text, workdate) Then
            MsgBox("Invalid work date format! Use YYYY-MM-DD.", MsgBoxStyle.Exclamation)
            Return
        End If

        Using conn As New MySqlConnection("server=localhost;user=root;password='0000';database=forgo")
            Try
                conn.Open()
                Dim sql As String = "UPDATE 老師 SET Tname = @Tname, Tlevel = @Tlevel, Tphone = @Tphone, workdate = @workdate WHERE Tid = @Tid"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Tid", currentTid)
                    cmd.Parameters.AddWithValue("@Tname", Tname)
                    cmd.Parameters.AddWithValue("@Tlevel", Tlevel)
                    cmd.Parameters.AddWithValue("@Tphone", Tphone)
                    cmd.Parameters.AddWithValue("@workdate", workdate)

                    ' Execute the update query
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if any rows were updated
                    If rowsAffected > 0 Then
                        MsgBox("Teacher data updated successfully!", MsgBoxStyle.Information)
                    Else
                        MsgBox("No matching teacher found with the provided ID.", MsgBoxStyle.Exclamation)
                    End If
                End Using

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class
