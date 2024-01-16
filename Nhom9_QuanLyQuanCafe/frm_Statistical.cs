using DataPlayer;
using Nhom9_QuanLyQuanCafe.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Nhom9_QuanLyQuanCafe
{
    public partial class frm_Statistical : Form
    {
        QLQCFEntities db = new QLQCFEntities();
        DateTime ngayBD = new DateTime(2023, 1, 1);
        DateTime ngayKT = DateTime.Now;
        public frm_Statistical()
        {
            InitializeComponent();
        }
       
        private void frm_Statistical_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
           
        }
        private void LoadDuLieu()
        {

            var sanpham = db.SanPhamBanChayNhat(ngayBD, ngayKT).FirstOrDefault();
            if(sanpham != null)
            {
                txt_sp.Text = sanpham.TenSanPham;
                txt_ttsp.Text = Hp.FormatCurrency((int)sanpham.TongTien);
                txt_slsp.Text = sanpham.SoLuongBan.ToString();
            }
          

            var khachang = db.KhachHangMuaNhieuNhat(ngayBD, ngayKT).FirstOrDefault();
            if(khachang != null)
            {
                txt_kh.Text = khachang.TenKhachHang;
                txt_khtt.Text = Hp.FormatCurrency((int)khachang.TongTienChiTra);
                txt_khsl.Text = khachang.SoLuongMua.ToString();
            }



            load_CharDoanhThuNhanVien();
            load_CharDoanhThuTheoLoai();
            load_CharSoluongDonTheoThang();

            SqlParameter ngayBDParam = new SqlParameter("@ngayBD", ngayBD);
            SqlParameter ngayKTParam = new SqlParameter("@ngayKT", ngayKT);
            var TongDoanhThu = db.Database.SqlQuery<double>("SELECT dbo.TongDoanhThuTrongKhoang(@ngayBD, @ngayKT)", ngayBDParam, ngayKTParam).FirstOrDefault();
            ngayBDParam = new SqlParameter("@ngayBD", ngayBD);
            ngayKTParam = new SqlParameter("@ngayKT", ngayKT);
            var TongDon = db.Database.SqlQuery<double>("SELECT dbo.TongDon(@ngayBD, @ngayKT)", ngayBDParam, ngayKTParam).FirstOrDefault();
            var TongKH = db.Database.SqlQuery<double>("SELECT dbo.TongKhachHang()").FirstOrDefault();
            var TongNV = db.Database.SqlQuery<double>("SELECT dbo.TongNhanVien()").FirstOrDefault();

            

            textBox1.Text = Hp.FormatCurrency((int)TongDoanhThu);
            textBox2.Text = TongKH.ToString();
            textBox3.Text = TongNV.ToString();
            textBox4.Text = TongDon.ToString();
            dtp_BD.Text = ngayBD.ToString();
            dtp_KT.Text = ngayKT.ToString();
           

        }

        private void load_CharDoanhThuNhanVien()
        {
            var l = db.Top10DoanhThuNhanVien(ngayBD, ngayKT);
            if(l.Count() == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo");
                 ngayBD = new DateTime(2023, 1, 1);
                 ngayKT = DateTime.Now;
                return;
            }
            chart_DoanhThuNhanVien.Series[0].Points.Clear();

            chart_DoanhThuNhanVien.ChartAreas[0].AxisX.Interval = 1;
            
            foreach (var item in l)
            {
                chart_DoanhThuNhanVien.Series[0].Points.AddXY(Hp.GetLastWord(item.TenNhanVien),item.DoanhThu);
            }
        }
        private void load_CharDoanhThuTheoLoai()
        {
            var l = db.DoanhThuTheoLoai(ngayBD, ngayKT);
            if (l.Count() == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo");
                ngayBD = new DateTime(2023, 1, 1);
                ngayKT = DateTime.Now;
                return;
            }
            chart_DoanhThuLoai.Series[0].Points.Clear();

            chart_DoanhThuLoai.ChartAreas[0].AxisX.Interval = 1;
            foreach (var item in l)
            {
                chart_DoanhThuLoai.Series[0].Points.AddXY(item.TenLoai, item.DoanhThu);
            }
        }
        private void load_CharSoluongDonTheoThang()
        {
            var l = db.TongSoLuongDonTheoThang(ngayBD, ngayKT);
            if (l.Count() == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo");
                ngayBD = new DateTime(2023, 1, 1);
                ngayKT = DateTime.Now;
                return;
            }
            chart_SoLuongTheoThang.Series[0].Points.Clear();

            chart_SoLuongTheoThang.ChartAreas[0].AxisX.Interval = 1;
            foreach (var item in l)
            {
                chart_SoLuongTheoThang.Series[0].Points.AddXY(item.Thang, item.TongSoLuongDon);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ngayBD = DateTime.Parse(dtp_BD.Text);
            ngayKT = DateTime.Parse(dtp_KT.Text);
            LoadDuLieu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ngayBD = new DateTime(2023, 1, 1);
            ngayKT = DateTime.Now;
            LoadDuLieu();
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CREATE FUNCTION [dbo].[TongDoanhThuTrongKhoang]\r\n(\r\n    @NgayBatDau date,\r\n    @NgayKetThuc date\r\n)\r\nRETURNS float\r\nAS\r\nBEGIN\r\n    DECLARE @TongDoanhThu float;\r\n\r\n    SELECT @TongDoanhThu = ISNULL(SUM(ThanhTien), 0)\r\n    FROM tbe_HoaDon\r\n    WHERE NgayDat BETWEEN @NgayBatDau AND @NgayKetThuc;\r\n\r\n    RETURN @TongDoanhThu;\r\nEND;");
        }
        private void pnl_1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CREATE FUNCTION [dbo].[TongKhachHang]()\r\n\r\nRETURNS float\r\nAS\r\nBEGIN\r\n    DECLARE @SoLuong float;\r\n\r\n    SELECT @SoLuong = ISNULL(count(*), 0)\r\n    FROM tbe_KhachHang\r\n\r\n    RETURN @SoLuong;\r\nEND;");
        }

        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CREATE FUNCTION [dbo].[TongNhanVien]()\r\nRETURNS float\r\nas\r\nBEGIN\r\n    DECLARE @SoLuong float;\r\n\r\n    SELECT @SoLuong = ISNULL(count(*), 0)\r\n    FROM tbe_NhanVien\r\n\r\n    RETURN @SoLuong;\r\nEND;");
        }

        private void panel3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CREATE FUNCTION [dbo].[TongDon]\r\n(\r\n    @NgayBatDau DATE,\r\n    @NgayKetThuc DATE\r\n)\r\nRETURNS FLOAT\r\nAS\r\nBEGIN\r\n    DECLARE @SoLuong FLOAT;\r\n\r\n    SELECT @SoLuong = ISNULL(COUNT(*), 0)\r\n    FROM tbe_HoaDon\r\n    WHERE NgayDat BETWEEN @NgayBatDau AND @NgayKetThuc;\r\n\r\n    RETURN @SoLuong;\r\nEND;");
        }

        private void chart_DoanhThuNhanVien_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("CREATE FUNCTION [dbo].[Top10DoanhThuNhanVien]\r\n(\r\n    @NgayBatDau date,\r\n    @NgayKetThuc date\r\n)\r\nRETURNS TABLE\r\nAS\r\nRETURN\r\n(\r\n    SELECT\r\n        TOP 10\r\n        NV.TenNhanVien,\r\n        ISNULL(SUM(HD.ThanhTien), 0) AS DoanhThu\r\n    FROM\r\n        tbe_NhanVien NV\r\n    LEFT JOIN\r\n        tbe_HoaDon HD ON NV.MaNhanVien = HD.MaNhanVien\r\n    WHERE\r\n        HD.NgayDat BETWEEN @NgayBatDau AND @NgayKetThuc\r\n    GROUP BY\r\n        NV.TenNhanVien\r\n    ORDER BY\r\n        DoanhThu DESC\r\n);");
        }

        private void chart_DoanhThuLoai_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("CREATE FUNCTION [dbo].[DoanhThuTheoLoai]\r\n(\r\n    @NgayBatDau date,\r\n    @NgayKetThuc date\r\n)\r\nRETURNS TABLE\r\nAS\r\nRETURN\r\n(\r\n    SELECT\r\n        L.TenLoai,\r\n        ISNULL(SUM(HD.ThanhTien), 0) AS DoanhThu\r\n    FROM\r\n        tbe_Loai L\r\n    LEFT JOIN\r\n        tbe_ThucDon T ON L.MaLoai = T.MaLoai\r\n    LEFT JOIN\r\n        tbe_ChiTietHoaDon CTHD ON T.MaThucDon = CTHD.MaThucDon\r\n    LEFT JOIN\r\n        tbe_HoaDon HD ON CTHD.MaHoaDon = HD.MaHoaDon\r\n    WHERE\r\n        HD.NgayDat BETWEEN @NgayBatDau AND @NgayKetThuc\r\n    GROUP BY\r\n        L.TenLoai\r\n);"); 
        }

        private void label6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CREATE FUNCTION [dbo].[SanPhamBanChayNhat]\r\n(\r\n    @NgayBatDau date,\r\n    @NgayKetThuc date\r\n)\r\nRETURNS TABLE\r\nAS\r\nRETURN\r\n(\r\n    SELECT TOP 1 \r\n        TD.TenThucDon AS TenSanPham,\r\n        SUM(CTHD.SoLuong) AS SoLuongBan,\r\n        SUM(CTHD.SoLuong * TD.GiaBan) AS TongTien\r\n    FROM\r\n        tbe_ChiTietHoaDon CTHD\r\n    JOIN\r\n        tbe_ThucDon TD ON CTHD.MaThucDon = TD.MaThucDon\r\n    JOIN\r\n        tbe_HoaDon HD ON CTHD.MaHoaDon = HD.MaHoaDon\r\n    WHERE\r\n        HD.NgayDat BETWEEN @NgayBatDau AND @NgayKetThuc\r\n    GROUP BY\r\n        TD.TenThucDon\r\n    ORDER BY\r\n        SoLuongBan DESC\r\n);"); 
        }

        private void label9_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("CREATE FUNCTION [dbo].[KhachHangMuaNhieuNhat]\r\n(\r\n    @NgayBatDau date,\r\n    @NgayKetThuc date\r\n)\r\nRETURNS TABLE\r\nAS\r\nRETURN\r\n(\r\n    SELECT TOP 1 \r\n        KH.TenKhachHang AS TenKhachHang,\r\n        COUNT(CTHD.MaThucDon) AS SoLuongMua,\r\n        SUM(TD.GiaBan * CTHD.SoLuong) AS TongTienChiTra\r\n    FROM\r\n        tbe_KhachHang KH\r\n    JOIN\r\n        tbe_HoaDon HD ON KH.MaKhachHang = HD.MaKhachHang\r\n    JOIN\r\n        tbe_ChiTietHoaDon CTHD ON HD.MaHoaDon = CTHD.MaHoaDon\r\n    JOIN\r\n        tbe_ThucDon TD ON CTHD.MaThucDon = TD.MaThucDon\r\n    WHERE\r\n        HD.NgayDat BETWEEN @NgayBatDau AND @NgayKetThuc\r\n    GROUP BY\r\n        KH.TenKhachHang\r\n    ORDER BY\r\n        SoLuongMua DESC, TongTienChiTra DESC\r\n);"); 
        }

        private void chart_SoLuongTheoThang_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("CREATE FUNCTION [dbo].[TongSoLuongDonTheoThang]\r\n(\r\n    @NgayBatDau DATE,\r\n    @NgayKetThuc DATE\r\n)\r\nRETURNS TABLE\r\nAS\r\nRETURN\r\n(\r\n    SELECT\r\n        FORMAT(HD.NgayDat, 'yyyy-MM') AS Thang,\r\n        COUNT(*) AS TongSoLuongDon\r\n    FROM\r\n        tbe_HoaDon HD\r\n    WHERE\r\n        HD.NgayDat BETWEEN @NgayBatDau AND @NgayKetThuc\r\n    GROUP BY\r\n        FORMAT(HD.NgayDat, 'yyyy-MM')\r\n);"); 
        }
    }
}
