Imports System.Data.SqlClient

Public Class pdf5
    Dim con As SqlConnection = New SqlConnection("Server = KEITH\SQLEXPRESS; database = Kali_University; integrated security = true")
    Private Sub goback_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Hide()
        data_grid.Show()
    End Sub
End Class