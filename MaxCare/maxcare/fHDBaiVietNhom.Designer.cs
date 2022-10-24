namespace maxcare
{
	// Token: 0x0200010A RID: 266
	public partial class fHDBaiVietNhom : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B82 RID: 2946 RVA: 0x00192F44 File Offset: 0x00191144
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00192FA4 File Offset: 0x001911A4
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
            this.ckbVip = new System.Windows.Forms.CheckBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.plAnh = new System.Windows.Forms.Panel();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbSendAnh = new System.Windows.Forms.CheckBox();
            this.plComment = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.btnDown = new MetroFramework.Controls.MetroButton();
            this.btnUp = new MetroFramework.Controls.MetroButton();
            this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
            this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.nudSoLuongNhomFrom = new System.Windows.Forms.NumericUpDown();
            this.label68 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nudSoLuongNhomTo = new System.Windows.Forms.NumericUpDown();
            this.label66 = new System.Windows.Forms.Label();
            this.ckbComment = new System.Windows.Forms.CheckBox();
            this.ckbShareWall = new System.Windows.Forms.CheckBox();
            this.ckbInteract = new System.Windows.Forms.CheckBox();
            this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
            this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
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
            this.plAnh.SuspendLayout();
            this.plComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongNhomFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongNhomTo)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(665, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Bài viết Nhóm";
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
            this.pnlHeader.Size = new System.Drawing.Size(665, 31);
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
            this.button1.Location = new System.Drawing.Point(634, 1);
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
            this.panel1.Controls.Add(this.plAnh);
            this.panel1.Controls.Add(this.ckbSendAnh);
            this.panel1.Controls.Add(this.plComment);
            this.panel1.Controls.Add(this.label49);
            this.panel1.Controls.Add(this.nudSoLuongNhomFrom);
            this.panel1.Controls.Add(this.label68);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.nudSoLuongNhomTo);
            this.panel1.Controls.Add(this.label66);
            this.panel1.Controls.Add(this.ckbComment);
            this.panel1.Controls.Add(this.ckbShareWall);
            this.panel1.Controls.Add(this.ckbInteract);
            this.panel1.Controls.Add(this.nudDelayTo);
            this.panel1.Controls.Add(this.nudSoLuongBaiVietTo);
            this.panel1.Controls.Add(this.nudDelayFrom);
            this.panel1.Controls.Add(this.nudSoLuongBaiVietFrom);
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
            this.panel1.Size = new System.Drawing.Size(668, 325);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ckbVip);
            this.panel2.Controls.Add(this.btnNhap);
            this.panel2.Location = new System.Drawing.Point(30, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 30);
            this.panel2.TabIndex = 167;
            this.panel2.Visible = false;
            // 
            // ckbVip
            // 
            this.ckbVip.AutoSize = true;
            this.ckbVip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbVip.Location = new System.Drawing.Point(3, 4);
            this.ckbVip.Name = "ckbVip";
            this.ckbVip.Size = new System.Drawing.Size(55, 25);
            this.ckbVip.TabIndex = 165;
            this.ckbVip.Text = "Vip";
            this.ckbVip.UseVisualStyleBackColor = true;
            this.ckbVip.CheckedChanged += new System.EventHandler(this.ckbVip_CheckedChanged);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(54, 2);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 166;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // plAnh
            // 
            this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plAnh.Controls.Add(this.txtAnh);
            this.plAnh.Controls.Add(this.label2);
            this.plAnh.Enabled = false;
            this.plAnh.Location = new System.Drawing.Point(48, 217);
            this.plAnh.Name = "plAnh";
            this.plAnh.Size = new System.Drawing.Size(281, 31);
            this.plAnh.TabIndex = 164;
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(138, 3);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(137, 27);
            this.txtAnh.TabIndex = 155;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 101;
            this.label2.Text = "Đường dẫn folder ảnh:";
            // 
            // ckbSendAnh
            // 
            this.ckbSendAnh.AutoSize = true;
            this.ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbSendAnh.Location = new System.Drawing.Point(30, 195);
            this.ckbSendAnh.Name = "ckbSendAnh";
            this.ckbSendAnh.Size = new System.Drawing.Size(132, 25);
            this.ckbSendAnh.TabIndex = 163;
            this.ckbSendAnh.Text = "Bình luận ảnh";
            this.ckbSendAnh.UseVisualStyleBackColor = true;
            this.ckbSendAnh.CheckedChanged += new System.EventHandler(this.ckbSendAnh_CheckedChanged);
            // 
            // plComment
            // 
            this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plComment.Controls.Add(this.linkLabel1);
            this.plComment.Controls.Add(this.button4);
            this.plComment.Controls.Add(this.button5);
            this.plComment.Controls.Add(this.button3);
            this.plComment.Controls.Add(this.txtComment);
            this.plComment.Controls.Add(this.btnDown);
            this.plComment.Controls.Add(this.btnUp);
            this.plComment.Controls.Add(this.rbNganCachKyTu);
            this.plComment.Controls.Add(this.rbNganCachMoiDong);
            this.plComment.Controls.Add(this.label9);
            this.plComment.Controls.Add(this.label8);
            this.plComment.Controls.Add(this.lblStatus);
            this.plComment.Location = new System.Drawing.Point(369, 84);
            this.plComment.Name = "plComment";
            this.plComment.Size = new System.Drawing.Size(281, 164);
            this.plComment.TabIndex = 106;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(167, 141);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 21);
            this.linkLabel1.TabIndex = 182;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Random icon";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Help;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(226, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 23);
            this.button4.TabIndex = 166;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Help;
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(226, 160);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 23);
            this.button5.TabIndex = 167;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Help;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(250, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 165;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
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
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label49.Location = new System.Drawing.Point(27, 81);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(126, 21);
            this.label49.TabIndex = 92;
            this.label49.Text = "Số lượng nhóm:";
            // 
            // nudSoLuongNhomFrom
            // 
            this.nudSoLuongNhomFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoLuongNhomFrom.Location = new System.Drawing.Point(135, 79);
            this.nudSoLuongNhomFrom.Name = "nudSoLuongNhomFrom";
            this.nudSoLuongNhomFrom.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongNhomFrom.TabIndex = 1;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label68.Location = new System.Drawing.Point(293, 81);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(51, 21);
            this.label68.TabIndex = 99;
            this.label68.Text = "nhóm";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label19.Location = new System.Drawing.Point(27, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 21);
            this.label19.TabIndex = 101;
            this.label19.Text = "Số bài/nhóm:";
            // 
            // nudSoLuongNhomTo
            // 
            this.nudSoLuongNhomTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoLuongNhomTo.Location = new System.Drawing.Point(232, 79);
            this.nudSoLuongNhomTo.Name = "nudSoLuongNhomTo";
            this.nudSoLuongNhomTo.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongNhomTo.TabIndex = 2;
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
            this.ckbComment.Location = new System.Drawing.Point(369, 62);
            this.ckbComment.Name = "ckbComment";
            this.ckbComment.Size = new System.Drawing.Size(163, 25);
            this.ckbComment.TabIndex = 9;
            this.ckbComment.Text = "Bình luận văn bản";
            this.ckbComment.UseVisualStyleBackColor = true;
            this.ckbComment.CheckedChanged += new System.EventHandler(this.ckbComment_CheckedChanged);
            // 
            // ckbShareWall
            // 
            this.ckbShareWall.AutoSize = true;
            this.ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbShareWall.Location = new System.Drawing.Point(135, 171);
            this.ckbShareWall.Name = "ckbShareWall";
            this.ckbShareWall.Size = new System.Drawing.Size(156, 25);
            this.ckbShareWall.TabIndex = 8;
            this.ckbShareWall.Text = "Chia sẻ về tường";
            this.ckbShareWall.UseVisualStyleBackColor = true;
            // 
            // ckbInteract
            // 
            this.ckbInteract.AutoSize = true;
            this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbInteract.Location = new System.Drawing.Point(30, 171);
            this.ckbInteract.Name = "ckbInteract";
            this.ckbInteract.Size = new System.Drawing.Size(61, 25);
            this.ckbInteract.TabIndex = 7;
            this.ckbInteract.Text = "Like";
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
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(135, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(194, 27);
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
            this.label6.Location = new System.Drawing.Point(293, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "giây";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 112);
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
            this.btnCancel.Location = new System.Drawing.Point(341, 286);
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
            this.btnAdd.Location = new System.Drawing.Point(234, 286);
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
            this.bunifuCards1.Size = new System.Drawing.Size(665, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDBaiVietNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 325);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDBaiVietNhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.plAnh.ResumeLayout(false);
            this.plAnh.PerformLayout();
            this.plComment.ResumeLayout(false);
            this.plComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongNhomFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongNhomTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBaiVietTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBaiVietFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x040011A5 RID: 4517
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040011A6 RID: 4518
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040011A7 RID: 4519
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x040011A8 RID: 4520
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040011A9 RID: 4521
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x040011AA RID: 4522
		private global::System.Windows.Forms.NumericUpDown nudSoLuongBaiVietTo;

		// Token: 0x040011AB RID: 4523
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x040011AC RID: 4524
		private global::System.Windows.Forms.NumericUpDown nudSoLuongBaiVietFrom;

		// Token: 0x040011AD RID: 4525
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x040011AE RID: 4526
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040011AF RID: 4527
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040011B0 RID: 4528
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040011B1 RID: 4529
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040011B2 RID: 4530
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040011B3 RID: 4531
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040011B4 RID: 4532
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040011B5 RID: 4533
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040011B6 RID: 4534
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040011B7 RID: 4535
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040011B8 RID: 4536
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040011B9 RID: 4537
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040011BA RID: 4538
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040011BB RID: 4539
		private global::System.Windows.Forms.CheckBox ckbComment;

		// Token: 0x040011BC RID: 4540
		private global::System.Windows.Forms.CheckBox ckbInteract;

		// Token: 0x040011BD RID: 4541
		private global::System.Windows.Forms.CheckBox ckbShareWall;

		// Token: 0x040011BE RID: 4542
		private global::System.Windows.Forms.Label label49;

		// Token: 0x040011BF RID: 4543
		private global::System.Windows.Forms.NumericUpDown nudSoLuongNhomFrom;

		// Token: 0x040011C0 RID: 4544
		private global::System.Windows.Forms.Label label68;

		// Token: 0x040011C1 RID: 4545
		private global::System.Windows.Forms.Label label19;

		// Token: 0x040011C2 RID: 4546
		private global::System.Windows.Forms.NumericUpDown nudSoLuongNhomTo;

		// Token: 0x040011C3 RID: 4547
		private global::System.Windows.Forms.Label label66;

		// Token: 0x040011C4 RID: 4548
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x040011C5 RID: 4549
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x040011C6 RID: 4550
		private global::MetroFramework.Controls.MetroButton btnDown;

		// Token: 0x040011C7 RID: 4551
		private global::MetroFramework.Controls.MetroButton btnUp;

		// Token: 0x040011C8 RID: 4552
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x040011C9 RID: 4553
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x040011CA RID: 4554
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040011CB RID: 4555
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040011CC RID: 4556
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x040011CD RID: 4557
		private global::System.Windows.Forms.Panel plAnh;

		// Token: 0x040011CE RID: 4558
		private global::System.Windows.Forms.TextBox txtAnh;

		// Token: 0x040011CF RID: 4559
		private global::System.Windows.Forms.CheckBox ckbSendAnh;

		// Token: 0x040011D0 RID: 4560
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040011D1 RID: 4561
		private global::System.Windows.Forms.Button button4;

		// Token: 0x040011D2 RID: 4562
		private global::System.Windows.Forms.Button button5;

		// Token: 0x040011D3 RID: 4563
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040011D4 RID: 4564
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x040011D5 RID: 4565
		private global::System.Windows.Forms.Button btnNhap;

		// Token: 0x040011D6 RID: 4566
		private global::System.Windows.Forms.CheckBox ckbVip;

		// Token: 0x040011D7 RID: 4567
		private global::System.Windows.Forms.Panel panel2;
	}
}
