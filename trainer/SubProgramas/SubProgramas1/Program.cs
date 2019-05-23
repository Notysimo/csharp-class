using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubProgramas1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresar 4 numeros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int mayorAyB = EncontrarMayor(a, b);
            int mayorCyD = EncontrarMayor(c, d);

            int mayorAbsoluto = EncontrarMayor(mayorAyB, mayorCyD);

            Console.WriteLine("El mayor es " + mayorAbsoluto);

            Console.ReadKey();
        }

        private static int EncontrarMayor(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }
    }
}
