using System;

class Program
{
    static bool IsValidPassword(string p)
    {
        string[] password = {"1899ucbh", "44 55 77 99", "^^7766&&22**88@@"};
        
        if (password.Length >= 8 && password.Contains(" ") == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main(string[] args)
    {
        string p = password[0];
        if (IsValidPassword(p))
            Console.WriteLine("Valid Password!");
        else
            Console.WriteLine("Invalid Password");
    }
}