Public Class warning
    Dim timerme As Integer = 0

    Private Sub warning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        warn.Text = "Warning last " & My.Settings.TimesUpWarningTime & " minutes!"
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If timerme = 20 Then
            Close()
        Else
            timerme = timerme + 1
            If Visible = True Then
                Visible = False
                TopMost = False
            Else
                Visible = True
                TopMost = True
            End If
        End If
    End Sub
End Class