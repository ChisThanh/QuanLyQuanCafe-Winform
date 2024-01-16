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
	public partial class frm_Permission : Form
	{
		public string connection_string { get; set; }

		public SqlConnection sql_connection {  get; set; }

		SqlDataAdapter sql_dataadapter;
		DataSet dataset = new DataSet();

		public frm_Permission(string connection_string)
		{
			InitializeComponent();
			this.connection_string = connection_string;
			sql_connection = new SqlConnection(connection_string);
		}

		private void frm_Permission_Load(object sender, EventArgs e)
		{
			dgv_Login.AllowUserToAddRows = false;
			dgv_User.AllowUserToAddRows = false;
			dgv_RoleMember.AllowUserToAddRows = false;
			dgv_RolePermission.AllowUserToAddRows = false;
			dgv_Role.AllowUserToAddRows = false;
			dgv_Login.ReadOnly = true;
			dgv_RoleMember.ReadOnly = true;
			dgv_RolePermission.ReadOnly = true;
			dgv_User.ReadOnly = true;
			dgv_Role.ReadOnly = true;
			dgv_Login.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_User.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_RoleMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_RolePermission.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_Role.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_Login.RowHeadersVisible = false;
			dgv_User.RowHeadersVisible = false;
			dgv_RoleMember.RowHeadersVisible = false;
			dgv_RolePermission.RowHeadersVisible = false;
			dgv_Role.RowHeadersVisible = false;
			pnl_Login.Enabled = false;
			pnl_User.Enabled = false;
			pnl_Role.Enabled = false;

			sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowLogin()", sql_connection);
			sql_dataadapter.Fill(dataset, "Login");
			dgv_Login.DataSource = dataset.Tables["Login"];
			dgv_Login.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_Login.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			cbx_TenTaiKhoan.DataSource = dataset.Tables["Login"];
			cbx_TenTaiKhoan.DisplayMember = "Tài Khoản";
			cbx_TenTaiKhoan.ValueMember = "Tài Khoản";

			sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowTable()", sql_connection);
			sql_dataadapter.Fill(dataset, "Table");
			cbx_TenBang.DataSource = dataset.Tables["Table"];
			cbx_TenBang.DisplayMember = "table_name";
			cbx_TenBang.ValueMember = "table_name";
			cbx_TenBang.SelectedIndex = -1;

			cbx_Quyen.Items.AddRange(new object[] { "insert", "delete", "update", "select" });

			sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowUser()", sql_connection);
			sql_dataadapter.Fill(dataset, "User");
			dgv_User.DataSource = dataset.Tables["User"];
			dgv_User.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_User.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			cbx_TenNguoiDung.DataSource = dataset.Tables["User"];
			cbx_TenNguoiDung.DisplayMember = "Người Dùng";
			cbx_TenNguoiDung.ValueMember = "Người Dùng";

			sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowRole()", sql_connection);
			sql_dataadapter.Fill(dataset, "Role");
			dgv_Role.DataSource = dataset.Tables["Role"];
			dgv_Role.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			cbx_TenNhomQuyen.DataSource = dataset.Tables["Role"];
			cbx_TenNhomQuyen.DisplayMember = "Nhóm Quyền";
			cbx_TenNhomQuyen.ValueMember = "Nhóm Quyền";

			sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowRolePermission()", sql_connection);
			sql_dataadapter.Fill(dataset, "RolePermission");
			dgv_RolePermission.DataSource = dataset.Tables["RolePermission"];
			dgv_RolePermission.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_RolePermission.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_RolePermission.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_RolePermission.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_RolePermission.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowRoleMemeber()", sql_connection);
			sql_dataadapter.Fill(dataset, "RoleMember");
			dgv_RoleMember.DataSource = dataset.Tables["RoleMember"];
			dgv_RoleMember.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_RoleMember.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private void rdo_Login_CheckedChanged(object sender, EventArgs e)
		{
			if (rdo_Login.Checked)
			{
				pnl_Login.Enabled = true;
				pnl_User.Enabled = false;
				pnl_Role.Enabled = false;
			}
		}

		private void rdo_User_CheckedChanged(object sender, EventArgs e)
		{
			if (rdo_User.Checked)
			{
				pnl_Login.Enabled = false;
				pnl_User.Enabled = true;
				pnl_Role.Enabled = false;
			}
		}

		private void rdo_Role_CheckedChanged(object sender, EventArgs e)
		{
			if (rdo_Role.Checked)
			{
				pnl_Login.Enabled = false;
				pnl_User.Enabled = false;
				pnl_Role.Enabled = true;
			}
		}

		private void btn_Insert_Click(object sender, EventArgs e)
		{
			if (rdo_Login.Checked)
			{
				if (string.IsNullOrEmpty(tbx_TenTaiKhoan.Text) || string.IsNullOrEmpty(tbx_MatKhau.Text))
				{
					MessageBox.Show("Nhập tên tài khoản và mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				sql_connection.Open();
				SqlCommand sql_command = new SqlCommand("execute pcd_NBL_AddLogin '" + tbx_TenTaiKhoan.Text + "', '" + tbx_MatKhau.Text.Trim() + "', 'dtb_QLQCF'", sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
					sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowLogin()", sql_connection);
					dataset.Tables["Login"].Clear();
					sql_dataadapter.Fill(dataset, "Login");

					sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowUser()", sql_connection);
					dataset.Tables["User"].Clear();
					sql_dataadapter.Fill(dataset, "User");
					sql_connection.Close();
					return;
				}
				catch
				{
					MessageBox.Show("Lỗi thêm tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					sql_connection.Close();
					return;
				}
			}
			else if (rdo_User.Checked)
			{
				if (string.IsNullOrEmpty(tbx_TenNguoiDung.Text) || cbx_TenTaiKhoan.SelectedIndex < 0)
				{
					MessageBox.Show("Nhập tên người dùng và chọn tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				sql_connection.Open();
				SqlCommand sql_command = new SqlCommand("execute pcd_NBL_AddUser '" + cbx_TenTaiKhoan.SelectedValue.ToString() + "', '" + tbx_TenNguoiDung.Text + "'", sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
					sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowUser()", sql_connection);
					dataset.Tables["User"].Clear();
					sql_dataadapter.Fill(dataset, "User");
					sql_connection.Close();
					return;
				}
				catch
				{
					MessageBox.Show("Lỗi thêm người dùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					sql_connection.Close();
					return;
				}
			}
			else if (rdo_Role.Checked)
			{
				if (string.IsNullOrEmpty(tbx_TenNhomQuyen.Text))
				{
					MessageBox.Show("Nhập tên nhóm quyền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				sql_connection.Open();
				SqlCommand sql_command = new SqlCommand("execute pcd_NBL_AddRole '" + tbx_TenNhomQuyen.Text + "'", sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
					sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowRole()", sql_connection);
					dataset.Tables["Role"].Clear();
					sql_dataadapter.Fill(dataset, "Role");
					sql_connection.Close();
					return;
				}
				catch
				{
					MessageBox.Show("Lỗi thêm nhóm quyền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					sql_connection.Close();
					return;
				}
			}
			else
			{
				MessageBox.Show("Chọn tùy chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			if (rdo_Login.Checked)
			{
				if (string.IsNullOrEmpty(tbx_TenTaiKhoan.Text))
				{
					MessageBox.Show("Nhập tên tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				sql_connection.Open();
				SqlCommand sql_command = new SqlCommand("execute pcd_NBL_DropLogin '" + tbx_TenTaiKhoan.Text + "'", sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
					sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowLogin()", sql_connection);
					dataset.Tables["Login"].Clear();
					sql_dataadapter.Fill(dataset, "Login");

					sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowUser()", sql_connection);
					dataset.Tables["User"].Clear();
					sql_dataadapter.Fill(dataset, "User");
					sql_connection.Close();
					return;
				}
				catch
				{
					MessageBox.Show("Lỗi xóa tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					sql_connection.Close();
					return;
				}
			}
			else if (rdo_User.Checked)
			{
				if (string.IsNullOrEmpty(tbx_TenNguoiDung.Text))
				{
					MessageBox.Show("Nhập tên người dùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				sql_connection.Open();
				SqlCommand sql_command = new SqlCommand("execute pcd_NBL_DropUser '" + tbx_TenNguoiDung.Text + "'", sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
					sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowUser()", sql_connection);
					dataset.Tables["User"].Clear();
					sql_dataadapter.Fill(dataset, "User");
					sql_connection.Close();
					return;
				}
				catch
				{
					MessageBox.Show("Lỗi xóa người dùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					sql_connection.Close();
					return;
				}
			}
			else if (rdo_Role.Checked)
			{
				if (string.IsNullOrEmpty(tbx_TenNhomQuyen.Text))
				{
					MessageBox.Show("Nhập tên nhóm quyền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				sql_connection.Open();
				SqlCommand sql_command = new SqlCommand("execute pcd_NBL_DropRole '" + tbx_TenNhomQuyen.Text + "'", sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
					sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowRole()", sql_connection);
					dataset.Tables["Role"].Clear();
					sql_dataadapter.Fill(dataset, "Role");
					sql_connection.Close();
					return;
				}
				catch
				{
					MessageBox.Show("Lỗi xóa nhóm quyền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					sql_connection.Close();
					return;
				}
			}
			else
			{
				MessageBox.Show("Chọn tùy chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tct_Tab_SelectedIndexChanged(object sender, EventArgs e)
		{
			sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowRolePermission()", sql_connection);
			dataset.Tables["RolePermission"].Clear();
			sql_dataadapter.Fill(dataset, "RolePermission");

			sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowRoleMemeber()", sql_connection);
			dataset.Tables["RoleMember"].Clear();
			sql_dataadapter.Fill(dataset, "RoleMember");

			rdo_Permission.Checked = true;
		}

		private void rdo_Permission_CheckedChanged(object sender, EventArgs e)
		{
			if (rdo_Permission.Checked)
			{
				btn_Deny.Enabled = true;
				btn_Grant.Enabled = true;
				btn_Revoke.Enabled = true;
				btn_Deny.Visible = true;
				lbl_TenNguoiDung_Role.Visible = false;
				cbx_TenNguoiDung.Visible = false;
				chk_Cascade.Visible = true;
				chk_Grant.Visible = true;
				cbx_Quyen.Enabled = true;
				cbx_TenBang.Enabled = true;
				btn_Grant.Text = "Cho";
				btn_Revoke.Text = "Tước";
			}
		}

		private void btn_Grant_Click(object sender, EventArgs e)
		{
			if (rdo_Permission.Checked)
			{
				if (cbx_Quyen.SelectedIndex < 0 || cbx_TenBang.SelectedIndex < 0 || cbx_TenNhomQuyen.SelectedIndex < 0)
				{
					MessageBox.Show("Lỗi dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				sql_connection.Open();
				string command = "grant " + cbx_Quyen.Text + " on " + cbx_TenBang.Text + " to " + tbx_TenNhomQuyen.Text;
				if (chk_Grant.Checked) command = command + " with grant option";
				SqlCommand sql_command = new SqlCommand(command, sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
					sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowRolePermission()", sql_connection);
					dataset.Tables["RolePermission"].Clear();
					sql_dataadapter.Fill(dataset, "RolePermission");
					sql_connection.Close();
					return;
				}
				catch
				{
					MessageBox.Show("Lỗi cho quyền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					sql_connection.Close();
					return;
				}
			}
			else if (rdo_Member.Checked)
			{
				if (cbx_TenNhomQuyen.SelectedIndex < 0 || cbx_TenNguoiDung.SelectedIndex < 0)
				{
					MessageBox.Show("Lỗi dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				sql_connection.Open();
				SqlCommand sql_command = new SqlCommand("execute pcd_NBL_AddMember '" + cbx_TenNhomQuyen.Text + "', '" + cbx_TenNguoiDung.Text + "'", sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
					sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowRoleMemeber()", sql_connection);
					dataset.Tables["RoleMember"].Clear();
					sql_dataadapter.Fill(dataset, "RoleMember");
					sql_connection.Close();
					return;
				}
				catch
				{
					MessageBox.Show("Lỗi thêm thành viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					sql_connection.Close();
					return;
				}
			}
			else
			{
				MessageBox.Show("Chọn tùy chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_Revoke_Click(object sender, EventArgs e)
		{
			if (rdo_Permission.Checked)
			{
				if (cbx_Quyen.SelectedIndex < 0 || cbx_TenBang.SelectedIndex < 0 || cbx_TenNhomQuyen.SelectedIndex < 0)
				{
					MessageBox.Show("Lỗi dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				sql_connection.Open();
				string command = "revoke " + cbx_Quyen.Text + " on " + cbx_TenBang.Text + " from " + cbx_TenNhomQuyen.Text;
				if (chk_Cascade.Checked) command = command + " cascade";
				SqlCommand sql_command = new SqlCommand(command, sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
					sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowRolePermission()", sql_connection);
					dataset.Tables["RolePermission"].Clear();
					sql_dataadapter.Fill(dataset, "RolePermission");
					sql_connection.Close();
					return;
				}
				catch
				{
					MessageBox.Show("Lỗi tước quyền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					sql_connection.Close();
					return;
				}
			}
			else if (rdo_Member.Checked)
			{
				if (cbx_TenNhomQuyen.SelectedIndex < 0 || cbx_TenNguoiDung.SelectedIndex < 0)
				{
					MessageBox.Show("Lỗi dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				sql_connection.Open();
				SqlCommand sql_command = new SqlCommand("execute pcd_NBL_DropMember '" + cbx_TenNhomQuyen.Text + "', '" + cbx_TenNguoiDung.Text + "'", sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
					sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowRoleMemeber()", sql_connection);
					dataset.Tables["RoleMember"].Clear();
					sql_dataadapter.Fill(dataset, "RoleMember");
					sql_connection.Close();
					return;
				}
				catch
				{
					MessageBox.Show("Lỗi xóa thành viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					sql_connection.Close();
					return;
				}
			}
			else
			{
				MessageBox.Show("Chọn tùy chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_Deny_Click(object sender, EventArgs e)
		{
			if (cbx_Quyen.SelectedIndex < 0 || cbx_TenBang.SelectedIndex < 0 || cbx_TenNhomQuyen.SelectedIndex < 0)
			{
				MessageBox.Show("Lỗi dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			sql_connection.Open();
			string command = "deny " + cbx_Quyen.Text + " on " + cbx_TenBang.Text + " to " + cbx_TenNhomQuyen.Text;
			if (chk_Cascade.Checked) command = command + " cascade";
			SqlCommand sql_command = new SqlCommand(command, sql_connection);
			try
			{
				sql_command.ExecuteNonQuery();
				sql_dataadapter = new SqlDataAdapter("select * from dbo.ftn_NBL_ShowRolePermission()", sql_connection);
				dataset.Tables["RolePermission"].Clear();
				sql_dataadapter.Fill(dataset, "RolePermission");
				sql_connection.Close();
				return;
			}
			catch
			{
				MessageBox.Show("Lỗi chặn quyền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				sql_connection.Close();
				return;
			}
		}

		private void rdo_Member_CheckedChanged(object sender, EventArgs e)
		{
			if (rdo_Member.Checked)
			{
				btn_Deny.Enabled = false;
				btn_Grant.Enabled = true;
				btn_Revoke.Enabled = true;
				btn_Deny.Visible = false;
				lbl_TenNguoiDung_Role.Visible = true;
				cbx_TenNguoiDung.Visible = true;
				chk_Cascade.Visible = false;
				chk_Grant.Visible = false;
				cbx_Quyen.Enabled = false;
				cbx_TenBang.Enabled = false;
				btn_Grant.Text = "Thêm";
				btn_Revoke.Text = "Xóa";
			}
		}

		private void btn_ShowCode_Click(object sender, EventArgs e)
		{

		}
	}
}
