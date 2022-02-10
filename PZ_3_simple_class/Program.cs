using System;

class Computer
{
    public int ID;
    public int totalHDDMemory;
    public int processorFrequency;

    public Computer (int a, int b, int c = 10)
    {
        ID = a;
        totalHDDMemory = b;
        processorFrequency = c;
    } 
    
    public void GetCompName()
    {
        Console.WriteLine($"ID = {ID}, totalHDDMemory = {totalHDDMemory} Гб, processorFrequency = {processorFrequency} Гц ");
    }


}
