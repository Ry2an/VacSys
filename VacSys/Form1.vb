Public Class Form1
    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim code As String = TextBox1.Text
        If code(0) = "P" Then
            Me.Hide()
            Form3.Show()
            Exit Sub
        End If
        If code(0) = "D" Then
            Me.Hide()
            Form2.Show()
            Exit Sub
        End If
        If code(0) = "X" Then
            Me.Hide()
            Form6.Show()
            Exit Sub
        End If
        If code(0) = "J" Then
            Me.Hide()
            Form5.Show()
            Exit Sub
        End If
        If code(0) = "Y" Then
            Me.Hide()
            Form4.Show()
            Exit Sub
        End If
        MessageBox.Show("Wrong Input!")
    End Sub

    Private Sub exit1_Click(sender As Object, e As EventArgs) Handles exit1.Click
        Me.Close()
    End Sub
End Class
