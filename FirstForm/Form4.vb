Option Strict On
Public Class Form4
    Private Sub BotonSumar_Click(sender As Object, e As EventArgs) Handles BotonSumar.Click
        Dim sumas As Double
        lblsuma.Text = "+"
        sumas = Convert.ToDouble(Numero1.Text) + Convert.ToDouble(Numero2.Text)
        resultado.Text = CStr(sumas)
    End Sub

    Private Sub BotonRestar_Click(sender As Object, e As EventArgs) Handles BotonRestar.Click
        Dim restas As Double
        lblsuma.Text = "-"
        restas = Convert.ToDouble(Numero1.Text) - Convert.ToDouble(Numero2.Text)
        resultado.Text = CStr(restas)
    End Sub

    Private Sub BotonMultiplicar_Click(sender As Object, e As EventArgs) Handles BotonMultiplicar.Click
        Dim mul As Double
        lblsuma.Text = "*"
        mul = Convert.ToDouble(Numero1.Text) * Convert.ToDouble(Numero2.Text)
        resultado.Text = CStr(mul)
    End Sub

    Private Sub BotonDividir_Click(sender As Object, e As EventArgs) Handles BotonDividir.Click
        Dim division As Double
        lblsuma.Text = "/"
        division = Convert.ToDouble(Numero1.Text) / Convert.ToDouble(Numero2.Text)
        resultado.Text = CStr(division)
    End Sub

    Private Sub Numero1_TextChanged(sender As Object, e As EventArgs) Handles Numero1.TextChanged
        Numero1.Focus()
    End Sub
End Class