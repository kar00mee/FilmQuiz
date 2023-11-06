Public Class frmQuestion3
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnAnswer2.Checked Then
            playerScore = playerScore + 1

        End If
        frmHighScore.Show()
        frmHighScore.doScore()
        Me.Hide()
    End Sub
End Class