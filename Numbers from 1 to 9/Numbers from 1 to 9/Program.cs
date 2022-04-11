using System;

namespace Numbers_from_1_to_9
{
    class Program
    {
        static void Main(string[] args)
        {
                int num = int.Parse(Console.ReadLine());
                if (num >= 1 && num <= 5)
                {
                    num *= 100;
                    Console.WriteLine(num);
                }
                else if (num > 5 && num <= 9)
                {
                    num *= 1000;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("invalid number");
                }
            }
        }
    }
