<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahSewa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DGPenyewa = New System.Windows.Forms.DataGridView()
        Me.DTRencana_kembali = New System.Windows.Forms.DateTimePicker()
        Me.DTTanggalPinjam = New System.Windows.Forms.DateTimePicker()
        Me.TxtNik = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtBiayaSewa = New System.Windows.Forms.TextBox()
        Me.TxtMerek = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPlatNomor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DGMobil = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtidmobil = New System.Windows.Forms.TextBox()
        Me.Txtidpenyewa = New System.Windows.Forms.TextBox()
        CType(Me.DGPenyewa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(488, 929)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 29)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "Tambah Sewa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(771, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 31)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Data Penyewa"
        '
        'DGPenyewa
        '
        Me.DGPenyewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPenyewa.Location = New System.Drawing.Point(585, 182)
        Me.DGPenyewa.Name = "DGPenyewa"
        Me.DGPenyewa.RowHeadersWidth = 51
        Me.DGPenyewa.RowTemplate.Height = 29
        Me.DGPenyewa.Size = New System.Drawing.Size(541, 315)
        Me.DGPenyewa.TabIndex = 85
        '
        'DTRencana_kembali
        '
        Me.DTRencana_kembali.Location = New System.Drawing.Point(279, 422)
        Me.DTRencana_kembali.Name = "DTRencana_kembali"
        Me.DTRencana_kembali.Size = New System.Drawing.Size(250, 27)
        Me.DTRencana_kembali.TabIndex = 78
        '
        'DTTanggalPinjam
        '
        Me.DTTanggalPinjam.Location = New System.Drawing.Point(279, 357)
        Me.DTTanggalPinjam.Name = "DTTanggalPinjam"
        Me.DTTanggalPinjam.Size = New System.Drawing.Size(250, 27)
        Me.DTTanggalPinjam.TabIndex = 77
        '
        'TxtNik
        '
        Me.TxtNik.Location = New System.Drawing.Point(279, 241)
        Me.TxtNik.Name = "TxtNik"
        Me.TxtNik.Size = New System.Drawing.Size(253, 27)
        Me.TxtNik.TabIndex = 76
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(488, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 38)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Tambah Sewa"
        '
        'TxtBiayaSewa
        '
        Me.TxtBiayaSewa.Location = New System.Drawing.Point(276, 483)
        Me.TxtBiayaSewa.Name = "TxtBiayaSewa"
        Me.TxtBiayaSewa.Size = New System.Drawing.Size(253, 27)
        Me.TxtBiayaSewa.TabIndex = 74
        '
        'TxtMerek
        '
        Me.TxtMerek.Location = New System.Drawing.Point(279, 130)
        Me.TxtMerek.Name = "TxtMerek"
        Me.TxtMerek.Size = New System.Drawing.Size(253, 27)
        Me.TxtMerek.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 483)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 20)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Total Biaya Sewa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Tanggal Pinjam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 422)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Rencana Kembali"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Nik Penyewa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 20)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Merk"
        '
        'TxtPlatNomor
        '
        Me.TxtPlatNomor.Location = New System.Drawing.Point(279, 182)
        Me.TxtPlatNomor.Name = "TxtPlatNomor"
        Me.TxtPlatNomor.Size = New System.Drawing.Size(253, 27)
        Me.TxtPlatNomor.TabIndex = 89
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(36, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 20)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Plat Nomor"
        '
        'DGMobil
        '
        Me.DGMobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMobil.Location = New System.Drawing.Point(585, 575)
        Me.DGMobil.Name = "DGMobil"
        Me.DGMobil.RowHeadersWidth = 51
        Me.DGMobil.RowTemplate.Height = 29
        Me.DGMobil.Size = New System.Drawing.Size(541, 315)
        Me.DGMobil.TabIndex = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(785, 528)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 31)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Data Mobil"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(279, 293)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(253, 27)
        Me.TxtNama.TabIndex = 93
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 20)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Nama Penyewa"
        '
        'Txtidmobil
        '
        Me.Txtidmobil.Location = New System.Drawing.Point(585, 542)
        Me.Txtidmobil.Name = "Txtidmobil"
        Me.Txtidmobil.Size = New System.Drawing.Size(25, 27)
        Me.Txtidmobil.TabIndex = 94
        '
        'Txtidpenyewa
        '
        Me.Txtidpenyewa.Location = New System.Drawing.Point(585, 149)
        Me.Txtidpenyewa.Name = "Txtidpenyewa"
        Me.Txtidpenyewa.Size = New System.Drawing.Size(25, 27)
        Me.Txtidpenyewa.TabIndex = 95
        '
        'TambahSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 992)
        Me.Controls.Add(Me.Txtidpenyewa)
        Me.Controls.Add(Me.Txtidmobil)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGMobil)
        Me.Controls.Add(Me.TxtPlatNomor)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DGPenyewa)
        Me.Controls.Add(Me.DTRencana_kembali)
        Me.Controls.Add(Me.DTTanggalPinjam)
        Me.Controls.Add(Me.TxtNik)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtBiayaSewa)
        Me.Controls.Add(Me.TxtMerek)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Name = "TambahSewa"
        Me.Text = "TambahSewa"
        CType(Me.DGPenyewa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents DGPenyewa As DataGridView
    Friend WithEvents DTRencana_kembali As DateTimePicker
    Friend WithEvents DTTanggalPinjam As DateTimePicker
    Friend WithEvents TxtNik As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtBiayaSewa As TextBox
    Friend WithEvents TxtMerek As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtPlatNomor As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DGMobil As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtidmobil As TextBox
    Friend WithEvents Txtidpenyewa As TextBox
End Class
