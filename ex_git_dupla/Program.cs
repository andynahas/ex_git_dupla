using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_git_dupla
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for (x = 1; x <= 200; x++)
            {
                if (x % 10 == 0)
                {
                    Console.WriteLine(x + " MÚLTIPLO DE 10");
                }
                else
                {
                    Console.WriteLine(x);
                }

            }
            Console.ReadKey();
        }

    }
}
