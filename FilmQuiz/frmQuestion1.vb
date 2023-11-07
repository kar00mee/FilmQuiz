Public Class frmQuestion1

    Public Sub init()
        progressCount = 0
        trmQuestion1.Enabled = True
        ProgressBarQ1.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False



    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        trmQuestion1.Enabled = False

        If btnAnswer2.Checked Then
            playerScore = playerScore + 1
        End If
        frmQuestion2.Show()
        frmQuestion2.init()
        Me.Hide()
    End Sub

    Private Sub ProgressCount1_Click(sender As Object, e As EventArgs) Handles ProgressBarQ1.Click

    End Sub

    Private Sub frmQuestion1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub trmQuestion1_Tick(sender As Object, e As EventArgs) Handles trmQuestion1.Tick
        progressCount = progressCount + 1
        ProgressBarQ1.PerformStep()
        If progressCount = 10 Then
            trmQuestion1.Enabled = False
            MsgBox("Time Out")
            frmQuestion2.Show()
            frmQuestion2.init()
        End If
    End Sub
End Class