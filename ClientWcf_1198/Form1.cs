using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWcf_1198
{
    public partial class Form1 : Form
    {
        wcfService.CalculatorClient myservice;
        double hasil;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myservice = new wcfService.CalculatorClient();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            hasil = myservice.tambah(int.Parse(txtA.Text), int.Parse(txtB.Text));
            txtHasil.Text = hasil.ToString();
        }

        private void btnKurarng_Click(object sender, EventArgs e)
        {
            hasil = myservice.kurang(int.Parse(txtA.Text), int.Parse(txtB.Text));
            txtHasil.Text = hasil.ToString();
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            hasil = myservice.kali(int.Parse(txtA.Text), int.Parse(txtB.Text));
            txtHasil.Text = hasil.ToString();
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            hasil = myservice.bagi(int.Parse(txtA.Text), int.Parse(txtB.Text));
            txtHasil.Text = hasil.ToString();
        }
    }
}
