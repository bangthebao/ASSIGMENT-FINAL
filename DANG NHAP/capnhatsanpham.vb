Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmcapnhatsp
    Dim db As New DataTable
    Dim cdd As String = ""
    Dim chuoiketnoi As String = "workstation id=Assgment-INF205-final.mssql.somee.com;packet size=4096;user id=thebao;pwd=bangthebao@123;data source=Assgment-INF205-final.mssql.somee.com;persist security info=False;initial catalog=Assgment-INF205-final"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into SANPHAM values(@MASP,@TENSP,@MALOAI,@TENLOAI,@SOLUONG)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMASP.Focus()
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtTENSP.Focus()
                If txtTENSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtMALOAI.Focus()
                    If txtMALOAI.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtTENLOAI.Focus()
                        If txtTENLOAI.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập tên loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSOLUONG.Focus()
                            If txtSOLUONG.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                save.Parameters.AddWithValue("@MASP", txtMASP.Text)
                                save.Parameters.AddWithValue("@TENSP", txtTENSP.Text)
                                save.Parameters.AddWithValue("@MALOAI", txtMALOAI.Text)
                                save.Parameters.AddWithValue("@TENLOAI", txtTENLOAI.Text)
                                save.Parameters.AddWithValue("@SOLUONG", txtSOLUONG.Text)
                                save.ExecuteNonQuery()
                                MessageBox.Show("Lưu thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtMASP.Text = Nothing
                                txtMALOAI.Text = Nothing
                                txtSOLUONG.Text = Nothing
                                txtTENSP.Text = Nothing
                                txtTENLOAI.Text = Nothing

                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MASP as 'Mã sản phẩm', TENSP as 'Tên sản phẩm', MALOAI as 'Mã Loại', TENLOAI as 'Tên Loại', SOLUONG as 'Số lượng' from SANPHAM", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnload.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MASP as 'Mã sản phẩm', TENSP as 'Tên sản phẩm', MALOAI as 'Mã Loại', TENLOAI as 'Tên Loại', SOLUONG as 'Số lượng' from SANPHAM", conn)
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvSanpham.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvSanpham.DataSource = db.DefaultView
                    txtMASP.Text = Nothing

                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMASP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmcapnhatsp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvSanpham_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsanpham.CellContentClick
        Dim click As Integer = dgvSanpham.CurrentCell.RowIndex
        txtMASP.Text = dgvSanpham.Item(0, click).Value
        txtTENSP.Text = dgvSanpham.Item(1, click).Value
        txtMALOAI.Text = dgvSanpham.Item(2, click).Value
        txtTENLOAI.Text = dgvSanpham.Item(3, click).Value
        txtSOLUONG.Text = dgvSanpham.Item(4, click).Value
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MASP as 'Mã sản phẩm', TENSP as 'Tên sản phẩm', MALOAI as 'Mã Loại', TENLOAI as 'Tên Loại', SOLUONG as 'Số lượng' from SANPHAM", conn)

        conn.Open()
        load.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub

    Private Sub btnCapnhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update SANPHAM set MASP=@MASP, TENSP=@TENSP, MALOAI=@MALOAI, TENLOAI=@TENLOAI, SOLUONG=@SOLUONG where MASP=@MASP"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMASP.Focus()
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMASP.Focus()
                If txtTENSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTENSP.Focus()
                    If txtMALOAI.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtMALOAI.Focus()
                        If txtSOLUONG.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            addupdate.Parameters.AddWithValue("@MASP", txtMASP.Text)
                            addupdate.Parameters.AddWithValue("@TENSP", txtTENSP.Text)
                            addupdate.Parameters.AddWithValue("@MALOAI", txtMALOAI.Text)
                            addupdate.Parameters.AddWithValue("@TENLOAI", txtTENLOAI.Text)
                            addupdate.Parameters.AddWithValue("@SOLUONG", txtSOLUONG.Text)
                            addupdate.ExecuteNonQuery()
                            conn.Close() 'đóng kết nối
                            MessageBox.Show("Cập nhật thành công")
                            txtMASP.Text = Nothing
                            txtTENSP.Text = Nothing
                            txtMALOAI.Text = Nothing
                            txtTENLOAI.Text = Nothing
                            txtSOLUONG.Text = Nothing
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        Dim delquery As String = "delete from SANPHAM where MASP=@MASP"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMASP.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MASP", txtMASP.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtMASP.Text = Nothing
                    txtTENSP.Text = Nothing
                    txtMALOAI.Text = Nothing
                    txtTENLOAI.Text = Nothing
                    txtSOLUONG.Text = Nothing
                    txtMASP.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnquaylai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnquaylai.Click
        Main.Show()

        Me.Hide()
    End Sub

    Private Sub txtMASP_TextChanged(sender As Object, e As EventArgs) Handles txtmasp.TextChanged

    End Sub
End Class
