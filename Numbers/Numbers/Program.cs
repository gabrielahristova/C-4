using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int diff= 0;
            for(int i = 100; i <= 2000; i++)
            {
                if (i % 35 == 0)
                {
                    diff -= i;
                }

            }
            Console.WriteLine(diff);
        }
    }
}
