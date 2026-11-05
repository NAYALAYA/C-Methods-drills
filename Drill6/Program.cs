using System;

class Project
{
    static void Main()
    {
       int total = CalcSum([20, 40, 400]);
       Console.WriteLine($"The total is {total}");
    }

    static int CalcSum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            //Console.WriteLine(numbers[i]);
            sum += numbers[i];
            //Console.WriteLine(sum);
        }
        return sum;
    }
}