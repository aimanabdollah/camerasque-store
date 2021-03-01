<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderproducttable_a175054
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orderproducttable_a175054))
        Me.grd_orderproduct = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_home = New System.Windows.Forms.Button()
        CType(Me.grd_orderproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_orderproduct
        '
        Me.grd_orderproduct.BackgroundColor = System.Drawing.Color.MediumPurple
        Me.grd_orderproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderproduct.Location = New System.Drawing.Point(30, 77)
        Me.grd_orderproduct.Name = "grd_orderproduct"
        Me.grd_orderproduct.ReadOnly = True
        Me.grd_orderproduct.RowHeadersWidth = 51
        Me.grd_orderproduct.RowTemplate.Height = 24
        Me.grd_orderproduct.Size = New System.Drawing.Size(741, 346)
        Me.grd_orderproduct.TabIndex = 0
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(25, 27)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(253, 29)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Table Order Product"
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.Plum
        Me.btn_home.Location = New System.Drawing.Point(668, 20)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(103, 36)
        Me.btn_home.TabIndex = 6
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'frm_orderproducttable_a175054
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grd_orderproduct)
        Me.Name = "frm_orderproducttable_a175054"
        Me.Text = "frm_orderproducttable_a175054"
        CType(Me.grd_orderproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_orderproduct As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_home As Button
End Class
