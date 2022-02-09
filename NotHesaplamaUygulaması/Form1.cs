using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotHesaplamaUygulaması
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
		float finalyüzde, vizeyüzde, ödevyüzde;
		float final, vize, ödev;

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click_1(object sender, EventArgs e)
		{

		}

		private void otobtn_Click(object sender, EventArgs e)
		{
			finalorttxtbox.Text = "60";
			vizeorttxtbox.Text = "40";
			ödevorttxtbox.Text = "0";
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		float finalsonuç, vizesonuç, ödevsonuç;
		float sonuç;
		private void Göster_Click(object sender, EventArgs e)
		{
			if (ödevorttxtbox.Text == "" || ödevtxtbox.Text == "")
			{
				ödevorttxtbox.Text = "0";
				ödevtxtbox.Text = "0";
			}
			if (vizeorttxtbox.Text == "" || vizetxtbox.Text == "")
			{
				vizeorttxtbox.Text = "0";
				vizetxtbox.Text = "0";
			}
			if (finalorttxtbox.Text == "" || finaltxtbox.Text == "")
			{
				finalorttxtbox.Text = "0";
				finaltxtbox.Text = "0";
			}

			finalorttxt.Text = "Final Etki Oranınız: " + finalorttxtbox.Text;
			vizeorttxt.Text = "Vize Etki Oranınız: " + vizeorttxtbox.Text;
			ödevorttxt.Text = "Ödev Etki Oranınız: " + ödevorttxtbox.Text;

			finalyüzde = Convert.ToInt32(finalorttxtbox.Text);
			vizeyüzde = Convert.ToInt32(vizeorttxtbox.Text);
			ödevyüzde = Convert.ToInt32(ödevorttxtbox.Text);

			final = Convert.ToInt32(finaltxtbox.Text);
			vize = Convert.ToInt32(vizetxtbox.Text);
			ödev = Convert.ToInt32(ödevtxtbox.Text);

			finalsonuç = finalyüzde * final / 100;
			vizesonuç = finalyüzde * vize / 100;
			ödevsonuç = finalyüzde * ödev / 100;

			sonuç = finalsonuç + vizesonuç + ödevsonuç;

			finalvizeödevtxt.Text = " Final Ortalamanız: " + finalsonuç + " Vize Ortalamanız: " + vizesonuç + " Ödev Ortalamanız: " + ödevsonuç;
			sonuçtxt.Text = "Ortalamanız: " + sonuç;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
