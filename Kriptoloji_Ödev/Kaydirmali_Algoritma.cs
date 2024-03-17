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
			anahtar = Convert.ToInt32(textBox3.Text);
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
					continue;
				}
				else
				{

					k = alfabe.IndexOf(kelime[i]);
					if (k + anahtar > 29)
					{
						int a = k + anahtar;
						int b = a - 29;
						z = alfabe[b].ToString();
					}
					else
					{
						z = alfabe[k + anahtar].ToString();
					}

					şifreliMetin += z;
				}
			}

			textBox2.Text = şifreliMetin;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			int anahtar = 0;
			anahtar = Convert.ToInt32(textBox4.Text);
			string alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
			string şifreliMetin = "";
			şifreliMetin = textBox6.Text.ToUpper();
			string kelime = "";
			int k;
			string z;
			for (int i = 0; i < şifreliMetin.Length; i++)
			{
				if (alfabe.IndexOf(şifreliMetin[i]) == -1)
				{
					continue;
				}
				else
				{

					k = alfabe.IndexOf(şifreliMetin[i]);
					if (k - anahtar < 0)
					{
						int a = anahtar - k;
						int b = 29 - a;
						z = alfabe[b].ToString();
					}
					else
					{
						z = alfabe[k - anahtar].ToString();
					}


					kelime += z;
				}
			}

			textBox5.Text = kelime;

		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
			this.Hide();
		}
	}
}
