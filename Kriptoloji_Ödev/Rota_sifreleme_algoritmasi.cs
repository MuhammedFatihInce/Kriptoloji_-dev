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
	public partial class Rota_sifreleme_algoritmasi : Form
	{
		public Rota_sifreleme_algoritmasi()
		{
			InitializeComponent();
		}


		private void button1_Click(object sender, EventArgs e)
		{
            string metin = textBox1.Text;
            string metinEdit = metin.Replace(" ", "");

            double anahtar = Convert.ToDouble(textBox4.Text);
            double gercek_deger = metinEdit.Length / anahtar;
            decimal satir_sayisi = Math.Ceiling(Convert.ToDecimal(gercek_deger));

            
            char[,] matrix = new char[(int)satir_sayisi, (int)anahtar];
            int index = 0;
            for (int i = 0; i < satir_sayisi; i++)
            {
                for (int j = 0; j < anahtar; j++)
                {
                    if (index < metinEdit.Length)
                    {
                        matrix[i, j] = metinEdit[index];
                        index++;
                    }
                    else
                    {
                        matrix[i, j] = 'z'; 
                    }
                }
            }

			string sifreMetin = "";
            int ust = 0, asagi = (int)satir_sayisi - 1, sol = 0, sag = (int)anahtar - 1;
            int yön = 0;

            while (ust <= asagi && sol <= sag)
            {
                if (yön == 0)
                {
                    for (int i = sol; i <= asagi; i++)
                    {
                        sifreMetin += matrix[ust, i];
                    }
                    ust++;
                }
                else if (yön == 1)
                {
                    for (int i = ust; i <= asagi; i++)
                    {
                        sifreMetin += matrix[i, sag];
                    }
                    sag--;
                }
                else if (yön == 2)
                {
                    for (int i = sag; i >= sol; i--)
                    {
                        sifreMetin += matrix[asagi, i];
                    }
                    asagi--;
                }
                else if (yön == 3)
                {
                    for (int i = asagi; i >= ust; i--)
                    {
                        sifreMetin += matrix[i, sol];
                    }
                    sol++;
                }

                yön = (yön + 1) % 4;
            }
            textBox2.Text = sifreMetin;
        }

		private void button2_Click(object sender, EventArgs e)
		{
            string metin = textBox6.Text;

            double anahtar = Convert.ToDouble(textBox3.Text);
            double gercek_deger = metin.Length / anahtar;
            decimal satir_sayisi = Math.Ceiling(Convert.ToDecimal(gercek_deger));

 
            char[,] matrix = new char[(int)satir_sayisi, (int)anahtar];

            string sifreMetin = "";
            int ust = 0, asagi = (int)satir_sayisi - 1, sol = 0, sag = (int)anahtar - 1;
            int yön = 0;
            int x = 0;

            while (ust <= asagi && sol <= sag)
            {
                
                if (yön == 0)
                {
                    for (int i = sol; i <= asagi; i++)
                    {
                        matrix[ust, i] = metin[x];
                        x++;
                    }
                    ust++;
                }
                else if (yön == 1)
                {
                    for (int i = ust; i <= asagi; i++)
                    {
                        matrix[i, sag] = metin[x];
                        x++;
                    }
                    sag--;
                }
                else if (yön == 2)
                {
                    for (int i = sag; i >= sol; i--)
                    {
                        matrix[asagi, i] = metin[x];
                        x++;
                    }
                    asagi--;
                }
                else if (yön == 3)
                {
                    for (int i = asagi; i >= ust; i--)
                    {
                        matrix[i, sol] = metin[x];
                        x++;
                    }
                    sol++;
                }

                yön = (yön + 1) % 4;
            }


            int index = 0;
            for (int i = 0; i < satir_sayisi; i++)
            {
                for (int j = 0; j < anahtar; j++)
                {
                    if (index < metin.Length)
                    {
                        sifreMetin += matrix[i, j]; 
                        index++;
                    }
                    else
                    {
                        matrix[i, j] = 'z'; 
                    }
                }
            }

            textBox5.Text = sifreMetin;
        }

		private void button3_Click(object sender, EventArgs e)
		{
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
	}
}

//bilgisayarmühendisliği