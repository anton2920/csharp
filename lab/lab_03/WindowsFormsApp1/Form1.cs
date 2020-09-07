using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			textBox1.Text = "";
			for (int i = 1; i <= numericUpDown1.Value; ++i)
			{
				textBox1.Text += i + " ";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			comboBox1.Items.Add(textBox2.Text);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			comboBox1.Items.Clear();
			textBox3.Text = "Will show there...";
			comboBox1.Text = "Items...";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBox3.Text = comboBox1.SelectedItem.ToString();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (textBox4.Text != "" && textBox5.Text != "")
			{
				var snd = Double.Parse(textBox5.Text);
				if (snd != 0)
				{
					var res = Double.Parse(textBox4.Text) / snd;
					textBox6.Text = res.ToString();
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (textBox4.Text != "" && textBox5.Text != "")
			{
				var res = Double.Parse(textBox4.Text) + Double.Parse(textBox5.Text);
				textBox6.Text = res.ToString();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (textBox4.Text != "" && textBox5.Text != "")
			{
				var res = Double.Parse(textBox4.Text) - Double.Parse(textBox5.Text);
				textBox6.Text = res.ToString();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (textBox4.Text != "" && textBox5.Text != "")
			{
				var res = Double.Parse(textBox4.Text) * Double.Parse(textBox5.Text);
				textBox6.Text = res.ToString();
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			comboBox2.Items.Clear();
			foreach (string line in textBox7.Lines)
			{
				double res;
				var ok = Double.TryParse(line, out res);

				if (ok)
				{
					comboBox2.Items.Add(res.ToString());
				}
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			textBox8.Text = "";
			decimal sum = 0M, prev, curr;

			for (long x = 1; true; )
			{
				prev = 1M / x++;
				sum += prev;
				textBox8.AppendText(sum.ToString() + Environment.NewLine);

				curr = 1M / x++;
				sum += curr;
				textBox8.AppendText(sum.ToString() + Environment.NewLine);

				if (Math.Abs(prev - curr) < numericUpDown2.Value)
				{
					break;
				}
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			textBox10.Clear();
			foreach (string line in textBox9.Lines.Reverse<string>())
			{
				double res;
				var ok = Double.TryParse(line, out res);

				if (!ok)
				{
					textBox10.AppendText(line + Environment.NewLine);
				}
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			double a = Double.Parse(textBox11.Text), b = Double.Parse(textBox12.Text),
				h = Double.Parse(textBox13.Text);
			double res;

			for (double x = a; x <= b; x += h)
			{
				res = Math.Sin(x) / (Math.Abs(x) + 1);
				textBox14.AppendText("x = " + x.ToString() + ";\tf(x) = " + res.ToString() +
					Environment.NewLine);
			}
		}
	}
}
