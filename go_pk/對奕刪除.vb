Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class 對奕刪除
    Private constr As String = "server=localhost;user=root;password='0000';database=forgo"
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub 對奕刪除_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection(constr)
        Dim reportData As DataTable = GetReport()
        DataGridView1.DataSource = reportData
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.RowTemplate.Height = 10
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        AddHandler DataGridView1.RowPostPaint, AddressOf R
        AddHandler DataGridView1.SelectionChanged, AddressOf DataGridView1_SelectionChanged
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
            Label1.Text = selectedRow.Cells("編號").Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label1.Text <> "" Then
            Dim rid As Integer = Integer.Parse(Label1.Text)
            DeleteRecord(rid)
            Dim reportData As DataTable = GetReport()
            DataGridView1.DataSource = reportData
        Else
            MsgBox("請先選擇要刪除的紀錄。")
        End If
    End Sub

    Private Sub DeleteRecord(rid As Integer)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' 先获取相关学生的ID
            Dim getStudentIdsSql As String = "SELECT winner FROM 對弈 WHERE Rid = @rid"
            Dim winnerId As Integer

            Using cmd As New MySqlCommand(getStudentIdsSql, conn)
                cmd.Parameters.AddWithValue("@rid", rid)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        winnerId = reader.GetInt32("winner")
                    End If
                End Using
            End Using

            ' 删除对弈记录
            Dim deleteSql As String = "DELETE FROM 對弈 WHERE Rid = @rid"
            Using cmd As New MySqlCommand(deleteSql, conn)
                cmd.Parameters.AddWithValue("@rid", rid)
                cmd.ExecuteNonQuery()
            End Using

            ' 更新相关学生的棋力等级
            UpdateStudentLevel(winnerId)

            MsgBox("紀錄已刪除。")
        Catch ex As Exception
            MsgBox("刪除紀錄時有錯誤: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

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

            If wonGames > 0 AndAlso (wonGames + 1) Mod 20 = 0 Then
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
                MsgBox(studentName & " 降到 " & newLevel & "!", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("更新學生棋力等級時出錯: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
End Class
