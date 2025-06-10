<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.coin_waiter = New System.Windows.Forms.Timer(Me.components)
        Me.displayupdater = New System.Windows.Forms.Timer(Me.components)
        Me.timeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.banner = New System.Windows.Forms.Label()
        Me.pcnumber = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RatesDataGridView = New System.Windows.Forms.DataGridView()
        Me.btn_insert_coin = New System.Windows.Forms.Button()
        Me.coinInsertGroupBox = New System.Windows.Forms.GroupBox()
        Me.insertcoinWaiter = New System.Windows.Forms.ProgressBar()
        Me.OfflineNotification = New System.Windows.Forms.Label()
        Me.total_inserted_coin = New System.Windows.Forms.Label()
        Me.inserted_display = New System.Windows.Forms.Label()
        Me.insert_coin_display = New System.Windows.Forms.Label()
        Me.timerGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.secondsDisplay = New System.Windows.Forms.Label()
        Me.minutesDisplay = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LogoutlinkBtn = New System.Windows.Forms.LinkLabel()
        Me.logInTimeDisplay = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hourDisplay = New System.Windows.Forms.Label()
        Me.loginGroupBox = New System.Windows.Forms.GroupBox()
        Me.pinSix = New System.Windows.Forms.TextBox()
        Me.pinFive = New System.Windows.Forms.TextBox()
        Me.pinFour = New System.Windows.Forms.TextBox()
        Me.pinThree = New System.Windows.Forms.TextBox()
        Me.pinTwo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.loginCancelBtn = New System.Windows.Forms.Button()
        Me.pinLoginBtn = New System.Windows.Forms.Button()
        Me.pinOne = New System.Windows.Forms.TextBox()
        Me.bg = New System.Windows.Forms.WebBrowser()
        Me.pcnumber.SuspendLayout()
        CType(Me.RatesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.coinInsertGroupBox.SuspendLayout()
        Me.timerGroupBox.SuspendLayout()
        Me.loginGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'coin_waiter
        '
        Me.coin_waiter.Interval = 1000
        '
        'displayupdater
        '
        Me.displayupdater.Enabled = True
        Me.displayupdater.Interval = 1000
        '
        'timeTimer
        '
        Me.timeTimer.Interval = 1000
        '
        'banner
        '
        Me.banner.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.banner.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.banner.ForeColor = System.Drawing.Color.White
        Me.banner.Location = New System.Drawing.Point(1, 292)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(332, 46)
        Me.banner.TabIndex = 11
        Me.banner.Text = "Banner Tag"
        Me.banner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pcnumber
        '
        Me.pcnumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pcnumber.Controls.Add(Me.Label9)
        Me.pcnumber.Controls.Add(Me.banner)
        Me.pcnumber.Controls.Add(Me.RatesDataGridView)
        Me.pcnumber.Controls.Add(Me.btn_insert_coin)
        Me.pcnumber.Controls.Add(Me.coinInsertGroupBox)
        Me.pcnumber.Controls.Add(Me.timerGroupBox)
        Me.pcnumber.Controls.Add(Me.loginGroupBox)
        Me.pcnumber.Dock = System.Windows.Forms.DockStyle.Left
        Me.pcnumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pcnumber.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pcnumber.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.pcnumber.Location = New System.Drawing.Point(0, 0)
        Me.pcnumber.Name = "pcnumber"
        Me.pcnumber.Size = New System.Drawing.Size(334, 1070)
        Me.pcnumber.TabIndex = 10
        Me.pcnumber.TabStop = False
        Me.pcnumber.Text = "PC 1"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(332, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Time Rates"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RatesDataGridView
        '
        Me.RatesDataGridView.AllowUserToDeleteRows = False
        Me.RatesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.RatesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RatesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RatesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.RatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RatesDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RatesDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.RatesDataGridView.Location = New System.Drawing.Point(6, 358)
        Me.RatesDataGridView.MultiSelect = False
        Me.RatesDataGridView.Name = "RatesDataGridView"
        Me.RatesDataGridView.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RatesDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.RatesDataGridView.RowHeadersWidth = 12
        Me.RatesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RatesDataGridView.ShowEditingIcon = False
        Me.RatesDataGridView.Size = New System.Drawing.Size(323, 450)
        Me.RatesDataGridView.TabIndex = 12
        '
        'btn_insert_coin
        '
        Me.btn_insert_coin.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_insert_coin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_insert_coin.FlatAppearance.BorderSize = 5
        Me.btn_insert_coin.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert_coin.ForeColor = System.Drawing.Color.White
        Me.btn_insert_coin.Location = New System.Drawing.Point(6, 219)
        Me.btn_insert_coin.Name = "btn_insert_coin"
        Me.btn_insert_coin.Size = New System.Drawing.Size(322, 36)
        Me.btn_insert_coin.TabIndex = 0
        Me.btn_insert_coin.Text = "Insert coin"
        Me.btn_insert_coin.UseVisualStyleBackColor = False
        '
        'coinInsertGroupBox
        '
        Me.coinInsertGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.coinInsertGroupBox.Controls.Add(Me.insertcoinWaiter)
        Me.coinInsertGroupBox.Controls.Add(Me.OfflineNotification)
        Me.coinInsertGroupBox.Controls.Add(Me.total_inserted_coin)
        Me.coinInsertGroupBox.Controls.Add(Me.inserted_display)
        Me.coinInsertGroupBox.Controls.Add(Me.insert_coin_display)
        Me.coinInsertGroupBox.Location = New System.Drawing.Point(6, 23)
        Me.coinInsertGroupBox.Name = "coinInsertGroupBox"
        Me.coinInsertGroupBox.Size = New System.Drawing.Size(323, 190)
        Me.coinInsertGroupBox.TabIndex = 0
        Me.coinInsertGroupBox.TabStop = False
        Me.coinInsertGroupBox.Visible = False
        '
        'insertcoinWaiter
        '
        Me.insertcoinWaiter.Location = New System.Drawing.Point(42, 163)
        Me.insertcoinWaiter.MarqueeAnimationSpeed = 10
        Me.insertcoinWaiter.Name = "insertcoinWaiter"
        Me.insertcoinWaiter.Size = New System.Drawing.Size(241, 19)
        Me.insertcoinWaiter.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.insertcoinWaiter.TabIndex = 9
        Me.insertcoinWaiter.Value = 100
        Me.insertcoinWaiter.Visible = False
        '
        'OfflineNotification
        '
        Me.OfflineNotification.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfflineNotification.ForeColor = System.Drawing.Color.Red
        Me.OfflineNotification.Location = New System.Drawing.Point(6, 23)
        Me.OfflineNotification.Name = "OfflineNotification"
        Me.OfflineNotification.Size = New System.Drawing.Size(310, 32)
        Me.OfflineNotification.TabIndex = 5
        Me.OfflineNotification.Text = "OFFLINE"
        Me.OfflineNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.OfflineNotification.Visible = False
        '
        'total_inserted_coin
        '
        Me.total_inserted_coin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_inserted_coin.ForeColor = System.Drawing.Color.White
        Me.total_inserted_coin.Location = New System.Drawing.Point(158, 141)
        Me.total_inserted_coin.Name = "total_inserted_coin"
        Me.total_inserted_coin.Size = New System.Drawing.Size(121, 19)
        Me.total_inserted_coin.TabIndex = 4
        Me.total_inserted_coin.Text = "-"
        Me.total_inserted_coin.Visible = False
        '
        'inserted_display
        '
        Me.inserted_display.AutoSize = True
        Me.inserted_display.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inserted_display.ForeColor = System.Drawing.Color.White
        Me.inserted_display.Location = New System.Drawing.Point(35, 140)
        Me.inserted_display.Name = "inserted_display"
        Me.inserted_display.Size = New System.Drawing.Size(122, 17)
        Me.inserted_display.TabIndex = 3
        Me.inserted_display.Text = "Total inserted coins :"
        Me.inserted_display.Visible = False
        '
        'insert_coin_display
        '
        Me.insert_coin_display.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert_coin_display.ForeColor = System.Drawing.Color.White
        Me.insert_coin_display.Location = New System.Drawing.Point(7, 54)
        Me.insert_coin_display.Name = "insert_coin_display"
        Me.insert_coin_display.Size = New System.Drawing.Size(309, 100)
        Me.insert_coin_display.TabIndex = 1
        Me.insert_coin_display.Text = "Hello World"
        Me.insert_coin_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerGroupBox
        '
        Me.timerGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.timerGroupBox.Controls.Add(Me.Label6)
        Me.timerGroupBox.Controls.Add(Me.Label7)
        Me.timerGroupBox.Controls.Add(Me.Label5)
        Me.timerGroupBox.Controls.Add(Me.Label8)
        Me.timerGroupBox.Controls.Add(Me.Label3)
        Me.timerGroupBox.Controls.Add(Me.secondsDisplay)
        Me.timerGroupBox.Controls.Add(Me.minutesDisplay)
        Me.timerGroupBox.Controls.Add(Me.Label2)
        Me.timerGroupBox.Controls.Add(Me.LogoutlinkBtn)
        Me.timerGroupBox.Controls.Add(Me.logInTimeDisplay)
        Me.timerGroupBox.Controls.Add(Me.Label1)
        Me.timerGroupBox.Controls.Add(Me.hourDisplay)
        Me.timerGroupBox.ForeColor = System.Drawing.Color.White
        Me.timerGroupBox.Location = New System.Drawing.Point(6, 23)
        Me.timerGroupBox.Name = "timerGroupBox"
        Me.timerGroupBox.Size = New System.Drawing.Size(323, 190)
        Me.timerGroupBox.TabIndex = 5
        Me.timerGroupBox.TabStop = False
        Me.timerGroupBox.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(201, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 64)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = ":"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(242, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "SS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(140, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "MM"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(99, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 64)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = ":"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(38, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "HH"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'secondsDisplay
        '
        Me.secondsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.secondsDisplay.Font = New System.Drawing.Font("Impact", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondsDisplay.ForeColor = System.Drawing.Color.White
        Me.secondsDisplay.Location = New System.Drawing.Point(222, 60)
        Me.secondsDisplay.Name = "secondsDisplay"
        Me.secondsDisplay.Size = New System.Drawing.Size(80, 75)
        Me.secondsDisplay.TabIndex = 9
        Me.secondsDisplay.Text = "00"
        Me.secondsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minutesDisplay
        '
        Me.minutesDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.minutesDisplay.Font = New System.Drawing.Font("Impact", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutesDisplay.ForeColor = System.Drawing.Color.White
        Me.minutesDisplay.Location = New System.Drawing.Point(120, 58)
        Me.minutesDisplay.Name = "minutesDisplay"
        Me.minutesDisplay.Size = New System.Drawing.Size(80, 75)
        Me.minutesDisplay.TabIndex = 8
        Me.minutesDisplay.Text = "00"
        Me.minutesDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Remaining time"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoutlinkBtn
        '
        Me.LogoutlinkBtn.AutoSize = True
        Me.LogoutlinkBtn.BackColor = System.Drawing.Color.Transparent
        Me.LogoutlinkBtn.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutlinkBtn.LinkColor = System.Drawing.Color.White
        Me.LogoutlinkBtn.Location = New System.Drawing.Point(271, 29)
        Me.LogoutlinkBtn.Name = "LogoutlinkBtn"
        Me.LogoutlinkBtn.Size = New System.Drawing.Size(46, 15)
        Me.LogoutlinkBtn.TabIndex = 7
        Me.LogoutlinkBtn.TabStop = True
        Me.LogoutlinkBtn.Text = "Logout"
        Me.LogoutlinkBtn.VisitedLinkColor = System.Drawing.Color.White
        '
        'logInTimeDisplay
        '
        Me.logInTimeDisplay.BackColor = System.Drawing.Color.Transparent
        Me.logInTimeDisplay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logInTimeDisplay.ForeColor = System.Drawing.Color.White
        Me.logInTimeDisplay.Location = New System.Drawing.Point(158, 158)
        Me.logInTimeDisplay.Name = "logInTimeDisplay"
        Me.logInTimeDisplay.Size = New System.Drawing.Size(121, 19)
        Me.logInTimeDisplay.TabIndex = 6
        Me.logInTimeDisplay.Text = "-:-"
        Me.logInTimeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(74, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Log in time :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'hourDisplay
        '
        Me.hourDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hourDisplay.Font = New System.Drawing.Font("Impact", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hourDisplay.ForeColor = System.Drawing.Color.White
        Me.hourDisplay.Location = New System.Drawing.Point(18, 58)
        Me.hourDisplay.Name = "hourDisplay"
        Me.hourDisplay.Size = New System.Drawing.Size(80, 75)
        Me.hourDisplay.TabIndex = 4
        Me.hourDisplay.Text = "00"
        Me.hourDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'loginGroupBox
        '
        Me.loginGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.loginGroupBox.Controls.Add(Me.pinSix)
        Me.loginGroupBox.Controls.Add(Me.pinFive)
        Me.loginGroupBox.Controls.Add(Me.pinFour)
        Me.loginGroupBox.Controls.Add(Me.pinThree)
        Me.loginGroupBox.Controls.Add(Me.pinTwo)
        Me.loginGroupBox.Controls.Add(Me.Label4)
        Me.loginGroupBox.Controls.Add(Me.loginCancelBtn)
        Me.loginGroupBox.Controls.Add(Me.pinLoginBtn)
        Me.loginGroupBox.Controls.Add(Me.pinOne)
        Me.loginGroupBox.ForeColor = System.Drawing.Color.White
        Me.loginGroupBox.Location = New System.Drawing.Point(6, 23)
        Me.loginGroupBox.Name = "loginGroupBox"
        Me.loginGroupBox.Size = New System.Drawing.Size(323, 190)
        Me.loginGroupBox.TabIndex = 6
        Me.loginGroupBox.TabStop = False
        Me.loginGroupBox.Visible = False
        '
        'pinSix
        '
        Me.pinSix.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pinSix.Location = New System.Drawing.Point(236, 93)
        Me.pinSix.MaxLength = 1
        Me.pinSix.Name = "pinSix"
        Me.pinSix.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.pinSix.Size = New System.Drawing.Size(29, 46)
        Me.pinSix.TabIndex = 6
        Me.pinSix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pinFive
        '
        Me.pinFive.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pinFive.Location = New System.Drawing.Point(201, 93)
        Me.pinFive.MaxLength = 1
        Me.pinFive.Name = "pinFive"
        Me.pinFive.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.pinFive.Size = New System.Drawing.Size(29, 46)
        Me.pinFive.TabIndex = 5
        Me.pinFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pinFour
        '
        Me.pinFour.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pinFour.Location = New System.Drawing.Point(166, 93)
        Me.pinFour.MaxLength = 1
        Me.pinFour.Name = "pinFour"
        Me.pinFour.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.pinFour.Size = New System.Drawing.Size(29, 46)
        Me.pinFour.TabIndex = 4
        Me.pinFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pinThree
        '
        Me.pinThree.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pinThree.Location = New System.Drawing.Point(131, 93)
        Me.pinThree.MaxLength = 1
        Me.pinThree.Name = "pinThree"
        Me.pinThree.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.pinThree.Size = New System.Drawing.Size(29, 46)
        Me.pinThree.TabIndex = 3
        Me.pinThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pinTwo
        '
        Me.pinTwo.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pinTwo.Location = New System.Drawing.Point(96, 93)
        Me.pinTwo.MaxLength = 1
        Me.pinTwo.Name = "pinTwo"
        Me.pinTwo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.pinTwo.Size = New System.Drawing.Size(29, 46)
        Me.pinTwo.TabIndex = 2
        Me.pinTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 47)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "PIN"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'loginCancelBtn
        '
        Me.loginCancelBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.loginCancelBtn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginCancelBtn.ForeColor = System.Drawing.Color.White
        Me.loginCancelBtn.Location = New System.Drawing.Point(71, 150)
        Me.loginCancelBtn.Name = "loginCancelBtn"
        Me.loginCancelBtn.Size = New System.Drawing.Size(85, 30)
        Me.loginCancelBtn.TabIndex = 7
        Me.loginCancelBtn.Text = "Cancel"
        Me.loginCancelBtn.UseVisualStyleBackColor = False
        '
        'pinLoginBtn
        '
        Me.pinLoginBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.pinLoginBtn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pinLoginBtn.ForeColor = System.Drawing.Color.White
        Me.pinLoginBtn.Location = New System.Drawing.Point(170, 151)
        Me.pinLoginBtn.Name = "pinLoginBtn"
        Me.pinLoginBtn.Size = New System.Drawing.Size(85, 30)
        Me.pinLoginBtn.TabIndex = 8
        Me.pinLoginBtn.Text = "Login"
        Me.pinLoginBtn.UseVisualStyleBackColor = False
        '
        'pinOne
        '
        Me.pinOne.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pinOne.Location = New System.Drawing.Point(61, 93)
        Me.pinOne.MaxLength = 1
        Me.pinOne.Name = "pinOne"
        Me.pinOne.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.pinOne.Size = New System.Drawing.Size(29, 46)
        Me.pinOne.TabIndex = 1
        Me.pinOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bg
        '
        Me.bg.Dock = System.Windows.Forms.DockStyle.Top
        Me.bg.Location = New System.Drawing.Point(334, 0)
        Me.bg.MinimumSize = New System.Drawing.Size(20, 20)
        Me.bg.Name = "bg"
        Me.bg.Size = New System.Drawing.Size(1366, 1086)
        Me.bg.TabIndex = 12
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1700, 1070)
        Me.ControlBox = False
        Me.Controls.Add(Me.bg)
        Me.Controls.Add(Me.pcnumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pcnumber.ResumeLayout(False)
        CType(Me.RatesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.coinInsertGroupBox.ResumeLayout(False)
        Me.coinInsertGroupBox.PerformLayout()
        Me.timerGroupBox.ResumeLayout(False)
        Me.timerGroupBox.PerformLayout()
        Me.loginGroupBox.ResumeLayout(False)
        Me.loginGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents coin_waiter As Timer
    Friend WithEvents displayupdater As Timer
    Friend WithEvents timeTimer As Timer
    Friend WithEvents banner As Label
    Friend WithEvents pcnumber As GroupBox
    Friend WithEvents btn_insert_coin As Button
    Friend WithEvents coinInsertGroupBox As GroupBox
    Friend WithEvents insertcoinWaiter As ProgressBar
    Friend WithEvents OfflineNotification As Label
    Friend WithEvents total_inserted_coin As Label
    Friend WithEvents inserted_display As Label
    Friend WithEvents insert_coin_display As Label
    Friend WithEvents loginGroupBox As GroupBox
    Friend WithEvents pinSix As TextBox
    Friend WithEvents pinFive As TextBox
    Friend WithEvents pinFour As TextBox
    Friend WithEvents pinThree As TextBox
    Friend WithEvents pinTwo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents loginCancelBtn As Button
    Friend WithEvents pinLoginBtn As Button
    Friend WithEvents pinOne As TextBox
    Friend WithEvents timerGroupBox As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents secondsDisplay As Label
    Friend WithEvents minutesDisplay As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LogoutlinkBtn As LinkLabel
    Friend WithEvents logInTimeDisplay As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents hourDisplay As Label
    Friend WithEvents bg As WebBrowser
    Friend WithEvents Label6 As Label
    Friend WithEvents RatesDataGridView As DataGridView
    Friend WithEvents Label9 As Label
End Class
