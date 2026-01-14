Imports MySql.Data.MySqlClient

Public Class 對弈新增
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub 對弈新增_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;user=root;password='0000';database=forgo")
        LoadComboBoxData()
    End Sub

    Private Sub LoadComboBoxData()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' 把學生新增到 ComboBox1 ComboBox2 的選項
            Dim studentSql = "SELECT `sname` FROM `學生`"
            Dim studentCommand As New MySqlCommand(studentSql, conn)
            Dim studentReader As MySqlDataReader = studentCommand.ExecuteReader()
            While studentReader.Read()
                ComboBox1.Items.Add(studentReader("sname").ToString())
                ComboBox2.Items.Add(studentReader("sname").ToString())
            End While
            studentReader.Close()

            ' Load teachers into ComboBox5
            Dim teacherSql = "SELECT `Tname` FROM `老師`"
            Dim teacherCommand As New MySqlCommand(teacherSql, conn)
            Dim teacherReader As MySqlDataReader = teacherCommand.ExecuteReader()
            While teacherReader.Read()
                ComboBox5.Items.Add(teacherReader("Tname").ToString())
            End While
            teacherReader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstName As String = ComboBox1.Text
        Dim afterName As String = ComboBox2.Text
        Dim winnerName As String = ComboBox3.Text
        Dim judgeName As String = ComboBox5.Text

        ' 根據姓名查詢對應的編號
        Dim firstId As Integer = GetStudentIdByName(firstName)
        Dim afterId As Integer = GetStudentIdByName(afterName)
        Dim winnerId As Integer = GetStudentIdByName(winnerName)
        Dim judgeId As Integer = GetTeacherIdByName(judgeName)

        Dim board As String = ComboBox4.Text
        Dim pkdate As Date = DateTimePicker1.Value

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim sql = "INSERT INTO `對弈` (`board`, `first`, `after`, `pkdate`, `winner`, `judge`) VALUES (@board, @first, @after, @pkdate, @winner, @judge)"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@board", board)
            cmd.Parameters.AddWithValue("@first", firstId)
            cmd.Parameters.AddWithValue("@after", afterId)
            cmd.Parameters.AddWithValue("@pkdate", pkdate)
            cmd.Parameters.AddWithValue("@winner", winnerId)
            cmd.Parameters.AddWithValue("@judge", judgeId)
            cmd.ExecuteNonQuery()

            ' 更新贏家的棋力等級
            UpdateStudentLevel(winnerId)

            MsgBox("Data successfully added!", MsgBoxStyle.Information)
            ResetForm()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        UpdateComboBox3()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        UpdateComboBox3()
    End Sub

    Private Sub UpdateComboBox3()
        ComboBox3.Items.Clear()
        Dim selectedStudent1 As String = ComboBox1.Text
        Dim selectedStudent2 As String = ComboBox2.Text

        ComboBox3.Items.Add(selectedStudent1)
        ComboBox3.Items.Add(selectedStudent2)
    End Sub

    Private Function GetStudentIdByName(studentName As String) As Integer
        Dim studentId As Integer = -1
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim sql = "SELECT sid FROM 學生 WHERE sname = @sname"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@sname", studentName)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                studentId = reader.GetInt32("sid")
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return studentId
    End Function

    Private Function GetTeacherIdByName(teacherName As String) As Integer
        Dim teacherId As Integer = -1
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim sql = "SELECT Tid FROM 老師 WHERE Tname = @Tname"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@Tname", teacherName)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                teacherId = reader.GetInt32("Tid")
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return teacherId
    End Function

    Private Sub UpdateStudentLevel(studentId As Integer)
        Dim wonGames As Integer = 0
        Dim oldLevel As Integer = 0
        Dim newLevel As Integer = 0
        Dim studentName As String = ""

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' 获取学生的旧等级
            Dim oldLevelSql = "SELECT `slevel`, `sname` FROM `學生` WHERE `sid` = @studentId"
            Dim oldLevelCmd As New MySqlCommand(oldLevelSql, conn)
            oldLevelCmd.Parameters.AddWithValue("@studentId", studentId)
            Dim reader As MySqlDataReader = oldLevelCmd.ExecuteReader()
            If reader.Read() Then
                oldLevel = Convert.ToInt32(reader("slevel"))
                studentName = reader("sname").ToString()
            End If
            reader.Close()

            ' 获取赢的场数
            Dim winSql = "SELECT COUNT(*) FROM `對弈` WHERE `winner` = @studentId"
            Dim winCmd As New MySqlCommand(winSql, conn)
            winCmd.Parameters.AddWithValue("@studentId", studentId)
            wonGames = Convert.ToInt32(winCmd.ExecuteScalar())

            If wonGames > 0 AndAlso wonGames Mod 20 = 0 Then
                newLevel = oldLevel - 1
            Else
                newLevel = oldLevel
            End If

            ' 更新學生的棋力等級
            If newLevel <> oldLevel Then
                Dim updateSql = "UPDATE `學生` SET `slevel` = @newLevel WHERE `sid` = @studentId"
                Dim updateCmd As New MySqlCommand(updateSql, conn)
                updateCmd.Parameters.AddWithValue("@newLevel", newLevel)
                updateCmd.Parameters.AddWithValue("@studentId", studentId)
                updateCmd.ExecuteNonQuery()
                MsgBox(studentName & " 升到 " & newLevel & "!", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("更新學生棋力等級時出錯: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub ResetForm()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
    End Sub
End Class

