namespace Nhom9_QuanLyQuanCafe
{
    partial class frm_Employee
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
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.dtp_Ngay = new System.Windows.Forms.DateTimePicker();
            this.cb_gt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Ten = new System.Windows.Forms.TextBox();
            this.lbl_TenLoai = new System.Windows.Forms.Label();
            this.tbx_Ma = new System.Windows.Forms.TextBox();
            this.lbl_MaLoai = new System.Windows.Forms.Label();
            this.pnl_Tooltip = new System.Windows.Forms.Panel();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.pnl_Data.SuspendLayout();
            this.pnl_Tooltip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(101, 101);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(603, 50);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Quản Lý Loại Nhân Viên";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Data
            // 
            this.dgv_Data.AllowUserToAddRows = false;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_Data.Location = new System.Drawing.Point(12, 332);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.Size = new System.Drawing.Size(776, 394);
            this.dgv_Data.TabIndex = 2;
            this.dgv_Data.SelectionChanged += new System.EventHandler(this.dgv_Data_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên Nhân Viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // pnl_Data
            // 
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.dtp_Ngay);
            this.pnl_Data.Controls.Add(this.cb_gt);
            this.pnl_Data.Controls.Add(this.label2);
            this.pnl_Data.Controls.Add(this.label1);
            this.pnl_Data.Controls.Add(this.tbx_Ten);
            this.pnl_Data.Controls.Add(this.lbl_TenLoai);
            this.pnl_Data.Controls.Add(this.tbx_Ma);
            this.pnl_Data.Controls.Add(this.lbl_MaLoai);
            this.pnl_Data.Location = new System.Drawing.Point(12, 167);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(776, 159);
            this.pnl_Data.TabIndex = 3;
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Ngay.Location = new System.Drawing.Point(520, 27);
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.Size = new System.Drawing.Size(241, 26);
            this.dtp_Ngay.TabIndex = 4;
            // 
            // cb_gt
            // 
            this.cb_gt.FormattingEnabled = true;
            this.cb_gt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gt.Location = new System.Drawing.Point(520, 69);
            this.cb_gt.Name = "cb_gt";
            this.cb_gt.Size = new System.Drawing.Size(241, 27);
            this.cb_gt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày sinh";
            // 
            // tbx_Ten
            // 
            this.tbx_Ten.Location = new System.Drawing.Point(94, 69);
            this.tbx_Ten.Name = "tbx_Ten";
            this.tbx_Ten.Size = new System.Drawing.Size(241, 26);
            this.tbx_Ten.TabIndex = 3;
            // 
            // lbl_TenLoai
            // 
            this.lbl_TenLoai.AutoSize = true;
            this.lbl_TenLoai.Location = new System.Drawing.Point(28, 73);
            this.lbl_TenLoai.Name = "lbl_TenLoai";
            this.lbl_TenLoai.Size = new System.Drawing.Size(32, 19);
            this.lbl_TenLoai.TabIndex = 2;
            this.lbl_TenLoai.Text = "Tên";
            // 
            // tbx_Ma
            // 
            this.tbx_Ma.Location = new System.Drawing.Point(94, 27);
            this.tbx_Ma.Name = "tbx_Ma";
            this.tbx_Ma.Size = new System.Drawing.Size(241, 26);
            this.tbx_Ma.TabIndex = 1;
            // 
            // lbl_MaLoai
            // 
            this.lbl_MaLoai.AutoSize = true;
            this.lbl_MaLoai.Location = new System.Drawing.Point(28, 31);
            this.lbl_MaLoai.Name = "lbl_MaLoai";
            this.lbl_MaLoai.Size = new System.Drawing.Size(30, 19);
            this.lbl_MaLoai.TabIndex = 0;
            this.lbl_MaLoai.Text = "Mã";
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
            this.pnl_Tooltip.Size = new System.Drawing.Size(508, 67);
            this.pnl_Tooltip.TabIndex = 4;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Filter;
            this.btn_Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Filter.Location = new System.Drawing.Point(403, 14);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(82, 38);
            this.btn_Filter.TabIndex = 4;
            this.btn_Filter.Text = "Tất cả";
            this.btn_Filter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
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
            this.btn_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Search_MouseDown);
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
            // frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 750);
            this.Controls.Add(this.pnl_Tooltip);
            this.Controls.Add(this.pnl_Data);
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.lbl_Title);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Type";
            this.Load += new System.EventHandler(this.frm_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            this.pnl_Tooltip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.Panel pnl_Data;
        private System.Windows.Forms.TextBox tbx_Ten;
        private System.Windows.Forms.Label lbl_TenLoai;
        private System.Windows.Forms.TextBox tbx_Ma;
        private System.Windows.Forms.Label lbl_MaLoai;
        private System.Windows.Forms.DateTimePicker dtp_Ngay;
        private System.Windows.Forms.ComboBox cb_gt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Tooltip;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}