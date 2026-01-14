Imports MySql.Data.MySqlClient

Public Class 統計數據
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub 統計數據_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;user=root;password='0000';database=forgo")
        LoadComboBoxData()
    End Sub

    Private Sub LoadComboBoxData()
        Try
            conn.Open()

            ' 把學生新增到 ComboBox1 的選項
            Dim studentSql = "SELECT `sid`, `sname` FROM `學生`"
            Dim studentCommand As New MySqlCommand(studentSql, conn)
            Dim studentReader As MySqlDataReader = studentCommand.ExecuteReader()
            While studentReader.Read()
                Dim student As New Student With {
                    .Id = Convert.ToInt32(studentReader("sid")),
                    .Name = studentReader("sname").ToString()
                }
                ComboBox1.Items.Add(student)
            End While
            studentReader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem IsNot Nothing Then
            Dim selectedStudent As Student = CType(ComboBox1.SelectedItem, Student)
            LoadStudentStats(selectedStudent.Id)
        End If
    End Sub

    Private Sub LoadStudentStats(studentId As Integer)
        Dim totalGames As Integer = 0
        Dim wonGames As Integer = 0
        Dim studentLevel As Integer = 0

        Try
            conn.Open()

            ' 获取学生等级
            Dim levelSql = "SELECT `slevel` FROM `學生` WHERE `sid` = @studentId"
            Dim levelCmd As New MySqlCommand(levelSql, conn)
            levelCmd.Parameters.AddWithValue("@studentId", studentId)
            Dim levelResult = levelCmd.ExecuteScalar()

            If Not IsDBNull(levelResult) Then
                Dim levelStr As String = levelResult.ToString()
                ' 去掉非數字字符
                Dim numericLevel As String = New String(levelStr.Where(Function(c) Char.IsDigit(c)).ToArray())
                studentLevel = Convert.ToInt32(numericLevel)
            End If

            ' 获取总比赛场数和赢的场数
            Dim statsSql = "SELECT COUNT(*) AS TotalGames, SUM(CASE WHEN `winner` = @studentId THEN 1 ELSE 0 END) AS WonGames " &
                       "FROM `對弈` WHERE `first` = @studentId OR `after` = @studentId"
            Dim statsCmd As New MySqlCommand(statsSql, conn)
            statsCmd.Parameters.AddWithValue("@studentId", studentId)
            Using reader As MySqlDataReader = statsCmd.ExecuteReader()
                If reader.Read() Then
                    If Not IsDBNull(reader("TotalGames")) Then
                        totalGames = Convert.ToInt32(reader("TotalGames"))
                    End If
                    If Not IsDBNull(reader("WonGames")) Then
                        wonGames = Convert.ToInt32(reader("WonGames"))
                    End If
                End If
            End Using

            ' 计算胜率
            Dim winRate As Double = If(totalGames > 0, (wonGames / totalGames) * 100, 0)

            ' 判断是否升级
            Dim gamesToNextLevel As Integer = 20 - (wonGames Mod 20)
            Dim canUpgrade As Boolean = wonGames >= 20

            ' 判断比赛资格
            Dim eligibleSql = "SELECT COUNT(*) AS EligibleGames FROM `對弈` " &
                          "WHERE (`first` = @studentId OR `after` = @studentId) " &
                          "AND ABS((SELECT `slevel` FROM `學生` WHERE `sid` = `first`) - @studentLevel) <= 3 " &
                          "AND `winner` = @studentId"
            Dim eligibleCmd As New MySqlCommand(eligibleSql, conn)
            eligibleCmd.Parameters.AddWithValue("@studentId", studentId)
            eligibleCmd.Parameters.AddWithValue("@studentLevel", studentLevel)
            Dim eligibleGamesResult = eligibleCmd.ExecuteScalar()
            Dim eligibleGames As Integer = If(IsDBNull(eligibleGamesResult), 0, Convert.ToInt32(eligibleGamesResult))
            Dim hasCompetitionEligibility As Boolean = eligibleGames >= 6

            ' 更新界面显示
            Label1.Text = totalGames.ToString()
            Label2.Text = wonGames.ToString()
            Label3.Text = winRate.ToString("F2") & "%"
            Label4.Text = "距離下次升級還需贏: " & gamesToNextLevel.ToString() & " 場"
            Label5.Text = "是否有比賽資格: " & If(hasCompetitionEligibility, "是", "否")
        Catch ex As Exception
            MsgBox("加載學生統計數據時出錯: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Class Student
        Public Property Id As Integer
        Public Property Name As String
        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        教師功能選擇.Show()
    End Sub
End Class
