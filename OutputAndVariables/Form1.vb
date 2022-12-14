Public Class Form1



    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click


        MsgBox("course")
        MsgBox("programming")
        MsgBox("VB.NET")
        MsgBox("the")
        MsgBox("to")
        MsgBox("Welcome")

        MessageBox.Show("this is another message")


    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Kris"
        stLastName = "Fynn"

        MsgBox("Hello and welcome " & stFirstName & " " & stLastName & " I hope you are well")

        stFirstName = "Marvin"
        stLastName = "Drake"

        MsgBox("Hello and welcome " & stFirstName & " " & stLastName & " I hope you are well")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click
        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColour As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date



        stMake = "Ford"
        stModel = "EScort"
        iDoors = 5
        stColour = "red"
        bTaxed = "True"
        iEngineSize = 1200
        decPrice = 999.99
        dtDateRegistered = #11/02/2022#

        MsgBox("The car is " & stMake & vbNewLine & stModel & vbNewLine &
               iDoors & vbNewLine & stColour & vbNewLine & bTaxed & vbNewLine &
               iEngineSize & vbNewLine & decPrice & vbNewLine & dtDateRegistered)


    End Sub
End Class
