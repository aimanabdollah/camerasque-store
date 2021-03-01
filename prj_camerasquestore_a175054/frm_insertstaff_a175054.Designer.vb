<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertstaff_a175054
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertstaff_a175054))
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_staffID = New System.Windows.Forms.TextBox()
        Me.txt_staffName = New System.Windows.Forms.TextBox()
        Me.txt_staffAge = New System.Windows.Forms.TextBox()
        Me.btn_insertStaff = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_home = New System.Windows.Forms.Button()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_staff
        '
        Me.grd_staff.BackgroundColor = System.Drawing.Color.MediumPurple
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(40, 81)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.RowHeadersWidth = 51
        Me.grd_staff.RowTemplate.Height = 24
        Me.grd_staff.Size = New System.Drawing.Size(677, 234)
        Me.grd_staff.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Insert a New Staff"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Thistle
        Me.Label2.Location = New System.Drawing.Point(46, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Staff ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Thistle
        Me.Label3.Location = New System.Drawing.Point(193, 350)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Staff Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Thistle
        Me.Label4.Location = New System.Drawing.Point(350, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Staff Age"
        '
        'txt_staffID
        '
        Me.txt_staffID.Location = New System.Drawing.Point(40, 371)
        Me.txt_staffID.Name = "txt_staffID"
        Me.txt_staffID.Size = New System.Drawing.Size(100, 22)
        Me.txt_staffID.TabIndex = 5
        '
        'txt_staffName
        '
        Me.txt_staffName.Location = New System.Drawing.Point(196, 371)
        Me.txt_staffName.Name = "txt_staffName"
        Me.txt_staffName.Size = New System.Drawing.Size(100, 22)
        Me.txt_staffName.TabIndex = 6
        '
        'txt_staffAge
        '
        Me.txt_staffAge.Location = New System.Drawing.Point(353, 371)
        Me.txt_staffAge.Name = "txt_staffAge"
        Me.txt_staffAge.Size = New System.Drawing.Size(100, 22)
        Me.txt_staffAge.TabIndex = 7
        '
        'btn_insertStaff
        '
        Me.btn_insertStaff.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_insertStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertStaff.Location = New System.Drawing.Point(528, 350)
        Me.btn_insertStaff.Name = "btn_insertStaff"
        Me.btn_insertStaff.Size = New System.Drawing.Size(189, 44)
        Me.btn_insertStaff.TabIndex = 8
        Me.btn_insertStaff.Text = "INSERT STAFF"
        Me.btn_insertStaff.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(37, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(354, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Please enter the details of the new staff below :"
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.Plum
        Me.btn_home.Location = New System.Drawing.Point(614, 20)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(103, 36)
        Me.btn_home.TabIndex = 10
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'frm_insertstaff_a175054
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_insertStaff)
        Me.Controls.Add(Me.txt_staffAge)
        Me.Controls.Add(Me.txt_staffName)
        Me.Controls.Add(Me.txt_staffID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_staff)
        Me.Name = "frm_insertstaff_a175054"
        Me.Text = "frm_insertstaff_a175054"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_staffID As TextBox
    Friend WithEvents txt_staffName As TextBox
    Friend WithEvents txt_staffAge As TextBox
    Friend WithEvents btn_insertStaff As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_home As Button
End Class
