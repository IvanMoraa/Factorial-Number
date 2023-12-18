using System;

class Program
{
    static void Main()
    {
        try{
        Console.WriteLine("Write a Number:");
        int number = Convert.ToInt32(Console.ReadLine());

        long factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Factorial from {number} is: {factorial}");
        }catch(Exception ex)
        {
            System.Console.WriteLine($"Something went wrong: {ex}");
        }
    }
}