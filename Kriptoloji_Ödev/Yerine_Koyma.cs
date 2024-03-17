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
	public partial class Yerine_Koyma : Form
	{
		public Yerine_Koyma()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox3.Text = "";
			string alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
			List<int> karistir = Karistir(0, 28);
			foreach (int item in karistir)
			{
				char a = alfabe[item];
				textBox3.Text += a;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
			string anahtar = textBox3.Text;
			string Metin = "";
			Metin = textBox1.Text.ToUpper();
			string sifrelenen_harf = "";

			for (int i = 0; i < Metin.Length; i++)
			{
				if (alfabe.IndexOf(Metin[i]) == -1)
				{
					continue;
				}
				else
				{
					int yerine_koyma = alfabe.IndexOf(Metin[i]);
					sifrelenen_harf = anahtar[yerine_koyma].ToString();
					textBox2.Text += sifrelenen_harf;
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
			string anahtar = textBox4.Text;
			string sifrelenen_metin = "";
			sifrelenen_metin = textBox6.Text.ToUpper();
			string Metin = "";
			

			for (int i = 0; i < sifrelenen_metin.Length; i++)
			{
				if (anahtar.IndexOf(sifrelenen_metin[i]) == -1)
				{
					continue;
				}
				else
				{
					int yerine_koyma = anahtar.IndexOf(sifrelenen_metin[i]);
					Metin = alfabe[yerine_koyma].ToString();
					textBox5.Text += Metin;
				}
			}
		}

		public static List<int> Karistir(int start, int end)
		{
			List<int> numbers = new List<int>();
			for (int i = start; i <= end; i++)
			{
				numbers.Add(i);
			}

			Random rnd = new Random();
			int n = numbers.Count;
			while (n > 1)
			{
				int k = rnd.Next(0, n);
				n--;
				int temp = numbers[k];
				numbers[k] = numbers[n];
				numbers[n] = temp;
			}

			return numbers;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
			this.Hide();
		}
	}
}
