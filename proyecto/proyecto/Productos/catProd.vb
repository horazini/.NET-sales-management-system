Public Class catProd
    Dim campo As String = ""
    Dim obj As New ConsultaDatosCategorias
    Dim ideliminado As String = "no"
    Dim ideliminado2 As String = "no"
    Private Sub CategoriasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CategoriasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseDataSet)

    End Sub

    Private Sub catProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseDataSet.Categorias' Puede moverla o quitarla según sea necesario.
        'Me.CategoriasTableAdapter.Fill(Me.BaseDataSet.Categorias)
        Id_categoriaTextBox.Visible = False
        PanelNuevo.Visible = False
        PanelMostrartodos.Visible = False
        PanelModificar.Visible = False
        BTCancelar.Visible = False
    End Sub

    Private Sub BTModificar_Click(sender As Object, e As EventArgs) Handles BTModificar.Click
        PanelModificar.Visible = True
        PanelMostrartodos.Visible = False
        Id_categoriaTextBox.Visible = False
    End Sub

    Private Sub BTCancelar_Click(sender As Object, e As EventArgs) Handles BTCancelar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BTCancelar.Visible = True
        Id_categoriaTextBox.Visible = False
        PanelMostrartodos.Visible = False
        PanelBotones.Visible = False
        PanelNuevo.Visible = True
        DescripcionTextBox.Clear()
    End Sub

    ' Para mostrar todas las Categorias
    Public Sub MostrarDatosCategorias()
        Conexion.consulta_categorias("Select * from categorias where eliminado='no'", "categorias")
        CategoriasDataGridView.DataSource = Conexion.ds.Tables("categorias")
    End Sub

    ' Para mostrar los productos inactivos
    Public Sub MostrarDatosInactivos()
        Conexion.consulta_categorias("Select * from categorias where eliminado='si'", "categorias")
        CategoriasDataGridView.DataSource = Conexion.ds.Tables("categorias")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label7.Text = "Categorías Activas"
        BTCancelar.Visible = True
        MostrarDatosCategorias()
        PanelMostrartodos.Visible = True
        BTCancelar.Visible = True
        PanelBotones.Visible = False
        PanelNuevo.Visible = False
        BTInactivo2.Visible = True
        BTActivo2.Visible = False
    End Sub

    Private Sub BTEliminar_Click(sender As Object, e As EventArgs) Handles BTEliminar.Click
        ' Defina el mensaje que desea ver dentro del cuadro de mensaje.
        Dim msg = "¿Desea eliminar la categoría?"

        ' Muestre un cuadro de mensaje simple.
        'MsgBox(msg)

        ' Defina un título para el cuadro de mensaje.
        Dim title = "Eliminar Categoría"

        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                    MsgBoxStyle.Information
        'Muestre el cuadro de mensaje y guarde la respuesta, Sí o No.
        Dim ask = MsgBox(msg, style, title)

        ' Tome alguna acción basada en la respuesta.
        If ask = MsgBoxResult.Yes Then
            If (Conexion.eliminar_productos("categorias", "id_categoria = " & Id_categoriaTextBox.Text)) Then
                MsgBox("Se elimino la categoría: " & Id_categoriaTextBox.Text, MsgBoxStyle.Information
                       )
                MostrarDatosCategorias()
            Else
                MsgBox("Error al eliminar.", MsgBoxStyle.Critical
                       )
            End If
        Else

        End If
    End Sub

    Private Sub CategoriasDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CategoriasDataGridView.CellClick
        Dim dtgp As DataGridViewRow = CategoriasDataGridView.Rows(e.RowIndex)
        Id_categoriaTextBox.Text = dtgp.Cells(0).Value.ToString
        DescripcionTextBox.Text = dtgp.Cells(1).Value.ToString
        CBEliminado.Text = dtgp.Cells(2).Value.ToString


        ' Fomu de modificar
        Id_categoriaTextBox2.Text = dtgp.Cells(0).Value.ToString
        DescripcionTextBox2.Text = dtgp.Cells(1).Value.ToString
        CBEliminado2.Text = dtgp.Cells(2).Value.ToString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BTInactivo2.Click
        Label7.Text = "Categorías Inactivas"
        MostrarDatosInactivos()
        PanelMostrartodos.Visible = True
        BTCancelar.Visible = True
        PanelBotones.Visible = False
        PanelNuevo.Visible = False
        BTActivo2.Visible = True
        BTInactivo2.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BTActivo2.Click
        Label7.Text = "Categorías Activas"
        BTCancelar.Visible = True
        MostrarDatosCategorias()
        PanelMostrartodos.Visible = True
        PanelBotones.Visible = False
        PanelNuevo.Visible = False
        BTActivo2.Visible = False
        BTInactivo2.Visible = True
    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged
        campo = "descripcion"
        obj.consultaDinamica(TextBoxBuscar.Text, campo, CategoriasDataGridView)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BTCancelar.Visible = True
        If CBEliminado2.SelectedItem = "NO" Then
            ideliminado2 = "no"
        ElseIf CBEliminado2.SelectedItem = "SI" Then
            ideliminado2 = "si"
        End If
        ' Defina el mensaje que desea ver dentro del cuadro de mensaje.
        Dim msg = "¿Desea modificar la categoría?"

        ' Muestre un cuadro de mensaje simple.
        'MsgBox(msg)

        ' Defina un título para el cuadro de mensaje.
        Dim title = "Modificar Categoría"

        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                    MsgBoxStyle.Information
        'Muestre el cuadro de mensaje y guarde la respuesta, Sí o No.
        Dim ask = MsgBox(msg, style, title)

        ' Tome alguna acción basada en la respuesta.
        If ask = MsgBoxResult.Yes Then
            If (DescripcionTextBox2.Text <> "" And CBEliminado2.Text <> "") Then
                Dim actualizar As String = "descripcion= '" & DescripcionTextBox2.Text & "',eliminado= '" & ideliminado2 & "'"
                If (Conexion.modificar_categorias("categorias", actualizar, "id_categoria=" & Id_categoriaTextBox2.Text)) Then
                    MsgBox("Se modifico correctamente categoría: " & Id_categoriaTextBox2.Text)
                    MostrarDatosCategorias()
                    Label2.Text = "Categorías Activas"
                    PanelNuevo.Visible = False

                    PanelModificar.Visible = False
                    PanelMostrartodos.Visible = True

                Else
                    MsgBox("Error al agregar la Categoría")
                End If
            Else
                MsgBox("Debe completar todas las opciones.", MsgBoxStyle.Critical)
            End If
        Else

        End If
    End Sub

    Private Sub BTGrabar_Click(sender As Object, e As EventArgs) Handles BTGrabar.Click
        BTCancelar.Visible = True
        If CBEliminado.SelectedItem = "NO" Then
            ideliminado = "no"
        ElseIf CBEliminado.SelectedItem = "SI" Then
            ideliminado = "si"
        End If
        If (DescripcionTextBox.Text <> "" And CBEliminado.Text <> "") Then
            Dim agregar As String = "insert into categorias values ('" & DescripcionTextBox.Text & "','" & ideliminado & "')"
            If (Conexion.insertar_productos(agregar)) Then
                MsgBox("Se registró correctamente.")
                MostrarDatosCategorias()
                PanelNuevo.Visible = False
                PanelBotones.Visible = False
                PanelMostrartodos.Visible = True
                BTActivo2.Visible = False
                BTInactivo2.Visible = True

            Else
                MsgBox("Error al agregar la categoría.")
            End If
        Else
            MsgBox("Debe completar todas las opciones.", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub CBEliminado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEliminado.SelectedIndexChanged
        If CBEliminado.SelectedItem = "NO" Then
            ideliminado = "no"
        ElseIf CBEliminado.SelectedItem = "SI" Then
            ideliminado = "si"
        End If
    End Sub
End Class