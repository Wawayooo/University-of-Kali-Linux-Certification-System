Imports System.Data.SqlClient
Public Class course3
    Dim con As SqlConnection = New SqlConnection("Server = KEITH\SQLEXPRESS; database = Kali_University; integrated security = true")
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        enrolling_page.Show()
        hiddencode.Text = "okay"
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Dim query As String = "INSERT INTO user_table2 (firstname, middlename, lastname, gender, username, mail_acc, course, pic_path) VALUES (@firstname, @middlename, @lastname, @gender, @username, @mail_acc, @course, @pic_path)"
        Dim command As SqlCommand = New SqlCommand(query, con)
        command.Parameters.AddWithValue("firstname", enrolling_page.t1.Text)
        command.Parameters.AddWithValue("middlename", enrolling_page.t2.Text)
        command.Parameters.AddWithValue("lastname", enrolling_page.t3.Text)
        command.Parameters.AddWithValue("mail_acc", enrolling_page.email_textbox.Text)
        command.Parameters.AddWithValue("pic_path", enrolling_page.OpenFileDialog1.FileName)
        command.Parameters.AddWithValue("course", "WEB EXPLOITATION")
        command.Parameters.AddWithValue("username", login_form.TextBox1.Text)
        If enrolling_page.female_gen.Checked Then
            command.Parameters.AddWithValue("gender", "Female")
        ElseIf enrolling_page.male_gender.Checked Then
            command.Parameters.AddWithValue("gender", "Male")
        End If

        con.Open()

        If command.ExecuteNonQuery = 1 Then
            hiddencode.Text = "okay"
            greetings.Show()
            LinkLabel1.Hide()
        Else
            MsgBox("UNABLE TO ENROLL PLEASE TRY AGAIN")
        End If

        con.Close()

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

        data_grid.enlink2.Hide()
        data_grid.aboutLink.Hide()

        data_grid.Width = 1824
        Me.Close()
        data_grid.Show()
        Dim command As SqlCommand = New SqlCommand("SELECT pic_path from user_table2 where firstname = @firstname", con)
        command.Parameters.AddWithValue("firstname", enrolling_page.t1.Text)
        con.Open()

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            If reader.Read Then
                Dim file As String = reader("pic_path").ToString()
                data_grid.profile_pic.BackgroundImage = New Bitmap(file)
                data_grid.profile_pic.BackgroundImageLayout = BackgroundImageLayout.Stretch
            End If
        End If

        con.Close()

    End Sub

    Private Sub course3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        greetings.Hide()
        Me.CenterToScreen()
    End Sub
End Class