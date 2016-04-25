Public Class historyClass
    Private name As playerClass = New playerClass()
    Private wins As Integer = 0
    Private loss As Integer = 0
    Private tie As Integer = 0
    Private opponent As String

    Public Sub New()
        name.name = ""
        wins = 0
        loss = 0
        tie = 0
        opponent = ""
    End Sub

    Public Sub getScore()
        'Retrieve scores from gameboard
        'name = 
        'wins =
        'loss =
        'tie =
    End Sub
    Public Sub setScore()
        'open file
        'Add the score to variable
        'if score = wins then wins +=1
        'if score = loss then loss +=1
        'if score = tie then tie +=1
    End Sub
End Class
