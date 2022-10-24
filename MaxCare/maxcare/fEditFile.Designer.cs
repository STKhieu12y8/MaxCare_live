namespace maxcare
{
	// Token: 0x02000070 RID: 112
	public partial class fEditFile : global::System.Windows.Forms.Form
	{
		// Token: 0x06000469 RID: 1129 RVA: 0x00055B8C File Offset: 0x00053D8C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00055BEC File Offset: 0x00053DEC
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
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtNameFileOld = new MetroFramework.Controls.MetroTextBox();
            this.txtNameFileNew = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.bunifuCards1.Size = new System.Drawing.Size(528, 47);
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
            this.pnlHeader.Size = new System.Drawing.Size(528, 39);
            this.pnlHeader.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(5, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::MaxCare.Properties.Resources.close_window_25px;
            this.btnMinimize.Location = new System.Drawing.Point(483, -2);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(528, 39);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Cập nhật Tên thư mục";
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
            this.btnCancel.Location = new System.Drawing.Point(272, 170);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
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
            this.btnAdd.Location = new System.Drawing.Point(133, 170);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Cập nhật";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(44, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên thư mục cũ:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtNameFileOld
            // 
            // 
            // 
            // 
            this.txtNameFileOld.CustomButton.Image = null;
            this.txtNameFileOld.CustomButton.Location = new System.Drawing.Point(337, 2);
            this.txtNameFileOld.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameFileOld.CustomButton.Name = "";
            this.txtNameFileOld.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtNameFileOld.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameFileOld.CustomButton.TabIndex = 1;
            this.txtNameFileOld.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameFileOld.CustomButton.UseSelectable = true;
            this.txtNameFileOld.CustomButton.Visible = false;
            this.txtNameFileOld.Enabled = false;
            this.txtNameFileOld.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNameFileOld.Lines = new string[0];
            this.txtNameFileOld.Location = new System.Drawing.Point(200, 81);
            this.txtNameFileOld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameFileOld.MaxLength = 32767;
            this.txtNameFileOld.Name = "txtNameFileOld";
            this.txtNameFileOld.PasswordChar = '\0';
            this.txtNameFileOld.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameFileOld.SelectedText = "";
            this.txtNameFileOld.SelectionLength = 0;
            this.txtNameFileOld.SelectionStart = 0;
            this.txtNameFileOld.ShortcutsEnabled = true;
            this.txtNameFileOld.Size = new System.Drawing.Size(279, 28);
            this.txtNameFileOld.TabIndex = 2;
            this.txtNameFileOld.UseSelectable = true;
            this.txtNameFileOld.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameFileOld.WaterMarkFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFileOld.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNameFile_KeyDown);
            // 
            // txtNameFileNew
            // 
            // 
            // 
            // 
            this.txtNameFileNew.CustomButton.Image = null;
            this.txtNameFileNew.CustomButton.Location = new System.Drawing.Point(337, 2);
            this.txtNameFileNew.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameFileNew.CustomButton.Name = "";
            this.txtNameFileNew.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtNameFileNew.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameFileNew.CustomButton.TabIndex = 1;
            this.txtNameFileNew.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameFileNew.CustomButton.UseSelectable = true;
            this.txtNameFileNew.CustomButton.Visible = false;
            this.txtNameFileNew.Lines = new string[0];
            this.txtNameFileNew.Location = new System.Drawing.Point(200, 117);
            this.txtNameFileNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameFileNew.MaxLength = 32767;
            this.txtNameFileNew.Name = "txtNameFileNew";
            this.txtNameFileNew.PasswordChar = '\0';
            this.txtNameFileNew.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameFileNew.SelectedText = "";
            this.txtNameFileNew.SelectionLength = 0;
            this.txtNameFileNew.SelectionStart = 0;
            this.txtNameFileNew.ShortcutsEnabled = true;
            this.txtNameFileNew.Size = new System.Drawing.Size(279, 28);
            this.txtNameFileNew.TabIndex = 2;
            this.txtNameFileNew.UseSelectable = true;
            this.txtNameFileNew.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameFileNew.WaterMarkFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFileNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNameFile_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(44, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên thư mục mới:";
            // 
            // fEditFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 224);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNameFileNew);
            this.Controls.Add(this.txtNameFileOld);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fEditFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fAddFile";
            this.Load += new System.EventHandler(this.fEditFile_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400033E RID: 830
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400033F RID: 831
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000340 RID: 832
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000341 RID: 833
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000342 RID: 834
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000343 RID: 835
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000344 RID: 836
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000345 RID: 837
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000346 RID: 838
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000347 RID: 839
		private global::MetroFramework.Controls.MetroTextBox txtNameFileOld;

		// Token: 0x04000348 RID: 840
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000349 RID: 841
		private global::MetroFramework.Controls.MetroTextBox txtNameFileNew;

		// Token: 0x0400034A RID: 842
		private global::System.Windows.Forms.Label label2;
	}
}
