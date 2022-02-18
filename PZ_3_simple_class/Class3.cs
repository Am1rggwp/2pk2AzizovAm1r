using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_3_simple_class
{

    class Smartphone : Computer
    {
        int Dioganal { get; set; } 
        int Diapazon { get; set; }
            
        public Smartphone(int a, int b, int c, int g, int f)
            : base(a, b, c)
        {
            Dioganal = g;
            Diapazon = f;

        }
         public override void GetCompName()
         {
            base.GetCompName();
            Console.WriteLine("Диагональ телефона =" + Dioganal + "дюймов" + "\n Тип интернета = " + Diapazon + "G");
         } 

        
        

        


          
    }    
}
