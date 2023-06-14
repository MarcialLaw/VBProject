Imports System.IO
Imports MySql.Data.MySqlClient

Public Class E_PDDForm
    Dim Conn As New LogModule

    Private Sub E_PDDForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SC_ID_textBox.Hide()
        SC_ID_label.Hide()
        PWD_ID_textBox.Hide()
        TBoxType_Disability.Hide()
        TBoxSince_When.Hide()
        PWD_ID_label.Hide()
        PWD_Disability_Lbl.Hide()
        PWD_Since_Lbl.Hide()

    End Sub

    Private Sub BtnSavePDD_Click(sender As Object, e As EventArgs) Handles BtnSavePDD.Click

        Dim last_name As String = TxtBoxLN.Text
        Dim first_name As String = TxtBoxFN.Text
        Dim middle_name As String = TxtBoxMN.Text
        Dim suffix As String = TxtBoxSN.Text
        Dim sex As String = ComboGender.Text
        Dim date_of_birth As String = Format$(DTPickerDOB.Value.Date, "yyyy-MM-dd")
        Dim age As String = TextBoxAge.Text
        Dim place_of_birth As String = TextBoxPlace.Text
        Dim civil_stat As String = ComboCivilStat.Text
        Dim education_stat As String = ComboEduStat.Text
        Dim employ As String = TxtBox_EStatus.Text
        Dim tax As String = TxtBoxTax_No.Text
        Dim religion As String = Combo_Religion.Text
        Dim street_name As String = TxtBoxStreet.Text
        Dim zip_code As String = TxtBoxZcode.Text
        Dim number As String = TxtBoxPhoneNum.Text
        Dim father_name As String = TextBoxFather.Text
        Dim mother_name As String = TextBoxMother.Text
        Dim height As String = TextBoxHeight.Text
        Dim weight As String = TextBoxWeight.Text
        Dim med_history As String = TxtBoxMed.Text
        Dim physician As String = TxtBoxPhysician.Text
        Dim senior_citizen As Boolean = SC_Checkbox.Checked
        Dim pwd As Boolean = PWD_Checkbox.Checked
        Dim sc_id As String = SC_ID_textBox.Text
        Dim pwd_id As String = PWD_ID_textBox.Text
        Dim Type_Disability As String = TBoxType_Disability.Text
        Dim Since_When As String = TBoxSince_When.Text
        Dim filepath As String = RTBoxFilePath.Text
        Dim Date_Consult As String = Format$(DTPick_Consult.Value.Date, "yyyy-MM-dd")
        Dim Systolic As String = TxtBox_Systolic.Text
        Dim diastolic As String = TxtBox_Diastolic.Text
        Dim Oxy As String = TxtBox_Oxygen.Text
        Dim temperature As String = TxtBox_Temp.Text
        Dim complaint As String = RTBox_Complaint.Text
        Dim name As String = TxtBox_onDuty.Text



        If last_name.Trim() = "" Or first_name.Trim() = "" Or middle_name.Trim() = "" Or sex.Trim() = "" Or date_of_birth.Trim() = "" Or place_of_birth.Trim() = "" Or mother_name.Trim() = "" Or education_stat.Trim() = "" Or street_name.Trim() = "" Or zip_code.Trim() = "" Then
            MsgBox("Please fill in the empty fields.")

        Else

            Dim command As New MySqlCommand(
                "INSERT INTO `pdd_tble`(`last_name`, `first_name`, `middle_name`, `suffix`, `sex`, `date_of_birth`, `civil_stat`, `education_stat`, `employ`, `tax`, `religion`, `street_name`, `med_history`, `physician`, `zip_code`, `number`, `age`, `place_of_birth`, `father_name`, `mother_name`, `height`, `weight`, `FilePath`, `isDeceased`,`isDeleted`)
                VALUES(@lname,@fname,@mname,@suf,@sex,@dob,@cs,@es,@empl,@taxes,@rel,@st,@mu,@sb,@zip,@num,@age,@place,@dad,@mom,@height,@weight,@file,0,0)", Conn.getConnection)

            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = last_name
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = first_name
            command.Parameters.Add("@mname", MySqlDbType.VarChar).Value = middle_name
            command.Parameters.Add("@suf", MySqlDbType.VarChar).Value = suffix
            command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = sex
            command.Parameters.Add("@dob", MySqlDbType.VarChar).Value = date_of_birth
            command.Parameters.Add("@cs", MySqlDbType.VarChar).Value = civil_stat
            command.Parameters.Add("@es", MySqlDbType.VarChar).Value = education_stat
            command.Parameters.Add("@empl", MySqlDbType.VarChar).Value = employ
            command.Parameters.Add("@taxes", MySqlDbType.VarChar).Value = tax
            command.Parameters.Add("@rel", MySqlDbType.VarChar).Value = religion
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = street_name
            command.Parameters.Add("@mu", MySqlDbType.VarChar).Value = med_history
            command.Parameters.Add("@sb", MySqlDbType.VarChar).Value = physician
            command.Parameters.Add("@zip", MySqlDbType.VarChar).Value = zip_code
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = number
            command.Parameters.Add("@age", MySqlDbType.VarChar).Value = age
            command.Parameters.Add("@place", MySqlDbType.VarChar).Value = place_of_birth
            command.Parameters.Add("@dad", MySqlDbType.VarChar).Value = father_name
            command.Parameters.Add("@mom", MySqlDbType.VarChar).Value = mother_name
            command.Parameters.Add("@height", MySqlDbType.VarChar).Value = height
            command.Parameters.Add("@weight", MySqlDbType.VarChar).Value = weight
            command.Parameters.Add("@file", MySqlDbType.VarChar).Value = filepath

            Conn.Open()
            If command.ExecuteNonQuery() = 1 Then
                Conn.Close()

                If CheckBoxConsult.Checked = True Then
                    Conn.Open()
                    Dim Consult_lastId As Integer
                    Dim sel_Cons_lastID As String = "SELECT MAX(PDD_id) FROM pdd_tble WHERE isDeleted = 0"
                    Dim cmd As New MySqlCommand(sel_Cons_lastID, Conn.getConnection)
                    cmd.CommandType = CommandType.Text
                    Consult_lastId = cmd.ExecuteScalar()
                    Conn.Close()


                    Dim cons_cmd As New MySqlCommand("INSERT INTO `referral_tble`(`PDD_id`, `systolic`, `diastolic`, `oxygen`, `temperature`, `complaint`, `midwife_name`, `date_of_referral`) VALUES (@pdd_id,@sys,@dias,@oxy,@temp,@com,@nam,@dref)", Conn.getConnection)
                    cons_cmd.Parameters.Add("@pdd_id", MySqlDbType.VarChar).Value = Consult_lastId
                    cons_cmd.Parameters.Add("@sys", MySqlDbType.VarChar).Value = Systolic
                    cons_cmd.Parameters.Add("@dias", MySqlDbType.VarChar).Value = diastolic
                    cons_cmd.Parameters.Add("@oxy", MySqlDbType.VarChar).Value = Oxy
                    cons_cmd.Parameters.Add("@temp", MySqlDbType.VarChar).Value = temperature
                    cons_cmd.Parameters.Add("@com", MySqlDbType.VarChar).Value = complaint
                    cons_cmd.Parameters.Add("@nam", MySqlDbType.VarChar).Value = name
                    cons_cmd.Parameters.Add("@dref", MySqlDbType.VarChar).Value = Date_Consult

                    Conn.Open()
                    If cons_cmd.ExecuteNonQuery() = 1 Then
                        Conn.Close()
                    End If
                End If

                If PWD_Checkbox.Checked = True Then
                    Conn.Open()
                    Dim pwd_lastId As Integer
                    Dim sel_pwd_lastID As String = "SELECT MAX(PDD_id) FROM pdd_tble WHERE isDeleted = 0"
                    Dim cmd As New MySqlCommand(sel_pwd_lastID, Conn.getConnection)
                    cmd.CommandType = CommandType.Text
                    pwd_lastId = cmd.ExecuteScalar()
                    Conn.Close()


                    Dim pwd_cmd As New MySqlCommand("INSERT INTO `pwd_tble`(`PDD_id`, `PWD_ID_number`, `PWD_age`, `Type_Disability`, `Since_When`) VALUES(@pdd_id, @pwd_id, @pwd_age ,@type ,@when)", Conn.getConnection)
                    pwd_cmd.Parameters.Add("@pdd_id", MySqlDbType.VarChar).Value = pwd_lastId
                    pwd_cmd.Parameters.Add("@pwd_id", MySqlDbType.VarChar).Value = pwd_id
                    pwd_cmd.Parameters.Add("@pwd_age", MySqlDbType.VarChar).Value = age
                    pwd_cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = Type_Disability
                    pwd_cmd.Parameters.Add("@when", MySqlDbType.VarChar).Value = Since_When

                    Conn.Open()
                    If pwd_cmd.ExecuteNonQuery() = 1 Then
                        Conn.Close()
                    End If
                End If

                If SC_Checkbox.Checked = True Then
                    Conn.Open()
                    Dim sc_lastId As Integer
                    Dim sel_sc_lastID As String = "SELECT MAX(PDD_id) FROM pdd_tble WHERE isDeleted = 0"
                    Dim cmd As New MySqlCommand(sel_sc_lastID, Conn.getConnection)
                    cmd.CommandType = CommandType.Text
                    sc_lastId = cmd.ExecuteScalar()
                    Conn.Close()

                    Dim sc_cmd As New MySqlCommand("INSERT INTO `sc_tble`(`PDD_id`, `ID_number`, `Senior_Age`) VALUES(@pdd_id, @sc_id, @sc_age)", Conn.getConnection)
                    sc_cmd.Parameters.Add("@pdd_id", MySqlDbType.VarChar).Value = sc_lastId
                    sc_cmd.Parameters.Add("@sc_id", MySqlDbType.VarChar).Value = sc_id
                    sc_cmd.Parameters.Add("@sc_age", MySqlDbType.VarChar).Value = age

                    Conn.Open()
                    If sc_cmd.ExecuteNonQuery() = 1 Then
                        MsgBox("NEW PATIENT ADDED")
                        Conn.Close()

                    End If
                Else
                    MsgBox("NEW PATIENT ADDED")
                    MainPage.Show()
                End If
            End If
        End If
    End Sub

    Private Sub clearAllTextBoxes()
        Dim formControl As Control
        Dim txtBox As TextBox
        For Each formControl In Me.Controls
            If TypeOf formControl Is TextBox Then
                txtBox = TryCast(formControl, TextBox)
                txtBox.Clear()
            End If
        Next
    End Sub

    Private Sub SC_Checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles SC_Checkbox.CheckedChanged
        If SC_Checkbox.Checked = True Then
            SC_ID_textBox.Visible = True
            SC_ID_label.Visible = True
        Else
            SC_ID_textBox.Visible = False
            SC_ID_label.Visible = False
        End If

    End Sub

    Private Sub PWD_Checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles PWD_Checkbox.CheckedChanged
        If PWD_Checkbox.Checked = True Then
            PWD_ID_label.Visible = True
            PWD_Disability_Lbl.Visible = True
            PWD_Since_Lbl.Visible = True
            PWD_ID_textBox.Visible = True
            TBoxType_Disability.Visible = True
            TBoxSince_When.Visible = True
        Else
            PWD_ID_label.Visible = False
            PWD_Disability_Lbl.Visible = False
            PWD_Since_Lbl.Visible = False
            PWD_ID_textBox.Visible = False
            TBoxType_Disability.Visible = False
            TBoxSince_When.Visible = False
        End If
    End Sub

    Private Sub CheckBoxConsult_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxConsult.CheckedChanged
        If CheckBoxConsult.Checked = True Then
            CheckBoxConsult.Visible = True
            DTPick_Consult.Visible = True
            TxtBox_Systolic.Visible = True
            TxtBox_Diastolic.Visible = True
            TxtBox_Oxygen.Visible = True
            TxtBox_Temp.Visible = True
            RTBox_Complaint.Visible = True
            TxtBox_onDuty.Visible = True
        End If
    End Sub

    Private Sub DTPickerDOB_ValueChanged(sender As Object, e As EventArgs) Handles DTPickerDOB.ValueChanged
        Dim date_of_birth As String = Format$(DTPickerDOB.Value.Date, "yyyy-MM-dd")

        Dim bday As Date, target As Date
        Dim numMo As Integer, numYrs As Integer, numDays As Integer
        Dim tmpDate As Date

        bday = DTPickerDOB.Value
        target = Date.Now
        If target <= bday Then
            MsgBox("Invalid date")
            Exit Sub
        End If

        numYrs = DateDiff("yyyy", bday, target)
        tmpDate = DateAdd("yyyy", numYrs, bday)

        If tmpDate > target Then
            numYrs = numYrs - 1
            tmpDate = DateAdd("yyyy", -1, tmpDate)
        End If

        numMo = DateDiff("m", tmpDate, target)
        tmpDate = DateAdd("m", numMo, tmpDate)

        If tmpDate > target Then
            numMo = numMo - 1
            tmpDate = DateAdd("m", -1, tmpDate)
        End If

        numDays = DateDiff("d", tmpDate, target)

        TextBoxAge.Text = numYrs

        If numYrs >= 60 Then
            SC_Checkbox.Checked = True
        Else
            SC_Checkbox.Checked = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenFile As New OpenFileDialog
        OpenFile.Filter = "Choose Image(*.jpg;*.png;*.gif;*.pdf) | *.jpg;*.png;*.gif;*.pdf"
        If (OpenFile.ShowDialog() = DialogResult.OK) Then
            PicBoxImage.Image = Image.FromFile(OpenFile.FileName)
            RTBoxFilePath.Text = OpenFile.FileName.ToString()
        End If
    End Sub

    Private Sub UpdateCancel_Click(sender As Object, e As EventArgs) Handles UpdateCancel.Click
        TxtBoxPDDId.Clear()
        TxtBoxLN.Clear()
        TxtBoxFN.Clear()
        TxtBoxMN.Clear()
        TxtBoxSN.Clear()
        TextBoxAge.Clear()
        TextBoxPlace.Clear()
        TextBoxFather.Clear()
        TextBoxMother.Clear()
        TextBoxHeight.Clear()
        TextBoxWeight.Clear()
        TxtBoxStreet.Clear()
        TxtBoxZcode.Clear()
        TxtBox_EStatus.Clear()
        TxtBoxPhoneNum.Clear()
        TxtBoxMed.Clear()
        TxtBoxPhysician.Clear()
        SC_Checkbox.Checked = False
        PWD_Checkbox.Checked = False
        SC_ID_textBox.Clear()
        PWD_ID_textBox.Clear()
        RTBoxFilePath.Clear()
        TxtBox_Systolic.Clear()
        TxtBox_Diastolic.Clear()
        TxtBoxZcode.Clear()
        TxtBox_Oxygen.Clear()
        TxtBox_Temp.Clear()
        RTBox_Complaint.Clear()
        TxtBox_onDuty.Clear()
        PicBoxImage.Image = Nothing
        ComboCivilStat.Text = String.Empty
        ComboGender.Text = String.Empty
        ComboEduStat.Text = String.Empty
        Combo_Religion.Text = String.Empty
        Me.Hide()
        MainPage.Show()
    End Sub

    Private Sub Btn_OpenCam_Click(sender As Object, e As EventArgs) Handles Btn_OpenCam.Click
        CaptureImage.Show()
    End Sub

    Private Sub Button_refer_Click(sender As Object, e As EventArgs) Handles Button_refer.Click
        Dim report As New Referral_Report
        report.SetParameterValue("lname", TxtBoxLN.Text)
        report.SetParameterValue("fname", TxtBoxFN.Text)
        report.SetParameterValue("mname", TxtBoxMN.Text)
        report.SetParameterValue("suffix", TxtBoxSN.Text)
        report.SetParameterValue("bdate", DTPickerDOB.Text)
        report.SetParameterValue("age", TextBoxAge.Text)
        report.SetParameterValue("sexx", ComboGender.Text)
        report.SetParameterValue("height", TextBoxHeight.Text)
        report.SetParameterValue("weight", TextBoxWeight.Text)
        report.SetParameterValue("systo", TxtBox_Systolic.Text)
        report.SetParameterValue("dias", TxtBox_Diastolic.Text)
        report.SetParameterValue("spo", TxtBox_Oxygen.Text)
        report.SetParameterValue("temp", TxtBox_Temp.Text)
        report.SetParameterValue("chief", RTBox_Complaint.Text)
        report.SetParameterValue("consultdate", DTPick_Consult.Text)
        report.SetParameterValue("midwife", TxtBox_onDuty.Text)
        ReportReferral.CrystalReportViewer1.ReportSource = report
        ReportReferral.ShowDialog()
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        TxtBoxPDDId.Clear()
        TxtBoxLN.Clear()
        TxtBoxFN.Clear()
        TxtBoxMN.Clear()
        TxtBoxSN.Clear()
        TextBoxAge.Clear()
        TextBoxPlace.Clear()
        TextBoxFather.Clear()
        TextBoxMother.Clear()
        TextBoxHeight.Clear()
        TextBoxWeight.Clear()
        TxtBoxStreet.Clear()
        TxtBoxZcode.Clear()
        TxtBox_EStatus.Clear()
        TxtBoxPhoneNum.Clear()
        TxtBoxMed.Clear()
        TxtBoxPhysician.Clear()
        SC_Checkbox.Checked = False
        PWD_Checkbox.Checked = False
        SC_ID_textBox.Clear()
        PWD_ID_textBox.Clear()
        RTBoxFilePath.Clear()
        TxtBox_Systolic.Clear()
        TxtBox_Diastolic.Clear()
        TxtBoxZcode.Clear()
        TxtBox_Oxygen.Clear()
        TxtBox_Temp.Clear()
        RTBox_Complaint.Clear()
        TxtBox_onDuty.Clear()
        PicBoxImage.Image = Nothing
        ComboCivilStat.Text = String.Empty
        ComboGender.Text = String.Empty
        ComboEduStat.Text = String.Empty
        Combo_Religion.Text = String.Empty
        Me.Hide()
        MainPage.Show()
    End Sub

End Class