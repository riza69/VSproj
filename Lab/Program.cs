using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        protected static int q;
        protected static int n;
        protected static string city;
        static void Main(string[] args)
        {
            Weather w = new Weather();
            
            Console.WriteLine("\n\n\t\tWelcome!!\n\n\t\t");
            Console.WriteLine("\t\tYou want to see weather for today? Tomorrow? or this week?");
            Console.WriteLine("\t\tInput 1 for today, 2 for tomorrow, 3 for this week");
            Console.WriteLine("\t\tBefore inputting number, enter your city");
            city = Console.ReadLine();
            int s = Convert.ToInt16(Console.ReadLine());
            switch (s)
            {
                case 1:
                    w.getWeather(city);
                    break;
                case 2:
                    w.getTomorrow(city);
                    break;
                case 3:
                    n = Convert.ToInt16(Console.ReadLine());
                    Weather o = new Weather(n,city);
                    break;                
            }

        }
    }
}
