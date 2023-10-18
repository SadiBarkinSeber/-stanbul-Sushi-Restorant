using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace İstanbul_Restorant.Class
{
    public class Siparis
    {
        
        public List<Malzeme> Malzemeler = new List<Malzeme>();

        public Menu Menu { get; set; }
        public MenuBoy Boy { get; set; }
        public int Adet { get; set; }



        private double toplamFiyat;
        public double ToplamFiyat
        {
            get
            {
                toplamFiyat = Menu.Fiyat;
                if (Boy == MenuBoy.orta)
                {
                    toplamFiyat *= 1.5;
                }
                else if (Boy == MenuBoy.büyük)
                {
                    toplamFiyat *= 2.0;
                }

                foreach (Malzeme malzeme in Malzemeler)
                {
                    toplamFiyat += malzeme.Fiyat;
                }

                toplamFiyat *= Adet;
                return toplamFiyat;
            }
        }

        public double EkstraMalzemeFiyatlari()
        {
            double toplam = 0;
            foreach (Malzeme malzeme in Malzemeler)
            {
                toplam += malzeme.Fiyat * this.Adet;
            }
            return toplam;
        }

        public override string ToString()
        {
            string ekstraMalzemelerinIsimleri = string.Empty;
            foreach (Malzeme malzeme in Malzemeler)
            {
                ekstraMalzemelerinIsimleri += malzeme.Ad + " ";
            }

            string bilgi = $"{Adet} {Menu.Ad} , {ekstraMalzemelerinIsimleri} , {Boy} Boy , Toplam : {ToplamFiyat} ";

            return bilgi;
        }


    }
}
