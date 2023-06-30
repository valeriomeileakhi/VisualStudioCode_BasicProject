Public Class TambahJenisMobil
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DTPJenisMobil.Format = DateTimePickerFormat.Custom
        DTPJenisMobil.CustomFormat = "yyyy/MM/dd"

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Home.DataJenisMobil.jenis_mobilProperty = TxtJeniMobil.Text.ToString()
        Home.DataJenisMobil.tanggal_inputProperty = DTPJenisMobil.Value.ToString("yyyy/MM/dd")

        Home.DataJenisMobil.AddDataJenisMobilDatabase(Home.DataJenisMobil.jenis_mobilProperty,
                                                      Home.DataJenisMobil.tanggal_inputProperty)

        Me.Close()
    End Sub
End Class