<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ranking_Productos_Vendidos
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
        Me.rpProductosVendidos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rpRankProductosVendidos1 = New proyecto.rpRankProductosVendidos()
        Me.SuspendLayout()
        '
        'rpProductosVendidos
        '
        Me.rpProductosVendidos.ActiveViewIndex = 0
        Me.rpProductosVendidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rpProductosVendidos.Cursor = System.Windows.Forms.Cursors.Default
        Me.rpProductosVendidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rpProductosVendidos.Location = New System.Drawing.Point(0, 0)
        Me.rpProductosVendidos.Name = "rpProductosVendidos"
        Me.rpProductosVendidos.ReportSource = Me.rpRankProductosVendidos1
        Me.rpProductosVendidos.ShowCloseButton = False
        Me.rpProductosVendidos.ShowGotoPageButton = False
        Me.rpProductosVendidos.ShowGroupTreeButton = False
        Me.rpProductosVendidos.ShowLogo = False
        Me.rpProductosVendidos.Size = New System.Drawing.Size(693, 370)
        Me.rpProductosVendidos.TabIndex = 0
        Me.rpProductosVendidos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Ranking_Productos_Vendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 370)
        Me.Controls.Add(Me.rpProductosVendidos)
        Me.Name = "Ranking_Productos_Vendidos"
        Me.Text = "Ranking Productos Vendidos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rpProductosVendidos As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rpRankProductosVendidos1 As rpRankProductosVendidos
End Class
