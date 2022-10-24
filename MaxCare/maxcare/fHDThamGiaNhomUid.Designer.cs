namespace maxcare
{
	// Token: 0x02000110 RID: 272
	public partial class fHDThamGiaNhomUid : global::System.Windows.Forms.Form
	{
		// Token: 0x06000BD8 RID: 3032 RVA: 0x001A6908 File Offset: 0x001A4B08
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x001A6968 File Offset: 0x001A4B68
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
            this.plTuongTac = new System.Windows.Forms.Panel();
            this.txtCauTraLoi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStatusComment = new System.Windows.Forms.Label();
            this.ckbTuDongTraLoiCauHoi = new System.Windows.Forms.CheckBox();
            this.txtUid = new System.Windows.Forms.RichTextBox();
            this.ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
            this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.plTuongTac.SuspendLayout();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(687, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Tham gia nhóm theo tệp UID";
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
            this.pnlHeader.Size = new System.Drawing.Size(687, 31);
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
            this.button1.Location = new System.Drawing.Point(656, 1);
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
            this.panel1.Controls.Add(this.plTuongTac);
            this.panel1.Controls.Add(this.ckbTuDongTraLoiCauHoi);
            this.panel1.Controls.Add(this.txtUid);
            this.panel1.Controls.Add(this.ckbTuDongXoaUid);
            this.panel1.Controls.Add(this.nudDelayTo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblStatus);
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
            this.panel1.Size = new System.Drawing.Size(690, 402);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // plTuongTac
            // 
            this.plTuongTac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTuongTac.Controls.Add(this.txtCauTraLoi);
            this.plTuongTac.Controls.Add(this.label9);
            this.plTuongTac.Controls.Add(this.lblStatusComment);
            this.plTuongTac.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plTuongTac.Location = new System.Drawing.Point(48, 162);
            this.plTuongTac.Name = "plTuongTac";
            this.plTuongTac.Size = new System.Drawing.Size(278, 179);
            this.plTuongTac.TabIndex = 116;
            // 
            // txtCauTraLoi
            // 
            this.txtCauTraLoi.Location = new System.Drawing.Point(6, 25);
            this.txtCauTraLoi.Multiline = true;
            this.txtCauTraLoi.Name = "txtCauTraLoi";
            this.txtCauTraLoi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCauTraLoi.Size = new System.Drawing.Size(265, 128);
            this.txtCauTraLoi.TabIndex = 1;
            this.txtCauTraLoi.WordWrap = false;
            this.txtCauTraLoi.TextChanged += new System.EventHandler(this.txtComment_TextChanged_1);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "(Mỗi nội dung 1 dòng)";
            // 
            // lblStatusComment
            // 
            this.lblStatusComment.AutoSize = true;
            this.lblStatusComment.Location = new System.Drawing.Point(3, 4);
            this.lblStatusComment.Name = "lblStatusComment";
            this.lblStatusComment.Size = new System.Drawing.Size(201, 21);
            this.lblStatusComment.TabIndex = 0;
            this.lblStatusComment.Text = "Danh sách câu trả lời (0):";
            // 
            // ckbTuDongTraLoiCauHoi
            // 
            this.ckbTuDongTraLoiCauHoi.AutoSize = true;
            this.ckbTuDongTraLoiCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuDongTraLoiCauHoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuDongTraLoiCauHoi.Location = new System.Drawing.Point(30, 139);
            this.ckbTuDongTraLoiCauHoi.Name = "ckbTuDongTraLoiCauHoi";
            this.ckbTuDongTraLoiCauHoi.Size = new System.Drawing.Size(200, 25);
            this.ckbTuDongTraLoiCauHoi.TabIndex = 115;
            this.ckbTuDongTraLoiCauHoi.Text = "Tự động trả lời câu hỏi";
            this.ckbTuDongTraLoiCauHoi.UseVisualStyleBackColor = true;
            this.ckbTuDongTraLoiCauHoi.CheckedChanged += new System.EventHandler(this.ckbTuongTac_CheckedChanged);
            // 
            // txtUid
            // 
            this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUid.Location = new System.Drawing.Point(356, 72);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(295, 230);
            this.txtUid.TabIndex = 114;
            this.txtUid.Text = "";
            this.txtUid.WordWrap = false;
            this.txtUid.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // ckbTuDongXoaUid
            // 
            this.ckbTuDongXoaUid.AutoSize = true;
            this.ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuDongXoaUid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuDongXoaUid.Location = new System.Drawing.Point(355, 324);
            this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
            this.ckbTuDongXoaUid.Size = new System.Drawing.Size(384, 25);
            this.ckbTuDongXoaUid.TabIndex = 113;
            this.ckbTuDongXoaUid.Text = "Tự động xóa Uid nhóm đã gửi yêu cầu tham gia";
            this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
            // 
            // nudDelayTo
            // 
            this.nudDelayTo.Location = new System.Drawing.Point(229, 111);
            this.nudDelayTo.Name = "nudDelayTo";
            this.nudDelayTo.Size = new System.Drawing.Size(56, 27);
            this.nudDelayTo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(553, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "(Mỗi Uid 1 dòng)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(352, 52);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(298, 21);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Danh sách Uid nhóm cần tham gia (0):";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
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
            this.label4.Text = "nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Số lượng:";
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
            this.btnCancel.Location = new System.Drawing.Point(355, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 7;
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
            this.btnAdd.Location = new System.Drawing.Point(248, 359);
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
            this.bunifuCards1.Size = new System.Drawing.Size(687, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 0;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 0;
            this.toolTip1.ShowAlways = true;
            // 
            // fHDThamGiaNhomUid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 402);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDThamGiaNhomUid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plTuongTac.ResumeLayout(false);
            this.plTuongTac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x040012A4 RID: 4772
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040012A5 RID: 4773
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040012A6 RID: 4774
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x040012A7 RID: 4775
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040012A8 RID: 4776
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x040012A9 RID: 4777
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x040012AA RID: 4778
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x040012AB RID: 4779
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040012AC RID: 4780
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040012AD RID: 4781
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040012AE RID: 4782
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040012AF RID: 4783
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040012B0 RID: 4784
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040012B1 RID: 4785
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040012B2 RID: 4786
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040012B3 RID: 4787
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040012B4 RID: 4788
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040012B5 RID: 4789
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040012B6 RID: 4790
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040012B7 RID: 4791
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x040012B8 RID: 4792
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x040012B9 RID: 4793
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x040012BA RID: 4794
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040012BB RID: 4795
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040012BC RID: 4796
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040012BD RID: 4797
		private global::System.Windows.Forms.RichTextBox txtUid;

		// Token: 0x040012BE RID: 4798
		private global::System.Windows.Forms.CheckBox ckbTuDongXoaUid;

		// Token: 0x040012BF RID: 4799
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x040012C0 RID: 4800
		private global::System.Windows.Forms.Panel plTuongTac;

		// Token: 0x040012C1 RID: 4801
		private global::System.Windows.Forms.CheckBox ckbTuDongTraLoiCauHoi;

		// Token: 0x040012C2 RID: 4802
		private global::System.Windows.Forms.TextBox txtCauTraLoi;

		// Token: 0x040012C3 RID: 4803
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040012C4 RID: 4804
		private global::System.Windows.Forms.Label lblStatusComment;
	}
}
