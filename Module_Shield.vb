Module Module_Shield

    Dim p() As Process
    Public Function RunShield(ByVal isTerminator As Boolean)
        Dim AppNameToRun As String

        If isTerminator = False Then
            AppNameToRun = "Acs" ' si anti cheat system ang irurun
        Else
            If My.Settings.Terminator Then
                AppNameToRun = "CoinShield" ' si terminator ang irurun
            Else
                Exit Function ' naka off ang terminator sa settings kaya hindi mateterminate ang mga app after the time
            End If

        End If

        p = Process.GetProcessesByName(AppNameToRun)
        If p.Count > 0 Then

        Else
            Try
                Dim proc As New System.Diagnostics.Process()
                proc = Process.Start(AppDomain.CurrentDomain.BaseDirectory & AppNameToRun, "")
            Catch ex As Exception

            End Try
        End If
    End Function


End Module
