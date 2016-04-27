Imports System.IO
Public Class scoreMenuForm
    Public playerHistory As historyClass = New historyClass()
    Private username As String = " "

    'Holds the button to view
    Private Sub Btn_View_Click(sender As Object, e As EventArgs) Handles Btn_View.Click
        username = playerHistory.getName()
        historyTextBox.Text = File.ReadAllLines("nameofuser.txt").FirstOrDefault(Function(x) x.Contains(username)) ' this display the found username
    End Sub

    'Holds the Clear button
    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        historyTextBox.Clear()
    End Sub
    'Button to go back or menu
    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()
        mainMenuForm.Show()
    End Sub

End Class