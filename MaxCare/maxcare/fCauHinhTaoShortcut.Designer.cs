namespace maxcare
{
	// Token: 0x020000E3 RID: 227
	public partial class fCauHinhTaoShortcut : global::System.Windows.Forms.Form
	{
		// Token: 0x0600091D RID: 2333 RVA: 0x0011B930 File Offset: 0x00119B30
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0011B990 File Offset: 0x00119B90
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPathShortcut = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathChromeOrigin = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
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
            this.bunifuCards1.Size = new System.Drawing.Size(792, 47);
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
            this.pnlHeader.Size = new System.Drawing.Size(792, 39);
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
            this.btnMinimize.Location = new System.Drawing.Point(749, 0);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(792, 39);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Cấu hình tạo Shortcut Chrome";
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
            this.btnCancel.Location = new System.Drawing.Point(404, 171);
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
            this.btnAdd.Location = new System.Drawing.Point(265, 171);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nơi lưu Shortcut:";
            // 
            // txtPathShortcut
            // 
            // 
            // 
            // 
            this.txtPathShortcut.CustomButton.Image = null;
            this.txtPathShortcut.CustomButton.Location = new System.Drawing.Point(591, 2);
            this.txtPathShortcut.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPathShortcut.CustomButton.Name = "";
            this.txtPathShortcut.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtPathShortcut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPathShortcut.CustomButton.TabIndex = 1;
            this.txtPathShortcut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPathShortcut.CustomButton.UseSelectable = true;
            this.txtPathShortcut.CustomButton.Visible = false;
            this.txtPathShortcut.Lines = new string[0];
            this.txtPathShortcut.Location = new System.Drawing.Point(209, 71);
            this.txtPathShortcut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPathShortcut.MaxLength = 32767;
            this.txtPathShortcut.Name = "txtPathShortcut";
            this.txtPathShortcut.PasswordChar = '\0';
            this.txtPathShortcut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPathShortcut.SelectedText = "";
            this.txtPathShortcut.SelectionLength = 0;
            this.txtPathShortcut.SelectionStart = 0;
            this.txtPathShortcut.ShortcutsEnabled = true;
            this.txtPathShortcut.Size = new System.Drawing.Size(469, 28);
            this.txtPathShortcut.TabIndex = 6;
            this.txtPathShortcut.UseSelectable = true;
            this.txtPathShortcut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPathShortcut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Location = new System.Drawing.Point(687, 71);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(63, 30);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Chọn";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đường dẫn Chrome:";
            // 
            // txtPathChromeOrigin
            // 
            // 
            // 
            // 
            this.txtPathChromeOrigin.CustomButton.Image = null;
            this.txtPathChromeOrigin.CustomButton.Location = new System.Drawing.Point(591, 2);
            this.txtPathChromeOrigin.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPathChromeOrigin.CustomButton.Name = "";
            this.txtPathChromeOrigin.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtPathChromeOrigin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPathChromeOrigin.CustomButton.TabIndex = 1;
            this.txtPathChromeOrigin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPathChromeOrigin.CustomButton.UseSelectable = true;
            this.txtPathChromeOrigin.CustomButton.Visible = false;
            this.txtPathChromeOrigin.Lines = new string[] {
        "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe"};
            this.txtPathChromeOrigin.Location = new System.Drawing.Point(209, 110);
            this.txtPathChromeOrigin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPathChromeOrigin.MaxLength = 32767;
            this.txtPathChromeOrigin.Name = "txtPathChromeOrigin";
            this.txtPathChromeOrigin.PasswordChar = '\0';
            this.txtPathChromeOrigin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPathChromeOrigin.SelectedText = "";
            this.txtPathChromeOrigin.SelectionLength = 0;
            this.txtPathChromeOrigin.SelectionStart = 0;
            this.txtPathChromeOrigin.ShortcutsEnabled = true;
            this.txtPathChromeOrigin.Size = new System.Drawing.Size(469, 28);
            this.txtPathChromeOrigin.TabIndex = 6;
            this.txtPathChromeOrigin.Text = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
            this.txtPathChromeOrigin.UseSelectable = true;
            this.txtPathChromeOrigin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPathChromeOrigin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton2.Location = new System.Drawing.Point(687, 110);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(63, 30);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Chọn";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // fCauHinhTaoShortcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 230);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtPathChromeOrigin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPathShortcut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fCauHinhTaoShortcut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fAddFile";
            this.Load += new System.EventHandler(this.fClearProfile_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000CBC RID: 3260
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000CBD RID: 3261
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000CBE RID: 3262
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000CBF RID: 3263
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000CC0 RID: 3264
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000CC1 RID: 3265
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000CC2 RID: 3266
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000CC3 RID: 3267
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000CC4 RID: 3268
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000CC5 RID: 3269
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000CC6 RID: 3270
		private global::MetroFramework.Controls.MetroTextBox txtPathShortcut;

		// Token: 0x04000CC7 RID: 3271
		private global::MetroFramework.Controls.MetroButton metroButton1;

		// Token: 0x04000CC8 RID: 3272
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000CC9 RID: 3273
		private global::MetroFramework.Controls.MetroTextBox txtPathChromeOrigin;

		// Token: 0x04000CCA RID: 3274
		private global::MetroFramework.Controls.MetroButton metroButton2;
	}
}
