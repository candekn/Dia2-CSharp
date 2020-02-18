using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Atletismo. n atletas segun edad: 
             12-18 cadetes, 19-30 juveniles, 30<x veteranos.
             de cada atleta se conoce apellido, edad y tiempo.
             Informar:
             1.Promedio de tiempos por categoria.
             2.Cantidad de participantes por categoria
             3.Promedio de competencia
             4.Porcentaje de partcipantes por categoria
             5.Maximo y minimo tiempo*/
            int vet = 0, juv = 0, cad = 0;
            double promvet = 0.0, promjuv = 0.0, promcad = 0.0, promtotal = 0.0,
                mejort=0.0, peort=0.0;
            string mejoratleta="", peoratleta="";
            Console.WriteLine("Ingrese cantidad de atletas: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese apellido: ");
                string apellido = Console.ReadLine();
            eti1:
                Console.WriteLine("Ingrese edad: ");
                int edad = int.Parse(Console.ReadLine());
                if (edad < 12 || edad > 100)
                {
                    Console.WriteLine("Edad incorrecta. Ingrese una edad valida");
                    goto eti1;
                };

                Console.WriteLine("Ingrese tiempo: ");
                double tiempo = double.Parse(Console.ReadLine());
           
                if (edad >= 30)
                {
                    vet++;
                    promvet = promvet + tiempo;
                }else if (edad >= 19)
                {
                    juv++;
                    promjuv = promjuv + tiempo;
                }else if (edad >= 12)
                {
                    cad++;
                    promcad = promcad + tiempo;
                };
                
                if (i == 0)
                {
                    mejort = tiempo;
                    peort = tiempo;
                    peoratleta = apellido;
                    mejoratleta = apellido;
                }
                else if(tiempo<mejort)
                {
                    mejort = tiempo;
                    mejoratleta = apellido;
                }else if (tiempo > peort)
                {
                    peort = tiempo;
                    peoratleta = apellido;
                }
                promtotal = promtotal + tiempo;
                Console.WriteLine("-");
            }
            Console.WriteLine("1 y 2.El promedio de tiempo y cantidad de participantes por categoria es de: ");
            promcad = promcad / cad;
            promjuv = promjuv / juv;
            promvet = promvet / vet;
            Console.WriteLine("-Promedio Cadetes: " + promcad +". Cantidad: " +cad);
            Console.WriteLine("-Promedio Juveniles: " + promjuv +". Cantidad: "+juv);
            Console.WriteLine("-Promedio Veteranos: " + promvet +". Cantidad: "+vet);
            promtotal = promtotal / n;
            Console.WriteLine("3. Promedio total de la competencia: " + promtotal);
            Console.WriteLine("4. Procentaje de participantes por categoria: ");
            Console.WriteLine("Cadetes: " + ((cad * 100) /n) + "%");
            Console.WriteLine("Juveniles: " + ((juv * 100) / n) + "%");
            Console.WriteLine("Veteranos: " + ((vet * 100) / n) + "%");
            Console.WriteLine("El maximo(peor) tiempo pertenece a: " + peoratleta + " con " + peort);
            Console.WriteLine("El minimo(mejor) tiempo pertenece a: " + mejoratleta + " con " + mejort);
            Console.ReadKey();
        }
    }
}
