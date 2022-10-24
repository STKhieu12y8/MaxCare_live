namespace maxcare
{
	// Token: 0x0200011E RID: 286
	public partial class fHDXemWatch : global::System.Windows.Forms.Form
	{
		// Token: 0x06000C9B RID: 3227 RVA: 0x001CFA8C File Offset: 0x001CDC8C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x001CFAEC File Offset: 0x001CDCEC
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
            this.plFollow = new System.Windows.Forms.Panel();
            this.nudFollowFrom = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nudFollowTo = new System.Windows.Forms.NumericUpDown();
            this.ckbFollow = new System.Windows.Forms.CheckBox();
            this.plCountComment = new System.Windows.Forms.Panel();
            this.nudCountCommentFrom = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
            this.plCountShareWall = new System.Windows.Forms.Panel();
            this.nudCountShareFrom = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudCountShareTo = new System.Windows.Forms.NumericUpDown();
            this.plCountLike = new System.Windows.Forms.Panel();
            this.nudCountLikeFrom = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudCountLikeTo = new System.Windows.Forms.NumericUpDown();
            this.plComment = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ckbComment = new System.Windows.Forms.CheckBox();
            this.ckbShareWall = new System.Windows.Forms.CheckBox();
            this.ckbInteract = new System.Windows.Forms.CheckBox();
            this.nudTimeWatchTo = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.nudTimeWatchFrom = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
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
            this.plFollow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFollowFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFollowTo)).BeginInit();
            this.plCountComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountCommentFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountCommentTo)).BeginInit();
            this.plCountShareWall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountShareFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountShareTo)).BeginInit();
            this.plCountLike.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLikeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLikeTo)).BeginInit();
            this.plComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeWatchTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeWatchFrom)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Xem Watch";
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.plFollow);
            this.panel1.Controls.Add(this.ckbFollow);
            this.panel1.Controls.Add(this.plCountComment);
            this.panel1.Controls.Add(this.plCountShareWall);
            this.panel1.Controls.Add(this.plCountLike);
            this.panel1.Controls.Add(this.plComment);
            this.panel1.Controls.Add(this.ckbComment);
            this.panel1.Controls.Add(this.ckbShareWall);
            this.panel1.Controls.Add(this.ckbInteract);
            this.panel1.Controls.Add(this.nudTimeWatchTo);
            this.panel1.Controls.Add(this.nudSoLuongTo);
            this.panel1.Controls.Add(this.nudTimeWatchFrom);
            this.panel1.Controls.Add(this.nudSoLuongFrom);
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
            this.panel1.Size = new System.Drawing.Size(362, 470);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // plFollow
            // 
            this.plFollow.Controls.Add(this.nudFollowFrom);
            this.plFollow.Controls.Add(this.label15);
            this.plFollow.Controls.Add(this.label16);
            this.plFollow.Controls.Add(this.nudFollowTo);
            this.plFollow.Location = new System.Drawing.Point(132, 212);
            this.plFollow.Name = "plFollow";
            this.plFollow.Size = new System.Drawing.Size(200, 25);
            this.plFollow.TabIndex = 46;
            // 
            // nudFollowFrom
            // 
            this.nudFollowFrom.Location = new System.Drawing.Point(1, 1);
            this.nudFollowFrom.Name = "nudFollowFrom";
            this.nudFollowFrom.Size = new System.Drawing.Size(56, 27);
            this.nudFollowFrom.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(159, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 21);
            this.label15.TabIndex = 35;
            this.label15.Text = "page";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(63, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 16);
            this.label16.TabIndex = 37;
            this.label16.Text = "đến";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudFollowTo
            // 
            this.nudFollowTo.Location = new System.Drawing.Point(98, 1);
            this.nudFollowTo.Name = "nudFollowTo";
            this.nudFollowTo.Size = new System.Drawing.Size(56, 27);
            this.nudFollowTo.TabIndex = 2;
            // 
            // ckbFollow
            // 
            this.ckbFollow.AutoSize = true;
            this.ckbFollow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbFollow.Location = new System.Drawing.Point(30, 214);
            this.ckbFollow.Name = "ckbFollow";
            this.ckbFollow.Size = new System.Drawing.Size(80, 25);
            this.ckbFollow.TabIndex = 45;
            this.ckbFollow.Text = "Follow";
            this.ckbFollow.UseVisualStyleBackColor = true;
            this.ckbFollow.CheckedChanged += new System.EventHandler(this.ckbFollow_CheckedChanged);
            // 
            // plCountComment
            // 
            this.plCountComment.Controls.Add(this.nudCountCommentFrom);
            this.plCountComment.Controls.Add(this.label13);
            this.plCountComment.Controls.Add(this.label14);
            this.plCountComment.Controls.Add(this.nudCountCommentTo);
            this.plCountComment.Location = new System.Drawing.Point(132, 186);
            this.plCountComment.Name = "plCountComment";
            this.plCountComment.Size = new System.Drawing.Size(200, 25);
            this.plCountComment.TabIndex = 44;
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
            this.label13.Location = new System.Drawing.Point(159, 3);
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
            // plCountShareWall
            // 
            this.plCountShareWall.Controls.Add(this.nudCountShareFrom);
            this.plCountShareWall.Controls.Add(this.label11);
            this.plCountShareWall.Controls.Add(this.label12);
            this.plCountShareWall.Controls.Add(this.nudCountShareTo);
            this.plCountShareWall.Location = new System.Drawing.Point(132, 158);
            this.plCountShareWall.Name = "plCountShareWall";
            this.plCountShareWall.Size = new System.Drawing.Size(200, 25);
            this.plCountShareWall.TabIndex = 43;
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
            this.label11.Location = new System.Drawing.Point(159, 3);
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
            // plCountLike
            // 
            this.plCountLike.Controls.Add(this.nudCountLikeFrom);
            this.plCountLike.Controls.Add(this.label9);
            this.plCountLike.Controls.Add(this.label10);
            this.plCountLike.Controls.Add(this.nudCountLikeTo);
            this.plCountLike.Location = new System.Drawing.Point(132, 130);
            this.plCountLike.Name = "plCountLike";
            this.plCountLike.Size = new System.Drawing.Size(200, 25);
            this.plCountLike.TabIndex = 42;
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
            this.label9.Location = new System.Drawing.Point(159, 3);
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
            // plComment
            // 
            this.plComment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plComment.Controls.Add(this.linkLabel1);
            this.plComment.Controls.Add(this.button2);
            this.plComment.Controls.Add(this.txtComment);
            this.plComment.Controls.Add(this.label8);
            this.plComment.Controls.Add(this.lblStatus);
            this.plComment.Location = new System.Drawing.Point(48, 249);
            this.plComment.Name = "plComment";
            this.plComment.Size = new System.Drawing.Size(278, 164);
            this.plComment.TabIndex = 8;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(165, 4);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 21);
            this.linkLabel1.TabIndex = 48;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Random icon";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Help;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(247, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(6, 24);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(264, 114);
            this.txtComment.TabIndex = 45;
            this.txtComment.Text = "";
            this.txtComment.WordWrap = false;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(342, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
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
            // ckbComment
            // 
            this.ckbComment.AutoSize = true;
            this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbComment.Location = new System.Drawing.Point(30, 188);
            this.ckbComment.Name = "ckbComment";
            this.ckbComment.Size = new System.Drawing.Size(103, 25);
            this.ckbComment.TabIndex = 7;
            this.ckbComment.Text = "Comment";
            this.ckbComment.UseVisualStyleBackColor = true;
            this.ckbComment.CheckedChanged += new System.EventHandler(this.ckbComment_CheckedChanged);
            // 
            // ckbShareWall
            // 
            this.ckbShareWall.AutoSize = true;
            this.ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbShareWall.Location = new System.Drawing.Point(30, 160);
            this.ckbShareWall.Name = "ckbShareWall";
            this.ckbShareWall.Size = new System.Drawing.Size(111, 25);
            this.ckbShareWall.TabIndex = 6;
            this.ckbShareWall.Text = "Share Wall";
            this.ckbShareWall.UseVisualStyleBackColor = true;
            this.ckbShareWall.CheckedChanged += new System.EventHandler(this.ckbShareWall_CheckedChanged);
            // 
            // ckbInteract
            // 
            this.ckbInteract.AutoSize = true;
            this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbInteract.Location = new System.Drawing.Point(30, 132);
            this.ckbInteract.Name = "ckbInteract";
            this.ckbInteract.Size = new System.Drawing.Size(61, 25);
            this.ckbInteract.TabIndex = 5;
            this.ckbInteract.Text = "Like";
            this.ckbInteract.UseVisualStyleBackColor = true;
            this.ckbInteract.CheckedChanged += new System.EventHandler(this.ckbInteract_CheckedChanged_1);
            // 
            // nudTimeWatchTo
            // 
            this.nudTimeWatchTo.Location = new System.Drawing.Point(229, 103);
            this.nudTimeWatchTo.Name = "nudTimeWatchTo";
            this.nudTimeWatchTo.Size = new System.Drawing.Size(56, 27);
            this.nudTimeWatchTo.TabIndex = 4;
            // 
            // nudSoLuongTo
            // 
            this.nudSoLuongTo.Location = new System.Drawing.Point(229, 76);
            this.nudSoLuongTo.Name = "nudSoLuongTo";
            this.nudSoLuongTo.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongTo.TabIndex = 2;
            // 
            // nudTimeWatchFrom
            // 
            this.nudTimeWatchFrom.Location = new System.Drawing.Point(132, 103);
            this.nudTimeWatchFrom.Name = "nudTimeWatchFrom";
            this.nudTimeWatchFrom.Size = new System.Drawing.Size(56, 27);
            this.nudTimeWatchFrom.TabIndex = 3;
            // 
            // nudSoLuongFrom
            // 
            this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 76);
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
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(194, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "đến";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(194, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "đến";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "giây";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "video";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Thời gian xem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Số lượng video:";
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
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            // fHDXemWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 470);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDXemWatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plFollow.ResumeLayout(false);
            this.plFollow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFollowFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFollowTo)).EndInit();
            this.plCountComment.ResumeLayout(false);
            this.plCountComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountCommentFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountCommentTo)).EndInit();
            this.plCountShareWall.ResumeLayout(false);
            this.plCountShareWall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountShareFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountShareTo)).EndInit();
            this.plCountLike.ResumeLayout(false);
            this.plCountLike.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLikeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLikeTo)).EndInit();
            this.plComment.ResumeLayout(false);
            this.plComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeWatchTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeWatchFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x040014B6 RID: 5302
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040014B7 RID: 5303
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040014B8 RID: 5304
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x040014B9 RID: 5305
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040014BA RID: 5306
		private global::System.Windows.Forms.NumericUpDown nudTimeWatchTo;

		// Token: 0x040014BB RID: 5307
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x040014BC RID: 5308
		private global::System.Windows.Forms.NumericUpDown nudTimeWatchFrom;

		// Token: 0x040014BD RID: 5309
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x040014BE RID: 5310
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x040014BF RID: 5311
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040014C0 RID: 5312
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040014C1 RID: 5313
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040014C2 RID: 5314
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040014C3 RID: 5315
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040014C4 RID: 5316
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040014C5 RID: 5317
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040014C6 RID: 5318
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040014C7 RID: 5319
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040014C8 RID: 5320
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040014C9 RID: 5321
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040014CA RID: 5322
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040014CB RID: 5323
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040014CC RID: 5324
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040014CD RID: 5325
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x040014CE RID: 5326
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040014CF RID: 5327
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x040014D0 RID: 5328
		private global::System.Windows.Forms.CheckBox ckbComment;

		// Token: 0x040014D1 RID: 5329
		private global::System.Windows.Forms.CheckBox ckbInteract;

		// Token: 0x040014D2 RID: 5330
		private global::System.Windows.Forms.CheckBox ckbShareWall;

		// Token: 0x040014D3 RID: 5331
		private global::System.Windows.Forms.Panel plCountComment;

		// Token: 0x040014D4 RID: 5332
		private global::System.Windows.Forms.NumericUpDown nudCountCommentFrom;

		// Token: 0x040014D5 RID: 5333
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040014D6 RID: 5334
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040014D7 RID: 5335
		private global::System.Windows.Forms.NumericUpDown nudCountCommentTo;

		// Token: 0x040014D8 RID: 5336
		private global::System.Windows.Forms.Panel plCountShareWall;

		// Token: 0x040014D9 RID: 5337
		private global::System.Windows.Forms.NumericUpDown nudCountShareFrom;

		// Token: 0x040014DA RID: 5338
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040014DB RID: 5339
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040014DC RID: 5340
		private global::System.Windows.Forms.NumericUpDown nudCountShareTo;

		// Token: 0x040014DD RID: 5341
		private global::System.Windows.Forms.Panel plCountLike;

		// Token: 0x040014DE RID: 5342
		private global::System.Windows.Forms.NumericUpDown nudCountLikeFrom;

		// Token: 0x040014DF RID: 5343
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040014E0 RID: 5344
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040014E1 RID: 5345
		private global::System.Windows.Forms.NumericUpDown nudCountLikeTo;

		// Token: 0x040014E2 RID: 5346
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x040014E3 RID: 5347
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040014E4 RID: 5348
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x040014E5 RID: 5349
		private global::System.Windows.Forms.Panel plFollow;

		// Token: 0x040014E6 RID: 5350
		private global::System.Windows.Forms.NumericUpDown nudFollowFrom;

		// Token: 0x040014E7 RID: 5351
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040014E8 RID: 5352
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040014E9 RID: 5353
		private global::System.Windows.Forms.NumericUpDown nudFollowTo;

		// Token: 0x040014EA RID: 5354
		private global::System.Windows.Forms.CheckBox ckbFollow;
	}
}
