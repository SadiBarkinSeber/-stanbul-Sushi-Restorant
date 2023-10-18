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
	public partial class MenuEkleEkrani : Form
	{
		public MenuEkleEkrani()
		{
			InitializeComponent();
		}

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            Menu menuEkle = new Menu();

            menuEkle.Ad = txtMenuAdi.Text;
            menuEkle.Fiyat = (int)nudMenuFiyat.Value;

            MainForm.Menuler.Add(menuEkle);

            Helper.Temizle(this.Controls);
        }
    }
}
