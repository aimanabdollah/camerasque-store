Public Class frm_insertproduct_a175054

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"

    Private Sub frm_insertproduct_a175054_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_userLevel.Items.Add("Beginner")
        cmb_userLevel.Items.Add("Intermediate")
        cmb_userLevel.Items.Add("Expert")
        cmb_userLevel.SelectedIndex = 0

        'cmb_manufacturerName.DataSource = run_select("SELECT FLD_MANUFACTURER_NAME FROM TBL_MANUFACTURER_A175054")
        'cmb_manufacturerName.DisplayMember = "FLD_MANUFACTURER_NAME"

        refresh_grid()



        'MsgBox(defaultpicture)

    End Sub

    Private Sub refresh_grid()

        grd_product.DataSource = run_select("SELECT * FROM TBL_PRODUCT_A175054")

        txt_productID.Text = generate_productID()

        txt_productName.Text = ""
        txt_productPrice.Text = ""
        txt_stock.Text = ""
        txt_warrantyLength.Text = ""
        txt_manufacturerName.Text = ""
        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Function generate_productID() As String

        Dim lastID As String = run_select("SELECT MAX(FLD_PRODUCT_ID) AS MAXID FROM TBL_PRODUCT_A175054").Rows(0).Item("MAXID")




        Dim newID As String = "P" & Mid(lastID, 2) + 1

        Return newID

    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click


        Dim mysql As String = "INSERT INTO TBL_PRODUCT_A175054 VALUES ('" & txt_productID.Text & "', '" & txt_productName.Text & "', '" & txt_productPrice.Text & "','" & txt_stock.Text & "','" & txt_warrantyLength.Text & "','" & cmb_userLevel.Text & "','" & txt_manufacturerName.Text & "')"

        MsgBox(mysql)

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_productID.Text & ".jpg")

            refresh_grid()


        Catch ex As Exception

            Beep()
            MsgBox("There is a Mistake in the data that you entered as shown below: " & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()


        End Try

    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        txt_picture.Text = OpenFileDialog1.FileName

        Try
            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        Catch ex As Exception
            txt_picture.Text = defaultpicture
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)
        End Try




    End Sub

    Private Sub txt_productID_TextChanged(sender As Object, e As EventArgs) Handles txt_productID.TextChanged

    End Sub

    Private Sub cmb_userLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_userLevel.SelectedIndexChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.Close()
        frm_mainmenu_a175054.Show()
    End Sub
End Class
