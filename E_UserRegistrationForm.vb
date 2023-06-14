Imports MySql.Data.MySqlClient
Public Class E_UserRegistrationForm
    Dim connection As New LogModule
    Private Sub RegForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Dim fullname As String = TextBoxFN.Text
        Dim position As String = ComboPo.Text
        Dim username As String = TextBoxUsername.Text
        Dim password As String = TextBoxPass.Text

        If fullname.Trim() = "" Or position.Trim() = "" Or username.Trim() = "" Or password.Trim() = "" Then

            MsgBox("EMPTY FIELDS")

        ElseIf Not username >= username Then
            MsgBox("USERNAME ALREADY EXIST!")

        Else
            Dim userCmd As New MySqlCommand("INSERT INTO `user_tble`( `fullname`, `position`, `username`, `password`) VALUES (@fn,@po ,@uname,@pass)", connection.getConnection)

            userCmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fullname
            userCmd.Parameters.Add("@po", MySqlDbType.VarChar).Value = position
            userCmd.Parameters.Add("@uname", MySqlDbType.VarChar).Value = username
            userCmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

            connection.Open()

            If userCmd.ExecuteNonQuery() = 1 Then
                connection.Close()

                connection.Open()
                Dim lastUser As String = "SELECT id FROM user_tble WHERE id= (SELECT MAX(id) FROM user_tble);"
                Dim user_lastId As Integer
                Dim lastUserCmd As New MySqlCommand(lastUser, connection.getConnection)
                lastUserCmd.CommandType = CommandType.Text
                user_lastId = lastUserCmd.ExecuteScalar()
                connection.Close()

                Dim accessCmd As New MySqlCommand("INSERT INTO `fkaccess_tble`(`user_id`, `pdd_view`, `pdd_entry`, `pdd_update`, `immunization_view`, `nutrition_view`, `maternal_view`, `senior_view`, `pwd_view`, `covax_view`, `refer_view`, `death_view`, `reports_access`, `setting_access`) VALUES (@id, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);", connection.getConnection)
                accessCmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = user_lastId

                connection.Open()
                If accessCmd.ExecuteNonQuery() = 1 Then
                    MsgBox("NEW USER ADDED")
                    connection.Close()
                Else
                    MsgBox("USER NOT ADDED")
                    connection.Close()
                End If

                Me.Hide()
            Else
                MsgBox("USER NOT ADDED")
                connection.Close()
            End If

        End If

    End Sub

    Public Function UsernameExist(ByVal username As String) As Boolean
        Dim connection As New LogModule()
        Dim dt As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `user_tble` WHERE `username` = @uname", connection.Open())

        command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = username

        adapter.SelectCommand = command
        adapter.Fill(dt)

        If dt.Rows.Count >= 0 Then

            Return True

        Else
            Return False

        End If


    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class