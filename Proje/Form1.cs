using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AnaProje;
namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kisi k = new Kisi();
            k.Ad = "can";
            k.Soyad = "mert";
            string s = k.FullName();

            

            Ogrenci o = new Ogrenci();
            Ogretmen g = new Ogretmen(); //instance oluşturma
           //g.kredikartı ----instance olsrtup buna deger atayamayaızz cunk internal
           
        }
    }
}
