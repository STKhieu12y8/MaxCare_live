namespace maxcare
{
	// Token: 0x02000068 RID: 104
	public partial class fCapNhatDuLieu : global::System.Windows.Forms.Form
	{
		// Token: 0x06000431 RID: 1073 RVA: 0x0004CDC4 File Offset: 0x0004AFC4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0004CE24 File Offset: 0x0004B024
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbDinhDangNhap = new System.Windows.Forms.ComboBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.txbAccount = new System.Windows.Forms.RichTextBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.ctmsDevice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chọnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tấtCảToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bôiĐenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoản0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoản1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoThiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaThiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDanhSachThiêtBiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.plDinhDangNhap = new System.Windows.Forms.Panel();
            this.cbbTypeProxy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDinhDang1 = new System.Windows.Forms.ComboBox();
            this.cbbDinhDang2 = new System.Windows.Forms.ComboBox();
            this.cbbDinhDang3 = new System.Windows.Forms.ComboBox();
            this.cbbDinhDang4 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbDinhDang5 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbDinhDang8 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbDinhDang6 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbDinhDang7 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.ctmsDevice.SuspendLayout();
            this.plDinhDangNhap.SuspendLayout();
            this.SuspendLayout();
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
            this.btnAdd.Location = new System.Drawing.Point(335, 460);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 31);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(452, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 31);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 14);
            this.label8.TabIndex = 39;
            this.label8.Text = "Chọn định dạng:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbDinhDangNhap
            // 
            this.cbbDinhDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDangNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDangNhap.FormattingEnabled = true;
            this.cbbDinhDangNhap.Items.AddRange(new object[] {
            "Uid|Pass",
            "Uid|Pass|2FA",
            "Uid|Pass|Token|Cookie",
            "Uid|Pass|Token|Cookie|Email|Pass Email",
            "Uid|Pass|Token|Cookie|Email|Pass Email|2FA",
            "Other..."});
            this.cbbDinhDangNhap.Location = new System.Drawing.Point(112, 364);
            this.cbbDinhDangNhap.Name = "cbbDinhDangNhap";
            this.cbbDinhDangNhap.Size = new System.Drawing.Size(269, 26);
            this.cbbDinhDangNhap.TabIndex = 40;
            this.cbbDinhDangNhap.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDangNhap_SelectedIndexChanged);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(885, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cập nhật dữ liệu";
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
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.pictureBox2);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Location = new System.Drawing.Point(0, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(885, 31);
            this.pnlHeader.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Location = new System.Drawing.Point(2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(-156, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::MaxCare.Properties.Resources.close_window_25px;
            this.btnMinimize.Location = new System.Drawing.Point(853, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 77;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // txbAccount
            // 
            this.txbAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAccount.Location = new System.Drawing.Point(12, 77);
            this.txbAccount.Name = "txbAccount";
            this.txbAccount.Size = new System.Drawing.Size(863, 277);
            this.txbAccount.TabIndex = 48;
            this.txbAccount.Text = "";
            this.txbAccount.WordWrap = false;
            this.txbAccount.TextChanged += new System.EventHandler(this.TxbAccount_TextChanged);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
            this.bunifuCards1.Controls.Add(this.pnlHeader);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(885, 37);
            this.bunifuCards1.TabIndex = 49;
            // 
            // ctmsDevice
            // 
            this.ctmsDevice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctmsDevice.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmsDevice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chọnToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.tạoThiếtBịToolStripMenuItem,
            this.xóaThiếtBịToolStripMenuItem,
            this.loadDanhSachThiêtBiToolStripMenuItem1});
            this.ctmsDevice.Name = "ctmsAcc";
            this.ctmsDevice.Size = new System.Drawing.Size(205, 114);
            // 
            // chọnToolStripMenuItem1
            // 
            this.chọnToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tấtCảToolStripMenuItem1,
            this.bôiĐenToolStripMenuItem1,
            this.tàiKhoản0ToolStripMenuItem,
            this.tàiKhoản1ToolStripMenuItem});
            this.chọnToolStripMenuItem1.Name = "chọnToolStripMenuItem1";
            this.chọnToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.chọnToolStripMenuItem1.Text = "Chọn";
            // 
            // tấtCảToolStripMenuItem1
            // 
            this.tấtCảToolStripMenuItem1.Name = "tấtCảToolStripMenuItem1";
            this.tấtCảToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.tấtCảToolStripMenuItem1.Text = "Tất cả";
            // 
            // bôiĐenToolStripMenuItem1
            // 
            this.bôiĐenToolStripMenuItem1.Name = "bôiĐenToolStripMenuItem1";
            this.bôiĐenToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.bôiĐenToolStripMenuItem1.Text = "Bôi đen";
            // 
            // tàiKhoản0ToolStripMenuItem
            // 
            this.tàiKhoản0ToolStripMenuItem.Name = "tàiKhoản0ToolStripMenuItem";
            this.tàiKhoản0ToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.tàiKhoản0ToolStripMenuItem.Text = "Tài khoản=0";
            // 
            // tàiKhoản1ToolStripMenuItem
            // 
            this.tàiKhoản1ToolStripMenuItem.Name = "tàiKhoản1ToolStripMenuItem";
            this.tàiKhoản1ToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.tàiKhoản1ToolStripMenuItem.Text = "Tài khoản=1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem2.Text = "Bỏ chọn tất cả";
            // 
            // tạoThiếtBịToolStripMenuItem
            // 
            this.tạoThiếtBịToolStripMenuItem.Name = "tạoThiếtBịToolStripMenuItem";
            this.tạoThiếtBịToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.tạoThiếtBịToolStripMenuItem.Text = "Tạo thiết bị";
            // 
            // xóaThiếtBịToolStripMenuItem
            // 
            this.xóaThiếtBịToolStripMenuItem.Name = "xóaThiếtBịToolStripMenuItem";
            this.xóaThiếtBịToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.xóaThiếtBịToolStripMenuItem.Text = "Xóa thiết bị";
            // 
            // loadDanhSachThiêtBiToolStripMenuItem1
            // 
            this.loadDanhSachThiêtBiToolStripMenuItem1.Name = "loadDanhSachThiêtBiToolStripMenuItem1";
            this.loadDanhSachThiêtBiToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.loadDanhSachThiêtBiToolStripMenuItem1.Text = "Làm mới danh sách";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(443, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Thành công:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.SystemColors.Control;
            this.lblSuccess.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.lblSuccess.Location = new System.Drawing.Point(526, 47);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(23, 24);
            this.lblSuccess.TabIndex = 50;
            this.lblSuccess.Text = "0";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.Control;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(649, 47);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(23, 24);
            this.lblError.TabIndex = 51;
            this.lblError.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Teal;
            this.lblTotal.Location = new System.Drawing.Point(809, 48);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(23, 24);
            this.lblTotal.TabIndex = 53;
            this.lblTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(600, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Lỗi:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(749, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 59;
            this.label7.Text = "Tổng số:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStatus.Location = new System.Drawing.Point(12, 44);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(227, 28);
            this.lblStatus.TabIndex = 60;
            this.lblStatus.Text = "Nhập thông tin tài khoản:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plDinhDangNhap
            // 
            this.plDinhDangNhap.Controls.Add(this.cbbTypeProxy);
            this.plDinhDangNhap.Controls.Add(this.label2);
            this.plDinhDangNhap.Controls.Add(this.label1);
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang1);
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang2);
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang3);
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang4);
            this.plDinhDangNhap.Controls.Add(this.label14);
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang5);
            this.plDinhDangNhap.Controls.Add(this.label17);
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang8);
            this.plDinhDangNhap.Controls.Add(this.label13);
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang6);
            this.plDinhDangNhap.Controls.Add(this.label12);
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang7);
            this.plDinhDangNhap.Controls.Add(this.label11);
            this.plDinhDangNhap.Controls.Add(this.label9);
            this.plDinhDangNhap.Controls.Add(this.label10);
            this.plDinhDangNhap.Location = new System.Drawing.Point(102, 392);
            this.plDinhDangNhap.Name = "plDinhDangNhap";
            this.plDinhDangNhap.Size = new System.Drawing.Size(777, 62);
            this.plDinhDangNhap.TabIndex = 61;
            // 
            // cbbTypeProxy
            // 
            this.cbbTypeProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTypeProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeProxy.FormattingEnabled = true;
            this.cbbTypeProxy.Items.AddRange(new object[] {
            "HTTP",
            "Sock5"});
            this.cbbTypeProxy.Location = new System.Drawing.Point(85, 33);
            this.cbbTypeProxy.Name = "cbbTypeProxy";
            this.cbbTypeProxy.Size = new System.Drawing.Size(130, 27);
            this.cbbTypeProxy.TabIndex = 126;
            this.cbbTypeProxy.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 125;
            this.label2.Text = "Loại proxy:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Uid|";
            // 
            // cbbDinhDang1
            // 
            this.cbbDinhDang1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang1.FormattingEnabled = true;
            this.cbbDinhDang1.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy"});
            this.cbbDinhDang1.Location = new System.Drawing.Point(44, 3);
            this.cbbDinhDang1.Name = "cbbDinhDang1";
            this.cbbDinhDang1.Size = new System.Drawing.Size(78, 26);
            this.cbbDinhDang1.TabIndex = 40;
            this.cbbDinhDang1.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // cbbDinhDang2
            // 
            this.cbbDinhDang2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang2.FormattingEnabled = true;
            this.cbbDinhDang2.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy"});
            this.cbbDinhDang2.Location = new System.Drawing.Point(137, 3);
            this.cbbDinhDang2.Name = "cbbDinhDang2";
            this.cbbDinhDang2.Size = new System.Drawing.Size(78, 26);
            this.cbbDinhDang2.TabIndex = 40;
            this.cbbDinhDang2.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // cbbDinhDang3
            // 
            this.cbbDinhDang3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang3.FormattingEnabled = true;
            this.cbbDinhDang3.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy"});
            this.cbbDinhDang3.Location = new System.Drawing.Point(230, 3);
            this.cbbDinhDang3.Name = "cbbDinhDang3";
            this.cbbDinhDang3.Size = new System.Drawing.Size(78, 26);
            this.cbbDinhDang3.TabIndex = 40;
            this.cbbDinhDang3.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // cbbDinhDang4
            // 
            this.cbbDinhDang4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang4.FormattingEnabled = true;
            this.cbbDinhDang4.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy"});
            this.cbbDinhDang4.Location = new System.Drawing.Point(323, 3);
            this.cbbDinhDang4.Name = "cbbDinhDang4";
            this.cbbDinhDang4.Size = new System.Drawing.Size(78, 26);
            this.cbbDinhDang4.TabIndex = 40;
            this.cbbDinhDang4.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label14.Location = new System.Drawing.Point(587, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 24);
            this.label14.TabIndex = 41;
            this.label14.Text = "|";
            // 
            // cbbDinhDang5
            // 
            this.cbbDinhDang5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang5.FormattingEnabled = true;
            this.cbbDinhDang5.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy"});
            this.cbbDinhDang5.Location = new System.Drawing.Point(416, 3);
            this.cbbDinhDang5.Name = "cbbDinhDang5";
            this.cbbDinhDang5.Size = new System.Drawing.Size(78, 26);
            this.cbbDinhDang5.TabIndex = 40;
            this.cbbDinhDang5.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label17.Location = new System.Drawing.Point(680, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 24);
            this.label17.TabIndex = 41;
            this.label17.Text = "|";
            // 
            // cbbDinhDang8
            // 
            this.cbbDinhDang8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang8.FormattingEnabled = true;
            this.cbbDinhDang8.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy"});
            this.cbbDinhDang8.Location = new System.Drawing.Point(695, 3);
            this.cbbDinhDang8.Name = "cbbDinhDang8";
            this.cbbDinhDang8.Size = new System.Drawing.Size(78, 26);
            this.cbbDinhDang8.TabIndex = 40;
            this.cbbDinhDang8.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label13.Location = new System.Drawing.Point(494, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 24);
            this.label13.TabIndex = 41;
            this.label13.Text = "|";
            // 
            // cbbDinhDang6
            // 
            this.cbbDinhDang6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang6.FormattingEnabled = true;
            this.cbbDinhDang6.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy"});
            this.cbbDinhDang6.Location = new System.Drawing.Point(509, 3);
            this.cbbDinhDang6.Name = "cbbDinhDang6";
            this.cbbDinhDang6.Size = new System.Drawing.Size(78, 26);
            this.cbbDinhDang6.TabIndex = 40;
            this.cbbDinhDang6.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.Location = new System.Drawing.Point(401, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 24);
            this.label12.TabIndex = 41;
            this.label12.Text = "|";
            // 
            // cbbDinhDang7
            // 
            this.cbbDinhDang7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang7.FormattingEnabled = true;
            this.cbbDinhDang7.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy"});
            this.cbbDinhDang7.Location = new System.Drawing.Point(602, 3);
            this.cbbDinhDang7.Name = "cbbDinhDang7";
            this.cbbDinhDang7.Size = new System.Drawing.Size(78, 26);
            this.cbbDinhDang7.TabIndex = 40;
            this.cbbDinhDang7.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label11.Location = new System.Drawing.Point(308, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 24);
            this.label11.TabIndex = 41;
            this.label11.Text = "|";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(122, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 24);
            this.label9.TabIndex = 41;
            this.label9.Text = "|";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(215, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 24);
            this.label10.TabIndex = 41;
            this.label10.Text = "|";
            // 
            // fCapNhatDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 502);
            this.Controls.Add(this.plDinhDangNhap);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txbAccount);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.cbbDinhDangNhap);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCapNhatDuLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập tài khoản";
            this.Load += new System.EventHandler(this.fCapNhatDuLieu_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ctmsDevice.ResumeLayout(false);
            this.plDinhDangNhap.ResumeLayout(false);
            this.plDinhDangNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x040002CA RID: 714
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040002CB RID: 715
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040002CC RID: 716
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040002CD RID: 717
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040002CE RID: 718
		private global::System.Windows.Forms.ComboBox cbbDinhDangNhap;

		// Token: 0x040002CF RID: 719
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040002D0 RID: 720
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x040002D1 RID: 721
		private global::System.Windows.Forms.RichTextBox txbAccount;

		// Token: 0x040002D2 RID: 722
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040002D3 RID: 723
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040002D4 RID: 724
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040002D5 RID: 725
		private global::System.Windows.Forms.ContextMenuStrip ctmsDevice;

		// Token: 0x040002D6 RID: 726
		private global::System.Windows.Forms.ToolStripMenuItem chọnToolStripMenuItem1;

		// Token: 0x040002D7 RID: 727
		private global::System.Windows.Forms.ToolStripMenuItem tấtCảToolStripMenuItem1;

		// Token: 0x040002D8 RID: 728
		private global::System.Windows.Forms.ToolStripMenuItem bôiĐenToolStripMenuItem1;

		// Token: 0x040002D9 RID: 729
		private global::System.Windows.Forms.ToolStripMenuItem tàiKhoản0ToolStripMenuItem;

		// Token: 0x040002DA RID: 730
		private global::System.Windows.Forms.ToolStripMenuItem tàiKhoản1ToolStripMenuItem;

		// Token: 0x040002DB RID: 731
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

		// Token: 0x040002DC RID: 732
		private global::System.Windows.Forms.ToolStripMenuItem tạoThiếtBịToolStripMenuItem;

		// Token: 0x040002DD RID: 733
		private global::System.Windows.Forms.ToolStripMenuItem xóaThiếtBịToolStripMenuItem;

		// Token: 0x040002DE RID: 734
		private global::System.Windows.Forms.ToolStripMenuItem loadDanhSachThiêtBiToolStripMenuItem1;

		// Token: 0x040002DF RID: 735
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040002E0 RID: 736
		private global::System.Windows.Forms.Label lblSuccess;

		// Token: 0x040002E1 RID: 737
		private global::System.Windows.Forms.Label lblError;

		// Token: 0x040002E2 RID: 738
		private global::System.Windows.Forms.Label lblTotal;

		// Token: 0x040002E3 RID: 739
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040002E4 RID: 740
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040002E5 RID: 741
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x040002E6 RID: 742
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040002E7 RID: 743
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x040002E8 RID: 744
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x040002E9 RID: 745
		private global::System.Windows.Forms.Panel plDinhDangNhap;

		// Token: 0x040002EA RID: 746
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040002EB RID: 747
		private global::System.Windows.Forms.ComboBox cbbDinhDang1;

		// Token: 0x040002EC RID: 748
		private global::System.Windows.Forms.ComboBox cbbDinhDang2;

		// Token: 0x040002ED RID: 749
		private global::System.Windows.Forms.ComboBox cbbDinhDang3;

		// Token: 0x040002EE RID: 750
		private global::System.Windows.Forms.ComboBox cbbDinhDang4;

		// Token: 0x040002EF RID: 751
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040002F0 RID: 752
		private global::System.Windows.Forms.ComboBox cbbDinhDang5;

		// Token: 0x040002F1 RID: 753
		private global::System.Windows.Forms.Label label17;

		// Token: 0x040002F2 RID: 754
		private global::System.Windows.Forms.ComboBox cbbDinhDang8;

		// Token: 0x040002F3 RID: 755
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040002F4 RID: 756
		private global::System.Windows.Forms.ComboBox cbbDinhDang6;

		// Token: 0x040002F5 RID: 757
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040002F6 RID: 758
		private global::System.Windows.Forms.ComboBox cbbDinhDang7;

		// Token: 0x040002F7 RID: 759
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040002F8 RID: 760
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040002F9 RID: 761
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040002FA RID: 762
		private global::System.Windows.Forms.ComboBox cbbTypeProxy;

		// Token: 0x040002FB RID: 763
		private global::System.Windows.Forms.Label label2;
	}
}
