
Imports MySql.Data.MySqlClient

Public Class 註冊
    Private ReadOnly connectionString As String = "Server=127.0.0.1;Database=forgo;User Id=root;Password=0000;"

    Private Sub 註冊_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxSname.BackColor = Color.FromArgb(189, 143, 83)
        TextBoxSaccount.BackColor = Color.FromArgb(189, 143, 83)
        TextBoxSpassword.BackColor = Color.FromArgb(189, 143, 83)
        ComboBox2.BackColor = Color.FromArgb(189, 143, 83)

        btn_return.FlatStyle = FlatStyle.Flat
        btn_return.FlatAppearance.BorderSize = 0
        btn_return.FlatAppearance.MouseOverBackColor = btn_return.BackColor
        btn_return.FlatAppearance.MouseDownBackColor = btn_return.BackColor
        RegisterButton.FlatStyle = FlatStyle.Flat
        RegisterButton.FlatAppearance.BorderSize = 0
        RegisterButton.FlatAppearance.MouseOverBackColor = btn_return.BackColor
        RegisterButton.FlatAppearance.MouseDownBackColor = btn_return.BackColor

        ComboBox2.Items.AddRange({"學生", "老師"})
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Try
            Dim identity = ComboBox2.SelectedItem.ToString()
            Dim account = TextBoxSaccount.Text
            Dim password = TextBoxSpassword.Text
            Dim name = TextBoxSname.Text

            If String.IsNullOrEmpty(account) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(name) Then
                MessageBox.Show("請填寫所有必填欄位。")
                Return
            End If

            Dim query As String = ""
            If identity = "學生" Then
                ' 預設 teacherID 為 1
                Dim teacherId As Integer = 1

                query = "INSERT INTO 學生 (saccount, spassword, sname, teacher) VALUES (@account, @password, @name, @teacherId)"
            ElseIf identity = "老師" Then
                query = "INSERT INTO 老師 (Taccount, Tpassword, Tname) VALUES (@account, @password, @name)"
            End If

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@account", account)
                    command.Parameters.AddWithValue("@password", password)
                    command.Parameters.AddWithValue("@name", name)
                    If identity = "學生" Then
                        command.Parameters.AddWithValue("@teacherId", 1) ' 使用預設的 teacherId
                    End If

                    command.ExecuteNonQuery()

                    MessageBox.Show("註冊成功！")
                    Close()
                    登入主畫面.Show()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("資料庫錯誤: " & ex.Message & vbCrLf & "詳細信息：" & ex.ToString)
        Catch ex As Exception
            MessageBox.Show("發生錯誤: " & ex.Message & vbCrLf & "詳細信息：" & ex.ToString)
        End Try
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Hide()
        登入主畫面.Show()
    End Sub

    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If
    End Sub
End Class