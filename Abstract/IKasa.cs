using Kaan_Binici_OOP_Sinavi.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaan_Binici_OOP_Sinavi.Abstract
{
    public interface IKasa
    {
        public event Haberci SiparisAtadim;

        void BostaDuranCalisanaSiparisGonder();
        void MusteridenAdiniVeSectigiMenuyuAlSiparisiOlustur(object sender);
    }
}
