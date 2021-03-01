<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_order_a175054
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_order_a175054))
        Me.Label = New System.Windows.Forms.Label()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btn_make = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.Transparent
        Me.Label.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Black
        Me.Label.Location = New System.Drawing.Point(34, 21)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(112, 24)
        Me.Label.TabIndex = 2
        Me.Label.Text = "ORDER LIST"
        '
        'grd_order
        '
        Me.grd_order.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(35, 93)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.RowHeadersWidth = 51
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(701, 267)
        Me.grd_order.TabIndex = 3
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(35, 384)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(51, 17)
        Me.lbl_total.TabIndex = 4
        Me.lbl_total.Text = "Label1"
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.Plum
        Me.btn_home.Location = New System.Drawing.Point(525, 36)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(103, 36)
        Me.btn_home.TabIndex = 5
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'btn_make
        '
        Me.btn_make.BackColor = System.Drawing.Color.Lime
        Me.btn_make.Location = New System.Drawing.Point(634, 36)
        Me.btn_make.Name = "btn_make"
        Me.btn_make.Size = New System.Drawing.Size(102, 36)
        Me.btn_make.TabIndex = 6
        Me.btn_make.Text = "Make Order"
        Me.btn_make.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(35, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "You can scroll to the right to view invoice"
        '
        'frm_order_a175054
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_make)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.Label)
        Me.Name = "frm_order_a175054"
        Me.Text = "frm_order_a175054"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label As Label
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents lbl_total As Label
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_make As Button
    Friend WithEvents Label1 As Label
End Class
