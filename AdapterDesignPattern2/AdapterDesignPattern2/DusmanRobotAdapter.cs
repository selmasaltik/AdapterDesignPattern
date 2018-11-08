using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern2
{
    //IDusman interfacesinde uygulanan yöntemleri kullanmaya ihtiyaç duyulur çünkü Adapter için alternatif bir eylem sağlamamız gerekir.
    //Bu Adapter yok bu Adaptee (DusmanRobotu) aynı türde bir nesne içeren tarafından
    //Tüm aramalar IDusman yöntemleri için bunun yerine DusmanRobotu tarafından kullanılan yöntemler gönderilir.
public class DusmanRobotAdapter : IDusman
    {
    
    DusmanRobotu robot;
	
	public DusmanRobotAdapter(DusmanRobotu yeniRobot)
    {
		
		robot = yeniRobot;
		
	}

    public void SilahKullan()
    {

        robot.YumrukAt();

    }

    public void Hizlan()
    {

        robot.Yuru();

    }

    public void DusmanAta(string DusmanAdi)
    {

        robot.RobotIsim(DusmanAdi);
    }

  }
}

