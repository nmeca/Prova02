Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PasABinari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasABinari.Click
        Dim NumeroDecimal As Integer
        Dim NumeroBinari As String
        Dim Divident As Integer
        Dim ResteDivisioPer2 As Integer
        Dim Quocient As Integer

        Divident = NumDec.Text
        NumeroBinari = ""

        While Divident > 0
            Quocient = Divident / 2
            ResteDivisioPer2 = Divident Mod 2
            NumeroBinari = Convert.ToString(ResteDivisioPer2) + NumeroBinari
            Divident = Quocient
        End While
        NumBin.Text = NumeroBinari
    End Sub
End Class
