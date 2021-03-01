Public Class frm_mainmenu_a175054
    Private Sub btn_customertable_Click(sender As Object, e As EventArgs) Handles btn_tablecustomer.Click
        frm_customertable_a175054.Show()
    End Sub

    Private Sub btn_tableproduct_Click(sender As Object, e As EventArgs) Handles btn_tableproduct.Click
        frm_producttable_a175054.Show()
    End Sub

    Private Sub btn_tablestaff_Click(sender As Object, e As EventArgs) Handles btn_tablestaff.Click
        frm_stafftable_a175054.Show()
    End Sub

    Private Sub btn_tablemanufacturer_Click(sender As Object, e As EventArgs) Handles btn_tablemanufacturer.Click
        frm_manufacturertable_a175054.Show()

    End Sub

    Private Sub btn_tableorder_Click(sender As Object, e As EventArgs) Handles btn_tableorder.Click
        frm_odertable_a175054.Show()

    End Sub

    Private Sub btn_exitprogram_Click(sender As Object, e As EventArgs) Handles btn_exitprogram.Click
        End
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub frm_mainmenu_a175054_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim current_date As String = Date.Now
        lbl_date.Text = current_date

    End Sub

    Private Sub btn_tableorderproduct_Click(sender As Object, e As EventArgs) Handles btn_tableorderproduct.Click
        frm_orderproducttable_a175054.Show()
    End Sub

    Private Sub lbl_date_Click(sender As Object, e As EventArgs) Handles lbl_date.Click

    End Sub

    Private Sub btn_insertcustomer_Click(sender As Object, e As EventArgs) Handles btn_insertcustomer.Click
        frm_insertcustomer_a175054.Show()

    End Sub

    Private Sub btn_insertstaff_Click(sender As Object, e As EventArgs) Handles btn_insertstaff.Click
        frm_insertstaff_a175054.Show()

    End Sub

    Private Sub btn_insertproduct_Click(sender As Object, e As EventArgs) Handles btn_insertproduct.Click
        frm_insertproduct_a175054.Show()

    End Sub

    Private Sub btn_updatecustomer_Click(sender As Object, e As EventArgs) Handles btn_updatecustomer.Click
        frm_managecustomer_a175054.Show()

    End Sub

    Private Sub btn_updatestaff_Click(sender As Object, e As EventArgs) Handles btn_updatestaff.Click
        frm_managestaff_a175054.Show()

    End Sub

    Private Sub btn_updateproduct_Click(sender As Object, e As EventArgs) Handles btn_updateproduct.Click
        frm_manageproduct_a175054.Show()

    End Sub

    Private Sub btn_catalogproduct_Click(sender As Object, e As EventArgs) Handles btn_catalogproduct.Click
        frm_catalogproduct_a175054.Show()

    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_order_a175054.Show()

    End Sub
End Class