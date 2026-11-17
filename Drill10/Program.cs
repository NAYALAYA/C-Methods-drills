using System;

class Program
{
    static string CountVowels(string word)
    {
        int count = 0;
        foreach (char c in word)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                count++;
            }
            return count;
        }
    static void Main()
        {
            string word = "I am a puppy!!";
            Console.WriteLine($"There are {count} vowels in this string!");
        }
    }
}