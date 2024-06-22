Imports AxWMPLib

Public Class bug_bounty
    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter
        AxWindowsMediaPlayer1.URL = "C:\Users\buddy\OneDrive\Pictures\hci_assignment\vid\BHUNT.mp4"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub AxWindowsMediaPlayer1_PlayStateChange(sender As Object, e As _WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange
        If e.newState = 8 Then
            Me.Close()

            Dim newForm As New course1()
            newForm.Show()
        End If
    End Sub

    Private Sub bug_bounty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class