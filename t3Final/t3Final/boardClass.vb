Public Class boardClass
    Public vaderFlag As Integer
    Private stone(2) As String
    Private board(6, 6) As Integer
    Public player1 As playerClass = New playerClass()
    Public player2 As playerClass = New playerClass()
    Private score1 As Integer
    Private score2 As Integer
    Private exitBtn As Button
    Private backBtn As Button

    Public Sub New()
        player1.name = ""
        player2.name = ""
        score1 = 0
        score2 = 0
        vaderFlag = 0
    End Sub

    Public Sub setDifficulty(ByVal Vader As Integer)
        vaderFlag = Vader
    End Sub

    Public Sub setPlayer(ByVal Name1 As String, ByVal Name2 As String)
        player1.name = Name1
        player1.turnNumber = 1
        player2.name = Name2
        player2.turnNumber = 2
    End Sub

    Public Sub easyVader()

        Dim vaderTurn As Integer                        'variable to hold the numerical value for the AI's turn
        Dim playerTurn As Integer                       'variable to hold the numerical value for the player's turn
        Dim flagFound As Boolean = False                'variable used to control the while loop
        Dim vaderMove1 As Integer                       'variable to hold AI selection of the first dimension of the array
        Dim vaderMove2 As Integer                       'variable to hold AI selection of the second dimension of the array

        If player1.name = "Vader" Then                  'if statement to set the vaderTurn and playerTurn variables
            vaderTurn = 1                               'to their corresponding values to use in Vader's move selection
            playerTurn = 2
        Else
            vaderTurn = 2
            playerTurn = 1
        End If

        Do

            'Do While loop to select a random position and check it for vader's selection. 
            'If position is taken the loop iterates again and checks a new position

            vaderMove1 = CInt(Math.Floor((5 - 0 + 1) * Rnd())) + 0
            'assigns a random integer between and including 0 and 5

            vaderMove2 = CInt(Math.Floor((5 - 0 + 1) * Rnd())) + 0
            'assigns a random integer between and including 0 and 5

            If board(vaderMove1, vaderMove2) = 0 Then
                board(vaderMove1, VaderMove2) = vaderTurn
                flagFound = True
            End If

        Loop While flagFound = False

    End Sub

    Public Sub medVader()

        Dim vaderTurn As Integer                        'variable to hold the numerical value for the AI's turn
        Dim playerTurn As Integer                       'variable to hold the numerical value for the player's turn
        Dim flagFound As Boolean = False                'variable used to control the while loop
        Dim vaderMove1 As Integer                       'variable to hold AI selection of the first dimension of the array
        Dim vaderMove2 As Integer                       'variable to hold AI selection of the second dimension of the array
        Dim loopFlag As Boolean = False                 'variable to tell if the AI has selected a move

        If player1.name = "Vader" Then                  'if statement to set the vaderTurn and playerTurn variables
            vaderTurn = 1                               'to their corresponding values to use in Vader's move selection
            playerTurn = 2
        Else
            vaderTurn = 2
            playerTurn = 1
        End If

        For i As Integer = 0 To 5                                                      'For loop to step through the rows
            If i = 0 Or i = 3 Then                                                     'Only scan the first, third, and fourth rows
                For j As Integer = 0 To 5                                              'Step'For loop to step through each column
                    If board(i, j) = playerTurn Then

                        If board(i, j + 1) = playerTurn And board(i, j + 2) = 0 Then
                            'Check to the right

                            board(i, j + 2) = vaderTurn
                            loopFlag = True
                            Exit For
                        End If

                        If board(i + 1, j + 1) = playerTurn And board(i + 2, j + 2) = 0 Then
                            'Check to the bottom right

                            board(i + 2, j + 2) = vaderTurn
                            loopFlag = True
                            Exit For
                        End If

                        If board(i + 1, j - 1) = playerTurn And board(i + 2, j - 2) = 0 Then
                            'Check to the bottom left

                            board(i + 2, j - 2) = vaderTurn
                            loopFlag = True
                            Exit For
                        End If

                        If board(i + 1, j) = playerTurn And board(i + 2, j) = 0 Then
                            'Check below

                            board(i + 2, j) = vaderTurn
                            loopFlag = True
                            Exit For

                        End If
                    End If
                Next
            End If

            If loopFlag Then
                'To exit the second loop

                Exit For
            End If

        Next

        If loopFlag = False Then
            'Loop to test for horizontle scoring on rows 1, 2, 4, and 5
            'Only runs if a suitable position isnt found above

            For x As Integer = 0 To 5
                If x = 1 Or x = 2 Or x = 4 Or x = 5 Then
                    For y As Integer = 0 To 5
                        If board(x, y) = playerTurn Then
                            If board(x, y + 1) = playerTurn And board(x, y + 2) = 0 Then
                                board(x, y + 2) = vaderTurn
                                loopFlag = True
                                Exit For
                            End If
                        End If
                    Next
                End If

                If loopFlag Then
                    Exit For
                End If

            Next
        End If

        Do While flagFound = False
            'Do While loop to select a random position and check it for vader's selection. If position is taken the loop iterates again and checks a new position

            vaderMove1 = CInt(Math.Floor((5 - 0 + 1) * Rnd())) + 0
            'assigns a random integer between and including 0 and 5

            vaderMove2 = CInt(Math.Floor((5 - 0 + 1) * Rnd())) + 0
            'assigns a random integer between and including 0 and 5

            If board(vaderMove1, vaderMove2) = 0 Then
                board(vaderMove1, vaderMove2) = vaderTurn
                flagFound = True
            End If

        Loop

    End Sub

    Public Sub hardVader()

        Dim vaderTurn As Integer                        'variable to hold the numerical value for the AI's turn
        Dim playerTurn As Integer                       'variable to hold the numerical value for the player's turn
        Dim flagFound As Boolean = False                'variable used to control the while loop
        Dim vaderMove1 As Integer                       'variable to hold AI selection of the first dimension of the array
        Dim vaderMove2 As Integer                       'variable to hold AI selection of the second dimension of the array
        Dim loopFlag As Boolean = False                 'variable to tell if the AI has selected a move 

        Dim turnCounter As Integer                      'placeholder variable until we define a turn counter

        If player1.name = "Vader" Then                  'if statement to set the vaderTurn and playerTurn variables
            vaderTurn = 1                               'to their corresponding values to use in Vader's move selection
            playerTurn = 2
        Else
            vaderTurn = 2
            playerTurn = 1
        End If

        Select Case turnCounter

            Case 0 To 4
                'Utilize the random function for the first 4 turns

                Do
                    'Do While loop to select a random position and check it for vader's selection. 
                    'If position is taken the loop iterates again and checks a new position

                    vaderMove1 = CInt(Math.Floor((5 - 0 + 1) * Rnd())) + 0
                    'assigns a random integer between and including 0 and 5

                    vaderMove2 = CInt(Math.Floor((5 - 0 + 1) * Rnd())) + 0
                    'assigns a random integer between and including 0 and 5

                    If board(vaderMove1, vaderMove2) = 0 Then
                        board(vaderMove1, vaderMove2) = vaderTurn
                        flagFound = True
                    End If

                Loop While flagFound = False

            Case 5 To 18
                'Utilize 2 square offense from turns 5 to 10

                For i As Integer = 0 To 5
                    If i = 0 Or i = 3 Then
                        For j As Integer = 0 To 5
                            If board(i, j) = vaderTurn Then

                                'Check to the right
                                If board(i, j + 1) = vaderTurn And board(i, j + 2) = 0 Then

                                    board(i, j + 2) = vaderTurn
                                    loopFlag = True
                                    Exit For
                                End If

                                'Check to the bottom right
                                If board(i + 1, j + 1) = vaderTurn And board(i + 2, j + 2) = 0 Then

                                    board(i + 2, j + 2) = vaderTurn
                                    loopFlag = True
                                    Exit For
                                End If

                                'Check to the bottom left
                                If board(i + 1, j - 1) = vaderTurn And board(i + 2, j - 2) = 0 Then

                                    board(i + 2, j - 2) = vaderTurn
                                    loopFlag = True
                                    Exit For
                                End If

                                'Check below
                                If board(i + 1, j) = vaderTurn And board(i + 2, j) = 0 Then

                                    board(i + 2, j) = vaderTurn
                                    loopFlag = True
                                    Exit For

                                End If
                            End If
                        Next
                    End If

                    If loopFlag Then
                        'to exit the second loop

                        Exit For
                    End If

                Next

                If loopFlag = False Then
                    'Loop to test for horizontle scoring on rows 1, 2, 4, and 5
                    'Only runs if a suitable position isnt found above

                    For x As Integer = 0 To 5
                        If x = 1 Or x = 2 Or x = 4 Or x = 5 Then
                            For y As Integer = 0 To 5
                                If board(x, y) = playerTurn Then
                                    If board(x, y + 1) = playerTurn And board(x, y + 2) = 0 Then
                                        board(x, y + 2) = vaderTurn
                                        loopFlag = True
                                        Exit For
                                    End If
                                End If
                            Next
                        End If

                        If loopFlag Then
                            Exit For
                        End If

                    Next
                End If

                'this loop is a last resort random selection if the Vader cannot find a position in the above code
                Do While flagFound = False
                    'Do While loop to select a random position and check it for vader's selection. If position is taken the loop iterates again and checks a new position

                    vaderMove1 = CInt(Math.Floor((5 - 0 + 1) * Rnd())) + 0
                    'assigns a random integer between and including 0 and 5

                    vaderMove2 = CInt(Math.Floor((5 - 0 + 1) * Rnd())) + 0
                    'assigns a random integer between and including 0 and 5

                    If board(vaderMove1, vaderMove2) = 0 Then
                        board(vaderMove1, vaderMove2) = vaderTurn
                        flagFound = True
                    End If

                Loop

                'Case 11 To 18
                '    'Utilize 3 square offense from turns 11 to 18

                '    For i As Integer = 0 To 5                               'For loop to step through the rows
                '        If i = 0 Or i = 3 Then                              'Only scan the first, third, and fourth rows
                '            For j As Integer = 0 To 5                       'Step'For loop to step through each column
                '                If board(i, j) = vaderTurn Then

                '                    'Check to the right
                '                    If board(i, j + 1) = vaderTurn And board(i, j + 2) = vaderTurn And
                '                        board(i, j + 3) = 0 Then

                '                        board(i, j + 3) = vaderTurn
                '                        loopFlag = True
                '                        Exit For
                '                    End If

                '                    'Check to the bottom right
                '                    If board(i + 1, j + 1) = vaderTurn And board(i + 2, j + 2) = vaderTurn And
                '                        board(i + 3, j + 3) = 0 Then

                '                        board(i + 3, j + 3) = vaderTurn
                '                        loopFlag = True
                '                        Exit For
                '                    End If

                '                    'Check to the bottom left
                '                    If board(i + 1, j - 1) = vaderTurn And board(i + 2, j - 2) = vaderTurn And
                '                        board(i + 3, j - 3) = 0 Then

                '                        board(i + 3, j - 3) = vaderTurn
                '                        loopFlag = True
                '                        Exit For
                '                    End If

                '                    'Check below
                '                    If board(i + 1, j) = vaderTurn And board(i + 2, j) = vaderTurn And
                '                        board(i + 3, j) Then

                '                        board(i + 3, j) = vaderTurn
                '                        loopFlag = True
                '                        Exit For

                '                    End If
                '                End If
                '            Next
                '        End If

                '        If loopFlag Then
                '            'To exit the second loop

                '            Exit For
                '        End If

                '    Next

                '    If loopFlag = False Then
                '        'Loop to test for horizontle scoring on rows 1, 2, 4, and 5
                '        'Only runs if a suitable position isnt found above
                '        For x As Integer = 0 To 5
                '            If x = 1 Or x = 2 Or x = 4 Or x = 5 Then
                '                For y As Integer = 0 To 5
                '                    If board(x, y) = vaderTurn Then
                '                        If board(x, y + 1) = vaderTurn And board(x, y + 2) = 0 Then
                '                            board(x, y + 2) = vaderTurn
                '                            loopFlag = True
                '                            Exit For
                '                        End If
                '                    End If
                '                Next
                '            End If

                '            If loopFlag Then
                '                Exit For
                '            End If

                '        Next
                '    End If

                '    Do While flagFound = False
                '        'Do While loop to select a random position and check it for vader's selection. 
                '        'If position is taken the loop iterates again and checks a new position

                '        vaderMove1 = CInt(Math.Floor((5 - 0 + 1) * Rnd())) + 0
                '        'assigns a random integer between and including 0 and 5

                '        vaderMove2 = CInt(Math.Floor((5 - 0 + 1) * Rnd())) + 0
                '        'assigns a random integer between and including 0 and 5

                '        If board(vaderMove1, vaderMove2) = 0 Then

                '            board(vaderMove1, vaderMove2) = vaderTurn
                '            flagFound = True

                '        End If

                '    Loop

            Case 18 To 36
                'Utilize defense from turn 18 and on

                For i As Integer = 0 To 5                                                      'For loop to step through the rows
                    If i = 0 Or i = 3 Then                                                     'Only scan the first, third, and fourth rows
                        For j As Integer = 0 To 5                                              'Step'For loop to step through each column
                            If board(i, j) = playerTurn Then

                                If board(i, j + 1) = playerTurn And board(i, j + 2) = 0 Then
                                    'Check to the right

                                    board(i, j + 2) = vaderTurn
                                    loopFlag = True
                                    Exit For
                                End If

                                If board(i + 1, j + 1) = playerTurn And board(i + 2, j + 2) = 0 Then
                                    'Check to the bottom right

                                    board(i + 2, j + 2) = vaderTurn
                                    loopFlag = True
                                    Exit For
                                End If

                                If board(i + 1, j - 1) = playerTurn And board(i + 2, j - 2) = 0 Then
                                    'Check to the bottom left

                                    board(i + 2, j - 2) = vaderTurn
                                    loopFlag = True
                                    Exit For
                                End If

                                If board(i + 1, j) = playerTurn And board(i + 2, j) = 0 Then
                                    'Check below

                                    board(i + 2, j) = vaderTurn
                                    loopFlag = True
                                    Exit For

                                End If
                            End If
                        Next
                    End If

                    If loopFlag Then
                        'To exit the second loop

                        Exit For
                    End If

                Next

                If loopFlag = False Then
                    'Loop to test for horizontle scoring on rows 1, 2, 4, and 5
                    'Only runs if a suitable position isnt found above

                    For x As Integer = 0 To 5
                        If x = 1 Or x = 2 Or x = 4 Or x = 5 Then
                            For y As Integer = 0 To 5
                                If board(x, y) = playerTurn Then
                                    If board(x, y + 1) = playerTurn And board(x, y + 2) = 0 Then
                                        board(x, y + 2) = vaderTurn
                                        loopFlag = True
                                        Exit For
                                    End If
                                End If
                            Next
                        End If

                        If loopFlag Then
                            Exit For
                        End If

                    Next
                End If

                Do While flagFound = False
                    'Do While loop to select a random position and check it for vader's selection. If position is taken the loop iterates again and checks a new position

                    vaderMove1 = CInt(Math.Floor((5 - 0 + 1) * Rnd())) + 0
                    'assigns a random integer between and including 0 and 5

                    vaderMove2 = CInt(Math.Floor((5 - 0 + 1) * Rnd())) + 0
                    'assigns a random integer between and including 0 and 5

                    If board(vaderMove1, vaderMove2) = 0 Then
                        board(vaderMove1, vaderMove2) = vaderTurn
                        flagFound = True
                    End If

                Loop

        End Select

    End Sub

    Public Sub getScores(ByVal score1 As Integer, ByVal score2 As Integer)
        'Calculate the score 
        score1 = score1
        score2 = score2
    End Sub

    Public Sub setScores()
        'Open the file and add the scores
    End Sub

    Public Sub setStone(ByVal color As String, ByVal color2 As String)
        'Place the stone on the board
    End Sub

    Public Sub exitButton()
        'Exit the board 
    End Sub

    Public Sub backButton()
        'Goes back to the previous menu
    End Sub
End Class
