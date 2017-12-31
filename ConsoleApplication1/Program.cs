using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysLeft;
            Console.WriteLine("How many days remain?: ");
            daysLeft = Convert.ToInt32(Console.ReadLine());
            DateTime endDate = DateTime.Now.AddDays(daysLeft);
            Console.WriteLine($"Your challenge will end on {endDate}");
            Thread.Sleep(10000);
        }
    }
}
