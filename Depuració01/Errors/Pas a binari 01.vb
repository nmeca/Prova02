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
            ResteDivisioPer2 = Divident Mod 2
            Quocient = Int(Divident / 2)
            NumeroBinari = CStr(ResteDivisioPer2) + NumeroBinari
            Divident = Quocient
        End While
        NumBin.Text = NumeroBinari
    End Sub

    Private Sub PasADecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasADecimal.Click
        Dim NumeroDecimal As Integer
        Dim NumeroBinari As String
        Dim DigitActual As Integer
        Dim PotenciaDeDosActual As Integer

        NumeroBinari = NumBin.Text
        NumeroDecimal = 0
        PotenciaDeDosActual = 1

        While Len(NumeroBinari) > 0
            DigitActual = Mid(NumeroBinari, Len(NumeroBinari), 1)
            NumeroBinari = Mid(NumeroBinari, 1, Len(NumeroBinari) - 1)
            NumeroDecimal = NumeroDecimal + DigitActual * PotenciaDeDosActual
            PotenciaDeDosActual = PotenciaDeDosActual * 2
        End While

        NumDec.Text = NumeroDecimal

    End Sub
End Class
