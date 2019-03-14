using System;
using System.Globalization;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d2 = new DateTime(1977,02,05);
            DateTime d3 = new DateTime(1977,02,05,14,55,32);

            DateTime d1 = DateTime.Now;
            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;

            DateTime d6 = DateTime.Parse("1977-02-05");
            DateTime d7 = DateTime.Parse("1977-02-05 08:40:33");
            DateTime d8 = DateTime.Parse("1977/02/05");

            DateTime d9 = DateTime.ParseExact("2000-08-15","yyyy-MM-dd",CultureInfo.InvariantCulture);
            DateTime d10 = DateTime.ParseExact("05/02/1977 14:55:32","dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);

            TimeSpan t1 = new TimeSpan(5,8,33);
            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(2,5,33,28,200);
            TimeSpan t4 = TimeSpan.FromDays(1.5);
            TimeSpan t5 = TimeSpan.FromHours(2.5);


            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            Console.WriteLine("Dia: " + d7.Day);
            Console.WriteLine("Mês: " + d7.Month);
            Console.WriteLine("Ano: " + d7.Year);
            Console.WriteLine(d7.ToLongDateString());
            Console.WriteLine(d7.ToShortDateString());
            Console.WriteLine(d7.ToShortTimeString());
            Console.WriteLine(d7.AddDays(3));
            Console.WriteLine(d7.AddHours(5));
            Console.WriteLine(d7.AddMonths(3));
            Console.WriteLine(d7.AddYears(1));
            


        }
    }
}
