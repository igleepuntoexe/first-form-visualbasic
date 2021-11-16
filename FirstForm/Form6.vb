Option Strict On
Public Class Form6
    Private Sub centrigradostxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles centrigradostxt.KeyPress
        Dim teclas As Char = e.KeyChar

        If teclas = Convert.ToChar(Keys.Enter) Then
            BotonFareheit.PerformClick()
        End If
    End Sub

    Private Sub farenhetitxtç_KeyPress(sender As Object, e As KeyPressEventArgs) Handles farenhetitxtç.KeyPress
        Dim teclas As Char = e.KeyChar

        If teclas = Convert.ToChar(Keys.Enter) Then
            BotonCentrigrados.PerformClick()
        End If
    End Sub

    Private Sub BotonFareheit_Click(sender As Object, e As EventArgs) Handles BotonFareheit.Click
        Dim temp As Double
        temp = (Convert.ToDouble(centrigradostxt.Text) * 9 / 5) + 32
        farenhetitxtç.Text = CStr(temp)
    End Sub

    Private Sub BotonCentrigrados_Click(sender As Object, e As EventArgs) Handles BotonCentrigrados.Click
        Dim temp As Double
        temp = (Convert.ToDouble(farenhetitxtç.Text) - 32) * 5 / 9
        centrigradostxt.Text = CStr(temp)
    End Sub

    Private Sub BotonLimpiar_Click(sender As Object, e As EventArgs) Handles BotonLimpiar.Click
        centrigradostxt.Text = " "
        farenhetitxtç.Text = " "

    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        Close()
    End Sub
End Class