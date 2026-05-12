Imports System.Drawing
Imports System.Text.RegularExpressions ' Required for the Password Strength Meter

Public Class frmRegister

    ' Create a dynamic label for the password strength meter
    Dim lblPasswordStrength As New Label()

    ' ==========================================
    ' NEW: Timer for Smooth Fade-In Transition
    ' ==========================================
    Private WithEvents fadeTimer As New Timer()

    ' --- LOAD EVENT: Make the Form Full Screen ---
    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Make the Form Full Screen
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        ' --- NEW: Setup Fade Transition ---
        Me.Opacity = 0 ' Start completely invisible
        fadeTimer.Interval = 15 ' Speed of the fade (lower is faster)
        fadeTimer.Start()
        ' ----------------------------------

        ' 2. Ensure header buttons stay visible
        btnGoLogin.BringToFront()
        btnGoHome.BringToFront()

        ' 3. Setup Password Strength Label dynamically
        lblPasswordStrength.AutoSize = True
        lblPasswordStrength.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblPasswordStrength.Location = New Point(lblPass.Right + 15, lblPass.Top)
        lblPasswordStrength.Text = ""
        pnlCard.Controls.Add(lblPasswordStrength)
        lblPasswordStrength.BringToFront()

        ' 4. Populate ALL Cebu Cities and Municipalities
        cmbCity.Items.Clear()
        cmbCity.Items.AddRange(New Object() {
            "Alcantara", "Alcoy", "Alegria", "Aloguinsan", "Argao", "Asturias", "Badian",
            "Balamban", "Bantayan", "Barili", "Bogo City", "Boljoon", "Borbon", "Carcar City",
            "Carmen", "Catmon", "Cebu City", "Compostela", "Consolacion", "Cordova",
            "Daanbantayan", "Dalaguete", "Danao City", "Dumanjug", "Ginatilan",
            "Lapu-Lapu City", "Liloan", "Madridejos", "Malabuyoc", "Mandaue City",
            "Medellin", "Minglanilla", "Moalboal", "City of Naga", "Oslob", "Pilar",
            "Pinamungajan", "Poro", "Ronda", "Samboan", "San Fernando", "San Francisco",
            "San Remigio", "Santa Fe", "Santander", "Sibonga", "Sogod", "Tabogon",
            "Tabuelan", "Talisay City", "Toledo City", "Tuburan", "Tudela"
        })
    End Sub

    ' ==========================================
    ' NEW: Fade Timer Tick Event
    ' ==========================================
    Private Sub fadeTimer_Tick(sender As Object, e As EventArgs) Handles fadeTimer.Tick
        If Me.Opacity < 1.0 Then
            Me.Opacity += 0.05 ' Gradually increase visibility
        Else
            fadeTimer.Stop() ' Stop when fully visible
        End If
    End Sub

    ' --- RESIZE EVENT: Keep the Registration Card Dead Center ---
    Private Sub frmRegister_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' 1. Center the white card dynamically when the screen stretches
        If pnlCard IsNot Nothing Then
            pnlCard.Left = CInt((Me.Width - pnlCard.Width) / 2)
            pnlCard.Top = CInt((Me.Height - pnlCard.Height) / 2)
        End If

        ' 2. Lock Header Buttons to the far right corner
        If btnGoLogin IsNot Nothing AndAlso btnGoHome IsNot Nothing Then
            btnGoLogin.Location = New Point(Me.Width - btnGoLogin.Width - 20, 15)
            btnGoHome.Location = New Point(btnGoLogin.Left - btnGoHome.Width - 10, 15)
        End If
    End Sub

    ' ==========================================
    ' NEW: Modern Interactive Hover Effects
    ' ==========================================
    Private Sub btnRegister_MouseEnter(sender As Object, e As EventArgs) Handles btnRegister.MouseEnter
        btnRegister.BackColor = Color.FromArgb(51, 133, 255)
    End Sub

    Private Sub btnRegister_MouseLeave(sender As Object, e As EventArgs) Handles btnRegister.MouseLeave
        btnRegister.BackColor = Color.FromArgb(0, 82, 204)
    End Sub

    Private Sub HeaderButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnGoLogin.MouseEnter, btnGoHome.MouseEnter
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(240, 242, 245)
    End Sub

    Private Sub HeaderButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnGoLogin.MouseLeave, btnGoHome.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.White
    End Sub

    ' --- PASSWORD STRENGTH METER LOGIC ---
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        Dim pass As String = txtPassword.Text

        If pass.Length = 0 Then
            lblPasswordStrength.Text = ""
        ElseIf pass.Length < 6 Then
            lblPasswordStrength.Text = "(Weak - Too Short)"
            lblPasswordStrength.ForeColor = Color.Red
        ElseIf pass.Length >= 6 AndAlso Regex.IsMatch(pass, "[A-Z]") AndAlso Regex.IsMatch(pass, "[0-9]") AndAlso Regex.IsMatch(pass, "[^a-zA-Z0-9]") Then
            lblPasswordStrength.Text = "(Strong - Excellent!)"
            lblPasswordStrength.ForeColor = Color.Green
        ElseIf pass.Length >= 6 AndAlso (Regex.IsMatch(pass, "[A-Z]") Or Regex.IsMatch(pass, "[0-9]")) Then
            lblPasswordStrength.Text = "(Medium - Good)"
            lblPasswordStrength.ForeColor = Color.Orange
        Else
            lblPasswordStrength.Text = "(Weak - Add numbers or capitals)"
            lblPasswordStrength.ForeColor = Color.Red
        End If
    End Sub

    ' --- AUTO-GENERATE USERNAME FROM FIRST AND LAST NAME ---
    Private Sub NameFields_Leave(sender As Object, e As EventArgs) Handles txtFirstName.Leave, txtLastName.Leave
        ' Only generate when both fields have text
        If txtFirstName.Text.Trim() <> "" AndAlso txtLastName.Text.Trim() <> "" Then
            Dim randomNum As New Random()
            Dim baseName As String = txtFirstName.Text.Trim().ToLower().Replace(" ", "") & txtLastName.Text.Trim().ToLower().Replace(" ", "")
            txtUsername.Text = baseName & randomNum.Next(100, 999).ToString()
        ElseIf txtFirstName.Text.Trim() = "" AndAlso txtLastName.Text.Trim() = "" Then
            txtUsername.Clear()
        End If
    End Sub

    ' --- DEPENDENT DROPDOWN: Load Barangays based on City ---
    Private Sub cmbCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCity.SelectedIndexChanged
        cmbBarangay.Items.Clear()
        cmbBarangay.Text = ""

        Select Case cmbCity.SelectedItem.ToString()
            Case "Cebu City"
                cmbBarangay.Items.AddRange(New Object() {"Apas", "Banilad", "Capitol Site", "Guadalupe", "Lahug", "Mabolo", "Punta Princesa", "Talamban", "Tisa", "Labangon", "Inayawan"})
            Case "Lapu-Lapu City"
                cmbBarangay.Items.AddRange(New Object() {"Agus", "Babag", "Bankal", "Baring", "Basak", "Buaya", "Calawisan", "Canjulao", "Caw-oy", "Cawhagan", "Caubian", "Gun-ob", "Ibo", "Looc", "Mactan", "Maribago", "Marigondon", "Pajac", "Pajo", "Pangan-an", "Poblacion", "Punta Engaño", "Pusok", "Sabang", "San Vicente", "Santa Rosa", "Subabasbas", "Talima", "Tingo", "Tungasan"})
            Case "Mandaue City"
                cmbBarangay.Items.AddRange(New Object() {"Alang-alang", "Bakilid", "Banilad", "Basak", "Cabancalan", "Cambaro", "Canduman", "Casili", "Casuntingan", "Centro", "Cubacub", "Guizo", "Ibabao-Estancia", "Jagobiao", "Labogon", "Looc", "Maguikay", "Mantuyong", "Opao", "Pakna-an", "Pagsabungan", "Subangdaku", "Tabok", "Tawason", "Tingub", "Tipolo", "Umapad"})
            Case "Bogo City"
                cmbBarangay.Items.AddRange(New Object() {"Anonang Norte", "Anonang Sur", "Banban", "Binabag", "Bungtod", "Carbon", "Cayang", "Cogon", "Dakit", "Don Pedro Rodriguez", "Gairan", "Guadalupe", "La Paz", "Lourdes", "Malingin", "Marangog", "Nailon", "Odlot", "Pandan", "Polambato", "Sambag", "San Vicente", "Santo Niño", "Santo Rosario", "Sudlonon", "Taytayan"})
            Case "Carcar City"
                cmbBarangay.Items.AddRange(New Object() {"Bolinawan", "Buenavista", "Calidngan", "Can-asujan", "Guadalupe", "Liburon", "Napo", "Ocana", "Perrelos", "Poblacion I", "Poblacion II", "Poblacion III", "Tuyom", "Valencia", "Valladolid"})
            Case "Danao City"
                cmbBarangay.Items.AddRange(New Object() {"Baliang", "Bayabas", "Binaliw", "Cabungahan", "Cagat-Lapu", "Cambanay", "Cambubho", "Cogon-Cruz", "Danasan", "Dumolog", "Dunggoan", "Guinacot", "Guinsay", "Ibo", "Langosig", "Lawaan", "Looc", "Magtagobtob", "Malapoc", "Manlayag", "Mantija", "Masaba", "Maslog", "Nangka", "Oguis", "Pili", "Poblacion", "Quisol", "Sabang", "Sacsac", "Sandayong Norte", "Sandayong Sur", "Santa Rosa", "Santican", "Sibacan", "Suba", "Taboc", "Taytay", "Togonon", "Tuburan Sur"})
            Case "City of Naga"
                cmbBarangay.Items.AddRange(New Object() {"Tina-an", "Poblacion", "Inoburan", "Langtad", "Tuyan", "Bairan", "Naalad", "Cantao-an", "Inayagan", "Uling"})
            Case "Talisay City"
                cmbBarangay.Items.AddRange(New Object() {"Bulacao", "Tabunok", "Lawaan I", "Lawaan II", "Lawaan III", "San Roque", "Dumlog", "Poblacion", "Cansojong", "Mohon", "Pooc"})
            Case "Toledo City"
                cmbBarangay.Items.AddRange(New Object() {"Awihao", "Bagakay", "Bato", "Biga", "Bulongan", "Bunga", "Cabitoonan", "Calongcalong", "Cambang-ug", "Camp 8", "Canlumampao", "Cantabaco", "Capitan Claudio", "Carmen", "Daanglungsod", "Don Andres Soriano", "Dumlog", "Ibo", "Ilihan", "Landahan", "Looc", "Luray II", "Matab-ang", "Media Once", "Pangamihan", "Poblacion", "Poog", "Putingbato", "Sagay", "Sam-ang", "Sangi", "Santo Niño", "Subayon", "Talavera", "Tubod", "Tungkay"})

            Case "Alcantara"
                cmbBarangay.Items.AddRange(New Object() {"Cabadiangan", "Cabil-isan", "Candabong", "Lawaan", "Mangaco", "Palanas", "Poblacion", "Polo", "Salagmaya"})
            Case "Alcoy"
                cmbBarangay.Items.AddRange(New Object() {"Atabay", "Daan-Lungsod", "Guiwang", "Nug-as", "Pasol", "Poblacion", "Pugalo", "San Agustin"})
            Case "Alegria"
                cmbBarangay.Items.AddRange(New Object() {"Compostela", "Guadalupe", "Legaspi", "Lepanto", "Madridejos", "Montpeller", "Poblacion", "Santa Filomena", "Valencia"})
            Case "Aloguinsan"
                cmbBarangay.Items.AddRange(New Object() {"Angilan", "Bojo", "Bonbon", "Esperanza", "Kandingan", "Kantabogon", "Kawasan", "Olango", "Poblacion", "Punay", "Rosario", "Saksak", "Tampa-an", "Toyokan", "Zaragosa"})
            Case "Argao"
                cmbBarangay.Items.AddRange(New Object() {"Alambijud", "Anajao", "Apo", "Balaas", "Balisong", "Binlod", "Bogo", "Bug-ot", "Bulasa", "Butong", "Calagasan", "Campanay", "Canbantug", "Canbanua", "Cansuje", "Capio-an", "Casay", "Catang", "Colawin", "Conalum", "Guiwanon", "Gutlang", "Jampang", "Jomgao", "Lamacan", "Langtad", "Langub", "Lapay", "Lengigon", "Linut-od", "Mabasa", "Macaas", "Mompeller", "Panadtaran", "Poblacion", "Sua", "Sumaguan", "Tabayag", "Talaga", "Talaytay", "Talo-ot", "Tiguib", "Tulic", "Ubaub", "Usmad"})
            Case "Asturias"
                cmbBarangay.Items.AddRange(New Object() {"Agtugop", "Bago", "Bairan", "Banban", "Baye", "Bog-o", "Kalo-Kalo", "Lanao", "Langub", "Looc Norte", "Looc Sur", "Lunas", "Magcalape", "Manguiao", "New Bago", "Owak", "Poblacion", "Readaptation Center", "Rueda", "San Isidro", "San Jose", "San Roque", "Santa Lucia", "Santa Rita", "Tag-amakan", "Tubigagmanok", "Tubod"})
            Case "Badian"
                cmbBarangay.Items.AddRange(New Object() {"Alawijao", "Balhaan", "Banhigan", "Basak", "Basiao", "Bato", "Bugas", "Calangcang", "Candiis", "Dagatan", "Dobdob", "Ginablan", "Lambug", "Malhiao", "Malabago", "Manduyong", "Matutinao", "Patong", "Poblacion", "Sanlagan", "Santicon", "Sohoton", "Sulsugan", "Talayong", "Taytay", "Tigbao", "Tiguib", "Tubod", "Zaragosa"})
            Case "Balamban"
                cmbBarangay.Items.AddRange(New Object() {"Abucayan", "Aliwanay", "Arpili", "Balamaban", "Buanoy", "Cabagdalan", "Cabasiangan", "Cambuhawe", "Cansomoroy", "Cantibas", "Cantuod", "Duangan", "Gaas", "Hinulawan", "Lamesa", "Liki", "Luca", "Matun-og", "Nangka", "Pondol", "Prenza", "Singsing", "Sunog", "Vito"})
            Case "Bantayan"
                cmbBarangay.Items.AddRange(New Object() {"Atop-atop", "Baigad", "Baod", "Binaobao", "Botigues", "Kabac", "Doong", "Hilotongan", "Guiwanon", "Kangkaibe", "Lipayran", "Luyongbaybay", "Mojon", "Obo-ob", "Patao", "Putian", "Sillion", "Suba", "Sulangan", "Sungko", "Tamiao", "Ticad"})
            Case "Barili"
                cmbBarangay.Items.AddRange(New Object() {"Azucena", "Bagakay", "Balao", "Bolocboloc", "Budbud", "Bugtong Kawayan", "Cabcaban", "Campangga", "Candugay", "Dakit", "Giloctog", "Guibuangan", "Giwanon", "Gunting", "Hilasgasan", "Japitan", "Luhod", "Lupo", "Luyo", "Maghanay", "Mantayupan", "Mayana", "Minolos", "Nabunturan", "Nasipit", "Pancil", "Pangpang", "Paril", "Patupat", "Poblacion", "San Rafael", "Santa Ana", "Sayaw", "Tal-ot", "Tubod", "Vito"})
            Case "Boljoon"
                cmbBarangay.Items.AddRange(New Object() {"Arbor", "Baclayan", "El Pardo", "Granada", "Lower Becerril", "Lunop", "Nangka", "Poblacion", "San Antonio", "South Granada", "Upper Becerril"})
            Case "Borbon"
                cmbBarangay.Items.AddRange(New Object() {"Bagacay", "Bili", "Bingay", "Bongdo", "Bongdo Gua", "Bonguyan", "Bunjawan", "Cadaruhan", "Cajel", "Campusong", "Clavera", "Don Gregorio Antigua", "Laaw", "Lugo", "Managase", "Mateo", "Panalipan", "Poblacion", "Sagay", "San Jose", "Tabunan", "Tagnucan"})
            Case "Carmen"
                cmbBarangay.Items.AddRange(New Object() {"Baring", "Cantipay", "Cantumog", "Cantukong", "Caurasan", "Corte", "Dawis Norte", "Dawis Sur", "Hagnaya", "Ipil", "Lanipga", "Liburon", "Lower Natimao-an", "Luyang", "Panalipan", "Poblacion", "Puente", "Sac-on", "Triumfo", "Upper Natimao-an"})
            Case "Catmon"
                cmbBarangay.Items.AddRange(New Object() {"Agsuwao", "Amancion", "Anig-igan", "Basak", "Binongkalan", "Bonguyan", "Cabungaan", "Cambangkaya", "Can-ibuang", "Catmondaan", "Corazon", "Duyan", "Ginabucan", "Macaas", "Panalipan", "Tabili", "Tinabyonan"})
            Case "Compostela"
                cmbBarangay.Items.AddRange(New Object() {"Bagalnga", "Basak", "Buluang", "Cabadiangan", "Cambayog", "Canamucan", "Cogon", "Dapdap", "Estaca", "Lupa", "Magay", "Mulao", "Panangban", "Poblacion", "Tag-ube", "Tamiao", "Tubigan"})
            Case "Consolacion"
                cmbBarangay.Items.AddRange(New Object() {"Cabangahan", "Cansaga", "Casili", "Danglag", "Garing", "Jugan", "Lamac", "Lanipga", "Nangka", "Panas", "Panoypoy", "Pitogo", "Poblacion Occidental", "Poblacion Oriental", "Polog", "Pulpogan", "Sacsac", "Tayud", "Tolotolo", "Tugbongan"})
            Case "Cordova"
                cmbBarangay.Items.AddRange(New Object() {"Alegria", "Bangbang", "Buagsong", "Catarman", "Cogon", "Dapitan", "Day-as", "Gabi", "Gilutongan", "Ibabao", "Pilipog", "Poblacion", "San Miguel"})
            Case "Daanbantayan"
                cmbBarangay.Items.AddRange(New Object() {"Agujo", "Bagay", "Bakhawan", "Bateria", "Bitoon", "Calape", "Carnaza", "Dalingding", "Lanao", "Logon", "Malbago", "Malingin", "Maya", "Pajo", "Paypay", "Poblacion", "Tapilon", "Tinubdan", "Tominjao"})
            Case "Dalaguete"
                cmbBarangay.Items.AddRange(New Object() {"Abugon", "Babayongan", "Balud", "Banhigan", "Bulak", "Caleriohan", "Caliongan", "Casay", "Catolohan", "Cawayan", "Consolacion", "Coro", "Dugyan", "Dumalan", "Jaway", "Langkas", "Lomboy", "Malones", "Maloray", "Mananggal", "Manlapay", "Mantalongon", "Nalhub", "Obo", "Obong", "Panalian", "Poblacion", "Sacsac", "Salug", "Tabon", "Tapon", "Tubod"})
            Case "Dumanjug"
                cmbBarangay.Items.AddRange(New Object() {"Balaygtiki", "Bitoon", "Bulak", "Bullaan", "Calaboon", "Camboang", "Candabong", "Cogon", "Cotcoton", "Doldol", "Kabalaasnan", "Kabatbatan", "Kang-actol", "Kangalmac", "Kanghumaod", "Kangito", "Kanghalo", "Kolabtingon", "Lamac", "Lawaan", "Liong", "Litmon", "Looc", "Mabuhay", "Manlapay", "Masa", "Matalao", "Paculob", "Panlaan", "Pawa", "Poblacion", "Tangil", "Tapon", "Tubod-Bitoon", "Tubod-Dugoan"})
            Case "Ginatilan"
                cmbBarangay.Items.AddRange(New Object() {"Anao", "Cagsing", "Calabawan", "Cambalag", "Campisong", "Canhas", "Guiwanon", "Looc", "Malatbo", "Mangaco", "Palanas", "Poblacion", "Salamanca", "San Roque"})
            Case "Liloan"
                cmbBarangay.Items.AddRange(New Object() {"Cabadiangan", "Calero", "Catarman", "Cotcot", "Jubay", "Lataban", "Mulao", "Poblacion", "San Roque", "San Vicente", "Santa Cruz", "Tabla", "Tayud", "Yati"})
            Case "Madridejos"
                cmbBarangay.Items.AddRange(New Object() {"Bunakan", "Kangwayan", "Kaongkod", "Kodia", "Maalat", "Malbago", "Mancilang", "Pili", "Poblacion", "San Agustin", "Tabagak", "Tarong", "Tugas"})
            Case "Malabuyoc"
                cmbBarangay.Items.AddRange(New Object() {"Armeña", "Cerdeña", "Looc", "Lombo", "Mahanlud", "Mindanao", "Montañeza", "Poblacion I", "Poblacion II", "Salmeron", "Santo Niño", "Sorsogon", "Tolosa"})
            Case "Medellin"
                cmbBarangay.Items.AddRange(New Object() {"Antipolo", "Awihaw", "Caputatan Norte", "Caputatan Sur", "Curva", "Daanlungsod", "Dalingding Sur", "Dayhagon", "Gibitngil", "Kawit", "Lamintak Norte", "Lamintak Sur", "Luy-a", "Maharuhay", "Mahawak", "Panugnawan", "Poblacion", "Tindog"})
            Case "Minglanilla"
                cmbBarangay.Items.AddRange(New Object() {"Cadulawan", "Calajo-an", "Camp 7", "Camp 8", "Cuanos", "Guindaruhan", "Linao-Lipata", "Manduang", "Pakigne", "Poblacion Ward I", "Poblacion Ward II", "Poblacion Ward III", "Poblacion Ward IV", "Tubod", "Tulay", "Tunghaan", "Tungkil", "Tungkop", "Vito"})
            Case "Moalboal"
                cmbBarangay.Items.AddRange(New Object() {"Agmacap", "Bala", "Balabagon", "Bato", "Buguil", "Bugho", "Busay", "Lanao", "Poblacion East", "Poblacion West", "Saavedra", "Tomonoy", "Tuble", "Tunga"})
            Case "Oslob"
                cmbBarangay.Items.AddRange(New Object() {"Alo", "Bangcogon", "Bonbon", "Calumpang", "Canangaze", "Can-ukban", "Cansalo-ay", "Cawayan", "Daanlungsod", "Gawi", "Hagdan", "Lagunde", "Looc", "Luka", "Mainit", "Manlapay", "Nueva Caceres", "Poblacion", "Pungtod", "Tan-awan", "Tumalog"})
            Case "Pilar"
                cmbBarangay.Items.AddRange(New Object() {"Biasong", "Cawit", "Dapdap", "Esperanza", "Lanao", "Lower Poblacion", "Moabog", "Montserrat", "San Isidro", "San Juan", "Upper Poblacion", "Villahermosa"})
            Case "Pinamungajan"
                cmbBarangay.Items.AddRange(New Object() {"Anislag", "Anopog", "Binabag", "Buhingtubig", "Busay", "Butong", "Cabagdalan", "Camugao", "Duangan", "Guimbawian", "Lamac", "Lut-od", "Mangoto", "Opao", "Pandacan", "Poblacion", "Punod", "Rizal", "Sacsac", "Sambagon", "Sibago", "Tajao", "Tangub", "Tanibag", "Tupas", "Tutay"})
            Case "Poro"
                cmbBarangay.Items.AddRange(New Object() {"Adela", "Altavista", "Cagcagan", "Cansuje", "Daan Paz", "Eastern Poblacion", "Esperanza", "Libertad", "Mabini", "Mercedes", "Pagsa", "Paz", "Rizal", "San Jose", "Santa Rita", "Teguis", "Western Poblacion"})
            Case "Ronda"
                cmbBarangay.Items.AddRange(New Object() {"Butong", "Can-abuhon", "Canduling", "Cansalonoy", "Cansayang", "Ilaya", "Langin", "Libo-o", "Malalay", "Palanas", "Poblacion", "Santa Cruz", "Tupas", "Vive"})
            Case "Samboan"
                cmbBarangay.Items.AddRange(New Object() {"Basak", "Bonbon", "Bulangsuran", "Calatagan", "Cambigong", "Camburoy", "Canbantug", "Candugay", "Colase", "Dalahikan", "Jumangpas", "Monteverde", "Poblacion", "San Sebastian", "Tangbo"})
            Case "San Fernando"
                cmbBarangay.Items.AddRange(New Object() {"Balud", "Balungag", "Basak", "Bugho", "Cabatbatan", "Greenhills", "Ilaya", "Lantawan", "Liburon", "Magsico", "Panadtaran", "Pitalo", "Poblacion North", "Poblacion South", "San Isidro", "Sangat", "Tabionan", "Tañon", "Tinubdan", "Tonggo", "Tubod"})
            Case "San Francisco"
                cmbBarangay.Items.AddRange(New Object() {"Cabunga-an", "Campo", "Consuelo", "Esperanza", "Himensulan", "Montealegre", "Northern Poblacion", "San Isidro", "Santa Cruz", "Santiago", "Sonog", "Southern Poblacion", "Unidos", "Union", "Western Poblacion"})
            Case "San Remigio"
                cmbBarangay.Items.AddRange(New Object() {"Anapog", "Argawanon", "Bagtic", "Bancasan", "Batad", "Busogon", "Calambua", "Canagahan", "Dapdap", "Gawaygaway", "Hagnaya", "Kayam", "Kinawahan", "Lambusan", "Lawis", "Ligaya", "Looc", "Luyang", "Mabuhay", "Manooc", "Poblacion", "Punta", "Sabang", "San Miguel", "Tacup", "Tambongon", "To-ong"})
            Case "Santa Fe"
                cmbBarangay.Items.AddRange(New Object() {"Balidbid", "Hagdan", "Hilantagaan", "Kinatarkan", "Langub", "Maricaban", "Okoy", "Piongo", "Poblacion", "Pooc"})
            Case "Santander"
                cmbBarangay.Items.AddRange(New Object() {"Bunlan", "Cabutongan", "Candamiang", "Liloan", "Lipit", "Looc", "Pasil", "Poblacion", "Talisay"})
            Case "Sibonga"
                cmbBarangay.Items.AddRange(New Object() {"Abugon", "Bae", "Bagacay", "Bahay", "Banlot", "Basak", "Bato", "Caganggangan", "Campangga", "Candaguit", "Cantulae", "Dugoan", "Guimbang", "Lamacan", "Libo", "Lindogon", "Magcagong", "Manatad", "Mangyan", "Papan", "Poblacion", "Sabang", "Sayao", "Simala", "Tubod"})
            Case "Sogod"
                cmbBarangay.Items.AddRange(New Object() {"Ampongol", "Bagatayam", "Bagtic", "Bawo", "Bogo", "Cabalawan", "Cabangahan", "Calumboyan", "Dakit", "Damolog", "Ibabao", "Liki", "Lubo", "Macaas", "Mohon", "Nahus-an", "Pansoy", "Poblacion", "Tabunok", "Takay"})
            Case "Tabogon"
                cmbBarangay.Items.AddRange(New Object() {"Alang-alang", "Caduawan", "Kal-anan", "Camoboan", "Canaocanao", "Combado", "Daantabogon", "Ilihan", "Labangon", "Libjo", "Loong", "Mabuli", "Managase", "Manlagtang", "Maslog", "Muabog", "Pio", "Poblacion", "Salag", "Sambag", "San Isidro", "San Vicente", "Somosa", "Taba-ao", "Tapul"})
            Case "Tabuelan"
                cmbBarangay.Items.AddRange(New Object() {"Bongon", "Kanluhangon", "Kantubaon", "Dalid", "Mabunao", "Maravilla", "Olivo", "Poblacion", "Tabunok", "Tigbawan", "Villahermosa"})
            Case "Tuburan"
                cmbBarangay.Items.AddRange(New Object() {"Alegria", "Amatugan", "Antipolo", "Apalan", "Bagasawe", "Bakyawan", "Bangkito", "Bulwang", "Cabahi", "Caridad", "Carmelo", "Cogon", "Colonia", "Daan Lungsod", "Fortaliza", "Ga-ang", "Gimama-a", "Jagbuaya", "Kabangkalan", "Kalangahan", "Kamansi", "Kan-an", "Kan-anes", "Kañacao", "Kelaw-an", "Kansi", "Libo", "Lusong", "Macupa", "Mag-alwa", "Mag-antoy", "Mag-atubang", "Maghan-ay", "Mangga", "Marmol", "Molobolo", "Montealegre", "Putat", "San Juan", "Sandayong", "Santo Niño", "Sianga", "Sumon", "Tominjao", "Tomou-ong", "Tunacao"})
            Case "Tudela"
                cmbBarangay.Items.AddRange(New Object() {"Buenavista", "Calmante", "Daan Secante", "General", "McArthur", "Northern Poblacion", "Puertobello", "Santander", "Secante Bag-o", "Southern Poblacion", "Villahermosa"})
        End Select
    End Sub

    ' --- MAIN REGISTER BUTTON LOGIC ---
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        ' 1. Validation: Ensure all fields are filled
        If txtFirstName.Text.Trim() = "" Or txtLastName.Text.Trim() = "" Or txtPassword.Text = "" Or cmbCity.Text = "" Or cmbBarangay.Text = "" Or txtEmail.Text.Trim() = "" Then
            MsgBox("Please fill in all fields, including your email and location.", MsgBoxStyle.Exclamation, "Incomplete Form")
            Exit Sub
        End If

        ' 2. Validation: Ensure passwords match
        If txtPassword.Text <> txtConfirm.Text Then
            MsgBox("Your passwords do not match!", MsgBoxStyle.Exclamation, "Password Error")
            Exit Sub
        End If

        ' 3. Validation: ENFORCE PASSWORD STRENGTH
        If lblPasswordStrength.Text.Contains("Weak") Then
            MsgBox("Your password is too weak! Please add numbers, capital letters, or make it longer.", MsgBoxStyle.Exclamation, "Security Warning")
            txtPassword.Focus()
            Exit Sub
        End If

        ' 4. Validation: CHECK IF EMAIL IS ALREADY USED
        If AuthManager.IsEmailTaken(txtEmail.Text.Trim()) Then
            MsgBox("This email is already registered! Please use a different email or sign in.", MsgBoxStyle.Exclamation, "Email Taken")
            Exit Sub
        End If

        ' ERP Data Formatting: Combine First and Last Name for the DB
        Dim combinedFullName As String = txtFirstName.Text.Trim() & " " & txtLastName.Text.Trim()

        ' 5. Generate a 6-digit OTP
        Dim rand As New Random()
        Dim generatedOTP As String = rand.Next(100000, 999999).ToString()

        ' 6. Send the OTP Email using your RegistrationManager class
        Dim emailSent As Boolean = RegistrationManager.SendOTPEmail(txtEmail.Text.Trim(), combinedFullName, generatedOTP)

        ' Stop if the email failed to send
        If Not emailSent Then
            Exit Sub
        End If

        ' 7. Prompt the user to enter the OTP via an InputBox
        Dim promptMessage As String = "An OTP has been sent to " & txtEmail.Text.Trim() & "." & vbCrLf & vbCrLf & "Please enter the 6-digit OTP below:"
        Dim userInputOTP As String = InputBox(promptMessage, "OTP Verification")

        ' 8. Verify the OTP
        If userInputOTP = generatedOTP Then
            Dim selectedRole As String = "Worker"
            If rbEmployer.Checked Then
                selectedRole = "Employer"
            End If

            ' Call AuthManager to save to MySQL (using the combined FullName so we don't break the DB schema)
            Dim success As Boolean = AuthManager.RegisterUser(
                combinedFullName, txtUsername.Text.Trim(), txtPassword.Text,
                selectedRole, txtEmail.Text.Trim(), cmbCity.Text, cmbBarangay.Text)

            If success Then
                MsgBox("Account created successfully! Welcome to TrabahoLocal.", MsgBoxStyle.Information, "Registration Success")
                Dim login As New frmLogin()
                login.Show()
                Me.Close()
            End If
        ElseIf userInputOTP = "" Then
            MsgBox("Registration cancelled.", MsgBoxStyle.Exclamation, "Cancelled")
        Else
            MsgBox("Invalid OTP! Registration failed. Please try again.", MsgBoxStyle.Critical, "Verification Failed")
        End If
    End Sub

    ' --- NAVIGATION BUTTONS ---
    Private Sub btnGoLogin_Click(sender As Object, e As EventArgs) Handles btnGoLogin.Click
        Dim login As New frmLogin()
        login.Show()
        Me.Hide()
    End Sub

    Private Sub btnGoHome_Click(sender As Object, e As EventArgs) Handles btnGoHome.Click
        Dim home As New frmHome()
        home.Show()
        Me.Hide()
    End Sub

End Class
