namespace maxcare
{
	// Token: 0x02000123 RID: 291
	public partial class fCopy : global::System.Windows.Forms.Form
	{
		// Token: 0x06000D2A RID: 3370 RVA: 0x001E348C File Offset: 0x001E168C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x001E34EC File Offset: 0x001E16EC
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.cbbDinhDang1 = new System.Windows.Forms.ComboBox();
            this.cbbDinhDang2 = new System.Windows.Forms.ComboBox();
            this.cbbDinhDang3 = new System.Windows.Forms.ComboBox();
            this.cbbDinhDang4 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbDinhDang5 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbDinhDang6 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbDinhDang7 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbDinhDang9 = new System.Windows.Forms.ComboBox();
            this.cbbDinhDang8 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuCards1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
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
            this.bunifuCards1.Size = new System.Drawing.Size(1383, 47);
            this.bunifuCards1.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Location = new System.Drawing.Point(0, 6);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1383, 39);
            this.pnlHeader.TabIndex = 9;
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
            this.btnMinimize.Location = new System.Drawing.Point(1340, 0);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(1383, 39);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Tùy chọn định dạng sao chép";
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
            this.btnCancel.Location = new System.Drawing.Point(767, 148);
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
            this.btnAdd.Location = new System.Drawing.Point(623, 148);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Xác nhận";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Chọn định dạng copy:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // cbbDinhDang1
            // 
            this.cbbDinhDang1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDinhDang1.FormattingEnabled = true;
            this.cbbDinhDang1.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Tên",
            "Giới tính",
            "Theo dõi",
            "Bạn bè",
            "Nhóm",
            "Ngày sinh",
            "Ngày tạo",
            "Ghi chú"});
            this.cbbDinhDang1.Location = new System.Drawing.Point(211, 80);
            this.cbbDinhDang1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbDinhDang1.Name = "cbbDinhDang1";
            this.cbbDinhDang1.Size = new System.Drawing.Size(103, 27);
            this.cbbDinhDang1.TabIndex = 42;
            // 
            // cbbDinhDang2
            // 
            this.cbbDinhDang2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDinhDang2.FormattingEnabled = true;
            this.cbbDinhDang2.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Tên",
            "Giới tính",
            "Theo dõi",
            "Bạn bè",
            "Nhóm",
            "Ngày sinh",
            "Ngày tạo",
            "Ghi chú"});
            this.cbbDinhDang2.Location = new System.Drawing.Point(340, 80);
            this.cbbDinhDang2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbDinhDang2.Name = "cbbDinhDang2";
            this.cbbDinhDang2.Size = new System.Drawing.Size(103, 27);
            this.cbbDinhDang2.TabIndex = 43;
            // 
            // cbbDinhDang3
            // 
            this.cbbDinhDang3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDinhDang3.FormattingEnabled = true;
            this.cbbDinhDang3.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Tên",
            "Giới tính",
            "Theo dõi",
            "Bạn bè",
            "Nhóm",
            "Ngày sinh",
            "Ngày tạo",
            "Ghi chú"});
            this.cbbDinhDang3.Location = new System.Drawing.Point(469, 80);
            this.cbbDinhDang3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbDinhDang3.Name = "cbbDinhDang3";
            this.cbbDinhDang3.Size = new System.Drawing.Size(103, 27);
            this.cbbDinhDang3.TabIndex = 44;
            // 
            // cbbDinhDang4
            // 
            this.cbbDinhDang4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDinhDang4.FormattingEnabled = true;
            this.cbbDinhDang4.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Tên",
            "Giới tính",
            "Theo dõi",
            "Bạn bè",
            "Nhóm",
            "Ngày sinh",
            "Ngày tạo",
            "Ghi chú"});
            this.cbbDinhDang4.Location = new System.Drawing.Point(599, 80);
            this.cbbDinhDang4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbDinhDang4.Name = "cbbDinhDang4";
            this.cbbDinhDang4.Size = new System.Drawing.Size(103, 27);
            this.cbbDinhDang4.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(961, 82);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 24);
            this.label14.TabIndex = 49;
            this.label14.Text = "|";
            // 
            // cbbDinhDang5
            // 
            this.cbbDinhDang5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDinhDang5.FormattingEnabled = true;
            this.cbbDinhDang5.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Tên",
            "Giới tính",
            "Theo dõi",
            "Bạn bè",
            "Nhóm",
            "Ngày sinh",
            "Ngày tạo",
            "Ghi chú"});
            this.cbbDinhDang5.Location = new System.Drawing.Point(728, 80);
            this.cbbDinhDang5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbDinhDang5.Name = "cbbDinhDang5";
            this.cbbDinhDang5.Size = new System.Drawing.Size(103, 27);
            this.cbbDinhDang5.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(832, 82);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 24);
            this.label13.TabIndex = 50;
            this.label13.Text = "|";
            // 
            // cbbDinhDang6
            // 
            this.cbbDinhDang6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDinhDang6.FormattingEnabled = true;
            this.cbbDinhDang6.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Tên",
            "Giới tính",
            "Theo dõi",
            "Bạn bè",
            "Nhóm",
            "Ngày sinh",
            "Ngày tạo",
            "Ghi chú"});
            this.cbbDinhDang6.Location = new System.Drawing.Point(857, 80);
            this.cbbDinhDang6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbDinhDang6.Name = "cbbDinhDang6";
            this.cbbDinhDang6.Size = new System.Drawing.Size(103, 27);
            this.cbbDinhDang6.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(703, 82);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 24);
            this.label12.TabIndex = 51;
            this.label12.Text = "|";
            // 
            // cbbDinhDang7
            // 
            this.cbbDinhDang7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDinhDang7.FormattingEnabled = true;
            this.cbbDinhDang7.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Tên",
            "Giới tính",
            "Theo dõi",
            "Bạn bè",
            "Nhóm",
            "Ngày sinh",
            "Ngày tạo",
            "Ghi chú"});
            this.cbbDinhDang7.Location = new System.Drawing.Point(987, 80);
            this.cbbDinhDang7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbDinhDang7.Name = "cbbDinhDang7";
            this.cbbDinhDang7.Size = new System.Drawing.Size(103, 27);
            this.cbbDinhDang7.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(573, 82);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 24);
            this.label11.TabIndex = 52;
            this.label11.Text = "|";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(315, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 24);
            this.label9.TabIndex = 53;
            this.label9.Text = "|";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(444, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 24);
            this.label10.TabIndex = 54;
            this.label10.Text = "|";
            // 
            // cbbDinhDang9
            // 
            this.cbbDinhDang9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDinhDang9.FormattingEnabled = true;
            this.cbbDinhDang9.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Tên",
            "Giới tính",
            "Theo dõi",
            "Bạn bè",
            "Nhóm",
            "Ngày sinh",
            "Ngày tạo",
            "Ghi chú"});
            this.cbbDinhDang9.Location = new System.Drawing.Point(1245, 80);
            this.cbbDinhDang9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbDinhDang9.Name = "cbbDinhDang9";
            this.cbbDinhDang9.Size = new System.Drawing.Size(103, 27);
            this.cbbDinhDang9.TabIndex = 48;
            // 
            // cbbDinhDang8
            // 
            this.cbbDinhDang8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDinhDang8.FormattingEnabled = true;
            this.cbbDinhDang8.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Tên",
            "Giới tính",
            "Theo dõi",
            "Bạn bè",
            "Nhóm",
            "Ngày sinh",
            "Ngày tạo",
            "Ghi chú"});
            this.cbbDinhDang8.Location = new System.Drawing.Point(1116, 80);
            this.cbbDinhDang8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbDinhDang8.Name = "cbbDinhDang8";
            this.cbbDinhDang8.Size = new System.Drawing.Size(103, 27);
            this.cbbDinhDang8.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1091, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1220, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "|";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(440, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reset định dạng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 203);
            this.Controls.Add(this.cbbDinhDang1);
            this.Controls.Add(this.cbbDinhDang2);
            this.Controls.Add(this.cbbDinhDang3);
            this.Controls.Add(this.cbbDinhDang4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbbDinhDang5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbDinhDang8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbbDinhDang6);
            this.Controls.Add(this.cbbDinhDang9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbbDinhDang7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fCopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fAddFile";
            this.Load += new System.EventHandler(this.fCopy_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x040015A8 RID: 5544
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040015A9 RID: 5545
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040015AA RID: 5546
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040015AB RID: 5547
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040015AC RID: 5548
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x040015AD RID: 5549
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040015AE RID: 5550
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040015AF RID: 5551
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040015B0 RID: 5552
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040015B1 RID: 5553
		private global::System.Windows.Forms.ComboBox cbbDinhDang1;

		// Token: 0x040015B2 RID: 5554
		private global::System.Windows.Forms.ComboBox cbbDinhDang2;

		// Token: 0x040015B3 RID: 5555
		private global::System.Windows.Forms.ComboBox cbbDinhDang3;

		// Token: 0x040015B4 RID: 5556
		private global::System.Windows.Forms.ComboBox cbbDinhDang4;

		// Token: 0x040015B5 RID: 5557
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040015B6 RID: 5558
		private global::System.Windows.Forms.ComboBox cbbDinhDang5;

		// Token: 0x040015B7 RID: 5559
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040015B8 RID: 5560
		private global::System.Windows.Forms.ComboBox cbbDinhDang6;

		// Token: 0x040015B9 RID: 5561
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040015BA RID: 5562
		private global::System.Windows.Forms.ComboBox cbbDinhDang7;

		// Token: 0x040015BB RID: 5563
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040015BC RID: 5564
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040015BD RID: 5565
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040015BE RID: 5566
		private global::System.Windows.Forms.ComboBox cbbDinhDang9;

		// Token: 0x040015BF RID: 5567
		private global::System.Windows.Forms.ComboBox cbbDinhDang8;

		// Token: 0x040015C0 RID: 5568
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040015C1 RID: 5569
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040015C2 RID: 5570
		private global::System.Windows.Forms.Button button1;
	}
}
