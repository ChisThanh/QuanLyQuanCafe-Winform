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
	public partial class frm_ChangePassword : Form
	{
		public string connection_string { get; set; }
		public SqlConnection sql_connection { get; set; }

		public frm_ChangePassword(string connection_string)
		{
			InitializeComponent();
			this.connection_string = connection_string;
			sql_connection = new SqlConnection(connection_string);
		}

		private void frm_ChangePassword_Load(object sender, EventArgs e)
		{
			lbl_LoginAnnotation.Text = "";
			lbl_PasswordAnnotation.Text = "";
			tbx_Password.PasswordChar = '*';
		}

		private void btn_HidePassword_Click(object sender, EventArgs e)
		{
			btn_ShowPassword.BringToFront();
			tbx_Password.PasswordChar = '\0';
		}

		private void btn_ShowPassword_Click(object sender, EventArgs e)
		{
			btn_HidePassword.BringToFront();
			tbx_Password.PasswordChar = '*';
		}

		private void btn_ChangePassword_Click(object sender, EventArgs e)
		{
			lbl_LoginAnnotation.Text = "";
			lbl_PasswordAnnotation.Text = "";

			bool error = false;
			if (string.IsNullOrEmpty(tbx_Login.Text))
			{
				error = true;
				lbl_LoginAnnotation.Text = "Không để trỗng";
			}
			if (string.IsNullOrEmpty(tbx_Password.Text))
			{
				error = true;
				lbl_PasswordAnnotation.Text = "Không để trỗng";
			}
			if (error == true) return;

			try
			{
				sql_connection.Open();
				SqlCommand sql_command = new SqlCommand("alter login " + tbx_Login.Text + " with password = '" + tbx_Password.Text + "'", sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
					MessageBox.Show("Đổi mật khẩu thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
				catch
				{
					MessageBox.Show("Đổi mật khẩu không thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
			}
			catch
			{
				MessageBox.Show("Không thể kết nối database, hãy kiểm tra lại thông tin Server và Database!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void btn_ShowCode_Click(object sender, EventArgs e)
		{
			string code = "alter login [Tên Tài Khoản] with password = '[Mật Khẩu]'";
			MessageBox.Show(code, "Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
