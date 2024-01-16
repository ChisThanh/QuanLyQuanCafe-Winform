namespace Nhom9_QuanLyQuanCafe
{
	partial class frm_Home
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pnl_Employee = new System.Windows.Forms.Panel();
            this.gbx_TQT = new System.Windows.Forms.GroupBox();
            this.btn_SignOut = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.gbx_TCC = new System.Windows.Forms.GroupBox();
            this.btn_Type = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.gbx_HMA = new System.Windows.Forms.GroupBox();
            this.btn_Bill = new System.Windows.Forms.Button();
            this.btn_ConnectDatabase = new System.Windows.Forms.Button();
            this.gbx_NBL = new System.Windows.Forms.GroupBox();
            this.btn_Permission = new System.Windows.Forms.Button();
            this.btn_BackupDatabase = new System.Windows.Forms.Button();
            this.gbx_NVCT = new System.Windows.Forms.GroupBox();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Employee = new System.Windows.Forms.Button();
            this.pnl_Child = new System.Windows.Forms.Panel();
            this.pnl_Employee.SuspendLayout();
            this.gbx_TQT.SuspendLayout();
            this.gbx_TCC.SuspendLayout();
            this.gbx_HMA.SuspendLayout();
            this.gbx_NBL.SuspendLayout();
            this.gbx_NVCT.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Employee
            // 
            this.pnl_Employee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Employee.Controls.Add(this.gbx_TQT);
            this.pnl_Employee.Controls.Add(this.gbx_TCC);
            this.pnl_Employee.Controls.Add(this.gbx_HMA);
            this.pnl_Employee.Controls.Add(this.gbx_NBL);
            this.pnl_Employee.Controls.Add(this.gbx_NVCT);
            this.pnl_Employee.Location = new System.Drawing.Point(12, 12);
            this.pnl_Employee.Name = "pnl_Employee";
            this.pnl_Employee.Size = new System.Drawing.Size(333, 750);
            this.pnl_Employee.TabIndex = 2;
            // 
            // gbx_TQT
            // 
            this.gbx_TQT.Controls.Add(this.btn_SignOut);
            this.gbx_TQT.Controls.Add(this.btn_Customer);
            this.gbx_TQT.Location = new System.Drawing.Point(8, 596);
            this.gbx_TQT.Name = "gbx_TQT";
            this.gbx_TQT.Size = new System.Drawing.Size(315, 141);
            this.gbx_TQT.TabIndex = 4;
            this.gbx_TQT.TabStop = false;
            this.gbx_TQT.Text = "Trần Quyết Tài";
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.SignOut;
            this.btn_SignOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_SignOut.Location = new System.Drawing.Point(159, 25);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(129, 99);
            this.btn_SignOut.TabIndex = 2;
            this.btn_SignOut.Text = "Đăng Xuất";
            this.btn_SignOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SignOut.UseVisualStyleBackColor = true;
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Customer;
            this.btn_Customer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Customer.Location = new System.Drawing.Point(24, 25);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(129, 99);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Khách Hàng";
            this.btn_Customer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // gbx_TCC
            // 
            this.gbx_TCC.Controls.Add(this.btn_Type);
            this.gbx_TCC.Controls.Add(this.btn_Menu);
            this.gbx_TCC.Location = new System.Drawing.Point(8, 449);
            this.gbx_TCC.Name = "gbx_TCC";
            this.gbx_TCC.Size = new System.Drawing.Size(315, 141);
            this.gbx_TCC.TabIndex = 3;
            this.gbx_TCC.TabStop = false;
            this.gbx_TCC.Text = "Trần Chí Công";
            // 
            // btn_Type
            // 
            this.btn_Type.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Food;
            this.btn_Type.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Type.Location = new System.Drawing.Point(24, 25);
            this.btn_Type.Name = "btn_Type";
            this.btn_Type.Size = new System.Drawing.Size(129, 99);
            this.btn_Type.TabIndex = 0;
            this.btn_Type.Text = "Loại Thực Đơn";
            this.btn_Type.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Type.UseVisualStyleBackColor = true;
            this.btn_Type.Click += new System.EventHandler(this.btn_Type_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Menu;
            this.btn_Menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Menu.Location = new System.Drawing.Point(159, 25);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(129, 99);
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.Text = "Thực Đơn";
            this.btn_Menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // gbx_HMA
            // 
            this.gbx_HMA.Controls.Add(this.btn_Bill);
            this.gbx_HMA.Controls.Add(this.btn_ConnectDatabase);
            this.gbx_HMA.Location = new System.Drawing.Point(8, 302);
            this.gbx_HMA.Name = "gbx_HMA";
            this.gbx_HMA.Size = new System.Drawing.Size(315, 141);
            this.gbx_HMA.TabIndex = 2;
            this.gbx_HMA.TabStop = false;
            this.gbx_HMA.Text = "Hoàng Minh Anh";
            // 
            // btn_Bill
            // 
            this.btn_Bill.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Bill;
            this.btn_Bill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Bill.Location = new System.Drawing.Point(159, 25);
            this.btn_Bill.Name = "btn_Bill";
            this.btn_Bill.Size = new System.Drawing.Size(129, 99);
            this.btn_Bill.TabIndex = 1;
            this.btn_Bill.Text = "Hóa Đơn";
            this.btn_Bill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Bill.UseVisualStyleBackColor = true;
            this.btn_Bill.Click += new System.EventHandler(this.btn_Bill_Click);
            // 
            // btn_ConnectDatabase
            // 
            this.btn_ConnectDatabase.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Database;
            this.btn_ConnectDatabase.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ConnectDatabase.Location = new System.Drawing.Point(24, 25);
            this.btn_ConnectDatabase.Name = "btn_ConnectDatabase";
            this.btn_ConnectDatabase.Size = new System.Drawing.Size(129, 99);
            this.btn_ConnectDatabase.TabIndex = 0;
            this.btn_ConnectDatabase.Text = "Kiểm Tra";
            this.btn_ConnectDatabase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ConnectDatabase.UseVisualStyleBackColor = true;
            this.btn_ConnectDatabase.Click += new System.EventHandler(this.btn_ConnectDatabase_Click);
            // 
            // gbx_NBL
            // 
            this.gbx_NBL.Controls.Add(this.btn_Permission);
            this.gbx_NBL.Controls.Add(this.btn_BackupDatabase);
            this.gbx_NBL.Location = new System.Drawing.Point(8, 155);
            this.gbx_NBL.Name = "gbx_NBL";
            this.gbx_NBL.Size = new System.Drawing.Size(315, 141);
            this.gbx_NBL.TabIndex = 1;
            this.gbx_NBL.TabStop = false;
            this.gbx_NBL.Text = "Nguyễn Bảo Long";
            // 
            // btn_Permission
            // 
            this.btn_Permission.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Permission;
            this.btn_Permission.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Permission.Location = new System.Drawing.Point(24, 25);
            this.btn_Permission.Name = "btn_Permission";
            this.btn_Permission.Size = new System.Drawing.Size(129, 99);
            this.btn_Permission.TabIndex = 0;
            this.btn_Permission.Text = "Phân Quyền";
            this.btn_Permission.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Permission.UseVisualStyleBackColor = true;
            this.btn_Permission.Click += new System.EventHandler(this.btn_Permission_Click);
            // 
            // btn_BackupDatabase
            // 
            this.btn_BackupDatabase.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Backup;
            this.btn_BackupDatabase.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_BackupDatabase.Location = new System.Drawing.Point(159, 25);
            this.btn_BackupDatabase.Name = "btn_BackupDatabase";
            this.btn_BackupDatabase.Size = new System.Drawing.Size(129, 99);
            this.btn_BackupDatabase.TabIndex = 1;
            this.btn_BackupDatabase.Text = "Sao Lưu";
            this.btn_BackupDatabase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_BackupDatabase.UseVisualStyleBackColor = true;
            this.btn_BackupDatabase.Click += new System.EventHandler(this.btn_BackupDatabase_Click);
            // 
            // gbx_NVCT
            // 
            this.gbx_NVCT.Controls.Add(this.btn_Report);
            this.gbx_NVCT.Controls.Add(this.btn_Employee);
            this.gbx_NVCT.Location = new System.Drawing.Point(8, 8);
            this.gbx_NVCT.Name = "gbx_NVCT";
            this.gbx_NVCT.Size = new System.Drawing.Size(315, 141);
            this.gbx_NVCT.TabIndex = 0;
            this.gbx_NVCT.TabStop = false;
            this.gbx_NVCT.Text = "Nguyễn Văn Chí Thanh";
            // 
            // btn_Report
            // 
            this.btn_Report.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Statistic;
            this.btn_Report.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Report.Location = new System.Drawing.Point(159, 28);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(129, 99);
            this.btn_Report.TabIndex = 1;
            this.btn_Report.Text = "Thống Kê";
            this.btn_Report.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_Employee
            // 
            this.btn_Employee.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Employee;
            this.btn_Employee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Employee.Location = new System.Drawing.Point(24, 28);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(129, 99);
            this.btn_Employee.TabIndex = 0;
            this.btn_Employee.Text = "Nhân Viên";
            this.btn_Employee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Employee.UseVisualStyleBackColor = true;
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // pnl_Child
            // 
            this.pnl_Child.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Child.Location = new System.Drawing.Point(351, 12);
            this.pnl_Child.Name = "pnl_Child";
            this.pnl_Child.Size = new System.Drawing.Size(800, 750);
            this.pnl_Child.TabIndex = 3;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 773);
            this.Controls.Add(this.pnl_Child);
            this.Controls.Add(this.pnl_Employee);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Quán Cafe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Home_FormClosing);
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.pnl_Employee.ResumeLayout(false);
            this.gbx_TQT.ResumeLayout(false);
            this.gbx_TCC.ResumeLayout(false);
            this.gbx_HMA.ResumeLayout(false);
            this.gbx_NBL.ResumeLayout(false);
            this.gbx_NVCT.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnl_Employee;
		private System.Windows.Forms.Panel pnl_Child;
		private System.Windows.Forms.Button btn_BackupDatabase;
		private System.Windows.Forms.Button btn_ConnectDatabase;
		private System.Windows.Forms.Button btn_Permission;
		private System.Windows.Forms.GroupBox gbx_NVCT;
		private System.Windows.Forms.Button btn_Employee;
		private System.Windows.Forms.GroupBox gbx_TQT;
		private System.Windows.Forms.Button btn_Customer;
		private System.Windows.Forms.GroupBox gbx_TCC;
		private System.Windows.Forms.Button btn_Menu;
		private System.Windows.Forms.GroupBox gbx_HMA;
		private System.Windows.Forms.Button btn_Bill;
		private System.Windows.Forms.GroupBox gbx_NBL;
		private System.Windows.Forms.Button btn_Type;
		private System.Windows.Forms.Button btn_Report;
		private System.Windows.Forms.Button btn_SignOut;
	}
}