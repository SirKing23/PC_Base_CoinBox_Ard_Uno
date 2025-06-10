Imports System.IO.Ports
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Module Arduino_Connection_Module
    Public mySerialPort As New SerialPort()
    Public mySerialPortConnectionStatus As Boolean
    Public mySerialPortReceivedData As String

    Public data As Integer
    Public Function ArduinoConnector(ByVal StatusContainer As Label)
        mySerialPort.PortName = My.Settings.RegisteredPort
        mySerialPort.BaudRate = 9600
        Try

            ' Set up the Serial port during Run time
            mySerialPort.Close()
            mySerialPort.Parity = Parity.None
            mySerialPort.DataBits = 8
            mySerialPort.StopBits = StopBits.One

            ' Set up the data received 
            AddHandler mySerialPort.DataReceived, AddressOf DataReceivedHandler

            mySerialPort.Open()
            Login.OfflineNotification.Visible = False
            StatusContainer.Text = "Connected"
            mySerialPortConnectionStatus = True
            StatusContainer.ForeColor = Color.Green




        Catch ex As Exception
            StatusContainer.Text = "Connecting"
            Login.OfflineNotification.Visible = True
            mySerialPortConnectionStatus = False
            StatusContainer.ForeColor = Color.Red
        End Try
    End Function



    Public Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs)
        Try
            Dim sp As SerialPort = CType(sender, SerialPort)
            data = sp.ReadLine()

            'If data < 0 Then ' meaning nagsend si arduino ng -1, napindot ang physical button na insert coin
            '    Login.btn_insert_coin.PerformClick()
            'End If
        Catch ex As Exception

        End Try


    End Sub


    Public Function ArduinoSendData(ByVal Data As String) As Boolean
        Try
            If mySerialPortConnectionStatus = True Then
                mySerialPort.Write(Data)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try


    End Function


    Public Function SetCoinslotClose(ByVal SerialPortName As System.IO.Ports.SerialPort)
        Try
            SerialPortName.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Function

    Public Function CheckAvailablePortName(ByVal ListOfPortReturnVal As System.Windows.Forms.ComboBox)
        ' Clear the existing items first
        ListOfPortReturnVal.Items.Clear()

        ' Add available serial ports
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ListOfPortReturnVal.Items.Add(sp)
        Next
    End Function


    Public Function SetCoinslotPort(ByVal SerialPortName As System.IO.Ports.SerialPort, ByVal PortName As String)
        Try
            SerialPortName.Close()
            SerialPortName.PortName = PortName
            SerialPortName.BaudRate = 9600
            SerialPortName.DataBits = 8
            SerialPortName.Parity = Parity.None
            SerialPortName.StopBits = StopBits.One
            SerialPortName.Handshake = Handshake.None
            SerialPortName.Encoding = System.Text.Encoding.Default
            SerialPortName.Open()
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Module
