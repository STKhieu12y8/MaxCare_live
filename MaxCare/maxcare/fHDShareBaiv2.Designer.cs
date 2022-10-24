namespace maxcare
{
	// Token: 0x020000B5 RID: 181
	public partial class fHDShareBaiv2 : global::System.Windows.Forms.Form
	{
		// Token: 0x060006DD RID: 1757 RVA: 0x000AD828 File Offset: 0x000ABA28
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x000AD888 File Offset: 0x000ABA88
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
            this.ckbKhongPhaiLinkFacebook = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.nudCountGroupTo = new System.Windows.Forms.NumericUpDown();
            this.nudCountGroupFrom = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.ckbOnlyShareNhomKhongKiemDuyet = new System.Windows.Forms.CheckBox();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(613, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Share bài v2\'";
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
            this.pnlHeader.Size = new System.Drawing.Size(613, 31);
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
            this.button1.Location = new System.Drawing.Point(582, 1);
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
            this.panel1.Controls.Add(this.ckbKhongPhaiLinkFacebook);
            this.panel1.Controls.Add(this.label4);
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
            this.panel1.Size = new System.Drawing.Size(616, 646);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ckbKhongPhaiLinkFacebook
            // 
            this.ckbKhongPhaiLinkFacebook.AutoSize = true;
            this.ckbKhongPhaiLinkFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbKhongPhaiLinkFacebook.Enabled = false;
            this.ckbKhongPhaiLinkFacebook.Location = new System.Drawing.Point(30, 371);
            this.ckbKhongPhaiLinkFacebook.Name = "ckbKhongPhaiLinkFacebook";
            this.ckbKhongPhaiLinkFacebook.Size = new System.Drawing.Size(340, 25);
            this.ckbKhongPhaiLinkFacebook.TabIndex = 65;
            this.ckbKhongPhaiLinkFacebook.Text = "Link cần chia sẻ không phải của Facebook";
            this.ckbKhongPhaiLinkFacebook.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(209, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 21);
            this.label4.TabIndex = 64;
            this.label4.Text = "(Tool sẽ lấy random 1 trong các link dưới để share)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 21);
            this.label2.TabIndex = 64;
            this.label2.Text = "Link bài cần share (0):";
            // 
            // txtLinkChiaSe
            // 
            this.txtLinkChiaSe.Location = new System.Drawing.Point(30, 269);
            this.txtLinkChiaSe.Multiline = true;
            this.txtLinkChiaSe.Name = "txtLinkChiaSe";
            this.txtLinkChiaSe.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLinkChiaSe.Size = new System.Drawing.Size(476, 98);
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
            this.groupBox2.Location = new System.Drawing.Point(30, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 137);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy chọn share";
            // 
            // plDangBaiLenPage
            // 
            this.plDangBaiLenPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plDangBaiLenPage.Controls.Add(this.label21);
            this.plDangBaiLenPage.Controls.Add(this.label22);
            this.plDangBaiLenPage.Controls.Add(this.nudCountPageTo);
            this.plDangBaiLenPage.Controls.Add(this.label23);
            this.plDangBaiLenPage.Controls.Add(this.nudCountPageFrom);
            this.plDangBaiLenPage.Location = new System.Drawing.Point(153, 102);
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
            this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupTo);
            this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupFrom);
            this.plDangBaiLenNhom.Controls.Add(this.label24);
            this.plDangBaiLenNhom.Controls.Add(this.label25);
            this.plDangBaiLenNhom.Controls.Add(this.ckbOnlyShareNhomKhongKiemDuyet);
            this.plDangBaiLenNhom.Controls.Add(this.label26);
            this.plDangBaiLenNhom.Location = new System.Drawing.Point(153, 46);
            this.plDangBaiLenNhom.Name = "plDangBaiLenNhom";
            this.plDangBaiLenNhom.Size = new System.Drawing.Size(310, 50);
            this.plDangBaiLenNhom.TabIndex = 1;
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
            // ckbOnlyShareNhomKhongKiemDuyet
            // 
            this.ckbOnlyShareNhomKhongKiemDuyet.AutoSize = true;
            this.ckbOnlyShareNhomKhongKiemDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbOnlyShareNhomKhongKiemDuyet.Location = new System.Drawing.Point(6, 28);
            this.ckbOnlyShareNhomKhongKiemDuyet.Name = "ckbOnlyShareNhomKhongKiemDuyet";
            this.ckbOnlyShareNhomKhongKiemDuyet.Size = new System.Drawing.Size(282, 25);
            this.ckbOnlyShareNhomKhongKiemDuyet.TabIndex = 0;
            this.ckbOnlyShareNhomKhongKiemDuyet.Text = "Chỉ share nhóm không kiểm duyệt";
            this.ckbOnlyShareNhomKhongKiemDuyet.UseVisualStyleBackColor = true;
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
            this.ckbShareBaiLenPage.AutoSize = true;
            this.ckbShareBaiLenPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbShareBaiLenPage.Location = new System.Drawing.Point(10, 104);
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
            this.nudDelayTo.Location = new System.Drawing.Point(251, 79);
            this.nudDelayTo.Name = "nudDelayTo";
            this.nudDelayTo.Size = new System.Drawing.Size(56, 27);
            this.nudDelayTo.TabIndex = 58;
            // 
            // nudDelayFrom
            // 
            this.nudDelayFrom.Location = new System.Drawing.Point(154, 79);
            this.nudDelayFrom.Name = "nudDelayFrom";
            this.nudDelayFrom.Size = new System.Drawing.Size(56, 27);
            this.nudDelayFrom.TabIndex = 57;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(216, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 21);
            this.label20.TabIndex = 61;
            this.label20.Text = "đến";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(310, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 21);
            this.label19.TabIndex = 60;
            this.label19.Text = "giây";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 21);
            this.label15.TabIndex = 59;
            this.label15.Text = "Khoảng cách share:";
            // 
            // plVanBan
            // 
            this.plVanBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.plVanBan.Location = new System.Drawing.Point(49, 421);
            this.plVanBan.Name = "plVanBan";
            this.plVanBan.Size = new System.Drawing.Size(457, 169);
            this.plVanBan.TabIndex = 33;
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
            this.btnDown.Location = new System.Drawing.Point(400, -1);
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
            this.btnUp.Location = new System.Drawing.Point(431, -1);
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
            this.txtNoiDung.Size = new System.Drawing.Size(442, 119);
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
            this.btnAdd.Location = new System.Drawing.Point(212, 604);
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
            this.ckbVanBan.Location = new System.Drawing.Point(30, 397);
            this.ckbVanBan.Name = "ckbVanBan";
            this.ckbVanBan.Size = new System.Drawing.Size(143, 25);
            this.ckbVanBan.TabIndex = 32;
            this.ckbVanBan.Text = "Nội dung share";
            this.ckbVanBan.UseVisualStyleBackColor = true;
            this.ckbVanBan.CheckedChanged += new System.EventHandler(this.ckbVanBan_CheckedChanged);
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(154, 49);
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
            this.btnCancel.Location = new System.Drawing.Point(311, 604);
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
            this.bunifuCards1.Size = new System.Drawing.Size(613, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDShareBaiv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 646);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDShareBaiv2";
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
            ((System.ComponentModel.ISupportInitialize)(this.nudCountGroupTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountGroupFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            this.plVanBan.ResumeLayout(false);
            this.plVanBan.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04000741 RID: 1857
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000742 RID: 1858
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000743 RID: 1859
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000744 RID: 1860
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000745 RID: 1861
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000746 RID: 1862
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000747 RID: 1863
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000748 RID: 1864
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000749 RID: 1865
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x0400074A RID: 1866
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x0400074B RID: 1867
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400074C RID: 1868
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400074D RID: 1869
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x0400074E RID: 1870
		private global::System.Windows.Forms.CheckBox ckbVanBan;

		// Token: 0x0400074F RID: 1871
		private global::System.Windows.Forms.Panel plVanBan;

		// Token: 0x04000750 RID: 1872
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000751 RID: 1873
		private global::System.Windows.Forms.RichTextBox txtNoiDung;

		// Token: 0x04000752 RID: 1874
		private global::MetroFramework.Controls.MetroButton btnDown;

		// Token: 0x04000753 RID: 1875
		private global::MetroFramework.Controls.MetroButton btnUp;

		// Token: 0x04000754 RID: 1876
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04000755 RID: 1877
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04000756 RID: 1878
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000757 RID: 1879
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04000758 RID: 1880
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000759 RID: 1881
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400075A RID: 1882
		private global::System.Windows.Forms.Panel plDangBaiLenPage;

		// Token: 0x0400075B RID: 1883
		private global::System.Windows.Forms.Label label21;

		// Token: 0x0400075C RID: 1884
		private global::System.Windows.Forms.Label label22;

		// Token: 0x0400075D RID: 1885
		private global::System.Windows.Forms.NumericUpDown nudCountPageTo;

		// Token: 0x0400075E RID: 1886
		private global::System.Windows.Forms.Label label23;

		// Token: 0x0400075F RID: 1887
		private global::System.Windows.Forms.NumericUpDown nudCountPageFrom;

		// Token: 0x04000760 RID: 1888
		private global::System.Windows.Forms.Panel plDangBaiLenNhom;

		// Token: 0x04000761 RID: 1889
		private global::System.Windows.Forms.NumericUpDown nudCountGroupTo;

		// Token: 0x04000762 RID: 1890
		private global::System.Windows.Forms.NumericUpDown nudCountGroupFrom;

		// Token: 0x04000763 RID: 1891
		private global::System.Windows.Forms.Label label24;

		// Token: 0x04000764 RID: 1892
		private global::System.Windows.Forms.Label label25;

		// Token: 0x04000765 RID: 1893
		private global::System.Windows.Forms.Label label26;

		// Token: 0x04000766 RID: 1894
		private global::System.Windows.Forms.CheckBox ckbShareBaiLenPage;

		// Token: 0x04000767 RID: 1895
		private global::System.Windows.Forms.CheckBox ckbShareBaiLenNhom;

		// Token: 0x04000768 RID: 1896
		private global::System.Windows.Forms.CheckBox ckbShareBaiLenTuong;

		// Token: 0x04000769 RID: 1897
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400076A RID: 1898
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400076B RID: 1899
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x0400076C RID: 1900
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x0400076D RID: 1901
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400076E RID: 1902
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400076F RID: 1903
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000770 RID: 1904
		private global::System.Windows.Forms.TextBox txtLinkChiaSe;

		// Token: 0x04000771 RID: 1905
		private global::System.Windows.Forms.CheckBox ckbOnlyShareNhomKhongKiemDuyet;

		// Token: 0x04000772 RID: 1906
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000773 RID: 1907
		private global::System.Windows.Forms.CheckBox ckbKhongPhaiLinkFacebook;
	}
}
