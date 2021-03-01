Public Class frm_insertstaff_a175054
    Private Sub frm_insertstaff_a175054_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A175054"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        grd_staff.DataSource = mytable

    End Sub

    Private Sub clear_fields()

        txt_staffID.Text = ""
        txt_staffName.Text = ""
        txt_staffAge.Text = ""

    End Sub

    Private Sub btn_insertCustomer_Click(sender As Object, e As EventArgs) Handles btn_insertStaff.Click
        Dim mysql As String = "INSERT INTO TBL_STAFF_A175054 VALUES ('" & txt_staffID.Text & "', '" & txt_staffName.Text & "', '" & txt_staffAge.Text & "')"

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

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.Close()
        frm_mainmenu_a175054.Show()
    End Sub
End Class