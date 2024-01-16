namespace Nhom9_QuanLyQuanCafe
{
	partial class frm_Customer
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
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.cbx_GioiTinh = new System.Windows.Forms.ComboBox();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.tbx_TenKhachHang = new System.Windows.Forms.TextBox();
            this.lbl_TenKhachHang = new System.Windows.Forms.Label();
            this.tbx_MaKhachHang = new System.Windows.Forms.TextBox();
            this.lbl_MaKhachHang = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Tooltip = new System.Windows.Forms.Panel();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.pnl_Data.SuspendLayout();
            this.pnl_Tooltip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Data
            // 
            this.dgv_Data.AllowUserToAddRows = false;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_Data.Location = new System.Drawing.Point(12, 332);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.Size = new System.Drawing.Size(776, 394);
            this.dgv_Data.TabIndex = 2;
            this.dgv_Data.SelectionChanged += new System.EventHandler(this.dgv_Data_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Giới tính";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // pnl_Data
            // 
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.cbx_GioiTinh);
            this.pnl_Data.Controls.Add(this.lbl_GioiTinh);
            this.pnl_Data.Controls.Add(this.tbx_TenKhachHang);
            this.pnl_Data.Controls.Add(this.lbl_TenKhachHang);
            this.pnl_Data.Controls.Add(this.tbx_MaKhachHang);
            this.pnl_Data.Controls.Add(this.lbl_MaKhachHang);
            this.pnl_Data.Location = new System.Drawing.Point(12, 167);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(776, 148);
            this.pnl_Data.TabIndex = 3;
            // 
            // cbx_GioiTinh
            // 
            this.cbx_GioiTinh.FormattingEnabled = true;
            this.cbx_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbx_GioiTinh.Location = new System.Drawing.Point(141, 89);
            this.cbx_GioiTinh.Name = "cbx_GioiTinh";
            this.cbx_GioiTinh.Size = new System.Drawing.Size(241, 27);
            this.cbx_GioiTinh.TabIndex = 12;
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(76, 92);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(59, 19);
            this.lbl_GioiTinh.TabIndex = 7;
            this.lbl_GioiTinh.Text = "Giới tính";
            // 
            // tbx_TenKhachHang
            // 
            this.tbx_TenKhachHang.Location = new System.Drawing.Point(141, 57);
            this.tbx_TenKhachHang.Name = "tbx_TenKhachHang";
            this.tbx_TenKhachHang.Size = new System.Drawing.Size(591, 26);
            this.tbx_TenKhachHang.TabIndex = 10;
            // 
            // lbl_TenKhachHang
            // 
            this.lbl_TenKhachHang.AutoSize = true;
            this.lbl_TenKhachHang.Location = new System.Drawing.Point(23, 60);
            this.lbl_TenKhachHang.Name = "lbl_TenKhachHang";
            this.lbl_TenKhachHang.Size = new System.Drawing.Size(112, 19);
            this.lbl_TenKhachHang.TabIndex = 9;
            this.lbl_TenKhachHang.Text = "Tên Khách Hàng";
            // 
            // tbx_MaKhachHang
            // 
            this.tbx_MaKhachHang.Location = new System.Drawing.Point(141, 25);
            this.tbx_MaKhachHang.Name = "tbx_MaKhachHang";
            this.tbx_MaKhachHang.Size = new System.Drawing.Size(591, 26);
            this.tbx_MaKhachHang.TabIndex = 6;
            // 
            // lbl_MaKhachHang
            // 
            this.lbl_MaKhachHang.AutoSize = true;
            this.lbl_MaKhachHang.Location = new System.Drawing.Point(25, 28);
            this.lbl_MaKhachHang.Name = "lbl_MaKhachHang";
            this.lbl_MaKhachHang.Size = new System.Drawing.Size(110, 19);
            this.lbl_MaKhachHang.TabIndex = 5;
            this.lbl_MaKhachHang.Text = "Mã Khách Hàng";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 98);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(776, 50);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "Quản Lý Khách Hàng";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Tooltip
            // 
            this.pnl_Tooltip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Tooltip.Controls.Add(this.btn_Filter);
            this.pnl_Tooltip.Controls.Add(this.btn_Search);
            this.pnl_Tooltip.Controls.Add(this.btn_Delete);
            this.pnl_Tooltip.Controls.Add(this.btn_Update);
            this.pnl_Tooltip.Controls.Add(this.btn_Insert);
            this.pnl_Tooltip.Location = new System.Drawing.Point(12, 12);
            this.pnl_Tooltip.Name = "pnl_Tooltip";
            this.pnl_Tooltip.Size = new System.Drawing.Size(493, 67);
            this.pnl_Tooltip.TabIndex = 5;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Filter;
            this.btn_Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Filter.Location = new System.Drawing.Point(403, 14);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(77, 38);
            this.btn_Filter.TabIndex = 4;
            this.btn_Filter.Text = "Lọc";
            this.btn_Filter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Filter.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Search;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(291, 14);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(106, 38);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Search_KeyDown);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Delete;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(212, 14);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(73, 38);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Update;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(101, 14);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(105, 38);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Cập Nhật";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Insert;
            this.btn_Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Insert.Location = new System.Drawing.Point(12, 14);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(83, 38);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(143)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(511, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 67);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pnl_Tooltip);
            this.Controls.Add(this.pnl_Data);
            this.Controls.Add(this.dgv_Data);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Type";
            this.Load += new System.EventHandler(this.frm_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            this.pnl_Tooltip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dgv_Data;
		private System.Windows.Forms.Panel pnl_Data;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Panel pnl_Tooltip;
		private System.Windows.Forms.Button btn_Filter;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.ComboBox cbx_GioiTinh;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.TextBox tbx_TenKhachHang;
        private System.Windows.Forms.Label lbl_TenKhachHang;
        private System.Windows.Forms.TextBox tbx_MaKhachHang;
        private System.Windows.Forms.Label lbl_MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}