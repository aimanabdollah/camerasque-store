Public Class frm_vieworder_a175054
    Private Sub frm_invois_a175054_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'order
        Dim sql_order As String = "SELECT * FROM TBL_ORDER_A175054 WHERE FLD_ORDER_ID='" & product_id & "'"
        Dim tbl_order As New DataTable
        Dim read_order As New OleDb.OleDbDataAdapter(sql_order, myconnection)
        read_order.Fill(tbl_order)

        'item
        Dim sql_item As String = "SELECT * FROM TBL_ORDER_PRODUCT_A175054 WHERE FLD_ORDER_ID='" & product_id & "'"
        Dim tbl_item As New DataTable
        Dim read_item As New OleDb.OleDbDataAdapter(sql_item, myconnection)
        read_item.Fill(tbl_item)

        'table header
        DataGridView1.ColumnCount = 4
        DataGridView1.Columns(0).Name = "Name"
        DataGridView1.Columns(1).Name = "Quantity"
        DataGridView1.Columns(2).Name = "Price Per Unit (RM)"
        DataGridView1.Columns(3).Name = "Total (RM)"

        'column data
        Dim row_total As Integer = tbl_item.Rows.Count
        For i As Integer = 0 To (row_total - 1)
            'product
            Dim sql_product As String = "SELECT * FROM TBL_PRODUCT_A175054 WHERE FLD_PRODUCT_ID='" & tbl_item.Rows(i).Item(2) & "'"
            Dim tbl_product As New DataTable
            Dim read_product As New OleDb.OleDbDataAdapter(sql_product, myconnection)
            read_product.Fill(tbl_product)

            Dim row As String() = New String() {tbl_product.Rows(0).Item("FLD_PRODUCT_NAME"), (tbl_item.Rows(i).Item("FLD_PRODUCT_TOTAL") / tbl_product.Rows(0).Item("FLD_PRODUCT_PRICE")), tbl_product.Rows(0).Item("FLD_PRODUCT_PRICE"), tbl_item.Rows(i).Item("FLD_PRODUCT_TOTAL")}
            DataGridView1.Rows.Add(row)
        Next

        'all label
        lbl_date.Text = tbl_order.Rows(0).Item("FLD_CREATED_AT")
        lbl_id.Text = tbl_order.Rows(0).Item("FLD_ORDER_ID")
        lbl_cust.Text = tbl_order.Rows(0).Item("FLD_CUSTOMER_ID")
        lbl_staff.Text = tbl_order.Rows(0).Item("FLD_STAFF_ID")
        lbl_total.Text = tbl_order.Rows(0).Item("FLD_CART_TOTAL")
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
        frm_order_a175054.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class