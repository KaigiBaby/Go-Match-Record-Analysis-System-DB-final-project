Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient
Public Class 學生對弈查詢
    Private constr As String = "server=localhost;user=root;password='0000';database=forgo"
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim sid As Integer = CInt(登入主畫面.CurrentUserSid)
    Private Sub 學生對弈查詢_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection(constr)
        Dim reportData As DataTable = GetReport()
        DataGridView1.DataSource = reportData
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.RowTemplate.Height = 10
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        AddHandler DataGridView1.RowPostPaint, AddressOf R
    End Sub
    Private Sub R(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        Using b As SolidBrush = New SolidBrush(Color.Black)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), sender.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 1)
        End Using
    End Sub
    Private Function GetReport() As DataTable
        Dim dt As New DataTable()
        Try
            Using connection As New MySqlConnection(constr)
                Dim sql As String = "SELECT d.Rid AS 編號, s1.sname AS 先手, s2.sname AS 後手, s3.sname AS 勝者, d.pkdate AS 日期, t.Tname AS 裁判,d.board AS 路數 FROM 對弈 d " &
                "INNER JOIN 學生 s1 ON d.first = s1.sid " &
                "INNER JOIN 學生 s2 ON d.after = s2.sid " &
                "INNER JOIN 學生 s3 ON d.winner = s3.sid " &
                "INNER JOIN 老師 t ON d.judge = t.Tid " &
                "WHERE d.first = @sid OR d.after = @sid"
                Using cmd As New MySqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@sid", sid)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error retrieving report data: " & ex.Message)
        End Try
        Return dt
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim reportData As DataTable = GetChoose()
        DataGridView1.DataSource = reportData
        DataGridView1.ClearSelection()
    End Sub

    ' 按下 Button4 时，恢复显示所有记录
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' 重新加载所有数据
        DataGridView1.DataSource = GetReport()
        DataGridView1.ClearSelection()
    End Sub

    Private Function GetChoose() As DataTable
        Dim dt As New DataTable()
        Try
            Using connection As New MySqlConnection(constr)
                Dim query As String = "SELECT d.Rid AS 編號, s1.sname AS 先手, s2.sname AS 後手, s3.sname AS 勝者, d.pkdate AS 日期, t.Tname AS 裁判,d.board AS 路數 FROM 對弈 d " &
                    "INNER JOIN 學生 s1 ON d.first = s1.sid " &
                    "INNER JOIN 學生 s2 ON d.after = s2.sid " &
                    "INNER JOIN 學生 s3 ON d.winner = s3.sid " &
                    "INNER JOIN 老師 t ON d.judge = t.Tid " &
                    "WHERE (d.first = @sid OR d.after = @sid) AND d.pkdate = @date"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@sid", sid)
                    Dim formattedDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
                    command.Parameters.AddWithValue("@date", formattedDate)
                    Dim adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error filtering data: " & ex.Message)
        End Try
        Return dt
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        學生功能選擇.Show()
    End Sub
End Class