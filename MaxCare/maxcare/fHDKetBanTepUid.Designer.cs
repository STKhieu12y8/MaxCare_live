namespace maxcare
{
	// Token: 0x02000113 RID: 275
	public partial class fHDKetBanTepUid : global::System.Windows.Forms.Form
	{
		// Token: 0x06000BFC RID: 3068 RVA: 0x001AE9C4 File Offset: 0x001ACBC4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x001AEA24 File Offset: 0x001ACC24
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
            this.plTuongTac = new System.Windows.Forms.Panel();
            this.plTuongTacComment = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblStatusComment = new System.Windows.Forms.Label();
            this.ckbTuongTacComment = new System.Windows.Forms.CheckBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nudSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
            this.ckbTuongTacLike = new System.Windows.Forms.CheckBox();
            this.label46 = new System.Windows.Forms.Label();
            this.nudTuongTacDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.label47 = new System.Windows.Forms.Label();
            this.nudSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
            this.nudTuongTacDelayTo = new System.Windows.Forms.NumericUpDown();
            this.label67 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.ckbTuongTac = new System.Windows.Forms.CheckBox();
            this.txtUid = new System.Windows.Forms.RichTextBox();
            this.ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.plTuongTac.SuspendLayout();
            this.plTuongTacComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBaiVietFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBaiVietTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacDelayTo)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(687, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Kết bạn theo tệp UID";
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
            this.panel1.Controls.Add(this.plTuongTac);
            this.panel1.Controls.Add(this.ckbTuongTac);
            this.panel1.Controls.Add(this.txtUid);
            this.panel1.Controls.Add(this.ckbTuDongXoaUid);
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
            this.panel1.Size = new System.Drawing.Size(690, 406);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // plTuongTac
            // 
            this.plTuongTac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTuongTac.Controls.Add(this.plTuongTacComment);
            this.plTuongTac.Controls.Add(this.ckbTuongTacComment);
            this.plTuongTac.Controls.Add(this.label54);
            this.plTuongTac.Controls.Add(this.label19);
            this.plTuongTac.Controls.Add(this.nudSoLuongBaiVietFrom);
            this.plTuongTac.Controls.Add(this.ckbTuongTacLike);
            this.plTuongTac.Controls.Add(this.label46);
            this.plTuongTac.Controls.Add(this.nudTuongTacDelayFrom);
            this.plTuongTac.Controls.Add(this.label47);
            this.plTuongTac.Controls.Add(this.nudSoLuongBaiVietTo);
            this.plTuongTac.Controls.Add(this.nudTuongTacDelayTo);
            this.plTuongTac.Controls.Add(this.label67);
            this.plTuongTac.Controls.Add(this.label48);
            this.plTuongTac.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plTuongTac.Location = new System.Drawing.Point(360, 74);
            this.plTuongTac.Name = "plTuongTac";
            this.plTuongTac.Size = new System.Drawing.Size(310, 272);
            this.plTuongTac.TabIndex = 116;
            // 
            // plTuongTacComment
            // 
            this.plTuongTacComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTuongTacComment.Controls.Add(this.linkLabel1);
            this.plTuongTacComment.Controls.Add(this.label17);
            this.plTuongTacComment.Controls.Add(this.txtComment);
            this.plTuongTacComment.Controls.Add(this.lblStatusComment);
            this.plTuongTacComment.Location = new System.Drawing.Point(25, 113);
            this.plTuongTacComment.Name = "plTuongTacComment";
            this.plTuongTacComment.Size = new System.Drawing.Size(278, 151);
            this.plTuongTacComment.TabIndex = 93;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(166, 130);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 21);
            this.linkLabel1.TabIndex = 189;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Random icon";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 130);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 21);
            this.label17.TabIndex = 188;
            this.label17.Text = "Spin content: {a|b|c}";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(7, 27);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComment.Size = new System.Drawing.Size(261, 100);
            this.txtComment.TabIndex = 1;
            this.txtComment.WordWrap = false;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged_1);
            // 
            // lblStatusComment
            // 
            this.lblStatusComment.AutoSize = true;
            this.lblStatusComment.Location = new System.Drawing.Point(3, 5);
            this.lblStatusComment.Name = "lblStatusComment";
            this.lblStatusComment.Size = new System.Drawing.Size(181, 21);
            this.lblStatusComment.TabIndex = 0;
            this.lblStatusComment.Text = "Nội dung bình luận (0):";
            // 
            // ckbTuongTacComment
            // 
            this.ckbTuongTacComment.AutoSize = true;
            this.ckbTuongTacComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacComment.Location = new System.Drawing.Point(7, 88);
            this.ckbTuongTacComment.Name = "ckbTuongTacComment";
            this.ckbTuongTacComment.Size = new System.Drawing.Size(166, 25);
            this.ckbTuongTacComment.TabIndex = 92;
            this.ckbTuongTacComment.Text = "Tự động bình luận";
            this.ckbTuongTacComment.UseVisualStyleBackColor = true;
            this.ckbTuongTacComment.CheckedChanged += new System.EventHandler(this.ckbTuongTacComment_CheckedChanged);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label54.Location = new System.Drawing.Point(240, 7);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(32, 21);
            this.label54.TabIndex = 89;
            this.label54.Text = "bài";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label19.Location = new System.Drawing.Point(4, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 21);
            this.label19.TabIndex = 89;
            this.label19.Text = "Số bài viết:";
            // 
            // nudSoLuongBaiVietFrom
            // 
            this.nudSoLuongBaiVietFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoLuongBaiVietFrom.Location = new System.Drawing.Point(114, 4);
            this.nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
            this.nudSoLuongBaiVietFrom.Size = new System.Drawing.Size(42, 27);
            this.nudSoLuongBaiVietFrom.TabIndex = 2;
            // 
            // ckbTuongTacLike
            // 
            this.ckbTuongTacLike.AutoSize = true;
            this.ckbTuongTacLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacLike.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacLike.Location = new System.Drawing.Point(7, 62);
            this.ckbTuongTacLike.Name = "ckbTuongTacLike";
            this.ckbTuongTacLike.Size = new System.Drawing.Size(61, 25);
            this.ckbTuongTacLike.TabIndex = 5;
            this.ckbTuongTacLike.Text = "Like";
            this.ckbTuongTacLike.UseVisualStyleBackColor = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label46.Location = new System.Drawing.Point(4, 34);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(128, 21);
            this.label46.TabIndex = 89;
            this.label46.Text = "Thời gian delay:";
            // 
            // nudTuongTacDelayFrom
            // 
            this.nudTuongTacDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacDelayFrom.Location = new System.Drawing.Point(114, 31);
            this.nudTuongTacDelayFrom.Name = "nudTuongTacDelayFrom";
            this.nudTuongTacDelayFrom.Size = new System.Drawing.Size(42, 27);
            this.nudTuongTacDelayFrom.TabIndex = 3;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label47.Location = new System.Drawing.Point(240, 36);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(40, 21);
            this.label47.TabIndex = 91;
            this.label47.Text = "giây";
            // 
            // nudSoLuongBaiVietTo
            // 
            this.nudSoLuongBaiVietTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoLuongBaiVietTo.Location = new System.Drawing.Point(191, 5);
            this.nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
            this.nudSoLuongBaiVietTo.Size = new System.Drawing.Size(47, 27);
            this.nudSoLuongBaiVietTo.TabIndex = 4;
            // 
            // nudTuongTacDelayTo
            // 
            this.nudTuongTacDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacDelayTo.Location = new System.Drawing.Point(191, 32);
            this.nudTuongTacDelayTo.Name = "nudTuongTacDelayTo";
            this.nudTuongTacDelayTo.Size = new System.Drawing.Size(47, 27);
            this.nudTuongTacDelayTo.TabIndex = 4;
            // 
            // label67
            // 
            this.label67.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label67.Location = new System.Drawing.Point(159, 7);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(29, 16);
            this.label67.TabIndex = 91;
            this.label67.Text = "đến";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label48.Location = new System.Drawing.Point(159, 36);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(29, 16);
            this.label48.TabIndex = 91;
            this.label48.Text = "đến";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckbTuongTac
            // 
            this.ckbTuongTac.AutoSize = true;
            this.ckbTuongTac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTac.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTac.Location = new System.Drawing.Point(342, 51);
            this.ckbTuongTac.Name = "ckbTuongTac";
            this.ckbTuongTac.Size = new System.Drawing.Size(237, 25);
            this.ckbTuongTac.TabIndex = 115;
            this.ckbTuongTac.Text = "Tương tác trước khi kết bạn";
            this.ckbTuongTac.UseVisualStyleBackColor = true;
            this.ckbTuongTac.CheckedChanged += new System.EventHandler(this.ckbTuongTac_CheckedChanged);
            // 
            // txtUid
            // 
            this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUid.Location = new System.Drawing.Point(24, 163);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(295, 141);
            this.txtUid.TabIndex = 114;
            this.txtUid.Text = "";
            this.txtUid.WordWrap = false;
            this.txtUid.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // ckbTuDongXoaUid
            // 
            this.ckbTuDongXoaUid.AutoSize = true;
            this.ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuDongXoaUid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuDongXoaUid.Location = new System.Drawing.Point(23, 326);
            this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
            this.ckbTuDongXoaUid.Size = new System.Drawing.Size(320, 25);
            this.ckbTuDongXoaUid.TabIndex = 113;
            this.ckbTuDongXoaUid.Text = "Tự động xóa Uid đã gửi lời mời kết bạn";
            this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
            // 
            // nudDelayTo
            // 
            this.nudDelayTo.Location = new System.Drawing.Point(222, 111);
            this.nudDelayTo.Name = "nudDelayTo";
            this.nudDelayTo.Size = new System.Drawing.Size(56, 27);
            this.nudDelayTo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "(Mỗi Uid 1 dòng)";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 141);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(242, 21);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Danh sách Uid cần kết bạn (0):";
            // 
            // nudDelayFrom
            // 
            this.nudDelayFrom.Location = new System.Drawing.Point(125, 111);
            this.nudDelayFrom.Name = "nudDelayFrom";
            this.nudDelayFrom.Size = new System.Drawing.Size(56, 27);
            this.nudDelayFrom.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(187, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "đến";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "giây";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Thời gian chờ:";
            // 
            // nudSoLuongTo
            // 
            this.nudSoLuongTo.Location = new System.Drawing.Point(222, 80);
            this.nudSoLuongTo.Name = "nudSoLuongTo";
            this.nudSoLuongTo.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongTo.TabIndex = 2;
            // 
            // nudSoLuongFrom
            // 
            this.nudSoLuongFrom.Location = new System.Drawing.Point(125, 80);
            this.nudSoLuongFrom.Name = "nudSoLuongFrom";
            this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongFrom.TabIndex = 1;
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(194, 27);
            this.txtTenHanhDong.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(187, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "đến";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "bạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Số lượng bạn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
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
            this.btnCancel.Location = new System.Drawing.Point(355, 362);
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
            this.btnAdd.Location = new System.Drawing.Point(248, 362);
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
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 0;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 0;
            this.toolTip1.ShowAlways = true;
            // 
            // fHDKetBanTepUid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 406);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDKetBanTepUid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plTuongTac.ResumeLayout(false);
            this.plTuongTac.PerformLayout();
            this.plTuongTacComment.ResumeLayout(false);
            this.plTuongTacComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBaiVietFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBaiVietTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x0400130D RID: 4877
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400130E RID: 4878
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400130F RID: 4879
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04001310 RID: 4880
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04001311 RID: 4881
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x04001312 RID: 4882
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x04001313 RID: 4883
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04001314 RID: 4884
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04001315 RID: 4885
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04001316 RID: 4886
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04001317 RID: 4887
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001318 RID: 4888
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04001319 RID: 4889
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x0400131A RID: 4890
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x0400131B RID: 4891
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x0400131C RID: 4892
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400131D RID: 4893
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400131E RID: 4894
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x0400131F RID: 4895
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04001320 RID: 4896
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04001321 RID: 4897
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04001322 RID: 4898
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04001323 RID: 4899
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04001324 RID: 4900
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04001325 RID: 4901
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001326 RID: 4902
		private global::System.Windows.Forms.RichTextBox txtUid;

		// Token: 0x04001327 RID: 4903
		private global::System.Windows.Forms.CheckBox ckbTuDongXoaUid;

		// Token: 0x04001328 RID: 4904
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04001329 RID: 4905
		private global::System.Windows.Forms.Panel plTuongTac;

		// Token: 0x0400132A RID: 4906
		private global::System.Windows.Forms.Label label54;

		// Token: 0x0400132B RID: 4907
		private global::System.Windows.Forms.Label label19;

		// Token: 0x0400132C RID: 4908
		private global::System.Windows.Forms.NumericUpDown nudSoLuongBaiVietFrom;

		// Token: 0x0400132D RID: 4909
		private global::System.Windows.Forms.CheckBox ckbTuongTacLike;

		// Token: 0x0400132E RID: 4910
		private global::System.Windows.Forms.Label label46;

		// Token: 0x0400132F RID: 4911
		private global::System.Windows.Forms.NumericUpDown nudTuongTacDelayFrom;

		// Token: 0x04001330 RID: 4912
		private global::System.Windows.Forms.Label label47;

		// Token: 0x04001331 RID: 4913
		private global::System.Windows.Forms.NumericUpDown nudSoLuongBaiVietTo;

		// Token: 0x04001332 RID: 4914
		private global::System.Windows.Forms.NumericUpDown nudTuongTacDelayTo;

		// Token: 0x04001333 RID: 4915
		private global::System.Windows.Forms.Label label67;

		// Token: 0x04001334 RID: 4916
		private global::System.Windows.Forms.Label label48;

		// Token: 0x04001335 RID: 4917
		private global::System.Windows.Forms.CheckBox ckbTuongTac;

		// Token: 0x04001336 RID: 4918
		private global::System.Windows.Forms.Panel plTuongTacComment;

		// Token: 0x04001337 RID: 4919
		private global::System.Windows.Forms.TextBox txtComment;

		// Token: 0x04001338 RID: 4920
		private global::System.Windows.Forms.Label lblStatusComment;

		// Token: 0x04001339 RID: 4921
		private global::System.Windows.Forms.CheckBox ckbTuongTacComment;

		// Token: 0x0400133A RID: 4922
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x0400133B RID: 4923
		private global::System.Windows.Forms.Label label17;
	}
}
