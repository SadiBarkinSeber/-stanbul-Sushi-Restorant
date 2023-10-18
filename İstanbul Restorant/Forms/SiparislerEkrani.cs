using İstanbul_Restorant.Class;
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
	public partial class SiparislerEkrani : Form
	{
		public SiparislerEkrani()
		{
			InitializeComponent();
		}

        private void SiparislerEkrani_Load(object sender, EventArgs e)
        {
            double ciro = 0;
            int toplamSiparis = 0;
            double ekstraMalzemeGeliri = 0;
            int satilanUrunAdedi = 0;


            foreach (Siparis siparis in MainForm.Siparisler)
            {

                lstTumSiparisler.Items.Add(siparis);
                ciro += siparis.ToplamFiyat;

                ekstraMalzemeGeliri += siparis.EkstraMalzemeFiyatlari();

                satilanUrunAdedi += siparis.Malzemeler.Count * siparis.Adet;

                satilanUrunAdedi += siparis.Adet;
            }

            toplamSiparis = MainForm.Siparisler.Count;
            // C2 --> C = Para birimleri için, 2 = 2 ondalık basamaklı yazmak için.
            lblCiro.Text = ciro.ToString("C2");
            lblToplamSiparis.Text = toplamSiparis.ToString();
            lblEkstraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString("C2");
            lblSatilanUrunAdedi.Text = satilanUrunAdedi.ToString();
        }
    }
}
