Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class 對弈修改
    Private constr As String = "server=localhost;user=root;password='0000';database=forgo"
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Private selectedRecordId As Integer

    Private Sub 對弈修改_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection(constr)
        Dim reportData As DataTable = GetReport()
        LoadComboBoxData()
        DataGridView1.DataSource = reportData
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.RowTemplate.Height = 10
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        AddHandler DataGridView1.RowPostPaint, AddressOf R
        AddHandler DataGridView1.SelectionChanged, AddressOf DataGridView1_SelectionChanged
    End Sub

    Private Sub LoadComboBoxData()
        Try
            conn.Open()

            ' 把學生新增到 ComboBox1 和 ComboBox2 的選項
            Dim studentSql = "SELECT `sname` FROM `學生`"
            Dim studentCommand As New MySqlCommand(studentSql, conn)
            Dim studentReader As MySqlDataReader = studentCommand.ExecuteReader()
            While studentReader.Read()
                ComboBox1.Items.Add(studentReader("sname").ToString())
                ComboBox2.Items.Add(studentReader("sname").ToString())
            End While
            studentReader.Close()

            ' 加載老師到 ComboBox5
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
            conn.Close()
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

    Private Function GetReport() As DataTable
        Dim dt As New DataTable()
        Try
            Using connection As New MySqlConnection(constr)
                Dim sql As String = "SELECT d.Rid AS 編號, s1.sname AS 先手, s2.sname AS 後手, s3.sname AS 勝者, d.pkdate AS 日期, t.Tname AS 裁判, d.board AS 路數 FROM 對弈 d " &
                    "INNER JOIN 學生 s1 ON d.first = s1.sid " &
                    "INNER JOIN 學生 s2 ON d.after = s2.sid " &
                    "INNER JOIN 學生 s3 ON d.winner = s3.sid " &
                    "INNER JOIN 老師 t ON d.judge = t.Tid"
                Using cmd As New MySqlCommand(sql, connection)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error retrieving report data: " & ex.Message)
        End Try
        Return dt
    End Function

    Private Sub R(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        Using b As SolidBrush = New SolidBrush(Color.Black)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), sender.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 1)
        End Using
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs)
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            selectedRecordId = Integer.Parse(selectedRow.Cells("編號").Value.ToString()) ' 獲取選擇行的編號
            ComboBox1.Text = selectedRow.Cells("先手").Value.ToString()
            ComboBox2.Text = selectedRow.Cells("後手").Value.ToString()
            ComboBox3.Text = selectedRow.Cells("勝者").Value.ToString()
            ComboBox4.Text = selectedRow.Cells("路數").Value.ToString()
            ComboBox5.Text = selectedRow.Cells("裁判").Value.ToString()
            DateTimePicker1.Value = DateTime.Parse(selectedRow.Cells("日期").Value.ToString())
        End If
    End Sub

    Private Sub ResetForm()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(ComboBox1.Text) OrElse String.IsNullOrEmpty(ComboBox2.Text) OrElse String.IsNullOrEmpty(ComboBox3.Text) OrElse String.IsNullOrEmpty(ComboBox5.Text) OrElse String.IsNullOrEmpty(ComboBox4.Text) Then
            MsgBox("所有字段都必须填写。")
            Return
        End If

        Dim oldWinnerId As Integer = GetWinnerId(selectedRecordId)
        Dim newWinnerId As Integer

        Try
            conn.Open()

            ' 更新對弈記錄
            Dim updateSql As String = "UPDATE 對弈 SET first = (SELECT sid FROM 學生 WHERE sname = @first), " &
                                  "after = (SELECT sid FROM 學生 WHERE sname = @after), " &
                                  "winner = (SELECT sid FROM 學生 WHERE sname = @winner), " &
                                  "judge = (SELECT Tid FROM 老師 WHERE Tname = @judge), " &
                                  "pkdate = @date, board = @board WHERE Rid = @rid"
            Using cmd As New MySqlCommand(updateSql, conn)
                cmd.Parameters.AddWithValue("@first", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@after", ComboBox2.Text)
                cmd.Parameters.AddWithValue("@winner", ComboBox3.Text)
                cmd.Parameters.AddWithValue("@judge", ComboBox5.Text)
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Value.Date)
                cmd.Parameters.AddWithValue("@board", ComboBox4.Text)
                cmd.Parameters.AddWithValue("@rid", selectedRecordId)
                cmd.ExecuteNonQuery()
            End Using

            newWinnerId = GetWinnerId(selectedRecordId)

            ' 更新胜者的棋力等级
            If oldWinnerId <> newWinnerId Then
                UpdateStudentLevel(oldWinnerId)
                UpdateStudentLevel(newWinnerId)
            Else
                UpdateStudentLevel(oldWinnerId)
            End If

            MsgBox("紀錄更新成功。")
            ResetForm()
            ' 更新完資料後重新加載資料到 DataGridView
            DataGridView1.DataSource = GetReport()
            DataGridView1.ClearSelection()
        Catch ex As Exception
            MsgBox("紀錄更新失敗: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Function GetWinnerId(rid As Integer) As Integer
        Dim winnerId As Integer
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim getWinnerSql As String = "SELECT winner FROM 對弈 WHERE Rid = @rid"
            Using cmd As New MySqlCommand(getWinnerSql, conn)
                cmd.Parameters.AddWithValue("@rid", rid)
                winnerId = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        Catch ex As Exception
            MsgBox("获取胜者 ID 时出错: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
        Return winnerId
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

            ' 判斷是否需要升降級
            If wonGames > 0 AndAlso wonGames Mod 20 = 0 Then
                newLevel = oldLevel - 1
            ElseIf wonGames > 0 AndAlso (wonGames + 1) Mod 20 = 0 Then
                newLevel = oldLevel + 1
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
                MsgBox(studentName & " 的棋力等級已更新到 " & newLevel & "!", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("更新學生棋力等級時出錯: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
End Class