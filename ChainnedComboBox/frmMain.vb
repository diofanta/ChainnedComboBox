' code by diofaprogsoft

Imports System.Data.SqlClient

Public Class frmMain
    Private _connection As SqlConnection
    Private _strConnection As String = "Data Source=(LocalDB)" &
                                       "\MSSQLLocalDB;AttachDbFilename=|DataDirectory|" &
                                       "dbWilayah.mdf;Integrated Security=True"

    ''' <summary>
    ''' Event membuka koneksi Databse
    ''' </summary>
    Sub ConnectDB()
        _connection = New SqlConnection(_strConnection)
        If _connection.State = ConnectionState.Closed Then
            _connection.Open()
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' membuka koneksi database
        ConnectDB()
        Dim _command As SqlCommand = New SqlCommand("select Provinsi from Wilayah " &
                                                    "group by Provinsi", _connection)
        Dim _adapter As SqlDataAdapter = New SqlDataAdapter(_command)
        Dim _datatable As DataTable = New DataTable
        _adapter.Fill(_datatable)
        _command.ExecuteReader()

        ' menambahkan keterangan pilih pada combobox
        Me.cboProvinsi.Items.Add("(Pilih)")
        Me.cboProvinsi.SelectedIndex = 0

        ' menambahkan daftar provinsi
        For Each _rows As DataRow In _datatable.Rows
            Me.cboProvinsi.Items.Add(_rows(0))
        Next

        ' menutup koneksi database
        _connection.Close()
    End Sub

    Private Sub cboProvinsi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvinsi.SelectedIndexChanged
        ' membuka koneksi database
        ConnectDB()
        Dim _command As SqlCommand = New SqlCommand("select Provinsi, Kabupaten " &
                                                    "from Wilayah " &
                                                    "where Provinsi='" &
                                                    Me.cboProvinsi.Text &
                                                    "' group by Provinsi, Kabupaten",
                                                    _connection)

        Dim _adapter As SqlDataAdapter = New SqlDataAdapter(_command)
        Dim _datatable As DataTable = New DataTable
        _adapter.Fill(_datatable)
        _command.ExecuteReader()

        ' menambahkan keterangan pilih pada combobox
        Me.cboKabupaten.Items.Clear()
        Me.cboKabupaten.Items.Add("(Pilih)")
        Me.cboKabupaten.SelectedIndex = 0

        ' menambahkan daftar kabupaten
        For Each _rows As DataRow In _datatable.Rows
            Me.cboKabupaten.Items.Add(_rows(1))
        Next

        ' menutup koneksi database
        _connection.Close()
    End Sub

    Private Sub cboKabupaten_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKabupaten.SelectedIndexChanged
        ' membuka koneksi database
        ConnectDB()
        Dim _command As SqlCommand = New SqlCommand("select Provinsi, Kabupaten, " &
                                                    "Kecamatan " &
                                                    "from Wilayah " &
                                                    "where Provinsi='" &
                                                    Me.cboProvinsi.Text &
                                                    "' and Kabupaten='" &
                                                    Me.cboKabupaten.Text &
                                                    "' group by Provinsi, Kabupaten, " &
                                                    "Kecamatan",
                                                    _connection)

        Dim _adapter As SqlDataAdapter = New SqlDataAdapter(_command)
        Dim _datatable As DataTable = New DataTable
        _adapter.Fill(_datatable)
        _command.ExecuteReader()

        ' menambahkan keterangan pilih pada combobox
        Me.cboKecamatan.Items.Clear()
        Me.cboKecamatan.Items.Add("(Pilih)")
        Me.cboKecamatan.SelectedIndex = 0

        ' menambahkan daftar kecamatan
        For Each _rows As DataRow In _datatable.Rows
            Me.cboKecamatan.Items.Add(_rows(2))
        Next

        ' menutup koneksi database
        _connection.Close()
    End Sub

    Private Sub cboKecamatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKecamatan.SelectedIndexChanged
        ' membuka koneksi database
        ConnectDB()
        Dim _command As SqlCommand = New SqlCommand("select Provinsi, Kabupaten, " &
                                                    "Kecamatan, Desa " &
                                                    "from Wilayah " &
                                                    "where Provinsi='" &
                                                    Me.cboProvinsi.Text &
                                                    "' and Kabupaten='" &
                                                    Me.cboKabupaten.Text &
                                                    "' and Kecamatan='" &
                                                    Me.cboKecamatan.Text &
                                                    "' group by Provinsi, Kabupaten, " &
                                                    "Kecamatan, Desa",
                                                    _connection)

        Dim _adapter As SqlDataAdapter = New SqlDataAdapter(_command)
        Dim _datatable As DataTable = New DataTable
        _adapter.Fill(_datatable)
        _command.ExecuteReader()

        ' menambahkan keterangan pilih pada combobox
        Me.cboDesa.Items.Clear()
        Me.cboDesa.Items.Add("(Pilih)")
        Me.cboDesa.SelectedIndex = 0

        ' menambahkan daftar desa
        For Each _rows As DataRow In _datatable.Rows
            Me.cboDesa.Items.Add(_rows(3))
        Next

        ' menutup koneksi database
        _connection.Close()

    End Sub
End Class
