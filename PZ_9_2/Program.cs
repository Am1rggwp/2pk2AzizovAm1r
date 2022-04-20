using System;
delegate void fast();
namespace PZ_9_2
{
    internal class Program
    {


        static void name()
        { Console.WriteLine("Лада"); }

        static void Main(string[] args)
        {

            A bob1 = new A();
            B bob = new B(bob1);

            bob.patrul();
            bob1.slow();
            bob.patrul();

            Console.ReadLine();
            
     

        }
    }
}



 