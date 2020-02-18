using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar valores hasta que sea cero, doWhile*/

            int n, c = -1;
            double suma = 0.0;
            do
            {
                Console.WriteLine("Ingrese valores (0 para terminar): ");
                n = int.Parse(Console.ReadLine());
                suma = suma + n;
                c++;
            } while (n != 0);
            double promedio = 0.0;
            promedio = (suma / c);
            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadKey();
        }
    }
}
