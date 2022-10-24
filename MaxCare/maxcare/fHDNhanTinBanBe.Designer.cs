namespace maxcare
{
	// Token: 0x0200011A RID: 282
	public partial class fHDNhanTinBanBe : global::System.Windows.Forms.Form
	{
		// Token: 0x06000C4B RID: 3147 RVA: 0x001C0FCC File Offset: 0x001BF1CC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x001C102C File Offset: 0x001BF22C
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.plUidChiDinh = new System.Windows.Forms.Panel();
            this.txtUidChiDinh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStatusUid = new System.Windows.Forms.Label();
            this.rbUidChiDinh = new System.Windows.Forms.RadioButton();
            this.rbTrucTuyen = new System.Windows.Forms.RadioButton();
            this.rbNgauNhien = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTinNhan = new System.Windows.Forms.TextBox();
            this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.txtTenHanhDong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.plUidChiDinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(720, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Nhắn tin bạn bè";
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
            this.pnlHeader.Size = new System.Drawing.Size(720, 31);
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
            this.button1.Location = new System.Drawing.Point(689, 1);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.plUidChiDinh);
            this.panel1.Controls.Add(this.rbUidChiDinh);
            this.panel1.Controls.Add(this.rbTrucTuyen);
            this.panel1.Controls.Add(this.rbNgauNhien);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtTinNhan);
            this.panel1.Controls.Add(this.nudDelayTo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.nudDelayFrom);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nudSoLuongTo);
            this.panel1.Controls.Add(this.nudSoLuongFrom);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 349);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(220, 268);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 21);
            this.linkLabel1.TabIndex = 189;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Random icon";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Help;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(304, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // plUidChiDinh
            // 
            this.plUidChiDinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plUidChiDinh.Controls.Add(this.txtUidChiDinh);
            this.plUidChiDinh.Controls.Add(this.label10);
            this.plUidChiDinh.Controls.Add(this.lblStatusUid);
            this.plUidChiDinh.Location = new System.Drawing.Point(375, 120);
            this.plUidChiDinh.Name = "plUidChiDinh";
            this.plUidChiDinh.Size = new System.Drawing.Size(281, 164);
            this.plUidChiDinh.TabIndex = 49;
            // 
            // txtUidChiDinh
            // 
            this.txtUidChiDinh.Location = new System.Drawing.Point(7, 27);
            this.txtUidChiDinh.Multiline = true;
            this.txtUidChiDinh.Name = "txtUidChiDinh";
            this.txtUidChiDinh.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUidChiDinh.Size = new System.Drawing.Size(266, 111);
            this.txtUidChiDinh.TabIndex = 1;
            this.txtUidChiDinh.WordWrap = false;
            this.txtUidChiDinh.TextChanged += new System.EventHandler(this.txtComment_TextChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "(Mỗi UID 1 dòng)";
            // 
            // lblStatusUid
            // 
            this.lblStatusUid.AutoSize = true;
            this.lblStatusUid.Location = new System.Drawing.Point(3, 5);
            this.lblStatusUid.Name = "lblStatusUid";
            this.lblStatusUid.Size = new System.Drawing.Size(156, 21);
            this.lblStatusUid.TabIndex = 0;
            this.lblStatusUid.Text = "Danh sách UID (0):";
            // 
            // rbUidChiDinh
            // 
            this.rbUidChiDinh.AutoSize = true;
            this.rbUidChiDinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbUidChiDinh.Location = new System.Drawing.Point(375, 94);
            this.rbUidChiDinh.Name = "rbUidChiDinh";
            this.rbUidChiDinh.Size = new System.Drawing.Size(123, 25);
            this.rbUidChiDinh.TabIndex = 48;
            this.rbUidChiDinh.Text = "UID chỉ định";
            this.rbUidChiDinh.UseVisualStyleBackColor = true;
            this.rbUidChiDinh.CheckedChanged += new System.EventHandler(this.rbUidChiDinh_CheckedChanged);
            // 
            // rbTrucTuyen
            // 
            this.rbTrucTuyen.AutoSize = true;
            this.rbTrucTuyen.Checked = true;
            this.rbTrucTuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTrucTuyen.Location = new System.Drawing.Point(479, 94);
            this.rbTrucTuyen.Name = "rbTrucTuyen";
            this.rbTrucTuyen.Size = new System.Drawing.Size(240, 25);
            this.rbTrucTuyen.TabIndex = 48;
            this.rbTrucTuyen.TabStop = true;
            this.rbTrucTuyen.Text = "Đang trực tuyến (Chưa làm)";
            this.rbTrucTuyen.UseVisualStyleBackColor = true;
            this.rbTrucTuyen.Visible = false;
            this.rbTrucTuyen.CheckedChanged += new System.EventHandler(this.rbNgauNhien_CheckedChanged);
            // 
            // rbNgauNhien
            // 
            this.rbNgauNhien.AutoSize = true;
            this.rbNgauNhien.Checked = true;
            this.rbNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNgauNhien.Location = new System.Drawing.Point(375, 71);
            this.rbNgauNhien.Name = "rbNgauNhien";
            this.rbNgauNhien.Size = new System.Drawing.Size(226, 25);
            this.rbNgauNhien.TabIndex = 48;
            this.rbNgauNhien.TabStop = true;
            this.rbNgauNhien.Text = "Ngẫu nhiên danh sách bạn";
            this.rbNgauNhien.UseVisualStyleBackColor = true;
            this.rbNgauNhien.CheckedChanged += new System.EventHandler(this.rbNgauNhien_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 21);
            this.label9.TabIndex = 47;
            this.label9.Text = "Tùy chọn đối tượng nhắn tin:";
            // 
            // txtTinNhan
            // 
            this.txtTinNhan.Location = new System.Drawing.Point(31, 158);
            this.txtTinNhan.Multiline = true;
            this.txtTinNhan.Name = "txtTinNhan";
            this.txtTinNhan.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTinNhan.Size = new System.Drawing.Size(295, 107);
            this.txtTinNhan.TabIndex = 5;
            this.txtTinNhan.WordWrap = false;
            this.txtTinNhan.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // nudDelayTo
            // 
            this.nudDelayTo.Location = new System.Drawing.Point(229, 111);
            this.nudDelayTo.Name = "nudDelayTo";
            this.nudDelayTo.Size = new System.Drawing.Size(56, 27);
            this.nudDelayTo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "(Spin nội dung {a|b|c})";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(27, 139);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(187, 21);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Danh sách tin nhắn (0):";
            // 
            // nudDelayFrom
            // 
            this.nudDelayFrom.Location = new System.Drawing.Point(132, 111);
            this.nudDelayFrom.Name = "nudDelayFrom";
            this.nudDelayFrom.Size = new System.Drawing.Size(56, 27);
            this.nudDelayFrom.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 21);
            this.label7.TabIndex = 46;
            this.label7.Text = "đến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "giây";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Thời gian chờ:";
            // 
            // nudSoLuongTo
            // 
            this.nudSoLuongTo.Location = new System.Drawing.Point(229, 80);
            this.nudSoLuongTo.Name = "nudSoLuongTo";
            this.nudSoLuongTo.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongTo.TabIndex = 2;
            // 
            // nudSoLuongFrom
            // 
            this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
            this.nudSoLuongFrom.Name = "nudSoLuongFrom";
            this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongFrom.TabIndex = 1;
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(194, 27);
            this.txtTenHanhDong.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "bạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Số lượng bạn:";
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
            this.btnCancel.Location = new System.Drawing.Point(353, 305);
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
            this.btnAdd.Location = new System.Drawing.Point(246, 305);
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
            this.bunifuCards1.Size = new System.Drawing.Size(720, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDNhanTinBanBe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 349);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDNhanTinBanBe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plUidChiDinh.ResumeLayout(false);
            this.plUidChiDinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04001404 RID: 5124
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04001405 RID: 5125
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04001406 RID: 5126
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04001407 RID: 5127
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04001408 RID: 5128
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x04001409 RID: 5129
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x0400140A RID: 5130
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x0400140B RID: 5131
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400140C RID: 5132
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400140D RID: 5133
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400140E RID: 5134
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400140F RID: 5135
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04001410 RID: 5136
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04001411 RID: 5137
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04001412 RID: 5138
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04001413 RID: 5139
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04001414 RID: 5140
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04001415 RID: 5141
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04001416 RID: 5142
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04001417 RID: 5143
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04001418 RID: 5144
		private global::System.Windows.Forms.TextBox txtTinNhan;

		// Token: 0x04001419 RID: 5145
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x0400141A RID: 5146
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x0400141B RID: 5147
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400141C RID: 5148
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400141D RID: 5149
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400141E RID: 5150
		private global::System.Windows.Forms.RadioButton rbUidChiDinh;

		// Token: 0x0400141F RID: 5151
		private global::System.Windows.Forms.RadioButton rbNgauNhien;

		// Token: 0x04001420 RID: 5152
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04001421 RID: 5153
		private global::System.Windows.Forms.Panel plUidChiDinh;

		// Token: 0x04001422 RID: 5154
		private global::System.Windows.Forms.TextBox txtUidChiDinh;

		// Token: 0x04001423 RID: 5155
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04001424 RID: 5156
		private global::System.Windows.Forms.Label lblStatusUid;

		// Token: 0x04001425 RID: 5157
		private global::System.Windows.Forms.RadioButton rbTrucTuyen;

		// Token: 0x04001426 RID: 5158
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04001427 RID: 5159
		private global::System.Windows.Forms.LinkLabel linkLabel1;
	}
}
