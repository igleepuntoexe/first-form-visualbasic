Option Strict On
Public Class Form7
    Private Sub IntroducirEuros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IntroducirEuros.KeyPress
        Dim teclas As Char = e.KeyChar()

        If teclas = Convert.ToChar(Keys.Enter) Then
            EurosConvertir.PerformClick()
        End If

    End Sub

    Private Sub IntroducirDolares_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IntroducirDolares.KeyPress
        Dim teclas2 As Char = e.KeyChar()

        If teclas2 = Convert.ToChar(Keys.Enter) Then
            DolaresConvertir.PerformClick()
        End If

    End Sub

    Private Sub DolaresConvertir_Click(sender As Object, e As EventArgs) Handles DolaresConvertir.Click
        Dim conversion, euro As Double
        euro = Convert.ToDouble(IntroducirDolares.Text)
        conversion = euro * 1.2
        IntroducirEuros.Text = CStr(conversion)
    End Sub

    Private Sub EurosConvertir_Click(sender As Object, e As EventArgs) Handles EurosConvertir.Click
        Dim conversion, dolar As Double
        dolar = Convert.ToDouble(IntroducirEuros.Text)
        conversion = dolar * 0.83
        IntroducirDolares.Text = CStr(conversion)
    End Sub

    Private Sub BotonLimpiar_Click(sender As Object, e As EventArgs) Handles BotonLimpiar.Click
        IntroducirDolares.Text = " "
        IntroducirEuros.Text = " "
    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        Close()
    End Sub
End Class