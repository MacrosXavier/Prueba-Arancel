Public Class frmreporteproductos

    Private Sub frmreporteproductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbventasDataSet1.mostrar_producto' Puede moverla o quitarla según sea necesario.
        Me.mostrar_productoTableAdapter.Fill(Me.dbventasDataSet1.mostrar_producto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class