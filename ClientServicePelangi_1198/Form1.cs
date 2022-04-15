using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServicePelangi_1198
{
    public partial class Form1 : Form
    {
        LayananPelangi.WebService1 Pelangi;
        string Rainbow;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pelangi = new LayananPelangi.WebService1();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNomor.Text, out int value))
            {
                Rainbow = Pelangi.Pelangi(int.Parse(txtNomor.Text));
                txtWarna.Text = Rainbow;
            }
            else
            {
                MessageBox.Show("Isi dengan angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
