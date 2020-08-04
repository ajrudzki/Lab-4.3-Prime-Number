using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Lab_4._3_Prime_Numbers
{
    public class PrimeNumbers
    {
        public static bool isPrime(int userInput)
        {
            int count = 0;

            for (int i = 2; i < userInput; i++)
            {
                if (userInput % i == 0) // % (modulo) reads like "is evenly divisable by"
                {
                    count = 1;
                    break;
                }
            }
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int GetPrime(int entry)
        {
            int number = 1;
            int count = 0;
            while (true)
            {
                number++;
                if (PrimeNumbers.isPrime(number))
                {
                    count++;
                }
                if (count == entry)
                {
                    return number;
                }
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Let's locate some primes!\n");
            Console.WriteLine($"This application will find you any prime, in order, from first prime number on.");

            bool running = true;
            while (running)
            {
                Console.WriteLine();
                Console.Write($"Which prime number are you looking for?: ");
                int entry = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine($"The number {entry} prime number is {PrimeNumbers.GetPrime(entry)}.");

                Console.WriteLine();
                Console.Write($"Do you want to find another prime number? (Y/N): ");
                string cont = Console.ReadLine().ToLower();
                if (cont == "yes" || cont == "y")
                {
                    running = true;
                    {

                    }
                }
                else if (cont == "no" || cont == "n")
                {
                    running = false;
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Goodbye!");
                        break;
                    }

                }
            }
        }
    }
}

