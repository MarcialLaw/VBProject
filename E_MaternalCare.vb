Imports MySql.Data.MySqlClient

Public Class E_Maternal_Care
    Dim Conn As New LogModule

    Private Sub E_Maternal_Care_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pddID.Text = Me.pddID.Text
    End Sub

    Private Sub BtnSaveMaternal_Click(sender As Object, e As EventArgs) Handles BtnSaveMaternal.Click
        Dim M_age As String = TextBoxM_Age.Text
        Dim Pregnancy As String = TboxPregnancy.Text
        Dim chilbirth As String = TBoxChilBirth.Text
        Dim Child As String = TBoxChildren.Text
        Dim M_weight As String = TextBoxWeight.Text

        Dim Maternity_cmd As New MySqlCommand(
            "INSERT INTO `mcare_tble`(`PDD_id`,`age`, `num_pregnancy`, `num_chilbirth`, `num_child`, `weight`) 
            VALUES (@pdd_id,@m_age,@m_pregnancy,@m_cbirth,@m_child,@m_weight)", Conn.getConnection)

        Maternity_cmd.Parameters.Add("@pdd_id", MySqlDbType.VarChar).Value = pddID.Text
        Maternity_cmd.Parameters.Add("@m_age", MySqlDbType.VarChar).Value = TextBoxM_Age.Text
        Maternity_cmd.Parameters.Add("@m_pregnancy", MySqlDbType.VarChar).Value = TboxPregnancy.Text
        Maternity_cmd.Parameters.Add("@m_cbirth", MySqlDbType.VarChar).Value = TBoxChilBirth.Text
        Maternity_cmd.Parameters.Add("@m_child", MySqlDbType.VarChar).Value = TBoxChildren.Text
        Maternity_cmd.Parameters.Add("@m_weight", MySqlDbType.VarChar).Value = TextBoxWeight.Text

        Conn.Open()
        If Maternity_cmd.ExecuteNonQuery() = 1 Then
            MsgBox("PATIENT MATERNITY STATUS ADDED")
            Conn.Close()

            TextBoxM_Age.Clear()
            TboxPregnancy.Clear()
            TBoxChilBirth.Clear()
            TBoxChildren.Clear()
            TextBoxWeight.Clear()

            Me.Hide()
        Else
            MessageBox.Show("PATIENT COVID-19 VACCINATION NOT STATUS ADDED")
            Conn.Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()


    End Sub

End Class