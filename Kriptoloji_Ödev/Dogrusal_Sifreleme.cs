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
	public partial class Dogrusal_Sifreleme : Form
	{
		
		public Dogrusal_Sifreleme()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
			int a, b, m, k;
			string metin, şifreliMetin;
			string z;

			a = int.Parse(textBox3.Text);
			b = int.Parse(textBox4.Text);
			m = 29;

			if (a% 29 != 0)
			{
				metin = textBox1.Text.ToUpper();
				şifreliMetin = "";

				for (int i = 0; i < metin.Length; i++)
				{
					if (alfabe.IndexOf(metin[i]) == -1)
					{
						continue;
					}
					else
					{

						k = alfabe.IndexOf(metin[i]);
						z = alfabe[((k * a + b) % 29)].ToString();

						şifreliMetin += z;
					}
				}

				textBox2.Text = şifreliMetin;
			}
			else
			{
				MessageBox.Show("a ve m değerleri birbirine bölünmemelidir.");
			}
		}



		private void button3_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
			int a, b, m, k, g, z;
			string metin, şifreliMetin;
			string y;

			a = int.Parse(textBox8.Text);
			b = int.Parse(textBox5.Text);
			m = 29;

			if (a % m != 0)
			{
				şifreliMetin = textBox6.Text.ToUpper();
				metin = "";


				for (int i = 0; i < şifreliMetin.Length; i++)
				{
					if (alfabe.IndexOf(şifreliMetin[i]) == -1)
					{
						continue;
					}
					else
					{
						k = alfabe.IndexOf(şifreliMetin[i]);
						z = (k - b);
						for (int j = 0;  ; j++)
						{
							if (z % a == 0)
							{
								break;
							}
							z += 29;
						}
						y = alfabe[(z/a)].ToString();

						metin += y;
					}
				}
				textBox7.Text = metin;
			}
			else
			{
				MessageBox.Show("a ve m değerleri birbirine tam bölünmelidir.");
			}
		}
	}
}
