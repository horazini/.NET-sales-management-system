Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class gestionClientes
    Dim ideliminado As String = ""
    Dim ideliminado2 As String = ""
    Dim obj As New ConsultaDatos3
    Dim campo As String = ""

    Dim cmd As New SqlCommand

    Private Sub gestionClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        'Me.ClientesTableAdapter.Fill(Me.BaseDataSet.Clientes)
        PanelNuevo.Visible = False
        PanelModificar.Visible = False
        PanelMostrarTodos.Visible = False
        PanelNuevo.Visible = False
        TBidcliente.Visible = False
        BTvolver.Visible = False
        If (perf <> 1) Then
            Beliminar.Visible = False
            Bmodificar.Visible = False
        End If
    End Sub

    ' Para mostrar todos los clientes
    Public Sub MostrarDatosClientes()
        conexion.consulta_clientes("Select * from clientes where eliminado='no'", "clientes")
        ClientesDataGridView.DataSource = Conexion.ds.Tables("clientes")
    End Sub

    Public Sub MostrarClientesInactivos()
        conexion.consulta_clientes("Select * from clientes where eliminado='si'", "clientes")
        ClientesDataGridView.DataSource = conexion.ds.Tables("clientes")
    End Sub

    Private Sub Bagregar_Click(sender As Object, e As EventArgs) Handles Bagregar.Click
        PanelNuevo.Visible = True
        BTvolver.Visible = True
        PanelBotones.Visible = False


    End Sub

    Private Sub Bmostrar_Click(sender As Object, e As EventArgs) Handles Bmostrar.Click
        Label12.Text = "Clientes Activos"
        PanelMostrarTodos.Visible = True
        PanelBotones.Visible = False
        BTvolver.Visible = True
        MostrarDatosClientes()
        BTInactivo.Visible = True
        BTActivos.Visible = False
        apecliente.Checked = True

    End Sub

    Private Sub Bmodificar_Click(sender As Object, e As EventArgs) Handles Bmodificar.Click
        PanelModificar.Visible = True
        BTvolver.Visible = True
        PanelBotones.Visible = False
        PanelMostrarTodos.Visible = False


    End Sub

    Private Sub BTvolver_Click(sender As Object, e As EventArgs) Handles BTvolver.Click
        PanelMostrarTodos.Visible = False
        PanelModificar.Visible = False
        PanelNuevo.Visible = False
        PanelBotones.Visible = True
        BTvolver.Visible = False

    End Sub

    Private Sub BTGuardar_Click(sender As Object, e As EventArgs) Handles BTGuardar.Click

        If (TBdni.Text <> "" And TBapellido.Text <> "" And TBnombre.Text <> "" And FechaNacDateTimePicker.Text <> "" And TBemail.Text <> "" And TBdomicilio.Text <> "" And TBtelefono.Text <> "") Then

            Dim Tabla As DataTable
            Conexion.consulta_clientes("Select * from clientes where dni ='" & TBdni.Text & "'", "clientes")
            Tabla = Conexion.ds.Tables("clientes")

            If Tabla.Rows.Count <> 0 Then
                MsgBox("Ya existe un cliente con ese DNI", MsgBoxStyle.Critical)
            Else

                Dim agregar As String = "insert into clientes values (" & TBdni.Text & ",'" & TBapellido.Text & "','" & TBnombre.Text & "','" & FechaNacDateTimePicker.Value.ToString("MM/dd/yyyy") & "','" & TBemail.Text & "','" & TBdomicilio.Text & "'," & TBtelefono.Text & ",'" & "no" & "')"
                If (Conexion.insertar_clientes(agregar)) Then
                    MsgBox("Se registró correctamente.")
                    MostrarDatosClientes()
                    PanelNuevo.Visible = False
                    PanelBotones.Visible = False
                    PanelMostrarTodos.Visible = True
                    BTActivos.Visible = False
                Else
                    MsgBox("Error al agregar el Cliente.")
                End If

            End If


        Else
            MsgBox("Debe completar todas las opciones.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub BTInactivo_Click(sender As Object, e As EventArgs) Handles BTInactivo.Click
        Label12.Text = "Clientes Inactivos"
        MostrarClientesInactivos()
        PanelMostrarTodos.Visible = True
        BTvolver.Visible = True
        PanelBotones.Visible = False
        PanelNuevo.Visible = False
        BTActivos.Visible = True
        BTInactivo.Visible = False
    End Sub

    Private Sub BTActivos_Click(sender As Object, e As EventArgs) Handles BTActivos.Click
        Label12.Text = "Clientes Activos"
        BTvolver.Visible = True
        MostrarDatosClientes()
        PanelMostrarTodos.Visible = True
        PanelBotones.Visible = False
        PanelNuevo.Visible = False
        BTInactivo.Visible = True
        BTActivos.Visible = False
    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged
        If (dnicli.Checked) Then
            campo = "dni"
        Else
            campo = "apellido"
        End If
        obj.consultaDinamica(TextBoxBuscar.Text, campo, ClientesDataGridView)
    End Sub

    Private Sub ClientesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClientesDataGridView.CellClick
        Dim dtgp As DataGridViewRow = ClientesDataGridView.Rows(e.RowIndex)

        'Para modif
        TBidcliente2.Text = dtgp.Cells(0).Value.ToString
        TBdni2.Text = dtgp.Cells(1).Value.ToString
        TBapellido2.Text = dtgp.Cells(2).Value.ToString
        TBnombre2.Text = dtgp.Cells(3).Value.ToString
        FechaNacDateTimePicker2.Value = dtgp.Cells(4).Value
        TBemail2.Text = dtgp.Cells(5).Value.ToString
        TBdomicilio2.Text = dtgp.Cells(6).Value.ToString
        TBtelefono2.Text = dtgp.Cells(7).Value.ToString

        If (dtgp.Cells(8).Value.ToString = "no") Then
            CBeliminado2.SelectedItem = "NO"
        ElseIf (dtgp.Cells(8).Value.ToString = "si") Then
            CBeliminado2.SelectedItem = "SI"
        End If

        If (dtgp.Cells(8).Value.ToString = "no") Then
            CBeliminado2.SelectedItem = "NO"
        ElseIf (dtgp.Cells(8).Value.ToString = "si") Then
            CBeliminado2.SelectedItem = "SI"
        End If

    End Sub

    Private Sub BTGrabar2_Click(sender As Object, e As EventArgs) Handles BTGrabar2.Click
        BTvolver.Visible = True
        ' Defina el mensaje que desea ver dentro del cuadro de mensaje.
        Dim msg = "¿Desea modificar el Cliente?"

        ' Muestre un cuadro de mensaje simple.
        'MsgBox(msg)

        ' Defina un título para el cuadro de mensaje.
        Dim title = "Modificar Cliente"

        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                    MsgBoxStyle.Information
        'Muestre el cuadro de mensaje y guarde la respuesta, Sí o No.
        Dim ask = MsgBox(msg, style, title)

        ' Tome alguna acción basada en la respuesta.
        If ask = MsgBoxResult.Yes Then

            If CBeliminado2.SelectedItem = "NO" Then
                ideliminado2 = "no"
            ElseIf CBeliminado2.SelectedItem = "SI" Then
                ideliminado2 = "si"
            End If

            If (TBdni2.Text <> "" And TBapellido2.Text <> "" And TBnombre2.Text <> "" And FechaNacDateTimePicker2.Text <> "" And TBemail2.Text <> "" And TBdomicilio2.Text <> "" And TBtelefono2.Text <> "" And CBeliminado2.Text <> "") Then
                Dim actualizar As String = "dni= " & TBdni2.Text & ",apellido= '" & TBapellido2.Text & "',nombre= '" & TBnombre2.Text & "',fecha_nac= '" & FechaNacDateTimePicker2.Value.ToString("MM/dd/yyyy") & "',email= '" & TBemail2.Text & "',direccion= '" & TBdomicilio2.Text & "',telefono= " & TBtelefono2.Text & ",eliminado= '" & ideliminado2 & "'"
                If (conexion.modificar_clientes("clientes", actualizar, "id_cliente=" & TBidcliente2.Text)) Then
                    MsgBox("Se modifico correctamente Cliente: " & TBidcliente2.Text)
                    MostrarDatosClientes()
                    PanelNuevo.Visible = False

                    PanelModificar.Visible = False
                    PanelMostrarTodos.Visible = True

                Else
                    MsgBox("Error al modificar Cliente")
                End If

            Else
                    MsgBox("Debe completar todas las opciones.", MsgBoxStyle.Critical)
            End If
        Else

        End If
    End Sub

    Private Sub Beliminar_Click(sender As Object, e As EventArgs) Handles Beliminar.Click
        ' Defina el mensaje que desea ver dentro del cuadro de mensaje.
        Dim msg = "¿Desea eliminar el Cliente?"

        ' Muestre un cuadro de mensaje simple.
        'MsgBox(msg)

        ' Defina un título para el cuadro de mensaje.
        Dim title = "Eliminar Cliente"

        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                    MsgBoxStyle.Information
        'Muestre el cuadro de mensaje y guarde la respuesta, Sí o No.
        Dim ask = MsgBox(msg, style, title)

        ' Tome alguna acción basada en la respuesta.
        If ask = MsgBoxResult.Yes Then
            If (conexion.eliminar_clientes("clientes", "id_cliente = " & TBidcliente2.Text)) Then
                MsgBox("Se elimino el Cliente: " & TBidcliente2.Text, MsgBoxStyle.Information
                       )
                MostrarDatosClientes()
            Else
                MsgBox("Error al eliminar el Cliente.", MsgBoxStyle.Critical
                       )
            End If
        Else

        End If
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

    Private Sub TBdni2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBdni2.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890" ' allowed In textbox
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TBtelefono2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBtelefono2.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890" ' allowed In textbox
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class