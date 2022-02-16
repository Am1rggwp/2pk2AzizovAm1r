using System;

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

        get { return ID; }
        set
        {
            if (value < 0) ID = 00000;
            else ID = value;
        }
    }
    
    public int ProcessorFrequency
    {
        get { return processorFrequency; }
        set
        {
            ERROR = value;
            if (value < 1.5 || value >  5) processorFrequency =00000;
            else processorFrequency = value;
        }

    }

    public Computer(int a, int b, int c = 10)
    {
        ID_1 = a;
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

    public void GetCompName()
    {
        Console.WriteLine($"ID = {ID}, totalHDDMemory = {totalHDDMemory} Гб, processorFrequency = {processorFrequency} Гц ");
    }


}
