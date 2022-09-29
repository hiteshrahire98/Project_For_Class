using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_For_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            // create object of Date class

            Date d1 = new Date(); // new allocate memory dynamically on the heap

            Console.WriteLine("Enter day month &  year");

            int d = Convert.ToInt32(Console.ReadLine());

            string m = Console.ReadLine();

            int y = Convert.ToInt32(Console.ReadLine());

            d1.AddValues(d, m, y);

            Console.WriteLine(d1.GetValues());

            Date d2 = new Date();

            d2.AddValues(10, "Jan", 2022);

            Console.WriteLine(d2.GetValues());
        }
    }
}
