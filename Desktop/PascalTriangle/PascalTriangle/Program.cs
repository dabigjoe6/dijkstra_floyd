using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pascal Triangle Program");
            Console.WriteLine("Enter the number of rows");

            int n = Convert.ToInt32(Console.ReadLine());

            for (int y = 0; y < n; y++)
            {
                int c = 1;

                for (int q = 0; q < n - y; q++)
                {
                    Console.Write(" ");
                }

                for (int x = 0; x <= y; x++)
                {
                    Console.Write(" {0:D}",c);
                    c = c * (y - x) / (x + 1);
                }

                Console.WriteLine("");
                Console.WriteLine("");
            }

            Console.WriteLine("");
        }
    }
}
