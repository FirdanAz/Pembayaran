using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pembayaran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (tbTambahBarang.Text == "")
            {

            }
            else {
                cbItemBarang.Items.Add(tbTambahBarang.Text);
                tbTambahBarang.Text = "";
            }
        }

        private void picSoto_Click(object sender, EventArgs e)
        {
         
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            picPecel.Visible = false;
            picSoto.Visible = false;
            picGetuk.Visible = false;
            if (cbItemBarang.Text == "Getuk") {
                picGetuk.Visible = true;
            }
            if (cbItemBarang.Text == "Pecel Pakis")
            {
                picPecel.Visible = true;
            }
            if (cbItemBarang.Text == "Soto")
            {
                picSoto.Visible = true;
            }
            

            LB1.Items.Clear();
            LB1.Items.Add("Nama Barang : " + cbItemBarang.Text);
            LB1.Items.Add("Banyaknya : " + bnyaknya.Value);
            LB1.Items.Add("Harga : " + cbHarga.Text);
            Decimal hasil = decimal.Parse(cbHarga.Text) * bnyaknya.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            Decimal hasil = decimal.Parse(cbHarga.Text) * bnyaknya.Value;
            LB1.Items.Add("Total : " + hasil);
            tbHarga.Text = hasil.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bnyaknya.Value = 1;
            tbTambahBarang.ResetText();
            picPecel.Visible = false;
            picSoto.Visible = false;
            picGetuk.Visible = false;
            LB1.Items.Clear();
            tbHarga.ResetText();
            tbTambahBarang.ResetText();
        }
    }
}
