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
using System.IO;

namespace Nhom9_QuanLyQuanCafe
{
	public partial class frm_BackupRestore : Form
	{
		public string connection_string { get; set; }

		public SqlConnection sql_connection {  get; set; }

		public frm_BackupRestore(string connection_string)
		{
			InitializeComponent();
			this.connection_string = connection_string;
			sql_connection = new SqlConnection(connection_string);
		}

		private void frm_BackupRestore_Load(object sender, EventArgs e)
		{
			cbx_DB_Settings.Items.AddRange(new object[] { "Recovery", "NoRecovery" });
			cbx_DB_Settings.SelectedIndex = -1;
			cbx_FB_Settings.Items.AddRange(new object[] { "Recovery", "NoRecovery" });
			cbx_FB_Settings.SelectedIndex = -1;
			cbx_TL_Settings.Items.AddRange(new object[] { "Recovery", "NoRecovery" });
			cbx_TL_Settings.SelectedIndex = -1;
			tbx_DB_Result.ReadOnly = true;
			tbx_FB_Result.ReadOnly = true;
			tbx_TL_Result.ReadOnly = true;
		}

		private void btn_FB_OpenFile_Click(object sender, EventArgs e)
		{
			ofd_OpenFile.Filter = "SQL Server Backup Files (*.bak)|*.bak";
			ofd_OpenFile.CheckFileExists = false;
			DialogResult dialog_result = ofd_OpenFile.ShowDialog();

			if (dialog_result == DialogResult.OK)
			{
				string file_path = ofd_OpenFile.FileName;
				if (File.Exists(file_path))
				{
					try
					{
						string file_content = File.ReadAllText(file_path);
						tbx_FB_FilePath.Text = file_path;
					}
					catch
					{
						MessageBox.Show("Không thể mở file", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void btn_DB_FilePath_Click(object sender, EventArgs e)
		{
			ofd_OpenFile.Filter = "SQL Server Backup Files (*.bak)|*.bak";
			ofd_OpenFile.CheckFileExists = false;
			DialogResult dialog_result = ofd_OpenFile.ShowDialog();

			if (dialog_result == DialogResult.OK)
			{
				string file_path = ofd_OpenFile.FileName;
				if (File.Exists(file_path))
				{
					try
					{
						string file_content = File.ReadAllText(file_path);
						tbx_DB_FilePath.Text = file_path;
					}
					catch
					{
						MessageBox.Show("Không thể mở file", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void btn_TL_FilePath_Click(object sender, EventArgs e)
		{
			ofd_OpenFile.Filter = "Transaction Log Files (*.trn)|*.trn";
			ofd_OpenFile.CheckFileExists = false;
			DialogResult dialog_result = ofd_OpenFile.ShowDialog();

			if (dialog_result == DialogResult.OK)
			{
				string file_path = ofd_OpenFile.FileName;
				if (File.Exists(file_path))
				{
					try
					{
						string file_content = File.ReadAllText(file_path);
						tbx_TL_FilePath.Text = file_path;
					}
					catch
					{
						MessageBox.Show("Không thể mở file", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void btn_FB_Backup_Click(object sender, EventArgs e)
		{
			tbx_FB_Result.Text = "";

			if (string.IsNullOrEmpty(tbx_FB_FilePath.Text))
			{
				tbx_FB_Result.Text = "Đường dẫn trống";
				return;
			}

			string database_name = "dtb_QLQCF";
			sql_connection.Open();
			SqlCommand sql_command = new SqlCommand("execute pcd_NBL_FullBackup '" + tbx_FB_FilePath.Text + "', '" +  database_name + "'", sql_connection);
			try
			{
				sql_command.ExecuteNonQuery();
			}
			catch
			{
				string backup = "backup database " + database_name + " to disk = '" + tbx_FB_FilePath.Text + "'";
				sql_command = new SqlCommand(backup, sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
				}
				catch
				{
					tbx_FB_Result.Text = "Lỗi sao lưu";
					sql_connection.Close();
					return;
				}
			}
			tbx_FB_Result.Text = "Sao lưu Full Backup thành công";
			sql_connection.Close();
		}

		private void btn_FB_Restore_Click(object sender, EventArgs e)
		{
			tbx_FB_Result.Text = "";

			if (string.IsNullOrEmpty(tbx_FB_FilePath.Text))
			{
				tbx_FB_Result.Text = "Đường dẫn trống";
				return;
			}

			string database_name = "dtb_QLQCF";
			string backup = "";
			sql_connection.Open();
			SqlCommand sql_command;

			if (cbx_FB_Settings.SelectedIndex == 0)
			{
				sql_command = new SqlCommand("execute pcd_NBL_RestoreRecovery '" + tbx_FB_FilePath.Text + "', '" + database_name + "'", sql_connection);
				backup = "restore database " + database_name + " from disk = '" + tbx_FB_FilePath.Text + "' with recovery";
			}
			else
			{
				sql_command = new SqlCommand("execute pcd_NBL_RestoreNoRecovery '" + tbx_FB_FilePath.Text + "', '" + database_name + "'", sql_connection);
				backup = "restore database " + database_name + " from disk = '" + tbx_FB_FilePath.Text + "' with norecovery";
			}

			try
			{
				sql_command.ExecuteNonQuery();
			}
			catch
			{
				sql_command = new SqlCommand(backup, sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
				}
				catch
				{
					tbx_FB_Result.Text = "Lỗi phục hồi";
					sql_connection.Close();
					return;
				}
			}
			tbx_FB_Result.Text = "Phục hồi Full Backup thành công";
			sql_connection.Close();
		}

		private void btn_FB_ShowCode_Click(object sender, EventArgs e)
		{
			string code = "Sao Lưu Full Backup:\r\ngo\r\ncreate procedure pcd_NBL_FullBackup\r\n@duongdan varchar(100), @tendatabase varchar(30)\r\nas\r\nbegin\r\n\tbackup database @tendatabase\r\n\tto disk = @duongdan\r\nend\r\ngo" +
				"\r\n\r\nPhục Hồi Có Recovery:\r\ngo\r\ncreate procedure pcd_NBL_RestoreRecovery\r\n@duongdan varchar(100),  @tendatabase varchar(30)\r\nas\r\nbegin\r\n\trestore database @tendatabase\r\n\tfrom disk = @duongdan\r\n\twith recovery\r\nend\r\ngo" +
				"\r\n\r\nPhục Hồi Không Recovery:\r\ngo\r\ncreate procedure pcd_NBL_RestoreNoRecovery\r\n@duongdan varchar(100),  @tendatabase varchar(30)\r\nas\r\nbegin\r\n\trestore database @tendatabase\r\n\tfrom disk = @duongdan\r\n\twith norecovery\r\nend\r\ngo";
			MessageBox.Show(code, "Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btn_DB_Backup_Click(object sender, EventArgs e)
		{
			tbx_DB_Result.Text = "";

			if (string.IsNullOrEmpty(tbx_DB_FilePath.Text))
			{
				tbx_DB_Result.Text = "Đường dẫn trống";
				return;
			}

			string database_name = "dtb_QLQCF";
			sql_connection.Open();
			SqlCommand sql_command = new SqlCommand("execute pcd_NBL_DifferentalBackup '" + tbx_DB_FilePath.Text + "', '" + database_name + "'", sql_connection);
			try
			{
				sql_command.ExecuteNonQuery();
			}
			catch
			{
				string backup = "backup database " + database_name + " to disk = '" + tbx_DB_FilePath.Text + "' with differential";
				sql_command = new SqlCommand(backup, sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
				}
				catch
				{
					tbx_DB_Result.Text = "Lỗi sao lưu";
					sql_connection.Close();
					return;
				}
			}
			tbx_DB_Result.Text = "Sao lưu Differental Backup thành công";
			sql_connection.Close();
		}

		private void btn_DB_Restore_Click(object sender, EventArgs e)
		{
			tbx_DB_Result.Text = "";

			if (string.IsNullOrEmpty(tbx_DB_FilePath.Text))
			{
				tbx_DB_Result.Text = "Đường dẫn trống";
				return;
			}

			string database_name = "dtb_QLQCF";
			string backup = "";
			sql_connection.Open();
			SqlCommand sql_command;

			if (cbx_DB_Settings.SelectedIndex == 0)
			{
				sql_command = new SqlCommand("execute pcd_NBL_RestoreRecovery '" + tbx_DB_FilePath.Text + "', '" + database_name + "'", sql_connection);
				backup = "restore database " + database_name + " from disk = '" + tbx_DB_FilePath.Text + "' with recovery";
			}
			else
			{
				sql_command = new SqlCommand("execute pcd_NBL_RestoreNoRecovery '" + tbx_DB_FilePath.Text + "', '" + database_name + "'", sql_connection);
				backup = "restore database " + database_name + " from disk = '" + tbx_DB_FilePath.Text + "' with norecovery";
			}

			try
			{
				sql_command.ExecuteNonQuery();
			}
			catch
			{
				sql_command = new SqlCommand(backup, sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
				}
				catch
				{
					tbx_DB_Result.Text = "Lỗi phục hồi";
					sql_connection.Close();
					return;
				}
			}
			tbx_DB_Result.Text = "Phục hồi Differential Backup thành công";
			sql_connection.Close();
		}

		private void btn_DB_ShowCode_Click(object sender, EventArgs e)
		{
			string code = "Sao Lưu Differential Backup:\r\ngo\r\ncreate procedure pcd_NBL_DifferentalBackup\r\n@duongdan varchar(100), @tendatabase varchar(30)\r\nas\r\nbegin\r\n\tbackup database @tendatabase\r\n\tto disk = @duongdan\r\n\twith differential\r\nend\r\ngo" +
				"\r\n\r\nPhục Hồi Có Recovery:\r\ngo\r\ncreate procedure pcd_NBL_RestoreRecovery\r\n@duongdan varchar(100),  @tendatabase varchar(30)\r\nas\r\nbegin\r\n\trestore database @tendatabase\r\n\tfrom disk = @duongdan\r\n\twith recovery\r\nend\r\ngo" +
				"\r\n\r\nPhục Hồi Không Recovery:\r\ngo\r\ncreate procedure pcd_NBL_RestoreNoRecovery\r\n@duongdan varchar(100),  @tendatabase varchar(30)\r\nas\r\nbegin\r\n\trestore database @tendatabase\r\n\tfrom disk = @duongdan\r\n\twith norecovery\r\nend\r\ngo";
			MessageBox.Show(code, "Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btn_TL_Backup_Click(object sender, EventArgs e)
		{
			tbx_TL_Result.Text = "";

			if (string.IsNullOrEmpty(tbx_TL_FilePath.Text))
			{
				tbx_TL_Result.Text = "Đường dẫn trống";
				return;
			}

			string database_name = "dtb_QLQCF";
			sql_connection.Open();
			SqlCommand sql_command = new SqlCommand("execute pcd_NBL_TransactionLog '" + tbx_TL_FilePath.Text + "', '" + database_name + "'", sql_connection);
			try
			{
				sql_command.ExecuteNonQuery();
			}
			catch
			{
				string backup = "backup log " + database_name + " to disk = '" + tbx_TL_FilePath.Text + "'";
				sql_command = new SqlCommand(backup, sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
				}
				catch
				{
					tbx_TL_Result.Text = "Lỗi sao lưu";
					sql_connection.Close();
					return;
				}
			}
			tbx_TL_Result.Text = "Sao lưu Transaction Log thành công";
			sql_connection.Close();
		}

		private void btn_TL_Restore_Click(object sender, EventArgs e)
		{
			tbx_TL_Result.Text = "";

			if (string.IsNullOrEmpty(tbx_TL_FilePath.Text))
			{
				tbx_TL_Result.Text = "Đường dẫn trống";
				return;
			}

			string database_name = "dtb_QLQCF";
			string backup = "";
			sql_connection.Open();
			SqlCommand sql_command;

			if (cbx_TL_Settings.SelectedIndex == 0)
			{
				sql_command = new SqlCommand("execute pcd_NBL_RestoreRecovery '" + tbx_TL_FilePath.Text + "', '" + database_name + "'", sql_connection);
				backup = "restore database " + database_name + " from disk = '" + tbx_TL_FilePath.Text + "' with recovery";
			}
			else
			{
				sql_command = new SqlCommand("execute pcd_NBL_RestoreNoRecovery '" + tbx_TL_FilePath.Text + "', '" + database_name + "'", sql_connection);
				backup = "restore database " + database_name + " from disk = '" + tbx_TL_FilePath.Text + "' with norecovery";
			}

			try
			{
				sql_command.ExecuteNonQuery();
			}
			catch
			{
				sql_command = new SqlCommand(backup, sql_connection);
				try
				{
					sql_command.ExecuteNonQuery();
				}
				catch
				{
					tbx_TL_Result.Text = "Lỗi phục hồi";
					sql_connection.Close();
					return;
				}
			}
			tbx_TL_Result.Text = "Phục hồi Transaction Log thành công";
			sql_connection.Close();
		}

		private void btn_TL_ShowCode_Click(object sender, EventArgs e)
		{
			string code = "Sao Lưu Transaction Log:\r\ngo\r\ncreate procedure pcd_NBL_TransactionLog\r\n@duongdan varchar(100), @tendatabase varchar(30)\r\nas\r\nbegin\r\n\tbackup log @tendatabase\r\n\tto disk = @duongdan\r\nend\r\ngo" +
				"\r\n\r\nPhục Hồi Có Recovery:\r\ngo\r\ncreate procedure pcd_NBL_RestoreRecovery\r\n@duongdan varchar(100),  @tendatabase varchar(30)\r\nas\r\nbegin\r\n\trestore database @tendatabase\r\n\tfrom disk = @duongdan\r\n\twith recovery\r\nend\r\ngo" +
				"\r\n\r\nPhục Hồi Không Recovery:\r\ngo\r\ncreate procedure pcd_NBL_RestoreNoRecovery\r\n@duongdan varchar(100),  @tendatabase varchar(30)\r\nas\r\nbegin\r\n\trestore database @tendatabase\r\n\tfrom disk = @duongdan\r\n\twith norecovery\r\nend\r\ngo";
			MessageBox.Show(code, "Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
