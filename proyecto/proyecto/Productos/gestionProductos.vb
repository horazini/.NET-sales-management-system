Imports System.Data.SqlClient

Public Class gestionProductos

    Dim ideliminado As String = "no"
    Dim idcategoria As Integer = 0
    Dim ideliminado2 As String = "no"
    Dim idcategoria2 As Integer = 0
    Dim obj As New ConsultaDatos
    Dim campo As String = ""

    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseDataSet)

    End Sub

    Private Sub gestionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelNuevo.Visible = False
        PanelMostrartodos.Visible = False
        PanelModificar.Visible = False
        BTCancelar.Visible = False
        ImagenTextBox.Visible = False
        desc_prod.Checked = True
        BTCancelar.Visible = False
        If (perf <> 1) Then
            BTEliminar.Visible = False
            BTModificar.Visible = False
        End If
    End Sub
    ' Para mostrar todos los productos
    Public Sub MostrarDatos()
        Conexion.consulta_productos("Select * from productos where eliminado='no'", "productos")
        ProductosDataGridView.DataSource = Conexion.ds.Tables("productos")
    End Sub

    ' Para mostrar los productos inactivos
    Public Sub MostrarDatosInactivos()
        Conexion.consulta_productos("Select * from productos where eliminado='si'", "productos")
        ProductosDataGridView.DataSource = Conexion.ds.Tables("productos")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTAgregar.Click
        BTCancelar.Visible = True
        Id_productoTextBox.Visible = False
        Label4.Visible = False
        PanelMostrartodos.Visible = False
        PanelBotones.Visible = False
        PanelNuevo.Visible = True
        DescripcionTextBox.Clear()
        Precio_ventaTextBox.Clear()
        Precio_costoTextBox.Clear()
        CBcategoria.Text = ""
        CBEliminado.Text = ""
        StockTextBox.Clear()
        Stock_minTextBox.Clear()
        ImagenTextBox.Clear()
        PictureBox1.Image = Nothing
        PictureBox1.BackgroundImage = Nothing
        BTCancelar.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTModificar.Click
        PanelModificar.Visible = True
        PanelMostrartodos.Visible = False
        Id_productoTextBox.Visible = False
        Label4.Visible = False
        ImagenTextBox2.Visible = False
        StockTextBox2.Text = CambiaComaPorPunto(StockTextBox2.Text)
        Stock_minTextBox2.Text = CambiaComaPorPunto(Stock_minTextBox2.Text)
        Precio_costoTextBox2.Text = CambiaComaPorPunto(Precio_costoTextBox2.Text)
        Precio_ventaTextBox2.Text = CambiaComaPorPunto(Precio_ventaTextBox2.Text)
    End Sub

    Public Function CambiaComaPorPunto(ByVal cadena As String) As String
        Dim iIni As Integer
        Dim iLng As Integer
        Dim sRes As String
        Dim sPed As String
        sRes = ""
        iLng = Len(cadena)
        For iIni = 1 To iLng
            sPed = Mid(cadena, iIni, 1)
            sRes = sRes & IIf(sPed = ",", ".", sPed)
        Next iIni
        CambiaComaPorPunto = sRes
    End Function

    Public Function CambiaPuntoPorComa(ByVal cadena2 As String) As String
        Dim iIni2 As Integer
        Dim iLng2 As Integer
        Dim sRes2 As String
        Dim sPed2 As String
        sRes2 = ""
        iLng2 = Len(cadena2)
        For iIni2 = 1 To iLng2
            sPed2 = Mid(cadena2, iIni2, 1)
            sRes2 = sRes2 & IIf(sPed2 = ".", ",", sPed2)
        Next iIni2
        CambiaPuntoPorComa = sRes2
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTEliminar.Click
        ' Defina el mensaje que desea ver dentro del cuadro de mensaje.
        Dim msg = "¿Desea eliminar el producto?"

        ' Muestre un cuadro de mensaje simple.
        'MsgBox(msg)

        ' Defina un título para el cuadro de mensaje.
        Dim title = "Eliminar Productos"

        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                    MsgBoxStyle.Information
        'Muestre el cuadro de mensaje y guarde la respuesta, Sí o No.
        Dim ask = MsgBox(msg, style, title)

        ' Tome alguna acción basada en la respuesta.
        If ask = MsgBoxResult.Yes Then
            If (Conexion.eliminar_productos("productos", "id_producto = " & Id_productoTextBox2.Text)) Then
                MsgBox("Se elimino el producto: " & Id_productoTextBox2.Text, MsgBoxStyle.Information
                       )
                MostrarDatos()
            Else
                MsgBox("Error al eliminar.", MsgBoxStyle.Critical
                       )
            End If
        Else

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BTMostrar.Click
        Label2.Text = "Productos Activos"
        BTCancelar.Visible = True
        MostrarDatos()
        PanelMostrartodos.Visible = True
        BTCancelar.Visible = True
        PanelBotones.Visible = False
        PanelNuevo.Visible = False
        BTInactivo.Visible = True
        BTActivos.Visible = False
    End Sub

    Private Sub BTGrabar_Click(sender As Object, e As EventArgs) Handles BTGrabar.Click
        PictureBox1.Image = Nothing
        PictureBox1.BackgroundImage = Nothing
        BTCancelar.Visible = True
        If (DescripcionTextBox.Text <> "" And CBcategoria.Text <> "" And Precio_costoTextBox.Text <> "" And Precio_ventaTextBox.Text <> "" And StockTextBox.Text <> "" And Stock_minTextBox.Text <> "") Then

            Dim Tabla As DataTable
            Conexion.consulta_productos("Select * from productos where descripcion ='" & DescripcionTextBox.Text & "'", "productos")
            Tabla = Conexion.ds.Tables("productos")

            If Tabla.Rows.Count <> 0 Then
                MsgBox("Ya existe un producto con esa descripcion", MsgBoxStyle.Critical)
            Else
                Dim agregar As String = "insert into productos values ('" & DescripcionTextBox.Text & "'," & idcategoria & "," & Precio_costoTextBox.Text & "," & Precio_ventaTextBox.Text & "," & StockTextBox.Text & "," & Stock_minTextBox.Text & ",'" & ImagenTextBox.Text & "','" & "no" & "')"
                If (Conexion.insertar_productos(agregar)) Then
                    MsgBox("Se registró correctamente.")
                    MostrarDatos()
                    PanelNuevo.Visible = False
                    PanelBotones.Visible = False
                    PanelMostrartodos.Visible = True
                    BTActivos.Visible = False

                Else
                    MsgBox("Error al agregar producto")
                End If

            End If

        Else
            MsgBox("Debe completar todas las opciones.", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub BTCancelar_Click(sender As Object, e As EventArgs) Handles BTCancelar.Click
        PanelBotones.Visible = True
        PanelMostrartodos.Visible = False
        PanelNuevo.Visible = False
        BTCancelar.Visible = False
        PanelModificar.Visible = False
    End Sub

    Private Sub BTLimpiar_Click(sender As Object, e As EventArgs) Handles BTLimpiar.Click
        DescripcionTextBox.Clear()
        Precio_ventaTextBox.Clear()
        Precio_costoTextBox.Clear()
        StockTextBox.Clear()
        Stock_minTextBox.Clear()
        ImagenTextBox.Clear()
        CBcategoria.Text = ""
        CBEliminado.Text = ""
        PictureBox1.Image = Nothing
        PictureBox1.BackgroundImage = Nothing
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BTFoto.Click
        'Filtrar archivos de imagenes para que el usuario no elija otro tipo de archivos
        OpenFileDialog1.Filter = "Archivos Imagenes|*.jpg|Archivos Imagenes|*.bmp|Archivos Imagenes|*.png"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            OpenFileDialog1_FileOk(Image.FromFile(OpenFileDialog1.FileName))
            PictureBox1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            'BTFoto.Text = OpenFileDialog1.FileName
            ImagenTextBox.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub OpenFileDialog2_FileOk(ByVal sender As System.Object)
        'Copia archivo a la carpeta creada en el proyecto
        Dim strm2 As System.IO.Stream = OpenFileDialog2.OpenFile()
        Dim cadena2 As String = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase).Remove(0, 6)
        'Obtiene la ruta del direcotiro donde esta el proyecto

        Dim Source2 As String
        Dim archivo2 As String
        Dim Destination2 As String
        Source2 = OpenFileDialog2.FileName.ToString()
        'Obtiene el nombre completo de la ruta donde esta el archivo que vamos a copiar
        archivo2 = StrSacaValoresString2(Source2)
        'Obtiene el nombre del archivo
        Destination2 = cadena2 + "\Fotos\" + archivo2
        'Es la carpeta destino donde voy a copiar los archivos
        'BTFoto.Text = Destination
    End Sub
    Function StrSacaValoresString2(ByVal RutaPathFichero2 As String) As String
        'Esta funcion obtiene el nombre del aricho que selecciono
        Dim ChrsIn2 As String, ChrsOut2 As String = 0, IdX2 As Integer, Chrs2 As Integer
        On Error GoTo StrSacaValoresString_General_ErrTrap2

        If RutaPathFichero2 = "" Then MsgBox("Debe seleccionar un archivo")
        ChrsIn2 = RutaPathFichero2
        'Devuelve el nombre del fichero original
        If InStr(ChrsIn2, "\") Then
            For IdX2 = Len(ChrsIn2) To 1 Step -1
                If Mid(ChrsIn2, IdX2, 1) = "\" Then
                    ChrsOut2 = Mid(ChrsIn2, IdX2 + 1)
                    Exit For
                End If
            Next IdX2
        ElseIf InStr(ChrsIn2, ":") = 2 Then
            ChrsOut2 = Mid(ChrsIn2, 3)
        Else
            ChrsOut2 = ChrsIn2
        End If
        StrSacaValoresString2 = ChrsOut2
        Exit Function

StrSacaValoresString_General_ErrTrap2:
        MsgBox("Error: " & Err.Number & " - Procedimiento: StrSacaValoresString" & vbCrLf & Err.Description, vbExclamation + vbOKOnly, "AVISO DE ERROR")
    End Function

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object)
        'Copia archivo a la carpeta creada en el proyecto
        Dim strm As System.IO.Stream = OpenFileDialog1.OpenFile()
        Dim cadena As String = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase).Remove(0, 6)
        'Obtiene la ruta del direcotiro donde esta el proyecto

        Dim Source As String
        Dim archivo As String
        Dim Destination As String
        Source = OpenFileDialog1.FileName.ToString()
        'Obtiene el nombre completo de la ruta donde esta el archivo que vamos a copiar
        archivo = StrSacaValoresString(Source)
        'Obtiene el nombre del archivo
        Destination = cadena + "\Fotos\" + archivo
        'Es la carpeta destino donde voy a copiar los archivos
        'BTFoto.Text = Destination
    End Sub
    Function StrSacaValoresString(ByVal RutaPathFichero As String) As String
        'Esta funcion obtiene el nombre del aricho que selecciono
        Dim ChrsIn As String, ChrsOut As String = 0, IdX As Integer, Chrs As Integer
        On Error GoTo StrSacaValoresString_General_ErrTrap

        If RutaPathFichero = "" Then MsgBox("Debe seleccionar un archivo")
        ChrsIn = RutaPathFichero
        'Devuelve el nombre del fichero original
        If InStr(ChrsIn, "\") Then
            For IdX = Len(ChrsIn) To 1 Step -1
                If Mid(ChrsIn, IdX, 1) = "\" Then
                    ChrsOut = Mid(ChrsIn, IdX + 1)
                    Exit For
                End If
            Next IdX
        ElseIf InStr(ChrsIn, ":") = 2 Then
            ChrsOut = Mid(ChrsIn, 3)
        Else
            ChrsOut = ChrsIn
        End If
        StrSacaValoresString = ChrsOut
        Exit Function

StrSacaValoresString_General_ErrTrap:
        MsgBox("Error: " & Err.Number & " - Procedimiento: StrSacaValoresString" & vbCrLf & Err.Description, vbExclamation + vbOKOnly, "AVISO DE ERROR")
    End Function

    Private Sub CBcategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBcategoria.SelectedIndexChanged
        If CBcategoria.SelectedItem = "1 - Cat1" Then
            idcategoria = 1
        ElseIf CBcategoria.SelectedItem = "2 - Cat2" Then
            idcategoria = 2
        ElseIf CBcategoria.SelectedItem = "3 - Cat3" Then
            idcategoria = 3
        End If
    End Sub

    Private Sub CBEliminado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEliminado.SelectedIndexChanged
        If CBEliminado.SelectedItem = "NO" Then
            ideliminado = "no"
        ElseIf CBEliminado.SelectedItem = "SI" Then
            ideliminado = "si"
        End If
    End Sub

    Private Sub ProductosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellClick
        Dim dtgp As DataGridViewRow = ProductosDataGridView.Rows(e.RowIndex)


        ' Fomu de modificar
        Id_productoTextBox2.Text = dtgp.Cells(0).Value.ToString
        DescripcionTextBox2.Text = dtgp.Cells(1).Value.ToString
        CBcategoria2.SelectedIndex = dtgp.Cells(2).Value - 1
        Precio_costoTextBox2.Text = dtgp.Cells(3).Value.ToString
        Precio_ventaTextBox2.Text = dtgp.Cells(4).Value.ToString
        StockTextBox2.Text = dtgp.Cells(5).Value.ToString
        Stock_minTextBox2.Text = dtgp.Cells(6).Value.ToString
        CBEliminado2.Text = dtgp.Cells(7).Value.ToString
        ImagenTextBox2.Text = dtgp.Cells(8).Value.ToString

        If (ImagenTextBox2.Text <> "") Then
            PictureBox2.Image = Image.FromFile(ImagenTextBox2.Text)
        Else
            PictureBox2.Image = Nothing
            PictureBox2.BackgroundImage = Nothing
        End If

    End Sub

    Private Sub BFoto2_Click(sender As Object, e As EventArgs) Handles BFoto2.Click
        PictureBox2.Image = Nothing
        PictureBox2.BackgroundImage = Nothing
        'Filtrar archivos de imagenes para que el usuario no elija otro tipo de archivos
        OpenFileDialog2.Filter = "Archivos Imagenes|*.jpg|Archivos Imagenes|*.bmp|Archivos Imagenes|*.png"

        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            OpenFileDialog2_FileOk(Image.FromFile(OpenFileDialog2.FileName))
            PictureBox2.BackgroundImage = Image.FromFile(OpenFileDialog2.FileName)
            'BTFoto.Text = OpenFileDialog1.FileName
            ImagenTextBox2.Text = OpenFileDialog2.FileName
        End If
    End Sub

    Private Sub Grabarmodificar_Click(sender As Object, e As EventArgs) Handles Grabarmodificar.Click
        BTCancelar.Visible = True
        ' Defina el mensaje que desea ver dentro del cuadro de mensaje.
        Dim msg = "¿Desea modificar el producto?"

        ' Muestre un cuadro de mensaje simple.
        'MsgBox(msg)

        ' Defina un título para el cuadro de mensaje.
        Dim title = "Modificar Productos"

        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                    MsgBoxStyle.Information
        'Muestre el cuadro de mensaje y guarde la respuesta, Sí o No.
        Dim ask = MsgBox(msg, style, title)

        ' Tome alguna acción basada en la respuesta.
        If ask = MsgBoxResult.Yes Then
            If (DescripcionTextBox2.Text <> "" And CBcategoria2.Text <> "" And Precio_costoTextBox2.Text <> "" And Precio_ventaTextBox2.Text <> "" And StockTextBox2.Text <> "" And Stock_minTextBox2.Text <> "" And CBEliminado2.Text <> "") Then
                Dim actualizar As String = "descripcion= '" & DescripcionTextBox2.Text & "',id_categoria= " & idcategoria2 & ",precio_costo= " & Precio_costoTextBox2.Text & ",precio_venta= " & Precio_ventaTextBox2.Text & ",stock= " & StockTextBox2.Text & ",stock_min= " & Stock_minTextBox2.Text & ",imagen= '" & ImagenTextBox2.Text & "',eliminado= '" & ideliminado2 & "'"
                If (Conexion.modificar_productos("productos", actualizar, "id_producto=" & Id_productoTextBox2.Text)) Then
                    MsgBox("Se modifico correctamente producto: " & Id_productoTextBox2.Text)
                    MostrarDatos()
                    Label2.Text = "Productos Activos"
                    PanelNuevo.Visible = False

                    PanelModificar.Visible = False
                    PanelMostrartodos.Visible = True

                Else
                    MsgBox("Error al agregar producto")
                End If
            Else
                MsgBox("Debe completar todas las opciones.", MsgBoxStyle.Critical)
            End If
        Else

        End If
    End Sub

    Private Sub CBcategoria2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBcategoria2.SelectedIndexChanged
        If CBcategoria2.SelectedItem = "1 - Cat1" Then
            idcategoria2 = 1
        ElseIf CBcategoria2.SelectedItem = "2 - Cat2" Then
            idcategoria2 = 2
        ElseIf CBcategoria2.SelectedItem = "3 - Cat3" Then
            idcategoria2 = 3
        End If
    End Sub

    Private Sub CBEliminado2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEliminado2.SelectedIndexChanged
        If CBEliminado2.SelectedItem = "NO" Then
            ideliminado2 = "no"
        ElseIf CBEliminado2.SelectedItem = "SI" Then
            ideliminado2 = "si"
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged
        If (nro_prod.Checked) Then
            campo = "id_producto"
        Else
            campo = "descripcion"
        End If
        obj.consultaDinamica(TextBoxBuscar.Text, campo, ProductosDataGridView)
    End Sub

    Private Sub BTInactivo_Click(sender As Object, e As EventArgs) Handles BTInactivo.Click
        Label2.Text = "Productos Inactivos"
        MostrarDatosInactivos()
        PanelMostrartodos.Visible = True
        BTCancelar.Visible = True
        PanelBotones.Visible = False
        PanelNuevo.Visible = False
        BTActivos.Visible = True
        BTInactivo.Visible = False

    End Sub

    Private Sub BTActivos_Click(sender As Object, e As EventArgs) Handles BTActivos.Click
        Label2.Text = "Productos Activos"
        BTCancelar.Visible = True
        MostrarDatos()
        PanelMostrartodos.Visible = True
        PanelBotones.Visible = False
        PanelNuevo.Visible = False
        BTInactivo.Visible = True
        BTActivos.Visible = False


    End Sub

    Public Sub soloNumeros(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890" ' allowed In textbox
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub soloNumerosYPunto(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890." ' allowed In textbox
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub StockTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StockTextBox.KeyPress
        Call soloNumerosYPunto(StockTextBox, e)
    End Sub


    Private Sub Stock_minTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Stock_minTextBox.KeyPress
        Call soloNumerosYPunto(Stock_minTextBox, e)
    End Sub

    Private Sub Precio_ventaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Precio_ventaTextBox.KeyPress
        Call soloNumerosYPunto(Precio_ventaTextBox, e)
    End Sub

    Private Sub Precio_costoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Precio_costoTextBox.KeyPress
        Call soloNumerosYPunto(Precio_costoTextBox, e)
    End Sub

    Private Sub StockTextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StockTextBox2.KeyPress
        Call soloNumerosYPunto(StockTextBox2, e)
    End Sub

    Private Sub Stock_minTextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Stock_minTextBox2.KeyPress
        Call soloNumerosYPunto(Stock_minTextBox2, e)
    End Sub

    Private Sub Precio_costoTextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Precio_costoTextBox2.KeyPress
        Call soloNumerosYPunto(Precio_costoTextBox2, e)
    End Sub

    Private Sub Precio_ventaTextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Precio_ventaTextBox2.KeyPress
        Call soloNumerosYPunto(Precio_ventaTextBox2, e)
    End Sub

    Private Sub BTCategoria_Click(sender As Object, e As EventArgs) 
        Dim newcatProductos As New catProd
        'newcatProductos.MdiParent = Me
        newcatProductos.Show()

    End Sub

    Private Sub ImagenTextBox_TextChanged(sender As Object, e As EventArgs) Handles ImagenTextBox.TextChanged

    End Sub

    Private Sub ProductosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick

    End Sub
End Class