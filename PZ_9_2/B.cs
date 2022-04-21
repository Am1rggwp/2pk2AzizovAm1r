using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_9_2
{
    internal class B
    {
        A car = new A();

        public event StopCar ivent;

        public B (A peremennaya)
        {
            car = peremennaya;
        }

        


        public void patrul()
        {
            if (ivent == null)
            {
                if (car.speed > 80 && car.speed <=120)
                {
                    ivent += DANGER;
                    
                }
                else if (car.speed > 120)
                {
                    ivent += MegaDanger;
                    
                }
                else
                {
                    ivent += NotDanger;
                    
                }
                
            }
            else 
            { 
                ivent = null;
                if (car.speed > 80 && car.speed <= 120)
                {
                    ivent += DANGER;
                   
                }
                else if (car.speed > 120)
                {
                    ivent += MegaDanger;
                   
                }
                else
                {
                    ivent += NotDanger;
                    
                }
                
            }



        }
        public void DANGER()
        {
            Console.WriteLine("Пожалуйста, снизьте скорость! ПОЖАЛУЙСТА!!!!!!!!!") ;
        }
        public void MegaDanger()
        {
            Console.WriteLine("НУ ВСЕ ТЫ ДОКОТАЛСЯ!!! начинаем погоню!!");
        }
        public void NotDanger()
        {
            Console.WriteLine("Ну лан, все нормально, сегодня тебе повезло,");
        }



    }

    
}
