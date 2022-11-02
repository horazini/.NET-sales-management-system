<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class catProd
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim EliminadoLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(catProd))
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseDataSet = New proyecto.BaseDataSet()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.DescripcionTextBox2 = New System.Windows.Forms.TextBox()
        Me.BTGrabar = New System.Windows.Forms.Button()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PanelNuevo = New System.Windows.Forms.Panel()
        Me.CBEliminado = New System.Windows.Forms.ComboBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Id_categoriaTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Id_categoriaTextBox2 = New System.Windows.Forms.TextBox()
        Me.PanelModificar = New System.Windows.Forms.Panel()
        Me.CBEliminado2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Grabarmodificar = New System.Windows.Forms.Button()
        Me.EliminadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriasTableAdapter = New proyecto.BaseDataSetTableAdapters.CategoriasTableAdapter()
        Me.TableAdapterManager = New proyecto.BaseDataSetTableAdapters.TableAdapterManager()
        Me.PanelMostrartodos = New System.Windows.Forms.Panel()
        Me.BTActivo2 = New System.Windows.Forms.Button()
        Me.BTInactivo2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTActivos = New System.Windows.Forms.Button()
        Me.BTInactivo = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BTModificar = New System.Windows.Forms.Button()
        Me.BTEliminar = New System.Windows.Forms.Button()
        Me.CategoriasDataGridView = New System.Windows.Forms.DataGridView()
        DescripcionLabel = New System.Windows.Forms.Label()
        EliminadoLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBotones.SuspendLayout()
        Me.PanelNuevo.SuspendLayout()
        Me.PanelModificar.SuspendLayout()
        Me.PanelMostrartodos.SuspendLayout()
        CType(Me.CategoriasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(99, 76)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(63, 13)
        DescripcionLabel.TabIndex = 33
        DescripcionLabel.Text = "Descripción"
        '
        'EliminadoLabel
        '
        EliminadoLabel.AutoSize = True
        EliminadoLabel.Location = New System.Drawing.Point(99, 102)
        EliminadoLabel.Name = "EliminadoLabel"
        EliminadoLabel.Size = New System.Drawing.Size(55, 13)
        EliminadoLabel.TabIndex = 35
        EliminadoLabel.Text = "Eliminado:"
        EliminadoLabel.Visible = False
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(128, 92)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(63, 13)
        Label3.TabIndex = 39
        Label3.Text = "Descripción"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(128, 118)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(55, 13)
        Label4.TabIndex = 41
        Label4.Text = "Eliminado:"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "Categorias"
        Me.CategoriasBindingSource.DataSource = Me.BaseDataSet
        '
        'BaseDataSet
        '
        Me.BaseDataSet.DataSetName = "BaseDataSet"
        Me.BaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(212, 157)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "Grabar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BTCancelar
        '
        Me.BTCancelar.Location = New System.Drawing.Point(6, 9)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTCancelar.TabIndex = 49
        Me.BTCancelar.Text = "Volver"
        Me.BTCancelar.UseVisualStyleBackColor = True
        '
        'DescripcionTextBox2
        '
        Me.DescripcionTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasBindingSource, "descripcion", True))
        Me.DescripcionTextBox2.Location = New System.Drawing.Point(199, 89)
        Me.DescripcionTextBox2.Name = "DescripcionTextBox2"
        Me.DescripcionTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox2.TabIndex = 40
        '
        'BTGrabar
        '
        Me.BTGrabar.Location = New System.Drawing.Point(177, 112)
        Me.BTGrabar.Name = "BTGrabar"
        Me.BTGrabar.Size = New System.Drawing.Size(75, 23)
        Me.BTGrabar.TabIndex = 37
        Me.BTGrabar.Text = "Grabar"
        Me.BTGrabar.UseVisualStyleBackColor = True
        '
        'PanelBotones
        '
        Me.PanelBotones.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelBotones.Controls.Add(Me.Label1)
        Me.PanelBotones.Controls.Add(Me.Button1)
        Me.PanelBotones.Controls.Add(Me.Button2)
        Me.PanelBotones.Location = New System.Drawing.Point(129, 24)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(449, 100)
        Me.PanelBotones.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 25)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Categorías de Productos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(224, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Mostrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(87, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Nueva"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PanelNuevo
        '
        Me.PanelNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelNuevo.Controls.Add(Me.CBEliminado)
        Me.PanelNuevo.Controls.Add(Me.BTGrabar)
        Me.PanelNuevo.Controls.Add(DescripcionLabel)
        Me.PanelNuevo.Controls.Add(Me.DescripcionTextBox)
        Me.PanelNuevo.Controls.Add(EliminadoLabel)
        Me.PanelNuevo.Controls.Add(Me.Id_categoriaTextBox)
        Me.PanelNuevo.Controls.Add(Me.Label2)
        Me.PanelNuevo.Location = New System.Drawing.Point(41, 57)
        Me.PanelNuevo.Name = "PanelNuevo"
        Me.PanelNuevo.Size = New System.Drawing.Size(465, 208)
        Me.PanelNuevo.TabIndex = 47
        '
        'CBEliminado
        '
        Me.CBEliminado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEliminado.FormattingEnabled = True
        Me.CBEliminado.Items.AddRange(New Object() {"SI", "NO"})
        Me.CBEliminado.Location = New System.Drawing.Point(170, 99)
        Me.CBEliminado.Name = "CBEliminado"
        Me.CBEliminado.Size = New System.Drawing.Size(67, 21)
        Me.CBEliminado.TabIndex = 38
        Me.CBEliminado.Visible = False
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(170, 73)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox.TabIndex = 34
        '
        'Id_categoriaTextBox
        '
        Me.Id_categoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasBindingSource, "id_categoria", True))
        Me.Id_categoriaTextBox.Location = New System.Drawing.Point(170, 47)
        Me.Id_categoriaTextBox.Name = "Id_categoriaTextBox"
        Me.Id_categoriaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_categoriaTextBox.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 25)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nueva Categoría"
        '
        'Id_categoriaTextBox2
        '
        Me.Id_categoriaTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasBindingSource, "id_categoria", True))
        Me.Id_categoriaTextBox2.Enabled = False
        Me.Id_categoriaTextBox2.Location = New System.Drawing.Point(199, 63)
        Me.Id_categoriaTextBox2.Name = "Id_categoriaTextBox2"
        Me.Id_categoriaTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.Id_categoriaTextBox2.TabIndex = 38
        '
        'PanelModificar
        '
        Me.PanelModificar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PanelModificar.Controls.Add(Me.CBEliminado2)
        Me.PanelModificar.Controls.Add(Me.Label5)
        Me.PanelModificar.Controls.Add(Me.Button3)
        Me.PanelModificar.Controls.Add(Label3)
        Me.PanelModificar.Controls.Add(Me.DescripcionTextBox2)
        Me.PanelModificar.Controls.Add(Label4)
        Me.PanelModificar.Controls.Add(Me.Id_categoriaTextBox2)
        Me.PanelModificar.Controls.Add(Me.Label6)
        Me.PanelModificar.Controls.Add(Me.Grabarmodificar)
        Me.PanelModificar.Location = New System.Drawing.Point(87, 35)
        Me.PanelModificar.Name = "PanelModificar"
        Me.PanelModificar.Size = New System.Drawing.Size(465, 194)
        Me.PanelModificar.TabIndex = 50
        '
        'CBEliminado2
        '
        Me.CBEliminado2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEliminado2.FormattingEnabled = True
        Me.CBEliminado2.Items.AddRange(New Object() {"SI", "NO"})
        Me.CBEliminado2.Location = New System.Drawing.Point(199, 116)
        Me.CBEliminado2.Name = "CBEliminado2"
        Me.CBEliminado2.Size = New System.Drawing.Size(67, 21)
        Me.CBEliminado2.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(139, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(115, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(218, 25)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Modificar Categoría"
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
        'EliminadoDataGridViewTextBoxColumn
        '
        Me.EliminadoDataGridViewTextBoxColumn.DataPropertyName = "eliminado"
        Me.EliminadoDataGridViewTextBoxColumn.HeaderText = "eliminado"
        Me.EliminadoDataGridViewTextBoxColumn.Name = "EliminadoDataGridViewTextBoxColumn"
        Me.EliminadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EliminadoDataGridViewTextBoxColumn.Visible = False
        '
        'IdcategoriaDataGridViewTextBoxColumn
        '
        Me.IdcategoriaDataGridViewTextBoxColumn.DataPropertyName = "id_categoria"
        Me.IdcategoriaDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdcategoriaDataGridViewTextBoxColumn.Name = "IdcategoriaDataGridViewTextBoxColumn"
        Me.IdcategoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriasTableAdapter = Me.CategoriasTableAdapter
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = proyecto.BaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.Ventas_cabeceraTableAdapter = Nothing
        Me.TableAdapterManager.Ventas_detalleTableAdapter = Nothing
        '
        'PanelMostrartodos
        '
        Me.PanelMostrartodos.BackColor = System.Drawing.SystemColors.Info
        Me.PanelMostrartodos.Controls.Add(Me.BTActivo2)
        Me.PanelMostrartodos.Controls.Add(Me.BTInactivo2)
        Me.PanelMostrartodos.Controls.Add(Me.Label8)
        Me.PanelMostrartodos.Controls.Add(Me.BTActivos)
        Me.PanelMostrartodos.Controls.Add(Me.BTInactivo)
        Me.PanelMostrartodos.Controls.Add(Me.Label14)
        Me.PanelMostrartodos.Controls.Add(Me.TextBoxBuscar)
        Me.PanelMostrartodos.Controls.Add(Me.Label7)
        Me.PanelMostrartodos.Controls.Add(Me.BTModificar)
        Me.PanelMostrartodos.Controls.Add(Me.BTEliminar)
        Me.PanelMostrartodos.Controls.Add(Me.CategoriasDataGridView)
        Me.PanelMostrartodos.Location = New System.Drawing.Point(24, 72)
        Me.PanelMostrartodos.Name = "PanelMostrartodos"
        Me.PanelMostrartodos.Size = New System.Drawing.Size(717, 224)
        Me.PanelMostrartodos.TabIndex = 48
        '
        'BTActivo2
        '
        Me.BTActivo2.Location = New System.Drawing.Point(624, 17)
        Me.BTActivo2.Name = "BTActivo2"
        Me.BTActivo2.Size = New System.Drawing.Size(78, 23)
        Me.BTActivo2.TabIndex = 46
        Me.BTActivo2.Text = "Activos"
        Me.BTActivo2.UseVisualStyleBackColor = True
        '
        'BTInactivo2
        '
        Me.BTInactivo2.Location = New System.Drawing.Point(627, 28)
        Me.BTInactivo2.Name = "BTInactivo2"
        Me.BTInactivo2.Size = New System.Drawing.Size(75, 23)
        Me.BTInactivo2.TabIndex = 45
        Me.BTInactivo2.Text = "Inactivos"
        Me.BTInactivo2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Descripción"
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
        Me.TextBoxBuscar.Location = New System.Drawing.Point(79, 23)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBuscar.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(274, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(236, 25)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Todas las Categorías"
        '
        'BTModificar
        '
        Me.BTModificar.Location = New System.Drawing.Point(516, 15)
        Me.BTModificar.Name = "BTModificar"
        Me.BTModificar.Size = New System.Drawing.Size(75, 23)
        Me.BTModificar.TabIndex = 21
        Me.BTModificar.Text = "Modificar"
        Me.BTModificar.UseVisualStyleBackColor = True
        '
        'BTEliminar
        '
        Me.BTEliminar.Location = New System.Drawing.Point(187, 17)
        Me.BTEliminar.Name = "BTEliminar"
        Me.BTEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTEliminar.TabIndex = 22
        Me.BTEliminar.Text = "Eliminar"
        Me.BTEliminar.UseVisualStyleBackColor = True
        '
        'CategoriasDataGridView
        '
        Me.CategoriasDataGridView.AllowUserToAddRows = False
        Me.CategoriasDataGridView.AllowUserToDeleteRows = False
        Me.CategoriasDataGridView.AutoGenerateColumns = False
        Me.CategoriasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CategoriasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CategoriasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdcategoriaDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.EliminadoDataGridViewTextBoxColumn})
        Me.CategoriasDataGridView.DataSource = Me.CategoriasBindingSource
        Me.CategoriasDataGridView.Location = New System.Drawing.Point(124, 62)
        Me.CategoriasDataGridView.Name = "CategoriasDataGridView"
        Me.CategoriasDataGridView.ReadOnly = True
        Me.CategoriasDataGridView.Size = New System.Drawing.Size(359, 151)
        Me.CategoriasDataGridView.TabIndex = 19
        '
        'catProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 305)
        Me.Controls.Add(Me.PanelNuevo)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.PanelBotones)
        Me.Controls.Add(Me.PanelModificar)
        Me.Controls.Add(Me.PanelMostrartodos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "catProd"
        Me.Text = "Categorías de Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBotones.ResumeLayout(False)
        Me.PanelBotones.PerformLayout()
        Me.PanelNuevo.ResumeLayout(False)
        Me.PanelNuevo.PerformLayout()
        Me.PanelModificar.ResumeLayout(False)
        Me.PanelModificar.PerformLayout()
        Me.PanelMostrartodos.ResumeLayout(False)
        Me.PanelMostrartodos.PerformLayout()
        CType(Me.CategoriasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriasBindingSource As BindingSource
    Friend WithEvents BaseDataSet As BaseDataSet
    Friend WithEvents Button3 As Button
    Friend WithEvents BTCancelar As Button
    Friend WithEvents DescripcionTextBox2 As TextBox
    Friend WithEvents BTGrabar As Button
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PanelNuevo As Panel
    Friend WithEvents CBEliminado As ComboBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents Id_categoriaTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Id_categoriaTextBox2 As TextBox
    Friend WithEvents PanelModificar As Panel
    Friend WithEvents CBEliminado2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Grabarmodificar As Button
    Friend WithEvents EliminadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdcategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriasTableAdapter As BaseDataSetTableAdapters.CategoriasTableAdapter
    Friend WithEvents TableAdapterManager As BaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PanelMostrartodos As Panel
    Friend WithEvents BTActivo2 As Button
    Friend WithEvents BTInactivo2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents BTActivos As Button
    Friend WithEvents BTInactivo As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BTModificar As Button
    Friend WithEvents BTEliminar As Button
    Friend WithEvents CategoriasDataGridView As DataGridView
End Class
