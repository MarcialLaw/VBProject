Imports MySql.Data.MySqlClient
Imports System.IO
Public Class E_MedicalInstrumentForm
    Dim Instro As New MySqlConnection("server=127.0.0.1; username=root; password=; database=sample_vb;")

    Sub InstruView()
        Try
            Dim Instrument As MySqlDataAdapter = New MySqlDataAdapter()
            Instrument.SelectCommand = New MySqlCommand("SELECT * FROM `med_instrument` WHERE INS_ID,i_name,i_description,i_distribute,i_quantity", Instro)
            Dim dset As DataSet = New DataSet()
            Instrument.Fill(dset)
            Dim row As DataRow
            For Each row In dset.Tables(0).Rows
                DataGridViewINS.Rows.Add(row("INS_ID").ToString(), row("i_name").ToString(), row("i_description").ToString(), row("i_distribute").ToString(), row("i_quantity").ToString(), File.ReadAllBytes(row("i_name").ToString()))

            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub InstrumentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnUpload_Click(sender As Object, e As EventArgs) Handles BtnUpload.Click
        Dim OpenFile As New OpenFileDialog
        OpenFile.Filter = "Choose Image(*.jpg;*.png;*.gif;*.pdf) | *.jpg;*.png;*.gif;*.pdf"
        If (OpenFile.ShowDialog() = DialogResult.OK) Then
            PboxImage.Image = Image.FromFile(OpenFile.FileName)
            RichTextBoxLocation.Text = OpenFile.FileName.ToString()
        End If


    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try

            Dim Instrument As MySqlDataAdapter = New MySqlDataAdapter()
            Instrument.SelectCommand = New MySqlCommand("INSERT INTO `med_instrument` (`i_name`, `i_description`, `i_distribute`, `i_quantity`) Values('" + TxtBoxInsID.Text + "','" + TextBoxName.Text + "','" + RichTextBoxDesc.Text + "','" + DTPickerDistribute.Value.Date + "','" + TextBoxQuantity.Text + "')", Instro)
            Instro.Open()
            Dim x = Instrument.InsertCommand.ExecuteNonQuery()
            If (x) Then
                MessageBox.Show("Save Successfully", "message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Data Not Save", "message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
            Instro.Close()
            DataGridViewINS.Rows.Clear()
            TxtBoxInsID.Clear()
            TextBoxName.Clear()
            RichTextBoxDesc.Clear()
            TextBoxQuantity.Clear()
            RichTextBoxLocation.Clear()

        Catch ex As Exception

        End Try
    End Sub
End Class