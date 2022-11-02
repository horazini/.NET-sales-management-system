Public Class gestionFacturas
    Dim Total As Decimal
    Dim c1, s2 As Int32
    Dim nuevostock As Decimal
    Dim bandera = 0
    Dim obj As New ConsultaDatos
    Dim campo As String = ""
    Dim Id_factura_seleccionada As String = ""

    Private Sub gestionFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comprar.Visible = False
        'TODO: esta línea de código carga datos en la tabla 'BaseDataSet.Ventas_cabecera' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'BaseDataSet.Ventas_detalle' Puede moverla o quitarla según sea necesario.
        'Me.Ventas_detalleTableAdapter.Fill(Me.BaseDataSet.Ventas_detalle)
        'TODO: esta línea de código carga datos en la tabla 'BaseDataSet.Productos' Puede moverla o quitarla según sea necesario.
        'Me.ProductosTableAdapter.Fill(Me.BaseDataSet.Productos)
        MostrarDatos()
        desc_prod.Checked = True
        'TODO: esta línea de código carga datos en la tabla 'BaseDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        'Me.ClientesTableAdapter.Fill(Me.BaseDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'BaseDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        'Me.ClientesTableAdapter.Fill(Me.BaseDataSet.Clientes)
        PanelNuevo.Visible = False
        PanelMostrarTodos.Visible = False
        PanelMostrarTodosF.Visible = False
        BTvolver.Visible = False
        cancelar.Visible = False
    End Sub

    Private Sub Bagregar_Click(sender As Object, e As EventArgs) Handles Bagregar.Click
        PanelNuevo.Visible = True
        BTvolver.Visible = True
        PanelBotones.Visible = False
        BTvolver.Visible = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub seleccionar1_Click(sender As Object, e As EventArgs) Handles seleccionar1.Click
        PanelMostrarTodos.Visible = True
        PanelNuevo.Visible = False
        MostrarDatosClientes()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles seleccionar1.Click
        PanelMostrarTodos.Visible = True
        PanelNuevo.Visible = False
        MostrarDatosFacturas()
    End Sub

    Private Sub Bmostrar_Click(sender As Object, e As EventArgs) Handles Bmostrar.Click
        PanelMostrarTodosF.Visible = True
        PanelBotones.Visible = False
        MostrarDatosFacturas()
    End Sub

    ' Para mostrar todos los clientes
    Public Sub MostrarDatosClientes()
        Conexion.consulta_clientes("Select * from clientes where eliminado='no'", "clientes")
        ClientesDataGridView.DataSource = Conexion.ds.Tables("clientes")
    End Sub

    ' Para mostrar todos los productos
    Public Sub MostrarDatos()
        Conexion.consulta_productos("Select * from productos where eliminado='no'", "productos")
        ProductosDataGridView.DataSource = Conexion.ds.Tables("productos")
    End Sub

    ' Para mostrar todos las ventas
    Public Sub MostrarDatosFacturas()
        Conexion.consulta_ventas_cabecera("Select * from ventas_cabecera where eliminado='no'", "ventas")
        FacturasDataGridView.DataSource = Conexion.ds.Tables("ventas")
    End Sub


    Private Sub BTvolver_Click(sender As Object, e As EventArgs) Handles BTvolver.Click
        PanelMostrarTodos.Visible = False
        PanelNuevo.Visible = False
        PanelBotones.Visible = True
        BTvolver.Visible = False
    End Sub

    Private Sub Bseleccionar_Click(sender As Object, e As EventArgs) Handles Bseleccionar.Click
        PanelMostrarTodos.Visible = False
        PanelNuevo.Visible = True
    End Sub

    Private Sub ClientesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClientesDataGridView.CellClick
        Dim dtgp As DataGridViewRow = ClientesDataGridView.Rows(e.RowIndex)
        TBCli.Text = dtgp.Cells(0).Value.ToString
        TBdni.Text = dtgp.Cells(1).Value.ToString
        TBapeynom.Text = dtgp.Cells(2).Value.ToString + " " + dtgp.Cells(3).Value.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles seleccionar2.Click
        If TBapeynom.Text = "" Then
            MsgBox("Ingrese un cliente", vbCritical)
            seleccionar2.Focus()
        Else
            PanelMostrarTodosP.Visible = True
            PanelNuevo.Visible = False
            PanelMostrarTodos.Visible = False
            CantP.Focus()
            MostrarDatos()
        End If
    End Sub


    Private Sub ProductosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellClick
        Dim dtgp As DataGridViewRow = ProductosDataGridView.Rows(e.RowIndex)
        Prod.Text = dtgp.Cells(1).Value.ToString
        Idprod.Text = dtgp.Cells(0).Value.ToString
        Preciop.Text = dtgp.Cells(4).Value.ToString
        stk.Text = dtgp.Cells(5).Value.ToString
    End Sub

    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        cancelar.Visible = True
        BTvolver.Visible = False
        seleccionar1.Enabled = False
        MostrarDatos()
        Double.TryParse(CantP.Text, c1)
        Double.TryParse(stk.Text, s2)
        Dim yy = 0
        If c1 <= 0 Then
            MsgBox("Ingrese una cantidad", vbCritical)
            yy = 1
            CantP.Focus()
        End If
        If Prod.Text = "" Then
            MsgBox("Ingrese un producto", vbCritical)
            seleccionar2.Focus()
        Else
            'MsgBox(CantP.Text + "-" + stk.Text)
            Dim subtotal As Decimal
            Dim subtotal2 As Decimal
            Dim subtotal3 As Decimal
            Dim xx = 0

            For Each Fila As DataGridViewRow In DetallesDataGrid.Rows
                If Not Fila Is Nothing Then
                    If Fila.Cells(0).Value = Idprod.Text Then
                        'repetido
                        c1 = c1 + Fila.Cells(2).Value
                    End If
                End If
            Next

            If (c1 <= s2) Then
                If DetallesDataGrid.Rows.Count > 0 Then
                    For Each Fila As DataGridViewRow In DetallesDataGrid.Rows
                        If Not Fila Is Nothing Then
                            If Fila.Cells(0).Value = Idprod.Text Then
                                'repetido
                                xx = 1
                                MsgBox("Agrego " + CantP.Text + " unidades más de " + Fila.Cells(1).Value)
                                CantP.Text = ""
                                Prod.Text = ""
                                Idprod.Text = ""
                                stk.Text = ""
                                Preciop.Text = ""
                                'Fila.Cells(2).Value = c1 + Fila.Cells(2).Value
                                Fila.Cells(2).Value = c1
                                subtotal2 = Fila.Cells(2).Value * Fila.Cells(3).Value
                                Fila.Cells(4).Value = subtotal2
                            End If
                        End If
                    Next
                End If

                If (xx = 0) Then
                    subtotal = c1 * Preciop.Text
                    subtotal3 = subtotal2 + subtotal
                    If (yy = 0) Then
                        DetallesDataGrid.Rows.Add(Idprod.Text, Prod.Text, CantP.Text, Preciop.Text, subtotal3, stk.Text, "Eliminar")
                        comprar.Visible = True
                        CantP.Text = ""
                        Prod.Text = ""
                        Idprod.Text = ""
                        stk.Text = ""
                        Preciop.Text = ""
                    End If
                End If

                Total = DetallesDataGrid.Rows.Cast(Of DataGridViewRow).Sum(Function(x) Convert.ToDecimal(x.Cells("subtotal").Value))

                Me.Label8.Text = Total.ToString
            Else
                MsgBox("Solo quedan " + stk.Text + " de " + Prod.Text, vbCritical)
                CantP.Focus()
            End If
        End If
    End Sub

    Private Sub DetallesDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DetallesDataGrid.CellContentClick
        If e.ColumnIndex = 6 Then
            Dim answer As Integer = MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)
            If answer = DialogResult.Yes Then
                Dim subtotal As Decimal
                subtotal = DetallesDataGrid.Rows(e.RowIndex).Cells("subtotal").Value

                Total = DetallesDataGrid.Rows.Cast(Of DataGridViewRow).Sum(Function(x) Convert.ToDecimal(x.Cells("subtotal").Value))
                Total = Total - subtotal
                Me.Label8.Text = Total.ToString
                DetallesDataGrid.Rows.RemoveAt(e.RowIndex)
            End If
        End If
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

    Private Sub CantP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CantP.KeyPress
        Call soloNumeros(CantP, e)
    End Sub

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Prod.Text = ""
        Idprod.Text = ""
        Preciop.Text = ""
        TBdni.Text = ""
        TBapeynom.Text = ""
        CantP.Text = ""
        Label8.Text = "-"
        seleccionar1.Enabled = True
        Total = 0
        DetallesDataGrid.Rows.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar2.TextChanged
        If (nro_prod.Checked) Then
            campo = "id_producto"
        Else
            campo = "descripcion"
        End If
        obj.consultaDinamica(TextBoxBuscar2.Text, campo, ProductosDataGridView)
    End Sub

    Private Sub PanelNuevo_Paint(sender As Object, e As PaintEventArgs) Handles PanelNuevo.Paint

    End Sub

    Private Sub comprar_Click(sender As Object, e As EventArgs) Handles comprar.Click
        ' Defina el mensaje que desea ver dentro del cuadro de mensaje.
        Dim msg = "¿Desea confirma la compra?"

        ' Muestre un cuadro de mensaje simple.
        'MsgBox(msg)

        ' Defina un título para el cuadro de mensaje.
        Dim title = "Confirmar Compra"

        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                    MsgBoxStyle.Information
        'Muestre el cuadro de mensaje y guarde la respuesta, Sí o No.
        Dim ask = MsgBox(msg, style, title)

        ' Tome alguna acción basada en la respuesta.
        If ask = MsgBoxResult.Yes Then
            If (CantP.Text = "") Then
                ConsultarUltimaVenta()
                Dim agregarcabecera As String = "insert into Ventas_cabecera values (" & idusuario & "," & TBCli.Text & ",'" & DateTimePicker1.Value.ToString("MM/dd/yyyy") & "'," & CambiaComaPorPunto(Total) & "," & nroventaAux & ",'no')"
                If (Conexion.insertar_ventas_cabecera(agregarcabecera)) Then
                Else
                    MsgBox("Error al guardar la compra.")
                End If
                'MsgBox(Me.DetallesDataGrid.Rows)

                For Each row2 As DataGridViewRow In Me.DetallesDataGrid.Rows
                    Dim agregardetalle As String = "insert into Ventas_detalle values (" & nroventaAux & "," & row2.Cells(0).Value.ToString & "," & CambiaComaPorPunto(row2.Cells(2).Value.ToString) & "," & CambiaComaPorPunto(row2.Cells(4).Value.ToString) & ",'no')"
                    If (Conexion.insertar_ventas_detalle(agregardetalle)) Then
                        nuevostock = row2.Cells(5).Value.ToString - row2.Cells(2).Value.ToString
                        'Actualizo stock
                        Dim actualizar As String = "stock= " & nuevostock
                        If (Conexion.modificar_productos("productos", actualizar, "id_producto=" & row2.Cells(0).Value.ToString)) Then
                            bandera = 1
                        Else
                            MsgBox("Error al Registrar la Venta.")
                        End If
                    Else
                        MsgBox("Error al guardar la compra.")
                    End If
                Next

                If (bandera = 1) Then
                    MsgBox("Venta Registrada.")
                    Prod.Text = ""
                    Idprod.Text = ""
                    Preciop.Text = ""
                    TBdni.Text = ""
                    TBapeynom.Text = ""
                    CantP.Text = ""
                    Label8.Text = "-"
                    seleccionar1.Enabled = True
                    Total = 0
                    DetallesDataGrid.Rows.Clear()
                    Dim cr As New rpComprobante_de_pago
                    Dim R As New Comprobante_de_pago
                    R.rpComprobante.ReportSource = cr
                    cr.SetParameterValue("@venta", nroventaAux)
                    R.rpComprobante.ReportSource = cr
                    R.ShowDialog()
                Else
                End If

            Else
                MsgBox("Debe completar todas las opciones.", MsgBoxStyle.Critical)
            End If
        Else
        End If
    End Sub


    ''''''''''''''''''''''''''''''''''''''''''''''''''''


    Private Sub FacturasDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FacturasDataGridView.CellClick
        Dim dtgp As DataGridViewRow = FacturasDataGridView.Rows(e.RowIndex)

        Id_factura_seleccionada = dtgp.Cells(0).Value.ToString

    End Sub

    Private Sub BSeleccionar2_Click(sender As Object, e As EventArgs) Handles BSeleccionar2.Click
        Dim cr As New rpComprobante_de_pago
        Dim R As New Comprobante_de_pago
        R.rpComprobante.ReportSource = cr
        cr.SetParameterValue("@venta", Id_factura_seleccionada)
        R.rpComprobante.ReportSource = cr
        R.ShowDialog()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles BSeleccionarProducto.Click
        PanelMostrarTodosP.Visible = False
        PanelNuevo.Visible = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        PanelMostrarTodosF.Visible = False
        PanelBotones.Visible = True
    End Sub

End Class