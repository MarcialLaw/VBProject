<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.userID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconBtnLogout = New FontAwesome.Sharp.IconButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.BtnCoVax = New FontAwesome.Sharp.IconButton()
        Me.SettingsBtn = New FontAwesome.Sharp.IconButton()
        Me.BtnReferral = New FontAwesome.Sharp.IconButton()
        Me.BtnMed = New FontAwesome.Sharp.IconButton()
        Me.BtnDRec = New FontAwesome.Sharp.IconButton()
        Me.BtnNourish = New FontAwesome.Sharp.IconButton()
        Me.BtnPWD = New FontAwesome.Sharp.IconButton()
        Me.BtnSC = New FontAwesome.Sharp.IconButton()
        Me.BtnMcare = New FontAwesome.Sharp.IconButton()
        Me.BtnIMM = New FontAwesome.Sharp.IconButton()
        Me.btnPDD = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelDesktop
        '
        Me.PanelDesktop.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDesktop.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PanelDesktop.Controls.Add(Me.PictureBox2)
        Me.PanelDesktop.Controls.Add(Me.Label5)
        Me.PanelDesktop.Controls.Add(Me.Label4)
        Me.PanelDesktop.Controls.Add(Me.Label3)
        Me.PanelDesktop.Controls.Add(Me.Label6)
        Me.PanelDesktop.Controls.Add(Me.Label7)
        Me.PanelDesktop.Location = New System.Drawing.Point(245, 130)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(879, 487)
        Me.PanelDesktop.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(239, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(372, 245)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label5.Location = New System.Drawing.Point(302, 434)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(240, 43)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "CAMARINES SUR"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label4.Location = New System.Drawing.Point(240, 393)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(357, 43)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "MUNICIPALITY OF TIGAON"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 54.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label3.Location = New System.Drawing.Point(191, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(471, 91)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "HEALTH CENTER"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 54.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label6.Location = New System.Drawing.Point(84, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(680, 91)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "BARANGAY SAN RAFAEL"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(349, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel2.Controls.Add(Me.userID)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(245, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(879, 131)
        Me.Panel2.TabIndex = 2
        '
        'userID
        '
        Me.userID.Location = New System.Drawing.Point(67, 84)
        Me.userID.Name = "userID"
        Me.userID.ReadOnly = True
        Me.userID.Size = New System.Drawing.Size(100, 20)
        Me.userID.TabIndex = 2
        Me.userID.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(526, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MANAGEMENT SYSTEM"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(84, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(447, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "E-BARANGAY HEALTHCARE RECORD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconBtnLogout
        '
        Me.IconBtnLogout.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.IconBtnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconBtnLogout.FlatAppearance.BorderSize = 0
        Me.IconBtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconBtnLogout.ForeColor = System.Drawing.Color.MidnightBlue
        Me.IconBtnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOut
        Me.IconBtnLogout.IconColor = System.Drawing.Color.MidnightBlue
        Me.IconBtnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconBtnLogout.IconSize = 30
        Me.IconBtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconBtnLogout.Location = New System.Drawing.Point(3, 584)
        Me.IconBtnLogout.Name = "IconBtnLogout"
        Me.IconBtnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconBtnLogout.Size = New System.Drawing.Size(240, 34)
        Me.IconBtnLogout.TabIndex = 10
        Me.IconBtnLogout.Text = "LOGOUT"
        Me.IconBtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconBtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconBtnLogout.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTime.ForeColor = System.Drawing.Color.Transparent
        Me.LabelTime.Location = New System.Drawing.Point(65, 107)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(107, 15)
        Me.LabelTime.TabIndex = 0
        Me.LabelTime.Text = "DATE and TIME"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(54, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 102)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.BtnCoVax)
        Me.PanelMenu.Controls.Add(Me.SettingsBtn)
        Me.PanelMenu.Controls.Add(Me.IconBtnLogout)
        Me.PanelMenu.Controls.Add(Me.BtnReferral)
        Me.PanelMenu.Controls.Add(Me.BtnMed)
        Me.PanelMenu.Controls.Add(Me.BtnDRec)
        Me.PanelMenu.Controls.Add(Me.BtnNourish)
        Me.PanelMenu.Controls.Add(Me.BtnPWD)
        Me.PanelMenu.Controls.Add(Me.BtnSC)
        Me.PanelMenu.Controls.Add(Me.BtnMcare)
        Me.PanelMenu.Controls.Add(Me.BtnIMM)
        Me.PanelMenu.Controls.Add(Me.btnPDD)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Location = New System.Drawing.Point(1, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(248, 614)
        Me.PanelMenu.TabIndex = 3
        '
        'BtnCoVax
        '
        Me.BtnCoVax.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCoVax.FlatAppearance.BorderSize = 0
        Me.BtnCoVax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCoVax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCoVax.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BtnCoVax.IconChar = FontAwesome.Sharp.IconChar.PersonBreastfeeding
        Me.BtnCoVax.IconColor = System.Drawing.Color.MidnightBlue
        Me.BtnCoVax.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnCoVax.IconSize = 32
        Me.BtnCoVax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCoVax.Location = New System.Drawing.Point(3, 369)
        Me.BtnCoVax.Name = "BtnCoVax"
        Me.BtnCoVax.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnCoVax.Size = New System.Drawing.Size(238, 39)
        Me.BtnCoVax.TabIndex = 12
        Me.BtnCoVax.Text = "COVID-19 VACCINATION"
        Me.BtnCoVax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCoVax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCoVax.UseVisualStyleBackColor = False
        '
        'SettingsBtn
        '
        Me.SettingsBtn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SettingsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SettingsBtn.FlatAppearance.BorderSize = 0
        Me.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsBtn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.SettingsBtn.IconChar = FontAwesome.Sharp.IconChar.Wrench
        Me.SettingsBtn.IconColor = System.Drawing.Color.MidnightBlue
        Me.SettingsBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SettingsBtn.IconSize = 30
        Me.SettingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SettingsBtn.Location = New System.Drawing.Point(5, 544)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.SettingsBtn.Size = New System.Drawing.Size(240, 34)
        Me.SettingsBtn.TabIndex = 11
        Me.SettingsBtn.Text = "SETTINGS"
        Me.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SettingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SettingsBtn.UseVisualStyleBackColor = False
        '
        'BtnReferral
        '
        Me.BtnReferral.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnReferral.FlatAppearance.BorderSize = 0
        Me.BtnReferral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReferral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReferral.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BtnReferral.IconChar = FontAwesome.Sharp.IconChar.FileMedical
        Me.BtnReferral.IconColor = System.Drawing.Color.MidnightBlue
        Me.BtnReferral.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnReferral.IconSize = 32
        Me.BtnReferral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReferral.Location = New System.Drawing.Point(5, 412)
        Me.BtnReferral.Name = "BtnReferral"
        Me.BtnReferral.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnReferral.Size = New System.Drawing.Size(240, 40)
        Me.BtnReferral.TabIndex = 9
        Me.BtnReferral.Text = "PATIENT REFERRAL"
        Me.BtnReferral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReferral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnReferral.UseVisualStyleBackColor = False
        '
        'BtnMed
        '
        Me.BtnMed.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnMed.FlatAppearance.BorderSize = 0
        Me.BtnMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMed.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BtnMed.IconChar = FontAwesome.Sharp.IconChar.FolderPlus
        Me.BtnMed.IconColor = System.Drawing.Color.MidnightBlue
        Me.BtnMed.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnMed.IconSize = 32
        Me.BtnMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMed.Location = New System.Drawing.Point(4, 499)
        Me.BtnMed.Name = "BtnMed"
        Me.BtnMed.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnMed.Size = New System.Drawing.Size(236, 39)
        Me.BtnMed.TabIndex = 8
        Me.BtnMed.Text = "REPORTS"
        Me.BtnMed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnMed.UseVisualStyleBackColor = False
        '
        'BtnDRec
        '
        Me.BtnDRec.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDRec.FlatAppearance.BorderSize = 0
        Me.BtnDRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDRec.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BtnDRec.IconChar = FontAwesome.Sharp.IconChar.Stamp
        Me.BtnDRec.IconColor = System.Drawing.Color.MidnightBlue
        Me.BtnDRec.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnDRec.IconSize = 32
        Me.BtnDRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDRec.Location = New System.Drawing.Point(4, 458)
        Me.BtnDRec.Name = "BtnDRec"
        Me.BtnDRec.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnDRec.Size = New System.Drawing.Size(241, 36)
        Me.BtnDRec.TabIndex = 7
        Me.BtnDRec.Text = "DEATH RECORD"
        Me.BtnDRec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDRec.UseVisualStyleBackColor = False
        '
        'BtnNourish
        '
        Me.BtnNourish.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnNourish.FlatAppearance.BorderSize = 0
        Me.BtnNourish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNourish.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNourish.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BtnNourish.IconChar = FontAwesome.Sharp.IconChar.PersonBreastfeeding
        Me.BtnNourish.IconColor = System.Drawing.Color.MidnightBlue
        Me.BtnNourish.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnNourish.IconSize = 32
        Me.BtnNourish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNourish.Location = New System.Drawing.Point(3, 332)
        Me.BtnNourish.Name = "BtnNourish"
        Me.BtnNourish.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnNourish.Size = New System.Drawing.Size(238, 39)
        Me.BtnNourish.TabIndex = 6
        Me.BtnNourish.Text = "CHILD NOURISHMENT"
        Me.BtnNourish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNourish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNourish.UseVisualStyleBackColor = False
        '
        'BtnPWD
        '
        Me.BtnPWD.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPWD.FlatAppearance.BorderSize = 0
        Me.BtnPWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPWD.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BtnPWD.IconChar = FontAwesome.Sharp.IconChar.Wheelchair
        Me.BtnPWD.IconColor = System.Drawing.Color.MidnightBlue
        Me.BtnPWD.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnPWD.IconSize = 32
        Me.BtnPWD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPWD.Location = New System.Drawing.Point(3, 295)
        Me.BtnPWD.Name = "BtnPWD"
        Me.BtnPWD.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnPWD.Size = New System.Drawing.Size(242, 32)
        Me.BtnPWD.TabIndex = 5
        Me.BtnPWD.Text = "PWD'S"
        Me.BtnPWD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPWD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPWD.UseVisualStyleBackColor = False
        '
        'BtnSC
        '
        Me.BtnSC.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSC.FlatAppearance.BorderSize = 0
        Me.BtnSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSC.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BtnSC.IconChar = FontAwesome.Sharp.IconChar.PersonCane
        Me.BtnSC.IconColor = System.Drawing.Color.MidnightBlue
        Me.BtnSC.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSC.IconSize = 32
        Me.BtnSC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSC.Location = New System.Drawing.Point(3, 259)
        Me.BtnSC.Name = "BtnSC"
        Me.BtnSC.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnSC.Size = New System.Drawing.Size(242, 32)
        Me.BtnSC.TabIndex = 4
        Me.BtnSC.Text = "SENIOR CITIZEN"
        Me.BtnSC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSC.UseVisualStyleBackColor = False
        '
        'BtnMcare
        '
        Me.BtnMcare.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnMcare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMcare.FlatAppearance.BorderSize = 0
        Me.BtnMcare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMcare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMcare.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BtnMcare.IconChar = FontAwesome.Sharp.IconChar.PersonPregnant
        Me.BtnMcare.IconColor = System.Drawing.Color.MidnightBlue
        Me.BtnMcare.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnMcare.IconSize = 32
        Me.BtnMcare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMcare.Location = New System.Drawing.Point(1, 221)
        Me.BtnMcare.Name = "BtnMcare"
        Me.BtnMcare.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnMcare.Size = New System.Drawing.Size(244, 32)
        Me.BtnMcare.TabIndex = 3
        Me.BtnMcare.Text = "MATERNAL CARE"
        Me.BtnMcare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMcare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnMcare.UseVisualStyleBackColor = False
        '
        'BtnIMM
        '
        Me.BtnIMM.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnIMM.FlatAppearance.BorderSize = 0
        Me.BtnIMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIMM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIMM.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BtnIMM.IconChar = FontAwesome.Sharp.IconChar.Syringe
        Me.BtnIMM.IconColor = System.Drawing.Color.MidnightBlue
        Me.BtnIMM.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnIMM.IconSize = 32
        Me.BtnIMM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIMM.Location = New System.Drawing.Point(3, 184)
        Me.BtnIMM.Name = "BtnIMM"
        Me.BtnIMM.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnIMM.Size = New System.Drawing.Size(238, 34)
        Me.BtnIMM.TabIndex = 2
        Me.BtnIMM.Text = "CHILD IMMUNIZATION"
        Me.BtnIMM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIMM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnIMM.UseVisualStyleBackColor = False
        '
        'btnPDD
        '
        Me.btnPDD.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPDD.FlatAppearance.BorderSize = 0
        Me.btnPDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPDD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPDD.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnPDD.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus
        Me.btnPDD.IconColor = System.Drawing.Color.MidnightBlue
        Me.btnPDD.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPDD.IconSize = 32
        Me.btnPDD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPDD.Location = New System.Drawing.Point(8, 136)
        Me.btnPDD.Name = "btnPDD"
        Me.btnPDD.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnPDD.Size = New System.Drawing.Size(237, 54)
        Me.btnPDD.TabIndex = 0
        Me.btnPDD.Text = "PATIENT DEMOGRAPHIC DATA"
        Me.btnPDD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPDD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPDD.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.LabelTime)
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(248, 130)
        Me.PanelLogo.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 615)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainPage"
        Me.Text = "MainPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelTime As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents btnPDD As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnDRec As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnNourish As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnPWD As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnSC As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnMcare As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnIMM As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnReferral As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnMed As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents IconBtnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents SettingsBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnCoVax As FontAwesome.Sharp.IconButton
    Friend WithEvents userID As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
