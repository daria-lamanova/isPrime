using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number < 1) return false;
        if (number == 2 || number == 1) return true;

        int sqrt = (int)Math.Sqrt(number);
        for (int i = 2; i <= sqrt; i++)
        {
            if (number % i == 0) return false;
        }

        return true;
    }

    static void Main()
    {
        //Console.WriteLine("Please enter the number of numbers: ");

        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        //Console.WriteLine($"Please enter {n} numbers: ");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if (IsPrime(numbers[i]))
                Console.WriteLine("TAK");
            else
                Console.WriteLine("NIE");
        }
        Console.ReadKey();
    }
}
