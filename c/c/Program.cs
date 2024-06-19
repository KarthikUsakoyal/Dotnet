using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            double pcost = 3000;
            double dcost = 25;
            double discount = pcost * dcost / 100;
            double cop = pcost - discount;
            Console.WriteLine("product cost" + pcost);
            Console.WriteLine("Discount" + discount);
            Console.WriteLine("Costprice" + cop);
            Console.ReadLine();
        }
    }
}
