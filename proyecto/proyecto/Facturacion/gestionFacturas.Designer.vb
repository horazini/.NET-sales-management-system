<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gestionFacturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestionFacturas))
        Me.BTvolver = New System.Windows.Forms.Button()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Bagregar = New System.Windows.Forms.Button()
        Me.Bmostrar = New System.Windows.Forms.Button()
        Me.PanelNuevo = New System.Windows.Forms.Panel()
        Me.TBCli = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.comprar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.stk = New System.Windows.Forms.TextBox()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.Preciop = New System.Windows.Forms.TextBox()
        Me.Idprod = New System.Windows.Forms.TextBox()
        Me.agregar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBdni = New System.Windows.Forms.TextBox()
        Me.CantP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Prod = New System.Windows.Forms.TextBox()
        Me.seleccionar2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DetallesDataGrid = New System.Windows.Forms.DataGridView()
        Me.idprodu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBapeynom = New System.Windows.Forms.TextBox()
        Me.seleccionar1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMostrarTodos = New System.Windows.Forms.Panel()
        Me.apecliente = New System.Windows.Forms.RadioButton()
        Me.dnicli = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdclienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechanacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EliminadoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseDataSet = New proyecto.BaseDataSet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Bseleccionar = New System.Windows.Forms.Button()
        Me.ClientesTableAdapter = New proyecto.BaseDataSetTableAdapters.ClientesTableAdapter()
        Me.PanelMostrarTodosF = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BSeleccionar2 = New System.Windows.Forms.Button()
        Me.desc_prod = New System.Windows.Forms.RadioButton()
        Me.nro_prod = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxBuscar2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FacturasDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdventaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdusuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdclienteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaventaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalventaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroventaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentascabeceraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New proyecto.BaseDataSetTableAdapters.ProductosTableAdapter()
        Me.VentasdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ventas_detalleTableAdapter = New proyecto.BaseDataSetTableAdapters.Ventas_detalleTableAdapter()
        Me.Ventas_cabeceraTableAdapter = New proyecto.BaseDataSetTableAdapters.Ventas_cabeceraTableAdapter()
        Me.PanelMostrarTodosP = New System.Windows.Forms.Panel()
        Me.BSeleccionarProducto = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciocostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioventaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImagenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelBotones.SuspendLayout()
        Me.PanelNuevo.SuspendLayout()
        CType(Me.DetallesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMostrarTodos.SuspendLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMostrarTodosF.SuspendLayout()
        CType(Me.FacturasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentascabeceraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMostrarTodosP.SuspendLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTvolver
        '
        Me.BTvolver.Location = New System.Drawing.Point(43, 39)
        Me.BTvolver.Name = "BTvolver"
        Me.BTvolver.Size = New System.Drawing.Size(75, 23)
        Me.BTvolver.TabIndex = 65
        Me.BTvolver.Text = "Volver"
        Me.BTvolver.UseVisualStyleBackColor = True
        '
        'PanelBotones
        '
        Me.PanelBotones.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelBotones.Controls.Add(Me.Label11)
        Me.PanelBotones.Controls.Add(Me.Bagregar)
        Me.PanelBotones.Controls.Add(Me.Bmostrar)
        Me.PanelBotones.Location = New System.Drawing.Point(257, 48)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(300, 100)
        Me.PanelBotones.TabIndex = 64
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(94, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 25)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Facturas"
        '
        'Bagregar
        '
        Me.Bagregar.Location = New System.Drawing.Point(40, 34)
        Me.Bagregar.Name = "Bagregar"
        Me.Bagregar.Size = New System.Drawing.Size(75, 23)
        Me.Bagregar.TabIndex = 48
        Me.Bagregar.Text = "Nueva"
        Me.Bagregar.UseVisualStyleBackColor = True
        '
        'Bmostrar
        '
        Me.Bmostrar.Location = New System.Drawing.Point(160, 34)
        Me.Bmostrar.Name = "Bmostrar"
        Me.Bmostrar.Size = New System.Drawing.Size(131, 23)
        Me.Bmostrar.TabIndex = 54
        Me.Bmostrar.Text = "Mostrar Facturas"
        Me.Bmostrar.UseVisualStyleBackColor = True
        '
        'PanelNuevo
        '
        Me.PanelNuevo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelNuevo.Controls.Add(Me.TBCli)
        Me.PanelNuevo.Controls.Add(Me.Label9)
        Me.PanelNuevo.Controls.Add(Me.DateTimePicker1)
        Me.PanelNuevo.Controls.Add(Me.comprar)
        Me.PanelNuevo.Controls.Add(Me.Label8)
        Me.PanelNuevo.Controls.Add(Me.Label7)
        Me.PanelNuevo.Controls.Add(Me.stk)
        Me.PanelNuevo.Controls.Add(Me.cancelar)
        Me.PanelNuevo.Controls.Add(Me.Preciop)
        Me.PanelNuevo.Controls.Add(Me.Idprod)
        Me.PanelNuevo.Controls.Add(Me.agregar)
        Me.PanelNuevo.Controls.Add(Me.Label5)
        Me.PanelNuevo.Controls.Add(Me.TBdni)
        Me.PanelNuevo.Controls.Add(Me.CantP)
        Me.PanelNuevo.Controls.Add(Me.Label4)
        Me.PanelNuevo.Controls.Add(Me.Prod)
        Me.PanelNuevo.Controls.Add(Me.seleccionar2)
        Me.PanelNuevo.Controls.Add(Me.Label3)
        Me.PanelNuevo.Controls.Add(Me.DetallesDataGrid)
        Me.PanelNuevo.Controls.Add(Me.Label2)
        Me.PanelNuevo.Controls.Add(Me.TBapeynom)
        Me.PanelNuevo.Controls.Add(Me.seleccionar1)
        Me.PanelNuevo.Controls.Add(Me.Label1)
        Me.PanelNuevo.Location = New System.Drawing.Point(43, 68)
        Me.PanelNuevo.Name = "PanelNuevo"
        Me.PanelNuevo.Size = New System.Drawing.Size(740, 352)
        Me.PanelNuevo.TabIndex = 66
        '
        'TBCli
        '
        Me.TBCli.Location = New System.Drawing.Point(32, 112)
        Me.TBCli.Name = "TBCli"
        Me.TBCli.Size = New System.Drawing.Size(100, 20)
        Me.TBCli.TabIndex = 90
        Me.TBCli.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Fecha"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(97, 57)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 88
        '
        'comprar
        '
        Me.comprar.Location = New System.Drawing.Point(587, 311)
        Me.comprar.Name = "comprar"
        Me.comprar.Size = New System.Drawing.Size(75, 23)
        Me.comprar.TabIndex = 87
        Me.comprar.Text = "Comprar"
        Me.comprar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(449, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 25)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(358, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 25)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "TOTAL"
        '
        'stk
        '
        Me.stk.Location = New System.Drawing.Point(301, 151)
        Me.stk.Name = "stk"
        Me.stk.Size = New System.Drawing.Size(100, 20)
        Me.stk.TabIndex = 84
        Me.stk.Visible = False
        '
        'cancelar
        '
        Me.cancelar.Location = New System.Drawing.Point(628, 28)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cancelar.TabIndex = 83
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'Preciop
        '
        Me.Preciop.Location = New System.Drawing.Point(174, 151)
        Me.Preciop.Name = "Preciop"
        Me.Preciop.Size = New System.Drawing.Size(100, 20)
        Me.Preciop.TabIndex = 82
        Me.Preciop.Visible = False
        '
        'Idprod
        '
        Me.Idprod.Location = New System.Drawing.Point(51, 151)
        Me.Idprod.Name = "Idprod"
        Me.Idprod.Size = New System.Drawing.Size(100, 20)
        Me.Idprod.TabIndex = 81
        Me.Idprod.Visible = False
        '
        'agregar
        '
        Me.agregar.Location = New System.Drawing.Point(612, 132)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(75, 23)
        Me.agregar.TabIndex = 80
        Me.agregar.Text = "Agregar"
        Me.agregar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "DNI:"
        '
        'TBdni
        '
        Me.TBdni.Enabled = False
        Me.TBdni.Location = New System.Drawing.Point(97, 95)
        Me.TBdni.Name = "TBdni"
        Me.TBdni.Size = New System.Drawing.Size(100, 20)
        Me.TBdni.TabIndex = 78
        '
        'CantP
        '
        Me.CantP.Location = New System.Drawing.Point(447, 132)
        Me.CantP.Name = "CantP"
        Me.CantP.Size = New System.Drawing.Size(124, 20)
        Me.CantP.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(388, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Unidades:"
        '
        'Prod
        '
        Me.Prod.Enabled = False
        Me.Prod.Location = New System.Drawing.Point(97, 132)
        Me.Prod.Name = "Prod"
        Me.Prod.ReadOnly = True
        Me.Prod.Size = New System.Drawing.Size(164, 20)
        Me.Prod.TabIndex = 75
        '
        'seleccionar2
        '
        Me.seleccionar2.Location = New System.Drawing.Point(267, 130)
        Me.seleccionar2.Name = "seleccionar2"
        Me.seleccionar2.Size = New System.Drawing.Size(75, 23)
        Me.seleccionar2.TabIndex = 74
        Me.seleccionar2.Text = "Seleccionar"
        Me.seleccionar2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Producto:"
        '
        'DetallesDataGrid
        '
        Me.DetallesDataGrid.AllowUserToAddRows = False
        Me.DetallesDataGrid.AllowUserToDeleteRows = False
        Me.DetallesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetallesDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idprodu, Me.descP, Me.cant, Me.precio, Me.subtotal, Me.stock, Me.Eliminar})
        Me.DetallesDataGrid.Location = New System.Drawing.Point(66, 169)
        Me.DetallesDataGrid.Name = "DetallesDataGrid"
        Me.DetallesDataGrid.ReadOnly = True
        Me.DetallesDataGrid.Size = New System.Drawing.Size(633, 126)
        Me.DetallesDataGrid.TabIndex = 69
        '
        'idprodu
        '
        Me.idprodu.HeaderText = "ID.Prod."
        Me.idprodu.Name = "idprodu"
        Me.idprodu.ReadOnly = True
        '
        'descP
        '
        Me.descP.HeaderText = "Producto"
        Me.descP.Name = "descP"
        Me.descP.ReadOnly = True
        '
        'cant
        '
        Me.cant.HeaderText = "Cant."
        Me.cant.Name = "cant"
        Me.cant.ReadOnly = True
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
        Me.stock.Visible = False
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(249, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 25)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Nueva Factura"
        '
        'TBapeynom
        '
        Me.TBapeynom.Enabled = False
        Me.TBapeynom.Location = New System.Drawing.Point(251, 95)
        Me.TBapeynom.Name = "TBapeynom"
        Me.TBapeynom.ReadOnly = True
        Me.TBapeynom.Size = New System.Drawing.Size(164, 20)
        Me.TBapeynom.TabIndex = 67
        '
        'seleccionar1
        '
        Me.seleccionar1.Location = New System.Drawing.Point(421, 93)
        Me.seleccionar1.Name = "seleccionar1"
        Me.seleccionar1.Size = New System.Drawing.Size(75, 23)
        Me.seleccionar1.TabIndex = 66
        Me.seleccionar1.Text = "Seleccionar"
        Me.seleccionar1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        '
        'PanelMostrarTodos
        '
        Me.PanelMostrarTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelMostrarTodos.Controls.Add(Me.apecliente)
        Me.PanelMostrarTodos.Controls.Add(Me.dnicli)
        Me.PanelMostrarTodos.Controls.Add(Me.Label15)
        Me.PanelMostrarTodos.Controls.Add(Me.TextBoxBuscar)
        Me.PanelMostrarTodos.Controls.Add(Me.ClientesDataGridView)
        Me.PanelMostrarTodos.Controls.Add(Me.Label12)
        Me.PanelMostrarTodos.Controls.Add(Me.Bseleccionar)
        Me.PanelMostrarTodos.Location = New System.Drawing.Point(27, 82)
        Me.PanelMostrarTodos.Name = "PanelMostrarTodos"
        Me.PanelMostrarTodos.Size = New System.Drawing.Size(766, 254)
        Me.PanelMostrarTodos.TabIndex = 67
        '
        'apecliente
        '
        Me.apecliente.AutoSize = True
        Me.apecliente.Location = New System.Drawing.Point(187, 43)
        Me.apecliente.Name = "apecliente"
        Me.apecliente.Size = New System.Drawing.Size(62, 17)
        Me.apecliente.TabIndex = 64
        Me.apecliente.TabStop = True
        Me.apecliente.Text = "Apellido"
        Me.apecliente.UseVisualStyleBackColor = True
        '
        'dnicli
        '
        Me.dnicli.AutoSize = True
        Me.dnicli.Location = New System.Drawing.Point(137, 43)
        Me.dnicli.Name = "dnicli"
        Me.dnicli.Size = New System.Drawing.Size(44, 17)
        Me.dnicli.TabIndex = 63
        Me.dnicli.TabStop = True
        Me.dnicli.Text = "Dni."
        Me.dnicli.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(31, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Buscar"
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(31, 43)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBuscar.TabIndex = 61
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AllowUserToAddRows = False
        Me.ClientesDataGridView.AllowUserToDeleteRows = False
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdclienteDataGridViewTextBoxColumn, Me.DniDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.FechanacDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.EliminadoDataGridViewImageColumn})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(13, 81)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.ReadOnly = True
        Me.ClientesDataGridView.Size = New System.Drawing.Size(736, 150)
        Me.ClientesDataGridView.TabIndex = 60
        '
        'IdclienteDataGridViewTextBoxColumn
        '
        Me.IdclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente"
        Me.IdclienteDataGridViewTextBoxColumn.HeaderText = "ID."
        Me.IdclienteDataGridViewTextBoxColumn.Name = "IdclienteDataGridViewTextBoxColumn"
        Me.IdclienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DniDataGridViewTextBoxColumn
        '
        Me.DniDataGridViewTextBoxColumn.DataPropertyName = "dni"
        Me.DniDataGridViewTextBoxColumn.HeaderText = "DNI."
        Me.DniDataGridViewTextBoxColumn.Name = "DniDataGridViewTextBoxColumn"
        Me.DniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechanacDataGridViewTextBoxColumn
        '
        Me.FechanacDataGridViewTextBoxColumn.DataPropertyName = "fecha_nac"
        Me.FechanacDataGridViewTextBoxColumn.HeaderText = "F.Nac."
        Me.FechanacDataGridViewTextBoxColumn.Name = "FechanacDataGridViewTextBoxColumn"
        Me.FechanacDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EliminadoDataGridViewImageColumn
        '
        Me.EliminadoDataGridViewImageColumn.DataPropertyName = "eliminado"
        Me.EliminadoDataGridViewImageColumn.HeaderText = "eliminado"
        Me.EliminadoDataGridViewImageColumn.Name = "EliminadoDataGridViewImageColumn"
        Me.EliminadoDataGridViewImageColumn.ReadOnly = True
        Me.EliminadoDataGridViewImageColumn.Visible = False
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BaseDataSet
        '
        'BaseDataSet
        '
        Me.BaseDataSet.DataSetName = "BaseDataSet"
        Me.BaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(341, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(208, 25)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Todos los Clientes"
        '
        'Bseleccionar
        '
        Me.Bseleccionar.Location = New System.Drawing.Point(674, 38)
        Me.Bseleccionar.Name = "Bseleccionar"
        Me.Bseleccionar.Size = New System.Drawing.Size(75, 23)
        Me.Bseleccionar.TabIndex = 50
        Me.Bseleccionar.Text = "Seleccionar"
        Me.Bseleccionar.UseVisualStyleBackColor = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'PanelMostrarTodosF
        '
        Me.PanelMostrarTodosF.BackColor = System.Drawing.SystemColors.Info
        Me.PanelMostrarTodosF.Controls.Add(Me.Button1)
        Me.PanelMostrarTodosF.Controls.Add(Me.BSeleccionar2)
        Me.PanelMostrarTodosF.Controls.Add(Me.desc_prod)
        Me.PanelMostrarTodosF.Controls.Add(Me.nro_prod)
        Me.PanelMostrarTodosF.Controls.Add(Me.Label14)
        Me.PanelMostrarTodosF.Controls.Add(Me.TextBoxBuscar2)
        Me.PanelMostrarTodosF.Controls.Add(Me.Label6)
        Me.PanelMostrarTodosF.Controls.Add(Me.FacturasDataGridView)
        Me.PanelMostrarTodosF.Location = New System.Drawing.Point(12, 106)
        Me.PanelMostrarTodosF.Name = "PanelMostrarTodosF"
        Me.PanelMostrarTodosF.Size = New System.Drawing.Size(857, 200)
        Me.PanelMostrarTodosF.TabIndex = 68
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(760, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BSeleccionar2
        '
        Me.BSeleccionar2.Location = New System.Drawing.Point(643, 20)
        Me.BSeleccionar2.Name = "BSeleccionar2"
        Me.BSeleccionar2.Size = New System.Drawing.Size(75, 23)
        Me.BSeleccionar2.TabIndex = 51
        Me.BSeleccionar2.Text = "Seleccionar"
        Me.BSeleccionar2.UseVisualStyleBackColor = True
        '
        'desc_prod
        '
        Me.desc_prod.AutoSize = True
        Me.desc_prod.Location = New System.Drawing.Point(193, 23)
        Me.desc_prod.Name = "desc_prod"
        Me.desc_prod.Size = New System.Drawing.Size(81, 17)
        Me.desc_prod.TabIndex = 36
        Me.desc_prod.TabStop = True
        Me.desc_prod.Text = "Descripción"
        Me.desc_prod.UseVisualStyleBackColor = True
        '
        'nro_prod
        '
        Me.nro_prod.AutoSize = True
        Me.nro_prod.Location = New System.Drawing.Point(123, 23)
        Me.nro_prod.Name = "nro_prod"
        Me.nro_prod.Size = New System.Drawing.Size(70, 17)
        Me.nro_prod.TabIndex = 35
        Me.nro_prod.TabStop = True
        Me.nro_prod.Text = "Nro Prod."
        Me.nro_prod.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Buscar"
        '
        'TextBoxBuscar2
        '
        Me.TextBoxBuscar2.Location = New System.Drawing.Point(17, 23)
        Me.TextBoxBuscar2.Name = "TextBoxBuscar2"
        Me.TextBoxBuscar2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBuscar2.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(362, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(214, 25)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Todas las Facturas"
        '
        'FacturasDataGridView
        '
        Me.FacturasDataGridView.AllowUserToAddRows = False
        Me.FacturasDataGridView.AllowUserToDeleteRows = False
        Me.FacturasDataGridView.AutoGenerateColumns = False
        Me.FacturasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FacturasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdventaDataGridViewTextBoxColumn, Me.IdusuarioDataGridViewTextBoxColumn, Me.IdclienteDataGridViewTextBoxColumn1, Me.FechaventaDataGridViewTextBoxColumn, Me.TotalventaDataGridViewTextBoxColumn, Me.NroventaDataGridViewTextBoxColumn})
        Me.FacturasDataGridView.DataSource = Me.VentascabeceraBindingSource
        Me.FacturasDataGridView.Location = New System.Drawing.Point(17, 49)
        Me.FacturasDataGridView.Name = "FacturasDataGridView"
        Me.FacturasDataGridView.ReadOnly = True
        Me.FacturasDataGridView.Size = New System.Drawing.Size(805, 151)
        Me.FacturasDataGridView.TabIndex = 19
        '
        'IdventaDataGridViewTextBoxColumn
        '
        Me.IdventaDataGridViewTextBoxColumn.DataPropertyName = "id_venta"
        Me.IdventaDataGridViewTextBoxColumn.HeaderText = "ID venta"
        Me.IdventaDataGridViewTextBoxColumn.Name = "IdventaDataGridViewTextBoxColumn"
        Me.IdventaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdusuarioDataGridViewTextBoxColumn
        '
        Me.IdusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario"
        Me.IdusuarioDataGridViewTextBoxColumn.HeaderText = "ID Usuario"
        Me.IdusuarioDataGridViewTextBoxColumn.Name = "IdusuarioDataGridViewTextBoxColumn"
        Me.IdusuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdclienteDataGridViewTextBoxColumn1
        '
        Me.IdclienteDataGridViewTextBoxColumn1.DataPropertyName = "id_cliente"
        Me.IdclienteDataGridViewTextBoxColumn1.HeaderText = "ID Cliente"
        Me.IdclienteDataGridViewTextBoxColumn1.Name = "IdclienteDataGridViewTextBoxColumn1"
        Me.IdclienteDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FechaventaDataGridViewTextBoxColumn
        '
        Me.FechaventaDataGridViewTextBoxColumn.DataPropertyName = "fecha_venta"
        Me.FechaventaDataGridViewTextBoxColumn.HeaderText = "Fecha venta"
        Me.FechaventaDataGridViewTextBoxColumn.Name = "FechaventaDataGridViewTextBoxColumn"
        Me.FechaventaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalventaDataGridViewTextBoxColumn
        '
        Me.TotalventaDataGridViewTextBoxColumn.DataPropertyName = "total_venta"
        Me.TotalventaDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalventaDataGridViewTextBoxColumn.Name = "TotalventaDataGridViewTextBoxColumn"
        Me.TotalventaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NroventaDataGridViewTextBoxColumn
        '
        Me.NroventaDataGridViewTextBoxColumn.DataPropertyName = "nro_venta"
        Me.NroventaDataGridViewTextBoxColumn.HeaderText = "Nro. venta"
        Me.NroventaDataGridViewTextBoxColumn.Name = "NroventaDataGridViewTextBoxColumn"
        Me.NroventaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VentascabeceraBindingSource
        '
        Me.VentascabeceraBindingSource.DataMember = "Ventas_cabecera"
        Me.VentascabeceraBindingSource.DataSource = Me.BaseDataSet
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.BaseDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'VentasdetalleBindingSource
        '
        Me.VentasdetalleBindingSource.DataMember = "Ventas_detalle"
        Me.VentasdetalleBindingSource.DataSource = Me.BaseDataSet
        '
        'Ventas_detalleTableAdapter
        '
        Me.Ventas_detalleTableAdapter.ClearBeforeFill = True
        '
        'Ventas_cabeceraTableAdapter
        '
        Me.Ventas_cabeceraTableAdapter.ClearBeforeFill = True
        '
        'PanelMostrarTodosP
        '
        Me.PanelMostrarTodosP.BackColor = System.Drawing.SystemColors.Info
        Me.PanelMostrarTodosP.Controls.Add(Me.BSeleccionarProducto)
        Me.PanelMostrarTodosP.Controls.Add(Me.RadioButton1)
        Me.PanelMostrarTodosP.Controls.Add(Me.RadioButton2)
        Me.PanelMostrarTodosP.Controls.Add(Me.Label10)
        Me.PanelMostrarTodosP.Controls.Add(Me.TextBox1)
        Me.PanelMostrarTodosP.Controls.Add(Me.Label13)
        Me.PanelMostrarTodosP.Controls.Add(Me.ProductosDataGridView)
        Me.PanelMostrarTodosP.Location = New System.Drawing.Point(24, 112)
        Me.PanelMostrarTodosP.Name = "PanelMostrarTodosP"
        Me.PanelMostrarTodosP.Size = New System.Drawing.Size(857, 200)
        Me.PanelMostrarTodosP.TabIndex = 70
        Me.PanelMostrarTodosP.Visible = False
        '
        'BSeleccionarProducto
        '
        Me.BSeleccionarProducto.Location = New System.Drawing.Point(643, 20)
        Me.BSeleccionarProducto.Name = "BSeleccionarProducto"
        Me.BSeleccionarProducto.Size = New System.Drawing.Size(75, 23)
        Me.BSeleccionarProducto.TabIndex = 51
        Me.BSeleccionarProducto.Text = "Seleccionar"
        Me.BSeleccionarProducto.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(193, 23)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(81, 17)
        Me.RadioButton1.TabIndex = 36
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Descripción"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(123, 23)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton2.TabIndex = 35
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Nro Prod."
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Buscar"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(17, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(362, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(228, 25)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Todos los Productos"
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AllowUserToAddRows = False
        Me.ProductosDataGridView.AllowUserToDeleteRows = False
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdproductoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.IdcategoriaDataGridViewTextBoxColumn, Me.PreciocostoDataGridViewTextBoxColumn, Me.PrecioventaDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.StockminDataGridViewTextBoxColumn, Me.ImagenDataGridViewTextBoxColumn})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(17, 49)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.ReadOnly = True
        Me.ProductosDataGridView.Size = New System.Drawing.Size(805, 151)
        Me.ProductosDataGridView.TabIndex = 19
        '
        'IdproductoDataGridViewTextBoxColumn
        '
        Me.IdproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn.HeaderText = "ID."
        Me.IdproductoDataGridViewTextBoxColumn.Name = "IdproductoDataGridViewTextBoxColumn"
        Me.IdproductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdcategoriaDataGridViewTextBoxColumn
        '
        Me.IdcategoriaDataGridViewTextBoxColumn.DataPropertyName = "id_categoria"
        Me.IdcategoriaDataGridViewTextBoxColumn.HeaderText = "Categoría"
        Me.IdcategoriaDataGridViewTextBoxColumn.Name = "IdcategoriaDataGridViewTextBoxColumn"
        Me.IdcategoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PreciocostoDataGridViewTextBoxColumn
        '
        Me.PreciocostoDataGridViewTextBoxColumn.DataPropertyName = "precio_costo"
        Me.PreciocostoDataGridViewTextBoxColumn.HeaderText = "Precio Costo"
        Me.PreciocostoDataGridViewTextBoxColumn.Name = "PreciocostoDataGridViewTextBoxColumn"
        Me.PreciocostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioventaDataGridViewTextBoxColumn
        '
        Me.PrecioventaDataGridViewTextBoxColumn.DataPropertyName = "precio_venta"
        Me.PrecioventaDataGridViewTextBoxColumn.HeaderText = "Precio Venta"
        Me.PrecioventaDataGridViewTextBoxColumn.Name = "PrecioventaDataGridViewTextBoxColumn"
        Me.PrecioventaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockminDataGridViewTextBoxColumn
        '
        Me.StockminDataGridViewTextBoxColumn.DataPropertyName = "stock_min"
        Me.StockminDataGridViewTextBoxColumn.HeaderText = "Stock Min."
        Me.StockminDataGridViewTextBoxColumn.Name = "StockminDataGridViewTextBoxColumn"
        Me.StockminDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImagenDataGridViewTextBoxColumn
        '
        Me.ImagenDataGridViewTextBoxColumn.DataPropertyName = "imagen"
        Me.ImagenDataGridViewTextBoxColumn.HeaderText = "imagen"
        Me.ImagenDataGridViewTextBoxColumn.Name = "ImagenDataGridViewTextBoxColumn"
        Me.ImagenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'gestionFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 424)
        Me.Controls.Add(Me.PanelNuevo)
        Me.Controls.Add(Me.PanelMostrarTodos)
        Me.Controls.Add(Me.PanelMostrarTodosF)
        Me.Controls.Add(Me.PanelBotones)
        Me.Controls.Add(Me.PanelMostrarTodosP)
        Me.Controls.Add(Me.BTvolver)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gestionFacturas"
        Me.Text = "Gestión Facturas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelBotones.ResumeLayout(False)
        Me.PanelBotones.PerformLayout()
        Me.PanelNuevo.ResumeLayout(False)
        Me.PanelNuevo.PerformLayout()
        CType(Me.DetallesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMostrarTodos.ResumeLayout(False)
        Me.PanelMostrarTodos.PerformLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMostrarTodosF.ResumeLayout(False)
        Me.PanelMostrarTodosF.PerformLayout()
        CType(Me.FacturasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentascabeceraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMostrarTodosP.ResumeLayout(False)
        Me.PanelMostrarTodosP.PerformLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTvolver As Button
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Bagregar As Button
    Friend WithEvents Bmostrar As Button
    Friend WithEvents PanelNuevo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelMostrarTodos As Panel
    Friend WithEvents apecliente As RadioButton
    Friend WithEvents dnicli As RadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Bseleccionar As Button
    Friend WithEvents TBapeynom As TextBox
    Friend WithEvents seleccionar1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CantP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Prod As TextBox
    Friend WithEvents seleccionar2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DetallesDataGrid As DataGridView
    Friend WithEvents BaseDataSet As BaseDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As BaseDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents IdclienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DniDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechanacDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EliminadoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents TBdni As TextBox
    Friend WithEvents PanelMostrarTodosF As Panel
    Friend WithEvents desc_prod As RadioButton
    Friend WithEvents nro_prod As RadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxBuscar2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FacturasDataGridView As DataGridView
    Friend WithEvents BSeleccionar2 As Button
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As BaseDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents VentasdetalleBindingSource As BindingSource
    Friend WithEvents Ventas_detalleTableAdapter As BaseDataSetTableAdapters.Ventas_detalleTableAdapter
    Friend WithEvents agregar As Button
    Friend WithEvents Idprod As TextBox
    Friend WithEvents Preciop As TextBox
    Friend WithEvents cancelar As Button
    Friend WithEvents stk As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents comprar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TBCli As TextBox
    Friend WithEvents idprodu As DataGridViewTextBoxColumn
    Friend WithEvents descP As DataGridViewTextBoxColumn
    Friend WithEvents cant As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents VentascabeceraBindingSource As BindingSource
    Friend WithEvents Ventas_cabeceraTableAdapter As BaseDataSetTableAdapters.Ventas_cabeceraTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents IdventaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdusuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdclienteDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FechaventaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalventaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroventaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EliminadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PanelMostrarTodosP As Panel
    Friend WithEvents BSeleccionarProducto As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents IdproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdcategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreciocostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioventaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImagenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
