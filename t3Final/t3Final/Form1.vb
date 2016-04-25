Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Sr As New StreamReader("nameofuser.txt")
        Dim i = 0, flagyes, flagno As Integer
        flagyes = 0
        flagno = 0
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

        Do Until Sr.Peek = -1
            StrdUsername = Sr.ReadLine()
            StrdUsername = StrdUsername.ToUpper
            If StrdUsername = NewUsername Then
                flagyes = flagyes + 1
            Else
                flagno = 0
            End If
            i = i + 1
        Loop
        Sr.Close()
        If (flagyes > 0) Then
            MsgBox("Please Enter another username different than before")
        Else
            Sr.Close()
            Dim file As New StreamWriter("nameofuser.txt", True)
            file.WriteLine(NewUsername)
            file.Close()
            MsgBox(" REGISTRATION WAS SUCESSFUL" & ControlChars.CrLf & " THANK YOU FOR THE REGISRATION WITH VADER TIC-TAC-TOE" & ControlChars.CrLf & " ENJOY THE GAME")
        End If
    End Sub

End Class
