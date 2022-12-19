Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim stName As String

        Do While stName <> "Kris"
            stName = InputBox("Please enter your name")
        Loop

        MsgBox("Hello " & stName)
    End Sub
End Class
