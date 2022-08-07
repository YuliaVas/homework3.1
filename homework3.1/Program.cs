using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 5;
            int B = 10;

            A = A + B;
            B = A - B;
            A = A - B;

            Console.WriteLine("A=" + A);
            Console.WriteLine("B=" + B);
            Console.ReadKey();
        }
    }
}
