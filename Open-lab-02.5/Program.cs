using System;

namespace Open_lab_02.5
{
    class Program
    {
        public static bool DivisibleByFive(int a)

        {
            return (a % 5 == 0);

        }
        static void Main(string[] args)
        {
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DivisibleByFive(b));

        }
    }
}
