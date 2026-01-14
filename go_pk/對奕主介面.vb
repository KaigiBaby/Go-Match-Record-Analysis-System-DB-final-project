Imports System.Windows.Forms.Design
Imports MySql.Data.MySqlClient
Imports System.Data.Common
Public Class 對奕主介面

    Public Sub switchPanel(ByVal panel As Form)
        Try
            Panel1.Controls.Clear()
            panel.TopLevel = False
            panel.FormBorderStyle = FormBorderStyle.None
            panel.Dock = DockStyle.Fill
            Panel1.Controls.Add(panel)
            panel.Show()
        Catch ex As Exception
            MessageBox.Show("发生了错误：" & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            switchPanel(對弈新增)
        Catch ex As Exception
            MessageBox.Show("发生了错误：" & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            switchPanel(對弈查詢)
        Catch ex As Exception
            MessageBox.Show("发生了错误：" & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            switchPanel(對奕刪除)
        Catch ex As Exception
            MessageBox.Show("发生了错误：" & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            switchPanel(對弈修改)
        Catch ex As Exception
            MessageBox.Show("发生了错误：" & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub 對奕主介面_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        教師功能選擇.Show()
    End Sub
End Class