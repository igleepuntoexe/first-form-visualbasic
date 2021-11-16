Option Strict On
Public Class Form2
    Private Sub BotonCuadrado_Click(sender As Object, e As EventArgs) Handles BotonCuadrado.Click
        Dim mul As Double
        mul = Convert.ToDouble(LadosCuadrado.Text) * Convert.ToDouble(LadosCuadrado.Text)
        AreaCuadrado.Text = CStr(mul)
    End Sub

    Private Sub BotonRectangulo_Click(sender As Object, e As EventArgs) Handles BotonRectangulo.Click
        Dim arearectandulo As Double
        arearectandulo = Convert.ToDouble(MedidaMayor.Text) * Convert.ToDouble(MedidaLadoMenor.Text)
        AreaRectangulo.Text = CStr(arearectandulo)
    End Sub

    Private Sub BotonTriangulo_Click(sender As Object, e As EventArgs) Handles BotonTriangulo.Click
        Dim baseporalturapartidodos As Double
        baseporalturapartidodos = Convert.ToDouble(BaseTriangulo.Text) * Convert.ToDouble(AlturaTriangulo.Text) / 2
        AreaTriangulo.Text = CStr(baseporalturapartidodos)
    End Sub

    Private Sub BotonReiniciar_Click(sender As Object, e As EventArgs) Handles BotonReiniciar.Click
        LadosCuadrado.Text = " "
        MedidaLadoMenor.Text = " "
        MedidaMayor.Text = " "
        BaseTriangulo.Text = " "
        AlturaTriangulo.Text = " "
        AreaTriangulo.Text = " "
        AreaRectangulo.Text = " "
        AreaCuadrado.Text = " "

    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        Close()
    End Sub

    Private Sub BotonCalculoTotal_Click(sender As Object, e As EventArgs) Handles BotonCalculoTotal.Click
        Dim mul As Double
        mul = Convert.ToDouble(LadosCuadrado.Text) * Convert.ToDouble(LadosCuadrado.Text)
        AreaCuadrado.Text = CStr(mul)

        Dim arearectandulo As Double
        arearectandulo = Convert.ToDouble(MedidaMayor.Text) * Convert.ToDouble(MedidaLadoMenor.Text)
        AreaRectangulo.Text = CStr(arearectandulo)

        Dim baseporalturapartidodos As Double
        baseporalturapartidodos = Convert.ToDouble(BaseTriangulo.Text) * Convert.ToDouble(AlturaTriangulo.Text) / 2
        AreaTriangulo.Text = CStr(baseporalturapartidodos)
    End Sub
End Class