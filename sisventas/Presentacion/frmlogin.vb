Public Class frmlogin

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora.Text = TimeOfDay
    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblhora.Text = TimeOfDay
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        Try
            Dim dts As New vusuario
            Dim func As New fusuario

            dts.glogin = txtlogin.Text
            dts.gpassword = txtpassword.Text

            If func.validar_usuario(dts) = True Then
                frminicio.Show()
                Me.Hide()
            Else
                MsgBox("Ingrese nuevamente sus datos correctos", MsgBoxStyle.Information, "Accesos denegado al sistema")
                txtpassword.Clear()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class