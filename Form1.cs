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
			if (textBox_num.Text == String.Empty)
			{
				MessageBox.Show("信息禁止为空");
				textBox_num.Focus();
			}
		}

		private void textBox_num_TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
