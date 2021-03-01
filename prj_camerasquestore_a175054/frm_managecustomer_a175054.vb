Public Class frm_managecustomer_a175054

    Dim current_id As String

    Private Sub frm_updatecustomer_a175054_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        get_current_id()

    End Sub

    Private Sub refresh_grid()

        grd_customer.DataSource = run_select("SELECT * FROM TBL_CUSTOMER_A175054")

    End Sub

    Private Sub get_current_id()

        Dim current_row As Integer = grd_customer.CurrentRow.Index

        current_id = grd_customer(0, current_row).Value

        'MsgBox(current_code)

        txt_customerID.Text = current_id
        txt_customerName.Text = grd_customer(1, current_row).Value
        txt_customerLocation.Text = grd_customer(2, current_row).Value


    End Sub


    Private Sub grd_customer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellClick
        get_current_id()
    End Sub

    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_CUSTOMER_A175054 SET FLD_CUSTOMER_NAME='" & txt_customerName.Text & "' WHERE FLD_CUSTOMER_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_CUSTOMER_A175054 SET FLD_CUSTOMER_LOCATION='" & txt_customerLocation.Text & "' WHERE FLD_CUSTOMER_ID='" & current_id & "'")

        'Beep()
        'MsgBox("You have successfully updated the customer """ & current_id & """.")
        refresh_grid()
        'clear_fields()
        get_current_id()
    End Sub





    Private Sub txt_customerID_TextChanged(sender As Object, e As EventArgs) Handles txt_customerID.TextChanged

    End Sub


    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click


        Beep()
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the customer " & current_id & "?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_CUSTOMER_A175054 WHERE FLD_CUSTOMER_ID ='" & current_id & "'")

            Beep()
            MsgBox("The customer " & current_id & " has been successfully deleted")

            refresh_grid()
            get_current_id()

        End If





    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.Close()
        frm_mainmenu_a175054.Show()
    End Sub
End Class


