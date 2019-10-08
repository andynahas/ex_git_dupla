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
                if (x % 20 == 1)
                {
                    Console.WriteLine(x + "Contagem do 52 até 200");
                }
                else
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine("Terceiro git Aluno B");

            }
            Console.ReadKey();
        }

    }
}
