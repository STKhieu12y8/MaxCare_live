namespace maxcare
{
	// Token: 0x020000FC RID: 252
	public partial class fHDTuongTacBanBe : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A58 RID: 2648 RVA: 0x001563A0 File Offset: 0x001545A0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00156400 File Offset: 0x00154600
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
            this.plComment = new System.Windows.Forms.Panel();
            this.plCommentText = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.btnDown = new MetroFramework.Controls.MetroButton();
            this.btnUp = new MetroFramework.Controls.MetroButton();
            this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
            this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbCommentText = new System.Windows.Forms.CheckBox();
            this.plCountComment = new System.Windows.Forms.Panel();
            this.nudCountCommentFrom = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
            this.plAnh = new System.Windows.Forms.Panel();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbSendAnh = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.ckbInteract = new System.Windows.Forms.CheckBox();
            this.ckbShareWall = new System.Windows.Forms.CheckBox();
            this.ckbComment = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.plCountShareWall = new System.Windows.Forms.Panel();
            this.nudCountShareFrom = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudCountShareTo = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.plCountLike = new System.Windows.Forms.Panel();
            this.nudCountLikeFrom = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudCountLikeTo = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.nudTimeTo = new System.Windows.Forms.NumericUpDown();
            this.nudTimeFrom = new System.Windows.Forms.NumericUpDown();
            this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.label49 = new System.Windows.Forms.Label();
            this.nudSoLuongBanBeFrom = new System.Windows.Forms.NumericUpDown();
            this.label68 = new System.Windows.Forms.Label();
            this.nudSoLuongBanBeTo = new System.Windows.Forms.NumericUpDown();
            this.label66 = new System.Windows.Forms.Label();
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
            this.plCommentText.SuspendLayout();
            this.plCountComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountCommentFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountCommentTo)).BeginInit();
            this.plAnh.SuspendLayout();
            this.plCountShareWall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountShareFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountShareTo)).BeginInit();
            this.plCountLike.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLikeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLikeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBanBeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBanBeTo)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(384, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Tương tác Bạn bè";
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
            this.pnlHeader.Size = new System.Drawing.Size(384, 31);
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
            this.button1.Location = new System.Drawing.Point(353, 1);
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
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label49);
            this.panel1.Controls.Add(this.nudSoLuongBanBeFrom);
            this.panel1.Controls.Add(this.label68);
            this.panel1.Controls.Add(this.nudSoLuongBanBeTo);
            this.panel1.Controls.Add(this.label66);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 628);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.plComment);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.ckbInteract);
            this.groupBox1.Controls.Add(this.ckbShareWall);
            this.groupBox1.Controls.Add(this.ckbComment);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.plCountShareWall);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.plCountLike);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.nudDelayTo);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.nudTimeTo);
            this.groupBox1.Controls.Add(this.nudTimeFrom);
            this.groupBox1.Controls.Add(this.nudDelayFrom);
            this.groupBox1.Location = new System.Drawing.Point(21, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 455);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấu hình tương tác/Bạn bè";
            // 
            // plComment
            // 
            this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plComment.Controls.Add(this.plCommentText);
            this.plComment.Controls.Add(this.label4);
            this.plComment.Controls.Add(this.ckbCommentText);
            this.plComment.Controls.Add(this.plCountComment);
            this.plComment.Controls.Add(this.plAnh);
            this.plComment.Controls.Add(this.ckbSendAnh);
            this.plComment.Location = new System.Drawing.Point(21, 164);
            this.plComment.Name = "plComment";
            this.plComment.Size = new System.Drawing.Size(317, 282);
            this.plComment.TabIndex = 172;
            // 
            // plCommentText
            // 
            this.plCommentText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plCommentText.Controls.Add(this.linkLabel1);
            this.plCommentText.Controls.Add(this.button3);
            this.plCommentText.Controls.Add(this.button4);
            this.plCommentText.Controls.Add(this.button2);
            this.plCommentText.Controls.Add(this.txtComment);
            this.plCommentText.Controls.Add(this.btnDown);
            this.plCommentText.Controls.Add(this.btnUp);
            this.plCommentText.Controls.Add(this.rbNganCachKyTu);
            this.plCommentText.Controls.Add(this.rbNganCachMoiDong);
            this.plCommentText.Controls.Add(this.label9);
            this.plCommentText.Controls.Add(this.label8);
            this.plCommentText.Controls.Add(this.lblStatus);
            this.plCommentText.Location = new System.Drawing.Point(27, 52);
            this.plCommentText.Name = "plCommentText";
            this.plCommentText.Size = new System.Drawing.Size(281, 162);
            this.plCommentText.TabIndex = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(167, 141);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 21);
            this.linkLabel1.TabIndex = 180;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Random icon";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Help;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(224, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 126;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Help;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(224, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 23);
            this.button4.TabIndex = 127;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Help;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(250, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 125;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(7, 27);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(266, 111);
            this.txtComment.TabIndex = 106;
            this.txtComment.Text = "";
            this.txtComment.WordWrap = false;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // btnDown
            // 
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.Location = new System.Drawing.Point(224, -1);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(25, 25);
            this.btnDown.TabIndex = 7;
            this.btnDown.UseSelectable = true;
            this.btnDown.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnUp
            // 
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Location = new System.Drawing.Point(255, -1);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(25, 25);
            this.btnUp.TabIndex = 7;
            this.btnUp.UseSelectable = true;
            this.btnUp.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // rbNganCachKyTu
            // 
            this.rbNganCachKyTu.AutoSize = true;
            this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachKyTu.Location = new System.Drawing.Point(69, 182);
            this.rbNganCachKyTu.Name = "rbNganCachKyTu";
            this.rbNganCachKyTu.Size = new System.Drawing.Size(204, 25);
            this.rbNganCachKyTu.TabIndex = 6;
            this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
            this.rbNganCachKyTu.UseVisualStyleBackColor = true;
            this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(this.rbNganCachKyTu_CheckedChanged);
            // 
            // rbNganCachMoiDong
            // 
            this.rbNganCachMoiDong.AutoSize = true;
            this.rbNganCachMoiDong.Checked = true;
            this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachMoiDong.Location = new System.Drawing.Point(69, 161);
            this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
            this.rbNganCachMoiDong.Size = new System.Drawing.Size(199, 25);
            this.rbNganCachMoiDong.TabIndex = 5;
            this.rbNganCachMoiDong.TabStop = true;
            this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
            this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
            this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(this.rbNganCachMoiDong_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tùy chọn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "(Spin nội dung {a|b|c})";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 110;
            this.label4.Text = "Số lượng:";
            // 
            // ckbCommentText
            // 
            this.ckbCommentText.AutoSize = true;
            this.ckbCommentText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCommentText.Location = new System.Drawing.Point(6, 31);
            this.ckbCommentText.Name = "ckbCommentText";
            this.ckbCommentText.Size = new System.Drawing.Size(163, 25);
            this.ckbCommentText.TabIndex = 171;
            this.ckbCommentText.Text = "Bình luận văn bản";
            this.ckbCommentText.UseVisualStyleBackColor = true;
            this.ckbCommentText.CheckedChanged += new System.EventHandler(this.ckbCommentText_CheckedChanged);
            // 
            // plCountComment
            // 
            this.plCountComment.Controls.Add(this.nudCountCommentFrom);
            this.plCountComment.Controls.Add(this.label13);
            this.plCountComment.Controls.Add(this.label14);
            this.plCountComment.Controls.Add(this.nudCountCommentTo);
            this.plCountComment.Location = new System.Drawing.Point(95, 3);
            this.plCountComment.Name = "plCountComment";
            this.plCountComment.Size = new System.Drawing.Size(196, 25);
            this.plCountComment.TabIndex = 118;
            // 
            // nudCountCommentFrom
            // 
            this.nudCountCommentFrom.Location = new System.Drawing.Point(1, 1);
            this.nudCountCommentFrom.Name = "nudCountCommentFrom";
            this.nudCountCommentFrom.Size = new System.Drawing.Size(56, 27);
            this.nudCountCommentFrom.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(156, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 21);
            this.label13.TabIndex = 35;
            this.label13.Text = "lần";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(63, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "đến";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudCountCommentTo
            // 
            this.nudCountCommentTo.Location = new System.Drawing.Point(98, 1);
            this.nudCountCommentTo.Name = "nudCountCommentTo";
            this.nudCountCommentTo.Size = new System.Drawing.Size(56, 27);
            this.nudCountCommentTo.TabIndex = 2;
            // 
            // plAnh
            // 
            this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plAnh.Controls.Add(this.txtAnh);
            this.plAnh.Controls.Add(this.label3);
            this.plAnh.Enabled = false;
            this.plAnh.Location = new System.Drawing.Point(24, 241);
            this.plAnh.Name = "plAnh";
            this.plAnh.Size = new System.Drawing.Size(284, 31);
            this.plAnh.TabIndex = 170;
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(137, 3);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(140, 27);
            this.txtAnh.TabIndex = 155;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Đường dẫn folder ảnh:";
            // 
            // ckbSendAnh
            // 
            this.ckbSendAnh.AutoSize = true;
            this.ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbSendAnh.Location = new System.Drawing.Point(6, 218);
            this.ckbSendAnh.Name = "ckbSendAnh";
            this.ckbSendAnh.Size = new System.Drawing.Size(132, 25);
            this.ckbSendAnh.TabIndex = 169;
            this.ckbSendAnh.Text = "Bình luận ảnh";
            this.ckbSendAnh.UseVisualStyleBackColor = true;
            this.ckbSendAnh.CheckedChanged += new System.EventHandler(this.ckbSendAnh_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(118, 21);
            this.label21.TabIndex = 110;
            this.label21.Text = "Thời gian lướt:";
            // 
            // ckbInteract
            // 
            this.ckbInteract.AutoSize = true;
            this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbInteract.Location = new System.Drawing.Point(9, 82);
            this.ckbInteract.Name = "ckbInteract";
            this.ckbInteract.Size = new System.Drawing.Size(61, 25);
            this.ckbInteract.TabIndex = 7;
            this.ckbInteract.Text = "Like";
            this.ckbInteract.UseVisualStyleBackColor = true;
            this.ckbInteract.CheckedChanged += new System.EventHandler(this.ckbInteract_CheckedChanged);
            // 
            // ckbShareWall
            // 
            this.ckbShareWall.AutoSize = true;
            this.ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbShareWall.Location = new System.Drawing.Point(9, 111);
            this.ckbShareWall.Name = "ckbShareWall";
            this.ckbShareWall.Size = new System.Drawing.Size(111, 25);
            this.ckbShareWall.TabIndex = 8;
            this.ckbShareWall.Text = "Share Wall";
            this.ckbShareWall.UseVisualStyleBackColor = true;
            this.ckbShareWall.CheckedChanged += new System.EventHandler(this.ckbShareWall_CheckedChanged);
            // 
            // ckbComment
            // 
            this.ckbComment.AutoSize = true;
            this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbComment.Location = new System.Drawing.Point(9, 140);
            this.ckbComment.Name = "ckbComment";
            this.ckbComment.Size = new System.Drawing.Size(103, 25);
            this.ckbComment.TabIndex = 9;
            this.ckbComment.Text = "Comment";
            this.ckbComment.UseVisualStyleBackColor = true;
            this.ckbComment.CheckedChanged += new System.EventHandler(this.ckbComment_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 21);
            this.label20.TabIndex = 111;
            this.label20.Text = "Khoảng cách lướt:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(273, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 21);
            this.label18.TabIndex = 112;
            this.label18.Text = "giây";
            // 
            // plCountShareWall
            // 
            this.plCountShareWall.Controls.Add(this.nudCountShareFrom);
            this.plCountShareWall.Controls.Add(this.label11);
            this.plCountShareWall.Controls.Add(this.label12);
            this.plCountShareWall.Controls.Add(this.nudCountShareTo);
            this.plCountShareWall.Location = new System.Drawing.Point(116, 109);
            this.plCountShareWall.Name = "plCountShareWall";
            this.plCountShareWall.Size = new System.Drawing.Size(196, 25);
            this.plCountShareWall.TabIndex = 117;
            // 
            // nudCountShareFrom
            // 
            this.nudCountShareFrom.Location = new System.Drawing.Point(1, 1);
            this.nudCountShareFrom.Name = "nudCountShareFrom";
            this.nudCountShareFrom.Size = new System.Drawing.Size(56, 27);
            this.nudCountShareFrom.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(156, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = "lần";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(63, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "đến";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudCountShareTo
            // 
            this.nudCountShareTo.Location = new System.Drawing.Point(98, 1);
            this.nudCountShareTo.Name = "nudCountShareTo";
            this.nudCountShareTo.Size = new System.Drawing.Size(56, 27);
            this.nudCountShareTo.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(273, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 21);
            this.label17.TabIndex = 113;
            this.label17.Text = "giây";
            // 
            // plCountLike
            // 
            this.plCountLike.Controls.Add(this.nudCountLikeFrom);
            this.plCountLike.Controls.Add(this.label2);
            this.plCountLike.Controls.Add(this.label10);
            this.plCountLike.Controls.Add(this.nudCountLikeTo);
            this.plCountLike.Location = new System.Drawing.Point(116, 80);
            this.plCountLike.Name = "plCountLike";
            this.plCountLike.Size = new System.Drawing.Size(196, 25);
            this.plCountLike.TabIndex = 116;
            // 
            // nudCountLikeFrom
            // 
            this.nudCountLikeFrom.Location = new System.Drawing.Point(1, 1);
            this.nudCountLikeFrom.Name = "nudCountLikeFrom";
            this.nudCountLikeFrom.Size = new System.Drawing.Size(56, 27);
            this.nudCountLikeFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "lần";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(63, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "đến";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudCountLikeTo
            // 
            this.nudCountLikeTo.Location = new System.Drawing.Point(98, 1);
            this.nudCountLikeTo.Name = "nudCountLikeTo";
            this.nudCountLikeTo.Size = new System.Drawing.Size(56, 27);
            this.nudCountLikeTo.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(179, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 16);
            this.label16.TabIndex = 114;
            this.label16.Text = "đến";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudDelayTo
            // 
            this.nudDelayTo.Location = new System.Drawing.Point(214, 51);
            this.nudDelayTo.Name = "nudDelayTo";
            this.nudDelayTo.Size = new System.Drawing.Size(56, 27);
            this.nudDelayTo.TabIndex = 109;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(179, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 16);
            this.label15.TabIndex = 115;
            this.label15.Text = "đến";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudTimeTo
            // 
            this.nudTimeTo.Location = new System.Drawing.Point(214, 23);
            this.nudTimeTo.Name = "nudTimeTo";
            this.nudTimeTo.Size = new System.Drawing.Size(56, 27);
            this.nudTimeTo.TabIndex = 107;
            // 
            // nudTimeFrom
            // 
            this.nudTimeFrom.Location = new System.Drawing.Point(117, 23);
            this.nudTimeFrom.Name = "nudTimeFrom";
            this.nudTimeFrom.Size = new System.Drawing.Size(56, 27);
            this.nudTimeFrom.TabIndex = 106;
            // 
            // nudDelayFrom
            // 
            this.nudDelayFrom.Location = new System.Drawing.Point(117, 51);
            this.nudDelayFrom.Name = "nudDelayFrom";
            this.nudDelayFrom.Size = new System.Drawing.Size(56, 27);
            this.nudDelayFrom.TabIndex = 108;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label49.Location = new System.Drawing.Point(18, 82);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(135, 21);
            this.label49.TabIndex = 121;
            this.label49.Text = "Số lượng bạn bè:";
            // 
            // nudSoLuongBanBeFrom
            // 
            this.nudSoLuongBanBeFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoLuongBanBeFrom.Location = new System.Drawing.Point(129, 80);
            this.nudSoLuongBanBeFrom.Name = "nudSoLuongBanBeFrom";
            this.nudSoLuongBanBeFrom.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongBanBeFrom.TabIndex = 119;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label68.Location = new System.Drawing.Point(287, 82);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(37, 21);
            this.label68.TabIndex = 122;
            this.label68.Text = "bạn";
            // 
            // nudSoLuongBanBeTo
            // 
            this.nudSoLuongBanBeTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoLuongBanBeTo.Location = new System.Drawing.Point(226, 80);
            this.nudSoLuongBanBeTo.Name = "nudSoLuongBanBeTo";
            this.nudSoLuongBanBeTo.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongBanBeTo.TabIndex = 120;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label66.Location = new System.Drawing.Point(191, 82);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(38, 21);
            this.label66.TabIndex = 123;
            this.label66.Text = "đến";
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(129, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(235, 27);
            this.txtTenHanhDong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 52);
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
            this.btnCancel.Location = new System.Drawing.Point(201, 583);
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
            this.btnAdd.Location = new System.Drawing.Point(94, 583);
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
            this.bunifuCards1.Size = new System.Drawing.Size(384, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDTuongTacBanBe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 628);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDTuongTacBanBe";
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
            this.plCommentText.ResumeLayout(false);
            this.plCommentText.PerformLayout();
            this.plCountComment.ResumeLayout(false);
            this.plCountComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountCommentFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountCommentTo)).EndInit();
            this.plAnh.ResumeLayout(false);
            this.plAnh.PerformLayout();
            this.plCountShareWall.ResumeLayout(false);
            this.plCountShareWall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountShareFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountShareTo)).EndInit();
            this.plCountLike.ResumeLayout(false);
            this.plCountLike.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLikeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLikeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBanBeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBanBeTo)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04000EBA RID: 3770
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000EBB RID: 3771
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000EBC RID: 3772
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000EBD RID: 3773
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000EBE RID: 3774
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000EBF RID: 3775
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000EC0 RID: 3776
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000EC1 RID: 3777
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000EC2 RID: 3778
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000EC3 RID: 3779
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000EC4 RID: 3780
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000EC5 RID: 3781
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000EC6 RID: 3782
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000EC7 RID: 3783
		private global::System.Windows.Forms.Panel plCommentText;

		// Token: 0x04000EC8 RID: 3784
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000EC9 RID: 3785
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000ECA RID: 3786
		private global::System.Windows.Forms.CheckBox ckbComment;

		// Token: 0x04000ECB RID: 3787
		private global::System.Windows.Forms.CheckBox ckbInteract;

		// Token: 0x04000ECC RID: 3788
		private global::System.Windows.Forms.CheckBox ckbShareWall;

		// Token: 0x04000ECD RID: 3789
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x04000ECE RID: 3790
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x04000ECF RID: 3791
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000ED0 RID: 3792
		private global::MetroFramework.Controls.MetroButton btnDown;

		// Token: 0x04000ED1 RID: 3793
		private global::MetroFramework.Controls.MetroButton btnUp;

		// Token: 0x04000ED2 RID: 3794
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x04000ED3 RID: 3795
		private global::System.Windows.Forms.Panel plCountComment;

		// Token: 0x04000ED4 RID: 3796
		private global::System.Windows.Forms.NumericUpDown nudCountCommentFrom;

		// Token: 0x04000ED5 RID: 3797
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000ED6 RID: 3798
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000ED7 RID: 3799
		private global::System.Windows.Forms.NumericUpDown nudCountCommentTo;

		// Token: 0x04000ED8 RID: 3800
		private global::System.Windows.Forms.Panel plCountShareWall;

		// Token: 0x04000ED9 RID: 3801
		private global::System.Windows.Forms.NumericUpDown nudCountShareFrom;

		// Token: 0x04000EDA RID: 3802
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000EDB RID: 3803
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000EDC RID: 3804
		private global::System.Windows.Forms.NumericUpDown nudCountShareTo;

		// Token: 0x04000EDD RID: 3805
		private global::System.Windows.Forms.Panel plCountLike;

		// Token: 0x04000EDE RID: 3806
		private global::System.Windows.Forms.NumericUpDown nudCountLikeFrom;

		// Token: 0x04000EDF RID: 3807
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000EE0 RID: 3808
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000EE1 RID: 3809
		private global::System.Windows.Forms.NumericUpDown nudCountLikeTo;

		// Token: 0x04000EE2 RID: 3810
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04000EE3 RID: 3811
		private global::System.Windows.Forms.NumericUpDown nudTimeTo;

		// Token: 0x04000EE4 RID: 3812
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04000EE5 RID: 3813
		private global::System.Windows.Forms.NumericUpDown nudTimeFrom;

		// Token: 0x04000EE6 RID: 3814
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000EE7 RID: 3815
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000EE8 RID: 3816
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000EE9 RID: 3817
		private global::System.Windows.Forms.Label label18;

		// Token: 0x04000EEA RID: 3818
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000EEB RID: 3819
		private global::System.Windows.Forms.Label label21;

		// Token: 0x04000EEC RID: 3820
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000EED RID: 3821
		private global::System.Windows.Forms.Label label49;

		// Token: 0x04000EEE RID: 3822
		private global::System.Windows.Forms.NumericUpDown nudSoLuongBanBeFrom;

		// Token: 0x04000EEF RID: 3823
		private global::System.Windows.Forms.Label label68;

		// Token: 0x04000EF0 RID: 3824
		private global::System.Windows.Forms.NumericUpDown nudSoLuongBanBeTo;

		// Token: 0x04000EF1 RID: 3825
		private global::System.Windows.Forms.Label label66;

		// Token: 0x04000EF2 RID: 3826
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000EF3 RID: 3827
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000EF4 RID: 3828
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000EF5 RID: 3829
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04000EF6 RID: 3830
		private global::System.Windows.Forms.Panel plAnh;

		// Token: 0x04000EF7 RID: 3831
		private global::System.Windows.Forms.TextBox txtAnh;

		// Token: 0x04000EF8 RID: 3832
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000EF9 RID: 3833
		private global::System.Windows.Forms.CheckBox ckbSendAnh;

		// Token: 0x04000EFA RID: 3834
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000EFB RID: 3835
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x04000EFC RID: 3836
		private global::System.Windows.Forms.CheckBox ckbCommentText;
	}
}
