using System;

namespace exp1q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Check if a number is odd or even");
                Console.WriteLine("2. Check if a number is prime");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CheckOddEven();
                        break;
                    case 2:
                        CheckPrime();
                        break;
                    case 3:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void CheckOddEven()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine($"{num} is even.");
            else
                Console.WriteLine($"{num} is odd.");
        }

        static void CheckPrime()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (IsPrime(num))
                Console.WriteLine($"{num} is prime.");
            else
                Console.WriteLine($"{num} is not prime.");
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0) return false;
            }

            return true;
        }
    }
}
