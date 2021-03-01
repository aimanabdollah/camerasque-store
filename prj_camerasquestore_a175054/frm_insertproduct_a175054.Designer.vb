<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_insertproduct_a175054
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertproduct_a175054))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.txt_productID = New System.Windows.Forms.TextBox()
        Me.txt_productPrice = New System.Windows.Forms.TextBox()
        Me.txt_warrantyLength = New System.Windows.Forms.TextBox()
        Me.txt_productName = New System.Windows.Forms.TextBox()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.cmb_userLevel = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_manufacturerName = New System.Windows.Forms.TextBox()
        Me.btn_home = New System.Windows.Forms.Button()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(24, 28)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(256, 29)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Insert a New Product"
        '
        'grd_product
        '
        Me.grd_product.BackgroundColor = System.Drawing.Color.MediumPurple
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(27, 283)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.RowHeadersWidth = 51
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(601, 155)
        Me.grd_product.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please enter the details of the new product  below :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Thistle
        Me.Label2.Location = New System.Drawing.Point(26, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Thistle
        Me.Label3.Location = New System.Drawing.Point(354, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Product Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Thistle
        Me.Label4.Location = New System.Drawing.Point(354, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Product Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Thistle
        Me.Label5.Location = New System.Drawing.Point(26, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Quantity Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Thistle
        Me.Label6.Location = New System.Drawing.Point(354, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Warranty Length"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Thistle
        Me.Label7.Location = New System.Drawing.Point(26, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "User Level"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Thistle
        Me.Label8.Location = New System.Drawing.Point(24, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Manufacturer Name"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(655, 321)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(122, 50)
        Me.btn_insert.TabIndex = 10
        Me.btn_insert.Text = "INSERT PRODUCT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'txt_productID
        '
        Me.txt_productID.Location = New System.Drawing.Point(176, 90)
        Me.txt_productID.Name = "txt_productID"
        Me.txt_productID.Size = New System.Drawing.Size(141, 22)
        Me.txt_productID.TabIndex = 11
        '
        'txt_productPrice
        '
        Me.txt_productPrice.Location = New System.Drawing.Point(497, 164)
        Me.txt_productPrice.Name = "txt_productPrice"
        Me.txt_productPrice.Size = New System.Drawing.Size(100, 22)
        Me.txt_productPrice.TabIndex = 12
        '
        'txt_warrantyLength
        '
        Me.txt_warrantyLength.Location = New System.Drawing.Point(497, 126)
        Me.txt_warrantyLength.Name = "txt_warrantyLength"
        Me.txt_warrantyLength.Size = New System.Drawing.Size(280, 22)
        Me.txt_warrantyLength.TabIndex = 13
        '
        'txt_productName
        '
        Me.txt_productName.Location = New System.Drawing.Point(497, 90)
        Me.txt_productName.Name = "txt_productName"
        Me.txt_productName.Size = New System.Drawing.Size(280, 22)
        Me.txt_productName.TabIndex = 14
        '
        'txt_stock
        '
        Me.txt_stock.Location = New System.Drawing.Point(176, 126)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(141, 22)
        Me.txt_stock.TabIndex = 15
        '
        'cmb_userLevel
        '
        Me.cmb_userLevel.FormattingEnabled = True
        Me.cmb_userLevel.Location = New System.Drawing.Point(176, 204)
        Me.cmb_userLevel.Name = "cmb_userLevel"
        Me.cmb_userLevel.Size = New System.Drawing.Size(141, 24)
        Me.cmb_userLevel.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Thistle
        Me.Label9.Location = New System.Drawing.Point(26, 245)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Product Photo Path"
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(176, 245)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(452, 22)
        Me.txt_picture.TabIndex = 19
        '
        'btn_picture
        '
        Me.btn_picture.BackColor = System.Drawing.Color.Thistle
        Me.btn_picture.Location = New System.Drawing.Point(655, 283)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(122, 23)
        Me.btn_picture.TabIndex = 20
        Me.btn_picture.Text = "Select Photo"
        Me.btn_picture.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(655, 164)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(122, 113)
        Me.pic_product.TabIndex = 21
        Me.pic_product.TabStop = False
        '
        'txt_manufacturerName
        '
        Me.txt_manufacturerName.Location = New System.Drawing.Point(176, 164)
        Me.txt_manufacturerName.Name = "txt_manufacturerName"
        Me.txt_manufacturerName.Size = New System.Drawing.Size(141, 22)
        Me.txt_manufacturerName.TabIndex = 23
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.Plum
        Me.btn_home.Location = New System.Drawing.Point(655, 377)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(122, 45)
        Me.btn_home.TabIndex = 24
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'frm_insertproduct_a175054
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.txt_manufacturerName)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmb_userLevel)
        Me.Controls.Add(Me.txt_stock)
        Me.Controls.Add(Me.txt_productName)
        Me.Controls.Add(Me.txt_warrantyLength)
        Me.Controls.Add(Me.txt_productPrice)
        Me.Controls.Add(Me.txt_productID)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_insertproduct_a175054"
        Me.Text = "frm_insertproduct_a175054"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_product As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents txt_productID As TextBox
    Friend WithEvents txt_productPrice As TextBox
    Friend WithEvents txt_warrantyLength As TextBox
    Friend WithEvents txt_productName As TextBox
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents cmb_userLevel As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_manufacturerName As TextBox
    Friend WithEvents btn_home As Button
End Class
