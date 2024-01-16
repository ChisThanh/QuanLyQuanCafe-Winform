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
	public partial class frm_SignIn : Form
	{
		public frm_SignIn()
		{
			InitializeComponent();
		}

		private void frm_SignIn_Load(object sender, EventArgs e)
		{
			tbx_Password.PasswordChar = '*';
			lbl_DatabaseAnnotation.Text = "";
			lbl_LoginAnnotation.Text = "";
			lbl_PasswordAnnotation.Text = "";
			lbl_ServerAnnotation.Text = "";
			tbx_ConnectionStatus.ReadOnly = true;
			tbx_Database.Text = "dtb_QLQCF";
			tbx_Server.Text = "CHISTHANH\\CHISTHANH";
			dgv_Login.AllowUserToAddRows = false;
			dgv_Login.ReadOnly = true;
			dgv_Login.RowHeadersVisible = false;
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

		private void btn_AccessDatabase_Click(object sender, EventArgs e)
		{
			ptb_Image.Visible = false;
		}

		private void btn_SignIn_Click(object sender, EventArgs e)
		{
			lbl_DatabaseAnnotation.Text = "";
			lbl_LoginAnnotation.Text = "";
			lbl_PasswordAnnotation.Text = "";
			lbl_ServerAnnotation.Text = "";

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

			if (string.IsNullOrEmpty(tbx_Database.Text) || string.IsNullOrEmpty(tbx_Server.Text))
			{
				ptb_Image.Visible = false;
				MessageBox.Show("Mời bạn nhập thông tin của server và database!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string connection_string = "Data Source = " + tbx_Server.Text + "; Initial Catalog = " + tbx_Database.Text + "; User ID = " + tbx_Login.Text + "; Password = " + tbx_Password.Text;
			try
			{
				SqlConnection test_connection = new SqlConnection(connection_string);
				test_connection.Open();
			}
			catch
			{
				MessageBox.Show("Không thể kết nối database, hãy kiểm tra lại thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			frm_Home form_Home = new frm_Home(tbx_Login.Text, "login", connection_string);
			form_Home.Show();
			Hide();
		}

		private void btn_CheckConnection_Click(object sender, EventArgs e)
		{
			lbl_DatabaseAnnotation.Text = "";
			lbl_LoginAnnotation.Text = "";
			lbl_PasswordAnnotation.Text = "";
			lbl_ServerAnnotation.Text = "";

			bool error = false;
			if (string.IsNullOrEmpty(tbx_Server.Text))
			{
				error = true;
				lbl_ServerAnnotation.Text = "Không để trỗng";
			}
			if (string.IsNullOrEmpty(tbx_Database.Text))
			{
				error = true;
				lbl_DatabaseAnnotation.Text = "Không để trỗng";
			}
			if (error == true) return;

			string connection_string = "Data Source = " + tbx_Server.Text + "; Initial Catalog = " + tbx_Database.Text + "; Integrated Security = True";
			try
			{
				SqlConnection test_connection = new SqlConnection(connection_string);
				test_connection.Open();
			}
			catch
			{
				tbx_ConnectionStatus.Text = "Không Thể Kết Nối";
				return;
			}

			tbx_ConnectionStatus.Text = "Có Thể Kết Nối";

			SqlConnection sql_connection = new SqlConnection(connection_string);
			SqlDataAdapter sql_dataadapter;
			DataTable datatable = new DataTable();
			try
			{
				sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowLogin()", sql_connection);
				datatable = new DataTable();
				sql_dataadapter.Fill(datatable);
				dgv_Login.DataSource = datatable;

				for (int i = 0; i < dgv_Login.Columns.Count; i = i + 1)
				{
					//dgv_Login.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
					if (i == dgv_Login.Columns.Count - 1) dgv_Login.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				}
			}
			catch
			{
				sql_dataadapter = new SqlDataAdapter("select name, default_database_name from sys.sql_logins", sql_connection);
				sql_dataadapter.Fill(datatable);
				dgv_Login.DataSource = datatable;
				
				for (int i = 0; i < dgv_Login.Columns.Count; i = i + 1)
				{
					//dgv_Login.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
					if (i == dgv_Login.Columns.Count - 1) dgv_Login.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				}
			}
		}

		private void btn_ShowCode_Click(object sender, EventArgs e)
		{
			string code = "go\r\ncreate function ftn_NBL_ShowLogin ()\r\nreturns table\r\nas\r\n\treturn\r\n\t(\r\n\t\tselect name, default_database_name\r\n\t\tfrom sys.sql_logins\r\n\t)\r\ngo\r\n\r\nselect * from dbo.ftn_NBL_ShowLogin()";
			MessageBox.Show(code, "Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btn_SignInWithoutAccount_Click(object sender, EventArgs e)
		{
			bool error = false;
			if (string.IsNullOrEmpty(tbx_Server.Text))
			{
				error = true;
				lbl_ServerAnnotation.Text = "Không để trỗng";
			}
			if (string.IsNullOrEmpty(tbx_Database.Text))
			{
				error = true;
				lbl_DatabaseAnnotation.Text = "Không để trỗng";
			}
			if (error == true) return;

			string connection_string = "Data Source = " + tbx_Server.Text + "; Initial Catalog = " + tbx_Database.Text + "; Integrated Security = True";
			try
			{
				SqlConnection test_connection = new SqlConnection(connection_string);
				test_connection.Open();
			}
			catch
			{
				MessageBox.Show("Không thể kết nối, hãy kiểm tra lại thông tin server và database!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				ptb_Image.Visible = false;
				return;
			}
			frm_Home form_Home = new frm_Home("", "windows", connection_string);
			form_Home.Show();
			Hide();
		}

		private void btn_ChangePassword_Click(object sender, EventArgs e)
		{
			string connection_string = "Data Source = " + tbx_Server.Text + "; Initial Catalog = " + tbx_Database.Text + "; Integrated Security = True";
			frm_ChangePassword form_changepassword = new frm_ChangePassword(connection_string);
			form_changepassword.Show();
		}
	}
}
