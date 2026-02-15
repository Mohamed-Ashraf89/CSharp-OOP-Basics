using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1.IsGreaterThan(num2))
            {
                Console.WriteLine($"The {num1} is greater than {num2}");
            }

            else
            {
                Console.WriteLine($"The {num1} is lesser than {num2}");
            }
            Console.WriteLine("-----------------------------------------");

            Console.Write("Please enter the word you want to check: ");
            string statment = Console.ReadLine();


            if (statment.IsNumber())
            {
                Console.WriteLine($"The {statment} is number");
            }
            else
            {
                Console.WriteLine($"The {statment} is not number");
            }

            Console.WriteLine("-----------------------------------------");

            Console.Write("Please enter the sentence you want to count words: ");
            string sentence = Console.ReadLine();

            Console.WriteLine($"the number of words is {sentence.CountWords()} ");

        }
    }
}
static class Extentions
{
    public static bool IsGreaterThan(this int num1, int num2)
    {
        return num1 > num2;
    }

    public static bool IsNumber(this string statment)
    {
        return int.TryParse(statment, out int c);
    }

    public static int CountWords(this string sentence)
    {
        if (!string.IsNullOrEmpty(sentence))
        {
            string[] array = sentence.Split(' ');
            return array.Length;
        }
        else
        {
            return 0;
        }
    }
}
