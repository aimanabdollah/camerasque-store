<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_catalogproduct_a175054
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_catalogproduct_a175054))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lst_productID = New System.Windows.Forms.ListBox()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_productID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_productName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_productPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_warrantyLength = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_userLevel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_manufacturerName = New System.Windows.Forms.TextBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.btn_home = New System.Windows.Forms.Button()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(24, 24)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(191, 29)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Product Details"
        '
        'lst_productID
        '
        Me.lst_productID.BackColor = System.Drawing.Color.MediumPurple
        Me.lst_productID.FormattingEnabled = True
        Me.lst_productID.ItemHeight = 16
        Me.lst_productID.Location = New System.Drawing.Point(29, 118)
        Me.lst_productID.Name = "lst_productID"
        Me.lst_productID.Size = New System.Drawing.Size(158, 308)
        Me.lst_productID.TabIndex = 1
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoSize = True
        Me.lbl_desc.BackColor = System.Drawing.Color.Black
        Me.lbl_desc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc.ForeColor = System.Drawing.Color.White
        Me.lbl_desc.Location = New System.Drawing.Point(26, 87)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(167, 16)
        Me.lbl_desc.TabIndex = 2
        Me.lbl_desc.Text = "Select a ProductID here"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Thistle
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(404, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Product ID"
        '
        'txt_productID
        '
        Me.txt_productID.BackColor = System.Drawing.Color.MediumPurple
        Me.txt_productID.Location = New System.Drawing.Point(405, 102)
        Me.txt_productID.Name = "txt_productID"
        Me.txt_productID.ReadOnly = True
        Me.txt_productID.Size = New System.Drawing.Size(164, 22)
        Me.txt_productID.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Thistle
        Me.Label2.Location = New System.Drawing.Point(404, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Product Name"
        '
        'txt_productName
        '
        Me.txt_productName.BackColor = System.Drawing.Color.MediumPurple
        Me.txt_productName.Location = New System.Drawing.Point(402, 166)
        Me.txt_productName.Name = "txt_productName"
        Me.txt_productName.ReadOnly = True
        Me.txt_productName.Size = New System.Drawing.Size(167, 22)
        Me.txt_productName.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Thistle
        Me.Label3.Location = New System.Drawing.Point(584, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Product Price"
        '
        'txt_productPrice
        '
        Me.txt_productPrice.BackColor = System.Drawing.Color.MediumPurple
        Me.txt_productPrice.Location = New System.Drawing.Point(587, 166)
        Me.txt_productPrice.Name = "txt_productPrice"
        Me.txt_productPrice.ReadOnly = True
        Me.txt_productPrice.Size = New System.Drawing.Size(175, 22)
        Me.txt_productPrice.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Thistle
        Me.Label4.Location = New System.Drawing.Point(402, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Quantity Stock"
        '
        'txt_stock
        '
        Me.txt_stock.BackColor = System.Drawing.Color.MediumPurple
        Me.txt_stock.Location = New System.Drawing.Point(402, 230)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.ReadOnly = True
        Me.txt_stock.Size = New System.Drawing.Size(167, 22)
        Me.txt_stock.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Thistle
        Me.Label5.Location = New System.Drawing.Point(402, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Warranty Length"
        '
        'txt_warrantyLength
        '
        Me.txt_warrantyLength.BackColor = System.Drawing.Color.MediumPurple
        Me.txt_warrantyLength.Location = New System.Drawing.Point(402, 292)
        Me.txt_warrantyLength.Name = "txt_warrantyLength"
        Me.txt_warrantyLength.ReadOnly = True
        Me.txt_warrantyLength.Size = New System.Drawing.Size(167, 22)
        Me.txt_warrantyLength.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Thistle
        Me.Label6.Location = New System.Drawing.Point(584, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "User Level"
        '
        'txt_userLevel
        '
        Me.txt_userLevel.BackColor = System.Drawing.Color.MediumPurple
        Me.txt_userLevel.Location = New System.Drawing.Point(582, 230)
        Me.txt_userLevel.Name = "txt_userLevel"
        Me.txt_userLevel.ReadOnly = True
        Me.txt_userLevel.Size = New System.Drawing.Size(180, 22)
        Me.txt_userLevel.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Thistle
        Me.Label7.Location = New System.Drawing.Point(584, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Manufacturer Name"
        '
        'txt_manufacturerName
        '
        Me.txt_manufacturerName.BackColor = System.Drawing.Color.MediumPurple
        Me.txt_manufacturerName.Location = New System.Drawing.Point(587, 292)
        Me.txt_manufacturerName.Name = "txt_manufacturerName"
        Me.txt_manufacturerName.ReadOnly = True
        Me.txt_manufacturerName.Size = New System.Drawing.Size(180, 22)
        Me.txt_manufacturerName.TabIndex = 16
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(229, 82)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(155, 140)
        Me.pic_product.TabIndex = 17
        Me.pic_product.TabStop = False
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.Plum
        Me.btn_home.Location = New System.Drawing.Point(664, 24)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(103, 36)
        Me.btn_home.TabIndex = 18
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'frm_catalogproduct_a175054
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_manufacturerName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_userLevel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_warrantyLength)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_stock)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_productPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_productName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_productID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_desc)
        Me.Controls.Add(Me.lst_productID)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_catalogproduct_a175054"
        Me.Text = "frm_catalogproduct_a175054"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lst_productID As ListBox
    Friend WithEvents lbl_desc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_productID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_productName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_productPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_warrantyLength As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_userLevel As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_manufacturerName As TextBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents btn_home As Button
End Class
