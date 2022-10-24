namespace maxcare
{
	// Token: 0x020000BC RID: 188
	public partial class fHDDangStatusV2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000768 RID: 1896 RVA: 0x000C8B08 File Offset: 0x000C6D08
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x000C8B68 File Offset: 0x000C6D68
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
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.nudKhoangCachTo = new System.Windows.Forms.NumericUpDown();
            this.nudKhoangCachFrom = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.plVanBan = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDown = new MetroFramework.Controls.MetroButton();
            this.btnUp = new MetroFramework.Controls.MetroButton();
            this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
            this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.plAnh = new System.Windows.Forms.Panel();
            this.nudSoLuongAnhTo = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongAnhFrom = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPathAnh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbDangAnhTheoThuTu = new System.Windows.Forms.CheckBox();
            this.ckbAnh = new System.Windows.Forms.CheckBox();
            this.ckbVanBan = new System.Windows.Forms.CheckBox();
            this.txtTenHanhDong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKhoangCachTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKhoangCachFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).BeginInit();
            this.plVanBan.SuspendLayout();
            this.plAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongAnhTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongAnhFrom)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(361, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Đăng status v2";
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
            this.pnlHeader.Size = new System.Drawing.Size(361, 31);
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
            this.button1.Location = new System.Drawing.Point(330, 1);
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
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.nudKhoangCachTo);
            this.panel1.Controls.Add(this.nudKhoangCachFrom);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.nudSoLuongTo);
            this.panel1.Controls.Add(this.nudSoLuongFrom);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.plVanBan);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.plAnh);
            this.panel1.Controls.Add(this.ckbAnh);
            this.panel1.Controls.Add(this.ckbVanBan);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 510);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(291, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 21);
            this.label19.TabIndex = 43;
            this.label19.Text = "giây";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(205, 108);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 16);
            this.label20.TabIndex = 42;
            this.label20.Text = "đến";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudKhoangCachTo
            // 
            this.nudKhoangCachTo.Location = new System.Drawing.Point(236, 106);
            this.nudKhoangCachTo.Name = "nudKhoangCachTo";
            this.nudKhoangCachTo.Size = new System.Drawing.Size(51, 27);
            this.nudKhoangCachTo.TabIndex = 41;
            // 
            // nudKhoangCachFrom
            // 
            this.nudKhoangCachFrom.Location = new System.Drawing.Point(151, 106);
            this.nudKhoangCachFrom.Name = "nudKhoangCachFrom";
            this.nudKhoangCachFrom.Size = new System.Drawing.Size(51, 27);
            this.nudKhoangCachFrom.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(291, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 21);
            this.label18.TabIndex = 39;
            this.label18.Text = "bài";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(205, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 16);
            this.label17.TabIndex = 38;
            this.label17.Text = "đến";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudSoLuongTo
            // 
            this.nudSoLuongTo.Location = new System.Drawing.Point(236, 78);
            this.nudSoLuongTo.Name = "nudSoLuongTo";
            this.nudSoLuongTo.Size = new System.Drawing.Size(51, 27);
            this.nudSoLuongTo.TabIndex = 37;
            // 
            // nudSoLuongFrom
            // 
            this.nudSoLuongFrom.Location = new System.Drawing.Point(151, 78);
            this.nudSoLuongFrom.Name = "nudSoLuongFrom";
            this.nudSoLuongFrom.Size = new System.Drawing.Size(51, 27);
            this.nudSoLuongFrom.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 21);
            this.label16.TabIndex = 35;
            this.label16.Text = "Khoảng cách đăng:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 21);
            this.label15.TabIndex = 34;
            this.label15.Text = "Số lượng bài viết:";
            // 
            // plVanBan
            // 
            this.plVanBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plVanBan.Controls.Add(this.button3);
            this.plVanBan.Controls.Add(this.button2);
            this.plVanBan.Controls.Add(this.btnDown);
            this.plVanBan.Controls.Add(this.btnUp);
            this.plVanBan.Controls.Add(this.rbNganCachKyTu);
            this.plVanBan.Controls.Add(this.rbNganCachMoiDong);
            this.plVanBan.Controls.Add(this.label9);
            this.plVanBan.Controls.Add(this.txtNoiDung);
            this.plVanBan.Controls.Add(this.label8);
            this.plVanBan.Controls.Add(this.lblStatus);
            this.plVanBan.Location = new System.Drawing.Point(47, 159);
            this.plVanBan.Name = "plVanBan";
            this.plVanBan.Size = new System.Drawing.Size(278, 187);
            this.plVanBan.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Help;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(225, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Help;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(225, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDown
            // 
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.Location = new System.Drawing.Point(221, -1);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(25, 25);
            this.btnDown.TabIndex = 38;
            this.btnDown.UseSelectable = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Location = new System.Drawing.Point(252, -1);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(25, 25);
            this.btnUp.TabIndex = 39;
            this.btnUp.UseSelectable = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // rbNganCachKyTu
            // 
            this.rbNganCachKyTu.AutoSize = true;
            this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachKyTu.Location = new System.Drawing.Point(69, 210);
            this.rbNganCachKyTu.Name = "rbNganCachKyTu";
            this.rbNganCachKyTu.Size = new System.Drawing.Size(204, 25);
            this.rbNganCachKyTu.TabIndex = 37;
            this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
            this.rbNganCachKyTu.UseVisualStyleBackColor = true;
            this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(this.rbNganCachKyTu_CheckedChanged);
            // 
            // rbNganCachMoiDong
            // 
            this.rbNganCachMoiDong.AutoSize = true;
            this.rbNganCachMoiDong.Checked = true;
            this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachMoiDong.Location = new System.Drawing.Point(69, 189);
            this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
            this.rbNganCachMoiDong.Size = new System.Drawing.Size(199, 25);
            this.rbNganCachMoiDong.TabIndex = 36;
            this.rbNganCachMoiDong.TabStop = true;
            this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
            this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
            this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(this.rbNganCachMoiDong_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 35;
            this.label9.Text = "Tùy chọn:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(7, 24);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(263, 137);
            this.txtNoiDung.TabIndex = 34;
            this.txtNoiDung.Text = "";
            this.txtNoiDung.WordWrap = false;
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 164);
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
            this.btnAdd.Location = new System.Drawing.Point(85, 465);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // plAnh
            // 
            this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plAnh.Controls.Add(this.nudSoLuongAnhTo);
            this.plAnh.Controls.Add(this.nudSoLuongAnhFrom);
            this.plAnh.Controls.Add(this.label2);
            this.plAnh.Controls.Add(this.label4);
            this.plAnh.Controls.Add(this.label21);
            this.plAnh.Controls.Add(this.txtPathAnh);
            this.plAnh.Controls.Add(this.label3);
            this.plAnh.Controls.Add(this.ckbDangAnhTheoThuTu);
            this.plAnh.Location = new System.Drawing.Point(47, 372);
            this.plAnh.Name = "plAnh";
            this.plAnh.Size = new System.Drawing.Size(278, 82);
            this.plAnh.TabIndex = 33;
            // 
            // nudSoLuongAnhTo
            // 
            this.nudSoLuongAnhTo.Location = new System.Drawing.Point(206, 30);
            this.nudSoLuongAnhTo.Name = "nudSoLuongAnhTo";
            this.nudSoLuongAnhTo.Size = new System.Drawing.Size(45, 27);
            this.nudSoLuongAnhTo.TabIndex = 7;
            // 
            // nudSoLuongAnhFrom
            // 
            this.nudSoLuongAnhFrom.Location = new System.Drawing.Point(129, 30);
            this.nudSoLuongAnhFrom.Name = "nudSoLuongAnhFrom";
            this.nudSoLuongAnhFrom.Size = new System.Drawing.Size(45, 27);
            this.nudSoLuongAnhFrom.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(177, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "đến";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "ảnh";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 21);
            this.label21.TabIndex = 6;
            this.label21.Text = "Số lượng ảnh/bài:";
            // 
            // txtPathAnh
            // 
            this.txtPathAnh.Location = new System.Drawing.Point(136, 2);
            this.txtPathAnh.Name = "txtPathAnh";
            this.txtPathAnh.Size = new System.Drawing.Size(138, 27);
            this.txtPathAnh.TabIndex = 1;
            this.txtPathAnh.TextChanged += new System.EventHandler(this.txtPathAnh_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đường dẫn folder ảnh:";
            // 
            // ckbDangAnhTheoThuTu
            // 
            this.ckbDangAnhTheoThuTu.AutoSize = true;
            this.ckbDangAnhTheoThuTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbDangAnhTheoThuTu.Location = new System.Drawing.Point(7, 57);
            this.ckbDangAnhTheoThuTu.Name = "ckbDangAnhTheoThuTu";
            this.ckbDangAnhTheoThuTu.Size = new System.Drawing.Size(219, 25);
            this.ckbDangAnhTheoThuTu.TabIndex = 32;
            this.ckbDangAnhTheoThuTu.Text = "Đăng file ảnh theo thứ tự";
            this.ckbDangAnhTheoThuTu.UseVisualStyleBackColor = true;
            // 
            // ckbAnh
            // 
            this.ckbAnh.AutoSize = true;
            this.ckbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbAnh.Location = new System.Drawing.Point(33, 350);
            this.ckbAnh.Name = "ckbAnh";
            this.ckbAnh.Size = new System.Drawing.Size(61, 25);
            this.ckbAnh.TabIndex = 32;
            this.ckbAnh.Text = "Ảnh";
            this.ckbAnh.UseVisualStyleBackColor = true;
            this.ckbAnh.CheckedChanged += new System.EventHandler(this.ckbAnh_CheckedChanged);
            // 
            // ckbVanBan
            // 
            this.ckbVanBan.AutoSize = true;
            this.ckbVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbVanBan.Location = new System.Drawing.Point(33, 135);
            this.ckbVanBan.Name = "ckbVanBan";
            this.ckbVanBan.Size = new System.Drawing.Size(92, 25);
            this.ckbVanBan.TabIndex = 32;
            this.ckbVanBan.Text = "Văn bản";
            this.ckbVanBan.UseVisualStyleBackColor = true;
            this.ckbVanBan.CheckedChanged += new System.EventHandler(this.ckbVanBan_CheckedChanged);
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(151, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(174, 27);
            this.txtTenHanhDong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 52);
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
            this.btnCancel.Location = new System.Drawing.Point(184, 465);
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
            this.bunifuCards1.Size = new System.Drawing.Size(361, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDDangStatusV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 510);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDDangStatusV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKhoangCachTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKhoangCachFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).EndInit();
            this.plVanBan.ResumeLayout(false);
            this.plVanBan.PerformLayout();
            this.plAnh.ResumeLayout(false);
            this.plAnh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongAnhTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongAnhFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x0400088E RID: 2190
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400088F RID: 2191
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000890 RID: 2192
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000891 RID: 2193
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000892 RID: 2194
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000893 RID: 2195
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000894 RID: 2196
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000895 RID: 2197
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000896 RID: 2198
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000897 RID: 2199
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000898 RID: 2200
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000899 RID: 2201
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400089A RID: 2202
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x0400089B RID: 2203
		private global::System.Windows.Forms.CheckBox ckbAnh;

		// Token: 0x0400089C RID: 2204
		private global::System.Windows.Forms.CheckBox ckbVanBan;

		// Token: 0x0400089D RID: 2205
		private global::System.Windows.Forms.Panel plVanBan;

		// Token: 0x0400089E RID: 2206
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400089F RID: 2207
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x040008A0 RID: 2208
		private global::System.Windows.Forms.Panel plAnh;

		// Token: 0x040008A1 RID: 2209
		private global::System.Windows.Forms.TextBox txtPathAnh;

		// Token: 0x040008A2 RID: 2210
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040008A3 RID: 2211
		private global::System.Windows.Forms.RichTextBox txtNoiDung;

		// Token: 0x040008A4 RID: 2212
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x040008A5 RID: 2213
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x040008A6 RID: 2214
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040008A7 RID: 2215
		private global::MetroFramework.Controls.MetroButton btnDown;

		// Token: 0x040008A8 RID: 2216
		private global::MetroFramework.Controls.MetroButton btnUp;

		// Token: 0x040008A9 RID: 2217
		private global::System.Windows.Forms.Label label19;

		// Token: 0x040008AA RID: 2218
		private global::System.Windows.Forms.Label label20;

		// Token: 0x040008AB RID: 2219
		private global::System.Windows.Forms.NumericUpDown nudKhoangCachTo;

		// Token: 0x040008AC RID: 2220
		private global::System.Windows.Forms.NumericUpDown nudKhoangCachFrom;

		// Token: 0x040008AD RID: 2221
		private global::System.Windows.Forms.Label label18;

		// Token: 0x040008AE RID: 2222
		private global::System.Windows.Forms.Label label17;

		// Token: 0x040008AF RID: 2223
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x040008B0 RID: 2224
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x040008B1 RID: 2225
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040008B2 RID: 2226
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040008B3 RID: 2227
		private global::System.Windows.Forms.NumericUpDown nudSoLuongAnhTo;

		// Token: 0x040008B4 RID: 2228
		private global::System.Windows.Forms.NumericUpDown nudSoLuongAnhFrom;

		// Token: 0x040008B5 RID: 2229
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040008B6 RID: 2230
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040008B7 RID: 2231
		private global::System.Windows.Forms.Label label21;

		// Token: 0x040008B8 RID: 2232
		private global::System.Windows.Forms.CheckBox ckbDangAnhTheoThuTu;

		// Token: 0x040008B9 RID: 2233
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040008BA RID: 2234
		private global::System.Windows.Forms.Button button2;
	}
}
