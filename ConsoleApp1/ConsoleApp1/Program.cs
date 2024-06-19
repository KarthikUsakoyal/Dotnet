using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
     

        static void Main(string[] args)
        {
            Console.Write("Enter Your Password");
            string s1 = Console.ReadLine();
            if(s1.Length>=8)
            {
                int uc = 0, lc = 0, dc = 0, sc = 0;
                for(int i =0;i<s1.Length;i++)
                {
                 if(s1[i]>='A' && s1[i]<='Z')
                  { uc++; }
                 else if(s1[i]>='a' && s1[i]<='z')
                  { lc++; }
                 else if (s1[i]>='0' && s1[i]<='9' )
                  { dc++; }
                 else
                  { sc++; }
                }
                if(uc==0 || lc=0|| dc==0 || sc==0)
                { Console.WriteLine("Invalid Password"); }
                else
                { 
                    Console.WriteLine("Valid Password");
                    Console.ReadLine();
                }

            }

            
        

        }
    }
}
