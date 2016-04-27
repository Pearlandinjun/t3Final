Imports System.IO
Public Class scoreMenuForm
    Private playerHistory As historyClass = New historyClass()
    Private username As String = "UHD"
    'Holds the button to view
    Private Sub Btn_View_Click(sender As Object, e As EventArgs) Handles Btn_View.Click
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




    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles historyTextBox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub scoreMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class