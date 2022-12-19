Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim astFruits(4) As String

        astFruits(0) = "Banana"
        astFruits(1) = "Orange"
        astFruits(2) = "Pineapple"
        astFruits(3) = "Strawberry"
        astFruits(4) = "Mango"


        Dim i As String

        For i = 0 To 4
            MsgBox(astFruits(i))
        Next



    End Sub
End Class
