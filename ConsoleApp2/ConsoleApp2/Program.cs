using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Karthik");
            Console.ReadLine();
            */
/*
String s2 = "We are DotNET Students";
String[] ch = s2.Split();
for(int j = 0; j< ch.Length; j++)
{
    String s1 = ch[j];
    for(int i = s1.Length-1; i>=0; i--)
    {
        Console.Write(s1[i]);
    }
}
 Console.ReadKey();

*/
string[] email = { "ven@ibm.com", "vishnu@wipro.com", "avinash@tcs.com" };
Console.WriteLine("enter employee: ");
string s1 = Console.ReadLine();
for(int i=0;i<email.Length;i++)
{
    string[] s3 = email[i].Split('@','.');
    for(int j=0;j<s3.Length;j++)
    {
        if(s1==s3[j])
        {
            Console.WriteLine(s3[0] + " ");
        }
    }
}


}



}
}
