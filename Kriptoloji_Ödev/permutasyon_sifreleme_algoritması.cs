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
		string desifreliMetin = "";
		int n;
		int[] anahtar;
		char ekKarakter = 'z';
		public permutasyon_sifreleme_algoritması()
		{
			InitializeComponent();
		}

		void anahtarOlustur()
		{
			n = int.Parse(textBox4.Text);
			if (n<=0)
			{
				MessageBox.Show("Anahtar değeri 0 olamaz!");
				n = 1;
			}
			anahtar = new int[n];

			Random rnd = new Random();
			int i = 0;
			while (i<n)
			{
				int sayi = rnd.Next(n) + 1;
				if (! anahtar.Contains(sayi) )
				{
					anahtar[i] = sayi;
					i++;
				}
			}
		}

		void ekKarakterEkle()
		{
			int fark1 = metinEdit.Length % n;
			if (fark1 != 0 )
			{
				int fark2 = n - fark1;
				for (int i = 0; i < fark2; i++)
				{
					metinEdit += ekKarakter;
				}
			}

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
			desifreliMetin = "";
			int i = 0;
			while (i<sifreliMetin.Length)
			{
				for (int j = 0; j < n; j++)
				{
					int k = j + 1;
					int indis = 0;
					while (k != anahtar[indis])
						indis++;

					desifreliMetin += sifreliMetin[i + indis];
					
				}
				i += n;
			}
			textBox3.Text = desifreliMetin;
		}
	}
}
