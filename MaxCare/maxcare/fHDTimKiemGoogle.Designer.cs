namespace maxcare
{
	// Token: 0x020000FF RID: 255
	public partial class fHDTimKiemGoogle : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A7E RID: 2686 RVA: 0x001616D8 File Offset: 0x0015F8D8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00161738 File Offset: 0x0015F938
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
            this.txtTuKhoa = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.nudCountTimeScrollTo = new System.Windows.Forms.NumericUpDown();
            this.nudCountLinkClickTo = new System.Windows.Forms.NumericUpDown();
            this.nudCountPageTo = new System.Windows.Forms.NumericUpDown();
            this.nudCountTuKhoaTo = new System.Windows.Forms.NumericUpDown();
            this.nudCountTimeScrollFrom = new System.Windows.Forms.NumericUpDown();
            this.nudCountLinkClickFrom = new System.Windows.Forms.NumericUpDown();
            this.nudCountPageFrom = new System.Windows.Forms.NumericUpDown();
            this.nudCountTuKhoaFrom = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenHanhDong = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountTimeScrollTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLinkClickTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountPageTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountTuKhoaTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountTimeScrollFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLinkClickFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountPageFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountTuKhoaFrom)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(380, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Tìm kiếm Google";
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
            this.pnlHeader.Size = new System.Drawing.Size(380, 31);
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
            this.button1.Location = new System.Drawing.Point(349, 1);
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
            this.panel1.Controls.Add(this.txtTuKhoa);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.nudCountTimeScrollTo);
            this.panel1.Controls.Add(this.nudCountLinkClickTo);
            this.panel1.Controls.Add(this.nudCountPageTo);
            this.panel1.Controls.Add(this.nudCountTuKhoaTo);
            this.panel1.Controls.Add(this.nudCountTimeScrollFrom);
            this.panel1.Controls.Add(this.nudCountLinkClickFrom);
            this.panel1.Controls.Add(this.nudCountPageFrom);
            this.panel1.Controls.Add(this.nudCountTuKhoaFrom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 428);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(30, 94);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(298, 142);
            this.txtTuKhoa.TabIndex = 42;
            this.txtTuKhoa.Text = "";
            this.txtTuKhoa.WordWrap = false;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "(Mỗi nội dung 1 dòng)";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(27, 75);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(261, 21);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Danh sách Từ khóa|Link Web (0):";
            // 
            // nudCountTimeScrollTo
            // 
            this.nudCountTimeScrollTo.Location = new System.Drawing.Point(263, 344);
            this.nudCountTimeScrollTo.Name = "nudCountTimeScrollTo";
            this.nudCountTimeScrollTo.Size = new System.Drawing.Size(36, 27);
            this.nudCountTimeScrollTo.TabIndex = 2;
            // 
            // nudCountLinkClickTo
            // 
            this.nudCountLinkClickTo.Location = new System.Drawing.Point(263, 316);
            this.nudCountLinkClickTo.Name = "nudCountLinkClickTo";
            this.nudCountLinkClickTo.Size = new System.Drawing.Size(36, 27);
            this.nudCountLinkClickTo.TabIndex = 2;
            // 
            // nudCountPageTo
            // 
            this.nudCountPageTo.Location = new System.Drawing.Point(263, 288);
            this.nudCountPageTo.Name = "nudCountPageTo";
            this.nudCountPageTo.Size = new System.Drawing.Size(36, 27);
            this.nudCountPageTo.TabIndex = 2;
            // 
            // nudCountTuKhoaTo
            // 
            this.nudCountTuKhoaTo.Location = new System.Drawing.Point(263, 260);
            this.nudCountTuKhoaTo.Name = "nudCountTuKhoaTo";
            this.nudCountTuKhoaTo.Size = new System.Drawing.Size(36, 27);
            this.nudCountTuKhoaTo.TabIndex = 2;
            // 
            // nudCountTimeScrollFrom
            // 
            this.nudCountTimeScrollFrom.Location = new System.Drawing.Point(192, 344);
            this.nudCountTimeScrollFrom.Name = "nudCountTimeScrollFrom";
            this.nudCountTimeScrollFrom.Size = new System.Drawing.Size(36, 27);
            this.nudCountTimeScrollFrom.TabIndex = 1;
            // 
            // nudCountLinkClickFrom
            // 
            this.nudCountLinkClickFrom.Location = new System.Drawing.Point(192, 316);
            this.nudCountLinkClickFrom.Name = "nudCountLinkClickFrom";
            this.nudCountLinkClickFrom.Size = new System.Drawing.Size(36, 27);
            this.nudCountLinkClickFrom.TabIndex = 1;
            // 
            // nudCountPageFrom
            // 
            this.nudCountPageFrom.Location = new System.Drawing.Point(192, 288);
            this.nudCountPageFrom.Name = "nudCountPageFrom";
            this.nudCountPageFrom.Size = new System.Drawing.Size(36, 27);
            this.nudCountPageFrom.TabIndex = 1;
            // 
            // nudCountTuKhoaFrom
            // 
            this.nudCountTuKhoaFrom.Location = new System.Drawing.Point(192, 260);
            this.nudCountTuKhoaFrom.Name = "nudCountTuKhoaFrom";
            this.nudCountTuKhoaFrom.Size = new System.Drawing.Size(36, 27);
            this.nudCountTuKhoaFrom.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(231, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "đến";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(134, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(194, 27);
            this.txtTenHanhDong.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(231, 318);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 16);
            this.label17.TabIndex = 37;
            this.label17.Text = "đến";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(231, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "đến";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "giây";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(231, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "đến";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(299, 318);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 21);
            this.label16.TabIndex = 35;
            this.label16.Text = "link";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 21);
            this.label12.TabIndex = 35;
            this.label12.Text = "trang";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = "từ khóa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 21);
            this.label15.TabIndex = 34;
            this.label15.Text = "Click random link trên web:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 21);
            this.label10.TabIndex = 34;
            this.label10.Text = "Số trang tìm kiếm tối đa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 21);
            this.label9.TabIndex = 32;
            this.label9.Text = "Số từ khóa cần tìm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Thời gian lướt trên web:";
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
            this.btnCancel.Location = new System.Drawing.Point(189, 384);
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
            this.btnAdd.Location = new System.Drawing.Point(82, 384);
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
            this.bunifuCards1.Size = new System.Drawing.Size(380, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDTimKiemGoogle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 428);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDTimKiemGoogle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountTimeScrollTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLinkClickTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountPageTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountTuKhoaTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountTimeScrollFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLinkClickFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountPageFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountTuKhoaFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04000F50 RID: 3920
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000F51 RID: 3921
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000F52 RID: 3922
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000F53 RID: 3923
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000F54 RID: 3924
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000F55 RID: 3925
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000F56 RID: 3926
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000F57 RID: 3927
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000F58 RID: 3928
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000F59 RID: 3929
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000F5A RID: 3930
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000F5B RID: 3931
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000F5C RID: 3932
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000F5D RID: 3933
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000F5E RID: 3934
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000F5F RID: 3935
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000F60 RID: 3936
		private global::System.Windows.Forms.RichTextBox txtTuKhoa;

		// Token: 0x04000F61 RID: 3937
		private global::System.Windows.Forms.NumericUpDown nudCountTimeScrollTo;

		// Token: 0x04000F62 RID: 3938
		private global::System.Windows.Forms.NumericUpDown nudCountLinkClickTo;

		// Token: 0x04000F63 RID: 3939
		private global::System.Windows.Forms.NumericUpDown nudCountPageTo;

		// Token: 0x04000F64 RID: 3940
		private global::System.Windows.Forms.NumericUpDown nudCountTuKhoaTo;

		// Token: 0x04000F65 RID: 3941
		private global::System.Windows.Forms.NumericUpDown nudCountTimeScrollFrom;

		// Token: 0x04000F66 RID: 3942
		private global::System.Windows.Forms.NumericUpDown nudCountLinkClickFrom;

		// Token: 0x04000F67 RID: 3943
		private global::System.Windows.Forms.NumericUpDown nudCountPageFrom;

		// Token: 0x04000F68 RID: 3944
		private global::System.Windows.Forms.NumericUpDown nudCountTuKhoaFrom;

		// Token: 0x04000F69 RID: 3945
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000F6A RID: 3946
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000F6B RID: 3947
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000F6C RID: 3948
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000F6D RID: 3949
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000F6E RID: 3950
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000F6F RID: 3951
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000F70 RID: 3952
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000F71 RID: 3953
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000F72 RID: 3954
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000F73 RID: 3955
		private global::System.Windows.Forms.Label label9;
	}
}
