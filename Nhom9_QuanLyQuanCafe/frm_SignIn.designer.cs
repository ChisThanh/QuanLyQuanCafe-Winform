namespace Nhom9_QuanLyQuanCafe
{
	partial class frm_SignIn
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
			this.pnl_SignIn = new System.Windows.Forms.Panel();
			this.lbl_PasswordAnnotation = new System.Windows.Forms.Label();
			this.lbl_LoginAnnotation = new System.Windows.Forms.Label();
			this.btn_AccessDatabase = new System.Windows.Forms.Button();
			this.btn_ChangePassword = new System.Windows.Forms.Button();
			this.btn_SignInWithoutAccount = new System.Windows.Forms.Button();
			this.btn_SignIn = new System.Windows.Forms.Button();
			this.tbx_Password = new System.Windows.Forms.TextBox();
			this.lbl_Password = new System.Windows.Forms.Label();
			this.lbl_Subtitle = new System.Windows.Forms.Label();
			this.tbx_Login = new System.Windows.Forms.TextBox();
			this.lbl_Login = new System.Windows.Forms.Label();
			this.lbl_SignIn = new System.Windows.Forms.Label();
			this.lbl_Title = new System.Windows.Forms.Label();
			this.pnl_DatabaseAccess = new System.Windows.Forms.Panel();
			this.btn_ShowCode = new System.Windows.Forms.Button();
			this.dgv_Login = new System.Windows.Forms.DataGridView();
			this.lbl_Permission = new System.Windows.Forms.Label();
			this.tbx_ConnectionStatus = new System.Windows.Forms.TextBox();
			this.lbl_ConnectionStatus = new System.Windows.Forms.Label();
			this.lbl_DatabaseAnnotation = new System.Windows.Forms.Label();
			this.lbl_ServerAnnotation = new System.Windows.Forms.Label();
			this.btn_CheckConnection = new System.Windows.Forms.Button();
			this.tbx_Database = new System.Windows.Forms.TextBox();
			this.lbl_Database = new System.Windows.Forms.Label();
			this.tbx_Server = new System.Windows.Forms.TextBox();
			this.lbl_Server = new System.Windows.Forms.Label();
			this.lbl_DatabaseAccess = new System.Windows.Forms.Label();
			this.ptb_Image = new System.Windows.Forms.PictureBox();
			this.ptb_TopColor = new System.Windows.Forms.PictureBox();
			this.ptb_BottomColor = new System.Windows.Forms.PictureBox();
			this.btn_HidePassword = new System.Windows.Forms.Button();
			this.btn_ShowPassword = new System.Windows.Forms.Button();
			this.pnl_SignIn.SuspendLayout();
			this.pnl_DatabaseAccess.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Login)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptb_Image)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptb_TopColor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptb_BottomColor)).BeginInit();
			this.SuspendLayout();
			// 
			// pnl_SignIn
			// 
			this.pnl_SignIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_SignIn.Controls.Add(this.ptb_BottomColor);
			this.pnl_SignIn.Controls.Add(this.lbl_PasswordAnnotation);
			this.pnl_SignIn.Controls.Add(this.lbl_LoginAnnotation);
			this.pnl_SignIn.Controls.Add(this.btn_AccessDatabase);
			this.pnl_SignIn.Controls.Add(this.btn_ChangePassword);
			this.pnl_SignIn.Controls.Add(this.btn_SignInWithoutAccount);
			this.pnl_SignIn.Controls.Add(this.btn_SignIn);
			this.pnl_SignIn.Controls.Add(this.btn_HidePassword);
			this.pnl_SignIn.Controls.Add(this.btn_ShowPassword);
			this.pnl_SignIn.Controls.Add(this.tbx_Password);
			this.pnl_SignIn.Controls.Add(this.lbl_Password);
			this.pnl_SignIn.Controls.Add(this.lbl_Subtitle);
			this.pnl_SignIn.Controls.Add(this.tbx_Login);
			this.pnl_SignIn.Controls.Add(this.lbl_Login);
			this.pnl_SignIn.Controls.Add(this.lbl_SignIn);
			this.pnl_SignIn.Controls.Add(this.lbl_Title);
			this.pnl_SignIn.Location = new System.Drawing.Point(12, 12);
			this.pnl_SignIn.Name = "pnl_SignIn";
			this.pnl_SignIn.Size = new System.Drawing.Size(450, 587);
			this.pnl_SignIn.TabIndex = 0;
			// 
			// lbl_PasswordAnnotation
			// 
			this.lbl_PasswordAnnotation.ForeColor = System.Drawing.Color.Red;
			this.lbl_PasswordAnnotation.Location = new System.Drawing.Point(24, 336);
			this.lbl_PasswordAnnotation.Name = "lbl_PasswordAnnotation";
			this.lbl_PasswordAnnotation.Size = new System.Drawing.Size(404, 21);
			this.lbl_PasswordAnnotation.TabIndex = 14;
			this.lbl_PasswordAnnotation.Text = "Báo Lỗi";
			this.lbl_PasswordAnnotation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_LoginAnnotation
			// 
			this.lbl_LoginAnnotation.ForeColor = System.Drawing.Color.Red;
			this.lbl_LoginAnnotation.Location = new System.Drawing.Point(24, 259);
			this.lbl_LoginAnnotation.Name = "lbl_LoginAnnotation";
			this.lbl_LoginAnnotation.Size = new System.Drawing.Size(404, 21);
			this.lbl_LoginAnnotation.TabIndex = 12;
			this.lbl_LoginAnnotation.Text = "Báo Lỗi";
			this.lbl_LoginAnnotation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_AccessDatabase
			// 
			this.btn_AccessDatabase.Location = new System.Drawing.Point(24, 484);
			this.btn_AccessDatabase.Name = "btn_AccessDatabase";
			this.btn_AccessDatabase.Size = new System.Drawing.Size(404, 44);
			this.btn_AccessDatabase.TabIndex = 7;
			this.btn_AccessDatabase.Text = "Kết Nối Database";
			this.btn_AccessDatabase.UseVisualStyleBackColor = true;
			this.btn_AccessDatabase.Click += new System.EventHandler(this.btn_AccessDatabase_Click);
			// 
			// btn_ChangePassword
			// 
			this.btn_ChangePassword.Location = new System.Drawing.Point(287, 434);
			this.btn_ChangePassword.Name = "btn_ChangePassword";
			this.btn_ChangePassword.Size = new System.Drawing.Size(141, 44);
			this.btn_ChangePassword.TabIndex = 6;
			this.btn_ChangePassword.Text = "Đổi Mật Khẩu";
			this.btn_ChangePassword.UseVisualStyleBackColor = true;
			this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
			// 
			// btn_SignInWithoutAccount
			// 
			this.btn_SignInWithoutAccount.Location = new System.Drawing.Point(24, 434);
			this.btn_SignInWithoutAccount.Name = "btn_SignInWithoutAccount";
			this.btn_SignInWithoutAccount.Size = new System.Drawing.Size(257, 44);
			this.btn_SignInWithoutAccount.TabIndex = 5;
			this.btn_SignInWithoutAccount.Text = "Đăng Nhập Không Tài Khoản";
			this.btn_SignInWithoutAccount.UseVisualStyleBackColor = true;
			this.btn_SignInWithoutAccount.Click += new System.EventHandler(this.btn_SignInWithoutAccount_Click);
			// 
			// btn_SignIn
			// 
			this.btn_SignIn.Location = new System.Drawing.Point(24, 384);
			this.btn_SignIn.Name = "btn_SignIn";
			this.btn_SignIn.Size = new System.Drawing.Size(404, 44);
			this.btn_SignIn.TabIndex = 4;
			this.btn_SignIn.Text = "Đăng Nhập";
			this.btn_SignIn.UseVisualStyleBackColor = true;
			this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
			// 
			// tbx_Password
			// 
			this.tbx_Password.Location = new System.Drawing.Point(24, 304);
			this.tbx_Password.Name = "tbx_Password";
			this.tbx_Password.Size = new System.Drawing.Size(365, 29);
			this.tbx_Password.TabIndex = 1;
			// 
			// lbl_Password
			// 
			this.lbl_Password.AutoSize = true;
			this.lbl_Password.Location = new System.Drawing.Point(20, 280);
			this.lbl_Password.Name = "lbl_Password";
			this.lbl_Password.Size = new System.Drawing.Size(83, 21);
			this.lbl_Password.TabIndex = 13;
			this.lbl_Password.Text = "Mật Khẩu";
			// 
			// lbl_Subtitle
			// 
			this.lbl_Subtitle.AutoSize = true;
			this.lbl_Subtitle.Location = new System.Drawing.Point(69, 83);
			this.lbl_Subtitle.Name = "lbl_Subtitle";
			this.lbl_Subtitle.Size = new System.Drawing.Size(321, 21);
			this.lbl_Subtitle.TabIndex = 9;
			this.lbl_Subtitle.Text = "Tận Hưỡng Vị Ngon Của Từng Hạt Nước";
			// 
			// tbx_Login
			// 
			this.tbx_Login.Location = new System.Drawing.Point(24, 227);
			this.tbx_Login.Name = "tbx_Login";
			this.tbx_Login.Size = new System.Drawing.Size(404, 29);
			this.tbx_Login.TabIndex = 0;
			// 
			// lbl_Login
			// 
			this.lbl_Login.AutoSize = true;
			this.lbl_Login.Location = new System.Drawing.Point(20, 203);
			this.lbl_Login.Name = "lbl_Login";
			this.lbl_Login.Size = new System.Drawing.Size(122, 21);
			this.lbl_Login.TabIndex = 11;
			this.lbl_Login.Text = "Tên Tài Khoản";
			// 
			// lbl_SignIn
			// 
			this.lbl_SignIn.AutoSize = true;
			this.lbl_SignIn.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SignIn.Location = new System.Drawing.Point(142, 147);
			this.lbl_SignIn.Name = "lbl_SignIn";
			this.lbl_SignIn.Size = new System.Drawing.Size(171, 36);
			this.lbl_SignIn.TabIndex = 10;
			this.lbl_SignIn.Text = "Đăng Nhập";
			// 
			// lbl_Title
			// 
			this.lbl_Title.AutoSize = true;
			this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.Location = new System.Drawing.Point(40, 28);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(371, 42);
			this.lbl_Title.TabIndex = 8;
			this.lbl_Title.Text = "Quán Cafe Lattecrone";
			// 
			// pnl_DatabaseAccess
			// 
			this.pnl_DatabaseAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_DatabaseAccess.Controls.Add(this.ptb_Image);
			this.pnl_DatabaseAccess.Controls.Add(this.btn_ShowCode);
			this.pnl_DatabaseAccess.Controls.Add(this.dgv_Login);
			this.pnl_DatabaseAccess.Controls.Add(this.ptb_TopColor);
			this.pnl_DatabaseAccess.Controls.Add(this.lbl_Permission);
			this.pnl_DatabaseAccess.Controls.Add(this.tbx_ConnectionStatus);
			this.pnl_DatabaseAccess.Controls.Add(this.lbl_ConnectionStatus);
			this.pnl_DatabaseAccess.Controls.Add(this.lbl_DatabaseAnnotation);
			this.pnl_DatabaseAccess.Controls.Add(this.lbl_ServerAnnotation);
			this.pnl_DatabaseAccess.Controls.Add(this.btn_CheckConnection);
			this.pnl_DatabaseAccess.Controls.Add(this.tbx_Database);
			this.pnl_DatabaseAccess.Controls.Add(this.lbl_Database);
			this.pnl_DatabaseAccess.Controls.Add(this.tbx_Server);
			this.pnl_DatabaseAccess.Controls.Add(this.lbl_Server);
			this.pnl_DatabaseAccess.Controls.Add(this.lbl_DatabaseAccess);
			this.pnl_DatabaseAccess.Location = new System.Drawing.Point(472, 12);
			this.pnl_DatabaseAccess.Name = "pnl_DatabaseAccess";
			this.pnl_DatabaseAccess.Size = new System.Drawing.Size(450, 587);
			this.pnl_DatabaseAccess.TabIndex = 1;
			// 
			// btn_ShowCode
			// 
			this.btn_ShowCode.Location = new System.Drawing.Point(328, 285);
			this.btn_ShowCode.Name = "btn_ShowCode";
			this.btn_ShowCode.Size = new System.Drawing.Size(100, 44);
			this.btn_ShowCode.TabIndex = 18;
			this.btn_ShowCode.Text = "Xem Code";
			this.btn_ShowCode.UseVisualStyleBackColor = true;
			this.btn_ShowCode.Click += new System.EventHandler(this.btn_ShowCode_Click);
			// 
			// dgv_Login
			// 
			this.dgv_Login.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Login.Location = new System.Drawing.Point(24, 442);
			this.dgv_Login.Name = "dgv_Login";
			this.dgv_Login.Size = new System.Drawing.Size(404, 140);
			this.dgv_Login.TabIndex = 17;
			// 
			// lbl_Permission
			// 
			this.lbl_Permission.AutoSize = true;
			this.lbl_Permission.Location = new System.Drawing.Point(20, 418);
			this.lbl_Permission.Name = "lbl_Permission";
			this.lbl_Permission.Size = new System.Drawing.Size(209, 21);
			this.lbl_Permission.TabIndex = 11;
			this.lbl_Permission.Text = "Danh Sách Các Tài Khoản";
			// 
			// tbx_ConnectionStatus
			// 
			this.tbx_ConnectionStatus.Location = new System.Drawing.Point(186, 369);
			this.tbx_ConnectionStatus.Name = "tbx_ConnectionStatus";
			this.tbx_ConnectionStatus.ReadOnly = true;
			this.tbx_ConnectionStatus.Size = new System.Drawing.Size(242, 29);
			this.tbx_ConnectionStatus.TabIndex = 3;
			this.tbx_ConnectionStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbl_ConnectionStatus
			// 
			this.lbl_ConnectionStatus.AutoSize = true;
			this.lbl_ConnectionStatus.Location = new System.Drawing.Point(20, 372);
			this.lbl_ConnectionStatus.Name = "lbl_ConnectionStatus";
			this.lbl_ConnectionStatus.Size = new System.Drawing.Size(157, 21);
			this.lbl_ConnectionStatus.TabIndex = 10;
			this.lbl_ConnectionStatus.Text = "Tình Trạng Kết Nối";
			// 
			// lbl_DatabaseAnnotation
			// 
			this.lbl_DatabaseAnnotation.ForeColor = System.Drawing.Color.Red;
			this.lbl_DatabaseAnnotation.Location = new System.Drawing.Point(24, 247);
			this.lbl_DatabaseAnnotation.Name = "lbl_DatabaseAnnotation";
			this.lbl_DatabaseAnnotation.Size = new System.Drawing.Size(404, 21);
			this.lbl_DatabaseAnnotation.TabIndex = 9;
			this.lbl_DatabaseAnnotation.Text = "Báo Lỗi";
			this.lbl_DatabaseAnnotation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_ServerAnnotation
			// 
			this.lbl_ServerAnnotation.ForeColor = System.Drawing.Color.Red;
			this.lbl_ServerAnnotation.Location = new System.Drawing.Point(27, 170);
			this.lbl_ServerAnnotation.Name = "lbl_ServerAnnotation";
			this.lbl_ServerAnnotation.Size = new System.Drawing.Size(401, 21);
			this.lbl_ServerAnnotation.TabIndex = 7;
			this.lbl_ServerAnnotation.Text = "Báo Lỗi";
			this.lbl_ServerAnnotation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_CheckConnection
			// 
			this.btn_CheckConnection.Location = new System.Drawing.Point(24, 285);
			this.btn_CheckConnection.Name = "btn_CheckConnection";
			this.btn_CheckConnection.Size = new System.Drawing.Size(298, 44);
			this.btn_CheckConnection.TabIndex = 2;
			this.btn_CheckConnection.Text = "Kiểm Tra Kết Nối";
			this.btn_CheckConnection.UseVisualStyleBackColor = true;
			this.btn_CheckConnection.Click += new System.EventHandler(this.btn_CheckConnection_Click);
			// 
			// tbx_Database
			// 
			this.tbx_Database.Location = new System.Drawing.Point(24, 215);
			this.tbx_Database.Name = "tbx_Database";
			this.tbx_Database.Size = new System.Drawing.Size(404, 29);
			this.tbx_Database.TabIndex = 1;
			// 
			// lbl_Database
			// 
			this.lbl_Database.AutoSize = true;
			this.lbl_Database.Location = new System.Drawing.Point(20, 191);
			this.lbl_Database.Name = "lbl_Database";
			this.lbl_Database.Size = new System.Drawing.Size(112, 21);
			this.lbl_Database.TabIndex = 8;
			this.lbl_Database.Text = "Tên Database";
			// 
			// tbx_Server
			// 
			this.tbx_Server.Location = new System.Drawing.Point(24, 138);
			this.tbx_Server.Name = "tbx_Server";
			this.tbx_Server.Size = new System.Drawing.Size(404, 29);
			this.tbx_Server.TabIndex = 0;
			// 
			// lbl_Server
			// 
			this.lbl_Server.AutoSize = true;
			this.lbl_Server.Location = new System.Drawing.Point(20, 114);
			this.lbl_Server.Name = "lbl_Server";
			this.lbl_Server.Size = new System.Drawing.Size(92, 21);
			this.lbl_Server.TabIndex = 6;
			this.lbl_Server.Text = "Tên Server";
			// 
			// lbl_DatabaseAccess
			// 
			this.lbl_DatabaseAccess.AutoSize = true;
			this.lbl_DatabaseAccess.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_DatabaseAccess.Location = new System.Drawing.Point(108, 68);
			this.lbl_DatabaseAccess.Name = "lbl_DatabaseAccess";
			this.lbl_DatabaseAccess.Size = new System.Drawing.Size(256, 36);
			this.lbl_DatabaseAccess.TabIndex = 5;
			this.lbl_DatabaseAccess.Text = "Kết Nối Database";
			// 
			// ptb_Image
			// 
			this.ptb_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ptb_Image.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Lattecrone;
			this.ptb_Image.Location = new System.Drawing.Point(-1, -1);
			this.ptb_Image.Name = "ptb_Image";
			this.ptb_Image.Size = new System.Drawing.Size(450, 587);
			this.ptb_Image.TabIndex = 17;
			this.ptb_Image.TabStop = false;
			// 
			// ptb_TopColor
			// 
			this.ptb_TopColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(143)))));
			this.ptb_TopColor.Location = new System.Drawing.Point(-1, -1);
			this.ptb_TopColor.Name = "ptb_TopColor";
			this.ptb_TopColor.Size = new System.Drawing.Size(450, 41);
			this.ptb_TopColor.TabIndex = 16;
			this.ptb_TopColor.TabStop = false;
			// 
			// ptb_BottomColor
			// 
			this.ptb_BottomColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(143)))));
			this.ptb_BottomColor.Location = new System.Drawing.Point(-1, 545);
			this.ptb_BottomColor.Name = "ptb_BottomColor";
			this.ptb_BottomColor.Size = new System.Drawing.Size(450, 41);
			this.ptb_BottomColor.TabIndex = 21;
			this.ptb_BottomColor.TabStop = false;
			// 
			// btn_HidePassword
			// 
			this.btn_HidePassword.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Eye_Cross;
			this.btn_HidePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_HidePassword.Location = new System.Drawing.Point(395, 304);
			this.btn_HidePassword.Name = "btn_HidePassword";
			this.btn_HidePassword.Size = new System.Drawing.Size(33, 29);
			this.btn_HidePassword.TabIndex = 2;
			this.btn_HidePassword.UseVisualStyleBackColor = true;
			this.btn_HidePassword.Click += new System.EventHandler(this.btn_HidePassword_Click);
			// 
			// btn_ShowPassword
			// 
			this.btn_ShowPassword.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Eye;
			this.btn_ShowPassword.Location = new System.Drawing.Point(395, 304);
			this.btn_ShowPassword.Name = "btn_ShowPassword";
			this.btn_ShowPassword.Size = new System.Drawing.Size(33, 29);
			this.btn_ShowPassword.TabIndex = 3;
			this.btn_ShowPassword.UseVisualStyleBackColor = true;
			this.btn_ShowPassword.Click += new System.EventHandler(this.btn_ShowPassword_Click);
			// 
			// frm_SignIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(934, 611);
			this.Controls.Add(this.pnl_DatabaseAccess);
			this.Controls.Add(this.pnl_SignIn);
			this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_SignIn";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quán Cafe Lattecrone";
			this.Load += new System.EventHandler(this.frm_SignIn_Load);
			this.pnl_SignIn.ResumeLayout(false);
			this.pnl_SignIn.PerformLayout();
			this.pnl_DatabaseAccess.ResumeLayout(false);
			this.pnl_DatabaseAccess.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Login)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptb_Image)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptb_TopColor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptb_BottomColor)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnl_SignIn;
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Button btn_ShowPassword;
		private System.Windows.Forms.TextBox tbx_Password;
		private System.Windows.Forms.Label lbl_Password;
		private System.Windows.Forms.Label lbl_Subtitle;
		private System.Windows.Forms.TextBox tbx_Login;
		private System.Windows.Forms.Label lbl_Login;
		private System.Windows.Forms.Label lbl_SignIn;
		private System.Windows.Forms.Button btn_HidePassword;
		private System.Windows.Forms.Button btn_SignIn;
		private System.Windows.Forms.Button btn_ChangePassword;
		private System.Windows.Forms.Button btn_SignInWithoutAccount;
		private System.Windows.Forms.Button btn_AccessDatabase;
		private System.Windows.Forms.Button btn_CheckConnection;
		private System.Windows.Forms.TextBox tbx_Database;
		private System.Windows.Forms.Label lbl_Database;
		private System.Windows.Forms.Label lbl_Server;
		private System.Windows.Forms.Label lbl_DatabaseAccess;
		private System.Windows.Forms.Label lbl_PasswordAnnotation;
		private System.Windows.Forms.Label lbl_LoginAnnotation;
		private System.Windows.Forms.Label lbl_DatabaseAnnotation;
		private System.Windows.Forms.Label lbl_ServerAnnotation;
		private System.Windows.Forms.Panel pnl_DatabaseAccess;
		private System.Windows.Forms.Label lbl_ConnectionStatus;
		private System.Windows.Forms.TextBox tbx_ConnectionStatus;
		private System.Windows.Forms.Label lbl_Permission;
		private System.Windows.Forms.TextBox tbx_Server;
		private System.Windows.Forms.PictureBox ptb_BottomColor;
		private System.Windows.Forms.PictureBox ptb_TopColor;
		private System.Windows.Forms.PictureBox ptb_Image;
		private System.Windows.Forms.DataGridView dgv_Login;
		private System.Windows.Forms.Button btn_ShowCode;
	}
}

