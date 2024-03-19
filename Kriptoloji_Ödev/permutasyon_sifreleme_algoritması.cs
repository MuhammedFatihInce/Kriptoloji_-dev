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
	public partial class permutasyon_sifreleme_algoritması : Form
	{
		string metin = "";
		string metinEdit = "";
		string sifreliMetin = "";
		string password = "";
		string desifreliMetin = "";
		int n;
		int y;
		int[] yalancıAnahtar;
		int[] anahtar;
		char ekKarakter = 'z';
		public permutasyon_sifreleme_algoritması()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			metin = textBox1.Text.ToLower();
			metinEdit = metin.Replace(" ", "");
			sifreliMetin = "";
			anahtarOlustur();
			ekKarakterEkle();
			int i = 0;

			while ( i< metinEdit.Length )
			{
				for (int j = 0; j < n; j++)
				{
					sifreliMetin += metinEdit[(i + anahtar[j] - 1)];
				}
				i += n;
			}
			textBox2.Text = sifreliMetin;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			password = textBox3.Text;
			desifreliMetin = "";

			if (textBox6.Text != textBox4.Text)
			{

				yalancıAnahtarOlustur();
				yalancıEkKarakterEkle();
				int i = 0;

				while (i < password.Length)
				{
					for (int j = 0; j < y; j++)
					{
						desifreliMetin += password[(i + yalancıAnahtar[j] - 1)];
					}
					i += y;
				}
				textBox5.Text = desifreliMetin;
			}
			else
			{
				int i = 0;
				while (i < password.Length)
				{
					for (int j = 0; j < n; j++)
					{
						int k = j + 1;
						int indis = 0;
						while (k != anahtar[indis])
							indis++;

						desifreliMetin += password[i + indis];

					}
					i += n;
				}
				textBox5.Text = desifreliMetin;
			}
			
		}

		void anahtarOlustur()
		{
			n = int.Parse(textBox4.Text);
			if (n <= 0)
			{
				MessageBox.Show("Anahtar değeri 0 olamaz!");
				n = 1;
			}
			anahtar = new int[n];

			Random rnd = new Random();
			int i = 0;
			while (i < n)
			{
				int sayi = rnd.Next(n) + 1;
				if (!anahtar.Contains(sayi))
				{
					anahtar[i] = sayi;
					i++;
				}
			}
		}
		void yalancıAnahtarOlustur()
		{
			y = int.Parse(textBox6.Text);
			if (y <= 0)
			{
				MessageBox.Show("Anahtar değeri 0 olamaz!");
				y = 1;
			}
			yalancıAnahtar = new int[y];

			Random rnd = new Random();
			int i = 0;
			while (i < y)
			{
				int sayi = rnd.Next(y) + 1;
				if (!yalancıAnahtar.Contains(sayi))
				{
					yalancıAnahtar[i] = sayi;
					i++;
				}
			}
		}

		void ekKarakterEkle()
		{
			int fark1 = metinEdit.Length % n;
			if (fark1 != 0)
			{
				int fark2 = n - fark1;
				for (int i = 0; i < fark2; i++)
				{
					metinEdit += ekKarakter;
				}
			}

		}
		void yalancıEkKarakterEkle()
		{
			int fark1 =  password.Length % y;
			if (fark1 != 0)
			{
				int fark2 = y - fark1;
				for (int i = 0; i < fark2; i++)
				{
					password += ekKarakter;
				}
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
