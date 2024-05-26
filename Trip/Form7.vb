Imports MySql.Data.MySqlClient
Public Class Form7
    Private Const V As String = " "
    Dim conn As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=example")
    Dim Command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim da As DataSet
    Dim Query As String
    Dim itemcoll(100) As String
    Private Sub Form7_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        

        conn.Open()

        Dim cmd As New MySqlCommand("select t1.date_of_request,t1.date_of_travel,t1.place_of_travel,t1.office,t1.purpose,t1.driver,t1.plate_number,t1.dispatcher,t2.stock_balance_in_tank,t2.fuel_consumption,t2.remaining_balance_in_tank,t2.distance_traveled,t2.liters_loaded,t2.amount_of_diesel_purchased from t1 inner join t2 on t1.date_of_request-t2.date_of_request", conn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        dgv1.DataSource = dt

        conn.Close()

       

        dgv1.MultiSelect = True

    End Sub
    Private Sub dgv1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub
    Public Sub ReloadConsumption()
        Try
            reload("SELECT CONCAT(date_of_request,date_of_travel,place_of_travel,office,purpose,driver,plate_number,time,dispatcher,stock_balance_in_tank,fuel_consumption,remaining_balance_in_tank,distance_traveled,liters_loaded,amount_of_diesel_purchased FROM t1 INNER JOIN t2 ON t1.date_of_request=t2.date_of_request WHERE MONTH(date_of_travel)=MONTH(NOW())", dgv1)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub month_Click(sender As System.Object, e As System.EventArgs) Handles month.Click
        Try
            reload("SELECT CONCAT(date_of_request,date_of_travel,place_of_travel,office,purpose,driver,plate_number,time,dispatcher,stock_balance_in_tank,fuel_consumption,remaining_balance_in_tank,distance_traveled,liters_loaded,amount_of_diesel_purchased FROM t1 INNER JOIN t2 ON t1.date_of_request=t2.date_of_request WHERE MONTH(date_of_travel)=MONTH(NOW())", dgv1)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub reload(p1 As String, dataGridView As DataGridView)
        Throw New NotImplementedException
    End Sub

End Class