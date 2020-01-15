Public Class SevenSegment

    Dim counter As Int16
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button8.Text = "START" Or Button8.Text = "RESTART" Then
            Timer1.Interval = 1000
            Timer1.Start()

        ElseIf Button8.Text = "STOP" Then
            Timer1.Stop()
            counter = 0
            Button8.Text = "RESTART"

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter += 1
        Button8.Text = "STOP"

        Button1.BackColor = Color.Crimson
        Button2.BackColor = Color.Crimson
        Button3.BackColor = Color.Crimson
        Button4.BackColor = Color.Crimson
        Button5.BackColor = Color.Crimson
        Button6.BackColor = Color.Crimson
        Button7.BackColor = Color.Ivory

        If counter = 1 Then
            Button1.BackColor = Color.Ivory
            Button2.BackColor = Color.Crimson
            Button3.BackColor = Color.Crimson
            Button4.BackColor = Color.Ivory
            Button5.BackColor = Color.Ivory
            Button6.BackColor = Color.Ivory
            Button7.BackColor = Color.Ivory

        ElseIf counter = 2 Then
            Button1.BackColor = Color.Crimson
            Button2.BackColor = Color.Crimson
            Button3.BackColor = Color.Ivory
            Button4.BackColor = Color.Crimson
            Button5.BackColor = Color.Crimson
            Button6.BackColor = Color.Ivory
            Button7.BackColor = Color.Crimson

        ElseIf counter = 3 Then
            Button1.BackColor = Color.Crimson
            Button2.BackColor = Color.Crimson
            Button3.BackColor = Color.Crimson
            Button4.BackColor = Color.Crimson
            Button5.BackColor = Color.Ivory
            Button6.BackColor = Color.Ivory
            Button7.BackColor = Color.Crimson

        ElseIf counter = 4 Then
            Button1.BackColor = Color.Ivory
            Button2.BackColor = Color.Crimson
            Button3.BackColor = Color.Crimson
            Button4.BackColor = Color.Ivory
            Button5.BackColor = Color.Ivory
            Button6.BackColor = Color.Crimson
            Button7.BackColor = Color.Crimson

        ElseIf counter = 5 Then
            Button1.BackColor = Color.Crimson
            Button2.BackColor = Color.Ivory
            Button3.BackColor = Color.Crimson
            Button4.BackColor = Color.Crimson
            Button5.BackColor = Color.Ivory
            Button6.BackColor = Color.Crimson
            Button7.BackColor = Color.Crimson

        ElseIf counter = 6 Then
            Button1.BackColor = Color.Crimson
            Button2.BackColor = Color.Ivory
            Button3.BackColor = Color.Crimson
            Button4.BackColor = Color.Crimson
            Button5.BackColor = Color.Crimson
            Button6.BackColor = Color.Crimson
            Button7.BackColor = Color.Crimson

        ElseIf counter = 7 Then
            Button1.BackColor = Color.Crimson
            Button2.BackColor = Color.Crimson
            Button3.BackColor = Color.Crimson
            Button4.BackColor = Color.Ivory
            Button5.BackColor = Color.Ivory
            Button6.BackColor = Color.Ivory
            Button7.BackColor = Color.Ivory

        ElseIf counter = 8 Then
            Button1.BackColor = Color.Crimson
            Button2.BackColor = Color.Crimson
            Button3.BackColor = Color.Crimson
            Button4.BackColor = Color.Crimson
            Button5.BackColor = Color.Crimson
            Button6.BackColor = Color.Crimson
            Button7.BackColor = Color.Crimson

        ElseIf counter = 9 Then
            Button1.BackColor = Color.Crimson
            Button2.BackColor = Color.Crimson
            Button3.BackColor = Color.Crimson
            Button4.BackColor = Color.Crimson
            Button5.BackColor = Color.Ivory
            Button6.BackColor = Color.Crimson
            Button7.BackColor = Color.Crimson
        End If

        If counter >= 10 Then
            Timer1.Stop()
            counter = 0
            Button8.Text = "START"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub
End Class
