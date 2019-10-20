using System;

namespace ConsoleApp1
{
    class Program
    {
        public static bool Reverse(int a)

        {
            if (a % 5 == 0)
            {
                return true;
            }
            else
            {
                return !true;
            }
        }
        static void Main(string[] args)
        {
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Reverse(b));

        }
    }
}