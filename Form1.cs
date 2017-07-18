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
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;


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

		private void button3_Click(object sender, EventArgs e)
		{
			ToExcel("方式3");
		}

		private void OpenExcel(string strFileName)
		{
			object missing = System.Reflection.Missing.Value;
			Excel.Application excel = new Excel.ApplicationClass();//lauch excel application
			if (excel == null)
			{
				this.label1.Text = "Can't access excel";
			}
			else
			{
				excel.Visible = false; excel.UserControl = true;
				// 以只读的形式打开EXCEL文件
				Excel.Workbook wb = excel.Application.Workbooks.Open(strFileName, missing, true, missing, missing, missing,
				 missing, missing, missing, true, missing, missing, missing, missing, missing);
				//取得第一个工作薄
				Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets.get_Item(1);
				//取得总记录行数    (包括标题列)
				int rowsint = ws.UsedRange.Cells.Rows.Count; //得到行数
															 //int columnsint = mySheet.UsedRange.Cells.Columns.Count;//得到列数
															 //取得数据范围区域   (不包括标题列)  
				Excel.Range rng1 = ws.Cells.get_Range("A2", "A" + rowsint);
				Excel.Range rng2 = ws.Cells.get_Range("B2", "B" + rowsint);
				Excel.Range rng3 = ws.Cells.get_Range("C2", "C" + rowsint);
				Excel.Range rng4 = ws.Cells.get_Range("D2", "D" + rowsint);
				object[,] arry1 = (object[,])rng1.Value2;   //get range's value
				object[,] arry2 = (object[,])rng2.Value2;
				object[,] arry3 = (object[,])rng3.Value2;   //get range's value
				object[,] arry4 = (object[,])rng4.Value2;
				//将新值赋给一个数组
				string[,] arry = new string[rowsint - 1, 4];
				//for (int i = 1; i <= rowsint - 1; i++)
				for (int i = 1; i <= rowsint - 2; i++)
				{

					arry[i - 1, 0] = arry1[i, 1].ToString();

					arry[i - 1, 1] = arry2[i, 1].ToString();

					arry[i - 1, 2] = arry3[i, 1].ToString();

					arry[i - 1, 3] = arry4[i, 1].ToString();
				}
				string a = "";
				for (int i = 0; i <= rowsint - 3; i++)
				{
					a += arry[i, 0] + "|" + arry[i, 1] + "|" + arry[i, 2] + "|" + arry[i, 3] + "\n";

				}
				this.label1.Text = a;
			}
			excel.Quit(); excel = null;
			Process[] procs = Process.GetProcessesByName("excel");
			foreach (Process pro in procs)
			{
				pro.Kill();//没有更好的方法,只有杀掉进程
			}
			GC.Collect();
		}

		public void ToExcel(string strTitle)
		{
			int nMax = 9;
			int nMin = 4;

			int rowCount = nMax - nMin + 1;//总行数

			const int columnCount = 4;//总列数



			//创建Excel对象

			Excel.Application excelApp = new Excel.ApplicationClass();



			//新建工作簿

			Excel.Workbook workBook = excelApp.Workbooks.Add(true);



			//新建工作表

			Excel.Worksheet worksheet = workBook.ActiveSheet as Excel.Worksheet;



			////设置标题

			//Excel.Range titleRange = worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[1, columnCount]);//选取单元格

			//titleRange.Merge(true);//合并单元格

			//titleRange.Value2 = strTitle; //设置单元格内文本

			//titleRange.Font.Name = "宋体";//设置字体

			//titleRange.Font.Size = 18;//字体大小

			//titleRange.Font.Bold = false;//加粗显示

			//titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;//水平居中

			//titleRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;//垂直居中

			//titleRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;//设置边框

			//titleRange.Borders.Weight = Excel.XlBorderWeight.xlThin;//边框常规粗细



			//设置表头

			string[] strHead = new string[columnCount] { "序号", "范围", "分组1", "分组2" };

			int[] columnWidth = new int[4] { 8, 16, 8, 10 };

			for (int i = 0; i < columnCount; i++)
			{

				//Excel.Range headRange = worksheet.Cells[2, i + 1] as Excel.Range;//获取表头单元格

				Excel.Range headRange = worksheet.Cells[1, i + 1] as Excel.Range;//获取表头单元格,不用标题则从1开始

				headRange.Value2 = strHead[i];//设置单元格文本

				headRange.Font.Name = "宋体";//设置字体

				headRange.Font.Size = 12;//字体大小

				headRange.Font.Bold = false;//加粗显示

				headRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;//水平居中

				headRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;//垂直居中

				headRange.ColumnWidth = columnWidth[i];//设置列宽

				//  headRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;//设置边框

				// headRange.Borders.Weight = Excel.XlBorderWeight.xlThin;//边框常规粗细

			}



			//设置每列格式

			for (int i = 0; i < columnCount; i++)
			{

				//Excel.Range contentRange = worksheet.get_Range(worksheet.Cells[3, i + 1], worksheet.Cells[rowCount - 1 + 3, i + 1]);

				Excel.Range contentRange = worksheet.get_Range(worksheet.Cells[2, i + 1], worksheet.Cells[rowCount - 1 + 3, i + 1]);//不用标题则从第二行开始

				contentRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;//水平居中

				contentRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;//垂直居中

				//contentRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;//设置边框

				// contentRange.Borders.Weight = Excel.XlBorderWeight.xlThin;//边框常规粗细

				contentRange.WrapText = true;//自动换行

				contentRange.NumberFormatLocal = "@";//文本格式

			}



			//填充数据

			for (int i = nMin; i <= nMax; i++)
			{

				int k = i - nMin;

				//excelApp.Cells[k + 3, 1] = string.Format("{0}", k + 1);

				//excelApp.Cells[k + 3, 2] = string.Format("{0}-{1}", i - 0.5, i + 0.5);

				//excelApp.Cells[k + 3, 3] = string.Format("{0}", k + 3);

				//excelApp.Cells[k + 3, 4] = string.Format("{0}", k + 4);

				excelApp.Cells[k + 2, 1] = string.Format("{0}", k + 1);

				excelApp.Cells[k + 2, 2] = string.Format("{0}-{1}", i - 0.5, i + 0.5);

				excelApp.Cells[k + 2, 3] = string.Format("{0}", k + 3);

				excelApp.Cells[k + 2, 4] = string.Format("{0}", k + 4);

			}



			//设置Excel可见

			excelApp.Visible = true;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			OpenExcel("testfile");
		}
	}
}
