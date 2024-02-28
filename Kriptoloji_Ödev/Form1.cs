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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Sezar_Algoritma s_a = new Sezar_Algoritma();
			s_a.Show();
			this.Hide();
		
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Kaydirmali_Algoritma k_a = new Kaydirmali_Algoritma();
			k_a.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Dogrusal_Sifreleme d_g = new Dogrusal_Sifreleme();
			d_g.Show();
			this.Hide();
		}
	}
}
