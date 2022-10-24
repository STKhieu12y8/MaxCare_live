namespace maxcare
{
	// Token: 0x02000108 RID: 264
	public partial class fHDBuffLikeComment : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B58 RID: 2904 RVA: 0x0018A250 File Offset: 0x00188450
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0018A2B0 File Offset: 0x001884B0
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
            this.plComment = new System.Windows.Forms.Panel();
            this.plCommentText = new System.Windows.Forms.Panel();
            this.ckbAutoDeleteComment = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbCommentTheoThuTu = new System.Windows.Forms.RadioButton();
            this.rbCommentNgauNhien = new System.Windows.Forms.RadioButton();
            this.btnDown = new MetroFramework.Controls.MetroButton();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUp = new MetroFramework.Controls.MetroButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ckbCommentText = new System.Windows.Forms.CheckBox();
            this.plTag = new System.Windows.Forms.Panel();
            this.nudSoLuongTagTo = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.nudSoLuongTagFrom = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ckbTag = new System.Windows.Forms.CheckBox();
            this.label49 = new System.Windows.Forms.Label();
            this.nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
            this.label68 = new System.Windows.Forms.Label();
            this.nudSoLuongUidTo = new System.Windows.Forms.NumericUpDown();
            this.label66 = new System.Windows.Forms.Label();
            this.plAnh = new System.Windows.Forms.Panel();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdPost = new System.Windows.Forms.RichTextBox();
            this.ckbSendAnh = new System.Windows.Forms.CheckBox();
            this.ckbComment = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbShareWall = new System.Windows.Forms.CheckBox();
            this.ckbInteract = new System.Windows.Forms.CheckBox();
            this.nudTimeTo = new System.Windows.Forms.NumericUpDown();
            this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
            this.nudTimeFrom = new System.Windows.Forms.NumericUpDown();
            this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.txtTenHanhDong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.plComment.SuspendLayout();
            this.plCommentText.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.plTag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTagTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTagFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongUidFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongUidTo)).BeginInit();
            this.plAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeFrom)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(711, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Buff Like, Comment bài viết";
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
            this.pnlHeader.Size = new System.Drawing.Size(711, 31);
            this.pnlHeader.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.RosyBrown;
            this.button1.Image = global::MaxCare.Properties.Resources.close_window_25px;
            this.button1.Location = new System.Drawing.Point(680, 1);
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
            this.panel1.Controls.Add(this.plComment);
            this.panel1.Controls.Add(this.label49);
            this.panel1.Controls.Add(this.nudSoLuongUidFrom);
            this.panel1.Controls.Add(this.label68);
            this.panel1.Controls.Add(this.nudSoLuongUidTo);
            this.panel1.Controls.Add(this.label66);
            this.panel1.Controls.Add(this.plAnh);
            this.panel1.Controls.Add(this.txtIdPost);
            this.panel1.Controls.Add(this.ckbSendAnh);
            this.panel1.Controls.Add(this.ckbComment);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ckbShareWall);
            this.panel1.Controls.Add(this.ckbInteract);
            this.panel1.Controls.Add(this.nudTimeTo);
            this.panel1.Controls.Add(this.nudDelayTo);
            this.panel1.Controls.Add(this.nudTimeFrom);
            this.panel1.Controls.Add(this.nudDelayFrom);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 537);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // plComment
            // 
            this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plComment.Controls.Add(this.plCommentText);
            this.plComment.Controls.Add(this.ckbCommentText);
            this.plComment.Controls.Add(this.plTag);
            this.plComment.Controls.Add(this.ckbTag);
            this.plComment.Location = new System.Drawing.Point(371, 129);
            this.plComment.Name = "plComment";
            this.plComment.Size = new System.Drawing.Size(312, 290);
            this.plComment.TabIndex = 172;
            // 
            // plCommentText
            // 
            this.plCommentText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plCommentText.Controls.Add(this.ckbAutoDeleteComment);
            this.plCommentText.Controls.Add(this.panel2);
            this.plCommentText.Controls.Add(this.linkLabel1);
            this.plCommentText.Controls.Add(this.panel3);
            this.plCommentText.Controls.Add(this.btnDown);
            this.plCommentText.Controls.Add(this.button4);
            this.plCommentText.Controls.Add(this.btnUp);
            this.plCommentText.Controls.Add(this.label13);
            this.plCommentText.Controls.Add(this.label8);
            this.plCommentText.Controls.Add(this.txtComment);
            this.plCommentText.Controls.Add(this.label11);
            this.plCommentText.Controls.Add(this.lblStatus);
            this.plCommentText.Location = new System.Drawing.Point(22, 26);
            this.plCommentText.Name = "plCommentText";
            this.plCommentText.Size = new System.Drawing.Size(281, 195);
            this.plCommentText.TabIndex = 164;
            // 
            // ckbAutoDeleteComment
            // 
            this.ckbAutoDeleteComment.AutoSize = true;
            this.ckbAutoDeleteComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbAutoDeleteComment.Location = new System.Drawing.Point(7, 236);
            this.ckbAutoDeleteComment.Name = "ckbAutoDeleteComment";
            this.ckbAutoDeleteComment.Size = new System.Drawing.Size(289, 25);
            this.ckbAutoDeleteComment.TabIndex = 176;
            this.ckbAutoDeleteComment.Text = "Tự động xóa nội dung đã bình luận";
            this.ckbAutoDeleteComment.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbNganCachMoiDong);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.rbNganCachKyTu);
            this.panel2.Location = new System.Drawing.Point(67, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 43);
            this.panel2.TabIndex = 42;
            // 
            // rbNganCachMoiDong
            // 
            this.rbNganCachMoiDong.AutoSize = true;
            this.rbNganCachMoiDong.Checked = true;
            this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachMoiDong.Location = new System.Drawing.Point(3, 3);
            this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
            this.rbNganCachMoiDong.Size = new System.Drawing.Size(199, 25);
            this.rbNganCachMoiDong.TabIndex = 3;
            this.rbNganCachMoiDong.TabStop = true;
            this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
            this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Help;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(165, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 21);
            this.button3.TabIndex = 172;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Help;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(165, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 21);
            this.button2.TabIndex = 173;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbNganCachKyTu
            // 
            this.rbNganCachKyTu.AutoSize = true;
            this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachKyTu.Location = new System.Drawing.Point(3, 24);
            this.rbNganCachKyTu.Name = "rbNganCachKyTu";
            this.rbNganCachKyTu.Size = new System.Drawing.Size(204, 25);
            this.rbNganCachKyTu.TabIndex = 3;
            this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
            this.rbNganCachKyTu.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(167, 128);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 21);
            this.linkLabel1.TabIndex = 175;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Random icon";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbCommentTheoThuTu);
            this.panel3.Controls.Add(this.rbCommentNgauNhien);
            this.panel3.Location = new System.Drawing.Point(67, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 43);
            this.panel3.TabIndex = 43;
            // 
            // rbCommentTheoThuTu
            // 
            this.rbCommentTheoThuTu.AutoSize = true;
            this.rbCommentTheoThuTu.Checked = true;
            this.rbCommentTheoThuTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCommentTheoThuTu.Location = new System.Drawing.Point(3, 2);
            this.rbCommentTheoThuTu.Name = "rbCommentTheoThuTu";
            this.rbCommentTheoThuTu.Size = new System.Drawing.Size(259, 25);
            this.rbCommentTheoThuTu.TabIndex = 3;
            this.rbCommentTheoThuTu.TabStop = true;
            this.rbCommentTheoThuTu.Text = "Comment theo thứ tự nội dung";
            this.rbCommentTheoThuTu.UseVisualStyleBackColor = true;
            this.rbCommentTheoThuTu.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbCommentNgauNhien
            // 
            this.rbCommentNgauNhien.AutoSize = true;
            this.rbCommentNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCommentNgauNhien.Location = new System.Drawing.Point(3, 23);
            this.rbCommentNgauNhien.Name = "rbCommentNgauNhien";
            this.rbCommentNgauNhien.Size = new System.Drawing.Size(256, 25);
            this.rbCommentNgauNhien.TabIndex = 3;
            this.rbCommentNgauNhien.Text = "Comment ngẫu nhiên nội dung";
            this.rbCommentNgauNhien.UseVisualStyleBackColor = true;
            this.rbCommentNgauNhien.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnDown
            // 
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.Location = new System.Drawing.Point(224, -1);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(25, 25);
            this.btnDown.TabIndex = 40;
            this.btnDown.UseSelectable = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Help;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(249, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 21);
            this.button4.TabIndex = 173;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUp
            // 
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Location = new System.Drawing.Point(255, -1);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(25, 25);
            this.btnUp.TabIndex = 41;
            this.btnUp.UseSelectable = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tùy chọn:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tùy chọn:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(7, 25);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(263, 102);
            this.txtComment.TabIndex = 1;
            this.txtComment.Text = "";
            this.txtComment.WordWrap = false;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Spin nội dung {a|b|c}";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(153, 21);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Nội dung bình luận:";
            // 
            // ckbCommentText
            // 
            this.ckbCommentText.AutoSize = true;
            this.ckbCommentText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCommentText.Location = new System.Drawing.Point(3, 3);
            this.ckbCommentText.Name = "ckbCommentText";
            this.ckbCommentText.Size = new System.Drawing.Size(163, 25);
            this.ckbCommentText.TabIndex = 165;
            this.ckbCommentText.Text = "Bình luận văn bản";
            this.ckbCommentText.UseVisualStyleBackColor = true;
            this.ckbCommentText.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // plTag
            // 
            this.plTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTag.Controls.Add(this.nudSoLuongTagTo);
            this.plTag.Controls.Add(this.label16);
            this.plTag.Controls.Add(this.nudSoLuongTagFrom);
            this.plTag.Controls.Add(this.label15);
            this.plTag.Controls.Add(this.label14);
            this.plTag.Location = new System.Drawing.Point(22, 249);
            this.plTag.Name = "plTag";
            this.plTag.Size = new System.Drawing.Size(258, 29);
            this.plTag.TabIndex = 167;
            // 
            // nudSoLuongTagTo
            // 
            this.nudSoLuongTagTo.Location = new System.Drawing.Point(156, 3);
            this.nudSoLuongTagTo.Name = "nudSoLuongTagTo";
            this.nudSoLuongTagTo.Size = new System.Drawing.Size(51, 27);
            this.nudSoLuongTagTo.TabIndex = 174;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 21);
            this.label16.TabIndex = 175;
            this.label16.Text = "Số lượng:";
            // 
            // nudSoLuongTagFrom
            // 
            this.nudSoLuongTagFrom.Location = new System.Drawing.Point(70, 3);
            this.nudSoLuongTagFrom.Name = "nudSoLuongTagFrom";
            this.nudSoLuongTagFrom.Size = new System.Drawing.Size(51, 27);
            this.nudSoLuongTagFrom.TabIndex = 173;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(213, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 21);
            this.label15.TabIndex = 176;
            this.label15.Text = "người";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(125, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 16);
            this.label14.TabIndex = 177;
            this.label14.Text = "đến";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckbTag
            // 
            this.ckbTag.AutoSize = true;
            this.ckbTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTag.Location = new System.Drawing.Point(3, 227);
            this.ckbTag.Name = "ckbTag";
            this.ckbTag.Size = new System.Drawing.Size(115, 25);
            this.ckbTag.TabIndex = 166;
            this.ckbTag.Text = "Tag bạn bè";
            this.ckbTag.UseVisualStyleBackColor = true;
            this.ckbTag.CheckedChanged += new System.EventHandler(this.ckbTag_CheckedChanged);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label49.Location = new System.Drawing.Point(26, 108);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(141, 21);
            this.label49.TabIndex = 169;
            this.label49.Text = "Số lượng ID/Nick:";
            // 
            // nudSoLuongUidFrom
            // 
            this.nudSoLuongUidFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoLuongUidFrom.Location = new System.Drawing.Point(134, 106);
            this.nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
            this.nudSoLuongUidFrom.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongUidFrom.TabIndex = 167;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label68.Location = new System.Drawing.Point(289, 108);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(28, 21);
            this.label68.TabIndex = 170;
            this.label68.Text = "ID";
            // 
            // nudSoLuongUidTo
            // 
            this.nudSoLuongUidTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoLuongUidTo.Location = new System.Drawing.Point(231, 106);
            this.nudSoLuongUidTo.Name = "nudSoLuongUidTo";
            this.nudSoLuongUidTo.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongUidTo.TabIndex = 168;
            // 
            // label66
            // 
            this.label66.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label66.Location = new System.Drawing.Point(196, 108);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(29, 16);
            this.label66.TabIndex = 171;
            this.label66.Text = "đến";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plAnh
            // 
            this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plAnh.Controls.Add(this.txtAnh);
            this.plAnh.Controls.Add(this.label12);
            this.plAnh.Enabled = false;
            this.plAnh.Location = new System.Drawing.Point(371, 449);
            this.plAnh.Name = "plAnh";
            this.plAnh.Size = new System.Drawing.Size(312, 31);
            this.plAnh.TabIndex = 166;
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(136, 3);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(171, 27);
            this.txtAnh.TabIndex = 155;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 21);
            this.label12.TabIndex = 39;
            this.label12.Text = "Đường dẫn folder ảnh:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtIdPost
            // 
            this.txtIdPost.Location = new System.Drawing.Point(30, 152);
            this.txtIdPost.Name = "txtIdPost";
            this.txtIdPost.Size = new System.Drawing.Size(297, 320);
            this.txtIdPost.TabIndex = 1;
            this.txtIdPost.Text = "";
            this.txtIdPost.WordWrap = false;
            this.txtIdPost.TextChanged += new System.EventHandler(this.txtIdPost_TextChanged);
            // 
            // ckbSendAnh
            // 
            this.ckbSendAnh.AutoSize = true;
            this.ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbSendAnh.Location = new System.Drawing.Point(353, 425);
            this.ckbSendAnh.Name = "ckbSendAnh";
            this.ckbSendAnh.Size = new System.Drawing.Size(132, 25);
            this.ckbSendAnh.TabIndex = 165;
            this.ckbSendAnh.Text = "Bình luận ảnh";
            this.ckbSendAnh.UseVisualStyleBackColor = true;
            this.ckbSendAnh.CheckedChanged += new System.EventHandler(this.ckbSendAnh_CheckedChanged);
            // 
            // ckbComment
            // 
            this.ckbComment.AutoSize = true;
            this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbComment.Location = new System.Drawing.Point(353, 103);
            this.ckbComment.Name = "ckbComment";
            this.ckbComment.Size = new System.Drawing.Size(100, 25);
            this.ckbComment.TabIndex = 163;
            this.ckbComment.Text = "Bình luận";
            this.ckbComment.UseVisualStyleBackColor = true;
            this.ckbComment.CheckedChanged += new System.EventHandler(this.ckbComment_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 475);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 21);
            this.label10.TabIndex = 39;
            this.label10.Text = "(Mỗi ID 1 dòng)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Danh sách ID bài viết (0):";
            // 
            // ckbShareWall
            // 
            this.ckbShareWall.AutoSize = true;
            this.ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbShareWall.Location = new System.Drawing.Point(508, 79);
            this.ckbShareWall.Name = "ckbShareWall";
            this.ckbShareWall.Size = new System.Drawing.Size(183, 25);
            this.ckbShareWall.TabIndex = 6;
            this.ckbShareWall.Text = "Chia sẻ bài về tường";
            this.ckbShareWall.UseVisualStyleBackColor = true;
            // 
            // ckbInteract
            // 
            this.ckbInteract.AutoSize = true;
            this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbInteract.Location = new System.Drawing.Point(353, 79);
            this.ckbInteract.Name = "ckbInteract";
            this.ckbInteract.Size = new System.Drawing.Size(120, 25);
            this.ckbInteract.TabIndex = 5;
            this.ckbInteract.Text = "Like bài viết";
            this.ckbInteract.UseVisualStyleBackColor = true;
            // 
            // nudTimeTo
            // 
            this.nudTimeTo.Location = new System.Drawing.Point(568, 50);
            this.nudTimeTo.Name = "nudTimeTo";
            this.nudTimeTo.Size = new System.Drawing.Size(51, 27);
            this.nudTimeTo.TabIndex = 4;
            // 
            // nudDelayTo
            // 
            this.nudDelayTo.Location = new System.Drawing.Point(231, 78);
            this.nudDelayTo.Name = "nudDelayTo";
            this.nudDelayTo.Size = new System.Drawing.Size(56, 27);
            this.nudDelayTo.TabIndex = 4;
            // 
            // nudTimeFrom
            // 
            this.nudTimeFrom.Location = new System.Drawing.Point(490, 50);
            this.nudTimeFrom.Name = "nudTimeFrom";
            this.nudTimeFrom.Size = new System.Drawing.Size(51, 27);
            this.nudTimeFrom.TabIndex = 3;
            // 
            // nudDelayFrom
            // 
            this.nudDelayFrom.Location = new System.Drawing.Point(134, 78);
            this.nudDelayFrom.Name = "nudDelayFrom";
            this.nudDelayFrom.Size = new System.Drawing.Size(56, 27);
            this.nudDelayFrom.TabIndex = 3;
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(134, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(194, 27);
            this.txtTenHanhDong.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(541, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "đến";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(196, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "đến";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = "giây";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "giây";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Thời gian xem bài viết:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Thời gian chờ:";
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
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(349, 495);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(242, 495);
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
            this.bunifuCards1.Size = new System.Drawing.Size(711, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDBuffLikeComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 537);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDBuffLikeComment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plComment.ResumeLayout(false);
            this.plComment.PerformLayout();
            this.plCommentText.ResumeLayout(false);
            this.plCommentText.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.plTag.ResumeLayout(false);
            this.plTag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTagTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTagFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongUidFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongUidTo)).EndInit();
            this.plAnh.ResumeLayout(false);
            this.plAnh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04001139 RID: 4409
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400113A RID: 4410
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400113B RID: 4411
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x0400113C RID: 4412
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400113D RID: 4413
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x0400113E RID: 4414
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x0400113F RID: 4415
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04001140 RID: 4416
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04001141 RID: 4417
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04001142 RID: 4418
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001143 RID: 4419
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001144 RID: 4420
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04001145 RID: 4421
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04001146 RID: 4422
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04001147 RID: 4423
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04001148 RID: 4424
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04001149 RID: 4425
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400114A RID: 4426
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x0400114B RID: 4427
		private global::System.Windows.Forms.CheckBox ckbInteract;

		// Token: 0x0400114C RID: 4428
		private global::System.Windows.Forms.CheckBox ckbShareWall;

		// Token: 0x0400114D RID: 4429
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400114E RID: 4430
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400114F RID: 4431
		private global::System.Windows.Forms.NumericUpDown nudTimeTo;

		// Token: 0x04001150 RID: 4432
		private global::System.Windows.Forms.NumericUpDown nudTimeFrom;

		// Token: 0x04001151 RID: 4433
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04001152 RID: 4434
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04001153 RID: 4435
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04001154 RID: 4436
		private global::System.Windows.Forms.Panel plCommentText;

		// Token: 0x04001155 RID: 4437
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x04001156 RID: 4438
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x04001157 RID: 4439
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04001158 RID: 4440
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x04001159 RID: 4441
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400115A RID: 4442
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x0400115B RID: 4443
		private global::System.Windows.Forms.Panel plAnh;

		// Token: 0x0400115C RID: 4444
		private global::System.Windows.Forms.TextBox txtAnh;

		// Token: 0x0400115D RID: 4445
		private global::System.Windows.Forms.RichTextBox txtIdPost;

		// Token: 0x0400115E RID: 4446
		private global::System.Windows.Forms.CheckBox ckbSendAnh;

		// Token: 0x0400115F RID: 4447
		private global::System.Windows.Forms.CheckBox ckbComment;

		// Token: 0x04001160 RID: 4448
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04001161 RID: 4449
		private global::System.Windows.Forms.Label label49;

		// Token: 0x04001162 RID: 4450
		private global::System.Windows.Forms.NumericUpDown nudSoLuongUidFrom;

		// Token: 0x04001163 RID: 4451
		private global::System.Windows.Forms.Label label68;

		// Token: 0x04001164 RID: 4452
		private global::System.Windows.Forms.NumericUpDown nudSoLuongUidTo;

		// Token: 0x04001165 RID: 4453
		private global::System.Windows.Forms.Label label66;

		// Token: 0x04001166 RID: 4454
		private global::System.Windows.Forms.RadioButton rbCommentNgauNhien;

		// Token: 0x04001167 RID: 4455
		private global::System.Windows.Forms.RadioButton rbCommentTheoThuTu;

		// Token: 0x04001168 RID: 4456
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04001169 RID: 4457
		private global::MetroFramework.Controls.MetroButton btnDown;

		// Token: 0x0400116A RID: 4458
		private global::MetroFramework.Controls.MetroButton btnUp;

		// Token: 0x0400116B RID: 4459
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400116C RID: 4460
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x0400116D RID: 4461
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400116E RID: 4462
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400116F RID: 4463
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04001170 RID: 4464
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04001171 RID: 4465
		private global::System.Windows.Forms.CheckBox ckbAutoDeleteComment;

		// Token: 0x04001172 RID: 4466
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x04001173 RID: 4467
		private global::System.Windows.Forms.CheckBox ckbCommentText;

		// Token: 0x04001174 RID: 4468
		private global::System.Windows.Forms.Panel plTag;

		// Token: 0x04001175 RID: 4469
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTagTo;

		// Token: 0x04001176 RID: 4470
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04001177 RID: 4471
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTagFrom;

		// Token: 0x04001178 RID: 4472
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04001179 RID: 4473
		private global::System.Windows.Forms.Label label14;

		// Token: 0x0400117A RID: 4474
		private global::System.Windows.Forms.CheckBox ckbTag;
	}
}
