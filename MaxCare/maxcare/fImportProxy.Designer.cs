namespace maxcare
{
	// Token: 0x020000E9 RID: 233
	public partial class fImportProxy : global::System.Windows.Forms.Form
	{
		// Token: 0x06000968 RID: 2408 RVA: 0x0012AF14 File Offset: 0x00129114
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0012AF74 File Offset: 0x00129174
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
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtProxy = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTaiKhoanPerUa = new System.Windows.Forms.NumericUpDown();
            this.ckbKhongNhapTaiKhoanDaCo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbNgauNhien = new System.Windows.Forms.RadioButton();
            this.rbLanLuot = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTypeProxy = new System.Windows.Forms.ComboBox();
            this.bunifuCards1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaiKhoanPerUa)).BeginInit();
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
            this.bunifuCards1.Size = new System.Drawing.Size(636, 47);
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
            this.pnlHeader.Size = new System.Drawing.Size(636, 39);
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
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::MaxCare.Properties.Resources.close_window_25px;
            this.btnMinimize.Location = new System.Drawing.Point(593, 0);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(636, 39);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Nhập Proxy";
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
            this.btnCancel.Location = new System.Drawing.Point(325, 475);
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
            this.btnAdd.Location = new System.Drawing.Point(180, 475);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Xác nhận";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(441, 310);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "(Mỗi proxy 1 dòng)";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(40, 58);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(167, 21);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Danh sách Proxy (0):";
            // 
            // txtProxy
            // 
            this.txtProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProxy.Location = new System.Drawing.Point(45, 81);
            this.txtProxy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProxy.Name = "txtProxy";
            this.txtProxy.Size = new System.Drawing.Size(544, 222);
            this.txtProxy.TabIndex = 118;
            this.txtProxy.Text = "";
            this.txtProxy.WordWrap = false;
            this.txtProxy.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 367);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 119;
            this.label1.Text = "Số tài khoản/proxy:";
            // 
            // nudTaiKhoanPerUa
            // 
            this.nudTaiKhoanPerUa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTaiKhoanPerUa.Location = new System.Drawing.Point(209, 364);
            this.nudTaiKhoanPerUa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudTaiKhoanPerUa.Name = "nudTaiKhoanPerUa";
            this.nudTaiKhoanPerUa.Size = new System.Drawing.Size(92, 27);
            this.nudTaiKhoanPerUa.TabIndex = 120;
            // 
            // ckbKhongNhapTaiKhoanDaCo
            // 
            this.ckbKhongNhapTaiKhoanDaCo.AutoSize = true;
            this.ckbKhongNhapTaiKhoanDaCo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbKhongNhapTaiKhoanDaCo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbKhongNhapTaiKhoanDaCo.Location = new System.Drawing.Point(44, 430);
            this.ckbKhongNhapTaiKhoanDaCo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbKhongNhapTaiKhoanDaCo.Name = "ckbKhongNhapTaiKhoanDaCo";
            this.ckbKhongNhapTaiKhoanDaCo.Size = new System.Drawing.Size(365, 25);
            this.ckbKhongNhapTaiKhoanDaCo.TabIndex = 121;
            this.ckbKhongNhapTaiKhoanDaCo.Text = "Không nhập vào những tài khoản đã có Proxy";
            this.ckbKhongNhapTaiKhoanDaCo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 400);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 119;
            this.label2.Text = "Tùy chọn nhập Proxy:";
            // 
            // rbNgauNhien
            // 
            this.rbNgauNhien.AutoSize = true;
            this.rbNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNgauNhien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNgauNhien.Location = new System.Drawing.Point(328, 398);
            this.rbNgauNhien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNgauNhien.Name = "rbNgauNhien";
            this.rbNgauNhien.Size = new System.Drawing.Size(114, 25);
            this.rbNgauNhien.TabIndex = 122;
            this.rbNgauNhien.Text = "Ngẫu nhiên";
            this.rbNgauNhien.UseVisualStyleBackColor = true;
            // 
            // rbLanLuot
            // 
            this.rbLanLuot.AutoSize = true;
            this.rbLanLuot.Checked = true;
            this.rbLanLuot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLanLuot.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLanLuot.Location = new System.Drawing.Point(209, 398);
            this.rbLanLuot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbLanLuot.Name = "rbLanLuot";
            this.rbLanLuot.Size = new System.Drawing.Size(91, 25);
            this.rbLanLuot.TabIndex = 122;
            this.rbLanLuot.TabStop = true;
            this.rbLanLuot.Text = "Lần lượt";
            this.rbLanLuot.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 329);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 119;
            this.label3.Text = "Loại Proxy:";
            // 
            // cbbTypeProxy
            // 
            this.cbbTypeProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTypeProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeProxy.FormattingEnabled = true;
            this.cbbTypeProxy.Items.AddRange(new object[] {
            "HTTP",
            "Sock5"});
            this.cbbTypeProxy.Location = new System.Drawing.Point(209, 325);
            this.cbbTypeProxy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbTypeProxy.Name = "cbbTypeProxy";
            this.cbbTypeProxy.Size = new System.Drawing.Size(185, 27);
            this.cbbTypeProxy.TabIndex = 123;
            // 
            // fImportProxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 532);
            this.Controls.Add(this.cbbTypeProxy);
            this.Controls.Add(this.rbLanLuot);
            this.Controls.Add(this.rbNgauNhien);
            this.Controls.Add(this.ckbKhongNhapTaiKhoanDaCo);
            this.Controls.Add(this.nudTaiKhoanPerUa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProxy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fImportProxy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fAddFile";
            this.Load += new System.EventHandler(this.fImportProxy_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaiKhoanPerUa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000D5A RID: 3418
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000D5B RID: 3419
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000D5C RID: 3420
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000D5D RID: 3421
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000D5E RID: 3422
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000D5F RID: 3423
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000D60 RID: 3424
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000D61 RID: 3425
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000D62 RID: 3426
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000D63 RID: 3427
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000D64 RID: 3428
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000D65 RID: 3429
		private global::System.Windows.Forms.RichTextBox txtProxy;

		// Token: 0x04000D66 RID: 3430
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000D67 RID: 3431
		private global::System.Windows.Forms.NumericUpDown nudTaiKhoanPerUa;

		// Token: 0x04000D68 RID: 3432
		private global::System.Windows.Forms.CheckBox ckbKhongNhapTaiKhoanDaCo;

		// Token: 0x04000D69 RID: 3433
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000D6A RID: 3434
		private global::System.Windows.Forms.RadioButton rbNgauNhien;

		// Token: 0x04000D6B RID: 3435
		private global::System.Windows.Forms.RadioButton rbLanLuot;

		// Token: 0x04000D6C RID: 3436
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000D6D RID: 3437
		private global::System.Windows.Forms.ComboBox cbbTypeProxy;
	}
}
