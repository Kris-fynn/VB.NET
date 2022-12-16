Imports System.Globalization

Public Class Form1
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click

        Dim stCountry As String
        stCountry = txtCountry.Text

        If stCountry = "Australia" Then MsgBox("hi")
        MsgBox("G'day mate")
        MsgBox("Good on ya")
            MsgBox("No worries")

        ElseIf stCountry = "France" Then
            MsgBox("Banjour")
            MsgBox("Comment allez-vous?")

        ElseIf stCountry = "Japan" Then
            MsgBox("Konnichiwa")
        MsgBox("Choushi wa dou desu ka")

        Else
        MsgBox("Hello There")
        MsgBox("I hope you are well")

        End If


    End Sub
End Class
