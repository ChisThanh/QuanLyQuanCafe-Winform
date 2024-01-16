using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataPlayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nhom9_QuanLyQuanCafe
{
	public partial class frm_Employee : Form
	{
		QLQCFEntities db = new QLQCFEntities();
	
		public frm_Employee()
		{
			InitializeComponent();
		}
        private void checkTxt()
        {
            if(string.IsNullOrEmpty(tbx_Ma.Text))
            {
                MessageBox.Show("Bạn cần nhập mã");  return;
            }
            if (string.IsNullOrEmpty(tbx_Ten.Text))
            {
                MessageBox.Show("Bạn cần nhập tên"); return;
            }

        }
        private void load_GV()
		{
            List<tbe_NhanVien> _lNV = (new QLQCFEntities()).tbe_NhanVien.ToList();
            dgv_Data.Rows.Clear();
            dgv_Data.Refresh();
            foreach (var item in _lNV)
            {
                int rowIndex = dgv_Data.Rows.Add();
                dgv_Data.Rows[rowIndex].Cells["Column1"].Value = item.MaNhanVien;
                dgv_Data.Rows[rowIndex].Cells["Column2"].Value = item.TenNhanVien;
                dgv_Data.Rows[rowIndex].Cells["Column3"].Value = item.GioiTinh;
                dgv_Data.Rows[rowIndex].Cells["Column4"].Value = item.NgaySinh;
            }
           
        }
        private void add_GV(tbe_NhanVien item)
        {
            int rowIndex = dgv_Data.Rows.Add();
            dgv_Data.Rows[rowIndex].Cells["Column1"].Value = item.MaNhanVien;
            dgv_Data.Rows[rowIndex].Cells["Column2"].Value = item.TenNhanVien;
            dgv_Data.Rows[rowIndex].Cells["Column3"].Value = item.GioiTinh;
            dgv_Data.Rows[rowIndex].Cells["Column4"].Value = item.NgaySinh;
        }

        private void frm_Employee_Load(object sender, EventArgs e)
        {
			load_GV();
            cb_gt.SelectedIndex = 0;
        }

        private void dgv_Data_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Data.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_Data.SelectedRows[0];
                tbx_Ma.Text = selectedRow.Cells[0].Value.ToString();
                tbx_Ten.Text = selectedRow.Cells[1].Value.ToString();
                cb_gt.Text = selectedRow.Cells[2].Value.ToString();
                dtp_Ngay.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            checkTxt();
            string ma = tbx_Ma.Text.Trim();
            string ten = tbx_Ten.Text.Trim();
            string gioitinh = cb_gt.Text.Trim();
            string ngaysinh = dtp_Ngay.Text.Trim();

            var tmpnv = db.tbe_NhanVien.ToList().Find(each => each.MaNhanVien == ma);
            if(tmpnv != null)
            {
                MessageBox.Show("Nhân viên đã tồn tại"); return;
            }    
            tbe_NhanVien nv = new tbe_NhanVien()
            {
                MaNhanVien = ma,
                TenNhanVien = ten,
                GioiTinh = gioitinh,
                NgaySinh = DateTime.Parse(ngaysinh)
            };
            try
            {
                db.tbe_NhanVien.Add(nv);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công <3!", 
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                add_GV(nv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công :((. " + ex,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string ma = tbx_Ma.Text;
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
            var nhanvien = db.tbe_NhanVien.ToList().FirstOrDefault(each =>each.MaNhanVien == ma);
            if(nhanvien == null)
            {
                MessageBox.Show("Nhân viên khôn tồn tại :((.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            return;
            }    
            try
            {
                db.tbe_NhanVien.Remove(nhanvien);
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            checkTxt();
            string ma = tbx_Ma.Text.Trim();
            string ten = tbx_Ten.Text.Trim();
            string gioitinh = cb_gt.Text.Trim();
            string ngaysinh = dtp_Ngay.Text.Trim();
            var nhanvien = db.tbe_NhanVien.ToList().FirstOrDefault(each => each.MaNhanVien == ma);
            if (nhanvien == null)
            {
                MessageBox.Show("Nhân viên khôn tồn tại :((.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            nhanvien.TenNhanVien= ten;
            nhanvien.GioiTinh= gioitinh;
            nhanvien.NgaySinh = DateTime.Parse(ngaysinh);
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

        
        private void btn_Filter_Click(object sender, EventArgs e)
        {
            load_GV();
        }

        private void btn_Search_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("CREATE FUNCTION TimKiemNhanVienTheoTen\r\n(\r\n    @TenNhanVien nvarchar(30)\r\n)\r\nRETURNS @KetQua TABLE\r\n(\r\n    MaNhanVien char(4),\r\n    TenNhanVien nvarchar(30),\r\n    NgaySinh date,\r\n    GioiTinh nvarchar(10)\r\n)\r\nAS\r\nBEGIN\r\n    DECLARE @MaNhanVien char(4), @TenNV nvarchar(30), @NgaySinh date, @GioiTinh nvarchar(10);\r\n\r\n    DECLARE TimKiemCursor CURSOR FOR\r\n    SELECT MaNhanVien, TenNhanVien, NgaySinh, GioiTinh\r\n    FROM tbe_NhanVien\r\n    WHERE TenNhanVien LIKE '%' + @TenNhanVien + '%';\r\n\r\n    OPEN TimKiemCursor;\r\n    FETCH NEXT FROM TimKiemCursor INTO @MaNhanVien, @TenNV, @NgaySinh, @GioiTinh;\r\n\r\n    WHILE @@FETCH_STATUS = 0\r\n    BEGIN\r\n        INSERT INTO @KetQua (MaNhanVien, TenNhanVien, NgaySinh, GioiTinh)\r\n        VALUES (@MaNhanVien, @TenNV, @NgaySinh, @GioiTinh);\r\n\r\n        FETCH NEXT FROM TimKiemCursor INTO @MaNhanVien, @TenNV, @NgaySinh, @GioiTinh;\r\n    END\r\n\r\n    CLOSE TimKiemCursor;\r\n    DEALLOCATE TimKiemCursor;\r\n\r\n    RETURN;\r\nEND;\r\n");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string ten = tbx_Ten.Text.Trim();
            if (string.IsNullOrEmpty(ten) )
            {
                MessageBox.Show("Bạn cẩn phải nhập tên"); return;
            }
            var tmp = db.TimKiemNhanVienTheoTen(ten).ToList();
            if (tmp.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên");  return;
            }
            dgv_Data.Rows.Clear();
            dgv_Data.Refresh();
            foreach (var item in tmp)
            {
                add_GV(new tbe_NhanVien()
                {
                    MaNhanVien = item.MaNhanVien,
                    TenNhanVien = item.TenNhanVien,
                    GioiTinh = item.GioiTinh,
                    NgaySinh = item.NgaySinh,
                });
            }
        }
    }
}
