Imports MySql.Data.MySqlClient
Public Class 老師_學生查詢
    Private Sub 老師_學生查詢_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Button1.BackColor
        Button1.FlatAppearance.MouseDownBackColor = Button1.BackColor

        Dim connectionString As String = "server=localhost;user id=root;password=0000;database=forgo"
        Using conn As New MySqlConnection(connectionString)
            Dim cmd As New MySqlCommand("SELECT sname FROM 學生", conn)
            Try
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBox1.Items.Add(reader("sname").ToString())
                End While
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedSname As String = ComboBox1.SelectedItem.ToString()
        Dim connectionString As String = "server=localhost;user id=root;password=0000;database=forgo"
        Using conn As New MySqlConnection(connectionString)
            Dim cmd As New MySqlCommand("SELECT sid, sname, slevel, sphone, school, grade FROM 學生 WHERE sname = @sname", conn)
            cmd.Parameters.AddWithValue("@sname", selectedSname)
            Try
                conn.Open()
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        教師_學生查詢刪除.Show()
    End Sub
End Class