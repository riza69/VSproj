using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Weather : Program
    {
        protected int z;

        public Weather() { }
        public Weather(int z, string city) : this(z)
        {
            if (this.z != 7)
            {
                this.z = 7;
                getWeather(7, city);
            }
        }

        public Weather(int z)
        {
            this.z = z;
        }

        public void getWeather(string city)
        {
            Console.WriteLine("Weather for {0}", city);
            Random rnd = new Random();
            int q = rnd.Next(-10, 40);
            if (q <= 0)
            {
                Console.WriteLine("Today's temperature is: {0}. {1}", q, "Frosty");
            }
            else if (q > 0 &&  q <= 10)
            {
                Console.WriteLine("Today's temperature is: {0}. {1}", q, "Cool");
            }
            else if (q > 10 && q <= 20)
            {
                Console.WriteLine("Today's temperature is: {0}.{1}", q, "warm");
            }
            else if (q > 21)
            {
                Console.WriteLine("Today's temperature is: {0}.{1}", q, "hot");
            }
            Console.ReadKey();
        }

        public void getTomorrow(string city)
        {
            Console.WriteLine("Weather for {0}", city);
            Random rnd = new Random();
            int q = rnd.Next(-10, 40);
            if (q <= 0)
            {
                Console.WriteLine("Tomorrow's temperature is: {0}. {1}", q, "Frosty");
            }
            else if (q > 0 && q <= 10)
            {
                Console.WriteLine("Tomorrow's temperature is: {0}. {1}", q, "Cool");
            }
            else if (q > 10 && q <= 20)
            {
                Console.WriteLine("Tomorrow's temperature is: {0}.{1}", q, "warm");
            }
            else if (q > 21)
            {
                Console.WriteLine("Tomorrow's temperature is: {0}.{1}", q, "hot");
            }
            Console.ReadKey();
        }

        public void getWeather(int n, string city)
        {
            Console.WriteLine("Weather for {0}", city);
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int q = rnd.Next(-10, 40);
                if (q <= 0)
                {
                    Console.WriteLine("Day #{0} temperature is: {1}. {2}", i, q, "Frosty");
                }
                else if (q > 0 && q <= 10)
                {
                    Console.WriteLine("Day #{0} temperature is: {1}. {2}", i, q, "Cool");
                }
                else if (q > 10 && q <= 20)
                {
                    Console.WriteLine("Day #{0} temperature is: {1}.{2}", i, q, "warm");
                }
                else if (q > 21)
                {
                    Console.WriteLine("Day #{0} temperature is: {1}.{2}", i,  q, "hot");
                }
                Console.ReadKey();
            }
        }
    }
    }

