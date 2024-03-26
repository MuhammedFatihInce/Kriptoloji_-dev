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
	public partial class Zigzag_algoritmasi : Form
	{
		public Zigzag_algoritmasi()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            string metin = textBox1.Text;
            string metinEdit = metin.Replace(" ", "");

            int anahtar = Convert.ToInt32(textBox4.Text);

            int satir_sayisi = anahtar;
            int sutun_sayisi = metinEdit.Length;


            char[,] matrix = new char[satir_sayisi, sutun_sayisi];

            int satir = 0, sutun = 0;
            bool asagi = true;


           

            for (int i = 0; i < metinEdit.Length; i++)
            {
                if (asagi)
                {
                    matrix[satir, sutun] = metinEdit[i];
                    satir++;
                }
                else
                {
                    matrix[satir, sutun] = metinEdit[i];
                    satir--;
                }

                if (satir == satir_sayisi)
                {
                    satir -= 2;
                    asagi = false;
                }
                else if (satir == -1)
                {
                    satir += 2;
                    asagi = true;
                }

                sutun++;
            }

			foreach (var item in matrix)
			{
                textBox2.Text += item;
            }
        }

		private void button2_Click(object sender, EventArgs e)
		{
            string sifreliMetin = textBox6.Text;

            int anahtar = Convert.ToInt32(textBox3.Text);

            int satir_sayisi = anahtar;
            int sutun_sayisi = sifreliMetin.Length;

            int satir = 0, sutun = 0;
            bool asagi = true;

            char[,] matrix = new char[satir_sayisi, sutun_sayisi];

            for (int i = 0; i < sifreliMetin.Length; i++)
            {
                if (asagi)
                {
                    matrix[satir, sutun] = 'c';
                    satir++;
                }
                else
                {
                    matrix[satir, sutun] = 'c';
                    satir--;
                }

                if (satir == satir_sayisi)
                {
                    satir -= 2;
                    asagi = false;
                }
                else if (satir == -1)
                {
                    satir += 2;
                    asagi = true;
                }

                sutun++;
            }

            int index = 0;
			for (int i = 0; i < satir_sayisi; i++)
			{
				for (int j = 0; j < sutun_sayisi; j++)
				{
					if (matrix[i, j] == 'c')
					{
                        matrix[i, j] = sifreliMetin[index++];

                    }
				}
			}


            int row = 0, col = 0;
            bool down = true;
            string decryptedText = "";
            for (int i = 0; i < sifreliMetin.Length; i++)
            {
                if (down)
                {
                    decryptedText += matrix[row, col];
                    row++;
                }
                else
                {
                    decryptedText += matrix[row, col];
                    row--;
                }

                if (row == satir_sayisi)
                {
                    row -= 2;
                    down = false;
                }
                else if (row == -1)
                {
                    row += 2;
                    down = true;
                }

                col++;
            }
            textBox5.Text = decryptedText.ToString();

        }

		private void button3_Click(object sender, EventArgs e)
		{
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
	}
}
