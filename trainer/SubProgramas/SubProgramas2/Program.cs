using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubProgramas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresar N");
            int n = int.Parse(Console.ReadLine());

            VisualizarTriangulo(n);

            Console.ReadKey();
        }

        private static void VisualizarTriangulo(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                VisualizarFila(n, i);
            }
        }

        private static void VisualizarFila(int n, int i)
        {
            VisulizarCaracteres(' ', n - i);
            VisulizarCaracteres('*', i * 2 - 1);
            Console.WriteLine();
        }

        private static void VisulizarCaracteres(char caracter, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write(caracter);
            }
        }
    }
}
