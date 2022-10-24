namespace maxcare
{
	// Token: 0x02000105 RID: 261
	public partial class fHDBackupData : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B26 RID: 2854 RVA: 0x00182680 File Offset: 0x00180880
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x001826E0 File Offset: 0x001808E0
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbNgaySinh = new System.Windows.Forms.CheckBox();
            this.ckbNhanTin = new System.Windows.Forms.CheckBox();
            this.plComment = new System.Windows.Forms.Panel();
            this.nudSoThang = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.plAnh = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.ckbBackupImageNangCao = new System.Windows.Forms.CheckBox();
            this.nudSoLuongAnh = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbBinhLuan = new System.Windows.Forms.CheckBox();
            this.ckbAnhBanBe = new System.Windows.Forms.CheckBox();
            this.ckbCreateHTML = new System.Windows.Forms.CheckBox();
            this.txtTenHanhDong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.plComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoThang)).BeginInit();
            this.plAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongAnh)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Backup dữ liệu";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pnlHeader;
            this.bunifuDragControl2.Vertical = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.button1);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Location = new System.Drawing.Point(0, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(359, 31);
            this.pnlHeader.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::MaxCare.Properties.Resources.close_window_25px;
            this.button1.Location = new System.Drawing.Point(328, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.ckbCreateHTML);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 373);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbNgaySinh);
            this.groupBox1.Controls.Add(this.ckbNhanTin);
            this.groupBox1.Controls.Add(this.plComment);
            this.groupBox1.Controls.Add(this.plAnh);
            this.groupBox1.Controls.Add(this.ckbBinhLuan);
            this.groupBox1.Controls.Add(this.ckbAnhBanBe);
            this.groupBox1.Location = new System.Drawing.Point(30, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấu hình backup";
            // 
            // ckbNgaySinh
            // 
            this.ckbNgaySinh.AutoSize = true;
            this.ckbNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbNgaySinh.Location = new System.Drawing.Point(12, 20);
            this.ckbNgaySinh.Name = "ckbNgaySinh";
            this.ckbNgaySinh.Size = new System.Drawing.Size(104, 25);
            this.ckbNgaySinh.TabIndex = 0;
            this.ckbNgaySinh.Text = "Ngày sinh";
            this.ckbNgaySinh.UseVisualStyleBackColor = true;
            // 
            // ckbNhanTin
            // 
            this.ckbNhanTin.AutoSize = true;
            this.ckbNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbNhanTin.Location = new System.Drawing.Point(12, 122);
            this.ckbNhanTin.Name = "ckbNhanTin";
            this.ckbNhanTin.Size = new System.Drawing.Size(239, 25);
            this.ckbNhanTin.TabIndex = 2;
            this.ckbNhanTin.Text = "Danh sách nhắn tin gần đây";
            this.ckbNhanTin.UseVisualStyleBackColor = true;
            // 
            // plComment
            // 
            this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plComment.Controls.Add(this.nudSoThang);
            this.plComment.Controls.Add(this.label2);
            this.plComment.Controls.Add(this.label4);
            this.plComment.Controls.Add(this.label5);
            this.plComment.Location = new System.Drawing.Point(30, 169);
            this.plComment.Name = "plComment";
            this.plComment.Size = new System.Drawing.Size(221, 27);
            this.plComment.TabIndex = 8;
            // 
            // nudSoThang
            // 
            this.nudSoThang.Location = new System.Drawing.Point(119, 1);
            this.nudSoThang.Name = "nudSoThang";
            this.nudSoThang.Size = new System.Drawing.Size(52, 27);
            this.nudSoThang.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(172, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 151;
            this.label2.Text = "tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(2, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 21);
            this.label4.TabIndex = 152;
            this.label4.Text = "Số lượng tháng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 31;
            // 
            // plAnh
            // 
            this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plAnh.Controls.Add(this.button2);
            this.plAnh.Controls.Add(this.ckbBackupImageNangCao);
            this.plAnh.Controls.Add(this.nudSoLuongAnh);
            this.plAnh.Controls.Add(this.label10);
            this.plAnh.Controls.Add(this.label7);
            this.plAnh.Controls.Add(this.label3);
            this.plAnh.Location = new System.Drawing.Point(30, 69);
            this.plAnh.Name = "plAnh";
            this.plAnh.Size = new System.Drawing.Size(221, 50);
            this.plAnh.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Help;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(154, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 153;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ckbBackupImageNangCao
            // 
            this.ckbBackupImageNangCao.AutoSize = true;
            this.ckbBackupImageNangCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbBackupImageNangCao.Location = new System.Drawing.Point(5, 26);
            this.ckbBackupImageNangCao.Name = "ckbBackupImageNangCao";
            this.ckbBackupImageNangCao.Size = new System.Drawing.Size(189, 25);
            this.ckbBackupImageNangCao.TabIndex = 0;
            this.ckbBackupImageNangCao.Text = "Backup ảnh nâng cao";
            this.ckbBackupImageNangCao.UseVisualStyleBackColor = true;
            // 
            // nudSoLuongAnh
            // 
            this.nudSoLuongAnh.Location = new System.Drawing.Point(119, 1);
            this.nudSoLuongAnh.Name = "nudSoLuongAnh";
            this.nudSoLuongAnh.Size = new System.Drawing.Size(52, 27);
            this.nudSoLuongAnh.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(173, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 21);
            this.label10.TabIndex = 151;
            this.label10.Text = "ảnh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(2, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 21);
            this.label7.TabIndex = 152;
            this.label7.Text = "Số lượng ảnh/bạn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 31;
            // 
            // ckbBinhLuan
            // 
            this.ckbBinhLuan.AutoSize = true;
            this.ckbBinhLuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbBinhLuan.Location = new System.Drawing.Point(12, 148);
            this.ckbBinhLuan.Name = "ckbBinhLuan";
            this.ckbBinhLuan.Size = new System.Drawing.Size(182, 25);
            this.ckbBinhLuan.TabIndex = 3;
            this.ckbBinhLuan.Text = "Danh sách bình luận";
            this.ckbBinhLuan.UseVisualStyleBackColor = true;
            this.ckbBinhLuan.CheckedChanged += new System.EventHandler(this.ckbBinhLuan_CheckedChanged);
            // 
            // ckbAnhBanBe
            // 
            this.ckbAnhBanBe.AutoSize = true;
            this.ckbAnhBanBe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbAnhBanBe.Location = new System.Drawing.Point(12, 46);
            this.ckbAnhBanBe.Name = "ckbAnhBanBe";
            this.ckbAnhBanBe.Size = new System.Drawing.Size(116, 25);
            this.ckbAnhBanBe.TabIndex = 1;
            this.ckbAnhBanBe.Text = "Ảnh bạn bè";
            this.ckbAnhBanBe.UseVisualStyleBackColor = true;
            this.ckbAnhBanBe.CheckedChanged += new System.EventHandler(this.ckbComment_CheckedChanged);
            // 
            // ckbCreateHTML
            // 
            this.ckbCreateHTML.AutoSize = true;
            this.ckbCreateHTML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCreateHTML.Location = new System.Drawing.Point(30, 293);
            this.ckbCreateHTML.Name = "ckbCreateHTML";
            this.ckbCreateHTML.Size = new System.Drawing.Size(344, 25);
            this.ckbCreateHTML.TabIndex = 2;
            this.ckbCreateHTML.Text = "Tự động tạo luôn File Html sau khi backup";
            this.ckbCreateHTML.UseVisualStyleBackColor = true;
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(193, 27);
            this.txtTenHanhDong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tên hành động:";
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
            this.btnCancel.Location = new System.Drawing.Point(189, 327);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(82, 327);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
            this.bunifuCards1.Controls.Add(this.pnlHeader);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(359, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDBackupData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 373);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDBackupData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.plComment.ResumeLayout(false);
            this.plComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoThang)).EndInit();
            this.plAnh.ResumeLayout(false);
            this.plAnh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongAnh)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x040010DC RID: 4316
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040010DD RID: 4317
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040010DE RID: 4318
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x040010DF RID: 4319
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040010E0 RID: 4320
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x040010E1 RID: 4321
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040010E2 RID: 4322
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040010E3 RID: 4323
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040010E4 RID: 4324
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040010E5 RID: 4325
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040010E6 RID: 4326
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040010E7 RID: 4327
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040010E8 RID: 4328
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040010E9 RID: 4329
		private global::System.Windows.Forms.Panel plAnh;

		// Token: 0x040010EA RID: 4330
		private global::System.Windows.Forms.CheckBox ckbAnhBanBe;

		// Token: 0x040010EB RID: 4331
		private global::System.Windows.Forms.CheckBox ckbNgaySinh;

		// Token: 0x040010EC RID: 4332
		private global::System.Windows.Forms.CheckBox ckbNhanTin;

		// Token: 0x040010ED RID: 4333
		private global::System.Windows.Forms.NumericUpDown nudSoLuongAnh;

		// Token: 0x040010EE RID: 4334
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040010EF RID: 4335
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040010F0 RID: 4336
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040010F1 RID: 4337
		private global::System.Windows.Forms.CheckBox ckbBinhLuan;

		// Token: 0x040010F2 RID: 4338
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040010F3 RID: 4339
		private global::System.Windows.Forms.CheckBox ckbCreateHTML;

		// Token: 0x040010F4 RID: 4340
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x040010F5 RID: 4341
		private global::System.Windows.Forms.NumericUpDown nudSoThang;

		// Token: 0x040010F6 RID: 4342
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040010F7 RID: 4343
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040010F8 RID: 4344
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040010F9 RID: 4345
		private global::System.Windows.Forms.CheckBox ckbBackupImageNangCao;

		// Token: 0x040010FA RID: 4346
		private global::System.Windows.Forms.Button button2;
	}
}
