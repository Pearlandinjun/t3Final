﻿Public Class mainMenuForm

    'Exit button will close the program 
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    'vsPlayerButton
    'Log in for two players
    'Procedure: 
    '   Hides main menu 
    '   Displays log in menu for first player
    '   Displays log in menu for second player 
    'Returns:
    '   Username for player 1 
    '   Username for player 2
    Private Sub vsPlayerBtn_Click(sender As Object, e As EventArgs) Handles vsPlayerBtn.Click
        Me.Hide()
        'Has to display log in menu twice
        loginMenuForm.setCount(2)
        loginMenuForm.Show()
    End Sub

    'vsVaderButton
    'Log in only for one player
    'Procedure:
    '   Displays log in for one player
    'Returns:
    '   Username for player
    Private Sub vsVaderBtn_Click(sender As Object, e As EventArgs) Handles vsVaderBtn.Click
        Me.Hide()
        'Has to display log in menu once
        loginMenuForm.setCount(1)
        GameBoard1.Board.player1.setVader()
        loginMenuForm.Show()
    End Sub

    'Register Button
    'Registration for one player 
    'Procedure:
    '   Displays registration for one player
    '   Makes new username in file
    'Returns: 
    '   Registration complete
    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        loginMenuForm.enterUsernameLabel.Text = "Create username"
        loginMenuForm.Text = "Register"
        Me.Hide()
        loginMenuForm.setCount(3)
        loginMenuForm.guestRadioButton.Visible = False
        loginMenuForm.Show()

    End Sub

    'History Button
    'Displays history for register player
    'Procedure:
    '   Player log in
    '   Gather history for player
    '   Displays history 
    'Returns:
    '   Form displaying history
    Private Sub historyBtn_Click(sender As Object, e As EventArgs) Handles historyBtn.Click
        Me.Hide()
        'Has to display log in menu once 
        'Then display score menu 
        loginMenuForm.setCount(4)
        loginMenuForm.guestRadioButton.Visible = False
        loginMenuForm.Show()
    End Sub

End Class
