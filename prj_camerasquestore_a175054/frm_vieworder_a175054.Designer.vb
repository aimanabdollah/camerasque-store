<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vieworder_a175054
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_vieworder_a175054))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_cust = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_staff = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INVOICE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(191, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Camerasque Store SDN. BHD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(191, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 80)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lot 17-B, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jalan Seksyen 4/11," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Taman Reko Kajang," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "43600 Kajang Selangor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Order ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(417, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Order Date:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(139, 181)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(68, 20)
        Me.lbl_id.TabIndex = 5
        Me.lbl_id.Text = "order id"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(517, 181)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(42, 20)
        Me.lbl_date.TabIndex = 6
        Me.lbl_date.Text = "date"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(51, 224)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(641, 160)
        Me.DataGridView1.TabIndex = 7
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(380, 403)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(36, 18)
        Me.lbl_total.TabIndex = 9
        Me.lbl_total.Text = "total"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Plum
        Me.btn_back.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_back.Location = New System.Drawing.Point(51, 403)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(82, 35)
        Me.btn_back.TabIndex = 10
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(51, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(251, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total Price : RM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(58, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Customer ID:"
        '
        'lbl_cust
        '
        Me.lbl_cust.AutoSize = True
        Me.lbl_cust.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cust.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cust.Location = New System.Drawing.Point(167, 201)
        Me.lbl_cust.Name = "lbl_cust"
        Me.lbl_cust.Size = New System.Drawing.Size(96, 20)
        Me.lbl_cust.TabIndex = 14
        Me.lbl_cust.Text = "customer id"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(417, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Staff ID:"
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staff.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff.Location = New System.Drawing.Point(488, 201)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(58, 20)
        Me.lbl_staff.TabIndex = 16
        Me.lbl_staff.Text = "staff id"
        '
        'frm_vieworder_a175054
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(759, 450)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_cust)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_vieworder_a175054"
        Me.Text = "frm_vieworder_a175054"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_total As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_cust As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_staff As Label
End Class
