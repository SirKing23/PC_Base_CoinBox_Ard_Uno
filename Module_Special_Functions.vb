Module Module_Special_Functions
    Public closingApp As Boolean
    Public Function numbersonly(ByVal Txtbox As TextBox, ByVal e As KeyPressEventArgs)

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Function

    Public Function RunOnStartUp(ByVal SetValue As Boolean) As Boolean
        Try
            Select Case SetValue
                Case True
                    Try
                        Dim exePath As String = Application.ExecutablePath()
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "CoinBoX3", exePath)
                        Return True
                    Catch ex As Exception
                        ' Handle the exception (e.g., log it or display an error message)
                        Return False
                    End Try
                Case False
                    Try
                        Dim key As Microsoft.Win32.RegistryKey
                        key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)

                        ' Check if the registry key exists before attempting to delete
                        If key.GetValue("CoinBoX3") IsNot Nothing Then
                            key.DeleteValue("CoinBoX3")
                        End If

                        Return True
                    Catch ex As Exception
                        ' Handle the exception (e.g., log it or display an error message)
                        Return False
                    End Try
            End Select


        Catch ex As Exception
            MsgBox(ex)
            Return False
        End Try

    End Function


    Public Function DisableTaskManager(ByVal SetValue As Boolean) As Boolean
        Try
            Select Case SetValue
                Case True
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 1)
                    Return True
                Case False
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 0)
                    Return True
            End Select
        Catch ex As Exception

            Return False


        End Try

    End Function

    Public Function GetDate() As String
        Dim currentDateTime As DateTime = DateTime.Now
        Dim formattedDateTime As String = currentDateTime.ToString("MMMM dd, yyyy - h:mm tt")
        Return (formattedDateTime)

    End Function

    Public Function isTextBoxNull(ByVal toCheck As TextBox) As Integer
        If toCheck.Text = "" Then
            toCheck.BackColor = Color.Pink
            Return 1
        Else
            toCheck.BackColor = Color.White
            Return 0
        End If
    End Function

    Public Function isTextBoxZero(ByVal toCheck As TextBox) As Integer
        If toCheck.Text = "0" Then
            toCheck.BackColor = Color.Pink
            Return 1
        Else
            toCheck.BackColor = Color.White
            Return 0
        End If
    End Function

    Public Function resetTextBoxToNull(ByVal toReset As TextBox)
        toReset.Text = ""
        toReset.BackColor = Color.White
    End Function
    Public Function resetTextBoxToNullError(ByVal toReset As TextBox)
        toReset.Text = ""
        toReset.BackColor = Color.Pink
    End Function


End Module
Public Class BorderlessGroupBox
    Inherits GroupBox

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Draw the group box, but omit the border
        Dim textSize = e.Graphics.MeasureString(Me.Text, Me.Font)
        Dim textRect = New Rectangle(6, 0, CInt(textSize.Width), CInt(textSize.Height))
        e.Graphics.Clear(Me.BackColor)
        e.Graphics.DrawString(Me.Text, Me.Font, Brushes.Black, textRect)
    End Sub
End Class