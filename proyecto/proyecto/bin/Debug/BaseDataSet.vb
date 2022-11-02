Partial Class BaseDataSet
    Partial Public Class ProductosDataTable
        Private Sub ProductosDataTable_ProductosRowChanging(sender As Object, e As ProductosRowChangeEvent) Handles Me.ProductosRowChanging

        End Sub

        Private Sub ProductosDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.precio_costoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class

Namespace BaseDataSetTableAdapters

    Partial Public Class ProductosTableAdapter
    End Class
End Namespace
