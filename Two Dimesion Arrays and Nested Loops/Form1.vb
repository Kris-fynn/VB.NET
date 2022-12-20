Public Class Form1
    Private Sub btnRowWise_Click(sender As Object, e As EventArgs) Handles btnRowWise.Click

        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematcian"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Eistein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Mahatma"
        astPeople(1, 4) = "Ghandhi"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Indian"
        astPeople(4, 4) = "lawyer"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = " van Gogh"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"

        Dim x As Integer
        Dim y As Integer



        For y = 0 To 5
            For x = 0 To 4
                MsgBox(astPeople(x, y))
            Next
        Next


    End Sub

    Private Sub btnColumnWise_Click(sender As Object, e As EventArgs) Handles btnColumnWise.Click

        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematcian"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Eistein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Mahatma"
        astPeople(1, 4) = "Ghandhi"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Indian"
        astPeople(4, 4) = "lawyer"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = " van Gogh"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"

        Dim x As Integer
        Dim y As Integer

        For x = 0 To 4
            For y = 0 To 5
                MsgBox(astPeople(x, y))
            Next
        Next


    End Sub

    Private Sub btnOutputAll_Click(sender As Object, e As EventArgs) Handles btnOutputAll.Click

        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematcian"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Eistein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Mahatma"
        astPeople(1, 4) = "Ghandhi"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Indian"
        astPeople(4, 4) = "lawyer"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = " van Gogh"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"

        Dim x As Integer
        Dim y As Integer
        Dim stOut As String

        For y = 0 To 5
            For x = 0 To 4
                stOut = stOut & astPeople(x, y) & " "
            Next
            stOut = stOut & vbNewLine
        Next

        MsgBox(stOut)


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematcian"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Eistein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Mahatma"
        astPeople(1, 4) = "Ghandhi"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Indian"
        astPeople(4, 4) = "lawyer"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "van Gogh"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"

        Dim x As Integer
        Dim y As Integer
        Dim bFound As Boolean
        Dim stTarget As String
        Dim stOut As String

        bFound = False

        stTarget = InputBox("Enter the Surname of the person you want ti find")

        For y = 0 To 5
            If astPeople(1, y) = stTarget Then
                bFound = True
                Exit For
            End If
        Next

        If bFound = True Then
            For x = 0 To 4
                stOut = stOut & astPeople(x, y) & " "
            Next
        Else
            MsgBox("not found")
        End If

        MsgBox(stOut)

    End Sub
End Class
