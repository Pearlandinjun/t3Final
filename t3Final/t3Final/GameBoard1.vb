Public Class GameBoard1
    Dim turnCounter As Integer = 1
    Public Board As boardClass = New boardClass()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button1.Visible Then
            Button1.Visible = False
            PictureBox1.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox1.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox1.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub turn1PicBox_Click(sender As Object, e As EventArgs) Handles turn1PicBox.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button2.Visible Then
            Button2.Visible = False
            PictureBox2.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox2.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox2.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button3.Visible Then
            Button3.Visible = False
            PictureBox3.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox3.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox3.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button4.Visible Then
            Button4.Visible = False
            PictureBox4.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox4.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox4.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button5.Visible Then
            Button5.Visible = False
            PictureBox5.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox5.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox5.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button6.Visible Then
            Button6.Visible = False
            PictureBox6.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox6.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox6.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button7.Visible Then
            Button7.Visible = False
            PictureBox7.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox7.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox7.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button8.Visible Then
            Button8.Visible = False
            PictureBox8.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox8.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox8.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button9.Visible Then
            Button9.Visible = False
            PictureBox9.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox9.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox9.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button10.Visible Then
            Button10.Visible = False
            PictureBox10.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox10.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox10.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button11.Visible Then
            Button11.Visible = False
            PictureBox11.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox11.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox11.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button12.Visible Then
            Button12.Visible = False
            PictureBox12.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox12.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox12.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button13.Visible Then
            Button13.Visible = False
            PictureBox13.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox13.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox13.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button14.Visible Then
            Button14.Visible = False
            PictureBox14.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox14.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox14.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button15.Visible Then
            Button15.Visible = False
            PictureBox15.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox15.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox15.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button16.Visible Then
            Button16.Visible = False
            PictureBox16.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox16.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox16.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button17.Visible Then
            Button17.Visible = False
            PictureBox17.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox17.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox17.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button18.Visible Then
            Button18.Visible = False
            PictureBox18.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox18.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox18.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button19.Visible Then
            Button19.Visible = False
            PictureBox19.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox19.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox19.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button20.Visible Then
            Button20.Visible = False
            PictureBox20.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox20.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox20.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button21.Visible Then
            Button21.Visible = False
            PictureBox21.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox21.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox21.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button22.Visible Then
            Button22.Visible = False
            PictureBox22.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox22.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox22.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button23.Visible Then
            Button23.Visible = False
            PictureBox23.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox23.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox23.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button24.Visible Then
            Button24.Visible = False
            PictureBox24.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox24.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox24.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button25.Visible Then
            Button25.Visible = False
            PictureBox25.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox25.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox25.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button26.Visible Then
            Button26.Visible = False
            PictureBox26.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox26.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox26.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button27.Visible Then
            Button27.Visible = False
            PictureBox27.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox27.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox27.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button28.Visible Then
            Button28.Visible = False
            PictureBox28.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox28.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox28.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button29.Visible Then
            Button29.Visible = False
            PictureBox29.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox29.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox29.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button30.Visible Then
            Button30.Visible = False
            PictureBox30.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox30.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox30.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button31.Visible Then
            Button31.Visible = False
            PictureBox31.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox31.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox31.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button32.Visible Then
            Button32.Visible = False
            PictureBox32.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox32.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox32.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button33.Visible Then
            Button33.Visible = False
            PictureBox33.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox33.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox33.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button34.Visible Then
            Button34.Visible = False
            PictureBox34.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox34.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox34.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button35.Visible Then
            Button35.Visible = False
            PictureBox35.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox35.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox35.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        If Board.vaderFlag = 1 Then
            Board.easyVader()
        ElseIf Board.vaderFlag = 2 Then
            Board.medVader()
        ElseIf Board.vaderFlag = 3 Then
            Board.hardVader()
        Else

        End If
        If Button36.Visible Then
            Button36.Visible = False
            PictureBox36.Visible = True
            If turnCounter Mod 2 = 0 Then
                PictureBox36.Image = turn1PicBox.Image
            ElseIf turnCounter Mod 2 = 1 Then
                PictureBox36.Image = turn2PicBox.Image
            End If
            turnCounter += 1
        End If
    End Sub

    Private Sub GameBoard1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class