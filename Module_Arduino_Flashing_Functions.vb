Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports ArduinoUploader
Imports NLog

Module Module_Arduino_Flashing_Functions
    Public AModel As ArduinoUploader.Hardware.ArduinoModel
    Public DownloadProgress As Integer
    Public ReflashedDone As Boolean = False
    Public HexFilePath As String = Directory.GetCurrentDirectory & "\references\Working_sketch.ino.hex"

    Public Function UploadSketch(ByVal BoardType As String, ByVal PortName As String)
        Select Case BoardType
            Case "Arduino Mega 2560"
                AModel = ArduinoUploader.Hardware.ArduinoModel.Mega2560
            Case "Arduino Nano R3"
                AModel = ArduinoUploader.Hardware.ArduinoModel.NanoR3
            Case "Arduino Uno R3"
                AModel = ArduinoUploader.Hardware.ArduinoModel.UnoR3
        End Select

        Dim uploader As New ArduinoUploader.ArduinoSketchUploader(New ArduinoUploader.ArduinoSketchUploaderOptions() With {
                                                                   .FileName = HexFilePath,
                                                                .PortName = PortName,
                                                                .ArduinoModel = AModel
                                                                })

        Try
            uploader.UploadSketch()
            'para alam kung natapos ba or hindi
            ReflashedDone = True
        Catch ex As Exception
            SetUp_Page.SketchUploader.CancelAsync()
            MsgBox(ex.Message)
            ReflashedDone = False

        End Try

    End Function
    Public Function CheckFileExist() As Boolean

        If System.IO.File.Exists(HexFilePath) Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
