<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestionClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DomicilioLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Usuario_dniLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestionClientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bmostrar = New System.Windows.Forms.Button()
        Me.Beliminar = New System.Windows.Forms.Button()
        Me.Bmodificar = New System.Windows.Forms.Button()
        Me.Bagregar = New System.Windows.Forms.Button()
        Me.TBidcliente = New System.Windows.Forms.TextBox()
        Me.TBapellido = New System.Windows.Forms.TextBox()
        Me.TBnombre = New System.Windows.Forms.TextBox()
        Me.TBdomicilio = New System.Windows.Forms.TextBox()
        Me.TBemail = New System.Windows.Forms.TextBox()
        Me.TBdni = New System.Windows.Forms.TextBox()
        Me.TBtelefono = New System.Windows.Forms.TextBox()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PanelMostrarTodos = New System.Windows.Forms.Panel()
        Me.BTActivos = New System.Windows.Forms.Button()
        Me.BTInactivo = New System.Windows.Forms.Button()
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
        Me.EliminadoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseDataSet = New proyecto.BaseDataSet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PanelNuevo = New System.Windows.Forms.Panel()
        Me.FechaNacDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BTGuardar = New System.Windows.Forms.Button()
        Me.BTLimpiar = New System.Windows.Forms.Button()
        Me.PanelModificar = New System.Windows.Forms.Panel()
        Me.FechaNacDateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.BTGrabar2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBtelefono2 = New System.Windows.Forms.TextBox()
        Me.CBeliminado2 = New System.Windows.Forms.ComboBox()
        Me.TBdni2 = New System.Windows.Forms.TextBox()
        Me.TBidcliente2 = New System.Windows.Forms.TextBox()
        Me.TBemail2 = New System.Windows.Forms.TextBox()
        Me.TBapellido2 = New System.Windows.Forms.TextBox()
        Me.TBdomicilio2 = New System.Windows.Forms.TextBox()
        Me.TBnombre2 = New System.Windows.Forms.TextBox()
        Me.BTvolver = New System.Windows.Forms.Button()
        Me.ClientesTableAdapter = New proyecto.BaseDataSetTableAdapters.ClientesTableAdapter()
        ApellidoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        DomicilioLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Usuario_dniLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Me.PanelBotones.SuspendLayout()
        Me.PanelMostrarTodos.SuspendLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNuevo.SuspendLayout()
        Me.PanelModificar.SuspendLayout()
        Me.SuspendLayout()
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(51, 69)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 36
        ApellidoLabel.Text = "Apellido:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(51, 95)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 39
        NombreLabel.Text = "Nombre:"
        '
        'DomicilioLabel
        '
        DomicilioLabel.AutoSize = True
        DomicilioLabel.Location = New System.Drawing.Point(340, 93)
        DomicilioLabel.Name = "DomicilioLabel"
        DomicilioLabel.Size = New System.Drawing.Size(52, 13)
        DomicilioLabel.TabIndex = 41
        DomicilioLabel.Text = "Domicilio:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(341, 123)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 51
        EmailLabel.Text = "Email:"
        '
        'Usuario_dniLabel
        '
        Usuario_dniLabel.AutoSize = True
        Usuario_dniLabel.Location = New System.Drawing.Point(51, 121)
        Usuario_dniLabel.Name = "Usuario_dniLabel"
        Usuario_dniLabel.Size = New System.Drawing.Size(29, 13)
        Usuario_dniLabel.TabIndex = 53
        Usuario_dniLabel.Text = "DNI:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(340, 67)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 56
        TelefonoLabel.Text = "Teléfono:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(340, 119)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(55, 13)
        Label3.TabIndex = 57
        Label3.Text = "Eliminado:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(340, 67)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(52, 13)
        Label4.TabIndex = 56
        Label4.Text = "Teléfono:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(45, 49)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(56, 13)
        Label5.TabIndex = 33
        Label5.Text = "ID Cliente:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(45, 134)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(29, 13)
        Label6.TabIndex = 53
        Label6.Text = "DNI:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(45, 82)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(47, 13)
        Label7.TabIndex = 36
        Label7.Text = "Apellido:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(340, 145)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(35, 13)
        Label8.TabIndex = 51
        Label8.Text = "Email:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(45, 108)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(47, 13)
        Label9.TabIndex = 39
        Label9.Text = "Nombre:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(340, 93)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(52, 13)
        Label10.TabIndex = 41
        Label10.Text = "Domicilio:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(51, 151)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(66, 13)
        Label13.TabIndex = 62
        Label13.Text = "Fecha Nac.:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(45, 160)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(66, 13)
        Label14.TabIndex = 64
        Label14.Text = "Fecha Nac.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 25)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Nuevo Cliente"
        '
        'Bmostrar
        '
        Me.Bmostrar.Location = New System.Drawing.Point(160, 34)
        Me.Bmostrar.Name = "Bmostrar"
        Me.Bmostrar.Size = New System.Drawing.Size(131, 23)
        Me.Bmostrar.TabIndex = 54
        Me.Bmostrar.Text = "Mostrar Clientes"
        Me.Bmostrar.UseVisualStyleBackColor = True
        '
        'Beliminar
        '
        Me.Beliminar.Location = New System.Drawing.Point(252, 37)
        Me.Beliminar.Name = "Beliminar"
        Me.Beliminar.Size = New System.Drawing.Size(75, 23)
        Me.Beliminar.TabIndex = 49
        Me.Beliminar.Text = "Eliminar"
        Me.Beliminar.UseVisualStyleBackColor = True
        '
        'Bmodificar
        '
        Me.Bmodificar.Location = New System.Drawing.Point(555, 37)
        Me.Bmodificar.Name = "Bmodificar"
        Me.Bmodificar.Size = New System.Drawing.Size(75, 23)
        Me.Bmodificar.TabIndex = 50
        Me.Bmodificar.Text = "Modificar"
        Me.Bmodificar.UseVisualStyleBackColor = True
        '
        'Bagregar
        '
        Me.Bagregar.Location = New System.Drawing.Point(40, 34)
        Me.Bagregar.Name = "Bagregar"
        Me.Bagregar.Size = New System.Drawing.Size(75, 23)
        Me.Bagregar.TabIndex = 48
        Me.Bagregar.Text = "Agregar"
        Me.Bagregar.UseVisualStyleBackColor = True
        '
        'TBidcliente
        '
        Me.TBidcliente.Enabled = False
        Me.TBidcliente.Location = New System.Drawing.Point(120, 25)
        Me.TBidcliente.Name = "TBidcliente"
        Me.TBidcliente.Size = New System.Drawing.Size(94, 20)
        Me.TBidcliente.TabIndex = 1
        '
        'TBapellido
        '
        Me.TBapellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBapellido.Location = New System.Drawing.Point(120, 66)
        Me.TBapellido.Name = "TBapellido"
        Me.TBapellido.Size = New System.Drawing.Size(200, 20)
        Me.TBapellido.TabIndex = 2
        '
        'TBnombre
        '
        Me.TBnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBnombre.Location = New System.Drawing.Point(120, 92)
        Me.TBnombre.Name = "TBnombre"
        Me.TBnombre.Size = New System.Drawing.Size(200, 20)
        Me.TBnombre.TabIndex = 3
        '
        'TBdomicilio
        '
        Me.TBdomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TBdomicilio.Location = New System.Drawing.Point(411, 90)
        Me.TBdomicilio.MaxLength = 350
        Me.TBdomicilio.Name = "TBdomicilio"
        Me.TBdomicilio.Size = New System.Drawing.Size(200, 20)
        Me.TBdomicilio.TabIndex = 6
        '
        'TBemail
        '
        Me.TBemail.Location = New System.Drawing.Point(412, 120)
        Me.TBemail.Name = "TBemail"
        Me.TBemail.Size = New System.Drawing.Size(200, 20)
        Me.TBemail.TabIndex = 8
        '
        'TBdni
        '
        Me.TBdni.Location = New System.Drawing.Point(120, 118)
        Me.TBdni.MaxLength = 8
        Me.TBdni.Name = "TBdni"
        Me.TBdni.Size = New System.Drawing.Size(200, 20)
        Me.TBdni.TabIndex = 4
        '
        'TBtelefono
        '
        Me.TBtelefono.Location = New System.Drawing.Point(411, 64)
        Me.TBtelefono.MaxLength = 10
        Me.TBtelefono.Name = "TBtelefono"
        Me.TBtelefono.Size = New System.Drawing.Size(200, 20)
        Me.TBtelefono.TabIndex = 5
        '
        'PanelBotones
        '
        Me.PanelBotones.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelBotones.Controls.Add(Me.Label11)
        Me.PanelBotones.Controls.Add(Me.Bagregar)
        Me.PanelBotones.Controls.Add(Me.Bmostrar)
        Me.PanelBotones.Location = New System.Drawing.Point(240, 22)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(300, 100)
        Me.PanelBotones.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(94, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 25)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Clientes"
        '
        'PanelMostrarTodos
        '
        Me.PanelMostrarTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelMostrarTodos.Controls.Add(Me.BTActivos)
        Me.PanelMostrarTodos.Controls.Add(Me.BTInactivo)
        Me.PanelMostrarTodos.Controls.Add(Me.apecliente)
        Me.PanelMostrarTodos.Controls.Add(Me.dnicli)
        Me.PanelMostrarTodos.Controls.Add(Me.Label15)
        Me.PanelMostrarTodos.Controls.Add(Me.TextBoxBuscar)
        Me.PanelMostrarTodos.Controls.Add(Me.ClientesDataGridView)
        Me.PanelMostrarTodos.Controls.Add(Me.Label12)
        Me.PanelMostrarTodos.Controls.Add(Me.Beliminar)
        Me.PanelMostrarTodos.Controls.Add(Me.Bmodificar)
        Me.PanelMostrarTodos.Location = New System.Drawing.Point(44, 107)
        Me.PanelMostrarTodos.Name = "PanelMostrarTodos"
        Me.PanelMostrarTodos.Size = New System.Drawing.Size(766, 254)
        Me.PanelMostrarTodos.TabIndex = 60
        '
        'BTActivos
        '
        Me.BTActivos.Location = New System.Drawing.Point(659, 42)
        Me.BTActivos.Name = "BTActivos"
        Me.BTActivos.Size = New System.Drawing.Size(78, 23)
        Me.BTActivos.TabIndex = 66
        Me.BTActivos.Text = "Activos"
        Me.BTActivos.UseVisualStyleBackColor = True
        '
        'BTInactivo
        '
        Me.BTInactivo.Location = New System.Drawing.Point(659, 35)
        Me.BTInactivo.Name = "BTInactivo"
        Me.BTInactivo.Size = New System.Drawing.Size(75, 23)
        Me.BTInactivo.TabIndex = 65
        Me.BTInactivo.Text = "Inactivos"
        Me.BTInactivo.UseVisualStyleBackColor = True
        '
        'apecliente
        '
        Me.apecliente.AutoSize = True
        Me.apecliente.Location = New System.Drawing.Point(187, 41)
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
        Me.IdclienteDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdclienteDataGridViewTextBoxColumn.Name = "IdclienteDataGridViewTextBoxColumn"
        Me.IdclienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DniDataGridViewTextBoxColumn
        '
        Me.DniDataGridViewTextBoxColumn.DataPropertyName = "dni"
        Me.DniDataGridViewTextBoxColumn.HeaderText = "DNI"
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
        Me.FechanacDataGridViewTextBoxColumn.HeaderText = "F.Nacimiento"
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
        Me.EliminadoDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EliminadoDataGridViewImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'PanelNuevo
        '
        Me.PanelNuevo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelNuevo.Controls.Add(Me.FechaNacDateTimePicker)
        Me.PanelNuevo.Controls.Add(Label13)
        Me.PanelNuevo.Controls.Add(Me.BTGuardar)
        Me.PanelNuevo.Controls.Add(Me.BTLimpiar)
        Me.PanelNuevo.Controls.Add(Me.Label1)
        Me.PanelNuevo.Controls.Add(Me.TBtelefono)
        Me.PanelNuevo.Controls.Add(TelefonoLabel)
        Me.PanelNuevo.Controls.Add(Me.TBdni)
        Me.PanelNuevo.Controls.Add(Usuario_dniLabel)
        Me.PanelNuevo.Controls.Add(Me.TBidcliente)
        Me.PanelNuevo.Controls.Add(Me.TBemail)
        Me.PanelNuevo.Controls.Add(ApellidoLabel)
        Me.PanelNuevo.Controls.Add(EmailLabel)
        Me.PanelNuevo.Controls.Add(Me.TBapellido)
        Me.PanelNuevo.Controls.Add(Me.TBdomicilio)
        Me.PanelNuevo.Controls.Add(NombreLabel)
        Me.PanelNuevo.Controls.Add(DomicilioLabel)
        Me.PanelNuevo.Controls.Add(Me.TBnombre)
        Me.PanelNuevo.Location = New System.Drawing.Point(57, 85)
        Me.PanelNuevo.Name = "PanelNuevo"
        Me.PanelNuevo.Size = New System.Drawing.Size(659, 207)
        Me.PanelNuevo.TabIndex = 61
        '
        'FechaNacDateTimePicker
        '
        Me.FechaNacDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaNacDateTimePicker.Location = New System.Drawing.Point(120, 147)
        Me.FechaNacDateTimePicker.Name = "FechaNacDateTimePicker"
        Me.FechaNacDateTimePicker.Size = New System.Drawing.Size(109, 20)
        Me.FechaNacDateTimePicker.TabIndex = 61
        '
        'BTGuardar
        '
        Me.BTGuardar.Location = New System.Drawing.Point(243, 178)
        Me.BTGuardar.Name = "BTGuardar"
        Me.BTGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BTGuardar.TabIndex = 60
        Me.BTGuardar.Text = "Guardar"
        Me.BTGuardar.UseVisualStyleBackColor = True
        '
        'BTLimpiar
        '
        Me.BTLimpiar.Location = New System.Drawing.Point(380, 178)
        Me.BTLimpiar.Name = "BTLimpiar"
        Me.BTLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTLimpiar.TabIndex = 59
        Me.BTLimpiar.Text = "Limpiar"
        Me.BTLimpiar.UseVisualStyleBackColor = True
        '
        'PanelModificar
        '
        Me.PanelModificar.BackColor = System.Drawing.Color.Violet
        Me.PanelModificar.Controls.Add(Me.FechaNacDateTimePicker2)
        Me.PanelModificar.Controls.Add(Label14)
        Me.PanelModificar.Controls.Add(Me.BTGrabar2)
        Me.PanelModificar.Controls.Add(Me.Label2)
        Me.PanelModificar.Controls.Add(Label3)
        Me.PanelModificar.Controls.Add(Me.TBtelefono2)
        Me.PanelModificar.Controls.Add(Me.CBeliminado2)
        Me.PanelModificar.Controls.Add(Label4)
        Me.PanelModificar.Controls.Add(Me.TBdni2)
        Me.PanelModificar.Controls.Add(Label5)
        Me.PanelModificar.Controls.Add(Label6)
        Me.PanelModificar.Controls.Add(Me.TBidcliente2)
        Me.PanelModificar.Controls.Add(Me.TBemail2)
        Me.PanelModificar.Controls.Add(Label7)
        Me.PanelModificar.Controls.Add(Label8)
        Me.PanelModificar.Controls.Add(Me.TBapellido2)
        Me.PanelModificar.Controls.Add(Me.TBdomicilio2)
        Me.PanelModificar.Controls.Add(Label9)
        Me.PanelModificar.Controls.Add(Label10)
        Me.PanelModificar.Controls.Add(Me.TBnombre2)
        Me.PanelModificar.Location = New System.Drawing.Point(41, 128)
        Me.PanelModificar.Name = "PanelModificar"
        Me.PanelModificar.Size = New System.Drawing.Size(659, 207)
        Me.PanelModificar.TabIndex = 62
        '
        'FechaNacDateTimePicker2
        '
        Me.FechaNacDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaNacDateTimePicker2.Location = New System.Drawing.Point(114, 156)
        Me.FechaNacDateTimePicker2.Name = "FechaNacDateTimePicker2"
        Me.FechaNacDateTimePicker2.Size = New System.Drawing.Size(109, 20)
        Me.FechaNacDateTimePicker2.TabIndex = 63
        '
        'BTGrabar2
        '
        Me.BTGrabar2.Location = New System.Drawing.Point(300, 181)
        Me.BTGrabar2.Name = "BTGrabar2"
        Me.BTGrabar2.Size = New System.Drawing.Size(75, 23)
        Me.BTGrabar2.TabIndex = 59
        Me.BTGrabar2.Text = "Grabar"
        Me.BTGrabar2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(234, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 25)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Modificar Cliente"
        '
        'TBtelefono2
        '
        Me.TBtelefono2.Location = New System.Drawing.Point(411, 64)
        Me.TBtelefono2.MaxLength = 10
        Me.TBtelefono2.Name = "TBtelefono2"
        Me.TBtelefono2.Size = New System.Drawing.Size(200, 20)
        Me.TBtelefono2.TabIndex = 5
        '
        'CBeliminado2
        '
        Me.CBeliminado2.FormattingEnabled = True
        Me.CBeliminado2.Items.AddRange(New Object() {"NO", "SI"})
        Me.CBeliminado2.Location = New System.Drawing.Point(411, 115)
        Me.CBeliminado2.Name = "CBeliminado2"
        Me.CBeliminado2.Size = New System.Drawing.Size(200, 21)
        Me.CBeliminado2.TabIndex = 7
        '
        'TBdni2
        '
        Me.TBdni2.Location = New System.Drawing.Point(114, 131)
        Me.TBdni2.MaxLength = 8
        Me.TBdni2.Name = "TBdni2"
        Me.TBdni2.Size = New System.Drawing.Size(200, 20)
        Me.TBdni2.TabIndex = 4
        '
        'TBidcliente2
        '
        Me.TBidcliente2.Enabled = False
        Me.TBidcliente2.Location = New System.Drawing.Point(114, 45)
        Me.TBidcliente2.Name = "TBidcliente2"
        Me.TBidcliente2.Size = New System.Drawing.Size(70, 20)
        Me.TBidcliente2.TabIndex = 1
        '
        'TBemail2
        '
        Me.TBemail2.Location = New System.Drawing.Point(411, 142)
        Me.TBemail2.Name = "TBemail2"
        Me.TBemail2.Size = New System.Drawing.Size(200, 20)
        Me.TBemail2.TabIndex = 8
        '
        'TBapellido2
        '
        Me.TBapellido2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBapellido2.Location = New System.Drawing.Point(114, 79)
        Me.TBapellido2.Name = "TBapellido2"
        Me.TBapellido2.Size = New System.Drawing.Size(200, 20)
        Me.TBapellido2.TabIndex = 2
        '
        'TBdomicilio2
        '
        Me.TBdomicilio2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TBdomicilio2.Location = New System.Drawing.Point(411, 90)
        Me.TBdomicilio2.MaxLength = 600
        Me.TBdomicilio2.Name = "TBdomicilio2"
        Me.TBdomicilio2.Size = New System.Drawing.Size(200, 20)
        Me.TBdomicilio2.TabIndex = 6
        '
        'TBnombre2
        '
        Me.TBnombre2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBnombre2.Location = New System.Drawing.Point(114, 105)
        Me.TBnombre2.Name = "TBnombre2"
        Me.TBnombre2.Size = New System.Drawing.Size(200, 20)
        Me.TBnombre2.TabIndex = 3
        '
        'BTvolver
        '
        Me.BTvolver.Location = New System.Drawing.Point(26, 13)
        Me.BTvolver.Name = "BTvolver"
        Me.BTvolver.Size = New System.Drawing.Size(75, 23)
        Me.BTvolver.TabIndex = 63
        Me.BTvolver.Text = "Volver"
        Me.BTvolver.UseVisualStyleBackColor = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'gestionClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 398)
        Me.Controls.Add(Me.PanelNuevo)
        Me.Controls.Add(Me.PanelMostrarTodos)
        Me.Controls.Add(Me.PanelModificar)
        Me.Controls.Add(Me.BTvolver)
        Me.Controls.Add(Me.PanelBotones)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gestionClientes"
        Me.Text = "Gestión Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelBotones.ResumeLayout(False)
        Me.PanelBotones.PerformLayout()
        Me.PanelMostrarTodos.ResumeLayout(False)
        Me.PanelMostrarTodos.PerformLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNuevo.ResumeLayout(False)
        Me.PanelNuevo.PerformLayout()
        Me.PanelModificar.ResumeLayout(False)
        Me.PanelModificar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Bmostrar As Button
    Friend WithEvents Beliminar As Button
    Friend WithEvents Bmodificar As Button
    Friend WithEvents Bagregar As Button
    Friend WithEvents TBidcliente As TextBox
    Friend WithEvents TBapellido As TextBox
    Friend WithEvents TBnombre As TextBox
    Friend WithEvents TBdomicilio As TextBox
    Friend WithEvents TBemail As TextBox
    Friend WithEvents TBdni As TextBox
    Friend WithEvents TBtelefono As TextBox
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents PanelMostrarTodos As Panel
    Friend WithEvents PanelNuevo As Panel
    Friend WithEvents PanelModificar As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TBtelefono2 As TextBox
    Friend WithEvents CBeliminado2 As ComboBox
    Friend WithEvents TBdni2 As TextBox
    Friend WithEvents TBidcliente2 As TextBox
    Friend WithEvents TBemail2 As TextBox
    Friend WithEvents TBapellido2 As TextBox
    Friend WithEvents TBdomicilio2 As TextBox
    Friend WithEvents TBnombre2 As TextBox
    Friend WithEvents BTGuardar As Button
    Friend WithEvents BTLimpiar As Button
    Friend WithEvents BTGrabar2 As Button
    Friend WithEvents BTvolver As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents BaseDataSet As BaseDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As BaseDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents apecliente As RadioButton
    Friend WithEvents dnicli As RadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents BTActivos As Button
    Friend WithEvents BTInactivo As Button
    Friend WithEvents FechaNacDateTimePicker As DateTimePicker
    Friend WithEvents FechaNacDateTimePicker2 As DateTimePicker
    Friend WithEvents IdclienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DniDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechanacDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EliminadoDataGridViewImageColumn As DataGridViewTextBoxColumn
End Class
