Imports MySql.Data.MySqlClient
Public Class Form3
    Private Const V As String = " "
    Dim conn As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=example")
    Dim Command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim da As DataSet
    Dim Query As String
    Dim itemcoll(100) As String

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim str As String = "Data source=localhost; user id=root; password=; database=example"
        Dim con As New MySqlConnection(str)
        Dim comm As String = "select date_of_request as 'date of request', date_of_travel as 'date of travel',place_of_travel as 'place of travel', office as 'office', purpose as 'purpose', driver as 'driver', plate_number as 'plate number',time as 'time', dispatcher as 'dispatcher' from t1"
        Dim adapt As New MySqlDataAdapter(comm, con)
        Dim ds As New DataSet()

        adapt.Fill(ds, "INFO")
        dgv1.DataSource = ds.Tables(0)

        dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim rowindex As Integer = 0
        Dim columnindex As Integer = 1

        dgv1.Rows(rowindex).Cells(columnindex).Style.BackColor = Color.Red

    End Sub
End Class