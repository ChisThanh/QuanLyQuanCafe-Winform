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
	public partial class frm_Menu : Form
	{
		public string connection_string { get; set; }
        SqlConnection conn;
        SqlDataAdapter da_Loai;
        public frm_Menu(string connection_string)
		{
			InitializeComponent();
			this.connection_string = connection_string;
            conn = new SqlConnection(connection_string);
        }
		
		DataSet ds_QlTD = new DataSet();
        void loadComBoDonVi()
        {
            Dictionary<int, string> trangThai = new Dictionary<int, string>
            {
                 { 0, "Ly" },
                 { 1, "Chén" },
                { 2, "Cốc" }
            };
            cbx_DonViTinh.DataSource = new BindingSource(trangThai, null);
            cbx_DonViTinh.DisplayMember = "Value";
            cbx_DonViTinh.ValueMember = "Value";
            cbx_DonViTinh.SelectedIndex = 0;
        }
        void loadComboboxLoai()
		{
            string query = "select * from tbe_Loai";
            SqlDataAdapter da_Loai = new SqlDataAdapter(query, conn);
            da_Loai.Fill(ds_QlTD, "LoaiThucDon");
            cbx_LoaiThucDon.DataSource = ds_QlTD.Tables["LoaiThucDon"];
            cbx_LoaiThucDon.DisplayMember = "TenLoai";
            cbx_LoaiThucDon.ValueMember = "MaLoai";
        }
        public string GenerateNewCode()
        {
            DataRow lastRow = ds_QlTD.Tables["ThucDon"].Rows[ds_QlTD.Tables["ThucDon"].Rows.Count - 1];

            string ma = lastRow.Field<string>("maThucDon").ToString();
            // Tách "HD" và số từ mã cuối cùng
            string prefix = ma.Substring(0,2) ;
            string numberPart = ma.Substring(2);
            // Chuyển số thành số nguyên và tăng lên 1
            int number = int.Parse(numberPart) ;
            number++;
            // Tạo mã mới
            string newCode = $"{prefix}{number:D2}";

            return newCode;
        }
        void LoadlistFood()
        {
            dgv_Data.DataSource = null; 
            dgv_Data.Refresh();
            string query = "select * from tbe_ThucDon";
            da_Loai = new SqlDataAdapter(query, conn);
            da_Loai.Fill(ds_QlTD, "ThucDon");
            dgv_Data.DataSource = ds_QlTD.Tables["ThucDon"];
            dgv_Data.Columns["maThucDon"].HeaderText = "Mã Thực Đơn";
            dgv_Data.Columns["tenThucDon"].HeaderText = "Tên Thực Đơn";
            dgv_Data.Columns["donViTinh"].HeaderText = "Đơn Vị Tính";
            dgv_Data.Columns["giaBan"].HeaderText = "Giá Bán";
            dgv_Data.Columns["maLoai"].HeaderText = "Mã Loại";           
            khoaDK();
        }
        private void frm_Menu_Load(object sender, EventArgs e)
        {
            loadComboboxLoai();
            loadComBoDonVi();
            LoadlistFood();
            tbx_MaLoai.Text = GenerateNewCode();
        }
        void khoaDK()
        {
           
        }
        private void dgv_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Update.Enabled = btn_Delete.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_Data.Rows[e.RowIndex];
                tbx_MaLoai.Text = selectedRow.Cells["maThucDon"].Value.ToString();
                tbx_TenLoai.Text = selectedRow.Cells["tenThucDon"].Value.ToString();
                tbx_GiaBan.Text = selectedRow.Cells["giaBan"].Value.ToString();
                cbx_DonViTinh.SelectedValue = selectedRow.Cells["donViTinh"].Value.ToString();
                cbx_LoaiThucDon.SelectedValue = selectedRow.Cells["maLoai"].Value.ToString();

            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbx_GiaBan.Text == string.Empty || tbx_MaLoai.Text == string.Empty || tbx_TenLoai.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông Báo");
                    return;
                }
                else
                {
                    conn.Open();
                    string query = "EXEC pcd_TCC_InsertThucDon '" + tbx_MaLoai.Text.Trim() + "' , N'" + tbx_TenLoai.Text.Trim() + "' , N'" + cbx_DonViTinh.SelectedValue.ToString() + "' , '" + tbx_GiaBan.Text.Trim() + "' , '" + cbx_LoaiThucDon.SelectedValue.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm món thành công", "Thông Báo");
                    LoadlistFood();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbx_GiaBan.Text == string.Empty || tbx_MaLoai.Text == string.Empty || tbx_TenLoai.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông Báo");
                    return;
                }
                else
                {
                    conn.Open();
                    string query = "execute pcd_TCC_UpdateThucDon  '" + tbx_MaLoai.Text.Trim()+"' , N'" + tbx_TenLoai.Text.Trim() + "' , N'"+ cbx_DonViTinh.SelectedValue.ToString() +"','" + tbx_GiaBan.Text.Trim() + "','"+ cbx_LoaiThucDon.SelectedValue.ToString() +"'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Cập nhật món thành công", "Thông Báo");
                    ds_QlTD.Tables["ThucDon"].Clear();
                    LoadlistFood();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbx_GiaBan.Text == string.Empty || tbx_MaLoai.Text == string.Empty || tbx_TenLoai.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông Báo");
                    return;
                }
                else
                {
                    conn.Open();
                    string query = "delete tbe_ThucDon where MaThucDon = '"+ tbx_MaLoai.Text.Trim()+"'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    ds_QlTD.Tables["ThucDon"].Clear();
                    LoadlistFood();
                    MessageBox.Show("Xóa món thành công", "Thông Báo");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchTerm = tbx_TenLoai.Text;
         
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.ftn_TCC_TimThucDon(@FoodName)", conn))
            {
                // Add parameter to the query
                cmd.Parameters.AddWithValue("@FoodName", searchTerm);

                // Assuming you have a DataTable to hold the results
                DataTable searchResults = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(searchResults);
                }

                // Assuming you have a DataGridView named dgvResults to display the search results
                dgv_Data.DataSource = searchResults;
            }
        }
    }
}
