Imports MySql.Data.MySqlClient

Public Class L_PDDRecords
    Dim Conn As New LogModule 'MySqlConnection("server=127.0.0.1; username=root; password=; database=sample_vb;")
    Dim adapter As MySqlDataAdapter
    Dim dt As DataTable
    Private Sub L_PDDRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Conn.Open()
        adapter = New MySqlDataAdapter("SELECT 
`pdd_view`, `pdd_update`, `pdd_entry` FROM `fkaccess_tble` WHERE user_id = '" & MainPage.userID.Text & "'", Conn.getConnection)
        dt = New DataTable
        dt.Clear()
        adapter.Fill(dt)

        If dt.Rows.Count() <= 0 Then
            MessageBox.Show("Account not available.")
            Conn.Close()
        Else
            For Each row As DataRow In dt.Rows
                IconAddRecord.Enabled = row("pdd_entry")
                IconView.Enabled = row("pdd_view")

            Next
            Conn.Close()
        End If

    End Sub
    Private Sub IconAddRecord_Click(sender As Object, e As EventArgs) Handles IconAddRecord.Click
        E_PDDForm.Show()
        MainPage.Hide()

    End Sub

    Private Sub IconView_Click(sender As Object, e As EventArgs) Handles IconView.Click
        V_PDDRecords.Show()
        MainPage.Hide()
    End Sub

    Private Sub BtnConsult_Click(sender As Object, e As EventArgs) Handles BtnConsult.Click
        V_PDDRECORDS_for_Consult.Show()
        MainPage.Hide()
    End Sub

End Class