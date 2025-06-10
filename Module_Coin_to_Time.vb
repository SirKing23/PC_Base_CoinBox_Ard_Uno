Module Module_Coin_to_Time
    Public Function Convert_CoinInput_To_Time(ByRef Coin_Input As Integer) As Integer
        Dim ConvertedCoin As Integer = 0
        Dim index As Integer = 0


        'Get the Number of Rates in My.Settings
        Dim NumberOfRates As Integer = My.Settings.Settings_Number_of_rates

        'Split the Data as string   
        Dim Rate() As String = My.Settings.Settings_Rates.Split(","c)
        Dim RateValue() As String = My.Settings.Settings_Rates_Value.Split(","c)

        'sort the rate - sort them b'coz it might not be sorted during saving :)
        If isRate_Sorted(Rate, RateValue) Then

            While index < NumberOfRates
                'convert string from single array to integer
                Dim price As Integer = Convert_to_Integer(Rate(index))
                Dim EquivalentTime As Integer = Convert_to_Integer(RateValue(index))

                'actual deduction from coin input vs. rate
                'actual addition of deducted coin to time
                While Coin_Input >= price
                    Coin_Input = Coin_Input - price
                    ConvertedCoin = ConvertedCoin + EquivalentTime
                End While

                index = index + 1

            End While
            Return ConvertedCoin
        Else
            MsgBox("There is an error in converting the coins to time value", vbExclamation + vbOKOnly, "Coin to time module error")
        End If


    End Function

    Public Function Convert_to_Integer(ByVal String_to_convert As String)
        Dim result As Integer
        Int32.TryParse(String_to_convert, result)
        Return result
    End Function

    Public Function Convert_to_hour_and_minutes(ByVal minutes_to_convert As Integer) As String

        Dim Converted_hour As Integer
        While minutes_to_convert >= 60
            minutes_to_convert = minutes_to_convert - 60
            Converted_hour = Converted_hour + 1
        End While

        Return (Converted_hour & " hour : " & minutes_to_convert & " minutes")

    End Function

    Public Function isRate_Sorted(ByRef arrayRate As String(), ByRef arrayRateValue As String()) As Boolean
        Try
            ' Zip the two arrays into a sequence of tuples
            Dim zippedArrays = arrayRate.Zip(arrayRateValue, Function(a, b) New With {a, b})

            ' Convert rates to integers for sorting
            Dim zippedArraysNumeric = zippedArrays.Select(Function(x) New With {.Rate = CInt(x.a), .RateValue = x.b})

            ' Sort the zipped sequence by the rates
            Dim sortedZippedArrays = zippedArraysNumeric.OrderByDescending(Function(x) x.Rate)

            ' Unzip the sorted sequence back into separate arrays
            arrayRate = sortedZippedArrays.Select(Function(x) x.Rate.ToString()).ToArray()
            arrayRateValue = sortedZippedArrays.Select(Function(x) x.RateValue).ToArray()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function



    Public Function ClientTimer(ByVal InputtotalTime As Integer, ByVal displayHour As Label,
                              ByVal displayMin As Label, ByVal displaySec As Label) As Integer
        Dim timeHour As Integer = 0
        Dim timeMin As Integer = 0
        Static timeSec As Integer
        Dim timeTotal As Integer = 0
        timeHour = 0
        timeTotal = InputtotalTime

        If timeTotal > 59 Then
            While timeTotal >= 60
                timeTotal = timeTotal - 60
                timeHour = timeHour + 1

            End While
        End If


        timeMin = timeTotal


        If timeSec = 0 Then
            If timeMin = 0 Then
                If timeHour = 0 Then

                    Return 0 ' Times Up!!!

                Else
                    timeHour = timeHour - 1
                    InputtotalTime = InputtotalTime - 1
                    timeMin = 59
                    timeSec = 59
                End If
            Else
                timeMin = timeMin - 1
                InputtotalTime = InputtotalTime - 1
                timeSec = 59

            End If

        Else
            timeSec = timeSec - 1
        End If

        If timeSec < 10 Then
            displaySec.Text = "0" & timeSec
        Else
            displaySec.Text = timeSec
        End If

        If timeMin < 10 Then
            displayMin.Text = "0" & timeMin
        Else
            displayMin.Text = timeMin
        End If
        If timeHour < 10 Then
            displayHour.Text = "0" & timeHour
        Else
            displayHour.Text = timeHour
        End If
        Return InputtotalTime
    End Function
End Module
