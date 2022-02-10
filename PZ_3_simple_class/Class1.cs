using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_3_simple_class
{
    static class ProgramP 
    {
        static void Main(string[] args)
        {
            Computer comp1 = new Computer(228337, 32, 3);
            Computer comp2 = new Computer(233832, 16, 2);
            Computer comp3 = new Computer(974359, 8, 4);
            Computer comp4 = new Computer(753487, 4);

            comp1.GetCompName();
            comp2.GetCompName();
            comp3.GetCompName();
            comp4.GetCompName();



        }


    }
}
