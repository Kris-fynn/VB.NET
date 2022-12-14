Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim iNumber1 As Integer
        Dim iNumber2 As Integer

        Dim iResult As Integer
        iNumber1 = txtNumber1.Text
        iNumber2 = txtNumber2.Text

        iResult = iNumber1 + iNumber2

        MsgBox(iResult)

        iResult = iNumber1 - iNumber2

        MsgBox(iResult)

        iResult = iNumber1 * iNumber2

        MsgBox(iResult)

        iResult = iNumber1 / iNumber2


        MsgBox(iResult)
    End Sub
End Class
