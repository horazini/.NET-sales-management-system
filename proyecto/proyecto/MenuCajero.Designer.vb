<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuCajero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuCajero))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTCerrarSesion = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTReportes = New System.Windows.Forms.Button()
        Me.BTSalir = New System.Windows.Forms.Button()
        Me.BTVentas = New System.Windows.Forms.Button()
        Me.BTProductos = New System.Windows.Forms.Button()
        Me.BTClientes = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StatusStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(163, 567)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(866, 22)
        Me.StatusStrip.TabIndex = 12
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BTCerrarSesion)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BTReportes)
        Me.Panel1.Controls.Add(Me.BTSalir)
        Me.Panel1.Controls.Add(Me.BTVentas)
        Me.Panel1.Controls.Add(Me.BTProductos)
        Me.Panel1.Controls.Add(Me.BTClientes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(163, 589)
        Me.Panel1.TabIndex = 13
        '
        'BTCerrarSesion
        '
        Me.BTCerrarSesion.Location = New System.Drawing.Point(12, 423)
        Me.BTCerrarSesion.Name = "BTCerrarSesion"
        Me.BTCerrarSesion.Size = New System.Drawing.Size(128, 55)
        Me.BTCerrarSesion.TabIndex = 4
        Me.BTCerrarSesion.Text = "Cerrar sesión"
        Me.BTCerrarSesion.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BTReportes
        '
        Me.BTReportes.Location = New System.Drawing.Point(12, 281)
        Me.BTReportes.Name = "BTReportes"
        Me.BTReportes.Size = New System.Drawing.Size(128, 55)
        Me.BTReportes.TabIndex = 3
        Me.BTReportes.Text = "Reportes"
        Me.BTReportes.UseVisualStyleBackColor = True
        '
        'BTSalir
        '
        Me.BTSalir.Location = New System.Drawing.Point(12, 494)
        Me.BTSalir.Name = "BTSalir"
        Me.BTSalir.Size = New System.Drawing.Size(128, 55)
        Me.BTSalir.TabIndex = 5
        Me.BTSalir.Text = "Salir"
        Me.BTSalir.UseVisualStyleBackColor = True
        '
        'BTVentas
        '
        Me.BTVentas.Location = New System.Drawing.Point(12, 98)
        Me.BTVentas.Name = "BTVentas"
        Me.BTVentas.Size = New System.Drawing.Size(128, 55)
        Me.BTVentas.TabIndex = 0
        Me.BTVentas.Text = "Ventas"
        Me.BTVentas.UseVisualStyleBackColor = True
        '
        'BTProductos
        '
        Me.BTProductos.Location = New System.Drawing.Point(12, 220)
        Me.BTProductos.Name = "BTProductos"
        Me.BTProductos.Size = New System.Drawing.Size(128, 55)
        Me.BTProductos.TabIndex = 2
        Me.BTProductos.Text = "Productos"
        Me.BTProductos.UseVisualStyleBackColor = True
        '
        'BTClientes
        '
        Me.BTClientes.Location = New System.Drawing.Point(12, 159)
        Me.BTClientes.Name = "BTClientes"
        Me.BTClientes.Size = New System.Drawing.Size(128, 55)
        Me.BTClientes.TabIndex = 1
        Me.BTClientes.Text = "Clientes"
        Me.BTClientes.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 589)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1029, 51)
        Me.Panel3.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(163, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(866, 44)
        Me.Panel2.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cajero"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuCajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 640)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MenuCajero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Cajero"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTCerrarSesion As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTReportes As Button
    Friend WithEvents BTSalir As Button
    Friend WithEvents BTVentas As Button
    Friend WithEvents BTProductos As Button
    Friend WithEvents BTClientes As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
