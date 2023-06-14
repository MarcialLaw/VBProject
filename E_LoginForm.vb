Imports MySql.Data.MySqlClient
Public Class LoginForm

    Dim connection As New LogModule
    Dim adapter As MySqlDataAdapter
    Dim dt As DataTable
    Dim command As New MySqlCommand
    Private Sub BtnLogIn_Click(sender As Object, e As EventArgs) Handles BtnLogIn.Click
        adapter = New MySqlDataAdapter("Select * From user_tble Where username ='" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'", connection.Open)
        dt = New DataTable
        dt.Clear()
        adapter.Fill(dt)

        If dt.Rows.Count() <= 0 Then
            MessageBox.Show("Invalid Username and Password")
            connection.Close()
        Else
            connection.Close()
            MessageBox.Show("Welcome " & TextBox1.Text & " to E-BHERMS!")
            Me.Hide()
            MainPage.Show()
            TextBox1.Clear()
            TextBox2.Clear()
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogIn_Cancel_Click(sender As Object, e As EventArgs) Handles BtnLogIn_Cancel.Click
        Application.Exit()

    End Sub
End Class
