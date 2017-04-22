Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class quanlynhanvien
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=Assgment-INF205-final.mssql.somee.com;packet size=4096;user id=thebao;pwd=bangthebao@123;data source=Assgment-INF205-final.mssql.somee.com;persist security info=False;initial catalog=Assgment-INF205-final"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)


    Private Sub btndong_Click(sender As Object, e As EventArgs) Handles btndong.Click

        Dim dialog As DialogResult = MessageBox.Show(" Are you sure??? ",
                                                     "Thông báo !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If (dialog = DialogResult.OK) Then
            Me.Close()
        End If
    End Sub

    Private Sub quanlynhanvien_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataview.CellContentClick
        Dim click As Integer = dataview.CurrentCell.RowIndex
        txtmanv.Text = dataview.Item(0, click).Value
        txthoten.Text = dataview.Item(1, click).Value
        
        txtloainv.Text = dataview.Item(4, click).Value
        
    End Sub

    Private Sub btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into NHANVIEN values(@MANV,@HOTEN,@LOAINV,)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtmanv.Focus()
            If txtmanv.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã nhân viên", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txthoten.Focus()
                If txthoten.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                   

                            txtloainv.Focus()
                            If txtloainv.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập loại nhân viên", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                           
                              
                                   
                                        Else
                                            save.Parameters.AddWithValue("@MANV", txtmanv.Text)
                                            save.Parameters.AddWithValue("@HOTEN", txthoten.Text)
                                           
                                            save.Parameters.AddWithValue("@LOAINV", txtloainv.Text)
                                           
                                            save.ExecuteNonQuery()
                                            MessageBox.Show("Lưu thành công")
                                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                            txtmanv.Text = Nothing
                                            txthoten.Text = Nothing
                                          
                                            txtloainv.Text = Nothing
                                          

                                        End If
                                    End If
                                End If
       
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã nhân viên", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select NHANVIEN.MANV as 'Mã nhân viên',NHANVIEN.HOTEN as 'Tên nhân viên', NHANVIEN.BIETDANH as 'biệt danh', NHANVIEN.NGAYSINH as 'ngaysinh',NHANVIEN.LOAINV as 'loại nhân viên',NHANVIEN.NGHENGHIEP as 'nghề nghiệp',NHANVIEN.CHUCVU as 'chức vụ',NHANVIEN.SDT as 'số điện thoại' from NHANVIEN ", conn)
        db.Clear()
        refesh.Fill(db)
        dataview.DataSource = db.DefaultView
    End Sub

    Private Sub btnsua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsua.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update NHANVIEN set MANV=@MANV, HOTEN=@HOTEN, BIETDANH=@BIETDANH, NGAYSINH=@NGAYSINH, LOAINV=@LOAINV, NGHENGHIEP=@NGHENGHIEP, CHUCVU=@CHUCVU, SDT=@SDT  where MANV=@MANV"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtmanv.Focus()
            If txtmanv.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã nhân viên", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txthoten.Focus()
                If txthoten.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                   
                    txtloainv.Focus()
                            If txtloainv.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập loại nhân viên", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                          
                                        Else
                                            addupdate.Parameters.AddWithValue("@MANV", txtmanv.Text)
                                            addupdate.Parameters.AddWithValue("@HOTEN", txthoten.Text)
                                            
                                            addupdate.Parameters.AddWithValue("@LOAINV", txtloainv.Text)
                                           
                                            addupdate.ExecuteNonQuery()
                                            conn.Close() 'đóng kết nối
                                            MessageBox.Show("Cập nhật thành công")
                                            txtmanv.Text = Nothing
                                            txthoten.Text = Nothing
                                            
                                            txtloainv.Text = Nothing
                                           
                                        End If
                                    End If
                                End If
         
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dataview.DataSource = db
        dataview.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        Dim delquery As String = "delete from NHANVIEN where NHANVIEN=@NHANVIEN"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtmanv.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã nhân viên", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtmanv.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@NHANVIEN", txtmanv.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtmanv.Text = Nothing
                    txthoten.Text = Nothing
                   
                    txtloainv.Text = Nothing
                   
                    txtmanv.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã nhân viên cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dataview.DataSource = db
        dataview.DataSource = Nothing
        LoadData()

    End Sub

    Private Sub btnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnload.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select NHANVIEN.MANV as 'Mã nhân viên',NHANVIEN.HOTEN as 'Tên nhân viên', NHANVIEN.BIETDANH as 'biệt danh', NHANVIEN.NGAYSINH as 'ngaysinh',NHANVIEN.LOAINHANVIEN as 'loại nhân viên',NHANVIEN.NGHENGHIEP as 'nghề nghiệp',NHANVIEN.CHUCVU as 'chức vụ',NHANVIEN.SDT as 'số điện thoại' from NHANVIEN ='" & txtmanv.Text & "'", connect)
        Try
            If txtmanv.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dataview.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dataview.DataSource = db.DefaultView
                    txtmanv.Text = Nothing

                Else
                    MessageBox.Show("Không tìm thấy")
                    txtmanv.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select NHANVIEN.MANV as 'Mã nhân viên',NHANVIEN.HOTEN as 'Tên nhân viên', NHANVIEN.BIETDANH as 'biệt danh', NHANVIEN.NGAYSINH as 'ngaysinh',NHANVIEN.LOAINHANVIEN as 'loại nhân viên',NHANVIEN.NGHENGHIEP as 'nghề nghiệp',NHANVIEN.CHUCVU as 'chức vụ',NHANVIEN.SDT as 'số điện thoại' from NHANVIEN", conn)

        conn.Open()
        load.Fill(db)
        dataview.DataSource = db.DefaultView
    End Sub

    Private Sub lbldienthoai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblchucvu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblnghenghiep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lbloainv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbloainv.Click

    End Sub

    Private Sub lblhoten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblhoten.Click

    End Sub

    Private Sub lblngaysinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblbietdanh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnquaylai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnquaylai.Click
        Main.Show()

        Me.Hide()
    End Sub
End Class
