Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient

Public Class MainPage
    Dim Conn As New LogModule
    Dim adapter As MySqlDataAdapter
    Dim dt As DataTable
    Dim command As New MySqlCommand

    'fields
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildform As Form


    'Constructor

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)

    End Sub
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(204, 255, 229)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage


            'leftborderBtn
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()



        End If

    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(161, 224, 255)
            currentBtn.ForeColor = Color.MidnightBlue
            currentBtn.IconColor = Color.MidnightBlue
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If

    End Sub
    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        Dim uname As String = LoginForm.TextBox1.Text
        Dim password As String = LoginForm.TextBox2.Text


        Conn.Open()
        Dim user_lastId As Integer
        Dim sel_user_lastID As String = "SELECT id From user_tble Where username ='" & uname & "' and password = '" & password & "'"
        Dim cmd As New MySqlCommand(sel_user_lastID, Conn.getConnection)
        cmd.CommandType = CommandType.Text
        user_lastId = cmd.ExecuteScalar()
        Conn.Close()

        userID.Text = user_lastId

        Conn.Open()
        adapter = New MySqlDataAdapter("SELECT 
`pdd_view`, `pdd_update`, `immunization_view`,`nutrition_view`,`maternal_view`,`senior_view`,`pwd_view`,`refer_view`,`covax_view`,`death_view`,`reports_access`,`setting_access` FROM `fkaccess_tble` WHERE user_id = '" & user_lastId & "'", Conn.getConnection)
        dt = New DataTable
        dt.Clear()
        adapter.Fill(dt)

        If dt.Rows.Count() <= 0 Then
            MessageBox.Show("Account not available.")
            Conn.Close()
        Else
            For Each row As DataRow In dt.Rows
                btnPDD.Enabled = row("pdd_update")
                BtnIMM.Enabled = row("immunization_view")
                BtnMcare.Enabled = row("maternal_view")
                BtnSC.Enabled = row("senior_view")
                BtnPWD.Enabled = row("pwd_view")
                BtnNourish.Enabled = row("nutrition_view")
                BtnDRec.Enabled = row("death_view")
                BtnMed.Enabled = row("reports_access")
                BtnCoVax.Enabled = row("covax_view")
                SettingsBtn.Enabled = row("setting_access")
                BtnReferral.Enabled = row("refer_view")

            Next
            Conn.Close()
        End If

    End Sub

    Private Sub LabelTime_Click(sender As Object, e As EventArgs) Handles LabelTime.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelTime.Text = Date.Now.ToString("dd MMM yyyy hh:mm:ss")
    End Sub

    Private Sub OpenChildform(childform As Form)
        'Open only form
        If currentChildform IsNot Nothing Then
            currentChildform.Close()
        End If
        currentChildform = childform
        'end
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childform)
        PanelDesktop.Tag = childform
        childform.BringToFront()
        childform.Show()

    End Sub
    Private Sub btnPDD_Click(sender As Object, e As EventArgs) Handles btnPDD.Click
        ActivateButton(sender, classColor.Color1)
        OpenChildform(New L_PDDRecords)
    End Sub

    Private Sub BtnIMM_Click(sender As Object, e As EventArgs) Handles BtnIMM.Click
        ActivateButton(sender, classColor.Color2)
        OpenChildform(New V_ChildImmunization)
    End Sub

    Private Sub BtnMcare_Click(sender As Object, e As EventArgs) Handles BtnMcare.Click
        ActivateButton(sender, classColor.Color2)
        OpenChildform(New V_Maternity_Record)
    End Sub

    Private Sub BtnSC_Click(sender As Object, e As EventArgs) Handles BtnSC.Click
        ActivateButton(sender, classColor.Color3)
        OpenChildform(New V_SeniorCitizenRecords)
    End Sub

    Private Sub BtnPWD_Click(sender As Object, e As EventArgs) Handles BtnPWD.Click
        ActivateButton(sender, classColor.Color4)
        OpenChildform(New V_PWDRecords)
    End Sub

    Private Sub BtnNourish_Click(sender As Object, e As EventArgs) Handles BtnNourish.Click
        ActivateButton(sender, classColor.Color5)
        OpenChildform(New V_ChildNourishment)
    End Sub

    Private Sub BtnDRec_Click(sender As Object, e As EventArgs) Handles BtnDRec.Click
        ActivateButton(sender, classColor.Color6)
        OpenChildform(New V_DeathRecord)
    End Sub

    Private Sub BtnMed_Click(sender As Object, e As EventArgs) Handles BtnMed.Click
        ActivateButton(sender, classColor.Color2)
        OpenChildform(New L_Reports)
    End Sub

    Private Sub BtnReferral_Click(sender As Object, e As EventArgs) Handles BtnReferral.Click
        ActivateButton(sender, classColor.Color2)
        OpenChildform(New V_ReferralList)
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If currentChildform IsNot Nothing Then
            currentChildform.Close()
        End If
    End Sub

    Private Sub IconBtnLogout_Click_1(sender As Object, e As EventArgs) Handles IconBtnLogout.Click
        ActivateButton(sender, classColor.Color6)
        Me.Hide()
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub BtnCoVax_Click(sender As Object, e As EventArgs) Handles BtnCoVax.Click
        ActivateButton(sender, classColor.Color7)
        OpenChildform(New V_Covid19_Vax)
    End Sub

    Private Sub SettingsBtn_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click
        ActivateButton(sender, classColor.Color6)
        OpenChildform(New L_Setting)
    End Sub
End Class