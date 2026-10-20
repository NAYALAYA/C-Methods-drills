using System;

class Program
{
    static void MyMethod(string name)
    {
        Console.WriteLine("Hello, " + name + "! Welcome to C# class.");
    }

    static void Main(string[] args)
    {
        MyMethod("Adiel");
        MyMethod("Momina");
    }
}