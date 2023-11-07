Public Class frmQuestion3


    Public Sub init()


        progressCount = 0
        trmQuestion3.Enabled = True
        ProgressBarQ3.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        trmQuestion3.Enabled = False
        If btnAnswer2.Checked Then
            playerScore = playerScore + 1

        End If
        frmHighScore.Show()
        frmHighScore.doScore()
        Me.Hide()
    End Sub

    Private Sub trmQuestion3_Tick(sender As Object, e As EventArgs) Handles trmQuestion3.Tick
        progressCount = progressCount + 1
        ProgressBarQ3.PerformStep()
        If progressCount = 10 Then
            trmQuestion3.Enabled = False
            MsgBox("Time Out")
            frmHighScore.Show()
            frmHighScore.doScore()
        End If
    End Sub
End Class