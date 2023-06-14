Imports MySql.Data.MySqlClient
Public Class E_PatientReferralForm
    Dim Conn As New LogModule

    Private Sub E_PatientReferralForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pddID.Text = Me.pddID.Text

    End Sub
    Private Sub BtnSenSave_Click(sender As Object, e As EventArgs) Handles BtnSenSave.Click

        Dim B_Pressure As String = TextBoxBPresure.Text
        Dim Complain As String = RichTextBoxComplain.Text
        Dim Midwife As String = TxtBoxMidwife.Text
        Dim Time_Ref As String = Format$(DTPickerTime_Ref.Value, "hh:mm tt")
        Dim Date_Ref As String = Format$(DTPickerDate_Ref.Value.Date, "yyyy-MM-dd")



        Dim Referral_cmd As New MySqlCommand(
            "INSERT INTO `referral_tble`(`PDD_id`, `blood_pressure`, `complain`, `midwife_name`, `date_of_referral`, `time_of_referral`) 
            VALUES (@pdd_id,@BP,@complain,@mw,@DOR,@TOR)", Conn.getConnection)

        Referral_cmd.Parameters.Add("@pdd_id", MySqlDbType.VarChar).Value = pddID.Text
        Referral_cmd.Parameters.Add("@BP", MySqlDbType.VarChar).Value = TextBoxBPresure.Text
        Referral_cmd.Parameters.Add("@complain", MySqlDbType.VarChar).Value = RichTextBoxComplain.Text
        Referral_cmd.Parameters.Add("@mw", MySqlDbType.VarChar).Value = TxtBoxMidwife.Text
        Referral_cmd.Parameters.Add("@TOR", MySqlDbType.VarChar).Value = Time_Ref
        Referral_cmd.Parameters.Add("@DOR", MySqlDbType.VarChar).Value = Date_Ref

        Conn.Open()
        If Referral_cmd.ExecuteNonQuery() = 1 Then
            MsgBox("PATIENT REFERRAL ADDED")
            Conn.Close()

            TextBoxBPresure.Clear()
            RichTextBoxComplain.Clear()
            TxtBoxMidwife.Clear()

            Me.Hide()
        Else
            MessageBox.Show("PATIENT COVID-19 VACCINATION NOT STATUS ADDED")
            Conn.Close()
        End If

    End Sub

    Private Sub DTPickerTime_ValueChanged(sender As Object, e As EventArgs) Handles DTPickerTime_Ref.ValueChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

End Class

