namespace maxcare
{
	// Token: 0x02000102 RID: 258
	public partial class fHDSpamBaiViet : global::System.Windows.Forms.Form
	{
		// Token: 0x06000ADB RID: 2779 RVA: 0x0017147C File Offset: 0x0016F67C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x001714DC File Offset: 0x0016F6DC
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudBoQuaTo = new System.Windows.Forms.NumericUpDown();
            this.nudBoQuaFrom = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ckbBoQua = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnChooseFileUid = new System.Windows.Forms.Button();
            this.rbListUid = new System.Windows.Forms.RadioButton();
            this.rbFileUid = new System.Windows.Forms.RadioButton();
            this.plComment = new System.Windows.Forms.Panel();
            this.btnDown = new MetroFramework.Controls.MetroButton();
            this.btnUp = new MetroFramework.Controls.MetroButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
            this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ckbAutoDeleteComment = new System.Windows.Forms.CheckBox();
            this.plAnh = new System.Windows.Forms.Panel();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ckbSendAnh = new System.Windows.Forms.CheckBox();
            this.txtUid = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
            this.label68 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nudSoLuongUidTo = new System.Windows.Forms.NumericUpDown();
            this.label66 = new System.Windows.Forms.Label();
            this.ckbComment = new System.Windows.Forms.CheckBox();
            this.ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
            this.ckbShareWall = new System.Windows.Forms.CheckBox();
            this.ckbInteract = new System.Windows.Forms.CheckBox();
            this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
            this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
            this.txtPathFileUid = new System.Windows.Forms.TextBox();
            this.txtTenHanhDong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoQuaTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoQuaFrom)).BeginInit();
            this.plComment.SuspendLayout();
            this.plAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongUidFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongUidTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBaiVietTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBaiVietFrom)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(680, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Spam bài viết";
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
            this.pnlHeader.Size = new System.Drawing.Size(680, 31);
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
            this.button1.Location = new System.Drawing.Point(649, 1);
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ckbBoQua);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnChooseFileUid);
            this.panel1.Controls.Add(this.rbListUid);
            this.panel1.Controls.Add(this.rbFileUid);
            this.panel1.Controls.Add(this.plComment);
            this.panel1.Controls.Add(this.plAnh);
            this.panel1.Controls.Add(this.ckbSendAnh);
            this.panel1.Controls.Add(this.txtUid);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label49);
            this.panel1.Controls.Add(this.nudSoLuongUidFrom);
            this.panel1.Controls.Add(this.label68);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.nudSoLuongUidTo);
            this.panel1.Controls.Add(this.label66);
            this.panel1.Controls.Add(this.ckbComment);
            this.panel1.Controls.Add(this.ckbTuDongXoaUid);
            this.panel1.Controls.Add(this.ckbShareWall);
            this.panel1.Controls.Add(this.ckbInteract);
            this.panel1.Controls.Add(this.nudDelayTo);
            this.panel1.Controls.Add(this.nudSoLuongBaiVietTo);
            this.panel1.Controls.Add(this.nudDelayFrom);
            this.panel1.Controls.Add(this.nudSoLuongBaiVietFrom);
            this.panel1.Controls.Add(this.txtPathFileUid);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 469);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.nudBoQuaTo);
            this.panel2.Controls.Add(this.nudBoQuaFrom);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(97, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 30);
            this.panel2.TabIndex = 166;
            // 
            // nudBoQuaTo
            // 
            this.nudBoQuaTo.Location = new System.Drawing.Point(92, 3);
            this.nudBoQuaTo.Name = "nudBoQuaTo";
            this.nudBoQuaTo.Size = new System.Drawing.Size(56, 27);
            this.nudBoQuaTo.TabIndex = 40;
            // 
            // nudBoQuaFrom
            // 
            this.nudBoQuaFrom.Location = new System.Drawing.Point(4, 3);
            this.nudBoQuaFrom.Name = "nudBoQuaFrom";
            this.nudBoQuaFrom.Size = new System.Drawing.Size(56, 27);
            this.nudBoQuaFrom.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(61, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "đến";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 21);
            this.label11.TabIndex = 41;
            this.label11.Text = "bài viết đầu";
            // 
            // ckbBoQua
            // 
            this.ckbBoQua.AutoSize = true;
            this.ckbBoQua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbBoQua.Location = new System.Drawing.Point(31, 383);
            this.ckbBoQua.Name = "ckbBoQua";
            this.ckbBoQua.Size = new System.Drawing.Size(89, 25);
            this.ckbBoQua.TabIndex = 164;
            this.ckbBoQua.Text = "Bỏ qua:";
            this.ckbBoQua.UseVisualStyleBackColor = true;
            this.ckbBoQua.CheckedChanged += new System.EventHandler(this.ckbBoQua_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Help;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(267, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnChooseFileUid
            // 
            this.btnChooseFileUid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseFileUid.Location = new System.Drawing.Point(267, 189);
            this.btnChooseFileUid.Name = "btnChooseFileUid";
            this.btnChooseFileUid.Size = new System.Drawing.Size(63, 25);
            this.btnChooseFileUid.TabIndex = 156;
            this.btnChooseFileUid.Text = "Chọn";
            this.btnChooseFileUid.UseVisualStyleBackColor = true;
            this.btnChooseFileUid.Click += new System.EventHandler(this.btnChooseFileUid_Click);
            // 
            // rbListUid
            // 
            this.rbListUid.AutoSize = true;
            this.rbListUid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbListUid.Location = new System.Drawing.Point(31, 213);
            this.rbListUid.Name = "rbListUid";
            this.rbListUid.Size = new System.Drawing.Size(226, 25);
            this.rbListUid.TabIndex = 163;
            this.rbListUid.Text = "Nhập (Mỗi Uid 1 dòng) (0)";
            this.rbListUid.UseVisualStyleBackColor = true;
            this.rbListUid.CheckedChanged += new System.EventHandler(this.rbListUid_CheckedChanged);
            // 
            // rbFileUid
            // 
            this.rbFileUid.AutoSize = true;
            this.rbFileUid.Checked = true;
            this.rbFileUid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFileUid.Location = new System.Drawing.Point(31, 190);
            this.rbFileUid.Name = "rbFileUid";
            this.rbFileUid.Size = new System.Drawing.Size(121, 25);
            this.rbFileUid.TabIndex = 163;
            this.rbFileUid.TabStop = true;
            this.rbFileUid.Text = "Nhập từ File";
            this.rbFileUid.UseVisualStyleBackColor = true;
            this.rbFileUid.CheckedChanged += new System.EventHandler(this.rbFileUid_CheckedChanged);
            // 
            // plComment
            // 
            this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plComment.Controls.Add(this.btnDown);
            this.plComment.Controls.Add(this.btnUp);
            this.plComment.Controls.Add(this.linkLabel1);
            this.plComment.Controls.Add(this.label2);
            this.plComment.Controls.Add(this.button5);
            this.plComment.Controls.Add(this.button3);
            this.plComment.Controls.Add(this.button2);
            this.plComment.Controls.Add(this.rbNganCachKyTu);
            this.plComment.Controls.Add(this.rbNganCachMoiDong);
            this.plComment.Controls.Add(this.label9);
            this.plComment.Controls.Add(this.txtComment);
            this.plComment.Controls.Add(this.lblStatus);
            this.plComment.Controls.Add(this.ckbAutoDeleteComment);
            this.plComment.Location = new System.Drawing.Point(369, 159);
            this.plComment.Name = "plComment";
            this.plComment.Size = new System.Drawing.Size(281, 193);
            this.plComment.TabIndex = 10;
            // 
            // btnDown
            // 
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.Location = new System.Drawing.Point(224, -1);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(25, 25);
            this.btnDown.TabIndex = 191;
            this.btnDown.UseSelectable = true;
            this.btnDown.Visible = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Location = new System.Drawing.Point(255, -1);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(25, 25);
            this.btnUp.TabIndex = 192;
            this.btnUp.UseSelectable = true;
            this.btnUp.Visible = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(163, 126);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 21);
            this.linkLabel1.TabIndex = 190;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Random icon";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 189;
            this.label2.Text = "Spin content: {a|b|c}";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Help;
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(247, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 188;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Help;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(229, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Help;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(229, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // rbNganCachKyTu
            // 
            this.rbNganCachKyTu.AutoSize = true;
            this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachKyTu.Location = new System.Drawing.Point(70, 168);
            this.rbNganCachKyTu.Name = "rbNganCachKyTu";
            this.rbNganCachKyTu.Size = new System.Drawing.Size(204, 25);
            this.rbNganCachKyTu.TabIndex = 3;
            this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
            this.rbNganCachKyTu.UseVisualStyleBackColor = true;
            this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(this.rbNganCachKyTu_CheckedChanged);
            // 
            // rbNganCachMoiDong
            // 
            this.rbNganCachMoiDong.AutoSize = true;
            this.rbNganCachMoiDong.Checked = true;
            this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachMoiDong.Location = new System.Drawing.Point(70, 147);
            this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
            this.rbNganCachMoiDong.Size = new System.Drawing.Size(199, 25);
            this.rbNganCachMoiDong.TabIndex = 3;
            this.rbNganCachMoiDong.TabStop = true;
            this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
            this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
            this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(this.rbNganCachMoiDong_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tùy chọn:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(7, 25);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(263, 99);
            this.txtComment.TabIndex = 1;
            this.txtComment.Text = "";
            this.txtComment.WordWrap = false;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            this.txtComment.MouseEnter += new System.EventHandler(this.txtComment_MouseEnter);
            this.txtComment.MouseLeave += new System.EventHandler(this.txtComment_MouseLeave);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(181, 21);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Nội dung bình luận (0):";
            // 
            // ckbAutoDeleteComment
            // 
            this.ckbAutoDeleteComment.AutoSize = true;
            this.ckbAutoDeleteComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbAutoDeleteComment.Location = new System.Drawing.Point(7, 190);
            this.ckbAutoDeleteComment.Name = "ckbAutoDeleteComment";
            this.ckbAutoDeleteComment.Size = new System.Drawing.Size(289, 25);
            this.ckbAutoDeleteComment.TabIndex = 8;
            this.ckbAutoDeleteComment.Text = "Tự động xóa nội dung đã bình luận";
            this.ckbAutoDeleteComment.UseVisualStyleBackColor = true;
            // 
            // plAnh
            // 
            this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plAnh.Controls.Add(this.txtAnh);
            this.plAnh.Controls.Add(this.label12);
            this.plAnh.Enabled = false;
            this.plAnh.Location = new System.Drawing.Point(367, 377);
            this.plAnh.Name = "plAnh";
            this.plAnh.Size = new System.Drawing.Size(283, 31);
            this.plAnh.TabIndex = 162;
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(138, 3);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(140, 27);
            this.txtAnh.TabIndex = 159;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 21);
            this.label12.TabIndex = 158;
            this.label12.Text = "Đường dẫn folder ảnh:";
            // 
            // ckbSendAnh
            // 
            this.ckbSendAnh.AutoSize = true;
            this.ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbSendAnh.Location = new System.Drawing.Point(349, 355);
            this.ckbSendAnh.Name = "ckbSendAnh";
            this.ckbSendAnh.Size = new System.Drawing.Size(132, 25);
            this.ckbSendAnh.TabIndex = 161;
            this.ckbSendAnh.Text = "Bình luận ảnh";
            this.ckbSendAnh.UseVisualStyleBackColor = true;
            this.ckbSendAnh.CheckedChanged += new System.EventHandler(this.ckbSendAnh_CheckedChanged);
            // 
            // txtUid
            // 
            this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUid.Location = new System.Drawing.Point(31, 236);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(299, 115);
            this.txtUid.TabIndex = 117;
            this.txtUid.Text = "";
            this.txtUid.WordWrap = false;
            this.txtUid.TextChanged += new System.EventHandler(this.txtUid_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(315, 21);
            this.label10.TabIndex = 116;
            this.label10.Text = "Nhập danh sách ID Cá nhân/Nhóm/Page:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label49.Location = new System.Drawing.Point(27, 81);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(109, 21);
            this.label49.TabIndex = 92;
            this.label49.Text = "Số lượng Uid:";
            // 
            // nudSoLuongUidFrom
            // 
            this.nudSoLuongUidFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoLuongUidFrom.Location = new System.Drawing.Point(135, 79);
            this.nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
            this.nudSoLuongUidFrom.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongUidFrom.TabIndex = 1;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label68.Location = new System.Drawing.Point(290, 81);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(34, 21);
            this.label68.TabIndex = 99;
            this.label68.Text = "Uid";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label19.Location = new System.Drawing.Point(27, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 21);
            this.label19.TabIndex = 101;
            this.label19.Text = "Số bài viết/uid:";
            // 
            // nudSoLuongUidTo
            // 
            this.nudSoLuongUidTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoLuongUidTo.Location = new System.Drawing.Point(232, 79);
            this.nudSoLuongUidTo.Name = "nudSoLuongUidTo";
            this.nudSoLuongUidTo.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongUidTo.TabIndex = 2;
            // 
            // label66
            // 
            this.label66.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label66.Location = new System.Drawing.Point(197, 81);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(29, 16);
            this.label66.TabIndex = 105;
            this.label66.Text = "đến";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckbComment
            // 
            this.ckbComment.AutoSize = true;
            this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbComment.Location = new System.Drawing.Point(351, 134);
            this.ckbComment.Name = "ckbComment";
            this.ckbComment.Size = new System.Drawing.Size(163, 25);
            this.ckbComment.TabIndex = 9;
            this.ckbComment.Text = "Bình luận văn bản";
            this.ckbComment.UseVisualStyleBackColor = true;
            this.ckbComment.CheckedChanged += new System.EventHandler(this.ckbComment_CheckedChanged);
            // 
            // ckbTuDongXoaUid
            // 
            this.ckbTuDongXoaUid.AutoSize = true;
            this.ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuDongXoaUid.Location = new System.Drawing.Point(31, 354);
            this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
            this.ckbTuDongXoaUid.Size = new System.Drawing.Size(397, 25);
            this.ckbTuDongXoaUid.TabIndex = 8;
            this.ckbTuDongXoaUid.Text = "Tự động xóa Uid đã tương tác (Không trùng UID)";
            this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
            this.ckbTuDongXoaUid.CheckedChanged += new System.EventHandler(this.ckbTuDongXoaUid_CheckedChanged);
            // 
            // ckbShareWall
            // 
            this.ckbShareWall.AutoSize = true;
            this.ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbShareWall.Location = new System.Drawing.Point(351, 108);
            this.ckbShareWall.Name = "ckbShareWall";
            this.ckbShareWall.Size = new System.Drawing.Size(215, 25);
            this.ckbShareWall.TabIndex = 8;
            this.ckbShareWall.Text = "Chia sẻ bài viết về tường";
            this.ckbShareWall.UseVisualStyleBackColor = true;
            // 
            // ckbInteract
            // 
            this.ckbInteract.AutoSize = true;
            this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbInteract.Location = new System.Drawing.Point(351, 82);
            this.ckbInteract.Name = "ckbInteract";
            this.ckbInteract.Size = new System.Drawing.Size(120, 25);
            this.ckbInteract.TabIndex = 7;
            this.ckbInteract.Text = "Like bài viết";
            this.ckbInteract.UseVisualStyleBackColor = true;
            // 
            // nudDelayTo
            // 
            this.nudDelayTo.Location = new System.Drawing.Point(232, 140);
            this.nudDelayTo.Name = "nudDelayTo";
            this.nudDelayTo.Size = new System.Drawing.Size(56, 27);
            this.nudDelayTo.TabIndex = 6;
            // 
            // nudSoLuongBaiVietTo
            // 
            this.nudSoLuongBaiVietTo.Location = new System.Drawing.Point(232, 110);
            this.nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
            this.nudSoLuongBaiVietTo.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongBaiVietTo.TabIndex = 4;
            // 
            // nudDelayFrom
            // 
            this.nudDelayFrom.Location = new System.Drawing.Point(135, 140);
            this.nudDelayFrom.Name = "nudDelayFrom";
            this.nudDelayFrom.Size = new System.Drawing.Size(56, 27);
            this.nudDelayFrom.TabIndex = 5;
            // 
            // nudSoLuongBaiVietFrom
            // 
            this.nudSoLuongBaiVietFrom.Location = new System.Drawing.Point(135, 110);
            this.nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
            this.nudSoLuongBaiVietFrom.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongBaiVietFrom.TabIndex = 3;
            // 
            // txtPathFileUid
            // 
            this.txtPathFileUid.Location = new System.Drawing.Point(135, 190);
            this.txtPathFileUid.Name = "txtPathFileUid";
            this.txtPathFileUid.Size = new System.Drawing.Size(126, 27);
            this.txtPathFileUid.TabIndex = 0;
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(135, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(195, 27);
            this.txtTenHanhDong.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(197, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "đến";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(197, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "đến";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "giây";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "bài";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Thời gian chờ:";
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
            this.btnCancel.Location = new System.Drawing.Point(349, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 12;
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
            this.btnAdd.Location = new System.Drawing.Point(242, 429);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 29);
            this.btnAdd.TabIndex = 11;
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
            this.bunifuCards1.Size = new System.Drawing.Size(680, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDSpamBaiViet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 469);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDSpamBaiViet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoQuaTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoQuaFrom)).EndInit();
            this.plComment.ResumeLayout(false);
            this.plComment.PerformLayout();
            this.plAnh.ResumeLayout(false);
            this.plAnh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongUidFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongUidTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBaiVietTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBaiVietFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04001008 RID: 4104
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04001009 RID: 4105
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400100A RID: 4106
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x0400100B RID: 4107
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400100C RID: 4108
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x0400100D RID: 4109
		private global::System.Windows.Forms.NumericUpDown nudSoLuongBaiVietTo;

		// Token: 0x0400100E RID: 4110
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x0400100F RID: 4111
		private global::System.Windows.Forms.NumericUpDown nudSoLuongBaiVietFrom;

		// Token: 0x04001010 RID: 4112
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04001011 RID: 4113
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04001012 RID: 4114
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04001013 RID: 4115
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04001014 RID: 4116
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04001015 RID: 4117
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001016 RID: 4118
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001017 RID: 4119
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04001018 RID: 4120
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04001019 RID: 4121
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x0400101A RID: 4122
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x0400101B RID: 4123
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400101C RID: 4124
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400101D RID: 4125
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x0400101E RID: 4126
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x0400101F RID: 4127
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04001020 RID: 4128
		private global::System.Windows.Forms.CheckBox ckbComment;

		// Token: 0x04001021 RID: 4129
		private global::System.Windows.Forms.CheckBox ckbInteract;

		// Token: 0x04001022 RID: 4130
		private global::System.Windows.Forms.CheckBox ckbShareWall;

		// Token: 0x04001023 RID: 4131
		private global::System.Windows.Forms.Label label49;

		// Token: 0x04001024 RID: 4132
		private global::System.Windows.Forms.NumericUpDown nudSoLuongUidFrom;

		// Token: 0x04001025 RID: 4133
		private global::System.Windows.Forms.Label label68;

		// Token: 0x04001026 RID: 4134
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04001027 RID: 4135
		private global::System.Windows.Forms.NumericUpDown nudSoLuongUidTo;

		// Token: 0x04001028 RID: 4136
		private global::System.Windows.Forms.Label label66;

		// Token: 0x04001029 RID: 4137
		private global::System.Windows.Forms.RichTextBox txtUid;

		// Token: 0x0400102A RID: 4138
		private global::System.Windows.Forms.Panel plAnh;

		// Token: 0x0400102B RID: 4139
		private global::System.Windows.Forms.CheckBox ckbSendAnh;

		// Token: 0x0400102C RID: 4140
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x0400102D RID: 4141
		private global::System.Windows.Forms.CheckBox ckbTuDongXoaUid;

		// Token: 0x0400102E RID: 4142
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x0400102F RID: 4143
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x04001030 RID: 4144
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04001031 RID: 4145
		private global::System.Windows.Forms.RadioButton rbListUid;

		// Token: 0x04001032 RID: 4146
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04001033 RID: 4147
		private global::System.Windows.Forms.TextBox txtAnh;

		// Token: 0x04001034 RID: 4148
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04001035 RID: 4149
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04001036 RID: 4150
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04001037 RID: 4151
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04001038 RID: 4152
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04001039 RID: 4153
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400103A RID: 4154
		private global::System.Windows.Forms.Button button5;

		// Token: 0x0400103B RID: 4155
		private global::System.Windows.Forms.CheckBox ckbAutoDeleteComment;

		// Token: 0x0400103C RID: 4156
		private global::MetroFramework.Controls.MetroButton btnDown;

		// Token: 0x0400103D RID: 4157
		private global::MetroFramework.Controls.MetroButton btnUp;

		// Token: 0x0400103E RID: 4158
		private global::System.Windows.Forms.Button btnChooseFileUid;

		// Token: 0x0400103F RID: 4159
		private global::System.Windows.Forms.RadioButton rbFileUid;

		// Token: 0x04001040 RID: 4160
		private global::System.Windows.Forms.TextBox txtPathFileUid;

		// Token: 0x04001041 RID: 4161
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04001042 RID: 4162
		private global::System.Windows.Forms.NumericUpDown nudBoQuaTo;

		// Token: 0x04001043 RID: 4163
		private global::System.Windows.Forms.NumericUpDown nudBoQuaFrom;

		// Token: 0x04001044 RID: 4164
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04001045 RID: 4165
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04001046 RID: 4166
		private global::System.Windows.Forms.CheckBox ckbBoQua;
	}
}
