using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please state your name.");

            string name = Console.ReadLine();
           
            Console.WriteLine("Welcome {0} to D520 Programming 1.", name);

            Thread.Sleep(2000);

            //holding console screen 
            Console.WriteLine("press enter to exit console application");
            Console.ReadLine();
        }
    }
}
