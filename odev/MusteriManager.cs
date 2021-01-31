using System;
using System.Collections.Generic;
using System.Text;

namespace odev
{
    class MusteriManager
    {
        

        public void Ekle(msuteri musteri)
        {
            Console.WriteLine("eklenen musteri id: " + musteri.id);
        }

        public void Silme(msuteri silinen)
        {
            Console.WriteLine("silinen müşteri id: " + silinen.id);
        }

        



    }
}
