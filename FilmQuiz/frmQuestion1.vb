﻿Public Class frmQuestion1
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer4.CheckedChanged

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnAnswer2.Checked Then
            playerScore = playerScore + 1
        End If
        frmQuestion2.Show()
        Me.Hide()
    End Sub
End Class