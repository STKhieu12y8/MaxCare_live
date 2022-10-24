namespace maxcare
{
	// Token: 0x020000E7 RID: 231
	public partial class fChonKichBan : global::System.Windows.Forms.Form
	{
		// Token: 0x06000957 RID: 2391 RVA: 0x00126BF4 File Offset: 0x00124DF4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00126C54 File Offset: 0x00124E54
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvKichBan = new System.Windows.Forms.DataGridView();
            this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdKichBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenKichBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCountAcc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgvKichBanChoose = new System.Windows.Forms.DataGridView();
            this.cSTTChoose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdKichBanChoose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenKichBanChoose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKichBan)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKichBanChoose)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            this.toolTip1.ToolTipTitle = "Chú thích";
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(696, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Chọn danh sách kịch bản chạy";
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
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.button1);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Location = new System.Drawing.Point(0, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(696, 31);
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
            this.button1.Location = new System.Drawing.Point(667, 2);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtgvKichBan);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(308, 302);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách kịch bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 21);
            this.label2.TabIndex = 81;
            this.label2.Text = "(Click đúp vào kịch bản để chọn)";
            // 
            // dtgvKichBan
            // 
            this.dtgvKichBan.AllowUserToAddRows = false;
            this.dtgvKichBan.AllowUserToDeleteRows = false;
            this.dtgvKichBan.AllowUserToResizeRows = false;
            this.dtgvKichBan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvKichBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvKichBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKichBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cStt,
            this.cIdKichBan,
            this.cTenKichBan});
            this.dtgvKichBan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvKichBan.Location = new System.Drawing.Point(6, 20);
            this.dtgvKichBan.MultiSelect = false;
            this.dtgvKichBan.Name = "dtgvKichBan";
            this.dtgvKichBan.RowHeadersVisible = false;
            this.dtgvKichBan.RowHeadersWidth = 51;
            this.dtgvKichBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvKichBan.Size = new System.Drawing.Size(296, 258);
            this.dtgvKichBan.TabIndex = 76;
            this.dtgvKichBan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKichBan_CellDoubleClick);
            // 
            // cStt
            // 
            this.cStt.HeaderText = "STT";
            this.cStt.MinimumWidth = 6;
            this.cStt.Name = "cStt";
            this.cStt.Width = 35;
            // 
            // cIdKichBan
            // 
            this.cIdKichBan.HeaderText = "Id kịch bản";
            this.cIdKichBan.MinimumWidth = 6;
            this.cIdKichBan.Name = "cIdKichBan";
            this.cIdKichBan.Visible = false;
            this.cIdKichBan.Width = 125;
            // 
            // cTenKichBan
            // 
            this.cTenKichBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenKichBan.HeaderText = "Tên kịch bản";
            this.cTenKichBan.MinimumWidth = 6;
            this.cTenKichBan.Name = "cTenKichBan";
            this.cTenKichBan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.bunifuCards1.Size = new System.Drawing.Size(699, 37);
            this.bunifuCards1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 391);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(359, 350);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(252, 350);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 29);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lblCountAcc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.dtgvKichBanChoose);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(325, 40);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(363, 302);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kịch bản cần chạy";
            // 
            // lblCountAcc
            // 
            this.lblCountAcc.AutoSize = true;
            this.lblCountAcc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCountAcc.ForeColor = System.Drawing.Color.Blue;
            this.lblCountAcc.Location = new System.Drawing.Point(297, 281);
            this.lblCountAcc.Name = "lblCountAcc";
            this.lblCountAcc.Size = new System.Drawing.Size(21, 21);
            this.lblCountAcc.TabIndex = 82;
            this.lblCountAcc.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(255, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 83;
            this.label7.Text = "Tổng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 21);
            this.label1.TabIndex = 81;
            this.label1.Text = "(Click đúp vào kịch bản để xóa)";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(314, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 38);
            this.button3.TabIndex = 78;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgvKichBanChoose
            // 
            this.dtgvKichBanChoose.AllowUserToAddRows = false;
            this.dtgvKichBanChoose.AllowUserToDeleteRows = false;
            this.dtgvKichBanChoose.AllowUserToResizeRows = false;
            this.dtgvKichBanChoose.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvKichBanChoose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvKichBanChoose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKichBanChoose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSTTChoose,
            this.cIdKichBanChoose,
            this.cTenKichBanChoose});
            this.dtgvKichBanChoose.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvKichBanChoose.Location = new System.Drawing.Point(6, 20);
            this.dtgvKichBanChoose.MultiSelect = false;
            this.dtgvKichBanChoose.Name = "dtgvKichBanChoose";
            this.dtgvKichBanChoose.RowHeadersVisible = false;
            this.dtgvKichBanChoose.RowHeadersWidth = 51;
            this.dtgvKichBanChoose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvKichBanChoose.Size = new System.Drawing.Size(302, 258);
            this.dtgvKichBanChoose.TabIndex = 76;
            this.dtgvKichBanChoose.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dtgvKichBanChoose.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgvKichBanChoose_RowsAdded);
            this.dtgvKichBanChoose.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvKichBanChoose_RowsRemoved);
            // 
            // cSTTChoose
            // 
            this.cSTTChoose.HeaderText = "STT";
            this.cSTTChoose.MinimumWidth = 6;
            this.cSTTChoose.Name = "cSTTChoose";
            this.cSTTChoose.Width = 35;
            // 
            // cIdKichBanChoose
            // 
            this.cIdKichBanChoose.HeaderText = "Id kịch bản";
            this.cIdKichBanChoose.MinimumWidth = 6;
            this.cIdKichBanChoose.Name = "cIdKichBanChoose";
            this.cIdKichBanChoose.Visible = false;
            this.cIdKichBanChoose.Width = 125;
            // 
            // cTenKichBanChoose
            // 
            this.cTenKichBanChoose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenKichBanChoose.HeaderText = "Tên kịch bản";
            this.cTenKichBanChoose.MinimumWidth = 6;
            this.cTenKichBanChoose.Name = "cTenKichBanChoose";
            this.cTenKichBanChoose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(314, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 38);
            this.button2.TabIndex = 78;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fChonKichBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fChonKichBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKichBan)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKichBanChoose)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x04000D2B RID: 3371
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000D2C RID: 3372
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000D2D RID: 3373
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000D2E RID: 3374
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000D2F RID: 3375
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000D30 RID: 3376
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000D31 RID: 3377
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000D32 RID: 3378
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000D33 RID: 3379
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000D34 RID: 3380
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000D35 RID: 3381
		public global::System.Windows.Forms.DataGridView dtgvKichBan;

		// Token: 0x04000D36 RID: 3382
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000D37 RID: 3383
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000D38 RID: 3384
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000D39 RID: 3385
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000D3A RID: 3386
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000D3B RID: 3387
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000D3C RID: 3388
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000D3D RID: 3389
		private global::System.Windows.Forms.Label lblCountAcc;

		// Token: 0x04000D3E RID: 3390
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000D3F RID: 3391
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000D40 RID: 3392
		public global::System.Windows.Forms.DataGridView dtgvKichBanChoose;

		// Token: 0x04000D41 RID: 3393
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStt;

		// Token: 0x04000D42 RID: 3394
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cIdKichBan;

		// Token: 0x04000D43 RID: 3395
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cTenKichBan;

		// Token: 0x04000D44 RID: 3396
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cSTTChoose;

		// Token: 0x04000D45 RID: 3397
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cIdKichBanChoose;

		// Token: 0x04000D46 RID: 3398
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cTenKichBanChoose;
	}
}
