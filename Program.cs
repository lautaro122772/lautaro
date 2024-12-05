using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_leguizamon
{
    public class TablasMultiplicarInfinitas
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i <= y; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0}x{1}= {2}", i, j, i * j);
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}

/*
 * Cree un programa en C# que solicite un rango de números al usuario (x,y) y muestre las tablas de multiplicar de x hasta y.
 * */
