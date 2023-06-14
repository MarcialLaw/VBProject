Imports MySql.Data.MySqlClient
Public Class H_CovidVax
    Dim connect As New MySqlConnection("server=127.0.0.1; username=root; password=; database=sample_vb;")
    Private Sub H_CovidVax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBoxPDDId.Text = Me.Tag

        Dim str As String
        str = "SELECT pdd.PDD_id, pdd.last_name, pdd.first_name, pdd.middle_name, pdd.date_of_birth, pdd.age, pdd.sex, pdd.FilePath, Vax.vaccineType, Vax.vaccineName, Vax.vaccinationDate, Vax.patientNotes FROM pdd_tble AS pdd INNER JOIN vax_tble As Vax ON pdd.PDD_id = Vax.PDD_id WHERE pdd.PDD_id = '" & Me.Tag & "' AND pdd.isDeceased = 0 AND pdd.isDeleted = 0;"

        Try
            connect.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(str, connect)
            Dim reader = cmd.ExecuteReader

            While reader.Read()
                TextBoxLast.Text = reader.Item("last_name")
                TextBoxFirst.Text = reader.Item("first_name")
                TextBoxMiddle.Text = reader.Item("middle_name")
                DTPicker_DOB.Value = reader.Item("date_of_birth")
                TextBoxAge.Text = reader.Item("age")
                TextBoxSex.Text = reader.Item("sex")
                TextBox_VaxName.Text = reader.Item("vaccineName")
                TextBox_Weight.Text = reader.Item("patientNotes")
                DTPicker_Date.Value = reader.Item("vaccinationDate")
                TextBoxVaccine.Text = reader.Item("vaccineType")
                TextBox_FilePath.Text = reader.Item("FilePath")

                If reader.Item("FilePath") <> "" Then
                    Dim img As Image = Image.FromFile(reader.Item("FilePath"))
                    PBox_Pic.Image = img.Clone
                    PBox_Pic.Refresh()
                    img.Dispose()
                Else
                    PBox_Pic.Image = Nothing

                End If
            End While
            reader.Close()
            connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Ok_Click(sender As Object, e As EventArgs) Handles Btn_Ok.Click
        Me.Hide()
    End Sub
End Class