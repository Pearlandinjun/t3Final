Public Class playerClass
    Public name As String = ""
    Public turnNumber As Integer = 0

    'Constructor 
    Public Sub New()
        name = ""
        turnNumber = 0
    End Sub

    'Register
    'Lets player register a new username
    'Procedure:
    '   Open file 
    '   Asks for username 
    '   Checks to see if username is taken
    '   Adds valid username
    'Returns:
    '   Display success
    Public Sub Register(ByVal username As String)
        Try
            Dim usernameFile As New System.IO.StreamReader("nameofuser.txt")
            Dim numberofUsers = 0, yesFlag, noFlag As Integer
            yesFlag = 0
            noFlag = 0
            Dim StrdUsername As String = ""
            Dim NewUsername As String = ""
            NewUsername = username.ToUpper()
            Do Until usernameFile.Peek = -1
                StrdUsername = usernameFile.ReadLine()
                StrdUsername = StrdUsername.ToUpper()
                If StrdUsername = NewUsername Then
                    yesFlag += 1
                Else
                    noFlag = 0
                End If
                numberofUsers += 1
            Loop
            usernameFile.Close()
            If (yesFlag > 0) Then
                MsgBox("Username exist. Please enter a different name")
            Else
                Dim file As New System.IO.StreamWriter("nameofuser.txt", True)
                file.WriteLine(NewUsername)
                file.Close()
                loginMenuForm.Close()
                mainMenuForm.Show()
                MsgBox(" REGISTRATION WAS SUCESSFUL!" & ControlChars.CrLf & " THANK YOU FOR REGISTERING." & ControlChars.CrLf & " ENJOY THE GAME!")
            End If

        Catch
            loginMenuForm.errorLabel2.Text = "File not found."
        End Try
    End Sub
    'Log in
    'Lets player login with username
    'Procedure:
    '   Open file 
    '   Asks for username or guest
    '   If guest adds guest to game board player name
    '   Checks if username is valid
    '   Adds valid username to game board player name 
    'Returns:
    '   Display success
    Public Function Login(ByVal username As String)
        Try
            Dim usernameFile As New System.IO.StreamReader("nameofuser.txt")
            Dim numberofUsers = 0, yesFlag = 0, noFlag As Integer = 0
            Dim StrdUsername As String = ""
            Dim NewUsername As String = username
            Do Until usernameFile.Peek = -1
                StrdUsername = usernameFile.ReadLine()
                If StrdUsername = NewUsername Then
                    yesFlag += 1
                Else
                    noFlag = 0
                End If
                numberofUsers += 1
            Loop
            If (yesFlag > 0) Then
                loginMenuForm.errorLabel2.Text = "Username found."
                name = username
                Return True
            Else
                MsgBox("Username not found." & ControlChars.CrLf & "Please register or play as guest")
                Return False
            End If
        Catch
            loginMenuForm.errorLabel2.Text = "File not found."
            Return False
        End Try
    End Function

    'SetVader
    'Sets the second player as Vader
    'Procedure:
    '   Sets the game board player 2 name to Vader 
    'Returns:
    '   Display success
    Public Sub setVader()
        name = "Vader"
    End Sub

End Class
