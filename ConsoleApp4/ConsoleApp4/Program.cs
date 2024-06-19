using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 30000;
            int leaves = 5;
            int august = 31;
            int workingdays = 26;
            double salaryperday = salary / august;
            double Sal = workingdays * salaryperday;
            Console.WriteLine("sal = " + Sal);
            Console.WriteLine("Sal perday = " + salaryperday);
            Console.ReadLine();
        }
    }
}
