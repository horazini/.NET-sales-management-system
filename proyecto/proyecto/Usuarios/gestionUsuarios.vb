Imports System.Data.SqlClient

Public Class gestionUsuarios

    Dim idperfil As Integer = 0
    Dim ideliminado As String = ""
    Dim idperfil2 As Integer = 0
    Dim ideliminado2 As String = ""
    Dim obj As New ConsultaDatos2
    Dim campo As String = ""

    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuariosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseDataSet)

    End Sub

    Private Sub gestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        ' Me.UsuariosTableAdapter.Fill(Me.BaseDataSet.Usuarios)

        PanelMostrarTodos.Visible = False

        PanelNuevo.Visible = False
        PanelModificar.Visible = False
        BTVolver.Visible = False
        dni.Checked = True
        If (perf <> 3) Then
            Beliminar.Visible = False
            Bmodificar.Visible = False
        End If
    End Sub
    ' Para mostrar todos los usuarios
    Public Sub MostrarDatosUsuarios()
        Conexion.consulta_usuarios("Select * from usuarios where eliminado='no'", "usuarios")
        UsuariosDataGridView.DataSource = Conexion.ds.Tables("usuarios")
    End Sub

    Public Sub MostrarUsuariosInactivos()
        Conexion.consulta_usuarios("Select * from usuarios where eliminado='si'", "usuarios")
        UsuariosDataGridView.DataSource = Conexion.ds.Tables("usuarios")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bagregar.Click
        BTVolver.Visible = True

        PanelBotones.Visible = False
        PanelNuevo.Visible = True


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Bmodificar.Click
        BTVolver.Visible = True
        PanelModificar.Visible = True
        PanelBotones.Visible = False
        PanelNuevo.Visible = False
        PanelMostrarTodos.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Beliminar.Click
        ' Defina el mensaje que desea ver dentro del cuadro de mensaje.
        Dim msg = "¿Desea eliminar el usuario?"

        ' Muestre un cuadro de mensaje simple.
        'MsgBox(msg)

        ' Defina un título para el cuadro de mensaje.
        Dim title = "Eliminar Usuario"

        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                    MsgBoxStyle.Information
        'Muestre el cuadro de mensaje y guarde la respuesta, Sí o No.
        Dim ask = MsgBox(msg, style, title)

        ' Tome alguna acción basada en la respuesta.
        If ask = MsgBoxResult.Yes Then

            If (Conexion.eliminar_usuarios("usuarios", "id_usuario = " & TBidusuario2.Text)) Then
                MsgBox("Se elimino el usuario: " & TBidusuario2.Text, MsgBoxStyle.Information
                       )
                MostrarDatosUsuarios()
            Else
                MsgBox("Error al eliminar.", MsgBoxStyle.Critical
                       )
            End If
        Else

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.UsuariosTableAdapter.buscarUsuario(Me.BaseDataSet.Usuarios, TBdni2.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Bmostrar.Click
        Label2.Text = "Usuarios Activos"
        PanelMostrarTodos.Visible = True
        PanelBotones.Visible = False
        BTVolver.Visible = True
        MostrarDatosUsuarios()
        BTInactivo.Visible = True
        BTActivos.Visible = False
    End Sub

    Private Sub FechaNacDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles FechaNacDateTimePicker2.ValueChanged

    End Sub

    Private Sub TelefonoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBtelefono2.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890" ' allowed In textbox
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Usuario_dniTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBdni2.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890" ' allowed In textbox
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBeliminado2.SelectedIndexChanged
        If CBeliminado2.SelectedItem = "NO" Then
            ideliminado2 = "no"
        ElseIf CBeliminado2.SelectedItem = "SI" Then
            ideliminado2 = "si"
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BTVolver.Click
        PanelBotones.Visible = True
        PanelNuevo.Visible = False
        PanelMostrarTodos.Visible = False
        PanelModificar.Visible = False
        BTVolver.Visible = False

    End Sub

    Private Sub BTLimpiar_Click(sender As Object, e As EventArgs) Handles BTLimpiar.Click
        TBapellido.Clear()
        TBnombre.Clear()
        TBtelefono.Clear()
        TBemail.Clear()
        TBdni.Clear()
        TBnombusuario.Clear()
        TBpass.Clear()
        CBidperfil.Text = ""
    End Sub

    Private Sub BTGuardar_Click(sender As Object, e As EventArgs) Handles BTGuardar.Click
        BTVolver.Visible = True
        If CBidperfil.Text = "1 - CAJERO" Then
            idperfil = 1
        ElseIf CBidperfil.Text = "2 - GESTION" Then
            idperfil = 2
        ElseIf CBidperfil.Text = "3 - SISTEMAS" Then
            idperfil = 3
        End If

        If (TBapellido.Text <> "" And TBnombre.Text <> "" And TBtelefono.Text <> "" And TBemail.Text <> "" And TBdni.Text <> "" And FechaNacDateTimePicker.Text <> "" And TBnombusuario.Text <> "" And TBpass.Text <> "" And CBidperfil.Text <> "") Then
            Dim Tabla As DataTable
            Conexion.consulta_usuarios("Select * from usuarios where usuario ='" & TBnombusuario.Text & "'", "usuarios")
            Tabla = Conexion.ds.Tables("usuarios")

            If Tabla.Rows.Count <> 0 Then
                MsgBox("Ya existe un usuario con ese nombre de usuario", MsgBoxStyle.Critical)
            Else
                Dim agregar As String = "insert into usuarios values ('" & TBapellido.Text & "','" & TBnombre.Text & "','" & TBnombusuario.Text & "','" & TBpass.Text & "'," & idperfil & ",'" & TBemail.Text & "'," & TBdni.Text & ",'" & FechaNacDateTimePicker.Value.ToString("MM/dd/yyyy") & "'," & TBtelefono.Text & ",'" & "no" & "')"
                If (Conexion.insertar_usuarios(agregar)) Then
                    MsgBox("Se registró correctamente.")
                    MostrarDatosUsuarios()
                    PanelNuevo.Visible = False
                    PanelBotones.Visible = False
                    PanelMostrarTodos.Visible = True

                Else
                    MsgBox("Error al agregar el usuario.")
                End If

            End If

        Else
            MsgBox("Debe completar todas las opciones.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub CBidperfil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBidperfil.SelectedIndexChanged

        If CBidperfil.Text = "1 - CAJERO" Then
            idperfil = 1
        ElseIf CBidperfil.Text = "2 - GESTION" Then
            idperfil = 2
        ElseIf CBidperfil.Text = "3 - SISTEMAS" Then
            idperfil = 3
        End If
    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged
        If (dni.Checked) Then
            campo = "usuario_dni"
        Else
            campo = "apellido"
        End If
        obj.consultaDinamica(TextBoxBuscar.Text, campo, UsuariosDataGridView)
    End Sub


    Private Sub UsuariosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsuariosDataGridView.CellClick
        Dim dtgp As DataGridViewRow = UsuariosDataGridView.Rows(e.RowIndex)



        'Para modif
        TBidusuario2.Text = dtgp.Cells(0).Value.ToString
        TBapellido2.Text = dtgp.Cells(1).Value.ToString
        TBnombre2.Text = dtgp.Cells(2).Value.ToString
        TBnombusuario2.Text = dtgp.Cells(3).Value.ToString
        TBpass2.Text = dtgp.Cells(4).Value.ToString
        TBemail2.Text = dtgp.Cells(6).Value.ToString
        TBdni2.Text = dtgp.Cells(7).Value.ToString
        FechaNacDateTimePicker2.Value = dtgp.Cells(8).Value
        TBtelefono2.Text = dtgp.Cells(9).Value.ToString


        If (dtgp.Cells(5).Value.ToString = 1) Then
            CBidperfil.SelectedItem = "1 - CAJERO"
        ElseIf (dtgp.Cells(5).Value.ToString = 2) Then
            CBidperfil.SelectedItem = "2 - GESTION"
        ElseIf (dtgp.Cells(5).Value.ToString = 3) Then
            CBidperfil.SelectedItem = "3 - SISTEMAS"
        End If

        If (dtgp.Cells(5).Value.ToString = 1) Then
            CBidperfil2.SelectedItem = "1 - CAJERO"
        ElseIf (dtgp.Cells(5).Value.ToString = 2) Then
            CBidperfil2.SelectedItem = "2 - GESTION"
        ElseIf (dtgp.Cells(5).Value.ToString = 3) Then
            CBidperfil2.SelectedItem = "3 - SISTEMAS"
        End If

        If (dtgp.Cells(10).Value.ToString = "no") Then
            CBeliminado2.SelectedItem = "NO"
        ElseIf (dtgp.Cells(10).Value.ToString = "si") Then
            CBeliminado2.SelectedItem = "SI"
        End If

        If (dtgp.Cells(10).Value.ToString = "no") Then
            CBeliminado2.SelectedItem = "NO"
        ElseIf (dtgp.Cells(10).Value.ToString = "si") Then
            CBeliminado2.SelectedItem = "SI"
        End If

    End Sub

    Private Sub BTGuardarModif_Click(sender As Object, e As EventArgs) Handles BTGuardarModif.Click
        BTVolver.Visible = True
        ' Defina el mensaje que desea ver dentro del cuadro de mensaje.
        Dim msg = "¿Desea modificar el usuario?"

        ' Muestre un cuadro de mensaje simple.
        'MsgBox(msg)

        ' Defina un título para el cuadro de mensaje.
        Dim title = "Modificar Usuario"

        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                    MsgBoxStyle.Information
        'Muestre el cuadro de mensaje y guarde la respuesta, Sí o No.
        Dim ask = MsgBox(msg, style, title)

        ' Tome alguna acción basada en la respuesta.
        If ask = MsgBoxResult.Yes Then
            If CBidperfil2.Text = "1 - CAJERO" Then
                idperfil2 = 1
            ElseIf CBidperfil2.Text = "2 - GESTION" Then
                idperfil2 = 2
            ElseIf CBidperfil2.Text = "3 - SISTEMAS" Then
                idperfil2 = 3
            End If

            If CBeliminado2.SelectedItem = "NO" Then
                ideliminado2 = "no"
            ElseIf CBeliminado2.SelectedItem = "SI" Then
                ideliminado2 = "si"
            End If

            If (TBapellido2.Text <> "" And TBnombre2.Text <> "" And TBtelefono2.Text <> "" And TBemail2.Text <> "" And TBdni2.Text <> "" And FechaNacDateTimePicker2.Text <> "" And TBnombusuario2.Text <> "" And TBpass2.Text <> "" And CBidperfil2.Text <> "" And CBeliminado2.Text <> "") Then
                Dim actualizar As String = "apellido= '" & TBapellido2.Text & "',nombre= '" & TBnombre2.Text & "',usuario= '" & TBnombusuario2.Text & "',contraseña= '" & TBpass2.Text & "',id_perfil= " & idperfil2 & ",email= '" & TBemail2.Text & "',usuario_dni= " & TBdni2.Text & ",fechaNac= '" & FechaNacDateTimePicker2.Value.ToString("MM/dd/yyyy") & "',telefono= " & TBtelefono2.Text & ",eliminado= '" & ideliminado2 & "'"
                If (Conexion.modificar_usuarios("usuarios", actualizar, "id_usuario=" & TBidusuario2.Text)) Then
                    MsgBox("Se modifico correctamente usuario: " & TBidusuario2.Text)
                    MostrarDatosUsuarios()
                    PanelNuevo.Visible = False

                    PanelModificar.Visible = False
                    PanelMostrarTodos.Visible = True

                Else
                    MsgBox("Error al modificar Usuario")
                End If
            Else
                MsgBox("Debe completar todas las opciones.", MsgBoxStyle.Critical)
            End If
        Else

        End If
    End Sub

    Private Sub CBidperfil2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBidperfil2.SelectedIndexChanged
        If CBidperfil2.Text = "1 - CAJERO" Then
            idperfil2 = 1
        ElseIf CBidperfil2.Text = "2 - GESTION" Then
            idperfil2 = 2
        ElseIf CBidperfil2.Text = "3 - SISTEMAS" Then
            idperfil2 = 3
        End If
    End Sub

    Private Sub BTActivos_Click(sender As Object, e As EventArgs) Handles BTActivos.Click
        Label2.Text = "Usuarios Activos"
        BTVolver.Visible = True
        MostrarDatosUsuarios()
        PanelMostrarTodos.Visible = True
        PanelBotones.Visible = False
        PanelNuevo.Visible = False
        BTInactivo.Visible = True
        BTActivos.Visible = False
    End Sub

    Private Sub BTInactivo_Click(sender As Object, e As EventArgs) Handles BTInactivo.Click
        Label2.Text = "Usuarios Inactivos"
        MostrarUsuariosInactivos()
        PanelMostrarTodos.Visible = True
        BTVolver.Visible = True
        PanelBotones.Visible = False
        PanelNuevo.Visible = False
        BTActivos.Visible = True
        BTInactivo.Visible = False
    End Sub

    Private Sub TBtelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBtelefono.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890" ' allowed In textbox
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TBdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBdni.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890" ' allowed In textbox
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BTPerfiles_Click(sender As Object, e As EventArgs) 
        Dim newperfUsuarios As New perfilesU
        'newcatProductos.MdiParent = Me
        newperfUsuarios.Show()
    End Sub
End Class