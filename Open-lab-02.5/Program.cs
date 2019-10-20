using System;

namespace ConsoleApp1
{
    class Program
    {
        public static bool Reverse(int a)

        {
           return (a % 5 == 0);
            
        }
        static void Main(string[] args)
        {
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Reverse(b));

        }
    }
}
