
Public Class frm_catalogproduct_a175054
    Private Sub frm_catalogproduct_a175054_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCT_A175054 ORDER BY FLD_PRODUCT_ID"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        lst_productID.DataSource = mytable
        lst_productID.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_productID.Text)

    End Sub

    Private Sub refresh_text(productID As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A175054 WHERE FLD_PRODUCT_ID='" & productID & "'"

        'MsgBox(mysql)

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        txt_productID.Text = mytable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_productName.Text = mytable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_productPrice.Text = mytable.Rows(0).Item("FLD_PRODUCT_PRICE")
        txt_stock.Text = mytable.Rows(0).Item("FLD_STOCK")
        txt_warrantyLength.Text = mytable.Rows(0).Item("FLD_WARRANTY_LENGTH")
        txt_userLevel.Text = mytable.Rows(0).Item("FLD_USER_LEVEL")
        txt_manufacturerName.Text = mytable.Rows(0).Item("FLD_MANUFACTURER_NAME")

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & productID & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try


    End Sub



    Private Sub lst_productID_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_productID.MouseClick
        refresh_text(lst_productID.Text)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.Close()
        frm_mainmenu_a175054.Show()
    End Sub
End Class
