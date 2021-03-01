Public Class frm_order_a175054
    Private Sub frm_order_a175054_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_ORDER_A175054"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        reader.Fill(table)
        grd_order.DataSource = table
        lbl_total.Text = "Total Order : " & table.Rows.Count() & ""
        Dim btn As New DataGridViewButtonColumn()

        'button
        grd_order.Columns.Add(btn)
        btn.HeaderText = "DETAIL"
        btn.Text = "View"
        btn.Name = "btn_view"
        btn.UseColumnTextForButtonValue = True
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        frm_mainmenu_a175054.Show()
        Me.Hide()
    End Sub

    Private Sub btn_make_Click(sender As Object, e As EventArgs) Handles btn_make.Click
        Me.Close()
        frm_makeorder_a175054.Show()
    End Sub

    Private Sub grd_order_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_order.CellContentClick
        Dim num As Integer = grd_order.CurrentCell.RowIndex
        Dim value = grd_order.Rows(num).Cells(0).Value.ToString
        product_id = value
        frm_vieworder_a175054.Show()
        Me.Close()
    End Sub
End Class