using Kaan_Binici_OOP_Sinavi.Concrete;
using Kaan_Binici_OOP_Sinavi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaan_Binici_OOP_Sinavi.Abstract
{
    public interface ICalisan
    {
        public ISiparis IslemYapilanSiparis { get; set; }  // Çalışanın o an aldığı siparişi atadığım prop.

        public event Haberci KasaBenMusaitim;  // Çalışan müsait olunca evet aracılığıyla ben müsaitim diyecek.
        public event Haberci MusteriSiparisiniHazirladim; // Müşteri işim bitti diyince müşteri siparişini verebilecek.
        void Gorev();  // çalışan siparişi hazırlayacak.

        void KasadanSiparisAl(object sender);  // Kasadan oluşan sipariş gönderilecek.
    }
}

