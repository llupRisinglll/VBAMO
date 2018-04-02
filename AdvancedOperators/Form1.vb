Public Class Form1
    Dim FirstNum, SecondNum As Double

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FirstNum = TextBox1.Text
        SecondNum = TextBox2.Text

        If RadioButton1.Checked = True Then
            TextBox3.Text = FirstNum \ SecondNum
        End If
        If RadioButton2.Checked = True Then
            TextBox3.Text = FirstNum Mod SecondNum
        End If
        If RadioButton3.Checked = True Then
            TextBox3.Text = FirstNum ^ SecondNum
        End If
        If RadioButton4.Checked = True Then
            TextBox3.Text = FirstNum & SecondNum
        End If
    End Sub
End Class
