<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comprobante_de_pago
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
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.rpComprobante = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rpComprobante_de_pago1 = New proyecto.rpComprobante_de_pago()
        Me.rpComprobante_de_pago2 = New proyecto.rpComprobante_de_pago()
        Me.SuspendLayout()
        '
        'rpComprobante
        '
        Me.rpComprobante.ActiveViewIndex = 0
        Me.rpComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rpComprobante.Cursor = System.Windows.Forms.Cursors.Default
        Me.rpComprobante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rpComprobante.Location = New System.Drawing.Point(0, 0)
        Me.rpComprobante.Name = "rpComprobante"
        Me.rpComprobante.ReportSource = Me.rpComprobante_de_pago2
        Me.rpComprobante.ShowExportButton = False
        Me.rpComprobante.ShowGotoPageButton = False
        Me.rpComprobante.ShowGroupTreeButton = False
        Me.rpComprobante.ShowLogo = False
        Me.rpComprobante.Size = New System.Drawing.Size(778, 355)
        Me.rpComprobante.TabIndex = 0
        Me.rpComprobante.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Comprobante_de_pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 355)
        Me.Controls.Add(Me.rpComprobante)
        Me.Name = "Comprobante_de_pago"
        Me.Text = "Comprobante de Pago"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rpComprobante As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents rpComprobante_de_pago1 As rpComprobante_de_pago
    Friend WithEvents rpComprobante_de_pago2 As rpComprobante_de_pago
End Class
