using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpaTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] times = new string[5];
            string[] pontos = new string[5];
            int i, a;
            
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o {0}° time: ", i + 1);
                times[i] = Console.ReadLine();
            }
            Console.WriteLine();
            for (i = 0; i< 5; i++)
            {
                Console.WriteLine("{0}° time:{1}", i + 1, times[i]);
            }
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o ponto do {0}° time: ", i + 1);
                times[i] = Console.ReadLine();
            }
            Console.WriteLine();
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("ponto do s" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
               {0}° time:{1}", i + 1, times[i]);
            }

            Console.ReadKey();
        }
    }
}
