using Kaan_Binici_OOP_Sinavi.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kaan_Binici_OOP_Sinavi.Concrete.KahveDukkani;

namespace Kaan_Binici_OOP_Sinavi.Abstract
{
    public interface IMusteri
    {
        public event Haberci UrunlerimiSectim;
        public string Ad { get; set; }

        public Menu SecilenMenu { get; set; }
        public void SiparisOlustur(object sender);
        public void HazirlananSiparisimiAliyorum(Object sender);
    }
}
