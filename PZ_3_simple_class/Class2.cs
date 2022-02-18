using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_3_simple_class
{
    class Computer
    {
        int ID;
        int totalHDDMemory;
        int processorFrequency;
        static int s;
        static int PF;
        int ERROR;


        public int ID_1
        {

            get { return ID_1; }
            set
            {
                if (value < 0) ID_1 = 00000;
                else ID_1 = value;
            }
        }

        public int ProcessorFrequency
        {
            get { return processorFrequency; }
            set
            {
                ERROR = value;
                if (value < 1.5 || value > 5) processorFrequency = 0;
                else processorFrequency = value;
            }

        }

        public Computer(int a, int b, int c = 10)
        {
            ID = a;
            totalHDDMemory = b;
            ProcessorFrequency = c;
            s += totalHDDMemory;

            if (ERROR > 2) PF += 1;
        }


        public void processorFrequency_1()
        {
            Console.WriteLine("ПК с частотой " + PF);
        }

        public void GetMemory()
        {
            Console.WriteLine("Сумма памяти всех ПК состовляет=" + s + "Гб");
        }

        public virtual void GetCompName()
        {
            Console.WriteLine($"ID = {ID}, totalHDDMemory = {totalHDDMemory} Гб, processorFrequency = {processorFrequency} ТГц ");
        }

    }
}
