<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.btnAbort = New System.Windows.Forms.Button()
        Me.txtBoxHours = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtBoxMinutes = New System.Windows.Forms.TextBox()
        Me.txtBoxSeconds = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxCommand = New System.Windows.Forms.TextBox()
        Me.labelTimer = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'btnExecute
        '
        Me.btnExecute.Location = New System.Drawing.Point(217, 294)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(58, 29)
        Me.btnExecute.TabIndex = 0
        Me.btnExecute.Text = "Execute"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'btnAbort
        '
        Me.btnAbort.Location = New System.Drawing.Point(281, 294)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(58, 29)
        Me.btnAbort.TabIndex = 1
        Me.btnAbort.Text = "Abort"
        Me.btnAbort.UseVisualStyleBackColor = True
        '
        'txtBoxHours
        '
        Me.txtBoxHours.Location = New System.Drawing.Point(287, 205)
        Me.txtBoxHours.Name = "txtBoxHours"
        Me.txtBoxHours.PlaceholderText = "Hours"
        Me.txtBoxHours.Size = New System.Drawing.Size(56, 23)
        Me.txtBoxHours.TabIndex = 2
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(345, 294)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(58, 29)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtBoxMinutes
        '
        Me.txtBoxMinutes.Location = New System.Drawing.Point(349, 205)
        Me.txtBoxMinutes.Name = "txtBoxMinutes"
        Me.txtBoxMinutes.PlaceholderText = "Minutes"
        Me.txtBoxMinutes.Size = New System.Drawing.Size(56, 23)
        Me.txtBoxMinutes.TabIndex = 4
        '
        'txtBoxSeconds
        '
        Me.txtBoxSeconds.Location = New System.Drawing.Point(411, 205)
        Me.txtBoxSeconds.Name = "txtBoxSeconds"
        Me.txtBoxSeconds.PlaceholderText = "Seconds"
        Me.txtBoxSeconds.Size = New System.Drawing.Size(56, 23)
        Me.txtBoxSeconds.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(80, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "$"
        '
        'txtBoxCommand
        '
        Me.txtBoxCommand.Location = New System.Drawing.Point(93, 176)
        Me.txtBoxCommand.Multiline = True
        Me.txtBoxCommand.Name = "txtBoxCommand"
        Me.txtBoxCommand.PlaceholderText = "Command"
        Me.txtBoxCommand.Size = New System.Drawing.Size(374, 23)
        Me.txtBoxCommand.TabIndex = 7
        '
        'labelTimer
        '
        Me.labelTimer.AutoSize = True
        Me.labelTimer.Font = New System.Drawing.Font("Courier New", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelTimer.Location = New System.Drawing.Point(227, 84)
        Me.labelTimer.Name = "labelTimer"
        Me.labelTimer.Size = New System.Drawing.Size(100, 65)
        Me.labelTimer.TabIndex = 8
        Me.labelTimer.Text = "0s"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(93, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(366, 38)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Command Will Execute In:"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(409, 294)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(58, 29)
        Me.btnQuit.TabIndex = 10
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 353)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelTimer)
        Me.Controls.Add(Me.txtBoxCommand)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBoxSeconds)
        Me.Controls.Add(Me.txtBoxMinutes)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtBoxHours)
        Me.Controls.Add(Me.btnAbort)
        Me.Controls.Add(Me.btnExecute)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.Text = "Exec Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer As Timer
    Friend WithEvents btnExecute As Button
    Friend WithEvents btnAbort As Button
    Friend WithEvents txtBoxHours As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents txtBoxMinutes As TextBox
    Friend WithEvents txtBoxSeconds As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxCommand As TextBox
    Friend WithEvents labelTimer As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnQuit As Button
End Class
