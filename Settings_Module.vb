Imports System.IO
Imports System.Text

Module Settings_Module
    Public Function CoinslotSettingsLoad()
        With SetUp_Page
            'for insert coin button 
            If My.Settings.Setting_InsertCoinButton = True Then
                .insertcoinenabler.Checked = True
                .insert_coin_waiting_time.Text = My.Settings.Setting_InsertCoin_Waiting_time
            Else
                .insertcoinenabler.Checked = False
                .insert_coin_waiting_time.Enabled = False
            End If


            .registeredPortName.Text = My.Settings.RegisteredPort
        End With




    End Function

    Public Function CoinslotSettingsSave()
        With SetUp_Page
            If .insertcoinenabler.Checked = True Then
                If .insert_coin_waiting_time.Text = "" Then
                    .insert_coin_waiting_time.BackColor = Color.Pink
                Else
                    Dim CoinWait As Integer = .insert_coin_waiting_time.Text
                    If CoinWait < 1 Then
                        .insert_coin_waiting_time.BackColor = Color.Pink
                        MsgBox("Coin waiting time cannot be zero (0).", vbCritical, "CoinBoX3")
                    Else
                        .insert_coin_waiting_time.BackColor = Color.White
                        My.Settings.Setting_InsertCoinButton = True
                        My.Settings.Setting_InsertCoin_Waiting_time = .insert_coin_waiting_time.Text
                        My.Settings.Save()
                        MsgBox("Coinslot Settings save", vbInformation, "CoinBoX3")
                    End If

                End If
            Else
                .insert_coin_waiting_time.BackColor = Color.White
                My.Settings.Setting_InsertCoinButton = False
                My.Settings.Save()
                MsgBox("Coinslot Settings save", vbInformation, "CoinBoX3")
            End If
        End With

    End Function


    Public Function SystemSettingsLoad()
        With SetUp_Page
            'For System =============================================================> TAB
            'For start up
            If My.Settings.RunAtStartUp = True Then
                .startupCheck.Checked = True
            Else
                .startupCheck.Checked = False
            End If

            'For Task manager
            If My.Settings.DisableTaskMngr = True Then

                .DisableTaskManager.Checked = True
            Else

                .DisableTaskManager.Checked = False

            End If

            'For Auto shutdown
            If My.Settings.AutoShutdown = True Then
                .AutoShutdown.Checked = True
                .AutoShutdownTime.Text = My.Settings.AutoShutdownTime
                .AutoShutdownTime.Enabled = True
            Else
                .AutoShutdown.Checked = False
                .AutoShutdownTime.Text = My.Settings.AutoShutdownTime
                .AutoShutdownTime.Enabled = False
            End If


            'For Warning time
            If My.Settings.TimesUpReminder = True Then
                .TimesupReminder.Checked = True
                .warningTime.Text = My.Settings.TimesUpWarningTime
                .warningTime.Enabled = True
            Else
                .TimesupReminder.Checked = False
                .warningTime.Text = My.Settings.TimesUpWarningTime
                .warningTime.Enabled = False
            End If

            'For Terminator
            If My.Settings.Terminator = True Then
                .terminatorenabler.Checked = True
                .terminatorExempter.Enabled = True
            Else
                .terminatorenabler.Checked = False
                .terminatorExempter.Enabled = False
            End If
            If My.Settings.TerminatorExempt = True Then
                .terminatorExempter.Checked = True
            Else
                .terminatorExempter.Checked = False
            End If


            'For Access Tab =============================================================> TAB
            .pcNameTxt.Text = My.Settings.Setting_PC_Name
            .pcNumberTxt.Text = My.Settings.Setting_PC_Number



            'For Banner =============================================================> TAB
            .bannertxtfilepath.Text = My.Settings.Setting_Banner_Path
            .bannertextenabler.Checked = My.Settings.Setting_Banner_Text_Enabler
            .bannertxt.Text = My.Settings.Setting_Banner_Text
            .bannerTxtPreview.Visible = My.Settings.Setting_Banner_Text_Enabler
            .bannerTxtPreview.Text = .bannertxt.Text
            .bannertxt.Enabled = My.Settings.Setting_Banner_Text_Enabler

            Try
                .bannerpreview.Image = Image.FromFile(My.Settings.Setting_Banner_Path)
            Catch ex As Exception
                .bannerpreview.Image = Nothing ' image path file is invalid
            End Try




        End With







    End Function
    Public Function SystemSettingsSave()

        With SetUp_Page

            If RunOnStartUp(.startupCheck.Checked) Then
                If .startupCheck.Checked = True Then
                    My.Settings.RunAtStartUp = True
                Else
                    My.Settings.RunAtStartUp = False
                End If
            Else
                MsgBox("Access denied! Please run the system as Administrator.", vbCritical, "Run at Startup")
                Exit Function
            End If


            If DisableTaskManager(.DisableTaskManager.Checked) Then
                If .DisableTaskManager.Checked = False Then
                    My.Settings.DisableTaskMngr = False
                Else
                    My.Settings.DisableTaskMngr = True
                End If
            Else

                MsgBox("Access denied! Please run the system as Administrator.", vbCritical, "Disable Task manager")
                Exit Function
            End If


            .AutoShutdownTime.BackColor = Color.White
            If .AutoShutdown.Checked = True Then

                If .AutoShutdownTime.Text = "" Then
                    .AutoShutdownTime.BackColor = Color.Pink
                    MsgBox("Please set the autoshutdown time.", vbCritical, "Auto shutdown")
                    Exit Function
                Else
                    Dim ShtTime As Integer = .AutoShutdownTime.Text
                    If ShtTime = 0 Then
                        .AutoShutdownTime.BackColor = Color.Pink
                        MsgBox("Autoshutdown time cannot be zero (0).", vbCritical, "Auto shutdown")
                        Exit Function
                    Else
                        .AutoShutdownTime.BackColor = Color.White
                        My.Settings.AutoShutdown = True
                        My.Settings.AutoShutdownTime = ShtTime
                    End If

                End If

            Else
                .AutoShutdownTime.BackColor = Color.White
                My.Settings.AutoShutdown = False
            End If



            .warningTime.BackColor = Color.White
            If .TimesupReminder.Checked = True Then

                If .warningTime.Text = "" Then
                    .warningTime.BackColor = Color.Pink
                    MsgBox("Please set the warning time.", vbCritical, "Warning time")
                    Exit Function
                Else
                    Dim WrnTime As Integer = .warningTime.Text
                    If WrnTime = 0 Then
                        .warningTime.BackColor = Color.Pink
                        MsgBox("Warning time cannot be zero (0).", vbCritical, "Warning time")
                        Exit Function
                    Else
                        .warningTime.BackColor = Color.White
                        My.Settings.TimesUpReminder = True
                        My.Settings.TimesUpWarningTime = WrnTime
                    End If
                End If
            Else
                .warningTime.BackColor = Color.White
                My.Settings.TimesUpReminder = False
            End If


            If .terminatorenabler.Checked = True Then
                My.Settings.Terminator = True
                .terminatorExempter.Enabled = True
            Else
                My.Settings.Terminator = False
                .terminatorExempter.Enabled = False
            End If

            If .terminatorExempter.Checked = True Then
                My.Settings.TerminatorExempt = True
            Else
                My.Settings.TerminatorExempt = False
            End If



            'Actual saving 
            My.Settings.Save()
            MsgBox("Settings saved successfully", vbOKOnly + vbInformation, "CoinBoX3")

        End With




    End Function


    Public Function DisplaySales(ByVal viewSales As Boolean)
        'Get the Coins
        Dim regTotalOneCoin As Integer = My.Settings.Coin_Total_One
        Dim regTotalFiveCoin As Integer = My.Settings.Coin_Total_Five
        Dim regTotalTenCoin As Integer = My.Settings.Coin_Total_Ten

        'Compute the SubTotal of each coins
        Dim subregTotalOneCoin As Integer = regTotalOneCoin * 1
        Dim subregTotalFiveCoin As Integer = regTotalFiveCoin * 5
        Dim subregTotalTenCoin As Integer = regTotalTenCoin * 10

        If viewSales Then
            With SetUp_Page
                .TotalOneCoin.Text = regTotalOneCoin
                .TotalFiveCoin.Text = regTotalFiveCoin
                .TotalTenCoin.Text = regTotalTenCoin
                .totalCoins.Text = regTotalOneCoin + regTotalFiveCoin + regTotalTenCoin
                .SubTotalOneCoin.Text = subregTotalOneCoin
                .SubTotalFiveCoin.Text = subregTotalFiveCoin
                .SubTotalTenCoin.Text = subregTotalTenCoin
                .GrandTotal.Text = subregTotalOneCoin + subregTotalFiveCoin + subregTotalTenCoin
            End With

        Else
            With SetUp_Page
                .TotalOneCoin.Text = "-"
                .TotalFiveCoin.Text = "-"
                .TotalTenCoin.Text = "-"
                .totalCoins.Text = "-"
                .SubTotalOneCoin.Text = "-"
                .SubTotalFiveCoin.Text = "-"
                .SubTotalTenCoin.Text = "-"
                .GrandTotal.Text = "-"
            End With

        End If



    End Function

    Public Function ResetSales() As Boolean
        Try
            My.Settings.Coin_Total_One = 0
            My.Settings.Coin_Total_Five = 0
            My.Settings.Coin_Total_Ten = 0
            My.Settings.Save()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function RatesLoad(ByVal datagrid As DataGridView)
        datagrid.ColumnCount = 5
        datagrid.Columns(0).Name = "No"
        datagrid.Columns(1).Name = "Name"
        datagrid.Columns(2).Name = "Rate"
        datagrid.Columns(3).Name = "Minutes"
        datagrid.Columns(4).Name = "Note"


        'My.Settings.Settings_Number_of_rates = 0
        'My.Settings.Settings_Rates_Name = ""
        'My.Settings.Settings_Rates = ""
        'My.Settings.Settings_Rates_Value = ""
        'My.Settings.Setting_Rates_Note = ""
        'My.Settings.Save()



        Dim numberOfRows As Integer = My.Settings.Settings_Number_of_rates
        Dim i As Integer = 0

        'Split the name
        Dim regRatesName As String = My.Settings.Settings_Rates_Name
        Dim splittedArrayName As String() = regRatesName.Split(","c)



        'Split the rates
        Dim regRates As String = My.Settings.Settings_Rates
        Dim splittedArrayRates As String() = regRates.Split(","c)



        'Split the value
        Dim regRatesValue As String = My.Settings.Settings_Rates_Value
        Dim splittedArrayValue As String() = regRatesValue.Split(","c)




        'Split the note
        Dim regRatesNote As String = My.Settings.Setting_Rates_Note
        Dim splittedArrayNote As String() = regRatesNote.Split(","c)



        'Add the items to datagridview
        While i < numberOfRows
            datagrid.Rows.Add(i + 1, splittedArrayName(i).ToString(), splittedArrayRates(i).ToString(), splittedArrayValue(i).ToString(), splittedArrayNote(i).ToString())
            i = i + 1
        End While
        i = 0
    End Function


    Public Function AddNewRate(ByVal newRateName As String, ByVal newRateRate As String, ByVal newRateValue As String, ByVal newRateNote As String) As Boolean
        Try
            If My.Settings.Settings_Number_of_rates = 0 Then ' unang rate na ilalagay kaya dapat walang comman
                Dim regNumberOfRates As Integer = My.Settings.Settings_Number_of_rates


                My.Settings.Settings_Number_of_rates = regNumberOfRates + 1
                My.Settings.Settings_Rates_Name = newRateName
                My.Settings.Settings_Rates = newRateRate
                My.Settings.Settings_Rates_Value = newRateValue
                My.Settings.Setting_Rates_Note = newRateNote

                My.Settings.Save()

                Return True
            Else
                Dim regNumberOfRates As Integer = My.Settings.Settings_Number_of_rates
                Dim regName As String = My.Settings.Settings_Rates_Name
                Dim regRates As String = My.Settings.Settings_Rates
                Dim regRateValue As String = My.Settings.Settings_Rates_Value
                Dim regNotes As String = My.Settings.Setting_Rates_Note

                My.Settings.Settings_Number_of_rates = regNumberOfRates + 1
                My.Settings.Settings_Rates_Name = regName & "," & newRateName
                My.Settings.Settings_Rates = regRates & "," & newRateRate
                My.Settings.Settings_Rates_Value = regRateValue & "," & newRateValue
                My.Settings.Setting_Rates_Note = regNotes & "," & newRateNote

                My.Settings.Save()

                Return True
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function SearchInRates(ByVal valueToSearch As String, ByVal whereToSearch As Integer) As String ' whereToSearch : 1 - return name of rate, 2 return value of rate, 3 return note of rate
        Dim i As Integer = 0

        'Split the name
        Dim regRatesName As String = My.Settings.Settings_Rates_Name
        Dim splittedArrayName As String() = regRatesName.Split(","c)

        'Split the rates
        Dim regRates As String = My.Settings.Settings_Rates
        Dim splittedArrayRates As String() = regRates.Split(","c)


        'Split the value
        Dim regRatesValue As String = My.Settings.Settings_Rates_Value
        Dim splittedArrayValue As String() = regRatesValue.Split(","c)


        'Split the note
        Dim regRatesNote As String = My.Settings.Setting_Rates_Note
        Dim splittedArrayNote As String() = regRatesNote.Split(","c)



        Dim whereToSearchArray As String()

        Select Case whereToSearch
            Case 1
                whereToSearchArray = splittedArrayName
            Case 2
                whereToSearchArray = splittedArrayValue
            Case 3
                whereToSearchArray = splittedArrayNote
            Case Else


        End Select

        For Each rateItem As String In splittedArrayRates
            If rateItem = valueToSearch Then
                Return whereToSearchArray(i)
            End If
            i += 1
        Next
        Return 0 ' Value not found in the array - Rate Price not yet registered
    End Function

    Public Function GetColumnValueInDataGrid(ByVal datagrid As DataGridView, ByVal columnIndex As Integer) As String ' returns the concatenated value of the column
        Dim columnValues As New StringBuilder()

        ' Iterate through the rows of the DataGridView
        For Each row As DataGridViewRow In datagrid.Rows
            ' Check if the row is not the NewRow
            If Not row.IsNewRow Then
                ' Get the value of the cell in the specified column
                Dim cellValue As String = row.Cells(columnIndex).Value.ToString()
                ' Append the cell value to the StringBuilder with a comma
                columnValues.Append(cellValue).Append(",")
            End If
        Next

        ' Remove the trailing comma if there are values
        If columnValues.Length > 0 Then
            columnValues.Remove(columnValues.Length - 1, 1)
        End If

        ' Return the concatenated string
        Return columnValues.ToString()
    End Function

    Public Function SaveRatesFromDataGrid(ByVal datagrid As DataGridView) As Boolean
        Try
            If ResetAllSavedRates(datagrid) Then
                My.Settings.Settings_Number_of_rates = datagrid.Rows.Count() - 1
                My.Settings.Settings_Rates_Name = GetColumnValueInDataGrid(datagrid, 1)
                My.Settings.Settings_Rates = GetColumnValueInDataGrid(datagrid, 2)
                My.Settings.Settings_Rates_Value = GetColumnValueInDataGrid(datagrid, 3)
                My.Settings.Setting_Rates_Note = GetColumnValueInDataGrid(datagrid, 4)
                My.Settings.Save()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function ResetAllSavedRates(ByVal datagrid As DataGridView) As Boolean
        Try
            My.Settings.Settings_Number_of_rates = 0
            My.Settings.Settings_Rates_Name = ""
            My.Settings.Settings_Rates = ""
            My.Settings.Settings_Rates_Value = ""
            My.Settings.Setting_Rates_Note = ""
            My.Settings.Save()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function


End Module
