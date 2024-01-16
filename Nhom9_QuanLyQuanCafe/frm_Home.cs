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
using System.Runtime.CompilerServices;

namespace Nhom9_QuanLyQuanCafe
{
	public partial class frm_Home : Form
	{
		public string login { get; set; }
		public string settings {  get; set; }
		public string connection_string { get; set; }
		public SqlConnection sql_connection { get; set; }

		public frm_Home(string login, string settings, string connection_string)
		{
			InitializeComponent();
			this.login = login;
			this.settings = settings;
			this.connection_string = connection_string;
			sql_connection = new SqlConnection(connection_string);
		}

		private void frm_Home_Load(object sender, EventArgs e)
		{
			frm_Database form_database = new frm_Database(connection_string);
			ftn_ShowForm(form_database);
		}

		private void ftn_ShowForm(Form child_form)
		{
			child_form.TopLevel = false;
			pnl_Child.Controls.Clear();
			pnl_Child.Controls.Add(child_form);
			child_form.Dock = DockStyle.Fill;
			child_form.Show();
		}

		private void btn_ConnectDatabase_Click(object sender, EventArgs e)
		{
			frm_Database form_database = new frm_Database(connection_string);
			ftn_ShowForm(form_database);
		}

		private void btn_BackupDatabase_Click(object sender, EventArgs e)
		{
			frm_BackupRestore form_backuprestore = new frm_BackupRestore(connection_string);
			ftn_ShowForm(form_backuprestore);
		}

		private void btn_Restoredatabase_Click(object sender, EventArgs e)
		{
			frm_BackupRestore form_backuprestore = new frm_BackupRestore(connection_string);
			ftn_ShowForm(form_backuprestore);
		}

		private void btn_Account_Click(object sender, EventArgs e)
		{

		}

		private void btn_Group_Click(object sender, EventArgs e)
		{
			frm_Permission form_permission = new frm_Permission(connection_string);
			ftn_ShowForm(form_permission);
		}

		private void btn_SignOut_Click(object sender, EventArgs e)
		{
			frm_SignIn form_SignIn = new frm_SignIn();
			form_SignIn.Show();
			Hide();
		}

		private void btn_Report_Click(object sender, EventArgs e)
		{
			frm_Statistical form_Statistical = new frm_Statistical();
			form_Statistical.Show();
		}

		private void btn_Employee_Click(object sender, EventArgs e)
		{
			frm_Employee form_employee = new frm_Employee();
			ftn_ShowForm(form_employee);
		}

		private void btn_NVCT_Click(object sender, EventArgs e)
		{

		}

		private void btn_Type_Click(object sender, EventArgs e)
		{
			//frm_Type form_type = new frm_Type(connection_string);
			//ftn_ShowForm(form_type);
		}

		private void btn_NBL_Click(object sender, EventArgs e)
		{

		}

		private void btn_Bill_Click(object sender, EventArgs e)
		{
			frm_Bill form_bill = new frm_Bill(connection_string);
			ftn_ShowForm(form_bill);
		}

		private void btn_HMA_Click(object sender, EventArgs e)
		{

		}

		private void btn_Menu_Click(object sender, EventArgs e)
		{
			frm_Menu form_menu = new frm_Menu(connection_string);
			ftn_ShowForm(form_menu);
		}

		private void btn_TCC_Click(object sender, EventArgs e)
		{

		}

		private void btn_Customer_Click(object sender, EventArgs e)
		{
			frm_Customer form_customer = new frm_Customer(connection_string);
			ftn_ShowForm(form_customer);
		}

		private void btn_TQT_Click(object sender, EventArgs e)
		{

		}

		private void btn_Permission_Click(object sender, EventArgs e)
		{
			frm_Permission form_permission = new frm_Permission(connection_string);
			ftn_ShowForm(form_permission);
		}

        private void frm_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
			Application.Exit();
        }
    }
}
