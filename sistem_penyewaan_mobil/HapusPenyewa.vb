﻿Public Class HapusPenyewa

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LbNama.Text = Penyewa.SelectedTablePenyewaNama
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnHapusKoleksi_Click(sender As Object, e As EventArgs) Handles BtnHapusKoleksi.Click
        Home.DataPenyewa.DeleteDataKoleksiByIDDatabase(Penyewa.SelectedTablePenyewa)
        Me.Close()
    End Sub

End Class