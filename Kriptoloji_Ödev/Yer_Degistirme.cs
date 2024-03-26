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
	public partial class Yer_Degistirme : Form
	{
		public Yer_Degistirme()
		{
			InitializeComponent();
		}

		private void button1_Click_1(object sender, EventArgs e)
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

            string cipherText = "";
            for (int j = 0; j < anahtar; j++)
            {
                for (int i = 0; i < satir_sayisi; i++)
                {
                    cipherText += matrix[i, j];
                }
            }

            textBox2.Text += cipherText;
        }

		
		private void button2_Click(object sender, EventArgs e)
		{
            string metin = textBox6.Text;


            double anahtar = Convert.ToDouble(textBox3.Text);
            double gercek_deger = metin.Length / anahtar;
            decimal satir_sayisi = Math.Ceiling(Convert.ToDecimal(gercek_deger));


            char[,] matrix = new char[(int)satir_sayisi, (int)anahtar];
            int index = 0;

            int a = 0;
            for (int j = 0; j < anahtar; j++)
            {
                for (int i = 0; i < satir_sayisi; i++)
                {
                    matrix[i, j] = metin[a];
                    a++;
                }
            }

            string sifreMetin = "";
            for (int i = 0; i < satir_sayisi; i++)
            {
                for (int j = 0; j < anahtar; j++)
                {
                    sifreMetin += matrix[i, j];
                    index++;
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
