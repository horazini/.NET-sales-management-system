<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuReportesCajero
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
        Dim Label8 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuReportesCajero))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FechaNacDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BTRanking1 = New System.Windows.Forms.Button()
        Me.FechaNacDateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Label8 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(33, 35)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(38, 13)
        Label8.TabIndex = 32
        Label8.Text = "Desde"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(216, 35)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(35, 13)
        Label1.TabIndex = 33
        Label1.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(337, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 25)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Reportes"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(120, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(537, 379)
        Me.Panel1.TabIndex = 43
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.FechaNacDateTimePicker1)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Me.BTRanking1)
        Me.GroupBox2.Controls.Add(Label8)
        Me.GroupBox2.Controls.Add(Me.FechaNacDateTimePicker2)
        Me.GroupBox2.Location = New System.Drawing.Point(67, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(412, 236)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ranking"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(36, 61)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 72)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Totales de venta"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(234, 154)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 72)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Totales por cliente"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FechaNacDateTimePicker1
        '
        Me.FechaNacDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaNacDateTimePicker1.Location = New System.Drawing.Point(77, 35)
        Me.FechaNacDateTimePicker1.Name = "FechaNacDateTimePicker1"
        Me.FechaNacDateTimePicker1.Size = New System.Drawing.Size(109, 20)
        Me.FechaNacDateTimePicker1.TabIndex = 11
        Me.FechaNacDateTimePicker1.Value = New Date(2021, 11, 1, 0, 0, 0, 0)
        '
        'BTRanking1
        '
        Me.BTRanking1.Location = New System.Drawing.Point(36, 154)
        Me.BTRanking1.Name = "BTRanking1"
        Me.BTRanking1.Size = New System.Drawing.Size(132, 72)
        Me.BTRanking1.TabIndex = 34
        Me.BTRanking1.Text = "Productos más vendidos"
        Me.BTRanking1.UseVisualStyleBackColor = True
        '
        'FechaNacDateTimePicker2
        '
        Me.FechaNacDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaNacDateTimePicker2.Location = New System.Drawing.Point(257, 35)
        Me.FechaNacDateTimePicker2.Name = "FechaNacDateTimePicker2"
        Me.FechaNacDateTimePicker2.Size = New System.Drawing.Size(109, 20)
        Me.FechaNacDateTimePicker2.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 108)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reportes"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 71)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Clientes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(234, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 71)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Productos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(234, 61)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(132, 72)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "Totales por cajero"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'MenuReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 451)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuReportes"
        Me.Text = "Menú de Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FechaNacDateTimePicker1 As DateTimePicker
    Friend WithEvents FechaNacDateTimePicker2 As DateTimePicker
    Friend WithEvents BTRanking1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
