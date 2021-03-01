<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_managestaff_a175054
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_managestaff_a175054))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_staffID = New System.Windows.Forms.TextBox()
        Me.txt_staffName = New System.Windows.Forms.TextBox()
        Me.txt_staffAge = New System.Windows.Forms.TextBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Staff"
        '
        'grd_staff
        '
        Me.grd_staff.AllowUserToAddRows = False
        Me.grd_staff.BackgroundColor = System.Drawing.Color.MediumPurple
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(30, 75)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.ReadOnly = True
        Me.grd_staff.RowHeadersWidth = 51
        Me.grd_staff.RowTemplate.Height = 24
        Me.grd_staff.Size = New System.Drawing.Size(724, 251)
        Me.grd_staff.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Thistle
        Me.Label2.Location = New System.Drawing.Point(340, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Staff Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Thistle
        Me.Label3.Location = New System.Drawing.Point(184, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Staff Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Thistle
        Me.Label4.Location = New System.Drawing.Point(38, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Staff ID"
        '
        'txt_staffID
        '
        Me.txt_staffID.Location = New System.Drawing.Point(41, 382)
        Me.txt_staffID.Name = "txt_staffID"
        Me.txt_staffID.ReadOnly = True
        Me.txt_staffID.Size = New System.Drawing.Size(100, 22)
        Me.txt_staffID.TabIndex = 5
        '
        'txt_staffName
        '
        Me.txt_staffName.Location = New System.Drawing.Point(187, 382)
        Me.txt_staffName.Name = "txt_staffName"
        Me.txt_staffName.Size = New System.Drawing.Size(97, 22)
        Me.txt_staffName.TabIndex = 6
        '
        'txt_staffAge
        '
        Me.txt_staffAge.Location = New System.Drawing.Point(343, 382)
        Me.txt_staffAge.Name = "txt_staffAge"
        Me.txt_staffAge.Size = New System.Drawing.Size(100, 22)
        Me.txt_staffAge.TabIndex = 7
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.LightGreen
        Me.btn_update.Location = New System.Drawing.Point(510, 338)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(119, 56)
        Me.btn_update.TabIndex = 8
        Me.btn_update.Text = "UPDATE STAFF"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.Location = New System.Drawing.Point(635, 338)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(119, 56)
        Me.btn_delete.TabIndex = 9
        Me.btn_delete.Text = "DELETE STAFF"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.Plum
        Me.btn_home.Location = New System.Drawing.Point(651, 16)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(103, 36)
        Me.btn_home.TabIndex = 10
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'frm_managestaff_a175054
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_staffAge)
        Me.Controls.Add(Me.txt_staffName)
        Me.Controls.Add(Me.txt_staffID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grd_staff)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_managestaff_a175054"
        Me.Text = "frm_managestaff_a175054"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_staffID As TextBox
    Friend WithEvents txt_staffName As TextBox
    Friend WithEvents txt_staffAge As TextBox
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_home As Button
End Class
