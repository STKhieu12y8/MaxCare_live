namespace maxcare
{
	// Token: 0x020000D0 RID: 208
	public partial class fHDPhanHoiBinhLuan : global::System.Windows.Forms.Form
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x0010B250 File Offset: 0x00109450
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0010B2B0 File Offset: 0x001094B0
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
            this.txtUid = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.ckbCommentText = new System.Windows.Forms.CheckBox();
            this.ckbCommentImage = new System.Windows.Forms.CheckBox();
            this.ckbGanThe = new System.Windows.Forms.CheckBox();
            this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(812, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Phản hồi bình luận";
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
            this.pnlHeader.Size = new System.Drawing.Size(812, 31);
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
            this.button1.Location = new System.Drawing.Point(781, 1);
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
            this.panel1.Controls.Add(this.txtUid);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.ckbCommentText);
            this.panel1.Controls.Add(this.ckbCommentImage);
            this.panel1.Controls.Add(this.ckbGanThe);
            this.panel1.Controls.Add(this.nudSoLuongTo);
            this.panel1.Controls.Add(this.nudSoLuongFrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
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
            this.panel1.Size = new System.Drawing.Size(815, 547);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(442, 103);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(302, 366);
            this.txtUid.TabIndex = 56;
            this.txtUid.Text = "";
            this.txtUid.TextChanged += new System.EventHandler(this.txtIdPost_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.txtComment);
            this.panel2.Controls.Add(this.lblComment);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(43, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 262);
            this.panel2.TabIndex = 54;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(271, 236);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 21);
            this.linkLabel1.TabIndex = 191;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Random icon";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(7, 23);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(346, 210);
            this.txtComment.TabIndex = 55;
            this.txtComment.Text = "";
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(4, 4);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(196, 21);
            this.lblComment.TabIndex = 53;
            this.lblComment.Text = "Danh sách comment (0):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(308, 21);
            this.label9.TabIndex = 52;
            this.label9.Text = "(Mỗi nội dung 1 dòng, spin text {a|b|c})";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(162, 168);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(235, 27);
            this.txtPath.TabIndex = 50;
            // 
            // ckbCommentText
            // 
            this.ckbCommentText.AutoSize = true;
            this.ckbCommentText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCommentText.Location = new System.Drawing.Point(32, 196);
            this.ckbCommentText.Name = "ckbCommentText";
            this.ckbCommentText.Size = new System.Drawing.Size(163, 25);
            this.ckbCommentText.TabIndex = 49;
            this.ckbCommentText.Text = "Bình luận văn bản";
            this.ckbCommentText.UseVisualStyleBackColor = true;
            this.ckbCommentText.CheckedChanged += new System.EventHandler(this.ckbCommentText_CheckedChanged);
            // 
            // ckbCommentImage
            // 
            this.ckbCommentImage.AutoSize = true;
            this.ckbCommentImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCommentImage.Location = new System.Drawing.Point(32, 170);
            this.ckbCommentImage.Name = "ckbCommentImage";
            this.ckbCommentImage.Size = new System.Drawing.Size(132, 25);
            this.ckbCommentImage.TabIndex = 48;
            this.ckbCommentImage.Text = "Bình luận ảnh";
            this.ckbCommentImage.UseVisualStyleBackColor = true;
            this.ckbCommentImage.CheckedChanged += new System.EventHandler(this.ckbCommentImage_CheckedChanged);
            // 
            // ckbGanThe
            // 
            this.ckbGanThe.AutoSize = true;
            this.ckbGanThe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbGanThe.Location = new System.Drawing.Point(32, 144);
            this.ckbGanThe.Name = "ckbGanThe";
            this.ckbGanThe.Size = new System.Drawing.Size(155, 25);
            this.ckbGanThe.TabIndex = 47;
            this.ckbGanThe.Text = "Tự động gắn thẻ";
            this.ckbGanThe.UseVisualStyleBackColor = true;
            // 
            // nudSoLuongTo
            // 
            this.nudSoLuongTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudSoLuongTo.Location = new System.Drawing.Point(259, 82);
            this.nudSoLuongTo.Name = "nudSoLuongTo";
            this.nudSoLuongTo.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongTo.TabIndex = 43;
            // 
            // nudSoLuongFrom
            // 
            this.nudSoLuongFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudSoLuongFrom.Location = new System.Drawing.Point(162, 82);
            this.nudSoLuongFrom.Name = "nudSoLuongFrom";
            this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongFrom.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(224, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "đến";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 45;
            this.label4.Text = "comment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 21);
            this.label8.TabIndex = 44;
            this.label8.Text = "Số comment/ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(439, 472);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 21);
            this.label10.TabIndex = 39;
            this.label10.Text = "(Mỗi ID Comment 1 dòng)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Danh sách ID Comment (0):";
            // 
            // nudDelayTo
            // 
            this.nudDelayTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudDelayTo.Location = new System.Drawing.Point(259, 114);
            this.nudDelayTo.Name = "nudDelayTo";
            this.nudDelayTo.Size = new System.Drawing.Size(56, 27);
            this.nudDelayTo.TabIndex = 4;
            // 
            // nudDelayFrom
            // 
            this.nudDelayFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudDelayFrom.Location = new System.Drawing.Point(162, 114);
            this.nudDelayFrom.Name = "nudDelayFrom";
            this.nudDelayFrom.Size = new System.Drawing.Size(56, 27);
            this.nudDelayFrom.TabIndex = 3;
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(162, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(216, 27);
            this.txtTenHanhDong.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(224, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "đến";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "giây";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 116);
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
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(397, 505);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 10;
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
            this.btnAdd.Location = new System.Drawing.Point(290, 505);
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
            this.bunifuCards1.Size = new System.Drawing.Size(812, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDPhanHoiBinhLuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 547);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDPhanHoiBinhLuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04000BED RID: 3053
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000BEE RID: 3054
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000BEF RID: 3055
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000BF0 RID: 3056
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000BF1 RID: 3057
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04000BF2 RID: 3058
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04000BF3 RID: 3059
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000BF4 RID: 3060
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000BF5 RID: 3061
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000BF6 RID: 3062
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000BF7 RID: 3063
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000BF8 RID: 3064
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000BF9 RID: 3065
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000BFA RID: 3066
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000BFB RID: 3067
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000BFC RID: 3068
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000BFD RID: 3069
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000BFE RID: 3070
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000BFF RID: 3071
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000C00 RID: 3072
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000C01 RID: 3073
		private global::System.Windows.Forms.CheckBox ckbCommentImage;

		// Token: 0x04000C02 RID: 3074
		private global::System.Windows.Forms.CheckBox ckbGanThe;

		// Token: 0x04000C03 RID: 3075
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x04000C04 RID: 3076
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x04000C05 RID: 3077
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000C06 RID: 3078
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000C07 RID: 3079
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000C08 RID: 3080
		private global::System.Windows.Forms.TextBox txtPath;

		// Token: 0x04000C09 RID: 3081
		private global::System.Windows.Forms.CheckBox ckbCommentText;

		// Token: 0x04000C0A RID: 3082
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000C0B RID: 3083
		private global::System.Windows.Forms.Label lblComment;

		// Token: 0x04000C0C RID: 3084
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000C0D RID: 3085
		private global::System.Windows.Forms.RichTextBox txtUid;

		// Token: 0x04000C0E RID: 3086
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x04000C0F RID: 3087
		private global::System.Windows.Forms.LinkLabel linkLabel1;
	}
}
