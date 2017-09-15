Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "proyectoinf" And TextBox2.Text = "prueba" Then
            MsgBox("Login Correcto", MsgBoxStyle.Information)
        Else
            MsgBox("Login Incorrecto", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
