using İstanbul_Restorant.Class;
using RandevuProject.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstanbul_Restorant
{
	public partial class EkstraMalzemeEkleEkrani : Form
    {
		public EkstraMalzemeEkleEkrani()
		{
			InitializeComponent();
		}

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            Malzeme ekMalzeme = new Malzeme();

            ekMalzeme.Ad = txtEkstraMalzemeEklemeAdi.Text;
            ekMalzeme.Fiyat = (int)nudMalzemeFiyat.Value;

            MainForm.Malzemeler.Add(ekMalzeme);

            Helper.Temizle(this.Controls);
        }
    }
}
