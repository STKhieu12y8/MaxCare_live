namespace maxcare
{
	// Token: 0x020000E4 RID: 228
	public partial class fCauHinhHienThi : global::System.Windows.Forms.Form
	{
		// Token: 0x06000926 RID: 2342 RVA: 0x0011DC24 File Offset: 0x0011BE24
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0011DC84 File Offset: 0x0011BE84
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ckbToken = new System.Windows.Forms.CheckBox();
            this.ckbCookie = new System.Windows.Forms.CheckBox();
            this.ckbEmail = new System.Windows.Forms.CheckBox();
            this.ckbTen = new System.Windows.Forms.CheckBox();
            this.ckbBanBe = new System.Windows.Forms.CheckBox();
            this.ckbNhom = new System.Windows.Forms.CheckBox();
            this.ckbNgaySinh = new System.Windows.Forms.CheckBox();
            this.ckbGioiTinh = new System.Windows.Forms.CheckBox();
            this.ckbMatKhau = new System.Windows.Forms.CheckBox();
            this.ckbMatKhauMail = new System.Windows.Forms.CheckBox();
            this.ckbBackup = new System.Windows.Forms.CheckBox();
            this.ckbMa2FA = new System.Windows.Forms.CheckBox();
            this.ckbUseragent = new System.Windows.Forms.CheckBox();
            this.ckbProxy = new System.Windows.Forms.CheckBox();
            this.ckbNgayTao = new System.Windows.Forms.CheckBox();
            this.ckbAvatar = new System.Windows.Forms.CheckBox();
            this.ckbProfile = new System.Windows.Forms.CheckBox();
            this.ckbTinhTrang = new System.Windows.Forms.CheckBox();
            this.ckbGhiChu = new System.Windows.Forms.CheckBox();
            this.ckbThuMuc = new System.Windows.Forms.CheckBox();
            this.ckbFollow = new System.Windows.Forms.CheckBox();
            this.ckbInteractEnd = new System.Windows.Forms.CheckBox();
            this.bunifuCards1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards1.Controls.Add(this.pnlHeader);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(639, 47);
            this.bunifuCards1.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Location = new System.Drawing.Point(0, 6);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(639, 39);
            this.pnlHeader.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::MaxCare.Properties.Resources.close_window_25px;
            this.btnMinimize.Location = new System.Drawing.Point(596, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 39);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(639, 39);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Cấu hình hiển thị";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(329, 311);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(191, 311);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(68, 50);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(512, 39);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Vui lòng chọn những cột cần hiển thị!";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // ckbToken
            // 
            this.ckbToken.AutoSize = true;
            this.ckbToken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbToken.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbToken.Location = new System.Drawing.Point(41, 105);
            this.ckbToken.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbToken.Name = "ckbToken";
            this.ckbToken.Size = new System.Drawing.Size(77, 25);
            this.ckbToken.TabIndex = 22;
            this.ckbToken.Text = "Token";
            this.ckbToken.UseVisualStyleBackColor = true;
            // 
            // ckbCookie
            // 
            this.ckbCookie.AutoSize = true;
            this.ckbCookie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCookie.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCookie.Location = new System.Drawing.Point(41, 137);
            this.ckbCookie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbCookie.Name = "ckbCookie";
            this.ckbCookie.Size = new System.Drawing.Size(81, 25);
            this.ckbCookie.TabIndex = 22;
            this.ckbCookie.Text = "Cookie";
            this.ckbCookie.UseVisualStyleBackColor = true;
            // 
            // ckbEmail
            // 
            this.ckbEmail.AutoSize = true;
            this.ckbEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEmail.Location = new System.Drawing.Point(41, 169);
            this.ckbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbEmail.Name = "ckbEmail";
            this.ckbEmail.Size = new System.Drawing.Size(73, 25);
            this.ckbEmail.TabIndex = 22;
            this.ckbEmail.Text = "Email";
            this.ckbEmail.UseVisualStyleBackColor = true;
            // 
            // ckbTen
            // 
            this.ckbTen.AutoSize = true;
            this.ckbTen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTen.Location = new System.Drawing.Point(41, 201);
            this.ckbTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbTen.Name = "ckbTen";
            this.ckbTen.Size = new System.Drawing.Size(60, 25);
            this.ckbTen.TabIndex = 22;
            this.ckbTen.Text = "Tên";
            this.ckbTen.UseVisualStyleBackColor = true;
            // 
            // ckbBanBe
            // 
            this.ckbBanBe.AutoSize = true;
            this.ckbBanBe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbBanBe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBanBe.Location = new System.Drawing.Point(41, 265);
            this.ckbBanBe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbBanBe.Name = "ckbBanBe";
            this.ckbBanBe.Size = new System.Drawing.Size(83, 25);
            this.ckbBanBe.TabIndex = 22;
            this.ckbBanBe.Text = "Bạn bè";
            this.ckbBanBe.UseVisualStyleBackColor = true;
            // 
            // ckbNhom
            // 
            this.ckbNhom.AutoSize = true;
            this.ckbNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbNhom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNhom.Location = new System.Drawing.Point(171, 105);
            this.ckbNhom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbNhom.Name = "ckbNhom";
            this.ckbNhom.Size = new System.Drawing.Size(75, 25);
            this.ckbNhom.TabIndex = 22;
            this.ckbNhom.Text = "Nhóm";
            this.ckbNhom.UseVisualStyleBackColor = true;
            // 
            // ckbNgaySinh
            // 
            this.ckbNgaySinh.AutoSize = true;
            this.ckbNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbNgaySinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNgaySinh.Location = new System.Drawing.Point(171, 137);
            this.ckbNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbNgaySinh.Name = "ckbNgaySinh";
            this.ckbNgaySinh.Size = new System.Drawing.Size(104, 25);
            this.ckbNgaySinh.TabIndex = 22;
            this.ckbNgaySinh.Text = "Ngày sinh";
            this.ckbNgaySinh.UseVisualStyleBackColor = true;
            // 
            // ckbGioiTinh
            // 
            this.ckbGioiTinh.AutoSize = true;
            this.ckbGioiTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbGioiTinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGioiTinh.Location = new System.Drawing.Point(171, 169);
            this.ckbGioiTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbGioiTinh.Name = "ckbGioiTinh";
            this.ckbGioiTinh.Size = new System.Drawing.Size(93, 25);
            this.ckbGioiTinh.TabIndex = 22;
            this.ckbGioiTinh.Text = "Giới tính";
            this.ckbGioiTinh.UseVisualStyleBackColor = true;
            // 
            // ckbMatKhau
            // 
            this.ckbMatKhau.AutoSize = true;
            this.ckbMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbMatKhau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMatKhau.Location = new System.Drawing.Point(171, 201);
            this.ckbMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbMatKhau.Name = "ckbMatKhau";
            this.ckbMatKhau.Size = new System.Drawing.Size(100, 25);
            this.ckbMatKhau.TabIndex = 22;
            this.ckbMatKhau.Text = "Mật khẩu";
            this.ckbMatKhau.UseVisualStyleBackColor = true;
            // 
            // ckbMatKhauMail
            // 
            this.ckbMatKhauMail.AutoSize = true;
            this.ckbMatKhauMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbMatKhauMail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMatKhauMail.Location = new System.Drawing.Point(171, 233);
            this.ckbMatKhauMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbMatKhauMail.Name = "ckbMatKhauMail";
            this.ckbMatKhauMail.Size = new System.Drawing.Size(136, 25);
            this.ckbMatKhauMail.TabIndex = 22;
            this.ckbMatKhauMail.Text = "Mật khẩu mail";
            this.ckbMatKhauMail.UseVisualStyleBackColor = true;
            // 
            // ckbBackup
            // 
            this.ckbBackup.AutoSize = true;
            this.ckbBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbBackup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBackup.Location = new System.Drawing.Point(171, 265);
            this.ckbBackup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbBackup.Name = "ckbBackup";
            this.ckbBackup.Size = new System.Drawing.Size(85, 25);
            this.ckbBackup.TabIndex = 22;
            this.ckbBackup.Text = "Backup";
            this.ckbBackup.UseVisualStyleBackColor = true;
            // 
            // ckbMa2FA
            // 
            this.ckbMa2FA.AutoSize = true;
            this.ckbMa2FA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbMa2FA.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMa2FA.Location = new System.Drawing.Point(337, 105);
            this.ckbMa2FA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbMa2FA.Name = "ckbMa2FA";
            this.ckbMa2FA.Size = new System.Drawing.Size(88, 25);
            this.ckbMa2FA.TabIndex = 22;
            this.ckbMa2FA.Text = "Mã 2FA";
            this.ckbMa2FA.UseVisualStyleBackColor = true;
            // 
            // ckbUseragent
            // 
            this.ckbUseragent.AutoSize = true;
            this.ckbUseragent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbUseragent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbUseragent.Location = new System.Drawing.Point(337, 137);
            this.ckbUseragent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbUseragent.Name = "ckbUseragent";
            this.ckbUseragent.Size = new System.Drawing.Size(108, 25);
            this.ckbUseragent.TabIndex = 22;
            this.ckbUseragent.Text = "Useragent";
            this.ckbUseragent.UseVisualStyleBackColor = true;
            // 
            // ckbProxy
            // 
            this.ckbProxy.AutoSize = true;
            this.ckbProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbProxy.Location = new System.Drawing.Point(337, 169);
            this.ckbProxy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbProxy.Name = "ckbProxy";
            this.ckbProxy.Size = new System.Drawing.Size(72, 25);
            this.ckbProxy.TabIndex = 22;
            this.ckbProxy.Text = "Proxy";
            this.ckbProxy.UseVisualStyleBackColor = true;
            // 
            // ckbNgayTao
            // 
            this.ckbNgayTao.AutoSize = true;
            this.ckbNgayTao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbNgayTao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNgayTao.Location = new System.Drawing.Point(337, 201);
            this.ckbNgayTao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbNgayTao.Name = "ckbNgayTao";
            this.ckbNgayTao.Size = new System.Drawing.Size(98, 25);
            this.ckbNgayTao.TabIndex = 22;
            this.ckbNgayTao.Text = "Ngày tạo";
            this.ckbNgayTao.UseVisualStyleBackColor = true;
            // 
            // ckbAvatar
            // 
            this.ckbAvatar.AutoSize = true;
            this.ckbAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbAvatar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAvatar.Location = new System.Drawing.Point(337, 233);
            this.ckbAvatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbAvatar.Name = "ckbAvatar";
            this.ckbAvatar.Size = new System.Drawing.Size(81, 25);
            this.ckbAvatar.TabIndex = 22;
            this.ckbAvatar.Text = "Avatar";
            this.ckbAvatar.UseVisualStyleBackColor = true;
            // 
            // ckbProfile
            // 
            this.ckbProfile.AutoSize = true;
            this.ckbProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbProfile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbProfile.Location = new System.Drawing.Point(337, 265);
            this.ckbProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbProfile.Name = "ckbProfile";
            this.ckbProfile.Size = new System.Drawing.Size(78, 25);
            this.ckbProfile.TabIndex = 22;
            this.ckbProfile.Text = "Profile";
            this.ckbProfile.UseVisualStyleBackColor = true;
            // 
            // ckbTinhTrang
            // 
            this.ckbTinhTrang.AutoSize = true;
            this.ckbTinhTrang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTinhTrang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTinhTrang.Location = new System.Drawing.Point(473, 137);
            this.ckbTinhTrang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbTinhTrang.Name = "ckbTinhTrang";
            this.ckbTinhTrang.Size = new System.Drawing.Size(108, 25);
            this.ckbTinhTrang.TabIndex = 22;
            this.ckbTinhTrang.Text = "Tình trạng";
            this.ckbTinhTrang.UseVisualStyleBackColor = true;
            // 
            // ckbGhiChu
            // 
            this.ckbGhiChu.AutoSize = true;
            this.ckbGhiChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbGhiChu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGhiChu.Location = new System.Drawing.Point(473, 201);
            this.ckbGhiChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbGhiChu.Name = "ckbGhiChu";
            this.ckbGhiChu.Size = new System.Drawing.Size(87, 25);
            this.ckbGhiChu.TabIndex = 22;
            this.ckbGhiChu.Text = "Ghi chú";
            this.ckbGhiChu.UseVisualStyleBackColor = true;
            // 
            // ckbThuMuc
            // 
            this.ckbThuMuc.AutoSize = true;
            this.ckbThuMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbThuMuc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbThuMuc.Location = new System.Drawing.Point(473, 169);
            this.ckbThuMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbThuMuc.Name = "ckbThuMuc";
            this.ckbThuMuc.Size = new System.Drawing.Size(97, 25);
            this.ckbThuMuc.TabIndex = 22;
            this.ckbThuMuc.Text = "Thư mục";
            this.ckbThuMuc.UseVisualStyleBackColor = true;
            // 
            // ckbFollow
            // 
            this.ckbFollow.AutoSize = true;
            this.ckbFollow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbFollow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFollow.Location = new System.Drawing.Point(41, 233);
            this.ckbFollow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbFollow.Name = "ckbFollow";
            this.ckbFollow.Size = new System.Drawing.Size(96, 25);
            this.ckbFollow.TabIndex = 22;
            this.ckbFollow.Text = "Theo dõi";
            this.ckbFollow.UseVisualStyleBackColor = true;
            // 
            // ckbInteractEnd
            // 
            this.ckbInteractEnd.AutoSize = true;
            this.ckbInteractEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbInteractEnd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbInteractEnd.Location = new System.Drawing.Point(473, 105);
            this.ckbInteractEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbInteractEnd.Name = "ckbInteractEnd";
            this.ckbInteractEnd.Size = new System.Drawing.Size(142, 25);
            this.ckbInteractEnd.TabIndex = 22;
            this.ckbInteractEnd.Text = "Tương tác cuối";
            this.ckbInteractEnd.UseVisualStyleBackColor = true;
            // 
            // fCauHinhHienThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 363);
            this.Controls.Add(this.ckbThuMuc);
            this.Controls.Add(this.ckbGhiChu);
            this.Controls.Add(this.ckbInteractEnd);
            this.Controls.Add(this.ckbTinhTrang);
            this.Controls.Add(this.ckbProfile);
            this.Controls.Add(this.ckbAvatar);
            this.Controls.Add(this.ckbNgayTao);
            this.Controls.Add(this.ckbProxy);
            this.Controls.Add(this.ckbUseragent);
            this.Controls.Add(this.ckbMa2FA);
            this.Controls.Add(this.ckbBackup);
            this.Controls.Add(this.ckbMatKhauMail);
            this.Controls.Add(this.ckbMatKhau);
            this.Controls.Add(this.ckbGioiTinh);
            this.Controls.Add(this.ckbNgaySinh);
            this.Controls.Add(this.ckbNhom);
            this.Controls.Add(this.ckbFollow);
            this.Controls.Add(this.ckbBanBe);
            this.Controls.Add(this.ckbTen);
            this.Controls.Add(this.ckbEmail);
            this.Controls.Add(this.ckbCookie);
            this.Controls.Add(this.ckbToken);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fCauHinhHienThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fAddFile";
            this.Load += new System.EventHandler(this.fClearProfile_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000CCC RID: 3276
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000CCD RID: 3277
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000CCE RID: 3278
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000CCF RID: 3279
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000CD0 RID: 3280
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000CD1 RID: 3281
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000CD2 RID: 3282
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000CD3 RID: 3283
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000CD4 RID: 3284
		private global::Bunifu.Framework.UI.BunifuCustomLabel lblStatus;

		// Token: 0x04000CD5 RID: 3285
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000CD6 RID: 3286
		private global::System.Windows.Forms.CheckBox ckbToken;

		// Token: 0x04000CD7 RID: 3287
		private global::System.Windows.Forms.CheckBox ckbCookie;

		// Token: 0x04000CD8 RID: 3288
		private global::System.Windows.Forms.CheckBox ckbEmail;

		// Token: 0x04000CD9 RID: 3289
		private global::System.Windows.Forms.CheckBox ckbTen;

		// Token: 0x04000CDA RID: 3290
		private global::System.Windows.Forms.CheckBox ckbBanBe;

		// Token: 0x04000CDB RID: 3291
		private global::System.Windows.Forms.CheckBox ckbNhom;

		// Token: 0x04000CDC RID: 3292
		private global::System.Windows.Forms.CheckBox ckbNgaySinh;

		// Token: 0x04000CDD RID: 3293
		private global::System.Windows.Forms.CheckBox ckbGioiTinh;

		// Token: 0x04000CDE RID: 3294
		private global::System.Windows.Forms.CheckBox ckbMatKhau;

		// Token: 0x04000CDF RID: 3295
		private global::System.Windows.Forms.CheckBox ckbMatKhauMail;

		// Token: 0x04000CE0 RID: 3296
		private global::System.Windows.Forms.CheckBox ckbBackup;

		// Token: 0x04000CE1 RID: 3297
		private global::System.Windows.Forms.CheckBox ckbMa2FA;

		// Token: 0x04000CE2 RID: 3298
		private global::System.Windows.Forms.CheckBox ckbUseragent;

		// Token: 0x04000CE3 RID: 3299
		private global::System.Windows.Forms.CheckBox ckbProxy;

		// Token: 0x04000CE4 RID: 3300
		private global::System.Windows.Forms.CheckBox ckbNgayTao;

		// Token: 0x04000CE5 RID: 3301
		private global::System.Windows.Forms.CheckBox ckbAvatar;

		// Token: 0x04000CE6 RID: 3302
		private global::System.Windows.Forms.CheckBox ckbProfile;

		// Token: 0x04000CE7 RID: 3303
		private global::System.Windows.Forms.CheckBox ckbTinhTrang;

		// Token: 0x04000CE8 RID: 3304
		private global::System.Windows.Forms.CheckBox ckbGhiChu;

		// Token: 0x04000CE9 RID: 3305
		private global::System.Windows.Forms.CheckBox ckbThuMuc;

		// Token: 0x04000CEA RID: 3306
		private global::System.Windows.Forms.CheckBox ckbFollow;

		// Token: 0x04000CEB RID: 3307
		private global::System.Windows.Forms.CheckBox ckbInteractEnd;
	}
}
