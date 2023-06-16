
Imports System.IO

Public Class Form1
    Private archivo As StreamReader

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If box_usuario.Text = "bombero" And box_contr.Text = "bombero" Then
            buttdatos.Enabled = True
            buttcumplimiento.Enabled = True
            butttelefonos.Enabled = True
            buttaspirantes.Enabled = False
            buttconfiguracion.Enabled = False
            buttcargar.Enabled = False
            txt_aut.Visible = True
            txt_aut.Text = "BOMBERO"
            txt_aut.ForeColor = Color.Blue
        ElseIf box_usuario.Text = "instructor" And box_contr.Text = "instructor" Then
            buttdatos.Enabled = True
            buttcumplimiento.Enabled = True
            butttelefonos.Enabled = True
            buttaspirantes.Enabled = True
            buttconfiguracion.Enabled = False
            buttcargar.Enabled = False
            txt_aut.Visible = True
            txt_aut.Text = "INSTRUCTOR"
            txt_aut.ForeColor = Color.Green
        ElseIf box_usuario.Text = "admin" And box_contr.Text = "admin" Then
            buttdatos.Enabled = True
            buttcumplimiento.Enabled = True
            butttelefonos.Enabled = True
            buttaspirantes.Enabled = True
            buttconfiguracion.Enabled = True
            buttcargar.Enabled = True
            txt_aut.Visible = True
            txt_aut.Text = "ADMINISTRADOR"
            txt_aut.ForeColor = Color.Red
        Else
            buttdatos.Enabled = False
            buttcumplimiento.Enabled = False
            butttelefonos.Enabled = False
            buttaspirantes.Enabled = False
            buttconfiguracion.Enabled = False
            buttcargar.Enabled = False
            txt_aut.Visible = True
            txt_aut.Text = "Incorrecto"
            txt_aut.ForeColor = Color.Black
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub buttcargar_Click(sender As Object, e As EventArgs) Handles buttcargar.Click
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("d:\Users\pc\Documents\nuevo programa cuartel\base de datos\BOMBEROS\basedatos.txt")
        textoo.Text = fileReader
    End Sub
End Class
