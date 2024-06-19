using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int sum = 0;
            while(n>=0)
            {
                int  r= n % 10;
                n = n / 10;
                sum = sum + r;

            }
            Console.WriteLine("Sum is " + sum);
            Console.ReadLine();
        }
    }
}
