Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim iTemperature As Integer
        iTemperature = CInt(txtTemperature.Text)

        Select Case iTemperature
            Case Is = 0
                MsgBox("Freezing")
                MsgBox("water is still freeze")
                MsgBox("and you can go skating")
            Case Is < 0
                MsgBox("Sub Zero")
            Case 1 To 10
                MsgBox("Cold")
            Case 11 To 20
                MsgBox("Warm")
            Case Else
                MsgBox("Hot")

        End Select

    End Sub
End Class
