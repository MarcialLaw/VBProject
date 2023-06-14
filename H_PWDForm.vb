Imports MySql.Data.MySqlClient
Imports System.IO
Public Class H_PWDForm
    Dim connect As New MySqlConnection("server=127.0.0.1; username=root; password=; database=sample_vb;")
    Private Sub H_PWDForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBoxPDDId.Text = Me.Tag

        Dim str As String
        str = "SELECT pdd.PDD_id, pdd.last_name, pdd.first_name, pdd.middle_name, pdd.suffix, pdd.age, pdd.sex, pdd.date_of_birth, pdd.religion, pdd.height, pdd.weight, pdd.FilePath, pdd.med_history, pdd.physician, PWD.PWD_ID_number, PWD.PWD_age, PWD.Type_Disability, PWD.Since_When FROM pdd_tble AS pdd INNER JOIN pwd_tble AS PWD WHERE pdd.PDD_id =" & Me.Tag & ";" 'PWD.PDD_id AND pdd.isDeceased = 0 AND pdd.isDeleted = 0 WHERE `PDD_id`=" & Me.Tag & ";"

        Try
            connect.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(str, connect)
            Dim reader = cmd.ExecuteReader

            While reader.Read()
                TxtBox_Lname.Text = reader.Item("last_name")
                TxtBox_Fname.Text = reader.Item("first_name")
                TxtBox_Mname.Text = reader.Item("middle_name")
                TxtBox_Suffix.Text = reader.Item("suffix")
                DTPicker_BDate.Value = reader.Item("date_of_birth")
                TxtBox_Age.Text = reader.Item("age")
                Combo_Sex.Text = reader.Item("sex")
                Combo_Religion.Text = reader.Item("religion")
                TxtBox_Height.Text = reader.Item("height")
                TxtBox_Weight.Text = reader.Item("weight")
                TextBox_FilePath.Text = reader.Item("FilePath")
                RTBox_MedHisotory.Text = reader.Item("med_history")
                TxtBox_Physician.Text = reader.Item("physician")
                TextBox_PWD_ID.Text = reader.Item("PWD_ID_number")
                TextBox_Type.Text = reader.Item("Type_Disability")
                TextBox_When.Text = reader.Item("Since_When")


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

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_Ok.Click
        Me.Hide()
    End Sub
End Class


