<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnResguardar = New System.Windows.Forms.Button()
        Me.btnSalir_backup = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRutaResguardo = New System.Windows.Forms.Button()
        Me.BDDOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.BDDSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.cboBaseDatos = New System.Windows.Forms.ComboBox()
        Me.btnRutaRestaurar = New System.Windows.Forms.Button()
        Me.txtRutaRestaurar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreBaseDeDatos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        'Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.tecnico
        Me.PictureBox1.Location = New System.Drawing.Point(4, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(169, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(369, 35)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "BASE DE DATOS"
        '
        'btnResguardar
        '
        Me.btnResguardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnResguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResguardar.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResguardar.Location = New System.Drawing.Point(700, 164)
        Me.btnResguardar.Name = "btnResguardar"
        Me.btnResguardar.Size = New System.Drawing.Size(117, 65)
        Me.btnResguardar.TabIndex = 108
        Me.btnResguardar.Text = "RESGUARDAR"
        Me.btnResguardar.UseVisualStyleBackColor = False
        '
        'btnSalir_backup
        '
        Me.btnSalir_backup.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSalir_backup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir_backup.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir_backup.Location = New System.Drawing.Point(721, 505)
        Me.btnSalir_backup.Name = "btnSalir_backup"
        Me.btnSalir_backup.Size = New System.Drawing.Size(96, 43)
        Me.btnSalir_backup.TabIndex = 110
        Me.btnSalir_backup.Text = "SALIR"
        Me.btnSalir_backup.UseVisualStyleBackColor = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurar.Location = New System.Drawing.Point(700, 340)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(117, 65)
        Me.btnRestaurar.TabIndex = 111
        Me.btnRestaurar.Text = "RESTAURAR"
        Me.btnRestaurar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(54, 500)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 48)
        Me.btnCancelar.TabIndex = 112
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.txtUbicacion.Location = New System.Drawing.Point(339, 168)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(280, 31)
        Me.txtUbicacion.TabIndex = 121
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(48, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(253, 35)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Ruta De Resguardo: "
        '
        'btnRutaResguardo
        '
        Me.btnRutaResguardo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRutaResguardo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRutaResguardo.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRutaResguardo.Location = New System.Drawing.Point(521, 205)
        Me.btnRutaResguardo.Name = "btnRutaResguardo"
        Me.btnRutaResguardo.Size = New System.Drawing.Size(98, 42)
        Me.btnRutaResguardo.TabIndex = 122
        Me.btnRutaResguardo.Text = "Ruta"
        Me.btnRutaResguardo.UseVisualStyleBackColor = False
        '
        'BDDOpenFileDialog
        '
        Me.BDDOpenFileDialog.FileName = "OpenFileDialog1"
        '
        'btnConectar
        '
        Me.btnConectar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConectar.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConectar.Location = New System.Drawing.Point(175, 97)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(108, 48)
        Me.btnConectar.TabIndex = 125
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = False
        '
        'cboBaseDatos
        '
        Me.cboBaseDatos.FormattingEnabled = True
        Me.cboBaseDatos.Location = New System.Drawing.Point(339, 105)
        Me.cboBaseDatos.Name = "cboBaseDatos"
        Me.cboBaseDatos.Size = New System.Drawing.Size(280, 33)
        Me.cboBaseDatos.TabIndex = 126
        '
        'btnRutaRestaurar
        '
        Me.btnRutaRestaurar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRutaRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRutaRestaurar.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRutaRestaurar.Location = New System.Drawing.Point(521, 377)
        Me.btnRutaRestaurar.Name = "btnRutaRestaurar"
        Me.btnRutaRestaurar.Size = New System.Drawing.Size(98, 42)
        Me.btnRutaRestaurar.TabIndex = 129
        Me.btnRutaRestaurar.Text = "Ruta"
        Me.btnRutaRestaurar.UseVisualStyleBackColor = False
        '
        'txtRutaRestaurar
        '
        Me.txtRutaRestaurar.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.txtRutaRestaurar.Location = New System.Drawing.Point(339, 340)
        Me.txtRutaRestaurar.Name = "txtRutaRestaurar"
        Me.txtRutaRestaurar.Size = New System.Drawing.Size(280, 31)
        Me.txtRutaRestaurar.TabIndex = 128
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(48, 340)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 35)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Ruta De Restauracion: "
        '
        'txtNombreBaseDeDatos
        '
        Me.txtNombreBaseDeDatos.Font = New System.Drawing.Font("Comic Sans MS", 10.2!)
        Me.txtNombreBaseDeDatos.Location = New System.Drawing.Point(373, 425)
        Me.txtNombreBaseDeDatos.Name = "txtNombreBaseDeDatos"
        Me.txtNombreBaseDeDatos.Size = New System.Drawing.Size(246, 31)
        Me.txtNombreBaseDeDatos.TabIndex = 130
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(48, 422)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 35)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "Nombre de Base de Datos"
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        'Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.logo7
        Me.ClientSize = New System.Drawing.Size(851, 578)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreBaseDeDatos)
        Me.Controls.Add(Me.btnRutaRestaurar)
        Me.Controls.Add(Me.txtRutaRestaurar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboBaseDatos)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.btnRutaResguardo)
        Me.Controls.Add(Me.txtUbicacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRestaurar)
        Me.Controls.Add(Me.btnSalir_backup)
        Me.Controls.Add(Me.btnResguardar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BACKUP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnResguardar As Button
    Friend WithEvents btnSalir_backup As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRutaResguardo As Button
    Friend WithEvents BDDOpenFileDialog As OpenFileDialog
    Friend WithEvents BDDSaveFileDialog As SaveFileDialog
    Friend WithEvents btnConectar As Button
    Friend WithEvents cboBaseDatos As ComboBox
    Friend WithEvents btnRutaRestaurar As Button
    Friend WithEvents txtRutaRestaurar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreBaseDeDatos As TextBox
    Friend WithEvents Label2 As Label
End Class
