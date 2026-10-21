using System;

class Program
{
    static bool IsEven(int x)
    {
        return x % 2;
    }
    static void Main(string[] args)
    {
        int yeeup = IsEven(40);

        Console.WriteLine(yeeup);
    }
    
}
