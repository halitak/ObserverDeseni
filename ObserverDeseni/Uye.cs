using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDeseni
{
    class Uye:IUye
    {
        public string email { get; set; }

        public void update(absUrun urun)
        {
            Console.WriteLine("{0} nın fiyatı {1} oldu, {2} adresine gönderildi", urun.urunAdi, urun.Fiyat.ToString("C2"), email);
        }
    }
}
