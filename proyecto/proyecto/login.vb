Public Class FInicio
    Private Sub BAceptar1_Click_1(sender As Object, e As EventArgs) Handles BAceptar1.Click
        If TBUsuario.Text = String.Empty Or TBContrasena.Text = String.Empty Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        Else
            '''''''''''''''
            Try
                If usuarioRegistrado(TBUsuario.Text) = True Then
                    Dim contra As String = contrasena(TBUsuario.Text)
                    If contra.Equals(TBContrasena.Text) = True Then
                        Me.Hide()
                        If ConsultarTipoUsuario(TBUsuario.Text) = 1 Then
                            ' FrmAdministrador.ShowDialog()
                            ' MsgBox("Cajero", MsgBoxStyle.Critical)
                            Dim NuevoForm As New MenuCajero

                            NuevoForm.Show()
                        ElseIf ConsultarTipoUsuario(TBUsuario.Text) = 2 Then
                            ' FrmInvitado.ShowDialog()
                            'MsgBox("Gestion", MsgBoxStyle.Critical)
                            Dim NuevoForm As New MenuGestion

                            NuevoForm.Show()
                        Else
                            ' FrmEstandar.ShowDialog()
                            'MsgBox("Sistema", MsgBoxStyle.Critical)
                            Dim NuevoForm As New MenuSistemas

                            NuevoForm.Show()
                        End If
                    Else
                        MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                    End If
                Else
                    MsgBox("El Usuario: " + TBUsuario.Text + " no se encuentra registrado")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            ''''''''''''''''''

        End If
    End Sub

    Private Sub FInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
        BAceptar1.Focus()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        TBUsuario.Text = ""
        TBContrasena.Text = ""
    End Sub


End Class
