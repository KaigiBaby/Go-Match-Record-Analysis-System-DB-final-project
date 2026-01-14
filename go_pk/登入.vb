Imports MySql.Data.MySqlClient

Public Class 登入
    Public Account As String

    Private Sub 登入_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = loginEnter
        Me.KeyPreview = True

        UpdateLabel()

        loginAct.BackColor = Color.FromArgb(189, 143, 83)
        loginPwd.BackColor = Color.FromArgb(189, 143, 83)
        Label.BackColor = Color.FromArgb(244, 241, 232)

        btn_return.FlatStyle = FlatStyle.Flat
        btn_return.FlatAppearance.BorderSize = 0
        btn_return.FlatAppearance.MouseOverBackColor = btn_return.BackColor
        btn_return.FlatAppearance.MouseDownBackColor = btn_return.BackColor

        loginEnter.FlatStyle = FlatStyle.Flat
        loginEnter.FlatAppearance.BorderSize = 0
        loginEnter.FlatAppearance.MouseOverBackColor = loginEnter.BackColor
        loginEnter.FlatAppearance.MouseDownBackColor = loginEnter.BackColor
    End Sub

    Public Sub UpdateLabel()
        If Label.Tag = 1 Then
            Label.Text = 登入主畫面.User1.Text
        ElseIf Label.Tag = 2 Then
            Label.Text = 登入主畫面.User2.Text
        ElseIf Label.Tag = 3 Then
            Label.Text = 登入主畫面.User3.Text
        End If
    End Sub

    Private Sub loginEnter_Click(sender As Object, e As EventArgs) Handles loginEnter.Click
        Account = loginAct.Text
        Dim Pwd As String = loginPwd.Text

        Dim connectionString As String = 登入主畫面.ConnectionString
        Dim queryString As String = 登入主畫面.QueryString

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New MySqlCommand(queryString, connection)
                    If 登入主畫面.QueryString.Contains("spassword=@spassword") Then
                        command.Parameters.AddWithValue("@saccount", Account)
                        command.Parameters.AddWithValue("@spassword", Pwd)
                    Else
                        command.Parameters.AddWithValue("@Taccount", Account)
                        command.Parameters.AddWithValue("@Tpassword", Pwd)
                    End If

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            MessageBox.Show("登入成功！")

                            If Label.Tag = 1 Then
                                登入主畫面.CurrentUserAccount = Account
                                登入主畫面.CurrentUserSid = reader("sid").ToString()

                                Me.Hide()
                                學生功能選擇.Show()

                                'Dim studentForm As New StudentForm(登入主畫面.CurrentUserSid)
                                'studentForm.Show()
                            ElseIf Label.Tag = 2 Then
                                登入主畫面.CurrentUserAccount = Account
                                登入主畫面.CurrentUserTid = reader("Tid").ToString()

                                Me.Hide()
                                教師功能選擇.Show()

                                ' Assuming there's a TeacherForm, adjust accordingly
                                'Dim teacherForm As New TeacherForm(Form1.CurrentUserTid)
                                'teacherForm.Show()
                            End If

                            Me.Close()
                        Else
                            MessageBox.Show("帳號或密碼錯誤，請重新輸入！")
                        End If
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("資料庫錯誤: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("發生錯誤: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs)
        Hide()
        登入主畫面.Show()
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If
    End Sub

    Private Sub btn_return_Click_1(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Hide()
        登入主畫面.Show()
    End Sub
End Class