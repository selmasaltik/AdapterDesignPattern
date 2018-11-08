using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern2
{
    public class DusmanRobotu
    {
        Random generator = new Random();

        public void YumrukAt()
        {

            int saldiriHasari = generator.Next(10) + 1;

            Console.WriteLine("Dusman Saldırı Hasarı: " + saldiriHasari);

        }

        public void Yuru()
        {

            int hareket = generator.Next(5) + 1;

            Console.WriteLine("Dusman Robotu İleri Hareket: " + hareket);

        }

        public void RobotIsim(String DusmanAdi)
        {

            Console.WriteLine("Dusman Robotu: " + DusmanAdi);

        }
    }
}


