Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class frmEmployeerDashboard

    Private WithEvents fadeTimer As New Timer()

    ' --- LOAD EVENT ---
    Private Sub frmEmployeerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        Me.Opacity = 0
        fadeTimer.Interval = 15
        fadeTimer.Start()

        btnLogout.BringToFront()

        ' ==================================================
        ' ERP FIX: Load the Pay Types into the Dropdown!
        ' ==================================================
        cmbPayType.Items.Clear()
        cmbPayType.Items.AddRange(New String() {"Hourly", "Daily", "Fixed"})

        ' Load Cebu Cities
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

        ' Start on the Post Job Screen by Default
        btnViewPostJob.PerformClick()
    End Sub

    ' --- DEPENDENT DROPDOWN: Load Barangays based on City ---
    Private Sub cmbCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCity.SelectedIndexChanged
        ' --- THE FIX: Add this Guard ---
        If cmbCity.SelectedItem Is Nothing Then
            cmbBarangay.Items.Clear()
            Exit Sub
        End If
        ' -------------------------------

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

    Private Sub fadeTimer_Tick(sender As Object, e As EventArgs) Handles fadeTimer.Tick
        If Me.Opacity < 1.0 Then
            Me.Opacity += 0.05
        Else
            fadeTimer.Stop()
        End If
    End Sub

    ' --- RESIZE EVENT ---
    Private Sub frmEmployeerDashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If pnlCard IsNot Nothing Then
            pnlCard.Left = CInt((Me.Width - pnlCard.Width) / 2)
            pnlCard.Top = CInt((Me.Height - pnlCard.Height) / 2) + 40
        End If
        If btnLogout IsNot Nothing AndAlso pnlHeader IsNot Nothing Then
            btnLogout.Location = New Point(Me.Width - btnLogout.Width - 20, 15)
        End If
    End Sub

    ' --- ANALYTICS LOGIC ---
    Private Sub UpdateEmployerStats()
        Try
            openConn()

            ' 1. Calculate Total Spent
            Dim querySpent As String = "SELECT SUM(j.Salary) FROM tblApplications a " &
                                       "JOIN tbljobs j ON a.JobID = j.JobID " &
                                       "JOIN tblemployeers e ON j.EmployeerID = e.EmployeerID " &
                                       "WHERE e.UserID = @uid AND a.Status = 'Closed'"
            Dim cmdSpent As New MySqlCommand(querySpent, conn)
            cmdSpent.Parameters.AddWithValue("@uid", CurrentUserID)
            Dim totalSpent As Object = cmdSpent.ExecuteScalar()

            If totalSpent IsNot DBNull.Value AndAlso totalSpent IsNot Nothing Then
                lblTotalSpent.Text = "Total Spent: ₱" & String.Format("{0:N2}", totalSpent)
            Else
                lblTotalSpent.Text = "Total Spent: ₱0.00"
            End If

            ' 2. Calculate Active Hires
            Dim queryHires As String = "SELECT COUNT(*) FROM tblApplications a " &
                                       "JOIN tbljobs j ON a.JobID = j.JobID " &
                                       "JOIN tblemployeers e ON j.EmployeerID = e.EmployeerID " &
                                       "WHERE e.UserID = @uid AND a.Status = 'Accepted'"
            Dim cmdHires As New MySqlCommand(queryHires, conn)
            cmdHires.Parameters.AddWithValue("@uid", CurrentUserID)
            Dim activeHires As Object = cmdHires.ExecuteScalar()

            If activeHires IsNot DBNull.Value AndAlso activeHires IsNot Nothing Then
                lblActiveHires.Text = "Active Hires: " & activeHires.ToString()
            Else
                lblActiveHires.Text = "Active Hires: 0"
            End If
        Catch ex As Exception
        Finally
            closeConn()
        End Try
    End Sub

    ' --- DATABASE LOGIC: Load Applicants ---
    Private Sub LoadApplicants()
        Try
            openConn()
            Dim query As String = "SELECT a.ApplicationID, w.UserID AS 'WorkerUserID', j.JobTitle AS 'Applied For', w.FullName AS 'Applicant Name', " &
                                  "a.ApplicationDate AS 'Date', a.Status " &
                                  "FROM tblApplications a " &
                                  "JOIN tbljobs j ON a.JobID = j.JobID " &
                                  "JOIN tblworkers w ON a.WorkerID = w.WorkerID " &
                                  "JOIN tblemployeers e ON j.EmployeerID = e.EmployeerID " &
                                  "WHERE e.UserID = @uid " &
                                  "ORDER BY a.ApplicationDate DESC"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", CurrentUserID)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            dgvApplicants.DataSource = table

            If dgvApplicants.Columns.Contains("ApplicationID") Then dgvApplicants.Columns("ApplicationID").Visible = False
            If dgvApplicants.Columns.Contains("WorkerUserID") Then dgvApplicants.Columns("WorkerUserID").Visible = False

        Catch ex As Exception
            MsgBox("Error loading applicants: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
    End Sub

    ' --- ERP LOGIC: Smart Payroll Grid ---
    Private Sub LoadPayroll()
        Try
            openConn()

            ' FIX: Added j.PayType and dynamic IF statement for the Rate
            Dim query As String = "SELECT a.ApplicationID, w.FullName AS 'Worker Name', j.JobTitle AS 'Project', " &
                                  "j.PayType AS 'Type', " &
                                  "IF(j.PayType = 'Fixed', j.Salary, j.PayRate) AS 'Rate (₱)', " &
                                  "a.Status AS 'Job Status' " &
                                  "FROM tblApplications a " &
                                  "JOIN tbljobs j ON a.JobID = j.JobID " &
                                  "JOIN tblworkers w ON a.WorkerID = w.WorkerID " &
                                  "JOIN tblemployeers e ON j.EmployeerID = e.EmployeerID " &
                                  "WHERE e.UserID = @uid AND a.Status IN ('Accepted', 'Completed')"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", CurrentUserID)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            dgvPayroll.DataSource = table

            If dgvPayroll.Columns.Contains("ApplicationID") Then dgvPayroll.Columns("ApplicationID").Visible = False

        Catch ex As Exception
        Finally
            closeConn()
        End Try
    End Sub

    ' --- POST A NEW JOB LOGIC (WITH SECURITY GATE & DROPDOWNS) ---
    Private Sub btnPostJob_Click(sender As Object, e As EventArgs) Handles btnPostJob.Click
        ' SECURITY CHECK: Is Employer Verified?
        Try
            openConn()
            Dim cmdCheck As New MySqlCommand("SELECT IsVerified FROM tblemployeers WHERE UserID = @uid", conn)
            cmdCheck.Parameters.AddWithValue("@uid", CurrentUserID)
            Dim isVerified As Boolean = Convert.ToBoolean(If(IsDBNull(cmdCheck.ExecuteScalar()), False, cmdCheck.ExecuteScalar()))
            closeConn()

            If Not isVerified Then
                MsgBox("You must be Verified by an Admin before you can post jobs to the community. Please go to 'Edit Company Profile' to upload your Business ID.", MsgBoxStyle.Exclamation, "Verification Required")
                Exit Sub
            End If
        Catch ex As Exception
            closeConn()
            MsgBox("Verification Check Error: " & ex.Message)
            Exit Sub
        End Try

        ' ==================================================
        ' ERP FIX: Validate the new dropdown and ensure numeric input
        ' ==================================================
        If txtJobTitle.Text.Trim() = "" Or cmbCity.Text.Trim() = "" Or cmbBarangay.Text.Trim() = "" Or cmbPayType.Text.Trim() = "" Or txtDescription.Text.Trim() = "" Or txtSalary.Text.Trim() = "" Then
            MsgBox("Please fill in all fields (including Payment Structure) before posting.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Not IsNumeric(txtSalary.Text.Trim()) Then
            MsgBox("Please enter only numbers in the Rate Amount box.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' Combine the Location string automatically
        Dim fullLocation As String = cmbBarangay.Text & ", " & cmbCity.Text

        ' ERP FIX: Send the selected Pay Type (cmbPayType.Text) to JobManager
        Dim success As Boolean = JobManager.PostNewJob(CurrentUserID, txtJobTitle.Text, fullLocation, cmbPayType.Text, txtSalary.Text, txtDescription.Text)

        If success Then
            MsgBox("Job Opportunity successfully posted to the community!", MsgBoxStyle.Information, "Success")
            txtJobTitle.Clear()
            cmbCity.SelectedIndex = -1
            cmbBarangay.Items.Clear()
            cmbPayType.SelectedIndex = -1
            txtSalary.Clear()
            txtDescription.Clear()
        End If
    End Sub

    ' ==========================================
    ' TOP NAVIGATION SYSTEM (MODERN UI)
    ' ==========================================
    Private Sub ResetNavButtons()
        btnViewPostJob.ForeColor = Color.FromArgb(108, 117, 125)
        btnMyPosts.ForeColor = Color.FromArgb(108, 117, 125)
        btnViewApplicants.ForeColor = Color.FromArgb(108, 117, 125)
        btnViewPayroll.ForeColor = Color.FromArgb(108, 117, 125)
        btnMyProfile.ForeColor = Color.FromArgb(108, 117, 125)
        btnGlobalInbox.ForeColor = Color.FromArgb(108, 117, 125)

        btnViewPostJob.BackColor = Color.White
        btnMyPosts.BackColor = Color.White
        btnViewApplicants.BackColor = Color.White
        btnViewPayroll.BackColor = Color.White
        btnMyProfile.BackColor = Color.White
        btnGlobalInbox.BackColor = Color.White
    End Sub

    ' --- NAVIGATION: View "Post a Job" Screen ---
    Private Sub btnViewPostJob_Click(sender As Object, e As EventArgs) Handles btnViewPostJob.Click
        ResetNavButtons()
        btnViewPostJob.ForeColor = Color.FromArgb(0, 45, 70)
        btnViewPostJob.BackColor = Color.FromArgb(245, 246, 248)

        lblTitle.Text = "Post a New Job Opportunity"

        ' ERP FIX: Show the Dropdown elements
        lblJobTitle.Visible = True : txtJobTitle.Visible = True
        lblCity.Visible = True : cmbCity.Visible = True
        lblBarangay.Visible = True : cmbBarangay.Visible = True
        lblPayType.Visible = True : cmbPayType.Visible = True
        lblSalary.Visible = True : txtSalary.Visible = True
        lblDesc.Visible = True : txtDescription.Visible = True
        btnPostJob.Visible = True

        dgvApplicants.Visible = False : btnAccept.Visible = False : btnReject.Visible = False
        btnViewProfile.Visible = False : btnConfirmJobDone.Visible = False : btnRefreshApplicants.Visible = False
        btnChatWorker.Visible = False : dgvPayroll.Visible = False : btnPayWorker.Visible = False
        dgvMyPosts.Visible = False : btnCloseJob.Visible = False
        lblActiveHires.Visible = False : lblTotalSpent.Visible = False
    End Sub

    ' --- NAVIGATION: View "Applicants" Screen ---
    Private Sub btnViewApplicants_Click(sender As Object, e As EventArgs) Handles btnViewApplicants.Click
        ResetNavButtons()
        btnViewApplicants.ForeColor = Color.FromArgb(0, 45, 70)
        btnViewApplicants.BackColor = Color.FromArgb(245, 246, 248)

        lblTitle.Text = "Manage Applicants"

        ' ERP FIX: Hide the Dropdown elements
        lblJobTitle.Visible = False : txtJobTitle.Visible = False
        lblCity.Visible = False : cmbCity.Visible = False
        lblBarangay.Visible = False : cmbBarangay.Visible = False
        lblPayType.Visible = False : cmbPayType.Visible = False
        lblSalary.Visible = False : txtSalary.Visible = False
        lblDesc.Visible = False : txtDescription.Visible = False
        btnPostJob.Visible = False
        dgvPayroll.Visible = False : btnPayWorker.Visible = False
        dgvMyPosts.Visible = False : btnCloseJob.Visible = False

        dgvApplicants.Visible = True : dgvApplicants.BringToFront()
        btnAccept.Visible = True : btnReject.Visible = True : btnViewProfile.Visible = True
        btnConfirmJobDone.Visible = True : btnRefreshApplicants.Visible = True : btnChatWorker.Visible = True
        lblActiveHires.Visible = True : lblTotalSpent.Visible = True

        LoadApplicants()
        UpdateEmployerStats()
    End Sub

    ' --- NAVIGATION: View "Pending Payroll" Screen ---
    Private Sub btnViewPayroll_Click(sender As Object, e As EventArgs) Handles btnViewPayroll.Click
        ResetNavButtons()
        btnViewPayroll.ForeColor = Color.FromArgb(0, 45, 70)
        btnViewPayroll.BackColor = Color.FromArgb(245, 246, 248)

        lblTitle.Text = "Pending Payroll & Contracts"

        ' ERP FIX: Hide the Dropdown elements
        lblJobTitle.Visible = False : txtJobTitle.Visible = False
        lblCity.Visible = False : cmbCity.Visible = False
        lblBarangay.Visible = False : cmbBarangay.Visible = False
        lblPayType.Visible = False : cmbPayType.Visible = False
        lblSalary.Visible = False : txtSalary.Visible = False
        lblDesc.Visible = False : txtDescription.Visible = False
        btnPostJob.Visible = False

        dgvApplicants.Visible = False : btnAccept.Visible = False : btnReject.Visible = False
        btnViewProfile.Visible = False : btnConfirmJobDone.Visible = False : btnRefreshApplicants.Visible = False
        dgvMyPosts.Visible = False : btnCloseJob.Visible = False

        dgvPayroll.Visible = True : dgvPayroll.BringToFront()
        btnPayWorker.Visible = True : btnChatWorker.Visible = True
        lblActiveHires.Visible = True : lblTotalSpent.Visible = True

        LoadPayroll()
        UpdateEmployerStats()
    End Sub

    ' ==========================================
    ' NAVIGATION: View "My Posts" Screen
    ' ==========================================
    Private Sub btnMyPosts_Click(sender As Object, e As EventArgs) Handles btnMyPosts.Click
        ResetNavButtons()
        btnMyPosts.ForeColor = Color.FromArgb(0, 45, 70)
        btnMyPosts.BackColor = Color.FromArgb(245, 246, 248)

        lblTitle.Text = "My Active Job Postings"

        ' Hide other elements
        lblJobTitle.Visible = False : txtJobTitle.Visible = False
        lblCity.Visible = False : cmbCity.Visible = False
        lblBarangay.Visible = False : cmbBarangay.Visible = False
        lblPayType.Visible = False : cmbPayType.Visible = False
        lblSalary.Visible = False : txtSalary.Visible = False
        lblDesc.Visible = False : txtDescription.Visible = False
        btnPostJob.Visible = False

        dgvApplicants.Visible = False : btnAccept.Visible = False : btnReject.Visible = False
        btnViewProfile.Visible = False : btnConfirmJobDone.Visible = False : btnRefreshApplicants.Visible = False
        dgvPayroll.Visible = False : btnPayWorker.Visible = False : btnChatWorker.Visible = False

        ' Show My Posts elements
        dgvMyPosts.Visible = True : dgvMyPosts.BringToFront()
        btnCloseJob.Visible = True

        lblActiveHires.Visible = True : lblTotalSpent.Visible = True

        LoadMyPosts()
        UpdateEmployerStats()
    End Sub

    ' ==========================================
    ' DATABASE LOGIC: Load My Posts
    ' ==========================================
    Private Sub LoadMyPosts()
        Try
            openConn()
            Dim query As String = "SELECT JobID, JobTitle AS 'Job Role', Location, PayType AS 'Type', " &
                                  "IF(PayType='Fixed', Salary, PayRate) AS 'Rate (₱)', Status " &
                                  "FROM tbljobs " &
                                  "WHERE EmployeerID = (SELECT EmployeerID FROM tblemployeers WHERE UserID = @uid) " &
                                  "ORDER BY JobID DESC"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", CurrentUserID)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            dgvMyPosts.DataSource = table

            If dgvMyPosts.Columns.Contains("JobID") Then dgvMyPosts.Columns("JobID").Visible = False

        Catch ex As Exception
        Finally
            closeConn()
        End Try
    End Sub

    ' ==========================================
    ' ACTION: Close Job Posting
    ' ==========================================
    Private Sub btnCloseJob_Click(sender As Object, e As EventArgs) Handles btnCloseJob.Click
        If dgvMyPosts.SelectedRows.Count > 0 Then
            Dim currentStatus As String = dgvMyPosts.SelectedRows(0).Cells("Status").Value.ToString()

            If currentStatus = "Closed" Then
                MsgBox("This job posting is already closed.", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim jobID As Integer = Convert.ToInt32(dgvMyPosts.SelectedRows(0).Cells("JobID").Value)
            Dim jobTitle As String = dgvMyPosts.SelectedRows(0).Cells("Job Role").Value.ToString()

            Dim confirm As DialogResult = MsgBox("Are you sure you want to officially close the posting for: " & jobTitle & "? It will be removed from the public job board.", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Close Job Posting")

            If confirm = DialogResult.Yes Then
                Try
                    openConn()
                    Dim cmd As New MySqlCommand("UPDATE tbljobs SET Status = 'Closed' WHERE JobID = @id", conn)
                    cmd.Parameters.AddWithValue("@id", jobID)
                    cmd.ExecuteNonQuery()

                    MsgBox("Job posting closed successfully.", MsgBoxStyle.Information)
                    LoadMyPosts()
                Catch ex As Exception
                    MsgBox("Error closing job: " & ex.Message, MsgBoxStyle.Critical)
                Finally
                    closeConn()
                End Try
            End If
        Else
            MsgBox("Please select a job posting from the list first.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    ' ==========================================
    ' NEW FEATURE: OPEN MY EMPLOYER PROFILE
    ' ==========================================
    Private Sub btnMyProfile_Click(sender As Object, e As EventArgs) Handles btnMyProfile.Click
        Dim myProfile As New frmEmployeerProfile()
        myProfile.IsViewOnly = False
        myProfile.ShowDialog()
    End Sub

    ' ==========================================
    ' NAVIGATION: Open Global Inbox (Employer Side)
    ' ==========================================
    Private Sub btnGlobalInbox_Click(sender As Object, e As EventArgs) Handles btnGlobalInbox.Click
        ' Open the Inbox in "General View" (No specific chat pre-selected)
        Dim globalInbox As New frmInbox()
        globalInbox.ShowDialog()

        ' Refresh the notification bell when they close the inbox
        Dim unreadCount As Integer = NotificationManager.GetUnreadCount(CurrentUserID)
        If unreadCount > 0 Then
            btnNotifications.Text = "🔔 Alerts (" & unreadCount & ")"
            btnNotifications.ForeColor = Color.Yellow
        Else
            btnNotifications.Text = "🔔 Alerts"
            btnNotifications.ForeColor = Color.White
        End If
    End Sub

    ' ==========================================
    ' ACTION: Open Chat Inbox (Employer Side - Contextual)
    ' ==========================================
    Private Sub btnChatWorker_Click(sender As Object, e As EventArgs) Handles btnChatWorker.Click
        Dim selectedGrid As DataGridView = If(dgvPayroll.Visible, dgvPayroll, dgvApplicants)

        If selectedGrid.SelectedRows.Count > 0 Then
            Dim appID As Integer = Convert.ToInt32(selectedGrid.SelectedRows(0).Cells("ApplicationID").Value)

            ' Launch the new Enterprise Inbox
            Dim inboxForm As New frmInbox()
            inboxForm.PreSelectedAppID = appID
            inboxForm.ShowDialog()
        Else
            MsgBox("Please select a worker from the table first.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    ' ==========================================
    ' ACTION: Review Application / Cover Letter
    ' ==========================================
    Private Sub btnViewProfile_Click(sender As Object, e As EventArgs) Handles btnViewProfile.Click
        If dgvApplicants.SelectedRows.Count > 0 Then
            Dim appID As Integer = Convert.ToInt32(dgvApplicants.SelectedRows(0).Cells("ApplicationID").Value)

            Dim reviewForm As New frmViewApplication()
            reviewForm.SelectedAppID = appID

            If reviewForm.ShowDialog() = DialogResult.OK Then
                LoadApplicants()
                UpdateEmployerStats()
            End If
        Else
            MsgBox("Please select an applicant from the table first.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    ' --- ERP LOGIC: Accept Worker (WITH LIVE NOTIFICATION) ---
    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        If dgvApplicants.SelectedRows.Count > 0 Then
            ' 1. Check the current status first!
            Dim currentStatus As String = dgvApplicants.SelectedRows(0).Cells("Status").Value.ToString()

            If currentStatus <> "Pending" Then
                MsgBox("You can only hire workers who are currently 'Pending'. This application is already marked as: " & currentStatus, MsgBoxStyle.Exclamation, "Action Blocked")
                Exit Sub
            End If

            ' 2. If it is Pending, proceed as normal
            Dim appID As Integer = Convert.ToInt32(dgvApplicants.SelectedRows(0).Cells("ApplicationID").Value)
            Dim workerName As String = dgvApplicants.SelectedRows(0).Cells("Applicant Name").Value.ToString()

            ' GRAB THE WORKER'S USER ID SO WE CAN TEXT THEM!
            Dim targetWorkerUserID As Integer = Convert.ToInt32(dgvApplicants.SelectedRows(0).Cells("WorkerUserID").Value)

            Dim confirm As DialogResult = MsgBox("Are you sure you want to HIRE " & workerName & "?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm Hire")

            If confirm = DialogResult.Yes Then
                If JobManager.UpdateApplicationStatus(appID, "Accepted") Then

                    ' ==================================================
                    ' SEND LIVE ALERT TO THE WORKER
                    ' ==================================================
                    NotificationManager.Send(targetWorkerUserID, "Great news! Your application was accepted. You are officially hired for the job!")

                    MsgBox("Success! " & workerName & " has been hired.", MsgBoxStyle.Information)
                    LoadApplicants()
                    UpdateEmployerStats()
                End If
            End If
        Else
            MsgBox("Please select an applicant from the table first.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    ' --- ERP LOGIC: Reject Worker (WITH LIVE NOTIFICATION) ---
    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        If dgvApplicants.SelectedRows.Count > 0 Then
            ' 1. Check the current status first!
            Dim currentStatus As String = dgvApplicants.SelectedRows(0).Cells("Status").Value.ToString()

            If currentStatus <> "Pending" Then
                MsgBox("You can only reject workers who are currently 'Pending'. This application is already marked as: " & currentStatus, MsgBoxStyle.Exclamation, "Action Blocked")
                Exit Sub
            End If

            ' 2. If it is Pending, proceed as normal
            Dim appID As Integer = Convert.ToInt32(dgvApplicants.SelectedRows(0).Cells("ApplicationID").Value)
            Dim workerName As String = dgvApplicants.SelectedRows(0).Cells("Applicant Name").Value.ToString()

            ' GRAB THE WORKER'S USER ID SO WE CAN TEXT THEM!
            Dim targetWorkerUserID As Integer = Convert.ToInt32(dgvApplicants.SelectedRows(0).Cells("WorkerUserID").Value)

            Dim confirm As DialogResult = MsgBox("Are you sure you want to REJECT the application from " & workerName & "?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm Rejection")

            If confirm = DialogResult.Yes Then
                If JobManager.UpdateApplicationStatus(appID, "Rejected") Then

                    ' ==================================================
                    ' SEND LIVE ALERT TO THE WORKER
                    ' ==================================================
                    NotificationManager.Send(targetWorkerUserID, "Update: The employer has decided to move forward with other candidates for this job.")

                    MsgBox("Application rejected.", MsgBoxStyle.Information)
                    LoadApplicants()
                End If
            End If
        Else
            MsgBox("Please select an applicant from the table first.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    ' --- ERP LOGIC: Dynamic Issue Payment ---
    Private Sub btnPayWorker_Click(sender As Object, e As EventArgs) Handles btnPayWorker.Click
        If dgvPayroll.SelectedRows.Count > 0 Then
            Dim appID As Integer = Convert.ToInt32(dgvPayroll.SelectedRows(0).Cells("ApplicationID").Value)
            Dim workerName As String = dgvPayroll.SelectedRows(0).Cells("Worker Name").Value.ToString()

            ' Grab the Type and Rate from our new Smart Grid!
            Dim payType As String = dgvPayroll.SelectedRows(0).Cells("Type").Value.ToString()

            ' ==================================================
            ' ERP SAFE MATH: Extract pure numbers from text
            ' ==================================================
            Dim rawRate As String = dgvPayroll.SelectedRows(0).Cells(4).Value.ToString()
            Dim cleanRate As String = System.Text.RegularExpressions.Regex.Match(rawRate, "\d+(\.\d+)?").Value

            Dim baseRate As Decimal = 0
            If cleanRate <> "" Then
                baseRate = Convert.ToDecimal(cleanRate)
            End If
            ' ==================================================

            ' ==================================================
            ' ERP TIMEKEEPING: Dynamic Prompt based on Pay Type
            ' ==================================================
            Dim promptMsg As String = ""
            If payType = "Hourly" Then
                promptMsg = "This is an HOURLY job." & vbCrLf & vbCrLf & "How many HOURS did " & workerName & " work?"
            ElseIf payType = "Daily" Then
                promptMsg = "This is a DAILY job." & vbCrLf & vbCrLf & "How many DAYS did " & workerName & " work?"
            Else
                promptMsg = "This is a FIXED price job." & vbCrLf & vbCrLf & "Enter 1 to issue the full flat-rate payment."
            End If

            Dim multiplierStr As String = InputBox(promptMsg, "Timekeeping (" & payType & ")", "1")

            If String.IsNullOrWhiteSpace(multiplierStr) OrElse Not IsNumeric(multiplierStr) Then
                MsgBox("Payment cancelled. You must enter a valid number.", MsgBoxStyle.Exclamation, "Cancelled")
                Exit Sub
            End If

            Dim multiplier As Decimal = Convert.ToDecimal(multiplierStr)
            Dim finalAmountDue As Decimal = baseRate * multiplier

            Dim confirmMsg As String = "Base Rate: ₱" & baseRate.ToString("N2") & " x " & multiplier.ToString() & " (" & payType & ")" & vbCrLf &
                                       "TOTAL PAYOUT: ₱" & finalAmountDue.ToString("N2") & vbCrLf & vbCrLf &
                                       "Issue this official payment to " & workerName & "?"

            Dim confirm As DialogResult = MsgBox(confirmMsg, MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm Final Payroll")

            If confirm = DialogResult.Yes Then
                Try
                    openConn()

                    Dim cmdIDs As New MySqlCommand("SELECT WorkerID, (SELECT EmployeerID FROM tbljobs WHERE JobID = a.JobID) AS EmpID FROM tblApplications a WHERE ApplicationID = @appID", conn)
                    cmdIDs.Parameters.AddWithValue("@appID", appID)
                    Dim reader As MySqlDataReader = cmdIDs.ExecuteReader()

                    Dim wID As Integer = 0
                    Dim eID As Integer = 0
                    If reader.Read() Then
                        wID = Convert.ToInt32(reader("WorkerID"))
                        eID = Convert.ToInt32(reader("EmpID"))
                    End If
                    reader.Close()

                    Dim cmdPay As New MySqlCommand("INSERT INTO tblTransactions (ApplicationID, EmployerID, WorkerID, AmountPaid, PaymentMethod) VALUES (@app, @emp, @work, @amt, 'Cash/Manual')", conn)
                    cmdPay.Parameters.AddWithValue("@app", appID)
                    cmdPay.Parameters.AddWithValue("@emp", eID)
                    cmdPay.Parameters.AddWithValue("@work", wID)
                    cmdPay.Parameters.AddWithValue("@amt", finalAmountDue)
                    cmdPay.ExecuteNonQuery()

                    Dim cmdClose As New MySqlCommand("UPDATE tblApplications SET Status = 'Closed' WHERE ApplicationID = @appID", conn)
                    cmdClose.Parameters.AddWithValue("@appID", appID)
                    cmdClose.ExecuteNonQuery()

                    Dim getWorkerUserCmd As New MySqlCommand("SELECT UserID FROM tblworkers WHERE WorkerID = @wID", conn)
                    getWorkerUserCmd.Parameters.AddWithValue("@wID", wID)
                    Dim targetWorkerUserID As Integer = Convert.ToInt32(getWorkerUserCmd.ExecuteScalar())

                    NotificationManager.Send(targetWorkerUserID, "You have been paid ₱" & finalAmountDue.ToString("N2") & " for your recent job! A digital receipt is now available in your History.")

                    MsgBox("Success! Payment of ₱" & finalAmountDue.ToString("N2") & " has been issued to " & workerName & ".", MsgBoxStyle.Information)
                    LoadPayroll()
                    UpdateEmployerStats()
                Catch ex As Exception
                    MsgBox("Payment Error: " & ex.Message, MsgBoxStyle.Critical)
                Finally
                    closeConn()
                End Try
            End If
        Else
            MsgBox("Please select a pending payroll record first.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    ' --- ERP LOGIC: Finalize and Review Job ---
    Private Sub btnConfirmJobDone_Click(sender As Object, e As EventArgs) Handles btnConfirmJobDone.Click
        If dgvApplicants.SelectedRows.Count > 0 Then
            Dim status As String = dgvApplicants.SelectedRows(0).Cells("Status").Value.ToString()

            If status = "Completed" Then
                Dim reviewForm As New frmReviewWorker()
                reviewForm.SelectedAppID = Convert.ToInt32(dgvApplicants.SelectedRows(0).Cells("ApplicationID").Value)
                reviewForm.WorkerName = dgvApplicants.SelectedRows(0).Cells("Applicant Name").Value.ToString()

                If reviewForm.ShowDialog() = DialogResult.OK Then
                    LoadApplicants()
                    UpdateEmployerStats()
                End If
            Else
                MsgBox("You can only review and pay for jobs that the worker has marked as 'Completed'.", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Please select a worker's application first.")
        End If
    End Sub

    Private Sub btnRefreshApplicants_Click(sender As Object, e As EventArgs) Handles btnRefreshApplicants.Click
        LoadApplicants()
        UpdateEmployerStats()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim home As New frmHome()
        home.Show()
        Me.Close()
    End Sub

    ' ==========================================
    ' EMPLOYER UI: Modern Interactive Hover Effects
    ' ==========================================
    Private Sub PrimaryButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnPostJob.MouseEnter, btnConfirmJobDone.MouseEnter
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(51, 133, 255)
    End Sub
    Private Sub PrimaryButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnPostJob.MouseLeave, btnConfirmJobDone.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(0, 45, 70)
    End Sub

    Private Sub btnViewProfile_MouseEnter(sender As Object, e As EventArgs) Handles btnViewProfile.MouseEnter, btnRefreshApplicants.MouseEnter
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(26, 188, 212)
    End Sub
    Private Sub btnViewProfile_MouseLeave(sender As Object, e As EventArgs) Handles btnViewProfile.MouseLeave, btnRefreshApplicants.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(23, 162, 184)
    End Sub

    Private Sub btnChatWorker_MouseEnter(sender As Object, e As EventArgs) Handles btnChatWorker.MouseEnter
        btnChatWorker.BackColor = Color.FromArgb(133, 79, 232)
    End Sub
    Private Sub btnChatWorker_MouseLeave(sender As Object, e As EventArgs) Handles btnChatWorker.MouseLeave
        btnChatWorker.BackColor = Color.FromArgb(111, 66, 193)
    End Sub

    Private Sub btnAccept_MouseEnter(sender As Object, e As EventArgs) Handles btnAccept.MouseEnter, btnPayWorker.MouseEnter
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(44, 185, 76)
    End Sub
    Private Sub btnAccept_MouseLeave(sender As Object, e As EventArgs) Handles btnAccept.MouseLeave, btnPayWorker.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(40, 167, 69)
    End Sub

    Private Sub btnReject_MouseEnter(sender As Object, e As EventArgs) Handles btnReject.MouseEnter, btnCloseJob.MouseEnter
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(225, 83, 97)
    End Sub
    Private Sub btnReject_MouseLeave(sender As Object, e As EventArgs) Handles btnReject.MouseLeave, btnCloseJob.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(220, 53, 69)
    End Sub

    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnViewPostJob.MouseEnter, btnViewApplicants.MouseEnter, btnViewPayroll.MouseEnter, btnMyProfile.MouseEnter, btnGlobalInbox.MouseEnter, btnMyPosts.MouseEnter
        Dim btn As Button = CType(sender, Button)
        If btn.BackColor <> Color.FromArgb(245, 246, 248) Then
            btn.BackColor = Color.FromArgb(245, 246, 248)
        End If
    End Sub
    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnViewPostJob.MouseLeave, btnViewApplicants.MouseLeave, btnViewPayroll.MouseLeave, btnMyProfile.MouseLeave, btnGlobalInbox.MouseLeave, btnMyPosts.MouseLeave
        Dim btn As Button = CType(sender, Button)
        If btn.ForeColor <> Color.FromArgb(0, 45, 70) Then
            btn.BackColor = Color.White
        End If
    End Sub

    ' ==========================================
    ' ERP NOTIFICATION ENGINE (LIVE PULSE)
    ' ==========================================
    Private Sub notifTimer_Tick(sender As Object, e As EventArgs) Handles notifTimer.Tick
        Dim unreadCount As Integer = NotificationManager.GetUnreadCount(CurrentUserID)

        If unreadCount > 0 Then
            btnNotifications.Text = "🔔 Alerts (" & unreadCount & ")"
            btnNotifications.ForeColor = Color.Yellow
        Else
            btnNotifications.Text = "🔔 Alerts"
            btnNotifications.ForeColor = Color.White
        End If
    End Sub

    Private Sub btnNotifications_Click(sender As Object, e As EventArgs) Handles btnNotifications.Click
        Dim unreadCount As Integer = NotificationManager.GetUnreadCount(CurrentUserID)

        If unreadCount > 0 Then
            MsgBox("You have new system alerts! Go to the Applicants tab to review your new notifications.", MsgBoxStyle.Information)
            NotificationManager.MarkAllAsRead(CurrentUserID)
            ' Force the UI to update immediately
            btnNotifications.Text = "🔔 Alerts"
            btnNotifications.ForeColor = Color.White
        Else
            MsgBox("You have no new alerts.", MsgBoxStyle.Information)
        End If
    End Sub

End Class