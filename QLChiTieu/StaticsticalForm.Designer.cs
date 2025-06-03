namespace QLChiTieu
{
    partial class StaticsticalForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Staticstical_Header = new System.Windows.Forms.Label();
            this.staticstical_TextBox_Note = new System.Windows.Forms.TextBox();
            this.staticstical_labelNote = new System.Windows.Forms.Label();
            this.staticstical_btnFilter = new System.Windows.Forms.Button();
            this.staticstical_TextBox_To = new System.Windows.Forms.TextBox();
            this.staticstical_labelMoney_To = new System.Windows.Forms.Label();
            this.staticstical_TextBox_From = new System.Windows.Forms.TextBox();
            this.staticstical_labelMoney_From = new System.Windows.Forms.Label();
            this.staticstical_labelMoney = new System.Windows.Forms.Label();
            this.staticstical_ComboBox_Type = new System.Windows.Forms.ComboBox();
            this.staticstical_labelType = new System.Windows.Forms.Label();
            this.staticstical_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.staticstical_labelTime = new System.Windows.Forms.Label();
            this.staticstical_ComboBox_Category = new System.Windows.Forms.ComboBox();
            this.staticstical_labelCategory = new System.Windows.Forms.Label();
            this.staticstical_dgv = new System.Windows.Forms.DataGridView();
            this.staticstical_labelList = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioBtn_Enable = new System.Windows.Forms.RadioButton();
            this.radioBtn_Disable = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staticstical_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.Staticstical_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 59);
            this.panel1.TabIndex = 0;
            // 
            // Staticstical_Header
            // 
            this.Staticstical_Header.AutoSize = true;
            this.Staticstical_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staticstical_Header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Staticstical_Header.Location = new System.Drawing.Point(14, 12);
            this.Staticstical_Header.Name = "Staticstical_Header";
            this.Staticstical_Header.Size = new System.Drawing.Size(239, 32);
            this.Staticstical_Header.TabIndex = 0;
            this.Staticstical_Header.Text = "Thống kê thu chi";
            // 
            // staticstical_TextBox_Note
            // 
            this.staticstical_TextBox_Note.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staticstical_TextBox_Note.Location = new System.Drawing.Point(137, 376);
            this.staticstical_TextBox_Note.Name = "staticstical_TextBox_Note";
            this.staticstical_TextBox_Note.Size = new System.Drawing.Size(375, 26);
            this.staticstical_TextBox_Note.TabIndex = 31;
            // 
            // staticstical_labelNote
            // 
            this.staticstical_labelNote.AutoSize = true;
            this.staticstical_labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticstical_labelNote.Location = new System.Drawing.Point(19, 375);
            this.staticstical_labelNote.Name = "staticstical_labelNote";
            this.staticstical_labelNote.Size = new System.Drawing.Size(85, 25);
            this.staticstical_labelNote.TabIndex = 30;
            this.staticstical_labelNote.Text = "Ghi chú:";
            // 
            // staticstical_btnFilter
            // 
            this.staticstical_btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.staticstical_btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.staticstical_btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staticstical_btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticstical_btnFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.staticstical_btnFilter.Location = new System.Drawing.Point(571, 186);
            this.staticstical_btnFilter.Name = "staticstical_btnFilter";
            this.staticstical_btnFilter.Size = new System.Drawing.Size(175, 71);
            this.staticstical_btnFilter.TabIndex = 28;
            this.staticstical_btnFilter.Text = "Lọc dữ liệu";
            this.staticstical_btnFilter.UseVisualStyleBackColor = false;
            this.staticstical_btnFilter.Click += new System.EventHandler(this.staticstical_btnFilter_Click);
            // 
            // staticstical_TextBox_To
            // 
            this.staticstical_TextBox_To.Location = new System.Drawing.Point(367, 330);
            this.staticstical_TextBox_To.Name = "staticstical_TextBox_To";
            this.staticstical_TextBox_To.Size = new System.Drawing.Size(145, 26);
            this.staticstical_TextBox_To.TabIndex = 27;
            // 
            // staticstical_labelMoney_To
            // 
            this.staticstical_labelMoney_To.AutoSize = true;
            this.staticstical_labelMoney_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticstical_labelMoney_To.Location = new System.Drawing.Point(321, 330);
            this.staticstical_labelMoney_To.Name = "staticstical_labelMoney_To";
            this.staticstical_labelMoney_To.Size = new System.Drawing.Size(48, 22);
            this.staticstical_labelMoney_To.TabIndex = 26;
            this.staticstical_labelMoney_To.Text = "Đến:";
            // 
            // staticstical_TextBox_From
            // 
            this.staticstical_TextBox_From.Location = new System.Drawing.Point(170, 329);
            this.staticstical_TextBox_From.Name = "staticstical_TextBox_From";
            this.staticstical_TextBox_From.Size = new System.Drawing.Size(145, 26);
            this.staticstical_TextBox_From.TabIndex = 25;
            // 
            // staticstical_labelMoney_From
            // 
            this.staticstical_labelMoney_From.AutoSize = true;
            this.staticstical_labelMoney_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticstical_labelMoney_From.Location = new System.Drawing.Point(136, 330);
            this.staticstical_labelMoney_From.Name = "staticstical_labelMoney_From";
            this.staticstical_labelMoney_From.Size = new System.Drawing.Size(37, 22);
            this.staticstical_labelMoney_From.TabIndex = 24;
            this.staticstical_labelMoney_From.Text = "Từ:";
            // 
            // staticstical_labelMoney
            // 
            this.staticstical_labelMoney.AutoSize = true;
            this.staticstical_labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticstical_labelMoney.Location = new System.Drawing.Point(19, 327);
            this.staticstical_labelMoney.Name = "staticstical_labelMoney";
            this.staticstical_labelMoney.Size = new System.Drawing.Size(92, 25);
            this.staticstical_labelMoney.TabIndex = 23;
            this.staticstical_labelMoney.Text = "Mức tiền:";
            // 
            // staticstical_ComboBox_Type
            // 
            this.staticstical_ComboBox_Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staticstical_ComboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staticstical_ComboBox_Type.FormattingEnabled = true;
            this.staticstical_ComboBox_Type.Items.AddRange(new object[] {
            "Thu",
            "Chi",
            "(None)"});
            this.staticstical_ComboBox_Type.Location = new System.Drawing.Point(137, 105);
            this.staticstical_ComboBox_Type.Name = "staticstical_ComboBox_Type";
            this.staticstical_ComboBox_Type.Size = new System.Drawing.Size(375, 28);
            this.staticstical_ComboBox_Type.TabIndex = 22;
            // 
            // staticstical_labelType
            // 
            this.staticstical_labelType.AutoSize = true;
            this.staticstical_labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticstical_labelType.Location = new System.Drawing.Point(44, 104);
            this.staticstical_labelType.Name = "staticstical_labelType";
            this.staticstical_labelType.Size = new System.Drawing.Size(60, 25);
            this.staticstical_labelType.TabIndex = 21;
            this.staticstical_labelType.Text = " Loại:";
            // 
            // staticstical_DateTimePicker
            // 
            this.staticstical_DateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staticstical_DateTimePicker.Enabled = false;
            this.staticstical_DateTimePicker.Location = new System.Drawing.Point(24, 208);
            this.staticstical_DateTimePicker.Name = "staticstical_DateTimePicker";
            this.staticstical_DateTimePicker.Size = new System.Drawing.Size(488, 26);
            this.staticstical_DateTimePicker.TabIndex = 20;
            // 
            // staticstical_labelTime
            // 
            this.staticstical_labelTime.AutoSize = true;
            this.staticstical_labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticstical_labelTime.Location = new System.Drawing.Point(19, 158);
            this.staticstical_labelTime.Name = "staticstical_labelTime";
            this.staticstical_labelTime.Size = new System.Drawing.Size(104, 25);
            this.staticstical_labelTime.TabIndex = 19;
            this.staticstical_labelTime.Text = "Thời gian: ";
            // 
            // staticstical_ComboBox_Category
            // 
            this.staticstical_ComboBox_Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staticstical_ComboBox_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staticstical_ComboBox_Category.FormattingEnabled = true;
            this.staticstical_ComboBox_Category.Items.AddRange(new object[] {
            "Lương",
            "Thu nhập khác",
            "Tiền chuyển đến",
            "Thu lãi",
            "Khoản thu chưa phân loại",
            "Ăn uống",
            "Sinh hoạt",
            "Đóng quỹ",
            "Phí phát sinh",
            "Học phí",
            "Bảo hiểm",
            "Y tế",
            "(None)"});
            this.staticstical_ComboBox_Category.Location = new System.Drawing.Point(137, 279);
            this.staticstical_ComboBox_Category.Name = "staticstical_ComboBox_Category";
            this.staticstical_ComboBox_Category.Size = new System.Drawing.Size(375, 28);
            this.staticstical_ComboBox_Category.TabIndex = 18;
            // 
            // staticstical_labelCategory
            // 
            this.staticstical_labelCategory.AutoSize = true;
            this.staticstical_labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticstical_labelCategory.Location = new System.Drawing.Point(19, 278);
            this.staticstical_labelCategory.Name = "staticstical_labelCategory";
            this.staticstical_labelCategory.Size = new System.Drawing.Size(112, 25);
            this.staticstical_labelCategory.TabIndex = 17;
            this.staticstical_labelCategory.Text = "Danh mục: ";
            // 
            // staticstical_dgv
            // 
            this.staticstical_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staticstical_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staticstical_dgv.Location = new System.Drawing.Point(3, 522);
            this.staticstical_dgv.Name = "staticstical_dgv";
            this.staticstical_dgv.RowHeadersWidth = 62;
            this.staticstical_dgv.RowTemplate.Height = 28;
            this.staticstical_dgv.Size = new System.Drawing.Size(1276, 465);
            this.staticstical_dgv.TabIndex = 32;
            // 
            // staticstical_labelList
            // 
            this.staticstical_labelList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.staticstical_labelList.AutoSize = true;
            this.staticstical_labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticstical_labelList.Location = new System.Drawing.Point(528, 466);
            this.staticstical_labelList.Name = "staticstical_labelList";
            this.staticstical_labelList.Size = new System.Drawing.Size(233, 25);
            this.staticstical_labelList.TabIndex = 33;
            this.staticstical_labelList.Text = "DANH SÁCH THU/CHI";
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(785, 79);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Chart";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(481, 344);
            this.chart.TabIndex = 34;
            this.chart.Text = "Biểu đồ";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.Red;
            title2.Name = "Title1";
            title2.Text = "Biểu đồ thống kê";
            this.chart.Titles.Add(title2);
            // 
            // radioBtn_Enable
            // 
            this.radioBtn_Enable.AutoSize = true;
            this.radioBtn_Enable.Location = new System.Drawing.Point(130, 158);
            this.radioBtn_Enable.Name = "radioBtn_Enable";
            this.radioBtn_Enable.Size = new System.Drawing.Size(84, 24);
            this.radioBtn_Enable.TabIndex = 35;
            this.radioBtn_Enable.Text = "Enable";
            this.radioBtn_Enable.UseVisualStyleBackColor = true;
            this.radioBtn_Enable.CheckedChanged += new System.EventHandler(this.radioBtn_Enable_CheckedChanged);
            // 
            // radioBtn_Disable
            // 
            this.radioBtn_Disable.AutoSize = true;
            this.radioBtn_Disable.Checked = true;
            this.radioBtn_Disable.Location = new System.Drawing.Point(275, 158);
            this.radioBtn_Disable.Name = "radioBtn_Disable";
            this.radioBtn_Disable.Size = new System.Drawing.Size(87, 24);
            this.radioBtn_Disable.TabIndex = 36;
            this.radioBtn_Disable.TabStop = true;
            this.radioBtn_Disable.Text = "Disable";
            this.radioBtn_Disable.UseVisualStyleBackColor = true;
            this.radioBtn_Disable.CheckedChanged += new System.EventHandler(this.radioBtn_Disable_CheckedChanged);
            // 
            // StaticsticalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioBtn_Disable);
            this.Controls.Add(this.radioBtn_Enable);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.staticstical_labelList);
            this.Controls.Add(this.staticstical_dgv);
            this.Controls.Add(this.staticstical_TextBox_Note);
            this.Controls.Add(this.staticstical_labelNote);
            this.Controls.Add(this.staticstical_btnFilter);
            this.Controls.Add(this.staticstical_TextBox_To);
            this.Controls.Add(this.staticstical_labelMoney_To);
            this.Controls.Add(this.staticstical_TextBox_From);
            this.Controls.Add(this.staticstical_labelMoney_From);
            this.Controls.Add(this.staticstical_labelMoney);
            this.Controls.Add(this.staticstical_ComboBox_Type);
            this.Controls.Add(this.staticstical_labelType);
            this.Controls.Add(this.staticstical_DateTimePicker);
            this.Controls.Add(this.staticstical_labelTime);
            this.Controls.Add(this.staticstical_ComboBox_Category);
            this.Controls.Add(this.staticstical_labelCategory);
            this.Controls.Add(this.panel1);
            this.Name = "StaticsticalForm";
            this.Size = new System.Drawing.Size(1288, 1000);
            this.Load += new System.EventHandler(this.StaticsticalForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staticstical_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Staticstical_Header;
        private System.Windows.Forms.TextBox staticstical_TextBox_Note;
        private System.Windows.Forms.Label staticstical_labelNote;
        private System.Windows.Forms.Button staticstical_btnFilter;
        private System.Windows.Forms.TextBox staticstical_TextBox_To;
        private System.Windows.Forms.Label staticstical_labelMoney_To;
        private System.Windows.Forms.TextBox staticstical_TextBox_From;
        private System.Windows.Forms.Label staticstical_labelMoney_From;
        private System.Windows.Forms.Label staticstical_labelMoney;
        private System.Windows.Forms.ComboBox staticstical_ComboBox_Type;
        private System.Windows.Forms.Label staticstical_labelType;
        private System.Windows.Forms.DateTimePicker staticstical_DateTimePicker;
        private System.Windows.Forms.Label staticstical_labelTime;
        private System.Windows.Forms.ComboBox staticstical_ComboBox_Category;
        private System.Windows.Forms.Label staticstical_labelCategory;
        private System.Windows.Forms.DataGridView staticstical_dgv;
        private System.Windows.Forms.Label staticstical_labelList;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.RadioButton radioBtn_Enable;
        private System.Windows.Forms.RadioButton radioBtn_Disable;
    }
}
