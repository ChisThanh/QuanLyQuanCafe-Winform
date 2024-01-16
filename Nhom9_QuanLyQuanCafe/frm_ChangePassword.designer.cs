namespace Nhom9_QuanLyQuanCafe
{
	partial class frm_ChangePassword
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
			this.lbl_PasswordAnnotation = new System.Windows.Forms.Label();
			this.lbl_LoginAnnotation = new System.Windows.Forms.Label();
			this.btn_ChangePassword = new System.Windows.Forms.Button();
			this.btn_HidePassword = new System.Windows.Forms.Button();
			this.btn_ShowPassword = new System.Windows.Forms.Button();
			this.tbx_Password = new System.Windows.Forms.TextBox();
			this.lbl_Password = new System.Windows.Forms.Label();
			this.tbx_Login = new System.Windows.Forms.TextBox();
			this.lbl_Login = new System.Windows.Forms.Label();
			this.lbl_SignIn = new System.Windows.Forms.Label();
			this.btn_ShowCode = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_PasswordAnnotation
			// 
			this.lbl_PasswordAnnotation.ForeColor = System.Drawing.Color.Red;
			this.lbl_PasswordAnnotation.Location = new System.Drawing.Point(31, 237);
			this.lbl_PasswordAnnotation.Name = "lbl_PasswordAnnotation";
			this.lbl_PasswordAnnotation.Size = new System.Drawing.Size(404, 21);
			this.lbl_PasswordAnnotation.TabIndex = 34;
			this.lbl_PasswordAnnotation.Text = "Báo Lỗi";
			this.lbl_PasswordAnnotation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_LoginAnnotation
			// 
			this.lbl_LoginAnnotation.ForeColor = System.Drawing.Color.Red;
			this.lbl_LoginAnnotation.Location = new System.Drawing.Point(31, 160);
			this.lbl_LoginAnnotation.Name = "lbl_LoginAnnotation";
			this.lbl_LoginAnnotation.Size = new System.Drawing.Size(404, 21);
			this.lbl_LoginAnnotation.TabIndex = 32;
			this.lbl_LoginAnnotation.Text = "Báo Lỗi";
			this.lbl_LoginAnnotation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_ChangePassword
			// 
			this.btn_ChangePassword.Location = new System.Drawing.Point(31, 284);
			this.btn_ChangePassword.Name = "btn_ChangePassword";
			this.btn_ChangePassword.Size = new System.Drawing.Size(404, 44);
			this.btn_ChangePassword.TabIndex = 29;
			this.btn_ChangePassword.Text = "Đổi Mật Khẩu";
			this.btn_ChangePassword.UseVisualStyleBackColor = true;
			this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
			// 
			// btn_HidePassword
			// 
			this.btn_HidePassword.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Eye_Cross;
			this.btn_HidePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_HidePassword.Location = new System.Drawing.Point(402, 203);
			this.btn_HidePassword.Name = "btn_HidePassword";
			this.btn_HidePassword.Size = new System.Drawing.Size(33, 29);
			this.btn_HidePassword.TabIndex = 27;
			this.btn_HidePassword.UseVisualStyleBackColor = true;
			this.btn_HidePassword.Click += new System.EventHandler(this.btn_HidePassword_Click);
			// 
			// btn_ShowPassword
			// 
			this.btn_ShowPassword.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Eye;
			this.btn_ShowPassword.Location = new System.Drawing.Point(402, 205);
			this.btn_ShowPassword.Name = "btn_ShowPassword";
			this.btn_ShowPassword.Size = new System.Drawing.Size(33, 29);
			this.btn_ShowPassword.TabIndex = 28;
			this.btn_ShowPassword.UseVisualStyleBackColor = true;
			this.btn_ShowPassword.Click += new System.EventHandler(this.btn_ShowPassword_Click);
			// 
			// tbx_Password
			// 
			this.tbx_Password.Location = new System.Drawing.Point(31, 205);
			this.tbx_Password.Name = "tbx_Password";
			this.tbx_Password.Size = new System.Drawing.Size(365, 26);
			this.tbx_Password.TabIndex = 26;
			// 
			// lbl_Password
			// 
			this.lbl_Password.AutoSize = true;
			this.lbl_Password.Location = new System.Drawing.Point(27, 181);
			this.lbl_Password.Name = "lbl_Password";
			this.lbl_Password.Size = new System.Drawing.Size(71, 19);
			this.lbl_Password.TabIndex = 33;
			this.lbl_Password.Text = "Mật Khẩu";
			// 
			// tbx_Login
			// 
			this.tbx_Login.Location = new System.Drawing.Point(31, 128);
			this.tbx_Login.Name = "tbx_Login";
			this.tbx_Login.Size = new System.Drawing.Size(404, 26);
			this.tbx_Login.TabIndex = 25;
			// 
			// lbl_Login
			// 
			this.lbl_Login.AutoSize = true;
			this.lbl_Login.Location = new System.Drawing.Point(27, 104);
			this.lbl_Login.Name = "lbl_Login";
			this.lbl_Login.Size = new System.Drawing.Size(100, 19);
			this.lbl_Login.TabIndex = 31;
			this.lbl_Login.Text = "Tên Tài Khoản";
			// 
			// lbl_SignIn
			// 
			this.lbl_SignIn.AutoSize = true;
			this.lbl_SignIn.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SignIn.Location = new System.Drawing.Point(123, 47);
			this.lbl_SignIn.Name = "lbl_SignIn";
			this.lbl_SignIn.Size = new System.Drawing.Size(215, 36);
			this.lbl_SignIn.TabIndex = 30;
			this.lbl_SignIn.Text = "Đổi Mật Khẩu";
			// 
			// btn_ShowCode
			// 
			this.btn_ShowCode.Location = new System.Drawing.Point(31, 334);
			this.btn_ShowCode.Name = "btn_ShowCode";
			this.btn_ShowCode.Size = new System.Drawing.Size(404, 44);
			this.btn_ShowCode.TabIndex = 35;
			this.btn_ShowCode.Text = "Hiện Code";
			this.btn_ShowCode.UseVisualStyleBackColor = true;
			this.btn_ShowCode.Click += new System.EventHandler(this.btn_ShowCode_Click);
			// 
			// frm_ChangePassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(463, 408);
			this.Controls.Add(this.btn_ShowCode);
			this.Controls.Add(this.lbl_PasswordAnnotation);
			this.Controls.Add(this.lbl_LoginAnnotation);
			this.Controls.Add(this.btn_ChangePassword);
			this.Controls.Add(this.btn_HidePassword);
			this.Controls.Add(this.btn_ShowPassword);
			this.Controls.Add(this.tbx_Password);
			this.Controls.Add(this.lbl_Password);
			this.Controls.Add(this.tbx_Login);
			this.Controls.Add(this.lbl_Login);
			this.Controls.Add(this.lbl_SignIn);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frm_ChangePassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đổi Mật Khẩu";
			this.Load += new System.EventHandler(this.frm_ChangePassword_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_PasswordAnnotation;
		private System.Windows.Forms.Label lbl_LoginAnnotation;
		private System.Windows.Forms.Button btn_ChangePassword;
		private System.Windows.Forms.Button btn_HidePassword;
		private System.Windows.Forms.Button btn_ShowPassword;
		private System.Windows.Forms.TextBox tbx_Password;
		private System.Windows.Forms.Label lbl_Password;
		private System.Windows.Forms.TextBox tbx_Login;
		private System.Windows.Forms.Label lbl_Login;
		private System.Windows.Forms.Label lbl_SignIn;
		private System.Windows.Forms.Button btn_ShowCode;
	}
}