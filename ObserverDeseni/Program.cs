using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDeseni
{
    class Program
    {
        static void Main(string[] args)
        {
            absUrun Kitap = new Urun("Kitap", 1025M);
            Kitap.TakipList.Add(new Uye { email = "halit@gmail.com" });
            Kitap.TakipList.Add(new Uye { email = "ak@gmail.com" });
            Kitap.Fiyat = 899M;
            Console.ReadKey();
        }
    }
}
