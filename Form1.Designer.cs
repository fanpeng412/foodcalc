namespace foodcalc
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("鸽子（带皮）");
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("鸽子（不带皮）");
			this.btn_day1 = new System.Windows.Forms.Button();
			this.btn_next = new System.Windows.Forms.Button();
			this.btn_calc = new System.Windows.Forms.Button();
			this.btn_day2 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label_num = new System.Windows.Forms.Label();
			this.textBox_num = new System.Windows.Forms.TextBox();
			this.btn_day3 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.DataGridcolumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridColumWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label_day = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_day1
			// 
			this.btn_day1.Location = new System.Drawing.Point(49, 63);
			this.btn_day1.Name = "btn_day1";
			this.btn_day1.Size = new System.Drawing.Size(75, 23);
			this.btn_day1.TabIndex = 0;
			this.btn_day1.Text = "第一天";
			this.btn_day1.UseVisualStyleBackColor = true;
			this.btn_day1.Click += new System.EventHandler(this.btn_day1_Click);
			// 
			// btn_next
			// 
			this.btn_next.Location = new System.Drawing.Point(837, 495);
			this.btn_next.Name = "btn_next";
			this.btn_next.Size = new System.Drawing.Size(75, 23);
			this.btn_next.TabIndex = 1;
			this.btn_next.Text = " 下一个";
			this.btn_next.UseVisualStyleBackColor = true;
			// 
			// btn_calc
			// 
			this.btn_calc.Location = new System.Drawing.Point(546, 495);
			this.btn_calc.Name = "btn_calc";
			this.btn_calc.Size = new System.Drawing.Size(75, 23);
			this.btn_calc.TabIndex = 2;
			this.btn_calc.Text = "计算";
			this.btn_calc.UseVisualStyleBackColor = true;
			this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
			// 
			// btn_day2
			// 
			this.btn_day2.Location = new System.Drawing.Point(131, 63);
			this.btn_day2.Name = "btn_day2";
			this.btn_day2.Size = new System.Drawing.Size(75, 23);
			this.btn_day2.TabIndex = 4;
			this.btn_day2.Text = "第二天";
			this.btn_day2.UseVisualStyleBackColor = true;
			this.btn_day2.Click += new System.EventHandler(this.btn_day2_Click);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnWeight,
            this.columnHeader1});
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
			this.listView1.Location = new System.Drawing.Point(49, 214);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(362, 315);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// columnName
			// 
			this.columnName.Text = "食物名称";
			this.columnName.Width = 120;
			// 
			// columnWeight
			// 
			this.columnWeight.Text = "DHA含量";
			this.columnWeight.Width = 120;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "EHA含量";
			this.columnHeader1.Width = 120;
			// 
			// label_num
			// 
			this.label_num.AutoSize = true;
			this.label_num.Location = new System.Drawing.Point(47, 24);
			this.label_num.Name = "label_num";
			this.label_num.Size = new System.Drawing.Size(29, 12);
			this.label_num.TabIndex = 6;
			this.label_num.Text = "编号";
			// 
			// textBox_num
			// 
			this.textBox_num.Location = new System.Drawing.Point(106, 24);
			this.textBox_num.Name = "textBox_num";
			this.textBox_num.Size = new System.Drawing.Size(100, 21);
			this.textBox_num.TabIndex = 7;
			this.textBox_num.TextChanged += new System.EventHandler(this.textBox_num_TextChanged);
			// 
			// btn_day3
			// 
			this.btn_day3.Location = new System.Drawing.Point(212, 63);
			this.btn_day3.Name = "btn_day3";
			this.btn_day3.Size = new System.Drawing.Size(75, 23);
			this.btn_day3.TabIndex = 8;
			this.btn_day3.Text = "第三天";
			this.btn_day3.UseVisualStyleBackColor = true;
			this.btn_day3.Click += new System.EventHandler(this.btn_day3_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridcolumName,
            this.DataGridColumWeight});
			this.dataGridView1.Location = new System.Drawing.Point(546, 63);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(246, 405);
			this.dataGridView1.TabIndex = 9;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// DataGridcolumName
			// 
			this.DataGridcolumName.HeaderText = "食物名称";
			this.DataGridcolumName.Name = "DataGridcolumName";
			// 
			// DataGridColumWeight
			// 
			this.DataGridColumWeight.HeaderText = "重量(g)";
			this.DataGridColumWeight.Name = "DataGridColumWeight";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(106, 174);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 21);
			this.textBox1.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 179);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 11;
			this.label1.Text = "食品查询";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(224, 174);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "查询";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label_day
			// 
			this.label_day.AutoSize = true;
			this.label_day.Location = new System.Drawing.Point(544, 46);
			this.label_day.Name = "label_day";
			this.label_day.Size = new System.Drawing.Size(29, 12);
			this.label_day.TabIndex = 13;
			this.label_day.Text = "日期";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(49, 116);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(122, 23);
			this.button2.TabIndex = 14;
			this.button2.Text = "导入参考文件";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(188, 116);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(122, 23);
			this.button3.TabIndex = 15;
			this.button3.Text = "导入单独计算文件";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(544, 536);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 12);
			this.label3.TabIndex = 18;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1});
			this.dataGridView2.Location = new System.Drawing.Point(824, 63);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowTemplate.Height = 23;
			this.dataGridView2.Size = new System.Drawing.Size(367, 405);
			this.dataGridView2.TabIndex = 19;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "食物名称";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "食物(g)";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// Column1
			// 
			this.Column1.HeaderText = "食用频率（次/月）";
			this.Column1.Name = "Column1";
			this.Column1.Width = 150;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(544, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 12);
			this.label4.TabIndex = 20;
			this.label4.Text = "24小时膳食回顾法";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(822, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 12);
			this.label2.TabIndex = 21;
			this.label2.Text = "FFQ";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(335, 116);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(143, 23);
			this.button4.TabIndex = 22;
			this.button4.Text = "批量导入计算文件";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(549, 283);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label_day);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_day3);
			this.Controls.Add(this.textBox_num);
			this.Controls.Add(this.label_num);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btn_day2);
			this.Controls.Add(this.btn_calc);
			this.Controls.Add(this.btn_next);
			this.Controls.Add(this.btn_day1);
			this.Name = "Form1";
			this.Text = "膳食ω-3脂肪酸摄入量计算器";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_day1;
		private System.Windows.Forms.Button btn_next;
		private System.Windows.Forms.Button btn_calc;
		private System.Windows.Forms.Button btn_day2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label label_num;
		private System.Windows.Forms.TextBox textBox_num;
		private System.Windows.Forms.Button btn_day3;
		private System.Windows.Forms.ColumnHeader columnName;
		private System.Windows.Forms.ColumnHeader columnWeight;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label_day;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataGridcolumName;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumWeight;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button4;
	}
}

