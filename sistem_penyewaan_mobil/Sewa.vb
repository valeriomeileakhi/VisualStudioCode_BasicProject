Public Class Sewa

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formtambah = New TambahSewa()
        formtambah.Show()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DGSewa.DataSource = Home.DataSewa.GetDataSewaDatabase()
    End Sub

    Private Sub Sewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub
End Class