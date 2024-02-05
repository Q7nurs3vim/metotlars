using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace metotlars_1575
{
    internal class sekil
    {
        public int uzunKenar { get; set; }
        public int kisaKenar { get; set; }
        
        //parametre almayan ve deger dondurmeyen(voit)

        public void KareYaz()
        {
            int sonuc = this.kisaKenar * this.uzunKenar;
            MessageBox.Show($"Şeklin Karesi :{sonuc}");
        }

        public void sekilCiz(Button btn , Color renk)
        {
            btn.Width = this.uzunKenar;
            btn.Height = this.kisaKenar;
            btn.BackColor = renk;

           
        }
        public void mesajGönderme (Button btn , string mesaj)
        {
            btn.Text = mesaj;
        }
    }   

}
