Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim stName As String

        Do While True
            stName = InputBox("Please enter your name")
            If stName = "Kris" Then
                Exit Do
            End If
        Loop

        MsgBox("Hello " & stName)
    End Sub
End Class
