<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gestionUsuarios
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
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim Id_perfilLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Usuario_dniLabel As System.Windows.Forms.Label
        Dim FechaNacLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EliminadoLabel As System.Windows.Forms.Label
        Dim Id_usuarioLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestionUsuarios))
        Me.UsuariosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.UsuariosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TBapellido2 = New System.Windows.Forms.TextBox()
        Me.TBnombre2 = New System.Windows.Forms.TextBox()
        Me.TBnombusuario2 = New System.Windows.Forms.TextBox()
        Me.TBpass2 = New System.Windows.Forms.TextBox()
        Me.TBemail2 = New System.Windows.Forms.TextBox()
        Me.TBdni2 = New System.Windows.Forms.TextBox()
        Me.FechaNacDateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TBtelefono2 = New System.Windows.Forms.TextBox()
        Me.UsuariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contraseña = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eliminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bmostrar = New System.Windows.Forms.Button()
        Me.Beliminar = New System.Windows.Forms.Button()
        Me.Bmodificar = New System.Windows.Forms.Button()
        Me.Bagregar = New System.Windows.Forms.Button()
        Me.UsuariosTableAdapter = New proyecto.BaseDataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New proyecto.BaseDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBidusuario2 = New System.Windows.Forms.TextBox()
        Me.CBeliminado2 = New System.Windows.Forms.ComboBox()
        Me.CBidperfil2 = New System.Windows.Forms.ComboBox()
        Me.PanelMostrarTodos = New System.Windows.Forms.Panel()
        Me.BTActivos = New System.Windows.Forms.Button()
        Me.BTInactivo = New System.Windows.Forms.Button()
        Me.nyap = New System.Windows.Forms.RadioButton()
        Me.dni = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PanelModificar = New System.Windows.Forms.Panel()
        Me.BTGuardarModif = New System.Windows.Forms.Button()
        Me.BTVolver = New System.Windows.Forms.Button()
        Me.PanelNuevo = New System.Windows.Forms.Panel()
        Me.TBidusuario = New System.Windows.Forms.TextBox()
        Me.BTGuardar = New System.Windows.Forms.Button()
        Me.BTLimpiar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBidperfil = New System.Windows.Forms.ComboBox()
        Me.TBtelefono = New System.Windows.Forms.TextBox()
        Me.FechaNacDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TBdni = New System.Windows.Forms.TextBox()
        Me.TBapellido = New System.Windows.Forms.TextBox()
        Me.TBemail = New System.Windows.Forms.TextBox()
        Me.TBnombre = New System.Windows.Forms.TextBox()
        Me.TBpass = New System.Windows.Forms.TextBox()
        Me.TBnombusuario = New System.Windows.Forms.TextBox()
        ApellidoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        Id_perfilLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Usuario_dniLabel = New System.Windows.Forms.Label()
        FechaNacLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EliminadoLabel = New System.Windows.Forms.Label()
        Id_usuarioLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        CType(Me.UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsuariosBindingNavigator.SuspendLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMostrarTodos.SuspendLayout()
        Me.PanelBotones.SuspendLayout()
        Me.PanelModificar.SuspendLayout()
        Me.PanelNuevo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(22, 75)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 3
        ApellidoLabel.Text = "Apellido:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(22, 101)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 5
        NombreLabel.Text = "Nombre:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(307, 49)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(84, 13)
        UsuarioLabel.TabIndex = 7
        UsuarioLabel.Text = "Nombre usuario:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Location = New System.Drawing.Point(307, 75)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(64, 13)
        ContraseñaLabel.TabIndex = 9
        ContraseñaLabel.Text = "Contraseña:"
        '
        'Id_perfilLabel
        '
        Id_perfilLabel.AutoSize = True
        Id_perfilLabel.Location = New System.Drawing.Point(307, 101)
        Id_perfilLabel.Name = "Id_perfilLabel"
        Id_perfilLabel.Size = New System.Drawing.Size(46, 13)
        Id_perfilLabel.TabIndex = 11
        Id_perfilLabel.Text = "ID perfil:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(22, 161)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 13
        EmailLabel.Text = "Email:"
        '
        'Usuario_dniLabel
        '
        Usuario_dniLabel.AutoSize = True
        Usuario_dniLabel.Location = New System.Drawing.Point(328, 161)
        Usuario_dniLabel.Name = "Usuario_dniLabel"
        Usuario_dniLabel.Size = New System.Drawing.Size(29, 13)
        Usuario_dniLabel.TabIndex = 15
        Usuario_dniLabel.Text = "DNI:"
        '
        'FechaNacLabel
        '
        FechaNacLabel.AutoSize = True
        FechaNacLabel.Location = New System.Drawing.Point(22, 194)
        FechaNacLabel.Name = "FechaNacLabel"
        FechaNacLabel.Size = New System.Drawing.Size(66, 13)
        FechaNacLabel.TabIndex = 17
        FechaNacLabel.Text = "Fecha Nac.:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(22, 129)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 19
        TelefonoLabel.Text = "Teléfono:"
        '
        'EliminadoLabel
        '
        EliminadoLabel.AutoSize = True
        EliminadoLabel.Location = New System.Drawing.Point(307, 133)
        EliminadoLabel.Name = "EliminadoLabel"
        EliminadoLabel.Size = New System.Drawing.Size(55, 13)
        EliminadoLabel.TabIndex = 21
        EliminadoLabel.Text = "Eliminado:"
        '
        'Id_usuarioLabel
        '
        Id_usuarioLabel.AutoSize = True
        Id_usuarioLabel.Location = New System.Drawing.Point(22, 49)
        Id_usuarioLabel.Name = "Id_usuarioLabel"
        Id_usuarioLabel.Size = New System.Drawing.Size(58, 13)
        Id_usuarioLabel.TabIndex = 1
        Id_usuarioLabel.Text = "ID usuario:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(22, 104)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(52, 13)
        Label5.TabIndex = 19
        Label5.Text = "Teléfono:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(330, 51)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(66, 13)
        Label7.TabIndex = 17
        Label7.Text = "Fecha Nac.:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(22, 50)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(47, 13)
        Label8.TabIndex = 3
        Label8.Text = "Apellido:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(22, 159)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(29, 13)
        Label9.TabIndex = 15
        Label9.Text = "DNI:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(22, 76)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(47, 13)
        Label10.TabIndex = 5
        Label10.Text = "Nombre:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(22, 133)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(35, 13)
        Label11.TabIndex = 13
        Label11.Text = "Email:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(307, 130)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(46, 13)
        Label12.TabIndex = 11
        Label12.Text = "ID perfil:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(307, 78)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(84, 13)
        Label13.TabIndex = 7
        Label13.Text = "Nombre usuario:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(307, 104)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(64, 13)
        Label14.TabIndex = 9
        Label14.Text = "Contraseña:"
        '
        'UsuariosBindingNavigator
        '
        Me.UsuariosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsuariosBindingNavigator.BindingSource = Me.UsuariosBindingSource
        Me.UsuariosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UsuariosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UsuariosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UsuariosBindingNavigatorSaveItem})
        Me.UsuariosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UsuariosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UsuariosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UsuariosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UsuariosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UsuariosBindingNavigator.Name = "UsuariosBindingNavigator"
        Me.UsuariosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UsuariosBindingNavigator.Size = New System.Drawing.Size(869, 25)
        Me.UsuariosBindingNavigator.TabIndex = 0
        Me.UsuariosBindingNavigator.Text = "BindingNavigator1"
        Me.UsuariosBindingNavigator.Visible = False
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
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.BaseDataSet
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
        'UsuariosBindingNavigatorSaveItem
        '
        Me.UsuariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsuariosBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsuariosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsuariosBindingNavigatorSaveItem.Name = "UsuariosBindingNavigatorSaveItem"
        Me.UsuariosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UsuariosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TBapellido2
        '
        Me.TBapellido2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBapellido2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "apellido", True))
        Me.TBapellido2.Location = New System.Drawing.Point(91, 72)
        Me.TBapellido2.Name = "TBapellido2"
        Me.TBapellido2.Size = New System.Drawing.Size(200, 20)
        Me.TBapellido2.TabIndex = 1
        '
        'TBnombre2
        '
        Me.TBnombre2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBnombre2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "nombre", True))
        Me.TBnombre2.Location = New System.Drawing.Point(91, 98)
        Me.TBnombre2.Name = "TBnombre2"
        Me.TBnombre2.Size = New System.Drawing.Size(200, 20)
        Me.TBnombre2.TabIndex = 2
        '
        'TBnombusuario2
        '
        Me.TBnombusuario2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TBnombusuario2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "usuario", True))
        Me.TBnombusuario2.Location = New System.Drawing.Point(397, 46)
        Me.TBnombusuario2.MaxLength = 15
        Me.TBnombusuario2.Name = "TBnombusuario2"
        Me.TBnombusuario2.Size = New System.Drawing.Size(200, 20)
        Me.TBnombusuario2.TabIndex = 4
        '
        'TBpass2
        '
        Me.TBpass2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "contraseña", True))
        Me.TBpass2.Location = New System.Drawing.Point(397, 72)
        Me.TBpass2.Name = "TBpass2"
        Me.TBpass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TBpass2.Size = New System.Drawing.Size(200, 20)
        Me.TBpass2.TabIndex = 5
        '
        'TBemail2
        '
        Me.TBemail2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "email", True))
        Me.TBemail2.Location = New System.Drawing.Point(91, 158)
        Me.TBemail2.Name = "TBemail2"
        Me.TBemail2.Size = New System.Drawing.Size(200, 20)
        Me.TBemail2.TabIndex = 8
        '
        'TBdni2
        '
        Me.TBdni2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "usuario_dni", True))
        Me.TBdni2.Location = New System.Drawing.Point(397, 158)
        Me.TBdni2.MaxLength = 8
        Me.TBdni2.Name = "TBdni2"
        Me.TBdni2.Size = New System.Drawing.Size(200, 20)
        Me.TBdni2.TabIndex = 9
        '
        'FechaNacDateTimePicker2
        '
        Me.FechaNacDateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UsuariosBindingSource, "fechaNac", True))
        Me.FechaNacDateTimePicker2.Location = New System.Drawing.Point(91, 190)
        Me.FechaNacDateTimePicker2.Name = "FechaNacDateTimePicker2"
        Me.FechaNacDateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.FechaNacDateTimePicker2.TabIndex = 10
        '
        'TBtelefono2
        '
        Me.TBtelefono2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "telefono", True))
        Me.TBtelefono2.Location = New System.Drawing.Point(91, 126)
        Me.TBtelefono2.MaxLength = 10
        Me.TBtelefono2.Name = "TBtelefono2"
        Me.TBtelefono2.Size = New System.Drawing.Size(200, 20)
        Me.TBtelefono2.TabIndex = 3
        '
        'UsuariosDataGridView
        '
        Me.UsuariosDataGridView.AllowUserToAddRows = False
        Me.UsuariosDataGridView.AllowUserToDeleteRows = False
        Me.UsuariosDataGridView.AutoGenerateColumns = False
        Me.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.contraseña, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.eliminado})
        Me.UsuariosDataGridView.DataSource = Me.UsuariosBindingSource
        Me.UsuariosDataGridView.Location = New System.Drawing.Point(25, 62)
        Me.UsuariosDataGridView.Name = "UsuariosDataGridView"
        Me.UsuariosDataGridView.ReadOnly = True
        Me.UsuariosDataGridView.Size = New System.Drawing.Size(827, 138)
        Me.UsuariosDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_usuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "usuario"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'contraseña
        '
        Me.contraseña.DataPropertyName = "contraseña"
        Me.contraseña.HeaderText = "Contraseña"
        Me.contraseña.Name = "contraseña"
        Me.contraseña.ReadOnly = True
        Me.contraseña.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_perfil"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Perfil"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "usuario_dni"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DNI"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "fechaNac"
        Me.DataGridViewTextBoxColumn9.HeaderText = "F.Nacimiento"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'eliminado
        '
        Me.eliminado.DataPropertyName = "eliminado"
        Me.eliminado.HeaderText = "eliminado"
        Me.eliminado.Name = "eliminado"
        Me.eliminado.ReadOnly = True
        Me.eliminado.Visible = False
        '
        'Bmostrar
        '
        Me.Bmostrar.Location = New System.Drawing.Point(166, 55)
        Me.Bmostrar.Name = "Bmostrar"
        Me.Bmostrar.Size = New System.Drawing.Size(131, 23)
        Me.Bmostrar.TabIndex = 15
        Me.Bmostrar.Text = "Mostrar"
        Me.Bmostrar.UseVisualStyleBackColor = True
        '
        'Beliminar
        '
        Me.Beliminar.Location = New System.Drawing.Point(297, 28)
        Me.Beliminar.Name = "Beliminar"
        Me.Beliminar.Size = New System.Drawing.Size(75, 23)
        Me.Beliminar.TabIndex = 12
        Me.Beliminar.Text = "Eliminar"
        Me.Beliminar.UseVisualStyleBackColor = True
        '
        'Bmodificar
        '
        Me.Bmodificar.Location = New System.Drawing.Point(606, 29)
        Me.Bmodificar.Name = "Bmodificar"
        Me.Bmodificar.Size = New System.Drawing.Size(75, 23)
        Me.Bmodificar.TabIndex = 13
        Me.Bmodificar.Text = "Modificar"
        Me.Bmodificar.UseVisualStyleBackColor = True
        '
        'Bagregar
        '
        Me.Bagregar.Location = New System.Drawing.Point(69, 54)
        Me.Bagregar.Name = "Bagregar"
        Me.Bagregar.Size = New System.Drawing.Size(75, 23)
        Me.Bagregar.TabIndex = 11
        Me.Bagregar.Text = "Agregar"
        Me.Bagregar.UseVisualStyleBackColor = True
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = proyecto.BaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        Me.TableAdapterManager.Ventas_cabeceraTableAdapter = Nothing
        Me.TableAdapterManager.Ventas_detalleTableAdapter = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 25)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Modificar Usuario"
        '
        'TBidusuario2
        '
        Me.TBidusuario2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "id_usuario", True))
        Me.TBidusuario2.Enabled = False
        Me.TBidusuario2.Location = New System.Drawing.Point(91, 46)
        Me.TBidusuario2.Name = "TBidusuario2"
        Me.TBidusuario2.Size = New System.Drawing.Size(200, 20)
        Me.TBidusuario2.TabIndex = 0
        '
        'CBeliminado2
        '
        Me.CBeliminado2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBeliminado2.FormattingEnabled = True
        Me.CBeliminado2.Items.AddRange(New Object() {"NO", "SI"})
        Me.CBeliminado2.Location = New System.Drawing.Point(397, 126)
        Me.CBeliminado2.Name = "CBeliminado2"
        Me.CBeliminado2.Size = New System.Drawing.Size(200, 21)
        Me.CBeliminado2.TabIndex = 7
        '
        'CBidperfil2
        '
        Me.CBidperfil2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBidperfil2.FormattingEnabled = True
        Me.CBidperfil2.Items.AddRange(New Object() {"1 - CAJERO", "2 - GESTION", "3 - SISTEMAS"})
        Me.CBidperfil2.Location = New System.Drawing.Point(397, 99)
        Me.CBidperfil2.Name = "CBidperfil2"
        Me.CBidperfil2.Size = New System.Drawing.Size(200, 21)
        Me.CBidperfil2.TabIndex = 6
        '
        'PanelMostrarTodos
        '
        Me.PanelMostrarTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelMostrarTodos.Controls.Add(Me.BTActivos)
        Me.PanelMostrarTodos.Controls.Add(Me.BTInactivo)
        Me.PanelMostrarTodos.Controls.Add(Me.nyap)
        Me.PanelMostrarTodos.Controls.Add(Me.dni)
        Me.PanelMostrarTodos.Controls.Add(Me.Label15)
        Me.PanelMostrarTodos.Controls.Add(Me.TextBoxBuscar)
        Me.PanelMostrarTodos.Controls.Add(Me.Label2)
        Me.PanelMostrarTodos.Controls.Add(Me.UsuariosDataGridView)
        Me.PanelMostrarTodos.Controls.Add(Me.Bmodificar)
        Me.PanelMostrarTodos.Controls.Add(Me.Beliminar)
        Me.PanelMostrarTodos.Location = New System.Drawing.Point(12, 65)
        Me.PanelMostrarTodos.Name = "PanelMostrarTodos"
        Me.PanelMostrarTodos.Size = New System.Drawing.Size(875, 221)
        Me.PanelMostrarTodos.TabIndex = 31
        '
        'BTActivos
        '
        Me.BTActivos.Location = New System.Drawing.Point(756, 29)
        Me.BTActivos.Name = "BTActivos"
        Me.BTActivos.Size = New System.Drawing.Size(78, 23)
        Me.BTActivos.TabIndex = 45
        Me.BTActivos.Text = "Activos"
        Me.BTActivos.UseVisualStyleBackColor = True
        '
        'BTInactivo
        '
        Me.BTInactivo.Location = New System.Drawing.Point(756, 22)
        Me.BTInactivo.Name = "BTInactivo"
        Me.BTInactivo.Size = New System.Drawing.Size(75, 23)
        Me.BTInactivo.TabIndex = 44
        Me.BTInactivo.Text = "Inactivos"
        Me.BTInactivo.UseVisualStyleBackColor = True
        '
        'nyap
        '
        Me.nyap.AutoSize = True
        Me.nyap.Location = New System.Drawing.Point(201, 32)
        Me.nyap.Name = "nyap"
        Me.nyap.Size = New System.Drawing.Size(62, 17)
        Me.nyap.TabIndex = 40
        Me.nyap.TabStop = True
        Me.nyap.Text = "Apellido"
        Me.nyap.UseVisualStyleBackColor = True
        '
        'dni
        '
        Me.dni.AutoSize = True
        Me.dni.Location = New System.Drawing.Point(131, 32)
        Me.dni.Name = "dni"
        Me.dni.Size = New System.Drawing.Size(44, 17)
        Me.dni.TabIndex = 39
        Me.dni.TabStop = True
        Me.dni.Text = "Dni."
        Me.dni.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(25, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Buscar"
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(25, 32)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBuscar.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(378, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 25)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Todos los Usuarios"
        '
        'PanelBotones
        '
        Me.PanelBotones.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelBotones.Controls.Add(Me.Label16)
        Me.PanelBotones.Controls.Add(Me.Bagregar)
        Me.PanelBotones.Controls.Add(Me.Bmostrar)
        Me.PanelBotones.Location = New System.Drawing.Point(282, 17)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(330, 100)
        Me.PanelBotones.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(107, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 25)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Usuarios"
        '
        'PanelModificar
        '
        Me.PanelModificar.BackColor = System.Drawing.SystemColors.Highlight
        Me.PanelModificar.Controls.Add(Me.BTGuardarModif)
        Me.PanelModificar.Controls.Add(Me.Label1)
        Me.PanelModificar.Controls.Add(EliminadoLabel)
        Me.PanelModificar.Controls.Add(Me.CBidperfil2)
        Me.PanelModificar.Controls.Add(Me.TBtelefono2)
        Me.PanelModificar.Controls.Add(Me.CBeliminado2)
        Me.PanelModificar.Controls.Add(TelefonoLabel)
        Me.PanelModificar.Controls.Add(Me.FechaNacDateTimePicker2)
        Me.PanelModificar.Controls.Add(Id_usuarioLabel)
        Me.PanelModificar.Controls.Add(FechaNacLabel)
        Me.PanelModificar.Controls.Add(Me.TBidusuario2)
        Me.PanelModificar.Controls.Add(Me.TBdni2)
        Me.PanelModificar.Controls.Add(ApellidoLabel)
        Me.PanelModificar.Controls.Add(Usuario_dniLabel)
        Me.PanelModificar.Controls.Add(Me.TBapellido2)
        Me.PanelModificar.Controls.Add(Me.TBemail2)
        Me.PanelModificar.Controls.Add(NombreLabel)
        Me.PanelModificar.Controls.Add(EmailLabel)
        Me.PanelModificar.Controls.Add(Me.TBnombre2)
        Me.PanelModificar.Controls.Add(Id_perfilLabel)
        Me.PanelModificar.Controls.Add(UsuarioLabel)
        Me.PanelModificar.Controls.Add(Me.TBpass2)
        Me.PanelModificar.Controls.Add(Me.TBnombusuario2)
        Me.PanelModificar.Controls.Add(ContraseñaLabel)
        Me.PanelModificar.Location = New System.Drawing.Point(51, 34)
        Me.PanelModificar.Name = "PanelModificar"
        Me.PanelModificar.Size = New System.Drawing.Size(625, 249)
        Me.PanelModificar.TabIndex = 34
        '
        'BTGuardarModif
        '
        Me.BTGuardarModif.Location = New System.Drawing.Point(408, 197)
        Me.BTGuardarModif.Name = "BTGuardarModif"
        Me.BTGuardarModif.Size = New System.Drawing.Size(75, 23)
        Me.BTGuardarModif.TabIndex = 31
        Me.BTGuardarModif.Text = "Guardar"
        Me.BTGuardarModif.UseVisualStyleBackColor = True
        '
        'BTVolver
        '
        Me.BTVolver.Location = New System.Drawing.Point(24, 5)
        Me.BTVolver.Name = "BTVolver"
        Me.BTVolver.Size = New System.Drawing.Size(75, 23)
        Me.BTVolver.TabIndex = 35
        Me.BTVolver.Text = "Volver"
        Me.BTVolver.UseVisualStyleBackColor = True
        '
        'PanelNuevo
        '
        Me.PanelNuevo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelNuevo.Controls.Add(Me.TBidusuario)
        Me.PanelNuevo.Controls.Add(Me.BTGuardar)
        Me.PanelNuevo.Controls.Add(Me.BTLimpiar)
        Me.PanelNuevo.Controls.Add(Me.Label3)
        Me.PanelNuevo.Controls.Add(Me.CBidperfil)
        Me.PanelNuevo.Controls.Add(Me.TBtelefono)
        Me.PanelNuevo.Controls.Add(Label5)
        Me.PanelNuevo.Controls.Add(Me.FechaNacDateTimePicker)
        Me.PanelNuevo.Controls.Add(Label7)
        Me.PanelNuevo.Controls.Add(Me.TBdni)
        Me.PanelNuevo.Controls.Add(Label8)
        Me.PanelNuevo.Controls.Add(Label9)
        Me.PanelNuevo.Controls.Add(Me.TBapellido)
        Me.PanelNuevo.Controls.Add(Me.TBemail)
        Me.PanelNuevo.Controls.Add(Label10)
        Me.PanelNuevo.Controls.Add(Label11)
        Me.PanelNuevo.Controls.Add(Me.TBnombre)
        Me.PanelNuevo.Controls.Add(Label12)
        Me.PanelNuevo.Controls.Add(Label13)
        Me.PanelNuevo.Controls.Add(Me.TBpass)
        Me.PanelNuevo.Controls.Add(Me.TBnombusuario)
        Me.PanelNuevo.Controls.Add(Label14)
        Me.PanelNuevo.Location = New System.Drawing.Point(26, 49)
        Me.PanelNuevo.Name = "PanelNuevo"
        Me.PanelNuevo.Size = New System.Drawing.Size(667, 216)
        Me.PanelNuevo.TabIndex = 35
        '
        'TBidusuario
        '
        Me.TBidusuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "id_usuario", True))
        Me.TBidusuario.Enabled = False
        Me.TBidusuario.Location = New System.Drawing.Point(91, 23)
        Me.TBidusuario.Name = "TBidusuario"
        Me.TBidusuario.Size = New System.Drawing.Size(200, 20)
        Me.TBidusuario.TabIndex = 33
        '
        'BTGuardar
        '
        Me.BTGuardar.Location = New System.Drawing.Point(433, 182)
        Me.BTGuardar.Name = "BTGuardar"
        Me.BTGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BTGuardar.TabIndex = 32
        Me.BTGuardar.Text = "Guardar"
        Me.BTGuardar.UseVisualStyleBackColor = True
        '
        'BTLimpiar
        '
        Me.BTLimpiar.Location = New System.Drawing.Point(187, 182)
        Me.BTLimpiar.Name = "BTLimpiar"
        Me.BTLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTLimpiar.TabIndex = 31
        Me.BTLimpiar.Text = "Limpiar"
        Me.BTLimpiar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(305, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 25)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Nuevo Usuario"
        '
        'CBidperfil
        '
        Me.CBidperfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBidperfil.FormattingEnabled = True
        Me.CBidperfil.Items.AddRange(New Object() {"1 - CAJERO", "2 - GESTION", "3 - SISTEMAS"})
        Me.CBidperfil.Location = New System.Drawing.Point(397, 128)
        Me.CBidperfil.Name = "CBidperfil"
        Me.CBidperfil.Size = New System.Drawing.Size(200, 21)
        Me.CBidperfil.TabIndex = 6
        '
        'TBtelefono
        '
        Me.TBtelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "telefono", True))
        Me.TBtelefono.Location = New System.Drawing.Point(91, 101)
        Me.TBtelefono.MaxLength = 10
        Me.TBtelefono.Name = "TBtelefono"
        Me.TBtelefono.Size = New System.Drawing.Size(200, 20)
        Me.TBtelefono.TabIndex = 3
        '
        'FechaNacDateTimePicker
        '
        Me.FechaNacDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UsuariosBindingSource, "fechaNac", True))
        Me.FechaNacDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaNacDateTimePicker.Location = New System.Drawing.Point(399, 47)
        Me.FechaNacDateTimePicker.Name = "FechaNacDateTimePicker"
        Me.FechaNacDateTimePicker.Size = New System.Drawing.Size(109, 20)
        Me.FechaNacDateTimePicker.TabIndex = 10
        '
        'TBdni
        '
        Me.TBdni.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "usuario_dni", True))
        Me.TBdni.Location = New System.Drawing.Point(91, 156)
        Me.TBdni.MaxLength = 8
        Me.TBdni.Name = "TBdni"
        Me.TBdni.Size = New System.Drawing.Size(200, 20)
        Me.TBdni.TabIndex = 9
        '
        'TBapellido
        '
        Me.TBapellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBapellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "apellido", True))
        Me.TBapellido.Location = New System.Drawing.Point(91, 47)
        Me.TBapellido.Name = "TBapellido"
        Me.TBapellido.Size = New System.Drawing.Size(200, 20)
        Me.TBapellido.TabIndex = 1
        '
        'TBemail
        '
        Me.TBemail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "email", True))
        Me.TBemail.Location = New System.Drawing.Point(91, 130)
        Me.TBemail.Name = "TBemail"
        Me.TBemail.Size = New System.Drawing.Size(200, 20)
        Me.TBemail.TabIndex = 8
        '
        'TBnombre
        '
        Me.TBnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBnombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "nombre", True))
        Me.TBnombre.Location = New System.Drawing.Point(91, 73)
        Me.TBnombre.Name = "TBnombre"
        Me.TBnombre.Size = New System.Drawing.Size(200, 20)
        Me.TBnombre.TabIndex = 2
        '
        'TBpass
        '
        Me.TBpass.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "contraseña", True))
        Me.TBpass.Location = New System.Drawing.Point(397, 101)
        Me.TBpass.Name = "TBpass"
        Me.TBpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TBpass.Size = New System.Drawing.Size(200, 20)
        Me.TBpass.TabIndex = 5
        '
        'TBnombusuario
        '
        Me.TBnombusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TBnombusuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "usuario", True))
        Me.TBnombusuario.Location = New System.Drawing.Point(397, 75)
        Me.TBnombusuario.MaxLength = 15
        Me.TBnombusuario.Name = "TBnombusuario"
        Me.TBnombusuario.Size = New System.Drawing.Size(200, 20)
        Me.TBnombusuario.TabIndex = 4
        '
        'gestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 408)
        Me.Controls.Add(Me.PanelBotones)
        Me.Controls.Add(Me.PanelNuevo)
        Me.Controls.Add(Me.PanelMostrarTodos)
        Me.Controls.Add(Me.BTVolver)
        Me.Controls.Add(Me.UsuariosBindingNavigator)
        Me.Controls.Add(Me.PanelModificar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gestionUsuarios"
        Me.Text = "Gestión Usuarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsuariosBindingNavigator.ResumeLayout(False)
        Me.UsuariosBindingNavigator.PerformLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMostrarTodos.ResumeLayout(False)
        Me.PanelMostrarTodos.PerformLayout()
        Me.PanelBotones.ResumeLayout(False)
        Me.PanelBotones.PerformLayout()
        Me.PanelModificar.ResumeLayout(False)
        Me.PanelModificar.PerformLayout()
        Me.PanelNuevo.ResumeLayout(False)
        Me.PanelNuevo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BaseDataSet As BaseDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As BaseDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As BaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuariosBindingNavigator As BindingNavigator
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
    Friend WithEvents UsuariosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TBapellido2 As TextBox
    Friend WithEvents TBnombre2 As TextBox
    Friend WithEvents TBnombusuario2 As TextBox
    Friend WithEvents TBpass2 As TextBox
    Friend WithEvents TBemail2 As TextBox
    Friend WithEvents TBdni2 As TextBox
    Friend WithEvents FechaNacDateTimePicker2 As DateTimePicker
    Friend WithEvents TBtelefono2 As TextBox
    Friend WithEvents UsuariosDataGridView As DataGridView
    Friend WithEvents Bmostrar As Button
    Friend WithEvents Beliminar As Button
    Friend WithEvents Bmodificar As Button
    Friend WithEvents Bagregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TBidusuario2 As TextBox
    Friend WithEvents CBeliminado2 As ComboBox
    Friend WithEvents CBidperfil2 As ComboBox
    Friend WithEvents PanelMostrarTodos As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents PanelModificar As Panel
    Friend WithEvents BTVolver As Button
    Friend WithEvents PanelNuevo As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents CBidperfil As ComboBox
    Friend WithEvents TBtelefono As TextBox
    Friend WithEvents FechaNacDateTimePicker As DateTimePicker
    Friend WithEvents TBdni As TextBox
    Friend WithEvents TBapellido As TextBox
    Friend WithEvents TBemail As TextBox
    Friend WithEvents TBnombre As TextBox
    Friend WithEvents TBpass As TextBox
    Friend WithEvents TBnombusuario As TextBox
    Friend WithEvents nyap As RadioButton
    Friend WithEvents dni As RadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents BTGuardarModif As Button
    Friend WithEvents BTGuardar As Button
    Friend WithEvents BTLimpiar As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents TBidusuario As TextBox
    Friend WithEvents BTActivos As Button
    Friend WithEvents BTInactivo As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents contraseña As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents eliminado As DataGridViewTextBoxColumn
End Class
