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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.income_clearBtn = new System.Windows.Forms.Button();
            this.income_deleteBtn = new System.Windows.Forms.Button();
            this.income_editBtn = new System.Windows.Forms.Button();
            this.income_addBtn = new System.Windows.Forms.Button();
            this.income_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.income_note = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.income_group = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.income_money = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.income_dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.income_dgv);
            this.panel1.Location = new System.Drawing.Point(15, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 359);
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
            this.income_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.income_dgv.Location = new System.Drawing.Point(14, 41);
            this.income_dgv.Name = "income_dgv";
            this.income_dgv.RowHeadersWidth = 51;
            this.income_dgv.Size = new System.Drawing.Size(802, 315);
            this.income_dgv.TabIndex = 0;
            this.income_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.income_dgv_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.income_clearBtn);
            this.panel2.Controls.Add(this.income_deleteBtn);
            this.panel2.Controls.Add(this.income_editBtn);
            this.panel2.Controls.Add(this.income_addBtn);
            this.panel2.Controls.Add(this.income_date);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.income_note);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.income_group);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.income_money);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 263);
            this.panel2.TabIndex = 2;
            // 
            // income_clearBtn
            // 
            this.income_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_clearBtn.FlatAppearance.BorderSize = 0;
            this.income_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_clearBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_clearBtn.ForeColor = System.Drawing.Color.White;
            this.income_clearBtn.Location = new System.Drawing.Point(642, 206);
            this.income_clearBtn.Name = "income_clearBtn";
            this.income_clearBtn.Size = new System.Drawing.Size(122, 40);
            this.income_clearBtn.TabIndex = 15;
            this.income_clearBtn.Text = "Xoá bảng";
            this.income_clearBtn.UseVisualStyleBackColor = false;
            this.income_clearBtn.Click += new System.EventHandler(this.income_clearBtn_Click);
            // 
            // income_deleteBtn
            // 
            this.income_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_deleteBtn.FlatAppearance.BorderSize = 0;
            this.income_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_deleteBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.income_deleteBtn.Location = new System.Drawing.Point(460, 206);
            this.income_deleteBtn.Name = "income_deleteBtn";
            this.income_deleteBtn.Size = new System.Drawing.Size(122, 40);
            this.income_deleteBtn.TabIndex = 14;
            this.income_deleteBtn.Text = "Xoá";
            this.income_deleteBtn.UseVisualStyleBackColor = false;
            this.income_deleteBtn.Click += new System.EventHandler(this.income_deleteBtn_Click);
            // 
            // income_editBtn
            // 
            this.income_editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_editBtn.FlatAppearance.BorderSize = 0;
            this.income_editBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_editBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_editBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_editBtn.ForeColor = System.Drawing.Color.White;
            this.income_editBtn.Location = new System.Drawing.Point(280, 206);
            this.income_editBtn.Name = "income_editBtn";
            this.income_editBtn.Size = new System.Drawing.Size(122, 40);
            this.income_editBtn.TabIndex = 13;
            this.income_editBtn.Text = "Sửa";
            this.income_editBtn.UseVisualStyleBackColor = false;
            this.income_editBtn.Click += new System.EventHandler(this.income_editBtn_Click);
            // 
            // income_addBtn
            // 
            this.income_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_addBtn.FlatAppearance.BorderSize = 0;
            this.income_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_addBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_addBtn.ForeColor = System.Drawing.Color.White;
            this.income_addBtn.Location = new System.Drawing.Point(98, 206);
            this.income_addBtn.Name = "income_addBtn";
            this.income_addBtn.Size = new System.Drawing.Size(122, 40);
            this.income_addBtn.TabIndex = 12;
            this.income_addBtn.Text = "Thêm";
            this.income_addBtn.UseVisualStyleBackColor = false;
            this.income_addBtn.Click += new System.EventHandler(this.income_addBtn_Click);
            // 
            // income_date
            // 
            this.income_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.income_date.Location = new System.Drawing.Point(499, 132);
            this.income_date.Name = "income_date";
            this.income_date.Size = new System.Drawing.Size(141, 26);
            this.income_date.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(403, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày tháng";
            // 
            // income_note
            // 
            this.income_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_note.Location = new System.Drawing.Point(499, 30);
            this.income_note.Multiline = true;
            this.income_note.Name = "income_note";
            this.income_note.Size = new System.Drawing.Size(300, 88);
            this.income_note.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ghi chú";
            // 
            // income_group
            // 
            this.income_group.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_group.FormattingEnabled = true;
            this.income_group.Items.AddRange(new object[] {
            "Lương",
            "Thu nhập khác",
            "Tiền chuyển đến",
            "Thu lãi",
            "Khoản thu chưa phân loại"});
            this.income_group.Location = new System.Drawing.Point(94, 131);
            this.income_group.Name = "income_group";
            this.income_group.Size = new System.Drawing.Size(245, 28);
            this.income_group.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhóm";
            // 
            // income_money
            // 
            this.income_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_money.Location = new System.Drawing.Point(94, 31);
            this.income_money.Name = "income_money";
            this.income_money.Size = new System.Drawing.Size(245, 38);
            this.income_money.TabIndex = 2;
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
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView income_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox income_money;
        private System.Windows.Forms.ComboBox income_group;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox income_note;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker income_date;
        private System.Windows.Forms.Button income_clearBtn;
        private System.Windows.Forms.Button income_deleteBtn;
        private System.Windows.Forms.Button income_editBtn;
        private System.Windows.Forms.Button income_addBtn;
    }
}
