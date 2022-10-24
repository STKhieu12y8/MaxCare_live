namespace maxcare
{
	// Token: 0x020000BA RID: 186
	public partial class fHDBaiVietProfile : global::System.Windows.Forms.Form
	{
		// Token: 0x06000746 RID: 1862 RVA: 0x000C23C0 File Offset: 0x000C05C0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x000C2420 File Offset: 0x000C0620
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnChooseFileUid = new System.Windows.Forms.Button();
            this.rbListUid = new System.Windows.Forms.RadioButton();
            this.rbFileUid = new System.Windows.Forms.RadioButton();
            this.plComment = new System.Windows.Forms.Panel();
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
            this.ckbRandomGoVanBan = new System.Windows.Forms.CheckBox();
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
            this.bunifuCustomLabel1.Text = "Cấu hình Bài viết Profile";
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
            this.panel1.Controls.Add(this.ckbRandomGoVanBan);
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
            this.panel1.Size = new System.Drawing.Size(683, 432);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.plComment.Location = new System.Drawing.Point(369, 128);
            this.plComment.Name = "plComment";
            this.plComment.Size = new System.Drawing.Size(281, 193);
            this.plComment.TabIndex = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(163, 126);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 21);
            this.linkLabel1.TabIndex = 187;
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
            this.label2.TabIndex = 186;
            this.label2.Text = "Spin content: {a|b|c}";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Help;
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(247, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 185;
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
            this.rbNganCachKyTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbNganCachKyTu.AutoSize = true;
            this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachKyTu.Location = new System.Drawing.Point(70, 163);
            this.rbNganCachKyTu.Name = "rbNganCachKyTu";
            this.rbNganCachKyTu.Size = new System.Drawing.Size(204, 25);
            this.rbNganCachKyTu.TabIndex = 3;
            this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
            this.rbNganCachKyTu.UseVisualStyleBackColor = true;
            this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(this.rbNganCachKyTu_CheckedChanged);
            // 
            // rbNganCachMoiDong
            // 
            this.rbNganCachMoiDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbNganCachMoiDong.AutoSize = true;
            this.rbNganCachMoiDong.Checked = true;
            this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachMoiDong.Location = new System.Drawing.Point(70, 142);
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
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tùy chọn:";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // plAnh
            // 
            this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plAnh.Controls.Add(this.txtAnh);
            this.plAnh.Controls.Add(this.label12);
            this.plAnh.Enabled = false;
            this.plAnh.Location = new System.Drawing.Point(369, 349);
            this.plAnh.Name = "plAnh";
            this.plAnh.Size = new System.Drawing.Size(281, 31);
            this.plAnh.TabIndex = 162;
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(136, 3);
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
            this.ckbSendAnh.Location = new System.Drawing.Point(351, 327);
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
            this.ckbComment.Location = new System.Drawing.Point(351, 103);
            this.ckbComment.Name = "ckbComment";
            this.ckbComment.Size = new System.Drawing.Size(163, 25);
            this.ckbComment.TabIndex = 9;
            this.ckbComment.Text = "Bình luận văn bản";
            this.ckbComment.UseVisualStyleBackColor = true;
            this.ckbComment.CheckedChanged += new System.EventHandler(this.ckbComment_CheckedChanged);
            // 
            // ckbRandomGoVanBan
            // 
            this.ckbRandomGoVanBan.AutoSize = true;
            this.ckbRandomGoVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbRandomGoVanBan.Location = new System.Drawing.Point(31, 383);
            this.ckbRandomGoVanBan.Name = "ckbRandomGoVanBan";
            this.ckbRandomGoVanBan.Size = new System.Drawing.Size(179, 25);
            this.ckbRandomGoVanBan.TabIndex = 8;
            this.ckbRandomGoVanBan.Text = "Random gõ văn bản";
            this.ckbRandomGoVanBan.UseVisualStyleBackColor = true;
            this.ckbRandomGoVanBan.Visible = false;
            // 
            // ckbTuDongXoaUid
            // 
            this.ckbTuDongXoaUid.AutoSize = true;
            this.ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuDongXoaUid.Location = new System.Drawing.Point(31, 357);
            this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
            this.ckbTuDongXoaUid.Size = new System.Drawing.Size(397, 25);
            this.ckbTuDongXoaUid.TabIndex = 8;
            this.ckbTuDongXoaUid.Text = "Tự động xóa Uid đã tương tác (Không trùng UID)";
            this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
            // 
            // ckbShareWall
            // 
            this.ckbShareWall.AutoSize = true;
            this.ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbShareWall.Location = new System.Drawing.Point(351, 77);
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
            this.ckbInteract.Location = new System.Drawing.Point(351, 51);
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
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(349, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 12;
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
            this.btnAdd.Location = new System.Drawing.Point(242, 390);
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
            // fHDBaiVietProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 432);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDBaiVietProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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

		// Token: 0x0400083C RID: 2108
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400083D RID: 2109
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400083E RID: 2110
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x0400083F RID: 2111
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000840 RID: 2112
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04000841 RID: 2113
		private global::System.Windows.Forms.NumericUpDown nudSoLuongBaiVietTo;

		// Token: 0x04000842 RID: 2114
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04000843 RID: 2115
		private global::System.Windows.Forms.NumericUpDown nudSoLuongBaiVietFrom;

		// Token: 0x04000844 RID: 2116
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000845 RID: 2117
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000846 RID: 2118
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000847 RID: 2119
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000848 RID: 2120
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000849 RID: 2121
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400084A RID: 2122
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400084B RID: 2123
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x0400084C RID: 2124
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x0400084D RID: 2125
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x0400084E RID: 2126
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x0400084F RID: 2127
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000850 RID: 2128
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000851 RID: 2129
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000852 RID: 2130
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x04000853 RID: 2131
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000854 RID: 2132
		private global::System.Windows.Forms.CheckBox ckbComment;

		// Token: 0x04000855 RID: 2133
		private global::System.Windows.Forms.CheckBox ckbInteract;

		// Token: 0x04000856 RID: 2134
		private global::System.Windows.Forms.CheckBox ckbShareWall;

		// Token: 0x04000857 RID: 2135
		private global::System.Windows.Forms.Label label49;

		// Token: 0x04000858 RID: 2136
		private global::System.Windows.Forms.NumericUpDown nudSoLuongUidFrom;

		// Token: 0x04000859 RID: 2137
		private global::System.Windows.Forms.Label label68;

		// Token: 0x0400085A RID: 2138
		private global::System.Windows.Forms.Label label19;

		// Token: 0x0400085B RID: 2139
		private global::System.Windows.Forms.NumericUpDown nudSoLuongUidTo;

		// Token: 0x0400085C RID: 2140
		private global::System.Windows.Forms.Label label66;

		// Token: 0x0400085D RID: 2141
		private global::System.Windows.Forms.RichTextBox txtUid;

		// Token: 0x0400085E RID: 2142
		private global::System.Windows.Forms.Panel plAnh;

		// Token: 0x0400085F RID: 2143
		private global::System.Windows.Forms.CheckBox ckbSendAnh;

		// Token: 0x04000860 RID: 2144
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x04000861 RID: 2145
		private global::System.Windows.Forms.CheckBox ckbTuDongXoaUid;

		// Token: 0x04000862 RID: 2146
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x04000863 RID: 2147
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x04000864 RID: 2148
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000865 RID: 2149
		private global::System.Windows.Forms.CheckBox ckbRandomGoVanBan;

		// Token: 0x04000866 RID: 2150
		private global::System.Windows.Forms.Button btnChooseFileUid;

		// Token: 0x04000867 RID: 2151
		private global::System.Windows.Forms.RadioButton rbListUid;

		// Token: 0x04000868 RID: 2152
		private global::System.Windows.Forms.RadioButton rbFileUid;

		// Token: 0x04000869 RID: 2153
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400086A RID: 2154
		private global::System.Windows.Forms.TextBox txtPathFileUid;

		// Token: 0x0400086B RID: 2155
		private global::System.Windows.Forms.TextBox txtAnh;

		// Token: 0x0400086C RID: 2156
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400086D RID: 2157
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400086E RID: 2158
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400086F RID: 2159
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000870 RID: 2160
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04000871 RID: 2161
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000872 RID: 2162
		private global::System.Windows.Forms.Button button5;
	}
}
