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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("食物名称");
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("重量");
			this.btn_day1 = new System.Windows.Forms.Button();
			this.btn_next = new System.Windows.Forms.Button();
			this.btn_calc = new System.Windows.Forms.Button();
			this.btn_day2 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.label_num = new System.Windows.Forms.Label();
			this.textBox_num = new System.Windows.Forms.TextBox();
			this.btn_day3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_day1
			// 
			this.btn_day1.Location = new System.Drawing.Point(49, 157);
			this.btn_day1.Name = "btn_day1";
			this.btn_day1.Size = new System.Drawing.Size(75, 23);
			this.btn_day1.TabIndex = 0;
			this.btn_day1.Text = "第一天";
			this.btn_day1.UseVisualStyleBackColor = true;
			this.btn_day1.Click += new System.EventHandler(this.btn_day1_Click);
			// 
			// btn_next
			// 
			this.btn_next.Location = new System.Drawing.Point(911, 479);
			this.btn_next.Name = "btn_next";
			this.btn_next.Size = new System.Drawing.Size(75, 23);
			this.btn_next.TabIndex = 1;
			this.btn_next.Text = "下一个";
			this.btn_next.UseVisualStyleBackColor = true;
			// 
			// btn_calc
			// 
			this.btn_calc.Location = new System.Drawing.Point(669, 479);
			this.btn_calc.Name = "btn_calc";
			this.btn_calc.Size = new System.Drawing.Size(75, 23);
			this.btn_calc.TabIndex = 2;
			this.btn_calc.Text = "计算";
			this.btn_calc.UseVisualStyleBackColor = true;
			// 
			// btn_day2
			// 
			this.btn_day2.Location = new System.Drawing.Point(143, 157);
			this.btn_day2.Name = "btn_day2";
			this.btn_day2.Size = new System.Drawing.Size(75, 23);
			this.btn_day2.TabIndex = 4;
			this.btn_day2.Text = "第二天";
			this.btn_day2.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
			this.listView1.Location = new System.Drawing.Point(669, 84);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(381, 370);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// label_num
			// 
			this.label_num.AutoSize = true;
			this.label_num.Location = new System.Drawing.Point(47, 84);
			this.label_num.Name = "label_num";
			this.label_num.Size = new System.Drawing.Size(29, 12);
			this.label_num.TabIndex = 6;
			this.label_num.Text = "编号";
			// 
			// textBox_num
			// 
			this.textBox_num.Location = new System.Drawing.Point(105, 81);
			this.textBox_num.Name = "textBox_num";
			this.textBox_num.Size = new System.Drawing.Size(100, 21);
			this.textBox_num.TabIndex = 7;
			this.textBox_num.TextChanged += new System.EventHandler(this.textBox_num_TextChanged);
			// 
			// btn_day3
			// 
			this.btn_day3.Location = new System.Drawing.Point(234, 157);
			this.btn_day3.Name = "btn_day3";
			this.btn_day3.Size = new System.Drawing.Size(75, 23);
			this.btn_day3.TabIndex = 8;
			this.btn_day3.Text = "第三天";
			this.btn_day3.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1160, 611);
			this.Controls.Add(this.btn_day3);
			this.Controls.Add(this.textBox_num);
			this.Controls.Add(this.label_num);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btn_day2);
			this.Controls.Add(this.btn_calc);
			this.Controls.Add(this.btn_next);
			this.Controls.Add(this.btn_day1);
			this.Name = "Form1";
			this.Text = "Form1";
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
	}
}

