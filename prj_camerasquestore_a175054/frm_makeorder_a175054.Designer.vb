<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_makeorder_a175054
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeorder_a175054))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_staff = New System.Windows.Forms.ComboBox()
        Me.cmb_customer = New System.Windows.Forms.ComboBox()
        Me.Product = New System.Windows.Forms.GroupBox()
        Me.lbl_error_quantity = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.cmb_product = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dg_cart = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblrm = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_make = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Product.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg_cart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MAKE ORDER FORM"
        '
        'cmb_staff
        '
        Me.cmb_staff.FormattingEnabled = True
        Me.cmb_staff.Location = New System.Drawing.Point(165, 205)
        Me.cmb_staff.Name = "cmb_staff"
        Me.cmb_staff.Size = New System.Drawing.Size(170, 24)
        Me.cmb_staff.TabIndex = 0
        '
        'cmb_customer
        '
        Me.cmb_customer.FormattingEnabled = True
        Me.cmb_customer.Location = New System.Drawing.Point(649, 201)
        Me.cmb_customer.Name = "cmb_customer"
        Me.cmb_customer.Size = New System.Drawing.Size(170, 24)
        Me.cmb_customer.TabIndex = 1
        '
        'Product
        '
        Me.Product.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Product.Controls.Add(Me.lbl_error_quantity)
        Me.Product.Controls.Add(Me.Label3)
        Me.Product.Controls.Add(Me.Label2)
        Me.Product.Controls.Add(Me.Label4)
        Me.Product.Controls.Add(Me.btn_add)
        Me.Product.Controls.Add(Me.txt_quantity)
        Me.Product.Controls.Add(Me.cmb_product)
        Me.Product.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product.Location = New System.Drawing.Point(32, 250)
        Me.Product.Name = "Product"
        Me.Product.Size = New System.Drawing.Size(787, 130)
        Me.Product.TabIndex = 3
        Me.Product.TabStop = False
        Me.Product.Text = "Product"
        '
        'lbl_error_quantity
        '
        Me.lbl_error_quantity.AutoSize = True
        Me.lbl_error_quantity.Location = New System.Drawing.Point(64, 19)
        Me.lbl_error_quantity.Name = "lbl_error_quantity"
        Me.lbl_error_quantity.Size = New System.Drawing.Size(150, 20)
        Me.lbl_error_quantity.TabIndex = 6
        Me.lbl_error_quantity.Text = "Fill your order details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Product"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(325, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = ":"
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Lime
        Me.btn_add.Location = New System.Drawing.Point(590, 60)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(128, 42)
        Me.btn_add.TabIndex = 2
        Me.btn_add.Text = "Add to Cart"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(329, 83)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(135, 24)
        Me.txt_quantity.TabIndex = 1
        '
        'cmb_product
        '
        Me.cmb_product.FormattingEnabled = True
        Me.cmb_product.Location = New System.Drawing.Point(68, 83)
        Me.cmb_product.Name = "cmb_product"
        Me.cmb_product.Size = New System.Drawing.Size(170, 27)
        Me.cmb_product.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.dg_cart)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(32, 402)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(787, 196)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cart"
        '
        'dg_cart
        '
        Me.dg_cart.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dg_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_cart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_name, Me.col_quantity, Me.col_total})
        Me.dg_cart.Location = New System.Drawing.Point(34, 48)
        Me.dg_cart.Name = "dg_cart"
        Me.dg_cart.RowHeadersWidth = 51
        Me.dg_cart.RowTemplate.Height = 24
        Me.dg_cart.Size = New System.Drawing.Size(731, 134)
        Me.dg_cart.TabIndex = 0
        '
        'col_id
        '
        Me.col_id.HeaderText = "Product ID"
        Me.col_id.MinimumWidth = 6
        Me.col_id.Name = "col_id"
        Me.col_id.Width = 125
        '
        'col_name
        '
        Me.col_name.HeaderText = "Product Name"
        Me.col_name.MinimumWidth = 6
        Me.col_name.Name = "col_name"
        Me.col_name.Width = 125
        '
        'col_quantity
        '
        Me.col_quantity.HeaderText = "Quantity"
        Me.col_quantity.MinimumWidth = 6
        Me.col_quantity.Name = "col_quantity"
        Me.col_quantity.Width = 125
        '
        'col_total
        '
        Me.col_total.HeaderText = "SubTotal (RM)"
        Me.col_total.MinimumWidth = 6
        Me.col_total.Name = "col_total"
        Me.col_total.Width = 125
        '
        'lblrm
        '
        Me.lblrm.AutoSize = True
        Me.lblrm.BackColor = System.Drawing.Color.Transparent
        Me.lblrm.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrm.Location = New System.Drawing.Point(298, 611)
        Me.lblrm.Name = "lblrm"
        Me.lblrm.Size = New System.Drawing.Size(110, 20)
        Me.lblrm.TabIndex = 5
        Me.lblrm.Text = "Total Price: RM"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Plum
        Me.btn_back.Location = New System.Drawing.Point(32, 652)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(128, 33)
        Me.btn_back.TabIndex = 3
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.SkyBlue
        Me.btn_clear.Location = New System.Drawing.Point(349, 652)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(128, 33)
        Me.btn_clear.TabIndex = 6
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_make
        '
        Me.btn_make.BackColor = System.Drawing.Color.Lime
        Me.btn_make.Location = New System.Drawing.Point(691, 652)
        Me.btn_make.Name = "btn_make"
        Me.btn_make.Size = New System.Drawing.Size(128, 33)
        Me.btn_make.TabIndex = 7
        Me.btn_make.Text = "Confirm Order"
        Me.btn_make.UseVisualStyleBackColor = False
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(414, 611)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(53, 20)
        Me.lbl_total.TabIndex = 8
        Me.lbl_total.Text = "Label5"
        '
        'lbl_orderid
        '
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.Location = New System.Drawing.Point(126, 164)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(76, 20)
        Me.lbl_orderid.TabIndex = 7
        Me.lbl_orderid.Text = "ORDER ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ORDER ID :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(176, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(227, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Camerasque Store SDN. BHD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(176, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 80)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Lot 17-B, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jalan Seksyen 4/11," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Taman Reko Kajang," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "43600 Kajang Selangor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Select Staff ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(463, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Select Customer ID"
        '
        'frm_makeorder_a175054
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(851, 725)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_staff)
        Me.Controls.Add(Me.cmb_customer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.btn_make)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lblrm)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Product)
        Me.Name = "frm_makeorder_a175054"
        Me.Text = "frm_makeorder_a175054"
        Me.Product.ResumeLayout(False)
        Me.Product.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dg_cart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_staff As ComboBox
    Friend WithEvents cmb_customer As ComboBox
    Friend WithEvents Product As GroupBox
    Friend WithEvents btn_add As Button
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents cmb_product As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dg_cart As DataGridView
    Friend WithEvents lblrm As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_make As Button
    Friend WithEvents lbl_error_quantity As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_orderid As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents col_name As DataGridViewTextBoxColumn
    Friend WithEvents col_quantity As DataGridViewTextBoxColumn
    Friend WithEvents col_total As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
