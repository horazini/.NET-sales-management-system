Imports System.Data.Sql
Imports System.Data.SqlClient



Module Conexion

    Public conexion As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public comando2 As SqlCommand
    Private cmb As SqlCommandBuilder
    Public idusuario As Integer
    Public nombreU As String
    Public perf As Integer
    Public nroventaAux As Integer

    ' Para resetear indices ej: DBCC CHECKIDENT("Ventas_cabecera", reseed,0)

    '__________Login______________________________________________________________
    Sub abrir()
        Try
            conexion = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\juanpc\Documents\Visual Studio 2015\Projects\proyecto\proyecto\Base.mdf';Integrated Security=True")
            conexion.Open()
            FInicio.Label1.Text = "Conectado"
        Catch ex As Exception
            'MsgBox("No se pudo conectar" + ex.ToString)
            MsgBox("No se pudo conectar con la base de datos.")
            FInicio.Label1.Text = "No Conectado."

        End Try
    End Sub

    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from Usuarios where Usuario='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function contrasena(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select contraseña from Usuarios where Usuario='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("contraseña")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function ConsultarTipoUsuario(ByVal nombreUsuario As String) As Integer
        Dim resultado As Integer
        Try
            enunciado = New SqlCommand("Select * from Usuarios where Usuario='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = CInt(respuesta.Item("id_perfil"))
                perf = resultado
                idusuario = CInt(respuesta.Item("id_usuario"))
                nombreU = respuesta.Item("apellido") + " " + respuesta.Item("nombre")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    '_______Consulta ultima venta______________
    Function ConsultarUltimaVenta() As Integer
        Dim resultado As Integer
        Try
            enunciado = New SqlCommand("Select * from Ventas_cabecera where eliminado='no' order by id_venta desc", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                nroventaAux = CInt(respuesta.Item("id_venta"))
                If (nroventaAux = 0) Then
                    nroventaAux = 1
                Else
                    nroventaAux = nroventaAux + 1
                End If
            End If
                respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    '__________Fin Login _____________________________________________________
    '__________Productos______________________________________________________
    Public Sub consulta_productos(ByVal sql As String, ByVal Productos As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, Productos)

    End Sub

    Function insertar_productos(ByVal sql)
        ' conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If

    End Function

    Function eliminar_productos(ByVal tabla, ByVal condicion)
        Dim elimina As String = "update " & tabla & " set eliminado='si' where " & condicion
        comando = New SqlCommand(elimina, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function modificar_productos(ByVal tabla, ByVal campos, ByVal condicion)
        Dim actualiza As String = "update " & tabla & " set " & campos & " where " & condicion
        comando = New SqlCommand(actualiza, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    '__________Fin Productos _____________________________________________________
    '__________Usuarios _____________________________________________________
    Public Sub consulta_usuarios(ByVal sql As String, ByVal Usuarios As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, Usuarios)

    End Sub

    Function insertar_usuarios(ByVal sql)
        ' conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If

    End Function

    Function eliminar_usuarios(ByVal tabla, ByVal condicion)
        Dim elimina As String = "update " & tabla & " set eliminado='si' where " & condicion
        comando = New SqlCommand(elimina, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function modificar_usuarios(ByVal tabla, ByVal campos, ByVal condicion)
        Dim actualiza As String = "update " & tabla & " set " & campos & " where " & condicion
        comando = New SqlCommand(actualiza, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    '__________Fin Usuarios _____________________________________________________


    '__________Clientes _____________________________________________________
    Public Sub consulta_clientes(ByVal sql As String, ByVal Clientes As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, Clientes)

    End Sub

    Function insertar_clientes(ByVal sql)
        ' conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If

    End Function

    Function eliminar_clientes(ByVal tabla, ByVal condicion)
        Dim elimina As String = "update " & tabla & " set eliminado='si' where " & condicion
        comando = New SqlCommand(elimina, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function modificar_clientes(ByVal tabla, ByVal campos, ByVal condicion)
        Dim actualiza As String = "update " & tabla & " set " & campos & " where " & condicion
        comando = New SqlCommand(actualiza, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    '__________Fin Clientes _____________________________________________________

    ' _________________ Categorias_________________________
    Public Sub consulta_categorias(ByVal sql As String, ByVal Productos As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, Productos)

    End Sub

    Function insertar_categorias(ByVal sql)
        ' conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If

    End Function

    Function eliminar_categorias(ByVal tabla, ByVal condicion)
        Dim elimina As String = "update " & tabla & " set eliminado='si' where " & condicion
        comando = New SqlCommand(elimina, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function modificar_categorias(ByVal tabla, ByVal campos, ByVal condicion)
        Dim actualiza As String = "update " & tabla & " set " & campos & " where " & condicion
        comando = New SqlCommand(actualiza, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    ' _________________Fin Categorias_________________________
    ' _________________ Perfiles_________________________
    Public Sub consulta_perfiles(ByVal sql As String, ByVal Productos As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, Productos)

    End Sub

    Function insertar_perfiles(ByVal sql)
        ' conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If

    End Function

    Function eliminar_perfiles(ByVal tabla, ByVal condicion)
        Dim elimina As String = "update " & tabla & " set eliminado='si' where " & condicion
        comando = New SqlCommand(elimina, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function modificar_perfiles(ByVal tabla, ByVal campos, ByVal condicion)
        Dim actualiza As String = "update " & tabla & " set " & campos & " where " & condicion
        comando = New SqlCommand(actualiza, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    ' _________________Fin Perfiles_________________________
    '__________Ventas Cabecera_____________________________________________________

    Public Sub consulta_ventas_cabecera(ByVal sql As String, ByVal Ventas_cabecera As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, Ventas_cabecera)
    End Sub

    Function insertar_ventas_cabecera(ByVal sql)
        ' conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If

    End Function

    Function eliminar_ventas_cabecera(ByVal tabla, ByVal condicion)
        Dim elimina As String = "update " & tabla & " set eliminado='si' where " & condicion
        comando = New SqlCommand(elimina, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function modificar_ventas_cabecera(ByVal tabla, ByVal campos, ByVal condicion)
        Dim actualiza As String = "update " & tabla & " set " & campos & " where " & condicion
        comando = New SqlCommand(actualiza, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    '__________Fin Ventas Cabecera _____________________________________________________
    '__________Ventas Detalle_____________________________________________________

    Public Sub consulta_ventas_detalle(ByVal sql As String, ByVal Ventas_detalle As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, Ventas_detalle)

    End Sub

    Function insertar_ventas_detalle(ByVal sql)
        'conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If

    End Function

    Function eliminar_ventas_detalle(ByVal tabla, ByVal condicion)
        Dim elimina As String = "update " & tabla & " set eliminado='si' where " & condicion
        comando = New SqlCommand(elimina, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function modificar_ventas_detalle(ByVal tabla, ByVal campos, ByVal condicion)
        Dim actualiza As String = "update " & tabla & " set " & campos & " where " & condicion
        comando = New SqlCommand(actualiza, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    '__________Fin Ventas Detalle _____________________________________________________
    'Consulta de datos para productos
    Public Class ConsultaDatos

        Public cn As SqlConnection
        Public adaptador As SqlDataAdapter
        Public dt As DataTable

        Sub New()
            Try
                cn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\juanpc\Documents\Visual Studio 2015\Projects\proyecto\proyecto\Base.mdf';Integrated Security=True")
                cn.Open()
            Catch ex As Exception
                MessageBox.Show("Error en la conexion: " + ex.ToString)
            End Try
        End Sub

        Sub llenarGrilla(ByVal dgv As DataGridView)
            Try
                adaptador = New SqlDataAdapter("Select * from productos", cn)
                dt = New DataTable
                adaptador.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al llenar la grilla: " + ex.ToString)
            End Try
        End Sub

        Sub consultaDinamica(ByVal id As String, ByVal campo As String, ByVal dgv As DataGridView)
            Try
                adaptador = New SqlDataAdapter("Select * from productos where " & campo & " like '" & "%" + id + "%" & "'", cn)
                dt = New DataTable
                adaptador.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error realizar la consulta dinamica en la grilla: " + ex.ToString)
            End Try
        End Sub
    End Class
    ' Consulta de datos para usuarios
    Public Class ConsultaDatos2

        Public cn As SqlConnection
        Public adaptador As SqlDataAdapter
        Public dt As DataTable

        Sub New()
            Try
                cn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\juanpc\Documents\Visual Studio 2015\Projects\proyecto\proyecto\Base.mdf';Integrated Security=True")
                cn.Open()
            Catch ex As Exception
                MessageBox.Show("Error en la conexion: " + ex.ToString)
            End Try
        End Sub

        Sub llenarGrilla(ByVal dgv As DataGridView)
            Try
                adaptador = New SqlDataAdapter("Select * from usuarios", cn)
                dt = New DataTable
                adaptador.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al llenar la grilla: " + ex.ToString)
            End Try
        End Sub

        Sub consultaDinamica(ByVal id As String, ByVal campo As String, ByVal dgv As DataGridView)
            Try
                adaptador = New SqlDataAdapter("Select * from usuarios where " & campo & " like '" & "%" + id + "%" & "'", cn)
                dt = New DataTable
                adaptador.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error realizar la consulta dinamica en la grilla: " + ex.ToString)
            End Try
        End Sub


    End Class
    ' Consulta de datos para clientes
    Public Class ConsultaDatos3

        Public cn As SqlConnection
        Public adaptador As SqlDataAdapter
        Public dt As DataTable

        Sub New()
            Try
                cn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\juanpc\Documents\Visual Studio 2015\Projects\proyecto\proyecto\Base.mdf';Integrated Security=True")
                cn.Open()
            Catch ex As Exception
                MessageBox.Show("Error en la conexion: " + ex.ToString)
            End Try
        End Sub

        Sub llenarGrilla(ByVal dgv As DataGridView)
            Try
                adaptador = New SqlDataAdapter("Select * from clientes", cn)
                dt = New DataTable
                adaptador.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al llenar la grilla: " + ex.ToString)
            End Try
        End Sub

        Sub consultaDinamica(ByVal id As String, ByVal campo As String, ByVal dgv As DataGridView)
            Try
                adaptador = New SqlDataAdapter("Select * from clientes where " & campo & " like '" & "%" + id + "%" & "'", cn)
                dt = New DataTable
                adaptador.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error realizar la consulta dinamica en la grilla: " + ex.ToString)
            End Try
        End Sub


    End Class

    ' Consulta de datos para ventas cabecera
    Public Class ConsultaDatos6

        Public cn As SqlConnection
        Public adaptador As SqlDataAdapter
        Public dt As DataTable

        Sub New()
            Try
                cn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\juanpc\Documents\Visual Studio 2015\Projects\proyecto\proyecto\Base.mdf';Integrated Security=True")
                cn.Open()
                respuesta = enunciado.ExecuteReader

            Catch ex As Exception
                MessageBox.Show("Error en la conexion: " + ex.ToString)
            End Try
        End Sub

        Sub llenarGrilla(ByVal dgv As DataGridView)
            Try
                adaptador = New SqlDataAdapter("Select * from ventas_cabecera", cn)
                dt = New DataTable
                adaptador.Fill(dt)
                dgv.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al llenar la grilla: " + ex.ToString)
            End Try
        End Sub

        Sub consultaDinamica(ByVal id As String, ByVal campo As String, ByVal dgv As DataGridView)
            Try
                adaptador = New SqlDataAdapter("Select * from ventas_cabecera where " & campo & " like '" & "%" + id + "%" & "'", cn)
                dt = New DataTable
                adaptador.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error realizar la consulta dinamica en la grilla: " + ex.ToString)
            End Try
        End Sub


    End Class
    ' Consulta de datos para ventas cabecera

    Public Class ConsultaDatos7

        Public cn As SqlConnection
        Public adaptador As SqlDataAdapter
        Public dt As DataTable

        Sub New()
            Try
                cn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\juanpc\Documents\Visual Studio 2015\Projects\proyecto\proyecto\Base.mdf';Integrated Security=True")
                cn.Open()
            Catch ex As Exception
                MessageBox.Show("Error en la conexion: " + ex.ToString)
            End Try
        End Sub

        Sub llenarGrilla(ByVal dgv As DataGridView)
            Try
                adaptador = New SqlDataAdapter("Select * from ventas_detalle", cn)
                dt = New DataTable
                adaptador.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al llenar la grilla: " + ex.ToString)
            End Try
        End Sub

        Sub consultaDinamica(ByVal id As String, ByVal campo As String, ByVal dgv As DataGridView)
            Try
                adaptador = New SqlDataAdapter("Select * from ventas_detalle where " & campo & " like '" & "%" + id + "%" & "'", cn)
                dt = New DataTable
                adaptador.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error realizar la consulta dinamica en la grilla: " + ex.ToString)
            End Try
        End Sub
    End Class
    'Consulta de datos para categorias
    Public Class ConsultaDatosCategorias

        Public cn As SqlConnection
        Public adaptador As SqlDataAdapter
        Public dt As DataTable

        Sub New()
            Try
                cn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\juanpc\Documents\Visual Studio 2015\Projects\proyecto\proyecto\Base.mdf';Integrated Security=True")
                cn.Open()
            Catch ex As Exception
                MessageBox.Show("Error en la conexion: " + ex.ToString)
            End Try
        End Sub

        Sub llenarGrilla(ByVal dgv As DataGridView)
            Try
                adaptador = New SqlDataAdapter("Select * from categorias where eliminado='no'", cn)
                dt = New DataTable
                adaptador.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al llenar la grilla: " + ex.ToString)
            End Try
        End Sub

        Sub consultaDinamica(ByVal id As String, ByVal campo As String, ByVal dgv As DataGridView)
            Try
                adaptador = New SqlDataAdapter("Select * from categorias where " & campo & " like '" & "%" + id + "%" & "'", cn)
                dt = New DataTable
                adaptador.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error realizar la consulta dinamica en la grilla: " + ex.ToString)
            End Try
        End Sub
    End Class

    'Consulta de datos para perfiles
    Public Class ConsultaDatosPerfiles

        Public cn As SqlConnection
        Public adaptador As SqlDataAdapter
        Public dt As DataTable

        Sub New()
            Try
                cn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\juanpc\Documents\Visual Studio 2015\Projects\proyecto\proyecto\Base.mdf';Integrated Security=True")
                cn.Open()
            Catch ex As Exception
                MessageBox.Show("Error en la conexion: " + ex.ToString)
            End Try
        End Sub

        Sub llenarGrilla(ByVal dgv As DataGridView)
            Try
                adaptador = New SqlDataAdapter("Select * from perfiles where eliminado='no'", cn)
                dt = New DataTable
                adaptador.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al llenar la grilla: " + ex.ToString)
            End Try
        End Sub

        Sub consultaDinamica(ByVal id As String, ByVal campo As String, ByVal dgv As DataGridView)
            Try
                adaptador = New SqlDataAdapter("Select * from perfiles where " & campo & " like '" & "%" + id + "%" & "'", cn)
                dt = New DataTable
                adaptador.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error realizar la consulta dinamica en la grilla: " + ex.ToString)
            End Try
        End Sub
    End Class
End Module