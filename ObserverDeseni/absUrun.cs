using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDeseni
{
    abstract class absUrun
    {
        public string urunAdi { get; set; }
        private decimal fiyat;
        public List<IUye> TakipList = new List<IUye>();
        public absUrun(string urunAdi, decimal urunFiyati) {
            this.urunAdi = urunAdi;
            this.fiyat = urunFiyati;
        }
        public decimal Fiyat
        {
            get { return fiyat; }
            set {
                if (fiyat>value)
                {
                    notifyUrun();
                }
                fiyat = value;
            }
        }
        public void notifyUrun() {
            foreach (IUye item in TakipList)
            {
                item.update(this);
            }
        }
    }
}
