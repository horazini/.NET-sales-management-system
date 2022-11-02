﻿Imports System.Windows.Forms

Public Class MenuSistemas

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub BTSalir_Click(sender As Object, e As EventArgs) Handles BTSalir.Click
        ' Defina el mensaje que desea ver dentro del cuadro de mensaje.
        Dim msg = "¿Desea salir de la aplicación?"

        ' Muestre un cuadro de mensaje simple.
        'MsgBox(msg)

        ' Defina un título para el cuadro de mensaje.
        Dim title = "Salir"

        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                    MsgBoxStyle.Information
        'Muestre el cuadro de mensaje y guarde la respuesta, Sí o No.
        Dim ask = MsgBox(msg, style, title)

        ' Tome alguna acción basada en la respuesta.
        If ask = MsgBoxResult.Yes Then
            End
        Else

        End If


    End Sub

    Private Sub BTusuarios_Click(sender As Object, e As EventArgs) Handles BTusuarios.Click
        Dim newgestionUsuarios As New gestionUsuarios
        newgestionUsuarios.MdiParent = Me
        newgestionUsuarios.Show()
    End Sub

    Private Sub BTClientes_Click(sender As Object, e As EventArgs) 
        Dim newgestionClientes As New gestionClientes
        newgestionClientes.MdiParent = Me
        newgestionClientes.Show()
    End Sub

    Private Sub BTProductos_Click(sender As Object, e As EventArgs) 
        Dim newgestionProductos As New gestionProductos
        newgestionProductos.MdiParent = Me
        newgestionProductos.Show()
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Bienvenido: " + nombreU
    End Sub

    Private Sub BTReportes_Click(sender As Object, e As EventArgs) Handles BTReportes.Click
        Dim newreportes As New MenuReportesCajero
        newreportes.MdiParent = Me
        newreportes.Show()
    End Sub

    Private Sub ButtonBackup_Click(sender As Object, e As EventArgs) Handles ButtonBackup.Click
        Dim newbackupForm As New Backup_Restore_Delete
        newbackupForm.MdiParent = Me
        newbackupForm.Show()
    End Sub

    Private Sub BTCerrarSesion_Click(sender As Object, e As EventArgs) Handles BTCerrarSesion.Click
        ' Defina el mensaje que desea ver dentro del cuadro de mensaje.
        Dim msg = "¿Desea cerrar sesión?"

        ' Muestre un cuadro de mensaje simple.
        'MsgBox(msg)

        ' Defina un título para el cuadro de mensaje.
        Dim title = "Cerrar sesión"

        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                    MsgBoxStyle.Information
        'Muestre el cuadro de mensaje y guarde la respuesta, Sí o No.
        Dim ask = MsgBox(msg, style, title)

        ' Tome alguna acción basada en la respuesta.
        If ask = MsgBoxResult.Yes Then
            Dim FormLogin As New FInicio
            FormLogin.Show()
            Me.Hide()
        Else

        End If


    End Sub

    Private Sub ToolStripStatusLabel_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel.Click

    End Sub

    Private Sub ToolTip_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip.Popup

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub StatusStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip.ItemClicked

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
