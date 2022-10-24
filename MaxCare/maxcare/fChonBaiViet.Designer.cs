namespace maxcare
{
	// Token: 0x02000090 RID: 144
	public partial class fChonBaiViet : global::System.Windows.Forms.Form
	{
		// Token: 0x0600057A RID: 1402 RVA: 0x00077EC4 File Offset: 0x000760C4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00077F24 File Offset: 0x00076124
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCountAcc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvBaiVietDaChon = new System.Windows.Forms.DataGridView();
            this.cStt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbChuDe = new System.Windows.Forms.ComboBox();
            this.dgvDSBaiViet = new System.Windows.Forms.DataGridView();
            this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cChuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdBaiViet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmBàiViếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaBàiViếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaBàiViếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtBàiViếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.làmMớiDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịTấtCảBàiViếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiVietDaChon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBaiViet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.bunifuCards1.Size = new System.Drawing.Size(270, 47);
            this.bunifuCards1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuCards2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 517);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.bunifuCards2.Size = new System.Drawing.Size(925, 37);
            this.bunifuCards2.TabIndex = 43;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Location = new System.Drawing.Point(0, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(925, 31);
            this.pnlHeader.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
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
            this.btnMinimize.Image = global::MaxCare.Properties.Resources.close_window_25px;
            this.btnMinimize.Location = new System.Drawing.Point(896, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnCancel_Click);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(925, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Chọn bình luận";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblCountAcc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgvBaiVietDaChon);
            this.groupBox2.Location = new System.Drawing.Point(465, 40);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(454, 423);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bình luận cần sử dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 21);
            this.label3.TabIndex = 80;
            this.label3.Text = "(Click đúp vào dòng để xóa)";
            // 
            // lblCountAcc
            // 
            this.lblCountAcc.AutoSize = true;
            this.lblCountAcc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCountAcc.ForeColor = System.Drawing.Color.Blue;
            this.lblCountAcc.Location = new System.Drawing.Point(349, 401);
            this.lblCountAcc.Name = "lblCountAcc";
            this.lblCountAcc.Size = new System.Drawing.Size(21, 21);
            this.lblCountAcc.TabIndex = 78;
            this.lblCountAcc.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(307, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 79;
            this.label7.Text = "Tổng:";
            // 
            // dgvBaiVietDaChon
            // 
            this.dgvBaiVietDaChon.AllowUserToAddRows = false;
            this.dgvBaiVietDaChon.AllowUserToDeleteRows = false;
            this.dgvBaiVietDaChon.AllowUserToResizeRows = false;
            this.dgvBaiVietDaChon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaiVietDaChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaiVietDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaiVietDaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cStt1,
            this.dataGridViewTextBoxColumn2,
            this.cId,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column1});
            this.dgvBaiVietDaChon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBaiVietDaChon.Location = new System.Drawing.Point(6, 52);
            this.dgvBaiVietDaChon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBaiVietDaChon.MultiSelect = false;
            this.dgvBaiVietDaChon.Name = "dgvBaiVietDaChon";
            this.dgvBaiVietDaChon.RowHeadersVisible = false;
            this.dgvBaiVietDaChon.RowHeadersWidth = 51;
            this.dgvBaiVietDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaiVietDaChon.Size = new System.Drawing.Size(444, 345);
            this.dgvBaiVietDaChon.TabIndex = 76;
            this.dgvBaiVietDaChon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaiVietDaChon_CellDoubleClick);
            this.dgvBaiVietDaChon.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvBaiVietDaChon_RowsAdded);
            this.dgvBaiVietDaChon.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvBaiVietDaChon_RowsRemoved);
            // 
            // cStt1
            // 
            this.cStt1.HeaderText = "STT";
            this.cStt1.MinimumWidth = 6;
            this.cStt1.Name = "cStt1";
            this.cStt1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Chủ đề";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // cId
            // 
            this.cId.HeaderText = "ID Bài viết";
            this.cId.MinimumWidth = 6;
            this.cId.Name = "cId";
            this.cId.Visible = false;
            this.cId.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tiêu đề";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 230;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Ảnh";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Video";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbChuDe);
            this.groupBox1.Controls.Add(this.dgvDSBaiViet);
            this.groupBox1.Location = new System.Drawing.Point(3, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(456, 423);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bình luận";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(7, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 21);
            this.label2.TabIndex = 80;
            this.label2.Text = "(Click đúp vào dòng để chọn)";
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Location = new System.Drawing.Point(282, 23);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(109, 25);
            this.metroButton1.TabIndex = 79;
            this.metroButton1.Text = "Quản lý chủ đề";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 78;
            this.label1.Text = "Chủ đề:";
            // 
            // cbbChuDe
            // 
            this.cbbChuDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbChuDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChuDe.FormattingEnabled = true;
            this.cbbChuDe.Location = new System.Drawing.Point(64, 23);
            this.cbbChuDe.Name = "cbbChuDe";
            this.cbbChuDe.Size = new System.Drawing.Size(212, 27);
            this.cbbChuDe.TabIndex = 77;
            this.cbbChuDe.SelectedIndexChanged += new System.EventHandler(this.cbbChuDe_SelectedIndexChanged);
            // 
            // dgvDSBaiViet
            // 
            this.dgvDSBaiViet.AllowUserToAddRows = false;
            this.dgvDSBaiViet.AllowUserToDeleteRows = false;
            this.dgvDSBaiViet.AllowUserToResizeRows = false;
            this.dgvDSBaiViet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSBaiViet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSBaiViet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBaiViet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cStt,
            this.cChuDe,
            this.cIdBaiViet,
            this.cTieuDe,
            this.cAnh,
            this.cVideo});
            this.dgvDSBaiViet.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDSBaiViet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDSBaiViet.Location = new System.Drawing.Point(10, 54);
            this.dgvDSBaiViet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDSBaiViet.MultiSelect = false;
            this.dgvDSBaiViet.Name = "dgvDSBaiViet";
            this.dgvDSBaiViet.RowHeadersVisible = false;
            this.dgvDSBaiViet.RowHeadersWidth = 51;
            this.dgvDSBaiViet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSBaiViet.Size = new System.Drawing.Size(440, 343);
            this.dgvDSBaiViet.TabIndex = 76;
            this.dgvDSBaiViet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBaiViet_CellContentClick);
            this.dgvDSBaiViet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKichBan_CellDoubleClick);
            // 
            // cStt
            // 
            this.cStt.HeaderText = "STT";
            this.cStt.MinimumWidth = 6;
            this.cStt.Name = "cStt";
            this.cStt.Width = 35;
            // 
            // cChuDe
            // 
            this.cChuDe.HeaderText = "Chủ đề";
            this.cChuDe.MinimumWidth = 6;
            this.cChuDe.Name = "cChuDe";
            this.cChuDe.Width = 125;
            // 
            // cIdBaiViet
            // 
            this.cIdBaiViet.HeaderText = "ID Bài viết";
            this.cIdBaiViet.MinimumWidth = 6;
            this.cIdBaiViet.Name = "cIdBaiViet";
            this.cIdBaiViet.Visible = false;
            this.cIdBaiViet.Width = 90;
            // 
            // cTieuDe
            // 
            this.cTieuDe.HeaderText = "Tiêu đề";
            this.cTieuDe.MinimumWidth = 6;
            this.cTieuDe.Name = "cTieuDe";
            this.cTieuDe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cTieuDe.Width = 230;
            // 
            // cAnh
            // 
            this.cAnh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cAnh.HeaderText = "Ảnh";
            this.cAnh.MinimumWidth = 6;
            this.cAnh.Name = "cAnh";
            // 
            // cVideo
            // 
            this.cVideo.HeaderText = "Video";
            this.cVideo.MinimumWidth = 6;
            this.cVideo.Name = "cVideo";
            this.cVideo.Visible = false;
            this.cVideo.Width = 50;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmBàiViếtToolStripMenuItem,
            this.sửaBàiViếtToolStripMenuItem,
            this.xóaBàiViếtToolStripMenuItem,
            this.chiTiếtBàiViếtToolStripMenuItem,
            this.làmMớiDanhSáchToolStripMenuItem,
            this.hiểnThịTấtCảBàiViếtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(237, 148);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // thêmBàiViếtToolStripMenuItem
            // 
            this.thêmBàiViếtToolStripMenuItem.Name = "thêmBàiViếtToolStripMenuItem";
            this.thêmBàiViếtToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.thêmBàiViếtToolStripMenuItem.Text = "Thêm bình luận";
            this.thêmBàiViếtToolStripMenuItem.Click += new System.EventHandler(this.thêmBàiViếtToolStripMenuItem_Click);
            // 
            // sửaBàiViếtToolStripMenuItem
            // 
            this.sửaBàiViếtToolStripMenuItem.Name = "sửaBàiViếtToolStripMenuItem";
            this.sửaBàiViếtToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.sửaBàiViếtToolStripMenuItem.Text = "Sửa bình luận";
            this.sửaBàiViếtToolStripMenuItem.Click += new System.EventHandler(this.sửaBàiViếtToolStripMenuItem_Click);
            // 
            // xóaBàiViếtToolStripMenuItem
            // 
            this.xóaBàiViếtToolStripMenuItem.Name = "xóaBàiViếtToolStripMenuItem";
            this.xóaBàiViếtToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.xóaBàiViếtToolStripMenuItem.Text = "Xóa bình luận";
            this.xóaBàiViếtToolStripMenuItem.Click += new System.EventHandler(this.xóaBàiViếtToolStripMenuItem_Click);
            // 
            // chiTiếtBàiViếtToolStripMenuItem
            // 
            this.chiTiếtBàiViếtToolStripMenuItem.Name = "chiTiếtBàiViếtToolStripMenuItem";
            this.chiTiếtBàiViếtToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.chiTiếtBàiViếtToolStripMenuItem.Text = "Chi tiết bình luận";
            this.chiTiếtBàiViếtToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtBàiViếtToolStripMenuItem_Click);
            // 
            // làmMớiDanhSáchToolStripMenuItem
            // 
            this.làmMớiDanhSáchToolStripMenuItem.Name = "làmMớiDanhSáchToolStripMenuItem";
            this.làmMớiDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.làmMớiDanhSáchToolStripMenuItem.Text = "Làm mới danh sách";
            this.làmMớiDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.làmMớiDanhSáchToolStripMenuItem_Click);
            // 
            // hiểnThịTấtCảBàiViếtToolStripMenuItem
            // 
            this.hiểnThịTấtCảBàiViếtToolStripMenuItem.Name = "hiểnThịTấtCảBàiViếtToolStripMenuItem";
            this.hiểnThịTấtCảBàiViếtToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.hiểnThịTấtCảBàiViếtToolStripMenuItem.Text = "Hiển thị tất cả bình luận";
            this.hiểnThịTấtCảBàiViếtToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịTấtCảBàiViếtToolStripMenuItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(468, 473);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(361, 473);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 29);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            // 
            // fChonBaiViet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fChonBaiViet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình chung";
            this.Load += new System.EventHandler(this.FConfigGenneral_Load);
            this.panel1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiVietDaChon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBaiViet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04000495 RID: 1173
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000496 RID: 1174
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000497 RID: 1175
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000498 RID: 1176
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000499 RID: 1177
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x0400049A RID: 1178
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x0400049B RID: 1179
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x0400049C RID: 1180
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400049D RID: 1181
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400049E RID: 1182
		public global::System.Windows.Forms.DataGridView dgvDSBaiViet;

		// Token: 0x0400049F RID: 1183
		private global::MetroFramework.Controls.MetroButton metroButton1;

		// Token: 0x040004A0 RID: 1184
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040004A1 RID: 1185
		private global::System.Windows.Forms.ComboBox cbbChuDe;

		// Token: 0x040004A2 RID: 1186
		private global::System.Windows.Forms.Label lblCountAcc;

		// Token: 0x040004A3 RID: 1187
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040004A4 RID: 1188
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards2;

		// Token: 0x040004A5 RID: 1189
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040004A6 RID: 1190
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040004A7 RID: 1191
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x040004A8 RID: 1192
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040004A9 RID: 1193
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040004AA RID: 1194
		public global::System.Windows.Forms.DataGridView dgvBaiVietDaChon;

		// Token: 0x040004AB RID: 1195
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x040004AC RID: 1196
		private global::System.Windows.Forms.ToolStripMenuItem thêmBàiViếtToolStripMenuItem;

		// Token: 0x040004AD RID: 1197
		private global::System.Windows.Forms.ToolStripMenuItem sửaBàiViếtToolStripMenuItem;

		// Token: 0x040004AE RID: 1198
		private global::System.Windows.Forms.ToolStripMenuItem xóaBàiViếtToolStripMenuItem;

		// Token: 0x040004AF RID: 1199
		private global::System.Windows.Forms.ToolStripMenuItem làmMớiDanhSáchToolStripMenuItem;

		// Token: 0x040004B0 RID: 1200
		private global::System.Windows.Forms.ToolStripMenuItem chiTiếtBàiViếtToolStripMenuItem;

		// Token: 0x040004B1 RID: 1201
		private global::System.Windows.Forms.ToolStripMenuItem hiểnThịTấtCảBàiViếtToolStripMenuItem;

		// Token: 0x040004B2 RID: 1202
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040004B3 RID: 1203
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStt1;

		// Token: 0x040004B4 RID: 1204
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

		// Token: 0x040004B5 RID: 1205
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cId;

		// Token: 0x040004B6 RID: 1206
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

		// Token: 0x040004B7 RID: 1207
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

		// Token: 0x040004B8 RID: 1208
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;

		// Token: 0x040004B9 RID: 1209
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStt;

		// Token: 0x040004BA RID: 1210
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cChuDe;

		// Token: 0x040004BB RID: 1211
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cIdBaiViet;

		// Token: 0x040004BC RID: 1212
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cTieuDe;

		// Token: 0x040004BD RID: 1213
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cAnh;

		// Token: 0x040004BE RID: 1214
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cVideo;
	}
}
