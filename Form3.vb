Option Strict On
Public Class Form3
    Private Sub HorasConversión_Click(sender As Object, e As EventArgs) Handles HorasConversión.Click
        Dim conversionmin, conversionsec As Double
        conversionmin = Convert.ToDouble(HorasIntroducidas.Text) * 60
        conversionsec = Convert.ToDouble(HorasIntroducidas.Text) * 3600
        MinutosConvertidos.Text = CStr(conversionmin)
        SegundosConvertidos.Text = Convert.ToString(conversionsec)

    End Sub

    Private Sub SalirEjercicio3_Click(sender As Object, e As EventArgs) Handles SalirEjercicio3.Click
        Close()
    End Sub

    Private Sub LimpiadorConversion_Click(sender As Object, e As EventArgs) Handles LimpiadorConversion.Click
        HorasIntroducidas.Text = " "
        MinutosConvertidos.Text = " "
        SegundosConvertidos.Text = " "
    End Sub
End Class