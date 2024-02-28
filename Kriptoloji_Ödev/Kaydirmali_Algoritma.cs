using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kriptoloji_Ödev
{
	public partial class Kaydirmali_Algoritma : Form
	{
		public Kaydirmali_Algoritma()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			int anahtar = 0;
			string kelime = "";
			anahtar = Convert.ToInt32(textBox3.Text);
			kelime = textBox1.Text;
			char[] harfler = kelime.ToCharArray();
			foreach (char harf in harfler)
			{
				textBox2.Text += Convert.ToChar(harf + anahtar).ToString();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int anahtar = 0;
			string sifre = "";
			anahtar = Convert.ToInt32(textBox3.Text);
			sifre = textBox2.Text;
			char[] harfler = sifre.ToCharArray();
			foreach (char harf in harfler)
			{
				string a = Convert.ToChar(harf - anahtar).ToString();
				textBox1.Text += a;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
			this.Hide();
		}
	}
}
