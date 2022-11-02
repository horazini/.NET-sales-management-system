<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gestionProductos
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Id_categoriaLabel As System.Windows.Forms.Label
        Dim Precio_costoLabel As System.Windows.Forms.Label
        Dim Precio_ventaLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim Stock_minLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestionProductos))
        Me.ProductosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseDataSet = New proyecto.BaseDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_costoTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_ventaTextBox = New System.Windows.Forms.TextBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.Stock_minTextBox = New System.Windows.Forms.TextBox()
        Me.ImagenTextBox = New System.Windows.Forms.TextBox()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imagen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTAgregar = New System.Windows.Forms.Button()
        Me.BTModificar = New System.Windows.Forms.Button()
        Me.BTEliminar = New System.Windows.Forms.Button()
        Me.BTMostrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTGrabar = New System.Windows.Forms.Button()
        Me.BTLimpiar = New System.Windows.Forms.Button()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PanelNuevo = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBEliminado = New System.Windows.Forms.ComboBox()
        Me.CBcategoria = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTFoto = New System.Windows.Forms.Button()
        Me.Id_productoTextBox = New System.Windows.Forms.TextBox()
        Me.PanelMostrartodos = New System.Windows.Forms.Panel()
        Me.BTActivos = New System.Windows.Forms.Button()
        Me.BTInactivo = New System.Windows.Forms.Button()
        Me.desc_prod = New System.Windows.Forms.RadioButton()
        Me.nro_prod = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PanelModificar = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBEliminado2 = New System.Windows.Forms.ComboBox()
        Me.CBcategoria2 = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BFoto2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Grabarmodificar = New System.Windows.Forms.Button()
        Me.ImagenTextBox2 = New System.Windows.Forms.TextBox()
        Me.Id_productoTextBox2 = New System.Windows.Forms.TextBox()
        Me.Stock_minTextBox2 = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox2 = New System.Windows.Forms.TextBox()
        Me.StockTextBox2 = New System.Windows.Forms.TextBox()
        Me.Precio_ventaTextBox2 = New System.Windows.Forms.TextBox()
        Me.Precio_costoTextBox2 = New System.Windows.Forms.TextBox()
        Me.ProductosTableAdapter = New proyecto.BaseDataSetTableAdapters.ProductosTableAdapter()
        Me.TableAdapterManager = New proyecto.BaseDataSetTableAdapters.TableAdapterManager()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        DescripcionLabel = New System.Windows.Forms.Label()
        Id_categoriaLabel = New System.Windows.Forms.Label()
        Precio_costoLabel = New System.Windows.Forms.Label()
        Precio_ventaLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        Stock_minLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductosBindingNavigator.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBotones.SuspendLayout()
        Me.PanelNuevo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMostrartodos.SuspendLayout()
        Me.PanelModificar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(57, 106)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripción:"
        '
        'Id_categoriaLabel
        '
        Id_categoriaLabel.AutoSize = True
        Id_categoriaLabel.Location = New System.Drawing.Point(53, 77)
        Id_categoriaLabel.Name = "Id_categoriaLabel"
        Id_categoriaLabel.Size = New System.Drawing.Size(57, 13)
        Id_categoriaLabel.TabIndex = 5
        Id_categoriaLabel.Text = "Categoría:"
        '
        'Precio_costoLabel
        '
        Precio_costoLabel.AutoSize = True
        Precio_costoLabel.Location = New System.Drawing.Point(271, 81)
        Precio_costoLabel.Name = "Precio_costoLabel"
        Precio_costoLabel.Size = New System.Drawing.Size(70, 13)
        Precio_costoLabel.TabIndex = 7
        Precio_costoLabel.Text = "Precio Costo:"
        '
        'Precio_ventaLabel
        '
        Precio_ventaLabel.AutoSize = True
        Precio_ventaLabel.Location = New System.Drawing.Point(270, 110)
        Precio_ventaLabel.Name = "Precio_ventaLabel"
        Precio_ventaLabel.Size = New System.Drawing.Size(71, 13)
        Precio_ventaLabel.TabIndex = 9
        Precio_ventaLabel.Text = "Precio Venta:"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(57, 140)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(38, 13)
        StockLabel.TabIndex = 11
        StockLabel.Text = "Stock:"
        '
        'Stock_minLabel
        '
        Stock_minLabel.AutoSize = True
        Stock_minLabel.Location = New System.Drawing.Point(57, 169)
        Stock_minLabel.Name = "Stock_minLabel"
        Stock_minLabel.Size = New System.Drawing.Size(58, 13)
        Stock_minLabel.TabIndex = 13
        Stock_minLabel.Text = "Stock Min:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(271, 143)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(55, 13)
        Label3.TabIndex = 17
        Label3.Text = "Eliminado:"
        Label3.Visible = False
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(285, 140)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(55, 13)
        Label7.TabIndex = 17
        Label7.Text = "Eliminado:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(57, 106)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(66, 13)
        Label8.TabIndex = 3
        Label8.Text = "Descripción:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(57, 169)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(58, 13)
        Label9.TabIndex = 13
        Label9.Text = "Stock Min:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(53, 77)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(57, 13)
        Label10.TabIndex = 5
        Label10.Text = "Categoría:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(57, 143)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(38, 13)
        Label11.TabIndex = 11
        Label11.Text = "Stock:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(271, 48)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(70, 13)
        Label12.TabIndex = 7
        Label12.Text = "Precio Costo:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(269, 88)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(71, 13)
        Label13.TabIndex = 9
        Label13.Text = "Precio Venta:"
        '
        'ProductosBindingNavigator
        '
        Me.ProductosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductosBindingNavigator.BindingSource = Me.ProductosBindingSource
        Me.ProductosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductosBindingNavigatorSaveItem})
        Me.ProductosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductosBindingNavigator.Name = "ProductosBindingNavigator"
        Me.ProductosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductosBindingNavigator.Size = New System.Drawing.Size(854, 25)
        Me.ProductosBindingNavigator.TabIndex = 0
        Me.ProductosBindingNavigator.Text = "BindingNavigator1"
        Me.ProductosBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.BaseDataSet
        '
        'BaseDataSet
        '
        Me.BaseDataSet.DataSetName = "BaseDataSet"
        Me.BaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProductosBindingNavigatorSaveItem
        '
        Me.ProductosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductosBindingNavigatorSaveItem.Name = "ProductosBindingNavigatorSaveItem"
        Me.ProductosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(132, 107)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DescripcionTextBox.TabIndex = 1
        '
        'Precio_costoTextBox
        '
        Me.Precio_costoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precio_costo", True))
        Me.Precio_costoTextBox.Location = New System.Drawing.Point(349, 78)
        Me.Precio_costoTextBox.Name = "Precio_costoTextBox"
        Me.Precio_costoTextBox.Size = New System.Drawing.Size(117, 20)
        Me.Precio_costoTextBox.TabIndex = 4
        '
        'Precio_ventaTextBox
        '
        Me.Precio_ventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precio_venta", True))
        Me.Precio_ventaTextBox.Location = New System.Drawing.Point(349, 107)
        Me.Precio_ventaTextBox.Name = "Precio_ventaTextBox"
        Me.Precio_ventaTextBox.Size = New System.Drawing.Size(117, 20)
        Me.Precio_ventaTextBox.TabIndex = 5
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "stock", True))
        Me.StockTextBox.Location = New System.Drawing.Point(132, 137)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(121, 20)
        Me.StockTextBox.TabIndex = 2
        '
        'Stock_minTextBox
        '
        Me.Stock_minTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "stock_min", True))
        Me.Stock_minTextBox.Location = New System.Drawing.Point(132, 166)
        Me.Stock_minTextBox.Name = "Stock_minTextBox"
        Me.Stock_minTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Stock_minTextBox.TabIndex = 3
        '
        'ImagenTextBox
        '
        Me.ImagenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "imagen", True))
        Me.ImagenTextBox.Location = New System.Drawing.Point(570, 139)
        Me.ImagenTextBox.Name = "ImagenTextBox"
        Me.ImagenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImagenTextBox.TabIndex = 16
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AllowUserToAddRows = False
        Me.ProductosDataGridView.AllowUserToDeleteRows = False
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.imagen})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(17, 49)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.ReadOnly = True
        Me.ProductosDataGridView.Size = New System.Drawing.Size(805, 151)
        Me.ProductosDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id_categoria"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Categoría"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "precio_costo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Precio Costo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "precio_venta"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio Venta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "stock"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "stock_min"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Stock Min"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "eliminado"
        Me.DataGridViewTextBoxColumn8.HeaderText = "eliminado"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'imagen
        '
        Me.imagen.DataPropertyName = "imagen"
        Me.imagen.HeaderText = "imagen"
        Me.imagen.Name = "imagen"
        Me.imagen.ReadOnly = True
        '
        'BTAgregar
        '
        Me.BTAgregar.Location = New System.Drawing.Point(98, 48)
        Me.BTAgregar.Name = "BTAgregar"
        Me.BTAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BTAgregar.TabIndex = 20
        Me.BTAgregar.Text = "Nuevo"
        Me.BTAgregar.UseVisualStyleBackColor = True
        '
        'BTModificar
        '
        Me.BTModificar.Location = New System.Drawing.Point(641, 13)
        Me.BTModificar.Name = "BTModificar"
        Me.BTModificar.Size = New System.Drawing.Size(75, 23)
        Me.BTModificar.TabIndex = 21
        Me.BTModificar.Text = "Modificar"
        Me.BTModificar.UseVisualStyleBackColor = True
        '
        'BTEliminar
        '
        Me.BTEliminar.Location = New System.Drawing.Point(305, 13)
        Me.BTEliminar.Name = "BTEliminar"
        Me.BTEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTEliminar.TabIndex = 22
        Me.BTEliminar.Text = "Eliminar"
        Me.BTEliminar.UseVisualStyleBackColor = True
        '
        'BTMostrar
        '
        Me.BTMostrar.Location = New System.Drawing.Point(226, 48)
        Me.BTMostrar.Name = "BTMostrar"
        Me.BTMostrar.Size = New System.Drawing.Size(131, 23)
        Me.BTMostrar.TabIndex = 24
        Me.BTMostrar.Text = "Mostrar"
        Me.BTMostrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Nuevo Producto"
        '
        'BTGrabar
        '
        Me.BTGrabar.Location = New System.Drawing.Point(693, 101)
        Me.BTGrabar.Name = "BTGrabar"
        Me.BTGrabar.Size = New System.Drawing.Size(75, 23)
        Me.BTGrabar.TabIndex = 9
        Me.BTGrabar.Text = "Grabar"
        Me.BTGrabar.UseVisualStyleBackColor = True
        '
        'BTLimpiar
        '
        Me.BTLimpiar.Location = New System.Drawing.Point(693, 69)
        Me.BTLimpiar.Name = "BTLimpiar"
        Me.BTLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTLimpiar.TabIndex = 8
        Me.BTLimpiar.Text = "Limpiar"
        Me.BTLimpiar.UseVisualStyleBackColor = True
        '
        'PanelBotones
        '
        Me.PanelBotones.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelBotones.Controls.Add(Me.Label15)
        Me.PanelBotones.Controls.Add(Me.BTMostrar)
        Me.PanelBotones.Controls.Add(Me.BTAgregar)
        Me.PanelBotones.Location = New System.Drawing.Point(215, 22)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(449, 100)
        Me.PanelBotones.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(171, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 25)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Productos"
        '
        'PanelNuevo
        '
        Me.PanelNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelNuevo.Controls.Add(Me.Label4)
        Me.PanelNuevo.Controls.Add(Me.CBEliminado)
        Me.PanelNuevo.Controls.Add(Me.CBcategoria)
        Me.PanelNuevo.Controls.Add(Me.PictureBox1)
        Me.PanelNuevo.Controls.Add(Me.BTFoto)
        Me.PanelNuevo.Controls.Add(Me.Label1)
        Me.PanelNuevo.Controls.Add(Me.BTLimpiar)
        Me.PanelNuevo.Controls.Add(Me.BTGrabar)
        Me.PanelNuevo.Controls.Add(Label3)
        Me.PanelNuevo.Controls.Add(Me.ImagenTextBox)
        Me.PanelNuevo.Controls.Add(Me.Id_productoTextBox)
        Me.PanelNuevo.Controls.Add(Me.Stock_minTextBox)
        Me.PanelNuevo.Controls.Add(DescripcionLabel)
        Me.PanelNuevo.Controls.Add(Stock_minLabel)
        Me.PanelNuevo.Controls.Add(Me.DescripcionTextBox)
        Me.PanelNuevo.Controls.Add(Me.StockTextBox)
        Me.PanelNuevo.Controls.Add(Id_categoriaLabel)
        Me.PanelNuevo.Controls.Add(StockLabel)
        Me.PanelNuevo.Controls.Add(Me.Precio_ventaTextBox)
        Me.PanelNuevo.Controls.Add(Precio_costoLabel)
        Me.PanelNuevo.Controls.Add(Precio_ventaLabel)
        Me.PanelNuevo.Controls.Add(Me.Precio_costoTextBox)
        Me.PanelNuevo.Location = New System.Drawing.Point(8, 99)
        Me.PanelNuevo.Name = "PanelNuevo"
        Me.PanelNuevo.Size = New System.Drawing.Size(820, 222)
        Me.PanelNuevo.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Nro de Prod."
        '
        'CBEliminado
        '
        Me.CBEliminado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEliminado.FormattingEnabled = True
        Me.CBEliminado.Items.AddRange(New Object() {"SI", "NO"})
        Me.CBEliminado.Location = New System.Drawing.Point(349, 139)
        Me.CBEliminado.Name = "CBEliminado"
        Me.CBEliminado.Size = New System.Drawing.Size(117, 21)
        Me.CBEliminado.TabIndex = 6
        Me.CBEliminado.Visible = False
        '
        'CBcategoria
        '
        Me.CBcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBcategoria.FormattingEnabled = True
        Me.CBcategoria.Items.AddRange(New Object() {"1 - Cat1", "2 - Cat2", "3 - Cat3"})
        Me.CBcategoria.Location = New System.Drawing.Point(132, 77)
        Me.CBcategoria.Name = "CBcategoria"
        Me.CBcategoria.Size = New System.Drawing.Size(121, 21)
        Me.CBcategoria.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(504, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'BTFoto
        '
        Me.BTFoto.Location = New System.Drawing.Point(489, 136)
        Me.BTFoto.Name = "BTFoto"
        Me.BTFoto.Size = New System.Drawing.Size(75, 23)
        Me.BTFoto.TabIndex = 7
        Me.BTFoto.Text = "Foto"
        Me.BTFoto.UseVisualStyleBackColor = True
        '
        'Id_productoTextBox
        '
        Me.Id_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id_producto", True))
        Me.Id_productoTextBox.Enabled = False
        Me.Id_productoTextBox.Location = New System.Drawing.Point(132, 45)
        Me.Id_productoTextBox.Name = "Id_productoTextBox"
        Me.Id_productoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_productoTextBox.TabIndex = 2
        '
        'PanelMostrartodos
        '
        Me.PanelMostrartodos.BackColor = System.Drawing.SystemColors.Info
        Me.PanelMostrartodos.Controls.Add(Me.BTActivos)
        Me.PanelMostrartodos.Controls.Add(Me.BTInactivo)
        Me.PanelMostrartodos.Controls.Add(Me.desc_prod)
        Me.PanelMostrartodos.Controls.Add(Me.nro_prod)
        Me.PanelMostrartodos.Controls.Add(Me.Label14)
        Me.PanelMostrartodos.Controls.Add(Me.TextBoxBuscar)
        Me.PanelMostrartodos.Controls.Add(Me.Label2)
        Me.PanelMostrartodos.Controls.Add(Me.BTModificar)
        Me.PanelMostrartodos.Controls.Add(Me.BTEliminar)
        Me.PanelMostrartodos.Controls.Add(Me.ProductosDataGridView)
        Me.PanelMostrartodos.Location = New System.Drawing.Point(39, 40)
        Me.PanelMostrartodos.Name = "PanelMostrartodos"
        Me.PanelMostrartodos.Size = New System.Drawing.Size(857, 200)
        Me.PanelMostrartodos.TabIndex = 36
        '
        'BTActivos
        '
        Me.BTActivos.Location = New System.Drawing.Point(732, 17)
        Me.BTActivos.Name = "BTActivos"
        Me.BTActivos.Size = New System.Drawing.Size(78, 23)
        Me.BTActivos.TabIndex = 43
        Me.BTActivos.Text = "Activos"
        Me.BTActivos.UseVisualStyleBackColor = True
        '
        'BTInactivo
        '
        Me.BTInactivo.Location = New System.Drawing.Point(732, 10)
        Me.BTInactivo.Name = "BTInactivo"
        Me.BTInactivo.Size = New System.Drawing.Size(75, 23)
        Me.BTInactivo.TabIndex = 42
        Me.BTInactivo.Text = "Inactivos"
        Me.BTInactivo.UseVisualStyleBackColor = True
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
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "descripcion", True))
        Me.TextBoxBuscar.Location = New System.Drawing.Point(17, 23)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBuscar.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(398, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Todos los Productos"
        '
        'BTCancelar
        '
        Me.BTCancelar.Location = New System.Drawing.Point(8, 6)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTCancelar.TabIndex = 34
        Me.BTCancelar.Text = "Volver"
        Me.BTCancelar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PanelModificar
        '
        Me.PanelModificar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PanelModificar.Controls.Add(Me.Label5)
        Me.PanelModificar.Controls.Add(Me.CBEliminado2)
        Me.PanelModificar.Controls.Add(Me.CBcategoria2)
        Me.PanelModificar.Controls.Add(Me.PictureBox2)
        Me.PanelModificar.Controls.Add(Me.BFoto2)
        Me.PanelModificar.Controls.Add(Me.Label6)
        Me.PanelModificar.Controls.Add(Me.Grabarmodificar)
        Me.PanelModificar.Controls.Add(Label7)
        Me.PanelModificar.Controls.Add(Me.ImagenTextBox2)
        Me.PanelModificar.Controls.Add(Me.Id_productoTextBox2)
        Me.PanelModificar.Controls.Add(Me.Stock_minTextBox2)
        Me.PanelModificar.Controls.Add(Label8)
        Me.PanelModificar.Controls.Add(Label9)
        Me.PanelModificar.Controls.Add(Me.DescripcionTextBox2)
        Me.PanelModificar.Controls.Add(Me.StockTextBox2)
        Me.PanelModificar.Controls.Add(Label10)
        Me.PanelModificar.Controls.Add(Label11)
        Me.PanelModificar.Controls.Add(Me.Precio_ventaTextBox2)
        Me.PanelModificar.Controls.Add(Label12)
        Me.PanelModificar.Controls.Add(Label13)
        Me.PanelModificar.Controls.Add(Me.Precio_costoTextBox2)
        Me.PanelModificar.Location = New System.Drawing.Point(12, 54)
        Me.PanelModificar.Name = "PanelModificar"
        Me.PanelModificar.Size = New System.Drawing.Size(820, 222)
        Me.PanelModificar.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Nro de Prod."
        '
        'CBEliminado2
        '
        Me.CBEliminado2.FormattingEnabled = True
        Me.CBEliminado2.Items.AddRange(New Object() {"SI", "NO"})
        Me.CBEliminado2.Location = New System.Drawing.Point(347, 140)
        Me.CBEliminado2.Name = "CBEliminado2"
        Me.CBEliminado2.Size = New System.Drawing.Size(121, 21)
        Me.CBEliminado2.TabIndex = 37
        '
        'CBcategoria2
        '
        Me.CBcategoria2.FormattingEnabled = True
        Me.CBcategoria2.Items.AddRange(New Object() {"1 - Cat1", "2 - Cat2", "3 - Cat3"})
        Me.CBcategoria2.Location = New System.Drawing.Point(132, 77)
        Me.CBcategoria2.Name = "CBcategoria2"
        Me.CBcategoria2.Size = New System.Drawing.Size(121, 21)
        Me.CBcategoria2.TabIndex = 36
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(488, 41)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(142, 83)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'BFoto2
        '
        Me.BFoto2.Location = New System.Drawing.Point(529, 133)
        Me.BFoto2.Name = "BFoto2"
        Me.BFoto2.Size = New System.Drawing.Size(75, 23)
        Me.BFoto2.TabIndex = 34
        Me.BFoto2.Text = "Foto"
        Me.BFoto2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(258, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(210, 25)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Modificar Producto"
        '
        'Grabarmodificar
        '
        Me.Grabarmodificar.Location = New System.Drawing.Point(693, 101)
        Me.Grabarmodificar.Name = "Grabarmodificar"
        Me.Grabarmodificar.Size = New System.Drawing.Size(75, 23)
        Me.Grabarmodificar.TabIndex = 32
        Me.Grabarmodificar.Text = "Grabar"
        Me.Grabarmodificar.UseVisualStyleBackColor = True
        '
        'ImagenTextBox2
        '
        Me.ImagenTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "imagen", True))
        Me.ImagenTextBox2.Location = New System.Drawing.Point(610, 136)
        Me.ImagenTextBox2.Name = "ImagenTextBox2"
        Me.ImagenTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.ImagenTextBox2.TabIndex = 16
        '
        'Id_productoTextBox2
        '
        Me.Id_productoTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id_producto", True))
        Me.Id_productoTextBox2.Enabled = False
        Me.Id_productoTextBox2.Location = New System.Drawing.Point(132, 45)
        Me.Id_productoTextBox2.Name = "Id_productoTextBox2"
        Me.Id_productoTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.Id_productoTextBox2.TabIndex = 2
        '
        'Stock_minTextBox2
        '
        Me.Stock_minTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "stock_min", True))
        Me.Stock_minTextBox2.Location = New System.Drawing.Point(132, 166)
        Me.Stock_minTextBox2.Name = "Stock_minTextBox2"
        Me.Stock_minTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.Stock_minTextBox2.TabIndex = 14
        '
        'DescripcionTextBox2
        '
        Me.DescripcionTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "descripcion", True))
        Me.DescripcionTextBox2.Location = New System.Drawing.Point(132, 107)
        Me.DescripcionTextBox2.Name = "DescripcionTextBox2"
        Me.DescripcionTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox2.TabIndex = 4
        '
        'StockTextBox2
        '
        Me.StockTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "stock", True))
        Me.StockTextBox2.Location = New System.Drawing.Point(132, 140)
        Me.StockTextBox2.Name = "StockTextBox2"
        Me.StockTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.StockTextBox2.TabIndex = 12
        '
        'Precio_ventaTextBox2
        '
        Me.Precio_ventaTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precio_venta", True))
        Me.Precio_ventaTextBox2.Location = New System.Drawing.Point(345, 88)
        Me.Precio_ventaTextBox2.Name = "Precio_ventaTextBox2"
        Me.Precio_ventaTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.Precio_ventaTextBox2.TabIndex = 10
        '
        'Precio_costoTextBox2
        '
        Me.Precio_costoTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precio_costo", True))
        Me.Precio_costoTextBox2.Location = New System.Drawing.Point(345, 48)
        Me.Precio_costoTextBox2.Name = "Precio_costoTextBox2"
        Me.Precio_costoTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.Precio_costoTextBox2.TabIndex = 8
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.UpdateOrder = proyecto.BaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.Ventas_cabeceraTableAdapter = Nothing
        Me.TableAdapterManager.Ventas_detalleTableAdapter = Nothing
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'gestionProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 464)
        Me.Controls.Add(Me.PanelNuevo)
        Me.Controls.Add(Me.PanelBotones)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.ProductosBindingNavigator)
        Me.Controls.Add(Me.PanelModificar)
        Me.Controls.Add(Me.PanelMostrartodos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gestionProductos"
        Me.Text = "Gestión Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductosBindingNavigator.ResumeLayout(False)
        Me.ProductosBindingNavigator.PerformLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBotones.ResumeLayout(False)
        Me.PanelBotones.PerformLayout()
        Me.PanelNuevo.ResumeLayout(False)
        Me.PanelNuevo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMostrartodos.ResumeLayout(False)
        Me.PanelMostrartodos.PerformLayout()
        Me.PanelModificar.ResumeLayout(False)
        Me.PanelModificar.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BaseDataSet As BaseDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As BaseDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents TableAdapterManager As BaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProductosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents Precio_costoTextBox As TextBox
    Friend WithEvents Precio_ventaTextBox As TextBox
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents Stock_minTextBox As TextBox
    Friend WithEvents ImagenTextBox As TextBox
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents BTAgregar As Button
    Friend WithEvents BTModificar As Button
    Friend WithEvents BTEliminar As Button
    Friend WithEvents BTMostrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BTGrabar As Button
    Friend WithEvents BTLimpiar As Button
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents PanelNuevo As Panel
    Friend WithEvents PanelMostrartodos As Panel
    Friend WithEvents BTCancelar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Id_productoTextBox As TextBox
    Friend WithEvents BTFoto As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CBEliminado As ComboBox
    Friend WithEvents CBcategoria As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelModificar As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents CBEliminado2 As ComboBox
    Friend WithEvents CBcategoria2 As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BFoto2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Grabarmodificar As Button
    Friend WithEvents ImagenTextBox2 As TextBox
    Friend WithEvents Id_productoTextBox2 As TextBox
    Friend WithEvents Stock_minTextBox2 As TextBox
    Friend WithEvents DescripcionTextBox2 As TextBox
    Friend WithEvents StockTextBox2 As TextBox
    Friend WithEvents Precio_ventaTextBox2 As TextBox
    Friend WithEvents Precio_costoTextBox2 As TextBox
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents desc_prod As RadioButton
    Friend WithEvents nro_prod As RadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents BTInactivo As Button
    Friend WithEvents BTActivos As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents imagen As DataGridViewTextBoxColumn
End Class
