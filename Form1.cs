using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace foodcalc
{
	public partial class Form1 : Form
	{
		public class Food
		{
			String name;
			int weight;
			public Food() {  }

			public  Food(String name)
			{
				this.name = name;
			}
		}

		private Food mFood = new Food("apple");

		public Form1()
		{
			InitializeComponent();
		}

		private void btn_day1_Click(object sender, EventArgs e)
		{
			Debug.Write("btn_day1 clicked");
			label_day.Text = "第一天";
		
		}

		private void textBox_num_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btn_day2_Click(object sender, EventArgs e)
		{
			label_day.Text = "第二天";
		}

		private void btn_day3_Click(object sender, EventArgs e)
		{
			label_day.Text = "第三天";
		}

		private void btn_calc_Click(object sender, EventArgs e)
		{
			if (textBox_num.Text == String.Empty)
			{
				MessageBox.Show("编号不能为空");
				textBox_num.Focus();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
