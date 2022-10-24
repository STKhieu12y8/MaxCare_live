namespace maxcare
{
	// Token: 0x0200008D RID: 141
	public partial class fCauHinhQuetNhom : global::System.Windows.Forms.Form
	{
		// Token: 0x06000545 RID: 1349 RVA: 0x00072820 File Offset: 0x00070A20
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00072880 File Offset: 0x00070A80
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbXuatAll = new System.Windows.Forms.RadioButton();
            this.rbXuatNhomKiemDuyet = new System.Windows.Forms.RadioButton();
            this.rbXuatNhomKhongKiemDuyet = new System.Windows.Forms.RadioButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.bunifuCards1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.bunifuCards1.Size = new System.Drawing.Size(472, 42);
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
            this.pnlHeader.Size = new System.Drawing.Size(469, 34);
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
            this.btnMinimize.Location = new System.Drawing.Point(426, 0);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(469, 34);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Tùy chọn mật khẩu";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(248, 235);
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
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(109, 235);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cấu hình đổi IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tùy chọn:";
            // 
            // rbXuatAll
            // 
            this.rbXuatAll.AutoSize = true;
            this.rbXuatAll.Checked = true;
            this.rbXuatAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbXuatAll.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbXuatAll.Location = new System.Drawing.Point(172, 114);
            this.rbXuatAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbXuatAll.Name = "rbXuatAll";
            this.rbXuatAll.Size = new System.Drawing.Size(159, 25);
            this.rbXuatAll.TabIndex = 8;
            this.rbXuatAll.TabStop = true;
            this.rbXuatAll.Text = "Xuất tất cả nhóm";
            this.rbXuatAll.UseVisualStyleBackColor = true;
            // 
            // rbXuatNhomKiemDuyet
            // 
            this.rbXuatNhomKiemDuyet.AutoSize = true;
            this.rbXuatNhomKiemDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbXuatNhomKiemDuyet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbXuatNhomKiemDuyet.Location = new System.Drawing.Point(172, 146);
            this.rbXuatNhomKiemDuyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbXuatNhomKiemDuyet.Name = "rbXuatNhomKiemDuyet";
            this.rbXuatNhomKiemDuyet.Size = new System.Drawing.Size(223, 25);
            this.rbXuatNhomKiemDuyet.TabIndex = 9;
            this.rbXuatNhomKiemDuyet.Text = "Chỉ xuất nhóm kiểm duyệt";
            this.rbXuatNhomKiemDuyet.UseVisualStyleBackColor = true;
            // 
            // rbXuatNhomKhongKiemDuyet
            // 
            this.rbXuatNhomKhongKiemDuyet.AutoSize = true;
            this.rbXuatNhomKhongKiemDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbXuatNhomKhongKiemDuyet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbXuatNhomKhongKiemDuyet.Location = new System.Drawing.Point(172, 178);
            this.rbXuatNhomKhongKiemDuyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbXuatNhomKhongKiemDuyet.Name = "rbXuatNhomKhongKiemDuyet";
            this.rbXuatNhomKhongKiemDuyet.Size = new System.Drawing.Size(272, 25);
            this.rbXuatNhomKhongKiemDuyet.TabIndex = 10;
            this.rbXuatNhomKhongKiemDuyet.Text = "Chỉ xuất nhóm không kiểm duyệt";
            this.rbXuatNhomKhongKiemDuyet.UseVisualStyleBackColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(172, 60);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(100, 28);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Cấu hình";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // fCauHinhQuetNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 281);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.rbXuatNhomKhongKiemDuyet);
            this.Controls.Add(this.rbXuatNhomKiemDuyet);
            this.Controls.Add(this.rbXuatAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bunifuCards1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fCauHinhQuetNhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fAddFile";
            this.Load += new System.EventHandler(this.fClearProfile_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400045E RID: 1118
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400045F RID: 1119
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000460 RID: 1120
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000461 RID: 1121
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000462 RID: 1122
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000463 RID: 1123
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000464 RID: 1124
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000465 RID: 1125
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000466 RID: 1126
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000467 RID: 1127
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000468 RID: 1128
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000469 RID: 1129
		private global::System.Windows.Forms.RadioButton rbXuatAll;

		// Token: 0x0400046A RID: 1130
		private global::System.Windows.Forms.RadioButton rbXuatNhomKiemDuyet;

		// Token: 0x0400046B RID: 1131
		private global::System.Windows.Forms.RadioButton rbXuatNhomKhongKiemDuyet;

		// Token: 0x0400046C RID: 1132
		private global::MetroFramework.Controls.MetroButton metroButton1;
	}
}
