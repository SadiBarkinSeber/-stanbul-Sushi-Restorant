using İstanbul_Restorant.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstanbul_Restorant
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu{Ad="Dana Etli Ramen",Fiyat=100},
            new Menu{Ad="Dana Etli Noodle",Fiyat=90},
            new Menu{Ad="Karidesli Noodle",Fiyat=90},
            new Menu{Ad="California Roll(8 Adet)",Fiyat=90},
            new Menu{Ad="Philadelphia Roll(8 Adet)",Fiyat=90}
        };

        public static List<Malzeme> Malzemeler = new List<Malzeme>()
        {
            new Malzeme{Ad="Soya Sos",Fiyat=10},
            new Malzeme{Ad="Sriracha Sos",Fiyat=20},
            new Malzeme{Ad="Wasabi",Fiyat=5},
        };

        public static List<Siparis> Siparisler = new List<Siparis>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            SiparisIslemleriEkraniGetir();
        }

        private void SiparisIslemleriEkraniGetir()
        {
            FormlarıKapat();

            SiparisIslemleriEkrani SiparisOlustur = new SiparisIslemleriEkrani();

            SiparisOlustur.MdiParent = this;
            SiparisOlustur.Dock = DockStyle.Fill;
            this.Width = SiparisOlustur.Width + 30;
            this.Height = SiparisOlustur.Height + 60;
            SiparisOlustur.Show();
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisIslemleriEkraniGetir();
        }

        private void siparişDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlarıKapat();

            SiparislerEkrani tumSiparsler = new SiparislerEkrani();

            tumSiparsler.MdiParent = this;
            tumSiparsler.Dock = DockStyle.Fill;
            this.Width = tumSiparsler.Width + 30;
            this.Height = tumSiparsler.Height + 60;
            tumSiparsler.Show();
        }
        private void FormlarıKapat()
        {
            Form[] forms = this.MdiChildren;
            foreach (Form form in forms)
            {
                form.Close();
            }
        }
        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlarıKapat();

            MenuEkleEkrani menuEkle = new MenuEkleEkrani();

            menuEkle.MdiParent = this;
            menuEkle.Dock = DockStyle.Fill;
            this.Width = menuEkle.Width + 30;
            this.Height = menuEkle.Height + 60;
            menuEkle.Show();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlarıKapat();

            EkstraMalzemeEkleEkrani ekstraMalzemeEkle = new EkstraMalzemeEkleEkrani();

            ekstraMalzemeEkle.MdiParent = this;
            ekstraMalzemeEkle.Dock = DockStyle.Fill;
            this.Width = ekstraMalzemeEkle.Width + 30;
            this.Height = ekstraMalzemeEkle.Height + 60;
            ekstraMalzemeEkle.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
    }
}
