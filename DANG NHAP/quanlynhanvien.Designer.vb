<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quanlynhanvien
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
        Me.btnload = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.dataview = New System.Windows.Forms.DataGridView()
        Me.btndong = New System.Windows.Forms.Button()
        Me.txtloainv = New System.Windows.Forms.TextBox()
        Me.txthoten = New System.Windows.Forms.TextBox()
        Me.txtmanv = New System.Windows.Forms.TextBox()
        Me.lbloainv = New System.Windows.Forms.Label()
        Me.lblhoten = New System.Windows.Forms.Label()
        Me.lblmanv = New System.Windows.Forms.Label()
        CType(Me.dataview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnquaylai
        '
        Me.btnquaylai.Location = New System.Drawing.Point(476, 272)
        Me.btnquaylai.Name = "btnquaylai"
        Me.btnquaylai.Size = New System.Drawing.Size(75, 30)
        Me.btnquaylai.TabIndex = 76
        Me.btnquaylai.Text = "Quay lại"
        Me.btnquaylai.UseVisualStyleBackColor = True
        '
        'btnload
        '
        Me.btnload.Location = New System.Drawing.Point(30, 272)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(63, 30)
        Me.btnload.TabIndex = 75
        Me.btnload.Text = "Load"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(302, 272)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(69, 30)
        Me.btnxoa.TabIndex = 74
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(215, 272)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(69, 30)
        Me.btnsua.TabIndex = 73
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(126, 272)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(69, 30)
        Me.btnthem.TabIndex = 72
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'dataview
        '
        Me.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataview.Location = New System.Drawing.Point(30, 327)
        Me.dataview.Name = "dataview"
        Me.dataview.Size = New System.Drawing.Size(521, 175)
        Me.dataview.TabIndex = 71
        '
        'btndong
        '
        Me.btndong.Location = New System.Drawing.Point(389, 272)
        Me.btndong.Name = "btndong"
        Me.btndong.Size = New System.Drawing.Size(70, 30)
        Me.btndong.TabIndex = 70
        Me.btndong.Text = "Đóng"
        Me.btndong.UseVisualStyleBackColor = True
        '
        'txtloainv
        '
        Me.txtloainv.Location = New System.Drawing.Point(215, 98)
        Me.txtloainv.Name = "txtloainv"
        Me.txtloainv.Size = New System.Drawing.Size(156, 20)
        Me.txtloainv.TabIndex = 66
        '
        'txthoten
        '
        Me.txthoten.Location = New System.Drawing.Point(215, 61)
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Size = New System.Drawing.Size(156, 20)
        Me.txthoten.TabIndex = 64
        '
        'txtmanv
        '
        Me.txtmanv.Location = New System.Drawing.Point(215, 17)
        Me.txtmanv.Name = "txtmanv"
        Me.txtmanv.Size = New System.Drawing.Size(156, 20)
        Me.txtmanv.TabIndex = 62
        '
        'lbloainv
        '
        Me.lbloainv.AutoSize = True
        Me.lbloainv.BackColor = System.Drawing.Color.Transparent
        Me.lbloainv.Location = New System.Drawing.Point(86, 98)
        Me.lbloainv.Name = "lbloainv"
        Me.lbloainv.Size = New System.Drawing.Size(77, 13)
        Me.lbloainv.TabIndex = 58
        Me.lbloainv.Text = "Loại nhân viên"
        '
        'lblhoten
        '
        Me.lblhoten.AutoSize = True
        Me.lblhoten.BackColor = System.Drawing.Color.Transparent
        Me.lblhoten.Location = New System.Drawing.Point(91, 64)
        Me.lblhoten.Name = "lblhoten"
        Me.lblhoten.Size = New System.Drawing.Size(39, 13)
        Me.lblhoten.TabIndex = 55
        Me.lblhoten.Text = "Họ tên"
        '
        'lblmanv
        '
        Me.lblmanv.AutoSize = True
        Me.lblmanv.BackColor = System.Drawing.Color.Transparent
        Me.lblmanv.Location = New System.Drawing.Point(86, 24)
        Me.lblmanv.Name = "lblmanv"
        Me.lblmanv.Size = New System.Drawing.Size(72, 13)
        Me.lblmanv.TabIndex = 54
        Me.lblmanv.Text = "Mã nhân viên"
        '
        'quanlynhanvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._13
        Me.ClientSize = New System.Drawing.Size(634, 500)
        Me.Controls.Add(Me.btnquaylai)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.dataview)
        Me.Controls.Add(Me.btndong)
        Me.Controls.Add(Me.txtloainv)
        Me.Controls.Add(Me.txthoten)
        Me.Controls.Add(Me.txtmanv)
        Me.Controls.Add(Me.lbloainv)
        Me.Controls.Add(Me.lblhoten)
        Me.Controls.Add(Me.lblmanv)
        Me.Name = "quanlynhanvien"
        Me.Text = "quanlynhanvien"
        CType(Me.dataview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnquaylai As System.Windows.Forms.Button
    Friend WithEvents btnload As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents dataview As System.Windows.Forms.DataGridView
    Friend WithEvents btndong As System.Windows.Forms.Button
    Friend WithEvents txtloainv As System.Windows.Forms.TextBox
    Friend WithEvents txthoten As System.Windows.Forms.TextBox
    Friend WithEvents txtmanv As System.Windows.Forms.TextBox
    Friend WithEvents lbloainv As System.Windows.Forms.Label
    Friend WithEvents lblhoten As System.Windows.Forms.Label
    Friend WithEvents lblmanv As System.Windows.Forms.Label
End Class
