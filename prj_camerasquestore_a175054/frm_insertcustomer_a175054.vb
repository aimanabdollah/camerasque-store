Public Class frm_insertcustomer_a175054
    Private Sub frm_insertcustomer_a175054_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A175054"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        grd_customer.DataSource = mytable

    End Sub

    Private Sub clear_fields()

        txt_customerID.Text = ""
        txt_customerName.Text = ""
        txt_customerLocation.Text = ""

    End Sub

    Private Sub btn_insertCustomer_Click(sender As Object, e As EventArgs) Handles btn_insertCustomer.Click

        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A175054 VALUES ('" & txt_customerID.Text & "', '" & txt_customerName.Text & "', '" & txt_customerLocation.Text & "')"

        'MsgBox(mysql)

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()
            clear_fields()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered:  " & ex.Message)
            mywriter.Connection.Close()

        End Try



    End Sub

    Private Sub txt_customerLocation_TextChanged(sender As Object, e As EventArgs) Handles txt_customerLocation.TextChanged

    End Sub

    Private Sub grd_customer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellContentClick

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.Close()
        frm_mainmenu_a175054.Show()
    End Sub
End Class