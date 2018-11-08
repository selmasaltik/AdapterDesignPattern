using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern2
{
    //DusmanTank IDusman interfacesi tarafından mükemmel bir şekilde implemente edilir.
    //Bizim işimiz IDusman interfacesiyle çalışmak için IDusman sınıflarını farklı yöntemler haline getirmektir.
    public class DusmanTank : IDusman
    {
        Random generator = new Random();

        public void SilahKullan()
        {

            int saldiriHasari = generator.Next(10) + 1;

            Console.WriteLine("Dusman Tankı Saldırı Hasarı: " + saldiriHasari);

        }

        public void Hizlan()
        {

            int hareket = generator.Next(5) + 1;

            Console.WriteLine("Dusman Tankı Hızı: " + hareket);

        }

        public void DusmanAta(String DusmanAdi)
        {

            Console.WriteLine("Tankı Süren: " + DusmanAdi);

        }
    }
}


