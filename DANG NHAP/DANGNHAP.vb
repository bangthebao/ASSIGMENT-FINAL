

Public Class DANGNHAP
 
    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
        'khai báo biến username và password để giữ thông tin đăng nhập
        Dim user As String = txtuser.Text
        Dim pass As String = txtpass.Text
        ' đăng nhập thành công khi thông tin đăng nhập là "user = baobtps03063" và "pass = 123"
        If (user = "baobtps03063" And pass = "123") Then
            'bậc hộp thoại thông báo đăng nhập thành công với nút OK
            MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công!",
                            "Chào mừng!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'khi thông tin đăng nhập đúng thì trang main tính thuế hiện lên và form đăng nhập ẩn đi
            Main.Show()

            Me.Hide()
        Else
            'bậc hộp thoại thông báo error nếu đăng nhập sai thông tin
            MessageBox.Show("Vui lòng nhập đúng thông tin đăng nhập",
                            "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        'khai báo biến kiểu dialog result và hiển thị hộp thoại yes ,no
        Dim dialog As DialogResult = MessageBox.Show("Are you sure???",
                                                     "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'nếu chọn yes thì kết thúc form và ứng dụng
        If (dialog = DialogResult.Yes) Then
            Me.Close() 'Đóng form
            Application.Exit() 'đóng ứng dụng
        End If
    End Sub

    Private Sub Lbluser_Click(sender As Object, e As EventArgs) Handles Lbluser.Click

    End Sub
End Class



