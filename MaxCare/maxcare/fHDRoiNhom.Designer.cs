namespace maxcare
{
	// Token: 0x0200010D RID: 269
	public partial class fHDRoiNhom : global::System.Windows.Forms.Form
	{
		// Token: 0x06000BB1 RID: 2993 RVA: 0x0019D568 File Offset: 0x0019B768
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0019D5C8 File Offset: 0x0019B7C8
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
            this.label12 = new System.Windows.Forms.Label();
            this.txtIDNhomGiuLai = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.plUidChiDinh = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdNhomRoi = new System.Windows.Forms.TextBox();
            this.ckbDieuKienID = new System.Windows.Forms.CheckBox();
            this.plDieuKienTuKhoa = new System.Windows.Forms.Panel();
            this.lblStatusUid = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.ckbDieuKienTuKhoa = new System.Windows.Forms.CheckBox();
            this.ckbDieuKienThanhVien = new System.Windows.Forms.CheckBox();
            this.nudThanhVienToiDa = new System.Windows.Forms.NumericUpDown();
            this.rbRoiTheoDieuKien = new System.Windows.Forms.RadioButton();
            this.rbNhomKiemDuyet = new System.Windows.Forms.RadioButton();
            this.rbNgauNhien = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
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
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.plUidChiDinh.SuspendLayout();
            this.panel2.SuspendLayout();
            this.plDieuKienTuKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThanhVienToiDa)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(669, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Rời nhóm";
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
            this.pnlHeader.Size = new System.Drawing.Size(669, 31);
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
            this.button1.Location = new System.Drawing.Point(638, 1);
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
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtIDNhomGiuLai);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.plUidChiDinh);
            this.panel1.Controls.Add(this.rbRoiTheoDieuKien);
            this.panel1.Controls.Add(this.rbNhomKiemDuyet);
            this.panel1.Controls.Add(this.rbNgauNhien);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.nudDelayTo);
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
            this.panel1.Size = new System.Drawing.Size(672, 672);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 585);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 21);
            this.label12.TabIndex = 119;
            this.label12.Text = "(Mỗi ID 1 dòng)";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtIDNhomGiuLai
            // 
            this.txtIDNhomGiuLai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDNhomGiuLai.Location = new System.Drawing.Point(33, 169);
            this.txtIDNhomGiuLai.Name = "txtIDNhomGiuLai";
            this.txtIDNhomGiuLai.Size = new System.Drawing.Size(253, 413);
            this.txtIDNhomGiuLai.TabIndex = 120;
            this.txtIDNhomGiuLai.Text = "";
            this.txtIDNhomGiuLai.WordWrap = false;
            this.txtIDNhomGiuLai.TextChanged += new System.EventHandler(this.txtUidKhongHuyKetBan_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(272, 21);
            this.label8.TabIndex = 118;
            this.label8.Text = "Danh sách ID nhóm cần giữ lại (0):";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // plUidChiDinh
            // 
            this.plUidChiDinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plUidChiDinh.Controls.Add(this.panel2);
            this.plUidChiDinh.Controls.Add(this.ckbDieuKienID);
            this.plUidChiDinh.Controls.Add(this.plDieuKienTuKhoa);
            this.plUidChiDinh.Controls.Add(this.ckbDieuKienTuKhoa);
            this.plUidChiDinh.Controls.Add(this.ckbDieuKienThanhVien);
            this.plUidChiDinh.Controls.Add(this.nudThanhVienToiDa);
            this.plUidChiDinh.Location = new System.Drawing.Point(350, 174);
            this.plUidChiDinh.Name = "plUidChiDinh";
            this.plUidChiDinh.Size = new System.Drawing.Size(295, 424);
            this.plUidChiDinh.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtIdNhomRoi);
            this.panel2.Location = new System.Drawing.Point(20, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 160);
            this.panel2.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Danh sách ID nhóm (0):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "(Mỗi ID nhóm 1 dòng)";
            // 
            // txtIdNhomRoi
            // 
            this.txtIdNhomRoi.Location = new System.Drawing.Point(7, 25);
            this.txtIdNhomRoi.Multiline = true;
            this.txtIdNhomRoi.Name = "txtIdNhomRoi";
            this.txtIdNhomRoi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIdNhomRoi.Size = new System.Drawing.Size(253, 111);
            this.txtIdNhomRoi.TabIndex = 1;
            this.txtIdNhomRoi.WordWrap = false;
            this.txtIdNhomRoi.TextChanged += new System.EventHandler(this.txtIdNhomRoi_TextChanged);
            // 
            // ckbDieuKienID
            // 
            this.ckbDieuKienID.AutoSize = true;
            this.ckbDieuKienID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbDieuKienID.Location = new System.Drawing.Point(6, 221);
            this.ckbDieuKienID.Name = "ckbDieuKienID";
            this.ckbDieuKienID.Size = new System.Drawing.Size(163, 25);
            this.ckbDieuKienID.TabIndex = 51;
            this.ckbDieuKienID.Text = "Rời theo ID nhóm";
            this.ckbDieuKienID.UseVisualStyleBackColor = true;
            this.ckbDieuKienID.CheckedChanged += new System.EventHandler(this.ckbDieuKienID_CheckedChanged);
            // 
            // plDieuKienTuKhoa
            // 
            this.plDieuKienTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plDieuKienTuKhoa.Controls.Add(this.lblStatusUid);
            this.plDieuKienTuKhoa.Controls.Add(this.label10);
            this.plDieuKienTuKhoa.Controls.Add(this.txtTuKhoa);
            this.plDieuKienTuKhoa.Location = new System.Drawing.Point(24, 55);
            this.plDieuKienTuKhoa.Name = "plDieuKienTuKhoa";
            this.plDieuKienTuKhoa.Size = new System.Drawing.Size(265, 160);
            this.plDieuKienTuKhoa.TabIndex = 50;
            // 
            // lblStatusUid
            // 
            this.lblStatusUid.AutoSize = true;
            this.lblStatusUid.Location = new System.Drawing.Point(3, 3);
            this.lblStatusUid.Name = "lblStatusUid";
            this.lblStatusUid.Size = new System.Drawing.Size(183, 21);
            this.lblStatusUid.TabIndex = 0;
            this.lblStatusUid.Text = "Danh sách từ khóa (0):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "(Mỗi từ khóa 1 dòng)";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(7, 25);
            this.txtTuKhoa.Multiline = true;
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTuKhoa.Size = new System.Drawing.Size(253, 111);
            this.txtTuKhoa.TabIndex = 1;
            this.txtTuKhoa.WordWrap = false;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtComment_TextChanged_1);
            // 
            // ckbDieuKienTuKhoa
            // 
            this.ckbDieuKienTuKhoa.AutoSize = true;
            this.ckbDieuKienTuKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbDieuKienTuKhoa.Location = new System.Drawing.Point(6, 29);
            this.ckbDieuKienTuKhoa.Name = "ckbDieuKienTuKhoa";
            this.ckbDieuKienTuKhoa.Size = new System.Drawing.Size(267, 25);
            this.ckbDieuKienTuKhoa.TabIndex = 2;
            this.ckbDieuKienTuKhoa.Text = "Tên nhóm có chứa từ khóa sau:";
            this.ckbDieuKienTuKhoa.UseVisualStyleBackColor = true;
            this.ckbDieuKienTuKhoa.CheckedChanged += new System.EventHandler(this.ckbDieuKienTuKhoa_CheckedChanged);
            // 
            // ckbDieuKienThanhVien
            // 
            this.ckbDieuKienThanhVien.AutoSize = true;
            this.ckbDieuKienThanhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbDieuKienThanhVien.Location = new System.Drawing.Point(6, 3);
            this.ckbDieuKienThanhVien.Name = "ckbDieuKienThanhVien";
            this.ckbDieuKienThanhVien.Size = new System.Drawing.Size(231, 25);
            this.ckbDieuKienThanhVien.TabIndex = 2;
            this.ckbDieuKienThanhVien.Text = "Số lượng thành viên ít hơn:";
            this.ckbDieuKienThanhVien.UseVisualStyleBackColor = true;
            this.ckbDieuKienThanhVien.CheckedChanged += new System.EventHandler(this.ckbThanhVienToiDa_CheckedChanged);
            // 
            // nudThanhVienToiDa
            // 
            this.nudThanhVienToiDa.Location = new System.Drawing.Point(197, 2);
            this.nudThanhVienToiDa.Name = "nudThanhVienToiDa";
            this.nudThanhVienToiDa.Size = new System.Drawing.Size(92, 27);
            this.nudThanhVienToiDa.TabIndex = 1;
            // 
            // rbRoiTheoDieuKien
            // 
            this.rbRoiTheoDieuKien.AutoSize = true;
            this.rbRoiTheoDieuKien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbRoiTheoDieuKien.Location = new System.Drawing.Point(350, 150);
            this.rbRoiTheoDieuKien.Name = "rbRoiTheoDieuKien";
            this.rbRoiTheoDieuKien.Size = new System.Drawing.Size(211, 25);
            this.rbRoiTheoDieuKien.TabIndex = 48;
            this.rbRoiTheoDieuKien.Text = "Rời nhóm theo điều kiện";
            this.rbRoiTheoDieuKien.UseVisualStyleBackColor = true;
            this.rbRoiTheoDieuKien.CheckedChanged += new System.EventHandler(this.rbUidChiDinh_CheckedChanged);
            // 
            // rbNhomKiemDuyet
            // 
            this.rbNhomKiemDuyet.AutoSize = true;
            this.rbNhomKiemDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNhomKiemDuyet.Location = new System.Drawing.Point(350, 126);
            this.rbNhomKiemDuyet.Name = "rbNhomKiemDuyet";
            this.rbNhomKiemDuyet.Size = new System.Drawing.Size(246, 25);
            this.rbNhomKiemDuyet.TabIndex = 48;
            this.rbNhomKiemDuyet.Text = "Rời nhóm kiểm duyệt bài viết";
            this.rbNhomKiemDuyet.UseVisualStyleBackColor = true;
            // 
            // rbNgauNhien
            // 
            this.rbNgauNhien.AutoSize = true;
            this.rbNgauNhien.Checked = true;
            this.rbNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNgauNhien.Location = new System.Drawing.Point(350, 102);
            this.rbNgauNhien.Name = "rbNgauNhien";
            this.rbNgauNhien.Size = new System.Drawing.Size(240, 25);
            this.rbNgauNhien.TabIndex = 48;
            this.rbNgauNhien.TabStop = true;
            this.rbNgauNhien.Text = "Ngẫu nhiên danh sách nhóm";
            this.rbNgauNhien.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 21);
            this.label9.TabIndex = 47;
            this.label9.Text = "Tùy chọn nhóm để rời:";
            // 
            // nudDelayTo
            // 
            this.nudDelayTo.Location = new System.Drawing.Point(229, 111);
            this.nudDelayTo.Name = "nudDelayTo";
            this.nudDelayTo.Size = new System.Drawing.Size(56, 27);
            this.nudDelayTo.TabIndex = 4;
            // 
            // nudDelayFrom
            // 
            this.nudDelayFrom.Location = new System.Drawing.Point(132, 111);
            this.nudDelayFrom.Name = "nudDelayFrom";
            this.nudDelayFrom.Size = new System.Drawing.Size(56, 27);
            this.nudDelayFrom.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(194, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "đến";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "giây";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Thời gian chờ:";
            // 
            // nudSoLuongTo
            // 
            this.nudSoLuongTo.Location = new System.Drawing.Point(229, 80);
            this.nudSoLuongTo.Name = "nudSoLuongTo";
            this.nudSoLuongTo.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongTo.TabIndex = 2;
            // 
            // nudSoLuongFrom
            // 
            this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
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
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(194, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "đến";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Số lượng nhóm:";
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
            this.btnCancel.Location = new System.Drawing.Point(363, 630);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 7;
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
            this.btnAdd.Location = new System.Drawing.Point(256, 630);
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
            this.bunifuCards1.Size = new System.Drawing.Size(669, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDRoiNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 672);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDRoiNhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plUidChiDinh.ResumeLayout(false);
            this.plUidChiDinh.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.plDieuKienTuKhoa.ResumeLayout(false);
            this.plDieuKienTuKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThanhVienToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04001229 RID: 4649
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400122A RID: 4650
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400122B RID: 4651
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x0400122C RID: 4652
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400122D RID: 4653
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x0400122E RID: 4654
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x0400122F RID: 4655
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04001230 RID: 4656
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04001231 RID: 4657
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04001232 RID: 4658
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04001233 RID: 4659
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001234 RID: 4660
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04001235 RID: 4661
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04001236 RID: 4662
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04001237 RID: 4663
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04001238 RID: 4664
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04001239 RID: 4665
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400123A RID: 4666
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x0400123B RID: 4667
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x0400123C RID: 4668
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x0400123D RID: 4669
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400123E RID: 4670
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400123F RID: 4671
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001240 RID: 4672
		private global::System.Windows.Forms.RadioButton rbRoiTheoDieuKien;

		// Token: 0x04001241 RID: 4673
		private global::System.Windows.Forms.RadioButton rbNgauNhien;

		// Token: 0x04001242 RID: 4674
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04001243 RID: 4675
		private global::System.Windows.Forms.Panel plUidChiDinh;

		// Token: 0x04001244 RID: 4676
		private global::System.Windows.Forms.TextBox txtTuKhoa;

		// Token: 0x04001245 RID: 4677
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04001246 RID: 4678
		private global::System.Windows.Forms.Label lblStatusUid;

		// Token: 0x04001247 RID: 4679
		private global::System.Windows.Forms.Panel plDieuKienTuKhoa;

		// Token: 0x04001248 RID: 4680
		private global::System.Windows.Forms.CheckBox ckbDieuKienTuKhoa;

		// Token: 0x04001249 RID: 4681
		private global::System.Windows.Forms.CheckBox ckbDieuKienThanhVien;

		// Token: 0x0400124A RID: 4682
		private global::System.Windows.Forms.NumericUpDown nudThanhVienToiDa;

		// Token: 0x0400124B RID: 4683
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400124C RID: 4684
		private global::System.Windows.Forms.RichTextBox txtIDNhomGiuLai;

		// Token: 0x0400124D RID: 4685
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400124E RID: 4686
		private global::System.Windows.Forms.RadioButton rbNhomKiemDuyet;

		// Token: 0x0400124F RID: 4687
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04001250 RID: 4688
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04001251 RID: 4689
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04001252 RID: 4690
		private global::System.Windows.Forms.TextBox txtIdNhomRoi;

		// Token: 0x04001253 RID: 4691
		private global::System.Windows.Forms.CheckBox ckbDieuKienID;
	}
}
