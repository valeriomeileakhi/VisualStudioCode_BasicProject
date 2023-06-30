Public Class TambahSewa
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ReloadDataTableDatabase()
        ' Add any initialization after the InitializeComponent() call.
        DTRencana_kembali.Format = DateTimePickerFormat.Custom
        DTRencana_kembali.CustomFormat = "yyyy/MM/dd"
        DTTanggalPinjam.Format = DateTimePickerFormat.Custom
        DTTanggalPinjam.CustomFormat = "yyyy/MM/dd"


    End Sub



    Private Sub ReloadDataTableDatabase()
        DGMobil.DataSource = Home.DataMobil.GetDataMobilDatabase()
        DGPenyewa.DataSource = Home.DataPenyewa.GetDataKoleksiDatabase()

    End Sub

    Private Sub TambahSewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.DataSewa.id_mobilProperty = Txtidmobil.Text.ToString()
        Home.DataSewa.id_penyewaProperty = Txtidpenyewa.Text.ToString()
        Home.DataSewa.rencana_pinjamProperty = DTRencana_kembali.Value.ToString("yyyy/MM/dd")
        Home.DataSewa.tanggal_pinjamProperty = DTTanggalPinjam.Value.ToString("yyyy/MM/dd")
        Home.DataSewa.total_biaya_SewaProperty = TxtBiayaSewa.Text.ToString()
        Home.DataSewa.status_sewaProperty = "Belum Selesai"
        Home.DataSewa.tanggal_kembaliProperty = Nothing
        Home.DataSewa.biaya_kelebihan_pinjamProperty = " "
        Home.DataSewa.total_bayarProperty = " "

        Home.DataSewa.AddDataSewaDatabase(Home.DataSewa.id_mobilProperty,
                                                Home.DataSewa.id_penyewaProperty,
                                                Home.DataSewa.rencana_pinjamProperty,
                                                Home.DataSewa.tanggal_pinjamProperty,
                                                Home.DataSewa.total_biaya_SewaProperty,
                                                Home.DataSewa.status_sewaProperty,
                                                Home.DataSewa.biaya_kelebihan_pinjamProperty,
                                                Home.DataSewa.total_bayarProperty
                                                )

        'Dim InfoTambah = New InfoMobil()
        'InfoTambah.Show()
        Me.Close()

    End Sub

    Private Sub DGMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMobil.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGMobil.Rows(index)

        Txtidmobil.Text = selectedRow.Cells(0).Value
        TxtMerek.Text = selectedRow.Cells(2).Value
        TxtPlatNomor.Text = selectedRow.Cells(3).Value
    End Sub

    Private Sub DGPenyewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPenyewa.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGPenyewa.Rows(index)

        Txtidpenyewa.Text = selectedRow.Cells(0).Value
        TxtNik.Text = selectedRow.Cells(1).Value
        TxtNama.Text = selectedRow.Cells(2).Value
    End Sub
End Class