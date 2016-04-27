Public Class loginMenuForm
    Private count As Integer = 0
    Public username, usernameCopy As String
    Private guest As Boolean = False
    Private nameError As Boolean = True
    Private loginSucess As Boolean = False
    Private guestAgain As Boolean = True
    'back button
    'Allows player to return to the main menu
    'Procedure:
    '   Closes the login menu
    '   Shows main menu
    'Return:
    '   None
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
        mainMenuForm.Show()
    End Sub


    'enter button
    'Checks if player entered username or checked play as guest
    'Procedure:
    '   If checked guest then set name as guest 
    '   If entered username 
    '   Open text file
    '   Searches text file for given username
    '   If invalid username then ask another username
    'Return:
    '   Message indicating if valid username
    Private Sub enterButton_Click(sender As Object, e As EventArgs) Handles enterButton.Click
        Try
            If Not nameError Or guest Then
                If count = 3 Then
                    GameBoard1.Board.player1.Register(username)
                ElseIf count = 2 Then
                    If guest Then
                        username = "GUEST"
                        loginSucess = GameBoard1.Board.player1.Login(username)
                        If loginSucess Then
                            usernameTextBox.Clear()
                            count -= 1
                        End If
                    Else
                        loginSucess = GameBoard1.Board.player1.Login(username)
                        If loginSucess Then
                            usernameCopy = username
                            usernameTextBox.Clear()
                            count -= 1
                        End If
                    End If
                ElseIf count = 1 Then
                    If guest Then
                        username = "GUEST"
                        loginSucess = GameBoard1.Board.player2.Login(username)
                        If loginSucess Then
                            MsgBox("Now choose your settings.")
                            Me.Close()
                            setupMenuForm.Show()
                        End If
                    Else

                        If username = usernameCopy Then
                            errorLabel2.Text = "Enter different username."
                        Else
                            loginSucess = GameBoard1.Board.player2.Login(username)
                            If loginSucess Then
                                MsgBox("Now choose your settings.")
                                Me.Close()
                                setupMenuForm.Show()
                            End If
                        End If
                    End If
            End If
            Else
                errorLabel2.Text = "Invalid username."
            End If
        Catch
            errorLabel2.Text = "Invalid username."
        End Try

    End Sub

    'usernameTextBox
    'Allows player to enter username
    'Procedure:
    '   Player enters username
    '   If valid sets the username to name of player 
    'Returns: 
    '   message indicating if username is valid
    Private Sub usernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles usernameTextBox.TextChanged
        Try
            username = usernameTextBox.Text.ToUpper
            If username.Contains("VADER") Or username.Contains(" ") Or username.Contains("GUEST") Or username.Length = 0 Then
                nameError = True
            Else
                errorLabel2.Text = " "
                nameError = False
            End If
        Catch
            errorLabel2.Text = "Invalid username."
            nameError = True
        End Try
    End Sub

    'setCount
    'set maximum number of time login menu will be called 
    'Arguments:
    '   cnt as integer 
    Public Sub setCount(ByVal cnt As Integer)
        count = cnt
    End Sub

    'guest radio button
    'Allows player to play as guest
    'Procedure:
    '   if checked then set boolen variable to true
    'Returns:
    '   None
    Private Sub guestRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles guestRadioButton.CheckedChanged
        Try
            guest = True
            usernameTextBox.Clear()
            errorLabel2.Text = "Play as guest."
        Catch
            errorLabel2.Text = "Can not play as guest. "
        End Try
    End Sub

    'Username textbox gotfocus
    'Adds focus to the username textbox and unchecks guest radio button
    'Sets guest to false
    'Procedure:
    '   unchecks guestRadiobutton
    '   sets guest to false
    '   erases whatever is in the errorLabel
    'Returns:
    '   None
    Private Sub usernameTextBox_GotFocus(sender As Object, e As EventArgs) Handles usernameTextBox.GotFocus
        Try
            guestRadioButton.Checked = False
            guest = False
            errorLabel2.Text = " "
        Catch
            errorLabel2.Text = "Sorry. Can not enter username. "
        End Try
    End Sub
    'Things left to do 
    '1. Make function to look for username in file 
    '2. Error handling vader and guest as username
    '3. Testing 


End Class