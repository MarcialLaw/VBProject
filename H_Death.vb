Imports MySql.Data.MySqlClient
Public Class H_Death
    Dim connect As New MySqlConnection("server=127.0.0.1; username=root; password=; database=sample_vb;")
    Private Sub H_Death_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBoxPDDId.Text = Me.Tag

        Dim str As String
        str = "SELECT 
	        pdd.PDD_id, 
	        pdd.last_name, 
            pdd.first_name, 
            pdd.middle_name, 
            pdd.sex, 
            pdd.date_of_birth, 
            pdd.age, 
            pdd.religion,
            pdd.height,
            pdd.weight,
            pdd.FilePath,
            d.date_of_death,
            d.cause_of_death
        FROM pdd_tble AS pdd 
        INNER JOIN d_tble AS d 
        WHERE pdd.PDD_id =" & Me.Tag & ";"

        Try
            connect.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(str, connect)
            Dim reader = cmd.ExecuteReader

            While reader.Read()
                TxtBox_Lname.Text = reader.Item("last_name")
                TxtBox_Fname.Text = reader.Item("first_name")
                TxtBox_Mname.Text = reader.Item("middle_name")
                DTPicker_BDate.Value = reader.Item("date_of_birth")
                TxtBox_Age.Text = reader.Item("age")
                Combo_Sex.Text = reader.Item("sex")
                Combo_Religion.Text = reader.Item("religion")
                TxtBox_Height.Text = reader.Item("height")
                TxtBox_Weight.Text = reader.Item("weight")
                TextBox_FilePath.Text = reader.Item("FilePath")
                DT_Picker_dateOfDeath.Value = reader.Item("date_of_death")
                RTBox_Cause_ofDeath.Text = reader.Item("cause_of_death")


                If reader.Item("FilePath") <> "" Then
                    Dim img As Image = Image.FromFile(reader.Item("FilePath"))
                    PictureBox1.Image = img.Clone
                    PictureBox1.Refresh()
                    img.Dispose()
                Else
                    PictureBox1.Image = Nothing

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