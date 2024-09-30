using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number to get square of it");
            int n =int.Parse(Console.ReadLine());
            int i;
            bool found=false;
            for( i=1;i<=n;i++)
            {
                if(i*i==n)
                {
                    Console.WriteLine("the number is" + i);
                    found = true;
                    break;
                }
            
            }
           if(!found)
            {
                Console.WriteLine("it is not");
            }
            Console.ReadKey();
        }
        
    }
}
