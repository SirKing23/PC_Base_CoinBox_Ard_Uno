Module Module_Cashier
    Public actualReceivedCoin As Integer
    Public toNormalize As Integer ' holds the total inserted Coin from data in Arduino Data received handler
    Dim actualData As Integer

    Public Function normalizedData(ByVal myData As Integer) As Integer ' change the actual data


        toNormalize = myData - actualReceivedCoin

        Select Case toNormalize
            Case 1
                actualData = 1
            Case Is < 5
                If myData > 1 Then
                    actualData = 5
                End If
            Case 5
                actualData = 5
            Case Is > 5
                If myData < 10 Then
                    actualData = 10
                End If
            Case 10
                actualData = 10
        End Select
        actualReceivedCoin = actualReceivedCoin + actualData

        sortReceivedCoins(actualData)
        ' myData = (myData - toNormalize) + actualData ' set the data from datareceived in arduino the corrected amount from coinslot
        '  toNormalize = myData
        Return actualReceivedCoin
    End Function


    Public Function sortReceivedCoins(ByVal coinToSort As String)

        Select Case coinToSort
            Case 1
                Dim pisocoin As Integer = My.Settings.Coin_Total_One
                pisocoin = pisocoin + 1
                My.Settings.Coin_Total_One = pisocoin
            Case 5
                Dim limacoin As Integer = My.Settings.Coin_Total_Five
                limacoin = limacoin + 1
                My.Settings.Coin_Total_Five = limacoin
            Case 10
                Dim sampucoin As Integer = My.Settings.Coin_Total_Ten
                sampucoin = sampucoin + 1
                My.Settings.Coin_Total_Ten = sampucoin
        End Select

        My.Settings.Save()

    End Function
End Module
