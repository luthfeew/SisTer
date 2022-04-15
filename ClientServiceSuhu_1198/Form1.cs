using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServiceSuhu_1198
{
    public partial class Form1 : Form
    {
        LayananKonversi.WebService1 MyService;
        double CtoR, CtoF, CtoK;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyService = new LayananKonversi.WebService1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CtoR = MyService.CelciusToReamur(int.Parse(txtC.Text));
            CtoF = MyService.CelciusToFahrenheit(int.Parse(txtC.Text));
            CtoK = MyService.CelciusToKelvin(int.Parse(txtC.Text));

            txtR.Text = CtoR.ToString() + " R";
            txtF.Text = CtoF.ToString() + " F";
            txtK.Text = CtoK.ToString() + " K";
        }
    }
}
