﻿Public Class frm_orderproducttable_a175054
    Private Sub frm_orderproducttable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_CAMERASQUESTORE_A175054.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_ORDER_PRODUCT_A175054"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)
        grd_orderproduct.DataSource = mydatatable
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.Close()
        frm_mainmenu_a175054.Show()
    End Sub
End Class