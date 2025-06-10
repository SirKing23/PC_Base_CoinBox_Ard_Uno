Public Class AddRate
    Private Sub newRateBtn_Click(sender As Object, e As EventArgs) Handles newRateBtn.Click
        rateRate.BackColor = Color.White

        If newRateBtn.Text = "Edit" Then ' edit existing rate

            Dim selectedIndex As Integer = SetUp_Page.RatesDataGridView.SelectedRows(0).Index
            SetUp_Page.RatesDataGridView.Rows.RemoveAt(selectedIndex)

            If SaveRatesFromDataGrid(SetUp_Page.RatesDataGridView) Then
                SaveRate()
            Else
                MsgBox("There is a problem in editing the selected Rate", vbInformation, "Failed")
            End If

        Else 'add new rate
            If isTextBoxNull(rateName) + isTextBoxNull(rateRate) + isTextBoxNull(rateMinutes) + isTextBoxNull(rateNotes) = 0 Then
                If isTextBoxZero(rateRate) + isTextBoxZero(rateMinutes) = 0 Then
                    Dim present As Integer = SearchInRates(rateRate.Text, 2)
                    If present > 0 Then
                        MsgBox("Same Rate value already exist!.", vbCritical, "Add Rate failed")
                        rateRate.BackColor = Color.Pink
                    Else
                        SaveRate()
                    End If
                Else
                    MsgBox("There is an internal error occured while saving the rate. Please run the program as administrator.", vbCritical, "Add Rate failed")
                End If
            End If
        End If

    End Sub
    Private Function SaveRate()
        If AddNewRate(rateName.Text, rateRate.Text, rateMinutes.Text, rateNotes.Text) Then
            SetUp_Page.RatesDataGridView.Rows.Clear()
            RatesLoad(SetUp_Page.RatesDataGridView)
            MsgBox(rateName.Text & " has been " & newRateBtn.Text & "ed successfully!", vbInformation, "Success")
            resetTextBoxToNull(rateName)
            resetTextBoxToNull(rateRate)
            resetTextBoxToNull(rateMinutes)
            resetTextBoxToNull(rateNotes)
            Close()
        End If
    End Function


    Private Sub rateRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rateRate.KeyPress
        numbersonly(rateRate, e)
    End Sub

    Private Sub rateMinutes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rateMinutes.KeyPress
        numbersonly(rateMinutes, e)
    End Sub



    Private Sub AddRate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class