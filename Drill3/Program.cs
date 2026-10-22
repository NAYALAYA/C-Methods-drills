using System;

class Program
{
    static bool IsEven(int x)
    {
        int remainder = x % 2;
        if (remainder == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        int x = 40;
        if (IsEven(x))
            Console.WriteLine("Yeeup");
        else
            Console.WriteLine("Nope");
    }
    
}
