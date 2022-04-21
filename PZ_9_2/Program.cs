using System;
delegate void StopCar();
namespace PZ_9_2
{
    internal class Program
    {


        static void name()
        { Console.WriteLine("Лада Granda"); }


        static void Main(string[] args)
        {
            Car speedometer = new Car();
            Patrul signal = new Patrul();
            speedometer.MyEvent += signal.DANGER;
            speedometer.speed();
            speedometer.MyEvent += signal.MegaDanger;

        }
    }
}



 