using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern2
{
    static class Program
    {
        public static void Main(string[] args)
        {
            DusmanTank  m24Tank  = new DusmanTank();

            DusmanRobotu robotSam = new DusmanRobotu();

            IDusman robotAdapter = new DusmanRobotAdapter(robotSam);

            Console.WriteLine("Robot");
            Console.ReadLine();

            robotSam.RobotIsim("Optimus Prime");
            robotSam.Yuru();
            robotSam.YumrukAt();
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("Dusman Tankı");
            Console.ReadLine();

            m24Tank.DusmanAta("Ironhide");
            m24Tank.Hizlan();
            m24Tank.SilahKullan();
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("Adapter Robot");
            Console.ReadLine();

            robotAdapter.DusmanAta("Megatron");
            robotAdapter.Hizlan();
            robotAdapter.SilahKullan();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

}
