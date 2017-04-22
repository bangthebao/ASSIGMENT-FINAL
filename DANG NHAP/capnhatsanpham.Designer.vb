<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcapnhatsp
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
        Me.btnquaylai = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btncapnhat = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        Me.dgvsanpham = New System.Windows.Forms.DataGridView()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.txttenloai = New System.Windows.Forms.TextBox()
        Me.txtmaloai = New System.Windows.Forms.TextBox()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.lblsoluong = New System.Windows.Forms.Label()
        Me.lbltenloai = New System.Windows.Forms.Label()
        Me.lblmaloai = New System.Windows.Forms.Label()
        Me.lbltensp = New System.Windows.Forms.Label()
        Me.lblmasp = New System.Windows.Forms.Label()
        CType(Me.dgvsanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnquaylai
        '
        Me.btnquaylai.Location = New System.Drawing.Point(489, 133)
        Me.btnquaylai.Name = "btnquaylai"
        Me.btnquaylai.Size = New System.Drawing.Size(75, 23)
        Me.btnquaylai.TabIndex = 31
        Me.btnquaylai.Text = "Quay Lại"
        Me.btnquaylai.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(548, 87)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 30
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btncapnhat
        '
        Me.btncapnhat.Location = New System.Drawing.Point(436, 87)
        Me.btncapnhat.Name = "btncapnhat"
        Me.btncapnhat.Size = New System.Drawing.Size(75, 23)
        Me.btncapnhat.TabIndex = 29
        Me.btncapnhat.Text = "Cập Nhật"
        Me.btncapnhat.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(548, 36)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 28
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnload
        '
        Me.btnload.Location = New System.Drawing.Point(436, 36)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(75, 23)
        Me.btnload.TabIndex = 27
        Me.btnload.Text = "Load"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'dgvsanpham
        '
        Me.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsanpham.Location = New System.Drawing.Point(-1, 244)
        Me.dgvsanpham.Name = "dgvsanpham"
        Me.dgvsanpham.Size = New System.Drawing.Size(649, 176)
        Me.dgvsanpham.TabIndex = 26
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(118, 161)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(240, 20)
        Me.txtsoluong.TabIndex = 25
        '
        'txttenloai
        '
        Me.txttenloai.Location = New System.Drawing.Point(118, 133)
        Me.txttenloai.Name = "txttenloai"
        Me.txttenloai.Size = New System.Drawing.Size(240, 20)
        Me.txttenloai.TabIndex = 24
        '
        'txtmaloai
        '
        Me.txtmaloai.Location = New System.Drawing.Point(118, 98)
        Me.txtmaloai.Name = "txtmaloai"
        Me.txtmaloai.Size = New System.Drawing.Size(240, 20)
        Me.txtmaloai.TabIndex = 23
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(118, 65)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(240, 20)
        Me.txttensp.TabIndex = 22
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(118, 36)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(240, 20)
        Me.txtmasp.TabIndex = 21
        '
        'lblsoluong
        '
        Me.lblsoluong.AutoSize = True
        Me.lblsoluong.BackColor = System.Drawing.Color.Transparent
        Me.lblsoluong.Location = New System.Drawing.Point(41, 161)
        Me.lblsoluong.Name = "lblsoluong"
        Me.lblsoluong.Size = New System.Drawing.Size(53, 13)
        Me.lblsoluong.TabIndex = 20
        Me.lblsoluong.Text = "Số Lượng"
        '
        'lbltenloai
        '
        Me.lbltenloai.AutoSize = True
        Me.lbltenloai.BackColor = System.Drawing.Color.Transparent
        Me.lbltenloai.Location = New System.Drawing.Point(41, 133)
        Me.lbltenloai.Name = "lbltenloai"
        Me.lbltenloai.Size = New System.Drawing.Size(49, 13)
        Me.lbltenloai.TabIndex = 19
        Me.lbltenloai.Text = "Tên Loại"
        '
        'lblmaloai
        '
        Me.lblmaloai.AutoSize = True
        Me.lblmaloai.BackColor = System.Drawing.Color.Transparent
        Me.lblmaloai.Location = New System.Drawing.Point(41, 98)
        Me.lblmaloai.Name = "lblmaloai"
        Me.lblmaloai.Size = New System.Drawing.Size(45, 13)
        Me.lblmaloai.TabIndex = 18
        Me.lblmaloai.Text = "Mã Loại"
        '
        'lbltensp
        '
        Me.lbltensp.AutoSize = True
        Me.lbltensp.BackColor = System.Drawing.Color.Transparent
        Me.lbltensp.Location = New System.Drawing.Point(41, 65)
        Me.lbltensp.Name = "lbltensp"
        Me.lbltensp.Size = New System.Drawing.Size(43, 13)
        Me.lbltensp.TabIndex = 17
        Me.lbltensp.Text = "Tên SP"
        '
        'lblmasp
        '
        Me.lblmasp.AutoSize = True
        Me.lblmasp.BackColor = System.Drawing.Color.Transparent
        Me.lblmasp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblmasp.Location = New System.Drawing.Point(41, 36)
        Me.lblmasp.Name = "lblmasp"
        Me.lblmasp.Size = New System.Drawing.Size(39, 13)
        Me.lblmasp.TabIndex = 16
        Me.lblmasp.Text = "Mã SP"
        '
        'frmcapnhatkh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._14
        Me.ClientSize = New System.Drawing.Size(645, 421)
        Me.Controls.Add(Me.btnquaylai)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btncapnhat)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.dgvsanpham)
        Me.Controls.Add(Me.txtsoluong)
        Me.Controls.Add(Me.txttenloai)
        Me.Controls.Add(Me.txtmaloai)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.txtmasp)
        Me.Controls.Add(Me.lblsoluong)
        Me.Controls.Add(Me.lbltenloai)
        Me.Controls.Add(Me.lblmaloai)
        Me.Controls.Add(Me.lbltensp)
        Me.Controls.Add(Me.lblmasp)
        Me.Name = "frmcapnhatkh"
        Me.Text = "capnhatsanpham"
        CType(Me.dgvsanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnquaylai As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btncapnhat As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnload As System.Windows.Forms.Button
    Friend WithEvents dgvsanpham As System.Windows.Forms.DataGridView
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents txttenloai As System.Windows.Forms.TextBox
    Friend WithEvents txtmaloai As System.Windows.Forms.TextBox
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents lblsoluong As System.Windows.Forms.Label
    Friend WithEvents lbltenloai As System.Windows.Forms.Label
    Friend WithEvents lblmaloai As System.Windows.Forms.Label
    Friend WithEvents lbltensp As System.Windows.Forms.Label
    Friend WithEvents lblmasp As System.Windows.Forms.Label
End Class
