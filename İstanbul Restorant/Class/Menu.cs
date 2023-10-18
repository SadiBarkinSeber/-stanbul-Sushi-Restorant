using İstanbul_Restorant.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İstanbul_Restorant
{
    public class Menu : Urun
    {
        public override string ToString()
        {
            return $"{this.Ad} Menu";
        }
    }
}
