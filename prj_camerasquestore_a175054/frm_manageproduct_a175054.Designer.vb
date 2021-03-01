<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_manageproduct_a175054
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_manageproduct_a175054))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_productID = New System.Windows.Forms.TextBox()
        Me.txt_warrantyLength = New System.Windows.Forms.TextBox()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.txt_productPrice = New System.Windows.Forms.TextBox()
        Me.txt_productName = New System.Windows.Forms.TextBox()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.txt_manufacturerName = New System.Windows.Forms.TextBox()
        Me.cmb_userLevel = New System.Windows.Forms.ComboBox()
        Me.btn_home = New System.Windows.Forms.Button()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(34, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Product"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Thistle
        Me.Label2.Location = New System.Drawing.Point(34, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Manufacturer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Thistle
        Me.Label3.Location = New System.Drawing.Point(572, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User Level"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Thistle
        Me.Label4.Location = New System.Drawing.Point(290, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Warranty Length"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Thistle
        Me.Label5.Location = New System.Drawing.Point(34, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Quantity Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Thistle
        Me.Label6.Location = New System.Drawing.Point(290, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Product Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Thistle
        Me.Label7.Location = New System.Drawing.Point(292, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Product Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Thistle
        Me.Label8.Location = New System.Drawing.Point(36, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Product ID"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.LightGreen
        Me.btn_update.Location = New System.Drawing.Point(561, 143)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(99, 49)
        Me.btn_update.TabIndex = 8
        Me.btn_update.Text = "UPDATE PRODUCT"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.Location = New System.Drawing.Point(666, 143)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(106, 49)
        Me.btn_delete.TabIndex = 9
        Me.btn_delete.Text = "DELETE PRODUCT"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'txt_productID
        '
        Me.txt_productID.Location = New System.Drawing.Point(173, 77)
        Me.txt_productID.Name = "txt_productID"
        Me.txt_productID.ReadOnly = True
        Me.txt_productID.Size = New System.Drawing.Size(101, 22)
        Me.txt_productID.TabIndex = 12
        '
        'txt_warrantyLength
        '
        Me.txt_warrantyLength.Location = New System.Drawing.Point(410, 111)
        Me.txt_warrantyLength.Name = "txt_warrantyLength"
        Me.txt_warrantyLength.Size = New System.Drawing.Size(107, 22)
        Me.txt_warrantyLength.TabIndex = 13
        '
        'txt_stock
        '
        Me.txt_stock.Location = New System.Drawing.Point(173, 111)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(100, 22)
        Me.txt_stock.TabIndex = 14
        '
        'txt_productPrice
        '
        Me.txt_productPrice.Location = New System.Drawing.Point(410, 148)
        Me.txt_productPrice.Name = "txt_productPrice"
        Me.txt_productPrice.Size = New System.Drawing.Size(118, 22)
        Me.txt_productPrice.TabIndex = 15
        '
        'txt_productName
        '
        Me.txt_productName.Location = New System.Drawing.Point(410, 77)
        Me.txt_productName.Name = "txt_productName"
        Me.txt_productName.Size = New System.Drawing.Size(362, 22)
        Me.txt_productName.TabIndex = 16
        '
        'grd_product
        '
        Me.grd_product.AllowUserToAddRows = False
        Me.grd_product.BackgroundColor = System.Drawing.Color.MediumPurple
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(37, 198)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.ReadOnly = True
        Me.grd_product.RowHeadersWidth = 51
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(735, 222)
        Me.grd_product.TabIndex = 17
        '
        'txt_manufacturerName
        '
        Me.txt_manufacturerName.Location = New System.Drawing.Point(173, 148)
        Me.txt_manufacturerName.Name = "txt_manufacturerName"
        Me.txt_manufacturerName.Size = New System.Drawing.Size(100, 22)
        Me.txt_manufacturerName.TabIndex = 18
        '
        'cmb_userLevel
        '
        Me.cmb_userLevel.FormattingEnabled = True
        Me.cmb_userLevel.Location = New System.Drawing.Point(665, 105)
        Me.cmb_userLevel.Name = "cmb_userLevel"
        Me.cmb_userLevel.Size = New System.Drawing.Size(107, 24)
        Me.cmb_userLevel.TabIndex = 20
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.Plum
        Me.btn_home.Location = New System.Drawing.Point(666, 23)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(103, 36)
        Me.btn_home.TabIndex = 21
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'frm_manageproduct_a175054
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.cmb_userLevel)
        Me.Controls.Add(Me.txt_manufacturerName)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.txt_productName)
        Me.Controls.Add(Me.txt_productPrice)
        Me.Controls.Add(Me.txt_stock)
        Me.Controls.Add(Me.txt_warrantyLength)
        Me.Controls.Add(Me.txt_productID)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_manageproduct_a175054"
        Me.Text = "frm_manageproduct_a175054"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_productID As TextBox
    Friend WithEvents txt_warrantyLength As TextBox
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents txt_productPrice As TextBox
    Friend WithEvents txt_productName As TextBox
    Friend WithEvents grd_product As DataGridView
    Friend WithEvents txt_manufacturerName As TextBox
    Friend WithEvents cmb_userLevel As ComboBox
    Friend WithEvents btn_home As Button
End Class
