Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class 對弈查詢
    Private constr As String = "server=localhost;user=root;password='0000';database=forgo"
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub 對弈查詢_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection(constr)
        LoadComboBoxData()
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

    Private Sub LoadComboBoxData()
        Try
            conn.Open()
            Dim studentSql = "SELECT `sname` FROM `學生`"
            Dim studentCommand As New MySqlCommand(studentSql, conn)
            Dim studentReader As MySqlDataReader = studentCommand.ExecuteReader()
            While studentReader.Read()
                ComboBox1.Items.Add(studentReader("sname").ToString())
            End While
            studentReader.Close()
        Catch ex As Exception
            MsgBox("Error loading ComboBox data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function GetReport() As DataTable
        Dim dt As New DataTable()
        Try
            Using connection As New MySqlConnection(constr)
                Dim sql As String = "SELECT d.Rid AS 編號, s1.sname AS 先手, s2.sname AS 後手, s3.sname AS 勝者, d.pkdate AS 日期, t.Tname AS 裁判,d.board AS 路數 FROM 對弈 d " &
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' 重置 ComboBox 和 DateTimePicker
        ComboBox1.SelectedIndex = -1
        DateTimePicker1.Value = DateTime.Now

        ' 重新加载所有数据
        DataGridView1.DataSource = GetReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reportData As DataTable = GetChoose()
        DataGridView1.DataSource = reportData
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.RowTemplate.Height = 10
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        AddHandler DataGridView1.RowPostPaint, AddressOf R
    End Sub

    Private Function GetChoose() As DataTable
        Dim dt As New DataTable()
        Dim stuName As String = ComboBox1.Text
        Dim firstId As Integer = GetStudentIdByName(stuName)

        Dim filter As String = ""

        If ComboBox1.SelectedItem IsNot Nothing AndAlso ComboBox1.Text <> "" Then
            filter = " WHERE (first = @firstId OR after = @firstId)"
        End If

        If CheckBox1.Checked Then
            If filter <> "" Then
                filter &= " AND "
            Else
                filter = " WHERE "
            End If

            filter &= "pkdate = @date"
        End If
        Try
            Using connection As New MySqlConnection(constr)
                Dim query As String = "SELECT d.Rid AS 編號, s1.sname AS 先手, s2.sname AS 後手, s3.sname AS 勝者, d.pkdate AS 日期, t.Tname AS 裁判,d.board AS 路數 FROM 對弈 d " &
                    "INNER JOIN 學生 s1 ON d.first = s1.sid " &
                    "INNER JOIN 學生 s2 ON d.after = s2.sid " &
                    "INNER JOIN 學生 s3 ON d.winner = s3.sid " &
                    "INNER JOIN 老師 t ON d.judge = t.Tid" & filter
                Using command As New MySqlCommand(query, connection)
                    If ComboBox1.SelectedItem IsNot Nothing AndAlso ComboBox1.Text <> "" Then
                        command.Parameters.AddWithValue("@firstId", firstId)
                    End If
                    If CheckBox1.Checked Then
                        Dim formattedDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
                        command.Parameters.AddWithValue("@date", formattedDate)
                    End If
                    Dim adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dt)
                    DataGridView1.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error filtering data: " & ex.Message)
        End Try
        Return dt
    End Function

    Private Function GetStudentIdByName(studentName As String) As Integer
        Dim studentId As Integer = -1
        Try
            conn.Open()
            Dim sql = "SELECT sid FROM 學生 WHERE sname = @sname"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@sname", studentName)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                studentId = reader.GetInt32("sid")
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("Error retrieving student ID: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return studentId
    End Function
End Class
