Public Class frm_manageproduct_a175054

    Dim current_id As String
    Private Sub frm_updateproduct_a175054_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_userLevel.Items.Add("Beginner")
        cmb_userLevel.Items.Add("Intermediate")
        cmb_userLevel.Items.Add("Expert")
        cmb_userLevel.SelectedIndex = 0

        'cmb_manufacturerName.DataSource = run_select("SELECT FLD_MANUFACTURER_NAME FROM TBL_MANUFACTURER_A175054")
        'cmb_manufacturerName.DisplayMember = "FLD_MANUFACTURER_NAME"

        refresh_grid()

        get_current_id()


    End Sub

    Private Sub refresh_grid()

        grd_product.DataSource = run_select("SELECT * FROM TBL_PRODUCT_A175054")

    End Sub

    Private Sub get_current_id()

        Dim current_row As Integer = grd_product.CurrentRow.Index

        current_id = grd_product(0, current_row).Value

        'MsgBox(current_code)

        txt_productID.Text = current_id
        txt_productName.Text = grd_product(1, current_row).Value
        txt_productPrice.Text = grd_product(2, current_row).Value
        txt_stock.Text = grd_product(3, current_row).Value
        txt_warrantyLength.Text = grd_product(4, current_row).Value
        cmb_userLevel.Text = grd_product(5, current_row).Value
        txt_manufacturerName.Text = grd_product(6, current_row).Value

    End Sub

    Private Sub grd_product_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellClick
        get_current_id()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click


        run_sql_command("UPDATE TBL_PRODUCT_A175054 SET FLD_PRODUCT_NAME='" & txt_productName.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCT_A175054 SET FLD_PRODUCT_PRICE=" & txt_productPrice.Text & " WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCT_A175054 SET FLD_STOCK=" & txt_stock.Text & " WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCT_A175054 SET FLD_WARRANTY_LENGTH='" & txt_warrantyLength.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCT_A175054 SET FLD_USER_LEVEL='" & cmb_userLevel.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCT_A175054 SET FLD_MANUFACTURER_NAME='" & txt_manufacturerName.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")


        'Beep()
        'MsgBox("You have successfully updated the product """ & current_id & """.")
        refresh_grid()
        'clear_fields()
        get_current_id()


    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click


        Beep()
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product " & current_id & "?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_PRODUCT_A175054 WHERE FLD_PRODUCT_ID ='" & current_id & "'")

            Beep()
            MsgBox("The product " & current_id & " has been successfully deleted")

            refresh_grid()
            get_current_id()

        End If





    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.Close()
        frm_mainmenu_a175054.Show()
    End Sub
End Class