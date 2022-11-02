Public Class MenuReportesCajero
    Private Sub MenuReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTRanking1_Click(sender As Object, e As EventArgs) Handles BTRanking1.Click
        ' Dim newreport3 As New Ranking_Productos_Vendidos
        'newreport3.Show()
        Dim cr2 As New rpRankProductosVendidos
        Dim R2 As New Ranking_Productos_Vendidos
        R2.rpProductosVendidos.ReportSource = cr2
        cr2.SetParameterValue("@desde", FechaNacDateTimePicker1.Text)
        cr2.SetParameterValue("@hasta", FechaNacDateTimePicker2.Text)
        R2.rpProductosVendidos.ReportSource = cr2
        R2.ShowDialog()
    End Sub

    Private Sub BTRanking2_Click(sender As Object, e As EventArgs)
        'Dim newreport4 As New Ranking_Ventas_por_cajero
        'newreport4.Show()
        Dim cr3 As New rpRankingVentasporcajero
        Dim R3 As New Ranking_Ventas_por_cajero
        R3.Ventasxcajero.ReportSource = cr3
        cr3.SetParameterValue("@desde", FechaNacDateTimePicker1.Text)
        cr3.SetParameterValue("@hasta", FechaNacDateTimePicker2.Text)
        R3.Ventasxcajero.ReportSource = cr3
        R3.ShowDialog()
    End Sub

    Private Sub BTImprimir_Click(sender As Object, e As EventArgs)
        MsgBox("En construcción.")
    End Sub

    Private Sub BTGraficos_Click(sender As Object, e As EventArgs)
        MsgBox("En construcción.")
    End Sub

    Private Sub FechaNacDateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles FechaNacDateTimePicker1.ValueChanged

    End Sub

    Private Sub FechaNacDateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles FechaNacDateTimePicker2.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newreport1 As New Reporte_Clientes
        newreport1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newreport2 As New Reporte_Productos
        newreport2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim crTotalesCliente As New rpTotalesPorCliente
        Dim rTotalesCliente As New TotalesPorCliente
        rTotalesCliente.CrystalReportViewer1.ReportSource = crTotalesCliente
        crTotalesCliente.SetParameterValue("@desde", FechaNacDateTimePicker1.Text)
        crTotalesCliente.SetParameterValue("@hasta", FechaNacDateTimePicker2.Text)
        rTotalesCliente.CrystalReportViewer1.ReportSource = crTotalesCliente
        rTotalesCliente.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim crTotales As New rpTotales
        Dim rTotales As New Totales
        rTotales.CrystalReportViewer1.ReportSource = crTotales
        crTotales.SetParameterValue("@desde", FechaNacDateTimePicker1.Text)
        crTotales.SetParameterValue("@hasta", FechaNacDateTimePicker2.Text)
        rTotales.CrystalReportViewer1.ReportSource = crTotales
        rTotales.ShowDialog()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim crTotalesCajero As New rpTotalPorCajero
        Dim rTotalesCajero As New TotalPorCajero
        rTotalesCajero.CrystalReportViewer1.ReportSource = crTotalesCajero
        crTotalesCajero.SetParameterValue("@desde", FechaNacDateTimePicker1.Text)
        crTotalesCajero.SetParameterValue("@hasta", FechaNacDateTimePicker2.Text)
        rTotalesCajero.CrystalReportViewer1.ReportSource = crTotalesCajero
        rTotalesCajero.ShowDialog()

    End Sub
End Class