<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertcustomer_a175054
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertcustomer_a175054))
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_customerID = New System.Windows.Forms.TextBox()
        Me.txt_customerName = New System.Windows.Forms.TextBox()
        Me.txt_customerLocation = New System.Windows.Forms.TextBox()
        Me.btn_insertCustomer = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_home = New System.Windows.Forms.Button()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_customer
        '
        Me.grd_customer.BackgroundColor = System.Drawing.Color.MediumPurple
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(56, 93)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.RowHeadersWidth = 51
        Me.grd_customer.RowTemplate.Height = 24
        Me.grd_customer.Size = New System.Drawing.Size(696, 232)
        Me.grd_customer.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Thistle
        Me.Label1.Location = New System.Drawing.Point(58, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Thistle
        Me.Label2.Location = New System.Drawing.Point(208, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Thistle
        Me.Label3.Location = New System.Drawing.Point(384, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Customer Location"
        '
        'txt_customerID
        '
        Me.txt_customerID.BackColor = System.Drawing.SystemColors.Control
        Me.txt_customerID.Location = New System.Drawing.Point(56, 372)
        Me.txt_customerID.Name = "txt_customerID"
        Me.txt_customerID.Size = New System.Drawing.Size(126, 22)
        Me.txt_customerID.TabIndex = 4
        '
        'txt_customerName
        '
        Me.txt_customerName.Location = New System.Drawing.Point(211, 373)
        Me.txt_customerName.Name = "txt_customerName"
        Me.txt_customerName.Size = New System.Drawing.Size(156, 22)
        Me.txt_customerName.TabIndex = 5
        '
        'txt_customerLocation
        '
        Me.txt_customerLocation.Location = New System.Drawing.Point(387, 372)
        Me.txt_customerLocation.Name = "txt_customerLocation"
        Me.txt_customerLocation.Size = New System.Drawing.Size(146, 22)
        Me.txt_customerLocation.TabIndex = 6
        '
        'btn_insertCustomer
        '
        Me.btn_insertCustomer.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_insertCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertCustomer.Location = New System.Drawing.Point(581, 358)
        Me.btn_insertCustomer.Name = "btn_insertCustomer"
        Me.btn_insertCustomer.Size = New System.Drawing.Size(171, 37)
        Me.btn_insertCustomer.TabIndex = 7
        Me.btn_insertCustomer.Text = "INSERT CUSTOMER"
        Me.btn_insertCustomer.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(56, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(278, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Insert a New Customer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(58, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(388, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Please enter the details of the new customer below :"
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.Plum
        Me.btn_home.Location = New System.Drawing.Point(649, 43)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(103, 36)
        Me.btn_home.TabIndex = 11
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'frm_insertcustomer_a175054
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_insertCustomer)
        Me.Controls.Add(Me.txt_customerLocation)
        Me.Controls.Add(Me.txt_customerName)
        Me.Controls.Add(Me.txt_customerID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_customer)
        Me.Name = "frm_insertcustomer_a175054"
        Me.Text = "frm_insertcustomer_a175054"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_customerID As TextBox
    Friend WithEvents txt_customerName As TextBox
    Friend WithEvents txt_customerLocation As TextBox
    Friend WithEvents btn_insertCustomer As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_home As Button
End Class
