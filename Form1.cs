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
		public Food[] foods;
		
		public class Food
		{
			public String name;
			public int weight;
			public int a;
			public int b;
			public Food() {
				this.name = null;
				this.a = 1;
				this.b = 2;
			}

			public  Food(String name)
			{
				this.name = name;
			}

			public void setName(String name)
			{
				this.name = name;
			}

			public void seta(int a)
			{
				this.a = a;
			}

			public void setb(int b)
			{
				this.b = b;
			}
		}

		private Food mFood = new Food("apple");

		public Form1()
		{
			InitializeComponent();
			foods = new Food[100];
			for(int i = 0; i < 99; i++)
			{
				foods[i] = new Food();
				foods[i].name="橘子";
				foods[i].seta(3);
				foods[i].setb(4);
			}
			foods[99] = new Food();
			foods[99].setName("苹果");
			foods[99].seta(7);
			foods[99].setb(8);
			int count = 0;

			Debug.Write("t1: " + new DateTime().Millisecond);
			for(int j = 0; j<100; j++)
			{
				for (int i = 0; i < 100; i++)
				{
					if (foods[i].name == "苹果")
					{
						count += foods[i].a + foods[i].b;
						break;
					}
				}
			}
			Debug.Write("count :" + count);
			Debug.Write("t2 " + new DateTime().Millisecond);
			
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
