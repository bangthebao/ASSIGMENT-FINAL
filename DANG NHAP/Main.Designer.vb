<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KHACHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QUẢNLÝNHÂNVIÊNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SANPHAMoolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CậpNhậtSPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐĂNGXUẤTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KHACHToolStripMenuItem, Me.QUẢNLÝNHÂNVIÊNToolStripMenuItem, Me.SANPHAMoolStripMenuItem, Me.ĐĂNGXUẤTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(522, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KHACHToolStripMenuItem
        '
        Me.KHACHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CNToolStripMenuItem})
        Me.KHACHToolStripMenuItem.Name = "KHACHToolStripMenuItem"
        Me.KHACHToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.KHACHToolStripMenuItem.Text = "KHÁCH HÀNG"
        '
        'CNToolStripMenuItem
        '
        Me.CNToolStripMenuItem.Name = "CNToolStripMenuItem"
        Me.CNToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.CNToolStripMenuItem.Text = "Cập nhật KH"
        '
        'QUẢNLÝNHÂNVIÊNToolStripMenuItem
        '
        Me.QUẢNLÝNHÂNVIÊNToolStripMenuItem.Name = "QUẢNLÝNHÂNVIÊNToolStripMenuItem"
        Me.QUẢNLÝNHÂNVIÊNToolStripMenuItem.Size = New System.Drawing.Size(135, 20)
        Me.QUẢNLÝNHÂNVIÊNToolStripMenuItem.Text = "QUẢN LÝ NHÂN VIÊN"
        '
        'SANPHAMoolStripMenuItem
        '
        Me.SANPHAMoolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CậpNhậtSPToolStripMenuItem})
        Me.SANPHAMoolStripMenuItem.Name = "SANPHAMoolStripMenuItem"
        Me.SANPHAMoolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.SANPHAMoolStripMenuItem.Text = "SẢN PHẨM"
        '
        'CậpNhậtSPToolStripMenuItem
        '
        Me.CậpNhậtSPToolStripMenuItem.Name = "CậpNhậtSPToolStripMenuItem"
        Me.CậpNhậtSPToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CậpNhậtSPToolStripMenuItem.Text = "Cập Nhật SP"
        '
        'ĐĂNGXUẤTToolStripMenuItem
        '
        Me.ĐĂNGXUẤTToolStripMenuItem.Name = "ĐĂNGXUẤTToolStripMenuItem"
        Me.ĐĂNGXUẤTToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.ĐĂNGXUẤTToolStripMenuItem.Text = " ĐĂNG XUẤT"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(522, 343)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KHACHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QUẢNLÝNHÂNVIÊNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SANPHAMoolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CậpNhậtSPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐĂNGXUẤTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
