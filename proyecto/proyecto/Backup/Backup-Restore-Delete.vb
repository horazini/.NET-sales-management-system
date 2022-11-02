Imports System.Data.SqlClient
Public Class Backup_Restore_Delete
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True")

    Private Sub databases()
        conn.Open()
        ComboBox1.Items.Clear()
        Dim cmd1 As New SqlCommand("Select * from sysdatabases order by name", conn)
        Dim myreader As SqlDataReader = cmd1.ExecuteReader
        While myreader.Read
            ComboBox1.Items.Add(myreader(0))
            ComboBox1.Text = "C:\USERS\JUANPC\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\PROYECTO\PROYECTO\BASE.MDF"
        End While
        conn.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        databases()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Selección de base de datos" Then
            MessageBox.Show("Seleccione una base de datos")
            Return
        Else
            SaveFileDialog1.FileName = ComboBox1.SelectedItem
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim lfolder As String
                lfolder = SaveFileDialog1.FileName
                'MsgBox("BACKUP Database " & ComboBox1.Text & " To disk='" & lfolder & " WITH FORMAT'")
                Dim cmd2 As New SqlCommand("BACKUP Database [" & ComboBox1.Text & "] To disk=N'" & lfolder & "'", conn)
                conn.Open()
                cmd2.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Back up realizado correctamente.")
            Else
                MessageBox.Show("Por favor guarde la database")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If ComboBox1.Text = "Selección de base de datos" Then
            MessageBox.Show("Seleccione una base de datos")
            Return
        Else
            Dim cmd3 As New SqlCommand("Drop database " & ComboBox1.Text & "", conn)
            conn.Open()
            cmd3.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("database deleted successfully")
            databases()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dbname As String
        dbname = InputBox("Input database name you want to restore", "Database Name")
        Dim cmd4 As New SqlCommand("Select * from sysdatabases where name = '" & dbname & "'", conn)
        conn.Open()
        Dim myreader2 As SqlDataReader = cmd4.ExecuteReader
        If myreader2.Read Then
            MessageBox.Show("Database exists in sql server")
            conn.Close()
        Else
            conn.Close()
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                Dim cmd3 As New SqlCommand("Restore database " & dbname & " from disk='" & OpenFileDialog1.FileName & "'", conn)
                conn.Open()
                cmd3.ExecuteReader()
                conn.Close()
                databases()
                MessageBox.Show("database restaurada exitosamente")
            Else
                MessageBox.Show("Please Select database you want to restore")
            End If
        End If
    End Sub
End Class