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
	public partial class Sezar_Algoritma : Form
	{
		public Sezar_Algoritma()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
			string kelime = "";
			kelime = textBox1.Text.ToUpper();
			string şifreliMetin = "";
			int k;
			string z;
			for (int i = 0; i < kelime.Length; i++)
			{
				if (alfabe.IndexOf(kelime[i]) == -1)
				{
					şifreliMetin += kelime[i].ToString();
				}
				else
				{

					k = alfabe.IndexOf(kelime[i]);
					if (k+3 > 29)
					{
						int a = k + 3;
						int b = a-29;
						z = alfabe[b].ToString();
					}
					else
					{
						z = alfabe[k + 3].ToString();
					}
					
					şifreliMetin += z;
				}
			}

			textBox2.Text = şifreliMetin;
			//string kelime = "";
			//kelime = textBox1.Text;
			//char[] harfler = kelime.ToCharArray();
			//foreach (char harf in harfler)
			//{
			//	textBox2.Text += Convert.ToChar(harf + 3).ToString();
			//}

		}


		private void button2_Click_1(object sender, EventArgs e)
		{
			string alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
			string şifreliMetin = "";
			şifreliMetin = textBox2.Text.ToUpper();
			string kelime = "";
			int k;
			string z;
			for (int i = 0; i < şifreliMetin.Length; i++)
			{
				if (alfabe.IndexOf(şifreliMetin[i]) == -1)
				{
					kelime += şifreliMetin[i].ToString();
				}
				else
				{

					k = alfabe.IndexOf(şifreliMetin[i]);
					if (k - 3 < 0)
					{
						int a = 3 - k ;
						int b = 29 - a ;
						z = alfabe[b].ToString();
					}
					else
					{
						z = alfabe[k - 3].ToString();
					}
					

					kelime += z;
				}
			}

			textBox1.Text = kelime;

			//string sifre = "";
			//sifre = textBox2.Text;
			//char[] harfler = sifre.ToCharArray();
			//foreach (char harf in harfler)
			//{
			//	textBox1.Text += Convert.ToChar(harf - 3).ToString();
			//}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			
			Form1 form = new Form1();
			form.Show();
			this.Hide();
		}
	}
}
