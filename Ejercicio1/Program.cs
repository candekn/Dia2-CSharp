using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Determinar si una persona obtiene un credito o no.
             Para obtenerlo: 
                Casado, mayor de edad, salario mayor a 10000.
                Informar cantidad de personas que obtuvieron el credito y quienes no
                Se deja de ingresar datos cuando el dni es 0*/
            int dni, edad, salario, credito = 0, nocredito = 0, total = 0;
            string civil;
            Console.WriteLine("Ingrese dni: ");
            dni = int.Parse(Console.ReadLine());
            while (dni != 0)
            {
                Console.WriteLine("Ingrese estado civil (casado, soltero, viudo): ");
                civil = Console.ReadLine();
                Console.WriteLine("Ingrese edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese salario: ");
                salario = int.Parse(Console.ReadLine());
                
                if (civil.Trim().ToLower().Equals("casado") && edad >= 18 && salario >= 10000)
                {
                    credito++;
                }
                else
                {
                    nocredito++;
                }
                total++;
                Console.WriteLine("Ingrese dni: ");
                dni = int.Parse(Console.ReadLine());
            }
            double porcentajecred = (credito * 100) / total;
            double porcentajenocred = (nocredito * 100) / total;
            Console.WriteLine("El total de personas encuestadas es de: " + total);
            Console.WriteLine("La cantidad de personas que obtuvieron el credito es de: " + credito);
            Console.WriteLine("El porcentaje es de: " + porcentajecred +"%");
            Console.WriteLine("La cantidad de personas que no lo obtuvieron es de: " + nocredito);
            Console.WriteLine("El porcentaje es de: " + porcentajenocred +"%");
            Console.ReadKey();
        }
    }
}
