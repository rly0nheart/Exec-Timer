Public Class MainWindow
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        labelTimer.Text = labelTimer.Text - 1
        If labelTimer.Text = "0" Then
            Timer.Stop()
            Process.Start("cmd.exe", $"/k {txtBoxCommand.Text}")
            Me.Close()
        End If
    End Sub

    Private Sub BtnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        btnAbort.Enabled = True
        btnReset.Enabled = True
        'Starting
        If txtBoxHours.Text = "" Then txtBoxHours.Text = "0"
        If txtBoxMinutes.Text = "" Then txtBoxMinutes.Text = "0"
        If txtBoxSeconds.Text = "" Then txtBoxSeconds.Text = "0"

        'Inputs
        Dim Hours As Integer
        Dim Minutes As Integer
        Dim Seconds As Integer
        Dim TotalTime As Integer

        Hours = (txtBoxHours.Text) * 3600
        Minutes = (txtBoxMinutes.Text) * 60
        Seconds = (txtBoxSeconds.Text) * 1
        TotalTime = Hours + Minutes + Seconds

        labelTimer.Text = TotalTime

        If TotalTime < 6 Then
            labelTimer.Text = "0s"
            txtBoxHours.Text = ""
            txtBoxMinutes.Text = ""
            txtBoxSeconds.Text = ""
            btnAbort.Enabled = False
            btnReset.Enabled = False
            MessageBox.Show("Set time is too small, try starting from 6 seconds", "Set Time", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtBoxCommand.Text = "" Then
            labelTimer.Text = "0s"
            txtBoxHours.Text = ""
            txtBoxMinutes.Text = ""
            txtBoxSeconds.Text = ""
            btnAbort.Enabled = False
            btnReset.Enabled = False
            MessageBox.Show("Command input should not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsNumeric(txtBoxCommand.Text) Then
            labelTimer.Text = "0s"
            txtBoxHours.Text = ""
            txtBoxMinutes.Text = ""
            txtBoxSeconds.Text = ""
            btnAbort.Enabled = False
            btnReset.Enabled = False
            MessageBox.Show($"{txtBoxCommand.Text} Does not appear to be a command", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            btnExecute.Enabled = False
            Timer.Start()
        End If
    End Sub

    Private Sub BtnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click
        'Check if text boxes (and timer label) are not empty to return a MessageBox
        If labelTimer.Text <> "0s" AndAlso txtBoxHours.Text <> "" AndAlso txtBoxMinutes.Text <> "" AndAlso txtBoxSeconds.Text <> "" Then
            Timer.Stop()
            btnAbort.Enabled = False
            btnReset.Enabled = True
            btnExecute.Enabled = True
            MessageBox.Show("Timer has been aborted.", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        If labelTimer.Text <> "0s" AndAlso txtBoxHours.Text <> "" AndAlso txtBoxMinutes.Text <> "" AndAlso txtBoxSeconds.Text <> "" Then
            Timer.Stop()
            labelTimer.Text = "0s"
            txtBoxHours.Text = ""
            txtBoxMinutes.Text = ""
            txtBoxSeconds.Text = ""
            btnAbort.Enabled = False
            btnReset.Enabled = False
            btnExecute.Enabled = True
            MessageBox.Show("Timer has been reset.", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAbort.Enabled = False
        btnReset.Enabled = False
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim Prompt As DialogResult

        Prompt = MessageBox.Show("This will abort any running timer and close the program, continue?", "Quit",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Prompt = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
