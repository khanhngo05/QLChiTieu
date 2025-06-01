namespace QLChiTieu
{
    partial class DebtBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDanhSachNo = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGhiNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaltien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tenkhoanno = new System.Windows.Forms.TextBox();
            this.sotienno = new System.Windows.Forms.TextBox();
            this.ngayno = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ngaytra = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.trangthai = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_done);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.btn_change);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.trangthai);
            this.panel1.Controls.Add(this.tenkhoanno);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.ngayno);
            this.panel1.Controls.Add(this.sotienno);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ngaytra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 220);
            this.panel1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 32);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 188);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(859, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "    Sổ nợ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDanhSachNo);
            this.panel2.Controls.Add(this.totaltien);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 430);
            this.panel2.TabIndex = 1;
            // 
            // dgvDanhSachNo
            // 
            this.dgvDanhSachNo.AllowUserToAddRows = false;
            this.dgvDanhSachNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenNo,
            this.TienNo,
            this.NgayGhiNo,
            this.HanTra,
            this.status});
            this.dgvDanhSachNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachNo.Location = new System.Drawing.Point(0, 70);
            this.dgvDanhSachNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDanhSachNo.Name = "dgvDanhSachNo";
            this.dgvDanhSachNo.RowHeadersWidth = 51;
            this.dgvDanhSachNo.RowTemplate.Height = 24;
            this.dgvDanhSachNo.Size = new System.Drawing.Size(859, 360);
            this.dgvDanhSachNo.TabIndex = 15;
            this.dgvDanhSachNo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachNo_CellClick);
            // 
            // STT
            // 
            this.STT.FillWeight = 5F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Visible = false;
            // 
            // TenNo
            // 
            this.TenNo.FillWeight = 19F;
            this.TenNo.HeaderText = "Tên khoản nợ";
            this.TenNo.MinimumWidth = 6;
            this.TenNo.Name = "TenNo";
            // 
            // TienNo
            // 
            this.TienNo.FillWeight = 19F;
            this.TienNo.HeaderText = "Tiền Nợ";
            this.TienNo.MinimumWidth = 6;
            this.TienNo.Name = "TienNo";
            // 
            // NgayGhiNo
            // 
            this.NgayGhiNo.FillWeight = 19F;
            this.NgayGhiNo.HeaderText = "Ngày ghi nợ";
            this.NgayGhiNo.MinimumWidth = 6;
            this.NgayGhiNo.Name = "NgayGhiNo";
            // 
            // HanTra
            // 
            this.HanTra.FillWeight = 19F;
            this.HanTra.HeaderText = "Ngày trả";
            this.HanTra.MinimumWidth = 6;
            this.HanTra.Name = "HanTra";
            // 
            // status
            // 
            this.status.FillWeight = 19F;
            this.status.HeaderText = "Trạng thái";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            // 
            // totaltien
            // 
            this.totaltien.BackColor = System.Drawing.Color.Transparent;
            this.totaltien.Dock = System.Windows.Forms.DockStyle.Top;
            this.totaltien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totaltien.Location = new System.Drawing.Point(0, 35);
            this.totaltien.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.totaltien.Name = "totaltien";
            this.totaltien.Size = new System.Drawing.Size(859, 35);
            this.totaltien.TabIndex = 8;
            this.totaltien.Text = "Tổng nợ: 0đ                   Tổng vay: 0đ";
            this.totaltien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.PaleGreen;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(859, 35);
            this.label6.TabIndex = 7;
            this.label6.Text = "Danh sách nợ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_del
            // 
            this.btn_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_del.Location = new System.Drawing.Point(503, 124);
            this.btn_del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(145, 35);
            this.btn_del.TabIndex = 43;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(503, 61);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(145, 35);
            this.btn_add.TabIndex = 42;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_change
            // 
            this.btn_change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_change.Location = new System.Drawing.Point(684, 61);
            this.btn_change.Margin = new System.Windows.Forms.Padding(2);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(145, 35);
            this.btn_change.TabIndex = 44;
            this.btn_change.Text = "Thay đổi";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.EnabledChanged += new System.EventHandler(this.btn_change_EnabledChanged);
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_done
            // 
            this.btn_done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.btn_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_done.Location = new System.Drawing.Point(684, 124);
            this.btn_done.Margin = new System.Windows.Forms.Padding(2);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(145, 35);
            this.btn_done.TabIndex = 45;
            this.btn_done.Text = "Trả";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tên Khoản nợ:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Số tiền nợ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Ngày ghi nợ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenkhoanno
            // 
            this.tenkhoanno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tenkhoanno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenkhoanno.Location = new System.Drawing.Point(131, 47);
            this.tenkhoanno.Margin = new System.Windows.Forms.Padding(2);
            this.tenkhoanno.Name = "tenkhoanno";
            this.tenkhoanno.Size = new System.Drawing.Size(330, 23);
            this.tenkhoanno.TabIndex = 46;
            // 
            // sotienno
            // 
            this.sotienno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sotienno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sotienno.Location = new System.Drawing.Point(131, 83);
            this.sotienno.Margin = new System.Windows.Forms.Padding(2);
            this.sotienno.Name = "sotienno";
            this.sotienno.Size = new System.Drawing.Size(330, 23);
            this.sotienno.TabIndex = 48;
            // 
            // ngayno
            // 
            this.ngayno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ngayno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayno.Location = new System.Drawing.Point(131, 119);
            this.ngayno.Margin = new System.Windows.Forms.Padding(2);
            this.ngayno.Name = "ngayno";
            this.ngayno.Size = new System.Drawing.Size(145, 23);
            this.ngayno.TabIndex = 49;
            this.ngayno.Tag = "0";
            this.ngayno.ValueChanged += new System.EventHandler(this.ngayno_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Hạn trả nợ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ngaytra
            // 
            this.ngaytra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ngaytra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaytra.Location = new System.Drawing.Point(131, 160);
            this.ngaytra.Margin = new System.Windows.Forms.Padding(2);
            this.ngaytra.Name = "ngaytra";
            this.ngaytra.Size = new System.Drawing.Size(145, 23);
            this.ngaytra.TabIndex = 51;
            this.ngaytra.Tag = "0";
            this.ngaytra.ValueChanged += new System.EventHandler(this.ngaytra_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 193);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 52;
            this.label11.Text = "Cho vay/Nợ:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trangthai
            // 
            this.trangthai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trangthai.FormattingEnabled = true;
            this.trangthai.Items.AddRange(new object[] {
            "Cho vay",
            "Nợ"});
            this.trangthai.Location = new System.Drawing.Point(131, 193);
            this.trangthai.Margin = new System.Windows.Forms.Padding(2);
            this.trangthai.Name = "trangthai";
            this.trangthai.Size = new System.Drawing.Size(145, 21);
            this.trangthai.TabIndex = 53;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(859, 650);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totaltien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDanhSachNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGhiNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ComboBox trangthai;
        private System.Windows.Forms.TextBox sotienno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ngaytra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ngayno;
        private System.Windows.Forms.TextBox tenkhoanno;
    }
}
