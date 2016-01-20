using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give distance: ");
            string line = Console.ReadLine();
            double distance = double.Parse(line);
            double gas = (distance / 100 * 7.02);
            double money = (gas * 1.595);
            Console.WriteLine("Gas needed: {0}l, money needed: {1}e", gas, money);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
