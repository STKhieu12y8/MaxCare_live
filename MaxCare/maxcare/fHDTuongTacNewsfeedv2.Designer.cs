namespace maxcare
{
	// Token: 0x020000C8 RID: 200
	public partial class fHDTuongTacNewsfeedv2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000828 RID: 2088 RVA: 0x000F293C File Offset: 0x000F0B3C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x000F299C File Offset: 0x000F0B9C
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
            this.ckbAngry = new System.Windows.Forms.CheckBox();
            this.ckbSad = new System.Windows.Forms.CheckBox();
            this.ckbWow = new System.Windows.Forms.CheckBox();
            this.ckbHaha = new System.Windows.Forms.CheckBox();
            this.ckbCare = new System.Windows.Forms.CheckBox();
            this.ckbLove = new System.Windows.Forms.CheckBox();
            this.ckbLike = new System.Windows.Forms.CheckBox();
            this.plComment = new System.Windows.Forms.Panel();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.btnDown = new MetroFramework.Controls.MetroButton();
            this.btnUp = new MetroFramework.Controls.MetroButton();
            this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
            this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.plCountComment = new System.Windows.Forms.Panel();
            this.nudCountCommentFrom = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
            this.plCountLike = new System.Windows.Forms.Panel();
            this.nudCountLikeFrom = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudCountLikeTo = new System.Windows.Forms.NumericUpDown();
            this.ckbComment = new System.Windows.Forms.CheckBox();
            this.ckbInteract = new System.Windows.Forms.CheckBox();
            this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
            this.nudTimeTo = new System.Windows.Forms.NumericUpDown();
            this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.nudTimeFrom = new System.Windows.Forms.NumericUpDown();
            this.txtTenHanhDong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.plComment.SuspendLayout();
            this.plCountComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountCommentFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountCommentTo)).BeginInit();
            this.plCountLike.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLikeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLikeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeFrom)).BeginInit();
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
            this.bunifuCustomLabel1.Text = "Cấu hình Tương tác Newsfeed v2";
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.plComment);
            this.panel1.Controls.Add(this.plCountComment);
            this.panel1.Controls.Add(this.plCountLike);
            this.panel1.Controls.Add(this.ckbComment);
            this.panel1.Controls.Add(this.ckbInteract);
            this.panel1.Controls.Add(this.nudDelayTo);
            this.panel1.Controls.Add(this.nudTimeTo);
            this.panel1.Controls.Add(this.nudDelayFrom);
            this.panel1.Controls.Add(this.nudTimeFrom);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 468);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ckbAngry);
            this.panel2.Controls.Add(this.ckbSad);
            this.panel2.Controls.Add(this.ckbWow);
            this.panel2.Controls.Add(this.ckbHaha);
            this.panel2.Controls.Add(this.ckbCare);
            this.panel2.Controls.Add(this.ckbLove);
            this.panel2.Controls.Add(this.ckbLike);
            this.panel2.Location = new System.Drawing.Point(50, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 51);
            this.panel2.TabIndex = 43;
            // 
            // ckbAngry
            // 
            this.ckbAngry.AutoSize = true;
            this.ckbAngry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbAngry.Location = new System.Drawing.Point(142, 29);
            this.ckbAngry.Name = "ckbAngry";
            this.ckbAngry.Size = new System.Drawing.Size(91, 25);
            this.ckbAngry.TabIndex = 12;
            this.ckbAngry.Text = "Phẫn nộ";
            this.ckbAngry.UseVisualStyleBackColor = true;
            // 
            // ckbSad
            // 
            this.ckbSad.AutoSize = true;
            this.ckbSad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbSad.Location = new System.Drawing.Point(73, 29);
            this.ckbSad.Name = "ckbSad";
            this.ckbSad.Size = new System.Drawing.Size(69, 25);
            this.ckbSad.TabIndex = 11;
            this.ckbSad.Text = "Buồn";
            this.ckbSad.UseVisualStyleBackColor = true;
            // 
            // ckbWow
            // 
            this.ckbWow.AutoSize = true;
            this.ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbWow.Location = new System.Drawing.Point(3, 29);
            this.ckbWow.Name = "ckbWow";
            this.ckbWow.Size = new System.Drawing.Size(69, 25);
            this.ckbWow.TabIndex = 10;
            this.ckbWow.Text = "Wow";
            this.ckbWow.UseVisualStyleBackColor = true;
            // 
            // ckbHaha
            // 
            this.ckbHaha.AutoSize = true;
            this.ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbHaha.Location = new System.Drawing.Point(222, 3);
            this.ckbHaha.Name = "ckbHaha";
            this.ckbHaha.Size = new System.Drawing.Size(70, 25);
            this.ckbHaha.TabIndex = 9;
            this.ckbHaha.Text = "Haha";
            this.ckbHaha.UseVisualStyleBackColor = true;
            // 
            // ckbCare
            // 
            this.ckbCare.AutoSize = true;
            this.ckbCare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCare.Location = new System.Drawing.Point(142, 3);
            this.ckbCare.Name = "ckbCare";
            this.ckbCare.Size = new System.Drawing.Size(88, 25);
            this.ckbCare.TabIndex = 8;
            this.ckbCare.Text = "Thương";
            this.ckbCare.UseVisualStyleBackColor = true;
            // 
            // ckbLove
            // 
            this.ckbLove.AutoSize = true;
            this.ckbLove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbLove.Location = new System.Drawing.Point(73, 3);
            this.ckbLove.Name = "ckbLove";
            this.ckbLove.Size = new System.Drawing.Size(64, 25);
            this.ckbLove.TabIndex = 7;
            this.ckbLove.Text = "Tym";
            this.ckbLove.UseVisualStyleBackColor = true;
            // 
            // ckbLike
            // 
            this.ckbLike.AutoSize = true;
            this.ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbLike.Location = new System.Drawing.Point(3, 3);
            this.ckbLike.Name = "ckbLike";
            this.ckbLike.Size = new System.Drawing.Size(61, 25);
            this.ckbLike.TabIndex = 6;
            this.ckbLike.Text = "Like";
            this.ckbLike.UseVisualStyleBackColor = true;
            // 
            // plComment
            // 
            this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plComment.Controls.Add(this.txtComment);
            this.plComment.Controls.Add(this.btnDown);
            this.plComment.Controls.Add(this.btnUp);
            this.plComment.Controls.Add(this.rbNganCachKyTu);
            this.plComment.Controls.Add(this.rbNganCachMoiDong);
            this.plComment.Controls.Add(this.label8);
            this.plComment.Controls.Add(this.label15);
            this.plComment.Controls.Add(this.lblStatus);
            this.plComment.Location = new System.Drawing.Point(50, 255);
            this.plComment.Name = "plComment";
            this.plComment.Size = new System.Drawing.Size(281, 163);
            this.plComment.TabIndex = 42;
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
            this.btnDown.Visible = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Location = new System.Drawing.Point(255, -1);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(25, 25);
            this.btnUp.TabIndex = 7;
            this.btnUp.UseSelectable = true;
            this.btnUp.Visible = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // rbNganCachKyTu
            // 
            this.rbNganCachKyTu.AutoSize = true;
            this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachKyTu.Location = new System.Drawing.Point(69, 182);
            this.rbNganCachKyTu.Name = "rbNganCachKyTu";
            this.rbNganCachKyTu.Size = new System.Drawing.Size(259, 25);
            this.rbNganCachKyTu.TabIndex = 6;
            this.rbNganCachKyTu.Text = "Các nội dung ngăn cách bởi \"|\"";
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
            this.rbNganCachMoiDong.Size = new System.Drawing.Size(218, 25);
            this.rbNganCachMoiDong.TabIndex = 5;
            this.rbNganCachMoiDong.TabStop = true;
            this.rbNganCachMoiDong.Text = "Mỗi dòng là một nội dung";
            this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
            this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(this.rbNganCachMoiDong_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tùy chọn:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(342, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
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
            // plCountComment
            // 
            this.plCountComment.Controls.Add(this.nudCountCommentFrom);
            this.plCountComment.Controls.Add(this.label13);
            this.plCountComment.Controls.Add(this.label14);
            this.plCountComment.Controls.Add(this.nudCountCommentTo);
            this.plCountComment.Location = new System.Drawing.Point(136, 226);
            this.plCountComment.Name = "plCountComment";
            this.plCountComment.Size = new System.Drawing.Size(195, 25);
            this.plCountComment.TabIndex = 41;
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
            this.label13.Location = new System.Drawing.Point(157, 3);
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
            // plCountLike
            // 
            this.plCountLike.Controls.Add(this.nudCountLikeFrom);
            this.plCountLike.Controls.Add(this.label9);
            this.plCountLike.Controls.Add(this.label10);
            this.plCountLike.Controls.Add(this.nudCountLikeTo);
            this.plCountLike.Location = new System.Drawing.Point(136, 133);
            this.plCountLike.Name = "plCountLike";
            this.plCountLike.Size = new System.Drawing.Size(195, 25);
            this.plCountLike.TabIndex = 39;
            // 
            // nudCountLikeFrom
            // 
            this.nudCountLikeFrom.Location = new System.Drawing.Point(1, 1);
            this.nudCountLikeFrom.Name = "nudCountLikeFrom";
            this.nudCountLikeFrom.Size = new System.Drawing.Size(56, 27);
            this.nudCountLikeFrom.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 21);
            this.label9.TabIndex = 35;
            this.label9.Text = "lần";
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
            // ckbComment
            // 
            this.ckbComment.AutoSize = true;
            this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbComment.Location = new System.Drawing.Point(30, 228);
            this.ckbComment.Name = "ckbComment";
            this.ckbComment.Size = new System.Drawing.Size(103, 25);
            this.ckbComment.TabIndex = 7;
            this.ckbComment.Text = "Comment";
            this.ckbComment.UseVisualStyleBackColor = true;
            this.ckbComment.CheckedChanged += new System.EventHandler(this.ckbComment_CheckedChanged);
            // 
            // ckbInteract
            // 
            this.ckbInteract.AutoSize = true;
            this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbInteract.Location = new System.Drawing.Point(30, 135);
            this.ckbInteract.Name = "ckbInteract";
            this.ckbInteract.Size = new System.Drawing.Size(132, 25);
            this.ckbInteract.TabIndex = 5;
            this.ckbInteract.Text = "Thả cảm xúc:";
            this.ckbInteract.UseVisualStyleBackColor = true;
            this.ckbInteract.CheckedChanged += new System.EventHandler(this.ckbInteract_CheckedChanged);
            // 
            // nudDelayTo
            // 
            this.nudDelayTo.Location = new System.Drawing.Point(234, 105);
            this.nudDelayTo.Name = "nudDelayTo";
            this.nudDelayTo.Size = new System.Drawing.Size(56, 27);
            this.nudDelayTo.TabIndex = 4;
            // 
            // nudTimeTo
            // 
            this.nudTimeTo.Location = new System.Drawing.Point(234, 77);
            this.nudTimeTo.Name = "nudTimeTo";
            this.nudTimeTo.Size = new System.Drawing.Size(56, 27);
            this.nudTimeTo.TabIndex = 2;
            // 
            // nudDelayFrom
            // 
            this.nudDelayFrom.Location = new System.Drawing.Point(137, 105);
            this.nudDelayFrom.Name = "nudDelayFrom";
            this.nudDelayFrom.Size = new System.Drawing.Size(56, 27);
            this.nudDelayFrom.TabIndex = 3;
            // 
            // nudTimeFrom
            // 
            this.nudTimeFrom.Location = new System.Drawing.Point(137, 77);
            this.nudTimeFrom.Name = "nudTimeFrom";
            this.nudTimeFrom.Size = new System.Drawing.Size(56, 27);
            this.nudTimeFrom.TabIndex = 1;
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(137, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(194, 27);
            this.txtTenHanhDong.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(199, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "đến";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(199, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "đến";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "giây";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "giây";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Khoảng cách lướt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Thời gian lướt:";
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
            this.btnCancel.Location = new System.Drawing.Point(189, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 10;
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
            this.btnAdd.Location = new System.Drawing.Point(82, 428);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 29);
            this.btnAdd.TabIndex = 9;
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
            // fHDTuongTacNewsfeedv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 468);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDTuongTacNewsfeedv2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.plComment.ResumeLayout(false);
            this.plComment.PerformLayout();
            this.plCountComment.ResumeLayout(false);
            this.plCountComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountCommentFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountCommentTo)).EndInit();
            this.plCountLike.ResumeLayout(false);
            this.plCountLike.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLikeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLikeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04000AA6 RID: 2726
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000AA7 RID: 2727
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000AA8 RID: 2728
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000AA9 RID: 2729
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000AAA RID: 2730
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04000AAB RID: 2731
		private global::System.Windows.Forms.NumericUpDown nudTimeTo;

		// Token: 0x04000AAC RID: 2732
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04000AAD RID: 2733
		private global::System.Windows.Forms.NumericUpDown nudTimeFrom;

		// Token: 0x04000AAE RID: 2734
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000AAF RID: 2735
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000AB0 RID: 2736
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000AB1 RID: 2737
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000AB2 RID: 2738
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000AB3 RID: 2739
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000AB4 RID: 2740
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000AB5 RID: 2741
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000AB6 RID: 2742
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000AB7 RID: 2743
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000AB8 RID: 2744
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000AB9 RID: 2745
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000ABA RID: 2746
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000ABB RID: 2747
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000ABC RID: 2748
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000ABD RID: 2749
		private global::System.Windows.Forms.CheckBox ckbComment;

		// Token: 0x04000ABE RID: 2750
		private global::System.Windows.Forms.CheckBox ckbInteract;

		// Token: 0x04000ABF RID: 2751
		private global::System.Windows.Forms.Panel plCountComment;

		// Token: 0x04000AC0 RID: 2752
		private global::System.Windows.Forms.NumericUpDown nudCountCommentFrom;

		// Token: 0x04000AC1 RID: 2753
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000AC2 RID: 2754
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000AC3 RID: 2755
		private global::System.Windows.Forms.NumericUpDown nudCountCommentTo;

		// Token: 0x04000AC4 RID: 2756
		private global::System.Windows.Forms.Panel plCountLike;

		// Token: 0x04000AC5 RID: 2757
		private global::System.Windows.Forms.NumericUpDown nudCountLikeFrom;

		// Token: 0x04000AC6 RID: 2758
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000AC7 RID: 2759
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000AC8 RID: 2760
		private global::System.Windows.Forms.NumericUpDown nudCountLikeTo;

		// Token: 0x04000AC9 RID: 2761
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x04000ACA RID: 2762
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x04000ACB RID: 2763
		private global::MetroFramework.Controls.MetroButton btnDown;

		// Token: 0x04000ACC RID: 2764
		private global::MetroFramework.Controls.MetroButton btnUp;

		// Token: 0x04000ACD RID: 2765
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x04000ACE RID: 2766
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x04000ACF RID: 2767
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000AD0 RID: 2768
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000AD1 RID: 2769
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000AD2 RID: 2770
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000AD3 RID: 2771
		private global::System.Windows.Forms.CheckBox ckbAngry;

		// Token: 0x04000AD4 RID: 2772
		private global::System.Windows.Forms.CheckBox ckbSad;

		// Token: 0x04000AD5 RID: 2773
		private global::System.Windows.Forms.CheckBox ckbWow;

		// Token: 0x04000AD6 RID: 2774
		private global::System.Windows.Forms.CheckBox ckbHaha;

		// Token: 0x04000AD7 RID: 2775
		private global::System.Windows.Forms.CheckBox ckbCare;

		// Token: 0x04000AD8 RID: 2776
		private global::System.Windows.Forms.CheckBox ckbLove;

		// Token: 0x04000AD9 RID: 2777
		private global::System.Windows.Forms.CheckBox ckbLike;
	}
}
