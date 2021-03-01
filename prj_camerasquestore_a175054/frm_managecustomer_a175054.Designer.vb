<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_managecustomer_a175054
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_managecustomer_a175054))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_customerID = New System.Windows.Forms.TextBox()
        Me.txt_customerName = New System.Windows.Forms.TextBox()
        Me.txt_customerLocation = New System.Windows.Forms.TextBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Customer"
        '
        'grd_customer
        '
        Me.grd_customer.AllowUserToAddRows = False
        Me.grd_customer.BackgroundColor = System.Drawing.Color.MediumPurple
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(28, 86)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.ReadOnly = True
        Me.grd_customer.RowHeadersWidth = 51
        Me.grd_customer.RowTemplate.Height = 24
        Me.grd_customer.Size = New System.Drawing.Size(722, 237)
        Me.grd_customer.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Thistle
        Me.Label2.Location = New System.Drawing.Point(34, 365)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Thistle
        Me.Label3.Location = New System.Drawing.Point(188, 370)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Customer Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Thistle
        Me.Label4.Location = New System.Drawing.Point(367, 370)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Customer Location"
        '
        'txt_customerID
        '
        Me.txt_customerID.Location = New System.Drawing.Point(28, 391)
        Me.txt_customerID.Name = "txt_customerID"
        Me.txt_customerID.ReadOnly = True
        Me.txt_customerID.Size = New System.Drawing.Size(132, 22)
        Me.txt_customerID.TabIndex = 5
        '
        'txt_customerName
        '
        Me.txt_customerName.Location = New System.Drawing.Point(191, 391)
        Me.txt_customerName.Name = "txt_customerName"
        Me.txt_customerName.Size = New System.Drawing.Size(150, 22)
        Me.txt_customerName.TabIndex = 6
        '
        'txt_customerLocation
        '
        Me.txt_customerLocation.Location = New System.Drawing.Point(370, 390)
        Me.txt_customerLocation.Name = "txt_customerLocation"
        Me.txt_customerLocation.Size = New System.Drawing.Size(148, 22)
        Me.txt_customerLocation.TabIndex = 7
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.LightGreen
        Me.btn_update.Location = New System.Drawing.Point(546, 365)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(103, 48)
        Me.btn_update.TabIndex = 8
        Me.btn_update.Text = "UPDATE CUSTOMER"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.Location = New System.Drawing.Point(675, 367)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(101, 46)
        Me.btn_delete.TabIndex = 9
        Me.btn_delete.Text = "DELETE CUSTOMER"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.Plum
        Me.btn_home.Location = New System.Drawing.Point(647, 26)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(103, 36)
        Me.btn_home.TabIndex = 10
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'frm_managecustomer_a175054
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_customerLocation)
        Me.Controls.Add(Me.txt_customerName)
        Me.Controls.Add(Me.txt_customerID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grd_customer)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_managecustomer_a175054"
        Me.Text = "frm_managecustomer_a175054"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_customerID As TextBox
    Friend WithEvents txt_customerName As TextBox
    Friend WithEvents txt_customerLocation As TextBox
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_home As Button
End Class
