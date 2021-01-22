Public Class frmreportecomprobante

    Private Sub frmreportecomprobante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbventasDataSet1.generar_comprobante' Puede moverla o quitarla según sea necesario.
        Me.generar_comprobanteTableAdapter.Fill(Me.dbventasDataSet1.generar_comprobante, idventa:=txtidventa.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class