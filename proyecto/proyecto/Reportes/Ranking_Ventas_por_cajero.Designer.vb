<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ranking_Ventas_por_cajero
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
        Me.Ventasxcajero = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rpRankingVentasporcajero1 = New proyecto.rpRankingVentasporcajero()
        Me.SuspendLayout()
        '
        'Ventasxcajero
        '
        Me.Ventasxcajero.ActiveViewIndex = 0
        Me.Ventasxcajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ventasxcajero.Cursor = System.Windows.Forms.Cursors.Default
        Me.Ventasxcajero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ventasxcajero.Location = New System.Drawing.Point(0, 0)
        Me.Ventasxcajero.Name = "Ventasxcajero"
        Me.Ventasxcajero.ReportSource = Me.rpRankingVentasporcajero1
        Me.Ventasxcajero.ShowCloseButton = False
        Me.Ventasxcajero.ShowGotoPageButton = False
        Me.Ventasxcajero.ShowGroupTreeButton = False
        Me.Ventasxcajero.ShowLogo = False
        Me.Ventasxcajero.Size = New System.Drawing.Size(752, 331)
        Me.Ventasxcajero.TabIndex = 0
        Me.Ventasxcajero.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Ranking_Ventas_por_cajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 331)
        Me.Controls.Add(Me.Ventasxcajero)
        Me.Name = "Ranking_Ventas_por_cajero"
        Me.Text = "Ranking de Ventas por Cajero"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ventasxcajero As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rpRankingVentasporcajero1 As rpRankingVentasporcajero
End Class
