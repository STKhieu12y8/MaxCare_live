namespace maxcare
{
	// Token: 0x020000C3 RID: 195
	public partial class fHDShareBai : global::System.Windows.Forms.Form
	{
		// Token: 0x060007D2 RID: 2002 RVA: 0x000DD988 File Offset: 0x000DBB88
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x000DD9E8 File Offset: 0x000DBBE8
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
            this.rbShareVip = new System.Windows.Forms.RadioButton();
            this.rbShareThuong = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbKhongPhaiLinkFacebook = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLinkChiaSe = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.plDangBaiLenPage = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.nudCountPageTo = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.nudCountPageFrom = new System.Windows.Forms.NumericUpDown();
            this.plDangBaiLenNhom = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ckbKhongShareTrung = new System.Windows.Forms.CheckBox();
            this.ckbUuTienNhomNhieuThanhVien = new System.Windows.Forms.CheckBox();
            this.ckbOnlyShareNhomKhongKiemDuyet = new System.Windows.Forms.CheckBox();
            this.ckbCauHinhNangCao = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.rbTuNhap = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.plInteractGroup = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.nudTuongTacTo = new System.Windows.Forms.NumericUpDown();
            this.nudTuongTacDelayTo = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudTuongTacFrom = new System.Windows.Forms.NumericUpDown();
            this.label52 = new System.Windows.Forms.Label();
            this.ckbTuongTacComment = new System.Windows.Forms.CheckBox();
            this.nudTuongTacDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.label51 = new System.Windows.Forms.Label();
            this.ckbTuongTacLike = new System.Windows.Forms.CheckBox();
            this.label50 = new System.Windows.Forms.Label();
            this.ckbTuongTac = new System.Windows.Forms.CheckBox();
            this.nudCountGroupTo = new System.Windows.Forms.NumericUpDown();
            this.nudCountGroupFrom = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.ckbShareBaiLenPage = new System.Windows.Forms.CheckBox();
            this.ckbShareBaiLenNhom = new System.Windows.Forms.CheckBox();
            this.ckbShareBaiLenTuong = new System.Windows.Forms.CheckBox();
            this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
            this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.plVanBan = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
            this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDown = new MetroFramework.Controls.MetroButton();
            this.btnUp = new MetroFramework.Controls.MetroButton();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ckbVanBan = new System.Windows.Forms.CheckBox();
            this.txtTenHanhDong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.plDangBaiLenPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountPageTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountPageFrom)).BeginInit();
            this.plDangBaiLenNhom.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.plInteractGroup.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountGroupTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountGroupFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).BeginInit();
            this.plVanBan.SuspendLayout();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(1097, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Share bài";
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
            this.pnlHeader.Size = new System.Drawing.Size(1097, 31);
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
            this.button1.Location = new System.Drawing.Point(1066, 1);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbShareVip);
            this.panel1.Controls.Add(this.rbShareThuong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ckbKhongPhaiLinkFacebook);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLinkChiaSe);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.nudDelayTo);
            this.panel1.Controls.Add(this.nudDelayFrom);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.plVanBan);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.ckbVanBan);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 612);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rbShareVip
            // 
            this.rbShareVip.AutoSize = true;
            this.rbShareVip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbShareVip.Location = new System.Drawing.Point(203, 237);
            this.rbShareVip.Name = "rbShareVip";
            this.rbShareVip.Size = new System.Drawing.Size(101, 25);
            this.rbShareVip.TabIndex = 68;
            this.rbShareVip.TabStop = true;
            this.rbShareVip.Text = "Share Vip";
            this.rbShareVip.UseVisualStyleBackColor = true;
            this.rbShareVip.CheckedChanged += new System.EventHandler(this.rbShareVip_CheckedChanged);
            // 
            // rbShareThuong
            // 
            this.rbShareThuong.AutoSize = true;
            this.rbShareThuong.Checked = true;
            this.rbShareThuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbShareThuong.Location = new System.Drawing.Point(90, 237);
            this.rbShareThuong.Name = "rbShareThuong";
            this.rbShareThuong.Size = new System.Drawing.Size(130, 25);
            this.rbShareThuong.TabIndex = 67;
            this.rbShareThuong.TabStop = true;
            this.rbShareThuong.Text = "Share thường";
            this.rbShareThuong.UseVisualStyleBackColor = true;
            this.rbShareThuong.CheckedChanged += new System.EventHandler(this.rbShareThuong_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 66;
            this.label3.Text = "Kiểu share:";
            // 
            // ckbKhongPhaiLinkFacebook
            // 
            this.ckbKhongPhaiLinkFacebook.AutoSize = true;
            this.ckbKhongPhaiLinkFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbKhongPhaiLinkFacebook.Location = new System.Drawing.Point(14, 270);
            this.ckbKhongPhaiLinkFacebook.Name = "ckbKhongPhaiLinkFacebook";
            this.ckbKhongPhaiLinkFacebook.Size = new System.Drawing.Size(340, 25);
            this.ckbKhongPhaiLinkFacebook.TabIndex = 65;
            this.ckbKhongPhaiLinkFacebook.Text = "Link cần chia sẻ không phải của Facebook";
            this.ckbKhongPhaiLinkFacebook.UseVisualStyleBackColor = true;
            this.ckbKhongPhaiLinkFacebook.CheckedChanged += new System.EventHandler(this.ckbKhongPhaiLinkFacebook_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 21);
            this.label2.TabIndex = 64;
            this.label2.Text = "Link bài cần share (0):";
            // 
            // txtLinkChiaSe
            // 
            this.txtLinkChiaSe.Location = new System.Drawing.Point(14, 136);
            this.txtLinkChiaSe.Multiline = true;
            this.txtLinkChiaSe.Name = "txtLinkChiaSe";
            this.txtLinkChiaSe.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLinkChiaSe.Size = new System.Drawing.Size(378, 98);
            this.txtLinkChiaSe.TabIndex = 63;
            this.txtLinkChiaSe.WordWrap = false;
            this.txtLinkChiaSe.TextChanged += new System.EventHandler(this.txtLinkChiaSe_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.plDangBaiLenPage);
            this.groupBox2.Controls.Add(this.plDangBaiLenNhom);
            this.groupBox2.Controls.Add(this.ckbShareBaiLenPage);
            this.groupBox2.Controls.Add(this.ckbShareBaiLenNhom);
            this.groupBox2.Controls.Add(this.ckbShareBaiLenTuong);
            this.groupBox2.Location = new System.Drawing.Point(407, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 459);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy chọn share";
            // 
            // plDangBaiLenPage
            // 
            this.plDangBaiLenPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.plDangBaiLenPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plDangBaiLenPage.Controls.Add(this.label21);
            this.plDangBaiLenPage.Controls.Add(this.label22);
            this.plDangBaiLenPage.Controls.Add(this.nudCountPageTo);
            this.plDangBaiLenPage.Controls.Add(this.label23);
            this.plDangBaiLenPage.Controls.Add(this.nudCountPageFrom);
            this.plDangBaiLenPage.Location = new System.Drawing.Point(35, 427);
            this.plDangBaiLenPage.Name = "plDangBaiLenPage";
            this.plDangBaiLenPage.Size = new System.Drawing.Size(310, 27);
            this.plDangBaiLenPage.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 21);
            this.label21.TabIndex = 49;
            this.label21.Text = "Số lượng page:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(264, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 21);
            this.label22.TabIndex = 50;
            this.label22.Text = "page";
            // 
            // nudCountPageTo
            // 
            this.nudCountPageTo.Location = new System.Drawing.Point(205, 1);
            this.nudCountPageTo.Name = "nudCountPageTo";
            this.nudCountPageTo.Size = new System.Drawing.Size(56, 27);
            this.nudCountPageTo.TabIndex = 48;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(170, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 21);
            this.label23.TabIndex = 51;
            this.label23.Text = "đến";
            // 
            // nudCountPageFrom
            // 
            this.nudCountPageFrom.Location = new System.Drawing.Point(108, 1);
            this.nudCountPageFrom.Name = "nudCountPageFrom";
            this.nudCountPageFrom.Size = new System.Drawing.Size(56, 27);
            this.nudCountPageFrom.TabIndex = 47;
            // 
            // plDangBaiLenNhom
            // 
            this.plDangBaiLenNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plDangBaiLenNhom.Controls.Add(this.panel4);
            this.plDangBaiLenNhom.Controls.Add(this.ckbCauHinhNangCao);
            this.plDangBaiLenNhom.Controls.Add(this.panel3);
            this.plDangBaiLenNhom.Controls.Add(this.label11);
            this.plDangBaiLenNhom.Controls.Add(this.plInteractGroup);
            this.plDangBaiLenNhom.Controls.Add(this.ckbTuongTac);
            this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupTo);
            this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupFrom);
            this.plDangBaiLenNhom.Controls.Add(this.label24);
            this.plDangBaiLenNhom.Controls.Add(this.label25);
            this.plDangBaiLenNhom.Controls.Add(this.label26);
            this.plDangBaiLenNhom.Location = new System.Drawing.Point(33, 72);
            this.plDangBaiLenNhom.Name = "plDangBaiLenNhom";
            this.plDangBaiLenNhom.Size = new System.Drawing.Size(637, 323);
            this.plDangBaiLenNhom.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ckbKhongShareTrung);
            this.panel4.Controls.Add(this.ckbUuTienNhomNhieuThanhVien);
            this.panel4.Controls.Add(this.ckbOnlyShareNhomKhongKiemDuyet);
            this.panel4.Location = new System.Drawing.Point(19, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 78);
            this.panel4.TabIndex = 69;
            // 
            // ckbKhongShareTrung
            // 
            this.ckbKhongShareTrung.AutoSize = true;
            this.ckbKhongShareTrung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbKhongShareTrung.Location = new System.Drawing.Point(3, 55);
            this.ckbKhongShareTrung.Name = "ckbKhongShareTrung";
            this.ckbKhongShareTrung.Size = new System.Drawing.Size(214, 25);
            this.ckbKhongShareTrung.TabIndex = 2;
            this.ckbKhongShareTrung.Text = "Không share trùng nhóm";
            this.ckbKhongShareTrung.UseVisualStyleBackColor = true;
            // 
            // ckbUuTienNhomNhieuThanhVien
            // 
            this.ckbUuTienNhomNhieuThanhVien.AutoSize = true;
            this.ckbUuTienNhomNhieuThanhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbUuTienNhomNhieuThanhVien.Location = new System.Drawing.Point(3, 29);
            this.ckbUuTienNhomNhieuThanhVien.Name = "ckbUuTienNhomNhieuThanhVien";
            this.ckbUuTienNhomNhieuThanhVien.Size = new System.Drawing.Size(327, 25);
            this.ckbUuTienNhomNhieuThanhVien.TabIndex = 1;
            this.ckbUuTienNhomNhieuThanhVien.Text = "Ưu tiên share nhóm có nhiều thành viên";
            this.ckbUuTienNhomNhieuThanhVien.UseVisualStyleBackColor = true;
            // 
            // ckbOnlyShareNhomKhongKiemDuyet
            // 
            this.ckbOnlyShareNhomKhongKiemDuyet.AutoSize = true;
            this.ckbOnlyShareNhomKhongKiemDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbOnlyShareNhomKhongKiemDuyet.Location = new System.Drawing.Point(3, 3);
            this.ckbOnlyShareNhomKhongKiemDuyet.Name = "ckbOnlyShareNhomKhongKiemDuyet";
            this.ckbOnlyShareNhomKhongKiemDuyet.Size = new System.Drawing.Size(282, 25);
            this.ckbOnlyShareNhomKhongKiemDuyet.TabIndex = 0;
            this.ckbOnlyShareNhomKhongKiemDuyet.Text = "Chỉ share nhóm không kiểm duyệt";
            this.ckbOnlyShareNhomKhongKiemDuyet.UseVisualStyleBackColor = true;
            // 
            // ckbCauHinhNangCao
            // 
            this.ckbCauHinhNangCao.AutoSize = true;
            this.ckbCauHinhNangCao.Location = new System.Drawing.Point(6, 115);
            this.ckbCauHinhNangCao.Name = "ckbCauHinhNangCao";
            this.ckbCauHinhNangCao.Size = new System.Drawing.Size(168, 25);
            this.ckbCauHinhNangCao.TabIndex = 68;
            this.ckbCauHinhNangCao.Text = "Cấu hình nâng cao";
            this.ckbCauHinhNangCao.UseVisualStyleBackColor = true;
            this.ckbCauHinhNangCao.CheckedChanged += new System.EventHandler(this.ckbCauHinhNangCao_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.rbTuNhap);
            this.panel3.Controls.Add(this.rbRandom);
            this.panel3.Location = new System.Drawing.Point(19, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 54);
            this.panel3.TabIndex = 67;
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Location = new System.Drawing.Point(207, 27);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Nhập";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // rbTuNhap
            // 
            this.rbTuNhap.AutoSize = true;
            this.rbTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTuNhap.Location = new System.Drawing.Point(3, 29);
            this.rbTuNhap.Name = "rbTuNhap";
            this.rbTuNhap.Size = new System.Drawing.Size(225, 25);
            this.rbTuNhap.TabIndex = 1;
            this.rbTuNhap.Text = "Nhóm do người dùng nhập";
            this.rbTuNhap.UseVisualStyleBackColor = true;
            this.rbTuNhap.CheckedChanged += new System.EventHandler(this.rbTuNhap_CheckedChanged);
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Checked = true;
            this.rbRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbRandom.Location = new System.Drawing.Point(3, 3);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(254, 25);
            this.rbRandom.TabIndex = 0;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "Ngẫu nhiên nhóm đã tham gia";
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 21);
            this.label11.TabIndex = 66;
            this.label11.Text = "Tùy chọn nhóm để share:";
            // 
            // plInteractGroup
            // 
            this.plInteractGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plInteractGroup.Controls.Add(this.panel2);
            this.plInteractGroup.Controls.Add(this.label5);
            this.plInteractGroup.Controls.Add(this.label6);
            this.plInteractGroup.Controls.Add(this.label53);
            this.plInteractGroup.Controls.Add(this.nudTuongTacTo);
            this.plInteractGroup.Controls.Add(this.nudTuongTacDelayTo);
            this.plInteractGroup.Controls.Add(this.label7);
            this.plInteractGroup.Controls.Add(this.nudTuongTacFrom);
            this.plInteractGroup.Controls.Add(this.label52);
            this.plInteractGroup.Controls.Add(this.ckbTuongTacComment);
            this.plInteractGroup.Controls.Add(this.nudTuongTacDelayFrom);
            this.plInteractGroup.Controls.Add(this.label51);
            this.plInteractGroup.Controls.Add(this.ckbTuongTacLike);
            this.plInteractGroup.Controls.Add(this.label50);
            this.plInteractGroup.Location = new System.Drawing.Point(338, 26);
            this.plInteractGroup.Name = "plInteractGroup";
            this.plInteractGroup.Size = new System.Drawing.Size(290, 280);
            this.plInteractGroup.TabIndex = 65;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtComment);
            this.panel2.Controls.Add(this.lblComment);
            this.panel2.Location = new System.Drawing.Point(8, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 168);
            this.panel2.TabIndex = 104;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Help;
            this.button7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(244, 144);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(23, 23);
            this.button7.TabIndex = 192;
            this.button7.Text = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Location = new System.Drawing.Point(164, 147);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(106, 21);
            this.linkLabel2.TabIndex = 191;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Random icon";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Help;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(230, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 23);
            this.button4.TabIndex = 44;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Help;
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(230, 166);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 23);
            this.button5.TabIndex = 45;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(71, 189);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(204, 25);
            this.radioButton1.TabIndex = 42;
            this.radioButton1.Text = "Nội dung có nhiều dòng";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Location = new System.Drawing.Point(71, 168);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(199, 25);
            this.radioButton2.TabIndex = 43;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nội dung chỉ có 1 dòng";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tùy chọn:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 21);
            this.label10.TabIndex = 40;
            this.label10.Text = "(Spin nội dung {a|b|c})";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.Location = new System.Drawing.Point(7, 26);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(260, 119);
            this.txtComment.TabIndex = 34;
            this.txtComment.Text = "";
            this.txtComment.WordWrap = false;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(3, 5);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(196, 21);
            this.lblComment.TabIndex = 0;
            this.lblComment.Text = "Danh sách comment (0):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 21);
            this.label5.TabIndex = 99;
            this.label5.Text = "Số bài viết/nhóm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(160, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 21);
            this.label6.TabIndex = 103;
            this.label6.Text = "đến";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label53.Location = new System.Drawing.Point(160, 33);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(38, 21);
            this.label53.TabIndex = 103;
            this.label53.Text = "đến";
            // 
            // nudTuongTacTo
            // 
            this.nudTuongTacTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacTo.Location = new System.Drawing.Point(190, 4);
            this.nudTuongTacTo.Name = "nudTuongTacTo";
            this.nudTuongTacTo.Size = new System.Drawing.Size(47, 27);
            this.nudTuongTacTo.TabIndex = 94;
            // 
            // nudTuongTacDelayTo
            // 
            this.nudTuongTacDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacDelayTo.Location = new System.Drawing.Point(190, 30);
            this.nudTuongTacDelayTo.Name = "nudTuongTacDelayTo";
            this.nudTuongTacDelayTo.Size = new System.Drawing.Size(47, 27);
            this.nudTuongTacDelayTo.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(240, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 21);
            this.label7.TabIndex = 102;
            this.label7.Text = "bài";
            // 
            // nudTuongTacFrom
            // 
            this.nudTuongTacFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacFrom.Location = new System.Drawing.Point(113, 3);
            this.nudTuongTacFrom.Name = "nudTuongTacFrom";
            this.nudTuongTacFrom.Size = new System.Drawing.Size(42, 27);
            this.nudTuongTacFrom.TabIndex = 92;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label52.Location = new System.Drawing.Point(240, 32);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(40, 21);
            this.label52.TabIndex = 102;
            this.label52.Text = "giây";
            // 
            // ckbTuongTacComment
            // 
            this.ckbTuongTacComment.AutoSize = true;
            this.ckbTuongTacComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacComment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacComment.Location = new System.Drawing.Point(113, 79);
            this.ckbTuongTacComment.Name = "ckbTuongTacComment";
            this.ckbTuongTacComment.Size = new System.Drawing.Size(103, 25);
            this.ckbTuongTacComment.TabIndex = 96;
            this.ckbTuongTacComment.Text = "Comment";
            this.ckbTuongTacComment.UseVisualStyleBackColor = true;
            this.ckbTuongTacComment.CheckedChanged += new System.EventHandler(this.ckbTuongTacComment_CheckedChanged);
            // 
            // nudTuongTacDelayFrom
            // 
            this.nudTuongTacDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacDelayFrom.Location = new System.Drawing.Point(113, 30);
            this.nudTuongTacDelayFrom.Name = "nudTuongTacDelayFrom";
            this.nudTuongTacDelayFrom.Size = new System.Drawing.Size(42, 27);
            this.nudTuongTacDelayFrom.TabIndex = 93;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label51.Location = new System.Drawing.Point(3, 33);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(128, 21);
            this.label51.TabIndex = 101;
            this.label51.Text = "Thời gian delay:";
            // 
            // ckbTuongTacLike
            // 
            this.ckbTuongTacLike.AutoSize = true;
            this.ckbTuongTacLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacLike.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacLike.Location = new System.Drawing.Point(113, 58);
            this.ckbTuongTacLike.Name = "ckbTuongTacLike";
            this.ckbTuongTacLike.Size = new System.Drawing.Size(61, 25);
            this.ckbTuongTacLike.TabIndex = 95;
            this.ckbTuongTacLike.Text = "Like";
            this.ckbTuongTacLike.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label50.Location = new System.Drawing.Point(3, 59);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(122, 21);
            this.label50.TabIndex = 100;
            this.label50.Text = "Loại tương tác:";
            // 
            // ckbTuongTac
            // 
            this.ckbTuongTac.AutoSize = true;
            this.ckbTuongTac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTac.Location = new System.Drawing.Point(316, 3);
            this.ckbTuongTac.Name = "ckbTuongTac";
            this.ckbTuongTac.Size = new System.Drawing.Size(269, 25);
            this.ckbTuongTac.TabIndex = 57;
            this.ckbTuongTac.Text = "Tương tác nhóm trước khi share";
            this.ckbTuongTac.UseVisualStyleBackColor = true;
            this.ckbTuongTac.CheckedChanged += new System.EventHandler(this.ckbTuongTac_CheckedChanged);
            // 
            // nudCountGroupTo
            // 
            this.nudCountGroupTo.Location = new System.Drawing.Point(205, 3);
            this.nudCountGroupTo.Name = "nudCountGroupTo";
            this.nudCountGroupTo.Size = new System.Drawing.Size(56, 27);
            this.nudCountGroupTo.TabIndex = 53;
            // 
            // nudCountGroupFrom
            // 
            this.nudCountGroupFrom.Location = new System.Drawing.Point(108, 3);
            this.nudCountGroupFrom.Name = "nudCountGroupFrom";
            this.nudCountGroupFrom.Size = new System.Drawing.Size(56, 27);
            this.nudCountGroupFrom.TabIndex = 52;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(170, 5);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 21);
            this.label24.TabIndex = 56;
            this.label24.Text = "đến";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(264, 5);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(51, 21);
            this.label25.TabIndex = 55;
            this.label25.Text = "nhóm";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 5);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(126, 21);
            this.label26.TabIndex = 54;
            this.label26.Text = "Số lượng nhóm:";
            // 
            // ckbShareBaiLenPage
            // 
            this.ckbShareBaiLenPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbShareBaiLenPage.AutoSize = true;
            this.ckbShareBaiLenPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbShareBaiLenPage.Location = new System.Drawing.Point(10, 396);
            this.ckbShareBaiLenPage.Name = "ckbShareBaiLenPage";
            this.ckbShareBaiLenPage.Size = new System.Drawing.Size(169, 25);
            this.ckbShareBaiLenPage.TabIndex = 0;
            this.ckbShareBaiLenPage.Text = "Share bài lên page";
            this.ckbShareBaiLenPage.UseVisualStyleBackColor = true;
            this.ckbShareBaiLenPage.CheckedChanged += new System.EventHandler(this.ckbDangBaiLenPage_CheckedChanged);
            // 
            // ckbShareBaiLenNhom
            // 
            this.ckbShareBaiLenNhom.AutoSize = true;
            this.ckbShareBaiLenNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbShareBaiLenNhom.Location = new System.Drawing.Point(10, 48);
            this.ckbShareBaiLenNhom.Name = "ckbShareBaiLenNhom";
            this.ckbShareBaiLenNhom.Size = new System.Drawing.Size(174, 25);
            this.ckbShareBaiLenNhom.TabIndex = 0;
            this.ckbShareBaiLenNhom.Text = "Share bài lên nhóm";
            this.ckbShareBaiLenNhom.UseVisualStyleBackColor = true;
            this.ckbShareBaiLenNhom.CheckedChanged += new System.EventHandler(this.ckbDangBaiLenNhom_CheckedChanged);
            // 
            // ckbShareBaiLenTuong
            // 
            this.ckbShareBaiLenTuong.AutoSize = true;
            this.ckbShareBaiLenTuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbShareBaiLenTuong.Location = new System.Drawing.Point(10, 22);
            this.ckbShareBaiLenTuong.Name = "ckbShareBaiLenTuong";
            this.ckbShareBaiLenTuong.Size = new System.Drawing.Size(176, 25);
            this.ckbShareBaiLenTuong.TabIndex = 0;
            this.ckbShareBaiLenTuong.Text = "Share bài lên tường";
            this.ckbShareBaiLenTuong.UseVisualStyleBackColor = true;
            this.ckbShareBaiLenTuong.CheckedChanged += new System.EventHandler(this.ckbShareBaiLenTuong_CheckedChanged);
            // 
            // nudDelayTo
            // 
            this.nudDelayTo.Location = new System.Drawing.Point(235, 79);
            this.nudDelayTo.Name = "nudDelayTo";
            this.nudDelayTo.Size = new System.Drawing.Size(56, 27);
            this.nudDelayTo.TabIndex = 58;
            // 
            // nudDelayFrom
            // 
            this.nudDelayFrom.Location = new System.Drawing.Point(138, 79);
            this.nudDelayFrom.Name = "nudDelayFrom";
            this.nudDelayFrom.Size = new System.Drawing.Size(56, 27);
            this.nudDelayFrom.TabIndex = 57;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(200, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 21);
            this.label20.TabIndex = 61;
            this.label20.Text = "đến";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(294, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 21);
            this.label19.TabIndex = 60;
            this.label19.Text = "giây";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 21);
            this.label15.TabIndex = 59;
            this.label15.Text = "Khoảng cách share:";
            // 
            // plVanBan
            // 
            this.plVanBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plVanBan.Controls.Add(this.button6);
            this.plVanBan.Controls.Add(this.linkLabel1);
            this.plVanBan.Controls.Add(this.button3);
            this.plVanBan.Controls.Add(this.button2);
            this.plVanBan.Controls.Add(this.rbNganCachKyTu);
            this.plVanBan.Controls.Add(this.rbNganCachMoiDong);
            this.plVanBan.Controls.Add(this.label9);
            this.plVanBan.Controls.Add(this.label8);
            this.plVanBan.Controls.Add(this.btnDown);
            this.plVanBan.Controls.Add(this.btnUp);
            this.plVanBan.Controls.Add(this.txtNoiDung);
            this.plVanBan.Controls.Add(this.lblStatus);
            this.plVanBan.Location = new System.Drawing.Point(33, 324);
            this.plVanBan.Name = "plVanBan";
            this.plVanBan.Size = new System.Drawing.Size(359, 169);
            this.plVanBan.TabIndex = 33;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Help;
            this.button6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(328, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 23);
            this.button6.TabIndex = 191;
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(245, 148);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 21);
            this.linkLabel1.TabIndex = 190;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Random icon";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Help;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(230, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 44;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Help;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(230, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbNganCachKyTu
            // 
            this.rbNganCachKyTu.AutoSize = true;
            this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachKyTu.Location = new System.Drawing.Point(71, 189);
            this.rbNganCachKyTu.Name = "rbNganCachKyTu";
            this.rbNganCachKyTu.Size = new System.Drawing.Size(204, 25);
            this.rbNganCachKyTu.TabIndex = 42;
            this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
            this.rbNganCachKyTu.UseVisualStyleBackColor = true;
            this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(this.rbNganCachKyTu_CheckedChanged_1);
            // 
            // rbNganCachMoiDong
            // 
            this.rbNganCachMoiDong.AutoSize = true;
            this.rbNganCachMoiDong.Checked = true;
            this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachMoiDong.Location = new System.Drawing.Point(71, 168);
            this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
            this.rbNganCachMoiDong.Size = new System.Drawing.Size(199, 25);
            this.rbNganCachMoiDong.TabIndex = 43;
            this.rbNganCachMoiDong.TabStop = true;
            this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
            this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
            this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(this.rbNganCachMoiDong_CheckedChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 41;
            this.label9.Text = "Tùy chọn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "(Spin nội dung {a|b|c})";
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.Location = new System.Drawing.Point(302, -1);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(25, 25);
            this.btnDown.TabIndex = 38;
            this.btnDown.UseSelectable = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Location = new System.Drawing.Point(333, -1);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(25, 25);
            this.btnUp.TabIndex = 39;
            this.btnUp.UseSelectable = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiDung.Location = new System.Drawing.Point(7, 26);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(344, 119);
            this.txtNoiDung.TabIndex = 34;
            this.txtNoiDung.Text = "";
            this.txtNoiDung.WordWrap = false;
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(190, 21);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Danh sách nội dung (0):";
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
            this.btnAdd.Location = new System.Drawing.Point(453, 570);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ckbVanBan
            // 
            this.ckbVanBan.AutoSize = true;
            this.ckbVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbVanBan.Location = new System.Drawing.Point(14, 296);
            this.ckbVanBan.Name = "ckbVanBan";
            this.ckbVanBan.Size = new System.Drawing.Size(143, 25);
            this.ckbVanBan.TabIndex = 32;
            this.ckbVanBan.Text = "Nội dung share";
            this.ckbVanBan.UseVisualStyleBackColor = true;
            this.ckbVanBan.CheckedChanged += new System.EventHandler(this.ckbVanBan_CheckedChanged);
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(138, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(193, 27);
            this.txtTenHanhDong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 52);
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
            this.btnCancel.Location = new System.Drawing.Point(563, 570);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.bunifuCards1.Size = new System.Drawing.Size(1097, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDShareBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 612);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDShareBai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.plDangBaiLenPage.ResumeLayout(false);
            this.plDangBaiLenPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountPageTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountPageFrom)).EndInit();
            this.plDangBaiLenNhom.ResumeLayout(false);
            this.plDangBaiLenNhom.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.plInteractGroup.ResumeLayout(false);
            this.plInteractGroup.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountGroupTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountGroupFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            this.plVanBan.ResumeLayout(false);
            this.plVanBan.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x0400099A RID: 2458
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400099B RID: 2459
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400099C RID: 2460
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x0400099D RID: 2461
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400099E RID: 2462
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x0400099F RID: 2463
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040009A0 RID: 2464
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040009A1 RID: 2465
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040009A2 RID: 2466
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040009A3 RID: 2467
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040009A4 RID: 2468
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040009A5 RID: 2469
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040009A6 RID: 2470
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040009A7 RID: 2471
		private global::System.Windows.Forms.CheckBox ckbVanBan;

		// Token: 0x040009A8 RID: 2472
		private global::System.Windows.Forms.Panel plVanBan;

		// Token: 0x040009A9 RID: 2473
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x040009AA RID: 2474
		private global::System.Windows.Forms.RichTextBox txtNoiDung;

		// Token: 0x040009AB RID: 2475
		private global::MetroFramework.Controls.MetroButton btnDown;

		// Token: 0x040009AC RID: 2476
		private global::MetroFramework.Controls.MetroButton btnUp;

		// Token: 0x040009AD RID: 2477
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x040009AE RID: 2478
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x040009AF RID: 2479
		private global::System.Windows.Forms.Label label20;

		// Token: 0x040009B0 RID: 2480
		private global::System.Windows.Forms.Label label19;

		// Token: 0x040009B1 RID: 2481
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040009B2 RID: 2482
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040009B3 RID: 2483
		private global::System.Windows.Forms.Panel plDangBaiLenPage;

		// Token: 0x040009B4 RID: 2484
		private global::System.Windows.Forms.Label label21;

		// Token: 0x040009B5 RID: 2485
		private global::System.Windows.Forms.Label label22;

		// Token: 0x040009B6 RID: 2486
		private global::System.Windows.Forms.NumericUpDown nudCountPageTo;

		// Token: 0x040009B7 RID: 2487
		private global::System.Windows.Forms.Label label23;

		// Token: 0x040009B8 RID: 2488
		private global::System.Windows.Forms.NumericUpDown nudCountPageFrom;

		// Token: 0x040009B9 RID: 2489
		private global::System.Windows.Forms.Panel plDangBaiLenNhom;

		// Token: 0x040009BA RID: 2490
		private global::System.Windows.Forms.NumericUpDown nudCountGroupTo;

		// Token: 0x040009BB RID: 2491
		private global::System.Windows.Forms.NumericUpDown nudCountGroupFrom;

		// Token: 0x040009BC RID: 2492
		private global::System.Windows.Forms.Label label24;

		// Token: 0x040009BD RID: 2493
		private global::System.Windows.Forms.Label label25;

		// Token: 0x040009BE RID: 2494
		private global::System.Windows.Forms.Label label26;

		// Token: 0x040009BF RID: 2495
		private global::System.Windows.Forms.CheckBox ckbShareBaiLenPage;

		// Token: 0x040009C0 RID: 2496
		private global::System.Windows.Forms.CheckBox ckbShareBaiLenNhom;

		// Token: 0x040009C1 RID: 2497
		private global::System.Windows.Forms.CheckBox ckbShareBaiLenTuong;

		// Token: 0x040009C2 RID: 2498
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040009C3 RID: 2499
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040009C4 RID: 2500
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x040009C5 RID: 2501
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x040009C6 RID: 2502
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040009C7 RID: 2503
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040009C8 RID: 2504
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040009C9 RID: 2505
		private global::System.Windows.Forms.TextBox txtLinkChiaSe;

		// Token: 0x040009CA RID: 2506
		private global::System.Windows.Forms.CheckBox ckbOnlyShareNhomKhongKiemDuyet;

		// Token: 0x040009CB RID: 2507
		private global::System.Windows.Forms.CheckBox ckbKhongPhaiLinkFacebook;

		// Token: 0x040009CC RID: 2508
		private global::System.Windows.Forms.RadioButton rbShareVip;

		// Token: 0x040009CD RID: 2509
		private global::System.Windows.Forms.RadioButton rbShareThuong;

		// Token: 0x040009CE RID: 2510
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040009CF RID: 2511
		private global::System.Windows.Forms.Panel plInteractGroup;

		// Token: 0x040009D0 RID: 2512
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040009D1 RID: 2513
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040009D2 RID: 2514
		private global::System.Windows.Forms.Label label53;

		// Token: 0x040009D3 RID: 2515
		private global::System.Windows.Forms.NumericUpDown nudTuongTacTo;

		// Token: 0x040009D4 RID: 2516
		private global::System.Windows.Forms.NumericUpDown nudTuongTacDelayTo;

		// Token: 0x040009D5 RID: 2517
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040009D6 RID: 2518
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFrom;

		// Token: 0x040009D7 RID: 2519
		private global::System.Windows.Forms.Label label52;

		// Token: 0x040009D8 RID: 2520
		private global::System.Windows.Forms.CheckBox ckbTuongTacComment;

		// Token: 0x040009D9 RID: 2521
		private global::System.Windows.Forms.NumericUpDown nudTuongTacDelayFrom;

		// Token: 0x040009DA RID: 2522
		private global::System.Windows.Forms.Label label51;

		// Token: 0x040009DB RID: 2523
		private global::System.Windows.Forms.CheckBox ckbTuongTacLike;

		// Token: 0x040009DC RID: 2524
		private global::System.Windows.Forms.Label label50;

		// Token: 0x040009DD RID: 2525
		private global::System.Windows.Forms.CheckBox ckbTuongTac;

		// Token: 0x040009DE RID: 2526
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x040009DF RID: 2527
		private global::System.Windows.Forms.Button button4;

		// Token: 0x040009E0 RID: 2528
		private global::System.Windows.Forms.Button button5;

		// Token: 0x040009E1 RID: 2529
		private global::System.Windows.Forms.RadioButton radioButton1;

		// Token: 0x040009E2 RID: 2530
		private global::System.Windows.Forms.RadioButton radioButton2;

		// Token: 0x040009E3 RID: 2531
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040009E4 RID: 2532
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040009E5 RID: 2533
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x040009E6 RID: 2534
		private global::System.Windows.Forms.Label lblComment;

		// Token: 0x040009E7 RID: 2535
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x040009E8 RID: 2536
		private global::System.Windows.Forms.Button button6;

		// Token: 0x040009E9 RID: 2537
		private global::System.Windows.Forms.Button button7;

		// Token: 0x040009EA RID: 2538
		private global::System.Windows.Forms.LinkLabel linkLabel2;

		// Token: 0x040009EB RID: 2539
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x040009EC RID: 2540
		private global::System.Windows.Forms.CheckBox ckbKhongShareTrung;

		// Token: 0x040009ED RID: 2541
		private global::System.Windows.Forms.CheckBox ckbUuTienNhomNhieuThanhVien;

		// Token: 0x040009EE RID: 2542
		private global::System.Windows.Forms.CheckBox ckbCauHinhNangCao;

		// Token: 0x040009EF RID: 2543
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x040009F0 RID: 2544
		private global::System.Windows.Forms.Button button8;

		// Token: 0x040009F1 RID: 2545
		private global::System.Windows.Forms.RadioButton rbTuNhap;

		// Token: 0x040009F2 RID: 2546
		private global::System.Windows.Forms.RadioButton rbRandom;

		// Token: 0x040009F3 RID: 2547
		private global::System.Windows.Forms.Label label11;
	}
}
