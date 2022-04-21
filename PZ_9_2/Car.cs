using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_9_2
{
    
    internal class Car
    {
        public int speedometer1;
        
        public event StopCar MyEvent;

        public void speed()
        {
            for (int i = 0; i < 201; i++)
            {
                speedometer1 = i;
                if (speedometer1 == 81)
                {
                    if (MyEvent != null)
                    {
                        MyEvent();
                    }
                }
                else if (speedometer1 == 121)
                {
                    if (MyEvent != null)
                    {
                        MyEvent();
                    }
                }
                Console.WriteLine($"{speedometer1} км/ч");
               
            }

        }

        
    }
}
