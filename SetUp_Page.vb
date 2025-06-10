Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SetUp_Page
    Private Sub SetUp_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If CheckSettings() Then
            'pag false ang replay ng method meaning walang laman ang system settings kaya ang lalabas ay ung setup page
            SystemSettingsLoad()
            RatesLoad(RatesDataGridView)
            RunShield(True) 'true ang irurun ay si CoinShield as terminator
            totalNumbOfRates.Text = "Available rates : " & My.Settings.Settings_Number_of_rates
            If ArduinoSendData("F") Then
            Else
                Login.OfflineNotification.Visible = True
            End If
            'To un arm disable the code below
            Login.Show()
            Me.Visible = False
            Me.ShowInTaskbar = False


        Else


        End If


    End Sub





    Private Sub CheckArduinoConnection_Tick(sender As Object, e As EventArgs) Handles CheckArduinoConnection.Tick

        If ArduinoStat.Text = "Connected" Then
            If Not mySerialPort.IsOpen Then
                ArduinoStat.Text = "Connecting"
            Else
                ArduinoSendData("0")
            End If

        Else
            ArduinoConnector(ArduinoStat)

        End If

    End Sub



    Private Sub insertcoinenabler_CheckStateChanged(sender As Object, e As EventArgs) Handles insertcoinenabler.CheckStateChanged
        '  If insertcoinenabler.Checked = True Then
        '
        '        My.Settings.Setting_InsertCoinButton = True
        '        insertcoindwaitingtime.Enabled = True
        '        Else
        '
        '        My.Settings.Setting_InsertCoinButton = False
        '        insertcoindwaitingtime.Enabled = False
        '        End If
        '
        '        My.Settings.Save()
    End Sub

    Private Sub Insertcoinenabler_CheckedChanged(sender As Object, e As EventArgs) Handles insertcoinenabler.CheckedChanged
        If insertcoinenabler.Checked = True Then
            insert_coin_waiting_time.Enabled = True
        Else
            insert_coin_waiting_time.Enabled = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If changepassgroup.Visible = False Then
            changepassgroup.Visible = True
            LinkLabel1.Text = "Done"
        Else
            changepassgroup.Visible = False
            LinkLabel1.Text = "Change PIN"
        End If
    End Sub


    Private Sub accountloginbtn_Click(sender As Object, e As EventArgs) Handles accountloginbtn.Click
        usernametxt.BackColor = Color.White
        passwordtxt.BackColor = Color.White
        msg.Text = ""
        If usernametxt.Text = "" Then
            msg.Text = "Please type your Username"
            usernametxt.BackColor = Color.Pink
        Else
            If passwordtxt.Text = "" Then
                msg.Text = "Please type your password"
                passwordtxt.BackColor = Color.Pink
            Else
                usernametxt.BackColor = Color.White
                passwordtxt.BackColor = Color.White
                msg.Text = "Logging in please wait..."
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim res As Integer
        res = MsgBox("Are you sure you want to quit the CoinBox3 system?", vbYesNo + vbQuestion, "Logout now?")
        If res = vbYes Then
            Dim myProcesses = Process.GetProcessesByName("Acs")
            For Each Proc As Process In myProcesses
                Try
                    Proc.Kill()
                Catch ex As Exception
                    ' Handle exception
                End Try
            Next
            End
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_relay_on.Click
        If ArduinoSendData("T") Then

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_relay_off.Click
        If ArduinoSendData("F") Then

        End If

    End Sub

    Private Sub Btn_save_coin_waiter_time_Click(sender As Object, e As EventArgs) Handles btn_save_coin_waiter_time.Click
        CoinslotSettingsSave()
    End Sub

    Private Sub btn_settingssave_Click(sender As Object, e As EventArgs) Handles btn_settingssave.Click
        SystemSettingsSave()
    End Sub

    Private Sub AutoShutdownTime_TextChanged(sender As Object, e As EventArgs) Handles AutoShutdownTime.TextChanged

    End Sub

    Private Sub AutoShutdownTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AutoShutdownTime.KeyPress
        numbersonly(AutoShutdownTime, e)
    End Sub

    Private Sub warningTime_TextChanged(sender As Object, e As EventArgs) Handles warningTime.TextChanged

    End Sub

    Private Sub warningTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles warningTime.KeyPress
        numbersonly(warningTime, e)
    End Sub

    Private Sub terminatorenabler_CheckedChanged(sender As Object, e As EventArgs) Handles terminatorenabler.CheckedChanged
        'If terminatorExempter.Enabled = False Then
        '    terminatorExempter.Enabled = True
        'Else
        '    terminatorExempter.Enabled = False
        'End If
    End Sub

    Private Sub AutoShutdown_CheckedChanged(sender As Object, e As EventArgs) Handles AutoShutdown.CheckedChanged
        If AutoShutdownTime.Enabled = True Then
            AutoShutdownTime.Enabled = False
        Else
            AutoShutdownTime.Enabled = True
        End If
    End Sub

    Private Sub TimesupReminder_CheckedChanged(sender As Object, e As EventArgs) Handles TimesupReminder.CheckedChanged
        If warningTime.Enabled = True Then
            warningTime.Enabled = False
        Else
            warningTime.Enabled = True
        End If
    End Sub

    Private Sub btnSketchUpload_Click(sender As Object, e As EventArgs) Handles btnSketchUpload.Click
        If ReflashBoard.Text = "" Then
            MsgBox("Please select you arduino board first before you proceed.", vbOKOnly, "Reflash board")
        Else
            Dim res As Integer
            res = MsgBox("Before you proceed make sure that you have selected the right mother board for your coinslot." & vbCrLf & vbCrLf & "Selected board : " & ReflashBoard.Text & vbCrLf & vbCrLf & "Port : " & registeredPortName.Text & vbCrLf & vbCrLf & "Do you want to continue?", vbYesNo, "WARNING: Board reflash confirmation")
            If res = vbYes Then
                msgupload.Text = "Preparing..."
                SetCoinslotClose(mySerialPort)
                msgupload.Text = "Port closed..."
                msgupload.Text = "Checking hex file..."
                If CheckFileExist() = True Then
                    msgupload.Text = "Hex file exist..."
                Else
                    msgupload.Text = "Hex file could not be located"
                    Exit Sub
                End If

                msgupload.Text = "Uploading please wait...."


                If SketchUploader.IsBusy Then
                    SketchUploader.CancelAsync()
                End If
                SketchUploader.RunWorkerAsync()


            End If
        End If

    End Sub

    Private Sub SketchUploader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles SketchUploader.DoWork
        UploadSketch(ReflashBoard.Text, registeredPortName.Text)
    End Sub
    Private Sub SketchUploader_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles SketchUploader.RunWorkerCompleted
        'mula sa sketchuploader na module, ititrigger ito 
        SetCoinslotPort(mySerialPort, registeredPortName.Text)
        msgupload.Text = ""
        If ReflashedDone = False Then
        Else
            MsgBox("Board reflashed successfully", vbInformation, "CoinBox")
        End If



    End Sub
    Private Sub btn_scanport_Click(sender As Object, e As EventArgs) Handles btn_scanport.Click
        CheckAvailablePortName(Port_Name)
    End Sub

    Private Sub btn_selectthisPort_Click(sender As Object, e As EventArgs) Handles btn_selectthisPort.Click
        If Port_Name.Text = "" Then
        Else
            My.Settings.RegisteredPort = Port_Name.Text
            My.Settings.Save()
            registeredPortName.Text = My.Settings.RegisteredPort
            MsgBox("Port :" & Port_Name.Text & " has been selected and saved successfuly", vbInformation, "Port")
        End If
    End Sub



    Private Sub changePnBtn_Click(sender As Object, e As EventArgs) Handles changePnBtn.Click
        If ChangePin(CurrPintxt, NewPinTxt, NewPinConfirmTxt) Then
            CurrPintxt.Text = ""
            NewPinTxt.Text = ""
            NewPinConfirmTxt.Text = ""
            changepassgroup.Visible = False
            LinkLabel1.Text = "Change PIN"

        End If
    End Sub

    Private Sub refreshSalesBtn_Click(sender As Object, e As EventArgs) Handles refreshSalesBtn.Click


        salesAsOf.Text = "Sales as of : " & GetDate()

        If refreshSalesBtn.Text = "View" Then
            DisplaySales(True)
            refreshSalesBtn.Text = "Hide"
            btn_reset_coins.Enabled = True
        Else
            DisplaySales(False)
            refreshSalesBtn.Text = "View"
            btn_reset_coins.Enabled = False
        End If



    End Sub

    Private Sub btn_reset_coins_Click(sender As Object, e As EventArgs) Handles btn_reset_coins.Click
        Dim res As Integer
        res = MsgBox("You are about to reset the coin counter and the sales report. This cannot be undone. Do you want to continue?", vbYesNo + vbQuestion, "Reset Coin Counter")
        If res = vbYes Then
            If ResetSales() Then
                TotalOneCoin.Text = "0"
                TotalFiveCoin.Text = "0"
                TotalTenCoin.Text = "0"
                totalCoins.Text = "0"
                SubTotalOneCoin.Text = "0"
                SubTotalFiveCoin.Text = "0"
                SubTotalTenCoin.Text = "0"
                GrandTotal.Text = "0"
                MsgBox("Coin counter has been reset.", vbInformation, "Reset Success")
            Else
                MsgBox("Cannot reset coin counter and sales.", vbCritical, "Reset Failed")
            End If



        End If
    End Sub



    Private Sub CurrPintxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CurrPintxt.KeyPress
        numbersonly(CurrPintxt, e)
    End Sub



    Private Sub NewPinTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewPinTxt.KeyPress
        numbersonly(NewPinTxt, e)
    End Sub



    Private Sub NewPinConfirmTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewPinConfirmTxt.KeyPress
        numbersonly(NewPinConfirmTxt, e)
    End Sub


    Private Sub pcNumberTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pcNumberTxt.KeyPress
        numbersonly(pcNumberTxt, e)
    End Sub

    Private Sub addRateBtn_Click(sender As Object, e As EventArgs) Handles addRateBtn.Click
        AddRate.Text = "Add new rate"
        AddRate.newRateBtn.Text = "Add"
        AddRate.ShowDialog()
        totalNumbOfRates.Text = "Available rates : " & My.Settings.Settings_Number_of_rates
    End Sub

    Private Sub delRateBtn_Click(sender As Object, e As EventArgs) Handles delRateBtn.Click
        ' Check if any row is selected
        If RatesDataGridView.SelectedRows.Count > 0 Then
            ' Get the index of the selected row
            Dim selectedIndex As Integer = RatesDataGridView.SelectedRows(0).Index
            Dim cellValue As Object = RatesDataGridView.Rows(selectedIndex).Cells(1).Value


            If cellValue = "" Then ' the selected row has no value

            Else
                Dim res As Integer
                res = MsgBox("Deleting " & cellValue & " cannot be undone. Do you want to continue?", vbYesNo + vbQuestion, "Delete Rate")
                If res = vbYes Then
                    ' Remove the selected row from the DataGridView
                    RatesDataGridView.Rows.RemoveAt(selectedIndex)

                    If SaveRatesFromDataGrid(RatesDataGridView) Then
                        RatesDataGridView.Rows.Clear()
                        RatesLoad(RatesDataGridView)
                        MsgBox("Deleted Successfully", vbInformation, "Rate deleted")

                    Else
                        MsgBox("There is a problem in deleting the selected Rate", vbInformation, "Failed")

                    End If
                End If
            End If
        Else
            MsgBox("No rate selected.", vbInformation, "Select rate")
        End If
        totalNumbOfRates.Text = "Available rates : " & My.Settings.Settings_Number_of_rates
    End Sub

    Private Sub editRateBtn_Click(sender As Object, e As EventArgs) Handles editRateBtn.Click

        If RatesDataGridView.SelectedRows.Count > 0 Then
            Dim selectedIndex As Integer = RatesDataGridView.SelectedRows(0).Index
            Dim cellValue As Object = RatesDataGridView.Rows(selectedIndex).Cells(1).Value


            If cellValue = "" Then ' the selected row has no value
            Else
                With AddRate
                    .rateName.Text = RatesDataGridView.Rows(selectedIndex).Cells(1).Value
                    .rateRate.Text = RatesDataGridView.Rows(selectedIndex).Cells(2).Value
                    .rateMinutes.Text = RatesDataGridView.Rows(selectedIndex).Cells(3).Value
                    .rateNotes.Text = RatesDataGridView.Rows(selectedIndex).Cells(4).Value
                End With
                AddRate.newRateBtn.Text = "Edit"
                AddRate.Text = "Edit rate"
                AddRate.ShowDialog()
            End If
        Else
            MsgBox("No row selected.")

        End If




    End Sub

    Private Sub savePCInfoBtn_Click(sender As Object, e As EventArgs) Handles savePCInfoBtn.Click
        If SavePCInfo(pcNameTxt, pcNumberTxt) Then
            MsgBox("PC information saved successfully", vbInformation, "PC Information")
        End If
    End Sub

    Private Sub pcNumberTxt_TextChanged(sender As Object, e As EventArgs) Handles pcNumberTxt.TextChanged

    End Sub

    Private Sub btn_browsebanner_Click(sender As Object, e As EventArgs) Handles btn_browsebanner.Click
        bannertxtfilepath.BackColor = Color.White
        Dim openFileDialog As New OpenFileDialog()

        ' Set filter to only allow image files
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

        ' Set initial directory (optional)
        ' openFileDialog.InitialDirectory = "C:\"

        ' Show the dialog and check if the user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Retrieve the selected file path
            Dim selectedImagePath As String = openFileDialog.FileName

            ' Copy the path to the clipboard
            'Clipboard.SetText(selectedImagePath)

            ' Optionally, display a message to confirm the path is copied
            bannertxtfilepath.Text = selectedImagePath
            bannerpreview.Image = Image.FromFile(selectedImagePath)
        End If
    End Sub

    Private Sub saveBannerSettingsBtn_Click(sender As Object, e As EventArgs) Handles saveBannerSettingsBtn.Click
        If isTextBoxNull(bannertxtfilepath) Then
        Else
            Dim imagePath As String = bannertxtfilepath.Text
            Try
                Dim imageFile As New System.IO.FileInfo(imagePath) ' as of now hindi pa pwede ang website, picture palang
                If imageFile.Exists Then
                    My.Settings.Setting_Banner_Path = bannertxtfilepath.Text
                    My.Settings.Setting_Banner_Text = bannertxt.Text
                    If bannertextenabler.Checked = True Then
                        My.Settings.Setting_Banner_Text_Enabler = True
                    Else
                        My.Settings.Setting_Banner_Text_Enabler = False
                    End If
                    My.Settings.Save()
                    bannerpreview.Image = Image.FromFile(bannertxtfilepath.Text)
                    MsgBox("Banner saved successfully", vbInformation, "Banner")
                Else
                    MsgBox("Invalid image directory!", vbCritical, "File not found")
                End If
            Catch ex As Exception
                MsgBox("Invalid image directory!", vbCritical, "File not found")
            End Try



        End If









    End Sub

    Private Sub bannertextenabler_CheckedChanged(sender As Object, e As EventArgs) Handles bannertextenabler.CheckedChanged
        If bannertextenabler.Checked = True Then
            bannertxt.Enabled = True
            bannerTxtPreview.Visible = True
        Else
            bannertxt.Enabled = False
            bannerTxtPreview.Visible = False
        End If
    End Sub





    Private Sub bannertxt_KeyUp(sender As Object, e As KeyEventArgs) Handles bannertxt.KeyUp
        bannerTxtPreview.Text = bannertxt.Text
    End Sub

    Private Sub clientModeBtn_Click(sender As Object, e As EventArgs) Handles clientModeBtn.Click
        With Login
            .pinOne.Clear()
            .pinTwo.Clear()
            .pinThree.Clear()
            .pinFour.Clear()
            .pinFive.Clear()
            .pinSix.Clear()
            .Show()
        End With
        Dim bgUri As New Uri(My.Settings.Setting_Banner_Path)
        Login.bg.Url = bgUri
        Me.Visible = False
        Me.ShowInTaskbar = False


    End Sub

    Private Sub checkACS_Tick(sender As Object, e As EventArgs) Handles checkACS.Tick
        RunShield(False) ' false meaning ang irurun ay si ACS
    End Sub
End Class
