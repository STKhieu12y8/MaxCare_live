namespace maxcare
{
	// Token: 0x020000FE RID: 254
	public partial class fHDTruyCapWebsite : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A74 RID: 2676 RVA: 0x0015E928 File Offset: 0x0015CB28
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0015E988 File Offset: 0x0015CB88
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
            this.nudCountTimeScrollTo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbLuot = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLinkWeb = new System.Windows.Forms.RichTextBox();
            this.nudCountTimeScrollFrom = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.nudCountLinkClickTo = new System.Windows.Forms.NumericUpDown();
            this.nudCountLinkTo = new System.Windows.Forms.NumericUpDown();
            this.nudCountLinkClickFrom = new System.Windows.Forms.NumericUpDown();
            this.nudCountLinkFrom = new System.Windows.Forms.NumericUpDown();
            this.txtTenHanhDong = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountTimeScrollTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountTimeScrollFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLinkClickTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLinkTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLinkClickFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLinkFrom)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Truy cập Website";
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
            this.pnlHeader.Size = new System.Drawing.Size(359, 31);
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
            this.button1.Location = new System.Drawing.Point(328, 1);
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
            this.panel1.Controls.Add(this.nudCountTimeScrollTo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ckbLuot);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLinkWeb);
            this.panel1.Controls.Add(this.nudCountTimeScrollFrom);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.nudCountLinkClickTo);
            this.panel1.Controls.Add(this.nudCountLinkTo);
            this.panel1.Controls.Add(this.nudCountLinkClickFrom);
            this.panel1.Controls.Add(this.nudCountLinkFrom);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 419);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // nudCountTimeScrollTo
            // 
            this.nudCountTimeScrollTo.Location = new System.Drawing.Point(263, 316);
            this.nudCountTimeScrollTo.Name = "nudCountTimeScrollTo";
            this.nudCountTimeScrollTo.Size = new System.Drawing.Size(36, 27);
            this.nudCountTimeScrollTo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Thời gian trên web:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "giây";
            // 
            // ckbLuot
            // 
            this.ckbLuot.AutoSize = true;
            this.ckbLuot.Checked = true;
            this.ckbLuot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbLuot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbLuot.Location = new System.Drawing.Point(30, 343);
            this.ckbLuot.Name = "ckbLuot";
            this.ckbLuot.Size = new System.Drawing.Size(201, 25);
            this.ckbLuot.TabIndex = 43;
            this.ckbLuot.Text = "Tự động lướt trên Web";
            this.ckbLuot.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(231, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "đến";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLinkWeb
            // 
            this.txtLinkWeb.Location = new System.Drawing.Point(30, 94);
            this.txtLinkWeb.Name = "txtLinkWeb";
            this.txtLinkWeb.Size = new System.Drawing.Size(298, 142);
            this.txtLinkWeb.TabIndex = 42;
            this.txtLinkWeb.Text = "";
            this.txtLinkWeb.WordWrap = false;
            this.txtLinkWeb.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // nudCountTimeScrollFrom
            // 
            this.nudCountTimeScrollFrom.Location = new System.Drawing.Point(192, 316);
            this.nudCountTimeScrollFrom.Name = "nudCountTimeScrollFrom";
            this.nudCountTimeScrollFrom.Size = new System.Drawing.Size(36, 27);
            this.nudCountTimeScrollFrom.TabIndex = 1;
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
            this.lblStatus.Size = new System.Drawing.Size(194, 21);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Danh sách Link Web (0):";
            // 
            // nudCountLinkClickTo
            // 
            this.nudCountLinkClickTo.Location = new System.Drawing.Point(263, 288);
            this.nudCountLinkClickTo.Name = "nudCountLinkClickTo";
            this.nudCountLinkClickTo.Size = new System.Drawing.Size(36, 27);
            this.nudCountLinkClickTo.TabIndex = 2;
            // 
            // nudCountLinkTo
            // 
            this.nudCountLinkTo.Location = new System.Drawing.Point(263, 260);
            this.nudCountLinkTo.Name = "nudCountLinkTo";
            this.nudCountLinkTo.Size = new System.Drawing.Size(36, 27);
            this.nudCountLinkTo.TabIndex = 2;
            // 
            // nudCountLinkClickFrom
            // 
            this.nudCountLinkClickFrom.Location = new System.Drawing.Point(192, 288);
            this.nudCountLinkClickFrom.Name = "nudCountLinkClickFrom";
            this.nudCountLinkClickFrom.Size = new System.Drawing.Size(36, 27);
            this.nudCountLinkClickFrom.TabIndex = 1;
            // 
            // nudCountLinkFrom
            // 
            this.nudCountLinkFrom.Location = new System.Drawing.Point(192, 260);
            this.nudCountLinkFrom.Name = "nudCountLinkFrom";
            this.nudCountLinkFrom.Size = new System.Drawing.Size(36, 27);
            this.nudCountLinkFrom.TabIndex = 1;
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
            this.label17.Location = new System.Drawing.Point(231, 290);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 16);
            this.label17.TabIndex = 37;
            this.label17.Text = "đến";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label16.Location = new System.Drawing.Point(299, 290);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 21);
            this.label16.TabIndex = 35;
            this.label16.Text = "link";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = "link";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 290);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 21);
            this.label15.TabIndex = 34;
            this.label15.Text = "Click random link trên web:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 21);
            this.label9.TabIndex = 32;
            this.label9.Text = "Số link web cần truy cập:";
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
            this.btnCancel.Location = new System.Drawing.Point(189, 375);
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
            this.btnAdd.Location = new System.Drawing.Point(82, 375);
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
            this.bunifuCards1.Size = new System.Drawing.Size(359, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDTruyCapWebsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 419);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDTruyCapWebsite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountTimeScrollTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountTimeScrollFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLinkClickTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLinkTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLinkClickFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountLinkFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04000F2A RID: 3882
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000F2B RID: 3883
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000F2C RID: 3884
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000F2D RID: 3885
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000F2E RID: 3886
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000F2F RID: 3887
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000F30 RID: 3888
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000F31 RID: 3889
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000F32 RID: 3890
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000F33 RID: 3891
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000F34 RID: 3892
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000F35 RID: 3893
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000F36 RID: 3894
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000F37 RID: 3895
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000F38 RID: 3896
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000F39 RID: 3897
		private global::System.Windows.Forms.RichTextBox txtLinkWeb;

		// Token: 0x04000F3A RID: 3898
		private global::System.Windows.Forms.NumericUpDown nudCountLinkClickTo;

		// Token: 0x04000F3B RID: 3899
		private global::System.Windows.Forms.NumericUpDown nudCountLinkTo;

		// Token: 0x04000F3C RID: 3900
		private global::System.Windows.Forms.NumericUpDown nudCountLinkClickFrom;

		// Token: 0x04000F3D RID: 3901
		private global::System.Windows.Forms.NumericUpDown nudCountLinkFrom;

		// Token: 0x04000F3E RID: 3902
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000F3F RID: 3903
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000F40 RID: 3904
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000F41 RID: 3905
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000F42 RID: 3906
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000F43 RID: 3907
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000F44 RID: 3908
		private global::System.Windows.Forms.CheckBox ckbLuot;

		// Token: 0x04000F45 RID: 3909
		private global::System.Windows.Forms.NumericUpDown nudCountTimeScrollTo;

		// Token: 0x04000F46 RID: 3910
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000F47 RID: 3911
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000F48 RID: 3912
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000F49 RID: 3913
		private global::System.Windows.Forms.NumericUpDown nudCountTimeScrollFrom;
	}
}
