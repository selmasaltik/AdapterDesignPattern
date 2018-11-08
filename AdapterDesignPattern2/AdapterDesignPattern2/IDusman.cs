using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern2
{

    //Bu target interfacedir: Bu client ile çalışmak için bekliyor. 
    //Yeni sınıflar bununla uyumlu hale getirmek için adaptörler iş yüzünden.
public interface IDusman
    {
        void SilahKullan();

        void Hizlan();

        void DusmanAta(String DusmanAdi);
    }
}
