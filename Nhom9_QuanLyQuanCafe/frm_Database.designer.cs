namespace Nhom9_QuanLyQuanCafe
{
	partial class frm_Database
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
			this.pnl_Color = new System.Windows.Forms.Panel();
			this.lbl_Title = new System.Windows.Forms.Label();
			this.ptb_Diagram = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.ptb_Diagram)).BeginInit();
			this.SuspendLayout();
			// 
			// pnl_Color
			// 
			this.pnl_Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(143)))));
			this.pnl_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Color.Location = new System.Drawing.Point(407, 12);
			this.pnl_Color.Name = "pnl_Color";
			this.pnl_Color.Size = new System.Drawing.Size(381, 67);
			this.pnl_Color.TabIndex = 9;
			// 
			// lbl_Title
			// 
			this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.lbl_Title.Location = new System.Drawing.Point(12, 17);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(389, 50);
			this.lbl_Title.TabIndex = 8;
			this.lbl_Title.Text = "Database";
			this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ptb_Diagram
			// 
			this.ptb_Diagram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ptb_Diagram.Image = global::Nhom9_QuanLyQuanCafe.Properties.Resources.Diagram;
			this.ptb_Diagram.Location = new System.Drawing.Point(12, 85);
			this.ptb_Diagram.Name = "ptb_Diagram";
			this.ptb_Diagram.Size = new System.Drawing.Size(776, 653);
			this.ptb_Diagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptb_Diagram.TabIndex = 10;
			this.ptb_Diagram.TabStop = false;
			// 
			// frm_Database
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 750);
			this.Controls.Add(this.ptb_Diagram);
			this.Controls.Add(this.pnl_Color);
			this.Controls.Add(this.lbl_Title);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_Database";
			this.Text = "frm_Database";
			((System.ComponentModel.ISupportInitialize)(this.ptb_Diagram)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnl_Color;
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.PictureBox ptb_Diagram;
	}
}