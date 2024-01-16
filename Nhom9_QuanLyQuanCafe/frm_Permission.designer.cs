namespace Nhom9_QuanLyQuanCafe
{
	partial class frm_Permission
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
			this.lbl_Title = new System.Windows.Forms.Label();
			this.pnl_Color = new System.Windows.Forms.Panel();
			this.dgv_Login = new System.Windows.Forms.DataGridView();
			this.pnl_Permission = new System.Windows.Forms.Panel();
			this.cbx_TenNhomQuyen = new System.Windows.Forms.ComboBox();
			this.cbx_TenNguoiDung = new System.Windows.Forms.ComboBox();
			this.lbl_TenNguoiDung_Role = new System.Windows.Forms.Label();
			this.lbl_TenNhomQuyen = new System.Windows.Forms.Label();
			this.chk_Cascade = new System.Windows.Forms.CheckBox();
			this.chk_Grant = new System.Windows.Forms.CheckBox();
			this.cbx_TenBang = new System.Windows.Forms.ComboBox();
			this.lbl_TenBang = new System.Windows.Forms.Label();
			this.cbx_Quyen = new System.Windows.Forms.ComboBox();
			this.lbl_Quyen = new System.Windows.Forms.Label();
			this.tbx_TenNguoiDung = new System.Windows.Forms.TextBox();
			this.lbl_TenNguoiDung = new System.Windows.Forms.Label();
			this.pnl_Tooltip_Tab1 = new System.Windows.Forms.Panel();
			this.rdo_Role = new System.Windows.Forms.RadioButton();
			this.rdo_User = new System.Windows.Forms.RadioButton();
			this.rdo_Login = new System.Windows.Forms.RadioButton();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Insert = new System.Windows.Forms.Button();
			this.dgv_RoleMember = new System.Windows.Forms.DataGridView();
			this.pnl_Login = new System.Windows.Forms.Panel();
			this.tbx_MatKhau = new System.Windows.Forms.TextBox();
			this.lbl_MatKhau = new System.Windows.Forms.Label();
			this.tbx_TenTaiKhoan = new System.Windows.Forms.TextBox();
			this.lbl_TenTaiKhoan = new System.Windows.Forms.Label();
			this.pnl_User = new System.Windows.Forms.Panel();
			this.cbx_TenTaiKhoan = new System.Windows.Forms.ComboBox();
			this.lbl_TenTaiKhoan_User = new System.Windows.Forms.Label();
			this.dgv_User = new System.Windows.Forms.DataGridView();
			this.tct_Tab = new System.Windows.Forms.TabControl();
			this.tpg_Add = new System.Windows.Forms.TabPage();
			this.dgv_Role = new System.Windows.Forms.DataGridView();
			this.pnl_Role = new System.Windows.Forms.Panel();
			this.tbx_TenNhomQuyen = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tpg_Role = new System.Windows.Forms.TabPage();
			this.dgv_RolePermission = new System.Windows.Forms.DataGridView();
			this.pnl_Tooltips_Tab2 = new System.Windows.Forms.Panel();
			this.btn_Deny = new System.Windows.Forms.Button();
			this.rdo_Permission = new System.Windows.Forms.RadioButton();
			this.rdo_Member = new System.Windows.Forms.RadioButton();
			this.btn_Revoke = new System.Windows.Forms.Button();
			this.btn_Grant = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Login)).BeginInit();
			this.pnl_Permission.SuspendLayout();
			this.pnl_Tooltip_Tab1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_RoleMember)).BeginInit();
			this.pnl_Login.SuspendLayout();
			this.pnl_User.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_User)).BeginInit();
			this.tct_Tab.SuspendLayout();
			this.tpg_Add.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Role)).BeginInit();
			this.pnl_Role.SuspendLayout();
			this.tpg_Role.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_RolePermission)).BeginInit();
			this.pnl_Tooltips_Tab2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_Title
			// 
			this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.lbl_Title.Location = new System.Drawing.Point(12, 17);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(389, 50);
			this.lbl_Title.TabIndex = 1;
			this.lbl_Title.Text = "Phân Quyền";
			this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnl_Color
			// 
			this.pnl_Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(143)))));
			this.pnl_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Color.Location = new System.Drawing.Point(407, 12);
			this.pnl_Color.Name = "pnl_Color";
			this.pnl_Color.Size = new System.Drawing.Size(381, 67);
			this.pnl_Color.TabIndex = 7;
			// 
			// dgv_Login
			// 
			this.dgv_Login.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Login.Location = new System.Drawing.Point(10, 281);
			this.dgv_Login.Name = "dgv_Login";
			this.dgv_Login.Size = new System.Drawing.Size(375, 324);
			this.dgv_Login.TabIndex = 8;
			// 
			// pnl_Permission
			// 
			this.pnl_Permission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Permission.Controls.Add(this.cbx_TenNhomQuyen);
			this.pnl_Permission.Controls.Add(this.cbx_TenNguoiDung);
			this.pnl_Permission.Controls.Add(this.lbl_TenNguoiDung_Role);
			this.pnl_Permission.Controls.Add(this.lbl_TenNhomQuyen);
			this.pnl_Permission.Controls.Add(this.chk_Cascade);
			this.pnl_Permission.Controls.Add(this.chk_Grant);
			this.pnl_Permission.Controls.Add(this.cbx_TenBang);
			this.pnl_Permission.Controls.Add(this.lbl_TenBang);
			this.pnl_Permission.Controls.Add(this.cbx_Quyen);
			this.pnl_Permission.Controls.Add(this.lbl_Quyen);
			this.pnl_Permission.Location = new System.Drawing.Point(10, 14);
			this.pnl_Permission.Name = "pnl_Permission";
			this.pnl_Permission.Size = new System.Drawing.Size(747, 126);
			this.pnl_Permission.TabIndex = 9;
			// 
			// cbx_TenNhomQuyen
			// 
			this.cbx_TenNhomQuyen.FormattingEnabled = true;
			this.cbx_TenNhomQuyen.Location = new System.Drawing.Point(133, 10);
			this.cbx_TenNhomQuyen.Name = "cbx_TenNhomQuyen";
			this.cbx_TenNhomQuyen.Size = new System.Drawing.Size(316, 27);
			this.cbx_TenNhomQuyen.TabIndex = 14;
			// 
			// cbx_TenNguoiDung
			// 
			this.cbx_TenNguoiDung.FormattingEnabled = true;
			this.cbx_TenNguoiDung.Location = new System.Drawing.Point(466, 75);
			this.cbx_TenNguoiDung.Name = "cbx_TenNguoiDung";
			this.cbx_TenNguoiDung.Size = new System.Drawing.Size(270, 27);
			this.cbx_TenNguoiDung.TabIndex = 13;
			// 
			// lbl_TenNguoiDung_Role
			// 
			this.lbl_TenNguoiDung_Role.AutoSize = true;
			this.lbl_TenNguoiDung_Role.Location = new System.Drawing.Point(462, 53);
			this.lbl_TenNguoiDung_Role.Name = "lbl_TenNguoiDung_Role";
			this.lbl_TenNguoiDung_Role.Size = new System.Drawing.Size(111, 19);
			this.lbl_TenNguoiDung_Role.TabIndex = 13;
			this.lbl_TenNguoiDung_Role.Text = "Tên Người Dùng";
			// 
			// lbl_TenNhomQuyen
			// 
			this.lbl_TenNhomQuyen.AutoSize = true;
			this.lbl_TenNhomQuyen.Location = new System.Drawing.Point(9, 13);
			this.lbl_TenNhomQuyen.Name = "lbl_TenNhomQuyen";
			this.lbl_TenNhomQuyen.Size = new System.Drawing.Size(118, 19);
			this.lbl_TenNhomQuyen.TabIndex = 0;
			this.lbl_TenNhomQuyen.Text = "Tên Nhóm Quyền";
			// 
			// chk_Cascade
			// 
			this.chk_Cascade.AutoSize = true;
			this.chk_Cascade.Location = new System.Drawing.Point(638, 13);
			this.chk_Cascade.Name = "chk_Cascade";
			this.chk_Cascade.Size = new System.Drawing.Size(81, 23);
			this.chk_Cascade.TabIndex = 11;
			this.chk_Cascade.Text = "Cascade";
			this.chk_Cascade.UseVisualStyleBackColor = true;
			// 
			// chk_Grant
			// 
			this.chk_Grant.AutoSize = true;
			this.chk_Grant.Location = new System.Drawing.Point(486, 13);
			this.chk_Grant.Name = "chk_Grant";
			this.chk_Grant.Size = new System.Drawing.Size(140, 23);
			this.chk_Grant.TabIndex = 10;
			this.chk_Grant.Text = "With Grant Option";
			this.chk_Grant.UseVisualStyleBackColor = true;
			// 
			// cbx_TenBang
			// 
			this.cbx_TenBang.FormattingEnabled = true;
			this.cbx_TenBang.Location = new System.Drawing.Point(133, 42);
			this.cbx_TenBang.Name = "cbx_TenBang";
			this.cbx_TenBang.Size = new System.Drawing.Size(316, 27);
			this.cbx_TenBang.TabIndex = 9;
			// 
			// lbl_TenBang
			// 
			this.lbl_TenBang.AutoSize = true;
			this.lbl_TenBang.Location = new System.Drawing.Point(60, 45);
			this.lbl_TenBang.Name = "lbl_TenBang";
			this.lbl_TenBang.Size = new System.Drawing.Size(67, 19);
			this.lbl_TenBang.TabIndex = 8;
			this.lbl_TenBang.Text = "Tên Bảng";
			// 
			// cbx_Quyen
			// 
			this.cbx_Quyen.FormattingEnabled = true;
			this.cbx_Quyen.Location = new System.Drawing.Point(133, 75);
			this.cbx_Quyen.Name = "cbx_Quyen";
			this.cbx_Quyen.Size = new System.Drawing.Size(316, 27);
			this.cbx_Quyen.TabIndex = 7;
			// 
			// lbl_Quyen
			// 
			this.lbl_Quyen.AutoSize = true;
			this.lbl_Quyen.Location = new System.Drawing.Point(78, 78);
			this.lbl_Quyen.Name = "lbl_Quyen";
			this.lbl_Quyen.Size = new System.Drawing.Size(49, 19);
			this.lbl_Quyen.TabIndex = 4;
			this.lbl_Quyen.Text = "Quyền";
			// 
			// tbx_TenNguoiDung
			// 
			this.tbx_TenNguoiDung.Location = new System.Drawing.Point(131, 47);
			this.tbx_TenNguoiDung.Name = "tbx_TenNguoiDung";
			this.tbx_TenNguoiDung.Size = new System.Drawing.Size(587, 26);
			this.tbx_TenNguoiDung.TabIndex = 3;
			// 
			// lbl_TenNguoiDung
			// 
			this.lbl_TenNguoiDung.AutoSize = true;
			this.lbl_TenNguoiDung.Location = new System.Drawing.Point(14, 50);
			this.lbl_TenNguoiDung.Name = "lbl_TenNguoiDung";
			this.lbl_TenNguoiDung.Size = new System.Drawing.Size(111, 19);
			this.lbl_TenNguoiDung.TabIndex = 2;
			this.lbl_TenNguoiDung.Text = "Tên Người Dùng";
			// 
			// pnl_Tooltip_Tab1
			// 
			this.pnl_Tooltip_Tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Tooltip_Tab1.Controls.Add(this.rdo_Role);
			this.pnl_Tooltip_Tab1.Controls.Add(this.rdo_User);
			this.pnl_Tooltip_Tab1.Controls.Add(this.rdo_Login);
			this.pnl_Tooltip_Tab1.Controls.Add(this.btn_Delete);
			this.pnl_Tooltip_Tab1.Controls.Add(this.btn_Insert);
			this.pnl_Tooltip_Tab1.Location = new System.Drawing.Point(10, 212);
			this.pnl_Tooltip_Tab1.Name = "pnl_Tooltip_Tab1";
			this.pnl_Tooltip_Tab1.Size = new System.Drawing.Size(747, 63);
			this.pnl_Tooltip_Tab1.TabIndex = 10;
			// 
			// rdo_Role
			// 
			this.rdo_Role.AutoSize = true;
			this.rdo_Role.Location = new System.Drawing.Point(434, 21);
			this.rdo_Role.Name = "rdo_Role";
			this.rdo_Role.Size = new System.Drawing.Size(109, 23);
			this.rdo_Role.TabIndex = 15;
			this.rdo_Role.TabStop = true;
			this.rdo_Role.Text = "Nhóm Quyền";
			this.rdo_Role.UseVisualStyleBackColor = true;
			this.rdo_Role.CheckedChanged += new System.EventHandler(this.rdo_Role_CheckedChanged);
			// 
			// rdo_User
			// 
			this.rdo_User.AutoSize = true;
			this.rdo_User.Location = new System.Drawing.Point(326, 21);
			this.rdo_User.Name = "rdo_User";
			this.rdo_User.Size = new System.Drawing.Size(102, 23);
			this.rdo_User.TabIndex = 13;
			this.rdo_User.TabStop = true;
			this.rdo_User.Text = "Người Dùng";
			this.rdo_User.UseVisualStyleBackColor = true;
			this.rdo_User.CheckedChanged += new System.EventHandler(this.rdo_User_CheckedChanged);
			// 
			// rdo_Login
			// 
			this.rdo_Login.AutoSize = true;
			this.rdo_Login.Location = new System.Drawing.Point(229, 21);
			this.rdo_Login.Name = "rdo_Login";
			this.rdo_Login.Size = new System.Drawing.Size(91, 23);
			this.rdo_Login.TabIndex = 12;
			this.rdo_Login.TabStop = true;
			this.rdo_Login.Text = "Tài Khoản";
			this.rdo_Login.UseVisualStyleBackColor = true;
			this.rdo_Login.CheckedChanged += new System.EventHandler(this.rdo_Login_CheckedChanged);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Delete;
			this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_Delete.Location = new System.Drawing.Point(110, 3);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(99, 55);
			this.btn_Delete.TabIndex = 11;
			this.btn_Delete.Text = "Xóa";
			this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Insert
			// 
			this.btn_Insert.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Insert;
			this.btn_Insert.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_Insert.Location = new System.Drawing.Point(5, 3);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.Size = new System.Drawing.Size(99, 55);
			this.btn_Insert.TabIndex = 10;
			this.btn_Insert.Text = "Thêm";
			this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_Insert.UseVisualStyleBackColor = true;
			this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
			// 
			// dgv_RoleMember
			// 
			this.dgv_RoleMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_RoleMember.Location = new System.Drawing.Point(526, 215);
			this.dgv_RoleMember.Name = "dgv_RoleMember";
			this.dgv_RoleMember.Size = new System.Drawing.Size(231, 389);
			this.dgv_RoleMember.TabIndex = 11;
			// 
			// pnl_Login
			// 
			this.pnl_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Login.Controls.Add(this.tbx_MatKhau);
			this.pnl_Login.Controls.Add(this.lbl_MatKhau);
			this.pnl_Login.Controls.Add(this.tbx_TenTaiKhoan);
			this.pnl_Login.Controls.Add(this.lbl_TenTaiKhoan);
			this.pnl_Login.Location = new System.Drawing.Point(10, 14);
			this.pnl_Login.Name = "pnl_Login";
			this.pnl_Login.Size = new System.Drawing.Size(445, 93);
			this.pnl_Login.TabIndex = 10;
			// 
			// tbx_MatKhau
			// 
			this.tbx_MatKhau.Location = new System.Drawing.Point(131, 47);
			this.tbx_MatKhau.Name = "tbx_MatKhau";
			this.tbx_MatKhau.Size = new System.Drawing.Size(297, 26);
			this.tbx_MatKhau.TabIndex = 3;
			// 
			// lbl_MatKhau
			// 
			this.lbl_MatKhau.AutoSize = true;
			this.lbl_MatKhau.Location = new System.Drawing.Point(54, 50);
			this.lbl_MatKhau.Name = "lbl_MatKhau";
			this.lbl_MatKhau.Size = new System.Drawing.Size(71, 19);
			this.lbl_MatKhau.TabIndex = 2;
			this.lbl_MatKhau.Text = "Mật Khẩu";
			// 
			// tbx_TenTaiKhoan
			// 
			this.tbx_TenTaiKhoan.Location = new System.Drawing.Point(131, 15);
			this.tbx_TenTaiKhoan.Name = "tbx_TenTaiKhoan";
			this.tbx_TenTaiKhoan.Size = new System.Drawing.Size(297, 26);
			this.tbx_TenTaiKhoan.TabIndex = 1;
			// 
			// lbl_TenTaiKhoan
			// 
			this.lbl_TenTaiKhoan.AutoSize = true;
			this.lbl_TenTaiKhoan.Location = new System.Drawing.Point(25, 18);
			this.lbl_TenTaiKhoan.Name = "lbl_TenTaiKhoan";
			this.lbl_TenTaiKhoan.Size = new System.Drawing.Size(100, 19);
			this.lbl_TenTaiKhoan.TabIndex = 0;
			this.lbl_TenTaiKhoan.Text = "Tên Tài Khoản";
			// 
			// pnl_User
			// 
			this.pnl_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_User.Controls.Add(this.cbx_TenTaiKhoan);
			this.pnl_User.Controls.Add(this.lbl_TenTaiKhoan_User);
			this.pnl_User.Controls.Add(this.tbx_TenNguoiDung);
			this.pnl_User.Controls.Add(this.lbl_TenNguoiDung);
			this.pnl_User.Location = new System.Drawing.Point(10, 113);
			this.pnl_User.Name = "pnl_User";
			this.pnl_User.Size = new System.Drawing.Size(747, 93);
			this.pnl_User.TabIndex = 11;
			// 
			// cbx_TenTaiKhoan
			// 
			this.cbx_TenTaiKhoan.FormattingEnabled = true;
			this.cbx_TenTaiKhoan.Location = new System.Drawing.Point(131, 14);
			this.cbx_TenTaiKhoan.Name = "cbx_TenTaiKhoan";
			this.cbx_TenTaiKhoan.Size = new System.Drawing.Size(587, 27);
			this.cbx_TenTaiKhoan.TabIndex = 12;
			// 
			// lbl_TenTaiKhoan_User
			// 
			this.lbl_TenTaiKhoan_User.AutoSize = true;
			this.lbl_TenTaiKhoan_User.Location = new System.Drawing.Point(25, 18);
			this.lbl_TenTaiKhoan_User.Name = "lbl_TenTaiKhoan_User";
			this.lbl_TenTaiKhoan_User.Size = new System.Drawing.Size(100, 19);
			this.lbl_TenTaiKhoan_User.TabIndex = 4;
			this.lbl_TenTaiKhoan_User.Text = "Tên Tài Khoản";
			// 
			// dgv_User
			// 
			this.dgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_User.Location = new System.Drawing.Point(391, 281);
			this.dgv_User.Name = "dgv_User";
			this.dgv_User.Size = new System.Drawing.Size(192, 324);
			this.dgv_User.TabIndex = 12;
			// 
			// tct_Tab
			// 
			this.tct_Tab.Controls.Add(this.tpg_Add);
			this.tct_Tab.Controls.Add(this.tpg_Role);
			this.tct_Tab.Location = new System.Drawing.Point(12, 85);
			this.tct_Tab.Name = "tct_Tab";
			this.tct_Tab.SelectedIndex = 0;
			this.tct_Tab.Size = new System.Drawing.Size(776, 653);
			this.tct_Tab.TabIndex = 13;
			this.tct_Tab.SelectedIndexChanged += new System.EventHandler(this.tct_Tab_SelectedIndexChanged);
			// 
			// tpg_Add
			// 
			this.tpg_Add.Controls.Add(this.dgv_Role);
			this.tpg_Add.Controls.Add(this.pnl_Role);
			this.tpg_Add.Controls.Add(this.pnl_Login);
			this.tpg_Add.Controls.Add(this.dgv_User);
			this.tpg_Add.Controls.Add(this.pnl_Tooltip_Tab1);
			this.tpg_Add.Controls.Add(this.pnl_User);
			this.tpg_Add.Controls.Add(this.dgv_Login);
			this.tpg_Add.Location = new System.Drawing.Point(4, 28);
			this.tpg_Add.Name = "tpg_Add";
			this.tpg_Add.Padding = new System.Windows.Forms.Padding(3);
			this.tpg_Add.Size = new System.Drawing.Size(768, 621);
			this.tpg_Add.TabIndex = 0;
			this.tpg_Add.Text = "Đối Tượng";
			this.tpg_Add.UseVisualStyleBackColor = true;
			// 
			// dgv_Role
			// 
			this.dgv_Role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Role.Location = new System.Drawing.Point(589, 281);
			this.dgv_Role.Name = "dgv_Role";
			this.dgv_Role.Size = new System.Drawing.Size(168, 324);
			this.dgv_Role.TabIndex = 13;
			// 
			// pnl_Role
			// 
			this.pnl_Role.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Role.Controls.Add(this.tbx_TenNhomQuyen);
			this.pnl_Role.Controls.Add(this.label2);
			this.pnl_Role.Location = new System.Drawing.Point(461, 14);
			this.pnl_Role.Name = "pnl_Role";
			this.pnl_Role.Size = new System.Drawing.Size(296, 93);
			this.pnl_Role.TabIndex = 11;
			// 
			// tbx_TenNhomQuyen
			// 
			this.tbx_TenNhomQuyen.Location = new System.Drawing.Point(3, 47);
			this.tbx_TenNhomQuyen.Name = "tbx_TenNhomQuyen";
			this.tbx_TenNhomQuyen.Size = new System.Drawing.Size(288, 26);
			this.tbx_TenNhomQuyen.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên Nhóm Quyền";
			// 
			// tpg_Role
			// 
			this.tpg_Role.Controls.Add(this.dgv_RolePermission);
			this.tpg_Role.Controls.Add(this.pnl_Tooltips_Tab2);
			this.tpg_Role.Controls.Add(this.pnl_Permission);
			this.tpg_Role.Controls.Add(this.dgv_RoleMember);
			this.tpg_Role.Location = new System.Drawing.Point(4, 28);
			this.tpg_Role.Name = "tpg_Role";
			this.tpg_Role.Padding = new System.Windows.Forms.Padding(3);
			this.tpg_Role.Size = new System.Drawing.Size(768, 621);
			this.tpg_Role.TabIndex = 1;
			this.tpg_Role.Text = "Phân Quyền";
			this.tpg_Role.UseVisualStyleBackColor = true;
			// 
			// dgv_RolePermission
			// 
			this.dgv_RolePermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_RolePermission.Location = new System.Drawing.Point(10, 215);
			this.dgv_RolePermission.Name = "dgv_RolePermission";
			this.dgv_RolePermission.Size = new System.Drawing.Size(510, 389);
			this.dgv_RolePermission.TabIndex = 13;
			// 
			// pnl_Tooltips_Tab2
			// 
			this.pnl_Tooltips_Tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Tooltips_Tab2.Controls.Add(this.btn_Deny);
			this.pnl_Tooltips_Tab2.Controls.Add(this.rdo_Permission);
			this.pnl_Tooltips_Tab2.Controls.Add(this.rdo_Member);
			this.pnl_Tooltips_Tab2.Controls.Add(this.btn_Revoke);
			this.pnl_Tooltips_Tab2.Controls.Add(this.btn_Grant);
			this.pnl_Tooltips_Tab2.Location = new System.Drawing.Point(10, 146);
			this.pnl_Tooltips_Tab2.Name = "pnl_Tooltips_Tab2";
			this.pnl_Tooltips_Tab2.Size = new System.Drawing.Size(747, 63);
			this.pnl_Tooltips_Tab2.TabIndex = 12;
			// 
			// btn_Deny
			// 
			this.btn_Deny.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Filter;
			this.btn_Deny.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_Deny.Location = new System.Drawing.Point(215, 3);
			this.btn_Deny.Name = "btn_Deny";
			this.btn_Deny.Size = new System.Drawing.Size(99, 55);
			this.btn_Deny.TabIndex = 17;
			this.btn_Deny.Text = "Chặn";
			this.btn_Deny.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_Deny.UseVisualStyleBackColor = true;
			this.btn_Deny.Click += new System.EventHandler(this.btn_Deny_Click);
			// 
			// rdo_Permission
			// 
			this.rdo_Permission.AutoSize = true;
			this.rdo_Permission.Location = new System.Drawing.Point(328, 19);
			this.rdo_Permission.Name = "rdo_Permission";
			this.rdo_Permission.Size = new System.Drawing.Size(101, 23);
			this.rdo_Permission.TabIndex = 16;
			this.rdo_Permission.TabStop = true;
			this.rdo_Permission.Text = "Phân Quyền";
			this.rdo_Permission.UseVisualStyleBackColor = true;
			this.rdo_Permission.CheckedChanged += new System.EventHandler(this.rdo_Permission_CheckedChanged);
			// 
			// rdo_Member
			// 
			this.rdo_Member.AutoSize = true;
			this.rdo_Member.Location = new System.Drawing.Point(435, 19);
			this.rdo_Member.Name = "rdo_Member";
			this.rdo_Member.Size = new System.Drawing.Size(95, 23);
			this.rdo_Member.TabIndex = 15;
			this.rdo_Member.TabStop = true;
			this.rdo_Member.Text = "Thành Viên";
			this.rdo_Member.UseVisualStyleBackColor = true;
			this.rdo_Member.CheckedChanged += new System.EventHandler(this.rdo_Member_CheckedChanged);
			// 
			// btn_Revoke
			// 
			this.btn_Revoke.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Delete;
			this.btn_Revoke.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_Revoke.Location = new System.Drawing.Point(110, 3);
			this.btn_Revoke.Name = "btn_Revoke";
			this.btn_Revoke.Size = new System.Drawing.Size(99, 55);
			this.btn_Revoke.TabIndex = 11;
			this.btn_Revoke.Text = "Tước";
			this.btn_Revoke.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_Revoke.UseVisualStyleBackColor = true;
			this.btn_Revoke.Click += new System.EventHandler(this.btn_Revoke_Click);
			// 
			// btn_Grant
			// 
			this.btn_Grant.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Insert;
			this.btn_Grant.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_Grant.Location = new System.Drawing.Point(5, 3);
			this.btn_Grant.Name = "btn_Grant";
			this.btn_Grant.Size = new System.Drawing.Size(99, 55);
			this.btn_Grant.TabIndex = 10;
			this.btn_Grant.Text = "Cho";
			this.btn_Grant.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_Grant.UseVisualStyleBackColor = true;
			this.btn_Grant.Click += new System.EventHandler(this.btn_Grant_Click);
			// 
			// frm_Permission
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 750);
			this.Controls.Add(this.tct_Tab);
			this.Controls.Add(this.pnl_Color);
			this.Controls.Add(this.lbl_Title);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_Permission";
			this.Text = "frm_Permission";
			this.Load += new System.EventHandler(this.frm_Permission_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Login)).EndInit();
			this.pnl_Permission.ResumeLayout(false);
			this.pnl_Permission.PerformLayout();
			this.pnl_Tooltip_Tab1.ResumeLayout(false);
			this.pnl_Tooltip_Tab1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_RoleMember)).EndInit();
			this.pnl_Login.ResumeLayout(false);
			this.pnl_Login.PerformLayout();
			this.pnl_User.ResumeLayout(false);
			this.pnl_User.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_User)).EndInit();
			this.tct_Tab.ResumeLayout(false);
			this.tpg_Add.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Role)).EndInit();
			this.pnl_Role.ResumeLayout(false);
			this.pnl_Role.PerformLayout();
			this.tpg_Role.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_RolePermission)).EndInit();
			this.pnl_Tooltips_Tab2.ResumeLayout(false);
			this.pnl_Tooltips_Tab2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Panel pnl_Color;
		private System.Windows.Forms.DataGridView dgv_Login;
		private System.Windows.Forms.Panel pnl_Permission;
		private System.Windows.Forms.ComboBox cbx_Quyen;
		private System.Windows.Forms.Label lbl_Quyen;
		private System.Windows.Forms.TextBox tbx_TenNguoiDung;
		private System.Windows.Forms.Label lbl_TenNguoiDung;
		private System.Windows.Forms.Panel pnl_Tooltip_Tab1;
		private System.Windows.Forms.DataGridView dgv_RoleMember;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Insert;
		private System.Windows.Forms.Panel pnl_Login;
		private System.Windows.Forms.TextBox tbx_MatKhau;
		private System.Windows.Forms.Label lbl_MatKhau;
		private System.Windows.Forms.TextBox tbx_TenTaiKhoan;
		private System.Windows.Forms.Label lbl_TenTaiKhoan;
		private System.Windows.Forms.ComboBox cbx_TenBang;
		private System.Windows.Forms.Label lbl_TenBang;
		private System.Windows.Forms.CheckBox chk_Grant;
		private System.Windows.Forms.CheckBox chk_Cascade;
		private System.Windows.Forms.RadioButton rdo_User;
		private System.Windows.Forms.RadioButton rdo_Login;
		private System.Windows.Forms.Panel pnl_User;
		private System.Windows.Forms.Label lbl_TenNhomQuyen;
		private System.Windows.Forms.Label lbl_TenTaiKhoan_User;
		private System.Windows.Forms.ComboBox cbx_TenTaiKhoan;
		private System.Windows.Forms.DataGridView dgv_User;
		private System.Windows.Forms.ComboBox cbx_TenNguoiDung;
		private System.Windows.Forms.Label lbl_TenNguoiDung_Role;
		private System.Windows.Forms.TabControl tct_Tab;
		private System.Windows.Forms.TabPage tpg_Add;
		private System.Windows.Forms.TabPage tpg_Role;
		private System.Windows.Forms.Panel pnl_Tooltips_Tab2;
		private System.Windows.Forms.Button btn_Revoke;
		private System.Windows.Forms.Button btn_Grant;
		private System.Windows.Forms.DataGridView dgv_RolePermission;
		private System.Windows.Forms.Panel pnl_Role;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rdo_Role;
		private System.Windows.Forms.TextBox tbx_TenNhomQuyen;
		private System.Windows.Forms.DataGridView dgv_Role;
		private System.Windows.Forms.ComboBox cbx_TenNhomQuyen;
		private System.Windows.Forms.RadioButton rdo_Permission;
		private System.Windows.Forms.RadioButton rdo_Member;
		private System.Windows.Forms.Button btn_Deny;
	}
}