using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metotlars_1575
{
    public partial class Form1 : Form
    {
        Color renk = Color.White;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            sekil sekil1 = new sekil();
            sekil1.uzunKenar = Convert.ToInt32(txt1.Text);
            sekil1.kisaKenar = Convert.ToInt32(txt2.Text);

            //sekil1.KareYaz();
            sekil1.sekilCiz(btnSekil, renk);
            sekil1.mesajGönderme(btnSekil, txtDegis.Text);


            btnSekil.Width = Convert.ToInt32(txt1.Text);
            btnSekil.Height = Convert.ToInt32(txt2.Text);
        }

        private void btnRenksec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }
    }
}