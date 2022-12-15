Public Class Form1
    Private Sub btGreet_Click(sender As Object, e As EventArgs) Handles btGreet.Click

        Dim stCountry As String
        stCountry = txtCountry.Text

        If stCountry = "Australia" Then
            MsgBox("G'day mate")
            MsgBox("Good on ya")
            MsgBox("No worries")
        End If


    End Sub
End Class
