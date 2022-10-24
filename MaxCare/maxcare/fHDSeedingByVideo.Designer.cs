namespace maxcare
{
	// Token: 0x020000FD RID: 253
	public partial class fHDSeedingByVideo : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A6A RID: 2666 RVA: 0x0015B9B4 File Offset: 0x00159BB4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0015BA14 File Offset: 0x00159C14
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
            this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
            this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.plVideo = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.txtVideo = new System.Windows.Forms.TextBox();
            this.txtIdPost = new System.Windows.Forms.RichTextBox();
            this.ckbSendVideo = new System.Windows.Forms.CheckBox();
            this.ckbComment = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
            this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.txtTenHanhDong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.plComment.SuspendLayout();
            this.plVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(684, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Seeding bài viết";
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
            this.pnlHeader.Size = new System.Drawing.Size(684, 31);
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
            this.button1.Location = new System.Drawing.Point(653, 1);
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
            this.panel1.Controls.Add(this.plVideo);
            this.panel1.Controls.Add(this.txtIdPost);
            this.panel1.Controls.Add(this.ckbSendVideo);
            this.panel1.Controls.Add(this.ckbComment);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nudDelayTo);
            this.panel1.Controls.Add(this.nudDelayFrom);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 437);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // plComment
            // 
            this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plComment.Controls.Add(this.rbNganCachKyTu);
            this.plComment.Controls.Add(this.rbNganCachMoiDong);
            this.plComment.Controls.Add(this.label8);
            this.plComment.Controls.Add(this.txtComment);
            this.plComment.Controls.Add(this.label11);
            this.plComment.Controls.Add(this.lblStatus);
            this.plComment.Location = new System.Drawing.Point(371, 104);
            this.plComment.Name = "plComment";
            this.plComment.Size = new System.Drawing.Size(281, 193);
            this.plComment.TabIndex = 164;
            // 
            // rbNganCachKyTu
            // 
            this.rbNganCachKyTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbNganCachKyTu.AutoSize = true;
            this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachKyTu.Location = new System.Drawing.Point(70, 163);
            this.rbNganCachKyTu.Name = "rbNganCachKyTu";
            this.rbNganCachKyTu.Size = new System.Drawing.Size(259, 25);
            this.rbNganCachKyTu.TabIndex = 3;
            this.rbNganCachKyTu.Text = "Các nội dung ngăn cách bởi \"|\"";
            this.rbNganCachKyTu.UseVisualStyleBackColor = true;
            // 
            // rbNganCachMoiDong
            // 
            this.rbNganCachMoiDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbNganCachMoiDong.AutoSize = true;
            this.rbNganCachMoiDong.Checked = true;
            this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachMoiDong.Location = new System.Drawing.Point(70, 142);
            this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
            this.rbNganCachMoiDong.Size = new System.Drawing.Size(218, 25);
            this.rbNganCachMoiDong.TabIndex = 3;
            this.rbNganCachMoiDong.TabStop = true;
            this.rbNganCachMoiDong.Text = "Mỗi dòng là một nội dung";
            this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tùy chọn:";
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
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 127);
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
            // plVideo
            // 
            this.plVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plVideo.Controls.Add(this.button3);
            this.plVideo.Controls.Add(this.txtVideo);
            this.plVideo.Enabled = false;
            this.plVideo.Location = new System.Drawing.Point(371, 325);
            this.plVideo.Name = "plVideo";
            this.plVideo.Size = new System.Drawing.Size(281, 31);
            this.plVideo.TabIndex = 166;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(217, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 25);
            this.button3.TabIndex = 156;
            this.button3.Text = "Chọn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtVideo
            // 
            this.txtVideo.Location = new System.Drawing.Point(3, 3);
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.Size = new System.Drawing.Size(208, 27);
            this.txtVideo.TabIndex = 155;
            // 
            // txtIdPost
            // 
            this.txtIdPost.Location = new System.Drawing.Point(30, 129);
            this.txtIdPost.Name = "txtIdPost";
            this.txtIdPost.Size = new System.Drawing.Size(297, 230);
            this.txtIdPost.TabIndex = 1;
            this.txtIdPost.Text = "";
            this.txtIdPost.WordWrap = false;
            this.txtIdPost.TextChanged += new System.EventHandler(this.txtIdPost_TextChanged);
            // 
            // ckbSendVideo
            // 
            this.ckbSendVideo.AutoSize = true;
            this.ckbSendVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbSendVideo.Location = new System.Drawing.Point(353, 303);
            this.ckbSendVideo.Name = "ckbSendVideo";
            this.ckbSendVideo.Size = new System.Drawing.Size(144, 25);
            this.ckbSendVideo.TabIndex = 165;
            this.ckbSendVideo.Text = "Bình luận video";
            this.ckbSendVideo.UseVisualStyleBackColor = true;
            this.ckbSendVideo.CheckedChanged += new System.EventHandler(this.ckbSendVideo_CheckedChanged);
            // 
            // ckbComment
            // 
            this.ckbComment.AutoSize = true;
            this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbComment.Location = new System.Drawing.Point(353, 79);
            this.ckbComment.Name = "ckbComment";
            this.ckbComment.Size = new System.Drawing.Size(163, 25);
            this.ckbComment.TabIndex = 163;
            this.ckbComment.Text = "Bình luận văn bản";
            this.ckbComment.UseVisualStyleBackColor = true;
            this.ckbComment.CheckedChanged += new System.EventHandler(this.ckbComment_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 21);
            this.label10.TabIndex = 39;
            this.label10.Text = "(Mỗi ID 1 dòng)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Danh sách ID bài viết (0):";
            // 
            // nudDelayTo
            // 
            this.nudDelayTo.Location = new System.Drawing.Point(231, 78);
            this.nudDelayTo.Name = "nudDelayTo";
            this.nudDelayTo.Size = new System.Drawing.Size(56, 27);
            this.nudDelayTo.TabIndex = 4;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "đến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "giây";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Thời gian delay:";
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
            this.btnCancel.Location = new System.Drawing.Point(343, 395);
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
            this.btnAdd.Location = new System.Drawing.Point(236, 395);
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
            this.bunifuCards1.Size = new System.Drawing.Size(684, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDSeedingByVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 437);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDSeedingByVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plComment.ResumeLayout(false);
            this.plComment.PerformLayout();
            this.plVideo.ResumeLayout(false);
            this.plVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04000F03 RID: 3843
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000F04 RID: 3844
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000F05 RID: 3845
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000F06 RID: 3846
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000F07 RID: 3847
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04000F08 RID: 3848
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04000F09 RID: 3849
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000F0A RID: 3850
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000F0B RID: 3851
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000F0C RID: 3852
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000F0D RID: 3853
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000F0E RID: 3854
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000F0F RID: 3855
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000F10 RID: 3856
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000F11 RID: 3857
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000F12 RID: 3858
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000F13 RID: 3859
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000F14 RID: 3860
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000F15 RID: 3861
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000F16 RID: 3862
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000F17 RID: 3863
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x04000F18 RID: 3864
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x04000F19 RID: 3865
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x04000F1A RID: 3866
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000F1B RID: 3867
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x04000F1C RID: 3868
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000F1D RID: 3869
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000F1E RID: 3870
		private global::System.Windows.Forms.Panel plVideo;

		// Token: 0x04000F1F RID: 3871
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000F20 RID: 3872
		private global::System.Windows.Forms.TextBox txtVideo;

		// Token: 0x04000F21 RID: 3873
		private global::System.Windows.Forms.RichTextBox txtIdPost;

		// Token: 0x04000F22 RID: 3874
		private global::System.Windows.Forms.CheckBox ckbSendVideo;

		// Token: 0x04000F23 RID: 3875
		private global::System.Windows.Forms.CheckBox ckbComment;
	}
}
