namespace QLChiTieu
{
    partial class IncomeForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.income_dgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.income_clearBtn = new System.Windows.Forms.Button();
            this.income_editBtn = new System.Windows.Forms.Button();
            this.income_deleteBtn = new System.Windows.Forms.Button();
            this.income_addBtn = new System.Windows.Forms.Button();
            this.income_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.income_note = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.income_group = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.income_money = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.income_loadDGV = new System.Windows.Forms.Button();
            this.income_btnLoc = new System.Windows.Forms.Button();
            this.income_dtpLocNgayCuoi = new System.Windows.Forms.DateTimePicker();
            this.income_lbLocNgayCuoi = new System.Windows.Forms.Label();
            this.income_dtpLocNgayDau = new System.Windows.Forms.DateTimePicker();
            this.income_lbLocNgayDau = new System.Windows.Forms.Label();
            this.income_tbLocSoTienCuoi = new System.Windows.Forms.TextBox();
            this.income_lbLocSoTienCuoi = new System.Windows.Forms.Label();
            this.income_tbLocSoTienDau = new System.Windows.Forms.TextBox();
            this.income_cbLocDanhMuc = new System.Windows.Forms.ComboBox();
            this.income_lbLocSoTienDau = new System.Windows.Forms.Label();
            this.income_cbChonTruongLoc = new System.Windows.Forms.ComboBox();
            this.income_lbLocDanhMuc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.income_dgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.income_dgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 381);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách khoản thu";
            // 
            // income_dgv
            // 
            this.income_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.income_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.income_dgv.Location = new System.Drawing.Point(14, 41);
            this.income_dgv.Name = "income_dgv";
            this.income_dgv.ReadOnly = true;
            this.income_dgv.RowHeadersWidth = 51;
            this.income_dgv.Size = new System.Drawing.Size(817, 337);
            this.income_dgv.TabIndex = 0;
            this.income_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.income_dgv_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 263);
            this.panel2.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.income_date);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.income_note);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.income_group);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.income_money);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.income_loadDGV);
            this.splitContainer1.Panel2.Controls.Add(this.income_btnLoc);
            this.splitContainer1.Panel2.Controls.Add(this.income_dtpLocNgayCuoi);
            this.splitContainer1.Panel2.Controls.Add(this.income_lbLocNgayCuoi);
            this.splitContainer1.Panel2.Controls.Add(this.income_dtpLocNgayDau);
            this.splitContainer1.Panel2.Controls.Add(this.income_lbLocNgayDau);
            this.splitContainer1.Panel2.Controls.Add(this.income_tbLocSoTienCuoi);
            this.splitContainer1.Panel2.Controls.Add(this.income_lbLocSoTienCuoi);
            this.splitContainer1.Panel2.Controls.Add(this.income_tbLocSoTienDau);
            this.splitContainer1.Panel2.Controls.Add(this.income_cbLocDanhMuc);
            this.splitContainer1.Panel2.Controls.Add(this.income_lbLocSoTienDau);
            this.splitContainer1.Panel2.Controls.Add(this.income_cbChonTruongLoc);
            this.splitContainer1.Panel2.Controls.Add(this.income_lbLocDanhMuc);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Size = new System.Drawing.Size(859, 263);
            this.splitContainer1.SplitterDistance = 494;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.income_clearBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.income_editBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.income_deleteBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.income_addBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 213);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 50);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // income_clearBtn
            // 
            this.income_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_clearBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.income_clearBtn.FlatAppearance.BorderSize = 0;
            this.income_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_clearBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_clearBtn.ForeColor = System.Drawing.Color.White;
            this.income_clearBtn.Location = new System.Drawing.Point(372, 3);
            this.income_clearBtn.Name = "income_clearBtn";
            this.income_clearBtn.Size = new System.Drawing.Size(119, 28);
            this.income_clearBtn.TabIndex = 29;
            this.income_clearBtn.Text = "Xoá bảng";
            this.income_clearBtn.UseVisualStyleBackColor = false;
            this.income_clearBtn.Click += new System.EventHandler(this.income_clearBtn_Click);
            // 
            // income_editBtn
            // 
            this.income_editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_editBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.income_editBtn.FlatAppearance.BorderSize = 0;
            this.income_editBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_editBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_editBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_editBtn.ForeColor = System.Drawing.Color.White;
            this.income_editBtn.Location = new System.Drawing.Point(126, 3);
            this.income_editBtn.Name = "income_editBtn";
            this.income_editBtn.Size = new System.Drawing.Size(117, 28);
            this.income_editBtn.TabIndex = 27;
            this.income_editBtn.Text = "Sửa";
            this.income_editBtn.UseVisualStyleBackColor = false;
            this.income_editBtn.Click += new System.EventHandler(this.income_editBtn_Click);
            // 
            // income_deleteBtn
            // 
            this.income_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_deleteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.income_deleteBtn.FlatAppearance.BorderSize = 0;
            this.income_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_deleteBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.income_deleteBtn.Location = new System.Drawing.Point(249, 3);
            this.income_deleteBtn.Name = "income_deleteBtn";
            this.income_deleteBtn.Size = new System.Drawing.Size(117, 28);
            this.income_deleteBtn.TabIndex = 28;
            this.income_deleteBtn.Text = "Xoá";
            this.income_deleteBtn.UseVisualStyleBackColor = false;
            this.income_deleteBtn.Click += new System.EventHandler(this.income_deleteBtn_Click);
            // 
            // income_addBtn
            // 
            this.income_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_addBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.income_addBtn.FlatAppearance.BorderSize = 0;
            this.income_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_addBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_addBtn.ForeColor = System.Drawing.Color.White;
            this.income_addBtn.Location = new System.Drawing.Point(3, 3);
            this.income_addBtn.Name = "income_addBtn";
            this.income_addBtn.Size = new System.Drawing.Size(117, 28);
            this.income_addBtn.TabIndex = 26;
            this.income_addBtn.Text = "Thêm";
            this.income_addBtn.UseVisualStyleBackColor = false;
            this.income_addBtn.Click += new System.EventHandler(this.income_addBtn_Click);
            // 
            // income_date
            // 
            this.income_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.income_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_date.CustomFormat = "dd/MM/yyyy";
            this.income_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.income_date.Location = new System.Drawing.Point(95, 177);
            this.income_date.Name = "income_date";
            this.income_date.Size = new System.Drawing.Size(396, 26);
            this.income_date.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ngày tháng";
            // 
            // income_note
            // 
            this.income_note.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.income_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_note.Location = new System.Drawing.Point(95, 90);
            this.income_note.Multiline = true;
            this.income_note.Name = "income_note";
            this.income_note.Size = new System.Drawing.Size(396, 69);
            this.income_note.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ghi chú";
            // 
            // income_group
            // 
            this.income_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.income_group.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_group.FormattingEnabled = true;
            this.income_group.Items.AddRange(new object[] {
            "Lương",
            "Thu nhập khác",
            "Tiền chuyển đến",
            "Thu lãi",
            "Khoản thu chưa phân loại"});
            this.income_group.Location = new System.Drawing.Point(95, 51);
            this.income_group.Name = "income_group";
            this.income_group.Size = new System.Drawing.Size(396, 24);
            this.income_group.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Danh mục";
            // 
            // income_money
            // 
            this.income_money.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.income_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_money.Location = new System.Drawing.Point(95, 6);
            this.income_money.Name = "income_money";
            this.income_money.Size = new System.Drawing.Size(396, 29);
            this.income_money.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Số tiền(VNĐ)";
            // 
            // income_loadDGV
            // 
            this.income_loadDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.income_loadDGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_loadDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_loadDGV.FlatAppearance.BorderSize = 0;
            this.income_loadDGV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_loadDGV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_loadDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_loadDGV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_loadDGV.ForeColor = System.Drawing.Color.White;
            this.income_loadDGV.Location = new System.Drawing.Point(233, 126);
            this.income_loadDGV.Name = "income_loadDGV";
            this.income_loadDGV.Size = new System.Drawing.Size(99, 28);
            this.income_loadDGV.TabIndex = 36;
            this.income_loadDGV.Text = "Tải lại bảng";
            this.income_loadDGV.UseVisualStyleBackColor = false;
            this.income_loadDGV.Click += new System.EventHandler(this.income_loadDGV_Click);
            // 
            // income_btnLoc
            // 
            this.income_btnLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.income_btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_btnLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_btnLoc.FlatAppearance.BorderSize = 0;
            this.income_btnLoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_btnLoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_btnLoc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_btnLoc.ForeColor = System.Drawing.Color.White;
            this.income_btnLoc.Location = new System.Drawing.Point(117, 126);
            this.income_btnLoc.Name = "income_btnLoc";
            this.income_btnLoc.Size = new System.Drawing.Size(99, 28);
            this.income_btnLoc.TabIndex = 30;
            this.income_btnLoc.Text = "Lọc";
            this.income_btnLoc.UseVisualStyleBackColor = false;
            this.income_btnLoc.Click += new System.EventHandler(this.income_btnFilter_Click);
            // 
            // income_dtpLocNgayCuoi
            // 
            this.income_dtpLocNgayCuoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.income_dtpLocNgayCuoi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_dtpLocNgayCuoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_dtpLocNgayCuoi.CustomFormat = "dd/MM/yyyy";
            this.income_dtpLocNgayCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_dtpLocNgayCuoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.income_dtpLocNgayCuoi.Location = new System.Drawing.Point(99, 87);
            this.income_dtpLocNgayCuoi.Name = "income_dtpLocNgayCuoi";
            this.income_dtpLocNgayCuoi.Size = new System.Drawing.Size(233, 22);
            this.income_dtpLocNgayCuoi.TabIndex = 35;
            this.income_dtpLocNgayCuoi.Visible = false;
            // 
            // income_lbLocNgayCuoi
            // 
            this.income_lbLocNgayCuoi.AutoSize = true;
            this.income_lbLocNgayCuoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_lbLocNgayCuoi.Location = new System.Drawing.Point(32, 89);
            this.income_lbLocNgayCuoi.Name = "income_lbLocNgayCuoi";
            this.income_lbLocNgayCuoi.Size = new System.Drawing.Size(61, 16);
            this.income_lbLocNgayCuoi.TabIndex = 34;
            this.income_lbLocNgayCuoi.Text = "Đến ngày";
            this.income_lbLocNgayCuoi.Visible = false;
            // 
            // income_dtpLocNgayDau
            // 
            this.income_dtpLocNgayDau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.income_dtpLocNgayDau.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_dtpLocNgayDau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_dtpLocNgayDau.CustomFormat = "dd/MM/yyyy";
            this.income_dtpLocNgayDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_dtpLocNgayDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.income_dtpLocNgayDau.Location = new System.Drawing.Point(98, 51);
            this.income_dtpLocNgayDau.Name = "income_dtpLocNgayDau";
            this.income_dtpLocNgayDau.Size = new System.Drawing.Size(234, 22);
            this.income_dtpLocNgayDau.TabIndex = 31;
            this.income_dtpLocNgayDau.Visible = false;
            // 
            // income_lbLocNgayDau
            // 
            this.income_lbLocNgayDau.AutoSize = true;
            this.income_lbLocNgayDau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_lbLocNgayDau.Location = new System.Drawing.Point(37, 56);
            this.income_lbLocNgayDau.Name = "income_lbLocNgayDau";
            this.income_lbLocNgayDau.Size = new System.Drawing.Size(54, 16);
            this.income_lbLocNgayDau.TabIndex = 30;
            this.income_lbLocNgayDau.Text = "Từ ngày";
            this.income_lbLocNgayDau.Visible = false;
            // 
            // income_tbLocSoTienCuoi
            // 
            this.income_tbLocSoTienCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_tbLocSoTienCuoi.Location = new System.Drawing.Point(98, 85);
            this.income_tbLocSoTienCuoi.Name = "income_tbLocSoTienCuoi";
            this.income_tbLocSoTienCuoi.Size = new System.Drawing.Size(234, 22);
            this.income_tbLocSoTienCuoi.TabIndex = 33;
            this.income_tbLocSoTienCuoi.Visible = false;
            // 
            // income_lbLocSoTienCuoi
            // 
            this.income_lbLocSoTienCuoi.AutoSize = true;
            this.income_lbLocSoTienCuoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_lbLocSoTienCuoi.Location = new System.Drawing.Point(28, 88);
            this.income_lbLocSoTienCuoi.Name = "income_lbLocSoTienCuoi";
            this.income_lbLocSoTienCuoi.Size = new System.Drawing.Size(65, 16);
            this.income_lbLocSoTienCuoi.TabIndex = 32;
            this.income_lbLocSoTienCuoi.Text = "Đến(VNĐ)";
            this.income_lbLocSoTienCuoi.Visible = false;
            // 
            // income_tbLocSoTienDau
            // 
            this.income_tbLocSoTienDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_tbLocSoTienDau.Location = new System.Drawing.Point(98, 51);
            this.income_tbLocSoTienDau.Name = "income_tbLocSoTienDau";
            this.income_tbLocSoTienDau.Size = new System.Drawing.Size(234, 22);
            this.income_tbLocSoTienDau.TabIndex = 31;
            this.income_tbLocSoTienDau.Visible = false;
            // 
            // income_cbLocDanhMuc
            // 
            this.income_cbLocDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_cbLocDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_cbLocDanhMuc.FormattingEnabled = true;
            this.income_cbLocDanhMuc.Items.AddRange(new object[] {
            "Lương",
            "Thu nhập khác",
            "Tiền chuyển đến",
            "Thu lãi",
            "Khoản thu chưa phân loại"});
            this.income_cbLocDanhMuc.Location = new System.Drawing.Point(99, 51);
            this.income_cbLocDanhMuc.Name = "income_cbLocDanhMuc";
            this.income_cbLocDanhMuc.Size = new System.Drawing.Size(233, 24);
            this.income_cbLocDanhMuc.TabIndex = 31;
            this.income_cbLocDanhMuc.Visible = false;
            this.income_cbLocDanhMuc.SelectedIndexChanged += new System.EventHandler(this.income_cbLocDanhMuc_SelectedIndexChanged);
            // 
            // income_lbLocSoTienDau
            // 
            this.income_lbLocSoTienDau.AutoSize = true;
            this.income_lbLocSoTienDau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_lbLocSoTienDau.Location = new System.Drawing.Point(34, 54);
            this.income_lbLocSoTienDau.Name = "income_lbLocSoTienDau";
            this.income_lbLocSoTienDau.Size = new System.Drawing.Size(58, 16);
            this.income_lbLocSoTienDau.TabIndex = 30;
            this.income_lbLocSoTienDau.Text = "Từ(VNĐ)";
            this.income_lbLocSoTienDau.Visible = false;
            // 
            // income_cbChonTruongLoc
            // 
            this.income_cbChonTruongLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.income_cbChonTruongLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_cbChonTruongLoc.FormattingEnabled = true;
            this.income_cbChonTruongLoc.Items.AddRange(new object[] {
            "Danh mục",
            "Khoảng tiền",
            "Ngày tháng"});
            this.income_cbChonTruongLoc.Location = new System.Drawing.Point(99, 10);
            this.income_cbChonTruongLoc.Name = "income_cbChonTruongLoc";
            this.income_cbChonTruongLoc.Size = new System.Drawing.Size(233, 28);
            this.income_cbChonTruongLoc.TabIndex = 31;
            this.income_cbChonTruongLoc.SelectedIndexChanged += new System.EventHandler(this.income_cbChonTruongLoc_SelectedIndexChanged);
            // 
            // income_lbLocDanhMuc
            // 
            this.income_lbLocDanhMuc.AutoSize = true;
            this.income_lbLocDanhMuc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_lbLocDanhMuc.Location = new System.Drawing.Point(28, 54);
            this.income_lbLocDanhMuc.Name = "income_lbLocDanhMuc";
            this.income_lbLocDanhMuc.Size = new System.Drawing.Size(64, 16);
            this.income_lbLocDanhMuc.TabIndex = 30;
            this.income_lbLocDanhMuc.Text = "Danh mục";
            this.income_lbLocDanhMuc.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 32);
            this.label6.TabIndex = 30;
            this.label6.Text = "Chọn trường\r\nmuốn lọc";
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IncomeForm";
            this.Size = new System.Drawing.Size(859, 650);
            this.Load += new System.EventHandler(this.IncomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.income_dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView income_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox income_money;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox income_group;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox income_note;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker income_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button income_editBtn;
        private System.Windows.Forms.Button income_addBtn;
        private System.Windows.Forms.Button income_clearBtn;
        private System.Windows.Forms.Button income_deleteBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox income_cbChonTruongLoc;
        private System.Windows.Forms.TextBox income_tbLocSoTienDau;
        private System.Windows.Forms.ComboBox income_cbLocDanhMuc;
        private System.Windows.Forms.Label income_lbLocSoTienDau;
        private System.Windows.Forms.Label income_lbLocDanhMuc;
        private System.Windows.Forms.TextBox income_tbLocSoTienCuoi;
        private System.Windows.Forms.Label income_lbLocSoTienCuoi;
        private System.Windows.Forms.DateTimePicker income_dtpLocNgayCuoi;
        private System.Windows.Forms.Label income_lbLocNgayCuoi;
        private System.Windows.Forms.DateTimePicker income_dtpLocNgayDau;
        private System.Windows.Forms.Label income_lbLocNgayDau;
        private System.Windows.Forms.Button income_btnLoc;
        private System.Windows.Forms.Button income_loadDGV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
