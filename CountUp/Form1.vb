Public Class Form1
    Private Sub btnCountUpTask_Click(sender As Object, e As EventArgs) Handles btnCountUpTask.Click
        Dim iMax As Integer
        Dim stOddOrEven As String
        Dim x As Integer

        iMax = InputBox("What number do want to count up to?")
        stOddOrEven = InputBox("Do you want odd numbers or even numbers?")

        If stOddOrEven = "even" Then
            For x = 2 To iMax Step 2
                MsgBox(x)
            Next
        ElseIf stOddOrEven = "odd" Then
            For x = 1 To iMax Step 2
                MsgBox(x)
            Next
        End If

    End Sub

End Class
