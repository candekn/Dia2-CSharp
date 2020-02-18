using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sucursal 1 2 3, cant asientos, turno m t n, precio de entradas 
             * (mañana 350, tarde 450, noche 550)
             Se desea saber:
             1.Cantidad de asientos vendidos por sucursal
             2.Montos recaudados por cada turno
             3.Cual fue la sucursal que mas asientos vendio y la cifra
             4.Porcentajes de asientos vendidos por sucursal*/
            //sucursal -> asignacion
            //sucursalNUMEROYTIPO
            int sucursal,
                montoM = 0, //total recaudado
                montoT = 0, //total recaudado
                montoN = 0; //total recaudado
            int asientosVendidos,
                asiento1 = 0, //cantidad de asientos vendidos
                asiento2 = 0,//cantidad de asientos vendidos
                asiento3 = 0; //cantidad de asientos vendidos
            char turno;
            const int M = 350;
            const int T = 450;
            const int N = 550;
            string flag="";
            do
            {
            etiSuc:
                Console.WriteLine("Ingrese numero de sucursal: ");
                sucursal = int.Parse(Console.ReadLine());
            etiTurno:
                Console.WriteLine("Ingrese turno: (M,T,N): ");
                turno = char.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese cantidad de asientos vendidos: ");
                asientosVendidos = int.Parse(Console.ReadLine());

                switch (char.ToUpper(turno))
                {
                    case 'M':
                        montoM = montoM + (asientosVendidos * M);
                        break;
                    case 'T':
                        montoT = montoT + (asientosVendidos * T);
                        break;
                    case 'N':
                        montoN = montoN + (asientosVendidos * N);
                        break;
                    default:
                        Console.WriteLine("Turno incorrecto. Ingrese nuevamente.");
                        goto etiTurno;
                }
                switch (sucursal)
                {
                    case 1:
                        asiento1 = asiento1 + asientosVendidos;
                        break;
                    case 2:
                        asiento2 = asiento2 + asientosVendidos;
                        break;
                    case 3:
                        asiento3 = asiento3 + asientosVendidos;
                        break;
                    default: Console.WriteLine("Numero de sucursal incorrecta.");
                        goto etiSuc;
                }
                Console.WriteLine("Para terminar marque 0, presione cualquier letra: ");
                flag = Console.ReadLine();
            } while (flag != "0");
            //Cantidad de asientos vendidos por sucursal
            Console.WriteLine("\nAsientos vendidos de sucursal: ");
            Console.WriteLine("1: " + asiento1);
            Console.WriteLine("2: " + asiento2);
            Console.WriteLine("3: " + asiento3);
            //Montos recaudados por turnos:
            Console.WriteLine("\nMonto recaudados por turno: ");
            Console.WriteLine("Manaña: $" + montoM);
            Console.WriteLine("Tarde: $" + montoT);
            Console.WriteLine("Noche: $" + montoN +"\n");
            //Sucursal mas asientos vendio y cuantos
            if (!(asiento1 == asiento2 && asiento2 == asiento3))
            {
                if (asiento1 > asiento2)
                {
                    if (asiento1 > asiento3)
                    {
                        Console.WriteLine("La sucursal que mas vendio es la numero 1");
                    }
                    else
                    {
                        Console.WriteLine("La sucursal que mas vendio es la numero 3");
                    }
                }
                else if(asiento2>asiento3)
                {
                    Console.WriteLine("La sucursal que mas vendio es la numero 2");
                }
                else
                {
                    Console.WriteLine("La sucursal que mas vendio es la numero 3");
                }
            }
            else
            {
                Console.WriteLine("La cantidad de asientos vendidos por las sucursales es igual.");
            };
            //Asientos vendidos por sucursal
            double asientosTotales = asiento1 + asiento2 + asiento3;
            Console.WriteLine("\nPorcentajes de asientos vendidos: ");
            Console.WriteLine("Sucursal 1: %" + ((asiento1 * 100) / asientosTotales));
            Console.WriteLine("Sucursal 2: %" + ((asiento2 * 100) / asientosTotales));
            Console.WriteLine("Sucursal 3: %" + ((asiento3 * 100) / asientosTotales));


            Console.ReadKey();
        }
    }
}
