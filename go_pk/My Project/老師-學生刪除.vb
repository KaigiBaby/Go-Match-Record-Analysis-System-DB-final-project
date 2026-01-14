Imports MySql.Data.MySqlClient
Public Class 老師_學生刪除
    Private Sub 老師_學生刪除_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Button1.BackColor
        Button1.FlatAppearance.MouseDownBackColor = Button1.BackColor

        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Button2.BackColor
        Button2.FlatAppearance.MouseDownBackColor = Button2.BackColor

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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("請選擇一個學生姓名。")
            Return
        End If

        Dim selectedSname As String = ComboBox1.SelectedItem.ToString()
        Dim connectionString As String = "server=localhost;user id=root;password=0000;database=forgo"

        Using conn As New MySqlConnection(connectionString)
            ' 開始交易
            Dim transaction As MySqlTransaction
            conn.Open()
            transaction = conn.BeginTransaction()

            Try
                ' 取得選定的學生ID
                Dim getIdCmd As New MySqlCommand("SELECT sid FROM 學生 WHERE sname = @sname", conn, transaction)
                getIdCmd.Parameters.AddWithValue("@sname", selectedSname)
                Dim sid As Object = getIdCmd.ExecuteScalar()

                If sid IsNot Nothing Then
                    ' 刪除對應的對弈記錄
                    Dim deleteRelatedCmdFirst As New MySqlCommand("DELETE FROM 對弈 WHERE first = @sid", conn, transaction)
                    deleteRelatedCmdFirst.Parameters.AddWithValue("@sid", sid)
                    deleteRelatedCmdFirst.ExecuteNonQuery()

                    Dim deleteRelatedCmdAfter As New MySqlCommand("DELETE FROM 對弈 WHERE after = @sid", conn, transaction)
                    deleteRelatedCmdAfter.Parameters.AddWithValue("@sid", sid)
                    deleteRelatedCmdAfter.ExecuteNonQuery()

                    ' 刪除學生記錄
                    Dim deleteCmd As New MySqlCommand("DELETE FROM 學生 WHERE sname = @sname", conn, transaction)
                    deleteCmd.Parameters.AddWithValue("@sname", selectedSname)
                    Dim result As Integer = deleteCmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("成功刪除資料。")
                        ComboBox1.Items.Remove(selectedSname)  ' 刪除後更新ComboBox
                    Else
                        MessageBox.Show("找不到該學生資料。")
                    End If

                    ' 提交交易
                    transaction.Commit()
                Else
                    MessageBox.Show("找不到該學生資料。")
                End If
            Catch ex As MySqlException
                ' 回滾交易
                transaction.Rollback()
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        教師_學生查詢刪除.Show()
    End Sub
End Class