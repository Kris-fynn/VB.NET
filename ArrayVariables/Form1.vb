Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim stFruit As String

        stFruit = "Banana"

        MsgBox(stFruit)

        stFruit = "Orange"

        Dim stFruit2 As String

        stFruit2 = "Pineapple"

        stFruit2 = stFruit

        MsgBox(stFruit2)



    End Sub
End Class
