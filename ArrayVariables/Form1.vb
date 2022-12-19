Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim astFruit(4) As String

        astFruit(0) = "Banana"
        astFruit(1) = "Orange"
        astFruit(2) = "Pineapple"
        astFruit(3) = "Strawberry"
        astFruit(4) = "Mango"

        MsgBox(stFruit)

        Dim i As String
        i = 8

        MsgBox(astFruit(i))



    End Sub
End Class
