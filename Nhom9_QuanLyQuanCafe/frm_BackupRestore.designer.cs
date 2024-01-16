namespace Nhom9_QuanLyQuanCafe
{
	partial class frm_BackupRestore
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
			this.gbx_FB = new System.Windows.Forms.GroupBox();
			this.btn_FB_ShowCode = new System.Windows.Forms.Button();
			this.tbx_FB_Result = new System.Windows.Forms.TextBox();
			this.lbl_FB_Result = new System.Windows.Forms.Label();
			this.btn_FB_Restore = new System.Windows.Forms.Button();
			this.btn_FB_Backup = new System.Windows.Forms.Button();
			this.cbx_FB_Settings = new System.Windows.Forms.ComboBox();
			this.lbl_FB_Settings = new System.Windows.Forms.Label();
			this.btn_FB_OpenFile = new System.Windows.Forms.Button();
			this.tbx_FB_FilePath = new System.Windows.Forms.TextBox();
			this.lbl_FB_FilePath = new System.Windows.Forms.Label();
			this.ofd_OpenFile = new System.Windows.Forms.OpenFileDialog();
			this.gbx_DB = new System.Windows.Forms.GroupBox();
			this.btn_DB_ShowCode = new System.Windows.Forms.Button();
			this.tbx_DB_Result = new System.Windows.Forms.TextBox();
			this.lbl_DB_Result = new System.Windows.Forms.Label();
			this.btn_DB_Restore = new System.Windows.Forms.Button();
			this.btn_DB_Backup = new System.Windows.Forms.Button();
			this.cbx_DB_Settings = new System.Windows.Forms.ComboBox();
			this.lbl_DB_Settings = new System.Windows.Forms.Label();
			this.btn_DB_FilePath = new System.Windows.Forms.Button();
			this.tbx_DB_FilePath = new System.Windows.Forms.TextBox();
			this.lbl_DB_FilePath = new System.Windows.Forms.Label();
			this.gbx_TL = new System.Windows.Forms.GroupBox();
			this.btn_TL_ShowCode = new System.Windows.Forms.Button();
			this.tbx_TL_Result = new System.Windows.Forms.TextBox();
			this.lbl_TL_Result = new System.Windows.Forms.Label();
			this.btn_TL_Restore = new System.Windows.Forms.Button();
			this.btn_TL_Backup = new System.Windows.Forms.Button();
			this.cbx_TL_Settings = new System.Windows.Forms.ComboBox();
			this.lbl_TL_Settings = new System.Windows.Forms.Label();
			this.btn_TL_FilePath = new System.Windows.Forms.Button();
			this.tbx_TL_FilePath = new System.Windows.Forms.TextBox();
			this.lbl_TL_FilePath = new System.Windows.Forms.Label();
			this.gbx_FB.SuspendLayout();
			this.gbx_DB.SuspendLayout();
			this.gbx_TL.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_Title
			// 
			this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.lbl_Title.Location = new System.Drawing.Point(12, 17);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(389, 50);
			this.lbl_Title.TabIndex = 0;
			this.lbl_Title.Text = "Sao Lưu và Phục Hồi";
			this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnl_Color
			// 
			this.pnl_Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(143)))));
			this.pnl_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Color.Location = new System.Drawing.Point(407, 12);
			this.pnl_Color.Name = "pnl_Color";
			this.pnl_Color.Size = new System.Drawing.Size(381, 67);
			this.pnl_Color.TabIndex = 6;
			// 
			// gbx_FB
			// 
			this.gbx_FB.Controls.Add(this.btn_FB_ShowCode);
			this.gbx_FB.Controls.Add(this.tbx_FB_Result);
			this.gbx_FB.Controls.Add(this.lbl_FB_Result);
			this.gbx_FB.Controls.Add(this.btn_FB_Restore);
			this.gbx_FB.Controls.Add(this.btn_FB_Backup);
			this.gbx_FB.Controls.Add(this.cbx_FB_Settings);
			this.gbx_FB.Controls.Add(this.lbl_FB_Settings);
			this.gbx_FB.Controls.Add(this.btn_FB_OpenFile);
			this.gbx_FB.Controls.Add(this.tbx_FB_FilePath);
			this.gbx_FB.Controls.Add(this.lbl_FB_FilePath);
			this.gbx_FB.Location = new System.Drawing.Point(12, 106);
			this.gbx_FB.Name = "gbx_FB";
			this.gbx_FB.Size = new System.Drawing.Size(776, 194);
			this.gbx_FB.TabIndex = 8;
			this.gbx_FB.TabStop = false;
			this.gbx_FB.Text = "Full Backup";
			// 
			// btn_FB_ShowCode
			// 
			this.btn_FB_ShowCode.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Code;
			this.btn_FB_ShowCode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_FB_ShowCode.Location = new System.Drawing.Point(649, 97);
			this.btn_FB_ShowCode.Name = "btn_FB_ShowCode";
			this.btn_FB_ShowCode.Size = new System.Drawing.Size(99, 84);
			this.btn_FB_ShowCode.TabIndex = 9;
			this.btn_FB_ShowCode.Text = "Hiện Code";
			this.btn_FB_ShowCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_FB_ShowCode.UseVisualStyleBackColor = true;
			this.btn_FB_ShowCode.Click += new System.EventHandler(this.btn_FB_ShowCode_Click);
			// 
			// tbx_FB_Result
			// 
			this.tbx_FB_Result.Location = new System.Drawing.Point(74, 141);
			this.tbx_FB_Result.Name = "tbx_FB_Result";
			this.tbx_FB_Result.Size = new System.Drawing.Size(338, 26);
			this.tbx_FB_Result.TabIndex = 8;
			this.tbx_FB_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbl_FB_Result
			// 
			this.lbl_FB_Result.AutoSize = true;
			this.lbl_FB_Result.Location = new System.Drawing.Point(6, 144);
			this.lbl_FB_Result.Name = "lbl_FB_Result";
			this.lbl_FB_Result.Size = new System.Drawing.Size(62, 19);
			this.lbl_FB_Result.TabIndex = 7;
			this.lbl_FB_Result.Text = "Kết Quả";
			// 
			// btn_FB_Restore
			// 
			this.btn_FB_Restore.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Restore;
			this.btn_FB_Restore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_FB_Restore.Location = new System.Drawing.Point(544, 97);
			this.btn_FB_Restore.Name = "btn_FB_Restore";
			this.btn_FB_Restore.Size = new System.Drawing.Size(99, 84);
			this.btn_FB_Restore.TabIndex = 6;
			this.btn_FB_Restore.Text = "Phục Hồi";
			this.btn_FB_Restore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_FB_Restore.UseVisualStyleBackColor = true;
			this.btn_FB_Restore.Click += new System.EventHandler(this.btn_FB_Restore_Click);
			// 
			// btn_FB_Backup
			// 
			this.btn_FB_Backup.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Backup;
			this.btn_FB_Backup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_FB_Backup.Location = new System.Drawing.Point(439, 97);
			this.btn_FB_Backup.Name = "btn_FB_Backup";
			this.btn_FB_Backup.Size = new System.Drawing.Size(99, 84);
			this.btn_FB_Backup.TabIndex = 5;
			this.btn_FB_Backup.Text = "Sao Lưu";
			this.btn_FB_Backup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_FB_Backup.UseVisualStyleBackColor = true;
			this.btn_FB_Backup.Click += new System.EventHandler(this.btn_FB_Backup_Click);
			// 
			// cbx_FB_Settings
			// 
			this.cbx_FB_Settings.FormattingEnabled = true;
			this.cbx_FB_Settings.Location = new System.Drawing.Point(74, 97);
			this.cbx_FB_Settings.Name = "cbx_FB_Settings";
			this.cbx_FB_Settings.Size = new System.Drawing.Size(338, 27);
			this.cbx_FB_Settings.TabIndex = 4;
			// 
			// lbl_FB_Settings
			// 
			this.lbl_FB_Settings.AutoSize = true;
			this.lbl_FB_Settings.Location = new System.Drawing.Point(12, 100);
			this.lbl_FB_Settings.Name = "lbl_FB_Settings";
			this.lbl_FB_Settings.Size = new System.Drawing.Size(56, 19);
			this.lbl_FB_Settings.TabIndex = 3;
			this.lbl_FB_Settings.Text = "Cài Đặt";
			// 
			// btn_FB_OpenFile
			// 
			this.btn_FB_OpenFile.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_FB_OpenFile.Location = new System.Drawing.Point(740, 56);
			this.btn_FB_OpenFile.Name = "btn_FB_OpenFile";
			this.btn_FB_OpenFile.Size = new System.Drawing.Size(30, 26);
			this.btn_FB_OpenFile.TabIndex = 2;
			this.btn_FB_OpenFile.Text = "...";
			this.btn_FB_OpenFile.UseVisualStyleBackColor = true;
			this.btn_FB_OpenFile.Click += new System.EventHandler(this.btn_FB_OpenFile_Click);
			// 
			// tbx_FB_FilePath
			// 
			this.tbx_FB_FilePath.Location = new System.Drawing.Point(6, 56);
			this.tbx_FB_FilePath.Name = "tbx_FB_FilePath";
			this.tbx_FB_FilePath.Size = new System.Drawing.Size(728, 26);
			this.tbx_FB_FilePath.TabIndex = 1;
			// 
			// lbl_FB_FilePath
			// 
			this.lbl_FB_FilePath.AutoSize = true;
			this.lbl_FB_FilePath.Location = new System.Drawing.Point(6, 34);
			this.lbl_FB_FilePath.Name = "lbl_FB_FilePath";
			this.lbl_FB_FilePath.Size = new System.Drawing.Size(80, 19);
			this.lbl_FB_FilePath.TabIndex = 0;
			this.lbl_FB_FilePath.Text = "Đường Dẫn";
			// 
			// gbx_DB
			// 
			this.gbx_DB.Controls.Add(this.btn_DB_ShowCode);
			this.gbx_DB.Controls.Add(this.tbx_DB_Result);
			this.gbx_DB.Controls.Add(this.lbl_DB_Result);
			this.gbx_DB.Controls.Add(this.btn_DB_Restore);
			this.gbx_DB.Controls.Add(this.btn_DB_Backup);
			this.gbx_DB.Controls.Add(this.cbx_DB_Settings);
			this.gbx_DB.Controls.Add(this.lbl_DB_Settings);
			this.gbx_DB.Controls.Add(this.btn_DB_FilePath);
			this.gbx_DB.Controls.Add(this.tbx_DB_FilePath);
			this.gbx_DB.Controls.Add(this.lbl_DB_FilePath);
			this.gbx_DB.Location = new System.Drawing.Point(12, 315);
			this.gbx_DB.Name = "gbx_DB";
			this.gbx_DB.Size = new System.Drawing.Size(776, 194);
			this.gbx_DB.TabIndex = 9;
			this.gbx_DB.TabStop = false;
			this.gbx_DB.Text = "Differential Backup";
			// 
			// btn_DB_ShowCode
			// 
			this.btn_DB_ShowCode.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Code;
			this.btn_DB_ShowCode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_DB_ShowCode.Location = new System.Drawing.Point(649, 97);
			this.btn_DB_ShowCode.Name = "btn_DB_ShowCode";
			this.btn_DB_ShowCode.Size = new System.Drawing.Size(99, 84);
			this.btn_DB_ShowCode.TabIndex = 10;
			this.btn_DB_ShowCode.Text = "Hiện Code";
			this.btn_DB_ShowCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_DB_ShowCode.UseVisualStyleBackColor = true;
			this.btn_DB_ShowCode.Click += new System.EventHandler(this.btn_DB_ShowCode_Click);
			// 
			// tbx_DB_Result
			// 
			this.tbx_DB_Result.Location = new System.Drawing.Point(74, 141);
			this.tbx_DB_Result.Name = "tbx_DB_Result";
			this.tbx_DB_Result.Size = new System.Drawing.Size(338, 26);
			this.tbx_DB_Result.TabIndex = 8;
			this.tbx_DB_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbl_DB_Result
			// 
			this.lbl_DB_Result.AutoSize = true;
			this.lbl_DB_Result.Location = new System.Drawing.Point(6, 144);
			this.lbl_DB_Result.Name = "lbl_DB_Result";
			this.lbl_DB_Result.Size = new System.Drawing.Size(62, 19);
			this.lbl_DB_Result.TabIndex = 7;
			this.lbl_DB_Result.Text = "Kết Quả";
			// 
			// btn_DB_Restore
			// 
			this.btn_DB_Restore.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Restore;
			this.btn_DB_Restore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_DB_Restore.Location = new System.Drawing.Point(544, 97);
			this.btn_DB_Restore.Name = "btn_DB_Restore";
			this.btn_DB_Restore.Size = new System.Drawing.Size(99, 84);
			this.btn_DB_Restore.TabIndex = 6;
			this.btn_DB_Restore.Text = "Phục Hồi";
			this.btn_DB_Restore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_DB_Restore.UseVisualStyleBackColor = true;
			this.btn_DB_Restore.Click += new System.EventHandler(this.btn_DB_Restore_Click);
			// 
			// btn_DB_Backup
			// 
			this.btn_DB_Backup.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Backup;
			this.btn_DB_Backup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_DB_Backup.Location = new System.Drawing.Point(439, 97);
			this.btn_DB_Backup.Name = "btn_DB_Backup";
			this.btn_DB_Backup.Size = new System.Drawing.Size(99, 84);
			this.btn_DB_Backup.TabIndex = 5;
			this.btn_DB_Backup.Text = "Sao Lưu";
			this.btn_DB_Backup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_DB_Backup.UseVisualStyleBackColor = true;
			this.btn_DB_Backup.Click += new System.EventHandler(this.btn_DB_Backup_Click);
			// 
			// cbx_DB_Settings
			// 
			this.cbx_DB_Settings.FormattingEnabled = true;
			this.cbx_DB_Settings.Location = new System.Drawing.Point(74, 97);
			this.cbx_DB_Settings.Name = "cbx_DB_Settings";
			this.cbx_DB_Settings.Size = new System.Drawing.Size(338, 27);
			this.cbx_DB_Settings.TabIndex = 4;
			// 
			// lbl_DB_Settings
			// 
			this.lbl_DB_Settings.AutoSize = true;
			this.lbl_DB_Settings.Location = new System.Drawing.Point(12, 100);
			this.lbl_DB_Settings.Name = "lbl_DB_Settings";
			this.lbl_DB_Settings.Size = new System.Drawing.Size(56, 19);
			this.lbl_DB_Settings.TabIndex = 3;
			this.lbl_DB_Settings.Text = "Cài Đặt";
			// 
			// btn_DB_FilePath
			// 
			this.btn_DB_FilePath.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DB_FilePath.Location = new System.Drawing.Point(740, 56);
			this.btn_DB_FilePath.Name = "btn_DB_FilePath";
			this.btn_DB_FilePath.Size = new System.Drawing.Size(30, 26);
			this.btn_DB_FilePath.TabIndex = 2;
			this.btn_DB_FilePath.Text = "...";
			this.btn_DB_FilePath.UseVisualStyleBackColor = true;
			this.btn_DB_FilePath.Click += new System.EventHandler(this.btn_DB_FilePath_Click);
			// 
			// tbx_DB_FilePath
			// 
			this.tbx_DB_FilePath.Location = new System.Drawing.Point(6, 56);
			this.tbx_DB_FilePath.Name = "tbx_DB_FilePath";
			this.tbx_DB_FilePath.Size = new System.Drawing.Size(728, 26);
			this.tbx_DB_FilePath.TabIndex = 1;
			// 
			// lbl_DB_FilePath
			// 
			this.lbl_DB_FilePath.AutoSize = true;
			this.lbl_DB_FilePath.Location = new System.Drawing.Point(6, 34);
			this.lbl_DB_FilePath.Name = "lbl_DB_FilePath";
			this.lbl_DB_FilePath.Size = new System.Drawing.Size(80, 19);
			this.lbl_DB_FilePath.TabIndex = 0;
			this.lbl_DB_FilePath.Text = "Đường Dẫn";
			// 
			// gbx_TL
			// 
			this.gbx_TL.Controls.Add(this.btn_TL_ShowCode);
			this.gbx_TL.Controls.Add(this.tbx_TL_Result);
			this.gbx_TL.Controls.Add(this.lbl_TL_Result);
			this.gbx_TL.Controls.Add(this.btn_TL_Restore);
			this.gbx_TL.Controls.Add(this.btn_TL_Backup);
			this.gbx_TL.Controls.Add(this.cbx_TL_Settings);
			this.gbx_TL.Controls.Add(this.lbl_TL_Settings);
			this.gbx_TL.Controls.Add(this.btn_TL_FilePath);
			this.gbx_TL.Controls.Add(this.tbx_TL_FilePath);
			this.gbx_TL.Controls.Add(this.lbl_TL_FilePath);
			this.gbx_TL.Location = new System.Drawing.Point(12, 525);
			this.gbx_TL.Name = "gbx_TL";
			this.gbx_TL.Size = new System.Drawing.Size(776, 194);
			this.gbx_TL.TabIndex = 10;
			this.gbx_TL.TabStop = false;
			this.gbx_TL.Text = "Transaction Log";
			// 
			// btn_TL_ShowCode
			// 
			this.btn_TL_ShowCode.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Code;
			this.btn_TL_ShowCode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_TL_ShowCode.Location = new System.Drawing.Point(649, 97);
			this.btn_TL_ShowCode.Name = "btn_TL_ShowCode";
			this.btn_TL_ShowCode.Size = new System.Drawing.Size(99, 84);
			this.btn_TL_ShowCode.TabIndex = 11;
			this.btn_TL_ShowCode.Text = "Hiện Code";
			this.btn_TL_ShowCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_TL_ShowCode.UseVisualStyleBackColor = true;
			this.btn_TL_ShowCode.Click += new System.EventHandler(this.btn_TL_ShowCode_Click);
			// 
			// tbx_TL_Result
			// 
			this.tbx_TL_Result.Location = new System.Drawing.Point(74, 141);
			this.tbx_TL_Result.Name = "tbx_TL_Result";
			this.tbx_TL_Result.Size = new System.Drawing.Size(338, 26);
			this.tbx_TL_Result.TabIndex = 8;
			this.tbx_TL_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbl_TL_Result
			// 
			this.lbl_TL_Result.AutoSize = true;
			this.lbl_TL_Result.Location = new System.Drawing.Point(6, 144);
			this.lbl_TL_Result.Name = "lbl_TL_Result";
			this.lbl_TL_Result.Size = new System.Drawing.Size(62, 19);
			this.lbl_TL_Result.TabIndex = 7;
			this.lbl_TL_Result.Text = "Kết Quả";
			// 
			// btn_TL_Restore
			// 
			this.btn_TL_Restore.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Restore;
			this.btn_TL_Restore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_TL_Restore.Location = new System.Drawing.Point(544, 97);
			this.btn_TL_Restore.Name = "btn_TL_Restore";
			this.btn_TL_Restore.Size = new System.Drawing.Size(99, 84);
			this.btn_TL_Restore.TabIndex = 6;
			this.btn_TL_Restore.Text = "Phục Hồi";
			this.btn_TL_Restore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_TL_Restore.UseVisualStyleBackColor = true;
			this.btn_TL_Restore.Click += new System.EventHandler(this.btn_TL_Restore_Click);
			// 
			// btn_TL_Backup
			// 
			this.btn_TL_Backup.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Backup;
			this.btn_TL_Backup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_TL_Backup.Location = new System.Drawing.Point(439, 97);
			this.btn_TL_Backup.Name = "btn_TL_Backup";
			this.btn_TL_Backup.Size = new System.Drawing.Size(99, 84);
			this.btn_TL_Backup.TabIndex = 5;
			this.btn_TL_Backup.Text = "Sao Lưu";
			this.btn_TL_Backup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_TL_Backup.UseVisualStyleBackColor = true;
			this.btn_TL_Backup.Click += new System.EventHandler(this.btn_TL_Backup_Click);
			// 
			// cbx_TL_Settings
			// 
			this.cbx_TL_Settings.FormattingEnabled = true;
			this.cbx_TL_Settings.Location = new System.Drawing.Point(74, 97);
			this.cbx_TL_Settings.Name = "cbx_TL_Settings";
			this.cbx_TL_Settings.Size = new System.Drawing.Size(338, 27);
			this.cbx_TL_Settings.TabIndex = 4;
			// 
			// lbl_TL_Settings
			// 
			this.lbl_TL_Settings.AutoSize = true;
			this.lbl_TL_Settings.Location = new System.Drawing.Point(12, 100);
			this.lbl_TL_Settings.Name = "lbl_TL_Settings";
			this.lbl_TL_Settings.Size = new System.Drawing.Size(56, 19);
			this.lbl_TL_Settings.TabIndex = 3;
			this.lbl_TL_Settings.Text = "Cài Đặt";
			// 
			// btn_TL_FilePath
			// 
			this.btn_TL_FilePath.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TL_FilePath.Location = new System.Drawing.Point(740, 56);
			this.btn_TL_FilePath.Name = "btn_TL_FilePath";
			this.btn_TL_FilePath.Size = new System.Drawing.Size(30, 26);
			this.btn_TL_FilePath.TabIndex = 2;
			this.btn_TL_FilePath.Text = "...";
			this.btn_TL_FilePath.UseVisualStyleBackColor = true;
			this.btn_TL_FilePath.Click += new System.EventHandler(this.btn_TL_FilePath_Click);
			// 
			// tbx_TL_FilePath
			// 
			this.tbx_TL_FilePath.Location = new System.Drawing.Point(6, 56);
			this.tbx_TL_FilePath.Name = "tbx_TL_FilePath";
			this.tbx_TL_FilePath.Size = new System.Drawing.Size(728, 26);
			this.tbx_TL_FilePath.TabIndex = 1;
			// 
			// lbl_TL_FilePath
			// 
			this.lbl_TL_FilePath.AutoSize = true;
			this.lbl_TL_FilePath.Location = new System.Drawing.Point(6, 34);
			this.lbl_TL_FilePath.Name = "lbl_TL_FilePath";
			this.lbl_TL_FilePath.Size = new System.Drawing.Size(80, 19);
			this.lbl_TL_FilePath.TabIndex = 0;
			this.lbl_TL_FilePath.Text = "Đường Dẫn";
			// 
			// frm_BackupRestore
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 750);
			this.Controls.Add(this.gbx_TL);
			this.Controls.Add(this.gbx_DB);
			this.Controls.Add(this.gbx_FB);
			this.Controls.Add(this.pnl_Color);
			this.Controls.Add(this.lbl_Title);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_BackupRestore";
			this.Text = "frm_Backup";
			this.Load += new System.EventHandler(this.frm_BackupRestore_Load);
			this.gbx_FB.ResumeLayout(false);
			this.gbx_FB.PerformLayout();
			this.gbx_DB.ResumeLayout(false);
			this.gbx_DB.PerformLayout();
			this.gbx_TL.ResumeLayout(false);
			this.gbx_TL.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Panel pnl_Color;
		private System.Windows.Forms.GroupBox gbx_FB;
		private System.Windows.Forms.TextBox tbx_FB_FilePath;
		private System.Windows.Forms.Label lbl_FB_FilePath;
		private System.Windows.Forms.OpenFileDialog ofd_OpenFile;
		private System.Windows.Forms.Button btn_FB_OpenFile;
		private System.Windows.Forms.ComboBox cbx_FB_Settings;
		private System.Windows.Forms.Label lbl_FB_Settings;
		private System.Windows.Forms.Button btn_FB_Restore;
		private System.Windows.Forms.Button btn_FB_Backup;
		private System.Windows.Forms.Label lbl_FB_Result;
		private System.Windows.Forms.TextBox tbx_FB_Result;
		private System.Windows.Forms.GroupBox gbx_DB;
		private System.Windows.Forms.TextBox tbx_DB_Result;
		private System.Windows.Forms.Label lbl_DB_Result;
		private System.Windows.Forms.Button btn_DB_Restore;
		private System.Windows.Forms.Button btn_DB_Backup;
		private System.Windows.Forms.ComboBox cbx_DB_Settings;
		private System.Windows.Forms.Label lbl_DB_Settings;
		private System.Windows.Forms.Button btn_DB_FilePath;
		private System.Windows.Forms.TextBox tbx_DB_FilePath;
		private System.Windows.Forms.Label lbl_DB_FilePath;
		private System.Windows.Forms.GroupBox gbx_TL;
		private System.Windows.Forms.TextBox tbx_TL_Result;
		private System.Windows.Forms.Label lbl_TL_Result;
		private System.Windows.Forms.Button btn_TL_Restore;
		private System.Windows.Forms.Button btn_TL_Backup;
		private System.Windows.Forms.ComboBox cbx_TL_Settings;
		private System.Windows.Forms.Label lbl_TL_Settings;
		private System.Windows.Forms.Button btn_TL_FilePath;
		private System.Windows.Forms.TextBox tbx_TL_FilePath;
		private System.Windows.Forms.Label lbl_TL_FilePath;
		private System.Windows.Forms.Button btn_FB_ShowCode;
		private System.Windows.Forms.Button btn_DB_ShowCode;
		private System.Windows.Forms.Button btn_TL_ShowCode;
	}
}