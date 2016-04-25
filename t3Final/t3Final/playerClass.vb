Public Class playerClass
    Public name As String = ""
    'Private guest As String = "guest"
    Public turnNumber As Integer = 0

    'Constructor 
    Public Sub New()
        name = ""
        'guest = "guest"
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
    Public Sub Register()
        'Using usernameFile As New System.IO.StreamWriter("username.txt")
        '    usernameFile.WriteLine(username)
        'End Using
        '  Dim usernameFile As New StreamReader("nameofuser.txt")
        Dim i = 0, yesFlag, noFlag As Integer
        yesFlag = 0
        noFlag = 0
        Dim StrdUsername As String = ""
        Dim NewUsername As String = ""
        Dim users(20) As String
BEGINHERE:
        NewUsername = InputBox(" Please Ente your Username without space ", "Input needed")
        NewUsername = NewUsername.ToUpper()
        If (NewUsername = "") Then
            MsgBox("Username cannot be blank")
            GoTo BEGINHERE
        End If

        'Do Until usernameFile.Peek = -1
        '    StrdUsername = usernameFile.ReadLine()
        '    StrdUsername = StrdUsername.ToUpper
        '    If StrdUsername = NewUsername Then
        '        yesFlag = yesFlag + 1
        '    Else
        '        noFlag = 0
        '    End If
        '    i = i + 1
        'Loop
        'usernameFile.Close()
        'If (yesFlag > 0) Then
        '    MsgBox("Please Enter another username different than before")
        'Else
        '    usernameFile.Close()
        '    Dim file As New StreamWriter("nameofuser.txt", True)
        '    file.WriteLine(NewUsername)
        '    file.Close()
        '    MsgBox(" REGISTRATION WAS SUCESSFUL" & ControlChars.CrLf & " THANK YOU FOR THE REGIusernameFileATION WITH VADER TIC-TAC-TOE" & ControlChars.CrLf & " ENJOY THE GAME")
        'End If
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
    Public Sub Login()
        Dim usernameFile = IO.File.ReadAllText("nameofuser.txt")
        Dim lookFor As String = loginMenuForm.username.ToUpper()
        If usernameFile.Contains(lookFor) Then

        End If
        Dim i = 0, yesFlag, noFlag As Integer
        yesFlag = 0
        noFlag = 0
        Dim StrdUsername As String = ""
        Dim NewUsername As String = ""
        Dim users(20) As String
BEGINHERE:
        NewUsername = loginMenuForm.username
        NewUsername = NewUsername.ToUpper()
        If (NewUsername = "") Then
            MsgBox("Username cannot be blank")
            GoTo BEGINHERE
        End If

        'Do Until usernameFile.Peek = -1
        '    StrdUsername = usernameFile.ReadLine()
        '    StrdUsername = StrdUsername.ToUpper
        '    If StrdUsername = NewUsername Then
        '        yesFlag = yesFlag + 1
        '    Else
        '        noFlag = 0
        '    End If
        '    i = i + 1
        'Loop
        'usernameFile.Close()
        'If (yesFlag > 0) Then
        '    MsgBox("Please Enter another username different than before")
        'Else
        '    usernameFile.Close()
        '    Dim file As New StreamWriter("nameofuser.txt", True)
        '    file.WriteLine(NewUsername)
        '    file.Close()
        '    MsgBox(" REGISTRATION WAS SUCESSFUL" & ControlChars.CrLf & " THANK YOU FOR THE REGIusernameFileATION WITH VADER TIC-TAC-TOE" & ControlChars.CrLf & " ENJOY THE GAME")
        'End If
    End Sub

    'SetVader
    'Sets the second player as Vader
    'Procedure:
    '   Sets the game board player 2 name to Vader 
    'Returns:
    '   Display success
    Public Sub setVader()
        name = "Vader"
    End Sub

    Private Sub searchFile()
        '    Try
        '        Dim usernameFile = IO.File.ReadAllText("username.txt")
        '        'Dim lookfor As String = username
        '        ' If usernameFile.Contains(lookfor) Then
        '        loginMenuForm.errorLabel.Text = "Username found"
        '        loginMenuForm.errorLabel.Visible = False

        '        Else
        '        loginMenuForm.errorLabel.Text = "Username not found"
        '        loginMenuForm.errorLabel.Visible = True
        '        End If
        '        'Using usernameFile As New System.IO.StreamWriter("username.txt")
        '        '    usernameFile.WriteLine(username)
        '        'End Using
        '    Catch
        '        errorLabel.Text = "Error with file"

        '    End Try

    End Sub
End Class
