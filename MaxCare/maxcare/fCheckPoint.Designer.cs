namespace maxcare
{
	// Token: 0x0200006B RID: 107
	public partial class fCheckPoint : global::System.Windows.Forms.Form
	{
		// Token: 0x0600044B RID: 1099 RVA: 0x00051E00 File Offset: 0x00050000
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00051E60 File Offset: 0x00050060
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbAnyCaptcha = new System.Windows.Forms.RadioButton();
            this.txtAnyCaptcha = new System.Windows.Forms.TextBox();
            this.rbGuru = new System.Windows.Forms.RadioButton();
            this.rb2Captcha = new System.Windows.Forms.RadioButton();
            this.txtGuru = new System.Windows.Forms.TextBox();
            this.txt2Captcha = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbPrimeOtp = new System.Windows.Forms.RadioButton();
            this.txtPrimeOtp = new System.Windows.Forms.TextBox();
            this.rbOtpmmo = new System.Windows.Forms.RadioButton();
            this.txtOtpmmo = new System.Windows.Forms.TextBox();
            this.rbSimCode = new System.Windows.Forms.RadioButton();
            this.txtSimCode = new System.Windows.Forms.TextBox();
            this.rbOtpSim = new System.Windows.Forms.RadioButton();
            this.txtOtpSim = new System.Windows.Forms.TextBox();
            this.rbTextNow = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTextNow = new System.Windows.Forms.TextBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.ckbImage = new System.Windows.Forms.CheckBox();
            this.ckbPhone = new System.Windows.Forms.CheckBox();
            this.ckbCaptcha = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(420, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Giải Checkpoint";
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
            this.pnlHeader.Size = new System.Drawing.Size(420, 31);
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
            this.button1.Location = new System.Drawing.Point(389, 1);
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
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtImage);
            this.panel1.Controls.Add(this.ckbImage);
            this.panel1.Controls.Add(this.ckbPhone);
            this.panel1.Controls.Add(this.ckbCaptcha);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rbAnyCaptcha);
            this.panel3.Controls.Add(this.txtAnyCaptcha);
            this.panel3.Controls.Add(this.rbGuru);
            this.panel3.Controls.Add(this.rb2Captcha);
            this.panel3.Controls.Add(this.txtGuru);
            this.panel3.Controls.Add(this.txt2Captcha);
            this.panel3.Location = new System.Drawing.Point(43, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 83);
            this.panel3.TabIndex = 39;
            // 
            // rbAnyCaptcha
            // 
            this.rbAnyCaptcha.AutoSize = true;
            this.rbAnyCaptcha.Location = new System.Drawing.Point(3, 3);
            this.rbAnyCaptcha.Name = "rbAnyCaptcha";
            this.rbAnyCaptcha.Size = new System.Drawing.Size(151, 25);
            this.rbAnyCaptcha.TabIndex = 44;
            this.rbAnyCaptcha.Text = "anycaptcha.com";
            this.rbAnyCaptcha.UseVisualStyleBackColor = true;
            this.rbAnyCaptcha.CheckedChanged += new System.EventHandler(this.rbAnyCaptcha_CheckedChanged);
            // 
            // txtAnyCaptcha
            // 
            this.txtAnyCaptcha.Location = new System.Drawing.Point(123, 2);
            this.txtAnyCaptcha.Name = "txtAnyCaptcha";
            this.txtAnyCaptcha.Size = new System.Drawing.Size(240, 27);
            this.txtAnyCaptcha.TabIndex = 43;
            // 
            // rbGuru
            // 
            this.rbGuru.AutoSize = true;
            this.rbGuru.Location = new System.Drawing.Point(3, 56);
            this.rbGuru.Name = "rbGuru";
            this.rbGuru.Size = new System.Drawing.Size(133, 25);
            this.rbGuru.TabIndex = 42;
            this.rbGuru.Text = "captcha.guru:";
            this.rbGuru.UseVisualStyleBackColor = true;
            this.rbGuru.CheckedChanged += new System.EventHandler(this.rbGuru_CheckedChanged);
            // 
            // rb2Captcha
            // 
            this.rb2Captcha.AutoSize = true;
            this.rb2Captcha.Checked = true;
            this.rb2Captcha.Location = new System.Drawing.Point(3, 29);
            this.rb2Captcha.Name = "rb2Captcha";
            this.rb2Captcha.Size = new System.Drawing.Size(140, 25);
            this.rb2Captcha.TabIndex = 41;
            this.rb2Captcha.TabStop = true;
            this.rb2Captcha.Text = "2captcha.com:";
            this.rb2Captcha.UseVisualStyleBackColor = true;
            this.rb2Captcha.CheckedChanged += new System.EventHandler(this.rb2Captcha_CheckedChanged);
            // 
            // txtGuru
            // 
            this.txtGuru.Location = new System.Drawing.Point(123, 55);
            this.txtGuru.Name = "txtGuru";
            this.txtGuru.Size = new System.Drawing.Size(240, 27);
            this.txtGuru.TabIndex = 34;
            // 
            // txt2Captcha
            // 
            this.txt2Captcha.Location = new System.Drawing.Point(123, 28);
            this.txt2Captcha.Name = "txt2Captcha";
            this.txt2Captcha.Size = new System.Drawing.Size(240, 27);
            this.txt2Captcha.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbPrimeOtp);
            this.panel2.Controls.Add(this.txtPrimeOtp);
            this.panel2.Controls.Add(this.rbOtpmmo);
            this.panel2.Controls.Add(this.txtOtpmmo);
            this.panel2.Controls.Add(this.rbSimCode);
            this.panel2.Controls.Add(this.txtSimCode);
            this.panel2.Controls.Add(this.rbOtpSim);
            this.panel2.Controls.Add(this.txtOtpSim);
            this.panel2.Controls.Add(this.rbTextNow);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nudTime);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTextNow);
            this.panel2.Location = new System.Drawing.Point(40, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 170);
            this.panel2.TabIndex = 38;
            // 
            // rbPrimeOtp
            // 
            this.rbPrimeOtp.AutoSize = true;
            this.rbPrimeOtp.Location = new System.Drawing.Point(6, 58);
            this.rbPrimeOtp.Name = "rbPrimeOtp";
            this.rbPrimeOtp.Size = new System.Drawing.Size(131, 25);
            this.rbPrimeOtp.TabIndex = 48;
            this.rbPrimeOtp.Text = "Primeotp.me:";
            this.rbPrimeOtp.UseVisualStyleBackColor = true;
            this.rbPrimeOtp.CheckedChanged += new System.EventHandler(this.rbPrimeOtp_CheckedChanged);
            // 
            // txtPrimeOtp
            // 
            this.txtPrimeOtp.Location = new System.Drawing.Point(165, 57);
            this.txtPrimeOtp.Name = "txtPrimeOtp";
            this.txtPrimeOtp.Size = new System.Drawing.Size(201, 27);
            this.txtPrimeOtp.TabIndex = 47;
            // 
            // rbOtpmmo
            // 
            this.rbOtpmmo.AutoSize = true;
            this.rbOtpmmo.Checked = true;
            this.rbOtpmmo.Location = new System.Drawing.Point(6, 7);
            this.rbOtpmmo.Name = "rbOtpmmo";
            this.rbOtpmmo.Size = new System.Drawing.Size(137, 25);
            this.rbOtpmmo.TabIndex = 46;
            this.rbOtpmmo.TabStop = true;
            this.rbOtpmmo.Text = "Otpmmo.com:";
            this.rbOtpmmo.UseVisualStyleBackColor = true;
            this.rbOtpmmo.CheckedChanged += new System.EventHandler(this.rbOtpmmo_CheckedChanged);
            // 
            // txtOtpmmo
            // 
            this.txtOtpmmo.Location = new System.Drawing.Point(165, 3);
            this.txtOtpmmo.Name = "txtOtpmmo";
            this.txtOtpmmo.Size = new System.Drawing.Size(201, 27);
            this.txtOtpmmo.TabIndex = 45;
            // 
            // rbSimCode
            // 
            this.rbSimCode.AutoSize = true;
            this.rbSimCode.Location = new System.Drawing.Point(6, 112);
            this.rbSimCode.Name = "rbSimCode";
            this.rbSimCode.Size = new System.Drawing.Size(195, 25);
            this.rbSimCode.TabIndex = 44;
            this.rbSimCode.Text = "Chothuesimcode.com:";
            this.rbSimCode.UseVisualStyleBackColor = true;
            this.rbSimCode.CheckedChanged += new System.EventHandler(this.rbSimCode_CheckedChanged);
            // 
            // txtSimCode
            // 
            this.txtSimCode.Location = new System.Drawing.Point(165, 111);
            this.txtSimCode.Name = "txtSimCode";
            this.txtSimCode.Size = new System.Drawing.Size(201, 27);
            this.txtSimCode.TabIndex = 43;
            // 
            // rbOtpSim
            // 
            this.rbOtpSim.AutoSize = true;
            this.rbOtpSim.Location = new System.Drawing.Point(6, 84);
            this.rbOtpSim.Name = "rbOtpSim";
            this.rbOtpSim.Size = new System.Drawing.Size(127, 25);
            this.rbOtpSim.TabIndex = 42;
            this.rbOtpSim.Text = "OtpSim.com:";
            this.rbOtpSim.UseVisualStyleBackColor = true;
            this.rbOtpSim.CheckedChanged += new System.EventHandler(this.rbOtpSim_CheckedChanged);
            // 
            // txtOtpSim
            // 
            this.txtOtpSim.Location = new System.Drawing.Point(165, 83);
            this.txtOtpSim.Name = "txtOtpSim";
            this.txtOtpSim.Size = new System.Drawing.Size(201, 27);
            this.txtOtpSim.TabIndex = 41;
            // 
            // rbTextNow
            // 
            this.rbTextNow.AutoSize = true;
            this.rbTextNow.Location = new System.Drawing.Point(6, 32);
            this.rbTextNow.Name = "rbTextNow";
            this.rbTextNow.Size = new System.Drawing.Size(170, 25);
            this.rbTextNow.TabIndex = 40;
            this.rbTextNow.Text = "Codetextnow.com:";
            this.rbTextNow.UseVisualStyleBackColor = true;
            this.rbTextNow.CheckedChanged += new System.EventHandler(this.rbTextNow_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "giây";
            // 
            // nudTime
            // 
            this.nudTime.Location = new System.Drawing.Point(41, 141);
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(56, 27);
            this.nudTime.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Chờ:";
            // 
            // txtTextNow
            // 
            this.txtTextNow.Location = new System.Drawing.Point(165, 31);
            this.txtTextNow.Name = "txtTextNow";
            this.txtTextNow.Size = new System.Drawing.Size(201, 27);
            this.txtTextNow.TabIndex = 35;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(120, 369);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(290, 27);
            this.txtImage.TabIndex = 37;
            // 
            // ckbImage
            // 
            this.ckbImage.AutoSize = true;
            this.ckbImage.Location = new System.Drawing.Point(22, 371);
            this.ckbImage.Name = "ckbImage";
            this.ckbImage.Size = new System.Drawing.Size(90, 25);
            this.ckbImage.TabIndex = 36;
            this.ckbImage.Text = "Up ảnh:";
            this.ckbImage.UseVisualStyleBackColor = true;
            this.ckbImage.CheckedChanged += new System.EventHandler(this.ckbImage_CheckedChanged);
            // 
            // ckbPhone
            // 
            this.ckbPhone.AutoSize = true;
            this.ckbPhone.Location = new System.Drawing.Point(22, 169);
            this.ckbPhone.Name = "ckbPhone";
            this.ckbPhone.Size = new System.Drawing.Size(116, 25);
            this.ckbPhone.TabIndex = 34;
            this.ckbPhone.Text = "Thêm SĐT:";
            this.ckbPhone.UseVisualStyleBackColor = true;
            this.ckbPhone.CheckedChanged += new System.EventHandler(this.ckbPhone_CheckedChanged);
            // 
            // ckbCaptcha
            // 
            this.ckbCaptcha.AutoSize = true;
            this.ckbCaptcha.Location = new System.Drawing.Point(22, 54);
            this.ckbCaptcha.Name = "ckbCaptcha";
            this.ckbCaptcha.Size = new System.Drawing.Size(129, 25);
            this.ckbCaptcha.TabIndex = 32;
            this.ckbCaptcha.Text = "Giải captcha:";
            this.ckbCaptcha.UseVisualStyleBackColor = true;
            this.ckbCaptcha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.btnCancel.Location = new System.Drawing.Point(221, 408);
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
            this.btnAdd.Location = new System.Drawing.Point(114, 408);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Lưu";
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
            this.bunifuCards1.Size = new System.Drawing.Size(420, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fCheckPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fCheckPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04000301 RID: 769
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000302 RID: 770
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000303 RID: 771
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000304 RID: 772
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000305 RID: 773
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000306 RID: 774
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000307 RID: 775
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000308 RID: 776
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000309 RID: 777
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400030A RID: 778
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400030B RID: 779
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x0400030C RID: 780
		private global::System.Windows.Forms.CheckBox ckbCaptcha;

		// Token: 0x0400030D RID: 781
		private global::System.Windows.Forms.TextBox txtImage;

		// Token: 0x0400030E RID: 782
		private global::System.Windows.Forms.CheckBox ckbImage;

		// Token: 0x0400030F RID: 783
		private global::System.Windows.Forms.TextBox txtTextNow;

		// Token: 0x04000310 RID: 784
		private global::System.Windows.Forms.CheckBox ckbPhone;

		// Token: 0x04000311 RID: 785
		private global::System.Windows.Forms.TextBox txt2Captcha;

		// Token: 0x04000312 RID: 786
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000313 RID: 787
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000314 RID: 788
		private global::System.Windows.Forms.NumericUpDown nudTime;

		// Token: 0x04000315 RID: 789
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000316 RID: 790
		private global::System.Windows.Forms.RadioButton rbSimCode;

		// Token: 0x04000317 RID: 791
		private global::System.Windows.Forms.TextBox txtSimCode;

		// Token: 0x04000318 RID: 792
		private global::System.Windows.Forms.RadioButton rbOtpSim;

		// Token: 0x04000319 RID: 793
		private global::System.Windows.Forms.TextBox txtOtpSim;

		// Token: 0x0400031A RID: 794
		private global::System.Windows.Forms.RadioButton rbTextNow;

		// Token: 0x0400031B RID: 795
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x0400031C RID: 796
		private global::System.Windows.Forms.RadioButton rbGuru;

		// Token: 0x0400031D RID: 797
		private global::System.Windows.Forms.RadioButton rb2Captcha;

		// Token: 0x0400031E RID: 798
		private global::System.Windows.Forms.TextBox txtGuru;

		// Token: 0x0400031F RID: 799
		private global::System.Windows.Forms.RadioButton rbOtpmmo;

		// Token: 0x04000320 RID: 800
		private global::System.Windows.Forms.TextBox txtOtpmmo;

		// Token: 0x04000321 RID: 801
		private global::System.Windows.Forms.RadioButton rbAnyCaptcha;

		// Token: 0x04000322 RID: 802
		private global::System.Windows.Forms.TextBox txtAnyCaptcha;

		// Token: 0x04000323 RID: 803
		private global::System.Windows.Forms.RadioButton rbPrimeOtp;

		// Token: 0x04000324 RID: 804
		private global::System.Windows.Forms.TextBox txtPrimeOtp;
	}
}
