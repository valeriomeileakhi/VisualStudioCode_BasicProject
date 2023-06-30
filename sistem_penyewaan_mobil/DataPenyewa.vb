Imports System.Text
Imports MySql.Data.MySqlClient
Public Class DataPenyewa
    Private id_penyewa As String
    Private nik As String
    Private nama As String
    Private alamat As String
    Private fotoKTP As String
    Private listPenyewa As New List(Of String)

    'Update 8 December MySql ---- until // close
    Public Shared ID
    Private koleksiDataTable As New ArrayList()
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    'Variabel Declaration
    Private sqlQuery As String
    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = " "
    Private database As String = "sistem_penyewaan_mobil"

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = " SELECT id_penyewa AS 'ID',
                                    nik AS 'NIK Penyewa', 
                                    nama AS 'Nama Penyewa',
                                    alamat AS 'Alamat',
                                    fotoKTP AS 'Foto KTP'
                                    FROM penyewa"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataKoleksiDatabase(nik As String,
                                        nama As String,
                                        alamat As String,
                                        fotoKTP As String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO PENYEWA(nik, nama, alamat, fotoKTP) VALUE('" _
            & nik & "', '" _
            & nama & "', '" _
            & alamat & "', '" _
            & fotoKTP & "')"
            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
        Return 0
    End Function

    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT nik, 
                                    nama,
                                    alamat, 
                                    fotoKTP
                                    FROM penyewa
                                    WHERE id_penyewa='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataPenyewaByIDDatabase(ID As Integer,
                                                  nik As String,
                                                  nama As String,
                                                  alamat As String,
                                                  fotoKTP As String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE penyewa SET " &
            "nik = '" & nik & "', " &
            "nama = '" & nama & "', " &
            "alamat = '" & alamat & "', " &
            "fotoKTP = '" & fotoKTP & "' " &
            "WHERE id_penyewa = '" & ID & "'"
            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM penyewa " &
                        "WHERE id_penyewa = '" & ID & "'"
            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlQuery)

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function removePenyewa(value As String)
        listPenyewa.Remove(value)
    End Function

    Public Property nikProperty() As String
        Get
            Return nik
        End Get
        Set(ByVal value As String)
            nik = value
        End Set
    End Property

    Public Property namaProperty() As String
        Get
            Return nama
        End Get
        Set(ByVal value As String)
            nama = value
        End Set
    End Property
    Public Property alamatProperty() As String
        Get
            Return alamat
        End Get
        Set(ByVal value As String)
            alamat = value
        End Set
    End Property

    Public Property fotoKTPProperty() As String
        Get
            Return fotoKTP
        End Get
        Set(ByVal value As String)
            fotoKTP = value
        End Set
    End Property

End Class
