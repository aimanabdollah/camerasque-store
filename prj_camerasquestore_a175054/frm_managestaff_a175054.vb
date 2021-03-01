Public Class frm_managestaff_a175054

    Dim current_id As String

    Private Sub frm_updatestaff_a175054_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        get_current_id()

    End Sub

    Private Sub refresh_grid()

        grd_staff.DataSource = run_select("SELECT * FROM TBL_STAFF_A175054")

    End Sub

    Private Sub get_current_id()

        Dim current_row As Integer = grd_staff.CurrentRow.Index

        current_id = grd_staff(0, current_row).Value

        'MsgBox(current_code)

        txt_staffID.Text = current_id
        txt_staffName.Text = grd_staff(1, current_row).Value
        txt_staffAge.Text = grd_staff(2, current_row).Value


    End Sub


    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick
        get_current_id()
    End Sub

    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_STAFF_A175054 SET FLD_STAFF_NAME='" & txt_staffName.Text & "' WHERE FLD_STAFF_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_STAFF_A175054 SET FLD_STAFF_AGE=" & txt_staffAge.Text & " WHERE FLD_STAFF_ID='" & current_id & "'")

        'Beep()
        'MsgBox("You have successfully updated the staff """ & current_id & """.")
        refresh_grid()
        'clear_fields()
        get_current_id()
    End Sub




    Private Sub txt_staffID_TextChanged(sender As Object, e As EventArgs) Handles txt_staffID.TextChanged

    End Sub


    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click


        Beep()
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the staff " & current_id & "?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_STAFF_A175054 WHERE FLD_STAFF_ID ='" & current_id & "'")

            Beep()
            MsgBox("The staff " & current_id & " has been successfully deleted")

            refresh_grid()
            get_current_id()

        End If





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frm_mainmenu_a175054.Show()


    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.Close()
        frm_mainmenu_a175054.Show()
    End Sub
End Class


