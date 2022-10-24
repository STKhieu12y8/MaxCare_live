namespace maxcare
{
	// Token: 0x020000D7 RID: 215
	public partial class fTienIchCheckProxy : global::System.Windows.Forms.Form
	{
		// Token: 0x060008C4 RID: 2244 RVA: 0x00110178 File Offset: 0x0010E378
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x001101D8 File Offset: 0x0010E3D8
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grChuaTao = new System.Windows.Forms.GroupBox();
            this.txtChuaTao = new System.Windows.Forms.RichTextBox();
            this.grDaTao = new System.Windows.Forms.GroupBox();
            this.txtDaTao = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTypeProxy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.bunifuCards1.Size = new System.Drawing.Size(421, 47);
            this.bunifuCards1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.grChuaTao);
            this.panel1.Controls.Add(this.grDaTao);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 404);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStatus.Location = new System.Drawing.Point(435, 59);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(91, 21);
            this.lblStatus.TabIndex = 52;
            this.lblStatus.Text = "Checking...";
            this.lblStatus.Visible = false;
            // 
            // grChuaTao
            // 
            this.grChuaTao.Controls.Add(this.txtChuaTao);
            this.grChuaTao.ForeColor = System.Drawing.Color.DarkRed;
            this.grChuaTao.Location = new System.Drawing.Point(521, 91);
            this.grChuaTao.Name = "grChuaTao";
            this.grChuaTao.Size = new System.Drawing.Size(221, 307);
            this.grChuaTao.TabIndex = 51;
            this.grChuaTao.TabStop = false;
            this.grChuaTao.Text = "DIE (0)";
            // 
            // txtChuaTao
            // 
            this.txtChuaTao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChuaTao.Location = new System.Drawing.Point(3, 23);
            this.txtChuaTao.Name = "txtChuaTao";
            this.txtChuaTao.Size = new System.Drawing.Size(215, 281);
            this.txtChuaTao.TabIndex = 50;
            this.txtChuaTao.Text = "";
            this.txtChuaTao.WordWrap = false;
            this.txtChuaTao.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // grDaTao
            // 
            this.grDaTao.Controls.Add(this.txtDaTao);
            this.grDaTao.ForeColor = System.Drawing.Color.DarkGreen;
            this.grDaTao.Location = new System.Drawing.Point(294, 91);
            this.grDaTao.Name = "grDaTao";
            this.grDaTao.Size = new System.Drawing.Size(221, 307);
            this.grDaTao.TabIndex = 51;
            this.grDaTao.TabStop = false;
            this.grDaTao.Text = "LIVE (0)";
            // 
            // txtDaTao
            // 
            this.txtDaTao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDaTao.Location = new System.Drawing.Point(3, 23);
            this.txtDaTao.Name = "txtDaTao";
            this.txtDaTao.Size = new System.Drawing.Size(215, 281);
            this.txtDaTao.TabIndex = 50;
            this.txtDaTao.Text = "";
            this.txtDaTao.WordWrap = false;
            this.txtDaTao.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTypeProxy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(6, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 358);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Proxy (0)";
            // 
            // cbbTypeProxy
            // 
            this.cbbTypeProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTypeProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeProxy.FormattingEnabled = true;
            this.cbbTypeProxy.Items.AddRange(new object[] {
            "HTTP/HTTPS",
            "Sock5"});
            this.cbbTypeProxy.Location = new System.Drawing.Point(83, 324);
            this.cbbTypeProxy.Name = "cbbTypeProxy";
            this.cbbTypeProxy.Size = new System.Drawing.Size(193, 27);
            this.cbbTypeProxy.TabIndex = 126;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 125;
            this.label3.Text = "Loại Proxy:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(9, 19);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(267, 299);
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
            this.btnAdd.Location = new System.Drawing.Point(294, 49);
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
            this.bunifuCards2.Size = new System.Drawing.Size(748, 37);
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
            this.pnlHeader.Size = new System.Drawing.Size(748, 31);
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
            this.button2.Location = new System.Drawing.Point(717, 1);
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
            this.lblTitle.Size = new System.Drawing.Size(748, 31);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Check Proxy";
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
            // fTienIchCheckProxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 404);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fTienIchCheckProxy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình chung";
            this.Load += new System.EventHandler(this.fTienIchLocTrung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grChuaTao.ResumeLayout(false);
            this.grDaTao.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x04000C30 RID: 3120
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000C31 RID: 3121
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000C32 RID: 3122
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000C33 RID: 3123
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000C34 RID: 3124
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000C35 RID: 3125
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards2;

		// Token: 0x04000C36 RID: 3126
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000C37 RID: 3127
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000C38 RID: 3128
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000C39 RID: 3129
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000C3A RID: 3130
		private global::Bunifu.Framework.UI.BunifuCustomLabel lblTitle;

		// Token: 0x04000C3B RID: 3131
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000C3C RID: 3132
		private global::System.Windows.Forms.RichTextBox txtInput;

		// Token: 0x04000C3D RID: 3133
		private global::System.Windows.Forms.GroupBox grDaTao;

		// Token: 0x04000C3E RID: 3134
		private global::System.Windows.Forms.RichTextBox txtDaTao;

		// Token: 0x04000C3F RID: 3135
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000C40 RID: 3136
		private global::System.Windows.Forms.GroupBox grChuaTao;

		// Token: 0x04000C41 RID: 3137
		private global::System.Windows.Forms.RichTextBox txtChuaTao;

		// Token: 0x04000C42 RID: 3138
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000C43 RID: 3139
		private global::System.Windows.Forms.ComboBox cbbTypeProxy;

		// Token: 0x04000C44 RID: 3140
		private global::System.Windows.Forms.Label label3;
	}
}
