Imports MySql.Data.MySqlClient
Public Class H_Immunization
    Dim connect As New MySqlConnection("server=127.0.0.1; username=root; password=; database=sample_vb;")
    Private Sub H_Immunization_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtBoxPDDId.Text = Me.Tag

        Dim str As String
        str = "SELECT pdd.PDD_id, pdd.last_name, pdd.first_name, pdd.middle_name, pdd.date_of_birth, pdd.age, pdd.sex, pdd.father_name, pdd.mother_name, pdd.FilePath, Imm.imm_height, Imm.imm_weight, Imm.vaccine_type, Imm.date_vaccination FROM pdd_tble AS pdd INNER JOIN imm_tble As Imm ON pdd.PDD_id = Imm.PDD_id WHERE pdd.PDD_id = '" & Me.Tag & "' AND pdd.isDeceased = 0 AND pdd.isDeleted = 0 ORDER BY pdd.PDD_id DESC LIMIT 1;"

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
                TextBox_Height.Text = reader.Item("imm_height")
                TextBox_Weight.Text = reader.Item("imm_weight")
                TextBox_FatherName.Text = reader.Item("father_name")
                TextBox_MotherName.Text = reader.Item("mother_name")
                TextBox_FilePath.Text = reader.Item("FilePath")
                DTPicker_Date.Value = reader.Item("date_vaccination")
                TextBoxVaccine.Text = reader.Item("vaccine_type")


                If reader.Item("FilePath") <> "" Then
                    Dim img As Image = Image.FromFile(reader.Item("FilePath"))
                    PBox_ChildPic.Image = img.Clone
                    PBox_ChildPic.Refresh()
                    img.Dispose()
                Else
                    PBox_ChildPic.Image = Nothing

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