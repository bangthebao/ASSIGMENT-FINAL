Public Class Main

 

    Private Sub ĐĂNGXUẤTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐĂNGXUẤTToolStripMenuItem.Click
        DANGNHAP.Show()

        DANGNHAP.txtuser.Text = Nothing
        DANGNHAP.txtpass.Text = Nothing
        DANGNHAP.txtuser.Focus()
    End Sub

    Private Sub QUẢNLÝNHÂNVIÊNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QUẢNLÝNHÂNVIÊNToolStripMenuItem.Click
        quanlynhanvien.Show()
        Me.Hide()


    End Sub

   


    Private Sub CNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CNToolStripMenuItem.Click
        capnhatkhachhang.Show()

        Me.Hide()
    End Sub

   
    Private Sub CậpNhậtSPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậpNhậtSPToolStripMenuItem.Click


    End Sub
End Class