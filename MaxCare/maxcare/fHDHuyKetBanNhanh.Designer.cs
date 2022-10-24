namespace maxcare
{
	// Token: 0x020000BE RID: 190
	public partial class fHDHuyKetBanNhanh : global::System.Windows.Forms.Form
	{
		// Token: 0x06000780 RID: 1920 RVA: 0x000CE8AC File Offset: 0x000CCAAC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x000CE90C File Offset: 0x000CCB0C
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
            this.label12 = new System.Windows.Forms.Label();
            this.txtUidKhongHuyKetBan = new System.Windows.Forms.RichTextBox();
            this.plHuyTheoUid = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.RichTextBox();
            this.plHuyNgauNhien = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.rbHuyTheoUid = new System.Windows.Forms.RadioButton();
            this.rbHuyNgauNhien = new System.Windows.Forms.RadioButton();
            this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
            this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenHanhDong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.plHuyTheoUid.SuspendLayout();
            this.plHuyNgauNhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(687, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Hủy kết bạn nhanh";
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
            this.pnlHeader.Size = new System.Drawing.Size(687, 31);
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
            this.button1.Location = new System.Drawing.Point(656, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 77;
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
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtUidKhongHuyKetBan);
            this.panel1.Controls.Add(this.plHuyTheoUid);
            this.panel1.Controls.Add(this.plHuyNgauNhien);
            this.panel1.Controls.Add(this.rbHuyTheoUid);
            this.panel1.Controls.Add(this.rbHuyNgauNhien);
            this.panel1.Controls.Add(this.nudDelayTo);
            this.panel1.Controls.Add(this.nudDelayFrom);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 411);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(539, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 21);
            this.label12.TabIndex = 115;
            this.label12.Text = "(Mỗi Uid 1 dòng)";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtUidKhongHuyKetBan
            // 
            this.txtUidKhongHuyKetBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUidKhongHuyKetBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUidKhongHuyKetBan.Location = new System.Drawing.Point(385, 102);
            this.txtUidKhongHuyKetBan.Name = "txtUidKhongHuyKetBan";
            this.txtUidKhongHuyKetBan.Size = new System.Drawing.Size(253, 221);
            this.txtUidKhongHuyKetBan.TabIndex = 117;
            this.txtUidKhongHuyKetBan.Text = "";
            this.txtUidKhongHuyKetBan.WordWrap = false;
            this.txtUidKhongHuyKetBan.TextChanged += new System.EventHandler(this.txtUidKhongHuyKetBan_TextChanged);
            // 
            // plHuyTheoUid
            // 
            this.plHuyTheoUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plHuyTheoUid.Controls.Add(this.lblStatus);
            this.plHuyTheoUid.Controls.Add(this.label9);
            this.plHuyTheoUid.Controls.Add(this.txtUid);
            this.plHuyTheoUid.Location = new System.Drawing.Point(59, 208);
            this.plHuyTheoUid.Name = "plHuyTheoUid";
            this.plHuyTheoUid.Size = new System.Drawing.Size(267, 134);
            this.plHuyTheoUid.TabIndex = 118;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(273, 21);
            this.lblStatus.TabIndex = 116;
            this.lblStatus.Text = "Danh sách Uid cần hủy kết bạn (0):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 21);
            this.label9.TabIndex = 115;
            this.label9.Text = "(Mỗi Uid 1 dòng)";
            // 
            // txtUid
            // 
            this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUid.Location = new System.Drawing.Point(7, 23);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(253, 86);
            this.txtUid.TabIndex = 117;
            this.txtUid.Text = "";
            this.txtUid.WordWrap = false;
            this.txtUid.TextChanged += new System.EventHandler(this.txtUid_TextChanged);
            // 
            // plHuyNgauNhien
            // 
            this.plHuyNgauNhien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plHuyNgauNhien.Controls.Add(this.label2);
            this.plHuyNgauNhien.Controls.Add(this.label4);
            this.plHuyNgauNhien.Controls.Add(this.label3);
            this.plHuyNgauNhien.Controls.Add(this.nudSoLuongFrom);
            this.plHuyNgauNhien.Controls.Add(this.nudSoLuongTo);
            this.plHuyNgauNhien.Location = new System.Drawing.Point(59, 155);
            this.plHuyNgauNhien.Name = "plHuyNgauNhien";
            this.plHuyNgauNhien.Size = new System.Drawing.Size(267, 27);
            this.plHuyNgauNhien.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "bạn";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(135, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "đến";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudSoLuongFrom
            // 
            this.nudSoLuongFrom.Location = new System.Drawing.Point(73, 1);
            this.nudSoLuongFrom.Name = "nudSoLuongFrom";
            this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongFrom.TabIndex = 1;
            // 
            // nudSoLuongTo
            // 
            this.nudSoLuongTo.Location = new System.Drawing.Point(167, 1);
            this.nudSoLuongTo.Name = "nudSoLuongTo";
            this.nudSoLuongTo.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongTo.TabIndex = 2;
            // 
            // rbHuyTheoUid
            // 
            this.rbHuyTheoUid.AutoSize = true;
            this.rbHuyTheoUid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbHuyTheoUid.Location = new System.Drawing.Point(46, 185);
            this.rbHuyTheoUid.Name = "rbHuyTheoUid";
            this.rbHuyTheoUid.Size = new System.Drawing.Size(191, 25);
            this.rbHuyTheoUid.TabIndex = 47;
            this.rbHuyTheoUid.Text = "Hủy kết bạn theo UID";
            this.rbHuyTheoUid.UseVisualStyleBackColor = true;
            this.rbHuyTheoUid.CheckedChanged += new System.EventHandler(this.rbHuyTheoUid_CheckedChanged);
            // 
            // rbHuyNgauNhien
            // 
            this.rbHuyNgauNhien.AutoSize = true;
            this.rbHuyNgauNhien.Checked = true;
            this.rbHuyNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbHuyNgauNhien.Location = new System.Drawing.Point(46, 132);
            this.rbHuyNgauNhien.Name = "rbHuyNgauNhien";
            this.rbHuyNgauNhien.Size = new System.Drawing.Size(226, 25);
            this.rbHuyNgauNhien.TabIndex = 47;
            this.rbHuyNgauNhien.TabStop = true;
            this.rbHuyNgauNhien.Text = "Ngẫu nhiên danh sách bạn";
            this.rbHuyNgauNhien.UseVisualStyleBackColor = true;
            this.rbHuyNgauNhien.CheckedChanged += new System.EventHandler(this.rbHuyNgauNhien_CheckedChanged);
            // 
            // nudDelayTo
            // 
            this.nudDelayTo.Location = new System.Drawing.Point(226, 78);
            this.nudDelayTo.Name = "nudDelayTo";
            this.nudDelayTo.Size = new System.Drawing.Size(56, 27);
            this.nudDelayTo.TabIndex = 4;
            // 
            // nudDelayFrom
            // 
            this.nudDelayFrom.Location = new System.Drawing.Point(132, 78);
            this.nudDelayFrom.Name = "nudDelayFrom";
            this.nudDelayFrom.Size = new System.Drawing.Size(56, 27);
            this.nudDelayFrom.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(192, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "đến";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "giây";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(292, 21);
            this.label10.TabIndex = 44;
            this.label10.Text = "Danh sách UID bạn bè cần giữ lại (0):";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 21);
            this.label8.TabIndex = 44;
            this.label8.Text = "Tùy chọn hủy kết bạn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Thời gian chờ:";
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(194, 27);
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
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(352, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(245, 364);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 29);
            this.btnAdd.TabIndex = 6;
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
            this.bunifuCards1.Size = new System.Drawing.Size(687, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDHuyKetBanNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 411);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDHuyKetBanNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plHuyTheoUid.ResumeLayout(false);
            this.plHuyTheoUid.PerformLayout();
            this.plHuyNgauNhien.ResumeLayout(false);
            this.plHuyNgauNhien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x040008DE RID: 2270
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040008DF RID: 2271
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040008E0 RID: 2272
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x040008E1 RID: 2273
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040008E2 RID: 2274
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x040008E3 RID: 2275
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x040008E4 RID: 2276
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x040008E5 RID: 2277
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040008E6 RID: 2278
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040008E7 RID: 2279
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040008E8 RID: 2280
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040008E9 RID: 2281
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040008EA RID: 2282
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040008EB RID: 2283
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040008EC RID: 2284
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040008ED RID: 2285
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040008EE RID: 2286
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040008EF RID: 2287
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x040008F0 RID: 2288
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x040008F1 RID: 2289
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040008F2 RID: 2290
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040008F3 RID: 2291
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040008F4 RID: 2292
		private global::System.Windows.Forms.RadioButton rbHuyTheoUid;

		// Token: 0x040008F5 RID: 2293
		private global::System.Windows.Forms.RadioButton rbHuyNgauNhien;

		// Token: 0x040008F6 RID: 2294
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040008F7 RID: 2295
		private global::System.Windows.Forms.Panel plHuyTheoUid;

		// Token: 0x040008F8 RID: 2296
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x040008F9 RID: 2297
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040008FA RID: 2298
		private global::System.Windows.Forms.RichTextBox txtUid;

		// Token: 0x040008FB RID: 2299
		private global::System.Windows.Forms.Panel plHuyNgauNhien;

		// Token: 0x040008FC RID: 2300
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040008FD RID: 2301
		private global::System.Windows.Forms.RichTextBox txtUidKhongHuyKetBan;

		// Token: 0x040008FE RID: 2302
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040008FF RID: 2303
		private global::System.Windows.Forms.Button button1;
	}
}
