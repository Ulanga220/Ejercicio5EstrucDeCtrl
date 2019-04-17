using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5EstrucDeCtrl
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string ingreso;
             bool ok = false;

              while (!ok)

              { Console.WriteLine("Ingrese un numero mayor a 0");
                  ingreso = Console.ReadLine();
                  ok = int.TryParse(ingreso, out int entero);

                  for (int n = 0; n <= entero; n++)

                  { Console.WriteLine(n); }   };

             Console.ReadKey(); 

             string ingreso;
             bool ok = false;

             while (!ok)

             {
                 Console.WriteLine("Ingrese un numero mayor a 0");
                 ingreso = Console.ReadLine();
                 ok = int.TryParse(ingreso, out int entero);

                 Console.WriteLine($"Ingrese un número entre 0 y {entero}");
                 ingreso = Console.ReadLine();

                 ok = int.TryParse(ingreso, out int m);

                 if (m < entero && m > 0)

                 for (int n = 0; n <= entero; n= n+m)

                 { Console.WriteLine(n); } 
             }; 

             Console.ReadKey(); 
              string ingreso;
             bool ok = false;

             do
             {
                 Console.WriteLine("Ingrese un numero mayor a 0");
                 ingreso = Console.ReadLine();
                 ok = int.TryParse(ingreso, out int entero);

                 Console.WriteLine($"Ingrese un número entre 0 y {entero}");
                 ingreso = Console.ReadLine();

                 ok = int.TryParse(ingreso, out int m);

                 if (m < entero && m > 0)

                     for (int n = 0; n <= entero; n = n + m)

                     { Console.WriteLine(n); }
             }
             while (!ok);

             Console.ReadKey();  */

             decimal[] numero = new decimal[20];
            decimal suma;
            decimal promedio;

            for (var i = 0; i < 20; i++)
             {

                 decimal valor;
                 string ingreso;

                 bool ok = false;

                while (!ok)

                {
                    Console.WriteLine("Ingrese un número (Ingreso máximo: 20)");

                    ingreso = Console.ReadLine();
                    ok = decimal.TryParse(ingreso, out valor);

                    numero[i] = valor;


                    suma = 0;

                    suma = suma + numero[i];
                    promedio = suma / 20;

                    {Console.WriteLine("Promedio de numeros ingresados:" +promedio); };

                }
            }
            Console.ReadKey(); 

            
            








        }

    }
    }

