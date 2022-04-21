using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_9_2
{
    
    internal class A
    {
        public event StopCar ivent;
        public int speed;

        public void slow()
        {
            for (int i = 0; i < 201; i++)
            {
                speed = i;
                Console.WriteLine($"{speed} км/ч");
                
               
            }
            ivent += 

        }
    }
}
