<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim CustomLabel1 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New DataVisualization.Charting.CustomLabel()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
        ConnectionPanel = New Panel()
        ButtonConnect = New Button()
        ComboBoxBaudRate = New ComboBox()
        LabelBaudRate = New Label()
        ComboBoxPort = New ComboBox()
        ButtonScanPort = New Button()
        ConnectionTitle = New Label()
        ButtonDisconnect = New Button()
        SpeedPanel = New Panel()
        Label2 = New Label()
        CircularProgressBarTemp = New CircularProgressBar_NET5.CircularProgressBar()
        CircularProgressBarVelocity = New CircularProgressBar_NET5.CircularProgressBar()
        Label1 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        ChartPosition = New DataVisualization.Charting.Chart()
        ChartTemperature = New DataVisualization.Charting.Chart()
        Panel1 = New Panel()
        Label3 = New Label()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        ReadButton = New Button()
        ConnectionPanel.SuspendLayout()
        SpeedPanel.SuspendLayout()
        CType(ChartPosition, ComponentModel.ISupportInitialize).BeginInit()
        CType(ChartTemperature, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ConnectionPanel
        ' 
        ConnectionPanel.BackColor = Color.White
        ConnectionPanel.Controls.Add(ButtonConnect)
        ConnectionPanel.Controls.Add(ComboBoxBaudRate)
        ConnectionPanel.Controls.Add(LabelBaudRate)
        ConnectionPanel.Controls.Add(ComboBoxPort)
        ConnectionPanel.Controls.Add(ButtonScanPort)
        ConnectionPanel.Controls.Add(ConnectionTitle)
        ConnectionPanel.Controls.Add(ButtonDisconnect)
        ConnectionPanel.Location = New Point(1896, 112)
        ConnectionPanel.Name = "ConnectionPanel"
        ConnectionPanel.Size = New Size(729, 417)
        ConnectionPanel.TabIndex = 0
        ' 
        ' ButtonConnect
        ' 
        ButtonConnect.BackColor = Color.RoyalBlue
        ButtonConnect.FlatStyle = FlatStyle.Flat
        ButtonConnect.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        ButtonConnect.ForeColor = Color.Azure
        ButtonConnect.Location = New Point(152, 308)
        ButtonConnect.Name = "ButtonConnect"
        ButtonConnect.Size = New Size(394, 58)
        ButtonConnect.TabIndex = 1
        ButtonConnect.Text = "Connect"
        ButtonConnect.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxBaudRate
        ' 
        ComboBoxBaudRate.BackColor = Color.RoyalBlue
        ComboBoxBaudRate.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxBaudRate.FlatStyle = FlatStyle.Flat
        ComboBoxBaudRate.ForeColor = Color.White
        ComboBoxBaudRate.FormattingEnabled = True
        ComboBoxBaudRate.Items.AddRange(New Object() {"9600", "14400", "19200", "38400", "57600", "115200"})
        ComboBoxBaudRate.Location = New Point(340, 226)
        ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        ComboBoxBaudRate.Size = New Size(302, 49)
        ComboBoxBaudRate.TabIndex = 4
        ' 
        ' LabelBaudRate
        ' 
        LabelBaudRate.AutoSize = True
        LabelBaudRate.BackColor = Color.White
        LabelBaudRate.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LabelBaudRate.ForeColor = Color.RoyalBlue
        LabelBaudRate.Location = New Point(91, 229)
        LabelBaudRate.Name = "LabelBaudRate"
        LabelBaudRate.Size = New Size(178, 41)
        LabelBaudRate.TabIndex = 3
        LabelBaudRate.Text = "Baud Rate :"
        ' 
        ' ComboBoxPort
        ' 
        ComboBoxPort.BackColor = Color.RoyalBlue
        ComboBoxPort.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxPort.FlatStyle = FlatStyle.Flat
        ComboBoxPort.ForeColor = Color.White
        ComboBoxPort.FormattingEnabled = True
        ComboBoxPort.Location = New Point(340, 131)
        ComboBoxPort.Name = "ComboBoxPort"
        ComboBoxPort.Size = New Size(302, 49)
        ComboBoxPort.TabIndex = 2
        ' 
        ' ButtonScanPort
        ' 
        ButtonScanPort.BackColor = Color.RoyalBlue
        ButtonScanPort.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        ButtonScanPort.FlatAppearance.MouseOverBackColor = Color.DodgerBlue
        ButtonScanPort.FlatStyle = FlatStyle.Flat
        ButtonScanPort.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonScanPort.ForeColor = Color.White
        ButtonScanPort.Location = New Point(72, 130)
        ButtonScanPort.Name = "ButtonScanPort"
        ButtonScanPort.Size = New Size(197, 49)
        ButtonScanPort.TabIndex = 1
        ButtonScanPort.Text = "Scan Port"
        ButtonScanPort.UseVisualStyleBackColor = False
        ' 
        ' ConnectionTitle
        ' 
        ConnectionTitle.AutoSize = True
        ConnectionTitle.BackColor = Color.White
        ConnectionTitle.FlatStyle = FlatStyle.System
        ConnectionTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ConnectionTitle.ForeColor = Color.RoyalBlue
        ConnectionTitle.Location = New Point(152, 25)
        ConnectionTitle.Name = "ConnectionTitle"
        ConnectionTitle.Size = New Size(350, 54)
        ConnectionTitle.TabIndex = 0
        ConnectionTitle.Text = "Connection Panel"
        ' 
        ' ButtonDisconnect
        ' 
        ButtonDisconnect.BackColor = Color.MidnightBlue
        ButtonDisconnect.FlatStyle = FlatStyle.Flat
        ButtonDisconnect.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        ButtonDisconnect.ForeColor = Color.Azure
        ButtonDisconnect.Location = New Point(152, 308)
        ButtonDisconnect.Name = "ButtonDisconnect"
        ButtonDisconnect.Size = New Size(394, 58)
        ButtonDisconnect.TabIndex = 5
        ButtonDisconnect.Text = "Disconnect"
        ButtonDisconnect.UseVisualStyleBackColor = False
        ' 
        ' SpeedPanel
        ' 
        SpeedPanel.BackColor = Color.White
        SpeedPanel.Controls.Add(Label2)
        SpeedPanel.Controls.Add(CircularProgressBarTemp)
        SpeedPanel.Controls.Add(CircularProgressBarVelocity)
        SpeedPanel.Controls.Add(Label1)
        SpeedPanel.Location = New Point(69, 112)
        SpeedPanel.Name = "SpeedPanel"
        SpeedPanel.Size = New Size(1008, 417)
        SpeedPanel.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.RoyalBlue
        Label2.Location = New Point(657, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(264, 54)
        Label2.TabIndex = 3
        Label2.Text = "Temperature"
        ' 
        ' CircularProgressBarTemp
        ' 
        CircularProgressBarTemp.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear
        CircularProgressBarTemp.AnimationSpeed = 500
        CircularProgressBarTemp.BackColor = Color.Transparent
        CircularProgressBarTemp.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        CircularProgressBarTemp.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        CircularProgressBarTemp.InnerColor = Color.White
        CircularProgressBarTemp.InnerMargin = 2
        CircularProgressBarTemp.InnerWidth = -1
        CircularProgressBarTemp.Location = New Point(657, 115)
        CircularProgressBarTemp.MarqueeAnimationSpeed = 2000
        CircularProgressBarTemp.Name = "CircularProgressBarTemp"
        CircularProgressBarTemp.OuterColor = Color.Gray
        CircularProgressBarTemp.OuterMargin = -25
        CircularProgressBarTemp.OuterWidth = 26
        CircularProgressBarTemp.ProgressColor = Color.RoyalBlue
        CircularProgressBarTemp.ProgressWidth = 25
        CircularProgressBarTemp.SecondaryFont = New Font("Segoe UI", 10F)
        CircularProgressBarTemp.Size = New Size(245, 251)
        CircularProgressBarTemp.StartAngle = 90
        CircularProgressBarTemp.SubscriptColor = Color.FromArgb(CByte(166), CByte(166), CByte(166))
        CircularProgressBarTemp.SubscriptMargin = New Padding(10, -35, 0, 0)
        CircularProgressBarTemp.SubscriptText = ""
        CircularProgressBarTemp.SuperscriptColor = Color.FromArgb(CByte(166), CByte(166), CByte(166))
        CircularProgressBarTemp.SuperscriptMargin = New Padding(10, 35, 0, 0)
        CircularProgressBarTemp.SuperscriptText = ""
        CircularProgressBarTemp.TabIndex = 2
        CircularProgressBarTemp.Text = "0.00 ºF"
        CircularProgressBarTemp.TextMargin = New Padding(0, 2, 0, 0)
        CircularProgressBarTemp.Value = 68
        ' 
        ' CircularProgressBarVelocity
        ' 
        CircularProgressBarVelocity.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear
        CircularProgressBarVelocity.AnimationSpeed = 500
        CircularProgressBarVelocity.BackColor = Color.Transparent
        CircularProgressBarVelocity.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        CircularProgressBarVelocity.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        CircularProgressBarVelocity.InnerColor = Color.White
        CircularProgressBarVelocity.InnerMargin = 2
        CircularProgressBarVelocity.InnerWidth = -1
        CircularProgressBarVelocity.Location = New Point(150, 115)
        CircularProgressBarVelocity.MarqueeAnimationSpeed = 2000
        CircularProgressBarVelocity.Name = "CircularProgressBarVelocity"
        CircularProgressBarVelocity.OuterColor = Color.Gray
        CircularProgressBarVelocity.OuterMargin = -25
        CircularProgressBarVelocity.OuterWidth = 26
        CircularProgressBarVelocity.ProgressColor = Color.RoyalBlue
        CircularProgressBarVelocity.ProgressWidth = 25
        CircularProgressBarVelocity.SecondaryFont = New Font("Segoe UI", 10F)
        CircularProgressBarVelocity.Size = New Size(245, 251)
        CircularProgressBarVelocity.StartAngle = 90
        CircularProgressBarVelocity.SubscriptColor = Color.FromArgb(CByte(166), CByte(166), CByte(166))
        CircularProgressBarVelocity.SubscriptMargin = New Padding(10, -35, 0, 0)
        CircularProgressBarVelocity.SubscriptText = ""
        CircularProgressBarVelocity.SuperscriptColor = Color.FromArgb(CByte(166), CByte(166), CByte(166))
        CircularProgressBarVelocity.SuperscriptMargin = New Padding(10, 35, 0, 0)
        CircularProgressBarVelocity.SuperscriptText = ""
        CircularProgressBarVelocity.TabIndex = 1
        CircularProgressBarVelocity.Text = "00 RPS"
        CircularProgressBarVelocity.TextMargin = New Padding(0, 2, 0, 0)
        CircularProgressBarVelocity.Value = 68
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(186, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 54)
        Label1.TabIndex = 0
        Label1.Text = "Velocity"
        ' 
        ' ChartPosition
        ' 
        ChartPosition.BorderlineColor = SystemColors.Highlight
        CustomLabel1.ForeColor = Color.Black
        CustomLabel1.Text = "Sample No."
        ChartArea1.AxisX.CustomLabels.Add(CustomLabel1)
        ChartArea1.AxisX.Title = "Sample No."
        ChartArea1.AxisY.Title = "Position (Degrees)"
        ChartArea1.Name = "ChartArea1"
        ChartPosition.ChartAreas.Add(ChartArea1)
        ChartPosition.Location = New Point(69, 591)
        ChartPosition.Name = "ChartPosition"
        Series1.BorderWidth = 5
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = DataVisualization.Charting.SeriesChartType.Spline
        Series1.Name = "Position"
        ChartPosition.Series.Add(Series1)
        ChartPosition.Size = New Size(1396, 706)
        ChartPosition.TabIndex = 2
        ChartPosition.Text = "RPM"
        Title1.BackColor = Color.White
        Title1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title1.Name = "Position (Degrees)"
        Title1.Text = "Position (Degrees)"
        ChartPosition.Titles.Add(Title1)
        ' 
        ' ChartTemperature
        ' 
        ChartTemperature.BorderlineColor = SystemColors.Highlight
        ChartArea2.Name = "ChartArea1"
        ChartTemperature.ChartAreas.Add(ChartArea2)
        ChartTemperature.Location = New Point(1515, 591)
        ChartTemperature.Name = "ChartTemperature"
        Series2.BorderWidth = 5
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = DataVisualization.Charting.SeriesChartType.Spline
        Series2.Name = "Temperature"
        ChartTemperature.Series.Add(Series2)
        ChartTemperature.Size = New Size(1133, 706)
        ChartTemperature.TabIndex = 3
        ChartTemperature.Text = "RPM"
        Title2.BackColor = Color.White
        Title2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title2.Name = "RPM"
        Title2.Text = "Temperature (F)"
        ChartTemperature.Titles.Add(Title2)
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.NovaRacing_Logo_Blue_V
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Location = New Point(1153, 112)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(685, 302)
        Panel1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Helonia", 20.0999985F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(1153, 429)
        Label3.Name = "Label3"
        Label3.Size = New Size(703, 79)
        Label3.TabIndex = 5
        Label3.Text = "Emrax 228 Dashboard"
        ' 
        ' ReadButton
        ' 
        ReadButton.Location = New Point(1378, 527)
        ReadButton.Name = "ReadButton"
        ReadButton.Size = New Size(188, 58)
        ReadButton.TabIndex = 6
        ReadButton.Text = "Read"
        ReadButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2702, 1325)
        Controls.Add(ReadButton)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Controls.Add(ChartTemperature)
        Controls.Add(ChartPosition)
        Controls.Add(SpeedPanel)
        Controls.Add(ConnectionPanel)
        Name = "Form1"
        Text = "NovaRacing Emrax 228 Dashboard"
        ConnectionPanel.ResumeLayout(False)
        ConnectionPanel.PerformLayout()
        SpeedPanel.ResumeLayout(False)
        SpeedPanel.PerformLayout()
        CType(ChartPosition, ComponentModel.ISupportInitialize).EndInit()
        CType(ChartTemperature, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ConnectionPanel As Panel
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents ConnectionTitle As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents LabelBaudRate As Label
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents ButtonDisconnect As Button
    Friend WithEvents SpeedPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CircularProgressBarVelocity As CircularProgressBar_NET5.CircularProgressBar
    Friend WithEvents ChartPosition As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents CircularProgressBarTemp As CircularProgressBar_NET5.CircularProgressBar
    Friend WithEvents ChartTemperature As DataVisualization.Charting.Chart
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ReadButton As Button

End Class
