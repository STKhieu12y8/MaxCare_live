namespace maxcare
{
	// Token: 0x0200008A RID: 138
	public partial class fCauHinhKhoiPhucTaiKhoan : global::System.Windows.Forms.Form
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x0006D12C File Offset: 0x0006B32C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0006D18C File Offset: 0x0006B38C
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.rbThuMucCu = new System.Windows.Forms.RadioButton();
            this.rbThuMucKhac = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbThuMuc = new System.Windows.Forms.ComboBox();
            this.plThuMucKhac = new System.Windows.Forms.Panel();
            this.bunifuCards1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plThuMucKhac.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards1.Controls.Add(this.pnlHeader);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(487, 42);
            this.bunifuCards1.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Location = new System.Drawing.Point(0, 4);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(487, 34);
            this.pnlHeader.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::MaxCare.Properties.Resources.close_window_25px;
            this.btnMinimize.Location = new System.Drawing.Point(444, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 34);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(487, 34);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Cấu hình Khôi phục tài khoản";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(251, 199);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(112, 199);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // rbThuMucCu
            // 
            this.rbThuMucCu.AutoSize = true;
            this.rbThuMucCu.Checked = true;
            this.rbThuMucCu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbThuMucCu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThuMucCu.Location = new System.Drawing.Point(48, 69);
            this.rbThuMucCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbThuMucCu.Name = "rbThuMucCu";
            this.rbThuMucCu.Size = new System.Drawing.Size(213, 25);
            this.rbThuMucCu.TabIndex = 5;
            this.rbThuMucCu.TabStop = true;
            this.rbThuMucCu.Text = "Khôi phục về thư mục cũ";
            this.rbThuMucCu.UseVisualStyleBackColor = true;
            // 
            // rbThuMucKhac
            // 
            this.rbThuMucKhac.AutoSize = true;
            this.rbThuMucKhac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbThuMucKhac.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThuMucKhac.Location = new System.Drawing.Point(48, 101);
            this.rbThuMucKhac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbThuMucKhac.Name = "rbThuMucKhac";
            this.rbThuMucKhac.Size = new System.Drawing.Size(230, 25);
            this.rbThuMucKhac.TabIndex = 5;
            this.rbThuMucKhac.Text = "Chuyển sang thư mục khác";
            this.rbThuMucKhac.UseVisualStyleBackColor = true;
            this.rbThuMucKhac.CheckedChanged += new System.EventHandler(this.rbThuMucKhac_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(280, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 33);
            this.button1.TabIndex = 48;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbThuMuc
            // 
            this.cbbThuMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbThuMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThuMuc.DropDownWidth = 269;
            this.cbbThuMuc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThuMuc.FormattingEnabled = true;
            this.cbbThuMuc.Location = new System.Drawing.Point(4, 4);
            this.cbbThuMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbThuMuc.Name = "cbbThuMuc";
            this.cbbThuMuc.Size = new System.Drawing.Size(267, 27);
            this.cbbThuMuc.TabIndex = 47;
            // 
            // plThuMucKhac
            // 
            this.plThuMucKhac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plThuMucKhac.Controls.Add(this.cbbThuMuc);
            this.plThuMucKhac.Controls.Add(this.button1);
            this.plThuMucKhac.Location = new System.Drawing.Point(73, 133);
            this.plThuMucKhac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plThuMucKhac.Name = "plThuMucKhac";
            this.plThuMucKhac.Size = new System.Drawing.Size(370, 40);
            this.plThuMucKhac.TabIndex = 49;
            // 
            // fCauHinhKhoiPhucTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 252);
            this.Controls.Add(this.plThuMucKhac);
            this.Controls.Add(this.rbThuMucKhac);
            this.Controls.Add(this.rbThuMucCu);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fCauHinhKhoiPhucTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fAddFile";
            this.Load += new System.EventHandler(this.fClearProfile_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plThuMucKhac.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000420 RID: 1056
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000421 RID: 1057
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000422 RID: 1058
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000423 RID: 1059
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000424 RID: 1060
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000425 RID: 1061
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000426 RID: 1062
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000427 RID: 1063
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000428 RID: 1064
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000429 RID: 1065
		private global::System.Windows.Forms.RadioButton rbThuMucCu;

		// Token: 0x0400042A RID: 1066
		private global::System.Windows.Forms.RadioButton rbThuMucKhac;

		// Token: 0x0400042B RID: 1067
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400042C RID: 1068
		private global::System.Windows.Forms.ComboBox cbbThuMuc;

		// Token: 0x0400042D RID: 1069
		private global::System.Windows.Forms.Panel plThuMucKhac;
	}
}
