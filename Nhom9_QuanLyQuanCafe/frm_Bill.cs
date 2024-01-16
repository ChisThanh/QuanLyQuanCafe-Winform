using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nhom9_QuanLyQuanCafe
{
	public partial class frm_Bill : Form
	{
		public string connection_string { get; set; }
        
		public frm_Bill(string connection_string)
		{
			InitializeComponent();
			this.connection_string = connection_string;
		}

		private void rdo_ChiTietHoaDon_CheckedChanged(object sender, EventArgs e)
		{
            
		}
        private void cbx_MaNhanVien_Load()
        {
            string queryNhanVien = "select distinct MaNhanVien from tbe_HoaDon order by MaNhanVien asc";
            DataTable dataTableNhanVien = new DataTable();
            SqlConnection connNhanVien = new SqlConnection(connection_string);
            SqlCommand cmdNhanVien = new SqlCommand(queryNhanVien, connNhanVien);

            try
            {
                connNhanVien.Open();
                SqlDataAdapter adapterNhanVien = new SqlDataAdapter(cmdNhanVien);
                adapterNhanVien.Fill(dataTableNhanVien);
                cbx_NhanVien.DisplayMember = "MaNhanVien";
                cbx_NhanVien.ValueMember = "MaNhanVien";
                cbx_NhanVien.DataSource = dataTableNhanVien;
                adapterNhanVien.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                if (connNhanVien != null && connNhanVien.State == ConnectionState.Open)
                {
                    connNhanVien.Close();
                }
                connNhanVien.Dispose();
            }
        }
        private void cbx_MaKhachHang_Load()
        {
            string queryKhachHang = "select MaKhachHang from tbe_HoaDon order by MaKhachHang asc";
            DataTable dataTableKhachHang = new DataTable();
            SqlConnection connKhachHang = new SqlConnection(connection_string);
            SqlCommand cmdKhachHang = new SqlCommand(queryKhachHang, connKhachHang);

            try
            {
                connKhachHang.Open();
                SqlDataAdapter adapterKhachHang = new SqlDataAdapter(cmdKhachHang);
                adapterKhachHang.Fill(dataTableKhachHang);
                cbx_KhachHang.DisplayMember = "MaKhachHang";
                cbx_KhachHang.ValueMember = "MaKhachHang";
                cbx_KhachHang.DataSource = dataTableKhachHang;
                adapterKhachHang.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                if (connKhachHang != null && connKhachHang.State == ConnectionState.Open)
                {
                    connKhachHang.Close();
                }
                connKhachHang.Dispose();
            }
        }
        private void cbx_MaHoaDon_Load()
        {
            string queryHoaDon = "select MaHoaDon from tbe_HoaDon order by MaHoaDon asc";
            DataTable dataTableHoaDon = new DataTable();
            SqlConnection connHoaDon = new SqlConnection(connection_string);
            SqlCommand cmdHoaDon = new SqlCommand(queryHoaDon, connHoaDon);

            try
            {
                connHoaDon.Open();
                SqlDataAdapter adapterHoaDon = new SqlDataAdapter(cmdHoaDon);
                adapterHoaDon.Fill(dataTableHoaDon);
                cbx_MaHoaDon.DisplayMember = "MaHoaDon";
                cbx_MaHoaDon.ValueMember = "MaHoaDon";
                cbx_MaHoaDon.DataSource = dataTableHoaDon;
                adapterHoaDon.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                if (connHoaDon != null && connHoaDon.State == ConnectionState.Open)
                {
                    connHoaDon.Close();
                }
                connHoaDon.Dispose();
            }
        }
        private void cbx_MaThucDon_Load()
        {
            string queryThucDon = "select MaThucDon from tbe_ThucDon order by MaThucDon asc";
            DataTable dataTableThucDon = new DataTable();
            SqlConnection connThucDon = new SqlConnection(connection_string);
            SqlCommand cmdThucDon = new SqlCommand(queryThucDon, connThucDon);

            try
            {
                connThucDon.Open();
                SqlDataAdapter adapterThucDon = new SqlDataAdapter(cmdThucDon);
                adapterThucDon.Fill(dataTableThucDon);
                cbx_MaThucDon.DisplayMember = "MaThucDon";
                cbx_MaThucDon.ValueMember = "MaThucDon";
                cbx_MaThucDon.DataSource = dataTableThucDon;
                adapterThucDon.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                if (connThucDon != null && connThucDon.State == ConnectionState.Open)
                {
                    connThucDon.Close();
                }
                cmdThucDon.Dispose();
            }
        }
        private void frm_Bill_Load(object sender, EventArgs e)
        {
            string query = "select * from ftn_HTMA_DanhSachHoaDon()";
            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                dgv_HoaDon.DataSource = dataTable;
                dgv_HoaDon.Columns["Ngày đặt"].DefaultCellStyle.Format = "yyyy/MM/dd";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
            cbx_MaHoaDon_Load();
            cbx_MaThucDon_Load();
            cbx_MaNhanVien_Load();
            cbx_MaKhachHang_Load();
        }
        private void frm_Bill_Load()
        {
            string query = "select * from ftn_HTMA_DanhSachHoaDon()";
            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                dgv_HoaDon.DataSource = dataTable;
                dgv_HoaDon.Columns["Ngày đặt"].DefaultCellStyle.Format = "yyyy/MM/dd";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
            cbx_MaHoaDon_Load();
            cbx_MaThucDon_Load();
            cbx_MaNhanVien_Load();
            cbx_MaKhachHang_Load();
        }
        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            string maHD = dgv_HoaDon.Rows[e.RowIndex].Cells["Mã hóa đơn"].Value.ToString();
            float thanhTien = float.Parse(dgv_HoaDon.Rows[e.RowIndex].Cells["Thành tiền"].Value.ToString() ?? "0");
            DateTime ngayDat = Convert.ToDateTime(dgv_HoaDon.Rows[e.RowIndex].Cells["Ngày đặt"].Value);
            string maNV = dgv_HoaDon.Rows[e.RowIndex].Cells["Mã nhân viên"].Value.ToString();
            string maKH = dgv_HoaDon.Rows[e.RowIndex].Cells["Mã khách hàng"].Value.ToString();


            tbx_MaDonHang.Text = maHD;
            tbx_ThanhTien.Text = thanhTien.ToString();
            dtp_NgayDat.Value = ngayDat;
            cbx_NhanVien.SelectedValue = maNV;
            cbx_KhachHang.SelectedValue = maKH;
            cbx_MaHoaDon.SelectedValue = maHD;

            string query = "SELECT * FROM dbo.ftn_HTMA_ChiTietHoaDon('" + maHD + "')";
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter adapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                conn = new SqlConnection(connection_string);
                cmd = new SqlCommand(query, conn);
                adapter = new SqlDataAdapter(cmd);
                conn.Open();

                adapter.Fill(dataTable);
                dgv_ChiTietHoaDon.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (adapter != null)
                {
                    adapter.Dispose();
                }
            }
        }

        private void dgv_ChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SqlConnection conn = new SqlConnection(connection_string);

                conn.Open();
                string sql = "SELECT MaThucDon, TenThucDon FROM tbe_ThucDon";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();
                adapter.Dispose();
                conn.Dispose();

                string tenThucDon = dgv_ChiTietHoaDon.Rows[e.RowIndex].Cells["Tên thực đơn"].Value.ToString();
                DataRow[] foundRows = dt.Select("TenThucDon = '" + tenThucDon.Replace("'", "''") + "'");
                if (foundRows.Length > 0)
                {
                    cbx_MaThucDon.SelectedValue = foundRows[0]["MaThucDon"];
                }
                else
                {
                    cbx_MaThucDon.SelectedIndex = -1;
                }
                int soLuong = int.Parse(dgv_ChiTietHoaDon.Rows[e.RowIndex].Cells["Số lượng"].Value.ToString());
                tbx_SoLuong.Text = soLuong.ToString();
            }

        }
        private void InsertHoaDon(string maHoaDon, string maThucDon, string maNV, string maKH, float thanhTien, DateTime ngayDat, int soLuong)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            conn.Open();

            SqlCommand command = new SqlCommand("pcd_HTMA_InsertHoaDon_CTHoaDon", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@mahoadon", maHoaDon);
            command.Parameters.AddWithValue("@mathucdon", maThucDon);
            command.Parameters.AddWithValue("@manv", maNV);
            command.Parameters.AddWithValue("@makh", maKH);
            command.Parameters.AddWithValue("@thanhtien", thanhTien);
            command.Parameters.AddWithValue("@ngaydat", ngayDat);
            command.Parameters.AddWithValue("@soluong", soLuong);

            command.ExecuteNonQuery();

            command.Dispose();
            conn.Close();
            conn.Dispose();
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string maHoaDon = tbx_MaDonHang.Text;
            string maThucDon = cbx_MaThucDon.SelectedValue.ToString();
            string maNV = cbx_NhanVien.SelectedValue.ToString();
            string maKH = cbx_KhachHang.SelectedValue.ToString();
            float thanhTien = float.Parse(tbx_ThanhTien.Text);
            DateTime ngayDat = dtp_NgayDat.Value;
            int soLuong = int.Parse(tbx_SoLuong.Text);

            InsertHoaDon(maHoaDon, maThucDon, maNV, maKH, thanhTien, ngayDat, soLuong);

            DataTable dt = (DataTable)dgv_HoaDon.DataSource;
            DataRow newRow = dt.NewRow();
            newRow["Mã hóa đơn"] = maHoaDon;
            newRow["Ngày đặt"] = ngayDat;
            newRow["Thành tiền"] = thanhTien;
            newRow["Mã nhân viên"] = maNV;
            newRow["Mã khách hàng"] = maKH;
            // Thêm các cột khác nếu cần
            dt.Rows.Add(newRow);

            // Đặt lại DataSource để cập nhật DataGridView
            dgv_HoaDon.DataSource = null;
            dgv_HoaDon.DataSource = dt;
            frm_Bill_Load();
        }
        private void UpdateHoaDon(string maHoaDon, string maThucDon, string maNV, string maKH, float thanhTien, DateTime ngayDat, int soLuong)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            conn.Open();

            SqlCommand command = new SqlCommand("pcd_HTMA_UpdateHoaDon", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@mahoadon", maHoaDon);
            command.Parameters.AddWithValue("@mathucdon", maThucDon);
            command.Parameters.AddWithValue("@manv", maNV);
            command.Parameters.AddWithValue("@makh", maKH);
            command.Parameters.AddWithValue("@thanhtien", thanhTien);
            command.Parameters.AddWithValue("@ngaydat", ngayDat);
            command.Parameters.AddWithValue("@soluong", soLuong);

            command.ExecuteNonQuery();

            command.Dispose();
            conn.Close();
            conn.Dispose();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string maHoaDon = tbx_MaDonHang.Text;
            string maThucDon = cbx_MaThucDon.SelectedValue.ToString();
            string maNV = cbx_NhanVien.SelectedValue.ToString();
            string maKH = cbx_KhachHang.SelectedValue.ToString();
            float thanhTien = float.Parse(tbx_ThanhTien.Text);
            DateTime ngayDat = dtp_NgayDat.Value;
            int soLuong = int.Parse(tbx_SoLuong.Text);

            // Gọi phương thức để cập nhật dữ liệu trong database
            UpdateHoaDon(maHoaDon, maThucDon, maNV, maKH, thanhTien, ngayDat, soLuong);

            // Cập nhật DataGridView
            DataTable dt = (DataTable)dgv_HoaDon.DataSource;
            foreach (DataRow row in dt.Rows)
            {
                if (row["Mã hóa đơn"].ToString() == maHoaDon)
                {
                    row["Ngày đặt"] = ngayDat;
                    row["Thành tiền"] = thanhTien;
                    row["Mã nhân viên"] = maNV;
                    row["Mã khách hàng"] = maKH;
                    break;
                }
            }

            // Đặt lại DataSource để cập nhật DataGridView
            dgv_HoaDon.DataSource = null;
            dgv_HoaDon.DataSource = dt;
            frm_Bill_Load();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {              
            string maKhachHang = tbx_SearchKhachHang.Text;
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter adapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                conn = new SqlConnection(connection_string);
                cmd = new SqlCommand("pcd_HTMA_TimKiemTheoKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);

                conn.Open();

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                dgv_HoaDon.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi ở đây
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Đóng và giải phóng tài nguyên
                if (adapter != null) adapter.Dispose();
                if (cmd != null) cmd.Dispose();
                if (conn != null)
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                    conn.Dispose();
                }
            }
        }
        // Phương thức gọi stored procedure để xóa hóa đơn
        private void DeleteHoaDon(string maHoaDon)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            conn.Open();

            SqlCommand command = new SqlCommand("pcd_HTMA_DeleteHoaDon", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@mahoadon", maHoaDon);

            command.ExecuteNonQuery();

            command.Dispose();
            conn.Close();
            conn.Dispose();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_ChiTietHoaDon.SelectedRows.Count > 0)
            {
                // Xóa chi tiết hóa đơn
                foreach (DataGridViewRow row in dgv_ChiTietHoaDon.SelectedRows)
                {
                    string maHoaDon = row.Cells["Tên thực đơn"].Value.ToString();
                    DeleteHoaDon(maHoaDon);
                    dgv_ChiTietHoaDon.Rows.Remove(row);
                }
            }
            else if (dgv_HoaDon.SelectedRows.Count > 0)
            {
                // Xóa hóa đơn và tất cả chi tiết liên quan
                foreach (DataGridViewRow row in dgv_HoaDon.SelectedRows)
                {
                    string maHoaDon = row.Cells["Mã hóa đơn"].Value.ToString();
                    DeleteHoaDon(maHoaDon);
                    dgv_HoaDon.Rows.Remove(row);
                }
            }
        }

	}
}
