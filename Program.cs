using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileAndDoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is for while loop
            int i = 0;
            while (i <= 20)
            {
                i++;
                if (i % 5 == 0)
                {
                    continue; // using continue we want to print which is not divisable by 5.
                }
                Console.WriteLine(i);
            }

            // this id for while loop
            int i = 0;
            while (true)
            {
                Console.WriteLine("hello");
                if (i >= 4)
                {
                    break; //using break
                }
                i++;
            }
            // this is for do while loop

            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);

            Console.ReadKey();
        }
    }
}
