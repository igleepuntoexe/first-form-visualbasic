Public Class Form5
    Private Sub BotonPulsar_Click(sender As Object, e As EventArgs) Handles BotonPulsar.Click
        Informacion.Text = "Tu nombres es: " + nombreIntroducirtxt.Text + " / Tu correo es: " + IntroducetuCorreo.Text
    End Sub
End Class