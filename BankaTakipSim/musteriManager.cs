using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaTakipSim
{
    internal class musteriManager
    {
        public void musteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi." + musteri.adi + " " + musteri.soyadi);
        }
        public void musteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi." + musteri.adi + " " + musteri.soyadi );
        }

    }
}
