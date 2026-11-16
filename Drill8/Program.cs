using System;

class Program
{
    static int Multiply(int a, int b)
    {
      return a * b;
    }
    static double Multiply(double a, double b)
    {
        return a * b;
    }
    static int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }
    static void Main()
    {
        int Num = Multiply(6, 7);
        Console.WriteLine(Num);

        double Num2 = Multiply(6.7, 8.9);
        Console.WriteLine(Num2);

        int Num3 = Multiply(5, 5, 5);
        Console.WriteLine(Num3);
    }
}