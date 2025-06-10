Module Module_Access
    Public Function ChangePin(ByVal CurrPin As TextBox, ByVal NewPass As TextBox, ByVal NewPassConfirm As TextBox) As Boolean
        CurrPin.BackColor = Color.White
        NewPass.BackColor = Color.White
        NewPassConfirm.BackColor = Color.White
        If CurrPin.Text = My.Settings.Access Then
            If NewPass.Text = "" Then
                NewPass.BackColor = Color.Pink
                MsgBox("New PIN cannot be empty", vbCritical, "Change PIN")
                Return False
            Else
                If NewPassConfirm.Text = "" Then
                    NewPassConfirm.BackColor = Color.Pink
                    MsgBox("Please confirm your PIN", vbCritical, "Change PIN")
                    Return False
                Else

                    If NewPass.Text = NewPassConfirm.Text Then
                        My.Settings.Access = NewPass.Text
                        My.Settings.Save()
                        MsgBox("Change PIN success!", vbInformation, "Change PIN")
                        Return True
                    Else
                        NewPassConfirm.BackColor = Color.Pink
                        MsgBox("PIN mismatch", vbCritical, "Change PIN")
                        Return False
                    End If
                End If
            End If
        Else
            CurrPin.BackColor = Color.Pink
            MsgBox("Current PIN is invalid", vbCritical, "Change PIN")
            Return False
        End If
    End Function

    Public Function SavePCInfo(ByVal PCName As TextBox, ByVal PCNumber As TextBox) As Boolean
        If isTextBoxNull(PCName) + isTextBoxNull(PCNumber) = 0 Then
            My.Settings.Setting_PC_Name = PCName.Text
            My.Settings.Setting_PC_Number = PCNumber.Text
            My.Settings.Save()
            Return True
        Else
            Return False
        End If

    End Function
End Module
