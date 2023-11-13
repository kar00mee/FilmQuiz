Public Class frmMain



    Public Sub playTrack(ByVal track As String)
        wmpQuiz.Ctlcontrols.stop()

        wmpQuiz.URL = track

        wmpQuiz.Ctlcontrols.play()

    End Sub

    Public Sub stopTrack()
        wmpQuiz.Ctlcontrols.stop()
    End Sub


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        playerScore = 0
        playerName = txtPlayerName.Text
        frmQuestion1.Show()
        frmQuestion1.init()
        txtPlayerName.Text = ""
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub txtPlayerName_TextChanged(sender As Object, e As EventArgs) Handles txtPlayerName.TextChanged

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub wmpQuiz_Enter(sender As Object, e As EventArgs) Handles wmpQuiz.Enter

    End Sub
End Class
