namespace maxcare
{
	// Token: 0x020000B4 RID: 180
	public partial class fHDLinkToInstagram : global::System.Windows.Forms.Form
	{
		// Token: 0x060006C3 RID: 1731 RVA: 0x000AA71C File Offset: 0x000A891C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x000AA77C File Offset: 0x000A897C
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
            this.txtPathImage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbUpAvatar = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbFollow = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbPassTuNhap = new System.Windows.Forms.RadioButton();
            this.rbPassRandom = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPathFileSaveAcc = new System.Windows.Forms.TextBox();
            this.txtTenHanhDong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(402, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Liên kết Instagram";
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
            this.pnlHeader.Size = new System.Drawing.Size(402, 31);
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
            this.button1.Location = new System.Drawing.Point(371, 1);
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
            this.panel1.Controls.Add(this.ckbUpAvatar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ckbFollow);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rbPassTuNhap);
            this.panel1.Controls.Add(this.rbPassRandom);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.txtPathFileSaveAcc);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 268);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtPathImage);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(145, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 27);
            this.panel3.TabIndex = 47;
            // 
            // txtPathImage
            // 
            this.txtPathImage.Location = new System.Drawing.Point(97, 2);
            this.txtPathImage.Name = "txtPathImage";
            this.txtPathImage.Size = new System.Drawing.Size(131, 27);
            this.txtPathImage.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Thư mục ảnh:";
            // 
            // ckbUpAvatar
            // 
            this.ckbUpAvatar.AutoSize = true;
            this.ckbUpAvatar.Location = new System.Drawing.Point(31, 159);
            this.ckbUpAvatar.Name = "ckbUpAvatar";
            this.ckbUpAvatar.Size = new System.Drawing.Size(112, 25);
            this.ckbUpAvatar.TabIndex = 42;
            this.ckbUpAvatar.Text = "Up Avatar:";
            this.ckbUpAvatar.UseVisualStyleBackColor = true;
            this.ckbUpAvatar.CheckedChanged += new System.EventHandler(this.ckbUpAvatar_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudSoLuongFrom);
            this.panel2.Controls.Add(this.nudSoLuongTo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(145, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 27);
            this.panel2.TabIndex = 47;
            // 
            // nudSoLuongFrom
            // 
            this.nudSoLuongFrom.Location = new System.Drawing.Point(1, 2);
            this.nudSoLuongFrom.Name = "nudSoLuongFrom";
            this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongFrom.TabIndex = 43;
            // 
            // nudSoLuongTo
            // 
            this.nudSoLuongTo.Location = new System.Drawing.Point(97, 2);
            this.nudSoLuongTo.Name = "nudSoLuongTo";
            this.nudSoLuongTo.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongTo.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 45;
            this.label4.Text = "người";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(62, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "đến";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckbFollow
            // 
            this.ckbFollow.AutoSize = true;
            this.ckbFollow.Location = new System.Drawing.Point(31, 189);
            this.ckbFollow.Name = "ckbFollow";
            this.ckbFollow.Size = new System.Drawing.Size(126, 25);
            this.ckbFollow.TabIndex = 42;
            this.ckbFollow.Text = "Follow gợi ý:";
            this.ckbFollow.UseVisualStyleBackColor = true;
            this.ckbFollow.CheckedChanged += new System.EventHandler(this.ckbFollow_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "File lưu tài khoản:";
            // 
            // rbPassTuNhap
            // 
            this.rbPassTuNhap.AutoSize = true;
            this.rbPassTuNhap.Location = new System.Drawing.Point(145, 100);
            this.rbPassTuNhap.Name = "rbPassTuNhap";
            this.rbPassTuNhap.Size = new System.Drawing.Size(98, 25);
            this.rbPassTuNhap.TabIndex = 40;
            this.rbPassTuNhap.Text = "Tự nhập:";
            this.rbPassTuNhap.UseVisualStyleBackColor = true;
            this.rbPassTuNhap.CheckedChanged += new System.EventHandler(this.rbPassTuNhap_CheckedChanged);
            // 
            // rbPassRandom
            // 
            this.rbPassRandom.AutoSize = true;
            this.rbPassRandom.Checked = true;
            this.rbPassRandom.Location = new System.Drawing.Point(145, 76);
            this.rbPassRandom.Name = "rbPassRandom";
            this.rbPassRandom.Size = new System.Drawing.Size(114, 25);
            this.rbPassRandom.TabIndex = 39;
            this.rbPassRandom.TabStop = true;
            this.rbPassRandom.Text = "Ngẫu nhiên";
            this.rbPassRandom.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(230, 99);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(146, 27);
            this.txtPassword.TabIndex = 38;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(28, 75);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 21);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Mật khẩu:";
            // 
            // txtPathFileSaveAcc
            // 
            this.txtPathFileSaveAcc.Location = new System.Drawing.Point(145, 128);
            this.txtPathFileSaveAcc.Name = "txtPathFileSaveAcc";
            this.txtPathFileSaveAcc.ReadOnly = true;
            this.txtPathFileSaveAcc.Size = new System.Drawing.Size(231, 27);
            this.txtPathFileSaveAcc.TabIndex = 0;
            this.txtPathFileSaveAcc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(145, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(231, 27);
            this.txtTenHanhDong.TabIndex = 0;
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
            this.btnCancel.Location = new System.Drawing.Point(214, 227);
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
            this.btnAdd.Location = new System.Drawing.Point(107, 227);
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
            this.bunifuCards1.Size = new System.Drawing.Size(402, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDLinkToInstagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 268);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDLinkToInstagram";
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
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x0400071E RID: 1822
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400071F RID: 1823
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000720 RID: 1824
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000721 RID: 1825
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000722 RID: 1826
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000723 RID: 1827
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000724 RID: 1828
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000725 RID: 1829
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000726 RID: 1830
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000727 RID: 1831
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000728 RID: 1832
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000729 RID: 1833
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x0400072A RID: 1834
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400072B RID: 1835
		private global::System.Windows.Forms.TextBox txtPassword;

		// Token: 0x0400072C RID: 1836
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400072D RID: 1837
		private global::System.Windows.Forms.RadioButton rbPassTuNhap;

		// Token: 0x0400072E RID: 1838
		private global::System.Windows.Forms.RadioButton rbPassRandom;

		// Token: 0x0400072F RID: 1839
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000730 RID: 1840
		private global::System.Windows.Forms.CheckBox ckbFollow;

		// Token: 0x04000731 RID: 1841
		private global::System.Windows.Forms.TextBox txtPathFileSaveAcc;

		// Token: 0x04000732 RID: 1842
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000733 RID: 1843
		private global::System.Windows.Forms.TextBox txtPathImage;

		// Token: 0x04000734 RID: 1844
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000735 RID: 1845
		private global::System.Windows.Forms.CheckBox ckbUpAvatar;

		// Token: 0x04000736 RID: 1846
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000737 RID: 1847
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x04000738 RID: 1848
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x04000739 RID: 1849
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400073A RID: 1850
		private global::System.Windows.Forms.Label label3;
	}
}
