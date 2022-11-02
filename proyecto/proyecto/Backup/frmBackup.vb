Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frmBackup
    'Private accion As Integer = 0
    'Private Sub frmBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Me.btnConectar.Enabled = False
    '    Me.cboBaseDatos.Enabled = False
    '    Me.txtUbicacion.Enabled = False
    '    Me.btnRutaResguardo.Enabled = False
    '    Me.txtRutaRestaurar.Enabled = False
    '    Me.btnRutaRestaurar.Enabled = False
    '    Me.txtNombreBaseDeDatos.Enabled = False

    'End Sub

    '
    'Boton Salir
    '
    Private Sub btnSalir_backup_Click(sender As Object, e As EventArgs) Handles btnSalir_backup.Click
        Me.Hide()
    End Sub

#Region "Base de Datos"
    '
    'Habilita las opciones de resguardo de la base de datos
    '

    Private Sub btnResguardar_Click(sender As Object, e As EventArgs) Handles btnResguardar.Click
        Try
            Process.Start("cmd", "/k" & "sqlcmd -S (LocalDB)\MSSQLLocalDB -E -Q ""BACKUP DATABASE [" & cboBaseDatos.Text & "] TO DISK='" & txtUbicacion.Text & "'""")

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        Me.txtUbicacion.Clear()
        Me.cboBaseDatos.SelectedIndex = -1
    End Sub


    '
    'Abre un Save File Dialog para indicar donde desea guardar el archivo
    '

    Private Sub btnRutaResguardo_Click(sender As Object, e As EventArgs) Handles btnRutaResguardo.Click
        BDDSaveFileDialog.Filter = "SQL Backup files|*.bak"
        BDDSaveFileDialog.FileName = cboBaseDatos.Text & "-" & Today.Date.ToString("dd-MM-yyyy") & "-" & TimeOfDay.ToString("h.mm") & ".bak"

        If BDDSaveFileDialog.ShowDialog = DialogResult.OK Then
            txtUbicacion.Text = BDDSaveFileDialog.FileName
        End If
    End Sub


    '
    'Cancela cualquier operación que no se desea llevar a cabo
    '

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnResguardar.Enabled = True
        btnRestaurar.Enabled = True
        txtUbicacion.Text = ""
        btnRutaResguardo.Enabled = False
        btnCancelar.Enabled = False
    End Sub


    '
    'Habilita las opciones de restauracion de la base de datos
    '

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Process.Start("cmd", "/k" & "Sqlcmd -S (LocalDB)\MSSQLLocalDB -E -Q ""RESTORE DATABASE [" & txtNombreBaseDeDatos.Text & "] FROM DISK = '" & txtRutaRestaurar.Text & "'""")
    End Sub

    '
    'txtRutaRestaurar, contiene la ruta de restauracion de backup
    '
    Private Sub btnRutaRestaurar_Click(sender As Object, e As EventArgs) Handles btnRutaRestaurar.Click
        BDDOpenFileDialog.Filter = "SQL Backup Files|*.bak"
        BDDOpenFileDialog.FileName = ""

        If BDDOpenFileDialog.ShowDialog = DialogResult.OK Then
            txtRutaRestaurar.Text = BDDOpenFileDialog.FileName
        End If
    End Sub

    '
    'Boton Conectar, Conecta al Servidor SQLServer y lista las bases de datos en un ComboBox
    '
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim conString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\juanpc\Documents\Visual Studio 2015\Projects\proyecto\proyecto\Base.mdf';Integrated Security=True"

        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = conString

        conexion.Open()

        Dim cmd As New SqlClient.SqlCommand("SELECT name from sys.databases", conexion)
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            For Each fila In ds.Tables(0).Rows
                cboBaseDatos.Items.Add(fila(0).ToString)
            Next

            cboBaseDatos.SelectedIndex = 0
        End If
    End Sub

    Private Sub frmBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


#End Region
End Class