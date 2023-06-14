Imports MySql.Data.MySqlClient
Public Class LogModule
    Dim con As New MySqlConnection("server=127.0.0.1; username=root; password=; database=sample_vb")
    Dim command As New MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim dt As DataTable
    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return con
        End Get
    End Property

    Public Function Open() As MySqlConnection
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return con
    End Function

    Public Function Close()
        Try
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return con
    End Function
End Class
