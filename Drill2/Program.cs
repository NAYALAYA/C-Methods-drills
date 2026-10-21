using System;

class Program
{
    static int FahrenheitToCelsius(int F)
    {
        return (F - 32) * 5/9;
    }
    static double PlusMethodDouble(double F)
    {
        return (F - 32) * 5/9;
    }
    static void Main(string[] args)
    {
        int C = FahrenheitToCelsius(82);
        double C2 = PlusMethodDouble(82);
        Console.WriteLine(C);
        Console.WriteLine(C2);
    }
}