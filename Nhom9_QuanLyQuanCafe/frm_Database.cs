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
	public partial class frm_Database : Form
	{
		public string connection_string {  get; set; }

		public frm_Database(string connection_string)
		{
			InitializeComponent();
			this.connection_string = connection_string;
		}
	}
}
