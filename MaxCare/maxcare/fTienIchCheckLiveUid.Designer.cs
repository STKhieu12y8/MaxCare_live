namespace maxcare
{
	// Token: 0x020000D3 RID: 211
	public partial class fTienIchCheckLiveUid : global::System.Windows.Forms.Form
	{
		// Token: 0x060008B0 RID: 2224 RVA: 0x0010DFE4 File Offset: 0x0010C1E4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0010E044 File Offset: 0x0010C244
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudThread = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grKhongCheckDuoc = new System.Windows.Forms.GroupBox();
            this.txtKhongCheckDuoc = new System.Windows.Forms.RichTextBox();
            this.grChuaTao = new System.Windows.Forms.GroupBox();
            this.txtDie = new System.Windows.Forms.RichTextBox();
            this.grDaTao = new System.Windows.Forms.GroupBox();
            this.txtLive = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThread)).BeginInit();
            this.grKhongCheckDuoc.SuspendLayout();
            this.grChuaTao.SuspendLayout();
            this.grDaTao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(649, 47);
            this.bunifuCards1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nudThread);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.grKhongCheckDuoc);
            this.panel1.Controls.Add(this.grChuaTao);
            this.panel1.Controls.Add(this.grDaTao);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 407);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // nudThread
            // 
            this.nudThread.Location = new System.Drawing.Point(360, 60);
            this.nudThread.Name = "nudThread";
            this.nudThread.Size = new System.Drawing.Size(69, 27);
            this.nudThread.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "Threads:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStatus.Location = new System.Drawing.Point(617, 62);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(91, 21);
            this.lblStatus.TabIndex = 52;
            this.lblStatus.Text = "Checking...";
            this.lblStatus.Visible = false;
            // 
            // grKhongCheckDuoc
            // 
            this.grKhongCheckDuoc.Controls.Add(this.txtKhongCheckDuoc);
            this.grKhongCheckDuoc.ForeColor = System.Drawing.Color.Red;
            this.grKhongCheckDuoc.Location = new System.Drawing.Point(748, 91);
            this.grKhongCheckDuoc.Name = "grKhongCheckDuoc";
            this.grKhongCheckDuoc.Size = new System.Drawing.Size(221, 307);
            this.grKhongCheckDuoc.TabIndex = 51;
            this.grKhongCheckDuoc.TabStop = false;
            this.grKhongCheckDuoc.Text = "Can\'t check (0)";
            // 
            // txtKhongCheckDuoc
            // 
            this.txtKhongCheckDuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKhongCheckDuoc.Location = new System.Drawing.Point(3, 23);
            this.txtKhongCheckDuoc.Name = "txtKhongCheckDuoc";
            this.txtKhongCheckDuoc.Size = new System.Drawing.Size(215, 281);
            this.txtKhongCheckDuoc.TabIndex = 50;
            this.txtKhongCheckDuoc.Text = "";
            this.txtKhongCheckDuoc.WordWrap = false;
            this.txtKhongCheckDuoc.TextChanged += new System.EventHandler(this.txtKhongCheckDuoc_TextChanged);
            // 
            // grChuaTao
            // 
            this.grChuaTao.Controls.Add(this.txtDie);
            this.grChuaTao.ForeColor = System.Drawing.Color.DarkRed;
            this.grChuaTao.Location = new System.Drawing.Point(521, 91);
            this.grChuaTao.Name = "grChuaTao";
            this.grChuaTao.Size = new System.Drawing.Size(221, 307);
            this.grChuaTao.TabIndex = 51;
            this.grChuaTao.TabStop = false;
            this.grChuaTao.Text = "DIE (0)";
            // 
            // txtDie
            // 
            this.txtDie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDie.Location = new System.Drawing.Point(3, 23);
            this.txtDie.Name = "txtDie";
            this.txtDie.Size = new System.Drawing.Size(215, 281);
            this.txtDie.TabIndex = 50;
            this.txtDie.Text = "";
            this.txtDie.WordWrap = false;
            this.txtDie.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // grDaTao
            // 
            this.grDaTao.Controls.Add(this.txtLive);
            this.grDaTao.ForeColor = System.Drawing.Color.DarkGreen;
            this.grDaTao.Location = new System.Drawing.Point(294, 91);
            this.grDaTao.Name = "grDaTao";
            this.grDaTao.Size = new System.Drawing.Size(221, 307);
            this.grDaTao.TabIndex = 51;
            this.grDaTao.TabStop = false;
            this.grDaTao.Text = "LIVE (0)";
            // 
            // txtLive
            // 
            this.txtLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLive.Location = new System.Drawing.Point(3, 23);
            this.txtLive.Name = "txtLive";
            this.txtLive.Size = new System.Drawing.Size(215, 281);
            this.txtLive.TabIndex = 50;
            this.txtLive.Text = "";
            this.txtLive.WordWrap = false;
            this.txtLive.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(6, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 358);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Uid (0)";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(9, 19);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(267, 336);
            this.txtInput.TabIndex = 50;
            this.txtInput.Text = "";
            this.txtInput.WordWrap = false;
            this.txtInput.TextChanged += new System.EventHandler(this.TxtComment_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(476, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 36);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Check";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 0;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards2.Controls.Add(this.pnlHeader);
            this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(976, 37);
            this.bunifuCards2.TabIndex = 43;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.button2);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Location = new System.Drawing.Point(0, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(976, 31);
            this.pnlHeader.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::MaxCare.Properties.Resources.close_window_25px;
            this.button2.Location = new System.Drawing.Point(945, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 77;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(899, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(976, 31);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Check Live Uid";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.lblTitle;
            this.bunifuDragControl1.Vertical = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            // 
            // fTienIchCheckLiveUid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 407);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fTienIchCheckLiveUid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình chung";
            this.Load += new System.EventHandler(this.fTienIchLocTrung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThread)).EndInit();
            this.grKhongCheckDuoc.ResumeLayout(false);
            this.grChuaTao.ResumeLayout(false);
            this.grDaTao.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x04000C13 RID: 3091
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000C14 RID: 3092
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000C15 RID: 3093
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000C16 RID: 3094
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000C17 RID: 3095
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000C18 RID: 3096
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards2;

		// Token: 0x04000C19 RID: 3097
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000C1A RID: 3098
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000C1B RID: 3099
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000C1C RID: 3100
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000C1D RID: 3101
		private global::Bunifu.Framework.UI.BunifuCustomLabel lblTitle;

		// Token: 0x04000C1E RID: 3102
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000C1F RID: 3103
		private global::System.Windows.Forms.RichTextBox txtInput;

		// Token: 0x04000C20 RID: 3104
		private global::System.Windows.Forms.GroupBox grDaTao;

		// Token: 0x04000C21 RID: 3105
		private global::System.Windows.Forms.RichTextBox txtLive;

		// Token: 0x04000C22 RID: 3106
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000C23 RID: 3107
		private global::System.Windows.Forms.GroupBox grChuaTao;

		// Token: 0x04000C24 RID: 3108
		private global::System.Windows.Forms.RichTextBox txtDie;

		// Token: 0x04000C25 RID: 3109
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000C26 RID: 3110
		private global::System.Windows.Forms.GroupBox grKhongCheckDuoc;

		// Token: 0x04000C27 RID: 3111
		private global::System.Windows.Forms.RichTextBox txtKhongCheckDuoc;

		// Token: 0x04000C28 RID: 3112
		private global::System.Windows.Forms.NumericUpDown nudThread;

		// Token: 0x04000C29 RID: 3113
		private global::System.Windows.Forms.Label label2;
	}
}
