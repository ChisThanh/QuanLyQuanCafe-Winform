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
using DataPlayer;

namespace Nhom9_QuanLyQuanCafe
{
	public partial class frm_Customer : Form
	{
        QLQCFEntities db = new QLQCFEntities();
        public string connection_string { get; set; }

		public frm_Customer(string connection_string)
		{
			InitializeComponent();
			this.connection_string = connection_string;
		}
        public frm_Customer()
        {
            InitializeComponent();
        }

        private void frm_Customer_Load(object sender, EventArgs e)
        {
            load_GV();
            cbx_GioiTinh.SelectedIndex = 0;
        }
        private void load_GV()
        {
            List<tbe_KhachHang> _lNV = (new QLQCFEntities()).tbe_KhachHang.ToList();
            dgv_Data.Rows.Clear();
            dgv_Data.Refresh();
            foreach (var item in _lNV)
            {
                int rowIndex = dgv_Data.Rows.Add();
                dgv_Data.Rows[rowIndex].Cells["Column1"].Value = item.MaKhachHang;
                dgv_Data.Rows[rowIndex].Cells["Column2"].Value = item.TenKhachHang;
                dgv_Data.Rows[rowIndex].Cells["Column3"].Value = item.GioiTinh;
            }

        }
        private void add_GV(tbe_KhachHang item)
        {
            int rowIndex = dgv_Data.Rows.Add();
            dgv_Data.Rows[rowIndex].Cells["Column1"].Value = item.MaKhachHang;
            dgv_Data.Rows[rowIndex].Cells["Column2"].Value = item.TenKhachHang;
            dgv_Data.Rows[rowIndex].Cells["Column3"].Value = item.GioiTinh;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string ma = tbx_MaKhachHang.Text.Trim();
            string ten = tbx_TenKhachHang.Text.Trim();
            string gioitinh = cbx_GioiTinh.Text.Trim();

            tbe_KhachHang kh = new tbe_KhachHang()
            {
                MaKhachHang = ma,
                TenKhachHang = ten,
                GioiTinh = gioitinh,
            };
            try
            {
                db.tbe_KhachHang.Add(kh);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công <3!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                add_GV(kh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công :((. " + ex,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string ma = tbx_MaKhachHang.Text.Trim();
            string ten = tbx_TenKhachHang.Text.Trim();
            string gioitinh = cbx_GioiTinh.Text.Trim();
            var kh = db.tbe_KhachHang.ToList().FirstOrDefault(each => each.MaKhachHang == ma);
            if (kh == null)
            {
                MessageBox.Show("Nhân viên khôn tồn tại :((.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            kh.TenKhachHang = ten;
            kh.GioiTinh = gioitinh;
            try
            {
                db.SaveChanges();
                MessageBox.Show("Sửa thành công <3.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa không thành công :((.",
                   "Thông báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            load_GV();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string ma = tbx_MaKhachHang.Text;
            if (ma.Length <= 0)
            {
                MessageBox.Show("Mã hiện tại đang trống :((.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắn chắn muốn xóa :((.",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            var kh = db.tbe_KhachHang.ToList().FirstOrDefault(each => each.MaKhachHang == ma);
            if (kh == null)
            {
                MessageBox.Show("Nhân viên khôn tồn tại :((.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            try
            {
                db.tbe_KhachHang.Remove(kh);
                db.SaveChanges();
                DataGridViewRow selectedRow = dgv_Data.SelectedRows[0];
                dgv_Data.Rows.Remove(selectedRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công :((. " + ex,
                   "Thông báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
        }

        private void dgv_Data_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Data.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_Data.SelectedRows[0];
                tbx_MaKhachHang.Text = selectedRow.Cells[0].Value.ToString();
                tbx_TenKhachHang.Text = selectedRow.Cells[1].Value.ToString();
                cbx_GioiTinh.Text = selectedRow.Cells[2].Value.ToString();
            }
        }

        private void btn_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) 
            {
                MessageBox.Show("Bạn đã nhấn vào phím `");
            }
        }
    }
}
