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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace İstanbul_Restorant
{
    public partial class SiparisIslemleriEkrani : Form
    {
        public SiparisIslemleriEkrani()
        {
            InitializeComponent();
            YeniSiparisler = new List<Siparis>();
        }

        List<Siparis> YeniSiparisler;



        double toplam = 0;
        private void SiparisIslemleriEkrani_Load(object sender, EventArgs e)
        {
            foreach (Menu menu in MainForm.Menuler)
            {
                cbMenu.Items.Add(menu);
            }

            foreach (Malzeme melzeme in MainForm.Malzemeler)
            {
                flowLayoutPanel1.Controls.Add(new CheckBox() { Text = melzeme.Ad, Tag = melzeme });
            }

            cbMenu.SelectedItem = 0;
            rbKucuk.Checked = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        }



        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            siparis.Menu = (Menu)cbMenu.SelectedItem;

            foreach (CheckBox cbox in flowLayoutPanel1.Controls)
            {
                if (cbox.Checked)
                {
                    siparis.Malzemeler.Add((Malzeme)cbox.Tag);
                }
            }

            if (rbOrta.Checked)
            {
                siparis.Boy = MenuBoy.orta;
            }
            else if (rbBuyuk.Checked)
            {
                siparis.Boy = MenuBoy.büyük;
            }
            else
            {
                siparis.Boy = MenuBoy.kucuk;
            }

            siparis.Adet = (int)numAdet.Value;

            toplam += siparis.ToplamFiyat;
            lblToplamFiyat.Text = toplam.ToString("C2");

            YeniSiparisler.Add(siparis);
            lbSiparis.Items.Add(siparis);

            Helper.Temizle(this.Controls);
        }



        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sipariş Onaylandı mı ?\nParası Ödendi mi ?", "Onay", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                MainForm.Siparisler.AddRange(YeniSiparisler);
                lbSiparis.Items.Clear();
                YeniSiparisler.Clear();
            }
            Helper.Temizle(this.Controls);
        }
    }
}
