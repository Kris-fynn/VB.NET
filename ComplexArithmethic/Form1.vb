Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decPrice As String
        Dim iQuantity As Integer
        Dim decDicount As Decimal
        Dim decTotalCost As Decimal
        Dim decPostage As Decimal

        decPrice = 5
        iQuantity = 10
        decDicount = 2
        decPostage = 3



        decTotalCost = (decPrice - decDicount) * iQuantity + decPostage


        MsgBox(decTotalCost)

        Dim iResult As Integer
        iResult = 10 - 5 + 2
        MsgBox(iResult)

        iResult = 10 + 2 - 5
        MsgBox(iResult)

        iResult = 10 - 2 + 5
        MsgBox(iResult)


        iResult = 10 / 2 * 5
        MsgBox(iResult)

        iResult = 10 * 2 / 5
        MsgBox(iResult)

        iResult = 10 * 5 / 2
        MsgBox(iResult)






    End Sub
End Class
