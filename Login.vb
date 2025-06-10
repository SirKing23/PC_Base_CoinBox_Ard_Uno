Imports System.ComponentModel
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Public TotalTime As Integer
    Public TempTime As Integer
    Public totalCoinInserted As Integer

    Private Function OfflineMode()

        OfflineNotification.Visible = True
    End Function
    Private Function StandbyMode()

        RunShield(True) 'true ang irurun ay si CoinShield as terminator
        coin_waiter.Enabled = False
        coinInsertGroupBox.Visible = True
        timerGroupBox.Visible = False
        insertcoinWaiter.Visible = False
        timeTimer.Enabled = False
        logInTimeDisplay.Text = "-:-"
        btn_insert_coin.Text = "Insert coin"
        insert_coin_display.Text = "Press insert coin to Start!"
        total_inserted_coin.Visible = False
        inserted_display.Visible = False
        coin_waiter.Enabled = False
        bg.Visible = True
        banner.Visible = True

        WindowState = FormWindowState.Maximized
        SetUp_Page.CheckArduinoConnection.Enabled = True
        'To un arm disable the code below
        TopMost = True
    End Function
    Private Function InserCoinMode() As Boolean

        'Mag on ang relay at coinslot
        If ArduinoSendData("T") Then
            Return True
        Else
            Return False ' offline ang coinslot
        End If

    End Function
    Private Sub TimerMode()
        TempTime = 0
        SetUp_Page.CheckArduinoConnection.Enabled = True
        If logInTimeDisplay.Text = "-:-" Then ' pag naka ganto ibig sabihin unang hulog
            logInTimeDisplay.Text = TimeOfDay
            WindowState = FormWindowState.Normal
            Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim formWidth As Integer = Me.Width
            Dim leftPosition As Integer = (screenWidth - formWidth) \ 2
            bg.Visible = False
            banner.Visible = False
            Me.Location = New Point(leftPosition, 0)
            Size = New Size(335, 268)
            TopMost = False

        End If

        btn_insert_coin.Text = "Insert coin"
        coin_waiter.Enabled = False
        coinInsertGroupBox.Visible = False
        insertcoinWaiter.Visible = False
        timerGroupBox.Visible = True
        timeTimer.Enabled = True
        '  hourDisplay.Text = Convert_to_hour_and_minutes(TotalTime)




    End Sub

    Private Sub LoginAdminMode()
        If TotalTime > 0 Then
            StandbyMode()
        End If

        TotalTime = 0
        timeTimer.Enabled = False
        pinOne.Select()
        coinInsertGroupBox.Visible = False
        timerGroupBox.Visible = False
        btn_insert_coin.Visible = False
        loginGroupBox.Visible = True

    End Sub



    Private Function getInsertedCoin() As Boolean

        'Mag off ang relay at coinslot - 1. all input will be invalid 2. Send the totalAmount inserted 3. reset the totalAmount
        If ArduinoSendData("F") Then
            Return True
        Else
            Return False ' offline ang coinslot
        End If

    End Function



    Private Function isCoinInserted() As Boolean

        Dim insertCoinSession As Integer = Convert_CoinInput_To_Time(data)

        If insertCoinSession > 0 Then
            TempTime = insertCoinSession
            Return True
        Else
            Return False
        End If


        ' the value of data (which is the number of coins inserted ) will become zero after the 
        ' Convert_CoinInput_To_Time(data) function
        'If the value of data is greater than 0, meaning there are coin inserted
        'data is being updated in arduino Data handler

    End Function

    Dim isWarnDisplayed As Boolean ' para malaman na ung warning display ay lumabas na..
    Private Sub timeTimer_Tick(sender As Object, e As EventArgs) Handles timeTimer.Tick
        ' note: TotalTime is in minutes
        'but the timer runs in seconds to update the display

        TotalTime = ClientTimer(TotalTime, hourDisplay, minutesDisplay, secondsDisplay) ' function that will deduct and update the display

        If TotalTime > 0 Then


            If My.Settings.TimesUpWarningTime = 0 Then
            Else
                If My.Settings.TimesUpReminder Then
                    Dim warnTime As Integer
                    warnTime = My.Settings.TimesUpWarningTime
                    If TotalTime = warnTime Then
                        If isWarnDisplayed Then
                        Else
                            warning.Show()
                            isWarnDisplayed = True
                        End If
                    Else
                        isWarnDisplayed = False
                    End If
                End If

            End If

        Else
            StandbyMode()
            isWarnDisplayed = False
            timeTimer.Enabled = False
        End If
    End Sub


    Dim initialInserted As Integer = 0

    Private Sub Coin_waiter_Tick(sender As Object, e As EventArgs) Handles coin_waiter.Tick

        If initialInserted = data Then
            Dim waitTime As Double = 100 / My.Settings.Setting_InsertCoin_Waiting_time
            Dim progValue As Double = insertcoinWaiter.Value - waitTime
            If progValue <= 0 Then
                btn_insert_coin.PerformClick()
            Else
                insertcoinWaiter.Value = progValue
            End If

        Else
            insertcoinWaiter.Value = 100
            actualReceivedCoin = data - initialInserted
            sortReceivedCoins(actualReceivedCoin)
        End If

        initialInserted = data



        total_inserted_coin.Text = "Php. " & data & ".00"
    End Sub


    Private Sub Displayupdater_Tick(sender As Object, e As EventArgs) Handles displayupdater.Tick
        If btn_insert_coin.Text = "Insert coin" Then
            If insert_coin_display.Visible = True Then
                insert_coin_display.Visible = False
            Else
                insert_coin_display.Visible = True
            End If
        Else
            insert_coin_display.Visible = True
            Select Case insert_coin_display.Text
                Case "Waiting for coins"
                    insert_coin_display.Text = "Waiting for coins."
                Case "Waiting for coins."
                    insert_coin_display.Text = "Waiting for coins.."
                Case "Waiting for coins.."
                    insert_coin_display.Text = "Waiting for coins..."
                Case "Waiting for coins..."
                    insert_coin_display.Text = "Waiting for coins"
            End Select

        End If



    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim bgUri As New Uri(My.Settings.Setting_Banner_Path)
        bg.Url = bgUri

        Size = New Size(411, 1070)
        StandbyMode()
        RatesLoad(RatesDataGridView)
        RatesDataGridView.BackgroundColor = Me.BackColor
        RatesDataGridView.RowHeadersVisible = False
        RatesDataGridView.AllowUserToResizeRows = False
        RatesDataGridView.Columns(0).Visible = False
        RatesDataGridView.Columns(1).Visible = False

        RatesDataGridView.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Bold)
        RatesDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White



        RatesDataGridView.DefaultCellStyle.Font = New Font("Arial", 11, FontStyle.Regular)
        RatesDataGridView.DefaultCellStyle.ForeColor = Color.White


        RatesDataGridView.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' rate
        RatesDataGridView.Columns(2).DefaultCellStyle.BackColor = Me.BackColor
        RatesDataGridView.Columns(2).FillWeight = 30

        RatesDataGridView.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        RatesDataGridView.Columns(3).DefaultCellStyle.BackColor = Me.BackColor
        RatesDataGridView.Columns(3).FillWeight = 35

        RatesDataGridView.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        RatesDataGridView.Columns(4).DefaultCellStyle.BackColor = Me.BackColor
        RatesDataGridView.Columns(4).FillWeight = 35


        pcnumber.Text = "PC " & My.Settings.Setting_PC_Number

        If My.Settings.Setting_Banner_Text_Enabler Then
            banner.Text = My.Settings.Setting_Banner_Text
            banner.Visible = True
        Else
            banner.Visible = False
        End If
        Me.ShowInTaskbar = False
    End Sub

    Private Sub loginCancelBtn_Click_1(sender As Object, e As EventArgs) Handles loginCancelBtn.Click
        btn_insert_coin.Visible = True
        loginGroupBox.Visible = False
        coinInsertGroupBox.Visible = True
        timerGroupBox.Visible = False
    End Sub



    Private Sub pinOne_TextChanged_1(sender As Object, e As EventArgs)
        If pinOne.Text.Length >= pinOne.MaxLength Then
            pinTwo.Focus()
        End If
    End Sub

    Private Sub pinTwo_TextChanged_1(sender As Object, e As EventArgs)
        If pinTwo.Text.Length >= pinTwo.MaxLength Then
            pinThree.Focus()
        End If
    End Sub

    Private Sub pinThree_TextChanged_1(sender As Object, e As EventArgs)
        If pinThree.Text.Length >= pinThree.MaxLength Then
            pinFour.Focus()
        End If
    End Sub

    Private Sub pinFour_TextChanged_1(sender As Object, e As EventArgs)
        If pinFour.Text.Length >= pinFour.MaxLength Then
            pinFive.Focus()
        End If
    End Sub

    Private Sub pinFive_TextChanged_1(sender As Object, e As EventArgs)
        If pinFive.Text.Length >= pinFive.MaxLength Then
            pinSix.Focus()
        End If
    End Sub

    Private Sub pinSix_TextChanged_1(sender As Object, e As EventArgs)

        If pinSix.Text.Length >= pinSix.MaxLength Then
            pinLoginBtn.Focus()
        End If
    End Sub

    Private Sub Login_KeyDown_1(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.Control AndAlso e.Alt AndAlso (e.KeyCode = Keys.P)) Then
            If TotalTime > 0 Then
                Dim res As Integer = MsgBox("Logging in will sign you out. Remaining time will not be save. Do you want to continue?", vbQuestion + vbYesNo, "Login now?")
                If res = vbYes Then
                    LoginAdminMode()
                End If
            Else
                LoginAdminMode()
            End If
        End If
    End Sub

    Private Sub pinSix_KeyDown_1(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Back Then
            pinFive.Focus()
        End If
    End Sub

    Private Sub pinFive_KeyDown_1(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Back Then
            pinFour.Focus()
        End If
    End Sub

    Private Sub pinFour_KeyDown_1(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Back Then
            pinThree.Focus()
        End If
    End Sub

    Private Sub pinThree_KeyDown_1(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Back Then
            pinTwo.Focus()
        End If
    End Sub

    Private Sub pinTwo_KeyDown_1(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Back Then
            pinOne.Focus()
        End If
    End Sub

    Private Sub btn_insert_coin_Click_1(sender As Object, e As EventArgs) Handles btn_insert_coin.Click

        If btn_insert_coin.Text = "Insert coin" Then
            total_inserted_coin.Text = 0

            If InserCoinMode() Then
                coinInsertGroupBox.Visible = True
                timerGroupBox.Visible = False
                OfflineNotification.Visible = False
                btn_insert_coin.Text = "Done paying"
                insert_coin_display.Text = "Waiting for coins"
                total_inserted_coin.Visible = True
                inserted_display.Visible = True
                coin_waiter.Enabled = True

                insertcoinWaiter.Visible = True
                insertcoinWaiter.Value = 100
                SetUp_Page.CheckArduinoConnection.Enabled = False


            Else ' nag insert coin pero offline ang board ng coinslot
                If TotalTime > 0 Then ' may oras pa na natitira
                    MsgBox("The Coinslot is offline.", vbExclamation, "Offline")
                Else
                    OfflineMode()
                End If

            End If
        Else
            If getInsertedCoin() Then ' isesend ni board ang total amount, then irereset ang totalAmount sa Board

                If isCoinInserted() Then

                    If TotalTime > 0 Then ' meaning naka timermode, nag add lang ng coins na hinulog
                        TotalTime = TotalTime + TempTime 'TempTime ay galing ay isCoinInserted 

                        TimerMode()

                    Else
                        If TempTime > 0 Then ' meaning unang hulog.. nakastandbymode lang talaga
                            TotalTime = TempTime

                            TimerMode()
                        Else
                            StandbyMode()
                        End If
                    End If
                Else ' nag insert coin pero walang hinulog
                    If TotalTime > 0 Then ' pero may remaining time pa
                        TimerMode()
                    Else
                        StandbyMode()
                    End If

                End If
            Else
                If TotalTime > 0 Then ' nag click ng insert coin, pumasok sa waiting pero bigla nag offline ang coinslot
                    TimerMode()
                Else
                    If data > 0 Then
                        MsgBox("Pakitawag ang Bantay!", vbExclamation, "Offline Coinslot")
                    Else
                        StandbyMode() ' nagclick ng insert coin, pero wala pang nahulog na coins
                    End If

                End If
                OfflineMode()
            End If
        End If
    End Sub

    Private Sub LogoutlinkBtn_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LogoutlinkBtn.LinkClicked
        Dim res As Integer = MsgBox("Remaining time will not be save. Do you want to continue?", vbYesNo + vbQuestion, "Logout now?")
        If res = vbYes Then
            TotalTime = 0
            data = 0
            StandbyMode()

        Else
        End If
    End Sub



    Private Sub pinLoginBtn_Click(sender As Object, e As EventArgs) Handles pinLoginBtn.Click
        If (isTextBoxNull(pinOne) + isTextBoxNull(pinTwo) + isTextBoxNull(pinThree) + isTextBoxNull(pinFour) + isTextBoxNull(pinFive) + isTextBoxNull(pinSix) = 0) Then
            Dim passPin As String = pinOne.Text & pinTwo.Text & pinThree.Text & pinFour.Text & pinFive.Text & pinSix.Text

            If passPin = My.Settings.Access Then
                loginGroupBox.Visible = False
                coinInsertGroupBox.Visible = True
                    btn_insert_coin.Visible = True
                    timerGroupBox.Visible = False
                    SetUp_Page.Visible = True
                    Me.Visible = False
                Else
                    resetTextBoxToNullError(pinOne)
                    resetTextBoxToNullError(pinTwo)
                    resetTextBoxToNullError(pinThree)
                    resetTextBoxToNullError(pinFour)
                    resetTextBoxToNullError(pinFive)
                    resetTextBoxToNullError(pinSix)
                End If
            End If
    End Sub

    Private Sub Login_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
    End Sub

    Private Sub pinOne_KeyUp(sender As Object, e As KeyEventArgs) Handles pinOne.KeyUp
        If pinOne.Text = "" Then
        Else
            pinTwo.Select()
        End If
    End Sub

    Private Sub pinTwo_KeyUp(sender As Object, e As KeyEventArgs) Handles pinTwo.KeyUp
        If pinTwo.Text = "" Then
        Else
            pinThree.Select()
        End If
    End Sub

    Private Sub pinThree_KeyUp(sender As Object, e As KeyEventArgs) Handles pinThree.KeyUp
        If pinThree.Text = "" Then
        Else
            pinFour.Select()
        End If
    End Sub

    Private Sub pinFour_KeyUp(sender As Object, e As KeyEventArgs) Handles pinFour.KeyUp
        If pinFour.Text = "" Then
        Else
            pinFive.Select()
        End If
    End Sub

    Private Sub pinFive_KeyUp(sender As Object, e As KeyEventArgs) Handles pinFive.KeyUp
        If pinFive.Text = "" Then
        Else
            pinSix.Select()
        End If
    End Sub

    Private Sub pinSix_KeyUp(sender As Object, e As KeyEventArgs) Handles pinSix.KeyUp
        If pinSix.Text = "" Then
        Else
            pinLoginBtn.Select()
        End If
    End Sub


End Class