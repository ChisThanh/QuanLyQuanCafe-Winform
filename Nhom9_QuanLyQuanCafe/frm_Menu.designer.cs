namespace Nhom9_QuanLyQuanCafe
{
	partial class frm_Menu
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
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.cbx_LoaiThucDon = new System.Windows.Forms.ComboBox();
            this.lbl_LoaiThucDon = new System.Windows.Forms.Label();
            this.cbx_DonViTinh = new System.Windows.Forms.ComboBox();
            this.lbl_DonViTinh = new System.Windows.Forms.Label();
            this.tbx_GiaBan = new System.Windows.Forms.TextBox();
            this.lbl_GiaBan = new System.Windows.Forms.Label();
            this.tbx_TenLoai = new System.Windows.Forms.TextBox();
            this.lbl_TenThucDon = new System.Windows.Forms.Label();
            this.tbx_MaLoai = new System.Windows.Forms.TextBox();
            this.lbl_MaThucDon = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Tooltip = new System.Windows.Forms.Panel();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Tooltip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Data
            // 
            this.dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(12, 316);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowHeadersWidth = 51;
            this.dgv_Data.Size = new System.Drawing.Size(776, 394);
            this.dgv_Data.TabIndex = 2;
            this.dgv_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Data_CellClick);
            // 
            // pnl_Data
            // 
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.cbx_LoaiThucDon);
            this.pnl_Data.Controls.Add(this.lbl_LoaiThucDon);
            this.pnl_Data.Controls.Add(this.cbx_DonViTinh);
            this.pnl_Data.Controls.Add(this.lbl_DonViTinh);
            this.pnl_Data.Controls.Add(this.tbx_GiaBan);
            this.pnl_Data.Controls.Add(this.lbl_GiaBan);
            this.pnl_Data.Controls.Add(this.tbx_TenLoai);
            this.pnl_Data.Controls.Add(this.lbl_TenThucDon);
            this.pnl_Data.Controls.Add(this.tbx_MaLoai);
            this.pnl_Data.Controls.Add(this.lbl_MaThucDon);
            this.pnl_Data.Location = new System.Drawing.Point(12, 151);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(776, 159);
            this.pnl_Data.TabIndex = 3;
            // 
            // cbx_LoaiThucDon
            // 
            this.cbx_LoaiThucDon.FormattingEnabled = true;
            this.cbx_LoaiThucDon.Location = new System.Drawing.Point(505, 65);
            this.cbx_LoaiThucDon.Name = "cbx_LoaiThucDon";
            this.cbx_LoaiThucDon.Size = new System.Drawing.Size(250, 30);
            this.cbx_LoaiThucDon.TabIndex = 9;
            // 
            // lbl_LoaiThucDon
            // 
            this.lbl_LoaiThucDon.AutoSize = true;
            this.lbl_LoaiThucDon.Location = new System.Drawing.Point(397, 68);
            this.lbl_LoaiThucDon.Name = "lbl_LoaiThucDon";
            this.lbl_LoaiThucDon.Size = new System.Drawing.Size(131, 22);
            this.lbl_LoaiThucDon.TabIndex = 8;
            this.lbl_LoaiThucDon.Text = "Loại Thực Đơn";
            // 
            // cbx_DonViTinh
            // 
            this.cbx_DonViTinh.FormattingEnabled = true;
            this.cbx_DonViTinh.Location = new System.Drawing.Point(505, 33);
            this.cbx_DonViTinh.Name = "cbx_DonViTinh";
            this.cbx_DonViTinh.Size = new System.Drawing.Size(250, 30);
            this.cbx_DonViTinh.TabIndex = 7;
            // 
            // lbl_DonViTinh
            // 
            this.lbl_DonViTinh.AutoSize = true;
            this.lbl_DonViTinh.Location = new System.Drawing.Point(416, 36);
            this.lbl_DonViTinh.Name = "lbl_DonViTinh";
            this.lbl_DonViTinh.Size = new System.Drawing.Size(109, 22);
            this.lbl_DonViTinh.TabIndex = 6;
            this.lbl_DonViTinh.Text = "Đơn Vị Tính";
            // 
            // tbx_GiaBan
            // 
            this.tbx_GiaBan.Location = new System.Drawing.Point(116, 97);
            this.tbx_GiaBan.Name = "tbx_GiaBan";
            this.tbx_GiaBan.Size = new System.Drawing.Size(266, 30);
            this.tbx_GiaBan.TabIndex = 5;
            // 
            // lbl_GiaBan
            // 
            this.lbl_GiaBan.AutoSize = true;
            this.lbl_GiaBan.Location = new System.Drawing.Point(52, 100);
            this.lbl_GiaBan.Name = "lbl_GiaBan";
            this.lbl_GiaBan.Size = new System.Drawing.Size(75, 22);
            this.lbl_GiaBan.TabIndex = 4;
            this.lbl_GiaBan.Text = "Giá Bán";
            // 
            // tbx_TenLoai
            // 
            this.tbx_TenLoai.Location = new System.Drawing.Point(116, 65);
            this.tbx_TenLoai.Name = "tbx_TenLoai";
            this.tbx_TenLoai.Size = new System.Drawing.Size(266, 30);
            this.tbx_TenLoai.TabIndex = 3;
            // 
            // lbl_TenThucDon
            // 
            this.lbl_TenThucDon.AutoSize = true;
            this.lbl_TenThucDon.Location = new System.Drawing.Point(14, 68);
            this.lbl_TenThucDon.Name = "lbl_TenThucDon";
            this.lbl_TenThucDon.Size = new System.Drawing.Size(125, 22);
            this.lbl_TenThucDon.TabIndex = 2;
            this.lbl_TenThucDon.Text = "Tên Thực Đơn";
            // 
            // tbx_MaLoai
            // 
            this.tbx_MaLoai.Enabled = false;
            this.tbx_MaLoai.Location = new System.Drawing.Point(116, 33);
            this.tbx_MaLoai.Name = "tbx_MaLoai";
            this.tbx_MaLoai.Size = new System.Drawing.Size(266, 30);
            this.tbx_MaLoai.TabIndex = 1;
            // 
            // lbl_MaThucDon
            // 
            this.lbl_MaThucDon.AutoSize = true;
            this.lbl_MaThucDon.Location = new System.Drawing.Point(16, 36);
            this.lbl_MaThucDon.Name = "lbl_MaThucDon";
            this.lbl_MaThucDon.Size = new System.Drawing.Size(121, 22);
            this.lbl_MaThucDon.TabIndex = 0;
            this.lbl_MaThucDon.Text = "Mã Thực Đơn";
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
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 98);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(776, 50);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "Quản Lý Thực Đơn";
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
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
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
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
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
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Type";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Tooltip.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dgv_Data;
		private System.Windows.Forms.Panel pnl_Data;
		private System.Windows.Forms.TextBox tbx_TenLoai;
		private System.Windows.Forms.Label lbl_TenThucDon;
		private System.Windows.Forms.TextBox tbx_MaLoai;
		private System.Windows.Forms.Label lbl_MaThucDon;
		private System.Windows.Forms.TextBox tbx_GiaBan;
		private System.Windows.Forms.Label lbl_GiaBan;
		private System.Windows.Forms.ComboBox cbx_LoaiThucDon;
		private System.Windows.Forms.Label lbl_LoaiThucDon;
		private System.Windows.Forms.ComboBox cbx_DonViTinh;
		private System.Windows.Forms.Label lbl_DonViTinh;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Panel pnl_Tooltip;
		private System.Windows.Forms.Button btn_Filter;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.Button btn_Insert;
	}
}