using System;

class Program
{
    static double CalculatePrice(double cost, double taxRate)
    {
        return cost + taxRate;
    }
    static void Main()
    {
        Console.Write("Price of item: ");
        double c = Console.Read();
        double price =  CalculatePrice(c, 0.07);
        Console.WriteLine(price);
    }
}