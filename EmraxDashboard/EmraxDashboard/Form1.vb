Imports System.IO.Ports

Public Class Form1
    Private WithEvents serialPort As New SerialPort()
    Private Const ChartLimit As Integer = 30

    Private outValue As Double ' Variable to store the extracted temperature value
    Private outPosition As Integer ' Variable to store the extracted position value
    Private temperatureTimestamps As New List(Of DateTime)()
    Private temperatureCounter As Integer = 0
    Private positionCounter As Integer = 0 ' New counter for position
    Private simpositionCounter As Integer = 0 ' New counter for position




    Private simulationTimer As New Timer()



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComPorts()
        simulationTimer.Interval = 10 ' Set the interval to 100 milliseconds
        AddHandler simulationTimer.Tick, AddressOf SimulationTimer_Tick
    End Sub

    Private Sub PopulateComPorts()
        ComboBoxPort.Items.Clear()

        Try
            ' Get an array of available COM port names
            Dim portNames As String() = SerialPort.GetPortNames()

            ' Check if there are available ports
            If portNames.Length > 0 Then
                ' Add the port names to the ComboBox
                ComboBoxPort.Items.AddRange(portNames)

                ' Optionally, set the default selected item
                ComboBoxPort.SelectedIndex = 0
            Else
                ' No ports available
                ComboBoxPort.Items.Add("No COM ports found")
            End If
        Catch ex As Exception
            ' Handle exceptions and display the error message
            ComboBoxPort.Items.Add($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click
        ConnectionPanel.Focus()

        ' Create a copy of the current items in the ComboBox
        Dim existingItems As New List(Of Object)(ComboBoxPort.Items.Cast(Of Object)())

        ' Clear the ComboBoxPort to avoid the "Collection was modified" error
        ComboBoxPort.Items.Clear()

        ' Get the current COM ports
        Dim myPort As Array = IO.Ports.SerialPort.GetPortNames()

        ' Add the COM ports to the ComboBox
        ComboBoxPort.Items.AddRange(myPort)

        ' Determine the selected index
        Dim selectedIndex As Integer = existingItems.IndexOf(ComboBoxPort.SelectedItem)

        ' Set the selected index, or default to the first item
        If selectedIndex >= 0 Then
            ComboBoxPort.SelectedIndex = selectedIndex
        Else
            ComboBoxPort.SelectedIndex = 0
        End If

        ' Enable the Connect button if there are COM ports
        ButtonConnect.Enabled = ComboBoxPort.Items.Count > 0
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        Try
            ' Check if the serial port is already open
            If Not serialPort.IsOpen Then
                ' Configure the serial port settings
                serialPort.PortName = ComboBoxPort.SelectedItem.ToString()
                serialPort.BaudRate = ComboBoxBaudRate.SelectedItem

                ' Open the serial port
                serialPort.Open()

                ' Switch button visibility
                ButtonConnect.SendToBack()
                ButtonDisconnect.BringToFront()
            Else
                MessageBox.Show("Serial port is already open.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error opening serial port: {ex.Message}")

            ' Close the serial port in case of an error
            CloseSerialPort()
        End Try
    End Sub

    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        ' Close the serial port
        CloseSerialPort()

        ' Switch button visibility back
        ButtonDisconnect.SendToBack()
        ButtonConnect.BringToFront()
    End Sub

    Private Sub CloseSerialPort()
        Try
            ' Check if the serial port is open before attempting to close it
            If serialPort.IsOpen Then
                serialPort.Close()
            End If
        Catch ex As Exception
            ' Handle the exception or display an error message
            MessageBox.Show($"Error closing serial port: {ex.Message}")
        End Try
    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles serialPort.DataReceived
        ' Read the data from the serial port
        Try
            serialPort.ReadTimeout = 1000
            Dim receivedData As String = serialPort.ReadLine()

            ' Process the received data
            ProcessSerialData(receivedData)
        Catch ex As Exception
            ' Handle the exception or display an error message
            MessageBox.Show($"Error reading data from serial port: {ex.Message}")

            ' Close the serial port in case of an error
            CloseSerialPort()
        End Try
    End Sub

    Private Sub ProcessSerialData(data As String)
        ' Check if the received data contains temperature information
        If data.StartsWith("Temperature: ") Then
            ' Extract the temperature value
            Dim temperatureStr As String = data.Substring("Temperature: ".Length)
            If Double.TryParse(temperatureStr, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, outValue) Then
                ' Update the chart with the temperature value using the counter as X-axis
                UpdateTemperatureChart(outValue, temperatureCounter)
                temperatureCounter += 1
            End If
        End If

        ' Check if the received data contains position information
    End Sub

    Private Sub UpdateTemperatureChart(temperatureValue As Double, xAxisValue As Integer)
        ' Check if Invoke is required and run the delegate in the UI thread
        If ChartTemperature.InvokeRequired Then
            ChartTemperature.Invoke(Sub() UpdateTemperatureChart(temperatureValue, xAxisValue))
            Return
        End If

        ' Update the temperature chart with the received value
        ' (Assuming you have a series named "Temperature" in your ChartTemperature)
        ChartTemperature.Series("Temperature").Points.AddXY(xAxisValue, temperatureValue)

        ' Set the minimum and maximum values for the X-axis to control scrolling
        ChartTemperature.ChartAreas(0).AxisX.Minimum = xAxisValue - ChartLimit + 1.0
        ChartTemperature.ChartAreas(0).AxisX.Maximum = xAxisValue + 1

        ' Set the minimum and maximum values for the Y-axis to provide a more responsive display
        ChartTemperature.ChartAreas(0).AxisY.Minimum = Math.Floor(temperatureValue) - 5
        ChartTemperature.ChartAreas(0).AxisY.Maximum = Math.Ceiling(temperatureValue) + 5

        ' Optionally, limit the number of points on the chart
        If ChartTemperature.Series(0).Points.Count > ChartLimit Then
            ChartTemperature.Series(0).Points.RemoveAt(0)
        End If

        ' Check if Invoke is required and run the delegate in the UI thread
        If CircularProgressBarTemp.InvokeRequired Then
            CircularProgressBarTemp.Invoke(Sub() UpdateCircularProgressBar(temperatureValue))
        Else
            UpdateCircularProgressBar(temperatureValue)
        End If
    End Sub

    Private Sub UpdateCircularProgressBar(temperatureValue As Double)
        ' Update the circular progress bar with the temperature value
        CircularProgressBarTemp.Value = CInt(temperatureValue)
        CircularProgressBarTemp.Text = $"{temperatureValue:F2} °F"
    End Sub




    Private Sub UpdatePositionChart(positionValue As Integer, xAxisValue As Integer)
        ' Update the position chart with the received value using the new position counter
        ' (Assuming you have a series named "Position" in your ChartPosition)
        ChartPosition.Series("Position").Points.AddXY(xAxisValue, positionValue)

        ChartPosition.ChartAreas(0).AxisX.Minimum = 0
        ChartPosition.ChartAreas(0).AxisX.Maximum = xAxisValue + 1

        ' Set the minimum and maximum values for the Y-axis to provide a more responsive display
        ChartPosition.ChartAreas(0).AxisY.Minimum = 0
        ChartPosition.ChartAreas(0).AxisY.Maximum = 370


        ' Optionally, limihe number of points on the chart
        If ChartPosition.Series(0).Points.Count > 360 Then
            ChartPosition.Series(0).Points.RemoveAt(0)
        End If
    End Sub

    Private Sub SpeedPanel_Paint(sender As Object, e As PaintEventArgs) Handles SpeedPanel.Paint
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles ChartPosition.Click
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub Chart2_Click(sender As Object, e As EventArgs) Handles ChartTemperature.Click
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub

    Private Sub ConnectionPanel_Paint(sender As Object, e As PaintEventArgs) Handles ConnectionPanel.Paint
    End Sub

    Private Sub ReadButton_Click(sender As Object, e As EventArgs) Handles ReadButton.Click
        ' Start the simulation timer
        simulationTimer.Start()
    End Sub
    Private Sub SimulationTimer_Tick(sender As Object, e As EventArgs)
        ' Simulate the motor spinning from 0 degrees to 360 degrees in 10 seconds
        Dim currentTime As Double = DateTime.Now.Second
        Dim elapsedSeconds As Double = currentTime Mod 10
        Dim simulatedPosition As Integer = 0
        Dim maxIncreaseRate As Double = 2 ' Maximum increase rate

        Dim increaseRate As Double = maxIncreaseRate * Math.Sin((elapsedSeconds / 3) * Math.PI / 2)
        ' Update the ChartPosition with simulated position data and the new position counter
        UpdatePositionChart(simpositionCounter, positionCounter)

        ' Increment the position counter by 1 degree each tick
        positionCounter += 1
        Dim randomOffset As Integer = New Random().Next(1)
        simpositionCounter += (1 + increaseRate)





        ' Stop the timer after 10 seconds
        If simpositionCounter >= 360 Then
            simpositionCounter = 0
            simulationTimer.Stop()
        End If
    End Sub

End Class
