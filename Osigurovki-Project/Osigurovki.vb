Public Class Osigurovki

    Dim pDOO As Single
    Dim pDZPO As Single

    Private Sub optBefore1960_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBefore1960.CheckedChanged
        pDOO = 0.089
        pDZPO = 0
    End Sub

    Private Sub optAfter1960_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAfter1960.CheckedChanged
        pDOO = 0.067
        pDZPO = 0.022
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        DOO.Text = FormatCurrency(pDOO * Val(txtZaplata.Text), 2)
        DZPO.Text = FormatCurrency(pDZPO * Val(txtZaplata.Text), 2)
        Zdravni.Text = FormatCurrency(0.032 * Val(txtZaplata.Text), 2)
        Sum.Text = FormatCurrency(Val(DOO.Text) + Val(DZPO.Text) + Val(Zdravni.Text), 2)
    End Sub
End Class
