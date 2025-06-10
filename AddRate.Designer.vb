<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rateName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rateRate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rateNotes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rateMinutes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.newRateBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rateName
        '
        Me.rateName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rateName.Location = New System.Drawing.Point(79, 38)
        Me.rateName.MaxLength = 15
        Me.rateName.Name = "rateName"
        Me.rateName.Size = New System.Drawing.Size(216, 21)
        Me.rateName.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 22)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Name :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rateRate
        '
        Me.rateRate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rateRate.Location = New System.Drawing.Point(79, 64)
        Me.rateRate.MaxLength = 3
        Me.rateRate.Name = "rateRate"
        Me.rateRate.Size = New System.Drawing.Size(107, 21)
        Me.rateRate.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 22)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Rate :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rateNotes
        '
        Me.rateNotes.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rateNotes.Location = New System.Drawing.Point(79, 116)
        Me.rateNotes.MaxLength = 15
        Me.rateNotes.Name = "rateNotes"
        Me.rateNotes.Size = New System.Drawing.Size(216, 21)
        Me.rateNotes.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 22)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Note :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rateMinutes
        '
        Me.rateMinutes.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rateMinutes.Location = New System.Drawing.Point(79, 90)
        Me.rateMinutes.MaxLength = 4
        Me.rateMinutes.Name = "rateMinutes"
        Me.rateMinutes.Size = New System.Drawing.Size(107, 21)
        Me.rateMinutes.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 22)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Minutes :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'newRateBtn
        '
        Me.newRateBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.newRateBtn.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newRateBtn.ForeColor = System.Drawing.Color.White
        Me.newRateBtn.Location = New System.Drawing.Point(220, 141)
        Me.newRateBtn.Name = "newRateBtn"
        Me.newRateBtn.Size = New System.Drawing.Size(75, 29)
        Me.newRateBtn.TabIndex = 53
        Me.newRateBtn.Text = "Add Rate"
        Me.newRateBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(188, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 23)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "pesos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(188, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 23)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "minutes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Gold
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(-4, -7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(361, 27)
        Me.Label6.TabIndex = 56
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(314, 176)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.newRateBtn)
        Me.Controls.Add(Me.rateNotes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rateMinutes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rateRate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rateName)
        Me.Controls.Add(Me.Label14)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddRate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rateName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents rateRate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rateNotes As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rateMinutes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents newRateBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
