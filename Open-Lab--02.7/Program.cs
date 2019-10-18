using System;

namespace Open_Lab__02._7
{
    class Program
    {
        public static bool IsTimeForMilkAndCookies(int year, int month, int day)
           {
            return day == 24 && month == 12;
           }

        static void Main(string[] args)
        {
            int day;
            int month;
            int year;

            Console.WriteLine("Type day:");
            day = int.Parse(Console.ReadLine());

            Console.WriteLine("Type month:");
            month = int.Parse(Console.ReadLine());

            Console.WriteLine("Type year:");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine(day, month, year); 
        }
    }
}
